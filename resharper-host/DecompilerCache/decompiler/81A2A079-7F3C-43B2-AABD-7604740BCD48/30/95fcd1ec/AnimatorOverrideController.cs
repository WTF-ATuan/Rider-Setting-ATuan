// Decompiled with JetBrains decompiler
// Type: UnityEngine.AnimatorOverrideController
// Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81A2A079-7F3C-43B2-AABD-7604740BCD48
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Interface to control Animator Override Controller.</para>
  /// </summary>
  [NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
  [UsedByNativeCode]
  [NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
  public class AnimatorOverrideController : RuntimeAnimatorController
  {
    internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

    /// <summary>
    ///   <para>Creates an empty Animator Override Controller.</para>
    /// </summary>
    public AnimatorOverrideController()
    {
      AnimatorOverrideController.Internal_Create(this, (RuntimeAnimatorController) null);
      this.OnOverrideControllerDirty = (AnimatorOverrideController.OnOverrideControllerDirtyCallback) null;
    }

    /// <summary>
    ///   <para>Creates an Animator Override Controller that overrides controller.</para>
    /// </summary>
    /// <param name="controller">Runtime Animator Controller to override.</param>
    public AnimatorOverrideController(RuntimeAnimatorController controller)
    {
      AnimatorOverrideController.Internal_Create(this, controller);
      this.OnOverrideControllerDirty = (AnimatorOverrideController.OnOverrideControllerDirtyCallback) null;
    }

    [FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_Create(
      [Writable] AnimatorOverrideController self,
      RuntimeAnimatorController controller);

    /// <summary>
    ///   <para>The Runtime Animator Controller that the Animator Override Controller overrides.</para>
    /// </summary>
    public extern RuntimeAnimatorController runtimeAnimatorController { [NativeMethod("GetAnimatorController"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetAnimatorController"), MethodImpl(MethodImplOptions.InternalCall)] set; }

    public AnimationClip this[string name]
    {
      get => this.Internal_GetClipByName(name, true);
      set => this.Internal_SetClipByName(name, value);
    }

    [NativeMethod("GetClip")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnimationClip Internal_GetClipByName(
      string name,
      bool returnEffectiveClip);

    [NativeMethod("SetClip")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Internal_SetClipByName(string name, AnimationClip clip);

    public AnimationClip this[AnimationClip clip]
    {
      get => this.GetClip(clip, true);
      set => this.SetClip(clip, value, true);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnimationClip GetClip(
      AnimationClip originalClip,
      bool returnEffectiveClip);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetClip(
      AnimationClip originalClip,
      AnimationClip overrideClip,
      bool notify);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SendNotification();

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnimationClip GetOriginalClip(int index);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern AnimationClip GetOverrideClip(AnimationClip originalClip);

    /// <summary>
    ///   <para>Returns the count of overrides.</para>
    /// </summary>
    public extern int overridesCount { [NativeMethod("GetOriginalClipsCount"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    public void GetOverrides(
      List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
    {
      if (overrides == null)
        throw new ArgumentNullException(nameof (overrides));
      int overridesCount = this.overridesCount;
      if (overrides.Capacity < overridesCount)
        overrides.Capacity = overridesCount;
      overrides.Clear();
      for (int index = 0; index < overridesCount; ++index)
      {
        AnimationClip originalClip = this.GetOriginalClip(index);
        overrides.Add(new KeyValuePair<AnimationClip, AnimationClip>(originalClip, this.GetOverrideClip(originalClip)));
      }
    }

    public void ApplyOverrides(
      IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
    {
      if (overrides == null)
        throw new ArgumentNullException(nameof (overrides));
      for (int index = 0; index < overrides.Count; ++index)
      {
        KeyValuePair<AnimationClip, AnimationClip> keyValuePair = overrides[index];
        AnimationClip key = keyValuePair.Key;
        keyValuePair = overrides[index];
        AnimationClip overrideClip = keyValuePair.Value;
        this.SetClip(key, overrideClip, false);
      }
      this.SendNotification();
    }

    /// <summary>
    ///   <para>Returns the list of orignal Animation Clip from the controller and their override Animation Clip.</para>
    /// </summary>
    [Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
    public AnimationClipPair[] clips
    {
      get
      {
        int overridesCount = this.overridesCount;
        AnimationClipPair[] animationClipPairArray = new AnimationClipPair[overridesCount];
        for (int index = 0; index < overridesCount; ++index)
        {
          animationClipPairArray[index] = new AnimationClipPair();
          animationClipPairArray[index].originalClip = this.GetOriginalClip(index);
          animationClipPairArray[index].overrideClip = this.GetOverrideClip(animationClipPairArray[index].originalClip);
        }
        return animationClipPairArray;
      }
      set
      {
        for (int index = 0; index < value.Length; ++index)
          this.SetClip(value[index].originalClip, value[index].overrideClip, false);
        this.SendNotification();
      }
    }

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void PerformOverrideClipListCleanup();

    [NativeConditional("UNITY_EDITOR")]
    [RequiredByNativeCode]
    internal static void OnInvalidateOverrideController(AnimatorOverrideController controller)
    {
      if (controller.OnOverrideControllerDirty == null)
        return;
      controller.OnOverrideControllerDirty();
    }

    internal delegate void OnOverrideControllerDirtyCallback();
  }
}
