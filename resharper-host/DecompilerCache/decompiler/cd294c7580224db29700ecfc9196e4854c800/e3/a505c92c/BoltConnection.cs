// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.BoltConnection
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using Photon.Bolt.Channel;
using Photon.Bolt.Collections;
using Photon.Bolt.Exceptions;
using Photon.Bolt.Internal;
using Photon.Bolt.SceneManagement;
using Photon.Bolt.Tokens;
using Photon.Bolt.Utils;
using System;
using System.Collections.Generic;
using UdpKit;
using UnityEngine;

namespace Photon.Bolt
{
  /// <summary>The connection to a remote endpoint</summary>
  /// <example>
  /// *Example:* Accepting an incoming connection.
  /// 
  /// <code>
  /// public override void ConnectRequest(UdpEndPoint endpoint) {
  ///   BoltNetwork.Accept(endPoint);
  /// }
  /// </code>
  /// </example>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection">`BoltConnection` on google.com</a></footer>
  [Documentation]
  public class BoltConnection : BoltObject, IBoltListNode<BoltConnection>
  {
    private readonly UdpConnection _udpConnection;
    private readonly BoltChannel[] _channels;
    private int _framesToStep;
    private int _packetsReceived;
    private int _packetCounter;
    private int _packetLostCounter;
    private int _remoteFrameDiff;
    private int _remoteFrameActual;
    private int _remoteFrameEstimated;
    private bool _remoteFrameAdjust;
    private int _bitsSecondIn;
    private int _bitsSecondInAcc;
    private int _bitsSecondOut;
    private int _bitsSecondOutAcc;
    private float _errorAccumulator;
    internal PacketTypeStats _commandStats;
    internal PacketTypeStats _stateStats;
    internal PacketTypeStats _eventsStats;
    internal BinaryDataChannel _binaryDataChannel;
    internal EventChannel _eventChannel;
    internal SceneLoadChannel _sceneLoadChannel;
    internal EntityChannel _entityChannel;
    internal EntityChannel.CommandChannel _commandChannel;
    internal List<Entity> _controlling;
    internal EntityList _controllingList;
    internal BoltRingBuffer<PacketStats> _packetStatsIn;
    internal BoltRingBuffer<PacketStats> _packetStatsOut;
    internal bool _canReceiveEntities = true;
    internal SceneLoadState _remoteSceneLoading;

    BoltConnection IBoltListNode<BoltConnection>.prev { get; set; }

    BoltConnection IBoltListNode<BoltConnection>.next { get; set; }

    object IBoltListNode<BoltConnection>.list { get; set; }

    /// <summary>
    /// Returns true if the remote computer on the other end of this connection is loading a map currently, otherwise false
    /// </summary>
    /// <example>
    /// *Example:* Removing a preloaded player entity from the game if they disconnect while loading.
    /// 
    /// <code>
    /// public override void Disconnected(BoltConnection connection) {
    ///   if(connection.isLoadingMap) {
    ///     PlayerEntityList.instance.RemoveFor(connection);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.IsLoadingMap">`BoltConnection.IsLoadingMap` on google.com</a></footer>
    public bool IsLoadingMap => this._remoteSceneLoading.Scene != BoltCore._localSceneLoading.Scene || this._remoteSceneLoading.State != 3;

    public EntityLookup ScopedTo => this._entityChannel._outgoingLookup;

    public EntityLookup SourceOf => this._entityChannel._incommingLookup;

    public EntityList HasControlOf => this._controllingList;

    /// <summary>
    /// The estimated frame of the simulation running at the other end of this connection
    /// </summary>
    /// <example>
    /// *Example:* Calculating the average frame difference of the client and server for all clients.
    /// 
    /// <code>
    /// float EstimateFrameDiff() {
    ///   int count
    ///   float avg;
    /// 
    ///   foreach(BoltConnection client in BoltNetwork.clients) {
    ///     count++;
    ///     avg += BoltNetwork.serverFrame - client.remoteFrame;
    ///   }
    ///   avg = avg / count;
    ///   return avg;
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.RemoteFrame">`BoltConnection.RemoteFrame` on google.com</a></footer>
    public int RemoteFrame => this._remoteFrameEstimated;

    /// <summary>
    /// The ConnectToken contains the token sent by the client when connecting to a game server.
    /// When you call BoltNetwork.Connect, BoltMatchmaking.JoinSession or BoltMatchmaking.JoinRandomSession with a Token,
    /// it can be accessed via this property
    /// </summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.ConnectToken">`BoltConnection.ConnectToken` on google.com</a></footer>
    public IProtocolToken ConnectToken { get; internal set; }

