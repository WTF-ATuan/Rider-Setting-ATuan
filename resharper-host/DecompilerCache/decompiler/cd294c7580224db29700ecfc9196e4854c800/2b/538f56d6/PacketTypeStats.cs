// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.Internal.PacketTypeStats
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using Photon.Bolt.Collections;
using System;
using System.Linq;

namespace Photon.Bolt.Internal
{
  [Documentation(Ignore = true)]
  public class PacketTypeStats
  {
    public double TotalIn;
    public double TotalOut;
    public double In;
    public double Out;

    internal void Update(
      BoltRingBuffer<PacketStats> statsIn,
      BoltRingBuffer<PacketStats> statsOut,
      Func<PacketStats, int> selector)
    {
      this.In = Math.Round((double) statsIn.Select<PacketStats, int>(selector).Sum() / 8.0 / (double) statsIn.count, 2);
      this.Out = Math.Round((double) statsOut.Select<PacketStats, int>(selector).Sum() / 8.0 / (double) statsOut.count, 2);
      this.TotalIn += Math.Round((double) statsIn.Select<PacketStats, int>(selector).Sum() / 8.0, 2);
      this.TotalOut += Math.Round((double) statsOut.Select<PacketStats, int>(selector).Sum() / 8.0, 2);
    }
  }
}
