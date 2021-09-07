// Decompiled with JetBrains decompiler
// Type: System.Tuple`2
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E81851A0-DC73-4A79-AFA9-F5B7273162BE
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
  /// <summary>代表 2-Tuple 或雙重物件。</summary>
  /// <typeparam name="T1">Tuple 的第一個元件的類型。</typeparam>
  /// <typeparam name="T2">Tuple 的第二個元件的類型。</typeparam>
  [__DynamicallyInvokable]
  [Serializable]
  public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
  {
    private readonly T1 m_Item1;
    private readonly T2 m_Item2;

    /// <summary>
    ///   取得目前的值<see cref="T:System.Tuple`2" />物件的第一個元件。
    /// </summary>
    /// <returns>
    ///   目前的值<see cref="T:System.Tuple`2" />物件的第一個元件。
    /// </returns>
    [__DynamicallyInvokable]
    public T1 Item1
    {
      [__DynamicallyInvokable] get => this.m_Item1;
    }

    /// <summary>
    ///   取得目前的值 <see cref="T:System.Tuple`2" /> 物件的第二個元件。
    /// </summary>
    /// <returns>
    ///   目前的值 <see cref="T:System.Tuple`2" /> 物件的第二個元件。
    /// </returns>
    [__DynamicallyInvokable]
    public T2 Item2
    {
      [__DynamicallyInvokable] get => this.m_Item2;
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Tuple`2" /> 類別的新執行個體。
    /// </summary>
    /// <param name="item1">Tuple 的第一個元件的值。</param>
    /// <param name="item2">Tuple 的第二個元件的值。</param>
    [__DynamicallyInvokable]
    public Tuple(T1 item1, T2 item2)
    {
      this.m_Item1 = item1;
      this.m_Item2 = item2;
    }

    /// <summary>
    ///   傳回值，指出是否目前 <see cref="T:System.Tuple`2" /> 物件是否等於指定的物件。
    /// </summary>
    /// <param name="obj">與這個執行個體相互比較的物件。</param>
    /// <returns>
    ///   <see langword="true" /> 目前的執行個體是否等於指定的物件。否則， <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public override bool Equals(object obj) => ((IStructuralEquatable) this).Equals(obj, (IEqualityComparer) EqualityComparer<object>.Default);

    [__DynamicallyInvokable]
    bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => other != null && other is Tuple<T1, T2> tuple && comparer.Equals((object) this.m_Item1, (object) tuple.m_Item1) && comparer.Equals((object) this.m_Item2, (object) tuple.m_Item2);

    [__DynamicallyInvokable]
    int IComparable.CompareTo(object obj) => ((IStructuralComparable) this).CompareTo(obj, (IComparer) Comparer<object>.Default);

    [__DynamicallyInvokable]
    int IStructuralComparable.CompareTo(object other, IComparer comparer)
    {
      if (other == null)
        return 1;
      if (!(other is Tuple<T1, T2> tuple))
        throw new ArgumentException(Environment.GetResourceString("ArgumentException_TupleIncorrectType", (object) this.GetType().ToString()), nameof (other));
      int num = comparer.Compare((object) this.m_Item1, (object) tuple.m_Item1);
      return num != 0 ? num : comparer.Compare((object) this.m_Item2, (object) tuple.m_Item2);
    }

    /// <summary>
    ///   傳回目前的雜湊程式碼 <see cref="T:System.Tuple`2" /> 物件。
    /// </summary>
    /// <returns>32 位元帶正負號的整數雜湊碼。</returns>
    [__DynamicallyInvokable]
    public override int GetHashCode() => ((IStructuralEquatable) this).GetHashCode((IEqualityComparer) EqualityComparer<object>.Default);

    [__DynamicallyInvokable]
    int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => Tuple.CombineHashCodes(comparer.GetHashCode((object) this.m_Item1), comparer.GetHashCode((object) this.m_Item2));

    int ITupleInternal.GetHashCode(IEqualityComparer comparer) => ((IStructuralEquatable) this).GetHashCode(comparer);

    /// <summary>
    ///   傳回字串，表示這個 <see cref="T:System.Tuple`2" /> 執行個體的值。
    /// </summary>
    /// <returns>
    ///   此 <see cref="T:System.Tuple`2" /> 物件的字串表示。
    /// </returns>
    [__DynamicallyInvokable]
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("(");
      return ((ITupleInternal) this).ToString(sb);
    }

    string ITupleInternal.ToString(StringBuilder sb)
    {
      sb.Append((object) this.m_Item1);
      sb.Append(", ");
      sb.Append((object) this.m_Item2);
      sb.Append(")");
      return sb.ToString();
    }

    int ITuple.Length => 2;

    object ITuple.this[int index]
    {
      get
      {
        if (index == 0)
          return (object) this.Item1;
        if (index == 1)
          return (object) this.Item2;
        throw new IndexOutOfRangeException();
      }
    }
  }
}
