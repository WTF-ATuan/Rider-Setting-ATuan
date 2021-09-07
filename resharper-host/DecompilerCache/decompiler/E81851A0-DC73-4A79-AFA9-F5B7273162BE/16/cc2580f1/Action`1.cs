// Decompiled with JetBrains decompiler
// Type: System.Action`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E81851A0-DC73-4A79-AFA9-F5B7273162BE
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

namespace System
{
  /// <summary>
  ///   封裝具有單一參數的方法，並且不會傳回值。
  /// 
  ///   若要瀏覽此類型的.NET Framework 原始程式碼，請參閱Reference Source。
  /// </summary>
  /// <param name="obj">這個委派所封裝之方法的參數。</param>
  /// <typeparam name="T">這個委派所封裝之方法的參數類型。</typeparam>
  [__DynamicallyInvokable]
  public delegate void Action<in T>(T obj);
}
