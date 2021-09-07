// Decompiled with JetBrains decompiler
// Type: UnityEngine.ScriptableObject
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A class you can derive from if you want to create objects that don't need to be attached to game objects.</para>
  /// </summary>
  [RequiredByNativeCode]
  [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
  [ExtensionOfNativeClass]
  [NativeClass(null)]
  [StructLayout(LayoutKind.Sequential)]
  public class ScriptableObject : Object
  {
    public ScriptableObject() => ScriptableObject.CreateScriptableObject(this);

    [Obsolete("Use EditorUtility.SetDirty instead")]
    [NativeConditional("ENABLE_MONO")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetDirty();

    /// <summary>
    ///   <para>Creates an instance of a scriptable object.</para>
    /// </summary>
    /// <param name="className">The type of the ScriptableObject to create, as the name of the type.</param>
    /// <param name="type">The type of the ScriptableObject to create, as a System.Type instance.</param>
    /// <returns>
    ///   <para>The created ScriptableObject.</para>
    /// </returns>
    public static ScriptableObject CreateInstance(string className) => ScriptableObject.CreateScriptableObjectInstanceFromName(className);

    /// <summary>
    ///   <para>Creates an instance of a scriptable object.</para>
    /// </summary>
    /// <param name="className">The type of the ScriptableObject to create, as the name of the type.</param>
    /// <param name="type">The type of the ScriptableObject to create, as a System.Type instance.</param>
    /// <returns>
    ///   <para>The created ScriptableObject.</para>
    /// </returns>
    public static ScriptableObject CreateInstance(System.Type type) => ScriptableObject.CreateScriptableObjectInstanceFromType(type, true);

    public static T CreateInstance<T>() where T : ScriptableObject => (T) ScriptableObject.CreateInstance(typeof (T));

    [NativeMethod(IsThreadSafe = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void CreateScriptableObject([Writable] ScriptableObject self);

    [FreeFunction("Scripting::CreateScriptableObject")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern ScriptableObject CreateScriptableObjectInstanceFromName(
      string className);

    [FreeFunction("Scripting::CreateScriptableObjectWithType")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern ScriptableObject CreateScriptableObjectInstanceFromType(
      System.Type type,
      bool applyDefaultsAndReset);

    [FreeFunction("Scripting::ResetAndApplyDefaultInstances")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void ResetAndApplyDefaultInstances(Object obj);
  }
}
