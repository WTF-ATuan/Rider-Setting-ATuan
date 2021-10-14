// Decompiled with JetBrains decompiler
// Type: System.IDisposable
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: CAFB29D5-2338-47FB-B4ED-CF8D7C32B1E3
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll

using System.Runtime.InteropServices;

namespace System
{
  /// <summary>
  ///   提供用於釋放 Unmanaged 資源的機制。
  /// 
  ///   若要瀏覽此類型的.NET Framework 原始程式碼，請參閱Reference Source。
  /// </summary>
  /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.7.2">`IDisposable` on docs.microsoft.com</a></footer>
  [ComVisible(true)]
  public interface IDisposable
  {
    /// <summary>
    ///   執行與釋放 (Free)、釋放 (Release) 或重設 Unmanaged 資源相關聯之應用程式定義的工作。
    /// </summary>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose?view=netframework-4.7.2">`IDisposable.Dispose` on docs.microsoft.com</a></footer>
    void Dispose();
  }
}
