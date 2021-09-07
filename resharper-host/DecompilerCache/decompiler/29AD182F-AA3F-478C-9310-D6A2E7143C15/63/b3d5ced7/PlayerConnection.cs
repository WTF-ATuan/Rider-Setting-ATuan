// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.PlayerConnection.PlayerConnection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection
{
  /// <summary>
  ///   <para>Used for handling the network connection from the Player to the Editor.</para>
  /// </summary>
  [Serializable]
  public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
  {
    internal static IPlayerEditorConnectionNative connectionNative;
    [SerializeField]
    private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents = new PlayerEditorConnectionEvents();
    [SerializeField]
    private List<int> m_connectedPlayers = new List<int>();
    private bool m_IsInitilized;
    private static UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;

    /// <summary>
    ///   <para>Returns a singleton instance of a PlayerConnection.</para>
    /// </summary>
    public static UnityEngine.Networking.PlayerConnection.PlayerConnection instance => (UnityEngine.Object) UnityEngine.Networking.PlayerConnection.PlayerConnection.s_Instance == (UnityEngine.Object) null ? UnityEngine.Networking.PlayerConnection.PlayerConnection.CreateInstance() : UnityEngine.Networking.PlayerConnection.PlayerConnection.s_Instance;

    /// <summary>
    ///   <para>Returns true when the Editor is connected to the Player.</para>
    /// </summary>
    public bool isConnected => this.GetConnectionNativeApi().IsConnected();

    private static UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance()
    {
      UnityEngine.Networking.PlayerConnection.PlayerConnection.s_Instance = ScriptableObject.CreateInstance<UnityEngine.Networking.PlayerConnection.PlayerConnection>();
      UnityEngine.Networking.PlayerConnection.PlayerConnection.s_Instance.hideFlags = HideFlags.HideAndDontSave;
      return UnityEngine.Networking.PlayerConnection.PlayerConnection.s_Instance;
    }

    public void OnEnable()
    {
      if (this.m_IsInitilized)
        return;
      this.m_IsInitilized = true;
      this.GetConnectionNativeApi().Initialize();
    }

    private IPlayerEditorConnectionNative GetConnectionNativeApi() => UnityEngine.Networking.PlayerConnection.PlayerConnection.connectionNative ?? (IPlayerEditorConnectionNative) new PlayerConnectionInternal();

    public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
    {
      if (messageId == Guid.Empty)
        throw new ArgumentException("Cant be Guid.Empty", nameof (messageId));
      if (!this.m_PlayerEditorConnectionEvents.messageTypeSubscribers.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>((Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>) (x => x.MessageTypeId == messageId)))
        this.GetConnectionNativeApi().RegisterInternal(messageId);
      this.m_PlayerEditorConnectionEvents.AddAndCreate(messageId).AddListener(callback);
    }

    public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
    {
      this.m_PlayerEditorConnectionEvents.UnregisterManagedCallback(messageId, callback);
      if (this.m_PlayerEditorConnectionEvents.messageTypeSubscribers.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>((Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>) (x => x.MessageTypeId == messageId)))
        return;
      this.GetConnectionNativeApi().UnregisterInternal(messageId);
    }

    public void RegisterConnection(UnityAction<int> callback)
    {
      foreach (int connectedPlayer in this.m_connectedPlayers)
        callback(connectedPlayer);
      this.m_PlayerEditorConnectionEvents.connectionEvent.AddListener(callback);
    }

    public void RegisterDisconnection(UnityAction<int> callback) => this.m_PlayerEditorConnectionEvents.disconnectionEvent.AddListener(callback);

    public void UnregisterConnection(UnityAction<int> callback) => this.m_PlayerEditorConnectionEvents.connectionEvent.RemoveListener(callback);

    public void UnregisterDisconnection(UnityAction<int> callback) => this.m_PlayerEditorConnectionEvents.disconnectionEvent.RemoveListener(callback);

    /// <summary>
    ///   <para>Sends data to the Editor.</para>
    /// </summary>
    /// <param name="messageId">The type ID of the message that is sent to the Editor.</param>
    /// <param name="data"></param>
    public void Send(Guid messageId, byte[] data)
    {
      if (messageId == Guid.Empty)
        throw new ArgumentException("Cant be Guid.Empty", nameof (messageId));
      this.GetConnectionNativeApi().SendMessage(messageId, data, 0);
    }

    /// <summary>
    ///   <para>Attempt to sends data to the Editor.</para>
    /// </summary>
    /// <param name="messageId">The type ID of the message that is sent to the Editor.</param>
    /// <param name="data"></param>
    /// <returns>
    ///   <para>Returns true when the Player sends data successfully, and false when there is no space in the socket ring buffer or sending fails.</para>
    /// </returns>
    public bool TrySend(Guid messageId, byte[] data) => !(messageId == Guid.Empty) ? this.GetConnectionNativeApi().TrySendMessage(messageId, data, 0) : throw new ArgumentException("Cant be Guid.Empty", nameof (messageId));

    /// <summary>
    ///   <para>Blocks the calling thread until either a message with the specified messageId is received or the specified time-out elapses.</para>
    /// </summary>
    /// <param name="messageId">The type ID of the message that is sent to the Editor.</param>
    /// <param name="timeout">The time-out specified in milliseconds.</param>
    /// <returns>
    ///   <para>Returns true when the message is received and false if the call timed out.</para>
    /// </returns>
    public bool BlockUntilRecvMsg(Guid messageId, int timeout)
    {
      bool msgReceived = false;
      UnityAction<MessageEventArgs> callback = (UnityAction<MessageEventArgs>) (args => msgReceived = true);
      DateTime now = DateTime.Now;
      this.Register(messageId, callback);
      while ((DateTime.Now - now).TotalMilliseconds < (double) timeout && !msgReceived)
        this.GetConnectionNativeApi().Poll();
      this.Unregister(messageId, callback);
      return msgReceived;
    }

    /// <summary>
    ///   <para>This disconnects all of the active connections.</para>
    /// </summary>
    public void DisconnectAll() => this.GetConnectionNativeApi().DisconnectAll();

    [RequiredByNativeCode]
    private static void MessageCallbackInternal(
      IntPtr data,
      ulong size,
      ulong guid,
      string messageId)
    {
      byte[] numArray = (byte[]) null;
      if (size > 0UL)
      {
        numArray = new byte[size];
        Marshal.Copy(data, numArray, 0, (int) size);
      }
      UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.m_PlayerEditorConnectionEvents.InvokeMessageIdSubscribers(new Guid(messageId), numArray, (int) guid);
    }

    [RequiredByNativeCode]
    private static void ConnectedCallbackInternal(int playerId)
    {
      UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.m_connectedPlayers.Add(playerId);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.m_PlayerEditorConnectionEvents.connectionEvent.Invoke(playerId);
    }

    [RequiredByNativeCode]
    private static void DisconnectedCallback(int playerId)
    {
      UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.m_connectedPlayers.Remove(playerId);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.m_PlayerEditorConnectionEvents.disconnectionEvent.Invoke(playerId);
    }
  }
}
