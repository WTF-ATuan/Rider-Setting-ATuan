// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableBehaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DC54541-A257-4AC7-826A-004A212A4332
// Assembly location: D:\unity\2019.4.1f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
  /// <summary>
  ///   <para>PlayableBehaviour is the base class from which every custom playable script derives.</para>
  /// </summary>
  [RequiredByNativeCode]
  [Serializable]
  public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
  {
    /// <summary>
    ///   <para>This function is called when the PlayableGraph that owns this PlayableBehaviour starts.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    public virtual void OnGraphStart(Playable playable)
    {
    }

    /// <summary>
    ///   <para>This function is called when the PlayableGraph that owns this PlayableBehaviour stops.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    public virtual void OnGraphStop(Playable playable)
    {
    }

    /// <summary>
    ///   <para>This function is called when the Playable that owns the PlayableBehaviour is created.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    public virtual void OnPlayableCreate(Playable playable)
    {
    }

    /// <summary>
    ///   <para>This function is called when the Playable that owns the PlayableBehaviour is destroyed.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    public virtual void OnPlayableDestroy(Playable playable)
    {
    }

    /// <summary>
    ///   <para>This function is called when the Playable play state is changed to Playables.PlayState.Delayed.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    [Obsolete("OnBehaviourDelay is obsolete; use a custom ScriptPlayable to implement this feature", false)]
    public virtual void OnBehaviourDelay(Playable playable, FrameData info)
    {
    }

    /// <summary>
    ///   <para>This function is called when the Playable play state is changed to Playables.PlayState.Playing.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    public virtual void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    /// <summary>
    ///         <para>This method is invoked when one of the following situations occurs:
    /// &lt;br&gt;&lt;br&gt;
    ///      The effective play state during traversal is changed to Playables.PlayState.Paused. This state is indicated by FrameData.effectivePlayState.&lt;br&gt;&lt;br&gt;
    ///      The PlayableGraph is stopped while the playable play state is Playing. This state is indicated by PlayableGraph.IsPlaying returning true.</para>
    ///       </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    public virtual void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    /// <summary>
    ///   <para>This function is called during the PrepareData phase of the PlayableGraph.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    public virtual void PrepareData(Playable playable, FrameData info)
    {
    }

    /// <summary>
    ///   <para>This function is called during the PrepareFrame phase of the PlayableGraph.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    public virtual void PrepareFrame(Playable playable, FrameData info)
    {
    }

    /// <summary>
    ///   <para>This function is called during the ProcessFrame phase of the PlayableGraph.</para>
    /// </summary>
    /// <param name="playable">The Playable that owns the current PlayableBehaviour.</param>
    /// <param name="info">A FrameData structure that contains information about the current frame context.</param>
    /// <param name="playerData">The user data of the ScriptPlayableOutput that initiated the process pass.</param>
    public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    public virtual object Clone() => this.MemberwiseClone();
  }
}
