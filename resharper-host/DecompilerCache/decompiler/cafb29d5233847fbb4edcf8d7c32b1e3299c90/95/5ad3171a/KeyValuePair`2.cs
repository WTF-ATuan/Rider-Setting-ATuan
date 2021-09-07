// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.KeyValuePair`2
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: CAFB29D5-2338-47FB-B4ED-CF8D7C32B1E3
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll

namespace System.Collections.Generic
{
  /// <summary>定義可設定或擷取的索引鍵/值組。</summary>
  /// <typeparam name="TKey">索引鍵的類型。</typeparam>
  /// <typeparam name="TValue">值的類型。</typeparam>
  /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.7.2">`KeyValuePair` on docs.microsoft.com</a></footer>
  [Serializable]
  public struct KeyValuePair<TKey, TValue>
  {
    private TKey key;
    private TValue value;

    /// <summary>
    ///   初始化的新執行個體 <see cref="T:System.Collections.Generic.KeyValuePair`2" /> 結構具有指定之索引鍵和值。
    /// </summary>
    /// <param name="key">在每個索引鍵/值組配對中定義的物件。</param>
    /// <param name="value">
    ///   相關聯的定義 <paramref name="key" />。
    /// </param>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.7.2">`KeyValuePair` on docs.microsoft.com</a></footer>
    public KeyValuePair(TKey key, TValue value);

    /// <summary>取得索引鍵/值組中的索引鍵。</summary>
    /// <returns>
    ///   A <paramref name="TKey" /> 也就是索引鍵 <see cref="T:System.Collections.Generic.KeyValuePair`2" />。
    /// </returns>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2.Key?view=netframework-4.7.2">`KeyValuePair.Key` on docs.microsoft.com</a></footer>
    public TKey Key { get; }

    /// <summary>取得索引鍵/值組中的值。</summary>
    /// <returns>
    ///   A <paramref name="TValue" /> 值的 <see cref="T:System.Collections.Generic.KeyValuePair`2" />。
    /// </returns>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2.Value?view=netframework-4.7.2">`KeyValuePair.Value` on docs.microsoft.com</a></footer>
    public TValue Value { get; }

    /// <summary>
    ///   傳回的字串表示 <see cref="T:System.Collections.Generic.KeyValuePair`2" />, ，使用索引鍵和值的字串表示。
    /// </summary>
    /// <returns>
    ///   字串表示法 <see cref="T:System.Collections.Generic.KeyValuePair`2" />, ，其中包括索引鍵和值的字串表示。
    /// </returns>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2.ToString?view=netframework-4.7.2">`KeyValuePair.ToString` on docs.microsoft.com</a></footer>
    public override string ToString();
  }
}
