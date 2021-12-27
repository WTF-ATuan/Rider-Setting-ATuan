// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.NetworkArray_Objects`1
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Photon.Bolt
{
  [Documentation]
  public class NetworkArray_Objects<T> : NetworkObj, IEnumerable<T>, IEnumerable
    where T : NetworkObj
  {
    private int _length;
    private int _stride;

    public int Length => this._length;

    internal override NetworkStorage Storage => this.Root.Storage;

    internal NetworkArray_Objects(int length, int stride)
      : base((NetworkObj_Meta) NetworkArray_Meta.Instance)
    {
      this._length = length;
      this._stride = stride;
    }

    public T this[int index]
    {
      get
      {
        if (index < 0 || index >= this._length)
          throw new IndexOutOfRangeException();
        return (T) this.Objects[this.OffsetObjects + 1 + index * this._stride];
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      for (int i = 0; i < this._length; ++i)
        yield return this[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
