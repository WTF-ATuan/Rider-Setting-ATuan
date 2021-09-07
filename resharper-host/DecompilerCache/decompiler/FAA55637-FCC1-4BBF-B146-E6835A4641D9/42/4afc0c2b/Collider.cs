// Decompiled with JetBrains decompiler
// Type: UnityEngine.Collider
// Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FAA55637-FCC1-4BBF-B146-E6835A4641D9
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A base class of all colliders.</para>
  /// </summary>
  [RequiredByNativeCode]
  [RequireComponent(typeof (Transform))]
  [NativeHeader("Modules/Physics/Collider.h")]
  public class Collider : Component
  {
    /// <summary>
    ///   <para>Enabled Colliders will collide with other Colliders, disabled Colliders won't.</para>
    /// </summary>
    public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The rigidbody the collider is attached to.</para>
    /// </summary>
    public extern Rigidbody attachedRigidbody { [NativeMethod("GetRigidbody"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Is the collider a trigger?</para>
    /// </summary>
    public extern bool isTrigger { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Contact offset value of this collider.</para>
    /// </summary>
    public extern float contactOffset { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns a point on the collider that is closest to a given location.</para>
    /// </summary>
    /// <param name="position">Location you want to find the closest point to.</param>
    /// <returns>
    ///   <para>The point on the collider that is closest to the specified location.</para>
    /// </returns>
    public Vector3 ClosestPoint(Vector3 position)
    {
      Vector3 ret;
      this.ClosestPoint_Injected(ref position, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>The world space bounding volume of the collider (Read Only).</para>
    /// </summary>
    public Bounds bounds
    {
      get
      {
        Bounds ret;
        this.get_bounds_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>The shared physic material of this collider.</para>
    /// </summary>
    [NativeMethod("Material")]
    public extern PhysicMaterial sharedMaterial { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The material used by the collider.</para>
    /// </summary>
    public extern PhysicMaterial material { [NativeMethod("GetClonedMaterial"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetMaterial"), MethodImpl(MethodImplOptions.InternalCall)] set; }

    private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
    {
      RaycastHit ret;
      this.Raycast_Injected(ref ray, maxDistance, ref hasHit, out ret);
      return ret;
    }

    public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
    {
      bool hasHit = false;
      hitInfo = this.Raycast(ray, maxDistance, ref hasHit);
      return hasHit;
    }

    [NativeName("ClosestPointOnBounds")]
    private void Internal_ClosestPointOnBounds(
      Vector3 point,
      ref Vector3 outPos,
      ref float distance)
    {
      this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
    }

    /// <summary>
    ///   <para>The closest point to the bounding box of the attached collider.</para>
    /// </summary>
    /// <param name="position"></param>
    public Vector3 ClosestPointOnBounds(Vector3 position)
    {
      float distance = 0.0f;
      Vector3 zero = Vector3.zero;
      this.Internal_ClosestPointOnBounds(position, ref zero, ref distance);
      return zero;
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_bounds_Injected(out Bounds ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Raycast_Injected(
      ref Ray ray,
      float maxDistance,
      ref bool hasHit,
      out RaycastHit ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Internal_ClosestPointOnBounds_Injected(
      ref Vector3 point,
      ref Vector3 outPos,
      ref float distance);
  }
}
