// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.EntityBehaviour`1
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

namespace Photon.Bolt
{
  /// <summary>
  /// Base class for unity behaviours that want to access Bolt methods with the state available also
  /// </summary>
  /// <typeparam name="TState">The type of state on this BoltEntity</typeparam>
  /// <example>
  /// *Example:* Using the <c>IPlayerState</c> type as a parameter and using its property <c>state.team</c> in code.
  /// 
  /// <code>
  /// public class PlayerController : Bolt.EntityBehaviour&lt;IPlayerState&gt; {
  ///   public override void ControlGained() {
  ///     state.AddCallback("team", TeamChanged);
  ///   }
  /// 
  ///   void TeamChanged() {
  ///     var nameplate = GetComponent&lt;PlayerNameplate&gt;();
  ///     if (state.team == 0) nameplate.color = Color.Blue;
  ///     else nameplate.color = Color.Red;
  ///   }
  /// }
  /// </code>
  /// </example>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour%601">`EntityBehaviour` on google.com</a></footer>
  [Documentation(Alias = "Photon.Bolt.EntityBehaviour<TState>")]
  public abstract class EntityBehaviour<TState> : EntityBehaviour
  {
    /// <summary>The state for this behaviours entity</summary>
    /// <example>
    /// *Example:* Using the ```state``` property to set up state callbacks.
    /// 
    /// <code>
    /// public class PlayerController : Bolt.EntityBehaviour&lt;IPlayerState&gt; {
    ///   public override void ControlGained() {
    ///     state.AddCallback("team", TeamChanged);
    ///   }
    /// 
    ///   void TeamChanged() {
    ///     var nameplate = GetComponent&lt;PlayerNameplate&gt;();
    ///     if (state.team == 0) nameplate.color = Color.Blue;
    ///     else nameplate.color = Color.Red;
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour%601.state">`EntityBehaviour.state` on google.com</a></footer>
    public TState state => this.entity.GetState<TState>();
  }
}