    /// <summary>
    /// The DisconnectToken contains the token used when a Connection is shutdown, either by the remote client or by the
    /// game server.
    /// When calling BoltConnection.Disconnect with a Token, it can be accessed via this property.
    /// </summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.DisconnectToken">`BoltConnection.DisconnectToken` on google.com</a></footer>
    public IProtocolToken DisconnectToken { get; internal set; }

    /// <summary>
    /// A data token that was passed by the server when accepting the connection
    /// </summary>
    /// <example>
    /// *Example:* Using the <c>AcceptToken</c> to store connection settings.
    /// 
    /// <code>
    /// public override void Disconnected(BoltConnection connection, IProtocolToken token) {
    ///   ConnectionSettings connSettings = (ConnectionSettings)token;
    /// 
    ///   StartCoroutine(RemoveIfTimeout(connection, connSettings.maxTimeout));
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.AcceptToken">`BoltConnection.AcceptToken` on google.com</a></footer>
    public IProtocolToken AcceptToken { get; internal set; }

    /// <summary>The round-trip time on the network</summary>
    /// <example>
    /// *Example:* Displaying the network ping when in debug mode.
    /// 
    /// <code>
    /// void OnGUI() {
    ///   if(BoltNetwork.isConnected &amp;&amp; BoltNetwork.isClient) {
    ///     GUILayout.Label("Ping:" + BoltNetwork.server.PingNetwork;
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.PingNetwork">`BoltConnection.PingNetwork` on google.com</a></footer>
    public float PingNetwork => this._udpConnection.NetworkPing;

    /// <summary>The dejitter delay in number of frames</summary>
    /// <example>
    /// *Example:* Showing the dejitter delay frames and ping.
    /// 
    /// <code>
    /// void OnGUI() {
    ///   if(BoltNetwork.isConnected &amp;&amp; BoltNetwork.isClient) {
    ///     GUILayout.Label("Ping:" + BoltNetwork.server.pingNetwork;
    ///     GUILayout.Label("Dejitter Delay:" + BoltNetwork.server.DejitterFrames;
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.DejitterFrames">`BoltConnection.DejitterFrames` on google.com</a></footer>
    public int DejitterFrames => this._remoteFrameActual - this._remoteFrameEstimated;

    /// <summary>
    /// The round-trip time across the network, including processing delays and acks
    /// </summary>
    /// <example>
    /// *Example:* Showing the difference between ping and aliased ping. Aliased ping will always be larger.
    /// 
    /// <code>
    /// void OnGUI() {
    ///   if(BoltNetwork.isConnected &amp;&amp; BoltNetwork.isClient) {
    ///     GUILayout.Label("Ping:" + BoltNetwork.server.PingNetwork;
    ///     GUILayout.Label("Ping (Aliased):" + BoltNetwork.server.PingAliased;
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.PingAliased">`BoltConnection.PingAliased` on google.com</a></footer>
    public float PingAliased => this._udpConnection.AliasedPing;

    public UdpConnectionType ConnectionType => this._udpConnection.ConnectionType;

    internal UdpConnection udpConnection => this._udpConnection;

    internal int remoteFrameLatest => this._remoteFrameActual;

    internal int remoteFrameDiff => this._remoteFrameDiff;

    /// <summary>How many bits per second we are receiving in</summary>
    /// <example>
    /// *Example:* Showing the ping and data flow in and out.
    /// 
    /// <code>
    /// void OnGUI() {
    ///   if(BoltNetwork.isConnected &amp;&amp; BoltNetwork.isClient) {
    ///     GUILayout.Label("Ping:" + BoltNetwork.server.PingNetwork;
    ///     GUILayout.Label("Bandwidth Out:" + BoltNetwork.server.BitsPerSecondOut);
    ///     GUILayout.Label("Bandwidth In:" + BoltNetwork.server.BitsPerSecondIn);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.BitsPerSecondIn">`BoltConnection.BitsPerSecondIn` on google.com</a></footer>
    public int BitsPerSecondIn => this._bitsSecondIn;

