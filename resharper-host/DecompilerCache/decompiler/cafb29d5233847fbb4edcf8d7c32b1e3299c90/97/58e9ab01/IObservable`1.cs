// Decompiled with JetBrains decompiler
// Type: System.IObservable`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: CAFB29D5-2338-47FB-B4ED-CF8D7C32B1E3
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll

namespace System
{
  /// <summary>定義推播通知的提供者。</summary>
  /// <typeparam name="T">提供通知資訊的物件。</typeparam>
  /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1?view=netframework-4.7.2">`IObservable` on docs.microsoft.com</a></footer>
  public interface IObservable<out T>
  {
    /// <summary>通知提供者，觀察者將接收通知。</summary>
    /// <param name="observer">要接收通知的物件。</param>
    /// <returns>可讓觀察者在提供者完成傳送通知之前停止接收通知的介面的參考。</returns>
    /// <footer><a href="https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1.Subscribe?view=netframework-4.7.2">`IObservable.Subscribe` on docs.microsoft.com</a></footer>
    IDisposable Subscribe(IObserver<T> observer);
  }
}
