// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.ICubeState
// Assembly: bolt.user, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 08F80C87-AC08-437F-95E7-341AF79C8D78
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.user.dll

using System;
using UnityEngine;

namespace Photon.Bolt
{
  public interface ICubeState : IState, IDisposable
  {
    NetworkTransform CubeTransform { get; }

    Color CubeColor { get; set; }

    NetworkArray_Objects<WeaponSlot> WeaponArray { get; }

    int WeaponActiveIndex { get; set; }
  }
}
