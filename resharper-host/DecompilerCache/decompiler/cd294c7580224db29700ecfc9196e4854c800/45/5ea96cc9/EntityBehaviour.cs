// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.EntityBehaviour
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using Photon.Bolt.Utils;
using UnityEngine;

namespace Photon.Bolt
{
  /// <summary>
  /// Base class for unity behaviours that want to access Bolt methods
  /// </summary>
  /// <example>
  /// *Example:* Using <c>Bolt.EntityBehaviour</c> to write a simple PlayerController class. Attach to a valid bolt entity/prefab.
  /// 
  /// <code>
  /// public class PlayerController : Bolt.EntityBehaviour&lt;IPlayerState&gt; {
  /// 
  ///   bool forward;
  ///   bool backward;
  ///   bool left;
  ///   bool right;
  /// 
  ///   public override void Initialized() {
  ///     MiniMap.instance.AddKnownPlayer(this.gameObject);
  ///   }
  /// 
  ///   public override void Attached() {
  ///     state.AddCallback("name", NameChanged);
  ///     state.AddCallback("team", TeamChanged);
  ///   }
  /// 
  ///   public override void ControlGained() {
  ///     GameCamera.instance.AddFollowTarget(this.transform);
  ///     MiniMap.instance.SetControlledPlayer(this.entity);
  ///   }
  /// 
  ///   public override SimulateOwner() {
  ///     if(state.health &lt; 100)
  ///     {
  ///       state.health += state.healthRegen * BoltNetwork.frameDeltaTime;
  ///     }
  ///   }
  /// 
  ///   public override void SimulateController() {
  ///     IPlayerCommandInput input = PlayerCommand.Create();
  /// 
  ///     PollKeys();
  /// 
  ///     input.forward = forward;
  ///     input.backward = backward;
  ///     input.left = left;
  ///     input.right = right;
  /// 
  ///     entity.QueueInput(input);
  ///   }
  /// 
  ///   public override ExecuteCommand(Bolt.Command command, bool resetState) {
  ///     if(resetState) {
  ///       motor.SetState(cmd.Result.position);
  ///     }
  ///     else
  ///     {
  ///       cmd.Result.position = motor.Move(cmd.Input.forward, cmd.Input.backward, command.Input.left, command.Input.right);
  /// 
  ///       if (cmd.IsFirstExecution) {
  ///         AnimatePlayer(cmd);
  ///       }
  ///     }
  ///   }
  /// }
  /// </code>
  /// </example>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour">`EntityBehaviour` on google.com</a></footer>
  [Documentation]
  public abstract class EntityBehaviour : MonoBehaviour, IEntityBehaviour
  {
    internal BoltEntity _entity;

    /// <summary>The entity for this behaviour</summary>
    /// 
    ///             Use the ```entity``` property to access the internal ```BoltEntity``` of the gameObject that this script is attached to.
    ///             <example>
    /// *Example:* Passing the ```entity``` of this gameObject to a ```MiniMap```, giving it the position, facing direction and the
    /// entity state (such as team, alive/dead, hostile, etc).
    /// 
    /// <code>
    /// public class PlayerController : Bolt.EntityBehaviour {
    ///   public override void ControlGained() {
    ///     GameCamera.instance.AddFollowTarget(this.transform);
    ///     MiniMap.instance.SetControlledPlayer(this.entity);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.entity">`EntityBehaviour.entity` on google.com</a></footer>
    public BoltEntity entity
    {
      get
      {
        if (!(bool) (Object) this._entity)
        {
          for (Transform transform = this.transform; (bool) (Object) transform && !(bool) (Object) this._entity; transform = transform.parent)
            this._entity = transform.GetComponent<BoltEntity>();
          if (!(bool) (Object) this._entity)
            BoltLog.Error("Could not find a Bolt Entity component attached to '{0}' or any of its parents", (object) this.gameObject.name);
        }
        return this._entity;
      }
      set => this._entity = value;
    }

    public bool invoke => this.enabled;

    /// <summary>
    /// Invoked when the entity has been initialized, before Attached
    /// </summary>
    /// <example>
    /// *Example:* Notifying a ```MiniMap``` class to draw this gameObject by overriding the ```Initialized()``` method.
    /// 
    /// <code>
    /// public override void Initialized() {
    ///   MiniMap.instance.AddKnownPlayer(this.gameObject);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.Initialized">`EntityBehaviour.Initialized` on google.com</a></footer>
    public virtual void Initialized()
    {
    }

    /// <summary>
    /// Invoked when Bolt is aware of this entity and all internal state has been setup
    /// </summary>
    /// <example>
    /// *Example:* Overriding the ```Attached()``` method to add state change callbacks to the newly valid state.
    /// 
    /// <code>
    /// public override void Attached() {
    ///   state.AddCallback("name", NameChanged);
    ///   state.AddCallback("team", TeamChanged);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.Attached">`EntityBehaviour.Attached` on google.com</a></footer>
    public virtual void Attached()
    {
    }

    /// <summary>
    /// Invoked when this entity is removed from Bolt's awareness
    /// </summary>
    /// <example>
    /// *Example:* Notifying the game minimap to remove the entity upon detaching from the simulation.
    /// 
    /// <code>
    /// public override void Detached() {
    ///   MiniMap.instance.RemoveKnownPlayer(this.entity);
    /// {
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.Detached">`EntityBehaviour.Detached` on google.com</a></footer>
    public virtual void Detached()
    {
    }

