// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.List`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 62FFEEB7-EC02-4BEA-B61E-5FBF8D44AC5B
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Threading;

namespace System.Collections.Generic
{
  /// <summary>
  ///   表示可以依照索引存取的強類型物件清單。
  ///    提供搜尋、排序和管理清單的方法。
  /// 
  ///   若要瀏覽此類型的.NET Framework 原始程式碼，請參閱 Reference Source。
  /// </summary>
  /// <typeparam name="T">清單中項目的類型。</typeparam>
  [DebuggerTypeProxy(typeof (Mscorlib_CollectionDebugView<>))]
  [DebuggerDisplay("Count = {Count}")]
  [__DynamicallyInvokable]
  [Serializable]
  public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
  {
    private const int _defaultCapacity = 4;
    private T[] _items;
    private int _size;
    private int _version;
    [NonSerialized]
    private object _syncRoot;
    private static readonly T[] _emptyArray = new T[0];

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.List`1" /> 類別的新執行個體，這個執行個體為空白且具有預設的初始容量。
    /// </summary>
    [__DynamicallyInvokable]
    public List() => this._items = List<T>._emptyArray;

    /// <summary>
    ///   為具有指定初始容量且為空的 <see cref="T:System.Collections.Generic.List`1" /> 類別，初始化新的執行個體。
    /// </summary>
    /// <param name="capacity">新清單一開始能夠儲存的項目數目。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="capacity" /> 小於 0。
    /// </exception>
    [__DynamicallyInvokable]
    public List(int capacity)
    {
      if (capacity < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (capacity == 0)
        this._items = List<T>._emptyArray;
      else
        this._items = new T[capacity];
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.List`1" /> 類別的新執行個體，其包含從指定之集合複製的項目，且具有容納複製之項目數目的足夠容量。
    /// </summary>
    /// <param name="collection">將其項目複製到新清單的來源集合。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="collection" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public List(IEnumerable<T> collection)
    {
      if (collection == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
      if (collection is ICollection<T> objs)
      {
        int count = objs.Count;
        if (count == 0)
        {
          this._items = List<T>._emptyArray;
        }
        else
        {
          this._items = new T[count];
          objs.CopyTo(this._items, 0);
          this._size = count;
        }
      }
      else
      {
        this._size = 0;
        this._items = List<T>._emptyArray;
        foreach (T obj in collection)
          this.Add(obj);
      }
    }

    /// <summary>在不需要調整大小之下，取得或設定內部資料結構可以保存的項目總數。</summary>
    /// <returns>
    ///   需要調整大小之前，<see cref="T:System.Collections.Generic.List`1" /> 可包含的項目數目。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <see cref="P:System.Collections.Generic.List`1.Capacity" /> 是設定為小於 <see cref="P:System.Collections.Generic.List`1.Count" /> 的值。
    /// </exception>
    /// <exception cref="T:System.OutOfMemoryException">
    ///   系統上沒有足夠的記憶體可用。
    /// </exception>
    [__DynamicallyInvokable]
    public int Capacity
    {
      [__DynamicallyInvokable] get => this._items.Length;
      [__DynamicallyInvokable] set
      {
        if (value < this._size)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
        if (value == this._items.Length)
          return;
        if (value > 0)
        {
          T[] objArray = new T[value];
          if (this._size > 0)
            Array.Copy((Array) this._items, 0, (Array) objArray, 0, this._size);
          this._items = objArray;
        }
        else
          this._items = List<T>._emptyArray;
      }
    }

    /// <summary>
    ///   取得 <see cref="T:System.Collections.Generic.List`1" /> 中所包含的項目數。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.List`1" /> 中所包含的項目數。
    /// </returns>
    [__DynamicallyInvokable]
    public int Count
    {
      [__DynamicallyInvokable] get => this._size;
    }

    [__DynamicallyInvokable]
    bool IList.IsFixedSize
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    bool ICollection<T>.IsReadOnly
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    bool IList.IsReadOnly
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    bool ICollection.IsSynchronized
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    object ICollection.SyncRoot
    {
      [__DynamicallyInvokable] get
      {
        if (this._syncRoot == null)
          Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), (object) null);
        return this._syncRoot;
      }
    }

    /// <summary>在指定的索引位置上取得或設定項目。</summary>
    /// <param name="index">要取得或設定之以零為起始的項目索引。</param>
    /// <returns>在指定索引上的項目。</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 等於或大於 <see cref="P:System.Collections.Generic.List`1.Count" />。
    /// </exception>
    [__DynamicallyInvokable]
    public T this[int index]
    {
      [__DynamicallyInvokable] get
      {
        if ((uint) index >= (uint) this._size)
          ThrowHelper.ThrowArgumentOutOfRangeException();
        return this._items[index];
      }
      [__DynamicallyInvokable] set
      {
        if ((uint) index >= (uint) this._size)
          ThrowHelper.ThrowArgumentOutOfRangeException();
        this._items[index] = value;
        ++this._version;
      }
    }

    private static bool IsCompatibleObject(object value)
    {
      if (value is T)
        return true;
      return value == null && (object) default (T) == null;
    }

    [__DynamicallyInvokable]
    object IList.this[int index]
    {
      [__DynamicallyInvokable] get => (object) this[index];
      [__DynamicallyInvokable] set
      {
        ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
        try
        {
          this[index] = (T) value;
        }
        catch (InvalidCastException ex)
        {
          ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof (T));
        }
      }
    }

