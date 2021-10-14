// Decompiled with JetBrains decompiler
// Type: UnityEngine.SpringJoint
// Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19391519-2608-4240-8FF9-93819E8AFDF3
// Assembly location: D:\unity\2020.3.14f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The spring joint ties together 2 rigid bodies, spring forces will be automatically applied to keep the object at the given distance.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint.html">External documentation for `SpringJoint`</a></footer>
  [NativeClass("Unity::SpringJoint")]
  [NativeHeader("Modules/Physics/SpringJoint.h")]
  public class SpringJoint : Joint
  {
    /// <summary>
    ///   <para>The spring force used to keep the two objects together.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint-spring.html">External documentation for `SpringJoint.spring`</a></footer>
    public extern float spring { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The damper force used to dampen the spring force.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint-damper.html">External documentation for `SpringJoint.damper`</a></footer>
    public extern float damper { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The minimum distance between the bodies relative to their initial distance.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint-minDistance.html">External documentation for `SpringJoint.minDistance`</a></footer>
    public extern float minDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum distance between the bodies relative to their initial distance.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint-maxDistance.html">External documentation for `SpringJoint.maxDistance`</a></footer>
    public extern float maxDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum allowed error between the current spring length and the length defined by minDistance and maxDistance.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SpringJoint-tolerance.html">External documentation for `SpringJoint.tolerance`</a></footer>
    public extern float tolerance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
  }
}
