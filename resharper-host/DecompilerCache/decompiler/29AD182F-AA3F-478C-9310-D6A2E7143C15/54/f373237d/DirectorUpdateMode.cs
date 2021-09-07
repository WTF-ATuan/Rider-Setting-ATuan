// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.DirectorUpdateMode
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

namespace UnityEngine.Playables
{
  /// <summary>
  ///   <para>Defines what time source is used to update a Director graph.</para>
  /// </summary>
  public enum DirectorUpdateMode
  {
    /// <summary>
    ///   <para>Update is based on DSP (Digital Sound Processing) clock. Use this for graphs that need to be synchronized with Audio.</para>
    /// </summary>
    DSPClock,
    /// <summary>
    ///   <para>Update is based on Time.time. Use this for graphs that need to be synchronized on gameplay, and that need to be paused when the game is paused.</para>
    /// </summary>
    GameTime,
    /// <summary>
    ///   <para>Update is based on Time.unscaledTime. Use this for graphs that need to be updated even when gameplay is paused. Example: Menus transitions need to be updated even when the game is paused.</para>
    /// </summary>
    UnscaledGameTime,
    /// <summary>
    ///   <para>Update mode is manual. You need to manually call PlayableGraph.Evaluate with your own deltaTime. This can be useful for graphs that are completely disconnected from the rest of the game. For example, localized bullet time.</para>
    /// </summary>
    Manual,
  }
}
