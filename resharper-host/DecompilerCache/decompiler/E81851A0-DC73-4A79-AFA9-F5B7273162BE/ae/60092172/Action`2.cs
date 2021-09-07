// Decompiled with JetBrains decompiler
// Type: System.Action`2
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: E81851A0-DC73-4A79-AFA9-F5B7273162BE
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll

using System.Runtime.CompilerServices;

namespace System
{
  /// <summary>封裝具有 2 個參數且沒有傳回值的方法。</summary>
  /// <param name="arg1">此委派封裝之方法的第一個參數。</param>
  /// <param name="arg2">此委派封裝之方法的第二個參數。</param>
  /// <typeparam name="T1">此委派封裝之方法的第一個參數類型。</typeparam>
  /// <typeparam name="T2">此委派封裝之方法的第二個參數類型。</typeparam>
  [TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
  [__DynamicallyInvokable]
  public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
}
