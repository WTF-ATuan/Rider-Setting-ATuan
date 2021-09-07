// Decompiled with JetBrains decompiler
// Type: System.Net.Sockets.Socket
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: EF151B6A-BB5D-474C-B2C1-CB8906A8B5A4
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\MonoBleedingEdge\lib\mono\unityjit\System.dll

using Mono;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
  /// <summary>實作 Berkeley 通訊端介面。</summary>
  public class Socket : IDisposable
  {
    private static object s_InternalSyncObject;
    internal static volatile bool s_SupportsIPv4;
    internal static volatile bool s_SupportsIPv6;
    internal static volatile bool s_OSSupportsIPv6;
    internal static volatile bool s_Initialized;
    private static volatile bool s_LoggingEnabled;
    internal static volatile bool s_PerfCountersEnabled;
    internal const int DefaultCloseTimeout = -1;
    private const int SOCKET_CLOSED_CODE = 10004;
    private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
    private bool is_closed;
    private bool is_listening;
    private bool useOverlappedIO;
    private int linger_timeout;
    private AddressFamily addressFamily;
    private SocketType socketType;
    private ProtocolType protocolType;
    internal SafeSocketHandle m_Handle;
    internal EndPoint seed_endpoint;
    internal SemaphoreSlim ReadSem = new SemaphoreSlim(1, 1);
    internal SemaphoreSlim WriteSem = new SemaphoreSlim(1, 1);
    internal bool is_blocking = true;
    internal bool is_bound;
    internal bool is_connected;
    private int m_IntCleanedUp;
    internal bool connect_in_progress;
    private static AsyncCallback AcceptAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.AcceptSocket = asyncState.current_socket.EndAccept(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        if (asyncState.AcceptSocket == null)
          asyncState.AcceptSocket = new Socket(asyncState.current_socket.AddressFamily, asyncState.current_socket.SocketType, asyncState.current_socket.ProtocolType, (SafeSocketHandle) null);
        asyncState.Complete();
      }
    });
    private static IOAsyncCallback BeginAcceptCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      Socket socket;
      try
      {
        if (socketAsyncResult.AcceptSocket == null)
        {
          socket = socketAsyncResult.socket.Accept();
        }
        else
        {
          socket = socketAsyncResult.AcceptSocket;
          socketAsyncResult.socket.Accept(socket);
        }
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete(socket);
    });
    private static IOAsyncCallback BeginAcceptReceiveCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      Socket socket;
      try
      {
        if (socketAsyncResult.AcceptSocket == null)
        {
          socket = socketAsyncResult.socket.Accept();
        }
        else
        {
          socket = socketAsyncResult.AcceptSocket;
          socketAsyncResult.socket.Accept(socket);
        }
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      int total = 0;
      if (socketAsyncResult.Size > 0)
      {
        try
        {
          SocketError errorCode;
          total = socket.Receive(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, out errorCode);
          if (errorCode != SocketError.Success)
          {
            socketAsyncResult.Complete((Exception) new SocketException((int) errorCode));
            return;
          }
        }
        catch (Exception ex)
        {
          socketAsyncResult.Complete(ex);
          return;
        }
      }
      socketAsyncResult.Complete(socket, total);
    });
    private static AsyncCallback ConnectAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.current_socket.EndConnect(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });
    private static IOAsyncCallback BeginConnectCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult sockares = (SocketAsyncResult) ares;
      if (sockares.EndPoint == null)
      {
        sockares.Complete((Exception) new SocketException(10049));
      }
      else
      {
        try
        {
          int socketOption = (int) sockares.socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error);
          if (socketOption == 0)
          {
            sockares.socket.seed_endpoint = sockares.EndPoint;
            sockares.socket.is_connected = true;
            sockares.socket.is_bound = true;
            sockares.socket.connect_in_progress = false;
            sockares.error = 0;
            sockares.Complete();
          }
          else if (sockares.Addresses == null)
          {
            sockares.socket.connect_in_progress = false;
            sockares.Complete((Exception) new SocketException(socketOption));
          }
          else if (sockares.CurrentAddress >= sockares.Addresses.Length)
            sockares.Complete((Exception) new SocketException(socketOption));
          else
            Socket.BeginMConnect(sockares);
        }
        catch (Exception ex)
        {
          sockares.socket.connect_in_progress = false;
          sockares.Complete(ex);
        }
      }
    });
    private static AsyncCallback DisconnectAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.current_socket.EndDisconnect(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });
    private static IOAsyncCallback BeginDisconnectCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      try
      {
        socketAsyncResult.socket.Disconnect(socketAsyncResult.ReuseSocket);
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete();
    });
    private static AsyncCallback ReceiveAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.BytesTransferred = asyncState.current_socket.EndReceive(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });
    private static unsafe IOAsyncCallback BeginReceiveCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      int total = 0;
      try
      {
        fixed (byte* numPtr = socketAsyncResult.Buffer)
          total = Socket.Receive_internal(socketAsyncResult.socket.m_Handle, numPtr + socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, out socketAsyncResult.error, socketAsyncResult.socket.is_blocking);
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete(total);
    });
    private static IOAsyncCallback BeginReceiveGenericCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      int total;
      try
      {
        total = socketAsyncResult.socket.Receive(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete(total);
    });
    private static AsyncCallback ReceiveFromAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.BytesTransferred = asyncState.current_socket.EndReceiveFrom(ares, ref asyncState.remote_ep);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });
    private static IOAsyncCallback BeginReceiveFromCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      int from;
      try
      {
        SocketError errorCode;
        from = socketAsyncResult.socket.ReceiveFrom(socketAsyncResult.Buffer, socketAsyncResult.Offset, socketAsyncResult.Size, socketAsyncResult.SockFlags, ref socketAsyncResult.EndPoint, out errorCode);
        if (errorCode != SocketError.Success)
        {
          socketAsyncResult.Complete((Exception) new SocketException(errorCode));
          return;
        }
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete(from);
    });
    private static AsyncCallback SendAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.BytesTransferred = asyncState.current_socket.EndSend(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });
    private static IOAsyncCallback BeginSendGenericCallback = (IOAsyncCallback) (ares =>
    {
      SocketAsyncResult socketAsyncResult = (SocketAsyncResult) ares;
      int total;
      try
      {
        total = socketAsyncResult.socket.Send(socketAsyncResult.Buffers, socketAsyncResult.SockFlags);
      }
      catch (Exception ex)
      {
        socketAsyncResult.Complete(ex);
        return;
      }
      socketAsyncResult.Complete(total);
    });
    private static AsyncCallback SendToAsyncCallback = (AsyncCallback) (ares =>
    {
      SocketAsyncEventArgs asyncState = (SocketAsyncEventArgs) ((IOAsyncResult) ares).AsyncState;
      if (Interlocked.Exchange(ref asyncState.in_progress, 0) != 1)
        throw new InvalidOperationException("No operation in progress");
      try
      {
        asyncState.BytesTransferred = asyncState.current_socket.EndSendTo(ares);
      }
      catch (SocketException ex)
      {
        asyncState.SocketError = ex.SocketErrorCode;
      }
      catch (ObjectDisposedException ex)
      {
        asyncState.SocketError = SocketError.OperationAborted;
      }
      finally
      {
        asyncState.Complete();
      }
    });

    /// <summary>
    ///   初始化的新執行個體 <see cref="T:System.Net.Sockets.Socket" /> 類別使用指定的通訊端類型和通訊協定。
    /// </summary>
    /// <param name="socketType">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketType" /> 值。
    /// </param>
    /// <param name="protocolType">
    ///   其中一個 <see cref="T:System.Net.Sockets.ProtocolType" /> 值。
    /// </param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   結合  <paramref name="socketType" /> 和 <paramref name="protocolType" /> 導致無效的通訊端。
    /// </exception>
    public Socket(SocketType socketType, ProtocolType protocolType)
      : this(AddressFamily.InterNetworkV6, socketType, protocolType)
      => this.DualMode = true;

    /// <summary>
    ///   初始化的新執行個體 <see cref="T:System.Net.Sockets.Socket" /> 類別使用指定的通訊協定家族、 通訊端類型和通訊協定。
    /// </summary>
    /// <param name="addressFamily">
    ///   其中一個 <see cref="T:System.Net.Sockets.AddressFamily" /> 值。
    /// </param>
    /// <param name="socketType">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketType" /> 值。
    /// </param>
    /// <param name="protocolType">
    ///   其中一個 <see cref="T:System.Net.Sockets.ProtocolType" /> 值。
    /// </param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   結合 <paramref name="addressFamily" />, ，<paramref name="socketType" />, ，和 <paramref name="protocolType" /> 導致無效的通訊端。
    /// </exception>
    public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
    {
      Socket.s_LoggingEnabled = Logging.On;
      int num1 = Socket.s_LoggingEnabled ? 1 : 0;
      Socket.InitializeSockets();
      this.m_Handle = new SafeSocketHandle(this.Socket_internal(addressFamily, socketType, protocolType, out int _), true);
      if (this.m_Handle.IsInvalid)
        throw new SocketException();
      this.addressFamily = addressFamily;
      this.socketType = socketType;
      this.protocolType = protocolType;
      IPProtectionLevel ipProtectionLevel = SettingsSectionInternal.Section.IPProtectionLevel;
      if (ipProtectionLevel != IPProtectionLevel.Unspecified)
        this.SetIPProtectionLevel(ipProtectionLevel);
      this.SocketDefaults();
      int num2 = Socket.s_LoggingEnabled ? 1 : 0;
    }

    /// <summary>取得值，指出 IPv4 支援可用且在目前的主機上啟用。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果目前的主機支援 IPv4 通訊協定。否則， <see langword="false" />。
    /// </returns>
    [Obsolete("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    public static bool SupportsIPv4
    {
      get
      {
        Socket.InitializeSockets();
        return Socket.s_SupportsIPv4;
      }
    }

    /// <summary>表示基礎作業系統和網路介面卡是否支援網際網路通訊協定第 4 版 (IPv4)。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果作業系統和網路介面卡支援 IPv4 通訊協定。，否則， <see langword="false" />。
    /// </returns>
    public static bool OSSupportsIPv4
    {
      get
      {
        Socket.InitializeSockets();
        return Socket.s_SupportsIPv4;
      }
    }

    /// <summary>
    ///   取得值，指出架構是否支援 IPv6 某些過時 <see cref="T:System.Net.Dns" /> 成員。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果架構支援 IPv6 某些過時 <see cref="T:System.Net.Dns" /> 方法，否則 <see langword="false" />。
    /// </returns>
    [Obsolete("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    public static bool SupportsIPv6
    {
      get
      {
        Socket.InitializeSockets();
        return Socket.s_SupportsIPv6;
      }
    }

    internal static bool LegacySupportsIPv6
    {
      get
      {
        Socket.InitializeSockets();
        return Socket.s_SupportsIPv6;
      }
    }

    /// <summary>表示基礎作業系統和網路介面卡是否支援網際網路通訊協定第 6 版 (IPv6)。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果作業系統和網路介面卡支援 IPv6 通訊協定。，否則， <see langword="false" />。
    /// </returns>
    public static bool OSSupportsIPv6
    {
      get
      {
        Socket.InitializeSockets();
        return Socket.s_OSSupportsIPv6;
      }
    }

    /// <summary>
    ///   取得作業系統控制代碼的 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.IntPtr" /> 表示作業系統控制代碼的 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    public IntPtr Handle => this.m_Handle.DangerousGetHandle();

    /// <summary>指定通訊端是否應該只使用重疊的 I/O 模式。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 只使用重疊的 I/O，否則 <see langword="false" />。
    ///    預設為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端已經繫結至完成通訊埠。
    /// </exception>
    public bool UseOnlyOverlappedIO
    {
      get => this.useOverlappedIO;
      set => this.useOverlappedIO = value;
    }

    /// <summary>
    ///   取得通訊協定家族的 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>
    ///   其中一個 <see cref="T:System.Net.Sockets.AddressFamily" /> 值。
    /// </returns>
    public AddressFamily AddressFamily => this.addressFamily;

    /// <summary>
    ///   取得 <see cref="T:System.Net.Sockets.Socket" /> 的類型。
    /// </summary>
    /// <returns>
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketType" /> 值。
    /// </returns>
    public SocketType SocketType => this.socketType;

    /// <summary>
    ///   取得通訊協定類型 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>
    ///   其中一個 <see cref="T:System.Net.Sockets.ProtocolType" /> 值。
    /// </returns>
    public ProtocolType ProtocolType => this.protocolType;

    /// <summary>
    ///   取得或設定<see cref="T:System.Boolean" />值，指定是否<see cref="T:System.Net.Sockets.Socket" />，讓繫結連接埠只能有一個處理序。
    /// </summary>
    /// <returns>
    ///   <see langword="true" />如果<see cref="T:System.Net.Sockets.Socket" />允許只能有一個通訊端，繫結至特定的連接埠; 否則<see langword="false" />。
    ///    預設值是<see langword="true" />為 Windows Server 2003 和 Windows XP Service Pack 2 和<see langword="false" />對於所有其他版本。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" />已呼叫這個<see cref="T:System.Net.Sockets.Socket" />。
    /// </exception>
    public bool ExclusiveAddressUse
    {
      get => (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse) != 0;
      set
      {
        if (this.IsBound)
          throw new InvalidOperationException(SR.GetString("The socket must not be bound or connected."));
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, value ? 1 : 0);
      }
    }

    /// <summary>
    ///   取得或設定值，這個值，指定接收緩衝區的大小 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Int32" /> 包含大小，以接收緩衝區的位元組為單位。
    ///    預設值為 8192。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   設定作業指定的值小於 0。
    /// </exception>
    public int ReceiveBufferSize
    {
      get => (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof (value));
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
      }
    }

    /// <summary>
    ///   取得或設定值，這個值，指定傳送緩衝區的大小 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Int32" /> 包含大小，以位元組為單位傳送緩衝區。
    ///    預設值為 8192。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   設定作業指定的值小於 0。
    /// </exception>
    public int SendBufferSize
    {
      get => (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof (value));
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
      }
    }

    /// <summary>
    ///   取得或設定值，指定的這段時間之後同步 <see cref="Overload:System.Net.Sockets.Socket.Receive" /> 會逾時呼叫。
    /// </summary>
    /// <returns>
    ///   逾時值 (以毫秒為單位)。
    ///    預設值是 0，表示無限逾時期間。
    ///    指定-1 也表示無限逾時期間。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   設定作業指定的值是小於-1。
    /// </exception>
    public int ReceiveTimeout
    {
      get => (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
      set
      {
        if (value < -1)
          throw new ArgumentOutOfRangeException(nameof (value));
        if (value == -1)
          value = 0;
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, value);
      }
    }

    /// <summary>
    ///   取得或設定值，指定的這段時間之後同步 <see cref="Overload:System.Net.Sockets.Socket.Send" /> 會逾時呼叫。
    /// </summary>
    /// <returns>
    ///   逾時值 (以毫秒為單位)。
    ///    如果您設定的屬性值介於 1 到 499，值會變更為 500。
    ///    預設值是 0，表示無限逾時期間。
    ///    指定-1 也表示無限逾時期間。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   設定作業指定的值是小於-1。
    /// </exception>
    public int SendTimeout
    {
      get => (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
      set
      {
        if (value < -1)
          throw new ArgumentOutOfRangeException(nameof (value));
        if (value == -1)
          value = 0;
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
      }
    }

    /// <summary>
    ///   取得或設定值，指定是否 <see cref="T:System.Net.Sockets.Socket" /> 會延遲傳送所有擱置中的資料，嘗試關閉通訊端。
    /// </summary>
    /// <returns>
    ///   A <see cref="T:System.Net.Sockets.LingerOption" /> ，指定如何在關閉通訊端延遲。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public LingerOption LingerState
    {
      get => (LingerOption) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
      set => this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, (object) value);
    }

    /// <summary>
    ///   取得或設定值，指定傳送的網際網路通訊協定 (IP) 封包的時間 (TTL) 值 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <returns>TTL 值。</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   TTL 值不能設為負數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個屬性可以設定只會針對在通訊端 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    嘗試將 TTL 設定為大於 255 的值時，也會傳回此錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public short Ttl
    {
      get
      {
        if (this.addressFamily == AddressFamily.InterNetwork)
          return (short) (int) this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress);
        if (this.addressFamily == AddressFamily.InterNetworkV6)
          return (short) (int) this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress);
        throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
      }
      set
      {
        if (value < (short) 0 || value > (short) byte.MaxValue)
          throw new ArgumentOutOfRangeException(nameof (value));
        if (this.addressFamily == AddressFamily.InterNetwork)
        {
          this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, (int) value);
        }
        else
        {
          if (this.addressFamily != AddressFamily.InterNetworkV6)
            throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
          this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress, (int) value);
        }
      }
    }

    /// <summary>
    ///   取得或設定 <see cref="T:System.Boolean" /> 值，指定是否 <see cref="T:System.Net.Sockets.Socket" /> 可讓網際網路通訊協定 (IP) 資料包進行分段處理。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 允許資料包分散，否則 <see langword="false" />。
    ///    預設為 <see langword="true" />。
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個屬性可以設定只會針對在通訊端 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool DontFragment
    {
      get
      {
        if (this.addressFamily != AddressFamily.InterNetwork)
          throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
        return (int) this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment) != 0;
      }
      set
      {
        if (this.addressFamily != AddressFamily.InterNetwork)
          throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
        this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DontFragment, value ? 1 : 0);
      }
    }

    /// <summary>
    ///   取得或設定 <see cref="T:System.Boolean" /> 值，指定 <see cref="T:System.Net.Sockets.Socket" /> 是否為適用於 IPv4 和 IPv6 的雙重模式通訊端。
    /// </summary>
    /// <returns>
    ///   如果 <see cref="T:System.Net.Sockets.Socket" /> 是雙重模式通訊端，則為 <see langword="true" />；否則為 <see langword="false" />。
    ///    預設為 <see langword="false" />。
    /// </returns>
    public bool DualMode
    {
      get
      {
        if (this.AddressFamily != AddressFamily.InterNetworkV6)
          throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
        return (int) this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only) == 0;
      }
      set
      {
        if (this.AddressFamily != AddressFamily.InterNetworkV6)
          throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
        this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, value ? 0 : 1);
      }
    }

    private bool IsDualMode => this.AddressFamily == AddressFamily.InterNetworkV6 && this.DualMode;

    internal bool CanTryAddressFamily(AddressFamily family)
    {
      if (family == this.addressFamily)
        return true;
      return family == AddressFamily.InterNetwork && this.IsDualMode;
    }

    /// <summary>
    ///   建立與遠端主機的連接。
    ///    主機被指定陣列的 IP 位址與連接埠號碼。
    /// </summary>
    /// <param name="addresses">遠端主機的 IP 位址。</param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="addresses" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法對於 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列的通訊端有效。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="address" /> 的長度為零。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public void Connect(IPAddress[] addresses, int port)
    {
      int num1 = Socket.s_LoggingEnabled ? 1 : 0;
      if (this.CleanedUp)
        throw new ObjectDisposedException(this.GetType().FullName);
      if (addresses == null)
        throw new ArgumentNullException(nameof (addresses));
      if (addresses.Length == 0)
        throw new ArgumentException(SR.GetString("The number of specified IP addresses has to be greater than 0."), nameof (addresses));
      if (!ValidationHelper.ValidateTcpPort(port))
        throw new ArgumentOutOfRangeException(nameof (port));
      if (this.addressFamily != AddressFamily.InterNetwork && this.addressFamily != AddressFamily.InterNetworkV6)
        throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
      Exception exception = (Exception) null;
      foreach (IPAddress address in addresses)
      {
        if (this.CanTryAddressFamily(address.AddressFamily))
        {
          try
          {
            this.Connect((EndPoint) new IPEndPoint(address, port));
            exception = (Exception) null;
            break;
          }
          catch (Exception ex)
          {
            if (NclUtilities.IsFatal(ex))
              throw;
            else
              exception = ex;
          }
        }
      }
      if (exception != null)
        throw exception;
      if (!this.Connected)
        throw new ArgumentException(SR.GetString("None of the discovered or specified addresses match the socket address family."), nameof (addresses));
      int num2 = Socket.s_LoggingEnabled ? 1 : 0;
    }

    /// <summary>
    ///   將指定的數個位元組的資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />, ，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="size" /> 小於 0 或超過緩衝區的大小。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   存取通訊端時發生作業系統錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(byte[] buffer, int size, SocketFlags socketFlags) => this.Send(buffer, 0, size, socketFlags);

    /// <summary>
    ///   將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" /> 使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(byte[] buffer, SocketFlags socketFlags) => this.Send(buffer, 0, buffer != null ? buffer.Length : 0, socketFlags);

    /// <summary>
    ///   將資料傳送至已連線 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(byte[] buffer) => this.Send(buffer, 0, buffer != null ? buffer.Length : 0, SocketFlags.None);

    /// <summary>
    ///   將緩衝區的集清單中的連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="buffers" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(IList<ArraySegment<byte>> buffers) => this.Send(buffers, SocketFlags.None);

    /// <summary>
    ///   將緩衝區的集清單中的連接 <see cref="T:System.Net.Sockets.Socket" />, ，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="buffers" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
    {
      SocketError errorCode;
      int num = this.Send(buffers, socketFlags, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   將檔案傳送 <paramref name="fileName" /> 已連線到 <see cref="T:System.Net.Sockets.Socket" /> 物件 <see cref="F:System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread" /> 傳輸旗標。
    /// </summary>
    /// <param name="fileName">
    ///   A <see cref="T:System.String" /> ，其中包含要傳送之檔案的名稱與路徑。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <exception cref="T:System.NotSupportedException">
    ///   通訊端未連線至遠端主機。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件不是處於封鎖模式，而且無法接受此同步呼叫。
    /// </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///   檔案 <paramref name="fileName" /> 找不到。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public void SendFile(string fileName) => this.SendFile(fileName, (byte[]) null, (byte[]) null, TransmitFileOptions.UseDefaultWorkerThread);

    /// <summary>
    ///   從指定位移開始，並使用指定的 <see cref="T:System.Net.Sockets.SocketFlags" />，將資料的指定位元組數傳送到連接的 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   類型 <see cref="T:System.Byte" /> 的陣列，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">資料緩衝區中要開始傳送資料的位置。</param>
    /// <param name="size">要傳送的位元組數。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>
    ///   已傳送到 <see cref="T:System.Net.Sockets.Socket" /> 的位元組數。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 大於 <paramref name="buffer" /> 的長度。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 大於 <paramref name="buffer" /> 的長度減去 <paramref name="offset" /> 參數的值。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   在存取 <see cref="T:System.Net.Sockets.Socket" /> 時發生作業系統錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
    {
      SocketError errorCode;
      int num = this.Send(buffer, offset, size, socketFlags, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   將指定的數個位元組的資料傳送至指定使用指定的端點 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料的目的地位置。
    /// </param>
    /// <returns>已傳送的位元組數。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   指定 <paramref name="size" /> 大小超過 <paramref name="buffer" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP) => this.SendTo(buffer, 0, size, socketFlags, remoteEP);

    /// <summary>
    ///   將資料傳送至使用指定之特定端點 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料的目的地位置。
    /// </param>
    /// <returns>已傳送的位元組數。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP) => this.SendTo(buffer, 0, buffer != null ? buffer.Length : 0, socketFlags, remoteEP);

    /// <summary>將資料傳送至指定的端點。</summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料的目的地。
    /// </param>
    /// <returns>已傳送的位元組數。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int SendTo(byte[] buffer, EndPoint remoteEP) => this.SendTo(buffer, 0, buffer != null ? buffer.Length : 0, SocketFlags.None, remoteEP);

    /// <summary>
    ///   從繫結接收資料的位元組數 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區中，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="size" /> 大小超過 <paramref name="buffer" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int Receive(byte[] buffer, int size, SocketFlags socketFlags) => this.Receive(buffer, 0, size, socketFlags);

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區中，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int Receive(byte[] buffer, SocketFlags socketFlags) => this.Receive(buffer, 0, buffer != null ? buffer.Length : 0, socketFlags);

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int Receive(byte[] buffer) => this.Receive(buffer, 0, buffer != null ? buffer.Length : 0, SocketFlags.None);

    /// <summary>
    ///   從繫結接收指定的位元組數 <see cref="T:System.Net.Sockets.Socket" /> 成接收緩衝區的指定位移的位置，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中的位置 <paramref name="buffer" /> 來儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> 未設定屬性。
    /// 
    ///   -或-
    /// 
    ///   在存取時發生作業系統錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
    {
      SocketError errorCode;
      int num = this.Receive(buffer, offset, size, socketFlags, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區的清單。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含已接收的資料。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 參數為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取的通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Receive(IList<ArraySegment<byte>> buffers) => this.Receive(buffers, SocketFlags.None);

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區清單中，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含已接收的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="buffers" />.計數為零。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取的通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
    {
      SocketError errorCode;
      int num = this.Receive(buffers, socketFlags, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   資料緩衝區中，使用指定接收指定的位元組數 <see cref="T:System.Net.Sockets.SocketFlags" />, ，並儲存端點。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" />, ，傳址方式傳遞，表示遠端伺服器。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> 未設定屬性。
    /// 
    ///   -或-
    /// 
    ///   在存取時發生作業系統錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int ReceiveFrom(
      byte[] buffer,
      int size,
      SocketFlags socketFlags,
      ref EndPoint remoteEP)
    {
      return this.ReceiveFrom(buffer, 0, size, socketFlags, ref remoteEP);
    }

    /// <summary>
    ///   資料緩衝區中，使用指定接收資料包 <see cref="T:System.Net.Sockets.SocketFlags" />, ，並儲存端點。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" />, ，傳址方式傳遞，表示遠端伺服器。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP) => this.ReceiveFrom(buffer, 0, buffer != null ? buffer.Length : 0, socketFlags, ref remoteEP);

    /// <summary>接收資料包至資料緩衝區，並儲存端點。</summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" />, ，傳址方式傳遞，表示遠端伺服器。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP) => this.ReceiveFrom(buffer, 0, buffer != null ? buffer.Length : 0, SocketFlags.None, ref remoteEP);

    /// <summary>
    ///   設定低層級作業模式 <see cref="T:System.Net.Sockets.Socket" /> 使用 <see cref="T:System.Net.Sockets.IOControlCode" /> 列舉，指定控制代碼。
    /// </summary>
    /// <param name="ioControlCode">
    ///   A <see cref="T:System.Net.Sockets.IOControlCode" /> 值，指定要執行之作業的控制碼。
    /// </param>
    /// <param name="optionInValue">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含作業所需的輸入的資料。
    /// </param>
    /// <param name="optionOutValue">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含作業所傳回的輸出資料。
    /// </param>
    /// <returns>
    ///   中的位元組數目 <paramref name="optionOutValue" /> 參數。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   嘗試變更封鎖的模式，而不需使用 <see cref="P:System.Net.Sockets.Socket.Blocking" /> 屬性。
    /// </exception>
    public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) => this.IOControl((int) ioControlCode, optionInValue, optionOutValue);

    /// <summary>通訊端上設定 IP 保護層級。</summary>
    /// <param name="level">這個通訊端上設定 IP 保護層級。</param>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="level" /> 參數不可為 <see cref="F:System.Net.Sockets.IPProtectionLevel.Unspecified" />。
    ///    IP 保護層級不能設未指定。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <see cref="T:System.Net.Sockets.AddressFamily" /> 通訊端必須是 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />。
    /// </exception>
    public void SetIPProtectionLevel(IPProtectionLevel level)
    {
      if (level == IPProtectionLevel.Unspecified)
        throw new ArgumentException(SR.GetString("The specified value is not valid."), nameof (level));
      if (this.addressFamily == AddressFamily.InterNetworkV6)
      {
        this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPProtectionLevel, (int) level);
      }
      else
      {
        if (this.addressFamily != AddressFamily.InterNetwork)
          throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
        this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IPProtectionLevel, (int) level);
      }
    }

    /// <summary>
    ///   將檔案傳送 <paramref name="fileName" /> 已連線到 <see cref="T:System.Net.Sockets.Socket" /> 物件使用 <see cref="F:System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread" /> 旗標。
    /// </summary>
    /// <param name="fileName">
    ///   字串，包含要傳送之檔案的名稱與路徑。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 物件，表示非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   通訊端未連線至遠端主機。
    /// </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///   檔案 <paramref name="fileName" /> 找不到。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginSendFile(
      string fileName,
      AsyncCallback callback,
      object state)
    {
      return this.BeginSendFile(fileName, (byte[]) null, (byte[]) null, TransmitFileOptions.UseDefaultWorkerThread, callback, state);
    }

    /// <summary>
    ///   開始遠端主機連接的非同步要求。
    ///    此主機是由 <see cref="T:System.Net.IPAddress" /> 和連接埠號碼所指定。
    /// </summary>
    /// <param name="address">
    ///   遠端主機的 <see cref="T:System.Net.IPAddress" />。
    /// </param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <param name="requestCallback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於連接作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   包含連線作業資訊的使用者定義物件。
    ///    作業完成時會將這個物件傳遞至 <paramref name="requestCallback" /> 委派。
    /// </param>
    /// <returns>
    ///   參考非同步連接的 <see cref="T:System.IAsyncResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="address" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 不在通訊端系列。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="address" /> 的長度為零。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginConnect(
      IPAddress address,
      int port,
      AsyncCallback requestCallback,
      object state)
    {
      int num1 = Socket.s_LoggingEnabled ? 1 : 0;
      if (this.CleanedUp)
        throw new ObjectDisposedException(this.GetType().FullName);
      if (address == null)
        throw new ArgumentNullException(nameof (address));
      if (!ValidationHelper.ValidateTcpPort(port))
        throw new ArgumentOutOfRangeException(nameof (port));
      if (!this.CanTryAddressFamily(address.AddressFamily))
        throw new NotSupportedException(SR.GetString("This protocol version is not supported."));
      IAsyncResult asyncResult = this.BeginConnect((EndPoint) new IPEndPoint(address, port), requestCallback, state);
      int num2 = Socket.s_LoggingEnabled ? 1 : 0;
      return asyncResult;
    }

    /// <summary>
    ///   以非同步方式將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 中要開始傳送資料的參數。
    /// </param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度小於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginSend(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      SocketError errorCode;
      IAsyncResult asyncResult = this.BeginSend(buffer, offset, size, socketFlags, out errorCode, callback, state);
      if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
        return asyncResult;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   以非同步方式將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffers">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="buffers" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginSend(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      SocketError errorCode;
      IAsyncResult asyncResult = this.BeginSend(buffers, socketFlags, out errorCode, callback, state);
      if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
        return asyncResult;
      throw new SocketException(errorCode);
    }

    /// <summary>結束暫止的非同步傳送。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 會儲存此非同步作業的狀態資訊。
    /// </param>
    /// <returns>
    ///   如果成功，位元組數傳送至 <see cref="T:System.Net.Sockets.Socket" />，否則無效 <see cref="T:System.Net.Sockets.Socket" /> 錯誤。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> 先前已呼叫非同步傳送。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndSend(IAsyncResult asyncResult)
    {
      SocketError errorCode;
      int num = this.EndSend(asyncResult, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   開始以非同步方式接收的資料連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 參數用來儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   使用者定義的物件，包含接收作業的相關資訊。
    ///    作業完成時會將這個物件傳遞至 <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 委派。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginReceive(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      SocketError errorCode;
      IAsyncResult asyncResult = this.BeginReceive(buffer, offset, size, socketFlags, out errorCode, callback, state);
      if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
        return asyncResult;
      throw new SocketException(errorCode);
    }

    /// <summary>
    ///   開始以非同步方式接收的資料連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffers">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   使用者定義的物件，包含接收作業的相關資訊。
    ///    作業完成時會將這個物件傳遞至 <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 委派。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginReceive(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      SocketError errorCode;
      IAsyncResult asyncResult = this.BeginReceive(buffers, socketFlags, out errorCode, callback, state);
      if (errorCode == SocketError.Success || errorCode == SocketError.IOPending)
        return asyncResult;
      throw new SocketException(errorCode);
    }

    /// <summary>結束暫止的非同步讀取。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 先前已呼叫的非同步讀取。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndReceive(IAsyncResult asyncResult)
    {
      SocketError errorCode;
      int num = this.EndReceive(asyncResult, out errorCode);
      if (errorCode == SocketError.Success)
        return num;
      throw new SocketException(errorCode);
    }

    /// <summary>開始非同步作業以接受連入連線嘗試，並接收第一個用戶端應用程式所傳送的資料區塊。</summary>
    /// <param name="receiveSize">若要接受來自寄件者的位元組數目。</param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 參考非同步 <see cref="T:System.Net.Sockets.Socket" /> 建立。
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   接受的通訊端未接聽的連接。
    ///    您必須呼叫 <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> 和 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 之前，先呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// 
    ///   -或-
    /// 
    ///   接受的通訊端已繫結。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="receiveSize" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
    public IAsyncResult BeginAccept(
      int receiveSize,
      AsyncCallback callback,
      object state)
    {
      return this.BeginAccept((Socket) null, receiveSize, callback, state);
    }

    /// <summary>
    ///   以非同步方式接受連入連線嘗試，並建立新 <see cref="T:System.Net.Sockets.Socket" /> 物件來處理遠端主機的通訊。
    ///    這個方法會傳回包含傳輸之初始資料的緩衝區。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含傳輸的位元組。
    /// </param>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存此非同步作業，以及任何使用者的狀態資訊的物件定義的資料。
    /// </param>
    /// <returns>
    ///   A <see cref="T:System.Net.Sockets.Socket" /> 物件，以處理與遠端主機的通訊。
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 不是由呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> 先前呼叫方法。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   當您嘗試存取時，發生錯誤 <see cref="T:System.Net.Sockets.Socket" /> 請參閱 &lt; 備註 &gt; 一節，如需詳細資訊。
    /// </exception>
    public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult)
    {
      byte[] buffer1;
      int bytesTransferred;
      Socket socket = this.EndAccept(out buffer1, out bytesTransferred, asyncResult);
      buffer = new byte[bytesTransferred];
      Array.Copy((Array) buffer1, (Array) buffer, bytesTransferred);
      return socket;
    }

    private static object InternalSyncObject
    {
      get
      {
        if (Socket.s_InternalSyncObject == null)
        {
          object obj = new object();
          Interlocked.CompareExchange(ref Socket.s_InternalSyncObject, obj, (object) null);
        }
        return Socket.s_InternalSyncObject;
      }
    }

    internal bool CleanedUp => this.m_IntCleanedUp == 1;

    internal static void InitializeSockets()
    {
      if (Socket.s_Initialized)
        return;
      lock (Socket.InternalSyncObject)
      {
        if (Socket.s_Initialized)
          return;
        int num = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv4) ? 1 : 0;
        bool flag = Socket.IsProtocolSupported(NetworkInterfaceComponent.IPv6);
        if (flag)
        {
          Socket.s_OSSupportsIPv6 = true;
          flag = SettingsSectionInternal.Section.Ipv6Enabled;
        }
        Socket.s_SupportsIPv4 = num != 0;
        Socket.s_SupportsIPv6 = flag;
        Socket.s_Initialized = true;
      }
    }

    /// <summary>
    ///   釋放 <see cref="T:System.Net.Sockets.Socket" /> 類別目前的執行個體所使用的全部資源。
    /// </summary>
    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    /// <summary>
    ///   釋放 <see cref="T:System.Net.Sockets.Socket" /> 類別所使用的資源。
    /// </summary>
    ~Socket() => this.Dispose(false);

    /// <summary>開始遠端主機連接的非同步要求。</summary>
    /// <param name="socketType">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketType" /> 值。
    /// </param>
    /// <param name="protocolType">
    ///   其中一個 <see cref="T:System.Net.Sockets.ProtocolType" /> 值。
    /// </param>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   引數無效。
    ///    如果指定了多個緩衝區，會發生此例外狀況 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> 屬性不是 null。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="e" /> 參數不可為 null， <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可為 null。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 是接聽或通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    ///    如果，也會發生這個例外狀況的本機端點和 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不是相同的通訊協定家族。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public static bool ConnectAsync(
      SocketType socketType,
      ProtocolType protocolType,
      SocketAsyncEventArgs e)
    {
      int num1 = Socket.s_LoggingEnabled ? 1 : 0;
      if (e.m_BufferList != null)
        throw new ArgumentException(SR.GetString("Multiple buffers cannot be used with this method."), "BufferList");
      EndPoint endPoint1 = e.RemoteEndPoint != null ? e.RemoteEndPoint : throw new ArgumentNullException("remoteEP");
      bool flag;
      if (endPoint1 is DnsEndPoint endPoint2)
      {
        Socket socket = (Socket) null;
        MultipleConnectAsync args;
        if (endPoint2.AddressFamily == AddressFamily.Unspecified)
        {
          args = (MultipleConnectAsync) new MultipleSocketMultipleConnectAsync(socketType, protocolType);
        }
        else
        {
          socket = new Socket(endPoint2.AddressFamily, socketType, protocolType);
          args = (MultipleConnectAsync) new SingleSocketMultipleConnectAsync(socket, false);
        }
        e.StartOperationCommon(socket);
        e.StartOperationWrapperConnect(args);
        flag = args.StartConnectAsync(e, endPoint2);
      }
      else
        flag = new Socket(endPoint1.AddressFamily, socketType, protocolType).ConnectAsync(e);
      int num2 = Socket.s_LoggingEnabled ? 1 : 0;
      return flag;
    }

    internal void InternalShutdown(SocketShutdown how)
    {
      if (!this.is_connected || this.CleanedUp)
        return;
      Socket.Shutdown_internal(this.m_Handle, how, out int _);
    }

    internal IAsyncResult UnsafeBeginConnect(
      EndPoint remoteEP,
      AsyncCallback callback,
      object state)
    {
      return this.BeginConnect(remoteEP, callback, state);
    }

    internal IAsyncResult UnsafeBeginSend(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      return this.BeginSend(buffer, offset, size, socketFlags, callback, state);
    }

    internal IAsyncResult UnsafeBeginReceive(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      return this.BeginReceive(buffer, offset, size, socketFlags, callback, state);
    }

    internal IAsyncResult BeginMultipleSend(
      BufferOffsetSize[] buffers,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      ArraySegment<byte>[] arraySegmentArray = new ArraySegment<byte>[buffers.Length];
      for (int index = 0; index < buffers.Length; ++index)
        arraySegmentArray[index] = new ArraySegment<byte>(buffers[index].Buffer, buffers[index].Offset, buffers[index].Size);
      return this.BeginSend((IList<ArraySegment<byte>>) arraySegmentArray, socketFlags, callback, state);
    }

    internal IAsyncResult UnsafeBeginMultipleSend(
      BufferOffsetSize[] buffers,
      SocketFlags socketFlags,
      AsyncCallback callback,
      object state)
    {
      return this.BeginMultipleSend(buffers, socketFlags, callback, state);
    }

    internal int EndMultipleSend(IAsyncResult asyncResult) => this.EndSend(asyncResult);

    internal void MultipleSend(BufferOffsetSize[] buffers, SocketFlags socketFlags)
    {
      ArraySegment<byte>[] arraySegmentArray = new ArraySegment<byte>[buffers.Length];
      for (int index = 0; index < buffers.Length; ++index)
        arraySegmentArray[index] = new ArraySegment<byte>(buffers[index].Buffer, buffers[index].Offset, buffers[index].Size);
      this.Send((IList<ArraySegment<byte>>) arraySegmentArray, socketFlags);
    }

    internal void SetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      int optionValue,
      bool silent)
    {
      if (this.CleanedUp && this.is_closed)
      {
        if (!silent)
          throw new ObjectDisposedException(this.GetType().ToString());
      }
      else
      {
        int error;
        Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) null, (byte[]) null, optionValue, out error);
        if (!silent && error != 0)
          throw new SocketException(error);
      }
    }

    /// <summary>
    ///   初始化的新執行個體 <see cref="T:System.Net.Sockets.Socket" /> 類別使用指定的值傳回 <see cref="M:System.Net.Sockets.Socket.DuplicateAndClose(System.Int32)" />。
    /// </summary>
    /// <param name="socketInformation">
    ///   所傳回的通訊端資訊 <see cref="M:System.Net.Sockets.Socket.DuplicateAndClose(System.Int32)" />。
    /// </param>
    public Socket(SocketInformation socketInformation)
    {
      this.is_listening = (uint) (socketInformation.Options & SocketInformationOptions.Listening) > 0U;
      this.is_connected = (uint) (socketInformation.Options & SocketInformationOptions.Connected) > 0U;
      this.is_blocking = (socketInformation.Options & SocketInformationOptions.NonBlocking) == (SocketInformationOptions) 0;
      this.useOverlappedIO = (uint) (socketInformation.Options & SocketInformationOptions.UseOnlyOverlappedIO) > 0U;
      IList list = DataConverter.Unpack("iiiil", socketInformation.ProtocolInformation, 0);
      this.addressFamily = (AddressFamily) list[0];
      this.socketType = (SocketType) list[1];
      this.protocolType = (ProtocolType) list[2];
      this.is_bound = (uint) (int) list[3] > 0U;
      this.m_Handle = new SafeSocketHandle((IntPtr) (long) list[4], true);
      Socket.InitializeSockets();
      this.SocketDefaults();
    }

    internal Socket(
      AddressFamily family,
      SocketType type,
      ProtocolType proto,
      SafeSocketHandle safe_handle)
    {
      this.addressFamily = family;
      this.socketType = type;
      this.protocolType = proto;
      this.m_Handle = safe_handle;
      this.is_connected = true;
      Socket.InitializeSockets();
    }

    private void SocketDefaults()
    {
      try
      {
        if (this.addressFamily == AddressFamily.InterNetwork)
        {
          this.DontFragment = false;
          if (this.protocolType != ProtocolType.Tcp)
            return;
          this.NoDelay = false;
        }
        else
        {
          if (this.addressFamily != AddressFamily.InterNetworkV6)
            return;
          this.DualMode = true;
        }
      }
      catch (SocketException ex)
      {
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern IntPtr Socket_internal(
      AddressFamily family,
      SocketType type,
      ProtocolType proto,
      out int error);

    /// <summary>取得已從網路接收且可供讀取的資料量。</summary>
    /// <returns>從網路收到的和可供讀取的資料位元組數。</returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int Available
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        int error;
        int num = Socket.Available_internal(this.m_Handle, out error);
        if (error == 0)
          return num;
        throw new SocketException(error);
      }
    }

    private static int Available_internal(SafeSocketHandle safeHandle, out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        return Socket.Available_internal(safeHandle.DangerousGetHandle(), out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int Available_internal(IntPtr socket, out int error);

    /// <summary>
    ///   取得或設定 <see cref="T:System.Boolean" /> 值，指定是否 <see cref="T:System.Net.Sockets.Socket" /> 可以傳送或接收廣播封包。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 允許廣播封包，否則 <see langword="false" />。
    ///    預設為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   這個選項才有效只對資料包通訊端。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool EnableBroadcast
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        if (this.protocolType != ProtocolType.Udp)
          throw new SocketException(10042);
        return (uint) (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast) > 0U;
      }
      set
      {
        this.ThrowIfDisposedAndClosed();
        if (this.protocolType != ProtocolType.Udp)
          throw new SocketException(10042);
        this.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, value ? 1 : 0);
      }
    }

    /// <summary>
    ///   取得值，指出是否 <see cref="T:System.Net.Sockets.Socket" /> 繫結至特定本機連接埠。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 本機連接埠繫結，否則 <see langword="false" />。
    /// </returns>
    public bool IsBound => this.is_bound;

    /// <summary>取得或設定值，指定是否將傳出多點傳送封包傳遞給傳送應用程式。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 接收輸出多點傳送封包; 否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool MulticastLoopback
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        if (this.protocolType == ProtocolType.Tcp)
          throw new SocketException(10042);
        switch (this.addressFamily)
        {
          case AddressFamily.InterNetwork:
            return (uint) (int) this.GetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback) > 0U;
          case AddressFamily.InterNetworkV6:
            return (uint) (int) this.GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback) > 0U;
          default:
            throw new NotSupportedException("This property is only valid for InterNetwork and InterNetworkV6 sockets");
        }
      }
      set
      {
        this.ThrowIfDisposedAndClosed();
        if (this.protocolType == ProtocolType.Tcp)
          throw new SocketException(10042);
        switch (this.addressFamily)
        {
          case AddressFamily.InterNetwork:
            this.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback, value ? 1 : 0);
            break;
          case AddressFamily.InterNetworkV6:
            this.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback, value ? 1 : 0);
            break;
          default:
            throw new NotSupportedException("This property is only valid for InterNetwork and InterNetworkV6 sockets");
        }
      }
    }

    /// <summary>取得本機端點。</summary>
    /// <returns>
    ///   <see cref="T:System.Net.EndPoint" /> ， <see cref="T:System.Net.Sockets.Socket" /> 使用進行通訊。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public EndPoint LocalEndPoint
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        if (this.seed_endpoint == null)
          return (EndPoint) null;
        int error;
        SocketAddress socketAddress = Socket.LocalEndPoint_internal(this.m_Handle, (int) this.addressFamily, out error);
        if (error != 0)
          throw new SocketException(error);
        return this.seed_endpoint.Create(socketAddress);
      }
    }

    private static SocketAddress LocalEndPoint_internal(
      SafeSocketHandle safeHandle,
      int family,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        return Socket.LocalEndPoint_internal(safeHandle.DangerousGetHandle(), family, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern SocketAddress LocalEndPoint_internal(
      IntPtr socket,
      int family,
      out int error);

    /// <summary>
    ///   取得或設定值，指出是否 <see cref="T:System.Net.Sockets.Socket" /> 處於封鎖模式。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 會封鎖; 否則 <see langword="false" />。
    ///    預設為 <see langword="true" />。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool Blocking
    {
      get => this.is_blocking;
      set
      {
        this.ThrowIfDisposedAndClosed();
        int error;
        Socket.Blocking_internal(this.m_Handle, value, out error);
        if (error != 0)
          throw new SocketException(error);
        this.is_blocking = value;
      }
    }

    private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.Blocking_internal(safeHandle.DangerousGetHandle(), block, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Blocking_internal(IntPtr socket, bool block, out int error);

    /// <summary>
    ///   取得值，指出是否 <see cref="T:System.Net.Sockets.Socket" /> 連線至遠端主機自上次起 <see cref="Overload:System.Net.Sockets.Socket.Send" /> 或 <see cref="Overload:System.Net.Sockets.Socket.Receive" /> 作業。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 已連接至遠端資源的最新的作業，否則 <see langword="false" />。
    /// </returns>
    public bool Connected
    {
      get => this.is_connected;
      internal set => this.is_connected = value;
    }

    /// <summary>
    ///   取得或設定 <see cref="T:System.Boolean" /> 值，指定是否在資料流 <see cref="T:System.Net.Sockets.Socket" /> 使用 Nagle 演算法。
    /// </summary>
    /// <returns>
    ///   <see langword="false" /> 如果 <see cref="T:System.Net.Sockets.Socket" /> 使用 Nagle 演算法; 否則 <see langword="true" />。
    ///    預設為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   當您嘗試存取時，發生錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool NoDelay
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        this.ThrowIfUdp();
        return (uint) (int) this.GetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) > 0U;
      }
      set
      {
        this.ThrowIfDisposedAndClosed();
        this.ThrowIfUdp();
        this.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
      }
    }

    /// <summary>取得遠端端點。</summary>
    /// <returns>
    ///   <see cref="T:System.Net.EndPoint" /> 與 <see cref="T:System.Net.Sockets.Socket" /> 進行通訊。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public EndPoint RemoteEndPoint
    {
      get
      {
        this.ThrowIfDisposedAndClosed();
        if (!this.is_connected || this.seed_endpoint == null)
          return (EndPoint) null;
        int error;
        SocketAddress socketAddress = Socket.RemoteEndPoint_internal(this.m_Handle, (int) this.addressFamily, out error);
        if (error != 0)
          throw new SocketException(error);
        return this.seed_endpoint.Create(socketAddress);
      }
    }

    private static SocketAddress RemoteEndPoint_internal(
      SafeSocketHandle safeHandle,
      int family,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        return Socket.RemoteEndPoint_internal(safeHandle.DangerousGetHandle(), family, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern SocketAddress RemoteEndPoint_internal(
      IntPtr socket,
      int family,
      out int error);

    /// <summary>判斷一或多個通訊端的狀態。</summary>
    /// <param name="checkRead">
    ///   要檢查可讀性的 <see cref="T:System.Net.Sockets.Socket" /> 執行個體的 <see cref="T:System.Collections.IList" />。
    /// </param>
    /// <param name="checkWrite">
    ///   要檢查可寫性的 <see cref="T:System.Net.Sockets.Socket" /> 執行個體的 <see cref="T:System.Collections.IList" />。
    /// </param>
    /// <param name="checkError">
    ///   要檢查錯誤的 <see cref="T:System.Net.Sockets.Socket" /> 執行個體的 <see cref="T:System.Collections.IList" />。
    /// </param>
    /// <param name="microSeconds">
    ///   逾時值 (以微秒為單位)。
    ///    -1 值表示無限逾時。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="checkRead" /> 參數是 <see langword="null" /> 或空白。
    /// 
    ///   -和-
    /// 
    ///   <paramref name="checkWrite" /> 參數是 <see langword="null" /> 或空白。
    /// 
    ///   -和-
    /// 
    ///   <paramref name="checkError" /> 參數是 <see langword="null" /> 或空白。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public static void Select(
      IList checkRead,
      IList checkWrite,
      IList checkError,
      int microSeconds)
    {
      List<Socket> sockets1 = new List<Socket>();
      Socket.AddSockets(sockets1, checkRead, nameof (checkRead));
      Socket.AddSockets(sockets1, checkWrite, nameof (checkWrite));
      Socket.AddSockets(sockets1, checkError, nameof (checkError));
      Socket[] sockets2 = sockets1.Count != 3 ? sockets1.ToArray() : throw new ArgumentNullException("checkRead, checkWrite, checkError", "All the lists are null or empty.");
      int error;
      Socket.Select_internal(ref sockets2, microSeconds, out error);
      if (error != 0)
        throw new SocketException(error);
      if (sockets2 == null)
      {
        checkRead?.Clear();
        checkWrite?.Clear();
        checkError?.Clear();
      }
      else
      {
        int num1 = 0;
        int length = sockets2.Length;
        IList list = checkRead;
        int index1 = 0;
        for (int index2 = 0; index2 < length; ++index2)
        {
          Socket socket = sockets2[index2];
          if (socket == null)
          {
            if (list != null)
            {
              int num2 = list.Count - index1;
              for (int index3 = 0; index3 < num2; ++index3)
                list.RemoveAt(index1);
            }
            list = num1 == 0 ? checkWrite : checkError;
            index1 = 0;
            ++num1;
          }
          else
          {
            if (num1 == 1 && list == checkWrite && (!socket.is_connected && (int) socket.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error) == 0))
              socket.is_connected = true;
            while ((Socket) list[index1] != socket)
              list.RemoveAt(index1);
            ++index1;
          }
        }
      }
    }

    private static void AddSockets(List<Socket> sockets, IList list, string name)
    {
      if (list != null)
      {
        foreach (Socket socket in (IEnumerable) list)
        {
          if (socket == null)
            throw new ArgumentNullException(name, "Contains a null element");
          sockets.Add(socket);
        }
      }
      sockets.Add((Socket) null);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Select_internal(
      ref Socket[] sockets,
      int microSeconds,
      out int error);

    /// <summary>
    ///   決定狀態 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="microSeconds">等候回應，以毫秒為單位的時間。</param>
    /// <param name="mode">
    ///   其中一個 <see cref="T:System.Net.Sockets.SelectMode" /> 值。
    /// </param>
    /// <returns>
    /// 狀態 <see cref="T:System.Net.Sockets.Socket" /> 根據傳入的輪詢模式值 <paramref name="mode" /> 參數。
    /// 
    ///         模式
    /// 
    ///         傳回值
    /// 
    ///         <see cref="F:System.Net.Sockets.SelectMode.SelectRead" />
    /// 
    ///         <see langword="true" /> 如果 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 已呼叫而且連接已暫止。
    /// 
    ///         -或-
    /// 
    ///         <see langword="true" /> 如果資料是可供讀取。
    /// 
    ///         -或-
    /// 
    ///         <see langword="true" /> 如果連線已關閉、 重設，或終止。，
    /// 
    ///         否則，會傳回 <see langword="false" />。
    /// 
    ///         <see cref="F:System.Net.Sockets.SelectMode.SelectWrite" />
    /// 
    ///         <see langword="true" />, 如果在處理 <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" />, ，並在連線成功。
    /// 
    ///         -或-
    /// 
    ///         <see langword="true" /> 如果可以傳送資料。
    /// 
    ///         否則，會傳回 <see langword="false" />。
    /// 
    ///         <see cref="F:System.Net.Sockets.SelectMode.SelectError" />
    /// 
    ///         <see langword="true" /> 如果在處理 <see cref="M:System.Net.Sockets.Socket.Connect(System.Net.EndPoint)" /> 不會封鎖，以及連接失敗。
    /// 
    ///         -或-
    /// 
    ///         <see langword="true" /> 如果 <see cref="F:System.Net.Sockets.SocketOptionName.OutOfBandInline" /> 組和超出訊號範圍不是資料可供使用。
    /// 
    ///         否則，會傳回 <see langword="false" />。
    ///       </returns>
    /// <exception cref="T:System.NotSupportedException">
    ///   <paramref name="mode" /> 參數不是其中一個 <see cref="T:System.Net.Sockets.SelectMode" /> 值。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱下面的＜備註＞。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool Poll(int microSeconds, SelectMode mode)
    {
      this.ThrowIfDisposedAndClosed();
      if (mode != SelectMode.SelectRead && mode != SelectMode.SelectWrite && mode != SelectMode.SelectError)
        throw new NotSupportedException("'mode' parameter is not valid.");
      int error;
      bool flag = Socket.Poll_internal(this.m_Handle, mode, microSeconds, out error);
      if (error != 0)
        throw new SocketException(error);
      if (mode == SelectMode.SelectWrite & flag && !this.is_connected && (int) this.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Error) == 0)
        this.is_connected = true;
      return flag;
    }

    private static bool Poll_internal(
      SafeSocketHandle safeHandle,
      SelectMode mode,
      int timeout,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        return Socket.Poll_internal(safeHandle.DangerousGetHandle(), mode, timeout, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool Poll_internal(
      IntPtr socket,
      SelectMode mode,
      int timeout,
      out int error);

    /// <summary>
    ///   建立新 <see cref="T:System.Net.Sockets.Socket" /> 新建立的連線。
    /// </summary>
    /// <returns>
    ///   A <see cref="T:System.Net.Sockets.Socket" /> 新建立的連線。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   接受的通訊端未接聽的連接。
    ///    您必須呼叫 <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> 和 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 之前，先呼叫 <see cref="M:System.Net.Sockets.Socket.Accept" />。
    /// </exception>
    public Socket Accept()
    {
      this.ThrowIfDisposedAndClosed();
      int error = 0;
      SafeSocketHandle safe_handle = Socket.Accept_internal(this.m_Handle, out error, this.is_blocking);
      if (error != 0)
      {
        if (this.is_closed)
          error = 10004;
        throw new SocketException(error);
      }
      return new Socket(this.AddressFamily, this.SocketType, this.ProtocolType, safe_handle)
      {
        seed_endpoint = this.seed_endpoint,
        Blocking = this.Blocking
      };
    }

    internal void Accept(Socket acceptSocket)
    {
      this.ThrowIfDisposedAndClosed();
      int error = 0;
      SafeSocketHandle safeSocketHandle = Socket.Accept_internal(this.m_Handle, out error, this.is_blocking);
      if (error != 0)
      {
        if (this.is_closed)
          error = 10004;
        throw new SocketException(error);
      }
      acceptSocket.addressFamily = this.AddressFamily;
      acceptSocket.socketType = this.SocketType;
      acceptSocket.protocolType = this.ProtocolType;
      acceptSocket.m_Handle = safeSocketHandle;
      acceptSocket.is_connected = true;
      acceptSocket.seed_endpoint = this.seed_endpoint;
      acceptSocket.Blocking = this.Blocking;
    }

    /// <summary>開始非同步作業以接受連入連線。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   引數無效。
    ///    如果提供的緩衝區夠大，就會發生這個例外狀況。
    ///    緩衝區的大小必須至少 2 * (sizeof(SOCKADDR_STORAGE + 16) 位元組。
    /// 
    ///   如果指定了多個緩衝區，也會發生這個例外狀況 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> 屬性不是 null。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   引數超出範圍。
    ///    如果發生例外狀況 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   要求的作業無效。
    ///    如果發生這個例外狀況接受 <see cref="T:System.Net.Sockets.Socket" /> 連接或接受未接聽通訊端繫結。
    /// 
    ///   您必須呼叫 <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> 和 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 方法之前先呼叫 <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> 方法。
    /// 
    ///   如果通訊端已連線或通訊端作業已在使用指定的進度，也會發生這個例外狀況 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public bool AcceptAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_bound)
        throw new InvalidOperationException("You must call the Bind method before performing this operation.");
      if (!this.is_listening)
        throw new InvalidOperationException("You must call the Listen method before performing this operation.");
      if (e.BufferList != null)
        throw new ArgumentException("Multiple buffers cannot be used with this method.");
      Socket socket = e.Count >= 0 ? e.AcceptSocket : throw new ArgumentOutOfRangeException("e.Count");
      if (socket != null && (socket.is_bound || socket.is_connected))
        throw new InvalidOperationException("AcceptSocket: The socket must not be bound or connected.");
      this.InitSocketAsyncEventArgs(e, Socket.AcceptAsyncCallback, (object) e, SocketOperation.Accept);
      this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptCallback, (IOAsyncResult) e.socket_async_result));
      return true;
    }

    /// <summary>開始非同步作業以接受連入連線。</summary>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 參考非同步 <see cref="T:System.Net.Sockets.Socket" /> 建立。
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   接受的通訊端未接聽的連接。
    ///    您必須呼叫 <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> 和 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 之前，先呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// 
    ///   -或-
    /// 
    ///   接受的通訊端已繫結。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="receiveSize" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public IAsyncResult BeginAccept(AsyncCallback callback, object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_bound || !this.is_listening)
        throw new InvalidOperationException();
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Accept);
      this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>開始非同步作業以接受連入連線嘗試從指定的通訊端和接收第一個用戶端應用程式所傳送的資料區塊。</summary>
    /// <param name="acceptSocket">
    ///   接受 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    ///    這個值可能是 <see langword="null" />。
    /// </param>
    /// <param name="receiveSize">要接收的位元組數目上限。</param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 物件，參照非同步 <see cref="T:System.Net.Sockets.Socket" /> 物件建立。
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   接受的通訊端未接聽的連接。
    ///    您必須呼叫 <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> 和 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> 之前，先呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// 
    ///   -或-
    /// 
    ///   接受的通訊端已繫結。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="receiveSize" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public IAsyncResult BeginAccept(
      Socket acceptSocket,
      int receiveSize,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (receiveSize < 0)
        throw new ArgumentOutOfRangeException(nameof (receiveSize), "receiveSize is less than zero");
      if (acceptSocket != null)
      {
        this.ThrowIfDisposedAndClosed(acceptSocket);
        if (acceptSocket.IsBound)
          throw new InvalidOperationException();
        if (acceptSocket.ProtocolType != ProtocolType.Tcp)
          throw new SocketException(10022);
      }
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.AcceptReceive)
      {
        Buffer = new byte[receiveSize],
        Offset = 0,
        Size = receiveSize,
        SockFlags = SocketFlags.None,
        AcceptSocket = acceptSocket
      };
      this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginAcceptReceiveCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>
    ///   以非同步方式接受連入連線嘗試，並建立新 <see cref="T:System.Net.Sockets.Socket" /> 以處理遠端主機的通訊。
    /// </summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存此非同步作業，以及任何使用者定義資料的狀態資訊。
    /// </param>
    /// <returns>
    ///   A <see cref="T:System.Net.Sockets.Socket" /> 以處理與遠端主機的通訊。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 不是由呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> 先前呼叫方法。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    public Socket EndAccept(IAsyncResult asyncResult) => this.EndAccept(out byte[] _, out int _, asyncResult);

    /// <summary>
    ///   以非同步方式接受連入連線嘗試，並建立新 <see cref="T:System.Net.Sockets.Socket" /> 物件來處理遠端主機的通訊。
    ///    這個方法會傳回緩衝區，其中包含的初始資料和傳送的位元組數。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含傳輸的位元組。
    /// </param>
    /// <param name="bytesTransferred">傳輸的位元組數目。</param>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存此非同步作業，以及任何使用者的狀態資訊的物件定義的資料。
    /// </param>
    /// <returns>
    ///   A <see cref="T:System.Net.Sockets.Socket" /> 物件，以處理與遠端主機的通訊。
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 不是由呼叫 <see cref="M:System.Net.Sockets.Socket.BeginAccept(System.AsyncCallback,System.Object)" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndAccept(System.IAsyncResult)" /> 先前呼叫方法。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   當您嘗試存取時，發生錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public Socket EndAccept(
      out byte[] buffer,
      out int bytesTransferred,
      IAsyncResult asyncResult)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndAccept), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      socketAsyncResult.CheckIfThrowDelayedException();
      buffer = socketAsyncResult.Buffer;
      bytesTransferred = socketAsyncResult.Total;
      return socketAsyncResult.AcceptedSocket;
    }

    private static SafeSocketHandle Accept_internal(
      SafeSocketHandle safeHandle,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return new SafeSocketHandle(Socket.Accept_internal(safeHandle.DangerousGetHandle(), out error, blocking), true);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern IntPtr Accept_internal(IntPtr sock, out int error, bool blocking);

    /// <summary>
    ///   將 <see cref="T:System.Net.Sockets.Socket" /> 與本機端點。
    /// </summary>
    /// <param name="localEP">
    ///   本機 <see cref="T:System.Net.EndPoint" /> 與 <see cref="T:System.Net.Sockets.Socket" />。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="localEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public void Bind(EndPoint localEP)
    {
      this.ThrowIfDisposedAndClosed();
      if (localEP == null)
        throw new ArgumentNullException(nameof (localEP));
      if (localEP is IPEndPoint input)
        localEP = (EndPoint) this.RemapIPEndPoint(input);
      int error;
      Socket.Bind_internal(this.m_Handle, localEP.Serialize(), out error);
      if (error != 0)
        throw new SocketException(error);
      if (error == 0)
        this.is_bound = true;
      this.seed_endpoint = localEP;
    }

    private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.Bind_internal(safeHandle.DangerousGetHandle(), sa, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Bind_internal(IntPtr sock, SocketAddress sa, out int error);

    /// <summary>
    ///   數位 <see cref="T:System.Net.Sockets.Socket" /> 接聽狀態中。
    /// </summary>
    /// <param name="backlog">擱置連線佇列長度上限。</param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void Listen(int backlog)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_bound)
        throw new SocketException(10022);
      int error;
      Socket.Listen_internal(this.m_Handle, backlog, out error);
      if (error != 0)
        throw new SocketException(error);
      this.is_listening = true;
    }

    private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.Listen_internal(safeHandle.DangerousGetHandle(), backlog, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Listen_internal(IntPtr sock, int backlog, out int error);

    /// <summary>
    ///   建立與遠端主機的連接。
    ///    指定主機的 IP 位址與連接埠號碼。
    /// </summary>
    /// <param name="address">遠端主機的 IP 位址。</param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="address" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法對於 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列的通訊端有效。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="address" /> 的長度為零。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public void Connect(IPAddress address, int port) => this.Connect((EndPoint) new IPEndPoint(address, port));

    /// <summary>
    ///   建立與遠端主機的連接。
    ///    此主機是由主機名稱和連接埠號碼指定。
    /// </summary>
    /// <param name="host">遠端主機的名稱。</param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="host" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法對於 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列的通訊端有效。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public void Connect(string host, int port) => this.Connect(Dns.GetHostAddresses(host), port);

    /// <summary>建立與遠端主機的連接。</summary>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表在遠端裝置。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public void Connect(EndPoint remoteEP)
    {
      this.ThrowIfDisposedAndClosed();
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      if (remoteEP is IPEndPoint input && this.socketType != SocketType.Dgram && (input.Address.Equals((object) IPAddress.Any) || input.Address.Equals((object) IPAddress.IPv6Any)))
        throw new SocketException(10049);
      if (this.is_listening)
        throw new InvalidOperationException();
      if (input != null)
        remoteEP = (EndPoint) this.RemapIPEndPoint(input);
      SocketAddress sa = remoteEP.Serialize();
      int error = 0;
      Socket.Connect_internal(this.m_Handle, sa, out error, this.is_blocking);
      if (error == 0 || error == 10035)
        this.seed_endpoint = remoteEP;
      if (error != 0)
      {
        if (this.is_closed)
          error = 10004;
        throw new SocketException(error);
      }
      this.is_connected = this.socketType != SocketType.Dgram || input == null || !input.Address.Equals((object) IPAddress.Any) && !input.Address.Equals((object) IPAddress.IPv6Any);
      this.is_bound = true;
    }

    /// <summary>開始遠端主機連接的非同步要求。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   引數無效。
    ///    如果指定了多個緩衝區，會發生此例外狀況 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> 屬性不是 null。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="e" /> 參數不可為 null， <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可為 null。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 是接聽或通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    ///    如果，也會發生這個例外狀況的本機端點和 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不是相同的通訊協定家族。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public bool ConnectAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (this.is_listening)
        throw new InvalidOperationException("You may not perform this operation after calling the Listen method.");
      if (e.RemoteEndPoint == null)
        throw new ArgumentNullException("remoteEP");
      this.InitSocketAsyncEventArgs(e, (AsyncCallback) null, (object) e, SocketOperation.Connect);
      try
      {
        IPAddress[] addresses;
        SocketAsyncResult socketAsyncResult;
        if (!this.GetCheckedIPs(e, out addresses))
        {
          socketAsyncResult = (SocketAsyncResult) this.BeginConnect(e.RemoteEndPoint, Socket.ConnectAsyncCallback, (object) e);
        }
        else
        {
          DnsEndPoint remoteEndPoint = (DnsEndPoint) e.RemoteEndPoint;
          socketAsyncResult = (SocketAsyncResult) this.BeginConnect(addresses, remoteEndPoint.Port, Socket.ConnectAsyncCallback, (object) e);
        }
        if (socketAsyncResult.IsCompleted)
        {
          if (socketAsyncResult.CompletedSynchronously)
          {
            socketAsyncResult.CheckIfThrowDelayedException();
            return false;
          }
        }
      }
      catch (Exception ex)
      {
        e.socket_async_result.Complete(ex, true);
        return false;
      }
      return true;
    }

    /// <summary>取消遠端主機連接的非同步要求。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 物件用來藉由呼叫其中一個要求至遠端主機連接 <see cref="M:System.Net.Sockets.Socket.ConnectAsync(System.Net.Sockets.SocketType,System.Net.Sockets.ProtocolType,System.Net.Sockets.SocketAsyncEventArgs)" /> 方法。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="e" /> 參數不可為 null， <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可為 null。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public static void CancelConnectAsync(SocketAsyncEventArgs e)
    {
      if (e == null)
        throw new ArgumentNullException(nameof (e));
      if (e.in_progress == 0 || e.LastOperation != SocketAsyncOperation.Connect)
        return;
      e.current_socket.Close();
    }

    /// <summary>
    ///   開始遠端主機連接的非同步要求。
    ///    此主機是由主機名稱和連接埠號碼指定。
    /// </summary>
    /// <param name="host">遠端主機的名稱。</param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <param name="requestCallback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於連接作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   包含連線作業資訊的使用者定義物件。
    ///    作業完成時會將這個物件傳遞至 <paramref name="requestCallback" /> 委派。
    /// </param>
    /// <returns>
    ///   參考非同步連接的 <see cref="T:System.IAsyncResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="host" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法對於 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 系列的通訊端有效。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public IAsyncResult BeginConnect(
      string host,
      int port,
      AsyncCallback requestCallback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (host == null)
        throw new ArgumentNullException(nameof (host));
      if (this.addressFamily != AddressFamily.InterNetwork && this.addressFamily != AddressFamily.InterNetworkV6)
        throw new NotSupportedException("This method is valid only for sockets in the InterNetwork and InterNetworkV6 families");
      if (port <= 0 || port > (int) ushort.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (port), "Must be > 0 and < 65536");
      if (this.is_listening)
        throw new InvalidOperationException();
      return this.BeginConnect(Dns.GetHostAddresses(host), port, requestCallback, state);
    }

    /// <summary>開始遠端主機連接的非同步要求。</summary>
    /// <param name="remoteEP">
    ///   表示遠端主機的 <see cref="T:System.Net.EndPoint" />。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   參考非同步連接的 <see cref="T:System.IAsyncResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public IAsyncResult BeginConnect(
      EndPoint remoteEP,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      if (this.is_listening)
        throw new InvalidOperationException();
      SocketAsyncResult sockares = new SocketAsyncResult(this, callback, state, SocketOperation.Connect);
      sockares.EndPoint = remoteEP;
      Socket.BeginSConnect(sockares);
      return (IAsyncResult) sockares;
    }

    /// <summary>
    ///   開始遠端主機連接的非同步要求。
    ///    主機是由 <see cref="T:System.Net.IPAddress" /> 陣列和連接埠號碼指定。
    /// </summary>
    /// <param name="addresses">
    ///   至少一個指定遠端主機的 <see cref="T:System.Net.IPAddress" />。
    /// </param>
    /// <param name="port">遠端主機的連接埠號碼。</param>
    /// <param name="requestCallback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於連接作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   包含連線作業資訊的使用者定義物件。
    ///    作業完成時會將這個物件傳遞至 <paramref name="requestCallback" /> 委派。
    /// </param>
    /// <returns>
    ///   參考非同步連接的 <see cref="T:System.IAsyncResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="addresses" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法對於使用 <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> 或 <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> 的通訊端有效。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   連接埠號碼無效。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="address" /> 的長度為零。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 正執行 <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" />。
    /// </exception>
    public IAsyncResult BeginConnect(
      IPAddress[] addresses,
      int port,
      AsyncCallback requestCallback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (addresses == null)
        throw new ArgumentNullException(nameof (addresses));
      if (addresses.Length == 0)
        throw new ArgumentException("Empty addresses list");
      if (this.AddressFamily != AddressFamily.InterNetwork && this.AddressFamily != AddressFamily.InterNetworkV6)
        throw new NotSupportedException("This method is only valid for addresses in the InterNetwork or InterNetworkV6 families");
      if (port <= 0 || port > (int) ushort.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (port), "Must be > 0 and < 65536");
      if (this.is_listening)
        throw new InvalidOperationException();
      SocketAsyncResult sockares = new SocketAsyncResult(this, requestCallback, state, SocketOperation.Connect);
      sockares.Addresses = addresses;
      sockares.Port = port;
      this.is_connected = false;
      Socket.BeginMConnect(sockares);
      return (IAsyncResult) sockares;
    }

    private static void BeginMConnect(SocketAsyncResult sockares)
    {
      Exception exception = (Exception) null;
      for (int currentAddress = sockares.CurrentAddress; currentAddress < sockares.Addresses.Length; ++currentAddress)
      {
        try
        {
          ++sockares.CurrentAddress;
          sockares.EndPoint = (EndPoint) new IPEndPoint(sockares.Addresses[currentAddress], sockares.Port);
          Socket.BeginSConnect(sockares);
          return;
        }
        catch (Exception ex)
        {
          exception = ex;
        }
      }
      throw exception;
    }

    private static void BeginSConnect(SocketAsyncResult sockares)
    {
      EndPoint endPoint = sockares.EndPoint;
      if (endPoint is IPEndPoint)
      {
        IPEndPoint input = (IPEndPoint) endPoint;
        if (input.Address.Equals((object) IPAddress.Any) || input.Address.Equals((object) IPAddress.IPv6Any))
        {
          sockares.Complete((Exception) new SocketException(10049), true);
          return;
        }
        sockares.EndPoint = endPoint = (EndPoint) sockares.socket.RemapIPEndPoint(input);
      }
      int error = 0;
      if (sockares.socket.connect_in_progress)
      {
        sockares.socket.connect_in_progress = false;
        sockares.socket.m_Handle.Dispose();
        sockares.socket.m_Handle = new SafeSocketHandle(sockares.socket.Socket_internal(sockares.socket.addressFamily, sockares.socket.socketType, sockares.socket.protocolType, out error), true);
        if (error != 0)
          throw new SocketException(error);
      }
      int num = sockares.socket.is_blocking ? 1 : 0;
      if (num != 0)
        sockares.socket.Blocking = false;
      Socket.Connect_internal(sockares.socket.m_Handle, endPoint.Serialize(), out error, false);
      if (num != 0)
        sockares.socket.Blocking = true;
      switch (error)
      {
        case 0:
          sockares.socket.is_connected = true;
          sockares.socket.is_bound = true;
          sockares.Complete(true);
          break;
        case 10035:
        case 10036:
          sockares.socket.is_connected = false;
          sockares.socket.is_bound = false;
          sockares.socket.connect_in_progress = true;
          IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginConnectCallback, (IOAsyncResult) sockares));
          break;
        default:
          sockares.socket.is_connected = false;
          sockares.socket.is_bound = false;
          sockares.Complete((Exception) new SocketException(error), true);
          break;
      }
    }

    /// <summary>結束擱置的非同步連接要求。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginConnect(System.Net.EndPoint,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndConnect(System.IAsyncResult)" /> 以前稱為非同步連線。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void EndConnect(IAsyncResult asyncResult)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndConnect), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      socketAsyncResult.CheckIfThrowDelayedException();
    }

    private static void Connect_internal(
      SafeSocketHandle safeHandle,
      SocketAddress sa,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        Socket.Connect_internal(safeHandle.DangerousGetHandle(), sa, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Connect_internal(
      IntPtr sock,
      SocketAddress sa,
      out int error,
      bool blocking);

    private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses)
    {
      addresses = (IPAddress[]) null;
      if (e.RemoteEndPoint is DnsEndPoint remoteEndPoint)
      {
        if (remoteEndPoint.AddressFamily == AddressFamily.Unspecified)
        {
          addresses = Dns.GetHostAddresses(remoteEndPoint.Host);
        }
        else
        {
          IPAddress[] hostAddresses = Dns.GetHostAddresses(remoteEndPoint.Host);
          int length = 0;
          int[] numArray = new int[hostAddresses.Length];
          for (int index = 0; index < hostAddresses.Length; ++index)
          {
            if (hostAddresses[index].AddressFamily == remoteEndPoint.AddressFamily)
            {
              numArray[length] = index;
              ++length;
            }
          }
          addresses = new IPAddress[length];
          for (int index = 0; index < length; ++index)
            addresses[index] = hostAddresses[numArray[index]];
        }
        return true;
      }
      e.ConnectByNameError = (Exception) null;
      return false;
    }

    /// <summary>關閉通訊端連接，並允許重複使用的通訊端。</summary>
    /// <param name="reuseSocket">
    ///   <see langword="true" /> 如果之後可以重複使用此通訊端就會關閉目前的連線。否則， <see langword="false" />。
    /// </param>
    /// <exception cref="T:System.PlatformNotSupportedException">
    ///   這個方法會要求 Windows 2000 （含） 以前版本中，或將會擲回例外狀況。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public void Disconnect(bool reuseSocket)
    {
      this.ThrowIfDisposedAndClosed();
      int error = 0;
      Socket.Disconnect_internal(this.m_Handle, reuseSocket, out error);
      if (error != 0)
      {
        if (error == 50)
          throw new PlatformNotSupportedException();
        throw new SocketException(error);
      }
      this.is_connected = false;
      int num = reuseSocket ? 1 : 0;
    }

    /// <summary>開始中斷與遠端端點的非同步要求。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="e" /> 參數不可以是 null。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    public bool DisconnectAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      this.InitSocketAsyncEventArgs(e, Socket.DisconnectAsyncCallback, (object) e, SocketOperation.Disconnect);
      IOSelector.Add(e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginDisconnectCallback, (IOAsyncResult) e.socket_async_result));
      return true;
    }

    /// <summary>開始中斷與遠端端點的非同步要求。</summary>
    /// <param name="reuseSocket">
    ///   <see langword="true" /> 如果之後可以重複使用此通訊端連接已關閉。否則， <see langword="false" />。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 物件，參照非同步作業。
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統是 Windows 2000 或更早版本，此方法需要 Windows XP。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public IAsyncResult BeginDisconnect(
      bool reuseSocket,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Disconnect)
      {
        ReuseSocket = reuseSocket
      };
      IOSelector.Add(socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginDisconnectCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>結束暫止的非同步中斷要求。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料的物件。
    /// </param>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統是 Windows 2000 或更早版本，此方法需要 Windows XP。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginDisconnect(System.Boolean,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndDisconnect(System.IAsyncResult)" /> 以前稱為非同步連線。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.Net.WebException">
    ///   中斷連接要求已逾時。
    /// </exception>
    public void EndDisconnect(IAsyncResult asyncResult)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndDisconnect), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      socketAsyncResult.CheckIfThrowDelayedException();
    }

    private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.Disconnect_internal(safeHandle.DangerousGetHandle(), reuse, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Disconnect_internal(IntPtr sock, bool reuse, out int error);

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區中，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中的位置 <paramref name="buffer" /> 參數來儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   未設定 <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> 屬性。
    /// 
    ///   -或-
    /// 
    ///   在存取時發生作業系統錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public unsafe int Receive(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      int error;
      int num;
      fixed (byte* numPtr = buffer)
        num = Socket.Receive_internal(this.m_Handle, numPtr + offset, size, socketFlags, out error, this.is_blocking);
      errorCode = (SocketError) error;
      if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
      {
        this.is_connected = false;
        this.is_bound = false;
        return num;
      }
      this.is_connected = true;
      return num;
    }

    /// <summary>
    ///   接收來自繫結資料 <see cref="T:System.Net.Sockets.Socket" /> 接收緩衝區清單中，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含已接收的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="buffers" />.計數為零。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取的通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [CLSCompliant(false)]
    public unsafe int Receive(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      int count = buffers != null && buffers.Count != 0 ? buffers.Count : throw new ArgumentNullException(nameof (buffers));
      GCHandle[] gcHandleArray = new GCHandle[count];
      int error;
      int num;
      try
      {
        fixed (Socket.WSABUF* bufarray = new Socket.WSABUF[count])
        {
          for (int index = 0; index < count; ++index)
          {
            ArraySegment<byte> buffer = buffers[index];
            if (buffer.Offset >= 0 && buffer.Count >= 0)
            {
              if (buffer.Count <= buffer.Array.Length - buffer.Offset)
              {
                try
                {
                }
                finally
                {
                  gcHandleArray[index] = GCHandle.Alloc((object) buffer.Array, GCHandleType.Pinned);
                }
                bufarray[index].len = buffer.Count;
                bufarray[index].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>((M0[]) buffer.Array, buffer.Offset);
                continue;
              }
            }
            throw new ArgumentOutOfRangeException("segment");
          }
          num = Socket.Receive_internal(this.m_Handle, bufarray, count, socketFlags, out error, this.is_blocking);
        }
      }
      finally
      {
        for (int index = 0; index < count; ++index)
        {
          if (gcHandleArray[index].IsAllocated)
            gcHandleArray[index].Free();
        }
      }
      errorCode = (SocketError) error;
      return num;
    }

    /// <summary>
    ///   開始接收來自已連接資料的非同步要求 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    /// </summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   引數無效。
    ///   <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> 或 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> 屬性 <paramref name="e" /> 參數必須參考正確的緩衝區。
    ///    一個或另一個屬性可能設定，但不是能同時在相同的時間。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public bool ReceiveAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (e.Buffer == null && e.BufferList == null)
        throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
      if (e.Buffer == null)
      {
        this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, (object) e, SocketOperation.ReceiveGeneric);
        e.socket_async_result.Buffers = e.BufferList;
        this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveGenericCallback, (IOAsyncResult) e.socket_async_result));
      }
      else
      {
        this.InitSocketAsyncEventArgs(e, Socket.ReceiveAsyncCallback, (object) e, SocketOperation.Receive);
        e.socket_async_result.Buffer = e.Buffer;
        e.socket_async_result.Offset = e.Offset;
        e.socket_async_result.Size = e.Count;
        this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, (IOAsyncResult) e.socket_async_result));
      }
      return true;
    }

    /// <summary>
    ///   開始以非同步方式接收的資料連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中的位置 <paramref name="buffer" /> 來儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   使用者定義的物件，包含接收作業的相關資訊。
    ///    作業完成時會將這個物件傳遞至 <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 委派。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    public IAsyncResult BeginReceive(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      out SocketError errorCode,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      errorCode = SocketError.Success;
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Receive)
      {
        Buffer = buffer,
        Offset = offset,
        Size = size,
        SockFlags = socketFlags
      };
      this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>
    ///   開始以非同步方式接收的資料連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffers">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派，會於作業完成時參考要叫用的方法。
    /// </param>
    /// <param name="state">
    ///   使用者定義的物件，包含接收作業的相關資訊。
    ///    作業完成時會將這個物件傳遞至 <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 委派。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [CLSCompliant(false)]
    public IAsyncResult BeginReceive(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      out SocketError errorCode,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (buffers == null)
        throw new ArgumentNullException(nameof (buffers));
      errorCode = SocketError.Success;
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.ReceiveGeneric)
      {
        Buffers = buffers,
        SockFlags = socketFlags
      };
      this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveGenericCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>結束暫止的非同步讀取。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginReceive(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndReceive(System.IAsyncResult)" /> 先前已呼叫的非同步讀取。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndReceive), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      errorCode = socketAsyncResult.ErrorCode;
      if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
        this.is_connected = false;
      if (errorCode == SocketError.Success)
        socketAsyncResult.CheckIfThrowDelayedException();
      return socketAsyncResult.Total;
    }

    private static unsafe int Receive_internal(
      SafeSocketHandle safeHandle,
      Socket.WSABUF* bufarray,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.Receive_internal(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int Receive_internal(
      IntPtr sock,
      Socket.WSABUF* bufarray,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking);

    private static unsafe int Receive_internal(
      SafeSocketHandle safeHandle,
      byte* buffer,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.Receive_internal(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int Receive_internal(
      IntPtr sock,
      byte* buffer,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking);

    /// <summary>
    ///   使用指定的 <see cref="T:System.Net.Sockets.SocketFlags" />，將指定的資料位元組數目接收至資料緩衝區的指定位置，並儲存端點。
    /// </summary>
    /// <param name="buffer">
    ///   類型 <see cref="T:System.Byte" /> 的陣列，此為接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   <paramref name="buffer" /> 參數中的位置，可儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   以傳址方式傳遞的 <see cref="T:System.Net.EndPoint" />，表示遠端伺服器。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 大於 <paramref name="buffer" /> 的長度。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 大於 <paramref name="buffer" /> 的長度減去位移參數的值。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   未設定 <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> 屬性。
    /// 
    ///   -或-
    /// 
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int ReceiveFrom(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      ref EndPoint remoteEP)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      SocketError errorCode;
      int from = this.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP, out errorCode);
      if (errorCode == SocketError.Success)
        return from;
      throw new SocketException(errorCode);
    }

    internal unsafe int ReceiveFrom(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      ref EndPoint remoteEP,
      out SocketError errorCode)
    {
      SocketAddress sockaddr = remoteEP.Serialize();
      int error;
      int fromInternal;
      fixed (byte* numPtr = buffer)
        fromInternal = Socket.ReceiveFrom_internal(this.m_Handle, numPtr + offset, size, socketFlags, ref sockaddr, out error, this.is_blocking);
      errorCode = (SocketError) error;
      if (errorCode != SocketError.Success)
      {
        if (errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
          this.is_connected = false;
        else if (errorCode == SocketError.WouldBlock && this.is_blocking)
          errorCode = SocketError.TimedOut;
        return 0;
      }
      this.is_connected = true;
      this.is_bound = true;
      if (sockaddr != null)
        remoteEP = remoteEP.Create(sockaddr);
      this.seed_endpoint = remoteEP;
      return fromInternal;
    }

    /// <summary>開始以非同步方式接收指定的網路裝置的資料。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可以是 null。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    public bool ReceiveFromAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (e.BufferList != null)
        throw new NotSupportedException("Mono doesn't support using BufferList at this point.");
      if (e.RemoteEndPoint == null)
        throw new ArgumentNullException("remoteEP", "Value cannot be null.");
      this.InitSocketAsyncEventArgs(e, Socket.ReceiveFromAsyncCallback, (object) e, SocketOperation.ReceiveFrom);
      e.socket_async_result.Buffer = e.Buffer;
      e.socket_async_result.Offset = e.Offset;
      e.socket_async_result.Size = e.Count;
      e.socket_async_result.EndPoint = e.RemoteEndPoint;
      e.socket_async_result.SockFlags = e.SocketFlags;
      this.QueueIOSelectorJob(this.ReadSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveFromCallback, (IOAsyncResult) e.socket_async_result));
      return true;
    }

    /// <summary>開始以非同步方式接收指定的網路裝置的資料。</summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 參數，來儲存資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料來源。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public IAsyncResult BeginReceiveFrom(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      ref EndPoint remoteEP,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.ReceiveFrom)
      {
        Buffer = buffer,
        Offset = offset,
        Size = size,
        SockFlags = socketFlags,
        EndPoint = remoteEP
      };
      this.QueueIOSelectorJob(this.ReadSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Read, Socket.BeginReceiveFromCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>結束暫止的非同步讀取從指定的端點。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <param name="endPoint">
    ///   來源 <see cref="T:System.Net.EndPoint" />。
    /// </param>
    /// <returns>
    ///   如果成功，接收的位元組數目。
    ///    如果不成功，則傳回 0。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginReceiveFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint@,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndReceiveFrom(System.IAsyncResult,System.Net.EndPoint@)" /> 先前已呼叫的非同步讀取。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
    {
      this.ThrowIfDisposedAndClosed();
      if (endPoint == null)
        throw new ArgumentNullException(nameof (endPoint));
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndReceiveFrom), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      socketAsyncResult.CheckIfThrowDelayedException();
      endPoint = socketAsyncResult.EndPoint;
      return socketAsyncResult.Total;
    }

    private static unsafe int ReceiveFrom_internal(
      SafeSocketHandle safeHandle,
      byte* buffer,
      int count,
      SocketFlags flags,
      ref SocketAddress sockaddr,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.ReceiveFrom_internal(safeHandle.DangerousGetHandle(), buffer, count, flags, ref sockaddr, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int ReceiveFrom_internal(
      IntPtr sock,
      byte* buffer,
      int count,
      SocketFlags flags,
      ref SocketAddress sockaddr,
      out int error,
      bool blocking);

    /// <summary>
    ///   接收資料的位元組數到指定的位置，使用指定的資料緩衝區 <see cref="T:System.Net.Sockets.SocketFlags" />, ，並儲存端點和封包資訊。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中的位置 <paramref name="buffer" /> 參數來儲存接收的資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" />, ，傳址方式傳遞，表示遠端伺服器。
    /// </param>
    /// <param name="ipPacketInformation">
    ///   <see cref="T:System.Net.Sockets.IPPacketInformation" /> 保留位址及介面資訊。
    /// </param>
    /// <returns>收到的位元組數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或者-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 減去位移參數的值。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   <see cref="P:System.Net.Sockets.Socket.LocalEndPoint" /> 未設定屬性。
    /// 
    ///   -或-
    /// 
    ///   .NET Framework AMD 64 位元處理器上執行。
    /// 
    ///   -或-
    /// 
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統是 Windows 2000 或更早版本，此方法需要 Windows XP。
    /// </exception>
    [MonoTODO("Not implemented")]
    public int ReceiveMessageFrom(
      byte[] buffer,
      int offset,
      int size,
      ref SocketFlags socketFlags,
      ref EndPoint remoteEP,
      out IPPacketInformation ipPacketInformation)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      throw new NotImplementedException();
    }

    /// <summary>
    ///   開始以非同步方式接收資料的位元組數到指定的位置，以使用指定的資料緩衝區 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.SocketFlags" />, ，並儲存端點和封包資訊。
    /// </summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可以是 null。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    /// </exception>
    [MonoTODO("Not implemented")]
    public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      throw new NotImplementedException();
    }

    /// <summary>
    ///   開始以非同步方式接收資料的位元組數到指定的位置，使用指定的資料緩衝區 <see cref="T:System.Net.Sockets.SocketFlags" />, ，並儲存端點和封包資訊...
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> 也就是接收資料的儲存位置。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 參數，來儲存資料。
    /// </param>
    /// <param name="size">要接收的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料來源。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步讀取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統是 Windows 2000 或更早版本，此方法需要 Windows XP。
    /// </exception>
    [MonoTODO]
    public IAsyncResult BeginReceiveMessageFrom(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      ref EndPoint remoteEP,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      throw new NotImplementedException();
    }

    /// <summary>
    ///   結束暫止的非同步讀取從指定的端點。
    ///    這個方法也會顯示在比封包的詳細資訊 <see cref="M:System.Net.Sockets.Socket.EndReceiveFrom(System.IAsyncResult,System.Net.EndPoint@)" />。
    /// </summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <param name="socketFlags">
    ///   位元組合 <see cref="T:System.Net.Sockets.SocketFlags" /> 收到的封包的值。
    /// </param>
    /// <param name="endPoint">
    ///   來源 <see cref="T:System.Net.EndPoint" />。
    /// </param>
    /// <param name="ipPacketInformation">
    ///   <see cref="T:System.Net.IPAddress" /> 和收到的封包的介面。
    /// </param>
    /// <returns>
    ///   如果成功，接收的位元組數目。
    ///    如果不成功，則傳回 0。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 是 <see langword="null" />
    /// 
    ///   -或-
    /// 
    ///   <paramref name="endPoint" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint@,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> 先前已呼叫的非同步讀取。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [MonoTODO]
    public int EndReceiveMessageFrom(
      IAsyncResult asyncResult,
      ref SocketFlags socketFlags,
      ref EndPoint endPoint,
      out IPPacketInformation ipPacketInformation)
    {
      this.ThrowIfDisposedAndClosed();
      if (endPoint == null)
        throw new ArgumentNullException(nameof (endPoint));
      this.ValidateEndIAsyncResult(asyncResult, nameof (EndReceiveMessageFrom), nameof (asyncResult));
      throw new NotImplementedException();
    }

    /// <summary>
    ///   將指定的數個位元組的資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />, ，從指定位移開始，並使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">要開始傳送資料的資料緩衝區中的位置。</param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   在存取時發生作業系統錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public unsafe int Send(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (size == 0)
      {
        errorCode = SocketError.Success;
        return 0;
      }
      int num = 0;
      do
      {
        int error;
        fixed (byte* numPtr = buffer)
          num += Socket.Send_internal(this.m_Handle, numPtr + (offset + num), size - num, socketFlags, out error, this.is_blocking);
        errorCode = (SocketError) error;
        if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
        {
          this.is_connected = false;
          this.is_bound = false;
          break;
        }
        this.is_connected = true;
      }
      while (num < size);
      return num;
    }

    /// <summary>
    ///   將緩衝區的集清單中的連接 <see cref="T:System.Net.Sockets.Socket" />, ，使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffers">
    ///   一份 <see cref="T:System.ArraySegment`1" />s 型別的 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>
    ///   若要傳送的位元組數目 <see cref="T:System.Net.Sockets.Socket" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="buffers" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [CLSCompliant(false)]
    public unsafe int Send(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      if (buffers == null)
        throw new ArgumentNullException(nameof (buffers));
      int count = buffers.Count != 0 ? buffers.Count : throw new ArgumentException("Buffer is empty", nameof (buffers));
      GCHandle[] gcHandleArray = new GCHandle[count];
      int error;
      int num;
      try
      {
        fixed (Socket.WSABUF* bufarray = new Socket.WSABUF[count])
        {
          for (int index = 0; index < count; ++index)
          {
            ArraySegment<byte> buffer = buffers[index];
            if (buffer.Offset >= 0 && buffer.Count >= 0)
            {
              if (buffer.Count <= buffer.Array.Length - buffer.Offset)
              {
                try
                {
                }
                finally
                {
                  gcHandleArray[index] = GCHandle.Alloc((object) buffer.Array, GCHandleType.Pinned);
                }
                bufarray[index].len = buffer.Count;
                bufarray[index].buf = Marshal.UnsafeAddrOfPinnedArrayElement<byte>((M0[]) buffer.Array, buffer.Offset);
                continue;
              }
            }
            throw new ArgumentOutOfRangeException("segment");
          }
          num = Socket.Send_internal(this.m_Handle, bufarray, count, socketFlags, out error, this.is_blocking);
        }
      }
      finally
      {
        for (int index = 0; index < count; ++index)
        {
          if (gcHandleArray[index].IsAllocated)
            gcHandleArray[index].Free();
        }
      }
      errorCode = (SocketError) error;
      return num;
    }

    /// <summary>
    ///   以非同步方式將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    /// </summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> 或 <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> 屬性 <paramref name="e" /> 參數必須參考正確的緩衝區。
    ///    一個或另一個屬性可能設定，但不是能同時在相同的時間。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 尚未連線或未取得透過 <see cref="M:System.Net.Sockets.Socket.Accept" />, ，<see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" />,，或 <see cref="Overload:System.Net.Sockets.Socket.BeginAccept" />, ，方法。
    /// </exception>
    public bool SendAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (e.Buffer == null && e.BufferList == null)
        throw new NullReferenceException("Either e.Buffer or e.BufferList must be valid buffers.");
      if (e.Buffer == null)
      {
        this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, (object) e, SocketOperation.SendGeneric);
        e.socket_async_result.Buffers = e.BufferList;
        this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginSendGenericCallback, (IOAsyncResult) e.socket_async_result));
      }
      else
      {
        this.InitSocketAsyncEventArgs(e, Socket.SendAsyncCallback, (object) e, SocketOperation.Send);
        e.socket_async_result.Buffer = e.Buffer;
        e.socket_async_result.Offset = e.Offset;
        e.socket_async_result.Size = e.Count;
        this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendCallback((SocketAsyncResult) s, 0)), (IOAsyncResult) e.socket_async_result));
      }
      return true;
    }

    /// <summary>
    ///   以非同步方式將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 中要開始傳送資料的參數。
    /// </param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度小於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public IAsyncResult BeginSend(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      out SocketError errorCode,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (!this.is_connected)
      {
        errorCode = SocketError.NotConnected;
        return (IAsyncResult) null;
      }
      errorCode = SocketError.Success;
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.Send)
      {
        Buffer = buffer,
        Offset = offset,
        Size = size,
        SockFlags = socketFlags
      };
      this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendCallback((SocketAsyncResult) s, 0)), (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    private static unsafe void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
    {
      int num = 0;
      try
      {
        fixed (byte* numPtr = sockares.Buffer)
          num = Socket.Send_internal(sockares.socket.m_Handle, numPtr + sockares.Offset, sockares.Size, sockares.SockFlags, out sockares.error, false);
      }
      catch (Exception ex)
      {
        sockares.Complete(ex);
        return;
      }
      if (sockares.error == 0)
      {
        sent_so_far += num;
        sockares.Offset += num;
        sockares.Size -= num;
        if (sockares.socket.CleanedUp)
        {
          sockares.Complete(sent_so_far);
          return;
        }
        if (sockares.Size > 0)
        {
          IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendCallback((SocketAsyncResult) s, sent_so_far)), (IOAsyncResult) sockares));
          return;
        }
        sockares.Total = sent_so_far;
      }
      sockares.Complete(sent_so_far);
    }

    /// <summary>
    ///   以非同步方式將資料傳送至連接 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="buffers">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffers" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="buffers" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    [CLSCompliant(false)]
    public IAsyncResult BeginSend(
      IList<ArraySegment<byte>> buffers,
      SocketFlags socketFlags,
      out SocketError errorCode,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (buffers == null)
        throw new ArgumentNullException(nameof (buffers));
      if (!this.is_connected)
      {
        errorCode = SocketError.NotConnected;
        return (IAsyncResult) null;
      }
      errorCode = SocketError.Success;
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.SendGeneric)
      {
        Buffers = buffers,
        SockFlags = socketFlags
      };
      this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, Socket.BeginSendGenericCallback, (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    /// <summary>結束暫止的非同步傳送。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 會儲存此非同步作業的狀態資訊。
    /// </param>
    /// <param name="errorCode">
    ///   A <see cref="T:System.Net.Sockets.SocketError" /> 物件，其中儲存通訊端錯誤。
    /// </param>
    /// <returns>
    ///   如果成功，位元組數傳送至 <see cref="T:System.Net.Sockets.Socket" />，否則無效 <see cref="T:System.Net.Sockets.Socket" /> 錯誤。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> 先前已呼叫非同步傳送。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndSend), nameof (asyncResult));
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      errorCode = socketAsyncResult.ErrorCode;
      if (errorCode != SocketError.Success && errorCode != SocketError.WouldBlock && errorCode != SocketError.InProgress)
        this.is_connected = false;
      if (errorCode == SocketError.Success)
        socketAsyncResult.CheckIfThrowDelayedException();
      return socketAsyncResult.Total;
    }

    private static unsafe int Send_internal(
      SafeSocketHandle safeHandle,
      Socket.WSABUF* bufarray,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.Send_internal(safeHandle.DangerousGetHandle(), bufarray, count, flags, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int Send_internal(
      IntPtr sock,
      Socket.WSABUF* bufarray,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking);

    private static unsafe int Send_internal(
      SafeSocketHandle safeHandle,
      byte* buffer,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.Send_internal(safeHandle.DangerousGetHandle(), buffer, count, flags, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int Send_internal(
      IntPtr sock,
      byte* buffer,
      int count,
      SocketFlags flags,
      out int error,
      bool blocking);

    /// <summary>
    ///   將指定的數個位元組的資料傳送至指定的端點，在緩衝區中指定的位置開始，並使用指定 <see cref="T:System.Net.Sockets.SocketFlags" />。
    /// </summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">要開始傳送資料的資料緩衝區中的位置。</param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表資料的目的地位置。
    /// </param>
    /// <returns>已傳送的位元組數。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="socketFlags" /> 不是有效的值組合。
    /// 
    ///   -或-
    /// 
    ///   在存取時發生作業系統錯誤 <see cref="T:System.Net.Sockets.Socket" />。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public unsafe int SendTo(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      EndPoint remoteEP)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      if (remoteEP == null)
        throw new ArgumentNullException(nameof (remoteEP));
      int error;
      int num;
      fixed (byte* numPtr = buffer)
        num = Socket.SendTo_internal(this.m_Handle, numPtr + offset, size, socketFlags, remoteEP.Serialize(), out error, this.is_blocking);
      switch ((SocketError) error)
      {
        case SocketError.Success:
          this.is_connected = true;
          this.is_bound = true;
          this.seed_endpoint = remoteEP;
          return num;
        case SocketError.WouldBlock:
        case SocketError.InProgress:
          throw new SocketException(error);
        default:
          this.is_connected = false;
          goto case SocketError.WouldBlock;
      }
    }

    /// <summary>以非同步方式傳送資料至特定的遠端主機。</summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> 不可以是 null。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   指定的通訊協定是連線導向，但 <see cref="T:System.Net.Sockets.Socket" /> 尚未連線。
    /// </exception>
    public bool SendToAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      if (e.BufferList != null)
        throw new NotSupportedException("Mono doesn't support using BufferList at this point.");
      if (e.RemoteEndPoint == null)
        throw new ArgumentNullException("remoteEP", "Value cannot be null.");
      this.InitSocketAsyncEventArgs(e, Socket.SendToAsyncCallback, (object) e, SocketOperation.SendTo);
      e.socket_async_result.Buffer = e.Buffer;
      e.socket_async_result.Offset = e.Offset;
      e.socket_async_result.Size = e.Count;
      e.socket_async_result.SockFlags = e.SocketFlags;
      e.socket_async_result.EndPoint = e.RemoteEndPoint;
      this.QueueIOSelectorJob(this.WriteSem, e.socket_async_result.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendToCallback((SocketAsyncResult) s, 0)), (IOAsyncResult) e.socket_async_result));
      return true;
    }

    /// <summary>以非同步方式傳送資料至特定的遠端主機。</summary>
    /// <param name="buffer">
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含要傳送的資料。
    /// </param>
    /// <param name="offset">
    ///   中以零為起始的位置 <paramref name="buffer" /> 中要開始傳送資料。
    /// </param>
    /// <param name="size">要傳送的位元組數目。</param>
    /// <param name="socketFlags">
    ///   <see cref="T:System.Net.Sockets.SocketFlags" /> 值的位元組合。
    /// </param>
    /// <param name="remoteEP">
    ///   <see cref="T:System.Net.EndPoint" /> ，代表在遠端裝置。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 委派。
    /// </param>
    /// <param name="state">物件，包含這個要求的狀態資訊。</param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 會參考非同步傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="buffer" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="remoteEP" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="offset" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="offset" /> 長度大於 <paramref name="buffer" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="size" /> 長度大於 <paramref name="buffer" /> 值減去 <paramref name="offset" /> 參數。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   在呼叫堆疊中位置較高的呼叫端對於要求的作業沒有權限。
    /// </exception>
    public IAsyncResult BeginSendTo(
      byte[] buffer,
      int offset,
      int size,
      SocketFlags socketFlags,
      EndPoint remoteEP,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      this.ThrowIfBufferNull(buffer);
      this.ThrowIfBufferOutOfRange(buffer, offset, size);
      SocketAsyncResult socketAsyncResult = new SocketAsyncResult(this, callback, state, SocketOperation.SendTo)
      {
        Buffer = buffer,
        Offset = offset,
        Size = size,
        SockFlags = socketFlags,
        EndPoint = remoteEP
      };
      this.QueueIOSelectorJob(this.WriteSem, socketAsyncResult.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendToCallback((SocketAsyncResult) s, 0)), (IOAsyncResult) socketAsyncResult));
      return (IAsyncResult) socketAsyncResult;
    }

    private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far)
    {
      try
      {
        int num = sockares.socket.SendTo(sockares.Buffer, sockares.Offset, sockares.Size, sockares.SockFlags, sockares.EndPoint);
        if (sockares.error == 0)
        {
          sent_so_far += num;
          sockares.Offset += num;
          sockares.Size -= num;
        }
        if (sockares.Size > 0)
        {
          IOSelector.Add(sockares.Handle, new IOSelectorJob(IOOperation.Write, (IOAsyncCallback) (s => Socket.BeginSendToCallback((SocketAsyncResult) s, sent_so_far)), (IOAsyncResult) sockares));
          return;
        }
        sockares.Total = sent_so_far;
      }
      catch (Exception ex)
      {
        sockares.Complete(ex);
        return;
      }
      sockares.Complete();
    }

    /// <summary>結束暫止的非同步傳送至特定位置。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 儲存狀態資訊和針對此非同步作業的任何使用者定義資料。
    /// </param>
    /// <returns>
    ///   如果成功，傳送的數個位元組;否則，無效 <see cref="T:System.Net.Sockets.Socket" /> 錯誤。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginSendTo(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.Net.EndPoint,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndSendTo(System.IAsyncResult)" /> 先前已呼叫非同步傳送。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public int EndSendTo(IAsyncResult asyncResult)
    {
      this.ThrowIfDisposedAndClosed();
      SocketAsyncResult socketAsyncResult = this.ValidateEndIAsyncResult(asyncResult, nameof (EndSendTo), "result");
      if (!socketAsyncResult.IsCompleted)
        socketAsyncResult.AsyncWaitHandle.WaitOne();
      socketAsyncResult.CheckIfThrowDelayedException();
      return socketAsyncResult.Total;
    }

    private static unsafe int SendTo_internal(
      SafeSocketHandle safeHandle,
      byte* buffer,
      int count,
      SocketFlags flags,
      SocketAddress sa,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.SendTo_internal(safeHandle.DangerousGetHandle(), buffer, count, flags, sa, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern unsafe int SendTo_internal(
      IntPtr sock,
      byte* buffer,
      int count,
      SocketFlags flags,
      SocketAddress sa,
      out int error,
      bool blocking);

    /// <summary>
    ///   使用指定的 <see cref="T:System.Net.Sockets.TransmitFileOptions" /> 值，將檔案 <paramref name="fileName" /> 和資料緩衝區傳送到連接的 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    /// </summary>
    /// <param name="fileName">
    ///   包含要傳送之檔案的路徑與名稱的 <see cref="T:System.String" />。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="preBuffer">
    ///   包含傳送檔案前要傳送之資料的 <see cref="T:System.Byte" /> 陣列。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="postBuffer">
    ///   包含傳送檔案後要傳送之資料的 <see cref="T:System.Byte" /> 陣列。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="flags">
    ///   一或多個 <see cref="T:System.Net.Sockets.TransmitFileOptions" /> 值。
    /// </param>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統不是 Windows NT 或更新版本。
    /// 
    ///   -或-
    /// 
    ///   通訊端未連線至遠端主機。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" />物件已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件不是處於封鎖模式，而且無法接受此同步呼叫。
    /// </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///   找不到檔案 <paramref name="fileName" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public void SendFile(
      string fileName,
      byte[] preBuffer,
      byte[] postBuffer,
      TransmitFileOptions flags)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_connected)
        throw new NotSupportedException();
      if (!this.is_blocking)
        throw new InvalidOperationException();
      int error = 0;
      if (Socket.SendFile_internal(this.m_Handle, fileName, preBuffer, postBuffer, flags, out error, this.is_blocking) && error == 0)
        return;
      SocketException socketException = new SocketException(error);
      if (socketException.ErrorCode == 2 || socketException.ErrorCode == 3)
        throw new FileNotFoundException();
      throw socketException;
    }

    /// <summary>
    ///   已連線到以非同步方式傳送的檔案和資料的緩衝區 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    /// </summary>
    /// <param name="fileName">
    ///   字串，包含要傳送之檔案的名稱與路徑。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="preBuffer">
    ///   A <see cref="T:System.Byte" /> 陣列，其中包含要傳送檔案之前傳送的資料。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="postBuffer">
    ///   A <see cref="T:System.Byte" /> 陣列，其中包含要傳送檔案之後，傳送資料。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="flags">
    ///   位元組合 <see cref="T:System.Net.Sockets.TransmitFileOptions" /> 值。
    /// </param>
    /// <param name="callback">
    ///   <see cref="T:System.AsyncCallback" /> 這項作業完成時要叫用委派。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <param name="state">
    ///   使用者定義的物件，其中包含這個要求的狀態資訊。
    ///    這個參數可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.IAsyncResult" /> 物件，表示非同步作業。
    /// </returns>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   作業系統不是 Windows NT 或更新版本。
    /// 
    ///   -或-
    /// 
    ///   通訊端未連線至遠端主機。
    /// </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///   檔案 <paramref name="fileName" /> 找不到。
    /// </exception>
    public IAsyncResult BeginSendFile(
      string fileName,
      byte[] preBuffer,
      byte[] postBuffer,
      TransmitFileOptions flags,
      AsyncCallback callback,
      object state)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_connected)
        throw new NotSupportedException();
      if (!System.IO.File.Exists(fileName))
        throw new FileNotFoundException();
      Socket.SendFileHandler handler = new Socket.SendFileHandler(this.SendFile);
      return (IAsyncResult) new Socket.SendFileAsyncResult(handler, handler.BeginInvoke(fileName, preBuffer, postBuffer, flags, (AsyncCallback) (ar => callback((IAsyncResult) new Socket.SendFileAsyncResult(handler, ar))), state));
    }

    /// <summary>結束暫止的非同步傳送的檔案。</summary>
    /// <param name="asyncResult">
    ///   <see cref="T:System.IAsyncResult" /> 物件，其中儲存此非同步作業的狀態資訊。
    /// </param>
    /// <exception cref="T:System.NotSupportedException">
    ///   這個方法需要 Windows NT。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="asyncResult" /> 是空的。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="asyncResult" /> 所以不會傳回呼叫 <see cref="M:System.Net.Sockets.Socket.BeginSendFile(System.String,System.AsyncCallback,System.Object)" /> 方法。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <see cref="M:System.Net.Sockets.Socket.EndSendFile(System.IAsyncResult)" /> 之前已呼叫的非同步 <see cref="M:System.Net.Sockets.Socket.BeginSendFile(System.String,System.AsyncCallback,System.Object)" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    請參閱 &lt; 備註 &gt; 一節。
    /// </exception>
    public void EndSendFile(IAsyncResult asyncResult)
    {
      this.ThrowIfDisposedAndClosed();
      if (asyncResult == null)
        throw new ArgumentNullException(nameof (asyncResult));
      if (!(asyncResult is Socket.SendFileAsyncResult sendFileAsyncResult))
        throw new ArgumentException("Invalid IAsyncResult", nameof (asyncResult));
      sendFileAsyncResult.Delegate.EndInvoke(sendFileAsyncResult.Original);
    }

    private static bool SendFile_internal(
      SafeSocketHandle safeHandle,
      string filename,
      byte[] pre_buffer,
      byte[] post_buffer,
      TransmitFileOptions flags,
      out int error,
      bool blocking)
    {
      try
      {
        safeHandle.RegisterForBlockingSyscall();
        return Socket.SendFile_internal(safeHandle.DangerousGetHandle(), filename, pre_buffer, post_buffer, flags, out error, blocking);
      }
      finally
      {
        safeHandle.UnRegisterForBlockingSyscall();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool SendFile_internal(
      IntPtr sock,
      string filename,
      byte[] pre_buffer,
      byte[] post_buffer,
      TransmitFileOptions flags,
      out int error,
      bool blocking);

    /// <summary>
    ///   以非同步的方式來連接傳送的檔案，或在記憶體中集合資料緩衝區 <see cref="T:System.Net.Sockets.Socket" /> 物件。
    /// </summary>
    /// <param name="e">
    ///   <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 要用於這個非同步通訊端作業的物件。
    /// </param>
    /// <returns>
    ///   傳回 <see langword="true" /> 如果 I/O 作業正在擱置中。
    ///   <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 作業完成之後，便產生參數。
    /// 
    ///   傳回 <see langword="false" /> 如果同步 I/O 作業完成。
    ///    在此情況下， <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> 事件 <paramref name="e" /> 參數不會引發和 <paramref name="e" /> 物件傳遞為參數來擷取作業的結果的方法呼叫傳回之後，立即可以檢查。
    /// </returns>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///   中指定的檔案 <see cref="P:System.Net.Sockets.SendPacketsElement.FilePath" /> 找不到屬性。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   通訊端作業已在使用進度 <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> 中指定的物件 <paramref name="e" /> 參數。
    /// </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///   Windows XP 或以上的版本，此方法。
    ///    如果，也會發生這個例外狀況 <see cref="T:System.Net.Sockets.Socket" /> 未連線至遠端主機。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   無連接 <see cref="T:System.Net.Sockets.Socket" /> 正在使用，並將檔案傳送超過基礎傳輸的最大的封包大小。
    /// </exception>
    [MonoTODO("Not implemented")]
    public bool SendPacketsAsync(SocketAsyncEventArgs e)
    {
      this.ThrowIfDisposedAndClosed();
      throw new NotImplementedException();
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool Duplicate_internal(
      IntPtr handle,
      int targetProcessId,
      out IntPtr duplicateHandle,
      out MonoIOError error);

    /// <summary>複製通訊端參考的目標處理序，然後關閉此處理序通訊端。</summary>
    /// <param name="targetProcessId">建立重複的通訊端的參考位置的目標處理序識別碼。</param>
    /// <returns>通訊端參考傳遞至目標處理序。</returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   <paramref name="targetProcessID" /> 不是有效的處理序識別碼。
    /// 
    ///   -或-
    /// 
    ///   無法複製通訊端參考。
    /// </exception>
    [MonoLimitation("We do not support passing sockets across processes, we merely allow this API to pass the socket across AppDomains")]
    public SocketInformation DuplicateAndClose(int targetProcessId)
    {
      SocketInformation socketInformation = new SocketInformation();
      socketInformation.Options = (SocketInformationOptions) ((this.is_listening ? 4 : 0) | (this.is_connected ? 2 : 0) | (this.is_blocking ? 0 : 1) | (this.useOverlappedIO ? 8 : 0));
      IntPtr duplicateHandle;
      MonoIOError error;
      if (!Socket.Duplicate_internal(this.Handle, targetProcessId, out duplicateHandle, out error))
        throw MonoIO.GetException(error);
      socketInformation.ProtocolInformation = DataConverter.Pack("iiiil", new object[5]
      {
        (object) (int) this.addressFamily,
        (object) (int) this.socketType,
        (object) (int) this.protocolType,
        (object) (this.is_bound ? 1 : 0),
        (object) (long) duplicateHandle
      });
      this.m_Handle = (SafeSocketHandle) null;
      return socketInformation;
    }

    /// <summary>
    ///   傳回指定 <see cref="T:System.Net.Sockets.Socket" /> 選項設定值，表示為位元組陣列。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionValue">
    ///   型別的陣列 <see cref="T:System.Byte" /> 要接收的選項設定。
    /// </param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// 
    ///   -或-
    /// 
    ///   在.NET Compact Framework 應用程式，Windows CE 預設的緩衝區空間設定為 32768 個位元組。
    ///    您可以變更每個通訊端緩衝區空間，藉由呼叫 <see cref="Overload:System.Net.Sockets.Socket.SetSocketOption" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void GetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      byte[] optionValue)
    {
      this.ThrowIfDisposedAndClosed();
      if (optionValue == null)
        throw new SocketException(10014, "Error trying to dereference an invalid pointer");
      int error;
      Socket.GetSocketOption_arr_internal(this.m_Handle, optionLevel, optionName, ref optionValue, out error);
      if (error != 0)
        throw new SocketException(error);
    }

    /// <summary>
    ///   傳回指定之值 <see cref="T:System.Net.Sockets.Socket" /> 陣列中的選項。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionLength">預期的傳回值的長度，單位為位元組。</param>
    /// <returns>
    ///   型別的陣列 <see cref="T:System.Byte" /> ，其中包含通訊端選項的值。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// 
    ///   -或-
    /// 
    ///   在.NET Compact Framework 應用程式，Windows CE 預設的緩衝區空間設定為 32768 個位元組。
    ///    您可以變更每個通訊端緩衝區空間，藉由呼叫 <see cref="Overload:System.Net.Sockets.Socket.SetSocketOption" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public byte[] GetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      int optionLength)
    {
      this.ThrowIfDisposedAndClosed();
      byte[] byte_val = new byte[optionLength];
      int error;
      Socket.GetSocketOption_arr_internal(this.m_Handle, optionLevel, optionName, ref byte_val, out error);
      if (error != 0)
        throw new SocketException(error);
      return byte_val;
    }

    /// <summary>
    ///   傳回指定的值 <see cref="T:System.Net.Sockets.Socket" /> 選項，表示為物件。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <returns>
    ///   物件，表示選項的值。
    ///    當 <paramref name="optionName" /> 參數設為 <see cref="F:System.Net.Sockets.SocketOptionName.Linger" /> 的傳回值是執行個體 <see cref="T:System.Net.Sockets.LingerOption" /> 類別。
    ///    當 <paramref name="optionName" /> 設為 <see cref="F:System.Net.Sockets.SocketOptionName.AddMembership" /> 或 <see cref="F:System.Net.Sockets.SocketOptionName.DropMembership" />, ，則傳回值是執行個體 <see cref="T:System.Net.Sockets.MulticastOption" /> 類別。
    ///    當 <paramref name="optionName" /> 是任何其他值，則傳回值是整數。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="optionName" /> 已設定為不支援的值 <see cref="F:System.Net.Sockets.SocketOptionName.MaxConnections" />。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
    {
      this.ThrowIfDisposedAndClosed();
      object obj_val;
      int error;
      Socket.GetSocketOption_obj_internal(this.m_Handle, optionLevel, optionName, out obj_val, out error);
      if (error != 0)
        throw new SocketException(error);
      switch (optionName)
      {
        case SocketOptionName.AddMembership:
        case SocketOptionName.DropMembership:
          return (object) (MulticastOption) obj_val;
        case SocketOptionName.Linger:
          return (object) (LingerOption) obj_val;
        default:
          return obj_val is int num ? (object) num : obj_val;
      }
    }

    private static void GetSocketOption_arr_internal(
      SafeSocketHandle safeHandle,
      SocketOptionLevel level,
      SocketOptionName name,
      ref byte[] byte_val,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.GetSocketOption_arr_internal(safeHandle.DangerousGetHandle(), level, name, ref byte_val, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSocketOption_arr_internal(
      IntPtr socket,
      SocketOptionLevel level,
      SocketOptionName name,
      ref byte[] byte_val,
      out int error);

    private static void GetSocketOption_obj_internal(
      SafeSocketHandle safeHandle,
      SocketOptionLevel level,
      SocketOptionName name,
      out object obj_val,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.GetSocketOption_obj_internal(safeHandle.DangerousGetHandle(), level, name, out obj_val, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSocketOption_obj_internal(
      IntPtr socket,
      SocketOptionLevel level,
      SocketOptionName name,
      out object obj_val,
      out int error);

    /// <summary>
    ///   設定指定 <see cref="T:System.Net.Sockets.Socket" /> 選項以指定的值，表示為位元組陣列。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionValue">
    ///   型別的陣列 <see cref="T:System.Byte" /> 表示選項的值。
    /// </param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void SetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      byte[] optionValue)
    {
      this.ThrowIfDisposedAndClosed();
      if (optionValue == null)
        throw new SocketException(10014, "Error trying to dereference an invalid pointer");
      int error;
      Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) null, optionValue, 0, out error);
      if (error == 0)
        return;
      if (error == 10022)
        throw new ArgumentException();
      throw new SocketException(error);
    }

    /// <summary>
    ///   設定指定 <see cref="T:System.Net.Sockets.Socket" /> 選項以指定的值，表示為物件。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionValue">
    ///   A <see cref="T:System.Net.Sockets.LingerOption" /> 或 <see cref="T:System.Net.Sockets.MulticastOption" /> ，其中包含選項的值。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="optionValue" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void SetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      object optionValue)
    {
      this.ThrowIfDisposedAndClosed();
      if (optionValue == null)
        throw new ArgumentNullException(nameof (optionValue));
      int error;
      if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
      {
        if (!(optionValue is LingerOption lingerOption))
          throw new ArgumentException("A 'LingerOption' value must be specified.", nameof (optionValue));
        Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) lingerOption, (byte[]) null, 0, out error);
      }
      else if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
      {
        if (!(optionValue is MulticastOption multicastOption))
          throw new ArgumentException("A 'MulticastOption' value must be specified.", nameof (optionValue));
        Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) multicastOption, (byte[]) null, 0, out error);
      }
      else
      {
        if (optionLevel != SocketOptionLevel.IPv6 || optionName != SocketOptionName.AddMembership && optionName != SocketOptionName.DropMembership)
          throw new ArgumentException("Invalid value specified.", nameof (optionValue));
        if (!(optionValue is IPv6MulticastOption ipv6MulticastOption))
          throw new ArgumentException("A 'IPv6MulticastOption' value must be specified.", nameof (optionValue));
        Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) ipv6MulticastOption, (byte[]) null, 0, out error);
      }
      if (error == 0)
        return;
      if (error == 10022)
        throw new ArgumentException();
      throw new SocketException(error);
    }

    /// <summary>
    ///   設定指定 <see cref="T:System.Net.Sockets.Socket" /> 選項來指定 <see cref="T:System.Boolean" /> 值。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionValue">
    ///   選項的值表示為 <see cref="T:System.Boolean" />。
    /// </param>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 物件已關閉。
    /// </exception>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    public void SetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      bool optionValue)
    {
      int optionValue1 = optionValue ? 1 : 0;
      this.SetSocketOption(optionLevel, optionName, optionValue1);
    }

    /// <summary>
    ///   設定指定 <see cref="T:System.Net.Sockets.Socket" /> 選項指定的整數值。
    /// </summary>
    /// <param name="optionLevel">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionLevel" /> 值。
    /// </param>
    /// <param name="optionName">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketOptionName" /> 值。
    /// </param>
    /// <param name="optionValue">選項的值。</param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void SetSocketOption(
      SocketOptionLevel optionLevel,
      SocketOptionName optionName,
      int optionValue)
    {
      this.ThrowIfDisposedAndClosed();
      int error;
      Socket.SetSocketOption_internal(this.m_Handle, optionLevel, optionName, (object) null, (byte[]) null, optionValue, out error);
      if (error == 0)
        return;
      if (error == 10022)
        throw new ArgumentException();
      throw new SocketException(error);
    }

    private static void SetSocketOption_internal(
      SafeSocketHandle safeHandle,
      SocketOptionLevel level,
      SocketOptionName name,
      object obj_val,
      byte[] byte_val,
      int int_val,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.SetSocketOption_internal(safeHandle.DangerousGetHandle(), level, name, obj_val, byte_val, int_val, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetSocketOption_internal(
      IntPtr socket,
      SocketOptionLevel level,
      SocketOptionName name,
      object obj_val,
      byte[] byte_val,
      int int_val,
      out int error);

    /// <summary>
    ///   設定低層級作業模式 <see cref="T:System.Net.Sockets.Socket" /> 使用數值控制碼。
    /// </summary>
    /// <param name="ioControlCode">
    ///   <see cref="T:System.Int32" /> 值，指定要執行之作業的控制碼。
    /// </param>
    /// <param name="optionInValue">
    ///   A <see cref="T:System.Byte" /> 陣列，其中包含作業所需的輸入的資料。
    /// </param>
    /// <param name="optionOutValue">
    ///   A <see cref="T:System.Byte" /> 陣列，其中包含作業所傳回的輸出資料。
    /// </param>
    /// <returns>
    ///   中的位元組數目 <paramref name="optionOutValue" /> 參數。
    /// </returns>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   嘗試變更封鎖的模式，而不需使用 <see cref="P:System.Net.Sockets.Socket.Blocking" /> 屬性。
    /// </exception>
    /// <exception cref="T:System.Security.SecurityException">
    ///   呼叫堆疊中的呼叫端沒有必要的權限。
    /// </exception>
    public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
    {
      if (this.CleanedUp)
        throw new ObjectDisposedException(this.GetType().ToString());
      int error;
      int num = Socket.IOControl_internal(this.m_Handle, ioControlCode, optionInValue, optionOutValue, out error);
      if (error != 0)
        throw new SocketException(error);
      return num != -1 ? num : throw new InvalidOperationException("Must use Blocking property instead.");
    }

    private static int IOControl_internal(
      SafeSocketHandle safeHandle,
      int ioctl_code,
      byte[] input,
      byte[] output,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        return Socket.IOControl_internal(safeHandle.DangerousGetHandle(), ioctl_code, input, output, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int IOControl_internal(
      IntPtr sock,
      int ioctl_code,
      byte[] input,
      byte[] output,
      out int error);

    /// <summary>
    ///   關閉 <see cref="T:System.Net.Sockets.Socket" /> 連接並釋放所有相關資源。
    /// </summary>
    public void Close()
    {
      this.linger_timeout = 0;
      this.Dispose();
    }

    /// <summary>
    ///   關閉 <see cref="T:System.Net.Sockets.Socket" /> 連線，並釋放所有具指定逾時的關聯資源，以允許傳送佇列的資料。
    /// </summary>
    /// <param name="timeout">
    ///   最多等候 <paramref name="timeout" /> 秒以傳送任何剩餘的資料，然後關閉通訊端。
    /// </param>
    public void Close(int timeout)
    {
      this.linger_timeout = timeout;
      this.Dispose();
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Close_internal(IntPtr socket, out int error);

    /// <summary>
    ///   停用傳送和接收上 <see cref="T:System.Net.Sockets.Socket" />。
    /// </summary>
    /// <param name="how">
    ///   其中一個 <see cref="T:System.Net.Sockets.SocketShutdown" /> 值，指定將不再允許的作業。
    /// </param>
    /// <exception cref="T:System.Net.Sockets.SocketException">
    ///   嘗試存取通訊端時發生錯誤。
    ///    如需詳細資訊，請參閱＜備註＞一節。
    /// </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///   <see cref="T:System.Net.Sockets.Socket" /> 已關閉。
    /// </exception>
    public void Shutdown(SocketShutdown how)
    {
      this.ThrowIfDisposedAndClosed();
      if (!this.is_connected)
        throw new SocketException(10057);
      int error;
      Socket.Shutdown_internal(this.m_Handle, how, out error);
      if (error != 0)
        throw new SocketException(error);
    }

    private static void Shutdown_internal(
      SafeSocketHandle safeHandle,
      SocketShutdown how,
      out int error)
    {
      bool success = false;
      try
      {
        safeHandle.DangerousAddRef(ref success);
        Socket.Shutdown_internal(safeHandle.DangerousGetHandle(), how, out error);
      }
      finally
      {
        if (success)
          safeHandle.DangerousRelease();
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error);

    /// <summary>
    ///   釋放 <see cref="T:System.Net.Sockets.Socket" /> 所使用的 Unmanaged 資源，並選擇性處置 Managed 資源。
    /// </summary>
    /// <param name="disposing">
    ///   <see langword="true" /> 表示會同時釋放 Managed 和 Unmanaged 資源；<see langword="false" /> 則表示只釋放 Unmanaged 資源。
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
      if (this.CleanedUp)
        return;
      this.m_IntCleanedUp = 1;
      bool isConnected = this.is_connected;
      this.is_connected = false;
      if (this.m_Handle == null)
        return;
      this.is_closed = true;
      IntPtr handle = this.Handle;
      if (isConnected)
        this.Linger(handle);
      this.m_Handle.Dispose();
    }

    private void Linger(IntPtr handle)
    {
      if (!this.is_connected || this.linger_timeout <= 0)
        return;
      int error;
      Socket.Shutdown_internal(handle, SocketShutdown.Receive, out error);
      if (error != 0)
        return;
      int seconds = this.linger_timeout / 1000;
      int num = this.linger_timeout % 1000;
      if (num > 0)
      {
        Socket.Poll_internal(handle, SelectMode.SelectRead, num * 1000, out error);
        if (error != 0)
          return;
      }
      if (seconds <= 0)
        return;
      LingerOption lingerOption = new LingerOption(true, seconds);
      Socket.SetSocketOption_internal(handle, SocketOptionLevel.Socket, SocketOptionName.Linger, (object) lingerOption, (byte[]) null, 0, out error);
    }

    private void ThrowIfDisposedAndClosed(Socket socket)
    {
      if (socket.CleanedUp && socket.is_closed)
        throw new ObjectDisposedException(socket.GetType().ToString());
    }

    private void ThrowIfDisposedAndClosed()
    {
      if (this.CleanedUp && this.is_closed)
        throw new ObjectDisposedException(this.GetType().ToString());
    }

    private void ThrowIfBufferNull(byte[] buffer)
    {
      if (buffer == null)
        throw new ArgumentNullException(nameof (buffer));
    }

    private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
    {
      if (offset < 0)
        throw new ArgumentOutOfRangeException(nameof (offset), "offset must be >= 0");
      if (offset > buffer.Length)
        throw new ArgumentOutOfRangeException(nameof (offset), "offset must be <= buffer.Length");
      if (size < 0)
        throw new ArgumentOutOfRangeException(nameof (size), "size must be >= 0");
      if (size > buffer.Length - offset)
        throw new ArgumentOutOfRangeException(nameof (size), "size must be <= buffer.Length - offset");
    }

    private void ThrowIfUdp()
    {
      if (this.protocolType == ProtocolType.Udp)
        throw new SocketException(10042);
    }

    private SocketAsyncResult ValidateEndIAsyncResult(
      IAsyncResult ares,
      string methodName,
      string argName)
    {
      if (ares == null)
        throw new ArgumentNullException(argName);
      if (!(ares is SocketAsyncResult socketAsyncResult))
        throw new ArgumentException("Invalid IAsyncResult", argName);
      return Interlocked.CompareExchange(ref socketAsyncResult.EndCalled, 1, 0) != 1 ? socketAsyncResult : throw new InvalidOperationException(methodName + " can only be called once per asynchronous operation");
    }

    private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
    {
      Task task = sem.WaitAsync();
      if (task.IsCompleted)
      {
        if (this.CleanedUp)
          job.MarkDisposed();
        else
          IOSelector.Add(handle, job);
      }
      else
        task.ContinueWith((Action<Task>) (t =>
        {
          if (this.CleanedUp)
            job.MarkDisposed();
          else
            IOSelector.Add(handle, job);
        }));
    }

    private void InitSocketAsyncEventArgs(
      SocketAsyncEventArgs e,
      AsyncCallback callback,
      object state,
      SocketOperation operation)
    {
      e.socket_async_result.Init(this, callback, state, operation);
      if (e.AcceptSocket != null)
        e.socket_async_result.AcceptSocket = e.AcceptSocket;
      e.current_socket = this;
      e.SetLastOperation(this.SocketOperationToSocketAsyncOperation(operation));
      e.SocketError = SocketError.Success;
      e.BytesTransferred = 0;
    }

    private SocketAsyncOperation SocketOperationToSocketAsyncOperation(
      SocketOperation op)
    {
      switch (op)
      {
        case SocketOperation.Accept:
          return SocketAsyncOperation.Accept;
        case SocketOperation.Connect:
          return SocketAsyncOperation.Connect;
        case SocketOperation.Receive:
        case SocketOperation.ReceiveGeneric:
          return SocketAsyncOperation.Receive;
        case SocketOperation.ReceiveFrom:
          return SocketAsyncOperation.ReceiveFrom;
        case SocketOperation.Send:
        case SocketOperation.SendGeneric:
          return SocketAsyncOperation.Send;
        case SocketOperation.SendTo:
          return SocketAsyncOperation.SendTo;
        case SocketOperation.Disconnect:
          return SocketAsyncOperation.Disconnect;
        default:
          throw new NotImplementedException(string.Format("Operation {0} is not implemented", (object) op));
      }
    }

    private IPEndPoint RemapIPEndPoint(IPEndPoint input) => this.IsDualMode && input.AddressFamily == AddressFamily.InterNetwork ? new IPEndPoint(input.Address.MapToIPv6(), input.Port) : input;

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void cancel_blocking_socket_operation(Thread thread);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool SupportsPortReuse(ProtocolType proto);

    internal static int FamilyHint
    {
      get
      {
        int num = 0;
        if (Socket.OSSupportsIPv4)
          num = 1;
        if (Socket.OSSupportsIPv6)
          num = num == 0 ? 2 : 0;
        return num;
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsProtocolSupported_internal(
      NetworkInterfaceComponent networkInterface);

    private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) => Socket.IsProtocolSupported_internal(networkInterface);

    private delegate void SendFileHandler(
      string fileName,
      byte[] preBuffer,
      byte[] postBuffer,
      TransmitFileOptions flags);

    private sealed class SendFileAsyncResult : IAsyncResult
    {
      private IAsyncResult ares;
      private Socket.SendFileHandler d;

      public SendFileAsyncResult(Socket.SendFileHandler d, IAsyncResult ares)
      {
        this.d = d;
        this.ares = ares;
      }

      public object AsyncState => this.ares.AsyncState;

      public WaitHandle AsyncWaitHandle => this.ares.AsyncWaitHandle;

      public bool CompletedSynchronously => this.ares.CompletedSynchronously;

      public bool IsCompleted => this.ares.IsCompleted;

      public Socket.SendFileHandler Delegate => this.d;

      public IAsyncResult Original => this.ares;
    }

    private struct WSABUF
    {
      public int len;
      public IntPtr buf;
    }
  }
}
