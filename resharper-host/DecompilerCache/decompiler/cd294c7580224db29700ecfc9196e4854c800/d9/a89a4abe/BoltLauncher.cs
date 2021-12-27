// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.BoltLauncher
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using Photon.Bolt.Internal;
using System;
using UdpKit;
using UdpKit.Platform;

namespace Photon.Bolt
{
  /// <summary>Utility class used to start Bolt as Server or Client.</summary>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher">`BoltLauncher` on google.com</a></footer>
  public static class BoltLauncher
  {
    private static UdpPlatform TargetPlatform { get; set; }

    /// <summary>Starts Bolt as a Single Player game</summary>
    /// <param name="config">Custom Bolt configuration</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartSinglePlayer">`BoltLauncher.StartSinglePlayer` on google.com</a></footer>
    public static void StartSinglePlayer(BoltConfig config = null)
    {
      if (config == null)
        config = BoltRuntimeSettings.instance.GetConfigCopy();
      BoltLauncher.Initialize(BoltNetworkModes.None, UdpEndPoint.Any, config);
    }

    /// <summary>Starts Bolt as Server.</summary>
    /// <param name="port">Port where the Server will try to bind</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartServer">`BoltLauncher.StartServer` on google.com</a></footer>
    public static void StartServer(int port = -1)
    {
      if (port >= 0 && port <= (int) ushort.MaxValue)
      {
        BoltLauncher.StartServer(new UdpEndPoint(UdpIPv4Address.Any, (ushort) port));
      }
      else
      {
        if (port != -1)
          throw new ArgumentOutOfRangeException(string.Format("'port' must be >= 0 and <= {0}", (object) ushort.MaxValue));
        BoltLauncher.StartServer(UdpEndPoint.Any);
      }
    }

    /// <summary>Starts Bolt as Server.</summary>
    /// <param name="config">Custom Bolt configuration</param>
    /// <param name="scene">Default Scene loaded by Bolt when the initialization is complete</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartServer">`BoltLauncher.StartServer` on google.com</a></footer>
    public static void StartServer(BoltConfig config, string scene = null) => BoltLauncher.StartServer(UdpEndPoint.Any, config, scene);

    /// <summary>Starts Bolt as Server.</summary>
    /// <param name="endpoint">Custom EndPoint where Bolt will try to bind</param>
    /// <param name="scene">Default Scene loaded by Bolt when the initialization is complete</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartServer">`BoltLauncher.StartServer` on google.com</a></footer>
    public static void StartServer(UdpEndPoint endpoint, string scene = null) => BoltLauncher.StartServer(endpoint, BoltRuntimeSettings.instance.GetConfigCopy(), scene);

    /// <summary>Starts Bolt as Server.</summary>
    /// <param name="endpoint">Custom EndPoint where Bolt will try to bind</param>
    /// <param name="config">Custom Bolt configuration</param>
    /// <param name="scene">Default Scene loaded by Bolt when the initialization is complete</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartServer">`BoltLauncher.StartServer` on google.com</a></footer>
    public static void StartServer(UdpEndPoint endpoint, BoltConfig config, string scene = null) => BoltLauncher.Initialize(BoltNetworkModes.Server, endpoint, config, scene);

    /// <summary>Starts Bolt as Client.</summary>
    /// <param name="port">Port where the Server will try to bind</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartClient">`BoltLauncher.StartClient` on google.com</a></footer>
    public static void StartClient(int port = -1)
    {
      if (port >= 0 && port <= (int) ushort.MaxValue)
      {
        BoltLauncher.StartClient(new UdpEndPoint(UdpIPv4Address.Any, (ushort) port));
      }
      else
      {
        if (port != -1)
          throw new ArgumentOutOfRangeException(string.Format("'port' must be >= 0 and <= {0}", (object) ushort.MaxValue));
        BoltLauncher.StartClient(UdpEndPoint.Any);
      }
    }

    /// <summary>Starts Bolt as Client.</summary>
    /// <param name="config">Custom Bolt configuration</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartClient">`BoltLauncher.StartClient` on google.com</a></footer>
    public static void StartClient(BoltConfig config) => BoltLauncher.StartClient(UdpEndPoint.Any, config);

    /// <summary>Starts Bolt as Client.</summary>
    /// <param name="endpoint">Custom EndPoint where Bolt will try to bind</param>
    /// <param name="config">Custom Bolt configuration</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.StartClient">`BoltLauncher.StartClient` on google.com</a></footer>
    public static void StartClient(UdpEndPoint endpoint, BoltConfig config = null)
    {
      if (config == null)
        config = BoltRuntimeSettings.instance.GetConfigCopy();
      BoltLauncher.Initialize(BoltNetworkModes.Client, endpoint, config);
    }

    /// <summary>
    /// Utility function to initialize Bolt with the specified modes, endpoint, config and scene.
    /// </summary>
    /// <param name="modes">Bolt mode. <see cref="T:Photon.Bolt.BoltNetworkModes" /></param>
    /// <param name="endpoint">Custom EndPoint where Bolt will try to bind</param>
    /// <param name="config">Custom Bolt configuration</param>
    /// <param name="scene">Default Scene loaded by Bolt when the initialization is complete</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.Initialize">`BoltLauncher.Initialize` on google.com</a></footer>
    private static void Initialize(
      BoltNetworkModes modes,
      UdpEndPoint endpoint,
      BoltConfig config,
      string scene = null)
    {
      BoltNetworkInternal.Initialize(modes, endpoint, config, BoltLauncher.TargetPlatform, scene);
    }

    /// <summary>Shutdown this Bolt instance.</summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.Shutdown">`BoltLauncher.Shutdown` on google.com</a></footer>
    public static void Shutdown() => BoltNetwork.Shutdown();

    /// <summary>
    /// Set a custom UDP platform. Use this method only to set custom properties
    /// to your desired platform. By default, there is no need to change
    /// the platform, this is handled internally by Bolt.
    /// </summary>
    /// <param name="platform">Custom UdpPlatform</param>
    /// <example>
    /// This example show how to set a custom PhotonPlatform:
    /// <code>
    /// BoltLauncher.SetUdpPlatform(new PhotonPlatform(new PhotonPlatformConfig
    /// {
    ///     AppId = "your-app-id",
    ///     RegionMaster = "your-region",
    ///     UsePunchThrough = true, // set to false, to disable PunchThrough
    ///     MaxConnections = 32
    /// }));
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.BoltLauncher.SetUdpPlatform">`BoltLauncher.SetUdpPlatform` on google.com</a></footer>
    public static void SetUdpPlatform(UdpPlatform platform) => BoltLauncher.TargetPlatform = platform;
  }
}
