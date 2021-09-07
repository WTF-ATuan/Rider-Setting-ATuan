// Decompiled with JetBrains decompiler
// Type: System.Linq.Enumerable
// Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E90BEB44-6898-4ECF-B706-59AC067ECC5C
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.Core.dll

using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Linq
{
  /// <summary>
  ///   提供一組 <see langword="static" /> (<see langword="Shared" /> 在 Visual Basic 中) 方法來查詢物件實作 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
  /// </summary>
  [__DynamicallyInvokable]
  public static class Enumerable
  {
    /// <summary>根據述詞來篩選值序列。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 來篩選。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列中滿足條件的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Where<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      switch (source)
      {
        case Enumerable.Iterator<TSource> _:
          return ((Enumerable.Iterator<TSource>) source).Where(predicate);
        case TSource[] _:
          return (IEnumerable<TSource>) new Enumerable.WhereArrayIterator<TSource>((TSource[]) source, predicate);
        case List<TSource> _:
          return (IEnumerable<TSource>) new Enumerable.WhereListIterator<TSource>((List<TSource>) source, predicate);
        default:
          return (IEnumerable<TSource>) new Enumerable.WhereEnumerableIterator<TSource>(source, predicate);
      }
    }

    /// <summary>
    ///   根據述詞來篩選值序列。
    ///    述詞函式的邏輯中使用各項目的索引。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 來篩選。
    /// </param>
    /// <param name="predicate">
    ///   用來測試各來源項目是否符合條件的函式；此函式的第二個參數代表來源項目的索引。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列中滿足條件的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Where<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return predicate != null ? Enumerable.WhereIterator<TSource>(source, predicate) : throw Error.ArgumentNull(nameof (predicate));
    }

    private static IEnumerable<TSource> WhereIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      int index = -1;
      foreach (TSource source1 in source)
      {
        checked { ++index; }
        if (predicate(source1, index))
          yield return source1;
      }
    }

    /// <summary>將序列的每個元素規劃成一個新的表單。</summary>
    /// <param name="source">要對於叫用轉換函式的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用每個項目的轉換函式的結果 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Select<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      switch (source)
      {
        case Enumerable.Iterator<TSource> _:
          return ((Enumerable.Iterator<TSource>) source).Select<TResult>(selector);
        case TSource[] _:
          return (IEnumerable<TResult>) new Enumerable.WhereSelectArrayIterator<TSource, TResult>((TSource[]) source, (Func<TSource, bool>) null, selector);
        case List<TSource> _:
          return (IEnumerable<TResult>) new Enumerable.WhereSelectListIterator<TSource, TResult>((List<TSource>) source, (Func<TSource, bool>) null, selector);
        default:
          return (IEnumerable<TResult>) new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(source, (Func<TSource, bool>) null, selector);
      }
    }

    /// <summary>投射成新的表單序列的每個項目所加入的項目索引。</summary>
    /// <param name="source">要對於叫用轉換函式的值序列。</param>
    /// <param name="selector">要套用到每個來源項目的轉換函式；此函式的第二個參數代表來源項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用每個項目的轉換函式的結果 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Select<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, TResult> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return selector != null ? Enumerable.SelectIterator<TSource, TResult>(source, selector) : throw Error.ArgumentNull(nameof (selector));
    }

    private static IEnumerable<TResult> SelectIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, TResult> selector)
    {
      int index = -1;
      foreach (TSource source1 in source)
      {
        checked { ++index; }
        yield return selector(source1, index);
      }
    }

    private static Func<TSource, bool> CombinePredicates<TSource>(
      Func<TSource, bool> predicate1,
      Func<TSource, bool> predicate2)
    {
      return (Func<TSource, bool>) (x => predicate1(x) && predicate2(x));
    }

    private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(
      Func<TSource, TMiddle> selector1,
      Func<TMiddle, TResult> selector2)
    {
      return (Func<TSource, TResult>) (x => selector2(selector1(x)));
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 並壓平合併成單一序列產生的序列。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的序列的項目類型 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用在輸入序列中的每個項目-一對多轉換函式的結果。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> SelectMany<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return selector != null ? Enumerable.SelectManyIterator<TSource, TResult>(source, selector) : throw Error.ArgumentNull(nameof (selector));
    }

    private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TResult>> selector)
    {
      foreach (TSource source1 in source)
      {
        foreach (TResult result in selector(source1))
          yield return result;
      }
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" />, ，並將簡化成單一序列產生的序列。
    ///    各來源項目的索引是在該項目的投影表單中使用。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用到每個來源項目的轉換函式；此函式的第二個參數代表來源項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的序列的項目類型 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用在輸入序列的每個項目-一對多轉換函式的結果。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> SelectMany<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return selector != null ? Enumerable.SelectManyIterator<TSource, TResult>(source, selector) : throw Error.ArgumentNull(nameof (selector));
    }

    private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TResult>> selector)
    {
      int index = -1;
      foreach (TSource source1 in source)
      {
        checked { ++index; }
        foreach (TResult result in selector(source1, index))
          yield return result;
      }
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" />, 壓平合併成單一序列，產生的序列，其中將每個項目中的結果選取器函式會叫用。
    ///    各來源項目的索引是在該項目的中繼投影表單中使用。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="collectionSelector">
    ///   要套用到每個來源項目的轉換函式；此函式的第二個參數代表來源項目的索引。
    /// </param>
    /// <param name="resultSelector">若要套用到中繼序列各個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TCollection">
    ///   所收集的中繼元素類型 <paramref name="collectionSelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">產生之序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用來從一對多轉換函式的結果 <paramref name="collectionSelector" /> 的每個項目上 <paramref name="source" /> 然後將每個序列項目及其對應的來源項目對應至結果項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="collectionSelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (collectionSelector == null)
        throw Error.ArgumentNull(nameof (collectionSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.SelectManyIterator<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
    }

    private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      int index = -1;
      foreach (TSource source1 in source)
      {
        TSource element = source1;
        checked { ++index; }
        foreach (TCollection collection in collectionSelector(element, index))
          yield return resultSelector(element, collection);
        element = default (TSource);
      }
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" />, 壓平合併成單一序列，產生的序列，其中將每個項目中的結果選取器函式會叫用。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="collectionSelector">要套用至每個輸入序列中項目的轉換函式。</param>
    /// <param name="resultSelector">若要套用到中繼序列各個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TCollection">
    ///   所收集的中繼元素類型 <paramref name="collectionSelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">產生之序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其項目是叫用來從一對多轉換函式的結果 <paramref name="collectionSelector" /> 的每個項目上 <paramref name="source" /> 然後將每個序列項目及其對應的來源項目對應至結果項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="collectionSelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (collectionSelector == null)
        throw Error.ArgumentNull(nameof (collectionSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.SelectManyIterator<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
    }

    private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      foreach (TSource source1 in source)
      {
        TSource element = source1;
        foreach (TCollection collection in collectionSelector(element))
          yield return resultSelector(element, collection);
        element = default (TSource);
      }
    }

    /// <summary>從序列開頭傳回指定的連續的項目數。</summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="count">要傳回的項目數目。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含從輸入序列的開頭指定項目數。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Take<TSource>(
      this IEnumerable<TSource> source,
      int count)
    {
      return source != null ? Enumerable.TakeIterator<TSource>(source, count) : throw Error.ArgumentNull(nameof (source));
    }

    private static IEnumerable<TSource> TakeIterator<TSource>(
      IEnumerable<TSource> source,
      int count)
    {
      if (count > 0)
      {
        foreach (TSource source1 in source)
        {
          yield return source1;
          if (--count == 0)
            break;
        }
      }
    }

    /// <summary>傳回序列中的項目，只要指定的條件為真。</summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列中的測試不成功的項目之前出現的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> TakeWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return predicate != null ? Enumerable.TakeWhileIterator<TSource>(source, predicate) : throw Error.ArgumentNull(nameof (predicate));
    }

    private static IEnumerable<TSource> TakeWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          yield return source1;
        else
          break;
      }
    }

    /// <summary>
    ///   傳回序列中的項目，只要指定的條件為真。
    ///    項目的索引是用於述詞功能的邏輯中。
    /// </summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="predicate">
    ///   用來測試各來源項目是否符合條件的函式；此函式的第二個參數代表來源項目的索引。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列中的測試不成功的項目出現的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> TakeWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return predicate != null ? Enumerable.TakeWhileIterator<TSource>(source, predicate) : throw Error.ArgumentNull(nameof (predicate));
    }

    private static IEnumerable<TSource> TakeWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      int index = -1;
      foreach (TSource source1 in source)
      {
        checked { ++index; }
        if (predicate(source1, index))
          yield return source1;
        else
          break;
      }
    }

    /// <summary>略過指定的數目的序列中的項目，然後傳回其餘項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回項目的。
    /// </param>
    /// <param name="count">傳回其餘項目之前要略過的項目數目。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列中指定的索引之後出現的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Skip<TSource>(
      this IEnumerable<TSource> source,
      int count)
    {
      return source != null ? Enumerable.SkipIterator<TSource>(source, count) : throw Error.ArgumentNull(nameof (source));
    }

    private static IEnumerable<TSource> SkipIterator<TSource>(
      IEnumerable<TSource> source,
      int count)
    {
      using (IEnumerator<TSource> e = source.GetEnumerator())
      {
        while (count > 0 && e.MoveNext())
          --count;
        if (count <= 0)
        {
          while (e.MoveNext())
            yield return e.Current;
        }
      }
    }

    /// <summary>只要指定的條件為 true，然後傳回其餘項目，請略過序列中的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回項目的。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含未通過指定測試線性系列中的第一個項目開始輸入序列中的項目 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> SkipWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return predicate != null ? Enumerable.SkipWhileIterator<TSource>(source, predicate) : throw Error.ArgumentNull(nameof (predicate));
    }

    private static IEnumerable<TSource> SkipWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      bool yielding = false;
      foreach (TSource source1 in source)
      {
        if (!yielding && !predicate(source1))
          yielding = true;
        if (yielding)
          yield return source1;
      }
    }

    /// <summary>
    ///   只要指定的條件為 true，然後傳回其餘項目，請略過序列中的項目。
    ///    項目的索引是用於述詞功能的邏輯中。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回項目的。
    /// </param>
    /// <param name="predicate">
    ///   用來測試各來源項目是否符合條件的函式；此函式的第二個參數代表來源項目的索引。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含未通過指定測試線性系列中的第一個項目開始輸入序列中的項目 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> SkipWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return predicate != null ? Enumerable.SkipWhileIterator<TSource>(source, predicate) : throw Error.ArgumentNull(nameof (predicate));
    }

    private static IEnumerable<TSource> SkipWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      int index = -1;
      bool yielding = false;
      foreach (TSource source1 in source)
      {
        checked { ++index; }
        if (!yielding && !predicate(source1, index))
          yielding = true;
        if (yielding)
          yield return source1;
      }
    }

    /// <summary>
    ///   根據相符索引鍵的兩個序列的項目相互關聯。
    ///    預設的相等比較子是用於比較索引鍵。
    /// </summary>
    /// <param name="outer">要聯結的第一個序列。</param>
    /// <param name="inner">要加入第一個序列的序列。</param>
    /// <param name="outerKeySelector">用來從第一個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="innerKeySelector">用來從第二個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="resultSelector">用來從兩個相符項目建立結果項目的函式。</param>
    /// <typeparam name="TOuter">第一個序列之項目的類型。</typeparam>
    /// <typeparam name="TInner">第二個序列之項目的類型。</typeparam>
    /// <typeparam name="TKey">索引鍵選取器函式所傳回之索引鍵的類型。</typeparam>
    /// <typeparam name="TResult">結果項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 具有型別的項目 <paramref name="TResult" /> 對兩個序列執行內部聯結所取得的。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector)
    {
      if (outer == null)
        throw Error.ArgumentNull(nameof (outer));
      if (inner == null)
        throw Error.ArgumentNull(nameof (inner));
      if (outerKeySelector == null)
        throw Error.ArgumentNull(nameof (outerKeySelector));
      if (innerKeySelector == null)
        throw Error.ArgumentNull(nameof (innerKeySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.JoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   根據相符索引鍵的兩個序列的項目相互關聯。
    ///    指定 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 用於比較索引鍵。
    /// </summary>
    /// <param name="outer">要聯結的第一個序列。</param>
    /// <param name="inner">要加入第一個序列的序列。</param>
    /// <param name="outerKeySelector">用來從第一個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="innerKeySelector">用來從第二個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="resultSelector">用來從兩個相符項目建立結果項目的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 雜湊並比較索引鍵。
    /// </param>
    /// <typeparam name="TOuter">第一個序列之項目的類型。</typeparam>
    /// <typeparam name="TInner">第二個序列之項目的類型。</typeparam>
    /// <typeparam name="TKey">索引鍵選取器函式所傳回之索引鍵的類型。</typeparam>
    /// <typeparam name="TResult">結果項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 具有型別的項目 <paramref name="TResult" /> 對兩個序列執行內部聯結所取得的。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (outer == null)
        throw Error.ArgumentNull(nameof (outer));
      if (inner == null)
        throw Error.ArgumentNull(nameof (inner));
      if (outerKeySelector == null)
        throw Error.ArgumentNull(nameof (outerKeySelector));
      if (innerKeySelector == null)
        throw Error.ArgumentNull(nameof (innerKeySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.JoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    }

    private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(
      IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      Lookup<TKey, TInner> lookup = Lookup<TKey, TInner>.CreateForJoin(inner, innerKeySelector, comparer);
      foreach (TOuter outer1 in outer)
      {
        TOuter item = outer1;
        Lookup<TKey, TInner>.Grouping g = lookup.GetGrouping(outerKeySelector(item), false);
        if (g != null)
        {
          for (int i = 0; i < g.count; ++i)
            yield return resultSelector(item, g.elements[i]);
        }
        g = (Lookup<TKey, TInner>.Grouping) null;
        item = default (TOuter);
      }
    }

    /// <summary>
    ///   根據索引鍵相等的兩個序列的項目相互關聯，並將結果分組。
    ///    預設的相等比較子是用於比較索引鍵。
    /// </summary>
    /// <param name="outer">要聯結的第一個序列。</param>
    /// <param name="inner">要加入第一個序列的序列。</param>
    /// <param name="outerKeySelector">用來從第一個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="innerKeySelector">用來從第二個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="resultSelector">
    ///   函式，用來從第一個序列的項目以及第二個序列的相符項目集合建立結果項目。
    /// </param>
    /// <typeparam name="TOuter">第一個序列之項目的類型。</typeparam>
    /// <typeparam name="TInner">第二個序列之項目的類型。</typeparam>
    /// <typeparam name="TKey">索引鍵選取器函式所傳回之索引鍵的類型。</typeparam>
    /// <typeparam name="TResult">結果項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含型別的項目 <paramref name="TResult" /> 兩個序列執行群組的聯結所取得的。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
    {
      if (outer == null)
        throw Error.ArgumentNull(nameof (outer));
      if (inner == null)
        throw Error.ArgumentNull(nameof (inner));
      if (outerKeySelector == null)
        throw Error.ArgumentNull(nameof (outerKeySelector));
      if (innerKeySelector == null)
        throw Error.ArgumentNull(nameof (innerKeySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.GroupJoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   根據索引鍵相等的兩個序列的項目相互關聯，並將結果分組。
    ///    指定 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 用於比較索引鍵。
    /// </summary>
    /// <param name="outer">要聯結的第一個序列。</param>
    /// <param name="inner">要加入第一個序列的序列。</param>
    /// <param name="outerKeySelector">用來從第一個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="innerKeySelector">用來從第二個序列各個項目擷取聯結索引鍵的函式。</param>
    /// <param name="resultSelector">
    ///   函式，用來從第一個序列的項目以及第二個序列的相符項目集合建立結果項目。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 雜湊並比較索引鍵。
    /// </param>
    /// <typeparam name="TOuter">第一個序列之項目的類型。</typeparam>
    /// <typeparam name="TInner">第二個序列之項目的類型。</typeparam>
    /// <typeparam name="TKey">索引鍵選取器函式所傳回之索引鍵的類型。</typeparam>
    /// <typeparam name="TResult">結果項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含型別的項目 <paramref name="TResult" /> 兩個序列執行群組的聯結所取得的。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (outer == null)
        throw Error.ArgumentNull(nameof (outer));
      if (inner == null)
        throw Error.ArgumentNull(nameof (inner));
      if (outerKeySelector == null)
        throw Error.ArgumentNull(nameof (outerKeySelector));
      if (innerKeySelector == null)
        throw Error.ArgumentNull(nameof (innerKeySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.GroupJoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    }

    private static IEnumerable<TResult> GroupJoinIterator<TOuter, TInner, TKey, TResult>(
      IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      Lookup<TKey, TInner> lookup = Lookup<TKey, TInner>.CreateForJoin(inner, innerKeySelector, comparer);
      foreach (TOuter outer1 in outer)
        yield return resultSelector(outer1, lookup[outerKeySelector(outer1)]);
    }

    /// <summary>排序序列中遞增順序依據索引鍵的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return (IOrderedEnumerable<TSource>) new OrderedEnumerable<TSource, TKey>(source, keySelector, (IComparer<TKey>) null, false);
    }

    /// <summary>排序序列中使用指定的比較子，依遞增順序排列的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      return (IOrderedEnumerable<TSource>) new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, false);
    }

    /// <summary>排序序列中遞減的順序，根據索引鍵的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return (IOrderedEnumerable<TSource>) new OrderedEnumerable<TSource, TKey>(source, keySelector, (IComparer<TKey>) null, true);
    }

    /// <summary>使用指定的比較子，依遞減順序排序序列中的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      return (IOrderedEnumerable<TSource>) new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, true);
    }

    /// <summary>執行以遞增順序依據索引鍵的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return source != null ? source.CreateOrderedEnumerable<TKey>(keySelector, (IComparer<TKey>) null, false) : throw Error.ArgumentNull(nameof (source));
    }

    /// <summary>執行使用指定的比較子，依遞增順序排列序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, false);
    }

    /// <summary>根據索引鍵，會執行，依遞減順序的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return source != null ? source.CreateOrderedEnumerable<TKey>(keySelector, (IComparer<TKey>) null, true) : throw Error.ArgumentNull(nameof (source));
    }

    /// <summary>執行在使用指定的比較子，依遞減順序的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedEnumerable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, true);
    }

    /// <summary>群組依據指定的索引鍵選取器函式序列的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt; 在 C# 或 IEnumerable(Of IGrouping(Of TKey, TSource)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 物件包含一連串的物件和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return (IEnumerable<IGrouping<TKey, TSource>>) new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, (IEqualityComparer<TKey>) null);
    }

    /// <summary>群組的順序，根據指定的索引鍵選取器函式和比較使用指定的比較子索引鍵的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt; 在 C# 或 IEnumerable(Of IGrouping(Of TKey, TSource)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 物件包含的物件和索引鍵集合。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      return (IEnumerable<IGrouping<TKey, TSource>>) new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
    }

    /// <summary>群組依據指定的索引鍵選取器函式並使用指定的函式的每個群組的項目序列的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   <see cref="T:System.Linq.IGrouping`2" /> 中的項目類型。
    /// </typeparam>
    /// <returns>
    ///   IEnumerable&lt;IGrouping&lt;TKey, TElement&gt;&gt; 在 C# 或 IEnumerable(Of IGrouping(Of TKey, TElement)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 物件包含的物件型別的集合 <paramref name="TElement" /> 和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      return (IEnumerable<IGrouping<TKey, TElement>>) new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   群組依據索引鍵選取器函式序列的項目。
    ///    索引鍵是使用比較子來進行比較，而每個群組的項目都是利用指定的函式進行投影。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   <see cref="T:System.Linq.IGrouping`2" /> 中的項目類型。
    /// </typeparam>
    /// <returns>
    ///   IEnumerable&lt;IGrouping&lt;TKey, TElement&gt;&gt; 在 C# 或 IEnumerable(Of IGrouping(Of TKey, TElement)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 物件包含的物件型別的集合 <paramref name="TElement" /> 和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      return (IEnumerable<IGrouping<TKey, TElement>>) new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
    }

    /// <summary>依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   集合型別的項目 <paramref name="TResult" /> 其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
    {
      return (IEnumerable<TResult>) new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    每個群組的項目都是利用指定的函式進行投影。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   集合型別的項目 <paramref name="TResult" /> 其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
    {
      return (IEnumerable<TResult>) new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    索引鍵是使用指定的比較子來進行比較。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵使用。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   集合型別的項目 <paramref name="TResult" /> 其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      return (IEnumerable<TResult>) new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, comparer);
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    索引鍵值是使用指定的比較子來進行比較，而每個群組的項目則都是利用指定的函式進行投影。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵使用。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   集合型別的項目 <paramref name="TResult" /> 其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      return (IEnumerable<TResult>) new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
    }

    /// <summary>串連兩個序列。</summary>
    /// <param name="first">要串連的第一個序列。</param>
    /// <param name="second">要串連到第一個序列的序列。</param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含兩個輸入序列的串連項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Concat<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      return second != null ? Enumerable.ConcatIterator<TSource>(first, second) : throw Error.ArgumentNull(nameof (second));
    }

    private static IEnumerable<TSource> ConcatIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      foreach (TSource source in first)
        yield return source;
      foreach (TSource source in second)
        yield return source;
    }

    /// <summary>套用指定的函式的兩個序列，產生的結果序列的對應元素。</summary>
    /// <param name="first">要合併的第一個序列。</param>
    /// <param name="second">要合併的第二個序列。</param>
    /// <param name="resultSelector">指定如何合併兩個序列中的項目函式。</param>
    /// <typeparam name="TFirst">第一個輸入序列的項目類型。</typeparam>
    /// <typeparam name="TSecond">第二個輸入序列的項目類型。</typeparam>
    /// <typeparam name="TResult">在結果序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含合併兩個輸入序列的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
      this IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      if (second == null)
        throw Error.ArgumentNull(nameof (second));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return Enumerable.ZipIterator<TFirst, TSecond, TResult>(first, second, resultSelector);
    }

    private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(
      IEnumerable<TFirst> first,
      IEnumerable<TSecond> second,
      Func<TFirst, TSecond, TResult> resultSelector)
    {
      using (IEnumerator<TFirst> e1 = first.GetEnumerator())
      {
        using (IEnumerator<TSecond> e2 = second.GetEnumerator())
        {
          while (e1.MoveNext() && e2.MoveNext())
            yield return resultSelector(e1.Current, e2.Current);
        }
      }
    }

    /// <summary>使用預設相等比較子來比較值，從序列傳回不同的項目。</summary>
    /// <param name="source">要移除重複項目的序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含來源序列中的不同項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source) => source != null ? Enumerable.DistinctIterator<TSource>(source, (IEqualityComparer<TSource>) null) : throw Error.ArgumentNull(nameof (source));

    /// <summary>
    ///   從序列傳回不同的項目，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </summary>
    /// <param name="source">要移除重複項目的序列。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含來源序列中的不同項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Distinct<TSource>(
      this IEnumerable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      return source != null ? Enumerable.DistinctIterator<TSource>(source, comparer) : throw Error.ArgumentNull(nameof (source));
    }

    private static IEnumerable<TSource> DistinctIterator<TSource>(
      IEnumerable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      Set<TSource> set = new Set<TSource>(comparer);
      foreach (TSource source1 in source)
      {
        if (set.Add(source1))
          yield return source1;
      }
    }

    /// <summary>使用預設相等比較子，以產生兩個序列的聯集。</summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其獨特的項目構成等位的第一個集合。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其不同項目構成等位的第二個集合。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含兩個輸入序列，排除重複的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Union<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      return second != null ? Enumerable.UnionIterator<TSource>(first, second, (IEqualityComparer<TSource>) null) : throw Error.ArgumentNull(nameof (second));
    }

    /// <summary>
    ///   使用指定之產生兩個序列的聯集 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其獨特的項目構成等位的第一個集合。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其不同項目構成等位的第二個集合。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含兩個輸入序列，排除重複的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Union<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      if (second == null)
        throw Error.ArgumentNull(nameof (second));
      return Enumerable.UnionIterator<TSource>(first, second, comparer);
    }

    private static IEnumerable<TSource> UnionIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      Set<TSource> set = new Set<TSource>(comparer);
      foreach (TSource source in first)
      {
        if (set.Add(source))
          yield return source;
      }
      foreach (TSource source in second)
      {
        if (set.Add(source))
          yield return source;
      }
    }

    /// <summary>使用預設相等比較子來比較值，以產生兩個序列的集合交集。</summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" />也會出現在其不同項目<paramref name="second" />會傳回。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" />將傳回其也會出現在第一個序列的不同項目。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>序列，其中包含形成兩個序列之交集的項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Intersect<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      return second != null ? Enumerable.IntersectIterator<TSource>(first, second, (IEqualityComparer<TSource>) null) : throw Error.ArgumentNull(nameof (second));
    }

    /// <summary>
    ///   使用指定的產生兩個序列的集合交集<see cref="T:System.Collections.Generic.IEqualityComparer`1" />比較的值。
    /// </summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" />也會出現在其不同項目<paramref name="second" />會傳回。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" />將傳回其也會出現在第一個序列的不同項目。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" />比較的值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>序列，其中包含形成兩個序列之交集的項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Intersect<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      if (second == null)
        throw Error.ArgumentNull(nameof (second));
      return Enumerable.IntersectIterator<TSource>(first, second, comparer);
    }

    private static IEnumerable<TSource> IntersectIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      Set<TSource> set = new Set<TSource>(comparer);
      foreach (TSource source in second)
        set.Add(source);
      foreach (TSource source in first)
      {
        if (set.Remove(source))
          yield return source;
      }
    }

    /// <summary>使用預設相等比較子來比較值，會產生兩個序列的差異。</summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 不在其項目 <paramref name="second" /> 會傳回。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其同時出現在第一個序列的項目將會從傳回序列中移除這些項目。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>序列，其中包含兩個序列之項目的差異。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Except<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      return second != null ? Enumerable.ExceptIterator<TSource>(first, second, (IEqualityComparer<TSource>) null) : throw Error.ArgumentNull(nameof (second));
    }

    /// <summary>
    ///   使用指定的產生兩個序列的差異 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 不在其項目 <paramref name="second" /> 會傳回。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其同時出現在第一個序列的項目將會從傳回序列中移除這些項目。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>序列，其中包含兩個序列之項目的差異。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Except<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      if (second == null)
        throw Error.ArgumentNull(nameof (second));
      return Enumerable.ExceptIterator<TSource>(first, second, comparer);
    }

    private static IEnumerable<TSource> ExceptIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      Set<TSource> set = new Set<TSource>(comparer);
      foreach (TSource source in second)
        set.Add(source);
      foreach (TSource source in first)
      {
        if (set.Add(source))
          yield return source;
      }
    }

    /// <summary>反轉序列中項目的順序。</summary>
    /// <param name="source">要反轉方向的值序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>其項目對應於輸入序列中反向排序之項目的序列。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source) => source != null ? Enumerable.ReverseIterator<TSource>(source) : throw Error.ArgumentNull(nameof (source));

    private static IEnumerable<TSource> ReverseIterator<TSource>(
      IEnumerable<TSource> source)
    {
      Buffer<TSource> buffer = new Buffer<TSource>(source);
      for (int i = buffer.count - 1; i >= 0; --i)
        yield return buffer.items[i];
    }

    /// <summary>判斷兩個序列是否相等來比較項目之類型使用預設相等比較子。</summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 比較 <paramref name="second" />。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要比較的第一個序列。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果兩個來源序列的長度相等，而且其對應項目相等根據預設相等比較子，其類型。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool SequenceEqual<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      return first.SequenceEqual<TSource>(second, (IEqualityComparer<TSource>) null);
    }

    /// <summary>
    ///   判斷兩個序列是否相等比較其項目，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="first">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 比較 <paramref name="second" />。
    /// </param>
    /// <param name="second">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要比較的第一個序列。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 用來比較項目。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果兩個來源序列的長度相等，而且其對應項目進行比較時相等根據 <paramref name="comparer" />，否則 <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="first" /> 或 <paramref name="second" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool SequenceEqual<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      if (comparer == null)
        comparer = (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default;
      if (first == null)
        throw Error.ArgumentNull(nameof (first));
      if (second == null)
        throw Error.ArgumentNull(nameof (second));
      using (IEnumerator<TSource> enumerator1 = first.GetEnumerator())
      {
        using (IEnumerator<TSource> enumerator2 = second.GetEnumerator())
        {
          while (enumerator1.MoveNext())
          {
            if (!enumerator2.MoveNext() || !comparer.Equals(enumerator1.Current, enumerator2.Current))
              return false;
          }
          if (enumerator2.MoveNext())
            return false;
        }
      }
      return true;
    }

    /// <summary>
    ///   傳回輸入型別為 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </summary>
    /// <param name="source">
    ///   輸入序列 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入的序列的型別為 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> AsEnumerable<TSource>(
      this IEnumerable<TSource> source)
    {
      return source;
    }

    /// <summary>
    ///   建立陣列，從 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 來建立陣列。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>陣列，其中包含輸入序列中的項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source) => source != null ? new Buffer<TSource>(source).ToArray() : throw Error.ArgumentNull(nameof (source));

    /// <summary>
    ///   建立 <see cref="T:System.Collections.Generic.List`1" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.List`1" /> 從。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Collections.Generic.List`1" /> ，其中包含輸入序列中的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source) => source != null ? new List<TSource>(source) : throw Error.ArgumentNull(nameof (source));

    /// <summary>
    ///   建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 依據指定的索引鍵選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Collections.Generic.Dictionary`2" /> ，其中包含索引鍵和值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="keySelector" /> 產生的金鑰 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="keySelector" /> 會產生重複的索引鍵的兩個項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return source.ToDictionary<TSource, TKey, TSource>(keySelector, IdentityFunction<TSource>.Instance, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器函式和索引鍵比較子。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Collections.Generic.Dictionary`2" /> ，其中包含索引鍵和值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="keySelector" /> 產生的金鑰 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="keySelector" /> 會產生重複的索引鍵的兩個項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      return source.ToDictionary<TSource, TKey, TSource>(keySelector, IdentityFunction<TSource>.Instance, comparer);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器和項目選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="elementSelector">用來從每個項目產生結果項目值的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   傳回值的型別 <paramref name="elementSelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Collections.Generic.Dictionary`2" /> ，其中包含型別的值 <paramref name="TElement" /> 輸入序列中選取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="keySelector" /> 產生的金鑰 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="keySelector" /> 會產生重複的索引鍵的兩個項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      return source.ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器函式、 比較子和項目選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.Dictionary`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="elementSelector">用來從每個項目產生結果項目值的轉換函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   傳回值的型別 <paramref name="elementSelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Collections.Generic.Dictionary`2" /> ，其中包含型別的值 <paramref name="TElement" /> 輸入序列中選取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="keySelector" /> 產生的金鑰 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="keySelector" /> 會產生重複的索引鍵的兩個項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (elementSelector == null)
        throw Error.ArgumentNull(nameof (elementSelector));
      Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
      foreach (TSource source1 in source)
        dictionary.Add(keySelector(source1), elementSelector(source1));
      return dictionary;
    }

    /// <summary>
    ///   建立 <see cref="T:System.Linq.Lookup`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 依據指定的索引鍵選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Linq.Lookup`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Linq.Lookup`2" /> ，其中包含索引鍵和值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      return (ILookup<TKey, TSource>) Lookup<TKey, TSource>.Create<TSource>(source, keySelector, IdentityFunction<TSource>.Instance, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Linq.Lookup`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器函式和索引鍵比較子。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Linq.Lookup`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Linq.Lookup`2" /> ，其中包含索引鍵和值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      return (ILookup<TKey, TSource>) Lookup<TKey, TSource>.Create<TSource>(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Linq.Lookup`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器和項目選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Linq.Lookup`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="elementSelector">用來從每個項目產生結果項目值的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   傳回值的型別 <paramref name="elementSelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Linq.Lookup`2" /> ，其中包含型別的值 <paramref name="TElement" /> 輸入序列中選取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      return (ILookup<TKey, TElement>) Lookup<TKey, TElement>.Create<TSource>(source, keySelector, elementSelector, (IEqualityComparer<TKey>) null);
    }

    /// <summary>
    ///   建立 <see cref="T:System.Linq.Lookup`2" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 根據指定的索引鍵選取器函式、 比較子和項目選取器函式。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Linq.Lookup`2" /> 從。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="elementSelector">用來從每個項目產生結果項目值的轉換函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   傳回值的型別 <paramref name="elementSelector" />。
    /// </typeparam>
    /// <returns>
    ///   A <see cref="T:System.Linq.Lookup`2" /> ，其中包含型別的值 <paramref name="TElement" /> 輸入序列中選取。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      return (ILookup<TKey, TElement>) Lookup<TKey, TElement>.Create<TSource>(source, keySelector, elementSelector, comparer);
    }

    /// <summary>
    ///   從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.HashSet`1" />。
    /// </summary>
    /// <param name="source">
    /// 
    /// 用來建立 <see cref="T:System.Collections.Generic.HashSet`1" /> 的來源 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    ///   </param>
    /// <typeparam name="TSource">
    ///   <paramref name="source" /> 項目的類型。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.HashSet`1" />，包含從輸入序列選取之 TSource 類型的值。
    /// </returns>
    public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source) => source.ToHashSet<TSource>((IEqualityComparer<TSource>) null);

    /// <summary>
    ///   使用 <paramref name="comparer" /> 從 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 建立 <see cref="T:System.Collections.Generic.HashSet`1" /> 以比較金鑰
    /// </summary>
    /// <param name="source">
    ///   用來建立 <see cref="T:System.Collections.Generic.HashSet`1" /> 的來源 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </param>
    /// <param name="comparer">
    ///   用來比較金鑰的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </param>
    /// <typeparam name="TSource">
    ///   <paramref name="source" /> 的元素類型
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.HashSet`1" />，包含從輸入序列選取之 <paramref name="TSource" /> 類型的值。
    /// </returns>
    public static HashSet<TSource> ToHashSet<TSource>(
      this IEnumerable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      return source != null ? new HashSet<TSource>(source, comparer) : throw Error.ArgumentNull(nameof (source));
    }

    /// <summary>傳回單一集合中指定的序列或型別參數的預設值的項目，如果序列是空的。</summary>
    /// <param name="source">序列，若此序列空白，便傳回預設值。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 物件，其中包含的預設值為 <paramref name="TSource" /> 輸入如果 <paramref name="source" /> 是空的否則 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> DefaultIfEmpty<TSource>(
      this IEnumerable<TSource> source)
    {
      return source.DefaultIfEmpty<TSource>(default (TSource));
    }

    /// <summary>傳回單一集合中指定的序列或指定的值的項目，如果序列是空的。</summary>
    /// <param name="source">序列，若此序列空白，便傳回指定的值。</param>
    /// <param name="defaultValue">在序列空白時所要傳回的值。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含 <paramref name="defaultValue" /> 如果 <paramref name="source" /> 是空的否則 <paramref name="source" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TSource> DefaultIfEmpty<TSource>(
      this IEnumerable<TSource> source,
      TSource defaultValue)
    {
      return source != null ? Enumerable.DefaultIfEmptyIterator<TSource>(source, defaultValue) : throw Error.ArgumentNull(nameof (source));
    }

    private static IEnumerable<TSource> DefaultIfEmptyIterator<TSource>(
      IEnumerable<TSource> source,
      TSource defaultValue)
    {
      using (IEnumerator<TSource> e = source.GetEnumerator())
      {
        if (e.MoveNext())
        {
          do
          {
            yield return e.Current;
          }
          while (e.MoveNext());
        }
        else
          yield return defaultValue;
      }
    }

    /// <summary>
    ///   篩選的項目 <see cref="T:System.Collections.IEnumerable" /> 根據指定的型別。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.IEnumerable" /> 來篩選其項目。
    /// </param>
    /// <typeparam name="TResult">用來做為序列項目之篩選依據的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含輸入序列的型別中的項目 <paramref name="TResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source) => source != null ? Enumerable.OfTypeIterator<TResult>(source) : throw Error.ArgumentNull(nameof (source));

    private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
    {
      foreach (object obj in source)
      {
        if (obj is TResult result)
          yield return result;
      }
    }

    /// <summary>
    ///   將轉換的項目 <see cref="T:System.Collections.IEnumerable" /> 指定的型別。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.IEnumerable" /> ，其中包含要轉換成輸入的項目 <paramref name="TResult" />。
    /// </param>
    /// <typeparam name="TResult">
    ///   要轉換的項目型別 <paramref name="source" /> 來。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含指定的型別轉換的來源序列的每個項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidCastException">
    ///   序列中的項目無法轉換成型別 <paramref name="TResult" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
    {
      if (source is IEnumerable<TResult> results)
        return results;
      return source != null ? Enumerable.CastIterator<TResult>(source) : throw Error.ArgumentNull(nameof (source));
    }

    private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
    {
      foreach (TResult result in source)
        yield return result;
    }

    /// <summary>傳回序列的第一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的第一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>指定之序列中的第一個項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource First<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        if (sourceList.Count > 0)
          return sourceList[0];
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          if (enumerator.MoveNext())
            return enumerator.Current;
        }
      }
      throw Error.NoElements();
    }

    /// <summary>傳回序列中符合指定條件的第一個元素。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中通過指定之述詞函式所做測試的第一個項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   沒有任何項目符合條件中的 <paramref name="predicate" />。
    /// 
    ///   -或-
    /// 
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource First<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          return source1;
      }
      throw Error.NoMatch();
    }

    /// <summary>傳回序列的第一個元素；如果序列中沒有包含任何元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的第一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="default" />(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的否則中的第一個項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        if (sourceList.Count > 0)
          return sourceList[0];
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          if (enumerator.MoveNext())
            return enumerator.Current;
        }
      }
      return default (TSource);
    }

    /// <summary>傳回序列中符合條件的第一個元素；如果找不到這類元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="default" />(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的或如果沒有任何項目會指定測試 <paramref name="predicate" />; 否則在第一個項目 <paramref name="source" /> 中通過指定測試 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource FirstOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          return source1;
      }
      return default (TSource);
    }

    /// <summary>傳回序列的最後一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的最後一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>位於來源序列中最後一個位置的值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Last<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        int count = sourceList.Count;
        if (count > 0)
          return sourceList[count - 1];
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          if (enumerator.MoveNext())
          {
            TSource current;
            do
            {
              current = enumerator.Current;
            }
            while (enumerator.MoveNext());
            return current;
          }
        }
      }
      throw Error.NoElements();
    }

    /// <summary>傳回序列中符合指定之條件的最後一個元素。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中通過指定之述詞函式所做測試的最後一個項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   沒有任何項目符合條件中的 <paramref name="predicate" />。
    /// 
    ///   -或-
    /// 
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Last<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      TSource source1 = default (TSource);
      bool flag = false;
      foreach (TSource source2 in source)
      {
        if (predicate(source2))
        {
          source1 = source2;
          flag = true;
        }
      }
      if (flag)
        return source1;
      throw Error.NoMatch();
    }

    /// <summary>傳回序列的最後一個元素；如果序列中沒有包含任何元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的最後一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="default" />(<paramref name="TSource" />) 如果來源序列是空的否則中的最後一個項目 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        int count = sourceList.Count;
        if (count > 0)
          return sourceList[count - 1];
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          if (enumerator.MoveNext())
          {
            TSource current;
            do
            {
              current = enumerator.Current;
            }
            while (enumerator.MoveNext());
            return current;
          }
        }
      }
      return default (TSource);
    }

    /// <summary>傳回序列中符合條件的最後一個元素；如果找不到這類元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="default" />(<paramref name="TSource" />) 如果序列是空的或如果任何元素不通過測試述詞的函式; 否則最後一個項目，通過測試述詞函式。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource LastOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      TSource source1 = default (TSource);
      foreach (TSource source2 in source)
      {
        if (predicate(source2))
          source1 = source2;
      }
      return source1;
    }

    /// <summary>傳回序列的唯一一個元素，如果序列中不是正好一個元素，則擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的單一項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>輸入序列的單一項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   輸入的序列包含一個以上的項目。
    /// 
    ///   -或-
    /// 
    ///   輸入的序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Single<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        switch (sourceList.Count)
        {
          case 0:
            throw Error.NoElements();
          case 1:
            return sourceList[0];
        }
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          TSource source1 = enumerator.MoveNext() ? enumerator.Current : throw Error.NoElements();
          if (!enumerator.MoveNext())
            return source1;
        }
      }
      throw Error.MoreThanOneElement();
    }

    /// <summary>傳回序列中符合指定之條件的唯一一個元素，如果有一個以上這類元素，則擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回單一項目。
    /// </param>
    /// <param name="predicate">用來測試項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>輸入序列中符合條件的單一項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   沒有任何項目符合條件中的 <paramref name="predicate" />。
    /// 
    ///   -或-
    /// 
    ///   多個項目符合條件中的 <paramref name="predicate" />。
    /// 
    ///   -或-
    /// 
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Single<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      TSource source1 = default (TSource);
      long num = 0;
      foreach (TSource source2 in source)
      {
        if (predicate(source2))
        {
          source1 = source2;
          checked { ++num; }
        }
      }
      if (num == 0L)
        throw Error.NoMatch();
      if (num == 1L)
        return source1;
      throw Error.MoreThanOneMatch();
    }

    /// <summary>傳回的唯一項目序列或預設值，如果序列是空的。如果序列中有多個項目，則這個方法會擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的單一項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入序列的單一項目或 <see langword="default" />(<paramref name="TSource" />) 如果序列中沒有包含任何項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   輸入的序列包含一個以上的項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
      {
        switch (sourceList.Count)
        {
          case 0:
            return default (TSource);
          case 1:
            return sourceList[0];
        }
      }
      else
      {
        using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        {
          if (!enumerator.MoveNext())
            return default (TSource);
          TSource current = enumerator.Current;
          if (!enumerator.MoveNext())
            return current;
        }
      }
      throw Error.MoreThanOneElement();
    }

    /// <summary>
    ///   傳回序列中符合指定之條件的唯一一個元素，如果沒有這類元素，則為預設值，如果有一個以上的元素符合條件，這個方法就會擲回例外狀況。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回單一項目。
    /// </param>
    /// <param name="predicate">用來測試項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入序列中符合條件的單一項目或 <see langword="default" />(<paramref name="TSource" />) 如果找到這類項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource SingleOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      TSource source1 = default (TSource);
      long num = 0;
      foreach (TSource source2 in source)
      {
        if (predicate(source2))
        {
          source1 = source2;
          checked { ++num; }
        }
      }
      if (num == 0L)
        return default (TSource);
      if (num == 1L)
        return source1;
      throw Error.MoreThanOneMatch();
    }

    /// <summary>傳回序列中的指定索引處的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="index">要擷取的項目之以零為起始索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>位於來源序列中指定位置的項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於 0 或大於或等於數字中的項目是 <paramref name="source" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IList<TSource> sourceList)
        return sourceList[index];
      if (index < 0)
        throw Error.ArgumentOutOfRange(nameof (index));
      using (IEnumerator<TSource> enumerator = source.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          if (index == 0)
            return enumerator.Current;
          --index;
        }
        throw Error.ArgumentOutOfRange(nameof (index));
      }
    }

    /// <summary>傳回位於序列中指定索引處的元素；如果索引超出範圍，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 傳回的項目。
    /// </param>
    /// <param name="index">要擷取的項目之以零為起始索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="default" />(<paramref name="TSource" />) 如果索引超出界限的來源序列中; 否則在來源序列中指定位置處的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (index >= 0)
      {
        if (source is IList<TSource> sourceList)
        {
          if (index < sourceList.Count)
            return sourceList[index];
        }
        else
        {
          foreach (TSource source1 in source)
          {
            if (index == 0)
              return source1;
            --index;
          }
        }
      }
      return default (TSource);
    }

    /// <summary>產生指定的範圍內的整數序列。</summary>
    /// <param name="start">序列中第一個整數的值。</param>
    /// <param name="count">要產生的循序整數數目。</param>
    /// <returns>
    ///   IEnumerable&lt;Int32&gt; 在 C# 或 IEnumerable(Of Int32) 中 Visual Basic ，其中包含的循序整數範圍。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="count" /> 小於 0。
    /// 
    ///   -或-
    /// 
    ///   <paramref name="start" /> + <paramref name="count" /> -1 會大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<int> Range(int start, int count)
    {
      long num = (long) start + (long) count - 1L;
      return count >= 0 && num <= (long) int.MaxValue ? Enumerable.RangeIterator(start, count) : throw Error.ArgumentOutOfRange(nameof (count));
    }

    private static IEnumerable<int> RangeIterator(int start, int count)
    {
      for (int i = 0; i < count; ++i)
        yield return start + i;
    }

    /// <summary>產生包含一個重複的值的序列。</summary>
    /// <param name="element">要重複的值。</param>
    /// <param name="count">這個值要在產生的序列中重複出現的次數。</param>
    /// <typeparam name="TResult">要在結果序列中重複出現的值之類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含重複的值。
    /// </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="count" /> 小於 0。
    /// </exception>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) => count >= 0 ? Enumerable.RepeatIterator<TResult>(element, count) : throw Error.ArgumentOutOfRange(nameof (count));

    private static IEnumerable<TResult> RepeatIterator<TResult>(
      TResult element,
      int count)
    {
      for (int i = 0; i < count; ++i)
        yield return element;
    }

    /// <summary>
    ///   傳回一個空 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 具有指定的型別引數。
    /// </summary>
    /// <typeparam name="TResult">
    ///   若要指派給傳回的泛型型別參數的型別 <see cref="T:System.Collections.Generic.IEnumerable`1" />。
    /// </typeparam>
    /// <returns>
    ///   空白 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其類型引數是 <paramref name="TResult" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static IEnumerable<TResult> Empty<TResult>() => (IEnumerable<TResult>) EmptyEnumerable<TResult>.Instance;

    /// <summary>判斷序列是否包含任何項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 檢查空的序列。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果來源序列中沒有包含任何項目。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Any<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      using (IEnumerator<TSource> enumerator = source.GetEnumerator())
      {
        if (enumerator.MoveNext())
          return true;
      }
      return false;
    }

    /// <summary>判斷序列中的任何項目是否符合條件。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其中項目套用述詞。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果來源序列中的任何元素通過測試中指定的述詞。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          return true;
      }
      return false;
    }

    /// <summary>判斷序列中的所有項目是否全都符合條件。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含的項目套用述詞。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果來源序列的每個項目中指定的述詞，通過測試，或如果序列是空的。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      foreach (TSource source1 in source)
      {
        if (!predicate(source1))
          return false;
      }
      return true;
    }

    /// <summary>傳回序列中的項目數目。</summary>
    /// <param name="source">包含要計算之項目的序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>輸入序列中的項目數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   中的項目數 <paramref name="source" /> 大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Count<TSource>(this IEnumerable<TSource> source)
    {
      switch (source)
      {
        case null:
          throw Error.ArgumentNull(nameof (source));
        case ICollection<TSource> sources:
          return sources.Count;
        case ICollection collection:
          return collection.Count;
        default:
          int num = 0;
          using (IEnumerator<TSource> enumerator = source.GetEnumerator())
          {
            while (enumerator.MoveNext())
              checked { ++num; }
          }
          return num;
      }
    }

    /// <summary>傳回表示指定之序列中的項目數目符合條件的數字。</summary>
    /// <param name="source">包含要測試及計算項目的序列。</param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>數字，代表序列中符合述詞函式之條件的項目數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   中的項目數 <paramref name="source" /> 大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Count<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      int num = 0;
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          checked { ++num; }
      }
      return num;
    }

    /// <summary>
    ///   傳回<see cref="T:System.Int64" />代表序列中的項目總數。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含要計算的項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   <paramref name="source" /> 項目的類型。
    /// </typeparam>
    /// <returns>來源序列中的項目數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   元素數目超過<see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long LongCount<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num = 0;
      using (IEnumerator<TSource> enumerator = source.GetEnumerator())
      {
        while (enumerator.MoveNext())
          checked { ++num; }
      }
      return num;
    }

    /// <summary>
    ///   傳回 <see cref="T:System.Int64" /> ，代表符合條件的序列中的項目數目。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，其中包含要計算的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>數字，代表序列中符合述詞函式之條件的項目數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   相符項目數目超過 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long LongCount<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      long num = 0;
      foreach (TSource source1 in source)
      {
        if (predicate(source1))
          checked { ++num; }
      }
      return num;
    }

    /// <summary>判斷序列是否包含指定的項目，使用預設相等比較子。</summary>
    /// <param name="source">要在其中尋找值的序列。</param>
    /// <param name="value">要在序列中尋找的值。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果來源序列包含具有指定的值; 的項目否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value) => source is ICollection<TSource> sources ? sources.Contains(value) : source.Contains<TSource>(value, (IEqualityComparer<TSource>) null);

    /// <summary>
    ///   判斷序列是否包含指定的項目，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="source">要在其中尋找值的序列。</param>
    /// <param name="value">要在序列中尋找的值。</param>
    /// <param name="comparer">用來比較值的相等比較子。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果來源序列包含具有指定的值; 的項目否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Contains<TSource>(
      this IEnumerable<TSource> source,
      TSource value,
      IEqualityComparer<TSource> comparer)
    {
      if (comparer == null)
        comparer = (IEqualityComparer<TSource>) EqualityComparer<TSource>.Default;
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      foreach (TSource x in source)
      {
        if (comparer.Equals(x, value))
          return true;
      }
      return false;
    }

    /// <summary>將累加函式套用到序列。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要彙總。
    /// </param>
    /// <param name="func">要在每個項目上叫用 (Invoke) 的累加函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>最終累積值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="func" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Aggregate<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource, TSource> func)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      using (IEnumerator<TSource> enumerator = source.GetEnumerator())
      {
        TSource source1 = enumerator.MoveNext() ? enumerator.Current : throw Error.NoElements();
        while (enumerator.MoveNext())
          source1 = func(source1, enumerator.Current);
        return source1;
      }
    }

    /// <summary>
    ///   將累加函式套用到序列。
    ///    使用指定的初始值做為初始累加值。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要彙總。
    /// </param>
    /// <param name="seed">初始累積值。</param>
    /// <param name="func">要在每個項目上叫用 (Invoke) 的累加函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TAccumulate">累積值的類型。</typeparam>
    /// <returns>最終累積值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="func" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TAccumulate Aggregate<TSource, TAccumulate>(
      this IEnumerable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> func)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      TAccumulate accumulate = seed;
      foreach (TSource source1 in source)
        accumulate = func(accumulate, source1);
      return accumulate;
    }

    /// <summary>
    ///   將累加函式套用到序列。
    ///    使用指定的值做為初始累加值，並使用指定的函式來選取結果值。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要彙總。
    /// </param>
    /// <param name="seed">初始累積值。</param>
    /// <param name="func">要在每個項目上叫用 (Invoke) 的累加函式。</param>
    /// <param name="resultSelector">用來將最終累加值轉換成結果值的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TAccumulate">累積值的類型。</typeparam>
    /// <typeparam name="TResult">結果值的類型。</typeparam>
    /// <returns>轉換後的最終累加值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="func" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Aggregate<TSource, TAccumulate, TResult>(
      this IEnumerable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> func,
      Func<TAccumulate, TResult> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      TAccumulate accumulate = seed;
      foreach (TSource source1 in source)
        accumulate = func(accumulate, source1);
      return resultSelector(accumulate);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int32" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Sum(this IEnumerable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int num1 = 0;
      foreach (int num2 in source)
        checked { num1 += num2; }
      return num1;
    }

    /// <summary>
    ///   計算的一系列可為 null 總和 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int32" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Sum(this IEnumerable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int num = 0;
      foreach (int? nullable in source)
      {
        if (nullable.HasValue)
          checked { num += nullable.GetValueOrDefault(); }
      }
      return new int?(num);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int64" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Sum(this IEnumerable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      foreach (long num2 in source)
        checked { num1 += num2; }
      return num1;
    }

    /// <summary>
    ///   計算的一系列可為 null 總和 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int64" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Sum(this IEnumerable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num = 0;
      foreach (long? nullable in source)
      {
        if (nullable.HasValue)
          checked { num += nullable.GetValueOrDefault(); }
      }
      return new long?(num);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Single" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Sum(this IEnumerable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      foreach (float num2 in source)
        num1 += (double) num2;
      return (float) num1;
    }

    /// <summary>
    ///   計算的一系列可為 null 總和 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Single" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Sum(this IEnumerable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num = 0.0;
      foreach (float? nullable in source)
      {
        if (nullable.HasValue)
          num += (double) nullable.GetValueOrDefault();
      }
      return new float?((float) num);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Double" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Sum(this IEnumerable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      foreach (double num2 in source)
        num1 += num2;
      return num1;
    }

    /// <summary>
    ///   計算的一系列可為 null 總和 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Double" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Sum(this IEnumerable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num = 0.0;
      foreach (double? nullable in source)
      {
        if (nullable.HasValue)
          num += nullable.GetValueOrDefault();
      }
      return new double?(num);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Decimal" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Sum(this IEnumerable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num1 = 0M;
      foreach (Decimal num2 in source)
        num1 += num2;
      return num1;
    }

    /// <summary>
    ///   計算的一系列可為 null 總和 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Decimal" /> 值來計算的總和。
    /// </param>
    /// <returns>序列中值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Sum(this IEnumerable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num = 0M;
      foreach (Decimal? nullable in source)
      {
        if (nullable.HasValue)
          num += nullable.GetValueOrDefault();
      }
      return new Decimal?(num);
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int32" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => source.Select<TSource, int>(selector).Sum();

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Int32" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => source.Select<TSource, int?>(selector).Sum();

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int64" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => source.Select<TSource, long>(selector).Sum();

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Int64" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      return source.Select<TSource, long?>(selector).Sum();
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Single" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      return source.Select<TSource, float>(selector).Sum();
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Single" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      return source.Select<TSource, float?>(selector).Sum();
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Double" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      return source.Select<TSource, double>(selector).Sum();
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Double" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      return source.Select<TSource, double?>(selector).Sum();
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Decimal" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      return source.Select<TSource, Decimal>(selector).Sum();
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Decimal" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算總和的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      return source.Select<TSource, Decimal?>(selector).Sum();
    }

    /// <summary>
    ///   傳回序列中的最小值 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int32" /> 值來判斷最小值。
    /// </param>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Min(this IEnumerable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int num1 = 0;
      bool flag = false;
      foreach (int num2 in source)
      {
        if (flag)
        {
          if (num2 < num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最小值為 null 的序列中 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int32" /> 值來判斷最小值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Int32&gt; 在 C# 或 Nullable(Of Int32) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Min(this IEnumerable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int? nullable1 = new int?();
      foreach (int? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          int? nullable3 = nullable2;
          int? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() < nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最小值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int64" /> 值來判斷最小值。
    /// </param>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Min(this IEnumerable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      bool flag = false;
      foreach (long num2 in source)
      {
        if (flag)
        {
          if (num2 < num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最小值為 null 的序列中 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int64" /> 值來判斷最小值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Int64&gt; 在 C# 或 Nullable(Of Int64) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Min(this IEnumerable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long? nullable1 = new long?();
      foreach (long? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          long? nullable3 = nullable2;
          long? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() < nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最小值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Single" /> 值來判斷最小值。
    /// </param>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Min(this IEnumerable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      float num = 0.0f;
      bool flag = false;
      foreach (float f in source)
      {
        if (flag)
        {
          if ((double) f < (double) num || float.IsNaN(f))
            num = f;
        }
        else
        {
          num = f;
          flag = true;
        }
      }
      if (flag)
        return num;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最小值為 null 的序列中 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Single" /> 值來判斷最小值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Single&gt; 在 C# 或 Nullable(Of Single) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Min(this IEnumerable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      float? nullable1 = new float?();
      foreach (float? nullable2 in source)
      {
        if (nullable2.HasValue)
        {
          if (nullable1.HasValue)
          {
            float? nullable3 = nullable2;
            float? nullable4 = nullable1;
            if (((double) nullable3.GetValueOrDefault() < (double) nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0 && !float.IsNaN(nullable2.Value))
              continue;
          }
          nullable1 = nullable2;
        }
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最小值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Double" /> 值來判斷最小值。
    /// </param>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Min(this IEnumerable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num = 0.0;
      bool flag = false;
      foreach (double d in source)
      {
        if (flag)
        {
          if (d < num || double.IsNaN(d))
            num = d;
        }
        else
        {
          num = d;
          flag = true;
        }
      }
      if (flag)
        return num;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最小值為 null 的序列中 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Double" /> 值來判斷最小值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Double&gt; 在 C# 或 Nullable(Of Double) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Min(this IEnumerable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double? nullable1 = new double?();
      foreach (double? nullable2 in source)
      {
        if (nullable2.HasValue)
        {
          if (nullable1.HasValue)
          {
            double? nullable3 = nullable2;
            double? nullable4 = nullable1;
            if ((nullable3.GetValueOrDefault() < nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0 && !double.IsNaN(nullable2.Value))
              continue;
          }
          nullable1 = nullable2;
        }
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最小值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Decimal" /> 值來判斷最小值。
    /// </param>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Min(this IEnumerable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num1 = 0M;
      bool flag = false;
      foreach (Decimal num2 in source)
      {
        if (flag)
        {
          if (num2 < num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最小值為 null 的序列中 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Decimal" /> 值來判斷最小值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Decimal&gt; 在 C# 或 Nullable(Of Decimal) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Min(this IEnumerable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal? nullable1 = new Decimal?();
      foreach (Decimal? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          Decimal? nullable3 = nullable2;
          Decimal? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() < nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>傳回泛型序列中的最小值。</summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Min<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Comparer<TSource> comparer = Comparer<TSource>.Default;
      TSource y = default (TSource);
      if ((object) y == null)
      {
        foreach (TSource x in source)
        {
          if ((object) x != null && ((object) y == null || comparer.Compare(x, y) < 0))
            y = x;
        }
        return y;
      }
      bool flag = false;
      foreach (TSource x in source)
      {
        if (flag)
        {
          if (comparer.Compare(x, y) < 0)
            y = x;
        }
        else
        {
          y = x;
          flag = true;
        }
      }
      if (flag)
        return y;
      throw Error.NoElements();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => source.Select<TSource, int>(selector).Min();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值為 null <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Int32&gt; 在 C# 或 Nullable(Of Int32) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => source.Select<TSource, int?>(selector).Min();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => source.Select<TSource, long>(selector).Min();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值為 null <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Int64&gt; 在 C# 或 Nullable(Of Int64) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      return source.Select<TSource, long?>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      return source.Select<TSource, float>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值為 null <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Single&gt; 在 C# 或 Nullable(Of Single) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      return source.Select<TSource, float?>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      return source.Select<TSource, double>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值為 null <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Double&gt; 在 C# 或 Nullable(Of Double) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      return source.Select<TSource, double?>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      return source.Select<TSource, Decimal>(selector).Min();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最小值為 null <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Decimal&gt; 在 C# 或 Nullable(Of Decimal) 中 Visual Basic 對應至序列中的最小值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      return source.Select<TSource, Decimal?>(selector).Min();
    }

    /// <summary>叫用轉換函式的泛型序列的每個項目並傳回產生的最小值。</summary>
    /// <param name="source">要判斷最小值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Min<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      return source.Select<TSource, TResult>(selector).Min<TResult>();
    }

    /// <summary>
    ///   傳回序列中的最大值 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int32" /> 值來判斷的最大值。
    /// </param>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Max(this IEnumerable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int num1 = 0;
      bool flag = false;
      foreach (int num2 in source)
      {
        if (flag)
        {
          if (num2 > num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最大值為 null 的序列中 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int32" /> 值來判斷的最大值。
    /// </param>
    /// <returns>
    /// 型別的值 Nullable&lt;Int32&gt; 在 C# 或 Nullable(Of Int32) 中 Visual Basic 對應至序列中的最大值。 </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Max(this IEnumerable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      int? nullable1 = new int?();
      foreach (int? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          int? nullable3 = nullable2;
          int? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() > nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最大值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int64" /> 值來判斷的最大值。
    /// </param>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Max(this IEnumerable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      bool flag = false;
      foreach (long num2 in source)
      {
        if (flag)
        {
          if (num2 > num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最大值為 null 的序列中 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int64" /> 值來判斷的最大值。
    /// </param>
    /// <returns>
    /// 型別的值 Nullable&lt;Int64&gt; 在 C# 或 Nullable(Of Int64) 中 Visual Basic 對應至序列中的最大值。 </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Max(this IEnumerable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long? nullable1 = new long?();
      foreach (long? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          long? nullable3 = nullable2;
          long? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() > nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最大值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Double" /> 值來判斷的最大值。
    /// </param>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Max(this IEnumerable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double d = 0.0;
      bool flag = false;
      foreach (double num in source)
      {
        if (flag)
        {
          if (num > d || double.IsNaN(d))
            d = num;
        }
        else
        {
          d = num;
          flag = true;
        }
      }
      if (flag)
        return d;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最大值為 null 的序列中 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Double" /> 值來判斷的最大值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Double&gt; 在 C# 或 Nullable(Of Double) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Max(this IEnumerable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double? nullable1 = new double?();
      foreach (double? nullable2 in source)
      {
        if (nullable2.HasValue)
        {
          if (nullable1.HasValue)
          {
            double? nullable3 = nullable2;
            double? nullable4 = nullable1;
            if ((nullable3.GetValueOrDefault() > nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0 && !double.IsNaN(nullable1.Value))
              continue;
          }
          nullable1 = nullable2;
        }
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最大值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Single" /> 值來判斷的最大值。
    /// </param>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Max(this IEnumerable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      float num1 = 0.0f;
      bool flag = false;
      foreach (float num2 in source)
      {
        if (flag)
        {
          if ((double) num2 > (double) num1 || double.IsNaN((double) num1))
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最大值為 null 的序列中 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Single" /> 值來判斷的最大值。
    /// </param>
    /// <returns>
    ///   型別的值 Nullable&lt;Single&gt; 在 C# 或 Nullable(Of Single) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Max(this IEnumerable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      float? nullable1 = new float?();
      foreach (float? nullable2 in source)
      {
        if (nullable2.HasValue)
        {
          if (nullable1.HasValue)
          {
            float? nullable3 = nullable2;
            float? nullable4 = nullable1;
            if (((double) nullable3.GetValueOrDefault() > (double) nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0 && !float.IsNaN(nullable1.Value))
              continue;
          }
          nullable1 = nullable2;
        }
      }
      return nullable1;
    }

    /// <summary>
    ///   傳回序列中的最大值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Decimal" /> 值來判斷的最大值。
    /// </param>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Max(this IEnumerable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num1 = 0M;
      bool flag = false;
      foreach (Decimal num2 in source)
      {
        if (flag)
        {
          if (num2 > num1)
            num1 = num2;
        }
        else
        {
          num1 = num2;
          flag = true;
        }
      }
      if (flag)
        return num1;
      throw Error.NoElements();
    }

    /// <summary>
    ///   傳回的最大值為 null 的序列中 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Decimal" /> 值來判斷的最大值。
    /// </param>
    /// <returns>
    /// 型別的值 Nullable&lt;Decimal&gt; 在 C# 或 Nullable(Of Decimal) 中 Visual Basic 對應至序列中的最大值。 </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Max(this IEnumerable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal? nullable1 = new Decimal?();
      foreach (Decimal? nullable2 in source)
      {
        if (nullable1.HasValue)
        {
          Decimal? nullable3 = nullable2;
          Decimal? nullable4 = nullable1;
          if ((nullable3.GetValueOrDefault() > nullable4.GetValueOrDefault() ? (nullable3.HasValue & nullable4.HasValue ? 1 : 0) : 0) == 0)
            continue;
        }
        nullable1 = nullable2;
      }
      return nullable1;
    }

    /// <summary>傳回泛型序列中的最大值。</summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Max<TSource>(this IEnumerable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Comparer<TSource> comparer = Comparer<TSource>.Default;
      TSource y = default (TSource);
      if ((object) y == null)
      {
        foreach (TSource x in source)
        {
          if ((object) x != null && ((object) y == null || comparer.Compare(x, y) > 0))
            y = x;
        }
        return y;
      }
      bool flag = false;
      foreach (TSource x in source)
      {
        if (flag)
        {
          if (comparer.Compare(x, y) > 0)
            y = x;
        }
        else
        {
          y = x;
          flag = true;
        }
      }
      if (flag)
        return y;
      throw Error.NoElements();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => source.Select<TSource, int>(selector).Max();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大值為 null <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Int32&gt; 在 C# 或 Nullable(Of Int32) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => source.Select<TSource, int?>(selector).Max();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => source.Select<TSource, long>(selector).Max();

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大值為 null <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Int64&gt; 在 C# 或 Nullable(Of Int64) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      return source.Select<TSource, long?>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      return source.Select<TSource, float>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大值為 null <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Single&gt; 在 C# 或 Nullable(Of Single) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      return source.Select<TSource, float?>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      return source.Select<TSource, double>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大值為 null <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Double&gt; 在 C# 或 Nullable(Of Double) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      return source.Select<TSource, double?>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      return source.Select<TSource, Decimal>(selector).Max();
    }

    /// <summary>
    ///   叫用轉換函式上序列的每個項目，並傳回最大值為 null <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   型別的值 Nullable&lt;Decimal&gt; 在 C# 或 Nullable(Of Decimal) 中 Visual Basic 對應至序列中的最大值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      return source.Select<TSource, Decimal?>(selector).Max();
    }

    /// <summary>叫用轉換函式的泛型序列的每個項目並傳回產生的最大值。</summary>
    /// <param name="source">要判斷最大值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Max<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      return source.Select<TSource, TResult>(selector).Max<TResult>();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int32" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int32" /> 來計算平均值的值。
    /// </param>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average(this IEnumerable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      long num2 = 0;
      foreach (int num3 in source)
      {
        checked { num1 += (long) num3; }
        checked { ++num2; }
      }
      if (num2 > 0L)
        return (double) num1 / (double) num2;
      throw Error.NoElements();
    }

    /// <summary>
    ///   計算可為 Null 之 <see cref="T:System.Int32" /> 值序列的平均值。
    /// </summary>
    /// <param name="source">
    ///   要計算其平均值的可為 Null 之 <see cref="T:System.Int32" /> 值的序列。
    /// </param>
    /// <returns>
    ///   值序列的平均值，或者，如果來源序列是空的或只包含 <see langword="null" /> 值，則為 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average(this IEnumerable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      long num2 = 0;
      foreach (int? nullable in source)
      {
        if (nullable.HasValue)
        {
          checked { num1 += (long) nullable.GetValueOrDefault(); }
          checked { ++num2; }
        }
      }
      return num2 > 0L ? new double?((double) num1 / (double) num2) : new double?();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Int64" /> 來計算平均值的值。
    /// </param>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average(this IEnumerable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      long num2 = 0;
      foreach (long num3 in source)
      {
        checked { num1 += num3; }
        checked { ++num2; }
      }
      if (num2 > 0L)
        return (double) num1 / (double) num2;
      throw Error.NoElements();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int64" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average(this IEnumerable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      long num1 = 0;
      long num2 = 0;
      foreach (long? nullable in source)
      {
        if (nullable.HasValue)
        {
          checked { num1 += nullable.GetValueOrDefault(); }
          checked { ++num2; }
        }
      }
      return num2 > 0L ? new double?((double) num1 / (double) num2) : new double?();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Single" /> 來計算平均值的值。
    /// </param>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Average(this IEnumerable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      long num2 = 0;
      foreach (float num3 in source)
      {
        num1 += (double) num3;
        checked { ++num2; }
      }
      if (num2 > 0L)
        return (float) num1 / (float) num2;
      throw Error.NoElements();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Single" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Average(this IEnumerable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      long num2 = 0;
      foreach (float? nullable in source)
      {
        if (nullable.HasValue)
        {
          num1 += (double) nullable.GetValueOrDefault();
          checked { ++num2; }
        }
      }
      return num2 > 0L ? new float?((float) num1 / (float) num2) : new float?();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Double" /> 來計算平均值的值。
    /// </param>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average(this IEnumerable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      long num2 = 0;
      foreach (double num3 in source)
      {
        num1 += num3;
        checked { ++num2; }
      }
      if (num2 > 0L)
        return num1 / (double) num2;
      throw Error.NoElements();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Double" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average(this IEnumerable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      double num1 = 0.0;
      long num2 = 0;
      foreach (double? nullable in source)
      {
        if (nullable.HasValue)
        {
          num1 += nullable.GetValueOrDefault();
          checked { ++num2; }
        }
      }
      return num2 > 0L ? new double?(num1 / (double) num2) : new double?();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   一系列 <see cref="T:System.Decimal" /> 來計算平均值的值。
    /// </param>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Average(this IEnumerable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num1 = 0M;
      long num2 = 0;
      foreach (Decimal num3 in source)
      {
        num1 += num3;
        checked { ++num2; }
      }
      if (num2 > 0L)
        return num1 / (Decimal) num2;
      throw Error.NoElements();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Decimal" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Average(this IEnumerable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      Decimal num1 = 0M;
      long num2 = 0;
      foreach (Decimal? nullable in source)
      {
        if (nullable.HasValue)
        {
          num1 += nullable.GetValueOrDefault();
          checked { ++num2; }
        }
      }
      return num2 > 0L ? new Decimal?(num1 / (Decimal) num2) : new Decimal?();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int32" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int> selector)
    {
      return source.Select<TSource, int>(selector).Average();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int32" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int?> selector)
    {
      return source.Select<TSource, int?>(selector).Average();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int64" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">來源之項目的類型。</typeparam>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long> selector)
    {
      return source.Select<TSource, long>(selector).Average();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int64" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      return source.Select<TSource, long?>(selector).Average();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Single" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      return source.Select<TSource, float>(selector).Average();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Single" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      return source.Select<TSource, float?>(selector).Average();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Double" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      return source.Select<TSource, double>(selector).Average();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Double" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      return source.Select<TSource, double?>(selector).Average();
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Decimal" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">用來計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>值序列的平均。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 包含任何項目。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      return source.Select<TSource, Decimal>(selector).Average();
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Decimal" /> 叫用轉換函式的輸入序列的每個項目上所取得的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目的轉換函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或包含的值 <see langword="null" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   序列中項目的總和大於 <see cref="F:System.Decimal.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      return source.Select<TSource, Decimal?>(selector).Average();
    }

    /// <summary>將值附加在序列結尾。</summary>
    /// <param name="source">一連串的值。</param>
    /// <param name="element">
    ///   要附加在 <paramref name="source" /> 後面的值。
    /// </param>
    /// <typeparam name="TSource">
    ///   <paramref name="source" /> 項目的類型。
    /// </typeparam>
    /// <returns>
    ///   以 <paramref name="element" /> 結尾的新序列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    public static IEnumerable<TSource> Append<TSource>(
      this IEnumerable<TSource> source,
      TSource element)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source is Enumerable.AppendPrependIterator<TSource> appendPrependIterator ? (IEnumerable<TSource>) appendPrependIterator.Append(element) : (IEnumerable<TSource>) new Enumerable.AppendPrepend1Iterator<TSource>(source, element, true);
    }

    /// <summary>將值新增至序列的開頭。</summary>
    /// <param name="source">一連串的值。</param>
    /// <param name="element">
    ///   要新增在 <paramref name="source" /> 開頭的值。
    /// </param>
    /// <typeparam name="TSource">
    ///   <paramref name="source" /> 項目的類型。
    /// </typeparam>
    /// <returns>
    ///   以 <paramref name="element" /> 開頭的新序列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    public static IEnumerable<TSource> Prepend<TSource>(
      this IEnumerable<TSource> source,
      TSource element)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source is Enumerable.AppendPrependIterator<TSource> appendPrependIterator ? (IEnumerable<TSource>) appendPrependIterator.Prepend(element) : (IEnumerable<TSource>) new Enumerable.AppendPrepend1Iterator<TSource>(source, element, false);
    }

    private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
    {
      private int threadId;
      internal int state;
      internal TSource current;

      public Iterator() => this.threadId = Thread.CurrentThread.ManagedThreadId;

      public TSource Current => this.current;

      public abstract Enumerable.Iterator<TSource> Clone();

      public virtual void Dispose()
      {
        this.current = default (TSource);
        this.state = -1;
      }

      public IEnumerator<TSource> GetEnumerator()
      {
        if (this.threadId == Thread.CurrentThread.ManagedThreadId && this.state == 0)
        {
          this.state = 1;
          return (IEnumerator<TSource>) this;
        }
        Enumerable.Iterator<TSource> iterator = this.Clone();
        iterator.state = 1;
        return (IEnumerator<TSource>) iterator;
      }

      public abstract bool MoveNext();

      public abstract IEnumerable<TResult> Select<TResult>(
        Func<TSource, TResult> selector);

      public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

      object IEnumerator.Current => (object) this.Current;

      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

      void IEnumerator.Reset() => throw new NotImplementedException();
    }

    private class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
    {
      private IEnumerable<TSource> source;
      private Func<TSource, bool> predicate;
      private IEnumerator<TSource> enumerator;

      public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
      {
        this.source = source;
        this.predicate = predicate;
      }

      public override Enumerable.Iterator<TSource> Clone() => (Enumerable.Iterator<TSource>) new Enumerable.WhereEnumerableIterator<TSource>(this.source, this.predicate);

      public override void Dispose()
      {
        if (this.enumerator != null)
          this.enumerator.Dispose();
        this.enumerator = (IEnumerator<TSource>) null;
        base.Dispose();
      }

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this.enumerator = this.source.GetEnumerator();
            this.state = 2;
            goto case 2;
          case 2:
            while (this.enumerator.MoveNext())
            {
              TSource current = this.enumerator.Current;
              if (this.predicate(current))
              {
                this.current = current;
                return true;
              }
            }
            this.Dispose();
            break;
        }
        return false;
      }

      public override IEnumerable<TResult> Select<TResult>(
        Func<TSource, TResult> selector)
      {
        return (IEnumerable<TResult>) new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(this.source, this.predicate, selector);
      }

      public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) => (IEnumerable<TSource>) new Enumerable.WhereEnumerableIterator<TSource>(this.source, Enumerable.CombinePredicates<TSource>(this.predicate, predicate));
    }

    private class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
    {
      private TSource[] source;
      private Func<TSource, bool> predicate;
      private int index;

      public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
      {
        this.source = source;
        this.predicate = predicate;
      }

      public override Enumerable.Iterator<TSource> Clone() => (Enumerable.Iterator<TSource>) new Enumerable.WhereArrayIterator<TSource>(this.source, this.predicate);

      public override bool MoveNext()
      {
        if (this.state == 1)
        {
          while (this.index < this.source.Length)
          {
            TSource source = this.source[this.index];
            ++this.index;
            if (this.predicate(source))
            {
              this.current = source;
              return true;
            }
          }
          this.Dispose();
        }
        return false;
      }

      public override IEnumerable<TResult> Select<TResult>(
        Func<TSource, TResult> selector)
      {
        return (IEnumerable<TResult>) new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this.source, this.predicate, selector);
      }

      public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) => (IEnumerable<TSource>) new Enumerable.WhereArrayIterator<TSource>(this.source, Enumerable.CombinePredicates<TSource>(this.predicate, predicate));
    }

    private class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
    {
      private List<TSource> source;
      private Func<TSource, bool> predicate;
      private List<TSource>.Enumerator enumerator;

      public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
      {
        this.source = source;
        this.predicate = predicate;
      }

      public override Enumerable.Iterator<TSource> Clone() => (Enumerable.Iterator<TSource>) new Enumerable.WhereListIterator<TSource>(this.source, this.predicate);

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this.enumerator = this.source.GetEnumerator();
            this.state = 2;
            goto case 2;
          case 2:
            while (this.enumerator.MoveNext())
            {
              TSource current = this.enumerator.Current;
              if (this.predicate(current))
              {
                this.current = current;
                return true;
              }
            }
            this.Dispose();
            break;
        }
        return false;
      }

      public override IEnumerable<TResult> Select<TResult>(
        Func<TSource, TResult> selector)
      {
        return (IEnumerable<TResult>) new Enumerable.WhereSelectListIterator<TSource, TResult>(this.source, this.predicate, selector);
      }

      public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) => (IEnumerable<TSource>) new Enumerable.WhereListIterator<TSource>(this.source, Enumerable.CombinePredicates<TSource>(this.predicate, predicate));
    }

    private class SelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>, IIListProvider<TResult>, IEnumerable<TResult>, IEnumerable
    {
      private readonly IEnumerable<TSource> _source;
      private readonly Func<TSource, TResult> _selector;
      private IEnumerator<TSource> _enumerator;

      public SelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, TResult> selector)
      {
        this._source = source;
        this._selector = selector;
      }

      public override Enumerable.Iterator<TResult> Clone() => (Enumerable.Iterator<TResult>) new Enumerable.SelectEnumerableIterator<TSource, TResult>(this._source, this._selector);

      public override void Dispose()
      {
        if (this._enumerator != null)
        {
          this._enumerator.Dispose();
          this._enumerator = (IEnumerator<TSource>) null;
        }
        base.Dispose();
      }

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this._enumerator = this._source.GetEnumerator();
            this.state = 2;
            goto case 2;
          case 2:
            if (this._enumerator.MoveNext())
            {
              this.current = this._selector(this._enumerator.Current);
              return true;
            }
            this.Dispose();
            break;
        }
        return false;
      }

      public override IEnumerable<TResult2> Select<TResult2>(
        Func<TResult, TResult2> selector)
      {
        return (IEnumerable<TResult2>) new Enumerable.SelectEnumerableIterator<TSource, TResult2>(this._source, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this._selector, selector));
      }

      public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) => (IEnumerable<TResult>) new Enumerable.WhereEnumerableIterator<TResult>((IEnumerable<TResult>) this, predicate);

      public TResult[] ToArray()
      {
        LargeArrayBuilder<TResult> largeArrayBuilder = new LargeArrayBuilder<TResult>(true);
        foreach (TSource source in this._source)
          largeArrayBuilder.Add(this._selector(source));
        return largeArrayBuilder.ToArray();
      }

      public List<TResult> ToList()
      {
        List<TResult> resultList = new List<TResult>();
        foreach (TSource source in this._source)
          resultList.Add(this._selector(source));
        return resultList;
      }

      public int GetCount(bool onlyIfCheap)
      {
        if (onlyIfCheap)
          return -1;
        int num = 0;
        foreach (TSource source in this._source)
        {
          TResult result = this._selector(source);
          checked { ++num; }
        }
        return num;
      }
    }

    private class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
    {
      private IEnumerable<TSource> source;
      private Func<TSource, bool> predicate;
      private Func<TSource, TResult> selector;
      private IEnumerator<TSource> enumerator;

      public WhereSelectEnumerableIterator(
        IEnumerable<TSource> source,
        Func<TSource, bool> predicate,
        Func<TSource, TResult> selector)
      {
        this.source = source;
        this.predicate = predicate;
        this.selector = selector;
      }

      public override Enumerable.Iterator<TResult> Clone() => (Enumerable.Iterator<TResult>) new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(this.source, this.predicate, this.selector);

      public override void Dispose()
      {
        if (this.enumerator != null)
          this.enumerator.Dispose();
        this.enumerator = (IEnumerator<TSource>) null;
        base.Dispose();
      }

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this.enumerator = this.source.GetEnumerator();
            this.state = 2;
            goto case 2;
          case 2:
            while (this.enumerator.MoveNext())
            {
              TSource current = this.enumerator.Current;
              if (this.predicate == null || this.predicate(current))
              {
                this.current = this.selector(current);
                return true;
              }
            }
            this.Dispose();
            break;
        }
        return false;
      }

      public override IEnumerable<TResult2> Select<TResult2>(
        Func<TResult, TResult2> selector)
      {
        return (IEnumerable<TResult2>) new Enumerable.WhereSelectEnumerableIterator<TSource, TResult2>(this.source, this.predicate, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
      }

      public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) => (IEnumerable<TResult>) new Enumerable.WhereEnumerableIterator<TResult>((IEnumerable<TResult>) this, predicate);
    }

    private class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
    {
      private TSource[] source;
      private Func<TSource, bool> predicate;
      private Func<TSource, TResult> selector;
      private int index;

      public WhereSelectArrayIterator(
        TSource[] source,
        Func<TSource, bool> predicate,
        Func<TSource, TResult> selector)
      {
        this.source = source;
        this.predicate = predicate;
        this.selector = selector;
      }

      public override Enumerable.Iterator<TResult> Clone() => (Enumerable.Iterator<TResult>) new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this.source, this.predicate, this.selector);

      public override bool MoveNext()
      {
        if (this.state == 1)
        {
          while (this.index < this.source.Length)
          {
            TSource source = this.source[this.index];
            ++this.index;
            if (this.predicate == null || this.predicate(source))
            {
              this.current = this.selector(source);
              return true;
            }
          }
          this.Dispose();
        }
        return false;
      }

      public override IEnumerable<TResult2> Select<TResult2>(
        Func<TResult, TResult2> selector)
      {
        return (IEnumerable<TResult2>) new Enumerable.WhereSelectArrayIterator<TSource, TResult2>(this.source, this.predicate, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
      }

      public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) => (IEnumerable<TResult>) new Enumerable.WhereEnumerableIterator<TResult>((IEnumerable<TResult>) this, predicate);
    }

    private class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
    {
      private List<TSource> source;
      private Func<TSource, bool> predicate;
      private Func<TSource, TResult> selector;
      private List<TSource>.Enumerator enumerator;

      public WhereSelectListIterator(
        List<TSource> source,
        Func<TSource, bool> predicate,
        Func<TSource, TResult> selector)
      {
        this.source = source;
        this.predicate = predicate;
        this.selector = selector;
      }

      public override Enumerable.Iterator<TResult> Clone() => (Enumerable.Iterator<TResult>) new Enumerable.WhereSelectListIterator<TSource, TResult>(this.source, this.predicate, this.selector);

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this.enumerator = this.source.GetEnumerator();
            this.state = 2;
            goto case 2;
          case 2:
            while (this.enumerator.MoveNext())
            {
              TSource current = this.enumerator.Current;
              if (this.predicate == null || this.predicate(current))
              {
                this.current = this.selector(current);
                return true;
              }
            }
            this.Dispose();
            break;
        }
        return false;
      }

      public override IEnumerable<TResult2> Select<TResult2>(
        Func<TResult, TResult2> selector)
      {
        return (IEnumerable<TResult2>) new Enumerable.WhereSelectListIterator<TSource, TResult2>(this.source, this.predicate, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
      }

      public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) => (IEnumerable<TResult>) new Enumerable.WhereEnumerableIterator<TResult>((IEnumerable<TResult>) this, predicate);
    }

    private abstract class AppendPrependIterator<TSource> : Enumerable.Iterator<TSource>, IIListProvider<TSource>, IEnumerable<TSource>, IEnumerable
    {
      protected readonly IEnumerable<TSource> _source;
      protected IEnumerator<TSource> enumerator;

      protected AppendPrependIterator(IEnumerable<TSource> source) => this._source = source;

      protected void GetSourceEnumerator() => this.enumerator = this._source.GetEnumerator();

      public abstract Enumerable.AppendPrependIterator<TSource> Append(TSource item);

      public abstract Enumerable.AppendPrependIterator<TSource> Prepend(TSource item);

      protected bool LoadFromEnumerator()
      {
        if (this.enumerator.MoveNext())
        {
          this.current = this.enumerator.Current;
          return true;
        }
        this.Dispose();
        return false;
      }

      public override void Dispose()
      {
        if (this.enumerator != null)
        {
          this.enumerator.Dispose();
          this.enumerator = (IEnumerator<TSource>) null;
        }
        base.Dispose();
      }

      public override IEnumerable<TResult> Select<TResult>(
        Func<TSource, TResult> selector)
      {
        return (IEnumerable<TResult>) new Enumerable.SelectEnumerableIterator<TSource, TResult>((IEnumerable<TSource>) this, selector);
      }

      public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) => (IEnumerable<TSource>) new Enumerable.WhereEnumerableIterator<TSource>((IEnumerable<TSource>) this, predicate);

      public abstract TSource[] ToArray();

      public abstract List<TSource> ToList();

      public abstract int GetCount(bool onlyIfCheap);
    }

    private class AppendPrepend1Iterator<TSource> : Enumerable.AppendPrependIterator<TSource>
    {
      private readonly TSource _item;
      private readonly bool _appending;

      public AppendPrepend1Iterator(IEnumerable<TSource> source, TSource item, bool appending)
        : base(source)
      {
        this._item = item;
        this._appending = appending;
      }

      public override Enumerable.Iterator<TSource> Clone() => (Enumerable.Iterator<TSource>) new Enumerable.AppendPrepend1Iterator<TSource>(this._source, this._item, this._appending);

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this.state = 2;
            if (!this._appending)
            {
              this.current = this._item;
              return true;
            }
            goto case 2;
          case 2:
            this.GetSourceEnumerator();
            this.state = 3;
            goto case 3;
          case 3:
            if (this.LoadFromEnumerator())
              return true;
            if (this._appending)
            {
              this.current = this._item;
              return true;
            }
            break;
        }
        this.Dispose();
        return false;
      }

      public override Enumerable.AppendPrependIterator<TSource> Append(TSource item) => this._appending ? (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, (SingleLinkedNode<TSource>) null, new SingleLinkedNode<TSource>(this._item).Add(item), 0, 2) : (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, new SingleLinkedNode<TSource>(this._item), new SingleLinkedNode<TSource>(item), 1, 1);

      public override Enumerable.AppendPrependIterator<TSource> Prepend(TSource item) => this._appending ? (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, new SingleLinkedNode<TSource>(item), new SingleLinkedNode<TSource>(this._item), 1, 1) : (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, new SingleLinkedNode<TSource>(this._item).Add(item), (SingleLinkedNode<TSource>) null, 2, 0);

      private TSource[] LazyToArray()
      {
        LargeArrayBuilder<TSource> largeArrayBuilder = new LargeArrayBuilder<TSource>(true);
        if (!this._appending)
          largeArrayBuilder.SlowAdd(this._item);
        largeArrayBuilder.AddRange(this._source);
        if (this._appending)
          largeArrayBuilder.SlowAdd(this._item);
        return largeArrayBuilder.ToArray();
      }

      public override TSource[] ToArray()
      {
        int count = this.GetCount(true);
        if (count == -1)
          return this.LazyToArray();
        TSource[] array = new TSource[count];
        int arrayIndex;
        if (this._appending)
        {
          arrayIndex = 0;
        }
        else
        {
          array[0] = this._item;
          arrayIndex = 1;
        }
        EnumerableHelpers.Copy<TSource>(this._source, array, arrayIndex, count - 1);
        if (this._appending)
          array[array.Length - 1] = this._item;
        return array;
      }

      public override List<TSource> ToList()
      {
        int count = this.GetCount(true);
        List<TSource> sourceList = count == -1 ? new List<TSource>() : new List<TSource>(count);
        if (!this._appending)
          sourceList.Add(this._item);
        sourceList.AddRange(this._source);
        if (this._appending)
          sourceList.Add(this._item);
        return sourceList;
      }

      public override int GetCount(bool onlyIfCheap)
      {
        if (this._source is IIListProvider<TSource> source)
        {
          int count = source.GetCount(onlyIfCheap);
          return count != -1 ? count + 1 : -1;
        }
        return onlyIfCheap && !(this._source is ICollection<TSource>) ? -1 : this._source.Count<TSource>() + 1;
      }
    }

    private class AppendPrependN<TSource> : Enumerable.AppendPrependIterator<TSource>
    {
      private readonly SingleLinkedNode<TSource> _prepended;
      private readonly SingleLinkedNode<TSource> _appended;
      private readonly int _prependCount;
      private readonly int _appendCount;
      private SingleLinkedNode<TSource> _node;

      public AppendPrependN(
        IEnumerable<TSource> source,
        SingleLinkedNode<TSource> prepended,
        SingleLinkedNode<TSource> appended,
        int prependCount,
        int appendCount)
        : base(source)
      {
        this._prepended = prepended;
        this._appended = appended;
        this._prependCount = prependCount;
        this._appendCount = appendCount;
      }

      public override Enumerable.Iterator<TSource> Clone() => (Enumerable.Iterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, this._prepended, this._appended, this._prependCount, this._appendCount);

      public override bool MoveNext()
      {
        switch (this.state)
        {
          case 1:
            this._node = this._prepended;
            this.state = 2;
            goto case 2;
          case 2:
            if (this._node != null)
            {
              this.current = this._node.Item;
              this._node = this._node.Linked;
              return true;
            }
            this.GetSourceEnumerator();
            this.state = 3;
            goto case 3;
          case 3:
            if (this.LoadFromEnumerator())
              return true;
            if (this._appended == null)
              return false;
            this.enumerator = this._appended.GetEnumerator(this._appendCount);
            this.state = 4;
            goto case 4;
          case 4:
            return this.LoadFromEnumerator();
          default:
            this.Dispose();
            return false;
        }
      }

      public override Enumerable.AppendPrependIterator<TSource> Append(TSource item) => (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, this._prepended, this._appended != null ? this._appended.Add(item) : new SingleLinkedNode<TSource>(item), this._prependCount, this._appendCount + 1);

      public override Enumerable.AppendPrependIterator<TSource> Prepend(TSource item) => (Enumerable.AppendPrependIterator<TSource>) new Enumerable.AppendPrependN<TSource>(this._source, this._prepended != null ? this._prepended.Add(item) : new SingleLinkedNode<TSource>(item), this._appended, this._prependCount + 1, this._appendCount);

      private TSource[] LazyToArray()
      {
        SparseArrayBuilder<TSource> sparseArrayBuilder = new SparseArrayBuilder<TSource>(true);
        if (this._prepended != null)
          sparseArrayBuilder.Reserve(this._prependCount);
        sparseArrayBuilder.AddRange(this._source);
        if (this._appended != null)
          sparseArrayBuilder.Reserve(this._appendCount);
        TSource[] array = sparseArrayBuilder.ToArray();
        int num1 = 0;
        for (SingleLinkedNode<TSource> singleLinkedNode = this._prepended; singleLinkedNode != null; singleLinkedNode = singleLinkedNode.Linked)
          array[num1++] = singleLinkedNode.Item;
        int num2 = array.Length - 1;
        for (SingleLinkedNode<TSource> singleLinkedNode = this._appended; singleLinkedNode != null; singleLinkedNode = singleLinkedNode.Linked)
          array[num2--] = singleLinkedNode.Item;
        return array;
      }

      public override TSource[] ToArray()
      {
        int count = this.GetCount(true);
        if (count == -1)
          return this.LazyToArray();
        TSource[] array = new TSource[count];
        int arrayIndex = 0;
        for (SingleLinkedNode<TSource> singleLinkedNode = this._prepended; singleLinkedNode != null; singleLinkedNode = singleLinkedNode.Linked)
        {
          array[arrayIndex] = singleLinkedNode.Item;
          ++arrayIndex;
        }
        if (this._source is ICollection<TSource> source)
        {
          source.CopyTo(array, arrayIndex);
        }
        else
        {
          foreach (TSource source in this._source)
          {
            array[arrayIndex] = source;
            ++arrayIndex;
          }
        }
        int length = array.Length;
        for (SingleLinkedNode<TSource> singleLinkedNode = this._appended; singleLinkedNode != null; singleLinkedNode = singleLinkedNode.Linked)
        {
          --length;
          array[length] = singleLinkedNode.Item;
        }
        return array;
      }

      public override List<TSource> ToList()
      {
        int count = this.GetCount(true);
        List<TSource> sourceList = count == -1 ? new List<TSource>() : new List<TSource>(count);
        for (SingleLinkedNode<TSource> singleLinkedNode = this._prepended; singleLinkedNode != null; singleLinkedNode = singleLinkedNode.Linked)
          sourceList.Add(singleLinkedNode.Item);
        sourceList.AddRange(this._source);
        if (this._appended != null)
        {
          IEnumerator<TSource> enumerator = this._appended.GetEnumerator(this._appendCount);
          while (enumerator.MoveNext())
            sourceList.Add(enumerator.Current);
        }
        return sourceList;
      }

      public override int GetCount(bool onlyIfCheap)
      {
        if (this._source is IIListProvider<TSource> source)
        {
          int count = source.GetCount(onlyIfCheap);
          return count != -1 ? count + this._appendCount + this._prependCount : -1;
        }
        return onlyIfCheap && !(this._source is ICollection<TSource>) ? -1 : this._source.Count<TSource>() + this._appendCount + this._prependCount;
      }
    }
  }
}