    /// <summary>How many bits per second we are sending out</summary>
    /// <example>
    /// *Example:* Showing the ping and data flow in and out.
    /// 
    /// <code>
    /// void OnGUI() {
    ///   if(BoltNetwork.isConnected &amp;&amp; BoltNetwork.isClient) {
    ///     GUILayout.Label("Ping:" + BoltNetwork.server.pingNetwork;
    ///     GUILayout.Label("Bandwidth Out:" + BoltNetwork.server.bitsPerSecondIn);
    ///     GUILayout.Label("Bandwidth In:" + BoltNetwork.server.bitsPerSecondOut);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.BitsPerSecondOut">`BoltConnection.BitsPerSecondOut` on google.com</a></footer>
    public int BitsPerSecondOut => this._bitsSecondOut;

    /// <summary>How many packets were received by this connection</summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.PacketsReceived">`BoltConnection.PacketsReceived` on google.com</a></footer>
    public int PacketsReceived => this._packetsReceived;

    /// <summary>How many packets were sent to this connection</summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.PacketsSent">`BoltConnection.PacketsSent` on google.com</a></footer>
    public int PacketsSent => this._packetCounter;

    /// <summary>How many packets were registered as lost packets</summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.PacketsLost">`BoltConnection.PacketsLost` on google.com</a></footer>
    public int PacketsLost => this._packetLostCounter;

    /// <summary>
    /// For the host this will be the ID of the client, an on the client it will show the ID of the client
    /// </summary>
    /// <example>
    ///  *Example:* Getting a connection Id
    /// 
    ///  <code>
    /// uint getID()
    /// {
    ///     if (BoltNetwork.isClient)
    ///     {
    ///         //my Id
    ///         return BoltNetwork.server.ConnectionId;
    ///     }
    ///     else
    ///     {
    ///         //Id of first client
    ///         return BoltNetwork.clients.First().ConnectionId;
    ///     }
    /// }
    ///  </code>
    ///  </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.ConnectionId">`BoltConnection.ConnectionId` on google.com</a></footer>
    public uint ConnectionId => this.udpConnection.ConnectionId;

    /// <summary>Remote end point of this connection</summary>
    /// <example>
    /// *Example:* Logging the address of new connections
    /// 
    /// <code>
    /// public override void Connected(BoltConnection connection) {
    ///   ServerLog.Write(string.Format("[{0}:{1}] New Connection", connection.remoteEndPoint.Address, connection.remoteEndPoint.Port);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.RemoteEndPoint">`BoltConnection.RemoteEndPoint` on google.com</a></footer>
    public UdpEndPoint RemoteEndPoint => this.udpConnection.RemoteEndPoint;

    /// <summary>
    /// User assignable object which lets you pair arbitrary data with the connection
    /// </summary>
    /// <example>
    /// *Example:* Using a reference to the player entity in the UserData property.
    /// 
    /// <code>
    /// public override void Disconnected(BoltConnection connection) {
    ///   BoltNetwork.Destroy((BoltEntity)connection.UserData);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.UserData">`BoltConnection.UserData` on google.com</a></footer>
    public object UserData { get; set; }

    public void SetCanReceiveEntities(bool v) => this._canReceiveEntities = v;

    public PacketTypeStats CommandsStats => this._commandStats;

    public PacketTypeStats EventsStats => this._eventsStats;

    public PacketTypeStats StatesStats => this._stateStats;

    public UdpConnectionDisconnectReason DisconnectReason => this.udpConnection.DisconnectReason;

    internal int SendRateMultiplier
    {
      get
      {
        float windowFillRatio = this.udpConnection.WindowFillRatio;
        return (double) windowFillRatio < 0.25 ? 1 : Mathf.Clamp((int) ((double) ((windowFillRatio - 0.25f) / 0.75f) * 60.0), 1, 60);
      }
    }

    internal BoltConnection(UdpConnection udpConnection)
    {
      this.UserData = udpConnection.UserToken;
      this._controlling = new List<Entity>();
      this._controllingList = new EntityList(this._controlling);
      this._udpConnection = udpConnection;
      this._udpConnection.UserToken = (object) this;
      this._channels = new BoltChannel[5]
      {
        (BoltChannel) (this._binaryDataChannel = new BinaryDataChannel()),
        (BoltChannel) (this._sceneLoadChannel = new SceneLoadChannel()),
        (BoltChannel) (this._commandChannel = new EntityChannel.CommandChannel()),
        (BoltChannel) (this._eventChannel = new EventChannel()),
        (BoltChannel) (this._entityChannel = new EntityChannel())
      };
      this._remoteFrameAdjust = false;
      this._remoteSceneLoading = SceneLoadState.DefaultRemote();
      this._packetStatsOut = new BoltRingBuffer<PacketStats>(BoltCore._config.framesPerSecond)
      {
        autofree = true
      };
      this._packetStatsIn = new BoltRingBuffer<PacketStats>(BoltCore._config.framesPerSecond)
      {
        autofree = true
      };
      this._commandStats = new PacketTypeStats();
      this._eventsStats = new PacketTypeStats();
      this._stateStats = new PacketTypeStats();
      this._errorAccumulator = 0.0f;
      for (int index = 0; index < this._channels.Length; ++index)
        this._channels[index].connection = this;
    }

