// Decompiled with JetBrains decompiler
// Type: System.Linq.Queryable
// Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E90BEB44-6898-4ECF-B706-59AC067ECC5C
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.Core.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq
{
  /// <summary>
  ///   提供一組 <see langword="static" /> (<see langword="Shared" /> 在 Visual Basic 中) 方法來查詢資料結構可實作 <see cref="T:System.Linq.IQueryable`1" />。
  /// </summary>
  [__DynamicallyInvokable]
  public static class Queryable
  {
    private static MethodInfo GetMethodInfo<T1, T2>(Func<T1, T2> f, T1 unused1) => f.Method;

    private static MethodInfo GetMethodInfo<T1, T2, T3>(
      Func<T1, T2, T3> f,
      T1 unused1,
      T2 unused2)
    {
      return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4>(
      Func<T1, T2, T3, T4> f,
      T1 unused1,
      T2 unused2,
      T3 unused3)
    {
      return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5>(
      Func<T1, T2, T3, T4, T5> f,
      T1 unused1,
      T2 unused2,
      T3 unused3,
      T4 unused4)
    {
      return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6>(
      Func<T1, T2, T3, T4, T5, T6> f,
      T1 unused1,
      T2 unused2,
      T3 unused3,
      T4 unused4,
      T5 unused5)
    {
      return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7>(
      Func<T1, T2, T3, T4, T5, T6, T7> f,
      T1 unused1,
      T2 unused2,
      T3 unused3,
      T4 unused4,
      T5 unused5,
      T6 unused6)
    {
      return f.Method;
    }

    /// <summary>
    ///   將轉換為泛型 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 至泛型 <see cref="T:System.Linq.IQueryable`1" />。
    /// </summary>
    /// <param name="source">要轉換的序列。</param>
    /// <typeparam name="TElement">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 表示輸入的序列。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TElement> AsQueryable<TElement>(
      this IEnumerable<TElement> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source is IQueryable<TElement> ? (IQueryable<TElement>) source : (IQueryable<TElement>) new EnumerableQuery<TElement>(source);
    }

    /// <summary>
    ///   將轉換 <see cref="T:System.Collections.IEnumerable" /> 到 <see cref="T:System.Linq.IQueryable" />。
    /// </summary>
    /// <param name="source">要轉換的序列。</param>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable" /> 表示輸入的序列。
    /// </returns>
    /// <exception cref="T:System.ArgumentException">
    ///   <paramref name="source" /> 不會實作 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 部分 <paramref name="T" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable AsQueryable(this IEnumerable source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (source is IQueryable)
        return (IQueryable) source;
      Type genericType = TypeHelper.FindGenericType(typeof (IEnumerable<>), source.GetType());
      return !(genericType == (Type) null) ? EnumerableQuery.Create(genericType.GetGenericArguments()[0], source) : throw Error.ArgumentNotIEnumerableGeneric((object) nameof (source));
    }

    /// <summary>根據述詞來篩選值序列。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 來篩選。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含輸入序列中符合指定條件的項目 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Where<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(Queryable.Where<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   根據述詞來篩選值序列。
    ///    述詞函式的邏輯中使用各項目的索引。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 來篩選。
    /// </param>
    /// <param name="predicate">函式來測試條件，每個項目函式的第二個參數代表來源序列中項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含輸入序列中符合指定條件的項目 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Where<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(Queryable.Where<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   篩選的項目 <see cref="T:System.Linq.IQueryable" /> 根據指定的型別。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable" /> 來篩選其項目。
    /// </param>
    /// <typeparam name="TResult">用來做為序列項目之篩選依據的類型。</typeparam>
    /// <returns>
    ///   集合，其中包含項目從 <paramref name="source" /> 具有型別 <paramref name="TResult" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> OfType<TResult>(this IQueryable source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable, IQueryable<TResult>>(new Func<IQueryable, IQueryable<TResult>>(Queryable.OfType<TResult>), source), source.Expression));
    }

    /// <summary>
    ///   將轉換的項目 <see cref="T:System.Linq.IQueryable" /> 指定的型別。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable" /> ，其中包含要轉換的項目。
    /// </param>
    /// <typeparam name="TResult">
    ///   要轉換的項目型別 <paramref name="source" /> 來。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含指定的型別轉換的來源序列的每個項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidCastException">
    ///   序列中的項目無法轉換成型別 <paramref name="TResult" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Cast<TResult>(this IQueryable source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable, IQueryable<TResult>>(new Func<IQueryable, IQueryable<TResult>>(Queryable.Cast<TResult>), source), source.Expression));
    }

    /// <summary>將序列的每個元素規劃成一個新的表單。</summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用每個項目投影函式的結果 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Select<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TResult>>, IQueryable<TResult>>(Queryable.Select<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>投射成新的表單序列的每個項目所加入的項目索引。</summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用每個項目投影函式的結果 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Select<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, TResult>>, IQueryable<TResult>>(Queryable.Select<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 並結合成單一序列產生的序列。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式所傳回的序列的項目類型 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用每個輸入序列的項目上一對多投影函式的結果。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> SelectMany<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, IEnumerable<TResult>>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, IEnumerable<TResult>>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, IEnumerable<TResult>>>, IQueryable<TResult>>(Queryable.SelectMany<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 並結合成單一序列產生的序列。
    ///    各來源項目的索引是在該項目的投影表單中使用。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="selector">要套用至每個項目; 投影函式此函式的第二個參數代表來源項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式所傳回的序列的項目類型 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用每個輸入序列的項目上一對多投影函式的結果。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> SelectMany<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, IEnumerable<TResult>>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, IEnumerable<TResult>>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, IEnumerable<TResult>>>, IQueryable<TResult>>(Queryable.SelectMany<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" /> ，結合產生它的來源項目的索引。
    ///    每個中繼序列，每個項目上叫用結果選取器函式和合併成單一的一維序列並傳回結果值。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="collectionSelector">
    ///   要套用至輸入序列中，每個項目投影函式此函式的第二個參數代表來源項目的索引。
    /// </param>
    /// <param name="resultSelector">要套用至每個中繼序列各個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TCollection">
    ///   所代表的函式所收集的中繼元素的型別 <paramref name="collectionSelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">產生之序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用來從一對多投影函式的結果 <paramref name="collectionSelector" /> 的每個項目上 <paramref name="source" /> 然後再將每個序列項目及其對應 <paramref name="source" /> 結果項目的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="collectionSelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector,
      Expression<Func<TSource, TCollection, TResult>> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (collectionSelector == null)
        throw Error.ArgumentNull(nameof (collectionSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, IEnumerable<TCollection>>>, Expression<Func<TSource, TCollection, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, IEnumerable<TCollection>>>, Expression<Func<TSource, TCollection, TResult>>, IQueryable<TResult>>(Queryable.SelectMany<TSource, TCollection, TResult>), source, collectionSelector, resultSelector), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) collectionSelector),
        (Expression) Expression.Quote((Expression) resultSelector)
      }));
    }

    /// <summary>
    ///   每個序列的項目至 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其中叫用每個項目中的結果選取器函式。
    ///    合併成單一的一維序列並傳回每個中繼序列產生的值。
    /// </summary>
    /// <param name="source">要投影的值序列。</param>
    /// <param name="collectionSelector">要套用至每個輸入序列的項目投影函式。</param>
    /// <param name="resultSelector">要套用至每個中繼序列各個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TCollection">
    ///   所代表的函式所收集的中繼元素的型別 <paramref name="collectionSelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">產生之序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目是叫用來從一對多投影函式的結果 <paramref name="collectionSelector" /> 的每個項目上 <paramref name="source" /> 然後再將每個序列項目及其對應 <paramref name="source" /> 結果項目的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="collectionSelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector,
      Expression<Func<TSource, TCollection, TResult>> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (collectionSelector == null)
        throw Error.ArgumentNull(nameof (collectionSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, IEnumerable<TCollection>>>, Expression<Func<TSource, TCollection, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, IEnumerable<TCollection>>>, Expression<Func<TSource, TCollection, TResult>>, IQueryable<TResult>>(Queryable.SelectMany<TSource, TCollection, TResult>), source, collectionSelector, resultSelector), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) collectionSelector),
        (Expression) Expression.Quote((Expression) resultSelector)
      }));
    }

    private static Expression GetSourceExpression<TSource>(IEnumerable<TSource> source) => source is IQueryable<TSource> queryable ? queryable.Expression : (Expression) Expression.Constant((object) source, typeof (IEnumerable<TSource>));

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
    ///   <see cref="T:System.Linq.IQueryable`1" /> 具有型別的項目 <paramref name="TResult" /> 執行內部聯結兩個序列上取得。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IQueryable<TOuter> outer,
      IEnumerable<TInner> inner,
      Expression<Func<TOuter, TKey>> outerKeySelector,
      Expression<Func<TInner, TKey>> innerKeySelector,
      Expression<Func<TOuter, TInner, TResult>> resultSelector)
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
      return outer.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, TInner, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, TInner, TResult>>, IQueryable<TResult>>(Queryable.Join<TOuter, TInner, TKey, TResult>), outer, inner, outerKeySelector, innerKeySelector, resultSelector), outer.Expression, Queryable.GetSourceExpression<TInner>(inner), (Expression) Expression.Quote((Expression) outerKeySelector), (Expression) Expression.Quote((Expression) innerKeySelector), (Expression) Expression.Quote((Expression) resultSelector)));
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
    ///   <see cref="T:System.Linq.IQueryable`1" /> 具有型別的項目 <paramref name="TResult" /> 執行內部聯結兩個序列上取得。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IQueryable<TOuter> outer,
      IEnumerable<TInner> inner,
      Expression<Func<TOuter, TKey>> outerKeySelector,
      Expression<Func<TInner, TKey>> innerKeySelector,
      Expression<Func<TOuter, TInner, TResult>> resultSelector,
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
      return outer.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, TInner, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(new Func<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, TInner, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(Queryable.Join<TOuter, TInner, TKey, TResult>), outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer), outer.Expression, Queryable.GetSourceExpression<TInner>(inner), (Expression) Expression.Quote((Expression) outerKeySelector), (Expression) Expression.Quote((Expression) innerKeySelector), (Expression) Expression.Quote((Expression) resultSelector), (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))));
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
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含型別的項目 <paramref name="TResult" /> 執行群組的聯結兩個序列上取得。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IQueryable<TOuter> outer,
      IEnumerable<TInner> inner,
      Expression<Func<TOuter, TKey>> outerKeySelector,
      Expression<Func<TInner, TKey>> innerKeySelector,
      Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
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
      return outer.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, IEnumerable<TInner>, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, IEnumerable<TInner>, TResult>>, IQueryable<TResult>>(Queryable.GroupJoin<TOuter, TInner, TKey, TResult>), outer, inner, outerKeySelector, innerKeySelector, resultSelector), outer.Expression, Queryable.GetSourceExpression<TInner>(inner), (Expression) Expression.Quote((Expression) outerKeySelector), (Expression) Expression.Quote((Expression) innerKeySelector), (Expression) Expression.Quote((Expression) resultSelector)));
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
    /// <param name="comparer">雜湊及比較索引鍵比較子。</param>
    /// <typeparam name="TOuter">第一個序列之項目的類型。</typeparam>
    /// <typeparam name="TInner">第二個序列之項目的類型。</typeparam>
    /// <typeparam name="TKey">索引鍵選取器函式所傳回之索引鍵的類型。</typeparam>
    /// <typeparam name="TResult">結果項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含型別的項目 <paramref name="TResult" /> 執行群組的聯結兩個序列上取得。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="outer" /> 或 <paramref name="inner" /> 或 <paramref name="outerKeySelector" /> 或 <paramref name="innerKeySelector" /> 或 <paramref name="resultSelector" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IQueryable<TOuter> outer,
      IEnumerable<TInner> inner,
      Expression<Func<TOuter, TKey>> outerKeySelector,
      Expression<Func<TInner, TKey>> innerKeySelector,
      Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector,
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
      return outer.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, IEnumerable<TInner>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(new Func<IQueryable<TOuter>, IEnumerable<TInner>, Expression<Func<TOuter, TKey>>, Expression<Func<TInner, TKey>>, Expression<Func<TOuter, IEnumerable<TInner>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(Queryable.GroupJoin<TOuter, TInner, TKey, TResult>), outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer), outer.Expression, Queryable.GetSourceExpression<TInner>(inner), (Expression) Expression.Quote((Expression) outerKeySelector), (Expression) Expression.Quote((Expression) innerKeySelector), (Expression) Expression.Quote((Expression) resultSelector), (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))));
    }

    /// <summary>排序序列中遞增順序依據索引鍵的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(Queryable.OrderBy<TSource, TKey>), source, keySelector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector)
      }));
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
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(Queryable.OrderBy<TSource, TKey>), source, keySelector, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Constant((object) comparer, typeof (IComparer<TKey>))
      }));
    }

    /// <summary>排序序列中遞減的順序，根據索引鍵的項目。</summary>
    /// <param name="source">要排序的值序列。</param>
    /// <param name="keySelector">用來從項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(Queryable.OrderByDescending<TSource, TKey>), source, keySelector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector)
      }));
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
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(Queryable.OrderByDescending<TSource, TKey>), source, keySelector, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Constant((object) comparer, typeof (IComparer<TKey>))
      }));
    }

    /// <summary>執行以遞增順序依據索引鍵的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(
      this IOrderedQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(new Func<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(Queryable.ThenBy<TSource, TKey>), source, keySelector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector)
      }));
    }

    /// <summary>執行使用指定的比較子，依遞增順序排列序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 根據索引鍵排序其項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(
      this IOrderedQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(new Func<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(Queryable.ThenBy<TSource, TKey>), source, keySelector, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Constant((object) comparer, typeof (IComparer<TKey>))
      }));
    }

    /// <summary>根據索引鍵，會執行，依遞減順序的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   索引鍵所代表的函式所傳回的型別 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> 排序其項目以遞減順序，根據索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(new Func<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IOrderedQueryable<TSource>>(Queryable.ThenByDescending<TSource, TKey>), source, keySelector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector)
      }));
    }

    /// <summary>執行在使用指定的比較子，依遞減順序的序列中項目的後續排序作業。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IOrderedQueryable`1" /> ，其中包含要排序的項目。
    /// </param>
    /// <param name="keySelector">用來從各個項目擷取索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   所傳回的索引鍵類型 <paramref name="keySelector" /> 函式。
    /// </typeparam>
    /// <returns>排序其項目以遞減順序，根據索引鍵集合。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      IComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return (IOrderedQueryable<TSource>) source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(new Func<IOrderedQueryable<TSource>, Expression<Func<TSource, TKey>>, IComparer<TKey>, IOrderedQueryable<TSource>>(Queryable.ThenByDescending<TSource, TKey>), source, keySelector, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Constant((object) comparer, typeof (IComparer<TKey>))
      }));
    }

    /// <summary>從序列開頭傳回指定的連續的項目數。</summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="count">要傳回的項目數目。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含從開頭指定項目數 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Take<TSource>(
      this IQueryable<TSource> source,
      int count)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, int, IQueryable<TSource>>(new Func<IQueryable<TSource>, int, IQueryable<TSource>>(Queryable.Take<TSource>), source, count), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) count)
      }));
    }

    /// <summary>傳回序列中的項目，只要指定的條件為真。</summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含測試所指定的項目之前發生的輸入序列中的項目 <paramref name="predicate" /> 不再傳遞。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> TakeWhile<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(Queryable.TakeWhile<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   傳回序列中的項目，只要指定的條件為真。
    ///    項目的索引是用於述詞功能的邏輯中。
    /// </summary>
    /// <param name="source">傳回項目的序列。</param>
    /// <param name="predicate">函式來測試條件，每個項目函式的第二個參數代表來源序列中項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含測試所指定的項目之前發生的輸入序列中的項目 <paramref name="predicate" /> 不會再傳送。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> TakeWhile<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(Queryable.TakeWhile<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>略過指定的數目的序列中的項目，然後傳回其餘項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回項目的。
    /// </param>
    /// <param name="count">傳回其餘項目之前要略過的項目數目。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含輸入序列中指定的索引之後所發生的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Skip<TSource>(
      this IQueryable<TSource> source,
      int count)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, int, IQueryable<TSource>>(new Func<IQueryable<TSource>, int, IQueryable<TSource>>(Queryable.Skip<TSource>), source, count), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) count)
      }));
    }

    /// <summary>只要指定的條件為 true，然後傳回其餘項目，請略過序列中的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回項目的。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含項目從 <paramref name="source" /> 未通過指定測試線性系列中的第一個項目開始 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> SkipWhile<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, IQueryable<TSource>>(Queryable.SkipWhile<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   只要指定的條件為 true，然後傳回其餘項目，請略過序列中的項目。
    ///    項目的索引是用於述詞功能的邏輯中。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回項目的。
    /// </param>
    /// <param name="predicate">函式來測試條件，每個項目此函式的第二個參數代表來源項目的索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含項目從 <paramref name="source" /> 未通過指定測試線性系列中的第一個項目開始 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> SkipWhile<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(new Func<IQueryable<TSource>, Expression<Func<TSource, int, bool>>, IQueryable<TSource>>(Queryable.SkipWhile<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>群組依據指定的索引鍵選取器函式序列的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   IQueryable&lt;IGrouping&lt;TKey, TSource&gt;&gt; 在 C# 或 IQueryable(Of IGrouping(Of TKey, TSource)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 物件包含一連串的物件和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return source.Provider.CreateQuery<IGrouping<TKey, TSource>>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IQueryable<IGrouping<TKey, TSource>>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IQueryable<IGrouping<TKey, TSource>>>(Queryable.GroupBy<TSource, TKey>), source, keySelector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector)
      }));
    }

    /// <summary>群組依據指定的索引鍵選取器函式並使用指定的函式的每個群組的項目序列的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <returns>
    ///   IQueryable&lt;IGrouping&lt;TKey, TElement&gt;&gt; 在 C# 或 IQueryable(Of IGrouping(Of TKey, TElement)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 包含一連串的物件型別的 <paramref name="TElement" /> 和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TSource, TElement>> elementSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (elementSelector == null)
        throw Error.ArgumentNull(nameof (elementSelector));
      return source.Provider.CreateQuery<IGrouping<TKey, TElement>>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, IQueryable<IGrouping<TKey, TElement>>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, IQueryable<IGrouping<TKey, TElement>>>(Queryable.GroupBy<TSource, TKey, TElement>), source, keySelector, elementSelector), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Quote((Expression) elementSelector)
      }));
    }

    /// <summary>群組的順序，根據指定的索引鍵選取器函式和比較使用指定的比較子索引鍵的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <returns>
    ///   IQueryable&lt;IGrouping&lt;TKey, TSource&gt;&gt; 在 C# 或 IQueryable(Of IGrouping(Of TKey, TSource)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 包含一連串的物件和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      return source.Provider.CreateQuery<IGrouping<TKey, TSource>>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IEqualityComparer<TKey>, IQueryable<IGrouping<TKey, TSource>>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, IEqualityComparer<TKey>, IQueryable<IGrouping<TKey, TSource>>>(Queryable.GroupBy<TSource, TKey>), source, keySelector, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))
      }));
    }

    /// <summary>
    ///   使用指定的函式來分組序列的項目並為每個群組的項目。
    ///    使用指定的比較子來比較索引鍵值。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
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
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <returns>
    ///   IQueryable&lt;IGrouping&lt;TKey, TElement&gt;&gt; 在 C# 或 IQueryable(Of IGrouping(Of TKey, TElement)) 中 Visual Basic 其中每個 <see cref="T:System.Linq.IGrouping`2" /> 包含一連串的物件型別的 <paramref name="TElement" /> 和索引鍵。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" />、<paramref name="elementSelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TSource, TElement>> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (elementSelector == null)
        throw Error.ArgumentNull(nameof (elementSelector));
      return source.Provider.CreateQuery<IGrouping<TKey, TElement>>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, IEqualityComparer<TKey>, IQueryable<IGrouping<TKey, TElement>>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, IEqualityComparer<TKey>, IQueryable<IGrouping<TKey, TElement>>>(Queryable.GroupBy<TSource, TKey, TElement>), source, keySelector, elementSelector, comparer), source.Expression, (Expression) Expression.Quote((Expression) keySelector), (Expression) Expression.Quote((Expression) elementSelector), (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))));
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    每個群組的項目都是利用指定的函式進行投影。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
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
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   T:System.Linq.IQueryable`1 具有型別引數的 <paramref name="TResult" /> ，其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" />、<paramref name="elementSelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TSource, TElement>> elementSelector,
      Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (elementSelector == null)
        throw Error.ArgumentNull(nameof (elementSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, Expression<Func<TKey, IEnumerable<TElement>, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, Expression<Func<TKey, IEnumerable<TElement>, TResult>>, IQueryable<TResult>>(Queryable.GroupBy<TSource, TKey, TElement, TResult>), source, keySelector, elementSelector, resultSelector), source.Expression, (Expression) Expression.Quote((Expression) keySelector), (Expression) Expression.Quote((Expression) elementSelector), (Expression) Expression.Quote((Expression) resultSelector)));
    }

    /// <summary>依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   T:System.Linq.IQueryable`1 具有型別引數的 <paramref name="TResult" /> ，其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" /> 或 <paramref name="resultSelector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TKey, IEnumerable<TSource>, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TKey, IEnumerable<TSource>, TResult>>, IQueryable<TResult>>(Queryable.GroupBy<TSource, TKey, TResult>), source, keySelector, resultSelector), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) keySelector),
        (Expression) Expression.Quote((Expression) resultSelector)
      }));
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    使用指定的比較子來比較索引鍵。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   T:System.Linq.IQueryable`1 具有型別引數的 <paramref name="TResult" /> ，其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="keySelector" />、<paramref name="resultSelector" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TKey, IEnumerable<TSource>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TKey, IEnumerable<TSource>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(Queryable.GroupBy<TSource, TKey, TResult>), source, keySelector, resultSelector, comparer), source.Expression, (Expression) Expression.Quote((Expression) keySelector), (Expression) Expression.Quote((Expression) resultSelector), (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))));
    }

    /// <summary>
    ///   依據指定的索引鍵選取器函式來群組序列的項目，並從每個群組及其索引鍵建立結果值。
    ///    使用指定的比較子來比較索引鍵，並利用指定的函式進行投影每個群組的項目。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 將其項目。
    /// </param>
    /// <param name="keySelector">用來擷取各項目之索引鍵的函式。</param>
    /// <param name="elementSelector">
    ///   函式來對應每個來源項目中的項目 <see cref="T:System.Linq.IGrouping`2" />。
    /// </param>
    /// <param name="resultSelector">用來從各個群組建立結果值的函式。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較索引鍵。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TKey">
    ///   表示函式所傳回的索引鍵類型 <paramref name="keySelector" />。
    /// </typeparam>
    /// <typeparam name="TElement">
    ///   在每個元素的型別 <see cref="T:System.Linq.IGrouping`2" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所傳回的結果值的型別 <paramref name="resultSelector" />。
    /// </typeparam>
    /// <returns>
    ///   T:System.Linq.IQueryable`1 具有型別引數的 <paramref name="TResult" /> ，其中每個項目代表投影的群組和其金鑰。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="keySelector" /> 或 <paramref name="elementSelector" /> 或 <paramref name="resultSelector" /> 或 <paramref name="comparer" /> 是 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TKey>> keySelector,
      Expression<Func<TSource, TElement>> elementSelector,
      Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (keySelector == null)
        throw Error.ArgumentNull(nameof (keySelector));
      if (elementSelector == null)
        throw Error.ArgumentNull(nameof (elementSelector));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, Expression<Func<TKey, IEnumerable<TElement>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(new Func<IQueryable<TSource>, Expression<Func<TSource, TKey>>, Expression<Func<TSource, TElement>>, Expression<Func<TKey, IEnumerable<TElement>, TResult>>, IEqualityComparer<TKey>, IQueryable<TResult>>(Queryable.GroupBy<TSource, TKey, TElement, TResult>), source, keySelector, elementSelector, resultSelector, comparer), source.Expression, (Expression) Expression.Quote((Expression) keySelector), (Expression) Expression.Quote((Expression) elementSelector), (Expression) Expression.Quote((Expression) resultSelector), (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TKey>))));
    }

    /// <summary>使用預設相等比較子來比較值，從序列傳回不同的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 移除重複項目中的。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含不同的項目從 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IQueryable<TSource>>(Queryable.Distinct<TSource>), source), source.Expression));
    }

    /// <summary>
    ///   從序列傳回不同的項目，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 移除重複項目中的。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含不同的項目從 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="comparer" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Distinct<TSource>(
      this IQueryable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(Queryable.Distinct<TSource>), source, comparer), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>串連兩個序列。</summary>
    /// <param name="source1">要串連的第一個序列。</param>
    /// <param name="source2">要串連到第一個序列的序列。</param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個輸入序列的串連項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Concat<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(Queryable.Concat<TSource>), source1, source2), new Expression[2]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2)
      }));
    }

    /// <summary>使用指定的述詞函式會將合併兩個序列。</summary>
    /// <param name="source1">要合併的第一個序列。</param>
    /// <param name="source2">要合併的第二個序列。</param>
    /// <param name="resultSelector">指定如何合併兩個序列中的項目函式。</param>
    /// <typeparam name="TFirst">第一個輸入序列的項目類型。</typeparam>
    /// <typeparam name="TSecond">第二個輸入序列的項目類型。</typeparam>
    /// <typeparam name="TResult">在結果序列的項目類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含合併兩個輸入序列的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" />或<paramref name="source2 " />是<see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TResult> Zip<TFirst, TSecond, TResult>(
      this IQueryable<TFirst> source1,
      IEnumerable<TSecond> source2,
      Expression<Func<TFirst, TSecond, TResult>> resultSelector)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      if (resultSelector == null)
        throw Error.ArgumentNull(nameof (resultSelector));
      return source1.Provider.CreateQuery<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TFirst>, IEnumerable<TSecond>, Expression<Func<TFirst, TSecond, TResult>>, IQueryable<TResult>>(new Func<IQueryable<TFirst>, IEnumerable<TSecond>, Expression<Func<TFirst, TSecond, TResult>>, IQueryable<TResult>>(Queryable.Zip<TFirst, TSecond, TResult>), source1, source2, resultSelector), new Expression[3]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSecond>(source2),
        (Expression) Expression.Quote((Expression) resultSelector)
      }));
    }

    /// <summary>使用預設相等比較子，以產生兩個序列的聯集。</summary>
    /// <param name="source1">序列，其不同項目構成等位作業的第一個集合。</param>
    /// <param name="source2">序列，其不同項目構成等位作業的第二個集合。</param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個輸入序列，排除重複的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Union<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(Queryable.Union<TSource>), source1, source2), new Expression[2]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2)
      }));
    }

    /// <summary>
    ///   使用指定之產生兩個序列的聯集 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="source1">序列，其不同項目構成等位作業的第一個集合。</param>
    /// <param name="source2">序列，其不同項目構成等位作業的第二個集合。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個輸入序列，排除重複的項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Union<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2,
      IEqualityComparer<TSource> comparer)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(Queryable.Union<TSource>), source1, source2, comparer), new Expression[3]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>使用預設相等比較子來比較值，會產生兩個序列的交集。</summary>
    /// <param name="source1">
    ///   也會出現在其個別項目的序列 <paramref name="source2" /> 會傳回。
    /// </param>
    /// <param name="source2">會傳回其獨特的項目同時出現在第一個序列的序列。</param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>序列，其中包含兩個序列的交集。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Intersect<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(Queryable.Intersect<TSource>), source1, source2), new Expression[2]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2)
      }));
    }

    /// <summary>
    ///   使用指定的產生兩個序列的交集 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </summary>
    /// <param name="source1">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其獨特的項目同時出現在 <paramref name="source2" /> 會傳回。
    /// </param>
    /// <param name="source2">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 會傳回其獨特的項目同時出現在第一個序列。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個序列的交集。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Intersect<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2,
      IEqualityComparer<TSource> comparer)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(Queryable.Intersect<TSource>), source1, source2, comparer), new Expression[3]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>使用預設相等比較子來比較值，會產生兩個序列的差異。</summary>
    /// <param name="source1">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 不在其項目 <paramref name="source2" /> 會傳回。
    /// </param>
    /// <param name="source2">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其同時出現在第一個序列的項目不會出現在傳回的序列。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個序列的差異。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Except<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IQueryable<TSource>>(Queryable.Except<TSource>), source1, source2), new Expression[2]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2)
      }));
    }

    /// <summary>
    ///   使用指定的產生兩個序列的差異 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </summary>
    /// <param name="source1">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 不在其項目 <paramref name="source2" /> 會傳回。
    /// </param>
    /// <param name="source2">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 其同時出現在第一個序列的項目不會出現在傳回的序列。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含兩個序列的差異。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Except<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2,
      IEqualityComparer<TSource> comparer)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, IQueryable<TSource>>(Queryable.Except<TSource>), source1, source2, comparer), new Expression[3]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>傳回序列的第一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的第一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   中的第一個項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource First<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.First<TSource>), source), source.Expression));
    }

    /// <summary>傳回序列中符合指定的條件的第一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   中的第一個項目 <paramref name="source" /> 中通過的測試 <paramref name="predicate" />。
    /// </returns>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.First<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回序列的第一個元素；如果序列中沒有包含任何元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的第一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   default(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的否則中的第一個項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.FirstOrDefault<TSource>), source), source.Expression));
    }

    /// <summary>傳回序列中符合指定的條件或預設值，如果找不到這類項目是第一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   default(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的或如果沒有任何項目會指定測試 <paramref name="predicate" />; 否則在第一個項目 <paramref name="source" /> 中通過指定測試 <paramref name="predicate" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource FirstOrDefault<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.FirstOrDefault<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回序列中的最後一個項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的最後一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   在最後一個位置中的值 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   來源序列是空的。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Last<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.Last<TSource>), source), source.Expression));
    }

    /// <summary>傳回序列中符合指定之條件的最後一個元素。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   中的最後一個項目 <paramref name="source" /> 中通過指定測試 <paramref name="predicate" />。
    /// </returns>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.Last<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回最後一個項目序列，或預設值，如果序列中沒有包含任何項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的最後一個元素。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   default(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的否則中的最後一個項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.LastOrDefault<TSource>), source), source.Expression));
    }

    /// <summary>傳回序列中符合條件的最後一個元素；如果找不到這類元素，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   default(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的或如果任何元素通過測試的述詞的函式; 否則最後一個項目 <paramref name="source" /> 中通過述詞函式的測試。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource LastOrDefault<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.LastOrDefault<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回序列的唯一一個元素，如果序列中不是正好一個元素，則擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的單一項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>輸入序列的單一項目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 有一個以上的項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Single<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.Single<TSource>), source), source.Expression));
    }

    /// <summary>傳回序列中符合指定之條件的唯一一個元素，如果有一個以上這類元素，則擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回單一項目。
    /// </param>
    /// <param name="predicate">用來測試項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入序列中符合條件中的單一項目 <paramref name="predicate" />。
    /// </returns>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.Single<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回的唯一項目序列或預設值，如果序列是空的。如果序列中有多個項目，則這個方法會擲回例外狀況。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的單一項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入序列的單一項目或 default(<paramref name="TSource" />) 如果序列中沒有包含任何項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   <paramref name="source" /> 有一個以上的項目。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.SingleOrDefault<TSource>), source), source.Expression));
    }

    /// <summary>
    ///   傳回序列中符合指定之條件的唯一一個元素，如果沒有這類元素，則為預設值，如果有一個以上的元素符合條件，這個方法就會擲回例外狀況。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回單一項目。
    /// </param>
    /// <param name="predicate">用來測試項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   輸入序列中符合條件中的單一項目 <paramref name="predicate" />, ，或 default(<paramref name="TSource" />) 如果找到這類項目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   多個項目符合條件中的 <paramref name="predicate" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource SingleOrDefault<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, TSource>(Queryable.SingleOrDefault<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回序列中的指定索引處的項目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="index">要擷取的項目之以零為起始索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   中指定位置處的項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="index" /> 小於零。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (index < 0)
        throw Error.ArgumentOutOfRange(nameof (index));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, int, TSource>(new Func<IQueryable<TSource>, int, TSource>(Queryable.ElementAt<TSource>), source, index), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) index)
      }));
    }

    /// <summary>傳回位於序列中指定索引處的元素；如果索引超出範圍，則傳回預設值。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的項目。
    /// </param>
    /// <param name="index">要擷取的項目之以零為起始索引。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   default(<paramref name="TSource" />) 如果 <paramref name="index" /> 超出界限的 <paramref name="source" />，否則中指定位置處的項目 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, int, TSource>(new Func<IQueryable<TSource>, int, TSource>(Queryable.ElementAtOrDefault<TSource>), source, index), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) index)
      }));
    }

    /// <summary>傳回單一集合中指定的序列或型別參數的預設值的項目，如果序列是空的。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 傳回的預設值，如果是空的。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含 <see langword="default" />(<paramref name="TSource" />) 如果 <paramref name="source" /> 是空的否則 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> DefaultIfEmpty<TSource>(
      this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IQueryable<TSource>>(Queryable.DefaultIfEmpty<TSource>), source), source.Expression));
    }

    /// <summary>傳回單一集合中指定的序列或指定的值的項目，如果序列是空的。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 來傳回指定的值，如果是空的。
    /// </param>
    /// <param name="defaultValue">在序列空白時所要傳回的值。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含 <paramref name="defaultValue" /> 如果 <paramref name="source" /> 是空的否則 <paramref name="source" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> DefaultIfEmpty<TSource>(
      this IQueryable<TSource> source,
      TSource defaultValue)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource, IQueryable<TSource>>(new Func<IQueryable<TSource>, TSource, IQueryable<TSource>>(Queryable.DefaultIfEmpty<TSource>), source, defaultValue), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) defaultValue, typeof (TSource))
      }));
    }

    /// <summary>判斷序列是否包含指定的項目，使用預設相等比較子。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 要放置於 <paramref name="item" />。
    /// </param>
    /// <param name="item">要尋找序列中的物件。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果輸入的序列中沒有包含具有指定的值; 的項目否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource, bool>(new Func<IQueryable<TSource>, TSource, bool>(Queryable.Contains<TSource>), source, item), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Constant((object) item, typeof (TSource))
      }));
    }

    /// <summary>
    ///   判斷序列是否包含指定的項目，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" />。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 要放置於 <paramref name="item" />。
    /// </param>
    /// <param name="item">要尋找序列中的物件。</param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較值。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果輸入的序列中沒有包含具有指定的值; 的項目否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool Contains<TSource>(
      this IQueryable<TSource> source,
      TSource item,
      IEqualityComparer<TSource> comparer)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource, IEqualityComparer<TSource>, bool>(new Func<IQueryable<TSource>, TSource, IEqualityComparer<TSource>, bool>(Queryable.Contains<TSource>), source, item, comparer), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Constant((object) item, typeof (TSource)),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>反轉序列中項目的順序。</summary>
    /// <param name="source">要反轉方向的值序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其項目對應於輸入序列中反向排序。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static IQueryable<TSource> Reverse<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.CreateQuery<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IQueryable<TSource>>(new Func<IQueryable<TSource>, IQueryable<TSource>>(Queryable.Reverse<TSource>), source), source.Expression));
    }

    /// <summary>判斷兩個序列是否相等，使用預設相等比較子來比較項目。</summary>
    /// <param name="source1">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其中的項目進行比對的 <paramref name="source2" />。
    /// </param>
    /// <param name="source2">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要比較的第一個序列的項目。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果兩個來源序列的長度相等，而且其對應項目比較結果相等。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool SequenceEqual<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, bool>(new Func<IQueryable<TSource>, IEnumerable<TSource>, bool>(Queryable.SequenceEqual<TSource>), source1, source2), new Expression[2]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2)
      }));
    }

    /// <summary>
    ///   判斷兩個序列是否相等，使用指定的 <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 來比較項目。
    /// </summary>
    /// <param name="source1">
    ///   <see cref="T:System.Linq.IQueryable`1" /> 其中的項目進行比對的 <paramref name="source2" />。
    /// </param>
    /// <param name="source2">
    ///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> 要比較的第一個序列的項目。
    /// </param>
    /// <param name="comparer">
    ///   <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> 用來比較項目。
    /// </param>
    /// <typeparam name="TSource">輸入序列之項目的類型。</typeparam>
    /// <returns>
    ///   <see langword="true" /> 如果兩個來源序列的長度相等，而且其對應項目比較結果相等。否則， <see langword="false" />。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source1" /> 或 <paramref name="source2" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static bool SequenceEqual<TSource>(
      this IQueryable<TSource> source1,
      IEnumerable<TSource> source2,
      IEqualityComparer<TSource> comparer)
    {
      if (source1 == null)
        throw Error.ArgumentNull(nameof (source1));
      if (source2 == null)
        throw Error.ArgumentNull(nameof (source2));
      return source1.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, bool>(new Func<IQueryable<TSource>, IEnumerable<TSource>, IEqualityComparer<TSource>, bool>(Queryable.SequenceEqual<TSource>), source1, source2, comparer), new Expression[3]
      {
        source1.Expression,
        Queryable.GetSourceExpression<TSource>(source2),
        (Expression) Expression.Constant((object) comparer, typeof (IEqualityComparer<TSource>))
      }));
    }

    /// <summary>判斷序列是否包含任何項目。</summary>
    /// <param name="source">要檢查為空的序列。</param>
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
    public static bool Any<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, bool>(new Func<IQueryable<TSource>, bool>(Queryable.Any<TSource>), source), source.Expression));
    }

    /// <summary>判斷序列中的任何項目是否符合條件。</summary>
    /// <param name="source">其項目來測試條件的序列。</param>
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
    public static bool Any<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, bool>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, bool>(Queryable.Any<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>判斷序列中的所有項目是否全都符合條件。</summary>
    /// <param name="source">其項目來測試條件的序列。</param>
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
    public static bool All<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<bool>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, bool>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, bool>(Queryable.All<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>傳回序列中的項目數目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含要計算的項目。
    /// </param>
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
    public static int Count<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<int>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, int>(new Func<IQueryable<TSource>, int>(Queryable.Count<TSource>), source), source.Expression));
    }

    /// <summary>指定符合條件的順序傳回項目數目。</summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含要計算的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中符合述詞函式的條件中的項目數目。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   中的項目數 <paramref name="source" /> 大於 <see cref="F:System.Int32.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static int Count<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<int>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, int>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, int>(Queryable.Count<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   傳回 <see cref="T:System.Int64" /> ，代表序列中的項目總數。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含要計算的項目。
    /// </param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   <paramref name="source" /> 中的元素數目。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   元素數目超過 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long LongCount<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<long>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, long>(new Func<IQueryable<TSource>, long>(Queryable.LongCount<TSource>), source), source.Expression));
    }

    /// <summary>
    ///   傳回 <see cref="T:System.Int64" /> ，代表序列中滿足條件的項目數目。
    /// </summary>
    /// <param name="source">
    ///   <see cref="T:System.Linq.IQueryable`1" /> ，其中包含要計算的項目。
    /// </param>
    /// <param name="predicate">用來測試每個項目是否符合條件的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   中的項目數 <paramref name="source" /> 中符合述詞函式的條件。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="predicate" /> 為 <see langword="null" />。
    /// </exception>
    /// <exception cref="T:System.OverflowException">
    ///   相符項目數目超過 <see cref="F:System.Int64.MaxValue" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static long LongCount<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, bool>> predicate)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (predicate == null)
        throw Error.ArgumentNull(nameof (predicate));
      return source.Provider.Execute<long>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, bool>>, long>(new Func<IQueryable<TSource>, Expression<Func<TSource, bool>>, long>(Queryable.LongCount<TSource>), source, predicate), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) predicate)
      }));
    }

    /// <summary>
    ///   傳回泛型的最小值 <see cref="T:System.Linq.IQueryable`1" />。
    /// </summary>
    /// <param name="source">若要判斷的最小值的序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Min<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.Min<TSource>), source), source.Expression));
    }

    /// <summary>
    ///   泛型的每個項目上的投影函式會叫用 <see cref="T:System.Linq.IQueryable`1" /> ，並傳回結果的最小值。
    /// </summary>
    /// <param name="source">若要判斷的最小值的序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>序列中的最小值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Min<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(new Func<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(Queryable.Min<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   泛型中傳回的最大值 <see cref="T:System.Linq.IQueryable`1" />。
    /// </summary>
    /// <param name="source">要判斷最多個值序列。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TSource Max<TSource>(this IQueryable<TSource> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TSource>(new Func<IQueryable<TSource>, TSource>(Queryable.Max<TSource>), source), source.Expression));
    }

    /// <summary>
    ///   泛型的每個項目上的投影函式會叫用 <see cref="T:System.Linq.IQueryable`1" /> ，並傳回結果的最大值。
    /// </summary>
    /// <param name="source">要判斷最多個值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TResult">
    ///   所代表的函式傳回值的型別 <paramref name="selector" />。
    /// </typeparam>
    /// <returns>序列中的最大值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Max<TSource, TResult>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(new Func<IQueryable<TSource>, Expression<Func<TSource, TResult>>, TResult>(Queryable.Max<TSource, TResult>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
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
    public static int Sum(this IQueryable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<int>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<int>, int>(new Func<IQueryable<int>, int>(Queryable.Sum), source), source.Expression));
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
    public static int? Sum(this IQueryable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<int?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<int?>, int?>(new Func<IQueryable<int?>, int?>(Queryable.Sum), source), source.Expression));
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
    public static long Sum(this IQueryable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<long>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<long>, long>(new Func<IQueryable<long>, long>(Queryable.Sum), source), source.Expression));
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
    public static long? Sum(this IQueryable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<long?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<long?>, long?>(new Func<IQueryable<long?>, long?>(Queryable.Sum), source), source.Expression));
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
    public static float Sum(this IQueryable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<float>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<float>, float>(new Func<IQueryable<float>, float>(Queryable.Sum), source), source.Expression));
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
    public static float? Sum(this IQueryable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<float?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<float?>, float?>(new Func<IQueryable<float?>, float?>(Queryable.Sum), source), source.Expression));
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
    public static double Sum(this IQueryable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<double>, double>(new Func<IQueryable<double>, double>(Queryable.Sum), source), source.Expression));
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
    public static double? Sum(this IQueryable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<double?>, double?>(new Func<IQueryable<double?>, double?>(Queryable.Sum), source), source.Expression));
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
    public static Decimal Sum(this IQueryable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<Decimal>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<Decimal>, Decimal>(new Func<IQueryable<Decimal>, Decimal>(Queryable.Sum), source), source.Expression));
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
    public static Decimal? Sum(this IQueryable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<Decimal?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<Decimal?>, Decimal?>(new Func<IQueryable<Decimal?>, Decimal?>(Queryable.Sum), source), source.Expression));
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int32" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
    public static int Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<int>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int>>, int>(new Func<IQueryable<TSource>, Expression<Func<TSource, int>>, int>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Int32" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
    public static int? Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<int?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int?>>, int?>(new Func<IQueryable<TSource>, Expression<Func<TSource, int?>>, int?>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Int64" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
    public static long Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, long>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<long>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long>>, long>(new Func<IQueryable<TSource>, Expression<Func<TSource, long>>, long>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Int64" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, long?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<long?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long?>>, long?>(new Func<IQueryable<TSource>, Expression<Func<TSource, long?>>, long?>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Single" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, float>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<float>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(new Func<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Single" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, float?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<float?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(new Func<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Double" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, double>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(new Func<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Double" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>預計值的總和。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Sum<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, double?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(new Func<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的總和 <see cref="T:System.Decimal" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, Decimal>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<Decimal>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, Decimal>>, Decimal>(new Func<IQueryable<TSource>, Expression<Func<TSource, Decimal>>, Decimal>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   可為 null 的序列的總和 <see cref="T:System.Decimal" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">
    ///   類型的值序列 <paramref name="TSource" />。
    /// </param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, Decimal?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<Decimal?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, Decimal?>>, Decimal?>(new Func<IQueryable<TSource>, Expression<Func<TSource, Decimal?>>, Decimal?>(Queryable.Sum<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
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
    public static double Average(this IQueryable<int> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<int>, double>(new Func<IQueryable<int>, double>(Queryable.Average), source), source.Expression));
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
    [__DynamicallyInvokable]
    public static double? Average(this IQueryable<int?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<int?>, double?>(new Func<IQueryable<int?>, double?>(Queryable.Average), source), source.Expression));
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
    public static double Average(this IQueryable<long> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<long>, double>(new Func<IQueryable<long>, double>(Queryable.Average), source), source.Expression));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int64" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Int64" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average(this IQueryable<long?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<long?>, double?>(new Func<IQueryable<long?>, double?>(Queryable.Average), source), source.Expression));
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
    public static float Average(this IQueryable<float> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<float>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<float>, float>(new Func<IQueryable<float>, float>(Queryable.Average), source), source.Expression));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Single" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Single" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Average(this IQueryable<float?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<float?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<float?>, float?>(new Func<IQueryable<float?>, float?>(Queryable.Average), source), source.Expression));
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
    public static double Average(this IQueryable<double> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<double>, double>(new Func<IQueryable<double>, double>(Queryable.Average), source), source.Expression));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Double" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Double" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average(this IQueryable<double?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<double?>, double?>(new Func<IQueryable<double?>, double?>(Queryable.Average), source), source.Expression));
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
    public static Decimal Average(this IQueryable<Decimal> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<Decimal>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<Decimal>, Decimal>(new Func<IQueryable<Decimal>, Decimal>(Queryable.Average), source), source.Expression));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Decimal" /> 值。
    /// </summary>
    /// <param name="source">
    ///   可為 null 的序列 <see cref="T:System.Decimal" /> 來計算平均值的值。
    /// </param>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果來源序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Average(this IQueryable<Decimal?> source)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      return source.Provider.Execute<Decimal?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<Decimal?>, Decimal?>(new Func<IQueryable<Decimal?>, Decimal?>(Queryable.Average), source), source.Expression));
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int32" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, int>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int>>, double>(new Func<IQueryable<TSource>, Expression<Func<TSource, int>>, double>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int32" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果 <paramref name="source" /> 序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, int?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, int?>>, double?>(new Func<IQueryable<TSource>, Expression<Func<TSource, int?>>, double?>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Single" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, float>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<float>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(new Func<IQueryable<TSource>, Expression<Func<TSource, float>>, float>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Single" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果 <paramref name="source" /> 序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static float? Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, float?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<float?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(new Func<IQueryable<TSource>, Expression<Func<TSource, float?>>, float?>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Int64" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, long>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long>>, double>(new Func<IQueryable<TSource>, Expression<Func<TSource, long>>, double>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Int64" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果 <paramref name="source" /> 序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, long?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, long?>>, double?>(new Func<IQueryable<TSource>, Expression<Func<TSource, long?>>, double?>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Double" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, double>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(new Func<IQueryable<TSource>, Expression<Func<TSource, double>>, double>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Double" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果 <paramref name="source" /> 序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static double? Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, double?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<double?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(new Func<IQueryable<TSource>, Expression<Func<TSource, double?>>, double?>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算序列的平均值 <see cref="T:System.Decimal" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">用來計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
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
    public static Decimal Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, Decimal>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<Decimal>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, Decimal>>, Decimal>(new Func<IQueryable<TSource>, Expression<Func<TSource, Decimal>>, Decimal>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>
    ///   計算可為 null 的序列的平均值 <see cref="T:System.Decimal" /> 藉由叫用每個輸入序列的項目中的投影函式的值。
    /// </summary>
    /// <param name="source">要計算平均值的值序列。</param>
    /// <param name="selector">要套用至每個項目投影函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <returns>
    ///   值的序列的平均值或 <see langword="null" /> 如果 <paramref name="source" /> 序列是空的或只包含 <see langword="null" /> 值。
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static Decimal? Average<TSource>(
      this IQueryable<TSource> source,
      Expression<Func<TSource, Decimal?>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<Decimal?>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, Decimal?>>, Decimal?>(new Func<IQueryable<TSource>, Expression<Func<TSource, Decimal?>>, Decimal?>(Queryable.Average<TSource>), source, selector), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) selector)
      }));
    }

    /// <summary>將累加函式套用到序列。</summary>
    /// <param name="source">所要彙總的序列。</param>
    /// <param name="func">累加函式套用至每個項目。</param>
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
      this IQueryable<TSource> source,
      Expression<Func<TSource, TSource, TSource>> func)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      return source.Provider.Execute<TSource>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, Expression<Func<TSource, TSource, TSource>>, TSource>(new Func<IQueryable<TSource>, Expression<Func<TSource, TSource, TSource>>, TSource>(Queryable.Aggregate<TSource>), source, func), new Expression[2]
      {
        source.Expression,
        (Expression) Expression.Quote((Expression) func)
      }));
    }

    /// <summary>
    ///   將累加函式套用到序列。
    ///    使用指定的初始值做為初始累加值。
    /// </summary>
    /// <param name="source">所要彙總的序列。</param>
    /// <param name="seed">初始累積值。</param>
    /// <param name="func">在每個項目上叫用的累加函式。</param>
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
      this IQueryable<TSource> source,
      TAccumulate seed,
      Expression<Func<TAccumulate, TSource, TAccumulate>> func)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      return source.Provider.Execute<TAccumulate>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TAccumulate, Expression<Func<TAccumulate, TSource, TAccumulate>>, TAccumulate>(new Func<IQueryable<TSource>, TAccumulate, Expression<Func<TAccumulate, TSource, TAccumulate>>, TAccumulate>(Queryable.Aggregate<TSource, TAccumulate>), source, seed, func), new Expression[3]
      {
        source.Expression,
        (Expression) Expression.Constant((object) seed),
        (Expression) Expression.Quote((Expression) func)
      }));
    }

    /// <summary>
    ///   將累加函式套用到序列。
    ///    使用指定的值做為初始累加值，並使用指定的函式來選取結果值。
    /// </summary>
    /// <param name="source">所要彙總的序列。</param>
    /// <param name="seed">初始累積值。</param>
    /// <param name="func">在每個項目上叫用的累加函式。</param>
    /// <param name="selector">用來將最終累加值轉換成結果值的函式。</param>
    /// <typeparam name="TSource">
    ///   項目的型別 <paramref name="source" />。
    /// </typeparam>
    /// <typeparam name="TAccumulate">累積值的類型。</typeparam>
    /// <typeparam name="TResult">結果值的類型。</typeparam>
    /// <returns>轉換後的最終累加值。</returns>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="source" />、<paramref name="func" /> 或 <paramref name="selector" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public static TResult Aggregate<TSource, TAccumulate, TResult>(
      this IQueryable<TSource> source,
      TAccumulate seed,
      Expression<Func<TAccumulate, TSource, TAccumulate>> func,
      Expression<Func<TAccumulate, TResult>> selector)
    {
      if (source == null)
        throw Error.ArgumentNull(nameof (source));
      if (func == null)
        throw Error.ArgumentNull(nameof (func));
      if (selector == null)
        throw Error.ArgumentNull(nameof (selector));
      return source.Provider.Execute<TResult>((Expression) Expression.Call((Expression) null, Queryable.GetMethodInfo<IQueryable<TSource>, TAccumulate, Expression<Func<TAccumulate, TSource, TAccumulate>>, Expression<Func<TAccumulate, TResult>>, TResult>(new Func<IQueryable<TSource>, TAccumulate, Expression<Func<TAccumulate, TSource, TAccumulate>>, Expression<Func<TAccumulate, TResult>>, TResult>(Queryable.Aggregate<TSource, TAccumulate, TResult>), source, seed, func, selector), source.Expression, (Expression) Expression.Constant((object) seed), (Expression) Expression.Quote((Expression) func), (Expression) Expression.Quote((Expression) selector)));
    }
  }
}
