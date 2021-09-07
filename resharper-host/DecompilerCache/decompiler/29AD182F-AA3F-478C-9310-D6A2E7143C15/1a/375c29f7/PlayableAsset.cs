// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
  /// <summary>
  ///   <para>A base class for assets that can be used to instantiate a Playable at runtime.</para>
  /// </summary>
  [AssetFileNameExtension("playable", new string[] {})]
  [RequiredByNativeCode]
  [Serializable]
  public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
  {
    /// <summary>
    ///   <para>Implement this method to have your asset inject playables into the given graph.</para>
    /// </summary>
    /// <param name="graph">The graph to inject playables into.</param>
    /// <param name="owner">The game object which initiated the build.</param>
    /// <returns>
    ///   <para>The playable injected into the graph, or the root playable if multiple playables are injected.</para>
    /// </returns>
    public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

    /// <summary>
    ///   <para>The playback duration in seconds of the instantiated Playable.</para>
    /// </summary>
    public virtual double duration => PlayableBinding.DefaultDuration;

    /// <summary>
    ///   <para>A description of the outputs of the instantiated Playable.</para>
    /// </summary>
    public virtual IEnumerable<PlayableBinding> outputs => (IEnumerable<PlayableBinding>) PlayableBinding.None;

    [RequiredByNativeCode]
    internal static unsafe void Internal_CreatePlayable(
      PlayableAsset asset,
      PlayableGraph graph,
      GameObject go,
      IntPtr ptr)
    {
      Playable playable = !((UnityEngine.Object) asset == (UnityEngine.Object) null) ? asset.CreatePlayable(graph, go) : Playable.Null;
      *(Playable*) ptr.ToPointer() = playable;
    }

    [RequiredByNativeCode]
    internal static unsafe void Internal_GetPlayableAssetDuration(
      PlayableAsset asset,
      IntPtr ptrToDouble)
    {
      double duration = asset.duration;
      *(double*) ptrToDouble.ToPointer() = duration;
    }
  }
}
