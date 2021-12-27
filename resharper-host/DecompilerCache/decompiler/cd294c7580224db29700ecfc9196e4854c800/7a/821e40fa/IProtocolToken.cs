// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.IProtocolToken
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using UdpKit;

namespace Photon.Bolt
{
  /// <summary>
  /// Describe a Protocol Token that can be used to transfer data between peers
  /// when running certain process on Bolt.
  /// Read more at <a href="https://doc.photonengine.com/en-us/bolt/current/in-depth/protocol-tokens">here</a>
  /// Utility methods to work with IProtocolTokens can be found on <see cref="T:Photon.Bolt.ProtocolTokenUtils" />.
  /// </summary>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IProtocolToken">`IProtocolToken` on google.com</a></footer>
  public interface IProtocolToken
  {
    /// <summary>
    /// Used to deserialize the Token reading data from the data packet.
    /// </summary>
    /// <param name="packet">Data packet that contains the Token info</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IProtocolToken.Read">`IProtocolToken.Read` on google.com</a></footer>
    void Read(UdpPacket packet);

    /// <summary>
    /// Used to serialize the Token by writing data into the data packet.
    /// </summary>
    /// <param name="packet">Data packet used to store the Token info</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IProtocolToken.Write">`IProtocolToken.Write` on google.com</a></footer>
    void Write(UdpPacket packet);
  }
}
