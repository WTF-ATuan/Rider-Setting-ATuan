// Decompiled with JetBrains decompiler
// Type: UnityEngine.AnimatorControllerParameter
// Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81A2A079-7F3C-43B2-AABD-7604740BCD48
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll

using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Used to communicate between scripting and the controller. Some parameters can be set in scripting and used by the controller, while other parameters are based on Custom Curves in Animation Clips and can be sampled using the scripting API.</para>
  /// </summary>
  [NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
  [NativeAsStruct]
  [UsedByNativeCode]
  [NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
  [NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
  [StructLayout(LayoutKind.Sequential)]
  public class AnimatorControllerParameter
  {
    internal string m_Name = "";
    internal AnimatorControllerParameterType m_Type;
    internal float m_DefaultFloat;
    internal int m_DefaultInt;
    internal bool m_DefaultBool;

    /// <summary>
    ///   <para>The name of the parameter.</para>
    /// </summary>
    public string name
    {
      get => this.m_Name;
      set => this.m_Name = value;
    }

    /// <summary>
    ///   <para>Returns the hash of the parameter based on its name.</para>
    /// </summary>
    public int nameHash => Animator.StringToHash(this.m_Name);

    /// <summary>
    ///   <para>The type of the parameter.</para>
    /// </summary>
    public AnimatorControllerParameterType type
    {
      get => this.m_Type;
      set => this.m_Type = value;
    }

    /// <summary>
    ///   <para>The default float value for the parameter.</para>
    /// </summary>
    public float defaultFloat
    {
      get => this.m_DefaultFloat;
      set => this.m_DefaultFloat = value;
    }

    /// <summary>
    ///   <para>The default int value for the parameter.</para>
    /// </summary>
    public int defaultInt
    {
      get => this.m_DefaultInt;
      set => this.m_DefaultInt = value;
    }

    /// <summary>
    ///   <para>The default bool value for the parameter.</para>
    /// </summary>
    public bool defaultBool
    {
      get => this.m_DefaultBool;
      set => this.m_DefaultBool = value;
    }

    public override bool Equals(object o) => o is AnimatorControllerParameter controllerParameter && this.m_Name == controllerParameter.m_Name && (this.m_Type == controllerParameter.m_Type && (double) this.m_DefaultFloat == (double) controllerParameter.m_DefaultFloat) && this.m_DefaultInt == controllerParameter.m_DefaultInt && this.m_DefaultBool == controllerParameter.m_DefaultBool;

    public override int GetHashCode() => this.name.GetHashCode();
  }
}