    public ExistsResult ExistsOnRemote(BoltEntity entity) => this._entityChannel.ExistsOnRemote(entity.Entity, false);

    public ExistsResult ExistsOnRemote(BoltEntity entity, bool allowMaybe) => this._entityChannel.ExistsOnRemote(entity.Entity, allowMaybe);

    /// <summary>Send a binary stream of data to this connection</summary>
    /// <param name="channel">The channel to send on</param>
    /// <param name="data">The binary data</param>
    /// <example>
    /// *Example:* Sending the binary data of a custom icon texture to the server using a static reference
    /// to the "PlayerIcon" channel that was created inside a <c>Channels</c> class.
    /// 
    /// <code>
    /// void SendCustomIcon(Texture2D myCustomIcon) {
    ///   byte[] data = myCustomIcon.EncodeToPNG();
    /// 
    ///   BoltNetwork.server.StreamBytes(Channels.PlayerIcon, data);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.StreamBytes">`BoltConnection.StreamBytes` on google.com</a></footer>
    public void StreamBytes(UdpChannelName channel, byte[] data) => this._udpConnection.StreamBytes(channel, data);

    /// <summary>Set the max amount of data allowed per second</summary>
    /// <param name="bytesPerSecond">The rate in bytes / sec</param>
    /// <example>
    /// *Example:* Configuring the initial stream bandwidth of new connections to 20 kb/s.
    /// 
    /// <code>
    /// public override void Connected(BoltConnection connection) {
    ///   connection.SetStreamBandwidth(1024 * 20);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.SetStreamBandwidth">`BoltConnection.SetStreamBandwidth` on google.com</a></footer>
    public void SetStreamBandwidth(int bytesPerSecond) => this._udpConnection.StreamSetBandwidth(bytesPerSecond);

    /// <summary>Sends the data.</summary>
    /// <param name="data">Data.</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.SendData">`BoltConnection.SendData` on google.com</a></footer>
    public void SendData(byte[] data) => this._binaryDataChannel.Outgoing.Enqueue(data);

    /// <summary>Receives the data.</summary>
    /// <returns><c>true</c>, if data was received, <c>false</c> otherwise.</returns>
    /// <param name="data">Data.</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.ReceiveData">`BoltConnection.ReceiveData` on google.com</a></footer>
    public bool ReceiveData(out byte[] data)
    {
      if (this._binaryDataChannel.Incomming.Count > 0)
      {
        data = this._binaryDataChannel.Incomming.Dequeue();
        return true;
      }
      data = (byte[]) null;
      return false;
    }

    /// <summary>Disconnect this connection</summary>
    /// <example>
    /// *Example:* Terminating all connections.
    /// 
    /// <code>
    /// void DisconnectAll() {
    ///   foreach(var connection in BoltNetwork.connections) {
    ///     connection.Disconnect();
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.Disconnect">`BoltConnection.Disconnect` on google.com</a></footer>
    public void Disconnect() => this.Disconnect((IProtocolToken) null);

    /// <summary>Disconnect this connection with custom data</summary>
    /// <param name="token">A data token</param>
    /// <param name="disconnectReason">Specify the disconnect reason to shutdown this connection</param>
    /// <example>
    /// *Example:* Terminating all connections with a custom error message.
    /// 
    /// <code>
    /// void DisconnectAll(int errorCode, string errorMessage) {
    ///   ServerMessage msg = new ServerMessage(errorCode, errorMessage);
    /// 
    ///   foreach(var connection in BoltNetwork.connections) {
    ///     connection.Disconnect(errorMessage);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.Disconnect">`BoltConnection.Disconnect` on google.com</a></footer>
    public void Disconnect(IProtocolToken token, UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected) => this._udpConnection.Disconnect(token.ToByteArray(), disconnectReason);

    public int GetSkippedUpdates(BoltEntity en) => this._entityChannel.GetSkippedUpdates(en.Entity);

    public void ForceSceneSync() => this._sceneLoadChannel?.ForceSceneSync();

