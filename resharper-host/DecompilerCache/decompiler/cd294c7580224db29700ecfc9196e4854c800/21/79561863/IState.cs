// Decompiled with JetBrains decompiler
// Type: Photon.Bolt.IState
// Assembly: bolt, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: CD294C75-8022-4DB2-9700-ECFC9196E485
// Assembly location: D:\unity\project\Photon-Networking-Project\Assets\Photon\PhotonBolt\assemblies\bolt.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.Bolt
{
  /// <summary>Base interface for all states</summary>
  /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState">`IState` on google.com</a></footer>
  [Documentation]
  public interface IState : IDisposable
  {
    /// <summary>
    /// The Animator component associated with this entity state
    /// </summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.Animator">`IState.Animator` on google.com</a></footer>
    Animator Animator { get; }

    /// <summary>
    /// A collection of all Animator components associated with this entity state
    /// </summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.AllAnimators">`IState.AllAnimators` on google.com</a></footer>
    IEnumerable<Animator> AllAnimators { get; }

    /// <summary>
    /// Set the animator object this state should use for reading/writing mecanim parameters
    /// </summary>
    /// <param name="animator">The animator object to use</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.SetAnimator">`IState.SetAnimator` on google.com</a></footer>
    void SetAnimator(Animator animator);

    void AddAnimator(Animator animator);

    /// <summary>
    /// Allows you to hook up a callback to a specific property
    /// </summary>
    /// <param name="path">The path of the property</param>
    /// <param name="callback">The callback delegate</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.AddCallback">`IState.AddCallback` on google.com</a></footer>
    void AddCallback(string path, PropertyCallback callback);

    /// <summary>
    /// Allows you to hook up a callback to a specific property
    /// </summary>
    /// <param name="path">The path of the property</param>
    /// <param name="callback">The callback delegate</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.AddCallback">`IState.AddCallback` on google.com</a></footer>
    void AddCallback(string path, PropertyCallbackSimple callback);

    /// <summary>Removes a callback from a property</summary>
    /// <param name="path">The path of the property</param>
    /// <param name="callback">The callback delegate to remove</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.RemoveCallback">`IState.RemoveCallback` on google.com</a></footer>
    void RemoveCallback(string path, PropertyCallback callback);

    /// <summary>Removes a callback from a property</summary>
    /// <param name="path">The path of the property</param>
    /// <param name="callback">The callback delegate to remove</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.RemoveCallback">`IState.RemoveCallback` on google.com</a></footer>
    void RemoveCallback(string path, PropertyCallbackSimple callback);

    /// <summary>
    /// Clears all callbacks currently set.  This is useful when pooling entities and you wish to clear out the current callbacks before returning the entity to the pool.
    /// </summary>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.RemoveAllCallbacks">`IState.RemoveAllCallbacks` on google.com</a></footer>
    void RemoveAllCallbacks();

    /// <summary>Set a property dynamically by string name</summary>
    /// <param name="property">The property name to set</param>
    /// <param name="value">The property value to set</param>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.SetDynamic">`IState.SetDynamic` on google.com</a></footer>
    void SetDynamic(string property, object value);

    /// <summary>Gets a property dynamically by string name</summary>
    /// <param name="property">The property name to get</param>
    /// <returns></returns>
    /// <footer><a href="https://www.google.com/search?q=Photon.Bolt.IState.GetDynamic">`IState.GetDynamic` on google.com</a></footer>
    object GetDynamic(string property);

    bool TrySetDynamic(string property, object value);

    bool TryGetDynamic(string property, out object value);

    void SetTeleport(NetworkTransform transform);

    void SetTransforms(NetworkTransform transform, Transform simulate);

    void SetTransforms(NetworkTransform transform, Transform simulate, Transform render);

    void ForceTransform(NetworkTransform transform, Vector3 position);

    void ForceTransform(NetworkTransform transform, Vector3 position, Quaternion rotation);
  }
}
