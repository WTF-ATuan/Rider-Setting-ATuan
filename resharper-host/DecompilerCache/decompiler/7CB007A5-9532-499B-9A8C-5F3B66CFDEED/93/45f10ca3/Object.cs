// Decompiled with JetBrains decompiler
// Type: UnityEngine.Object
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7CB007A5-9532-499B-9A8C-5F3B66CFDEED
// Assembly location: D:\unity\2018.4.29f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Base class for all objects Unity can reference.</para>
  /// </summary>
  [RequiredByNativeCode(GenerateProxy = true)]
  [NativeHeader("Runtime/Export/UnityEngineObject.bindings.h")]
  [NativeHeader("Runtime/GameCode/CloneObject.h")]
  [NativeHeader("Runtime/SceneManager/SceneManager.h")]
  [StructLayout(LayoutKind.Sequential)]
  public class Object
  {
    private IntPtr m_CachedPtr;
    private int m_InstanceID;
    private string m_UnityRuntimeErrorString;
    internal static int OffsetOfInstanceIDInCPlusPlusObject = -1;
    private const string objectIsNullMessage = "The Object you want to instantiate is null.";
    private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

    /// <summary>
    ///   <para>Returns the instance id of the object.</para>
    /// </summary>
    [SecuritySafeCritical]
    public int GetInstanceID()
    {
      this.EnsureRunningOnMainThread();
      return this.m_InstanceID;
    }

    public override int GetHashCode() => this.m_InstanceID;

    public override bool Equals(object other)
    {
      Object rhs = other as Object;
      return (!(rhs == (Object) null) || other == null || (object) (other as Object) != null) && Object.CompareBaseObjects(this, rhs);
    }

    public static implicit operator bool(Object exists) => !Object.CompareBaseObjects(exists, (Object) null);

    private static bool CompareBaseObjects(Object lhs, Object rhs)
    {
      bool flag1 = (object) lhs == null;
      bool flag2 = (object) rhs == null;
      if (flag2 && flag1)
        return true;
      if (flag2)
        return !Object.IsNativeObjectAlive(lhs);
      return flag1 ? !Object.IsNativeObjectAlive(rhs) : lhs.m_InstanceID == rhs.m_InstanceID;
    }

    private void EnsureRunningOnMainThread()
    {
      if (!Object.CurrentThreadIsMainThread())
        throw new InvalidOperationException("EnsureRunningOnMainThread can only be called from the main thread");
    }

    private static bool IsNativeObjectAlive(Object o)
    {
      if (o.GetCachedPtr() != IntPtr.Zero)
        return true;
      switch (o)
      {
        case MonoBehaviour _:
        case ScriptableObject _:
          return false;
        default:
          return Object.DoesObjectWithInstanceIDExist(o.GetInstanceID());
      }
    }

    private IntPtr GetCachedPtr() => this.m_CachedPtr;

    /// <summary>
    ///   <para>The name of the object.</para>
    /// </summary>
    public string name
    {
      get => Object.GetName(this);
      set => Object.SetName(this, value);
    }

    /// <summary>
    ///   <para>Clones the object original and returns the clone.</para>
    /// </summary>
    /// <param name="original">An existing object that you want to make a copy of.</param>
    /// <param name="position">Position for the new object.</param>
    /// <param name="rotation">Orientation of the new object.</param>
    /// <param name="parent">Parent that will be assigned to the new object.</param>
    /// <param name="instantiateInWorldSpace">Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.</param>
    /// <returns>
    ///   <para>The instantiated clone.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
    public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
    {
      Object.CheckNullArgument((object) original, "The Object you want to instantiate is null.");
      if (original is ScriptableObject)
        throw new ArgumentException("Cannot instantiate a ScriptableObject with a position and rotation");
      Object @object = Object.Internal_InstantiateSingle(original, position, rotation);
      return !(@object == (Object) null) ? @object : throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
    }

    /// <summary>
    ///   <para>Clones the object original and returns the clone.</para>
    /// </summary>
    /// <param name="original">An existing object that you want to make a copy of.</param>
    /// <param name="position">Position for the new object.</param>
    /// <param name="rotation">Orientation of the new object.</param>
    /// <param name="parent">Parent that will be assigned to the new object.</param>
    /// <param name="instantiateInWorldSpace">Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.</param>
    /// <returns>
    ///   <para>The instantiated clone.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
    public static Object Instantiate(
      Object original,
      Vector3 position,
      Quaternion rotation,
      Transform parent)
    {
      if ((Object) parent == (Object) null)
        return Object.Instantiate(original, position, rotation);
      Object.CheckNullArgument((object) original, "The Object you want to instantiate is null.");
      Object @object = Object.Internal_InstantiateSingleWithParent(original, parent, position, rotation);
      return !(@object == (Object) null) ? @object : throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
    }

    /// <summary>
    ///   <para>Clones the object original and returns the clone.</para>
    /// </summary>
    /// <param name="original">An existing object that you want to make a copy of.</param>
    /// <param name="position">Position for the new object.</param>
    /// <param name="rotation">Orientation of the new object.</param>
    /// <param name="parent">Parent that will be assigned to the new object.</param>
    /// <param name="instantiateInWorldSpace">Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.</param>
    /// <returns>
    ///   <para>The instantiated clone.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
    public static Object Instantiate(Object original)
    {
      Object.CheckNullArgument((object) original, "The Object you want to instantiate is null.");
      Object @object = Object.Internal_CloneSingle(original);
      return !(@object == (Object) null) ? @object : throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
    }

    /// <summary>
    ///   <para>Clones the object original and returns the clone.</para>
    /// </summary>
    /// <param name="original">An existing object that you want to make a copy of.</param>
    /// <param name="position">Position for the new object.</param>
    /// <param name="rotation">Orientation of the new object.</param>
    /// <param name="parent">Parent that will be assigned to the new object.</param>
    /// <param name="instantiateInWorldSpace">Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.</param>
    /// <returns>
    ///   <para>The instantiated clone.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
    public static Object Instantiate(Object original, Transform parent) => Object.Instantiate(original, parent, false);

    /// <summary>
    ///   <para>Clones the object original and returns the clone.</para>
    /// </summary>
    /// <param name="original">An existing object that you want to make a copy of.</param>
    /// <param name="position">Position for the new object.</param>
    /// <param name="rotation">Orientation of the new object.</param>
    /// <param name="parent">Parent that will be assigned to the new object.</param>
    /// <param name="instantiateInWorldSpace">Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.</param>
    /// <returns>
    ///   <para>The instantiated clone.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
    public static Object Instantiate(
      Object original,
      Transform parent,
      bool instantiateInWorldSpace)
    {
      if ((Object) parent == (Object) null)
        return Object.Instantiate(original);
      Object.CheckNullArgument((object) original, "The Object you want to instantiate is null.");
      Object @object = Object.Internal_CloneSingleWithParent(original, parent, instantiateInWorldSpace);
      return !(@object == (Object) null) ? @object : throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
    }

    public static T Instantiate<T>(T original) where T : Object
    {
      Object.CheckNullArgument((object) original, "The Object you want to instantiate is null.");
      T obj = (T) Object.Internal_CloneSingle((Object) original);
      return !((Object) obj == (Object) null) ? obj : throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
    }

    public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object => (T) Object.Instantiate((Object) original, position, rotation);

    public static T Instantiate<T>(
      T original,
      Vector3 position,
      Quaternion rotation,
      Transform parent)
      where T : Object
    {
      return (T) Object.Instantiate((Object) original, position, rotation, parent);
    }

    public static T Instantiate<T>(T original, Transform parent) where T : Object => Object.Instantiate<T>(original, parent, false);

    public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object => (T) Object.Instantiate((Object) original, parent, worldPositionStays);

    /// <summary>
    ///   <para>Removes a gameobject, component or asset.</para>
    /// </summary>
    /// <param name="obj">The object to destroy.</param>
    /// <param name="t">The optional amount of time to delay before destroying the object.</param>
    [NativeMethod(IsFreeFunction = true, Name = "Scripting::DestroyObjectFromScripting", ThrowsException = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void Destroy(Object obj, [DefaultValue("0.0F")] float t);

    /// <summary>
    ///   <para>Removes a gameobject, component or asset.</para>
    /// </summary>
    /// <param name="obj">The object to destroy.</param>
    /// <param name="t">The optional amount of time to delay before destroying the object.</param>
    [ExcludeFromDocs]
    public static void Destroy(Object obj)
    {
      float t = 0.0f;
      Object.Destroy(obj, t);
    }

    /// <summary>
    ///   <para>Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</para>
    /// </summary>
    /// <param name="obj">Object to be destroyed.</param>
    /// <param name="allowDestroyingAssets">Set to true to allow assets to be destroyed.</param>
    [NativeMethod(IsFreeFunction = true, Name = "Scripting::DestroyObjectFromScriptingImmediate", ThrowsException = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);

    /// <summary>
    ///   <para>Destroys the object obj immediately. You are strongly recommended to use Destroy instead.</para>
    /// </summary>
    /// <param name="obj">Object to be destroyed.</param>
    /// <param name="allowDestroyingAssets">Set to true to allow assets to be destroyed.</param>
    [ExcludeFromDocs]
    public static void DestroyImmediate(Object obj)
    {
      bool allowDestroyingAssets = false;
      Object.DestroyImmediate(obj, allowDestroyingAssets);
    }

    /// <summary>
    ///   <para>Returns a list of all active loaded objects of Type type.</para>
    /// </summary>
    /// <param name="type">The type of object to find.</param>
    /// <returns>
    ///   <para>The array of objects found matching the type specified.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
    [FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern Object[] FindObjectsOfType(System.Type type);

    /// <summary>
    ///   <para>Do not destroy the target Object when loading a new Scene.</para>
    /// </summary>
    /// <param name="target">An Object not destroyed on Scene change.</param>
    [FreeFunction("GetSceneManager().DontDestroyOnLoad")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DontDestroyOnLoad(Object target);

    /// <summary>
    ///   <para>Should the object be hidden, saved with the Scene or modifiable by the user?</para>
    /// </summary>
    public extern HideFlags hideFlags { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("use Object.Destroy instead.")]
    public static void DestroyObject(Object obj, [DefaultValue("0.0F")] float t) => Object.Destroy(obj, t);

    [Obsolete("use Object.Destroy instead.")]
    [ExcludeFromDocs]
    public static void DestroyObject(Object obj)
    {
      float t = 0.0f;
      Object.Destroy(obj, t);
    }

    [Obsolete("warning use Object.FindObjectsOfType instead.")]
    [FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern Object[] FindSceneObjectsOfType(System.Type type);

    /// <summary>
    ///   <para>Returns a list of all active and inactive loaded objects of Type type, including assets.</para>
    /// </summary>
    /// <param name="type">The type of object or asset to find.</param>
    /// <returns>
    ///   <para>The array of objects and assets found matching the type specified.</para>
    /// </returns>
    [Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
    [FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern Object[] FindObjectsOfTypeIncludingAssets(System.Type type);

    public static T[] FindObjectsOfType<T>() where T : Object => Resources.ConvertObjects<T>(Object.FindObjectsOfType(typeof (T)));

    public static T FindObjectOfType<T>() where T : Object => (T) Object.FindObjectOfType(typeof (T));

    /// <summary>
    ///   <para>Returns a list of all active and inactive loaded objects of Type type.</para>
    /// </summary>
    /// <param name="type">The type of object to find.</param>
    /// <returns>
    ///   <para>The array of objects found matching the type specified.</para>
    /// </returns>
    [Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
    public static Object[] FindObjectsOfTypeAll(System.Type type) => Resources.FindObjectsOfTypeAll(type);

    private static void CheckNullArgument(object arg, string message)
    {
      if (arg == null)
        throw new ArgumentException(message);
    }

    /// <summary>
    ///   <para>Returns the first active loaded object of Type type.</para>
    /// </summary>
    /// <param name="type">The type of object to find.</param>
    /// <returns>
    ///   <para>This returns the  Object that matches the specified type. It returns null if no Object matches the type.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
    public static Object FindObjectOfType(System.Type type)
    {
      Object[] objectsOfType = Object.FindObjectsOfType(type);
      return objectsOfType.Length > 0 ? objectsOfType[0] : (Object) null;
    }

    /// <summary>
    ///   <para>Returns the name of the GameObject.</para>
    /// </summary>
    /// <returns>
    ///   <para>The name returned by ToString.</para>
    /// </returns>
    public override string ToString() => Object.ToString(this);

    public static bool operator ==(Object x, Object y) => Object.CompareBaseObjects(x, y);

    public static bool operator !=(Object x, Object y) => !Object.CompareBaseObjects(x, y);

    [NativeMethod(IsFreeFunction = true, IsThreadSafe = true, Name = "Object::GetOffsetOfInstanceIdMember")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetOffsetOfInstanceIDInCPlusPlusObject();

    [NativeMethod(IsFreeFunction = true, IsThreadSafe = true, Name = "CurrentThreadIsMainThread")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool CurrentThreadIsMainThread();

    [FreeFunction("CloneObject")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Object Internal_CloneSingle(Object data);

    [FreeFunction("CloneObject")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Object Internal_CloneSingleWithParent(
      Object data,
      Transform parent,
      bool worldPositionStays);

    [FreeFunction("InstantiateObject")]
    private static Object Internal_InstantiateSingle(
      Object data,
      Vector3 pos,
      Quaternion rot)
    {
      return Object.Internal_InstantiateSingle_Injected(data, ref pos, ref rot);
    }

    [FreeFunction("InstantiateObject")]
    private static Object Internal_InstantiateSingleWithParent(
      Object data,
      Transform parent,
      Vector3 pos,
      Quaternion rot)
    {
      return Object.Internal_InstantiateSingleWithParent_Injected(data, parent, ref pos, ref rot);
    }

    [FreeFunction("UnityEngineObjectBindings::ToString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string ToString(Object obj);

    [FreeFunction("UnityEngineObjectBindings::GetName")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string GetName(Object obj);

    [FreeFunction("UnityEngineObjectBindings::SetName")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetName(Object obj, string name);

    [NativeMethod(IsFreeFunction = true, IsThreadSafe = true, Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool DoesObjectWithInstanceIDExist(int instanceID);

    [VisibleToOtherModules]
    [FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern Object FindObjectFromInstanceID(int instanceID);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Object Internal_InstantiateSingle_Injected(
      Object data,
      ref Vector3 pos,
      ref Quaternion rot);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Object Internal_InstantiateSingleWithParent_Injected(
      Object data,
      Transform parent,
      ref Vector3 pos,
      ref Quaternion rot);
  }
}