    /// <summary>Reference comparison between two connections</summary>
    /// <param name="obj">The object to compare</param>
    /// <example>
    /// bool Compare(BoltConnection A, BoltConnection B) {
    ///   return A.Equals(B);
    /// }
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.Equals">`BoltConnection.Equals` on google.com</a></footer>
    public override bool Equals(object obj) => this == obj;

    /// <summary>A hash code for this connection</summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.GetHashCode">`BoltConnection.GetHashCode` on google.com</a></footer>
    public override int GetHashCode() => this._udpConnection.GetHashCode();

    /// <summary>The string representation of this connection</summary>
    /// <example>
    /// *Example:* Logging the address of new connections using the string representation.
    /// 
    /// <code>
    /// public override void Connected(BoltConnection connection) {
    ///   ServerLog.instance.Write("New Connection:" + connection.ToString());
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltConnection.ToString">`BoltConnection.ToString` on google.com</a></footer>
    public override string ToString() => string.Format("[Connection {0}]", (object) this._udpConnection.RemoteEndPoint);

    internal void DisconnectedInternal()
    {
      for (int index = 0; index < this._channels.Length; ++index)
        this._channels[index].Disconnected();
      if (this.UserData == null)
        return;
      if (this.UserData is IDisposable)
        (this.UserData as IDisposable).Dispose();
      this.UserData = (object) null;
    }

    internal bool StepRemoteEntities()
    {
      if (this._framesToStep > 0)
      {
        --this._framesToStep;
        ++this._remoteFrameEstimated;
        Dictionary<NetworkId, EntityProxy>.Enumerator enumerator = this._entityChannel._incommingDict.GetEnumerator();
        while (enumerator.MoveNext())
        {
          EntityProxy entityProxy = enumerator.Current.Value;
          if (!entityProxy.Entity.HasPredictedControl && !entityProxy.Entity.IsFrozen)
            entityProxy.Entity.Simulate();
        }
      }
      return this._framesToStep > 0;
    }

    internal void AdjustRemoteFrame()
    {
      if (this._packetsReceived == 0)
        return;
      if (BoltCore._config.disableDejitterBuffer)
      {
        if (this._remoteFrameAdjust)
        {
          this._framesToStep = Mathf.Max(0, this._remoteFrameActual - this._remoteFrameEstimated);
          this._remoteFrameEstimated = this._remoteFrameActual;
          this._remoteFrameAdjust = false;
        }
        else
          this._framesToStep = 1;
      }
      else
      {
        int remoteSendRate = BoltCore.remoteSendRate;
        int interpolationDelay = BoltCore.localInterpolationDelay;
        int interpolationDelayMin = BoltCore.localInterpolationDelayMin;
        int interpolationDelayMax = BoltCore.localInterpolationDelayMax;
        bool flag = interpolationDelay >= 0;
        if (this._remoteFrameAdjust)
        {
          this._remoteFrameAdjust = false;
          if (flag)
          {
            if (this._packetsReceived == 1)
              this._remoteFrameEstimated = this._remoteFrameActual - interpolationDelay;
            this._remoteFrameDiff = this._remoteFrameActual - this._remoteFrameEstimated;
            if (this._remoteFrameDiff < interpolationDelayMin - remoteSendRate || this._remoteFrameDiff > interpolationDelayMax + remoteSendRate)
            {
              int num = this._remoteFrameActual - interpolationDelay;
              BoltLog.Debug("{0} FRAME RESET: {1}", (object) this, (object) this._remoteFrameDiff);
              this._remoteFrameEstimated = num;
              this._remoteFrameDiff = this._remoteFrameActual - this._remoteFrameEstimated;
            }
          }
        }
        if (flag)
        {
          if (this._remoteFrameDiff > interpolationDelayMax)
          {
            BoltLog.Debug("{0} FRAME FORWARD: {1}", (object) this, (object) this._remoteFrameDiff);
            this._framesToStep = 2;
            this._remoteFrameDiff -= this._framesToStep;
          }
          else if (this._remoteFrameDiff < interpolationDelayMin)
          {
            BoltLog.Debug("{0} FRAME STALL: {1}", (object) this, (object) this._remoteFrameDiff);
            this._framesToStep = 0;
            ++this._remoteFrameDiff;
          }
          else
            this._framesToStep = 1;
        }
        else
          this._remoteFrameEstimated = this._remoteFrameActual - (remoteSendRate - 1);
      }
    }