    /// <summary>Invoked each simulation step on the owner</summary>
    /// <example>
    /// *Example:* Implementing an authoritative health regeneration update every 10th frame. Also fires the
    /// <c>DeathTrigger()</c> on the state if health falls below zero.
    /// 
    /// <code>
    /// public override SimulateOwner() {
    ///   if(state.alive &amp;&amp; state.Health.Current &lt;= 0) {
    ///     state.Health.alive = false;
    ///     state.DeathTrigger();
    ///   }
    ///   else if(state.alive &amp;&amp; (BoltNetwork.frame % 10) == 0)
    ///   {
    ///     state.Health.Current = Mathf.Clamp (state.Health.Current + (state.Health.RegenPer10 * BoltNetwork.frameDeltaTime),
    ///         // clamp from 0 to max health
    ///         0, state.Health.Max);
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.SimulateOwner">`EntityBehaviour.SimulateOwner` on google.com</a></footer>
    public virtual void SimulateOwner()
    {
    }

    /// <summary>Invoked each simulation step on the controller</summary>
    /// <example>
    /// *Example:* Creating a simple WASD-style movement input command and adding it to the queue of inputs. One input command
    /// should be added to the queue per execution and remember to create and compile a Command asset before using this method!
    /// 
    /// <code>
    /// bool forward;
    /// bool backward;
    /// bool left;
    /// bool right;
    /// 
    /// public override void SimulateController() {
    ///   IPlayerCommandInput input = PlayerCommand.Create();
    /// 
    ///   PollKeys();
    /// 
    ///   input.forward = forward;
    ///   input.backward = backward;
    ///   input.left = left;
    ///   input.right = right;
    /// 
    ///   entity.QueueInput(input);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.SimulateController">`EntityBehaviour.SimulateController` on google.com</a></footer>
    public virtual void SimulateController()
    {
    }

    /// <summary>Invoked when you gain control of this entity</summary>
    /// <example>
    /// *Example:* Using the ```ControlGained()``` callback to set up a ```GameCamera``` and ```MiniMap``` to focus on this entity.
    /// 
    /// <code>
    /// public override void ControlGained() {
    ///   GameCamera.instance.AddFollowTarget(this.transform);
    ///   MiniMap.instance.ControlGained(this.entity);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.ControlGained">`EntityBehaviour.ControlGained` on google.com</a></footer>
    public virtual void ControlGained()
    {
    }

    /// <summary>Invoked when you lost control of this entity</summary>
    /// <example>
    /// *Example:* Using the ```ControlLost()``` callback to remove the focus of a ```GameCamera``` and ```MiniMap```.
    /// 
    /// <code>
    /// public override void ControlLost() {
    ///   GameCamera.instance.RemoveFollowTarget();
    ///   MiniMap.instance.ControlLost(this.entity);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.ControlLost">`EntityBehaviour.ControlLost` on google.com</a></footer>
    public virtual void ControlLost()
    {
    }

    /// <summary>
    /// Invoked on the owner when a remote connection is controlling this entity but we have not received any command for the current simulation frame.
    /// </summary>
    /// <param name="previous">The last valid command received</param>
    /// <example>
    /// *Example:* Handling missing input commands by using the last received input command to continue moving in the same direction.
    /// 
    /// <code>
    /// public override void MissingCommand(Bolt.Command previous)
    /// {
    ///   WASDCommand cmd = (WASDCommand)command;
    /// 
    ///   cmd.Result.position motor.Move(cmd.Input.forward, cmd.Input.backward, cmd.Input.left, cmd.Input.right);
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.MissingCommand">`EntityBehaviour.MissingCommand` on google.com</a></footer>
    public virtual void MissingCommand(Command previous)
    {
    }

    /// <summary>
    /// Invoked on both the owner and controller to execute a command
    /// </summary>
    /// <param name="command">The command to execute</param>
    /// <param name="resetState">Indicates if we should reset the state of the local motor or not</param>
    /// <example>
    /// *Example:* Executing a simple WASD movement command. On the client this method can be called multiple times per fixed frame,
    /// beginning with a reset to the last confirmed state (resetState == true), and then again for each unverified input command in the queue (resetState == false);
    /// 
    /// Use the cmd.isFirstExecution property to do any type of one-shot behaviour such as playing sound or animations. This will prevent it from being called each time
    /// the input is replayed on the client.
    /// 
    /// Remember to create and compile a Command asset before using this method!
    /// 
    /// <code>
    /// public override ExecuteCommand(Bolt.Command command, bool resetState) {
    ///   WASDCommand cmd = (WASDCommand)command;
    ///   if(resetState) {
    ///     motor.SetState(cmd.Result.position);
    ///   }
    ///   else {
    ///      cmd.Result.position = motor.Move(cmd.Input.forward, cmd.Input.backward, cmd.Input.left, cmd.Input.right);
    /// 
    ///      if (cmd.IsFirstExecution) {
    ///         AnimatePlayer(cmd);
    ///      }
    ///   }
    /// }
    /// </code>
    /// </example>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.ExecuteCommand">`EntityBehaviour.ExecuteCommand` on google.com</a></footer>
    public virtual void ExecuteCommand(Command command, bool resetState)
    {
    }

    /// <summary>
    /// Utility callback used to signal to the user that this entity is about to be reset by a Command Result.
    /// Using this method, you are able to signal Bolt that the Result of the Command is equaled the current state of your
    /// entity, skipping all the recomputation needed when a Reset command arrives.
    /// </summary>
    /// <param name="command">The Command with ResetState flag as true for ExecuteCommand callback</param>
    /// <returns>True if you want to not recompute everything when local and remote Result match. False otherwise (default always recompute)</returns>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.EntityBehaviour.LocalAndRemoteResultEqual">`EntityBehaviour.LocalAndRemoteResultEqual` on google.com</a></footer>
    public virtual bool LocalAndRemoteResultEqual(Command command) => false;
  }
}
