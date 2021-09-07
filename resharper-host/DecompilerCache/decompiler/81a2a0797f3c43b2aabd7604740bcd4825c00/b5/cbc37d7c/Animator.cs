// Decompiled with JetBrains decompiler
// Type: UnityEngine.Animator
// Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81A2A079-7F3C-43B2-AABD-7604740BCD48
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Interface to control the Mecanim animation system.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.html">External documentation for `Animator`</a></footer>
  [NativeHeader("Modules/Animation/Animator.h")]
  [NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
  [UsedByNativeCode]
  [NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
  public class Animator : Behaviour
  {
    /// <summary>
    ///   <para>Gets the list of AnimatorClipInfo currently played by the current state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer's index.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetCurrentAnimationClipState.html">External documentation for `Animator.GetCurrentAnimationClipState`</a></footer>
    [Obsolete("GetCurrentAnimationClipState is obsolete. Use GetCurrentAnimatorClipInfo instead (UnityUpgradable) -> GetCurrentAnimatorClipInfo(*)", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public AnimationInfo[] GetCurrentAnimationClipState(int layerIndex) => (AnimationInfo[]) null;

    /// <summary>
    ///   <para>Gets the list of AnimatorClipInfo currently played by the next state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer's index.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetNextAnimationClipState.html">External documentation for `Animator.GetNextAnimationClipState`</a></footer>
    [Obsolete("GetNextAnimationClipState is obsolete. Use GetNextAnimatorClipInfo instead (UnityUpgradable) -> GetNextAnimatorClipInfo(*)", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public AnimationInfo[] GetNextAnimationClipState(int layerIndex) => (AnimationInfo[]) null;

    [Obsolete("Stop is obsolete. Use Animator.enabled = false instead", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void Stop()
    {
    }

    /// <summary>
    ///   <para>Returns true if the current rig is optimizable with AnimatorUtility.OptimizeTransformHierarchy.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-isOptimizable.html">External documentation for `Animator.isOptimizable`</a></footer>
    public extern bool isOptimizable { [NativeMethod("IsOptimizable"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns true if the current rig is humanoid, false if it is generic.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-isHuman.html">External documentation for `Animator.isHuman`</a></footer>
    public extern bool isHuman { [NativeMethod("IsHuman"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns true if the current rig has root motion.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-hasRootMotion.html">External documentation for `Animator.hasRootMotion`</a></footer>
    public extern bool hasRootMotion { [NativeMethod("HasRootMotion"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    internal extern bool isRootPositionOrRotationControlledByCurves { [NativeMethod("IsRootTranslationOrRotationControllerByCurves"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns the scale of the current Avatar for a humanoid rig, (1 by default if the rig is generic).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-humanScale.html">External documentation for `Animator.humanScale`</a></footer>
    public extern float humanScale { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns whether the animator is initialized successfully.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-isInitialized.html">External documentation for `Animator.isInitialized`</a></footer>
    public extern bool isInitialized { [NativeMethod("IsInitialized"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns the value of the given float parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetFloat.html">External documentation for `Animator.GetFloat`</a></footer>
    public float GetFloat(string name) => this.GetFloatString(name);

    /// <summary>
    ///   <para>Returns the value of the given float parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetFloat.html">External documentation for `Animator.GetFloat`</a></footer>
    public float GetFloat(int id) => this.GetFloatID(id);

    /// <summary>
    ///   <para>Send float values to the Animator to affect transitions.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <param name="dampTime">The damper total time.</param>
    /// <param name="deltaTime">The delta time to give to the damper.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetFloat.html">External documentation for `Animator.SetFloat`</a></footer>
    public void SetFloat(string name, float value) => this.SetFloatString(name, value);

    /// <summary>
    ///   <para>Send float values to the Animator to affect transitions.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <param name="dampTime">The damper total time.</param>
    /// <param name="deltaTime">The delta time to give to the damper.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetFloat.html">External documentation for `Animator.SetFloat`</a></footer>
    public void SetFloat(string name, float value, float dampTime, float deltaTime) => this.SetFloatStringDamp(name, value, dampTime, deltaTime);

    /// <summary>
    ///   <para>Send float values to the Animator to affect transitions.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <param name="dampTime">The damper total time.</param>
    /// <param name="deltaTime">The delta time to give to the damper.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetFloat.html">External documentation for `Animator.SetFloat`</a></footer>
    public void SetFloat(int id, float value) => this.SetFloatID(id, value);

    /// <summary>
    ///   <para>Send float values to the Animator to affect transitions.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <param name="dampTime">The damper total time.</param>
    /// <param name="deltaTime">The delta time to give to the damper.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetFloat.html">External documentation for `Animator.SetFloat`</a></footer>
    public void SetFloat(int id, float value, float dampTime, float deltaTime) => this.SetFloatIDDamp(id, value, dampTime, deltaTime);

    /// <summary>
    ///   <para>Returns the value of the given boolean parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetBool.html">External documentation for `Animator.GetBool`</a></footer>
    public bool GetBool(string name) => this.GetBoolString(name);

    /// <summary>
    ///   <para>Returns the value of the given boolean parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetBool.html">External documentation for `Animator.GetBool`</a></footer>
    public bool GetBool(int id) => this.GetBoolID(id);

    /// <summary>
    ///   <para>Sets the value of the given boolean parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetBool.html">External documentation for `Animator.SetBool`</a></footer>
    public void SetBool(string name, bool value) => this.SetBoolString(name, value);

    /// <summary>
    ///   <para>Sets the value of the given boolean parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetBool.html">External documentation for `Animator.SetBool`</a></footer>
    public void SetBool(int id, bool value) => this.SetBoolID(id, value);

    /// <summary>
    ///   <para>Returns the value of the given integer parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetInteger.html">External documentation for `Animator.GetInteger`</a></footer>
    public int GetInteger(string name) => this.GetIntegerString(name);

    /// <summary>
    ///   <para>Returns the value of the given integer parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>The value of the parameter.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetInteger.html">External documentation for `Animator.GetInteger`</a></footer>
    public int GetInteger(int id) => this.GetIntegerID(id);

    /// <summary>
    ///   <para>Sets the value of the given integer parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetInteger.html">External documentation for `Animator.SetInteger`</a></footer>
    public void SetInteger(string name, int value) => this.SetIntegerString(name, value);

    /// <summary>
    ///   <para>Sets the value of the given integer parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <param name="value">The new parameter value.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetInteger.html">External documentation for `Animator.SetInteger`</a></footer>
    public void SetInteger(int id, int value) => this.SetIntegerID(id, value);

    /// <summary>
    ///   <para>Sets the value of the given trigger parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetTrigger.html">External documentation for `Animator.SetTrigger`</a></footer>
    public void SetTrigger(string name) => this.SetTriggerString(name);

    /// <summary>
    ///   <para>Sets the value of the given trigger parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetTrigger.html">External documentation for `Animator.SetTrigger`</a></footer>
    public void SetTrigger(int id) => this.SetTriggerID(id);

    /// <summary>
    ///   <para>Resets the value of the given trigger parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.ResetTrigger.html">External documentation for `Animator.ResetTrigger`</a></footer>
    public void ResetTrigger(string name) => this.ResetTriggerString(name);

    /// <summary>
    ///   <para>Resets the value of the given trigger parameter.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.ResetTrigger.html">External documentation for `Animator.ResetTrigger`</a></footer>
    public void ResetTrigger(int id) => this.ResetTriggerID(id);

    /// <summary>
    ///   <para>Returns true if the parameter is controlled by a curve, false otherwise.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>True if the parameter is controlled by a curve, false otherwise.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.IsParameterControlledByCurve.html">External documentation for `Animator.IsParameterControlledByCurve`</a></footer>
    public bool IsParameterControlledByCurve(string name) => this.IsParameterControlledByCurveString(name);

    /// <summary>
    ///   <para>Returns true if the parameter is controlled by a curve, false otherwise.</para>
    /// </summary>
    /// <param name="name">The parameter name.</param>
    /// <param name="id">The parameter ID.</param>
    /// <returns>
    ///   <para>True if the parameter is controlled by a curve, false otherwise.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.IsParameterControlledByCurve.html">External documentation for `Animator.IsParameterControlledByCurve`</a></footer>
    public bool IsParameterControlledByCurve(int id) => this.IsParameterControlledByCurveID(id);

    /// <summary>
    ///   <para>Gets the avatar delta position for the last evaluated frame.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-deltaPosition.html">External documentation for `Animator.deltaPosition`</a></footer>
    public Vector3 deltaPosition
    {
      get
      {
        Vector3 ret;
        this.get_deltaPosition_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Gets the avatar delta rotation for the last evaluated frame.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-deltaRotation.html">External documentation for `Animator.deltaRotation`</a></footer>
    public Quaternion deltaRotation
    {
      get
      {
        Quaternion ret;
        this.get_deltaRotation_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Gets the avatar velocity  for the last evaluated frame.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-velocity.html">External documentation for `Animator.velocity`</a></footer>
    public Vector3 velocity
    {
      get
      {
        Vector3 ret;
        this.get_velocity_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Gets the avatar angular velocity for the last evaluated frame.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-angularVelocity.html">External documentation for `Animator.angularVelocity`</a></footer>
    public Vector3 angularVelocity
    {
      get
      {
        Vector3 ret;
        this.get_angularVelocity_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>The root position, the position of the game object.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-rootPosition.html">External documentation for `Animator.rootPosition`</a></footer>
    public Vector3 rootPosition
    {
      [NativeMethod("GetAvatarPosition")] get
      {
        Vector3 ret;
        this.get_rootPosition_Injected(out ret);
        return ret;
      }
      [NativeMethod("SetAvatarPosition")] set => this.set_rootPosition_Injected(ref value);
    }

    /// <summary>
    ///   <para>The root rotation, the rotation of the game object.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-rootRotation.html">External documentation for `Animator.rootRotation`</a></footer>
    public Quaternion rootRotation
    {
      [NativeMethod("GetAvatarRotation")] get
      {
        Quaternion ret;
        this.get_rootRotation_Injected(out ret);
        return ret;
      }
      [NativeMethod("SetAvatarRotation")] set => this.set_rootRotation_Injected(ref value);
    }

    /// <summary>
    ///   <para>Should root motion be applied?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-applyRootMotion.html">External documentation for `Animator.applyRootMotion`</a></footer>
    public extern bool applyRootMotion { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>When linearVelocityBlending is set to true, the root motion velocity and angular velocity will be blended linearly.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-linearVelocityBlending.html">External documentation for `Animator.linearVelocityBlending`</a></footer>
    [Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
    public extern bool linearVelocityBlending { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>When turned on, animations will be executed in the physics loop. This is only useful in conjunction with kinematic rigidbodies.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-animatePhysics.html">External documentation for `Animator.animatePhysics`</a></footer>
    [Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
    public bool animatePhysics
    {
      get => this.updateMode == AnimatorUpdateMode.AnimatePhysics;
      set => this.updateMode = value ? AnimatorUpdateMode.AnimatePhysics : AnimatorUpdateMode.Normal;
    }

    /// <summary>
    ///   <para>Specifies the update mode of the Animator.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-updateMode.html">External documentation for `Animator.updateMode`</a></footer>
    public extern AnimatorUpdateMode updateMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns true if the object has a transform hierarchy.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-hasTransformHierarchy.html">External documentation for `Animator.hasTransformHierarchy`</a></footer>
    public extern bool hasTransformHierarchy { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    internal extern bool allowConstantClipSamplingOptimization { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The current gravity weight based on current animations that are played.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-gravityWeight.html">External documentation for `Animator.gravityWeight`</a></footer>
    public extern float gravityWeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The position of the body center of mass.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-bodyPosition.html">External documentation for `Animator.bodyPosition`</a></footer>
    public Vector3 bodyPosition
    {
      get
      {
        this.CheckIfInIKPass();
        return this.bodyPositionInternal;
      }
      set
      {
        this.CheckIfInIKPass();
        this.bodyPositionInternal = value;
      }
    }

    internal Vector3 bodyPositionInternal
    {
      [NativeMethod("GetBodyPosition")] get
      {
        Vector3 ret;
        this.get_bodyPositionInternal_Injected(out ret);
        return ret;
      }
      [NativeMethod("SetBodyPosition")] set => this.set_bodyPositionInternal_Injected(ref value);
    }

    /// <summary>
    ///   <para>The rotation of the body center of mass.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-bodyRotation.html">External documentation for `Animator.bodyRotation`</a></footer>
    public Quaternion bodyRotation
    {
      get
      {
        this.CheckIfInIKPass();
        return this.bodyRotationInternal;
      }
      set
      {
        this.CheckIfInIKPass();
        this.bodyRotationInternal = value;
      }
    }

    internal Quaternion bodyRotationInternal
    {
      [NativeMethod("GetBodyRotation")] get
      {
        Quaternion ret;
        this.get_bodyRotationInternal_Injected(out ret);
        return ret;
      }
      [NativeMethod("SetBodyRotation")] set => this.set_bodyRotationInternal_Injected(ref value);
    }

    /// <summary>
    ///   <para>Gets the position of an IK goal.</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is queried.</param>
    /// <returns>
    ///   <para>Return the current position of this IK goal in world space.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKPosition.html">External documentation for `Animator.GetIKPosition`</a></footer>
    public Vector3 GetIKPosition(AvatarIKGoal goal)
    {
      this.CheckIfInIKPass();
      return this.GetGoalPosition(goal);
    }

    private Vector3 GetGoalPosition(AvatarIKGoal goal)
    {
      Vector3 ret;
      this.GetGoalPosition_Injected(goal, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Sets the position of an IK goal.</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is set.</param>
    /// <param name="goalPosition">The position in world space.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKPosition.html">External documentation for `Animator.SetIKPosition`</a></footer>
    public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
    {
      this.CheckIfInIKPass();
      this.SetGoalPosition(goal, goalPosition);
    }

    private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) => this.SetGoalPosition_Injected(goal, ref goalPosition);

    /// <summary>
    ///   <para>Gets the rotation of an IK goal.</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is is queried.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKRotation.html">External documentation for `Animator.GetIKRotation`</a></footer>
    public Quaternion GetIKRotation(AvatarIKGoal goal)
    {
      this.CheckIfInIKPass();
      return this.GetGoalRotation(goal);
    }

    private Quaternion GetGoalRotation(AvatarIKGoal goal)
    {
      Quaternion ret;
      this.GetGoalRotation_Injected(goal, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Sets the rotation of an IK goal.</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is set.</param>
    /// <param name="goalRotation">The rotation in world space.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKRotation.html">External documentation for `Animator.SetIKRotation`</a></footer>
    public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
    {
      this.CheckIfInIKPass();
      this.SetGoalRotation(goal, goalRotation);
    }

    private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) => this.SetGoalRotation_Injected(goal, ref goalRotation);

    /// <summary>
    ///   <para>Gets the translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal).</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is queried.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKPositionWeight.html">External documentation for `Animator.GetIKPositionWeight`</a></footer>
    public float GetIKPositionWeight(AvatarIKGoal goal)
    {
      this.CheckIfInIKPass();
      return this.GetGoalWeightPosition(goal);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetGoalWeightPosition(AvatarIKGoal goal);

    /// <summary>
    ///   <para>Sets the translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal).</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is set.</param>
    /// <param name="value">The translative weight.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKPositionWeight.html">External documentation for `Animator.SetIKPositionWeight`</a></footer>
    public void SetIKPositionWeight(AvatarIKGoal goal, float value)
    {
      this.CheckIfInIKPass();
      this.SetGoalWeightPosition(goal, value);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetGoalWeightPosition(AvatarIKGoal goal, float value);

    /// <summary>
    ///   <para>Gets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal).</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is queried.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKRotationWeight.html">External documentation for `Animator.GetIKRotationWeight`</a></footer>
    public float GetIKRotationWeight(AvatarIKGoal goal)
    {
      this.CheckIfInIKPass();
      return this.GetGoalWeightRotation(goal);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetGoalWeightRotation(AvatarIKGoal goal);

    /// <summary>
    ///   <para>Sets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal).</para>
    /// </summary>
    /// <param name="goal">The AvatarIKGoal that is set.</param>
    /// <param name="value">The rotational weight.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKRotationWeight.html">External documentation for `Animator.SetIKRotationWeight`</a></footer>
    public void SetIKRotationWeight(AvatarIKGoal goal, float value)
    {
      this.CheckIfInIKPass();
      this.SetGoalWeightRotation(goal, value);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetGoalWeightRotation(AvatarIKGoal goal, float value);

    /// <summary>
    ///   <para>Gets the position of an IK hint.</para>
    /// </summary>
    /// <param name="hint">The AvatarIKHint that is queried.</param>
    /// <returns>
    ///   <para>Return the current position of this IK hint in world space.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKHintPosition.html">External documentation for `Animator.GetIKHintPosition`</a></footer>
    public Vector3 GetIKHintPosition(AvatarIKHint hint)
    {
      this.CheckIfInIKPass();
      return this.GetHintPosition(hint);
    }

    private Vector3 GetHintPosition(AvatarIKHint hint)
    {
      Vector3 ret;
      this.GetHintPosition_Injected(hint, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Sets the position of an IK hint.</para>
    /// </summary>
    /// <param name="hint">The AvatarIKHint that is set.</param>
    /// <param name="hintPosition">The position in world space.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKHintPosition.html">External documentation for `Animator.SetIKHintPosition`</a></footer>
    public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
    {
      this.CheckIfInIKPass();
      this.SetHintPosition(hint, hintPosition);
    }

    private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) => this.SetHintPosition_Injected(hint, ref hintPosition);

    /// <summary>
    ///   <para>Gets the translative weight of an IK Hint (0 = at the original animation before IK, 1 = at the hint).</para>
    /// </summary>
    /// <param name="hint">The AvatarIKHint that is queried.</param>
    /// <returns>
    ///   <para>Return translative weight.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetIKHintPositionWeight.html">External documentation for `Animator.GetIKHintPositionWeight`</a></footer>
    public float GetIKHintPositionWeight(AvatarIKHint hint)
    {
      this.CheckIfInIKPass();
      return this.GetHintWeightPosition(hint);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetHintWeightPosition(AvatarIKHint hint);

    /// <summary>
    ///   <para>Sets the translative weight of an IK hint (0 = at the original animation before IK, 1 = at the hint).</para>
    /// </summary>
    /// <param name="hint">The AvatarIKHint that is set.</param>
    /// <param name="value">The translative weight.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetIKHintPositionWeight.html">External documentation for `Animator.SetIKHintPositionWeight`</a></footer>
    public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
    {
      this.CheckIfInIKPass();
      this.SetHintWeightPosition(hint, value);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetHintWeightPosition(AvatarIKHint hint, float value);

    /// <summary>
    ///   <para>Sets the look at position.</para>
    /// </summary>
    /// <param name="lookAtPosition">The position to lookAt.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtPosition.html">External documentation for `Animator.SetLookAtPosition`</a></footer>
    public void SetLookAtPosition(Vector3 lookAtPosition)
    {
      this.CheckIfInIKPass();
      this.SetLookAtPositionInternal(lookAtPosition);
    }

    [NativeMethod("SetLookAtPosition")]
    private void SetLookAtPositionInternal(Vector3 lookAtPosition) => this.SetLookAtPositionInternal_Injected(ref lookAtPosition);

    /// <summary>
    ///   <para>Set look at weights.</para>
    /// </summary>
    /// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
    /// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
    /// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
    /// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
    /// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtWeight.html">External documentation for `Animator.SetLookAtWeight`</a></footer>
    public void SetLookAtWeight(float weight)
    {
      this.CheckIfInIKPass();
      this.SetLookAtWeightInternal(weight, 0.0f, 1f, 0.0f, 0.5f);
    }

    /// <summary>
    ///   <para>Set look at weights.</para>
    /// </summary>
    /// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
    /// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
    /// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
    /// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
    /// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtWeight.html">External documentation for `Animator.SetLookAtWeight`</a></footer>
    public void SetLookAtWeight(float weight, float bodyWeight)
    {
      this.CheckIfInIKPass();
      this.SetLookAtWeightInternal(weight, bodyWeight, 1f, 0.0f, 0.5f);
    }

    /// <summary>
    ///   <para>Set look at weights.</para>
    /// </summary>
    /// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
    /// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
    /// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
    /// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
    /// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtWeight.html">External documentation for `Animator.SetLookAtWeight`</a></footer>
    public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
    {
      this.CheckIfInIKPass();
      this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, 0.0f, 0.5f);
    }

    /// <summary>
    ///   <para>Set look at weights.</para>
    /// </summary>
    /// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
    /// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
    /// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
    /// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
    /// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtWeight.html">External documentation for `Animator.SetLookAtWeight`</a></footer>
    public void SetLookAtWeight(
      float weight,
      float bodyWeight,
      float headWeight,
      float eyesWeight)
    {
      this.CheckIfInIKPass();
      this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, 0.5f);
    }

    /// <summary>
    ///   <para>Set look at weights.</para>
    /// </summary>
    /// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
    /// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
    /// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
    /// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
    /// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLookAtWeight.html">External documentation for `Animator.SetLookAtWeight`</a></footer>
    public void SetLookAtWeight(
      float weight,
      [DefaultValue("0.0f")] float bodyWeight,
      [DefaultValue("1.0f")] float headWeight,
      [DefaultValue("0.0f")] float eyesWeight,
      [DefaultValue("0.5f")] float clampWeight)
    {
      this.CheckIfInIKPass();
      this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
    }

    [NativeMethod("SetLookAtWeight")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetLookAtWeightInternal(
      float weight,
      float bodyWeight,
      float headWeight,
      float eyesWeight,
      float clampWeight);

    /// <summary>
    ///   <para>Sets local rotation of a human bone during a IK pass.</para>
    /// </summary>
    /// <param name="humanBoneId">The human bone Id.</param>
    /// <param name="rotation">The local rotation.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetBoneLocalRotation.html">External documentation for `Animator.SetBoneLocalRotation`</a></footer>
    public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
    {
      this.CheckIfInIKPass();
      this.SetBoneLocalRotationInternal(HumanTrait.GetBoneIndexFromMono((int) humanBoneId), rotation);
    }

    [NativeMethod("SetBoneLocalRotation")]
    private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) => this.SetBoneLocalRotationInternal_Injected(humanBoneId, ref rotation);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern ScriptableObject GetBehaviour([NotNull] System.Type type);

    public T GetBehaviour<T>() where T : StateMachineBehaviour => this.GetBehaviour(typeof (T)) as T;

    private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) where T : StateMachineBehaviour
    {
      if (rawObjects == null)
        return (T[]) null;
      T[] objArray = new T[rawObjects.Length];
      for (int index = 0; index < objArray.Length; ++index)
        objArray[index] = (T) rawObjects[index];
      return objArray;
    }

    public T[] GetBehaviours<T>() where T : StateMachineBehaviour => Animator.ConvertStateMachineBehaviour<T>(this.InternalGetBehaviours(typeof (T)));

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::InternalGetBehaviours")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern ScriptableObject[] InternalGetBehaviours([NotNull] System.Type type);

    public StateMachineBehaviour[] GetBehaviours(
      int fullPathHash,
      int layerIndex)
    {
      return this.InternalGetBehavioursByKey(fullPathHash, layerIndex, typeof (StateMachineBehaviour)) as StateMachineBehaviour[];
    }

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::InternalGetBehavioursByKey")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern ScriptableObject[] InternalGetBehavioursByKey(
      int fullPathHash,
      int layerIndex,
      [NotNull] System.Type type);

    /// <summary>
    ///   <para>Automatic stabilization of feet during transition and blending.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-stabilizeFeet.html">External documentation for `Animator.stabilizeFeet`</a></footer>
    public extern bool stabilizeFeet { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns the number of layers in the controller.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-layerCount.html">External documentation for `Animator.layerCount`</a></footer>
    public extern int layerCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns the layer name.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>The layer name.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetLayerName.html">External documentation for `Animator.GetLayerName`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern string GetLayerName(int layerIndex);

    /// <summary>
    ///   <para>Returns the index of the layer with the given name.</para>
    /// </summary>
    /// <param name="layerName">The layer name.</param>
    /// <returns>
    ///   <para>The layer index.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetLayerIndex.html">External documentation for `Animator.GetLayerIndex`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int GetLayerIndex(string layerName);

    /// <summary>
    ///   <para>Returns the weight of the layer at the specified index.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>The layer weight.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetLayerWeight.html">External documentation for `Animator.GetLayerWeight`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern float GetLayerWeight(int layerIndex);

    /// <summary>
    ///   <para>Sets the weight of the layer at the given index.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <param name="weight">The new layer weight.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetLayerWeight.html">External documentation for `Animator.SetLayerWeight`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetLayerWeight(int layerIndex, float weight);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetAnimatorStateInfo(
      int layerIndex,
      StateInfoIndex stateInfoIndex,
      out AnimatorStateInfo info);

    /// <summary>
    ///   <para>Returns an AnimatorStateInfo with the information on the current state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>An AnimatorStateInfo with the information on the current state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetCurrentAnimatorStateInfo.html">External documentation for `Animator.GetCurrentAnimatorStateInfo`</a></footer>
    public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
    {
      AnimatorStateInfo info;
      this.GetAnimatorStateInfo(layerIndex, StateInfoIndex.CurrentState, out info);
      return info;
    }

    /// <summary>
    ///   <para>Returns an AnimatorStateInfo with the information on the next state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>An AnimatorStateInfo with the information on the next state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetNextAnimatorStateInfo.html">External documentation for `Animator.GetNextAnimatorStateInfo`</a></footer>
    public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
    {
      AnimatorStateInfo info;
      this.GetAnimatorStateInfo(layerIndex, StateInfoIndex.NextState, out info);
      return info;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info);

    /// <summary>
    ///   <para>Returns an AnimatorTransitionInfo with the informations on the current transition.</para>
    /// </summary>
    /// <param name="layerIndex">The layer's index.</param>
    /// <returns>
    ///   <para>An AnimatorTransitionInfo with the informations on the current transition.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetAnimatorTransitionInfo.html">External documentation for `Animator.GetAnimatorTransitionInfo`</a></footer>
    public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
    {
      AnimatorTransitionInfo info;
      this.GetAnimatorTransitionInfo(layerIndex, out info);
      return info;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern int GetAnimatorClipInfoCount(int layerIndex, bool current);

    /// <summary>
    ///   <para>Returns the number of AnimatorClipInfo in the current state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>The number of AnimatorClipInfo in the current state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetCurrentAnimatorClipInfoCount.html">External documentation for `Animator.GetCurrentAnimatorClipInfoCount`</a></footer>
    public int GetCurrentAnimatorClipInfoCount(int layerIndex) => this.GetAnimatorClipInfoCount(layerIndex, true);

    /// <summary>
    ///   <para>Returns the number of AnimatorClipInfo in the next state.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>The number of AnimatorClipInfo in the next state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetNextAnimatorClipInfoCount.html">External documentation for `Animator.GetNextAnimatorClipInfoCount`</a></footer>
    public int GetNextAnimatorClipInfoCount(int layerIndex) => this.GetAnimatorClipInfoCount(layerIndex, false);

    /// <summary>
    ///   <para>Returns an array of all the AnimatorClipInfo in the current state of the given layer.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>An array of all the AnimatorClipInfo in the current state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetCurrentAnimatorClipInfo.html">External documentation for `Animator.GetCurrentAnimatorClipInfo`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetCurrentAnimatorClipInfo")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

    /// <summary>
    ///   <para>Returns an array of all the AnimatorClipInfo in the next state of the given layer.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>An array of all the AnimatorClipInfo in the next state.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetNextAnimatorClipInfo.html">External documentation for `Animator.GetNextAnimatorClipInfo`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetNextAnimatorClipInfo")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

    public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
    {
      if (clips == null)
        throw new ArgumentNullException(nameof (clips));
      this.GetAnimatorClipInfoInternal(layerIndex, true, (object) clips);
    }

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetAnimatorClipInfoInternal")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);

    public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
    {
      if (clips == null)
        throw new ArgumentNullException(nameof (clips));
      this.GetAnimatorClipInfoInternal(layerIndex, false, (object) clips);
    }

    /// <summary>
    ///   <para>Returns true if there is a transition on the given layer, false otherwise.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <returns>
    ///   <para>True if there is a transition on the given layer, false otherwise.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.IsInTransition.html">External documentation for `Animator.IsInTransition`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool IsInTransition(int layerIndex);

    /// <summary>
    ///   <para>The AnimatorControllerParameter list used by the animator. (Read Only)</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-parameters.html">External documentation for `Animator.parameters`</a></footer>
    public extern AnimatorControllerParameter[] parameters { [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetParameters"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns the number of parameters in the controller.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-parameterCount.html">External documentation for `Animator.parameterCount`</a></footer>
    public extern int parameterCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>See AnimatorController.parameters.</para>
    /// </summary>
    /// <param name="index"></param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetParameter.html">External documentation for `Animator.GetParameter`</a></footer>
    public AnimatorControllerParameter GetParameter(int index)
    {
      AnimatorControllerParameter[] parameters = this.parameters;
      if (index < 0 || index >= this.parameters.Length)
        throw new IndexOutOfRangeException("Index must be between 0 and " + (object) this.parameters.Length);
      return parameters[index];
    }

    /// <summary>
    ///   <para>Blends pivot point between body center of mass and feet pivot.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-feetPivotActive.html">External documentation for `Animator.feetPivotActive`</a></footer>
    public extern float feetPivotActive { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Gets the pivot weight.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-pivotWeight.html">External documentation for `Animator.pivotWeight`</a></footer>
    public extern float pivotWeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Get the current position of the pivot.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-pivotPosition.html">External documentation for `Animator.pivotPosition`</a></footer>
    public Vector3 pivotPosition
    {
      get
      {
        Vector3 ret;
        this.get_pivotPosition_Injected(out ret);
        return ret;
      }
    }

    private void MatchTarget(
      Vector3 matchPosition,
      Quaternion matchRotation,
      int targetBodyPart,
      MatchTargetWeightMask weightMask,
      float startNormalizedTime,
      float targetNormalizedTime,
      bool completeMatch)
    {
      this.MatchTarget_Injected(ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime, completeMatch);
    }

    public void MatchTarget(
      Vector3 matchPosition,
      Quaternion matchRotation,
      AvatarTarget targetBodyPart,
      MatchTargetWeightMask weightMask,
      float startNormalizedTime)
    {
      this.MatchTarget(matchPosition, matchRotation, (int) targetBodyPart, weightMask, startNormalizedTime, 1f, true);
    }

    /// <summary>
    ///   <para>Automatically adjust the GameObject position and rotation.</para>
    /// </summary>
    /// <param name="matchPosition">The position we want the body part to reach.</param>
    /// <param name="matchRotation">The rotation in which we want the body part to be.</param>
    /// <param name="targetBodyPart">The body part that is involved in the match.</param>
    /// <param name="weightMask">Structure that contains weights for matching position and rotation.</param>
    /// <param name="startNormalizedTime">Start time within the animation clip (0 - beginning of clip, 1 - end of clip).</param>
    /// <param name="targetNormalizedTime">End time within the animation clip (0 - beginning of clip, 1 - end of clip), values greater than 1 can be set to trigger a match after a certain number of loops. Ex: 2.3 means at 30% of 2nd loop.</param>
    /// <param name="completeMatch">Allows you to specify what should happen if the MatchTarget function is interrupted. A value of true causes the GameObject to immediately move to the matchPosition if interrupted. A value of false causes the GameObject to stay at its current position if interrupted.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.MatchTarget.html">External documentation for `Animator.MatchTarget`</a></footer>
    public void MatchTarget(
      Vector3 matchPosition,
      Quaternion matchRotation,
      AvatarTarget targetBodyPart,
      MatchTargetWeightMask weightMask,
      float startNormalizedTime,
      [DefaultValue("1")] float targetNormalizedTime)
    {
      this.MatchTarget(matchPosition, matchRotation, (int) targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime, true);
    }

    public void MatchTarget(
      Vector3 matchPosition,
      Quaternion matchRotation,
      AvatarTarget targetBodyPart,
      MatchTargetWeightMask weightMask,
      float startNormalizedTime,
      [DefaultValue("1")] float targetNormalizedTime,
      [DefaultValue("true")] bool completeMatch)
    {
      this.MatchTarget(matchPosition, matchRotation, (int) targetBodyPart, weightMask, startNormalizedTime, targetNormalizedTime, completeMatch);
    }

    /// <summary>
    ///   <para>Interrupts the automatic target matching.</para>
    /// </summary>
    /// <param name="completeMatch"></param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.InterruptMatchTarget.html">External documentation for `Animator.InterruptMatchTarget`</a></footer>
    public void InterruptMatchTarget() => this.InterruptMatchTarget(true);

    /// <summary>
    ///   <para>Interrupts the automatic target matching.</para>
    /// </summary>
    /// <param name="completeMatch"></param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.InterruptMatchTarget.html">External documentation for `Animator.InterruptMatchTarget`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void InterruptMatchTarget([DefaultValue("true")] bool completeMatch);

    /// <summary>
    ///   <para>If automatic matching is active.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-isMatchingTarget.html">External documentation for `Animator.isMatchingTarget`</a></footer>
    public extern bool isMatchingTarget { [NativeMethod("IsMatchingTarget"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The playback speed of the Animator. 1 is normal playback speed.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-speed.html">External documentation for `Animator.speed`</a></footer>
    public extern float speed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
    public void ForceStateNormalizedTime(float normalizedTime) => this.Play(0, 0, normalizedTime);

    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration)
    {
      float normalizedTransitionTime = 0.0f;
      float fixedTimeOffset = 0.0f;
      int layer = -1;
      this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer)
    {
      float normalizedTransitionTime = 0.0f;
      float fixedTimeOffset = 0.0f;
      this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFadeInFixedTime(
      string stateName,
      float fixedTransitionDuration,
      int layer,
      float fixedTimeOffset)
    {
      float normalizedTransitionTime = 0.0f;
      this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    /// <summary>
    ///   <para>Creates a crossfade from the current state to any other state using times in seconds.</para>
    /// </summary>
    /// <param name="stateName">The name of the state.</param>
    /// <param name="stateHashName">The hash name of the state.</param>
    /// <param name="fixedTransitionDuration">The duration of the transition (in seconds).</param>
    /// <param name="layer">The layer where the crossfade occurs.</param>
    /// <param name="fixedTimeOffset">The time of the state (in seconds).</param>
    /// <param name="normalizedTransitionTime">The time of the transition (normalized).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.CrossFadeInFixedTime.html">External documentation for `Animator.CrossFadeInFixedTime`</a></footer>
    public void CrossFadeInFixedTime(
      string stateName,
      float fixedTransitionDuration,
      [DefaultValue("-1")] int layer,
      [DefaultValue("0.0f")] float fixedTimeOffset,
      [DefaultValue("0.0f")] float normalizedTransitionTime)
    {
      this.CrossFadeInFixedTime(Animator.StringToHash(stateName), fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFadeInFixedTime(
      int stateHashName,
      float fixedTransitionDuration,
      int layer,
      float fixedTimeOffset)
    {
      float normalizedTransitionTime = 0.0f;
      this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer)
    {
      float normalizedTransitionTime = 0.0f;
      float fixedTimeOffset = 0.0f;
      this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration)
    {
      float normalizedTransitionTime = 0.0f;
      float fixedTimeOffset = 0.0f;
      int layer = -1;
      this.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
    }

    /// <summary>
    ///   <para>Creates a crossfade from the current state to any other state using times in seconds.</para>
    /// </summary>
    /// <param name="stateName">The name of the state.</param>
    /// <param name="stateHashName">The hash name of the state.</param>
    /// <param name="fixedTransitionDuration">The duration of the transition (in seconds).</param>
    /// <param name="layer">The layer where the crossfade occurs.</param>
    /// <param name="fixedTimeOffset">The time of the state (in seconds).</param>
    /// <param name="normalizedTransitionTime">The time of the transition (normalized).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.CrossFadeInFixedTime.html">External documentation for `Animator.CrossFadeInFixedTime`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::CrossFadeInFixedTime")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void CrossFadeInFixedTime(
      int stateHashName,
      float fixedTransitionDuration,
      [DefaultValue("-1")] int layer,
      [DefaultValue("0.0f")] float fixedTimeOffset,
      [DefaultValue("0.0f")] float normalizedTransitionTime);

    /// <summary>
    ///   <para>Forces a write of the default values stored in the animator.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.WriteDefaultValues.html">External documentation for `Animator.WriteDefaultValues`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::WriteDefaultValues")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void WriteDefaultValues();

    public void CrossFade(
      string stateName,
      float normalizedTransitionDuration,
      int layer,
      float normalizedTimeOffset)
    {
      float normalizedTransitionTime = 0.0f;
      this.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
    {
      float normalizedTransitionTime = 0.0f;
      float normalizedTimeOffset = float.NegativeInfinity;
      this.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFade(string stateName, float normalizedTransitionDuration)
    {
      float normalizedTransitionTime = 0.0f;
      float normalizedTimeOffset = float.NegativeInfinity;
      int layer = -1;
      this.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    /// <summary>
    ///   <para>Creates a crossfade from the current state to any other state using normalized times.</para>
    /// </summary>
    /// <param name="stateName">The name of the state.</param>
    /// <param name="stateHashName">The hash name of the state.</param>
    /// <param name="normalizedTransitionDuration">The duration of the transition (normalized).</param>
    /// <param name="layer">The layer where the crossfade occurs.</param>
    /// <param name="normalizedTimeOffset">The time of the state (normalized).</param>
    /// <param name="normalizedTransitionTime">The time of the transition (normalized).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.CrossFade.html">External documentation for `Animator.CrossFade`</a></footer>
    public void CrossFade(
      string stateName,
      float normalizedTransitionDuration,
      [DefaultValue("-1")] int layer,
      [DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset,
      [DefaultValue("0.0f")] float normalizedTransitionTime)
    {
      this.CrossFade(Animator.StringToHash(stateName), normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    /// <summary>
    ///   <para>Creates a crossfade from the current state to any other state using normalized times.</para>
    /// </summary>
    /// <param name="stateName">The name of the state.</param>
    /// <param name="stateHashName">The hash name of the state.</param>
    /// <param name="normalizedTransitionDuration">The duration of the transition (normalized).</param>
    /// <param name="layer">The layer where the crossfade occurs.</param>
    /// <param name="normalizedTimeOffset">The time of the state (normalized).</param>
    /// <param name="normalizedTransitionTime">The time of the transition (normalized).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.CrossFade.html">External documentation for `Animator.CrossFade`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::CrossFade")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void CrossFade(
      int stateHashName,
      float normalizedTransitionDuration,
      [DefaultValue("-1")] int layer,
      [DefaultValue("0.0f")] float normalizedTimeOffset,
      [DefaultValue("0.0f")] float normalizedTransitionTime);

    public void CrossFade(
      int stateHashName,
      float normalizedTransitionDuration,
      int layer,
      float normalizedTimeOffset)
    {
      float normalizedTransitionTime = 0.0f;
      this.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer)
    {
      float normalizedTransitionTime = 0.0f;
      float normalizedTimeOffset = float.NegativeInfinity;
      this.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    public void CrossFade(int stateHashName, float normalizedTransitionDuration)
    {
      float normalizedTransitionTime = 0.0f;
      float normalizedTimeOffset = float.NegativeInfinity;
      int layer = -1;
      this.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
    }

    public void PlayInFixedTime(string stateName, int layer)
    {
      float fixedTime = float.NegativeInfinity;
      this.PlayInFixedTime(stateName, layer, fixedTime);
    }

    public void PlayInFixedTime(string stateName)
    {
      float fixedTime = float.NegativeInfinity;
      int layer = -1;
      this.PlayInFixedTime(stateName, layer, fixedTime);
    }

    /// <summary>
    ///   <para>Plays a state.</para>
    /// </summary>
    /// <param name="stateName">The state name.</param>
    /// <param name="stateNameHash">The state hash name. If stateNameHash is 0, it changes the current state time.</param>
    /// <param name="layer">The layer index. If layer is -1, it plays the first state with the given state name or hash.</param>
    /// <param name="fixedTime">The time offset (in seconds).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.PlayInFixedTime.html">External documentation for `Animator.PlayInFixedTime`</a></footer>
    public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime) => this.PlayInFixedTime(Animator.StringToHash(stateName), layer, fixedTime);

    /// <summary>
    ///   <para>Plays a state.</para>
    /// </summary>
    /// <param name="stateName">The state name.</param>
    /// <param name="stateNameHash">The state hash name. If stateNameHash is 0, it changes the current state time.</param>
    /// <param name="layer">The layer index. If layer is -1, it plays the first state with the given state name or hash.</param>
    /// <param name="fixedTime">The time offset (in seconds).</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.PlayInFixedTime.html">External documentation for `Animator.PlayInFixedTime`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::PlayInFixedTime")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);

    public void PlayInFixedTime(int stateNameHash, int layer)
    {
      float fixedTime = float.NegativeInfinity;
      this.PlayInFixedTime(stateNameHash, layer, fixedTime);
    }

    public void PlayInFixedTime(int stateNameHash)
    {
      float fixedTime = float.NegativeInfinity;
      int layer = -1;
      this.PlayInFixedTime(stateNameHash, layer, fixedTime);
    }

    public void Play(string stateName, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.Play(stateName, layer, normalizedTime);
    }

    public void Play(string stateName)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.Play(stateName, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>Plays a state.</para>
    /// </summary>
    /// <param name="stateName">The state name.</param>
    /// <param name="stateNameHash">The state hash name. If stateNameHash is 0, it changes the current state time.</param>
    /// <param name="layer">The layer index. If layer is -1, it plays the first state with the given state name or hash.</param>
    /// <param name="normalizedTime">The time offset between zero and one.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.Play.html">External documentation for `Animator.Play`</a></footer>
    public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime) => this.Play(Animator.StringToHash(stateName), layer, normalizedTime);

    /// <summary>
    ///   <para>Plays a state.</para>
    /// </summary>
    /// <param name="stateName">The state name.</param>
    /// <param name="stateNameHash">The state hash name. If stateNameHash is 0, it changes the current state time.</param>
    /// <param name="layer">The layer index. If layer is -1, it plays the first state with the given state name or hash.</param>
    /// <param name="normalizedTime">The time offset between zero and one.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.Play.html">External documentation for `Animator.Play`</a></footer>
    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::Play")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

    public void Play(int stateNameHash, int layer)
    {
      float normalizedTime = float.NegativeInfinity;
      this.Play(stateNameHash, layer, normalizedTime);
    }

    public void Play(int stateNameHash)
    {
      float normalizedTime = float.NegativeInfinity;
      int layer = -1;
      this.Play(stateNameHash, layer, normalizedTime);
    }

    /// <summary>
    ///   <para>Sets an AvatarTarget and a targetNormalizedTime for the current state.</para>
    /// </summary>
    /// <param name="targetIndex">The avatar body part that is queried.</param>
    /// <param name="targetNormalizedTime">The current state Time that is queried.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetTarget.html">External documentation for `Animator.SetTarget`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);

    /// <summary>
    ///   <para>Returns the position of the target specified by SetTarget.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-targetPosition.html">External documentation for `Animator.targetPosition`</a></footer>
    public Vector3 targetPosition
    {
      get
      {
        Vector3 ret;
        this.get_targetPosition_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Returns the rotation of the target specified by SetTarget.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-targetRotation.html">External documentation for `Animator.targetRotation`</a></footer>
    public Quaternion targetRotation
    {
      get
      {
        Quaternion ret;
        this.get_targetRotation_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Returns true if the transform is controlled by the Animator\.</para>
    /// </summary>
    /// <param name="transform">The transform that is queried.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.IsControlled.html">External documentation for `Animator.IsControlled`</a></footer>
    [Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsControlled(Transform transform) => false;

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern bool IsBoneTransform(Transform transform);

    internal extern Transform avatarRoot { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Returns Transform mapped to this human bone id.</para>
    /// </summary>
    /// <param name="humanBoneId">The human bone that is queried, see enum HumanBodyBones for a list of possible values.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetBoneTransform.html">External documentation for `Animator.GetBoneTransform`</a></footer>
    public Transform GetBoneTransform(HumanBodyBones humanBoneId) => humanBoneId >= HumanBodyBones.Hips && humanBoneId < HumanBodyBones.LastBone ? this.GetBoneTransformInternal(HumanTrait.GetBoneIndexFromMono((int) humanBoneId)) : throw new IndexOutOfRangeException("humanBoneId must be between 0 and " + (object) HumanBodyBones.LastBone);

    [NativeMethod("GetBoneTransform")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern Transform GetBoneTransformInternal(int humanBoneId);

    /// <summary>
    ///   <para>Controls culling of this Animator component.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-cullingMode.html">External documentation for `Animator.cullingMode`</a></footer>
    public extern AnimatorCullingMode cullingMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets the animator in playback mode.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.StartPlayback.html">External documentation for `Animator.StartPlayback`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void StartPlayback();

    /// <summary>
    ///   <para>Stops the animator playback mode. When playback stops, the avatar resumes getting control from game logic.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.StopPlayback.html">External documentation for `Animator.StopPlayback`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void StopPlayback();

    /// <summary>
    ///   <para>Sets the playback position in the recording buffer.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-playbackTime.html">External documentation for `Animator.playbackTime`</a></footer>
    public extern float playbackTime { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets the animator in recording mode, and allocates a circular buffer of size frameCount.</para>
    /// </summary>
    /// <param name="frameCount">The number of frames (updates) that will be recorded. If frameCount is 0, the recording will continue until the user calls StopRecording. The maximum value for frameCount is 10000.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.StartRecording.html">External documentation for `Animator.StartRecording`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void StartRecording(int frameCount);

    /// <summary>
    ///   <para>Stops animator record mode.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.StopRecording.html">External documentation for `Animator.StopRecording`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void StopRecording();

    /// <summary>
    ///   <para>Start time of the first frame of the buffer relative to the frame at which StartRecording was called.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-recorderStartTime.html">External documentation for `Animator.recorderStartTime`</a></footer>
    public float recorderStartTime
    {
      get => this.GetRecorderStartTime();
      set
      {
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetRecorderStartTime();

    /// <summary>
    ///   <para>End time of the recorded clip relative to when StartRecording was called.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-recorderStopTime.html">External documentation for `Animator.recorderStopTime`</a></footer>
    public float recorderStopTime
    {
      get => this.GetRecorderStopTime();
      set
      {
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetRecorderStopTime();

    /// <summary>
    ///   <para>Gets the mode of the Animator recorder.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-recorderMode.html">External documentation for `Animator.recorderMode`</a></footer>
    public extern AnimatorRecorderMode recorderMode { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The runtime representation of AnimatorController that controls the Animator.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-runtimeAnimatorController.html">External documentation for `Animator.runtimeAnimatorController`</a></footer>
    public extern RuntimeAnimatorController runtimeAnimatorController { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns true if Animator has any playables assigned to it.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-hasBoundPlayables.html">External documentation for `Animator.hasBoundPlayables`</a></footer>
    public extern bool hasBoundPlayables { [NativeMethod("HasBoundPlayables"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void ClearInternalControllerPlayable();

    /// <summary>
    ///   <para>Returns true if the state exists in this layer, false otherwise.</para>
    /// </summary>
    /// <param name="layerIndex">The layer index.</param>
    /// <param name="stateID">The state ID.</param>
    /// <returns>
    ///   <para>True if the state exists in this layer, false otherwise.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.HasState.html">External documentation for `Animator.HasState`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool HasState(int layerIndex, int stateID);

    /// <summary>
    ///   <para>Generates an parameter id from a string.</para>
    /// </summary>
    /// <param name="name">The string to convert to Id.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.StringToHash.html">External documentation for `Animator.StringToHash`</a></footer>
    [NativeMethod(IsThreadSafe = true, Name = "ScriptingStringToCRC32")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int StringToHash(string name);

    /// <summary>
    ///   <para>Gets/Sets the current Avatar.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-avatar.html">External documentation for `Animator.avatar`</a></footer>
    public extern Avatar avatar { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern string GetStats();

    /// <summary>
    ///   <para>The PlayableGraph created by the Animator.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-playableGraph.html">External documentation for `Animator.playableGraph`</a></footer>
    public PlayableGraph playableGraph
    {
      get
      {
        PlayableGraph graph = new PlayableGraph();
        this.GetCurrentGraph(ref graph);
        return graph;
      }
    }

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetCurrentGraph")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetCurrentGraph(ref PlayableGraph graph);

    private void CheckIfInIKPass()
    {
      if (!this.logWarnings || this.IsInIKPass())
        return;
      Debug.LogWarning((object) "Setting and getting Body Position/Rotation, IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern bool IsInIKPass();

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetFloatString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatString(string name, float value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetFloatID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatID(int id, float value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetFloatString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetFloatString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetFloatID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetFloatID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetBoolString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetBoolString(string name, bool value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetBoolID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetBoolID(int id, bool value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetBoolString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern bool GetBoolString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetBoolID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern bool GetBoolID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetIntegerString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetIntegerString(string name, int value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetIntegerID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetIntegerID(int id, int value);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetIntegerString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetIntegerString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::GetIntegerID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetIntegerID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetTriggerString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTriggerString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetTriggerID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTriggerID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::ResetTriggerString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ResetTriggerString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::ResetTriggerID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ResetTriggerID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::IsParameterControlledByCurveString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern bool IsParameterControlledByCurveString(string name);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::IsParameterControlledByCurveID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern bool IsParameterControlledByCurveID(int id);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetFloatStringDamp")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatStringDamp(
      string name,
      float value,
      float dampTime,
      float deltaTime);

    [FreeFunction(HasExplicitThis = true, Name = "AnimatorBindings::SetFloatIDDamp")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);

    /// <summary>
    ///   <para>Additional layers affects the center of mass.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-layersAffectMassCenter.html">External documentation for `Animator.layersAffectMassCenter`</a></footer>
    public extern bool layersAffectMassCenter { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Get left foot bottom height.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-leftFeetBottomHeight.html">External documentation for `Animator.leftFeetBottomHeight`</a></footer>
    public extern float leftFeetBottomHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Get right foot bottom height.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-rightFeetBottomHeight.html">External documentation for `Animator.rightFeetBottomHeight`</a></footer>
    public extern float rightFeetBottomHeight { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    [NativeConditional("UNITY_EDITOR")]
    internal extern bool supportsOnAnimatorMove { [NativeMethod("SupportsOnAnimatorMove"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void OnUpdateModeChanged();

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void OnCullingModeChanged();

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void WriteDefaultPose();

    /// <summary>
    ///   <para>Evaluates the animator based on deltaTime.</para>
    /// </summary>
    /// <param name="deltaTime">The time delta.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.Update.html">External documentation for `Animator.Update`</a></footer>
    [NativeMethod("UpdateWithDelta")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Update(float deltaTime);

    /// <summary>
    ///   <para>Rebind all the animated properties and mesh data with the Animator.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.Rebind.html">External documentation for `Animator.Rebind`</a></footer>
    public void Rebind() => this.Rebind(true);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Rebind(bool writeDefaultValues);

    /// <summary>
    ///   <para>Apply the default Root Motion.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.ApplyBuiltinRootMotion.html">External documentation for `Animator.ApplyBuiltinRootMotion`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void ApplyBuiltinRootMotion();

    [NativeConditional("UNITY_EDITOR")]
    internal void EvaluateController() => this.EvaluateController(0.0f);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void EvaluateController(float deltaTime);

    [NativeConditional("UNITY_EDITOR")]
    internal string GetCurrentStateName(int layerIndex) => this.GetAnimatorStateName(layerIndex, true);

    [NativeConditional("UNITY_EDITOR")]
    internal string GetNextStateName(int layerIndex) => this.GetAnimatorStateName(layerIndex, false);

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern string GetAnimatorStateName(int layerIndex, bool current);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern string ResolveHash(int hash);

    public extern bool logWarnings { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets whether the Animator sends events of type AnimationEvent.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-fireEvents.html">External documentation for `Animator.fireEvents`</a></footer>
    public extern bool fireEvents { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Controls the behaviour of the Animator component when a GameObject is disabled.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator-keepAnimatorControllerStateOnDisable.html">External documentation for `Animator.keepAnimatorControllerStateOnDisable`</a></footer>
    public extern bool keepAnimatorControllerStateOnDisable { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Gets the value of a vector parameter.</para>
    /// </summary>
    /// <param name="name">The name of the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetVector.html">External documentation for `Animator.GetVector`</a></footer>
    [Obsolete("GetVector is deprecated.")]
    public Vector3 GetVector(string name) => Vector3.zero;

    /// <summary>
    ///   <para>Gets the value of a vector parameter.</para>
    /// </summary>
    /// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetVector.html">External documentation for `Animator.GetVector`</a></footer>
    [Obsolete("GetVector is deprecated.")]
    public Vector3 GetVector(int id) => Vector3.zero;

    /// <summary>
    ///   <para>Sets the value of a vector parameter.</para>
    /// </summary>
    /// <param name="name">The name of the parameter.</param>
    /// <param name="value">The new value for the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetVector.html">External documentation for `Animator.SetVector`</a></footer>
    [Obsolete("SetVector is deprecated.")]
    public void SetVector(string name, Vector3 value)
    {
    }

    /// <summary>
    ///   <para>Sets the value of a vector parameter.</para>
    /// </summary>
    /// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
    /// <param name="value">The new value for the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetVector.html">External documentation for `Animator.SetVector`</a></footer>
    [Obsolete("SetVector is deprecated.")]
    public void SetVector(int id, Vector3 value)
    {
    }

    /// <summary>
    ///   <para>Gets the value of a quaternion parameter.</para>
    /// </summary>
    /// <param name="name">The name of the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetQuaternion.html">External documentation for `Animator.GetQuaternion`</a></footer>
    [Obsolete("GetQuaternion is deprecated.")]
    public Quaternion GetQuaternion(string name) => Quaternion.identity;

    /// <summary>
    ///   <para>Gets the value of a quaternion parameter.</para>
    /// </summary>
    /// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.GetQuaternion.html">External documentation for `Animator.GetQuaternion`</a></footer>
    [Obsolete("GetQuaternion is deprecated.")]
    public Quaternion GetQuaternion(int id) => Quaternion.identity;

    /// <summary>
    ///   <para>Sets the value of a quaternion parameter.</para>
    /// </summary>
    /// <param name="name">The name of the parameter.</param>
    /// <param name="value">The new value for the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetQuaternion.html">External documentation for `Animator.SetQuaternion`</a></footer>
    [Obsolete("SetQuaternion is deprecated.")]
    public void SetQuaternion(string name, Quaternion value)
    {
    }

    /// <summary>
    ///   <para>Sets the value of a quaternion parameter.</para>
    /// </summary>
    /// <param name="id">Of the parameter. The id is generated using Animator::StringToHash.</param>
    /// <param name="value">The new value for the parameter.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/Animator.SetQuaternion.html">External documentation for `Animator.SetQuaternion`</a></footer>
    [Obsolete("SetQuaternion is deprecated.")]
    public void SetQuaternion(int id, Quaternion value)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_deltaPosition_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_deltaRotation_Injected(out Quaternion ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_velocity_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_angularVelocity_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_rootPosition_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_rootPosition_Injected(ref Vector3 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_rootRotation_Injected(out Quaternion ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_rootRotation_Injected(ref Quaternion value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_bodyPositionInternal_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_bodyPositionInternal_Injected(ref Vector3 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_bodyRotationInternal_Injected(out Quaternion ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_bodyRotationInternal_Injected(ref Quaternion value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetBoneLocalRotationInternal_Injected(
      int humanBoneId,
      ref Quaternion rotation);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_pivotPosition_Injected(out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void MatchTarget_Injected(
      ref Vector3 matchPosition,
      ref Quaternion matchRotation,
      int targetBodyPart,
      ref MatchTargetWeightMask weightMask,
      float startNormalizedTime,
      float targetNormalizedTime,
      bool completeMatch);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_targetPosition_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_targetRotation_Injected(out Quaternion ret);
  }
}