    internal void SwitchPerfCounters()
    {
      this._bitsSecondOut = this._bitsSecondOutAcc;
      this._bitsSecondOutAcc = 0;
      this._bitsSecondIn = this._bitsSecondInAcc;
      this._bitsSecondInAcc = 0;
      if (!BoltRuntimeSettings.instance.enableClientMetrics)
        return;
      this._commandStats.Update(this._packetStatsIn, this._packetStatsOut, (Func<PacketStats, int>) (x => x.CommandBits));
      this._eventsStats.Update(this._packetStatsIn, this._packetStatsOut, (Func<PacketStats, int>) (x => x.EventBits));
      this._stateStats.Update(this._packetStatsIn, this._packetStatsOut, (Func<PacketStats, int>) (x => x.StateBits));
    }

    internal void Send()
    {
      try
      {
        Packet packet = PacketPool.Acquire();
        packet.Frame = BoltCore.frame;
        packet.Number = ++this._packetCounter;
        packet.UdpPacket = BoltCore.AllocateUdpPacket();
        packet.UdpPacket.UserToken = (object) packet;
        packet.UdpPacket.WriteIntVB(packet.Frame);
        for (int index = 0; index < this._channels.Length; ++index)
          this._channels[index].Pack(packet);
        Assert.False(packet.UdpPacket.Overflowing);
        this._udpConnection.Send(packet.UdpPacket);
        this._bitsSecondOutAcc += packet.UdpPacket.Position;
        this._packetStatsOut.Enqueue(packet.Stats);
      }
      catch (Exception ex)
      {
        BoltLog.Exception(ex);
        throw;
      }
    }

    internal void PacketReceived(UdpPacket udpPacket)
    {
      Packet packet = (Packet) null;
      try
      {
        using (packet = PacketPool.Acquire())
        {
          packet.UdpPacket = udpPacket;
          packet.Frame = packet.UdpPacket.ReadIntVB();
          if (packet.Frame > this._remoteFrameActual)
          {
            this._remoteFrameAdjust = true;
            this._remoteFrameActual = packet.Frame;
          }
          this._bitsSecondInAcc += packet.UdpPacket.Size;
          ++this._packetsReceived;
          for (int index = 0; index < this._channels.Length; ++index)
            this._channels[index].Read(packet);
          this._packetStatsIn.Enqueue(packet.Stats);
          Assert.False<BoltPackageOverflowException>(udpPacket.Overflowing, (object) this.udpConnection.RemoteEndPoint);
          this._errorAccumulator = Mathf.Max(0.0f, this._errorAccumulator - (float) BoltCore.frameSlice);
        }
        packet = (Packet) null;
      }
      catch (BoltPackageOverflowException ex)
      {
        BoltLog.Exception((Exception) ex);
        this.Disconnect((IProtocolToken) new BoltDisconnectToken(ex.Message, UdpConnectionDisconnectReason.Timeout), UdpConnectionDisconnectReason.Timeout);
      }
      catch (Exception ex)
      {
        this._errorAccumulator += (float) (BoltCore.frameSlice * 2);
        BoltLog.Warn((object) ex);
        BoltLog.Warn("Exception thrown while unpacking data from {0} ({1})", (object) this.udpConnection.RemoteEndPoint, (object) this._errorAccumulator);
        if ((double) this._errorAccumulator < 1.0)
          return;
        BoltLog.Error("Too many errors accumulated while unpacking data from {0}, disconnecting.", (object) this.udpConnection.RemoteEndPoint);
        this.Disconnect();
      }
      finally
      {
        packet?.Dispose();
      }
    }

    internal void PacketDelivered(Packet packet)
    {
      try
      {
        for (int index = 0; index < this._channels.Length; ++index)
          this._channels[index].Delivered(packet);
      }
      catch (Exception ex)
      {
        BoltLog.Exception(ex);
        BoltLog.Error("exception thrown while handling delivered packet to {0}", (object) this.udpConnection.RemoteEndPoint);
      }
    }

    internal void PacketLost(Packet packet)
    {
      try
      {
        ++this._packetLostCounter;
        for (int index = 0; index < this._channels.Length; ++index)
          this._channels[index].Lost(packet);
      }
      catch (Exception ex)
      {
        BoltLog.Exception(ex);
        BoltLog.Error("exception thrown while handling lost packet to {0}", (object) this.udpConnection.RemoteEndPoint);
      }
    }

    public static implicit operator bool(BoltConnection cn) => cn != null;
  }
}
