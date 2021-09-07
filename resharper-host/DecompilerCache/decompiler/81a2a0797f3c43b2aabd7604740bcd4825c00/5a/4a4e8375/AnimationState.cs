// Decompiled with JetBrains decompiler
// Type: UnityEngine.AnimationState
// Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81A2A079-7F3C-43B2-AABD-7604740BCD48
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The AnimationState gives full control over animation blending.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState.html">External documentation for `AnimationState`</a></footer>
  [UsedByNativeCode]
  public sealed class AnimationState : TrackedReference
  {
    /// <summary>
    ///   <para>Enables / disables the animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-enabled.html">External documentation for `AnimationState.enabled`</a></footer>
    public extern bool enabled { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The weight of animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-weight.html">External documentation for `AnimationState.weight`</a></footer>
    public extern float weight { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Wrapping mode of the animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-wrapMode.html">External documentation for `AnimationState.wrapMode`</a></footer>
    public extern WrapMode wrapMode { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The current time of the animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-time.html">External documentation for `AnimationState.time`</a></footer>
    public extern float time { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The normalized time of the animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-normalizedTime.html">External documentation for `AnimationState.normalizedTime`</a></footer>
    public extern float normalizedTime { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The playback speed of the animation. 1 is normal playback speed.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-speed.html">External documentation for `AnimationState.speed`</a></footer>
    public extern float speed { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The normalized playback speed.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-normalizedSpeed.html">External documentation for `AnimationState.normalizedSpeed`</a></footer>
    public extern float normalizedSpeed { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The length of the animation clip in seconds.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-length.html">External documentation for `AnimationState.length`</a></footer>
    public extern float length { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public extern int layer { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The clip that is being played by this animation state.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-clip.html">External documentation for `AnimationState.clip`</a></footer>
    public extern AnimationClip clip { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Adds a transform which should be animated. This allows you to reduce the number of animations you have to create.</para>
    /// </summary>
    /// <param name="mix">The transform to animate.</param>
    /// <param name="recursive">Whether to also animate all children of the specified transform.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState.AddMixingTransform.html">External documentation for `AnimationState.AddMixingTransform`</a></footer>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void AddMixingTransform(Transform mix, [DefaultValue("true")] bool recursive);

    /// <summary>
    ///   <para>Adds a transform which should be animated. This allows you to reduce the number of animations you have to create.</para>
    /// </summary>
    /// <param name="mix">The transform to animate.</param>
    /// <param name="recursive">Whether to also animate all children of the specified transform.</param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState.AddMixingTransform.html">External documentation for `AnimationState.AddMixingTransform`</a></footer>
    [ExcludeFromDocs]
    public void AddMixingTransform(Transform mix)
    {
      bool recursive = true;
      this.AddMixingTransform(mix, recursive);
    }

    /// <summary>
    ///   <para>Removes a transform which should be animated.</para>
    /// </summary>
    /// <param name="mix"></param>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState.RemoveMixingTransform.html">External documentation for `AnimationState.RemoveMixingTransform`</a></footer>
    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void RemoveMixingTransform(Transform mix);

    /// <summary>
    ///   <para>The name of the animation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-name.html">External documentation for `AnimationState.name`</a></footer>
    public extern string name { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Which blend mode should be used?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2019.4.16f1/Editor/Data/Documentation/en/ScriptReference/AnimationState-blendMode.html">External documentation for `AnimationState.blendMode`</a></footer>
    public extern AnimationBlendMode blendMode { [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator, MethodImpl(MethodImplOptions.InternalCall)] set; }
  }
}
