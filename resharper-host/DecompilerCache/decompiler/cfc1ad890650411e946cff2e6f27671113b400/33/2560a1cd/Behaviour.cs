// Decompiled with JetBrains decompiler
// Type: UnityEngine.Behaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFC1AD89-0650-411E-946C-FF2E6F276711
// Assembly location: D:\unity\2020.3.14f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Behaviours are Components that can be enabled or disabled.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Behaviour.html">External documentation for `Behaviour`</a></footer>
  [UsedByNativeCode]
  [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
  public class Behaviour : Component
  {
    /// <summary>
    ///   <para>Enabled Behaviours are Updated, disabled Behaviours are not.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Behaviour-enabled.html">External documentation for `Behaviour.enabled`</a></footer>
    [RequiredByNativeCode]
    [NativeProperty]
    public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Has the Behaviour had active and enabled called?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Behaviour-isActiveAndEnabled.html">External documentation for `Behaviour.isActiveAndEnabled`</a></footer>
    [NativeProperty]
    public extern bool isActiveAndEnabled { [NativeMethod("IsAddedToManager"), MethodImpl(MethodImplOptions.InternalCall)] get; }
  }
}