    /// <summary>
    ///   將物件加入至 <see cref="T:System.Collections.Generic.List`1" /> 的末端。
    /// </summary>
    /// <param name="item">
    ///   要加入至 <see cref="T:System.Collections.Generic.List`1" /> 結尾的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    [__DynamicallyInvokable]
    public void Add(T item)
    {
      if (this._size == this._items.Length)
        this.EnsureCapacity(this._size + 1);
      this._items[this._size++] = item;
      ++this._version;
    }

    [__DynamicallyInvokable]
    int IList.Add(object item)
    {
      ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
      try
      {
        this.Add((T) item);
      }
      catch (InvalidCastException ex)
      {
        ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof (T));
      }
      return this.Count - 1;
    }

    /// <summary>
    ///   將特定集合的項目加入至 <see cref="T:System.Collections.Generic.List`1" /> 的結尾。
    /// </summary>
    /// <param name="collection">
    ///   集合，其項目應加入至 <see cref="T:System.Collections.Generic.List`1" /> 的結尾。
    ///    集合本身不可為 <see langword="null" />，但如果類型 <paramref name="T" /> 是參考類型，則其可以包含為 <see langword="null" /> 的項目。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="collection" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public void AddRange(IEnumerable<T> collection) => this.InsertRange(this._size, collection);

    /// <summary>
    ///   傳回目前集合的唯讀 <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> 包裝函式。
    /// </summary>
    /// <returns>
    ///   此物件做為唯讀包裝函式包住目前的 <see cref="T:System.Collections.Generic.List`1" />。
    /// </returns>
    [__DynamicallyInvokable]
    public ReadOnlyCollection<T> AsReadOnly() => new ReadOnlyCollection<T>((IList<T>) this);

    /// <summary>
    ///   使用指定的比較子在已經過排序之 <see cref="T:System.Collections.Generic.List`1" /> 內，搜尋某範圍的項目，並傳回該項目以零為起始的索引。
    /// </summary>
    /// <param name="index">要搜尋範圍內之以零為起始的起始索引。</param>
    /// <param name="count">搜尋範圍的長度。</param>
    /// <param name="item">
    ///   要尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="comparer">
    ///   比較項目時要使用的 <see cref="T:System.Collections.Generic.IComparer`1" /> 實作，或 <see langword="null" /> 表示使用預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" />。
    /// </param>
    /// <returns>
    ///   如果有找到 <paramref name="item" />，則為已排序的 <see cref="T:System.Collections.Generic.List`1" /> 中 <paramref name="item" /> 之以零為起始的索引，否則便為負數，此負數為大於 <paramref name="item" /> 的下一個項目索引之位元補數，或者，如果沒有更大的項目，則為 <see cref="P:System.Collections.Generic.List`1.Count" /> 的位元補數。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不代表 <see cref="T:System.Collections.Generic.List`1" /> 中的有效範圍。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="comparer" /> 為 <see langword="null" />，而且預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    [__DynamicallyInvokable]
    public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
    {
      if (index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      return Array.BinarySearch<T>(this._items, index, count, item, comparer);
    }

    /// <summary>
    ///   使用預設的比較子並傳回項目以零為起始的索引，來搜尋項目之整個排序的 <see cref="T:System.Collections.Generic.List`1" />。
    /// </summary>
    /// <param name="item">
    ///   要尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果有找到 <paramref name="item" />，則為已排序的 <see cref="T:System.Collections.Generic.List`1" /> 中 <paramref name="item" /> 之以零為起始的索引，否則便為負數，此負數為大於 <paramref name="item" /> 的下一個項目索引之位元補數，或者，如果沒有更大的項目，則為 <see cref="P:System.Collections.Generic.List`1.Count" /> 的位元補數。
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    ///   預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    [__DynamicallyInvokable]
    public int BinarySearch(T item) => this.BinarySearch(0, this.Count, item, (IComparer<T>) null);

    /// <summary>
    ///   使用指定的比較子並傳回項目以零為起始的索引，來搜尋項目之整個排序的 <see cref="T:System.Collections.Generic.List`1" />。
    /// </summary>
    /// <param name="item">
    ///   要尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="comparer">
    ///   比較項目時所要使用的 <see cref="T:System.Collections.Generic.IComparer`1" /> 實作。
    /// 
    ///   -或-
    /// 
    ///   <see langword="null" /> 表示使用預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" />。
    /// </param>
    /// <returns>
    ///   如果有找到 <paramref name="item" />，則為已排序的 <see cref="T:System.Collections.Generic.List`1" /> 中 <paramref name="item" /> 之以零為起始的索引，否則便為負數，此負數為大於 <paramref name="item" /> 的下一個項目索引之位元補數，或者，如果沒有更大的項目，則為 <see cref="P:System.Collections.Generic.List`1.Count" /> 的位元補數。
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="comparer" /> 為 <see langword="null" />，而且預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    [__DynamicallyInvokable]
    public int BinarySearch(T item, IComparer<T> comparer) => this.BinarySearch(0, this.Count, item, comparer);

    /// <summary>
    ///   將所有項目從 <see cref="T:System.Collections.Generic.List`1" /> 移除。
    /// </summary>
    [__DynamicallyInvokable]
    public void Clear()
    {
      if (this._size > 0)
      {
        Array.Clear((Array) this._items, 0, this._size);
        this._size = 0;
      }
      ++this._version;
    }

    /// <summary>
    ///   判斷某項目是否在 <see cref="T:System.Collections.Generic.List`1" /> 中。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果在 <see langword="true" /> 中找到 <paramref name="item" />，則為 <see cref="T:System.Collections.Generic.List`1" />，否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public bool Contains(T item)
    {
      if ((object) item == null)
      {
        for (int index = 0; index < this._size; ++index)
        {
          if ((object) this._items[index] == null)
            return true;
        }
        return false;
      }
      EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
      for (int index = 0; index < this._size; ++index)
      {
        if (equalityComparer.Equals(this._items[index], item))
          return true;
      }
      return false;
    }

    [__DynamicallyInvokable]
    bool IList.Contains(object item) => List<T>.IsCompatibleObject(item) && this.Contains((T) item);

    /// <summary>
    ///   將目前 <see cref="T:System.Collections.Generic.List`1" /> 中的項目轉換成另一個類型，並傳回包含轉換過的項目清單。
    /// </summary>
    /// <param name="converter">
    ///   <see cref="T:System.Converter`2" /> 委派，可將某一個類型的每一個項目轉換成另一個類型。
    /// </param>
    /// <typeparam name="TOutput">目標陣列項目的類型。</typeparam>
    /// <returns>
    ///   目標類型的 <see cref="T:System.Collections.Generic.List`1" />，包含從目前 <see cref="T:System.Collections.Generic.List`1" /> 中轉換過的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="converter" /> 為 <see langword="null" />。
    /// </exception>
    public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
    {
      if (converter == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.converter);
      List<TOutput> outputList = new List<TOutput>(this._size);
      for (int index = 0; index < this._size; ++index)
        outputList._items[index] = converter(this._items[index]);
      outputList._size = this._size;
      return outputList;
    }

    /// <summary>
    ///   從目標陣列的開頭開始，將整個 <see cref="T:System.Collections.Generic.List`1" /> 複製到相容的一維陣列。
    /// </summary>
    /// <param name="array">
    ///   一維 <see cref="T:System.Array" />，是從 <see cref="T:System.Collections.Generic.List`1" /> 複製過來之項目的目的端。
    ///   <see cref="T:System.Array" /> 必須有以零為起始的索引。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="array" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   來源 <see cref="T:System.Collections.Generic.List`1" /> 中的項目數大於目的 <paramref name="array" /> 可包含的項目數。
    /// </exception>
    [__DynamicallyInvokable]
    public void CopyTo(T[] array) => this.CopyTo(array, 0);

    [__DynamicallyInvokable]
    void ICollection.CopyTo(Array array, int arrayIndex)
    {
      if (array != null && array.Rank != 1)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
      try
      {
        Array.Copy((Array) this._items, 0, array, arrayIndex, this._size);
      }
      catch (ArrayTypeMismatchException ex)
      {
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
      }
    }

    /// <summary>
    ///   從目標陣列的指定索引處開始，將項目範圍從 <see cref="T:System.Collections.Generic.List`1" /> 複製到相容的一維陣列。
    /// </summary>
    /// <param name="index">
    ///   來源 <see cref="T:System.Collections.Generic.List`1" /> 中以零為起始的索引，位於複製開始的位置。
    /// </param>
    /// <param name="array">
    ///   一維 <see cref="T:System.Array" />，是從 <see cref="T:System.Collections.Generic.List`1" /> 複製過來之項目的目的端。
    ///   <see cref="T:System.Array" /> 必須有以零為起始的索引。
    /// </param>
    /// <param name="arrayIndex">
    ///   <paramref name="array" /> 中以零起始的索引，即開始複製的位置。
    /// </param>
    /// <param name="count">要複製的項目數目。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="array" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="arrayIndex" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 等於或大於來源 <see cref="T:System.Collections.Generic.List`1" /> 的 <see cref="P:System.Collections.Generic.List`1.Count" />。
    /// 
    ///   -或-
    /// 
    ///   從 <paramref name="index" /> 到來源 <see cref="T:System.Collections.Generic.List`1" /> 結尾的項目數目，大於從 <paramref name="arrayIndex" /> 到目的 <paramref name="array" /> 結尾的可用空間。
    /// </exception>
    [__DynamicallyInvokable]
    public void CopyTo(int index, T[] array, int arrayIndex, int count)
    {
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      Array.Copy((Array) this._items, index, (Array) array, arrayIndex, count);
    }

    /// <summary>
    ///   從目標陣列的指定索引處開始，將整個 <see cref="T:System.Collections.Generic.List`1" /> 複製到相容的一維陣列中。
    /// </summary>
    /// <param name="array">
    ///   一維 <see cref="T:System.Array" />，是從 <see cref="T:System.Collections.Generic.List`1" /> 複製過來之項目的目的端。
    ///   <see cref="T:System.Array" /> 必須有以零為起始的索引。
    /// </param>
    /// <param name="arrayIndex">
    ///   <paramref name="array" /> 中以零起始的索引，即開始複製的位置。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="array" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="arrayIndex" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   來源 <see cref="T:System.Collections.Generic.List`1" /> 中的項目數目，大於 <paramref name="arrayIndex" /> 到目的 <paramref name="array" /> 結尾的可用空間。
    /// </exception>
    [__DynamicallyInvokable]
    public void CopyTo(T[] array, int arrayIndex) => Array.Copy((Array) this._items, 0, (Array) array, arrayIndex, this._size);

    private void EnsureCapacity(int min)
    {
      if (this._items.Length >= min)
        return;
      int num = this._items.Length == 0 ? 4 : this._items.Length * 2;
      if ((uint) num > 2146435071U)
        num = 2146435071;
      if (num < min)
        num = min;
      this.Capacity = num;
    }

    /// <summary>
    ///   判斷 <see cref="T:System.Collections.Generic.List`1" /> 是否包含符合指定之述詞所定義之條件的項目。
    /// </summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   如果 <see cref="T:System.Collections.Generic.List`1" /> 包含的一或多個項目符合指定之述詞所定義的條件，則為 <see langword="true" />，否則為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public bool Exists(Predicate<T> match) => this.FindIndex(match) != -1;

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 內第一個相符的項目。
    /// </summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   第一個符合指定之述詞所定義的條件之項目 (如有找到)，否則為類型 <paramref name="T" /> 的預設值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public T Find(Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      for (int index = 0; index < this._size; ++index)
      {
        if (match(this._items[index]))
          return this._items[index];
      }
      return default (T);
    }

    /// <summary>擷取符合指定之述詞所定義的條件之所有項目。</summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.List`1" />，其中包含符合指定之述詞所定義的條件之所有項目 (如有找到)，否則為空的 <see cref="T:System.Collections.Generic.List`1" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public List<T> FindAll(Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      List<T> objList = new List<T>();
      for (int index = 0; index < this._size; ++index)
      {
        if (match(this._items[index]))
          objList.Add(this._items[index]);
      }
      return objList;
    }

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 內第一次出現之以零為起始的索引。
    /// </summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   第一次出現符合 <paramref name="match" /> 所定義之條件的項目以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindIndex(Predicate<T> match) => this.FindIndex(0, this._size, match);

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回 <see cref="T:System.Collections.Generic.List`1" /> 內 (從指定之索引延伸到最後一個項目)，於某項目範圍中第一次出現之以零為起始的索引。
    /// </summary>
    /// <param name="startIndex">搜尋之以零為起始的起始索引。</param>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   第一次出現符合 <paramref name="match" /> 所定義之條件的項目以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="startIndex" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindIndex(int startIndex, Predicate<T> match) => this.FindIndex(startIndex, this._size - startIndex, match);

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回 <see cref="T:System.Collections.Generic.List`1" /> 中從指定之索引開始，且包含指定之項目數目的項目範圍內第一個符合項目之以零為起始的索引。
    /// </summary>
    /// <param name="startIndex">搜尋之以零為起始的起始索引。</param>
    /// <param name="count">區段中要搜尋的項目數目。</param>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   第一次出現符合 <paramref name="match" /> 所定義之條件的項目以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="startIndex" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="startIndex" /> 和 <paramref name="count" /> 不指定 <see cref="T:System.Collections.Generic.List`1" /> 的有效區段。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindIndex(int startIndex, int count, Predicate<T> match)
    {
      if ((uint) startIndex > (uint) this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
      if (count < 0 || startIndex > this._size - count)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      int num = startIndex + count;
      for (int index = startIndex; index < num; ++index)
      {
        if (match(this._items[index]))
          return index;
      }
      return -1;
    }

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 內最後一個相符的項目。
    /// </summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   最後一個符合指定之述詞所定義的條件之項目 (如有找到)，否則為類型 <paramref name="T" /> 的預設值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public T FindLast(Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      for (int index = this._size - 1; index >= 0; --index)
      {
        if (match(this._items[index]))
          return this._items[index];
      }
      return default (T);
    }

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 內最後一次出現之以為零起始的索引。
    /// </summary>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   符合 <paramref name="match" /> 所定義之條件且最後一次出現之項目的以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindLastIndex(Predicate<T> match) => this.FindLastIndex(this._size - 1, this._size, match);

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回 <see cref="T:System.Collections.Generic.List`1" /> 中從第一個項目延伸到指定之索引的項目範圍內，最後一個符合項目之以零為起始的索引。
    /// </summary>
    /// <param name="startIndex">向後搜尋之以零為起始的起始索引。</param>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   符合 <paramref name="match" /> 所定義之條件且最後一次出現之項目的以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="startIndex" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindLastIndex(int startIndex, Predicate<T> match) => this.FindLastIndex(startIndex, startIndex + 1, match);

    /// <summary>
    ///   搜尋符合指定之述詞所定義的條件之項目，並傳回 <see cref="T:System.Collections.Generic.List`1" /> 中包含指定之項目數目，且結束於指定之索引的項目範圍內最後一個符合項目之以零為起始的索引。
    /// </summary>
    /// <param name="startIndex">向後搜尋之以零為起始的起始索引。</param>
    /// <param name="count">區段中要搜尋的項目數目。</param>
    /// <param name="match">
    ///   定義要搜尋項目之條件的 <see cref="T:System.Predicate`1" /> 委派。
    /// </param>
    /// <returns>
    ///   符合 <paramref name="match" /> 所定義之條件且最後一次出現之項目的以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="startIndex" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="startIndex" /> 和 <paramref name="count" /> 不指定 <see cref="T:System.Collections.Generic.List`1" /> 的有效區段。
    /// </exception>
    [__DynamicallyInvokable]
    public int FindLastIndex(int startIndex, int count, Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      if (this._size == 0)
      {
        if (startIndex != -1)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
      }
      else if ((uint) startIndex >= (uint) this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
      if (count < 0 || startIndex - count + 1 < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
      int num = startIndex - count;
      for (int index = startIndex; index > num; --index)
      {
        if (match(this._items[index]))
          return index;
      }
      return -1;
    }

    /// <summary>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 的每一個項目上執行指定之動作。
    /// </summary>
    /// <param name="action">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 的每一個項目上執行的 <see cref="T:System.Action`1" /> 委派。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="action" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    /// 集合中的項目已經過修改。
    /// 
    ///   會擲回這個例外狀況，從.NET Framework 4.5 開始。
    /// </exception>
    [__DynamicallyInvokable]
    public void ForEach(Action<T> action)
    {
      if (action == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      int version = this._version;
      for (int index = 0; index < this._size && (version == this._version || !BinaryCompatibility.TargetsAtLeast_Desktop_V4_5); ++index)
        action(this._items[index]);
      if (version == this._version || !BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
        return;
      ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
    }

    /// <summary>
    ///   傳回在 <see cref="T:System.Collections.Generic.List`1" /> 中逐一查看的列舉值。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.List`1.Enumerator" /> 的 <see cref="T:System.Collections.Generic.List`1" />。
    /// </returns>
    [__DynamicallyInvokable]
    public List<T>.Enumerator GetEnumerator() => new List<T>.Enumerator(this);

    [__DynamicallyInvokable]
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new List<T>.Enumerator(this);

    [__DynamicallyInvokable]
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new List<T>.Enumerator(this);

    /// <summary>
    ///   為來源 <see cref="T:System.Collections.Generic.List`1" /> 中的項目範圍建立淺層複本。
    /// </summary>
    /// <param name="index">
    ///   範圍起始處之以零為起始的 <see cref="T:System.Collections.Generic.List`1" /> 索引。
    /// </param>
    /// <param name="count">範圍中的項目數。</param>
    /// <returns>
    ///   來源 <see cref="T:System.Collections.Generic.List`1" /> 中項目範圍的淺層複本。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不代表 <see cref="T:System.Collections.Generic.List`1" /> 中項目的有效範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public List<T> GetRange(int index, int count)
    {
      if (index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      List<T> objList = new List<T>(count);
      Array.Copy((Array) this._items, index, (Array) objList._items, 0, count);
      objList._size = count;
      return objList;
    }

    /// <summary>
    ///   搜尋指定的物件，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 中第一個出現之以零為起始的索引。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果有找到，則是在整個 <paramref name="item" /> 內，<see cref="T:System.Collections.Generic.List`1" /> 之第一次出現的以零起始的索引，否則為 -1。
    /// </returns>
    [__DynamicallyInvokable]
    public int IndexOf(T item) => Array.IndexOf<T>(this._items, item, 0, this._size);

    [__DynamicallyInvokable]
    int IList.IndexOf(object item) => List<T>.IsCompatibleObject(item) ? this.IndexOf((T) item) : -1;

    /// <summary>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從指定的索引開始到最後一個項目這段範圍內，搜尋指定的物件第一次出現的位置，並傳回其索引值 (索引以零為起始)。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="index">
    ///   搜尋之以零為起始的起始索引。
    ///    0 (零) 在空白清單中有效。
    /// </param>
    /// <returns>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從 <paramref name="index" /> 開始到最後一個項目的範圍內，第一次出現 <paramref name="item" /> 的位置之以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public int IndexOf(T item, int index)
    {
      if (index > this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
      return Array.IndexOf<T>(this._items, item, index, this._size - index);
    }

    /// <summary>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從指定索引開始且包含指定個數項目的範圍內，搜尋指定的物件第一次出現的位置，並傳回其索引值 (索引以零為起始)。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="index">
    ///   搜尋之以零為起始的起始索引。
    ///    0 (零) 在空白清單中有效。
    /// </param>
    /// <param name="count">區段中要搜尋的項目數目。</param>
    /// <returns>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從 <paramref name="index" /> 開始且包含 <paramref name="count" /> 個項目的範圍內，第一次出現 <paramref name="item" /> 之以零為起始的索引，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不指定 <see cref="T:System.Collections.Generic.List`1" /> 的有效區段。
    /// </exception>
    [__DynamicallyInvokable]
    public int IndexOf(T item, int index, int count)
    {
      if (index > this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
      if (count < 0 || index > this._size - count)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
      return Array.IndexOf<T>(this._items, item, index, count);
    }

    /// <summary>
    ///   將項目插入至 <see cref="T:System.Collections.Generic.List`1" /> 中指定的索引位置。
    /// </summary>
    /// <param name="index">
    ///   應在 <paramref name="item" /> 插入以零為起始的索引。
    /// </param>
    /// <param name="item">
    ///   要插入的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 大於 <see cref="P:System.Collections.Generic.List`1.Count" />。
    /// </exception>
    [__DynamicallyInvokable]
    public void Insert(int index, T item)
    {
      if ((uint) index > (uint) this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
      if (this._size == this._items.Length)
        this.EnsureCapacity(this._size + 1);
      if (index < this._size)
        Array.Copy((Array) this._items, index, (Array) this._items, index + 1, this._size - index);
      this._items[index] = item;
      ++this._size;
      ++this._version;
    }

    [__DynamicallyInvokable]
    void IList.Insert(int index, object item)
    {
      ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
      try
      {
        this.Insert(index, (T) item);
      }
      catch (InvalidCastException ex)
      {
        ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof (T));
      }
    }

    /// <summary>
    ///   將集合的項目插入位於指定索引的 <see cref="T:System.Collections.Generic.List`1" /> 中。
    /// </summary>
    /// <param name="index">應插入新項目處的以零為起始的索引。</param>
    /// <param name="collection">
    ///   集合，其項目應插入至 <see cref="T:System.Collections.Generic.List`1" />。
    ///    集合本身不可為 <see langword="null" />，但如果類型 <paramref name="T" /> 是參考類型，則其可以包含為 <see langword="null" /> 的項目。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="collection" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 大於 <see cref="P:System.Collections.Generic.List`1.Count" />。
    /// </exception>
    [__DynamicallyInvokable]
    public void InsertRange(int index, IEnumerable<T> collection)
    {
      if (collection == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
      if ((uint) index > (uint) this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
      if (collection is ICollection<T> objs)
      {
        int count = objs.Count;
        if (count > 0)
        {
          this.EnsureCapacity(this._size + count);
          if (index < this._size)
            Array.Copy((Array) this._items, index, (Array) this._items, index + count, this._size - index);
          if (this == objs)
          {
            Array.Copy((Array) this._items, 0, (Array) this._items, index, index);
            Array.Copy((Array) this._items, index + count, (Array) this._items, index * 2, this._size - index);
          }
          else
          {
            T[] array = new T[count];
            objs.CopyTo(array, 0);
            array.CopyTo((Array) this._items, index);
          }
          this._size += count;
        }
      }
      else
      {
        foreach (T obj in collection)
          this.Insert(index++, obj);
      }
      ++this._version;
    }

    /// <summary>
    ///   搜尋指定的物件，並傳回整個 <see cref="T:System.Collections.Generic.List`1" /> 中最後一個相符項目之以零為起始的索引。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果找到的話，則為整個 <see cref="T:System.Collections.Generic.List`1" /> 中最後一次出現 <paramref name="item" /> 之以零為起始的索引 (如有找到)，如未找到則為 -1。
    /// </returns>
    [__DynamicallyInvokable]
    public int LastIndexOf(T item) => this._size == 0 ? -1 : this.LastIndexOf(item, this._size - 1, this._size);

    /// <summary>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從第一個項目開始到指定的索引這段範圍內，搜尋指定的物件最後一次出現的位置，並傳回其索引值 (索引以零為起始)。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="index">向後搜尋之以零為起始的起始索引。</param>
    /// <returns>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中從第一個項目開始到 <paramref name="index" /> 這段範圍內，如果有找到指定的 <paramref name="item" /> 最後一次出現的位置，則為該位置以零為起始的索引，如未找到則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public int LastIndexOf(T item, int index)
    {
      if (index >= this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_Index);
      return this.LastIndexOf(item, index, index + 1);
    }

    /// <summary>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中包含指定個數項目且結尾位於指定索引的範圍內，搜尋指定的物件最後一次出現的位置，並傳回其索引值 (索引以零為起始)。
    /// </summary>
    /// <param name="item">
    ///   要在 <see cref="T:System.Collections.Generic.List`1" /> 中尋找的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <param name="index">向後搜尋之以零為起始的起始索引。</param>
    /// <param name="count">區段中要搜尋的項目數目。</param>
    /// <returns>
    ///   在 <see cref="T:System.Collections.Generic.List`1" /> 中含有 <paramref name="count" /> 個項目且結尾位置為 <paramref name="index" /> 的範圍內，如果有找到指定的 <paramref name="item" /> 最後一次出現的位置，則為該位置的索引 (從零開始起算)，否則為 -1。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 超出 <see cref="T:System.Collections.Generic.List`1" /> 的有效索引範圍。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不指定 <see cref="T:System.Collections.Generic.List`1" /> 的有效區段。
    /// </exception>
    [__DynamicallyInvokable]
    public int LastIndexOf(T item, int index, int count)
    {
      if (this.Count != 0 && index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this.Count != 0 && count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size == 0)
        return -1;
      if (index >= this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
      if (count > index + 1)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
      return Array.LastIndexOf<T>(this._items, item, index, count);
    }

    /// <summary>
    ///   從 <see cref="T:System.Collections.Generic.List`1" /> 移除特定物件之第一個符合的元素。
    /// </summary>
    /// <param name="item">
    ///   要從 <see cref="T:System.Collections.Generic.List`1" /> 移除的物件。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果成功移除 <paramref name="item" /> 則為 <see langword="true" />，否則為 <see langword="false" />。
    ///     如果在 <see langword="false" /> 中找不到 <paramref name="item" />，則這個方法也會傳回 <see cref="T:System.Collections.Generic.List`1" />。
    /// </returns>
    [__DynamicallyInvokable]
    public bool Remove(T item)
    {
      int index = this.IndexOf(item);
      if (index < 0)
        return false;
      this.RemoveAt(index);
      return true;
    }

    [__DynamicallyInvokable]
    void IList.Remove(object item)
    {
      if (!List<T>.IsCompatibleObject(item))
        return;
      this.Remove((T) item);
    }

    /// <summary>移除符合指定的述詞所定義之條件的所有項目。</summary>
    /// <param name="match">
    ///   <see cref="T:System.Predicate`1" /> 委派，定義要移除項目的條件。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.List`1" /> 中已移除的項目數。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public int RemoveAll(Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      int index1 = 0;
      while (index1 < this._size && !match(this._items[index1]))
        ++index1;
      if (index1 >= this._size)
        return 0;
      int index2 = index1 + 1;
      while (index2 < this._size)
      {
        while (index2 < this._size && match(this._items[index2]))
          ++index2;
        if (index2 < this._size)
          this._items[index1++] = this._items[index2++];
      }
      Array.Clear((Array) this._items, index1, this._size - index1);
      int num = this._size - index1;
      this._size = index1;
      ++this._version;
      return num;
    }

    /// <summary>
    ///   移除 <see cref="T:System.Collections.Generic.List`1" /> 中指定之索引處的項目。
    /// </summary>
    /// <param name="index">移除項目之以零為起始的索引。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="index" /> 等於或大於 <see cref="P:System.Collections.Generic.List`1.Count" />。
    /// </exception>
    [__DynamicallyInvokable]
    public void RemoveAt(int index)
    {
      if ((uint) index >= (uint) this._size)
        ThrowHelper.ThrowArgumentOutOfRangeException();
      --this._size;
      if (index < this._size)
        Array.Copy((Array) this._items, index + 1, (Array) this._items, index, this._size - index);
      this._items[this._size] = default (T);
      ++this._version;
    }

    /// <summary>
    ///   從 <see cref="T:System.Collections.Generic.List`1" /> 移除的項目範圍。
    /// </summary>
    /// <param name="index">要移除之項目範圍內之以零為起始的起始索引。</param>
    /// <param name="count">要移除的項目數目。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不代表 <see cref="T:System.Collections.Generic.List`1" /> 中項目的有效範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public void RemoveRange(int index, int count)
    {
      if (index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      if (count <= 0)
        return;
      int size = this._size;
      this._size -= count;
      if (index < this._size)
        Array.Copy((Array) this._items, index + count, (Array) this._items, index, this._size - index);
      Array.Clear((Array) this._items, this._size, count);
      ++this._version;
    }

    /// <summary>
    ///   反轉整個 <see cref="T:System.Collections.Generic.List`1" /> 中項目的順序。
    /// </summary>
    [__DynamicallyInvokable]
    public void Reverse() => this.Reverse(0, this.Count);

    /// <summary>反向指定範圍中項目的順序。</summary>
    /// <param name="index">要反向範圍內之以零為起始的起始索引。</param>
    /// <param name="count">要反向範圍中的項目數。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 和 <paramref name="count" /> 不代表 <see cref="T:System.Collections.Generic.List`1" /> 中項目的有效範圍。
    /// </exception>
    [__DynamicallyInvokable]
    public void Reverse(int index, int count)
    {
      if (index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      Array.Reverse((Array) this._items, index, count);
      ++this._version;
    }

    /// <summary>
    ///   使用預設的比較子來排序在整個 <see cref="T:System.Collections.Generic.List`1" /> 中的項目。
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">
    ///   預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    [__DynamicallyInvokable]
    public void Sort() => this.Sort(0, this.Count, (IComparer<T>) null);

    /// <summary>
    ///   使用指定的比較子來排序在整個 <see cref="T:System.Collections.Generic.List`1" /> 中的項目。
    /// </summary>
    /// <param name="comparer">
    ///   比較項目時要使用的 <see cref="T:System.Collections.Generic.IComparer`1" /> 實作，或 <see langword="null" /> 表示使用預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" />。
    /// </param>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="comparer" /> 為 <see langword="null" />，而且預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="comparer" /> 的實作在排序期間造成錯誤。
    ///    例如，在將項目與其本身比較時，<paramref name="comparer" /> 可能不會傳回 0。
    /// </exception>
    [__DynamicallyInvokable]
    public void Sort(IComparer<T> comparer) => this.Sort(0, this.Count, comparer);

    /// <summary>
    ///   使用指定的比較子對 <see cref="T:System.Collections.Generic.List`1" /> 中某段範圍內的項目進行排序。
    /// </summary>
    /// <param name="index">要排序範圍內之以零為起始的起始索引。</param>
    /// <param name="count">要排序的範圍長度。</param>
    /// <param name="comparer">
    ///   比較項目時要使用的 <see cref="T:System.Collections.Generic.IComparer`1" /> 實作，或 <see langword="null" /> 表示使用預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" />。
    /// </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="index" /> 和 <paramref name="count" /> 未指定 <see cref="T:System.Collections.Generic.List`1" /> 中的有效範圍。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="comparer" /> 的實作在排序期間造成錯誤。
    ///    例如，在將項目與其本身比較時，<paramref name="comparer" /> 可能不會傳回 0。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="comparer" /> 為 <see langword="null" />，而且預設比較子 <see cref="P:System.Collections.Generic.Comparer`1.Default" /> 找不到 <see cref="T:System.IComparable`1" /> 泛型介面的實作或 <paramref name="T" /> 類型的 <see cref="T:System.IComparable" /> 介面。
    /// </exception>
    [__DynamicallyInvokable]
    public void Sort(int index, int count, IComparer<T> comparer)
    {
      if (index < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (count < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (this._size - index < count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
      Array.Sort<T>(this._items, index, count, comparer);
      ++this._version;
    }

    /// <summary>
    ///   使用指定的 <see cref="T:System.Comparison`1" /> 來排序在整個 <see cref="T:System.Collections.Generic.List`1" /> 中的項目。
    /// </summary>
    /// <param name="comparison">
    ///   比較項目時所要使用的 <see cref="T:System.Comparison`1" />。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="comparison" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="comparison" /> 的實作在排序期間造成錯誤。
    ///    例如，在將項目與其本身比較時，<paramref name="comparison" /> 可能不會傳回 0。
    /// </exception>
    [__DynamicallyInvokable]
    public void Sort(Comparison<T> comparison)
    {
      if (comparison == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      if (this._size <= 0)
        return;
      Array.Sort<T>(this._items, 0, this._size, (IComparer<T>) new Array.FunctorComparer<T>(comparison));
    }

    /// <summary>
    ///   將 <see cref="T:System.Collections.Generic.List`1" /> 的項目複製到新的陣列。
    /// </summary>
    /// <returns>
    ///   含有 <see cref="T:System.Collections.Generic.List`1" /> 的項目複本的陣列。
    /// </returns>
    [__DynamicallyInvokable]
    public T[] ToArray()
    {
      T[] objArray = new T[this._size];
      Array.Copy((Array) this._items, 0, (Array) objArray, 0, this._size);
      return objArray;
    }

    /// <summary>
    ///   將容量設為 <see cref="T:System.Collections.Generic.List`1" /> 中項目的實際數目，如果該數目小於臨界值。
    /// </summary>
    [__DynamicallyInvokable]
    public void TrimExcess()
    {
      if (this._size >= (int) ((double) this._items.Length * 0.9))
        return;
      this.Capacity = this._size;
    }

    /// <summary>
    ///   判斷 <see cref="T:System.Collections.Generic.List`1" /> 中的每一個項目是否符合指定之述詞所定義的條件。
    /// </summary>
    /// <param name="match">
    ///   <see cref="T:System.Predicate`1" /> 委派，可定義檢查項目所根據的條件。
    /// </param>
    /// <returns>
    ///   如果 <see cref="T:System.Collections.Generic.List`1" /> 中的每一個項目都符合指定之述詞所定義的條件，則為 <see langword="true" />，否則為 <see langword="false" />。
    ///    如果清單中沒有項目，則傳回值為 <see langword="true" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="match" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public bool TrueForAll(Predicate<T> match)
    {
      if (match == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
      for (int index = 0; index < this._size; ++index)
      {
        if (!match(this._items[index]))
          return false;
      }
      return true;
    }

    internal static IList<T> Synchronized(List<T> list) => (IList<T>) new List<T>.SynchronizedList(list);

    [Serializable]
    internal class SynchronizedList : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
    {
      private List<T> _list;
      private object _root;

      internal SynchronizedList(List<T> list)
      {
        this._list = list;
        this._root = ((ICollection) list).SyncRoot;
      }

      public int Count
      {
        get
        {
          lock (this._root)
            return this._list.Count;
        }
      }

      public bool IsReadOnly => ((ICollection<T>) this._list).IsReadOnly;

      public void Add(T item)
      {
        lock (this._root)
          this._list.Add(item);
      }

      public void Clear()
      {
        lock (this._root)
          this._list.Clear();
      }

      public bool Contains(T item)
      {
        lock (this._root)
          return this._list.Contains(item);
      }

      public void CopyTo(T[] array, int arrayIndex)
      {
        lock (this._root)
          this._list.CopyTo(array, arrayIndex);
      }

      public bool Remove(T item)
      {
        lock (this._root)
          return this._list.Remove(item);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        lock (this._root)
          return (IEnumerator) this._list.GetEnumerator();
      }

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
        lock (this._root)
          return ((IEnumerable<T>) this._list).GetEnumerator();
      }

      public T this[int index]
      {
        get
        {
          lock (this._root)
            return this._list[index];
        }
        set
        {
          lock (this._root)
            this._list[index] = value;
        }
      }

      public int IndexOf(T item)
      {
        lock (this._root)
          return this._list.IndexOf(item);
      }

      public void Insert(int index, T item)
      {
        lock (this._root)
          this._list.Insert(index, item);
      }

      public void RemoveAt(int index)
      {
        lock (this._root)
          this._list.RemoveAt(index);
      }
    }

    /// <summary>
    ///   列舉 <see cref="T:System.Collections.Generic.List`1" /> 的項目。
    /// </summary>
    [__DynamicallyInvokable]
    [Serializable]
    public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
    {
      private List<T> list;
      private int index;
      private int version;
      private T current;

      internal Enumerator(List<T> list)
      {
        this.list = list;
        this.index = 0;
        this.version = list._version;
        this.current = default (T);
      }

      /// <summary>
      ///   釋放 <see cref="T:System.Collections.Generic.List`1.Enumerator" /> 所使用的所有資源。
      /// </summary>
      [__DynamicallyInvokable]
      public void Dispose()
      {
      }

      /// <summary>
      ///   將列舉值前移至 <see cref="T:System.Collections.Generic.List`1" /> 的下一個項目。
      /// </summary>
      /// <returns>
      ///   如果列舉值成功前移至下一個項目，則為 <see langword="true" />；如果列舉值超過集合的結尾，則為 <see langword="false" />。
      /// </returns>
      /// <exception cref="T:System.InvalidOperationException">
      ///   建立列舉值之後，已修改集合。
      /// </exception>
      [__DynamicallyInvokable]
      public bool MoveNext()
      {
        List<T> list = this.list;
        if (this.version != list._version || (uint) this.index >= (uint) list._size)
          return this.MoveNextRare();
        this.current = list._items[this.index];
        ++this.index;
        return true;
      }

      private bool MoveNextRare()
      {
        if (this.version != this.list._version)
          ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
        this.index = this.list._size + 1;
        this.current = default (T);
        return false;
      }

      /// <summary>取得位於目前列舉值位置的項目。</summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.List`1" /> 中位於目前列舉值位置的項目。
      /// </returns>
      [__DynamicallyInvokable]
      public T Current
      {
        [__DynamicallyInvokable] get => this.current;
      }

      [__DynamicallyInvokable]
      object IEnumerator.Current
      {
        [__DynamicallyInvokable] get
        {
          if (this.index == 0 || this.index == this.list._size + 1)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
          return (object) this.Current;
        }
      }

      [__DynamicallyInvokable]
      void IEnumerator.Reset()
      {
        if (this.version != this.list._version)
          ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
        this.index = 0;
        this.current = default (T);
      }
    }
  }
}
