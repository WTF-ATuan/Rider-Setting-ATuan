// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.Dictionary`2
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E81851A0-DC73-4A79-AFA9-F5B7273162BE
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Collections.Generic
{
  /// <summary>
  ///   表示索引鍵和值的集合。
  /// 
  ///   若要瀏覽此類型的 .NET Framework 原始程式碼，請參閱參考來源。
  /// </summary>
  /// <typeparam name="TKey">字典中的索引鍵類型。</typeparam>
  /// <typeparam name="TValue">字典中的值類型。</typeparam>
  [DebuggerTypeProxy(typeof (Mscorlib_DictionaryDebugView<,>))]
  [DebuggerDisplay("Count = {Count}")]
  [ComVisible(false)]
  [__DynamicallyInvokable]
  [Serializable]
  public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
  {
    private int[] buckets;
    private Dictionary<TKey, TValue>.Entry[] entries;
    private int count;
    private int version;
    private int freeList;
    private int freeCount;
    private IEqualityComparer<TKey> comparer;
    private Dictionary<TKey, TValue>.KeyCollection keys;
    private Dictionary<TKey, TValue>.ValueCollection values;
    private object _syncRoot;
    private const string VersionName = "Version";
    private const string HashSizeName = "HashSize";
    private const string KeyValuePairsName = "KeyValuePairs";
    private const string ComparerName = "Comparer";

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，這個執行個體是空白的、具有預設的初始容量，並使用索引鍵類型的預設相等比較子。
    /// </summary>
    [__DynamicallyInvokable]
    public Dictionary()
      : this(0, (IEqualityComparer<TKey>) null)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，這個執行個體是空白的、具有指定的初始容量，並使用索引鍵類型的預設相等比較子。
    /// </summary>
    /// <param name="capacity">
    ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 可包含的初始項目數。
    /// </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="capacity" /> 小於 0。
    /// </exception>
    [__DynamicallyInvokable]
    public Dictionary(int capacity)
      : this(capacity, (IEqualityComparer<TKey>) null)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，這個執行個體是空白的、具有預設的初始容量，並使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="comparer">
    ///   比較索引鍵時所要使用的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 實作，或是 <see langword="null" />，表示要為索引鍵的類型使用預設 <see cref="T:System.Collections.Generic.EqualityComparer`1" />。
    /// </param>
    [__DynamicallyInvokable]
    public Dictionary(IEqualityComparer<TKey> comparer)
      : this(0, comparer)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，這個執行個體是空白的、具有指定的初始容量，並使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="capacity">
    ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 可包含的初始項目數。
    /// </param>
    /// <param name="comparer">
    ///   比較索引鍵時所要使用的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 實作，或是 <see langword="null" />，表示要為索引鍵的類型使用預設 <see cref="T:System.Collections.Generic.EqualityComparer`1" />。
    /// </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="capacity" /> 小於 0。
    /// </exception>
    [__DynamicallyInvokable]
    public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
    {
      if (capacity < 0)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
      if (capacity > 0)
        this.Initialize(capacity);
      this.comparer = comparer ?? (IEqualityComparer<TKey>) EqualityComparer<TKey>.Default;
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，其中包含從指定的 <see cref="T:System.Collections.Generic.IDictionary`2" /> 複製的項目，並使用索引鍵類型的預設相等比較子。
    /// </summary>
    /// <param name="dictionary">
    ///   要將其項目複製到新 <see cref="T:System.Collections.Generic.IDictionary`2" /> 的 <see cref="T:System.Collections.Generic.Dictionary`2" />。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="dictionary" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="dictionary" /> 包含一或多個重複的索引鍵。
    /// </exception>
    [__DynamicallyInvokable]
    public Dictionary(IDictionary<TKey, TValue> dictionary)
      : this(dictionary, (IEqualityComparer<TKey>) null)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體，其中包含從指定的 <see cref="T:System.Collections.Generic.IDictionary`2" /> 複製的項目，並使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="dictionary">
    ///   要將其項目複製到新 <see cref="T:System.Collections.Generic.IDictionary`2" /> 的 <see cref="T:System.Collections.Generic.Dictionary`2" />。
    /// </param>
    /// <param name="comparer">
    ///   比較索引鍵時所要使用的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 實作，或是 <see langword="null" />，表示要為索引鍵的類型使用預設 <see cref="T:System.Collections.Generic.EqualityComparer`1" />。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="dictionary" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="dictionary" /> 包含一或多個重複的索引鍵。
    /// </exception>
    [__DynamicallyInvokable]
    public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
      : this(dictionary != null ? dictionary.Count : 0, comparer)
    {
      if (dictionary == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
      foreach (KeyValuePair<TKey, TValue> keyValuePair in (IEnumerable<KeyValuePair<TKey, TValue>>) dictionary)
        this.Add(keyValuePair.Key, keyValuePair.Value);
    }

    /// <summary>
    ///   使用序列化資料，初始化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 類別的新執行個體。
    /// </summary>
    /// <param name="info">
    ///   <see cref="T:System.Runtime.Serialization.SerializationInfo" /> 物件，包含序列化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 所需的資訊。
    /// </param>
    /// <param name="context">
    ///   <see cref="T:System.Runtime.Serialization.StreamingContext" /> 結構，包含與 <see cref="T:System.Collections.Generic.Dictionary`2" /> 相關聯之已序列化資料流的來源和目的地。
    /// </param>
    protected Dictionary(SerializationInfo info, StreamingContext context) => HashHelpers.SerializationInfoTable.Add((object) this, info);

    /// <summary>
    ///   取得 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />，用來判斷字典的索引鍵是否相等。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 泛型介面實作，用來判斷目前 <see cref="T:System.Collections.Generic.Dictionary`2" /> 的索引鍵是否相等，並提供索引鍵的雜湊值。
    /// </returns>
    [__DynamicallyInvokable]
    public IEqualityComparer<TKey> Comparer
    {
      [__DynamicallyInvokable] get => this.comparer;
    }

    /// <summary>
    ///   取得 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中所包含的索引鍵/值組數目。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 中所包含的索引鍵/值組數目。
    /// </returns>
    [__DynamicallyInvokable]
    public int Count
    {
      [__DynamicallyInvokable] get => this.count - this.freeCount;
    }

    /// <summary>
    ///   取得集合，包含 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中的索引鍵。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />，包含 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中的索引鍵。
    /// </returns>
    [__DynamicallyInvokable]
    public Dictionary<TKey, TValue>.KeyCollection Keys
    {
      [__DynamicallyInvokable] get
      {
        if (this.keys == null)
          this.keys = new Dictionary<TKey, TValue>.KeyCollection(this);
        return this.keys;
      }
    }

    [__DynamicallyInvokable]
    ICollection<TKey> IDictionary<TKey, TValue>.Keys
    {
      [__DynamicallyInvokable] get
      {
        if (this.keys == null)
          this.keys = new Dictionary<TKey, TValue>.KeyCollection(this);
        return (ICollection<TKey>) this.keys;
      }
    }

    [__DynamicallyInvokable]
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
    {
      [__DynamicallyInvokable] get
      {
        if (this.keys == null)
          this.keys = new Dictionary<TKey, TValue>.KeyCollection(this);
        return (IEnumerable<TKey>) this.keys;
      }
    }

    /// <summary>
    ///   取得集合，包含 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中的值。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />，包含 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中的值。
    /// </returns>
    [__DynamicallyInvokable]
    public Dictionary<TKey, TValue>.ValueCollection Values
    {
      [__DynamicallyInvokable] get
      {
        if (this.values == null)
          this.values = new Dictionary<TKey, TValue>.ValueCollection(this);
        return this.values;
      }
    }

    [__DynamicallyInvokable]
    ICollection<TValue> IDictionary<TKey, TValue>.Values
    {
      [__DynamicallyInvokable] get
      {
        if (this.values == null)
          this.values = new Dictionary<TKey, TValue>.ValueCollection(this);
        return (ICollection<TValue>) this.values;
      }
    }

    [__DynamicallyInvokable]
    IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
    {
      [__DynamicallyInvokable] get
      {
        if (this.values == null)
          this.values = new Dictionary<TKey, TValue>.ValueCollection(this);
        return (IEnumerable<TValue>) this.values;
      }
    }

    /// <summary>取得或設定與指定之索引鍵相關聯的值。</summary>
    /// <param name="key">要取得或設定之值的索引鍵。</param>
    /// <returns>
    ///   與指定之索引鍵關聯的值。
    ///    如果找不到指定的索引鍵，則取得作業會擲回 <see cref="T:System.Collections.Generic.KeyNotFoundException" />，且設定作業會使用指定的索引鍵建立新項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="key" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.Collections.Generic.KeyNotFoundException">
    ///   會擷取該屬性，而且 <paramref name="key" /> 不存在於集合中。
    /// </exception>
    [__DynamicallyInvokable]
    public TValue this[TKey key]
    {
      [__DynamicallyInvokable] get
      {
        int entry = this.FindEntry(key);
        if (entry >= 0)
          return this.entries[entry].value;
        ThrowHelper.ThrowKeyNotFoundException();
        return default (TValue);
      }
      [__DynamicallyInvokable] set => this.Insert(key, value, false);
    }

    /// <summary>將指定的索引鍵和值加入字典。</summary>
    /// <param name="key">要加入的項目的索引鍵。</param>
    /// <param name="value">
    ///   要加入的項目的值。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="key" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 中已存在具有相同索引鍵的元素。
    /// </exception>
    [__DynamicallyInvokable]
    public void Add(TKey key, TValue value) => this.Insert(key, value, true);

    [__DynamicallyInvokable]
    void ICollection<KeyValuePair<TKey, TValue>>.Add(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      this.Add(keyValuePair.Key, keyValuePair.Value);
    }

    [__DynamicallyInvokable]
    bool ICollection<KeyValuePair<TKey, TValue>>.Contains(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      int entry = this.FindEntry(keyValuePair.Key);
      return entry >= 0 && EqualityComparer<TValue>.Default.Equals(this.entries[entry].value, keyValuePair.Value);
    }

    [__DynamicallyInvokable]
    bool ICollection<KeyValuePair<TKey, TValue>>.Remove(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      int entry = this.FindEntry(keyValuePair.Key);
      if (entry < 0 || !EqualityComparer<TValue>.Default.Equals(this.entries[entry].value, keyValuePair.Value))
        return false;
      this.Remove(keyValuePair.Key);
      return true;
    }

    /// <summary>
    ///   從 <see cref="T:System.Collections.Generic.Dictionary`2" /> 移除所有索引鍵和值。
    /// </summary>
    [__DynamicallyInvokable]
    public void Clear()
    {
      if (this.count <= 0)
        return;
      for (int index = 0; index < this.buckets.Length; ++index)
        this.buckets[index] = -1;
      Array.Clear((Array) this.entries, 0, this.count);
      this.freeList = -1;
      this.count = 0;
      this.freeCount = 0;
      ++this.version;
    }

    /// <summary>
    ///   判斷 <see cref="T:System.Collections.Generic.Dictionary`2" /> 是否包含特定索引鍵。
    /// </summary>
    /// <param name="key">
    ///   要在 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中尋找的索引鍵。
    /// </param>
    /// <returns>
    ///   如果 <see langword="true" /> 包含具有指定索引鍵的項目，則為 <see cref="T:System.Collections.Generic.Dictionary`2" />，否則為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="key" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public bool ContainsKey(TKey key) => this.FindEntry(key) >= 0;

    /// <summary>
    ///   判斷 <see cref="T:System.Collections.Generic.Dictionary`2" /> 是否包含特定值。
    /// </summary>
    /// <param name="value">
    ///   要在 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中尋找的值。
    ///    參考類型的值可以是 <see langword="null" />。
    /// </param>
    /// <returns>
    ///   如果 <see langword="true" /> 包含具有指定值的項目，則為 <see cref="T:System.Collections.Generic.Dictionary`2" />，否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public bool ContainsValue(TValue value)
    {
      if ((object) value == null)
      {
        for (int index = 0; index < this.count; ++index)
        {
          if (this.entries[index].hashCode >= 0 && (object) this.entries[index].value == null)
            return true;
        }
      }
      else
      {
        EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
        for (int index = 0; index < this.count; ++index)
        {
          if (this.entries[index].hashCode >= 0 && equalityComparer.Equals(this.entries[index].value, value))
            return true;
        }
      }
      return false;
    }

    private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    {
      if (array == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
      if (index < 0 || index > array.Length)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (array.Length - index < this.Count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
      int count = this.count;
      Dictionary<TKey, TValue>.Entry[] entries = this.entries;
      for (int index1 = 0; index1 < count; ++index1)
      {
        if (entries[index1].hashCode >= 0)
          array[index++] = new KeyValuePair<TKey, TValue>(entries[index1].key, entries[index1].value);
      }
    }

    /// <summary>
    ///   傳回在 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中逐一查看的列舉值。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 的 <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" /> 結構。
    /// </returns>
    [__DynamicallyInvokable]
    public Dictionary<TKey, TValue>.Enumerator GetEnumerator() => new Dictionary<TKey, TValue>.Enumerator(this, 2);

    [__DynamicallyInvokable]
    IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => (IEnumerator<KeyValuePair<TKey, TValue>>) new Dictionary<TKey, TValue>.Enumerator(this, 2);

    /// <summary>
    ///   實作 <see cref="T:System.Runtime.Serialization.ISerializable" /> 介面，並傳回序列化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 執行個體所需的資料。
    /// </summary>
    /// <param name="info">
    ///   <see cref="T:System.Runtime.Serialization.SerializationInfo" /> 物件，包含序列化 <see cref="T:System.Collections.Generic.Dictionary`2" /> 執行個體所需的資訊。
    /// </param>
    /// <param name="context">
    ///   <see cref="T:System.Runtime.Serialization.StreamingContext" /> 結構，包含與 <see cref="T:System.Collections.Generic.Dictionary`2" /> 執行個體相關聯之已序列化資料流的來源和目的地。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="info" /> 為 <see langword="null" />。
    /// </exception>
    [SecurityCritical]
    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      if (info == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
      info.AddValue("Version", this.version);
      info.AddValue("Comparer", HashHelpers.GetEqualityComparerForSerialization((object) this.comparer), typeof (IEqualityComparer<TKey>));
      info.AddValue("HashSize", this.buckets == null ? 0 : this.buckets.Length);
      if (this.buckets == null)
        return;
      KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this.Count];
      this.CopyTo(array, 0);
      info.AddValue("KeyValuePairs", (object) array, typeof (KeyValuePair<TKey, TValue>[]));
    }

    private int FindEntry(TKey key)
    {
      if ((object) key == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
      if (this.buckets != null)
      {
        int num = this.comparer.GetHashCode(key) & int.MaxValue;
        for (int index = this.buckets[num % this.buckets.Length]; index >= 0; index = this.entries[index].next)
        {
          if (this.entries[index].hashCode == num && this.comparer.Equals(this.entries[index].key, key))
            return index;
        }
      }
      return -1;
    }

    private void Initialize(int capacity)
    {
      int prime = HashHelpers.GetPrime(capacity);
      this.buckets = new int[prime];
      for (int index = 0; index < this.buckets.Length; ++index)
        this.buckets[index] = -1;
      this.entries = new Dictionary<TKey, TValue>.Entry[prime];
      this.freeList = -1;
    }

    private void Insert(TKey key, TValue value, bool add)
    {
      if ((object) key == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
      if (this.buckets == null)
        this.Initialize(0);
      int num1 = this.comparer.GetHashCode(key) & int.MaxValue;
      int index1 = num1 % this.buckets.Length;
      int num2 = 0;
      for (int index2 = this.buckets[index1]; index2 >= 0; index2 = this.entries[index2].next)
      {
        if (this.entries[index2].hashCode == num1 && this.comparer.Equals(this.entries[index2].key, key))
        {
          if (add)
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
          this.entries[index2].value = value;
          ++this.version;
          return;
        }
        ++num2;
      }
      int index3;
      if (this.freeCount > 0)
      {
        index3 = this.freeList;
        this.freeList = this.entries[index3].next;
        --this.freeCount;
      }
      else
      {
        if (this.count == this.entries.Length)
        {
          this.Resize();
          index1 = num1 % this.buckets.Length;
        }
        index3 = this.count;
        ++this.count;
      }
      this.entries[index3].hashCode = num1;
      this.entries[index3].next = this.buckets[index1];
      this.entries[index3].key = key;
      this.entries[index3].value = value;
      this.buckets[index1] = index3;
      ++this.version;
      if (num2 <= 100 || !HashHelpers.IsWellKnownEqualityComparer((object) this.comparer))
        return;
      this.comparer = (IEqualityComparer<TKey>) HashHelpers.GetRandomizedEqualityComparer((object) this.comparer);
      this.Resize(this.entries.Length, true);
    }

    /// <summary>
    ///   實作 <see cref="T:System.Runtime.Serialization.ISerializable" /> 介面，並於還原序列化完成時引發還原序列化事件。
    /// </summary>
    /// <param name="sender">還原序列化事件的來源。</param>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">
    ///   <see cref="T:System.Runtime.Serialization.SerializationInfo" /> 目前相關聯的物件 <see cref="T:System.Collections.Generic.Dictionary`2" /> 是無效的執行個體。
    /// </exception>
    public virtual void OnDeserialization(object sender)
    {
      SerializationInfo serializationInfo;
      HashHelpers.SerializationInfoTable.TryGetValue((object) this, out serializationInfo);
      if (serializationInfo == null)
        return;
      int int32_1 = serializationInfo.GetInt32("Version");
      int int32_2 = serializationInfo.GetInt32("HashSize");
      this.comparer = (IEqualityComparer<TKey>) serializationInfo.GetValue("Comparer", typeof (IEqualityComparer<TKey>));
      if (int32_2 != 0)
      {
        this.buckets = new int[int32_2];
        for (int index = 0; index < this.buckets.Length; ++index)
          this.buckets[index] = -1;
        this.entries = new Dictionary<TKey, TValue>.Entry[int32_2];
        this.freeList = -1;
        KeyValuePair<TKey, TValue>[] keyValuePairArray = (KeyValuePair<TKey, TValue>[]) serializationInfo.GetValue("KeyValuePairs", typeof (KeyValuePair<TKey, TValue>[]));
        if (keyValuePairArray == null)
          ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
        for (int index = 0; index < keyValuePairArray.Length; ++index)
        {
          if ((object) keyValuePairArray[index].Key == null)
            ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_NullKey);
          this.Insert(keyValuePairArray[index].Key, keyValuePairArray[index].Value, true);
        }
      }
      else
        this.buckets = (int[]) null;
      this.version = int32_1;
      HashHelpers.SerializationInfoTable.Remove((object) this);
    }

    private void Resize() => this.Resize(HashHelpers.ExpandPrime(this.count), false);

    private void Resize(int newSize, bool forceNewHashCodes)
    {
      int[] numArray = new int[newSize];
      for (int index = 0; index < numArray.Length; ++index)
        numArray[index] = -1;
      Dictionary<TKey, TValue>.Entry[] entryArray = new Dictionary<TKey, TValue>.Entry[newSize];
      Array.Copy((Array) this.entries, 0, (Array) entryArray, 0, this.count);
      if (forceNewHashCodes)
      {
        for (int index = 0; index < this.count; ++index)
        {
          if (entryArray[index].hashCode != -1)
            entryArray[index].hashCode = this.comparer.GetHashCode(entryArray[index].key) & int.MaxValue;
        }
      }
      for (int index1 = 0; index1 < this.count; ++index1)
      {
        if (entryArray[index1].hashCode >= 0)
        {
          int index2 = entryArray[index1].hashCode % newSize;
          entryArray[index1].next = numArray[index2];
          numArray[index2] = index1;
        }
      }
      this.buckets = numArray;
      this.entries = entryArray;
    }

    /// <summary>
    ///   將具有指定索引鍵的值從 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中移除。
    /// </summary>
    /// <param name="key">要移除的項目索引鍵。</param>
    /// <returns>
    ///   如果成功找到並移除項目則為 <see langword="true" />，否則為 <see langword="false" />。
    ///     這個方法會傳回 <see langword="false" /> 如果 <paramref name="key" /> 中找不到 <see cref="T:System.Collections.Generic.Dictionary`2" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="key" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public bool Remove(TKey key)
    {
      if ((object) key == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
      if (this.buckets != null)
      {
        int num = this.comparer.GetHashCode(key) & int.MaxValue;
        int index1 = num % this.buckets.Length;
        int index2 = -1;
        for (int index3 = this.buckets[index1]; index3 >= 0; index3 = this.entries[index3].next)
        {
          if (this.entries[index3].hashCode == num && this.comparer.Equals(this.entries[index3].key, key))
          {
            if (index2 < 0)
              this.buckets[index1] = this.entries[index3].next;
            else
              this.entries[index2].next = this.entries[index3].next;
            this.entries[index3].hashCode = -1;
            this.entries[index3].next = this.freeList;
            this.entries[index3].key = default (TKey);
            this.entries[index3].value = default (TValue);
            this.freeList = index3;
            ++this.freeCount;
            ++this.version;
            return true;
          }
          index2 = index3;
        }
      }
      return false;
    }

    /// <summary>取得指定索引鍵相關聯的值。</summary>
    /// <param name="key">要取得之值的索引鍵。</param>
    /// <param name="value">
    ///   這個方法傳回時，如果找到索引鍵，則包含與指定索引鍵相關聯的值，否則為 <paramref name="value" /> 參數類型的預設值。
    ///    這個參數會以未初始化的狀態傳遞。
    /// </param>
    /// <returns>
    ///   如果 <see langword="true" /> 包含具有指定索引鍵的項目，則為 <see cref="T:System.Collections.Generic.Dictionary`2" />，否則為 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="key" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public bool TryGetValue(TKey key, out TValue value)
    {
      int entry = this.FindEntry(key);
      if (entry >= 0)
      {
        value = this.entries[entry].value;
        return true;
      }
      value = default (TValue);
      return false;
    }

    internal TValue GetValueOrDefault(TKey key)
    {
      int entry = this.FindEntry(key);
      return entry >= 0 ? this.entries[entry].value : default (TValue);
    }

    [__DynamicallyInvokable]
    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(
      KeyValuePair<TKey, TValue>[] array,
      int index)
    {
      this.CopyTo(array, index);
    }

    [__DynamicallyInvokable]
    void ICollection.CopyTo(Array array, int index)
    {
      if (array == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
      if (array.Rank != 1)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
      if (array.GetLowerBound(0) != 0)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
      if (index < 0 || index > array.Length)
        ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
      if (array.Length - index < this.Count)
        ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
      switch (array)
      {
        case KeyValuePair<TKey, TValue>[] array1:
          this.CopyTo(array1, index);
          break;
        case DictionaryEntry[] _:
          DictionaryEntry[] dictionaryEntryArray = array as DictionaryEntry[];
          Dictionary<TKey, TValue>.Entry[] entries1 = this.entries;
          for (int index1 = 0; index1 < this.count; ++index1)
          {
            if (entries1[index1].hashCode >= 0)
              dictionaryEntryArray[index++] = new DictionaryEntry((object) entries1[index1].key, (object) entries1[index1].value);
          }
          break;
        case object[] objArray:
label_18:
          try
          {
            int count = this.count;
            Dictionary<TKey, TValue>.Entry[] entries2 = this.entries;
            for (int index1 = 0; index1 < count; ++index1)
            {
              if (entries2[index1].hashCode >= 0)
              {
                int index2 = index++;
                // ISSUE: variable of a boxed type
                __Boxed<KeyValuePair<TKey, TValue>> local = (ValueType) new KeyValuePair<TKey, TValue>(entries2[index1].key, entries2[index1].value);
                objArray[index2] = (object) local;
              }
            }
            break;
          }
          catch (ArrayTypeMismatchException ex)
          {
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
            break;
          }
        default:
          ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
          goto label_18;
      }
    }

    [__DynamicallyInvokable]
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new Dictionary<TKey, TValue>.Enumerator(this, 2);

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

    [__DynamicallyInvokable]
    bool IDictionary.IsFixedSize
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    bool IDictionary.IsReadOnly
    {
      [__DynamicallyInvokable] get => false;
    }

    [__DynamicallyInvokable]
    ICollection IDictionary.Keys
    {
      [__DynamicallyInvokable] get => (ICollection) this.Keys;
    }

    [__DynamicallyInvokable]
    ICollection IDictionary.Values
    {
      [__DynamicallyInvokable] get => (ICollection) this.Values;
    }

    [__DynamicallyInvokable]
    object IDictionary.this[object key]
    {
      [__DynamicallyInvokable] get
      {
        if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
        {
          int entry = this.FindEntry((TKey) key);
          if (entry >= 0)
            return (object) this.entries[entry].value;
        }
        return (object) null;
      }
      [__DynamicallyInvokable] set
      {
        if (key == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
        ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
        try
        {
          TKey key1 = (TKey) key;
          try
          {
            this[key1] = (TValue) value;
          }
          catch (InvalidCastException ex)
          {
            ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof (TValue));
          }
        }
        catch (InvalidCastException ex)
        {
          ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof (TKey));
        }
      }
    }

    private static bool IsCompatibleKey(object key)
    {
      if (key == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
      return key is TKey;
    }

    [__DynamicallyInvokable]
    void IDictionary.Add(object key, object value)
    {
      if (key == null)
        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
      ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
      try
      {
        TKey key1 = (TKey) key;
        try
        {
          this.Add(key1, (TValue) value);
        }
        catch (InvalidCastException ex)
        {
          ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof (TValue));
        }
      }
      catch (InvalidCastException ex)
      {
        ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof (TKey));
      }
    }

    [__DynamicallyInvokable]
    bool IDictionary.Contains(object key) => Dictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey) key);

    [__DynamicallyInvokable]
    IDictionaryEnumerator IDictionary.GetEnumerator() => (IDictionaryEnumerator) new Dictionary<TKey, TValue>.Enumerator(this, 1);

    [__DynamicallyInvokable]
    void IDictionary.Remove(object key)
    {
      if (!Dictionary<TKey, TValue>.IsCompatibleKey(key))
        return;
      this.Remove((TKey) key);
    }

    private struct Entry
    {
      public int hashCode;
      public int next;
      public TKey key;
      public TValue value;
    }

    /// <summary>
    ///   列舉 <see cref="T:System.Collections.Generic.Dictionary`2" /> 的項目。
    /// </summary>
    [__DynamicallyInvokable]
    [Serializable]
    public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
    {
      private Dictionary<TKey, TValue> dictionary;
      private int version;
      private int index;
      private KeyValuePair<TKey, TValue> current;
      private int getEnumeratorRetType;
      internal const int DictEntry = 1;
      internal const int KeyValuePair = 2;

      internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
      {
        this.dictionary = dictionary;
        this.version = dictionary.version;
        this.index = 0;
        this.getEnumeratorRetType = getEnumeratorRetType;
        this.current = new KeyValuePair<TKey, TValue>();
      }

      /// <summary>
      ///   將列舉值前移至 <see cref="T:System.Collections.Generic.Dictionary`2" /> 的下一個項目。
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
        if (this.version != this.dictionary.version)
          ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
        for (; (uint) this.index < (uint) this.dictionary.count; ++this.index)
        {
          if (this.dictionary.entries[this.index].hashCode >= 0)
          {
            this.current = new KeyValuePair<TKey, TValue>(this.dictionary.entries[this.index].key, this.dictionary.entries[this.index].value);
            ++this.index;
            return true;
          }
        }
        this.index = this.dictionary.count + 1;
        this.current = new KeyValuePair<TKey, TValue>();
        return false;
      }

      /// <summary>取得位於目前列舉值位置的項目。</summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 中位於目前列舉值位置的項目。
      /// </returns>
      [__DynamicallyInvokable]
      public KeyValuePair<TKey, TValue> Current
      {
        [__DynamicallyInvokable] get => this.current;
      }

      /// <summary>
      ///   釋放 <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" /> 所使用的所有資源。
      /// </summary>
      [__DynamicallyInvokable]
      public void Dispose()
      {
      }

      [__DynamicallyInvokable]
      object IEnumerator.Current
      {
        [__DynamicallyInvokable] get
        {
          if (this.index == 0 || this.index == this.dictionary.count + 1)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
          return this.getEnumeratorRetType == 1 ? (object) new DictionaryEntry((object) this.current.Key, (object) this.current.Value) : (object) new KeyValuePair<TKey, TValue>(this.current.Key, this.current.Value);
        }
      }

      [__DynamicallyInvokable]
      void IEnumerator.Reset()
      {
        if (this.version != this.dictionary.version)
          ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
        this.index = 0;
        this.current = new KeyValuePair<TKey, TValue>();
      }

      [__DynamicallyInvokable]
      DictionaryEntry IDictionaryEnumerator.Entry
      {
        [__DynamicallyInvokable] get
        {
          if (this.index == 0 || this.index == this.dictionary.count + 1)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
          return new DictionaryEntry((object) this.current.Key, (object) this.current.Value);
        }
      }

      [__DynamicallyInvokable]
      object IDictionaryEnumerator.Key
      {
        [__DynamicallyInvokable] get
        {
          if (this.index == 0 || this.index == this.dictionary.count + 1)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
          return (object) this.current.Key;
        }
      }

      [__DynamicallyInvokable]
      object IDictionaryEnumerator.Value
      {
        [__DynamicallyInvokable] get
        {
          if (this.index == 0 || this.index == this.dictionary.count + 1)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
          return (object) this.current.Value;
        }
      }
    }

    /// <summary>
    ///   代表 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中索引鍵的集合。
    ///    此類別無法被繼承。
    /// </summary>
    [DebuggerTypeProxy(typeof (Mscorlib_DictionaryKeyCollectionDebugView<,>))]
    [DebuggerDisplay("Count = {Count}")]
    [__DynamicallyInvokable]
    [Serializable]
    public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
    {
      private Dictionary<TKey, TValue> dictionary;

      /// <summary>
      ///   初始化的新執行個體 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 會反映在指定的索引鍵的類別 <see cref="T:System.Collections.Generic.Dictionary`2" />。
      /// </summary>
      /// <param name="dictionary">
      ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 之索引鍵會反映在新 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />。
      /// </param>
      /// <exception cref="T:System.ArgumentNullException">
      ///   <paramref name="dictionary" /> 為 <see langword="null" />。
      /// </exception>
      [__DynamicallyInvokable]
      public KeyCollection(Dictionary<TKey, TValue> dictionary)
      {
        if (dictionary == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
        this.dictionary = dictionary;
      }

      /// <summary>
      ///   傳回在 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 中逐一查看的列舉值。
      /// </summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" /> 的 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />。
      /// </returns>
      [__DynamicallyInvokable]
      public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() => new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this.dictionary);

      /// <summary>
      ///   從指定的陣列索引處開始，複製 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 項目至現有一維 <see cref="T:System.Array" />。
      /// </summary>
      /// <param name="array">
      ///   一維 <see cref="T:System.Array" />，是從 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 複製過來之項目的目的端。
      ///   <see cref="T:System.Array" /> 必須有以零為起始的索引。
      /// </param>
      /// <param name="index">
      ///   <paramref name="array" /> 中以零起始的索引，即開始複製的位置。
      /// </param>
      /// <exception cref="T:System.ArgumentNullException">
      ///   <paramref name="array" /> 為 <see langword="null" />。
      /// </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      ///   <paramref name="index" /> 小於零。
      /// </exception>
      /// <exception cref="T:System.ArgumentException">
      ///   在來源中的項目數 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 大於從可用的空間 <paramref name="index" /> 目的地結尾 <paramref name="array" />。
      /// </exception>
      [__DynamicallyInvokable]
      public void CopyTo(TKey[] array, int index)
      {
        if (array == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
        if (index < 0 || index > array.Length)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
        if (array.Length - index < this.dictionary.Count)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
        int count = this.dictionary.count;
        Dictionary<TKey, TValue>.Entry[] entries = this.dictionary.entries;
        for (int index1 = 0; index1 < count; ++index1)
        {
          if (entries[index1].hashCode >= 0)
            array[index++] = entries[index1].key;
        }
      }

      /// <summary>
      ///   取得 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 中所包含的項目數。
      /// </summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 中所包含的項目數。
      /// 
      ///   擷取這個屬性的值是一種 O(1) 運算。
      /// </returns>
      [__DynamicallyInvokable]
      public int Count
      {
        [__DynamicallyInvokable] get => this.dictionary.Count;
      }

      [__DynamicallyInvokable]
      bool ICollection<TKey>.IsReadOnly
      {
        [__DynamicallyInvokable] get => true;
      }

      [__DynamicallyInvokable]
      void ICollection<TKey>.Add(TKey item) => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);

      [__DynamicallyInvokable]
      void ICollection<TKey>.Clear() => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);

      [__DynamicallyInvokable]
      bool ICollection<TKey>.Contains(TKey item) => this.dictionary.ContainsKey(item);

      [__DynamicallyInvokable]
      bool ICollection<TKey>.Remove(TKey item)
      {
        ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
        return false;
      }

      [__DynamicallyInvokable]
      IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator() => (IEnumerator<TKey>) new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this.dictionary);

      [__DynamicallyInvokable]
      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this.dictionary);

      [__DynamicallyInvokable]
      void ICollection.CopyTo(Array array, int index)
      {
        if (array == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
        if (array.Rank != 1)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
        if (array.GetLowerBound(0) != 0)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
        if (index < 0 || index > array.Length)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
        if (array.Length - index < this.dictionary.Count)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
        switch (array)
        {
          case TKey[] array1:
            this.CopyTo(array1, index);
            break;
          case object[] objArray:
label_13:
            int count = this.dictionary.count;
            Dictionary<TKey, TValue>.Entry[] entries = this.dictionary.entries;
            try
            {
              for (int index1 = 0; index1 < count; ++index1)
              {
                if (entries[index1].hashCode >= 0)
                {
                  int index2 = index++;
                  // ISSUE: variable of a boxed type
                  __Boxed<TKey> key = (object) entries[index1].key;
                  objArray[index2] = (object) key;
                }
              }
              break;
            }
            catch (ArrayTypeMismatchException ex)
            {
              ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
              break;
            }
          default:
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
            goto label_13;
        }
      }

      [__DynamicallyInvokable]
      bool ICollection.IsSynchronized
      {
        [__DynamicallyInvokable] get => false;
      }

      [__DynamicallyInvokable]
      object ICollection.SyncRoot
      {
        [__DynamicallyInvokable] get => ((ICollection) this.dictionary).SyncRoot;
      }

      /// <summary>
      ///   列舉 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 的項目。
      /// </summary>
      [__DynamicallyInvokable]
      [Serializable]
      public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
      {
        private Dictionary<TKey, TValue> dictionary;
        private int index;
        private int version;
        private TKey currentKey;

        internal Enumerator(Dictionary<TKey, TValue> dictionary)
        {
          this.dictionary = dictionary;
          this.version = dictionary.version;
          this.index = 0;
          this.currentKey = default (TKey);
        }

        /// <summary>
        ///   釋放 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" /> 所使用的所有資源。
        /// </summary>
        [__DynamicallyInvokable]
        public void Dispose()
        {
        }

        /// <summary>
        ///   將列舉值前移至 <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 的下一個項目。
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
          if (this.version != this.dictionary.version)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
          for (; (uint) this.index < (uint) this.dictionary.count; ++this.index)
          {
            if (this.dictionary.entries[this.index].hashCode >= 0)
            {
              this.currentKey = this.dictionary.entries[this.index].key;
              ++this.index;
              return true;
            }
          }
          this.index = this.dictionary.count + 1;
          this.currentKey = default (TKey);
          return false;
        }

        /// <summary>取得位於目前列舉值位置的項目。</summary>
        /// <returns>
        ///   <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> 中位於目前列舉值位置的項目。
        /// </returns>
        [__DynamicallyInvokable]
        public TKey Current
        {
          [__DynamicallyInvokable] get => this.currentKey;
        }

        [__DynamicallyInvokable]
        object IEnumerator.Current
        {
          [__DynamicallyInvokable] get
          {
            if (this.index == 0 || this.index == this.dictionary.count + 1)
              ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
            return (object) this.currentKey;
          }
        }

        [__DynamicallyInvokable]
        void IEnumerator.Reset()
        {
          if (this.version != this.dictionary.version)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
          this.index = 0;
          this.currentKey = default (TKey);
        }
      }
    }

    /// <summary>
    ///   表示 <see cref="T:System.Collections.Generic.Dictionary`2" /> 中值的集合。
    ///    此類別無法被繼承。
    /// </summary>
    [DebuggerTypeProxy(typeof (Mscorlib_DictionaryValueCollectionDebugView<,>))]
    [DebuggerDisplay("Count = {Count}")]
    [__DynamicallyInvokable]
    [Serializable]
    public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
    {
      private Dictionary<TKey, TValue> dictionary;

      /// <summary>
      ///   初始化的新執行個體 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 類別中指定的值會反映出 <see cref="T:System.Collections.Generic.Dictionary`2" />。
      /// </summary>
      /// <param name="dictionary">
      ///   <see cref="T:System.Collections.Generic.Dictionary`2" /> 其值就會反映在新 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />。
      /// </param>
      /// <exception cref="T:System.ArgumentNullException">
      ///   <paramref name="dictionary" /> 為 <see langword="null" />。
      /// </exception>
      [__DynamicallyInvokable]
      public ValueCollection(Dictionary<TKey, TValue> dictionary)
      {
        if (dictionary == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
        this.dictionary = dictionary;
      }

      /// <summary>
      ///   傳回在 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 中逐一查看的列舉值。
      /// </summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" /> 的 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />。
      /// </returns>
      [__DynamicallyInvokable]
      public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() => new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this.dictionary);

      /// <summary>
      ///   從指定的陣列索引處開始，複製 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 項目至現有一維 <see cref="T:System.Array" />。
      /// </summary>
      /// <param name="array">
      ///   一維 <see cref="T:System.Array" />，是從 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 複製過來之項目的目的端。
      ///   <see cref="T:System.Array" /> 必須有以零為起始的索引。
      /// </param>
      /// <param name="index">
      ///   <paramref name="array" /> 中以零起始的索引，即開始複製的位置。
      /// </param>
      /// <exception cref="T:System.ArgumentNullException">
      ///   <paramref name="array" /> 為 <see langword="null" />。
      /// </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      ///   <paramref name="index" /> 小於零。
      /// </exception>
      /// <exception cref="T:System.ArgumentException">
      ///   在來源中的項目數 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 大於從可用的空間 <paramref name="index" /> 目的地結尾 <paramref name="array" />。
      /// </exception>
      [__DynamicallyInvokable]
      public void CopyTo(TValue[] array, int index)
      {
        if (array == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
        if (index < 0 || index > array.Length)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
        if (array.Length - index < this.dictionary.Count)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
        int count = this.dictionary.count;
        Dictionary<TKey, TValue>.Entry[] entries = this.dictionary.entries;
        for (int index1 = 0; index1 < count; ++index1)
        {
          if (entries[index1].hashCode >= 0)
            array[index++] = entries[index1].value;
        }
      }

      /// <summary>
      ///   取得 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 中所包含的項目數。
      /// </summary>
      /// <returns>
      ///   <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 中所包含的項目數。
      /// </returns>
      [__DynamicallyInvokable]
      public int Count
      {
        [__DynamicallyInvokable] get => this.dictionary.Count;
      }

      [__DynamicallyInvokable]
      bool ICollection<TValue>.IsReadOnly
      {
        [__DynamicallyInvokable] get => true;
      }

      [__DynamicallyInvokable]
      void ICollection<TValue>.Add(TValue item) => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);

      [__DynamicallyInvokable]
      bool ICollection<TValue>.Remove(TValue item)
      {
        ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
        return false;
      }

      [__DynamicallyInvokable]
      void ICollection<TValue>.Clear() => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);

      [__DynamicallyInvokable]
      bool ICollection<TValue>.Contains(TValue item) => this.dictionary.ContainsValue(item);

      [__DynamicallyInvokable]
      IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => (IEnumerator<TValue>) new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this.dictionary);

      [__DynamicallyInvokable]
      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this.dictionary);

      [__DynamicallyInvokable]
      void ICollection.CopyTo(Array array, int index)
      {
        if (array == null)
          ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
        if (array.Rank != 1)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
        if (array.GetLowerBound(0) != 0)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
        if (index < 0 || index > array.Length)
          ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
        if (array.Length - index < this.dictionary.Count)
          ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
        switch (array)
        {
          case TValue[] array1:
            this.CopyTo(array1, index);
            break;
          case object[] objArray:
label_13:
            int count = this.dictionary.count;
            Dictionary<TKey, TValue>.Entry[] entries = this.dictionary.entries;
            try
            {
              for (int index1 = 0; index1 < count; ++index1)
              {
                if (entries[index1].hashCode >= 0)
                {
                  int index2 = index++;
                  // ISSUE: variable of a boxed type
                  __Boxed<TValue> local = (object) entries[index1].value;
                  objArray[index2] = (object) local;
                }
              }
              break;
            }
            catch (ArrayTypeMismatchException ex)
            {
              ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
              break;
            }
          default:
            ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
            goto label_13;
        }
      }

      [__DynamicallyInvokable]
      bool ICollection.IsSynchronized
      {
        [__DynamicallyInvokable] get => false;
      }

      [__DynamicallyInvokable]
      object ICollection.SyncRoot
      {
        [__DynamicallyInvokable] get => ((ICollection) this.dictionary).SyncRoot;
      }

      /// <summary>
      ///   列舉 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 的項目。
      /// </summary>
      [__DynamicallyInvokable]
      [Serializable]
      public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
      {
        private Dictionary<TKey, TValue> dictionary;
        private int index;
        private int version;
        private TValue currentValue;

        internal Enumerator(Dictionary<TKey, TValue> dictionary)
        {
          this.dictionary = dictionary;
          this.version = dictionary.version;
          this.index = 0;
          this.currentValue = default (TValue);
        }

        /// <summary>
        ///   釋放 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" /> 所使用的所有資源。
        /// </summary>
        [__DynamicallyInvokable]
        public void Dispose()
        {
        }

        /// <summary>
        ///   將列舉值前移至 <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 的下一個項目。
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
          if (this.version != this.dictionary.version)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
          for (; (uint) this.index < (uint) this.dictionary.count; ++this.index)
          {
            if (this.dictionary.entries[this.index].hashCode >= 0)
            {
              this.currentValue = this.dictionary.entries[this.index].value;
              ++this.index;
              return true;
            }
          }
          this.index = this.dictionary.count + 1;
          this.currentValue = default (TValue);
          return false;
        }

        /// <summary>取得位於目前列舉值位置的項目。</summary>
        /// <returns>
        ///   <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> 中位於目前列舉值位置的項目。
        /// </returns>
        [__DynamicallyInvokable]
        public TValue Current
        {
          [__DynamicallyInvokable] get => this.currentValue;
        }

        [__DynamicallyInvokable]
        object IEnumerator.Current
        {
          [__DynamicallyInvokable] get
          {
            if (this.index == 0 || this.index == this.dictionary.count + 1)
              ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
            return (object) this.currentValue;
          }
        }

        [__DynamicallyInvokable]
        void IEnumerator.Reset()
        {
          if (this.version != this.dictionary.version)
            ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
          this.index = 0;
          this.currentValue = default (TValue);
        }
      }
    }
  }
}
