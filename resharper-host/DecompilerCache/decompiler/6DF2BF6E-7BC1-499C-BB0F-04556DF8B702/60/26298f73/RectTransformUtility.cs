// Decompiled with JetBrains decompiler
// Type: UnityEngine.RectTransformUtility
// Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6DF2BF6E-7BC1-499C-BB0F-04556DF8B702
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Utility class containing helper methods for working with  RectTransform.</para>
  /// </summary>
  [NativeHeader("Runtime/Camera/Camera.h")]
  [NativeHeader("Modules/UI/Canvas.h")]
  [NativeHeader("Modules/UI/RectTransformUtil.h")]
  [NativeHeader("Runtime/Transform/RectTransform.h")]
  [StaticAccessor("UI", StaticAccessorType.DoubleColon)]
  public sealed class RectTransformUtility
  {
    private static readonly Vector3[] s_Corners = new Vector3[4];

    /// <summary>
    ///   <para>Convert a given point in screen space into a pixel correct point.</para>
    /// </summary>
    /// <param name="point"></param>
    /// <param name="elementTransform"></param>
    /// <param name="canvas"></param>
    /// <returns>
    ///   <para>Pixel adjusted point.</para>
    /// </returns>
    public static Vector2 PixelAdjustPoint(
      Vector2 point,
      Transform elementTransform,
      Canvas canvas)
    {
      Vector2 ret;
      RectTransformUtility.PixelAdjustPoint_Injected(ref point, elementTransform, canvas, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Given a rect transform, return the corner points in pixel accurate coordinates.</para>
    /// </summary>
    /// <param name="rectTransform"></param>
    /// <param name="canvas"></param>
    /// <returns>
    ///   <para>Pixel adjusted rect.</para>
    /// </returns>
    public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
    {
      Rect ret;
      RectTransformUtility.PixelAdjustRect_Injected(rectTransform, canvas, out ret);
      return ret;
    }

    private static bool PointInRectangle(
      Vector2 screenPoint,
      RectTransform rect,
      Camera cam,
      Vector4 offset)
    {
      return RectTransformUtility.PointInRectangle_Injected(ref screenPoint, rect, cam, ref offset);
    }

    private RectTransformUtility()
    {
    }

    public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) => RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, (Camera) null);

    /// <summary>
    ///   <para>Does the RectTransform contain the screen point as seen from the given camera?</para>
    /// </summary>
    /// <param name="rect">The RectTransform to test with.</param>
    /// <param name="screenPoint">The screen point to test.</param>
    /// <param name="cam">The camera from which the test is performed from. (Optional)</param>
    /// <returns>
    ///   <para>True if the point is inside the rectangle.</para>
    /// </returns>
    public static bool RectangleContainsScreenPoint(
      RectTransform rect,
      Vector2 screenPoint,
      Camera cam)
    {
      return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, cam, Vector4.zero);
    }

    public static bool RectangleContainsScreenPoint(
      RectTransform rect,
      Vector2 screenPoint,
      Camera cam,
      Vector4 offset)
    {
      return RectTransformUtility.PointInRectangle(screenPoint, rect, cam, offset);
    }

    public static bool ScreenPointToWorldPointInRectangle(
      RectTransform rect,
      Vector2 screenPoint,
      Camera cam,
      out Vector3 worldPoint)
    {
      worldPoint = (Vector3) Vector2.zero;
      Ray ray = RectTransformUtility.ScreenPointToRay(cam, screenPoint);
      float enter;
      if (!new Plane(rect.rotation * Vector3.back, rect.position).Raycast(ray, out enter))
        return false;
      worldPoint = ray.GetPoint(enter);
      return true;
    }

    public static bool ScreenPointToLocalPointInRectangle(
      RectTransform rect,
      Vector2 screenPoint,
      Camera cam,
      out Vector2 localPoint)
    {
      localPoint = Vector2.zero;
      Vector3 worldPoint;
      if (!RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPoint, cam, out worldPoint))
        return false;
      localPoint = (Vector2) rect.InverseTransformPoint(worldPoint);
      return true;
    }

    public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
    {
      if ((Object) cam != (Object) null)
        return cam.ScreenPointToRay((Vector3) screenPos);
      Vector3 origin = (Vector3) screenPos;
      origin.z -= 100f;
      return new Ray(origin, Vector3.forward);
    }

    public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) => (Object) cam == (Object) null ? new Vector2(worldPoint.x, worldPoint.y) : (Vector2) cam.WorldToScreenPoint(worldPoint);

    public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
    {
      RectTransform[] componentsInChildren = child.GetComponentsInChildren<RectTransform>(false);
      if ((uint) componentsInChildren.Length <= 0U)
        return new Bounds(Vector3.zero, Vector3.zero);
      Vector3 vector3_1 = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
      Vector3 vector3_2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
      Matrix4x4 worldToLocalMatrix = root.worldToLocalMatrix;
      int index1 = 0;
      for (int length = componentsInChildren.Length; index1 < length; ++index1)
      {
        componentsInChildren[index1].GetWorldCorners(RectTransformUtility.s_Corners);
        for (int index2 = 0; index2 < 4; ++index2)
        {
          Vector3 lhs = worldToLocalMatrix.MultiplyPoint3x4(RectTransformUtility.s_Corners[index2]);
          vector3_1 = Vector3.Min(lhs, vector3_1);
          vector3_2 = Vector3.Max(lhs, vector3_2);
        }
      }
      Bounds bounds = new Bounds(vector3_1, Vector3.zero);
      bounds.Encapsulate(vector3_2);
      return bounds;
    }

    public static Bounds CalculateRelativeRectTransformBounds(Transform trans) => RectTransformUtility.CalculateRelativeRectTransformBounds(trans, trans);

    /// <summary>
    ///   <para>Flips the alignment of the RectTransform along the horizontal or vertical axis, and optionally its children as well.</para>
    /// </summary>
    /// <param name="rect">The RectTransform to flip.</param>
    /// <param name="keepPositioning">Flips around the pivot if true. Flips within the parent rect if false.</param>
    /// <param name="recursive">Flip the children as well?</param>
    /// <param name="axis">The axis to flip along. 0 is horizontal and 1 is vertical.</param>
    public static void FlipLayoutOnAxis(
      RectTransform rect,
      int axis,
      bool keepPositioning,
      bool recursive)
    {
      if ((Object) rect == (Object) null)
        return;
      if (recursive)
      {
        for (int index = 0; index < rect.childCount; ++index)
        {
          RectTransform child = rect.GetChild(index) as RectTransform;
          if ((Object) child != (Object) null)
            RectTransformUtility.FlipLayoutOnAxis(child, axis, false, true);
        }
      }
      Vector2 pivot = rect.pivot;
      pivot[axis] = 1f - pivot[axis];
      rect.pivot = pivot;
      if (keepPositioning)
        return;
      Vector2 anchoredPosition = rect.anchoredPosition;
      anchoredPosition[axis] = -anchoredPosition[axis];
      rect.anchoredPosition = anchoredPosition;
      Vector2 anchorMin = rect.anchorMin;
      Vector2 anchorMax = rect.anchorMax;
      float num = anchorMin[axis];
      anchorMin[axis] = 1f - anchorMax[axis];
      anchorMax[axis] = 1f - num;
      rect.anchorMin = anchorMin;
      rect.anchorMax = anchorMax;
    }

    /// <summary>
    ///   <para>Flips the horizontal and vertical axes of the RectTransform size and alignment, and optionally its children as well.</para>
    /// </summary>
    /// <param name="rect">The RectTransform to flip.</param>
    /// <param name="keepPositioning">Flips around the pivot if true. Flips within the parent rect if false.</param>
    /// <param name="recursive">Flip the children as well?</param>
    public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
    {
      if ((Object) rect == (Object) null)
        return;
      if (recursive)
      {
        for (int index = 0; index < rect.childCount; ++index)
        {
          RectTransform child = rect.GetChild(index) as RectTransform;
          if ((Object) child != (Object) null)
            RectTransformUtility.FlipLayoutAxes(child, false, true);
        }
      }
      rect.pivot = RectTransformUtility.GetTransposed(rect.pivot);
      rect.sizeDelta = RectTransformUtility.GetTransposed(rect.sizeDelta);
      if (keepPositioning)
        return;
      rect.anchoredPosition = RectTransformUtility.GetTransposed(rect.anchoredPosition);
      rect.anchorMin = RectTransformUtility.GetTransposed(rect.anchorMin);
      rect.anchorMax = RectTransformUtility.GetTransposed(rect.anchorMax);
    }

    private static Vector2 GetTransposed(Vector2 input) => new Vector2(input.y, input.x);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void PixelAdjustPoint_Injected(
      ref Vector2 point,
      Transform elementTransform,
      Canvas canvas,
      out Vector2 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void PixelAdjustRect_Injected(
      RectTransform rectTransform,
      Canvas canvas,
      out Rect ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool PointInRectangle_Injected(
      ref Vector2 screenPoint,
      RectTransform rect,
      Camera cam,
      ref Vector4 offset);
  }
}
