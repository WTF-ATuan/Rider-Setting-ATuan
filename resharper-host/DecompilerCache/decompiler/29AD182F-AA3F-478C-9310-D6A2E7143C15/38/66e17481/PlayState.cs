// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayState
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;

namespace UnityEngine.Playables
{
  /// <summary>
  ///   <para>Status of a Playable.</para>
  /// </summary>
  public enum PlayState
  {
    /// <summary>
    ///   <para>The Playable has been paused. Its local time will not advance.</para>
    /// </summary>
    Paused,
    /// <summary>
    ///   <para>The Playable is currently Playing.</para>
    /// </summary>
    Playing,
    /// <summary>
    ///   <para>The Playable has been delayed, using PlayableExtensions.SetDelay. It will not start until the delay is entirely consumed.</para>
    /// </summary>
    [Obsolete("Delayed is obsolete; use a custom ScriptPlayable to implement this feature", false)] Delayed,
  }
}
