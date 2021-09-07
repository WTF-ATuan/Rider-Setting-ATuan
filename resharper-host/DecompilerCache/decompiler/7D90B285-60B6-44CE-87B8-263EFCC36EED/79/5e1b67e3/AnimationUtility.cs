// Decompiled with JetBrains decompiler
// Type: UnityEditor.AnimationUtility
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D90B285-60B6-44CE-87B8-263EFCC36EED
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEditor.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Editor utility functions for modifying animation clips.</para>
  /// </summary>
  [NativeHeader("Editor/Src/Animation/AnimationUtility.bindings.h")]
  public class AnimationUtility
  {
    /// <summary>
    ///   <para>Triggered when an animation curve inside an animation clip has been modified.</para>
    /// </summary>
    public static AnimationUtility.OnCurveWasModified onCurveWasModified;

    [RequiredByNativeCode]
    private static void Internal_CallOnCurveWasModified(
      AnimationClip clip,
      EditorCurveBinding binding,
      AnimationUtility.CurveModifiedType type)
    {
      if (AnimationUtility.onCurveWasModified == null)
        return;
      AnimationUtility.onCurveWasModified(clip, binding, type);
    }

    [RequiredByNativeCode]
    private static void Internal_CallAnimationClipAwake(AnimationClip clip)
    {
      if (AnimationUtility.onCurveWasModified == null)
        return;
      AnimationUtility.onCurveWasModified(clip, new EditorCurveBinding(), AnimationUtility.CurveModifiedType.ClipModified);
    }

    /// <summary>
    ///   <para>Returns the array of Animation Clips associated with the GameObject or component.</para>
    /// </summary>
    /// <param name="component"></param>
    /// <param name="gameObject"></param>
    [Obsolete("GetAnimationClips(Animation) is deprecated. Use GetAnimationClips(GameObject) instead.")]
    public static AnimationClip[] GetAnimationClips(Animation component) => AnimationUtility.GetAnimationClipsInAnimationPlayer(component.gameObject);

    /// <summary>
    ///   <para>Returns the array of Animation Clips associated with the GameObject or component.</para>
    /// </summary>
    /// <param name="component"></param>
    /// <param name="gameObject"></param>
    public static AnimationClip[] GetAnimationClips(GameObject gameObject)
    {
      AnimationClip[] animationClipArray = !((UnityEngine.Object) gameObject == (UnityEngine.Object) null) ? AnimationUtility.GetAnimationClipsInAnimationPlayer(gameObject) : throw new ArgumentNullException(nameof (gameObject));
      IAnimationClipSource[] components = gameObject.GetComponents<IAnimationClipSource>();
      if ((uint) components.Length <= 0U)
        return animationClipArray;
      List<AnimationClip> animationClipList = new List<AnimationClip>((IEnumerable<AnimationClip>) animationClipArray);
      for (int index = 0; index < components.Length; ++index)
      {
        List<AnimationClip> results = new List<AnimationClip>();
        components[index].GetAnimationClips(results);
        animationClipList.AddRange((IEnumerable<AnimationClip>) results);
      }
      return animationClipList.ToArray();
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern AnimationClip[] GetAnimationClipsInAnimationPlayer(
      [NotNull] GameObject gameObject);

    /// <summary>
    ///   <para>Sets the array of AnimationClips to be referenced in the Animation component.</para>
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="clips"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAnimationClips([NotNull] Animation animation, AnimationClip[] clips);

    /// <summary>
    ///   <para>Returns all the animatable bindings that a specific game object has.</para>
    /// </summary>
    /// <param name="targetObject"></param>
    /// <param name="root"></param>
    public static EditorCurveBinding[] GetAnimatableBindings(
      GameObject targetObject,
      GameObject root)
    {
      return AnimationUtility.Internal_GetGameObjectAnimatableBindings(targetObject, root);
    }

    internal static EditorCurveBinding[] GetAnimatableBindings(
      ScriptableObject scriptableObject)
    {
      return AnimationUtility.Internal_GetScriptableObjectAnimatableBindings(scriptableObject);
    }

    internal static EditorCurveBinding[] GetAnimationStreamBindings(
      GameObject root)
    {
      return AnimationUtility.Internal_GetAnimationStreamBindings(root);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern EditorCurveBinding[] Internal_GetGameObjectAnimatableBindings(
      [NotNull] GameObject targetObject,
      [NotNull] GameObject root);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern EditorCurveBinding[] Internal_GetScriptableObjectAnimatableBindings(
      [NotNull] ScriptableObject scriptableObject);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern EditorCurveBinding[] Internal_GetAnimationStreamBindings(
      [NotNull] GameObject root);

    public static System.Type GetEditorCurveValueType(
      GameObject root,
      EditorCurveBinding binding)
    {
      return AnimationUtility.Internal_GetGameObjectEditorCurveValueType(root, binding);
    }

    internal static System.Type GetEditorCurveValueType(
      ScriptableObject scriptableObject,
      EditorCurveBinding binding)
    {
      return AnimationUtility.Internal_GetScriptableObjectEditorCurveValueType(scriptableObject, binding);
    }

    private static System.Type Internal_GetGameObjectEditorCurveValueType(
      [NotNull] GameObject root,
      EditorCurveBinding binding)
    {
      return AnimationUtility.Internal_GetGameObjectEditorCurveValueType_Injected(root, ref binding);
    }

    private static System.Type Internal_GetScriptableObjectEditorCurveValueType(
      [NotNull] ScriptableObject scriptableObject,
      EditorCurveBinding binding)
    {
      return AnimationUtility.Internal_GetScriptableObjectEditorCurveValueType_Injected(scriptableObject, ref binding);
    }

    public static bool GetFloatValue([NotNull] GameObject root, EditorCurveBinding binding, out float data) => AnimationUtility.GetFloatValue_Injected(root, ref binding, out data);

    public static bool GetObjectReferenceValue(
      GameObject root,
      EditorCurveBinding binding,
      out UnityEngine.Object data)
    {
      data = AnimationUtility.Internal_GetObjectReferenceValue(root, binding);
      return data != (UnityEngine.Object) null;
    }

    private static UnityEngine.Object Internal_GetObjectReferenceValue(
      [NotNull] GameObject root,
      EditorCurveBinding binding)
    {
      return AnimationUtility.Internal_GetObjectReferenceValue_Injected(root, ref binding);
    }

    /// <summary>
    ///   <para>Returns the animated object that the binding is pointing to.</para>
    /// </summary>
    /// <param name="root"></param>
    /// <param name="binding"></param>
    public static UnityEngine.Object GetAnimatedObject(
      [NotNull] GameObject root,
      EditorCurveBinding binding)
    {
      return AnimationUtility.GetAnimatedObject_Injected(root, ref binding);
    }

    public static System.Type PropertyModificationToEditorCurveBinding(
      PropertyModification modification,
      GameObject gameObject,
      out EditorCurveBinding binding)
    {
      binding = new EditorCurveBinding();
      binding.type = typeof (UnityEngine.Object);
      return modification == null ? (System.Type) null : AnimationUtility.Internal_PropertyModificationToEditorCurveBinding(modification, gameObject, out binding);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern System.Type Internal_PropertyModificationToEditorCurveBinding(
      PropertyModification modification,
      [NotNull] GameObject gameObject,
      out EditorCurveBinding binding);

    internal static PropertyModification EditorCurveBindingToPropertyModification(
      EditorCurveBinding binding,
      [NotNull] GameObject gameObject)
    {
      return AnimationUtility.EditorCurveBindingToPropertyModification_Injected(ref binding, gameObject);
    }

    /// <summary>
    ///   <para>Returns all the float curve bindings currently stored in the clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern EditorCurveBinding[] GetCurveBindings([NotNull] AnimationClip clip);

    /// <summary>
    ///   <para>Returns all the object reference curve bindings currently stored in the clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern EditorCurveBinding[] GetObjectReferenceCurveBindings(
      [NotNull] AnimationClip clip);

    /// <summary>
    ///   <para>Return the object reference curve that the binding is pointing to.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="binding"></param>
    public static ObjectReferenceKeyframe[] GetObjectReferenceCurve(
      [NotNull] AnimationClip clip,
      EditorCurveBinding binding)
    {
      return AnimationUtility.GetObjectReferenceCurve_Injected(clip, ref binding);
    }

    /// <summary>
    ///   <para>Adds, modifies or removes an object reference curve in a given clip.</para>
    /// </summary>
    /// <param name="keyframes">Setting this to null will remove the curve.</param>
    /// <param name="clip"></param>
    /// <param name="binding"></param>
    public static void SetObjectReferenceCurve(
      AnimationClip clip,
      EditorCurveBinding binding,
      ObjectReferenceKeyframe[] keyframes)
    {
      AnimationUtility.Internal_SetObjectReferenceCurve(clip, binding, keyframes, true);
      AnimationUtility.Internal_InvokeOnCurveWasModified(clip, binding, keyframes != null ? AnimationUtility.CurveModifiedType.CurveModified : AnimationUtility.CurveModifiedType.CurveDeleted);
    }

    internal static void SetObjectReferenceCurveNoSync(
      AnimationClip clip,
      EditorCurveBinding binding,
      ObjectReferenceKeyframe[] keyframes)
    {
      AnimationUtility.Internal_SetObjectReferenceCurve(clip, binding, keyframes, false);
      AnimationUtility.Internal_InvokeOnCurveWasModified(clip, binding, keyframes != null ? AnimationUtility.CurveModifiedType.CurveModified : AnimationUtility.CurveModifiedType.CurveDeleted);
    }

    private static void Internal_SetObjectReferenceCurve(
      [NotNull] AnimationClip clip,
      EditorCurveBinding binding,
      ObjectReferenceKeyframe[] keyframes,
      bool updateMuscleClip)
    {
      AnimationUtility.Internal_SetObjectReferenceCurve_Injected(clip, ref binding, keyframes, updateMuscleClip);
    }

    /// <summary>
    ///   <para>Return the float curve that the binding is pointing to.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="relativePath"></param>
    /// <param name="type"></param>
    /// <param name="propertyName"></param>
    /// <param name="binding"></param>
    public static AnimationCurve GetEditorCurve(
      [NotNull] AnimationClip clip,
      EditorCurveBinding binding)
    {
      return AnimationUtility.GetEditorCurve_Injected(clip, ref binding);
    }

    /// <summary>
    ///   <para>Adds, modifies or removes an editor float curve in a given clip.</para>
    /// </summary>
    /// <param name="clip">The animation clip to which the curve will be added.</param>
    /// <param name="binding">The bindings which defines the path and the property of the curve.</param>
    /// <param name="curve">The curve to add. Setting this to null will remove the curve.</param>
    public static void SetEditorCurve(
      AnimationClip clip,
      EditorCurveBinding binding,
      AnimationCurve curve)
    {
      AnimationUtility.Internal_SetEditorCurve(clip, binding, curve, true);
      AnimationUtility.Internal_InvokeOnCurveWasModified(clip, binding, curve != null ? AnimationUtility.CurveModifiedType.CurveModified : AnimationUtility.CurveModifiedType.CurveDeleted);
    }

    internal static void SetEditorCurveNoSync(
      AnimationClip clip,
      EditorCurveBinding binding,
      AnimationCurve curve)
    {
      AnimationUtility.Internal_SetEditorCurve(clip, binding, curve, false);
      AnimationUtility.Internal_InvokeOnCurveWasModified(clip, binding, curve != null ? AnimationUtility.CurveModifiedType.CurveModified : AnimationUtility.CurveModifiedType.CurveDeleted);
    }

    private static void Internal_SetEditorCurve(
      [NotNull] AnimationClip clip,
      EditorCurveBinding binding,
      AnimationCurve curve,
      bool syncEditorCurves)
    {
      AnimationUtility.Internal_SetEditorCurve_Injected(clip, ref binding, curve, syncEditorCurves);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void SyncEditorCurves([NotNull] AnimationClip clip);

    private static void Internal_InvokeOnCurveWasModified(
      AnimationClip clip,
      EditorCurveBinding binding,
      AnimationUtility.CurveModifiedType type)
    {
      if (AnimationUtility.onCurveWasModified == null)
        return;
      AnimationUtility.onCurveWasModified(clip, binding, type);
    }

    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void UpdateTangentsFromModeSurrounding([NotNull] AnimationCurve curve, int index);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void UpdateTangentsFromMode([NotNull] AnimationCurve curve);

    /// <summary>
    ///   <para>Retrieve the left tangent mode of the keyframe at specified index.</para>
    /// </summary>
    /// <param name="curve">Curve to query.</param>
    /// <param name="index">Keyframe index.</param>
    /// <returns>
    ///   <para>Tangent mode at specified index.</para>
    /// </returns>
    [NativeThrows]
    [ThreadSafe]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern AnimationUtility.TangentMode GetKeyLeftTangentMode(
      [NotNull] AnimationCurve curve,
      int index);

    /// <summary>
    ///   <para>Retrieve the right tangent mode of the keyframe at specified index.</para>
    /// </summary>
    /// <param name="curve">Curve to query.</param>
    /// <param name="index">Keyframe index.</param>
    /// <returns>
    ///   <para>Tangent mode at specified index.</para>
    /// </returns>
    [NativeThrows]
    [ThreadSafe]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern AnimationUtility.TangentMode GetKeyRightTangentMode(
      [NotNull] AnimationCurve curve,
      int index);

    /// <summary>
    ///   <para>Retrieve the specified keyframe broken tangent flag.</para>
    /// </summary>
    /// <param name="curve">Curve to query.</param>
    /// <param name="index">Keyframe index.</param>
    /// <returns>
    ///   <para>Broken flag at specified index.</para>
    /// </returns>
    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool GetKeyBroken([NotNull] AnimationCurve curve, int index);

    [NativeThrows]
    [ThreadSafe]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetKeyLeftTangentMode(
      [NotNull] AnimationCurve curve,
      int index,
      AnimationUtility.TangentMode tangentMode);

    [ThreadSafe]
    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetKeyRightTangentMode(
      [NotNull] AnimationCurve curve,
      int index,
      AnimationUtility.TangentMode tangentMode);

    /// <summary>
    ///   <para>Change the specified keyframe broken tangent flag.</para>
    /// </summary>
    /// <param name="curve">The curve to modify.</param>
    /// <param name="index">Keyframe index.</param>
    /// <param name="broken">Broken flag.</param>
    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetKeyBroken([NotNull] AnimationCurve curve, int index, bool broken);

    internal static AnimationUtility.TangentMode GetKeyLeftTangentMode(Keyframe key) => AnimationUtility.Internal_GetKeyLeftTangentMode(key);

    internal static AnimationUtility.TangentMode GetKeyRightTangentMode(Keyframe key) => AnimationUtility.Internal_GetKeyRightTangentMode(key);

    internal static bool GetKeyBroken(Keyframe key) => AnimationUtility.Internal_GetKeyBroken(key);

    private static AnimationUtility.TangentMode Internal_GetKeyLeftTangentMode(
      Keyframe key)
    {
      return AnimationUtility.Internal_GetKeyLeftTangentMode_Injected(ref key);
    }

    private static AnimationUtility.TangentMode Internal_GetKeyRightTangentMode(
      Keyframe key)
    {
      return AnimationUtility.Internal_GetKeyRightTangentMode_Injected(ref key);
    }

    private static bool Internal_GetKeyBroken(Keyframe key) => AnimationUtility.Internal_GetKeyBroken_Injected(ref key);

    internal static void SetKeyLeftTangentMode(
      ref Keyframe key,
      AnimationUtility.TangentMode tangentMode)
    {
      AnimationUtility.Internal_SetKeyLeftTangentMode(ref key, tangentMode);
    }

    internal static void SetKeyRightTangentMode(
      ref Keyframe key,
      AnimationUtility.TangentMode tangentMode)
    {
      AnimationUtility.Internal_SetKeyRightTangentMode(ref key, tangentMode);
    }

    internal static void SetKeyBroken(ref Keyframe key, bool broken) => AnimationUtility.Internal_SetKeyBroken(ref key, broken);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetKeyLeftTangentMode(
      ref Keyframe key,
      AnimationUtility.TangentMode tangentMode);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetKeyRightTangentMode(
      ref Keyframe key,
      AnimationUtility.TangentMode tangentMode);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetKeyBroken(ref Keyframe key, bool broken);

    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern int AddInbetweenKey(AnimationCurve curve, float time);

    /// <summary>
    ///   <para>Retrieves all curves from a specific animation clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="includeCurveData"></param>
    [Obsolete("GetAllCurves is deprecated. Use GetCurveBindings and GetObjectReferenceCurveBindings instead.")]
    public static AnimationClipCurveData[] GetAllCurves(AnimationClip clip)
    {
      bool includeCurveData = true;
      return AnimationUtility.GetAllCurves(clip, includeCurveData);
    }

    /// <summary>
    ///   <para>Retrieves all curves from a specific animation clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="includeCurveData"></param>
    [Obsolete("GetAllCurves is deprecated. Use GetCurveBindings and GetObjectReferenceCurveBindings instead.")]
    public static AnimationClipCurveData[] GetAllCurves(
      AnimationClip clip,
      [DefaultValue("true")] bool includeCurveData)
    {
      EditorCurveBinding[] curveBindings = AnimationUtility.GetCurveBindings(clip);
      AnimationClipCurveData[] animationClipCurveDataArray = new AnimationClipCurveData[curveBindings.Length];
      for (int index = 0; index < animationClipCurveDataArray.Length; ++index)
      {
        animationClipCurveDataArray[index] = new AnimationClipCurveData(curveBindings[index]);
        if (includeCurveData)
          animationClipCurveDataArray[index].curve = AnimationUtility.GetEditorCurve(clip, curveBindings[index]);
      }
      return animationClipCurveDataArray;
    }

    [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
    public static bool GetFloatValue(
      GameObject root,
      string relativePath,
      System.Type type,
      string propertyName,
      out float data)
    {
      return AnimationUtility.GetFloatValue(root, EditorCurveBinding.FloatCurve(relativePath, type, propertyName), out data);
    }

    [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
    public static void SetEditorCurve(
      AnimationClip clip,
      string relativePath,
      System.Type type,
      string propertyName,
      AnimationCurve curve)
    {
      AnimationUtility.SetEditorCurve(clip, EditorCurveBinding.FloatCurve(relativePath, type, propertyName), curve);
    }

    /// <summary>
    ///   <para>Return the float curve that the binding is pointing to.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="relativePath"></param>
    /// <param name="type"></param>
    /// <param name="propertyName"></param>
    /// <param name="binding"></param>
    [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
    public static AnimationCurve GetEditorCurve(
      AnimationClip clip,
      string relativePath,
      System.Type type,
      string propertyName)
    {
      return AnimationUtility.GetEditorCurve(clip, EditorCurveBinding.FloatCurve(relativePath, type, propertyName));
    }

    /// <summary>
    ///   <para>Retrieves all animation events associated with the animation clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern AnimationEvent[] GetAnimationEvents([NotNull] AnimationClip clip);

    /// <summary>
    ///   <para>Replaces all animation events in the animation clip.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="events"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAnimationEvents([NotNull] AnimationClip clip, [NotNull] AnimationEvent[] events);

    /// <summary>
    ///   <para>Calculates path from root transform to target transform.</para>
    /// </summary>
    /// <param name="targetTransform"></param>
    /// <param name="root"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string CalculateTransformPath([NotNull] Transform targetTransform, Transform root);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern AnimationClipSettings GetAnimationClipSettings(
      [NotNull] AnimationClip clip);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAnimationClipSettings(
      [NotNull] AnimationClip clip,
      AnimationClipSettings srcClipInfo);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void SetAnimationClipSettingsNoDirty(
      [NotNull] AnimationClip clip,
      AnimationClipSettings srcClipInfo);

    /// <summary>
    ///   <para>Set the additive reference pose from referenceClip at time for animation clip clip.</para>
    /// </summary>
    /// <param name="clip">The animation clip to be used.</param>
    /// <param name="referenceClip">The animation clip containing the reference pose.</param>
    /// <param name="time">Time that defines the reference pose in referenceClip.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetAdditiveReferencePose(
      AnimationClip clip,
      AnimationClip referenceClip,
      float time);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool IsValidOptimizedPolynomialCurve(AnimationCurve curve);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ConstrainToPolynomialCurve(AnimationCurve curve);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern int GetMaxNumPolynomialSegmentsSupported();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern AnimationUtility.PolynomialValid IsValidPolynomialCurve(
      AnimationCurve curve);

    internal static AnimationClipStats GetAnimationClipStats(AnimationClip clip)
    {
      AnimationClipStats ret;
      AnimationUtility.GetAnimationClipStats_Injected(clip, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Returns whether the animation clip is set to generate root motion curves.</para>
    /// </summary>
    /// <param name="clip">AnimationClip to query.</param>
    [Obsolete("This is not used anymore.  Root motion curves are automatically generated if applyRootMotion is enabled on Animator component.")]
    public static bool GetGenerateMotionCurves(AnimationClip clip) => true;

    /// <summary>
    ///   <para>Sets whether the animation clip generates root motion curves.</para>
    /// </summary>
    /// <param name="clip">AnimationClip to change.</param>
    /// <param name="value">Set to true to enable generation of root motion curves.</param>
    [Obsolete("This is not used anymore.  Root motion curves are automatically generated if applyRootMotion is enabled on Animator component.")]
    public static void SetGenerateMotionCurves(AnimationClip clip, bool value)
    {
    }

    [Obsolete("Use AnimationClip.hasGenericRootTransform instead.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool HasGenericRootTransform(AnimationClip clip);

    [Obsolete("Use AnimationClip.hasMotionFloatCurves instead.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool HasMotionFloatCurves(AnimationClip clip);

    [Obsolete("Use AnimationClip.hasMotionCurves instead.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool HasMotionCurves(AnimationClip clip);

    [Obsolete("Use AnimationClip.hasRootCurves instead.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool HasRootCurves(AnimationClip clip);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool AmbiguousBinding(string path, int classID, Transform root);

    internal static Vector3 GetClosestEuler(
      Quaternion q,
      Vector3 eulerHint,
      RotationOrder rotationOrder)
    {
      Vector3 ret;
      AnimationUtility.GetClosestEuler_Injected(ref q, ref eulerHint, rotationOrder, out ret);
      return ret;
    }

    [NativeHeader("Modules/Animation/AnimationUtility.h")]
    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void SampleEulerHint(
      [NotNull] GameObject go,
      [NotNull] AnimationClip clip,
      float inTime,
      WrapMode wrapMode);

    [Obsolete("Use AnimationMode.InAnimationMode instead.")]
    public static bool InAnimationMode() => AnimationMode.InAnimationMode();

    [Obsolete("Use AnimationMode.StartAnimationmode instead.")]
    public static void StartAnimationMode(UnityEngine.Object[] objects)
    {
      Debug.LogWarning((object) "AnimationUtility.StartAnimationMode is deprecated. Use AnimationMode.StartAnimationMode with the new APIs. The objects passed to this function will no longer be reverted automatically. See AnimationMode.AddPropertyModification");
      AnimationMode.StartAnimationMode();
    }

    [Obsolete("Use AnimationMode.StopAnimationMode instead.")]
    public static void StopAnimationMode() => AnimationMode.StopAnimationMode();

    [Obsolete("SetAnimationType is no longer supported.")]
    public static void SetAnimationType(AnimationClip clip, ModelImporterAnimationType type)
    {
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern System.Type Internal_GetGameObjectEditorCurveValueType_Injected(
      GameObject root,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern System.Type Internal_GetScriptableObjectEditorCurveValueType_Injected(
      ScriptableObject scriptableObject,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool GetFloatValue_Injected(
      GameObject root,
      ref EditorCurveBinding binding,
      out float data);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern UnityEngine.Object Internal_GetObjectReferenceValue_Injected(
      GameObject root,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern UnityEngine.Object GetAnimatedObject_Injected(
      GameObject root,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern PropertyModification EditorCurveBindingToPropertyModification_Injected(
      ref EditorCurveBinding binding,
      GameObject gameObject);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern ObjectReferenceKeyframe[] GetObjectReferenceCurve_Injected(
      AnimationClip clip,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetObjectReferenceCurve_Injected(
      AnimationClip clip,
      ref EditorCurveBinding binding,
      ObjectReferenceKeyframe[] keyframes,
      bool updateMuscleClip);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AnimationCurve GetEditorCurve_Injected(
      AnimationClip clip,
      ref EditorCurveBinding binding);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetEditorCurve_Injected(
      AnimationClip clip,
      ref EditorCurveBinding binding,
      AnimationCurve curve,
      bool syncEditorCurves);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AnimationUtility.TangentMode Internal_GetKeyLeftTangentMode_Injected(
      ref Keyframe key);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AnimationUtility.TangentMode Internal_GetKeyRightTangentMode_Injected(
      ref Keyframe key);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool Internal_GetKeyBroken_Injected(ref Keyframe key);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetAnimationClipStats_Injected(
      AnimationClip clip,
      out AnimationClipStats ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetClosestEuler_Injected(
      ref Quaternion q,
      ref Vector3 eulerHint,
      RotationOrder rotationOrder,
      out Vector3 ret);

    /// <summary>
    ///   <para>Describes the type of modification that caused OnCurveWasModified to fire.</para>
    /// </summary>
    public enum CurveModifiedType
    {
      CurveDeleted,
      CurveModified,
      ClipModified,
    }

    /// <summary>
    ///   <para>Tangent constraints on Keyframe.</para>
    /// </summary>
    public enum TangentMode
    {
      /// <summary>
      ///   <para>The tangent can be freely set by dragging the tangent handle.</para>
      /// </summary>
      Free,
      /// <summary>
      ///   <para>The tangents are automatically set to make the curve go smoothly through the key.</para>
      /// </summary>
      Auto,
      /// <summary>
      ///   <para>The tangent points towards the neighboring key.</para>
      /// </summary>
      Linear,
      /// <summary>
      ///   <para>The curve retains a constant value between two keys.</para>
      /// </summary>
      Constant,
      /// <summary>
      ///   <para>The tangents are automatically set to make the curve go smoothly through the key.</para>
      /// </summary>
      ClampedAuto,
    }

    internal enum PolynomialValid
    {
      Valid,
      InvalidPreWrapMode,
      InvalidPostWrapMode,
      TooManySegments,
    }

    /// <summary>
    ///   <para>Triggered when an animation curve inside an animation clip has been modified.</para>
    /// </summary>
    /// <param name="clip"></param>
    /// <param name="binding"></param>
    /// <param name="type"></param>
    public delegate void OnCurveWasModified(
      AnimationClip clip,
      EditorCurveBinding binding,
      AnimationUtility.CurveModifiedType type);
  }
}
