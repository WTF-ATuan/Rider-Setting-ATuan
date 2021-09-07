// Decompiled with JetBrains decompiler
// Type: UnityEngine.Behaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Behaviours are Components that can be enabled or disabled.</para>
  /// </summary>
  [UsedByNativeCode]
  [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
  public class Behaviour : Component
  {
    /// <summary>
    ///   <para>Enabled Behaviours are Updated, disabled Behaviours are not.</para>
    /// </summary>
    [NativeProperty]
    [RequiredByNativeCode]
    public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Has the Behaviour had active and enabled called?</para>
    /// </summary>
    [NativeProperty]
    public extern bool isActiveAndEnabled { [NativeMethod("IsAddedToManager"), MethodImpl(MethodImplOptions.InternalCall)] get; }
  }
}
