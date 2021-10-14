// Decompiled with JetBrains decompiler
// Type: UnityEngine.Transform
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFC1AD89-0650-411E-946C-FF2E6F276711
// Assembly location: D:\unity\2020.3.14f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Position, rotation and scale of an object.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.html">External documentation for `Transform`</a></footer>
  [NativeHeader("Runtime/Transform/Transform.h")]
  [NativeHeader("Configuration/UnityConfigure.h")]
  [NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
  [RequiredByNativeCode]
  public class Transform : Component, IEnumerable
  {
    protected Transform()
    {
    }

    /// <summary>
    ///   <para>The world space position of the Transform.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-position.html">External documentation for `Transform.position`</a></footer>
    public Vector3 position
    {
      get
      {
        Vector3 ret;
        this.get_position_Injected(out ret);
        return ret;
      }
      set => this.set_position_Injected(ref value);
    }

    /// <summary>
    ///   <para>Position of the transform relative to the parent transform.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-localPosition.html">External documentation for `Transform.localPosition`</a></footer>
    public Vector3 localPosition
    {
      get
      {
        Vector3 ret;
        this.get_localPosition_Injected(out ret);
        return ret;
      }
      set => this.set_localPosition_Injected(ref value);
    }

    internal Vector3 GetLocalEulerAngles(RotationOrder order)
    {
      Vector3 ret;
      this.GetLocalEulerAngles_Injected(order, out ret);
      return ret;
    }

    internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) => this.SetLocalEulerAngles_Injected(ref euler, order);

    [NativeConditional("UNITY_EDITOR")]
    internal void SetLocalEulerHint(Vector3 euler) => this.SetLocalEulerHint_Injected(ref euler);

    /// <summary>
    ///   <para>The rotation as Euler angles in degrees.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-eulerAngles.html">External documentation for `Transform.eulerAngles`</a></footer>
    public Vector3 eulerAngles
    {
      get => this.rotation.eulerAngles;
      set => this.rotation = Quaternion.Euler(value);
    }

    /// <summary>
    ///   <para>The rotation as Euler angles in degrees relative to the parent transform's rotation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-localEulerAngles.html">External documentation for `Transform.localEulerAngles`</a></footer>
    public Vector3 localEulerAngles
    {
      get => this.localRotation.eulerAngles;
      set => this.localRotation = Quaternion.Euler(value);
    }

    /// <summary>
    ///   <para>The red axis of the transform in world space.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-right.html">External documentation for `Transform.right`</a></footer>
    public Vector3 right
    {
      get => this.rotation * Vector3.right;
      set => this.rotation = Quaternion.FromToRotation(Vector3.right, value);
    }

    /// <summary>
    ///   <para>The green axis of the transform in world space.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-up.html">External documentation for `Transform.up`</a></footer>
    public Vector3 up
    {
      get => this.rotation * Vector3.up;
      set => this.rotation = Quaternion.FromToRotation(Vector3.up, value);
    }

    /// <summary>
    ///   <para>Returns a normalized vector representing the blue axis of the transform in world space.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-forward.html">External documentation for `Transform.forward`</a></footer>
    public Vector3 forward
    {
      get => this.rotation * Vector3.forward;
      set => this.rotation = Quaternion.LookRotation(value);
    }

    /// <summary>
    ///   <para>A Quaternion that stores the rotation of the Transform in world space.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-rotation.html">External documentation for `Transform.rotation`</a></footer>
    public Quaternion rotation
    {
      get
      {
        Quaternion ret;
        this.get_rotation_Injected(out ret);
        return ret;
      }
      set => this.set_rotation_Injected(ref value);
    }

    /// <summary>
    ///   <para>The rotation of the transform relative to the transform rotation of the parent.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-localRotation.html">External documentation for `Transform.localRotation`</a></footer>
    public Quaternion localRotation
    {
      get
      {
        Quaternion ret;
        this.get_localRotation_Injected(out ret);
        return ret;
      }
      set => this.set_localRotation_Injected(ref value);
    }

    [NativeConditional("UNITY_EDITOR")]
    internal RotationOrder rotationOrder
    {
      get => (RotationOrder) this.GetRotationOrderInternal();
      set => this.SetRotationOrderInternal(value);
    }

    [NativeConditional("UNITY_EDITOR")]
    [NativeMethod("GetRotationOrder")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern int GetRotationOrderInternal();

    [NativeConditional("UNITY_EDITOR")]
    [NativeMethod("SetRotationOrder")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void SetRotationOrderInternal(RotationOrder rotationOrder);

    /// <summary>
    ///   <para>The scale of the transform relative to the GameObjects parent.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-localScale.html">External documentation for `Transform.localScale`</a></footer>
    public Vector3 localScale
    {
      get
      {
        Vector3 ret;
        this.get_localScale_Injected(out ret);
        return ret;
      }
      set => this.set_localScale_Injected(ref value);
    }

    /// <summary>
    ///   <para>The parent of the transform.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-parent.html">External documentation for `Transform.parent`</a></footer>
    public Transform parent
    {
      get => this.parentInternal;
      set
      {
        if (this is RectTransform)
          Debug.LogWarning((object) "Parent of RectTransform is being set with parent property. Consider using the SetParent method instead, with the worldPositionStays argument set to false. This will retain local orientation and scale rather than world orientation and scale, which can prevent common UI scaling issues.", (Object) this);
        this.parentInternal = value;
      }
    }

    internal Transform parentInternal
    {
      get => this.GetParent();
      set => this.SetParent(value);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Transform GetParent();

    /// <summary>
    ///   <para>Set the parent of the transform.</para>
    /// </summary>
    /// <param name="parent">The parent Transform to use.</param>
    /// <param name="worldPositionStays">If true, the parent-relative position, scale and rotation are modified such that the object keeps the same world space position, rotation and scale as before.</param>
    /// <param name="p"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetParent.html">External documentation for `Transform.SetParent`</a></footer>
    public void SetParent(Transform p) => this.SetParent(p, true);

    /// <summary>
    ///   <para>Set the parent of the transform.</para>
    /// </summary>
    /// <param name="parent">The parent Transform to use.</param>
    /// <param name="worldPositionStays">If true, the parent-relative position, scale and rotation are modified such that the object keeps the same world space position, rotation and scale as before.</param>
    /// <param name="p"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetParent.html">External documentation for `Transform.SetParent`</a></footer>
    [FreeFunction("SetParent", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetParent(Transform parent, bool worldPositionStays);

    /// <summary>
    ///   <para>Matrix that transforms a point from world space into local space (Read Only).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-worldToLocalMatrix.html">External documentation for `Transform.worldToLocalMatrix`</a></footer>
    public Matrix4x4 worldToLocalMatrix
    {
      get
      {
        Matrix4x4 ret;
        this.get_worldToLocalMatrix_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Matrix that transforms a point from local space into world space (Read Only).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-localToWorldMatrix.html">External documentation for `Transform.localToWorldMatrix`</a></footer>
    public Matrix4x4 localToWorldMatrix
    {
      get
      {
        Matrix4x4 ret;
        this.get_localToWorldMatrix_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Sets the world space position and rotation of the Transform component.</para>
    /// </summary>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetPositionAndRotation.html">External documentation for `Transform.SetPositionAndRotation`</a></footer>
    public void SetPositionAndRotation(Vector3 position, Quaternion rotation) => this.SetPositionAndRotation_Injected(ref position, ref rotation);

    /// <summary>
    ///   <para>Moves the transform in the direction and distance of translation.</para>
    /// </summary>
    /// <param name="translation"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
    {
      if (relativeTo == Space.World)
        this.position += translation;
      else
        this.position += this.TransformDirection(translation);
    }

    /// <summary>
    ///   <para>Moves the transform in the direction and distance of translation.</para>
    /// </summary>
    /// <param name="translation"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(Vector3 translation) => this.Translate(translation, Space.Self);

    /// <summary>
    ///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo) => this.Translate(new Vector3(x, y, z), relativeTo);

    /// <summary>
    ///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(float x, float y, float z) => this.Translate(new Vector3(x, y, z), Space.Self);

    /// <summary>
    ///   <para>Moves the transform in the direction and distance of translation.</para>
    /// </summary>
    /// <param name="translation"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(Vector3 translation, Transform relativeTo)
    {
      if ((bool) (Object) relativeTo)
        this.position += relativeTo.TransformDirection(translation);
      else
        this.position += translation;
    }

    /// <summary>
    ///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <param name="relativeTo"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Translate.html">External documentation for `Transform.Translate`</a></footer>
    public void Translate(float x, float y, float z, Transform relativeTo) => this.Translate(new Vector3(x, y, z), relativeTo);

    /// <summary>
    ///   <para>Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that order).</para>
    /// </summary>
    /// <param name="eulers">The rotation to apply in euler angles.</param>
    /// <param name="relativeTo">Determines whether to rotate the GameObject either locally to  the GameObject or relative to the Scene in world space.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo)
    {
      Quaternion quaternion = Quaternion.Euler(eulers.x, eulers.y, eulers.z);
      if (relativeTo == Space.Self)
        this.localRotation *= quaternion;
      else
        this.rotation *= Quaternion.Inverse(this.rotation) * quaternion * this.rotation;
    }

    /// <summary>
    ///   <para>Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that order).</para>
    /// </summary>
    /// <param name="eulers">The rotation to apply in euler angles.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(Vector3 eulers) => this.Rotate(eulers, Space.Self);

    /// <summary>
    ///   <para>The implementation of this method applies a rotation of zAngle degrees around the z axis, xAngle degrees around the x axis, and yAngle degrees around the y axis (in that order).</para>
    /// </summary>
    /// <param name="relativeTo">Determines whether to rotate the GameObject either locally to the GameObject or relative to the Scene in world space.</param>
    /// <param name="xAngle">Degrees to rotate the GameObject around the X axis.</param>
    /// <param name="yAngle">Degrees to rotate the GameObject around the Y axis.</param>
    /// <param name="zAngle">Degrees to rotate the GameObject around the Z axis.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo) => this.Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);

    /// <summary>
    ///   <para>The implementation of this method applies a rotation of zAngle degrees around the z axis, xAngle degrees around the x axis, and yAngle degrees around the y axis (in that order).</para>
    /// </summary>
    /// <param name="xAngle">Degrees to rotate the GameObject around the X axis.</param>
    /// <param name="yAngle">Degrees to rotate the GameObject around the Y axis.</param>
    /// <param name="zAngle">Degrees to rotate the GameObject around the Z axis.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(float xAngle, float yAngle, float zAngle) => this.Rotate(new Vector3(xAngle, yAngle, zAngle), Space.Self);

    [NativeMethod("RotateAround")]
    internal void RotateAroundInternal(Vector3 axis, float angle) => this.RotateAroundInternal_Injected(ref axis, angle);

    /// <summary>
    ///   <para>Rotates the object around the given axis by the number of degrees defined by the given angle.</para>
    /// </summary>
    /// <param name="angle">The degrees of rotation to apply.</param>
    /// <param name="axis">The axis to apply rotation to.</param>
    /// <param name="relativeTo">Determines whether to rotate the GameObject either locally to the GameObject or relative to the Scene in world space.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
    {
      if (relativeTo == Space.Self)
        this.RotateAroundInternal(this.transform.TransformDirection(axis), angle * ((float) Math.PI / 180f));
      else
        this.RotateAroundInternal(axis, angle * ((float) Math.PI / 180f));
    }

    /// <summary>
    ///   <para>Rotates the object around the given axis by the number of degrees defined by the given angle.</para>
    /// </summary>
    /// <param name="axis">The axis to apply rotation to.</param>
    /// <param name="angle">The degrees of rotation to apply.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Rotate.html">External documentation for `Transform.Rotate`</a></footer>
    public void Rotate(Vector3 axis, float angle) => this.Rotate(axis, angle, Space.Self);

    /// <summary>
    ///   <para>Rotates the transform about axis passing through point in world coordinates by angle degrees.</para>
    /// </summary>
    /// <param name="point"></param>
    /// <param name="axis"></param>
    /// <param name="angle"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.RotateAround.html">External documentation for `Transform.RotateAround`</a></footer>
    public void RotateAround(Vector3 point, Vector3 axis, float angle)
    {
      Vector3 position = this.position;
      Vector3 vector3 = Quaternion.AngleAxis(angle, axis) * (position - point);
      this.position = point + vector3;
      this.RotateAroundInternal(axis, angle * ((float) Math.PI / 180f));
    }

    /// <summary>
    ///   <para>Rotates the transform so the forward vector points at target's current position.</para>
    /// </summary>
    /// <param name="target">Object to point towards.</param>
    /// <param name="worldUp">Vector specifying the upward direction.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.LookAt.html">External documentation for `Transform.LookAt`</a></footer>
    public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
    {
      if (!(bool) (Object) target)
        return;
      this.LookAt(target.position, worldUp);
    }

    /// <summary>
    ///   <para>Rotates the transform so the forward vector points at target's current position.</para>
    /// </summary>
    /// <param name="target">Object to point towards.</param>
    /// <param name="worldUp">Vector specifying the upward direction.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.LookAt.html">External documentation for `Transform.LookAt`</a></footer>
    public void LookAt(Transform target)
    {
      if (!(bool) (Object) target)
        return;
      this.LookAt(target.position, Vector3.up);
    }

    /// <summary>
    ///   <para>Rotates the transform so the forward vector points at worldPosition.</para>
    /// </summary>
    /// <param name="worldPosition">Point to look at.</param>
    /// <param name="worldUp">Vector specifying the upward direction.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.LookAt.html">External documentation for `Transform.LookAt`</a></footer>
    public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp) => this.Internal_LookAt(worldPosition, worldUp);

    /// <summary>
    ///   <para>Rotates the transform so the forward vector points at worldPosition.</para>
    /// </summary>
    /// <param name="worldPosition">Point to look at.</param>
    /// <param name="worldUp">Vector specifying the upward direction.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.LookAt.html">External documentation for `Transform.LookAt`</a></footer>
    public void LookAt(Vector3 worldPosition) => this.Internal_LookAt(worldPosition, Vector3.up);

    [FreeFunction("Internal_LookAt", HasExplicitThis = true)]
    private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) => this.Internal_LookAt_Injected(ref worldPosition, ref worldUp);

    /// <summary>
    ///   <para>Transforms direction from local space to world space.</para>
    /// </summary>
    /// <param name="direction"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformDirection.html">External documentation for `Transform.TransformDirection`</a></footer>
    public Vector3 TransformDirection(Vector3 direction)
    {
      Vector3 ret;
      this.TransformDirection_Injected(ref direction, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms direction x, y, z from local space to world space.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformDirection.html">External documentation for `Transform.TransformDirection`</a></footer>
    public Vector3 TransformDirection(float x, float y, float z) => this.TransformDirection(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Transforms a direction from world space to local space. The opposite of Transform.TransformDirection.</para>
    /// </summary>
    /// <param name="direction"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformDirection.html">External documentation for `Transform.InverseTransformDirection`</a></footer>
    public Vector3 InverseTransformDirection(Vector3 direction)
    {
      Vector3 ret;
      this.InverseTransformDirection_Injected(ref direction, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms the direction x, y, z from world space to local space. The opposite of Transform.TransformDirection.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformDirection.html">External documentation for `Transform.InverseTransformDirection`</a></footer>
    public Vector3 InverseTransformDirection(float x, float y, float z) => this.InverseTransformDirection(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Transforms vector from local space to world space.</para>
    /// </summary>
    /// <param name="vector"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformVector.html">External documentation for `Transform.TransformVector`</a></footer>
    public Vector3 TransformVector(Vector3 vector)
    {
      Vector3 ret;
      this.TransformVector_Injected(ref vector, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms vector x, y, z from local space to world space.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformVector.html">External documentation for `Transform.TransformVector`</a></footer>
    public Vector3 TransformVector(float x, float y, float z) => this.TransformVector(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Transforms a vector from world space to local space. The opposite of Transform.TransformVector.</para>
    /// </summary>
    /// <param name="vector"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformVector.html">External documentation for `Transform.InverseTransformVector`</a></footer>
    public Vector3 InverseTransformVector(Vector3 vector)
    {
      Vector3 ret;
      this.InverseTransformVector_Injected(ref vector, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms the vector x, y, z from world space to local space. The opposite of Transform.TransformVector.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformVector.html">External documentation for `Transform.InverseTransformVector`</a></footer>
    public Vector3 InverseTransformVector(float x, float y, float z) => this.InverseTransformVector(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Transforms position from local space to world space.</para>
    /// </summary>
    /// <param name="position"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformPoint.html">External documentation for `Transform.TransformPoint`</a></footer>
    public Vector3 TransformPoint(Vector3 position)
    {
      Vector3 ret;
      this.TransformPoint_Injected(ref position, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms the position x, y, z from local space to world space.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.TransformPoint.html">External documentation for `Transform.TransformPoint`</a></footer>
    public Vector3 TransformPoint(float x, float y, float z) => this.TransformPoint(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Transforms position from world space to local space.</para>
    /// </summary>
    /// <param name="position"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformPoint.html">External documentation for `Transform.InverseTransformPoint`</a></footer>
    public Vector3 InverseTransformPoint(Vector3 position)
    {
      Vector3 ret;
      this.InverseTransformPoint_Injected(ref position, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Transforms the position x, y, z from world space to local space. The opposite of Transform.TransformPoint.</para>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.InverseTransformPoint.html">External documentation for `Transform.InverseTransformPoint`</a></footer>
    public Vector3 InverseTransformPoint(float x, float y, float z) => this.InverseTransformPoint(new Vector3(x, y, z));

    /// <summary>
    ///   <para>Returns the topmost transform in the hierarchy.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-root.html">External documentation for `Transform.root`</a></footer>
    public Transform root => this.GetRoot();

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Transform GetRoot();

    /// <summary>
    ///   <para>The number of children the parent Transform has.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-childCount.html">External documentation for `Transform.childCount`</a></footer>
    public extern int childCount { [NativeMethod("GetChildrenCount"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Unparents all children.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.DetachChildren.html">External documentation for `Transform.DetachChildren`</a></footer>
    [FreeFunction("DetachChildren", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void DetachChildren();

    /// <summary>
    ///   <para>Move the transform to the start of the local transform list.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetAsFirstSibling.html">External documentation for `Transform.SetAsFirstSibling`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetAsFirstSibling();

    /// <summary>
    ///   <para>Move the transform to the end of the local transform list.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetAsLastSibling.html">External documentation for `Transform.SetAsLastSibling`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetAsLastSibling();

    /// <summary>
    ///   <para>Sets the sibling index.</para>
    /// </summary>
    /// <param name="index">Index to set.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.SetSiblingIndex.html">External documentation for `Transform.SetSiblingIndex`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetSiblingIndex(int index);

    [NativeMethod("MoveAfterSiblingInternal")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty);

    /// <summary>
    ///   <para>Gets the sibling index.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.GetSiblingIndex.html">External documentation for `Transform.GetSiblingIndex`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int GetSiblingIndex();

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Transform FindRelativeTransformWithPath(
      [NotNull("NullExceptionObject")] Transform transform,
      string path,
      [DefaultValue("false")] bool isActiveOnly);

    /// <summary>
    ///   <para>Finds a child by n and returns it.</para>
    /// </summary>
    /// <param name="n">Name of child to be found.</param>
    /// <returns>
    ///   <para>The returned child transform or null if no child is found.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.Find.html">External documentation for `Transform.Find`</a></footer>
    public Transform Find(string n) => n != null ? Transform.FindRelativeTransformWithPath(this, n, false) : throw new ArgumentNullException("Name cannot be null");

    [NativeConditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern void SendTransformChangedScale();

    /// <summary>
    ///   <para>The global scale of the object (Read Only).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-lossyScale.html">External documentation for `Transform.lossyScale`</a></footer>
    public Vector3 lossyScale
    {
      [NativeMethod("GetWorldScaleLossy")] get
      {
        Vector3 ret;
        this.get_lossyScale_Injected(out ret);
        return ret;
      }
    }

    /// <summary>
    ///   <para>Is this transform a child of parent?</para>
    /// </summary>
    /// <param name="parent"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.IsChildOf.html">External documentation for `Transform.IsChildOf`</a></footer>
    [FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool IsChildOf([NotNull("ArgumentNullException")] Transform parent);

    /// <summary>
    ///   <para>Has the transform changed since the last time the flag was set to 'false'?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-hasChanged.html">External documentation for `Transform.hasChanged`</a></footer>
    [NativeProperty("HasChangedDeprecated")]
    public extern bool hasChanged { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", false)]
    public Transform FindChild(string n) => this.Find(n);

    public IEnumerator GetEnumerator() => (IEnumerator) new Transform.Enumerator(this);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="axis"></param>
    /// <param name="angle"></param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.RotateAround.html">External documentation for `Transform.RotateAround`</a></footer>
    [Obsolete("warning use Transform.Rotate instead.")]
    public void RotateAround(Vector3 axis, float angle) => this.RotateAround_Injected(ref axis, angle);

    [Obsolete("warning use Transform.Rotate instead.")]
    public void RotateAroundLocal(Vector3 axis, float angle) => this.RotateAroundLocal_Injected(ref axis, angle);

    /// <summary>
    ///   <para>Returns a transform child by index.</para>
    /// </summary>
    /// <param name="index">Index of the child transform to return. Must be smaller than Transform.childCount.</param>
    /// <returns>
    ///   <para>Transform child by index.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform.GetChild.html">External documentation for `Transform.GetChild`</a></footer>
    [NativeThrows]
    [FreeFunction("GetChild", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern Transform GetChild(int index);

    [NativeMethod("GetChildrenCount")]
    [Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", false)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int GetChildCount();

    /// <summary>
    ///   <para>The transform capacity of the transform's hierarchy data structure.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-hierarchyCapacity.html">External documentation for `Transform.hierarchyCapacity`</a></footer>
    public int hierarchyCapacity
    {
      get => this.internal_getHierarchyCapacity();
      set => this.internal_setHierarchyCapacity(value);
    }

    [FreeFunction("GetHierarchyCapacity", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int internal_getHierarchyCapacity();

    [FreeFunction("SetHierarchyCapacity", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void internal_setHierarchyCapacity(int value);

    /// <summary>
    ///   <para>The number of transforms in the transform's hierarchy data structure.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Transform-hierarchyCount.html">External documentation for `Transform.hierarchyCount`</a></footer>
    public int hierarchyCount => this.internal_getHierarchyCount();

    [FreeFunction("GetHierarchyCount", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int internal_getHierarchyCount();

    [NativeConditional("UNITY_EDITOR")]
    [FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal extern bool IsNonUniformScaleTransform();

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_position_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_position_Injected(ref Vector3 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_localPosition_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_localPosition_Injected(ref Vector3 value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetLocalEulerHint_Injected(ref Vector3 euler);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_rotation_Injected(out Quaternion ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_rotation_Injected(ref Quaternion value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_localRotation_Injected(out Quaternion ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_localRotation_Injected(ref Quaternion value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_localScale_Injected(out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void set_localScale_Injected(ref Vector3 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_worldToLocalMatrix_Injected(out Matrix4x4 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_localToWorldMatrix_Injected(out Matrix4x4 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetPositionAndRotation_Injected(
      ref Vector3 position,
      ref Quaternion rotation);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void RotateAroundInternal_Injected(ref Vector3 axis, float angle);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void TransformVector_Injected(ref Vector3 vector, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void TransformPoint_Injected(ref Vector3 position, out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void get_lossyScale_Injected(out Vector3 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void RotateAround_Injected(ref Vector3 axis, float angle);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void RotateAroundLocal_Injected(ref Vector3 axis, float angle);

    private class Enumerator : IEnumerator
    {
      private Transform outer;
      private int currentIndex = -1;

      internal Enumerator(Transform outer) => this.outer = outer;

      public object Current => (object) this.outer.GetChild(this.currentIndex);

      public bool MoveNext() => ++this.currentIndex < this.outer.childCount;

      public void Reset() => this.currentIndex = -1;
    }
  }
}
