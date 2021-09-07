// Decompiled with JetBrains decompiler
// Type: System.Lazy`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E81851A0-DC73-4A79-AFA9-F5B7273162BE
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System
{
  /// <summary>提供延遲初始設定的支援。</summary>
  /// <typeparam name="T">正在延遲初始化的物件類型。</typeparam>
  [ComVisible(false)]
  [DebuggerTypeProxy(typeof (System_LazyDebugView<>))]
  [DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
  [__DynamicallyInvokable]
  [Serializable]
  [HostProtection(SecurityAction.LinkDemand, ExternalThreading = true, Synchronization = true)]
  public class Lazy<T>
  {
    private static readonly Func<T> ALREADY_INVOKED_SENTINEL = (Func<T>) (() => default (T));
    private object m_boxed;
    [NonSerialized]
    private Func<T> m_valueFactory;
    [NonSerialized]
    private object m_threadSafeObj;

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體。
    ///    發生延遲初始設定時，會使用目標類型的預設建構函式。
    /// </summary>
    [__DynamicallyInvokable]
    public Lazy()
      : this(LazyThreadSafetyMode.ExecutionAndPublication)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體。
    ///    當延遲初始設定發生時，就會使用指定的初始化函式。
    /// </summary>
    /// <param name="valueFactory">委派，需要時會叫用以產生延遲初始化的值。</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="valueFactory" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public Lazy(Func<T> valueFactory)
      : this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體。
    ///    當延遲初始設定發生時，會使用目標類型的預設建構函式和指定的初始設定模式。
    /// </summary>
    /// <param name="isThreadSafe">
    ///   <see langword="true" /> 表示這個執行個體可供多個執行緒同時使用；<see langword="false" /> 表示這個執行個體一次只能供一個執行緒使用。
    /// </param>
    [__DynamicallyInvokable]
    public Lazy(bool isThreadSafe)
      : this(isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體，這些類別會使用 <paramref name="T" /> 的預設建構函式和指定執行緒安全模式。
    /// </summary>
    /// <param name="mode">其中一個列舉值會指定執行緒安全模式。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="mode" /> 包含無效的值。
    /// </exception>
    [__DynamicallyInvokable]
    public Lazy(LazyThreadSafetyMode mode) => this.m_threadSafeObj = Lazy<T>.GetObjectFromMode(mode);

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體。
    ///    當延遲初始設定發生時，會使用指定的初始化函式和初始化模式。
    /// </summary>
    /// <param name="valueFactory">委派，需要時會叫用以產生延遲初始化的值。</param>
    /// <param name="isThreadSafe">
    ///   <see langword="true" /> 表示這個執行個體可供多個執行緒同時使用；<see langword="false" /> 表示這個執行個體一次只能供一個執行緒使用。
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="valueFactory" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public Lazy(Func<T> valueFactory, bool isThreadSafe)
      : this(valueFactory, isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
    {
    }

    /// <summary>
    ///   初始化 <see cref="T:System.Lazy`1" /> 類別的新執行個體，此類別使用的是指定的初始化函數和執行緒安全模式。
    /// </summary>
    /// <param name="valueFactory">委派，需要時會叫用以產生延遲初始化的值。</param>
    /// <param name="mode">其中一個列舉值會指定執行緒安全模式。</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///   <paramref name="mode" /> 包含無效的值。
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///   <paramref name="valueFactory" /> 為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
    {
      if (valueFactory == null)
        throw new ArgumentNullException(nameof (valueFactory));
      this.m_threadSafeObj = Lazy<T>.GetObjectFromMode(mode);
      this.m_valueFactory = valueFactory;
    }

    private static object GetObjectFromMode(LazyThreadSafetyMode mode)
    {
      if (mode == LazyThreadSafetyMode.ExecutionAndPublication)
        return new object();
      if (mode == LazyThreadSafetyMode.PublicationOnly)
        return LazyHelpers.PUBLICATION_ONLY_SENTINEL;
      if (mode != LazyThreadSafetyMode.None)
        throw new ArgumentOutOfRangeException(nameof (mode), Environment.GetResourceString("Lazy_ctor_ModeInvalid"));
      return (object) null;
    }

    [System.Runtime.Serialization.OnSerializing]
    private void OnSerializing(StreamingContext context)
    {
      T obj = this.Value;
    }

    /// <summary>
    ///   建立並傳回這個執行個體之 <see cref="P:System.Lazy`1.Value" /> 屬性的字串表示。
    /// </summary>
    /// <returns>
    ///   在這個執行個體的 <see cref="P:System.Lazy`1.Value" /> 屬性上呼叫 <see cref="M:System.Object.ToString" /> 方法的結果 (如果已建立值) (亦即，如果 <see cref="P:System.Lazy`1.IsValueCreated" /> 屬性傳回 <see langword="true" />)。
    ///    否則為表示尚未建立值的字串。
    /// </returns>
    /// <exception cref="T:System.NullReferenceException">
    ///   <see cref="P:System.Lazy`1.Value" /> 屬性為 <see langword="null" />。
    /// </exception>
    [__DynamicallyInvokable]
    public override string ToString() => !this.IsValueCreated ? Environment.GetResourceString("Lazy_ToString_ValueNotCreated") : this.Value.ToString();

    internal T ValueForDebugDisplay => !this.IsValueCreated ? default (T) : ((Lazy<T>.Boxed) this.m_boxed).m_value;

    internal LazyThreadSafetyMode Mode
    {
      get
      {
        if (this.m_threadSafeObj == null)
          return LazyThreadSafetyMode.None;
        return this.m_threadSafeObj == LazyHelpers.PUBLICATION_ONLY_SENTINEL ? LazyThreadSafetyMode.PublicationOnly : LazyThreadSafetyMode.ExecutionAndPublication;
      }
    }

    internal bool IsValueFaulted => this.m_boxed is Lazy<T>.LazyInternalExceptionHolder;

    /// <summary>
    ///   取得值，指出某個值是否已經建立這個 <see cref="T:System.Lazy`1" /> 執行個體。
    /// </summary>
    /// <returns>
    ///   如果已為這個 <see cref="T:System.Lazy`1" /> 執行個體建立了值，則為 <see langword="true" />；否則為 <see langword="false" />。
    /// </returns>
    [__DynamicallyInvokable]
    public bool IsValueCreated
    {
      [__DynamicallyInvokable] get => this.m_boxed != null && this.m_boxed is Lazy<T>.Boxed;
    }

    /// <summary>
    ///   取得目前 <see cref="T:System.Lazy`1" /> 執行個體的延遲初始化值。
    /// </summary>
    /// <returns>
    ///   目前 <see cref="T:System.Lazy`1" /> 執行個體的延遲初始化值。
    /// </returns>
    /// <exception cref="T:System.MemberAccessException">
    ///   <see cref="T:System.Lazy`1" /> 執行個體初始化為使用延遲初始化之類型的預設建構函式，且存取建構函式的權限已遺失。
    /// </exception>
    /// <exception cref="T:System.MissingMemberException">
    ///   <see cref="T:System.Lazy`1" /> 執行個體初始化為使用延遲初始化之類型的預設建構函式，且該類型未具有公用無參數的建構函式。
    /// </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///   初始化函式嘗試存取此執行個體上的 <see cref="P:System.Lazy`1.Value" />。
    /// </exception>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [__DynamicallyInvokable]
    public T Value
    {
      [__DynamicallyInvokable] get
      {
        if (this.m_boxed != null)
        {
          if (this.m_boxed is Lazy<T>.Boxed boxed)
            return boxed.m_value;
          (this.m_boxed as Lazy<T>.LazyInternalExceptionHolder).m_edi.Throw();
        }
        Debugger.NotifyOfCrossThreadDependency();
        return this.LazyInitValue();
      }
    }

    private T LazyInitValue()
    {
      boxed = (Lazy<T>.Boxed) null;
      switch (this.Mode)
      {
        case LazyThreadSafetyMode.None:
          boxed = this.CreateValue();
          this.m_boxed = (object) boxed;
          break;
        case LazyThreadSafetyMode.PublicationOnly:
          boxed = this.CreateValue();
          if (boxed == null || Interlocked.CompareExchange(ref this.m_boxed, (object) boxed, (object) null) != null)
          {
            boxed = (Lazy<T>.Boxed) this.m_boxed;
            break;
          }
          this.m_valueFactory = Lazy<T>.ALREADY_INVOKED_SENTINEL;
          break;
        default:
          object obj = Volatile.Read<object>(ref this.m_threadSafeObj);
          bool lockTaken = false;
          try
          {
            if (obj != Lazy<T>.ALREADY_INVOKED_SENTINEL)
              Monitor.Enter(obj, ref lockTaken);
            if (this.m_boxed == null)
            {
              boxed = this.CreateValue();
              this.m_boxed = (object) boxed;
              Volatile.Write<object>(ref this.m_threadSafeObj, (object) Lazy<T>.ALREADY_INVOKED_SENTINEL);
              break;
            }
            if (!(this.m_boxed is Lazy<T>.Boxed boxed))
            {
              (this.m_boxed as Lazy<T>.LazyInternalExceptionHolder).m_edi.Throw();
              break;
            }
            break;
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(obj);
          }
      }
      return boxed.m_value;
    }

    private Lazy<T>.Boxed CreateValue()
    {
      LazyThreadSafetyMode mode = this.Mode;
      if (this.m_valueFactory != null)
      {
        try
        {
          if (mode != LazyThreadSafetyMode.PublicationOnly && this.m_valueFactory == Lazy<T>.ALREADY_INVOKED_SENTINEL)
            throw new InvalidOperationException(Environment.GetResourceString("Lazy_Value_RecursiveCallsToValue"));
          Func<T> valueFactory = this.m_valueFactory;
          if (mode != LazyThreadSafetyMode.PublicationOnly)
            this.m_valueFactory = Lazy<T>.ALREADY_INVOKED_SENTINEL;
          else if (valueFactory == Lazy<T>.ALREADY_INVOKED_SENTINEL)
            return (Lazy<T>.Boxed) null;
          return new Lazy<T>.Boxed(valueFactory());
        }
        catch (Exception ex)
        {
          if (mode != LazyThreadSafetyMode.PublicationOnly)
            this.m_boxed = (object) new Lazy<T>.LazyInternalExceptionHolder(ex);
          throw;
        }
      }
      else
      {
        try
        {
          return new Lazy<T>.Boxed((T) Activator.CreateInstance(typeof (T)));
        }
        catch (MissingMethodException ex1)
        {
          Exception ex2 = (Exception) new MissingMemberException(Environment.GetResourceString("Lazy_CreateValue_NoParameterlessCtorForT"));
          if (mode != LazyThreadSafetyMode.PublicationOnly)
            this.m_boxed = (object) new Lazy<T>.LazyInternalExceptionHolder(ex2);
          throw ex2;
        }
      }
    }

    [Serializable]
    private class Boxed
    {
      internal T m_value;

      internal Boxed(T value) => this.m_value = value;
    }

    private class LazyInternalExceptionHolder
    {
      internal ExceptionDispatchInfo m_edi;

      internal LazyInternalExceptionHolder(Exception ex) => this.m_edi = ExceptionDispatchInfo.Capture(ex);
    }
  }
}
