// Decompiled with JetBrains decompiler
// Type: System.IDisposable
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 63DD8BF9-8CFA-4BA9-85AF-735EF1A56BA9
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Runtime.InteropServices;

namespace System
{
  /// <summary>
  ///   提供用於釋放 Unmanaged 資源的機制。
  /// 
  ///   若要瀏覽此類型的.NET Framework 原始程式碼，請參閱Reference Source。
  /// </summary>
  [ComVisible(true)]
  [__DynamicallyInvokable]
  public interface IDisposable
  {
    /// <summary>
    ///   執行與釋放 (Free)、釋放 (Release) 或重設 Unmanaged 資源相關聯之應用程式定義的工作。
    /// </summary>
    [__DynamicallyInvokable]
    void Dispose();
  }
}
