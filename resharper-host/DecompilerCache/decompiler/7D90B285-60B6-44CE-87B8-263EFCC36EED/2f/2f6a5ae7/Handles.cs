// Decompiled with JetBrains decompiler
// Type: UnityEditor.Handles
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D90B285-60B6-44CE-87B8-263EFCC36EED
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEditor.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Custom 3D GUI controls and drawing in the Scene view.</para>
  /// </summary>
  [NativeHeader("Editor/Src/Handles/Handles.bindings.h")]
  public sealed class Handles
  {
    internal static PrefColor s_XAxisColor = new PrefColor("Scene/X Axis", 0.8588235f, 0.2431373f, 0.1137255f, 0.93f);
    internal static PrefColor s_YAxisColor = new PrefColor("Scene/Y Axis", 0.6039216f, 0.9529412f, 0.282353f, 0.93f);
    internal static PrefColor s_ZAxisColor = new PrefColor("Scene/Z Axis", 0.227451f, 0.4784314f, 0.972549f, 0.93f);
    internal static PrefColor s_CenterColor = new PrefColor("Scene/Center Axis", 0.8f, 0.8f, 0.8f, 0.93f);
    internal static PrefColor s_SelectedColor = new PrefColor("Scene/Selected Axis", 0.9647059f, 0.9490196f, 0.1960784f, 0.89f);
    internal static PrefColor s_PreselectionColor = new PrefColor("Scene/Preselection Highlight", 0.7882353f, 0.7843137f, 0.5647059f, 0.89f);
    internal static PrefColor s_SecondaryColor = new PrefColor("Scene/Guide Line", 0.5f, 0.5f, 0.5f, 0.2f);
    internal static Color staticColor = new Color(0.5f, 0.5f, 0.5f, 0.0f);
    internal static float staticBlend = 0.6f;
    internal static float backfaceAlphaMultiplier = 0.2f;
    internal static Color s_ColliderHandleColor = new Color(145f, 244f, 139f, 210f) / (float) byte.MaxValue;
    internal static Color s_ColliderHandleColorDisabled = new Color(84f, 200f, 77f, 140f) / (float) byte.MaxValue;
    internal static Color s_BoundingBoxHandleColor = new Color((float) byte.MaxValue, (float) byte.MaxValue, (float) byte.MaxValue, 150f) / (float) byte.MaxValue;
    private static GUIContent s_Static = EditorGUIUtility.TrTextContent("Static");
    internal static int s_SliderHash = "SliderHash".GetHashCode();
    internal static int s_Slider2DHash = "Slider2DHash".GetHashCode();
    internal static int s_FreeRotateHandleHash = "FreeRotateHandleHash".GetHashCode();
    internal static int s_RadiusHandleHash = "RadiusHandleHash".GetHashCode();
    internal static int s_xAxisMoveHandleHash = "xAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_yAxisMoveHandleHash = "yAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_zAxisMoveHandleHash = "zAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_FreeMoveHandleHash = "FreeMoveHandleHash".GetHashCode();
    internal static int s_xzAxisMoveHandleHash = "xzAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_xyAxisMoveHandleHash = "xyAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_yzAxisMoveHandleHash = "yzAxisFreeMoveHandleHash".GetHashCode();
    internal static int s_xAxisScaleHandleHash = "xAxisScaleHandleHash".GetHashCode();
    internal static int s_yAxisScaleHandleHash = "yAxisScaleHandleHash".GetHashCode();
    internal static int s_zAxisScaleHandleHash = "zAxisScaleHandleHash".GetHashCode();
    internal static int s_ScaleSliderHash = "ScaleSliderHash".GetHashCode();
    internal static int s_ScaleValueHandleHash = "ScaleValueHandleHash".GetHashCode();
    internal static int s_DiscHash = "DiscHash".GetHashCode();
    internal static int s_ButtonHash = "ButtonHash".GetHashCode();
    internal static int s_xRotateHandleHash = "xRotateHandleHash".GetHashCode();
    internal static int s_yRotateHandleHash = "yRotateHandleHash".GetHashCode();
    internal static int s_zRotateHandleHash = "zRotateHandleHash".GetHashCode();
    internal static int s_cameraAxisRotateHandleHash = "cameraAxisRotateHandleHash".GetHashCode();
    internal static int s_xyzRotateHandleHash = "xyzRotateHandleHash".GetHashCode();
    internal static int s_xScaleHandleHash = "xScaleHandleHash".GetHashCode();
    internal static int s_yScaleHandleHash = "yScaleHandleHash".GetHashCode();
    internal static int s_zScaleHandleHash = "zScaleHandleHash".GetHashCode();
    internal static int s_xyzScaleHandleHash = "xyzScaleHandleHash".GetHashCode();
    private static Color lineTransparency = new Color(1f, 1f, 1f, 0.75f);
    internal const float kCameraViewLerpStart = 0.85f;
    internal const float kCameraViewThreshold = 0.9f;
    internal const float kCameraViewLerpSpeed = 6.666668f;
    private static PrefColor[] s_AxisColor = new PrefColor[3]
    {
      Handles.s_XAxisColor,
      Handles.s_YAxisColor,
      Handles.s_ZAxisColor
    };
    private static Vector3[] s_AxisVector = new Vector3[3]
    {
      Vector3.right,
      Vector3.up,
      Vector3.forward
    };
    internal static Color s_DisabledHandleColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    private static Vector3[] s_RectangleHandlePointsCache = new Vector3[5];
    private static Vector3[] s_RectangleCapPointsCache = new Vector3[5];
    private static readonly Vector3[] s_WireArcPoints = new Vector3[60];
    internal static Mesh s_CubeMesh;
    internal static Mesh s_SphereMesh;
    internal static Mesh s_ConeMesh;
    internal static Mesh s_CylinderMesh;
    internal static Mesh s_QuadMesh;
    private static Vector3[] verts = new Vector3[4]
    {
      Vector3.zero,
      Vector3.zero,
      Vector3.zero,
      Vector3.zero
    };
    private const float kFreeMoveHandleSizeFactor = 0.15f;
    private static bool s_FreeMoveMode = false;
    private static Vector3 s_PlanarHandlesOctant = Vector3.one;
    private static Vector3 s_DoPositionHandle_AxisHandlesOctant = Vector3.one;
    private static Vector3 s_DoPositionHandle_ArrowCapConeOffset = Vector3.zero;
    private static float[] s_DoPositionHandle_Internal_CameraViewLerp = new float[6];
    private static string[] s_DoPositionHandle_Internal_AxisNames = new string[3]
    {
      "xAxis",
      "yAxis",
      "zAxis"
    };
    private static int[] s_DoPositionHandle_Internal_NextIndex = new int[3]
    {
      1,
      2,
      0
    };
    private static int[] s_DoPositionHandle_Internal_PrevIndex = new int[3]
    {
      2,
      0,
      1
    };
    private static int[] s_DoPositionHandle_Internal_PrevPlaneIndex = new int[3]
    {
      5,
      3,
      4
    };
    private static readonly Color k_RotationPieColor = new Color(0.9647059f, 0.9490196f, 0.1960784f, 0.89f);
    private static Vector3 s_DoScaleHandle_AxisHandlesOctant = Vector3.one;
    private static Vector3 s_InitialScale;
    private static bool s_IsHotInCameraAlignedMode = false;
    private static Dictionary<Handles.RotationHandleIds, Handles.RotationHandleData> s_TransformHandle_RotationData = new Dictionary<Handles.RotationHandleIds, Handles.RotationHandleData>();

    /// <summary>
    ///   <para>Are handles lit?</para>
    /// </summary>
    [NativeProperty("handles::g_HandleLighting", true, TargetType.Field)]
    public static extern bool lighting { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Colors of the handles.</para>
    /// </summary>
    [NativeProperty("handles::g_HandleColor", true, TargetType.Field)]
    public static Color color
    {
      get
      {
        Color ret;
        Handles.get_color_Injected(out ret);
        return ret;
      }
      set => Handles.set_color_Injected(ref value);
    }

    /// <summary>
    ///   <para>zTest of the handles.</para>
    /// </summary>
    [NativeProperty("handles::g_HandleZTest", true, TargetType.Field)]
    public static extern CompareFunction zTest { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Matrix for all handle operations.</para>
    /// </summary>
    public static Matrix4x4 matrix
    {
      [FreeFunction("Internal_GetMatrix")] get
      {
        Matrix4x4 ret;
        Handles.get_matrix_Injected(out ret);
        return ret;
      }
      [FreeFunction("Internal_SetMatrix")] set => Handles.set_matrix_Injected(ref value);
    }

    /// <summary>
    ///   <para>The inverse of the matrix for all handle operations.</para>
    /// </summary>
    [NativeProperty("handles::g_HandleInverseMatrix", true, TargetType.Field)]
    public static Matrix4x4 inverseMatrix
    {
      get
      {
        Matrix4x4 ret;
        Handles.get_inverseMatrix_Injected(out ret);
        return ret;
      }
    }

    [FreeFunction("handles::ClearHandles")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void ClearHandles();

    [FreeFunction("Internal_DrawGizmos")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Internal_DoDrawGizmos([NotNull] Camera camera);

    [FreeFunction("Internal_IsCameraDrawModeEnabled")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool IsCameraDrawModeEnabled(Camera camera, DrawCameraMode drawMode);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_DrawCameraWithGrid(
      Camera cam,
      DrawCameraMode renderMode,
      ref DrawGridParameters gridParam,
      bool drawGizmos);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_DrawCamera(
      Camera cam,
      DrawCameraMode renderMode,
      bool drawGizmos);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_FinishDrawingCamera(Camera cam, [DefaultValue("true")] bool drawGizmos);

    private static void Internal_FinishDrawingCamera(Camera cam) => Handles.Internal_FinishDrawingCamera(cam, true);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_ClearCamera(Camera cam);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Internal_SetCurrentCamera(Camera cam);

    [FreeFunction("Internal_SetSceneViewColors")]
    internal static void SetSceneViewColors(
      Color wire,
      Color wireOverlay,
      Color selectedOutline,
      Color selectedChildrenOutline,
      Color selectedWire)
    {
      Handles.SetSceneViewColors_Injected(ref wire, ref wireOverlay, ref selectedOutline, ref selectedChildrenOutline, ref selectedWire);
    }

    [FreeFunction("Internal_EnableCameraFx")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void EnableCameraFx(Camera cam, bool fx);

    [FreeFunction("Internal_EnableCameraFlares")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void EnableCameraFlares(Camera cam, bool flares);

    [FreeFunction("Internal_EnableCameraSkybox")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void EnableCameraSkybox(Camera cam, bool skybox);

    [FreeFunction]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_SetupCamera(Camera cam);

    [FreeFunction]
    private static void Internal_DrawAAPolyLine(
      Color[] colors,
      Vector3[] points,
      Color defaultColor,
      int actualNumberOfPoints,
      Texture2D texture,
      float width,
      Matrix4x4 toWorld)
    {
      Handles.Internal_DrawAAPolyLine_Injected(colors, points, ref defaultColor, actualNumberOfPoints, texture, width, ref toWorld);
    }

    [FreeFunction]
    private static void Internal_DrawAAConvexPolygon(
      Vector3[] points,
      Color defaultColor,
      int actualNumberOfPoints,
      Matrix4x4 toWorld)
    {
      Handles.Internal_DrawAAConvexPolygon_Injected(points, ref defaultColor, actualNumberOfPoints, ref toWorld);
    }

    [FreeFunction]
    private static void Internal_DrawBezier(
      Vector3 startPosition,
      Vector3 endPosition,
      Vector3 startTangent,
      Vector3 endTangent,
      Color color,
      Texture2D texture,
      float width,
      Matrix4x4 toWorld)
    {
      Handles.Internal_DrawBezier_Injected(ref startPosition, ref endPosition, ref startTangent, ref endTangent, ref color, texture, width, ref toWorld);
    }

    [FreeFunction("Internal_SetDiscSectionPoints")]
    internal static void SetDiscSectionPoints(
      Vector3[] dest,
      Vector3 center,
      Vector3 normal,
      Vector3 from,
      float angle,
      float radius)
    {
      Handles.SetDiscSectionPoints_Injected(dest, ref center, ref normal, ref from, angle, radius);
    }

    [FreeFunction("Internal_EmitGUIGeometryForCamera")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void EmitGUIGeometryForCamera(Camera source, Camera dest);

    [FreeFunction("Internal_SetCameraFilterMode")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void SetCameraFilterMode(Camera camera, Handles.CameraFilterMode mode);

    [FreeFunction("Internal_GetCameraFilterMode")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern Handles.CameraFilterMode GetCameraFilterMode(Camera camera);

    [FreeFunction("Internal_DrawCameraFade")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void DrawCameraFade(Camera camera, float fade);

    [FreeFunction]
    private static Vector3[] Internal_MakeBezierPoints(
      Vector3 startPosition,
      Vector3 endPosition,
      Vector3 startTangent,
      Vector3 endTangent,
      int division)
    {
      return Handles.Internal_MakeBezierPoints_Injected(ref startPosition, ref endPosition, ref startTangent, ref endTangent, division);
    }

    /// <summary>
    ///   <para>Color to use for handles that manipulates the X coordinate of something.</para>
    /// </summary>
    public static Color xAxisColor => (Color) Handles.s_XAxisColor;

    /// <summary>
    ///   <para>Color to use for handles that manipulates the Y coordinate of something.</para>
    /// </summary>
    public static Color yAxisColor => (Color) Handles.s_YAxisColor;

    /// <summary>
    ///   <para>Color to use for handles that manipulates the Z coordinate of something.</para>
    /// </summary>
    public static Color zAxisColor => (Color) Handles.s_ZAxisColor;

    /// <summary>
    ///   <para>Color to use for handles that represent the center of something.</para>
    /// </summary>
    public static Color centerColor => (Color) Handles.s_CenterColor;

    /// <summary>
    ///   <para>Color to use for the currently active handle.</para>
    /// </summary>
    public static Color selectedColor => (Color) Handles.s_SelectedColor;

    /// <summary>
    ///   <para>Color to use to highlight an unselected handle currently under the mouse pointer.</para>
    /// </summary>
    public static Color preselectionColor => (Color) Handles.s_PreselectionColor;

    /// <summary>
    ///   <para>Soft color to use for for general things.</para>
    /// </summary>
    public static Color secondaryColor => (Color) Handles.s_SecondaryColor;

    private static Mesh cubeMesh
    {
      get
      {
        if ((UnityEngine.Object) Handles.s_CubeMesh == (UnityEngine.Object) null)
          Handles.Init();
        return Handles.s_CubeMesh;
      }
    }

    private static Mesh coneMesh
    {
      get
      {
        if ((UnityEngine.Object) Handles.s_ConeMesh == (UnityEngine.Object) null)
          Handles.Init();
        return Handles.s_ConeMesh;
      }
    }

    private static Mesh cylinderMesh
    {
      get
      {
        if ((UnityEngine.Object) Handles.s_CylinderMesh == (UnityEngine.Object) null)
          Handles.Init();
        return Handles.s_CylinderMesh;
      }
    }

    private static Mesh sphereMesh
    {
      get
      {
        if ((UnityEngine.Object) Handles.s_SphereMesh == (UnityEngine.Object) null)
          Handles.Init();
        return Handles.s_SphereMesh;
      }
    }

    internal static Color GetColorByAxis(int axis) => (Color) Handles.s_AxisColor[axis];

    internal static Color ToActiveColorSpace(Color color) => QualitySettings.activeColorSpace == ColorSpace.Linear ? color.linear : color;

    private static Vector3 GetAxisVector(int axis) => Handles.s_AxisVector[axis];

    private static bool BeginLineDrawing(Matrix4x4 matrix, bool dottedLines, int mode)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return false;
      Color c = Handles.color * Handles.lineTransparency;
      if (dottedLines)
        HandleUtility.ApplyDottedWireMaterial(Handles.zTest);
      else
        HandleUtility.ApplyWireMaterial(Handles.zTest);
      GL.PushMatrix();
      GL.MultMatrix(matrix);
      GL.Begin(mode);
      GL.Color(c);
      return true;
    }

    private static void EndLineDrawing()
    {
      GL.End();
      GL.PopMatrix();
    }

    /// <summary>
    ///   <para>Draw a line going through the list of points.</para>
    /// </summary>
    /// <param name="points"></param>
    public static void DrawPolyLine(params Vector3[] points)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, false, 2))
        return;
      for (int index = 0; index < points.Length; ++index)
        GL.Vertex(points[index]);
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a line from p1 to p2.</para>
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    public static void DrawLine(Vector3 p1, Vector3 p2) => Handles.DrawLine(p1, p2, false);

    internal static void DrawLine(Vector3 p1, Vector3 p2, bool dottedLine)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, dottedLine, 1))
        return;
      GL.Vertex(p1);
      GL.Vertex(p2);
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a list of line segments.</para>
    /// </summary>
    /// <param name="lineSegments">A list of pairs of points that represent the start and end of line segments.</param>
    public static void DrawLines(Vector3[] lineSegments)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, false, 1))
        return;
      for (int index = 0; index < lineSegments.Length; index += 2)
      {
        Vector3 lineSegment1 = lineSegments[index];
        Vector3 lineSegment2 = lineSegments[index + 1];
        GL.Vertex(lineSegment1);
        GL.Vertex(lineSegment2);
      }
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a list of indexed line segments.</para>
    /// </summary>
    /// <param name="points">A list of points.</param>
    /// <param name="segmentIndices">A list of pairs of indices to the start and end points of the line segments.</param>
    public static void DrawLines(Vector3[] points, int[] segmentIndices)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, false, 1))
        return;
      for (int index = 0; index < segmentIndices.Length; index += 2)
      {
        Vector3 point1 = points[segmentIndices[index]];
        Vector3 point2 = points[segmentIndices[index + 1]];
        GL.Vertex(point1);
        GL.Vertex(point2);
      }
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a dotted line from p1 to p2.</para>
    /// </summary>
    /// <param name="p1">The start point.</param>
    /// <param name="p2">The end point.</param>
    /// <param name="screenSpaceSize">The size in pixels for the lengths of the line segments and the gaps between them.</param>
    public static void DrawDottedLine(Vector3 p1, Vector3 p2, float screenSpaceSize)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, true, 1))
        return;
      float x = screenSpaceSize * EditorGUIUtility.pixelsPerPoint;
      GL.MultiTexCoord(1, p1);
      GL.MultiTexCoord2(2, x, 0.0f);
      GL.Vertex(p1);
      GL.MultiTexCoord(1, p1);
      GL.MultiTexCoord2(2, x, 0.0f);
      GL.Vertex(p2);
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a list of dotted line segments.</para>
    /// </summary>
    /// <param name="lineSegments">A list of pairs of points that represent the start and end of line segments.</param>
    /// <param name="screenSpaceSize">The size in pixels for the lengths of the line segments and the gaps between them.</param>
    public static void DrawDottedLines(Vector3[] lineSegments, float screenSpaceSize)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, true, 1))
        return;
      float x = screenSpaceSize * EditorGUIUtility.pixelsPerPoint;
      for (int index = 0; index < lineSegments.Length; index += 2)
      {
        Vector3 lineSegment1 = lineSegments[index];
        Vector3 lineSegment2 = lineSegments[index + 1];
        GL.MultiTexCoord(1, lineSegment1);
        GL.MultiTexCoord2(2, x, 0.0f);
        GL.Vertex(lineSegment1);
        GL.MultiTexCoord(1, lineSegment1);
        GL.MultiTexCoord2(2, x, 0.0f);
        GL.Vertex(lineSegment2);
      }
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a list of indexed dotted line segments.</para>
    /// </summary>
    /// <param name="points">A list of points.</param>
    /// <param name="segmentIndices">A list of pairs of indices to the start and end points of the line segments.</param>
    /// <param name="screenSpaceSize">The size in pixels for the lengths of the line segments and the gaps between them.</param>
    public static void DrawDottedLines(
      Vector3[] points,
      int[] segmentIndices,
      float screenSpaceSize)
    {
      if (!Handles.BeginLineDrawing(Handles.matrix, true, 1))
        return;
      float x = screenSpaceSize * EditorGUIUtility.pixelsPerPoint;
      for (int index = 0; index < segmentIndices.Length; index += 2)
      {
        Vector3 point1 = points[segmentIndices[index]];
        Vector3 point2 = points[segmentIndices[index + 1]];
        GL.MultiTexCoord(1, point1);
        GL.MultiTexCoord2(2, x, 0.0f);
        GL.Vertex(point1);
        GL.MultiTexCoord(1, point1);
        GL.MultiTexCoord2(2, x, 0.0f);
        GL.Vertex(point2);
      }
      Handles.EndLineDrawing();
    }

    /// <summary>
    ///   <para>Draw a wireframe box with center and size.</para>
    /// </summary>
    /// <param name="center"></param>
    /// <param name="size"></param>
    public static void DrawWireCube(Vector3 center, Vector3 size)
    {
      Vector3 vector3 = size * 0.5f;
      Vector3[] vector3Array = new Vector3[10]
      {
        center + new Vector3(-vector3.x, -vector3.y, -vector3.z),
        center + new Vector3(-vector3.x, vector3.y, -vector3.z),
        center + new Vector3(vector3.x, vector3.y, -vector3.z),
        center + new Vector3(vector3.x, -vector3.y, -vector3.z),
        center + new Vector3(-vector3.x, -vector3.y, -vector3.z),
        center + new Vector3(-vector3.x, -vector3.y, vector3.z),
        center + new Vector3(-vector3.x, vector3.y, vector3.z),
        center + new Vector3(vector3.x, vector3.y, vector3.z),
        center + new Vector3(vector3.x, -vector3.y, vector3.z),
        center + new Vector3(-vector3.x, -vector3.y, vector3.z)
      };
      Handles.DrawPolyLine(vector3Array);
      Handles.DrawLine(vector3Array[1], vector3Array[6]);
      Handles.DrawLine(vector3Array[2], vector3Array[7]);
      Handles.DrawLine(vector3Array[3], vector3Array[8]);
    }

    /// <summary>
    ///   <para>Determines whether or not to draw Gizmos.</para>
    /// </summary>
    public static bool ShouldRenderGizmos()
    {
      PlayModeView renderingView = PlayModeView.GetRenderingView();
      SceneView drawingSceneView = SceneView.currentDrawingSceneView;
      if ((UnityEngine.Object) renderingView != (UnityEngine.Object) null)
        return renderingView.IsShowingGizmos();
      return (UnityEngine.Object) drawingSceneView != (UnityEngine.Object) null && drawingSceneView.drawGizmos;
    }

    public static void DrawGizmos(Camera camera)
    {
      if (!Handles.ShouldRenderGizmos())
        return;
      Handles.Internal_DoDrawGizmos(camera);
    }

    /// <summary>
    ///   <para>Make a 3D disc that can be dragged with the mouse.</para>
    /// </summary>
    /// <param name="id">Control id of the handle.</param>
    /// <param name="rotation">The rotation of the disc.</param>
    /// <param name="position">The center of the disc.</param>
    /// <param name="axis">The axis to rotate around.</param>
    /// <param name="size">The size of the disc in world space.</param>
    /// <param name="cutoffPlane">If true, only the front-facing half of the circle is draw / draggable. This is useful when you have many overlapping rotation axes (like in the default rotate tool) to avoid clutter.</param>
    /// <param name="snap">The grid size to snap to.</param>
    /// <returns>
    ///   <para>The new rotation value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Quaternion Disc(
      int id,
      Quaternion rotation,
      Vector3 position,
      Vector3 axis,
      float size,
      bool cutoffPlane,
      float snap)
    {
      return UnityEditorInternal.Disc.Do(id, rotation, position, axis, size, cutoffPlane, snap);
    }

    /// <summary>
    ///   <para>Make an unconstrained rotation handle.</para>
    /// </summary>
    /// <param name="id">Control id of the handle.</param>
    /// <param name="rotation">Orientation of the handle.</param>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <param name="size">The size of the handle.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    /// <returns>
    ///   <para>The new rotation value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Quaternion FreeRotateHandle(
      int id,
      Quaternion rotation,
      Vector3 position,
      float size)
    {
      return FreeRotate.Do(id, rotation, position, size);
    }

    /// <summary>
    ///   <para>Make a 3D slider that moves along one axis.</para>
    /// </summary>
    /// <param name="position">The position of the current point in the space of Handles.matrix.</param>
    /// <param name="direction">The direction axis of the slider in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="snap">The snap increment. See Handles.SnapValue.</param>
    /// <param name="capFunction">The function to call for doing the actual drawing. By default it is Handles.ArrowHandleCap, but any function that has the same signature can be used.</param>
    /// <returns>
    ///   <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the position value passed into the function.</para>
    /// </returns>
    public static Vector3 Slider(Vector3 position, Vector3 direction) => Handles.Slider(position, direction, HandleUtility.GetHandleSize(position), new Handles.CapFunction(Handles.ArrowHandleCap), -1f);

    public static Vector3 Slider(
      Vector3 position,
      Vector3 direction,
      float size,
      Handles.CapFunction capFunction,
      float snap)
    {
      return Slider1D.Do(GUIUtility.GetControlID(Handles.s_SliderHash, FocusType.Passive), position, direction, size, capFunction, snap);
    }

    public static Vector3 Slider(
      int controlID,
      Vector3 position,
      Vector3 direction,
      float size,
      Handles.CapFunction capFunction,
      float snap)
    {
      return Slider1D.Do(controlID, position, direction, size, capFunction, snap);
    }

    public static Vector3 Slider(
      int controlID,
      Vector3 position,
      Vector3 offset,
      Vector3 direction,
      float size,
      Handles.CapFunction capFunction,
      float snap)
    {
      return Slider1D.Do(controlID, position, offset, direction, direction, size, capFunction, snap);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider(
      Vector3 position,
      Vector3 direction,
      float size,
      Handles.DrawCapFunction drawFunc,
      float snap)
    {
      return Slider1D.Do(GUIUtility.GetControlID(Handles.s_SliderHash, FocusType.Passive), position, direction, size, drawFunc, snap);
    }

    public static Vector3 FreeMoveHandle(
      Vector3 position,
      Quaternion rotation,
      float size,
      Vector3 snap,
      Handles.CapFunction capFunction)
    {
      return FreeMove.Do(GUIUtility.GetControlID(Handles.s_FreeMoveHandleHash, FocusType.Passive), position, rotation, size, snap, capFunction);
    }

    public static Vector3 FreeMoveHandle(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      Vector3 snap,
      Handles.CapFunction capFunction)
    {
      return FreeMove.Do(controlID, position, rotation, size, snap, capFunction);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 FreeMoveHandle(
      Vector3 position,
      Quaternion rotation,
      float size,
      Vector3 snap,
      Handles.DrawCapFunction capFunc)
    {
      return FreeMove.Do(GUIUtility.GetControlID(Handles.s_FreeMoveHandleHash, FocusType.Passive), position, rotation, size, snap, capFunc);
    }

    public static float ScaleValueHandle(
      float value,
      Vector3 position,
      Quaternion rotation,
      float size,
      Handles.CapFunction capFunction,
      float snap)
    {
      return SliderScale.DoCenter(GUIUtility.GetControlID(Handles.s_ScaleValueHandleHash, FocusType.Passive), value, position, rotation, size, capFunction, snap);
    }

    public static float ScaleValueHandle(
      int controlID,
      float value,
      Vector3 position,
      Quaternion rotation,
      float size,
      Handles.CapFunction capFunction,
      float snap)
    {
      return SliderScale.DoCenter(controlID, value, position, rotation, size, capFunction, snap);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static float ScaleValueHandle(
      float value,
      Vector3 position,
      Quaternion rotation,
      float size,
      Handles.DrawCapFunction capFunc,
      float snap)
    {
      return SliderScale.DoCenter(GUIUtility.GetControlID(Handles.s_ScaleValueHandleHash, FocusType.Passive), value, position, rotation, size, capFunc, snap);
    }

    public static bool Button(
      Vector3 position,
      Quaternion direction,
      float size,
      float pickSize,
      Handles.CapFunction capFunction)
    {
      return UnityEditorInternal.Button.Do(GUIUtility.GetControlID(Handles.s_ButtonHash, FocusType.Passive), position, direction, size, pickSize, capFunction);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static bool Button(
      Vector3 position,
      Quaternion direction,
      float size,
      float pickSize,
      Handles.DrawCapFunction capFunc)
    {
      return UnityEditorInternal.Button.Do(GUIUtility.GetControlID(Handles.s_ButtonHash, FocusType.Passive), position, direction, size, pickSize, capFunc);
    }

    internal static bool Button(
      int controlID,
      Vector3 position,
      Quaternion direction,
      float size,
      float pickSize,
      Handles.CapFunction capFunction)
    {
      return UnityEditorInternal.Button.Do(controlID, position, direction, size, pickSize, capFunction);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    internal static bool Button(
      int controlID,
      Vector3 position,
      Quaternion direction,
      float size,
      float pickSize,
      Handles.DrawCapFunction capFunc)
    {
      return UnityEditorInternal.Button.Do(controlID, position, direction, size, pickSize, capFunc);
    }

    /// <summary>
    ///   <para>Draw a cube handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void CubeHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Graphics.DrawMeshNow(Handles.cubeMesh, Handles.StartCapDraw(position, rotation, size));
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToCircle(position, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a sphere handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    public static void SphereHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Graphics.DrawMeshNow(Handles.sphereMesh, Handles.StartCapDraw(position, rotation, size));
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToCircle(position, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a cone handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void ConeHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Graphics.DrawMeshNow(Handles.coneMesh, Handles.StartCapDraw(position, rotation, size));
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToCircle(position, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a cylinder handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void CylinderHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Graphics.DrawMeshNow(Handles.cylinderMesh, Handles.StartCapDraw(position, rotation, size));
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToCircle(position, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a rectangle handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void RectangleHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      Handles.RectangleHandleCap(controlID, position, rotation, new Vector2(size, size), eventType);
    }

    internal static void RectangleHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      Vector2 size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Vector3 vector3_1 = rotation * new Vector3(size.x, 0.0f, 0.0f);
          Vector3 vector3_2 = rotation * new Vector3(0.0f, size.y, 0.0f);
          Handles.s_RectangleHandlePointsCache[0] = position + vector3_1 + vector3_2;
          Handles.s_RectangleHandlePointsCache[1] = position + vector3_1 - vector3_2;
          Handles.s_RectangleHandlePointsCache[2] = position - vector3_1 - vector3_2;
          Handles.s_RectangleHandlePointsCache[3] = position - vector3_1 + vector3_2;
          Handles.s_RectangleHandlePointsCache[4] = position + vector3_1 + vector3_2;
          Handles.DrawPolyLine(Handles.s_RectangleHandlePointsCache);
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToRectangleInternal(position, rotation, size));
          break;
      }
    }

    internal static void RectangleHandleCapWorldSpace(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      Handles.RectangleHandleCapWorldSpace(controlID, position, rotation, new Vector2(size, size), eventType);
    }

    internal static void RectangleHandleCapWorldSpace(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      Vector2 size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Vector3 vector3_1 = rotation * new Vector3(size.x, 0.0f, 0.0f);
          Vector3 vector3_2 = rotation * new Vector3(0.0f, size.y, 0.0f);
          Handles.s_RectangleHandlePointsCache[0] = position + vector3_1 + vector3_2;
          Handles.s_RectangleHandlePointsCache[1] = position + vector3_1 - vector3_2;
          Handles.s_RectangleHandlePointsCache[2] = position - vector3_1 - vector3_2;
          Handles.s_RectangleHandlePointsCache[3] = position - vector3_1 + vector3_2;
          Handles.s_RectangleHandlePointsCache[4] = position + vector3_1 + vector3_2;
          Handles.DrawPolyLine(Handles.s_RectangleHandlePointsCache);
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToRectangleInternalWorldSpace(position, rotation, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a dot handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void DotHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          position = Handles.matrix.MultiplyPoint(position);
          Vector3 vector3_1 = ((UnityEngine.Object) Camera.current == (UnityEngine.Object) null ? Vector3.right : Camera.current.transform.right) * size;
          Vector3 vector3_2 = ((UnityEngine.Object) Camera.current == (UnityEngine.Object) null ? Vector3.up : Camera.current.transform.up) * size;
          Color c = Handles.color * new Color(1f, 1f, 1f, 0.99f);
          HandleUtility.ApplyWireMaterial(Handles.zTest);
          GL.Begin(7);
          GL.Color(c);
          GL.Vertex(position + vector3_1 + vector3_2);
          GL.Vertex(position + vector3_1 - vector3_2);
          GL.Vertex(position - vector3_1 - vector3_2);
          GL.Vertex(position - vector3_1 + vector3_2);
          GL.End();
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToRectangle(position, rotation, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a circle handle. Pass this into handle functions.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void CircleHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Handles.StartCapDraw(position, rotation, size);
          Vector3 normal = rotation * new Vector3(0.0f, 0.0f, 1f);
          Handles.DrawWireDisc(position, normal, size);
          break;
        case UnityEngine.EventType.Layout:
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToRectangle(position, rotation, size));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw an arrow like those used by the move tool.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public static void ArrowHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      Handles.ArrowHandleCap(controlID, position, rotation, size, eventType, Vector3.zero);
    }

    internal static void ArrowHandleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType,
      Vector3 coneOffset)
    {
      switch (eventType)
      {
        case UnityEngine.EventType.Repaint:
          Vector3 forward = rotation * Vector3.forward;
          Handles.ConeHandleCap(controlID, position + (forward + coneOffset) * size, Quaternion.LookRotation(forward), size * 0.2f, eventType);
          Handles.DrawLine(position, position + (forward + coneOffset) * size * 0.9f, false);
          break;
        case UnityEngine.EventType.Layout:
          Vector3 vector3 = rotation * Vector3.forward;
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToLine(position, position + (vector3 + coneOffset) * size * 0.9f));
          HandleUtility.AddControl(controlID, HandleUtility.DistanceToCircle(position + (vector3 + coneOffset) * size, size * 0.2f));
          break;
      }
    }

    /// <summary>
    ///   <para>Draw a camera facing selection frame.</para>
    /// </summary>
    /// <param name="controlID"></param>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <param name="size"></param>
    /// <param name="eventType"></param>
    public static void DrawSelectionFrame(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      if (eventType != UnityEngine.EventType.Repaint)
        return;
      Handles.StartCapDraw(position, rotation, size);
      Vector3 vector3_1 = rotation * new Vector3(size, 0.0f, 0.0f);
      Vector3 vector3_2 = rotation * new Vector3(0.0f, size, 0.0f);
      Vector3 vector3_3 = position - vector3_1 + vector3_2;
      Vector3 vector3_4 = position + vector3_1 + vector3_2;
      Vector3 vector3_5 = position + vector3_1 - vector3_2;
      Vector3 vector3_6 = position - vector3_1 - vector3_2;
      Handles.DrawLine(vector3_3, vector3_4);
      Handles.DrawLine(vector3_4, vector3_5);
      Handles.DrawLine(vector3_5, vector3_6);
      Handles.DrawLine(vector3_6, vector3_3);
    }

    internal static float GetCameraViewLerpForWorldAxis(Vector3 viewVector, Vector3 axis) => Mathf.Clamp01((float) (6.66666793823242 * ((double) Mathf.Abs(Vector3.Dot(viewVector, axis)) - 0.850000023841858)));

    internal static Vector3 GetCameraViewFrom(Vector3 position, Matrix4x4 matrix)
    {
      Camera current = Camera.current;
      return current.orthographic ? matrix.MultiplyVector(-current.transform.forward).normalized : matrix.MultiplyVector(position - current.transform.position).normalized;
    }

    /// <summary>
    ///   <para>Make a position handle.</para>
    /// </summary>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <param name="rotation">Orientation of the handle in 3D space.</param>
    /// <returns>
    ///   <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Vector3 PositionHandle(Vector3 position, Quaternion rotation) => Handles.DoPositionHandle(position, rotation);

    /// <summary>
    ///   <para>Make a Scene view rotation handle.</para>
    /// </summary>
    /// <param name="rotation">Orientation of the handle.</param>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <returns>
    ///   <para>The new rotation value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Quaternion RotationHandle(Quaternion rotation, Vector3 position) => Handles.DoRotationHandle(rotation, position);

    /// <summary>
    ///   <para>Make a Scene view scale handle.</para>
    /// </summary>
    /// <param name="scale">Scale to modify.</param>
    /// <param name="position">The position of the handle.</param>
    /// <param name="rotation">The rotation of the handle.</param>
    /// <param name="size">Allows you to scale the size of the handle on-scren.</param>
    /// <returns>
    ///   <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Vector3 ScaleHandle(
      Vector3 scale,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      return Handles.DoScaleHandle(scale, position, rotation, size);
    }

    /// <summary>
    ///   <para>Make a Scene view radius handle.</para>
    /// </summary>
    /// <param name="rotation">Orientation of the handle.</param>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <param name="radius">Radius to modify.</param>
    /// <param name="handlesOnly">Whether to omit the circular outline of the radius and only draw the point handles.</param>
    /// <returns>
    ///         <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</para>
    ///       </returns>
    public static float RadiusHandle(
      Quaternion rotation,
      Vector3 position,
      float radius,
      bool handlesOnly)
    {
      return Handles.DoRadiusHandle(rotation, position, radius, handlesOnly);
    }

    /// <summary>
    ///   <para>Make a Scene view radius handle.</para>
    /// </summary>
    /// <param name="rotation">Orientation of the handle.</param>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <param name="radius">Radius to modify.</param>
    /// <param name="handlesOnly">Whether to omit the circular outline of the radius and only draw the point handles.</param>
    /// <returns>
    ///         <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</para>
    ///       </returns>
    public static float RadiusHandle(Quaternion rotation, Vector3 position, float radius) => Handles.DoRadiusHandle(rotation, position, radius, false);

    internal static Vector2 ConeHandle(
      Quaternion rotation,
      Vector3 position,
      Vector2 angleAndRange,
      float angleScale,
      float rangeScale,
      bool handlesOnly)
    {
      return Handles.DoConeHandle(rotation, position, angleAndRange, angleScale, rangeScale, handlesOnly);
    }

    internal static Vector3 ConeFrustrumHandle(
      Quaternion rotation,
      Vector3 position,
      Vector3 radiusAngleRange,
      Handles.ConeHandles showHandles = Handles.ConeHandles.All)
    {
      return Handles.DoConeFrustrumHandle(rotation, position, radiusAngleRange, showHandles);
    }

    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 offset,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap)
    {
      return Handles.Slider2D(id, handlePos, offset, handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, false);
    }

    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 offset,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(id, handlePos, offset, handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, drawHelper);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 offset,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap)
    {
      return Handles.Slider2D(id, handlePos, offset, handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, false);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 offset,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(id, handlePos, offset, handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, drawHelper);
    }

    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap)
    {
      return Handles.Slider2D(handlePos, handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, false);
    }

    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(GUIUtility.GetControlID(Handles.s_Slider2DHash, FocusType.Passive), handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, drawHelper);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap)
    {
      return Handles.Slider2D(handlePos, handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, false);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(GUIUtility.GetControlID(Handles.s_Slider2DHash, FocusType.Passive), handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, drawHelper);
    }

    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap)
    {
      return Handles.Slider2D(id, handlePos, handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, false);
    }

    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(id, handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, drawHelper);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap)
    {
      return Handles.Slider2D(id, handlePos, handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, false);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      int id,
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      Vector2 snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return UnityEditorInternal.Slider2D.Do(id, handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, drawHelper);
    }

    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      float snap)
    {
      return Handles.Slider2D(handlePos, handleDir, slideDir1, slideDir2, handleSize, capFunction, snap, false);
    }

    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.CapFunction capFunction,
      float snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return Handles.Slider2D(GUIUtility.GetControlID(Handles.s_Slider2DHash, FocusType.Passive), handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, capFunction, new Vector2(snap, snap), drawHelper);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      float snap)
    {
      return Handles.Slider2D(handlePos, handleDir, slideDir1, slideDir2, handleSize, drawFunc, snap, false);
    }

    [Obsolete("DrawCapFunction is obsolete. Use the version with CapFunction instead. Example: Change SphereCap to SphereHandleCap.")]
    public static Vector3 Slider2D(
      Vector3 handlePos,
      Vector3 handleDir,
      Vector3 slideDir1,
      Vector3 slideDir2,
      float handleSize,
      Handles.DrawCapFunction drawFunc,
      float snap,
      [DefaultValue("false")] bool drawHelper)
    {
      return Handles.Slider2D(GUIUtility.GetControlID(Handles.s_Slider2DHash, FocusType.Passive), handlePos, new Vector3(0.0f, 0.0f, 0.0f), handleDir, slideDir1, slideDir2, handleSize, drawFunc, new Vector2(snap, snap), drawHelper);
    }

    /// <summary>
    ///   <para>Make an unconstrained rotation handle.</para>
    /// </summary>
    /// <param name="id">Control id of the handle.</param>
    /// <param name="rotation">Orientation of the handle.</param>
    /// <param name="position">Center of the handle in 3D space.</param>
    /// <param name="size">The size of the handle.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    /// <returns>
    ///   <para>The new rotation value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Quaternion FreeRotateHandle(
      Quaternion rotation,
      Vector3 position,
      float size)
    {
      return FreeRotate.Do(GUIUtility.GetControlID(Handles.s_FreeRotateHandleHash, FocusType.Passive), rotation, position, size);
    }

    /// <summary>
    ///   <para>Make a directional scale slider.</para>
    /// </summary>
    /// <param name="scale">The value the user can modify.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="direction">The direction of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in the space of Handles.matrix. Use HandleUtility.GetHandleSize if you want a constant screen-space size.</param>
    /// <param name="snap">The snap increment. See Handles.SnapValue.</param>
    /// <returns>
    ///   <para>The new value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static float ScaleSlider(
      float scale,
      Vector3 position,
      Vector3 direction,
      Quaternion rotation,
      float size,
      float snap)
    {
      return SliderScale.DoAxis(GUIUtility.GetControlID(Handles.s_ScaleSliderHash, FocusType.Passive), scale, position, direction, rotation, size, snap);
    }

    /// <summary>
    ///   <para>Make a 3D disc that can be dragged with the mouse.</para>
    /// </summary>
    /// <param name="id">Control id of the handle.</param>
    /// <param name="rotation">The rotation of the disc.</param>
    /// <param name="position">The center of the disc.</param>
    /// <param name="axis">The axis to rotate around.</param>
    /// <param name="size">The size of the disc in world space.</param>
    /// <param name="cutoffPlane">If true, only the front-facing half of the circle is draw / draggable. This is useful when you have many overlapping rotation axes (like in the default rotate tool) to avoid clutter.</param>
    /// <param name="snap">The grid size to snap to.</param>
    /// <returns>
    ///   <para>The new rotation value modified by the user's interaction with the handle. If the user has not moved the handle, it will return the same value as you passed into the function.</para>
    /// </returns>
    public static Quaternion Disc(
      Quaternion rotation,
      Vector3 position,
      Vector3 axis,
      float size,
      bool cutoffPlane,
      float snap)
    {
      return UnityEditorInternal.Disc.Do(GUIUtility.GetControlID(Handles.s_DiscHash, FocusType.Passive), rotation, position, axis, size, cutoffPlane, snap);
    }

    internal static void SetupIgnoreRaySnapObjects() => HandleUtility.ignoreRaySnapObjects = Selection.GetTransforms(SelectionMode.Deep | SelectionMode.Editable);

    /// <summary>
    ///   <para>Rounds value to the closest multiple of snap if snapping is active. Note that snap can only be positive.</para>
    /// </summary>
    /// <param name="value">The value to snap.</param>
    /// <param name="snap">The increment to snap to.</param>
    /// <returns>
    ///   <para>If snapping is active, rounds value to the closest multiple of snap (snap can only be positive).</para>
    /// </returns>
    public static float SnapValue(float value, float snap) => EditorSnapSettings.incrementalSnapActive ? Snapping.Snap(value, snap) : value;

    /// <summary>
    ///   <para>Rounds value to the closest multiple of snap if snapping is active. Note that snap can only be positive.</para>
    /// </summary>
    /// <param name="value">The value to snap.</param>
    /// <param name="snap">The increment to snap to.</param>
    /// <returns>
    ///   <para>If snapping is active, rounds value to the closest multiple of snap (snap can only be positive).</para>
    /// </returns>
    public static Vector2 SnapValue(Vector2 value, Vector2 snap) => EditorSnapSettings.incrementalSnapActive ? Snapping.Snap(value, snap) : value;

    /// <summary>
    ///   <para>Rounds value to the closest multiple of snap if snapping is active. Note that snap can only be positive.</para>
    /// </summary>
    /// <param name="value">The value to snap.</param>
    /// <param name="snap">The increment to snap to.</param>
    /// <returns>
    ///   <para>If snapping is active, rounds value to the closest multiple of snap (snap can only be positive).</para>
    /// </returns>
    public static Vector3 SnapValue(Vector3 value, Vector3 snap) => EditorSnapSettings.incrementalSnapActive ? Snapping.Snap(value, snap) : value;

    /// <summary>
    ///   <para>Rounds each Transform.position to the closest multiple of EditorSnap.move.</para>
    /// </summary>
    /// <param name="transforms">The transforms to snap.</param>
    /// <param name="axis">The axes on which to apply snapping.</param>
    public static void SnapToGrid(Transform[] transforms, SnapAxis axis = SnapAxis.All)
    {
      if (transforms == null || (uint) transforms.Length <= 0U)
        return;
      foreach (Transform transform in transforms)
      {
        if ((UnityEngine.Object) transform != (UnityEngine.Object) null)
          transform.position = Snapping.Snap(transform.position, Vector3.Scale(GridSettings.size, (Vector3) new SnapAxisFilter(axis)));
      }
    }

    /// <summary>
    ///   <para>Setup viewport and stuff for a current camera.</para>
    /// </summary>
    public Camera currentCamera
    {
      get => Camera.current;
      set => Handles.Internal_SetCurrentCamera(value);
    }

    internal static Color realHandleColor => Handles.color * new Color(1f, 1f, 1f, 0.5f) + (Handles.lighting ? new Color(0.0f, 0.0f, 0.0f, 0.5f) : new Color(0.0f, 0.0f, 0.0f, 0.0f));

    internal static void DrawTwoShadedWireDisc(Vector3 position, Vector3 axis, float radius)
    {
      Color color1 = Handles.color;
      Color color2 = color1;
      color1.a *= Handles.backfaceAlphaMultiplier;
      Handles.color = color1;
      Handles.DrawWireDisc(position, axis, radius);
      Handles.color = color2;
    }

    internal static void DrawTwoShadedWireDisc(
      Vector3 position,
      Vector3 axis,
      Vector3 from,
      float degrees,
      float radius)
    {
      Handles.DrawWireArc(position, axis, from, degrees, radius);
      Color color1 = Handles.color;
      Color color2 = color1;
      color1.a *= Handles.backfaceAlphaMultiplier;
      Handles.color = color1;
      Handles.DrawWireArc(position, axis, from, degrees - 360f, radius);
      Handles.color = color2;
    }

    internal static Matrix4x4 StartCapDraw(
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      Shader.SetGlobalColor("_HandleColor", Handles.realHandleColor);
      Shader.SetGlobalFloat("_HandleSize", size);
      Matrix4x4 matrix4x4 = Handles.matrix * Matrix4x4.TRS(position, rotation, Vector3.one);
      Shader.SetGlobalMatrix("_ObjectToWorld", matrix4x4);
      HandleUtility.handleMaterial.SetInt("_HandleZTest", (int) Handles.zTest);
      HandleUtility.handleMaterial.SetPass(0);
      return matrix4x4;
    }

    [Obsolete("Use CubeHandleCap instead")]
    public static void CubeCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Graphics.DrawMeshNow(Handles.cubeMesh, Handles.StartCapDraw(position, rotation, size));
    }

    [Obsolete("Use SphereHandleCap instead")]
    public static void SphereCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Graphics.DrawMeshNow(Handles.sphereMesh, Handles.StartCapDraw(position, rotation, size));
    }

    [Obsolete("Use ConeHandleCap instead")]
    public static void ConeCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Graphics.DrawMeshNow(Handles.coneMesh, Handles.StartCapDraw(position, rotation, size));
    }

    [Obsolete("Use CylinderHandleCap instead")]
    public static void CylinderCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Graphics.DrawMeshNow(Handles.cylinderMesh, Handles.StartCapDraw(position, rotation, size));
    }

    [Obsolete("Use RectangleHandleCap instead")]
    public static void RectangleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      Handles.RectangleCap(controlID, position, rotation, new Vector2(size, size));
    }

    internal static void RectangleCap(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      Vector2 size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Vector3 vector3_1 = rotation * new Vector3(size.x, 0.0f, 0.0f);
      Vector3 vector3_2 = rotation * new Vector3(0.0f, size.y, 0.0f);
      Handles.s_RectangleCapPointsCache[0] = position + vector3_1 + vector3_2;
      Handles.s_RectangleCapPointsCache[1] = position + vector3_1 - vector3_2;
      Handles.s_RectangleCapPointsCache[2] = position - vector3_1 - vector3_2;
      Handles.s_RectangleCapPointsCache[3] = position - vector3_1 + vector3_2;
      Handles.s_RectangleCapPointsCache[4] = position + vector3_1 + vector3_2;
      Handles.DrawPolyLine(Handles.s_RectangleCapPointsCache);
    }

    public static void SelectionFrame(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Handles.StartCapDraw(position, rotation, size);
      Vector3 vector3_1 = rotation * new Vector3(size, 0.0f, 0.0f);
      Vector3 vector3_2 = rotation * new Vector3(0.0f, size, 0.0f);
      Vector3 vector3_3 = position - vector3_1 + vector3_2;
      Vector3 vector3_4 = position + vector3_1 + vector3_2;
      Vector3 vector3_5 = position + vector3_1 - vector3_2;
      Vector3 vector3_6 = position - vector3_1 - vector3_2;
      Handles.DrawLine(vector3_3, vector3_4);
      Handles.DrawLine(vector3_4, vector3_5);
      Handles.DrawLine(vector3_5, vector3_6);
      Handles.DrawLine(vector3_6, vector3_3);
    }

    [Obsolete("Use DotHandleCap instead")]
    public static void DotCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      position = Handles.matrix.MultiplyPoint(position);
      Vector3 vector3_1 = Camera.current.transform.right * size;
      Vector3 vector3_2 = Camera.current.transform.up * size;
      Color c = Handles.color * new Color(1f, 1f, 1f, 0.99f);
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      GL.Begin(7);
      GL.Color(c);
      GL.Vertex(position + vector3_1 + vector3_2);
      GL.Vertex(position + vector3_1 - vector3_2);
      GL.Vertex(position - vector3_1 - vector3_2);
      GL.Vertex(position - vector3_1 + vector3_2);
      GL.End();
    }

    [Obsolete("Use CircleHandleCap instead")]
    public static void CircleCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Handles.StartCapDraw(position, rotation, size);
      Vector3 normal = rotation * new Vector3(0.0f, 0.0f, 1f);
      Handles.DrawWireDisc(position, normal, size);
    }

    [Obsolete("Use ArrowHandleCap instead")]
    public static void ArrowCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Vector3 forward = rotation * Vector3.forward;
      Handles.ConeCap(controlID, position + forward * size, Quaternion.LookRotation(forward), size * 0.2f);
      Handles.DrawLine(position, position + forward * size * 0.9f);
    }

    [Obsolete("DrawCylinder has been renamed to CylinderCap.")]
    public static void DrawCylinder(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      Handles.CylinderCap(controlID, position, rotation, size);
    }

    [Obsolete("DrawSphere has been renamed to SphereCap.")]
    public static void DrawSphere(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      Handles.SphereCap(controlID, position, rotation, size);
    }

    [Obsolete("DrawRectangle has been renamed to RectangleCap.")]
    public static void DrawRectangle(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      Handles.RectangleCap(controlID, position, rotation, size);
    }

    [Obsolete("DrawCube has been renamed to CubeCap.")]
    public static void DrawCube(int controlID, Vector3 position, Quaternion rotation, float size) => Handles.CubeCap(controlID, position, rotation, size);

    [Obsolete("DrawArrow has been renamed to ArrowCap.")]
    public static void DrawArrow(int controlID, Vector3 position, Quaternion rotation, float size) => Handles.ArrowCap(controlID, position, rotation, size);

    [Obsolete("DrawCone has been renamed to ConeCap.")]
    public static void DrawCone(int controlID, Vector3 position, Quaternion rotation, float size) => Handles.ConeCap(controlID, position, rotation, size);

    internal static void DrawAAPolyLine(Color[] colors, Vector3[] points) => Handles.DoDrawAAPolyLine(colors, points, -1, (Texture2D) null, 2f, 0.75f);

    internal static void DrawAAPolyLine(float width, Color[] colors, Vector3[] points) => Handles.DoDrawAAPolyLine(colors, points, -1, (Texture2D) null, width, 0.75f);

    /// <summary>
    ///   <para>Draw anti-aliased line specified with point array and width.</para>
    /// </summary>
    /// <param name="lineTex">The AA texture used for rendering.</param>
    /// <param name="width">The width of the line.</param>
    /// <param name="points">List of points to build the line from.</param>
    /// <param name="actualNumberOfPoints"></param>
    public static void DrawAAPolyLine(params Vector3[] points) => Handles.DoDrawAAPolyLine((Color[]) null, points, -1, (Texture2D) null, 2f, 0.75f);

    /// <summary>
    ///   <para>Draw anti-aliased line specified with point array and width.</para>
    /// </summary>
    /// <param name="lineTex">The AA texture used for rendering.</param>
    /// <param name="width">The width of the line.</param>
    /// <param name="points">List of points to build the line from.</param>
    /// <param name="actualNumberOfPoints"></param>
    public static void DrawAAPolyLine(float width, params Vector3[] points) => Handles.DoDrawAAPolyLine((Color[]) null, points, -1, (Texture2D) null, width, 0.75f);

    /// <summary>
    ///   <para>Draw anti-aliased line specified with point array and width.</para>
    /// </summary>
    /// <param name="lineTex">The AA texture used for rendering.</param>
    /// <param name="width">The width of the line.</param>
    /// <param name="points">List of points to build the line from.</param>
    /// <param name="actualNumberOfPoints"></param>
    public static void DrawAAPolyLine(Texture2D lineTex, params Vector3[] points) => Handles.DoDrawAAPolyLine((Color[]) null, points, -1, lineTex, (float) (lineTex.height / 2), 0.99f);

    /// <summary>
    ///   <para>Draw anti-aliased line specified with point array and width.</para>
    /// </summary>
    /// <param name="lineTex">The AA texture used for rendering.</param>
    /// <param name="width">The width of the line.</param>
    /// <param name="points">List of points to build the line from.</param>
    /// <param name="actualNumberOfPoints"></param>
    public static void DrawAAPolyLine(
      float width,
      int actualNumberOfPoints,
      params Vector3[] points)
    {
      Handles.DoDrawAAPolyLine((Color[]) null, points, actualNumberOfPoints, (Texture2D) null, width, 0.75f);
    }

    /// <summary>
    ///   <para>Draw anti-aliased line specified with point array and width.</para>
    /// </summary>
    /// <param name="lineTex">The AA texture used for rendering.</param>
    /// <param name="width">The width of the line.</param>
    /// <param name="points">List of points to build the line from.</param>
    /// <param name="actualNumberOfPoints"></param>
    public static void DrawAAPolyLine(Texture2D lineTex, float width, params Vector3[] points) => Handles.DoDrawAAPolyLine((Color[]) null, points, -1, lineTex, width, 0.99f);

    private static void DoDrawAAPolyLine(
      Color[] colors,
      Vector3[] points,
      int actualNumberOfPoints,
      Texture2D lineTex,
      float width,
      float alpha)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      Color defaultColor = new Color(1f, 1f, 1f, alpha);
      if (colors != null)
      {
        for (int index = 0; index < colors.Length; ++index)
          colors[index] *= defaultColor;
      }
      else
        defaultColor *= Handles.color;
      Handles.Internal_DrawAAPolyLine(colors, points, defaultColor, actualNumberOfPoints, lineTex, width, Handles.matrix);
    }

    /// <summary>
    ///   <para>Draw anti-aliased convex polygon specified with point array.</para>
    /// </summary>
    /// <param name="points">List of points describing the convex polygon.</param>
    public static void DrawAAConvexPolygon(params Vector3[] points) => Handles.DoDrawAAConvexPolygon(points, -1, 1f);

    private static void DoDrawAAConvexPolygon(
      Vector3[] points,
      int actualNumberOfPoints,
      float alpha)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      Color defaultColor = new Color(1f, 1f, 1f, alpha) * Handles.color;
      Handles.Internal_DrawAAConvexPolygon(points, defaultColor, actualNumberOfPoints, Handles.matrix);
    }

    /// <summary>
    ///   <para>Draw textured bezier line through start and end points with the given tangents.</para>
    /// </summary>
    /// <param name="startPosition">The start point of the bezier line.</param>
    /// <param name="endPosition">The end point of the bezier line.</param>
    /// <param name="startTangent">The start tangent of the bezier line.</param>
    /// <param name="endTangent">The end tangent of the bezier line.</param>
    /// <param name="color">The color to use for the bezier line.</param>
    /// <param name="texture">The texture to use for drawing the bezier line.</param>
    /// <param name="width">The width of the bezier line.</param>
    public static void DrawBezier(
      Vector3 startPosition,
      Vector3 endPosition,
      Vector3 startTangent,
      Vector3 endTangent,
      Color color,
      Texture2D texture,
      float width)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      Handles.Internal_DrawBezier(startPosition, endPosition, startTangent, endTangent, color, texture, width, Handles.matrix);
    }

    /// <summary>
    ///   <para>Draw the outline of a flat disc in 3D space.</para>
    /// </summary>
    /// <param name="center">The center of the disc.</param>
    /// <param name="normal">The normal of the disc.</param>
    /// <param name="radius">The radius of the disc.</param>
    public static void DrawWireDisc(Vector3 center, Vector3 normal, float radius)
    {
      Vector3 from = Vector3.Cross(normal, Vector3.up);
      if ((double) from.sqrMagnitude < 1.0 / 1000.0)
        from = Vector3.Cross(normal, Vector3.right);
      Handles.DrawWireArc(center, normal, from, 360f, radius);
    }

    /// <summary>
    ///   <para>Draw a circular arc in 3D space.</para>
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="normal">The normal of the circle.</param>
    /// <param name="from">The direction of the point on the circle circumference, relative to the center, where the arc begins.</param>
    /// <param name="angle">The angle of the arc, in degrees.</param>
    /// <param name="radius">The radius of the circle
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void DrawWireArc(
      Vector3 center,
      Vector3 normal,
      Vector3 from,
      float angle,
      float radius)
    {
      Handles.SetDiscSectionPoints(Handles.s_WireArcPoints, center, normal, from, angle, radius);
      Handles.DrawPolyLine(Handles.s_WireArcPoints);
    }

    public static void DrawSolidRectangleWithOutline(
      Rect rectangle,
      Color faceColor,
      Color outlineColor)
    {
      Handles.DrawSolidRectangleWithOutline(new Vector3[4]
      {
        new Vector3(rectangle.xMin, rectangle.yMin, 0.0f),
        new Vector3(rectangle.xMax, rectangle.yMin, 0.0f),
        new Vector3(rectangle.xMax, rectangle.yMax, 0.0f),
        new Vector3(rectangle.xMin, rectangle.yMax, 0.0f)
      }, faceColor, outlineColor);
    }

    /// <summary>
    ///   <para>Draw a solid outlined rectangle in 3D space.</para>
    /// </summary>
    /// <param name="verts">The 4 vertices of the rectangle in world coordinates.</param>
    /// <param name="faceColor">The color of the rectangle's face.</param>
    /// <param name="outlineColor">The outline color of the rectangle.</param>
    public static void DrawSolidRectangleWithOutline(
      Vector3[] verts,
      Color faceColor,
      Color outlineColor)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      GL.PushMatrix();
      GL.MultMatrix(Handles.matrix);
      if ((double) faceColor.a > 0.0)
      {
        Color c = faceColor * Handles.color;
        GL.Begin(4);
        for (int index = 0; index < 2; ++index)
        {
          GL.Color(c);
          GL.Vertex(verts[index * 2]);
          GL.Vertex(verts[index * 2 + 1]);
          GL.Vertex(verts[(index * 2 + 2) % 4]);
          GL.Vertex(verts[index * 2]);
          GL.Vertex(verts[(index * 2 + 2) % 4]);
          GL.Vertex(verts[index * 2 + 1]);
        }
        GL.End();
      }
      if ((double) outlineColor.a > 0.0)
      {
        Color c = outlineColor * Handles.color;
        GL.Begin(1);
        GL.Color(c);
        for (int index = 0; index < 4; ++index)
        {
          GL.Vertex(verts[index]);
          GL.Vertex(verts[(index + 1) % 4]);
        }
        GL.End();
      }
      GL.PopMatrix();
    }

    /// <summary>
    ///   <para>Draw a solid flat disc in 3D space.</para>
    /// </summary>
    /// <param name="center">The center of the dics.</param>
    /// <param name="normal">The normal of the disc.</param>
    /// <param name="radius">The radius of the dics
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void DrawSolidDisc(Vector3 center, Vector3 normal, float radius)
    {
      Vector3 from = Vector3.Cross(normal, Vector3.up);
      if ((double) from.sqrMagnitude < 1.0 / 1000.0)
        from = Vector3.Cross(normal, Vector3.right);
      Handles.DrawSolidArc(center, normal, from, 360f, radius);
    }

    /// <summary>
    ///   <para>Draw a circular sector (pie piece) in 3D space.</para>
    /// </summary>
    /// <param name="center">The center of the circle.</param>
    /// <param name="normal">The normal of the circle.</param>
    /// <param name="from">The direction of the point on the circumference, relative to the center, where the sector begins.</param>
    /// <param name="angle">The angle of the sector, in degrees.</param>
    /// <param name="radius">The radius of the circle
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void DrawSolidArc(
      Vector3 center,
      Vector3 normal,
      Vector3 from,
      float angle,
      float radius)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Handles.SetDiscSectionPoints(Handles.s_WireArcPoints, center, normal, from, angle, radius);
      Shader.SetGlobalColor("_HandleColor", Handles.color * new Color(1f, 1f, 1f, 0.5f));
      Shader.SetGlobalFloat("_HandleSize", 1f);
      HandleUtility.ApplyWireMaterial(Handles.zTest);
      GL.PushMatrix();
      GL.MultMatrix(Handles.matrix);
      GL.Begin(4);
      int index = 1;
      for (int length = Handles.s_WireArcPoints.Length; index < length; ++index)
      {
        GL.Color(Handles.color);
        GL.Vertex(center);
        GL.Vertex(Handles.s_WireArcPoints[index - 1]);
        GL.Vertex(Handles.s_WireArcPoints[index]);
        GL.Vertex(center);
        GL.Vertex(Handles.s_WireArcPoints[index]);
        GL.Vertex(Handles.s_WireArcPoints[index - 1]);
      }
      GL.End();
      GL.PopMatrix();
    }

    internal static void Init()
    {
      if ((bool) (UnityEngine.Object) Handles.s_CubeMesh)
        return;
      GameObject gameObject = (GameObject) EditorGUIUtility.Load("SceneView/HandlesGO.fbx");
      if (!(bool) (UnityEngine.Object) gameObject)
        Debug.Log((object) "Couldn't find SceneView/HandlesGO.fbx");
      gameObject.SetActive(false);
      foreach (Transform transform in gameObject.transform)
      {
        MeshFilter component = transform.GetComponent<MeshFilter>();
        string name = transform.name;
        if (!(name == "Cube"))
        {
          if (!(name == "Sphere"))
          {
            if (!(name == "Cone"))
            {
              if (!(name == "Cylinder"))
              {
                if (name == "Quad")
                {
                  Handles.s_QuadMesh = component.sharedMesh;
                  Debug.AssertFormat((UnityEngine.Object) Handles.s_QuadMesh != (UnityEngine.Object) null, "mesh is null. A problem has occurred with `SceneView/HandlesGO.fbx`");
                }
              }
              else
              {
                Handles.s_CylinderMesh = component.sharedMesh;
                Debug.AssertFormat((UnityEngine.Object) Handles.s_CylinderMesh != (UnityEngine.Object) null, "mesh is null. A problem has occurred with `SceneView/HandlesGO.fbx`");
              }
            }
            else
            {
              Handles.s_ConeMesh = component.sharedMesh;
              Debug.AssertFormat((UnityEngine.Object) Handles.s_ConeMesh != (UnityEngine.Object) null, "mesh is null. A problem has occurred with `SceneView/HandlesGO.fbx`");
            }
          }
          else
          {
            Handles.s_SphereMesh = component.sharedMesh;
            Debug.AssertFormat((UnityEngine.Object) Handles.s_SphereMesh != (UnityEngine.Object) null, "mesh is null. A problem has occurred with `SceneView/HandlesGO.fbx`");
          }
        }
        else
        {
          Handles.s_CubeMesh = component.sharedMesh;
          Debug.AssertFormat((UnityEngine.Object) Handles.s_CubeMesh != (UnityEngine.Object) null, "mesh is null. A problem has occurred with `SceneView/HandlesGO.fbx`");
        }
      }
    }

    /// <summary>
    ///   <para>Make a text label positioned in 3D space.</para>
    /// </summary>
    /// <param name="position">Position in 3D space as seen from the current handle camera.</param>
    /// <param name="text">Text to display on the label.</param>
    /// <param name="image">Texture to display on the label.</param>
    /// <param name="content">Text, image and tooltip for this label.</param>
    /// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void Label(Vector3 position, string text) => Handles.Label(position, EditorGUIUtility.TempContent(text), GUI.skin.label);

    /// <summary>
    ///   <para>Make a text label positioned in 3D space.</para>
    /// </summary>
    /// <param name="position">Position in 3D space as seen from the current handle camera.</param>
    /// <param name="text">Text to display on the label.</param>
    /// <param name="image">Texture to display on the label.</param>
    /// <param name="content">Text, image and tooltip for this label.</param>
    /// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void Label(Vector3 position, Texture image) => Handles.Label(position, EditorGUIUtility.TempContent(image), GUI.skin.label);

    /// <summary>
    ///   <para>Make a text label positioned in 3D space.</para>
    /// </summary>
    /// <param name="position">Position in 3D space as seen from the current handle camera.</param>
    /// <param name="text">Text to display on the label.</param>
    /// <param name="image">Texture to display on the label.</param>
    /// <param name="content">Text, image and tooltip for this label.</param>
    /// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void Label(Vector3 position, GUIContent content) => Handles.Label(position, content, GUI.skin.label);

    /// <summary>
    ///   <para>Make a text label positioned in 3D space.</para>
    /// </summary>
    /// <param name="position">Position in 3D space as seen from the current handle camera.</param>
    /// <param name="text">Text to display on the label.</param>
    /// <param name="image">Texture to display on the label.</param>
    /// <param name="content">Text, image and tooltip for this label.</param>
    /// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void Label(Vector3 position, string text, GUIStyle style) => Handles.Label(position, EditorGUIUtility.TempContent(text), style);

    /// <summary>
    ///   <para>Make a text label positioned in 3D space.</para>
    /// </summary>
    /// <param name="position">Position in 3D space as seen from the current handle camera.</param>
    /// <param name="text">Text to display on the label.</param>
    /// <param name="image">Texture to display on the label.</param>
    /// <param name="content">Text, image and tooltip for this label.</param>
    /// <param name="style">The style to use. If left out, the label style from the current GUISkin is used.
    /// 
    /// Note: Use HandleUtility.GetHandleSize where you might want to have constant screen-sized handles.</param>
    public static void Label(Vector3 position, GUIContent content, GUIStyle style)
    {
      if ((double) HandleUtility.WorldToGUIPointWithDepth(position).z < 0.0)
        return;
      Handles.BeginGUI();
      GUI.Label(HandleUtility.WorldPointToSizedRect(position, content, style), content, style);
      Handles.EndGUI();
    }

    internal static Rect GetCameraRect(Rect position)
    {
      Rect rect = GUIClip.Unclip(position);
      return new Rect(rect.xMin, (float) Screen.height - rect.yMax, rect.width, rect.height);
    }

    /// <summary>
    ///   <para>Get the width and height of the main game view.</para>
    /// </summary>
    public static Vector2 GetMainGameViewSize() => PlayModeView.GetMainPlayModeViewTargetSize();

    /// <summary>
    ///   <para>Clears the camera.</para>
    /// </summary>
    /// <param name="position">Where in the Scene to clear.</param>
    /// <param name="camera">The camera to clear.</param>
    public static void ClearCamera(Rect position, Camera camera)
    {
      Event current = Event.current;
      if ((UnityEngine.Object) camera.targetTexture == (UnityEngine.Object) null)
      {
        Rect pixels = EditorGUIUtility.PointsToPixels(GUIClip.Unclip(position));
        Rect rect = new Rect(pixels.xMin, (float) Screen.height - pixels.yMax, pixels.width, pixels.height);
        camera.pixelRect = rect;
      }
      else
        camera.rect = new Rect(0.0f, 0.0f, 1f, 1f);
      if (current.type == UnityEngine.EventType.Repaint)
        Handles.Internal_ClearCamera(camera);
      else
        Handles.Internal_SetCurrentCamera(camera);
    }

    internal static void DrawCameraImpl(
      Rect position,
      Camera camera,
      DrawCameraMode drawMode,
      bool drawGrid,
      DrawGridParameters gridParam,
      bool finish,
      bool renderGizmos = true)
    {
      if (Event.current.type == UnityEngine.EventType.Repaint)
      {
        if ((UnityEngine.Object) camera.targetTexture == (UnityEngine.Object) null)
        {
          Rect pixels = EditorGUIUtility.PointsToPixels(GUIClip.Unclip(position));
          camera.pixelRect = new Rect(pixels.xMin, (float) Screen.height - pixels.yMax, pixels.width, pixels.height);
        }
        else
          camera.rect = new Rect(0.0f, 0.0f, 1f, 1f);
        if (drawMode == DrawCameraMode.Normal)
        {
          RenderTexture targetTexture = camera.targetTexture;
          camera.targetTexture = RenderTexture.active;
          camera.Render();
          camera.targetTexture = targetTexture;
        }
        else
        {
          if (drawGrid)
            Handles.Internal_DrawCameraWithGrid(camera, drawMode, ref gridParam, renderGizmos);
          else
            Handles.Internal_DrawCamera(camera, drawMode, renderGizmos);
          if (finish && camera.cameraType != CameraType.VR)
            Handles.Internal_FinishDrawingCamera(camera, renderGizmos);
        }
      }
      else
        Handles.Internal_SetCurrentCamera(camera);
    }

    internal static void DrawCamera(
      Rect position,
      Camera camera,
      DrawCameraMode drawMode,
      DrawGridParameters gridParam)
    {
      Handles.DrawCameraImpl(position, camera, drawMode, true, gridParam, true);
    }

    internal static void DrawCameraStep1(
      Rect position,
      Camera camera,
      DrawCameraMode drawMode,
      DrawGridParameters gridParam,
      bool drawGizmos)
    {
      Handles.DrawCameraImpl(position, camera, drawMode, true, gridParam, false, drawGizmos);
    }

    internal static void DrawCameraStep2(Camera camera, DrawCameraMode drawMode, bool drawGizmos)
    {
      if (Event.current.type != UnityEngine.EventType.Repaint || drawMode == DrawCameraMode.Normal)
        return;
      Handles.Internal_FinishDrawingCamera(camera, drawGizmos);
    }

    /// <summary>
    ///   <para>Draws a camera inside a rectangle.</para>
    /// </summary>
    /// <param name="position">The area to draw the camera within in GUI coordinates.</param>
    /// <param name="camera">The camera to draw.</param>
    /// <param name="drawMode">How the camera is drawn (textured, wireframe, etc.).</param>
    public static void DrawCamera(Rect position, Camera camera) => Handles.DrawCamera(position, camera, DrawCameraMode.Normal);

    /// <summary>
    ///   <para>Draws a camera inside a rectangle.</para>
    /// </summary>
    /// <param name="position">The area to draw the camera within in GUI coordinates.</param>
    /// <param name="camera">The camera to draw.</param>
    /// <param name="drawMode">How the camera is drawn (textured, wireframe, etc.).</param>
    public static void DrawCamera(Rect position, Camera camera, [DefaultValue("UnityEditor.DrawCameraMode.Normal")] DrawCameraMode drawMode)
    {
      DrawGridParameters gridParam = new DrawGridParameters();
      Handles.DrawCameraImpl(position, camera, drawMode, false, gridParam, true);
    }

    /// <summary>
    ///   <para>Set the current camera so all Handles and Gizmos are draw with its settings.</para>
    /// </summary>
    /// <param name="camera"></param>
    /// <param name="position"></param>
    public static void SetCamera(Camera camera)
    {
      if (Event.current.type == UnityEngine.EventType.Repaint)
        Handles.Internal_SetupCamera(camera);
      else
        Handles.Internal_SetCurrentCamera(camera);
    }

    /// <summary>
    ///   <para>Set the current camera so all Handles and Gizmos are draw with its settings.</para>
    /// </summary>
    /// <param name="camera"></param>
    /// <param name="position"></param>
    public static void SetCamera(Rect position, Camera camera)
    {
      Rect pixels = EditorGUIUtility.PointsToPixels(GUIClip.Unclip(position));
      Rect rect = new Rect(pixels.xMin, (float) Screen.height - pixels.yMax, pixels.width, pixels.height);
      camera.pixelRect = rect;
      if (Event.current.type == UnityEngine.EventType.Repaint)
        Handles.Internal_SetupCamera(camera);
      else
        Handles.Internal_SetCurrentCamera(camera);
    }

    /// <summary>
    ///   <para>Begin a 2D GUI block inside the 3D handle GUI.</para>
    /// </summary>
    public static void BeginGUI()
    {
      if (!(bool) (UnityEngine.Object) Camera.current || Event.current.type != UnityEngine.EventType.Repaint)
        return;
      GUIClip.Reapply();
    }

    [Obsolete("Please use BeginGUI() with GUILayout.BeginArea(position) / GUILayout.EndArea()")]
    public static void BeginGUI(Rect position) => GUILayout.BeginArea(position);

    /// <summary>
    ///   <para>End a 2D GUI block and get back to the 3D handle GUI.</para>
    /// </summary>
    public static void EndGUI()
    {
      Camera current = Camera.current;
      if (!(bool) (UnityEngine.Object) current || Event.current.type != UnityEngine.EventType.Repaint)
        return;
      Handles.Internal_SetupCamera(current);
    }

    internal static void ShowStaticLabelIfNeeded(Vector3 pos)
    {
      if (Tools.s_Hidden || !EditorApplication.isPlaying || !GameObjectUtility.ContainsStatic(Selection.gameObjects))
        return;
      Handles.ShowStaticLabel(pos);
    }

    internal static void ShowStaticLabel(Vector3 pos)
    {
      Handles.color = Color.white;
      Handles.zTest = CompareFunction.Always;
      GUIStyle style = (GUIStyle) "SC ViewAxisLabel";
      style.alignment = TextAnchor.MiddleLeft;
      style.fixedWidth = 0.0f;
      Handles.BeginGUI();
      Rect sizedRect = HandleUtility.WorldPointToSizedRect(pos, Handles.s_Static, style);
      sizedRect.x += 10f;
      sizedRect.y += 10f;
      GUI.Label(sizedRect, Handles.s_Static, style);
      Handles.EndGUI();
    }

    /// <summary>
    ///   <para>Retuns an array of points to representing the bezier curve.</para>
    /// </summary>
    /// <param name="startPosition"></param>
    /// <param name="endPosition"></param>
    /// <param name="startTangent"></param>
    /// <param name="endTangent"></param>
    /// <param name="division"></param>
    public static Vector3[] MakeBezierPoints(
      Vector3 startPosition,
      Vector3 endPosition,
      Vector3 startTangent,
      Vector3 endTangent,
      int division)
    {
      if (division < 1)
        throw new ArgumentOutOfRangeException(nameof (division), "Must be greater than zero");
      return Handles.Internal_MakeBezierPoints(startPosition, endPosition, startTangent, endTangent, division);
    }

    internal static float DistanceToPolygone(Vector3[] vertices) => HandleUtility.DistanceToPolyLine(vertices);

    internal static void DoBoneHandle(Transform target, Handles.BoneRenderer renderer) => Handles.DoBoneHandle(target, (Dictionary<Transform, bool>) null, renderer);

    internal static void DoBoneHandle(
      Transform target,
      Dictionary<Transform, bool> validBones,
      Handles.BoneRenderer renderer)
    {
      int hashCode = target.name.GetHashCode();
      Event current = Event.current;
      bool flag = false;
      if (validBones != null)
      {
        foreach (Transform key in target)
        {
          if (validBones.ContainsKey(key))
          {
            flag = true;
            break;
          }
        }
      }
      Vector3 position = target.position;
      List<Vector3> vector3List = new List<Vector3>();
      if (!flag && (UnityEngine.Object) target.parent != (UnityEngine.Object) null)
      {
        vector3List.Add(target.position + (target.position - target.parent.position) * 0.4f);
      }
      else
      {
        foreach (Transform key in target)
        {
          if (validBones == null || validBones.ContainsKey(key))
            vector3List.Add(key.position);
        }
      }
      for (int index = 0; index < vector3List.Count; ++index)
      {
        Vector3 end = vector3List[index];
        switch (current.GetTypeForControl(hashCode))
        {
          case UnityEngine.EventType.MouseDown:
            if (!current.alt && HandleUtility.nearestControl == hashCode && current.button == 0)
            {
              GUIUtility.hotControl = hashCode;
              if (current.shift)
              {
                UnityEngine.Object[] objects = Selection.objects;
                if (!ArrayUtility.Contains<UnityEngine.Object>(objects, (UnityEngine.Object) target))
                {
                  ArrayUtility.Add<UnityEngine.Object>(ref objects, (UnityEngine.Object) target);
                  Selection.objects = objects;
                }
              }
              else
                Selection.activeObject = (UnityEngine.Object) target;
              EditorGUIUtility.PingObject((UnityEngine.Object) target);
              current.Use();
              break;
            }
            break;
          case UnityEngine.EventType.MouseUp:
            if (GUIUtility.hotControl == hashCode && (current.button == 0 || current.button == 2))
            {
              GUIUtility.hotControl = 0;
              current.Use();
              break;
            }
            break;
          case UnityEngine.EventType.MouseMove:
            if (hashCode == HandleUtility.nearestControl)
            {
              HandleUtility.Repaint();
              break;
            }
            break;
          case UnityEngine.EventType.MouseDrag:
            if (!current.alt && GUIUtility.hotControl == hashCode)
            {
              DragAndDrop.PrepareStartDrag();
              DragAndDrop.objectReferences = new UnityEngine.Object[1]
              {
                (UnityEngine.Object) target
              };
              DragAndDrop.StartDrag(ObjectNames.GetDragAndDropTitle((UnityEngine.Object) target));
              GUIUtility.hotControl = 0;
              current.Use();
              break;
            }
            break;
          case UnityEngine.EventType.Repaint:
            Handles.color = GUIUtility.hotControl != 0 || HandleUtility.nearestControl != hashCode ? Handles.color : Handles.preselectionColor;
            if (flag)
            {
              renderer.AddBoneInstance(position, end, Handles.color);
              break;
            }
            renderer.AddBoneLeafInstance(position, target.rotation, (end - position).magnitude, Handles.color);
            break;
          case UnityEngine.EventType.Layout:
            Vector3[] boneWireVertices = Handles.BoneRenderer.GetBoneWireVertices(position, end);
            if (boneWireVertices != null)
            {
              HandleUtility.AddControl(hashCode, Handles.DistanceToPolygone(boneWireVertices));
              break;
            }
            break;
        }
      }
    }

    internal static Vector3 DoConeFrustrumHandle(
      Quaternion rotation,
      Vector3 position,
      Vector3 radiusAngleRange,
      Handles.ConeHandles showHandles)
    {
      if (Event.current.alt)
        showHandles = (Handles.ConeHandles) 0;
      Vector3 vector3 = rotation * Vector3.forward;
      Vector3 d1 = rotation * Vector3.up;
      Vector3 d2 = rotation * Vector3.right;
      float num1 = radiusAngleRange.x;
      float y1 = radiusAngleRange.y;
      float num2 = radiusAngleRange.z;
      float y2 = Mathf.Max(0.0f, y1);
      if ((uint) (showHandles & Handles.ConeHandles.Range) > 0U)
      {
        bool changed = GUI.changed;
        num2 = Handles.SizeSlider(position, vector3, num2);
        GUI.changed |= changed;
      }
      if ((uint) (showHandles & Handles.ConeHandles.Radius) > 0U)
      {
        bool changed = GUI.changed;
        GUI.changed = false;
        float r1 = Handles.SizeSlider(position, d1, num1);
        float r2 = Handles.SizeSlider(position, -d1, r1);
        float r3 = Handles.SizeSlider(position, d2, r2);
        num1 = Handles.SizeSlider(position, -d2, r3);
        if (GUI.changed)
          num1 = Mathf.Max(0.0f, num1);
        GUI.changed |= changed;
      }
      float num3 = Mathf.Min(1000f, Mathf.Abs(num2 * Mathf.Tan((float) Math.PI / 180f * y2)) + num1);
      if ((uint) (showHandles & Handles.ConeHandles.Angle) > 0U)
      {
        bool changed = GUI.changed;
        GUI.changed = false;
        float r1 = Handles.SizeSlider(position + vector3 * num2, d1, num3);
        float r2 = Handles.SizeSlider(position + vector3 * num2, -d1, r1);
        float r3 = Handles.SizeSlider(position + vector3 * num2, d2, r2);
        num3 = Handles.SizeSlider(position + vector3 * num2, -d2, r3);
        if (GUI.changed)
          y2 = Mathf.Clamp(57.29578f * Mathf.Atan((num3 - num1) / Mathf.Abs(num2)), 0.0f, 90f);
        GUI.changed |= changed;
      }
      if ((double) num1 > 0.0)
        Handles.DrawWireDisc(position, vector3, num1);
      if ((double) num3 > 0.0)
        Handles.DrawWireDisc(position + num2 * vector3, vector3, num3);
      Handles.DrawLine(position + d1 * num1, position + vector3 * num2 + d1 * num3);
      Handles.DrawLine(position - d1 * num1, position + vector3 * num2 - d1 * num3);
      Handles.DrawLine(position + d2 * num1, position + vector3 * num2 + d2 * num3);
      Handles.DrawLine(position - d2 * num1, position + vector3 * num2 - d2 * num3);
      return new Vector3(num1, y2, num2);
    }

    internal static Vector2 DoConeHandle(
      Quaternion rotation,
      Vector3 position,
      Vector2 angleAndRange,
      float angleScale,
      float rangeScale,
      bool handlesOnly)
    {
      float x = angleAndRange.x;
      float y = angleAndRange.y;
      float r1 = y * rangeScale;
      Vector3 vector3 = rotation * Vector3.forward;
      Vector3 d1 = rotation * Vector3.up;
      Vector3 d2 = rotation * Vector3.right;
      bool changed1 = GUI.changed;
      GUI.changed = false;
      float num = Handles.SizeSlider(position, vector3, r1);
      if (GUI.changed)
        y = Mathf.Max(0.0f, num / rangeScale);
      GUI.changed |= changed1;
      bool changed2 = GUI.changed;
      GUI.changed = false;
      float r2 = num * Mathf.Tan((float) (Math.PI / 180.0 * (double) x / 2.0)) * angleScale;
      float r3 = Handles.SizeSlider(position + vector3 * num, d1, r2);
      float r4 = Handles.SizeSlider(position + vector3 * num, -d1, r3);
      float r5 = Handles.SizeSlider(position + vector3 * num, d2, r4);
      float radius = Handles.SizeSlider(position + vector3 * num, -d2, r5);
      if (GUI.changed)
        x = Mathf.Clamp((float) (57.2957801818848 * (double) Mathf.Atan(radius / (num * angleScale)) * 2.0), 0.0f, 179f);
      GUI.changed |= changed2;
      if (!handlesOnly)
      {
        Handles.DrawLine(position, position + vector3 * num + d1 * radius);
        Handles.DrawLine(position, position + vector3 * num - d1 * radius);
        Handles.DrawLine(position, position + vector3 * num + d2 * radius);
        Handles.DrawLine(position, position + vector3 * num - d2 * radius);
        Handles.DrawWireDisc(position + num * vector3, vector3, radius);
      }
      return new Vector2(x, y);
    }

    internal static float SizeSlider(Vector3 p, Vector3 d, float r)
    {
      Vector3 position = p + d * r;
      float handleSize = HandleUtility.GetHandleSize(position);
      bool changed = GUI.changed;
      GUI.changed = false;
      Vector3 vector3 = Handles.Slider(position, d, handleSize * 0.03f, new Handles.CapFunction(Handles.DotHandleCap), 0.0f);
      if (GUI.changed)
        r = Vector3.Dot(vector3 - p, d);
      GUI.changed |= changed;
      return r;
    }

    private static bool currentlyDragging => (uint) GUIUtility.hotControl > 0U;

    public static Vector3 DoPositionHandle(Vector3 position, Quaternion rotation) => Handles.DoPositionHandle(Handles.PositionHandleIds.@default, position, rotation);

    internal static Vector3 DoPositionHandle(
      Handles.PositionHandleIds ids,
      Vector3 position,
      Quaternion rotation)
    {
      Event current = Event.current;
      switch (current.type)
      {
        case UnityEngine.EventType.KeyDown:
          if (current.keyCode == KeyCode.V && !Handles.currentlyDragging)
          {
            Handles.s_FreeMoveMode = true;
            break;
          }
          break;
        case UnityEngine.EventType.KeyUp:
          position = Handles.DoPositionHandle_Internal(ids, position, rotation, Handles.PositionHandleParam.DefaultHandle);
          if (current.keyCode == KeyCode.V && !current.shift && !Handles.currentlyDragging)
            Handles.s_FreeMoveMode = false;
          return position;
        case UnityEngine.EventType.Layout:
          if (!Handles.currentlyDragging && !Tools.vertexDragging)
          {
            Handles.s_FreeMoveMode = current.shift;
            break;
          }
          break;
      }
      Handles.PositionHandleParam positionHandleParam = Handles.s_FreeMoveMode ? Handles.PositionHandleParam.DefaultFreeMoveHandle : Handles.PositionHandleParam.DefaultHandle;
      return Handles.DoPositionHandle_Internal(ids, position, rotation, positionHandleParam);
    }

    private static Vector3 DoPositionHandle_Internal(
      Handles.PositionHandleIds ids,
      Vector3 position,
      Quaternion rotation,
      Handles.PositionHandleParam param)
    {
      Color color = Handles.color;
      bool flag1 = !Tools.s_Hidden && EditorApplication.isPlaying && GameObjectUtility.ContainsStatic(Selection.gameObjects);
      Vector3 cameraViewFrom = Handles.GetCameraViewFrom(Handles.matrix.MultiplyPoint3x4(position), (Handles.matrix * Matrix4x4.TRS(position, rotation, Vector3.one)).inverse);
      float handleSize = HandleUtility.GetHandleSize(position);
      for (int index = 0; index < 3; ++index)
        Handles.s_DoPositionHandle_Internal_CameraViewLerp[index] = ids[index] == GUIUtility.hotControl ? 0.0f : Handles.GetCameraViewLerpForWorldAxis(cameraViewFrom, Handles.GetAxisVector(index));
      for (int index = 0; index < 3; ++index)
        Handles.s_DoPositionHandle_Internal_CameraViewLerp[3 + index] = Mathf.Max(Handles.s_DoPositionHandle_Internal_CameraViewLerp[index], Handles.s_DoPositionHandle_Internal_CameraViewLerp[(index + 1) % 3]);
      bool flag2 = ids.Has(GUIUtility.hotControl);
      Vector3 vector3_1 = param.axisOffset;
      Vector3 vector3_2 = param.planeOffset;
      if (flag2)
      {
        vector3_1 = Vector3.zero;
        vector3_2 = Vector3.zero;
      }
      Vector3 vector3_3 = flag2 ? param.planeSize + param.planeOffset : param.planeSize;
      for (int index = 0; index < 3; ++index)
      {
        if (param.ShouldShow(3 + index) && (!flag2 || ids[3 + index] == GUIUtility.hotControl))
        {
          float cameraLerp = flag2 ? 0.0f : Handles.s_DoPositionHandle_Internal_CameraViewLerp[3 + index];
          if ((double) cameraLerp <= 0.899999976158142)
          {
            Vector3 offset = vector3_2 * handleSize;
            offset[Handles.s_DoPositionHandle_Internal_PrevIndex[index]] = 0.0f;
            float num = Mathf.Max(vector3_3[index], vector3_3[Handles.s_DoPositionHandle_Internal_NextIndex[index]]);
            position = Handles.DoPlanarHandle(ids[3 + index], index, position, offset, rotation, handleSize * num, cameraLerp, cameraViewFrom, param.planeOrientation);
          }
        }
      }
      for (int index = 0; index < 3; ++index)
      {
        if (param.ShouldShow(index))
        {
          if (!Handles.currentlyDragging)
          {
            switch (param.axesOrientation)
            {
              case Handles.PositionHandleParam.Orientation.Signed:
                Handles.s_DoPositionHandle_AxisHandlesOctant[index] = 1f;
                break;
              case Handles.PositionHandleParam.Orientation.Camera:
                Handles.s_DoPositionHandle_AxisHandlesOctant[index] = (double) cameraViewFrom[index] > 0.00999999977648258 ? -1f : 1f;
                break;
            }
          }
          bool flag3 = flag2 && ids[index] == GUIUtility.hotControl;
          Color colorByAxis = Handles.GetColorByAxis(index);
          Handles.color = flag1 ? Color.Lerp(colorByAxis, Handles.staticColor, Handles.staticBlend) : colorByAxis;
          GUI.SetNextControlName(Handles.s_DoPositionHandle_Internal_AxisNames[index]);
          float t = flag3 ? 0.0f : Handles.s_DoPositionHandle_Internal_CameraViewLerp[index];
          if ((double) t <= 0.899999976158142)
          {
            Handles.color = Color.Lerp(Handles.color, Color.clear, t);
            Vector3 axisVector = Handles.GetAxisVector(index);
            Vector3 vector3_4 = rotation * axisVector;
            Vector3 vector3_5 = vector3_4 * vector3_1[index] * handleSize;
            Vector3 vector3_6 = vector3_4 * Handles.s_DoPositionHandle_AxisHandlesOctant[index];
            Vector3 vector3_7 = vector3_5 * Handles.s_DoPositionHandle_AxisHandlesOctant[index];
            if (flag2 && !flag3)
              Handles.color = Handles.s_DisabledHandleColor;
            if (flag2 && (ids[Handles.s_DoPositionHandle_Internal_PrevPlaneIndex[index]] == GUIUtility.hotControl || ids[index + 3] == GUIUtility.hotControl))
              Handles.color = Handles.selectedColor;
            Handles.color = Handles.ToActiveColorSpace(Handles.color);
            Handles.s_DoPositionHandle_ArrowCapConeOffset = flag2 ? rotation * Vector3.Scale(Vector3.Scale(axisVector, param.axisOffset), Handles.s_DoPositionHandle_AxisHandlesOctant) : Vector3.zero;
            int id = ids[index];
            Vector3 position1 = position;
            Vector3 offset = vector3_7;
            Vector3 direction = vector3_6;
            double num1 = (double) handleSize;
            Vector3 vector3_8 = param.axisSize;
            double num2 = (double) vector3_8[index];
            double num3 = num1 * num2;
            Handles.CapFunction capFunction = new Handles.CapFunction(Handles.DoPositionHandle_ArrowCap);
            double num4;
            if (!GridSnapping.active)
            {
              vector3_8 = EditorSnapSettings.move;
              num4 = (double) vector3_8[index];
            }
            else
              num4 = 0.0;
            position = Handles.Slider(id, position1, offset, direction, (float) num3, capFunction, (float) num4);
          }
        }
      }
      VertexSnapping.HandleMouseMove(ids.xyz);
      if (param.ShouldShow(Handles.PositionHandleParam.Handle.XYZ) && (flag2 && ids.xyz == GUIUtility.hotControl || !flag2))
      {
        Handles.color = Handles.ToActiveColorSpace(Handles.centerColor);
        GUI.SetNextControlName("FreeMoveAxis");
        position = Handles.FreeMoveHandle(ids.xyz, position, rotation, handleSize * 0.15f, GridSnapping.active ? Vector3.zero : EditorSnapSettings.move, new Handles.CapFunction(Handles.RectangleHandleCap));
      }
      if (GridSnapping.active)
        position = GridSnapping.Snap(position);
      Handles.color = color;
      return position;
    }

    private static Vector3 DoPlanarHandle(
      int id,
      int planePrimaryAxis,
      Vector3 position,
      Vector3 offset,
      Quaternion rotation,
      float handleSize,
      float cameraLerp,
      Vector3 viewVectorDrawSpace,
      Handles.PositionHandleParam.Orientation orientation)
    {
      Vector3 a = offset;
      int index1 = planePrimaryAxis;
      int index2 = (index1 + 1) % 3;
      int num1 = (index1 + 2) % 3;
      Color color = Handles.color;
      Handles.color = !Tools.s_Hidden && EditorApplication.isPlaying && GameObjectUtility.ContainsStatic(Selection.gameObjects) ? Handles.staticColor : Handles.GetColorByAxis(num1);
      Handles.color = Color.Lerp(Handles.color, Color.clear, cameraLerp);
      bool flag = false;
      if (GUIUtility.hotControl == id)
        Handles.color = Handles.selectedColor;
      else if (HandleUtility.nearestControl == id && !Event.current.alt)
        Handles.color = Handles.preselectionColor;
      else
        flag = true;
      Handles.color = Handles.ToActiveColorSpace(Handles.color);
      if (!Handles.currentlyDragging)
      {
        switch (orientation)
        {
          case Handles.PositionHandleParam.Orientation.Signed:
            Handles.s_PlanarHandlesOctant[index1] = 1f;
            Handles.s_PlanarHandlesOctant[index2] = 1f;
            break;
          case Handles.PositionHandleParam.Orientation.Camera:
            Handles.s_PlanarHandlesOctant[index1] = (double) viewVectorDrawSpace[index1] > 0.00999999977648258 ? -1f : 1f;
            Handles.s_PlanarHandlesOctant[index2] = (double) viewVectorDrawSpace[index2] > 0.00999999977648258 ? -1f : 1f;
            break;
        }
      }
      Vector3 b = Handles.s_PlanarHandlesOctant;
      b[num1] = 0.0f;
      Vector3 vector3_1 = rotation * Vector3.Scale(a, b);
      b = rotation * (b * handleSize * 0.5f);
      Vector3 vector3_2 = Vector3.zero;
      Vector3 vector3_3 = Vector3.zero;
      Vector3 zero = Vector3.zero;
      vector3_2[index1] = 1f;
      vector3_3[index2] = 1f;
      zero[num1] = 1f;
      vector3_2 = rotation * vector3_2;
      vector3_3 = rotation * vector3_3;
      Vector3 vector3_4 = rotation * zero;
      Handles.verts[0] = position + vector3_1 + b + (vector3_2 + vector3_3) * handleSize * 0.5f;
      Handles.verts[1] = position + vector3_1 + b + (-vector3_2 + vector3_3) * handleSize * 0.5f;
      Handles.verts[2] = position + vector3_1 + b + (-vector3_2 - vector3_3) * handleSize * 0.5f;
      Handles.verts[3] = position + vector3_1 + b + (vector3_2 - vector3_3) * handleSize * 0.5f;
      Color activeColorSpace = Handles.ToActiveColorSpace(flag ? new Color(Handles.color.r, Handles.color.g, Handles.color.b, 0.1f) : Handles.color);
      Handles.DrawSolidRectangleWithOutline(Handles.verts, activeColorSpace, Color.clear);
      int id1 = id;
      Vector3 handlePos = position;
      Vector3 offset1 = b + vector3_1;
      Vector3 handleDir = vector3_4;
      Vector3 slideDir1 = vector3_2;
      Vector3 slideDir2 = vector3_3;
      double num2 = (double) handleSize * 0.5;
      Handles.CapFunction capFunction = new Handles.CapFunction(Handles.RectangleHandleCap);
      Vector2 snap;
      if (!GridSnapping.active)
      {
        Vector3 move = EditorSnapSettings.move;
        double num3 = (double) move[index1];
        move = EditorSnapSettings.move;
        double num4 = (double) move[index2];
        snap = new Vector2((float) num3, (float) num4);
      }
      else
        snap = Vector2.zero;
      position = Handles.Slider2D(id1, handlePos, offset1, handleDir, slideDir1, slideDir2, (float) num2, capFunction, snap, false);
      Handles.color = color;
      return position;
    }

    private static void DoPositionHandle_ArrowCap(
      int controlId,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType)
    {
      Handles.ArrowHandleCap(controlId, position, rotation, size, eventType, Handles.s_DoPositionHandle_ArrowCapConeOffset);
    }

    internal static float DoRadiusHandle(
      Quaternion rotation,
      Vector3 position,
      float radius,
      bool handlesOnly)
    {
      float num1 = 90f;
      Vector3[] vector3Array = new Vector3[6]
      {
        rotation * Vector3.right,
        rotation * Vector3.up,
        rotation * Vector3.forward,
        rotation * -Vector3.right,
        rotation * -Vector3.up,
        rotation * -Vector3.forward
      };
      Vector3 vector3;
      if (Camera.current.orthographic)
      {
        vector3 = Camera.current.transform.forward;
        if (!handlesOnly)
        {
          Handles.DrawWireDisc(position, vector3, radius);
          for (int index = 0; index < 3; ++index)
          {
            Vector3 normalized = Vector3.Cross(vector3Array[index], vector3).normalized;
            Handles.DrawTwoShadedWireDisc(position, vector3Array[index], normalized, 180f, radius);
          }
        }
      }
      else
      {
        Matrix4x4 matrix4x4 = Matrix4x4.Inverse(Handles.matrix);
        vector3 = position - matrix4x4.MultiplyPoint(Camera.current.transform.position);
        float sqrMagnitude = vector3.sqrMagnitude;
        float num2 = radius * radius;
        float f1 = num2 * num2 / sqrMagnitude;
        float num3 = f1 / num2;
        if ((double) num3 < 1.0)
        {
          float num4 = Mathf.Sqrt(num2 - f1);
          num1 = Mathf.Atan2(num4, Mathf.Sqrt(f1)) * 57.29578f;
          if (!handlesOnly)
            Handles.DrawWireDisc(position - num2 * vector3 / sqrMagnitude, vector3, num4);
        }
        else
          num1 = -1000f;
        if (!handlesOnly)
        {
          for (int index = 0; index < 3; ++index)
          {
            if ((double) num3 < 1.0)
            {
              float a = Vector3.Angle(vector3, vector3Array[index]);
              float num4 = Mathf.Tan((90f - Mathf.Min(a, 180f - a)) * ((float) Math.PI / 180f));
              float f2 = Mathf.Sqrt(f1 + num4 * num4 * f1) / radius;
              if ((double) f2 < 1.0)
              {
                float angle = Mathf.Asin(f2) * 57.29578f;
                Vector3 normalized = Vector3.Cross(vector3Array[index], vector3).normalized;
                Vector3 from = Quaternion.AngleAxis(angle, vector3Array[index]) * normalized;
                Handles.DrawTwoShadedWireDisc(position, vector3Array[index], from, (float) ((90.0 - (double) angle) * 2.0), radius);
              }
              else
                Handles.DrawTwoShadedWireDisc(position, vector3Array[index], radius);
            }
            else
              Handles.DrawTwoShadedWireDisc(position, vector3Array[index], radius);
          }
        }
      }
      Color color1 = Handles.color;
      for (int index = 0; index < 6; ++index)
      {
        int controlId = GUIUtility.GetControlID(Handles.s_RadiusHandleHash, FocusType.Passive);
        float num2 = Vector3.Angle(vector3Array[index], -vector3);
        if ((double) num2 > 5.0 && (double) num2 < 175.0 || GUIUtility.hotControl == controlId)
        {
          Color color2 = color1;
          color2.a = (double) num2 <= (double) num1 + 5.0 ? Mathf.Clamp01(color1.a * 2f) : Mathf.Clamp01((float) ((double) Handles.backfaceAlphaMultiplier * (double) color1.a * 2.0));
          Handles.color = Handles.ToActiveColorSpace(color2);
          Vector3 position1 = position + radius * vector3Array[index];
          bool changed = GUI.changed;
          GUI.changed = false;
          Vector3 a = Slider1D.Do(controlId, position1, vector3Array[index], HandleUtility.GetHandleSize(position1) * 0.03f, new Handles.CapFunction(Handles.DotHandleCap), 0.0f);
          if (GUI.changed)
            radius = Vector3.Distance(a, position);
          GUI.changed |= changed;
        }
      }
      Handles.color = color1;
      return radius;
    }

    internal static Vector2 DoRectHandles(
      Quaternion rotation,
      Vector3 position,
      Vector2 size,
      bool handlesOnly)
    {
      Vector3 d1 = rotation * Vector3.up;
      Vector3 d2 = rotation * Vector3.right;
      float r1 = 0.5f * size.x;
      float r2 = 0.5f * size.y;
      if (!handlesOnly)
      {
        Vector3 vector3_1 = position + d1 * r2 + d2 * r1;
        Vector3 vector3_2 = position - d1 * r2 + d2 * r1;
        Vector3 vector3_3 = position - d1 * r2 - d2 * r1;
        Vector3 vector3_4 = position + d1 * r2 - d2 * r1;
        Handles.DrawLine(vector3_1, vector3_2);
        Handles.DrawLine(vector3_2, vector3_3);
        Handles.DrawLine(vector3_3, vector3_4);
        Handles.DrawLine(vector3_4, vector3_1);
      }
      Color color1 = Handles.color;
      Color color2 = Handles.color;
      color2.a = Mathf.Clamp01(Handles.color.a * 2f);
      Handles.color = Handles.ToActiveColorSpace(color2);
      float r3 = Handles.SizeSlider(position, d1, r2);
      float num1 = Handles.SizeSlider(position, -d1, r3);
      float r4 = Handles.SizeSlider(position, d2, r1);
      float num2 = Handles.SizeSlider(position, -d2, r4);
      size.x = Mathf.Max(0.0f, 2f * num2);
      size.y = Mathf.Max(0.0f, 2f * num1);
      Handles.color = color1;
      return size;
    }

    public static Quaternion DoRotationHandle(Quaternion rotation, Vector3 position) => Handles.DoRotationHandle(Handles.RotationHandleIds.@default, rotation, position, Handles.RotationHandleParam.Default);

    internal static Quaternion DoRotationHandle(
      Handles.RotationHandleIds ids,
      Quaternion rotation,
      Vector3 position,
      Handles.RotationHandleParam param)
    {
      Event current = Event.current;
      Vector3 vector3 = Handles.inverseMatrix.MultiplyVector((UnityEngine.Object) Camera.current != (UnityEngine.Object) null ? Camera.current.transform.forward : Vector3.forward);
      float handleSize = HandleUtility.GetHandleSize(position);
      Color color = Handles.color;
      bool flag1 = !Tools.s_Hidden && EditorApplication.isPlaying && GameObjectUtility.ContainsStatic(Selection.gameObjects);
      bool flag2 = ids.Has(GUIUtility.hotControl);
      if (!flag1 && param.ShouldShow(Handles.RotationHandleParam.Handle.XYZ) && (flag2 && ids.xyz == GUIUtility.hotControl || !flag2))
      {
        Handles.color = Handles.centerColor;
        rotation = FreeRotate.Do(ids.xyz, rotation, position, handleSize * param.xyzSize, param.displayXYZCircle);
      }
      float num1 = -1f;
      for (int index = 0; index < 3; ++index)
      {
        if (param.ShouldShow(index))
        {
          Color colorByAxis = Handles.GetColorByAxis(index);
          Handles.color = flag1 ? Color.Lerp(colorByAxis, Handles.staticColor, Handles.staticBlend) : colorByAxis;
          Handles.color = Handles.ToActiveColorSpace(Handles.color);
          Vector3 axisVector = Handles.GetAxisVector(index);
          float num2 = handleSize * param.axisSize[index];
          num1 = Mathf.Max(num2, num1);
          rotation = UnityEditorInternal.Disc.Do(ids[index], rotation, position, rotation * axisVector, num2, true, EditorSnapSettings.rotate, param.enableRayDrag, true, Handles.k_RotationPieColor);
        }
      }
      if ((double) num1 > 0.0 && current.type == UnityEngine.EventType.Repaint)
      {
        Handles.color = new Color(0.0f, 0.0f, 0.0f, 0.2f);
        Handles.DrawWireDisc(position, vector3, num1);
      }
      if (flag2 && current.type == UnityEngine.EventType.Repaint)
      {
        Handles.color = Handles.ToActiveColorSpace(Handles.s_DisabledHandleColor);
        Handles.DrawWireDisc(position, vector3, handleSize * param.axisSize[0]);
      }
      if (!flag1 && param.ShouldShow(Handles.RotationHandleParam.Handle.CameraAxis) && (flag2 && ids.cameraAxis == GUIUtility.hotControl || !flag2))
      {
        Handles.color = Handles.ToActiveColorSpace(Handles.centerColor);
        rotation = UnityEditorInternal.Disc.Do(ids.cameraAxis, rotation, position, vector3, handleSize * param.cameraAxisSize, false, 0.0f, param.enableRayDrag, true, Handles.k_RotationPieColor);
      }
      Handles.color = color;
      return rotation;
    }

    public static Vector3 DoScaleHandle(
      Vector3 scale,
      Vector3 position,
      Quaternion rotation,
      float size)
    {
      return Handles.DoScaleHandle(Handles.ScaleHandleIds.@default, scale, position, rotation, size, Handles.ScaleHandleParam.Default);
    }

    internal static Vector3 DoScaleHandle(
      Handles.ScaleHandleIds ids,
      Vector3 scale,
      Vector3 position,
      Quaternion rotation,
      float handleSize,
      Handles.ScaleHandleParam param)
    {
      Vector3 cameraViewFrom = Handles.GetCameraViewFrom(Handles.matrix.MultiplyPoint3x4(position), (Handles.matrix * Matrix4x4.TRS(position, rotation, Vector3.one)).inverse);
      bool flag1 = !Tools.s_Hidden && EditorApplication.isPlaying && GameObjectUtility.ContainsStatic(Selection.gameObjects);
      bool flag2 = ids.Has(GUIUtility.hotControl);
      Vector3 vector3_1 = param.axisOffset;
      Vector3 axisLineScale = param.axisLineScale;
      if (flag2)
      {
        axisLineScale += vector3_1;
        vector3_1 = Vector3.zero;
      }
      bool flag3 = ids.xyz == GUIUtility.hotControl;
      if (Event.current.type == UnityEngine.EventType.MouseDown)
        Handles.s_InitialScale = scale;
      for (int index = 0; index < 3; ++index)
      {
        if (param.ShouldShow(index))
        {
          if (!Handles.currentlyDragging)
          {
            switch (param.orientation)
            {
              case Handles.ScaleHandleParam.Orientation.Signed:
                Handles.s_DoScaleHandle_AxisHandlesOctant[index] = 1f;
                break;
              case Handles.ScaleHandleParam.Orientation.Camera:
                Handles.s_DoScaleHandle_AxisHandlesOctant[index] = (double) cameraViewFrom[index] > 0.00999999977648258 ? -1f : 1f;
                break;
            }
          }
          int id = ids[index];
          bool flag4 = flag2 && id == GUIUtility.hotControl;
          Vector3 axisVector = Handles.GetAxisVector(index);
          Color colorByAxis = Handles.GetColorByAxis(index);
          float handleOffset = vector3_1[index];
          float num = id == GUIUtility.hotControl ? 0.0f : Handles.GetCameraViewLerpForWorldAxis(cameraViewFrom, axisVector);
          float t = flag2 ? 0.0f : num;
          Handles.color = flag1 ? Color.Lerp(colorByAxis, Handles.staticColor, Handles.staticBlend) : colorByAxis;
          Vector3 vector3_2 = axisVector * Handles.s_DoScaleHandle_AxisHandlesOctant[index];
          if ((double) t <= 0.899999976158142)
          {
            Handles.color = Color.Lerp(Handles.color, Color.clear, t);
            if (flag2 && !flag4)
              Handles.color = Handles.s_DisabledHandleColor;
            if (flag3)
              Handles.color = Handles.selectedColor;
            Handles.color = Handles.ToActiveColorSpace(Handles.color);
            scale[index] = SliderScale.DoAxis(id, scale[index], position, rotation * vector3_2, rotation, handleSize * param.axisSize[index], EditorSnapSettings.scale, handleOffset, axisLineScale[index]);
          }
        }
      }
      if (param.ShouldShow(Handles.ScaleHandleParam.Handle.XYZ) && (flag2 && ids.xyz == GUIUtility.hotControl || !flag2))
      {
        Handles.color = Handles.ToActiveColorSpace(Handles.centerColor);
        EditorGUI.BeginChangeCheck();
        float num = Handles.ScaleValueHandle(ids.xyz, scale.x, position, rotation, handleSize * param.xyzSize, new Handles.CapFunction(Handles.CubeHandleCap), EditorSnapSettings.scale);
        if (EditorGUI.EndChangeCheck())
          scale = Handles.s_InitialScale * num;
      }
      return scale;
    }

    internal static float DoSimpleEdgeHandle(
      Quaternion rotation,
      Vector3 position,
      float radius,
      bool editable = true)
    {
      if (Event.current.alt)
        editable = false;
      Vector3 d = rotation * Vector3.right;
      if (editable)
      {
        EditorGUI.BeginChangeCheck();
        radius = Handles.SizeSlider(position, d, radius);
        radius = Handles.SizeSlider(position, -d, radius);
        if (EditorGUI.EndChangeCheck())
          radius = Mathf.Max(0.0f, radius);
      }
      if ((double) radius > 0.0)
        Handles.DrawLine(position - d * radius, position + d * radius);
      return radius;
    }

    internal static float DoSimpleRadiusHandle(
      Quaternion rotation,
      Vector3 position,
      float radius,
      bool hemisphere,
      float arc = 360f,
      bool editable = true)
    {
      if (Event.current.alt)
        editable = false;
      Vector3 vector3_1 = rotation * Vector3.forward;
      Vector3 vector3_2 = rotation * Vector3.up;
      Vector3 vector3_3 = rotation * Vector3.right;
      if (editable)
      {
        bool changed1 = GUI.changed;
        GUI.changed = false;
        radius = Handles.SizeSlider(position, vector3_1, radius);
        if (!hemisphere)
          radius = Handles.SizeSlider(position, -vector3_1, radius);
        if (GUI.changed)
          radius = Mathf.Max(0.0f, radius);
        GUI.changed |= changed1;
        bool changed2 = GUI.changed;
        GUI.changed = false;
        radius = Handles.SizeSlider(position, vector3_3, radius);
        if ((double) arc >= 90.0)
          radius = Handles.SizeSlider(position, vector3_2, radius);
        if ((double) arc >= 180.0)
          radius = Handles.SizeSlider(position, -vector3_3, radius);
        if ((double) arc >= 270.0)
          radius = Handles.SizeSlider(position, -vector3_2, radius);
        if (GUI.changed)
          radius = Mathf.Max(0.0f, radius);
        GUI.changed |= changed2;
      }
      if ((double) radius > 0.0)
      {
        Handles.DrawWireArc(position, vector3_1, vector3_3, arc, radius);
        Handles.DrawWireArc(position, vector3_2, vector3_1, hemisphere ? 90f : 180f, radius);
        for (int index = 0; index < 4; ++index)
        {
          if ((double) arc >= 90.0 * (double) index)
          {
            Vector3 normal = (Vector3) (Matrix4x4.Rotate(Quaternion.Euler(0.0f, 0.0f, 90f * (float) index)) * (Vector4) vector3_2);
            Handles.DrawWireArc(position, normal, vector3_1, hemisphere ? 90f : 180f, radius);
          }
        }
        Vector3 normal1 = (Vector3) (Matrix4x4.Rotate(Quaternion.Euler(0.0f, 0.0f, arc)) * (Vector4) vector3_2);
        Handles.DrawWireArc(position, normal1, vector3_1, hemisphere ? 90f : 180f, radius);
      }
      return radius;
    }

    public static void TransformHandle(
      ref Vector3 position,
      ref Quaternion rotation,
      ref Vector3 scale)
    {
      Handles.TransformHandle(Handles.TransformHandleIds.Default, ref position, ref rotation, ref scale, Handles.TransformHandleParam.Default);
    }

    public static void TransformHandle(
      ref Vector3 position,
      Quaternion rotation,
      ref Vector3 scale)
    {
      Handles.TransformHandle(Handles.TransformHandleIds.Default, ref position, ref rotation, ref scale, Handles.TransformHandleParam.Default.Without(Handles.RotationHandleParam.Handle.All));
    }

    public static void TransformHandle(
      Vector3 position,
      ref Quaternion rotation,
      ref Vector3 scale)
    {
      Handles.TransformHandle(Handles.TransformHandleIds.Default, ref position, ref rotation, ref scale, Handles.TransformHandleParam.Default.Without(Handles.PositionHandleParam.Handle.All));
    }

    public static void TransformHandle(
      ref Vector3 position,
      ref Quaternion rotation,
      ref float uniformScale)
    {
      Vector3 scale = Vector3.one * uniformScale;
      Handles.TransformHandle(Handles.TransformHandleIds.Default, ref position, ref rotation, ref scale, Handles.TransformHandleParam.Default.Without(Handles.ScaleHandleParam.Handle.X | Handles.ScaleHandleParam.Handle.Y | Handles.ScaleHandleParam.Handle.Z));
      uniformScale = scale.x;
    }

    public static void TransformHandle(
      ref Vector3 position,
      Quaternion rotation,
      ref float uniformScale)
    {
      Vector3 vector3 = Vector3.one * uniformScale;
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref vector3;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.RotationHandleParam.Handle.All);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.Without(Handles.ScaleHandleParam.Handle.X | Handles.ScaleHandleParam.Handle.Y | Handles.ScaleHandleParam.Handle.Z);
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
      uniformScale = vector3.x;
    }

    public static void TransformHandle(
      Vector3 position,
      ref Quaternion rotation,
      ref float uniformScale)
    {
      Vector3 vector3 = Vector3.one * uniformScale;
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref vector3;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.PositionHandleParam.Handle.All);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.Without(Handles.ScaleHandleParam.Handle.X | Handles.ScaleHandleParam.Handle.Y | Handles.ScaleHandleParam.Handle.Z);
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
      uniformScale = vector3.x;
    }

    public static void TransformHandle(ref Vector3 position, ref Quaternion rotation)
    {
      Vector3 one = Vector3.one;
      Handles.TransformHandle(Handles.TransformHandleIds.Default, ref position, ref rotation, ref one, Handles.TransformHandleParam.Default.Without(Handles.ScaleHandleParam.Handle.All));
    }

    private static void TransformHandle(ref Vector3 position, Quaternion rotation)
    {
      Vector3 one = Vector3.one;
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref one;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.ScaleHandleParam.Handle.All);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.WithSoloPositionManipulatorSize();
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
    }

    private static void TransformHandle(Vector3 position, ref Quaternion rotation)
    {
      Vector3 one = Vector3.one;
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref one;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.ScaleHandleParam.Handle.All);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.WithSoloRotationManipulatorSize();
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
    }

    private static void TransformHandle(Vector3 position, Quaternion rotation, ref Vector3 scale)
    {
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref scale;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.PositionHandleParam.Handle.All);
      transformHandleParam1 = transformHandleParam1.Without(Handles.RotationHandleParam.Handle.All);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.WithSoloScaleManipulatorSize();
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
    }

    private static void TransformHandle(
      Vector3 position,
      Quaternion rotation,
      ref float uniformScale)
    {
      Vector3 vector3 = Vector3.one * uniformScale;
      Handles.TransformHandleIds ids = Handles.TransformHandleIds.Default;
      ref Vector3 local1 = ref position;
      ref Quaternion local2 = ref rotation;
      ref Vector3 local3 = ref vector3;
      Handles.TransformHandleParam transformHandleParam1 = Handles.TransformHandleParam.Default;
      transformHandleParam1 = transformHandleParam1.Without(Handles.PositionHandleParam.Handle.All);
      transformHandleParam1 = transformHandleParam1.Without(Handles.RotationHandleParam.Handle.All);
      transformHandleParam1 = transformHandleParam1.Without(Handles.ScaleHandleParam.Handle.X | Handles.ScaleHandleParam.Handle.Y | Handles.ScaleHandleParam.Handle.Z);
      Handles.TransformHandleParam transformHandleParam2 = transformHandleParam1.WithSoloScaleManipulatorSize();
      Handles.TransformHandle(ids, ref local1, ref local2, ref local3, transformHandleParam2);
      uniformScale = vector3.x;
    }

    internal static void TransformHandle(
      Handles.TransformHandleIds ids,
      ref Vector3 position,
      ref Quaternion rotation,
      ref Vector3 scale,
      Handles.TransformHandleParam param)
    {
      Quaternion rotation1 = rotation;
      Handles.PositionHandleParam positionHandleParam = param.position;
      Handles.RotationHandleParam rotationHandleParam = param.rotation;
      Handles.ScaleHandleParam scaleHandleParam = param.scale;
      bool flag1 = ids.Has(GUIUtility.hotControl);
      bool flag2 = flag1 && Handles.s_IsHotInCameraAlignedMode || !flag1 && Event.current.shift;
      if (Tools.vertexDragging)
      {
        positionHandleParam = param.vertexSnappingPosition;
        rotationHandleParam = param.vertexSnappingRotation;
        scaleHandleParam = param.vertexSnappingScale;
      }
      else if (flag2)
      {
        rotation1 = Camera.current.transform.rotation;
        positionHandleParam = param.cameraAlignedPosition;
        rotationHandleParam = param.cameraAlignedRotation;
        scaleHandleParam = param.cameraAlignedScale;
      }
      else if (Tools.pivotRotation == PivotRotation.Local)
      {
        positionHandleParam = param.localPosition;
        rotationHandleParam = param.localRotation;
        scaleHandleParam = param.localScale;
      }
      if (ids.Has(GUIUtility.hotControl))
      {
        if (ids.position.Has(GUIUtility.hotControl))
          position = Handles.DoPositionHandle_Internal(ids.position, position, rotation1, positionHandleParam);
        else if (ids.rotation.Has(GUIUtility.hotControl))
        {
          Quaternion quaternion1 = Handles.DoRotationHandle(ids.rotation, rotation1, position, rotationHandleParam);
          if (flag2)
          {
            if (!Handles.s_TransformHandle_RotationData.ContainsKey(ids.rotation))
              Handles.s_TransformHandle_RotationData[ids.rotation] = new Handles.RotationHandleData()
              {
                rotationStarted = true,
                initialRotation = rotation
              };
            Quaternion quaternion2 = ids.rotation.xyz != GUIUtility.hotControl ? Handles.s_TransformHandle_RotationData[ids.rotation].initialRotation : rotation;
            float angle;
            Vector3 axis;
            (quaternion1 * Quaternion.Inverse(rotation1)).ToAngleAxis(out angle, out axis);
            rotation = Quaternion.AngleAxis(angle, axis) * quaternion2;
          }
          else
            rotation = quaternion1;
        }
        else if (ids.scale.Has(GUIUtility.hotControl))
          scale = Handles.DoScaleHandle(ids.scale, scale, position, rotation1, HandleUtility.GetHandleSize(position), scaleHandleParam);
      }
      else
      {
        if (Handles.s_TransformHandle_RotationData.ContainsKey(ids.rotation))
        {
          Handles.RotationHandleData rotationHandleData = Handles.s_TransformHandle_RotationData[ids.rotation];
          rotationHandleData.rotationStarted = false;
          Handles.s_TransformHandle_RotationData[ids.rotation] = rotationHandleData;
        }
        Handles.DoRotationHandle(ids.rotation, rotation1, position, rotationHandleParam);
        Handles.DoPositionHandle_Internal(ids.position, position, rotation1, positionHandleParam);
        Handles.DoScaleHandle(ids.scale, scale, position, rotation1, HandleUtility.GetHandleSize(position), scaleHandleParam);
      }
      bool flag3 = ids.Has(GUIUtility.hotControl);
      if (((!flag3 ? 0 : (!flag1 ? 1 : 0)) & (flag2 ? 1 : 0)) != 0)
      {
        Handles.s_IsHotInCameraAlignedMode = true;
      }
      else
      {
        if (!Handles.s_IsHotInCameraAlignedMode || flag1 && flag3)
          return;
        Handles.s_IsHotInCameraAlignedMode = false;
      }
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_color_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_color_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_matrix_Injected(out Matrix4x4 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_matrix_Injected(ref Matrix4x4 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_inverseMatrix_Injected(out Matrix4x4 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetSceneViewColors_Injected(
      ref Color wire,
      ref Color wireOverlay,
      ref Color selectedOutline,
      ref Color selectedChildrenOutline,
      ref Color selectedWire);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_DrawAAPolyLine_Injected(
      Color[] colors,
      Vector3[] points,
      ref Color defaultColor,
      int actualNumberOfPoints,
      Texture2D texture,
      float width,
      ref Matrix4x4 toWorld);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_DrawAAConvexPolygon_Injected(
      Vector3[] points,
      ref Color defaultColor,
      int actualNumberOfPoints,
      ref Matrix4x4 toWorld);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_DrawBezier_Injected(
      ref Vector3 startPosition,
      ref Vector3 endPosition,
      ref Vector3 startTangent,
      ref Vector3 endTangent,
      ref Color color,
      Texture2D texture,
      float width,
      ref Matrix4x4 toWorld);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetDiscSectionPoints_Injected(
      Vector3[] dest,
      ref Vector3 center,
      ref Vector3 normal,
      ref Vector3 from,
      float angle,
      float radius);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Vector3[] Internal_MakeBezierPoints_Injected(
      ref Vector3 startPosition,
      ref Vector3 endPosition,
      ref Vector3 startTangent,
      ref Vector3 endTangent,
      int division);

    /// <summary>
    ///   <para>Disposable helper struct for automatically setting and reverting Handles.color and/or Handles.matrix.</para>
    /// </summary>
    public struct DrawingScope : IDisposable
    {
      private bool m_Disposed;
      private Color m_OriginalColor;
      private Matrix4x4 m_OriginalMatrix;

      /// <summary>
      ///   <para>The value of Handles.color at the time this DrawingScope was created.</para>
      /// </summary>
      public Color originalColor => this.m_OriginalColor;

      /// <summary>
      ///   <para>The value of Handles.matrix at the time this DrawingScope was created.</para>
      /// </summary>
      public Matrix4x4 originalMatrix => this.m_OriginalMatrix;

      /// <summary>
      ///   <para>Create a new DrawingScope and set Handles.color and/or Handles.matrix to the specified values.</para>
      /// </summary>
      /// <param name="matrix">The matrix to use for displaying Handles inside the scope block.</param>
      /// <param name="color">The color to use for displaying Handles inside the scope block.</param>
      public DrawingScope(Color color)
        : this(color, Handles.matrix)
      {
      }

      /// <summary>
      ///   <para>Create a new DrawingScope and set Handles.color and/or Handles.matrix to the specified values.</para>
      /// </summary>
      /// <param name="matrix">The matrix to use for displaying Handles inside the scope block.</param>
      /// <param name="color">The color to use for displaying Handles inside the scope block.</param>
      public DrawingScope(Matrix4x4 matrix)
        : this(Handles.color, matrix)
      {
      }

      /// <summary>
      ///   <para>Create a new DrawingScope and set Handles.color and/or Handles.matrix to the specified values.</para>
      /// </summary>
      /// <param name="matrix">The matrix to use for displaying Handles inside the scope block.</param>
      /// <param name="color">The color to use for displaying Handles inside the scope block.</param>
      public DrawingScope(Color color, Matrix4x4 matrix)
      {
        this.m_Disposed = false;
        this.m_OriginalColor = Handles.color;
        this.m_OriginalMatrix = Handles.matrix;
        Handles.matrix = matrix;
        Handles.color = color;
      }

      /// <summary>
      ///   <para>Automatically reverts Handles.color and Handles.matrix to their values prior to entering the scope, when the scope is exited. You do not need to call this method manually.</para>
      /// </summary>
      public void Dispose()
      {
        if (this.m_Disposed)
          return;
        this.m_Disposed = true;
        Handles.color = this.m_OriginalColor;
        Handles.matrix = this.m_OriginalMatrix;
      }
    }

    /// <summary>
    ///   <para>The function to use for drawing the handle e.g. Handles.RectangleCap.</para>
    /// </summary>
    /// <param name="controlID">The control ID for the handle.</param>
    /// <param name="position">The position of the handle in the space of Handles.matrix.</param>
    /// <param name="rotation">The rotation of the handle in the space of Handles.matrix.</param>
    /// <param name="size">The size of the handle in world-space units.</param>
    /// <param name="eventType">Event type for the handle to act upon. By design it handles EventType.Layout and EventType.Repaint events.</param>
    public delegate void CapFunction(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size,
      UnityEngine.EventType eventType);

    [Obsolete("This delegate is obsolete. Use CapFunction instead.")]
    public delegate void DrawCapFunction(
      int controlID,
      Vector3 position,
      Quaternion rotation,
      float size);

    /// <summary>
    ///   <para>A delegate type for getting a handle's size based on its current position.</para>
    /// </summary>
    /// <param name="position">The current position of the handle in the space of Handles.matrix.</param>
    public delegate float SizeFunction(Vector3 position);

    internal enum CameraFilterMode
    {
      Off,
      ShowFiltered,
      ShowRest,
    }

    internal sealed class BoneRenderer
    {
      private List<Matrix4x4> m_BoneMatrices;
      private List<Vector4> m_BoneColors;
      private List<Matrix4x4> m_BoneLeafMatrices;
      private List<Vector4> m_BoneLeafColors;
      private static Mesh s_Mesh;
      private static Material s_Material;
      private const float k_Epsilon = 1E-05f;
      private const float k_BoneScale = 0.08f;
      private const float k_BoneLeafScale = 0.24f;
      private const int k_BoneVertexCount = 4;
      private const int k_BoneLeafDiscResolution = 30;

      public BoneRenderer()
      {
        this.m_BoneMatrices = new List<Matrix4x4>();
        this.m_BoneColors = new List<Vector4>();
        this.m_BoneLeafMatrices = new List<Matrix4x4>();
        this.m_BoneLeafColors = new List<Vector4>();
      }

      public void AddBoneInstance(Vector3 start, Vector3 end, Color color)
      {
        float magnitude = (end - start).magnitude;
        if ((double) magnitude < 9.99999974737875E-06)
          return;
        this.m_BoneMatrices.Add(Handles.BoneRenderer.ComputeBoneMatrix(start, end, magnitude));
        this.m_BoneColors.Add(new Vector4(color.r, color.g, color.b, color.a));
      }

      public void AddBoneLeafInstance(
        Vector3 position,
        Quaternion rotation,
        float radius,
        Color color)
      {
        radius *= 0.24f;
        if ((double) radius < 9.99999974737875E-06)
          return;
        this.m_BoneLeafMatrices.Add(Matrix4x4.TRS(position, rotation, new Vector3(radius, radius, radius)));
        this.m_BoneLeafColors.Add(new Vector4(color.r, color.g, color.b, color.a));
      }

      public void ClearInstances()
      {
        this.m_BoneMatrices.Clear();
        this.m_BoneColors.Clear();
        this.m_BoneLeafMatrices.Clear();
        this.m_BoneLeafColors.Clear();
      }

      public static Material material
      {
        get
        {
          if (!(bool) (UnityEngine.Object) Handles.BoneRenderer.s_Material)
          {
            Handles.BoneRenderer.s_Material = new Material((Shader) EditorGUIUtility.LoadRequired("SceneView/BoneHandles.shader"));
            Handles.BoneRenderer.s_Material.enableInstancing = true;
          }
          return Handles.BoneRenderer.s_Material;
        }
      }

      public static Mesh mesh
      {
        get
        {
          if (!(bool) (UnityEngine.Object) Handles.BoneRenderer.s_Mesh)
          {
            Handles.BoneRenderer.s_Mesh = new Mesh();
            Handles.BoneRenderer.s_Mesh.name = "BoneRendererMesh";
            Handles.BoneRenderer.s_Mesh.subMeshCount = 3;
            Handles.BoneRenderer.s_Mesh.hideFlags = HideFlags.DontSave;
            List<Vector3> vector3List = new List<Vector3>(94);
            vector3List.Add(new Vector3(0.0f, 1f, 0.0f));
            vector3List.Add(new Vector3(0.0f, 0.0f, -1f));
            vector3List.Add(new Vector3(-0.9f, 0.0f, 0.5f));
            vector3List.Add(new Vector3(0.9f, 0.0f, 0.5f));
            Vector3[] dest = new Vector3[30];
            Handles.SetDiscSectionPoints(dest, Vector3.zero, Vector3.up, Vector3.right, 360f, 1f);
            vector3List.AddRange((IEnumerable<Vector3>) dest);
            Handles.SetDiscSectionPoints(dest, Vector3.zero, Vector3.right, Vector3.up, 360f, 1f);
            vector3List.AddRange((IEnumerable<Vector3>) dest);
            Handles.SetDiscSectionPoints(dest, Vector3.zero, Vector3.forward, Vector3.up, 360f, 1f);
            vector3List.AddRange((IEnumerable<Vector3>) dest);
            Handles.BoneRenderer.s_Mesh.vertices = vector3List.ToArray();
            int[] indices1 = new int[12]
            {
              0,
              2,
              1,
              0,
              1,
              3,
              0,
              3,
              2,
              1,
              2,
              3
            };
            Handles.BoneRenderer.s_Mesh.SetIndices(indices1, MeshTopology.Triangles, 0);
            int[] indices2 = new int[12]
            {
              0,
              1,
              0,
              2,
              0,
              3,
              1,
              2,
              2,
              3,
              3,
              1
            };
            Handles.BoneRenderer.s_Mesh.SetIndices(indices2, MeshTopology.Lines, 1);
            int num1 = 0;
            int[] indices3 = new int[(vector3List.Count - 4 - 3) * 2];
            for (int index1 = 5; index1 < vector3List.Count; ++index1)
            {
              if ((index1 - 4) % 30 != 0)
              {
                int[] numArray1 = indices3;
                int index2 = num1;
                int num2 = index2 + 1;
                int num3 = index1 - 1;
                numArray1[index2] = num3;
                int[] numArray2 = indices3;
                int index3 = num2;
                num1 = index3 + 1;
                int num4 = index1;
                numArray2[index3] = num4;
              }
            }
            Handles.BoneRenderer.s_Mesh.SetIndices(indices3, MeshTopology.Lines, 2);
          }
          return Handles.BoneRenderer.s_Mesh;
        }
      }

      public int boneCount => this.m_BoneMatrices.Count;

      public int boneLeafCount => this.m_BoneLeafMatrices.Count;

      private static Matrix4x4 ComputeBoneMatrix(Vector3 start, Vector3 end, float length)
      {
        Vector3 lhs = (end - start) / length;
        Vector3 vector3_1 = Vector3.Cross(lhs, Vector3.up);
        if ((double) Vector3.SqrMagnitude(vector3_1) < 0.100000001490116)
          vector3_1 = Vector3.Cross(lhs, Vector3.right);
        vector3_1.Normalize();
        Vector3 vector3_2 = Vector3.Cross(lhs, vector3_1);
        float num = length * 0.08f;
        return new Matrix4x4(new Vector4(vector3_1.x * num, vector3_1.y * num, vector3_1.z * num, 0.0f), new Vector4(lhs.x * length, lhs.y * length, lhs.z * length, 0.0f), new Vector4(vector3_2.x * num, vector3_2.y * num, vector3_2.z * num, 0.0f), new Vector4(start.x, start.y, start.z, 1f));
      }

      private static int RenderChunkCount(int totalCount) => Mathf.CeilToInt((float) totalCount / (float) Graphics.kMaxDrawMeshInstanceCount);

      private static T[] GetRenderChunk<T>(List<T> array, int chunkIndex)
      {
        int count = chunkIndex < Handles.BoneRenderer.RenderChunkCount(array.Count) - 1 ? Graphics.kMaxDrawMeshInstanceCount : array.Count - chunkIndex * Graphics.kMaxDrawMeshInstanceCount;
        return array.GetRange(chunkIndex * Graphics.kMaxDrawMeshInstanceCount, count).ToArray();
      }

      public static Vector3[] GetBoneWireVertices(Vector3 start, Vector3 end)
      {
        float magnitude = (end - start).magnitude;
        if ((double) magnitude < 9.99999974737875E-06)
          return (Vector3[]) null;
        Matrix4x4 boneMatrix = Handles.BoneRenderer.ComputeBoneMatrix(start, end, magnitude);
        Vector3[] vector3Array1 = new Vector3[4];
        for (int index = 0; index < 4; ++index)
          vector3Array1[index] = boneMatrix.MultiplyPoint3x4(Handles.BoneRenderer.mesh.vertices[index]);
        int[] indices = Handles.BoneRenderer.mesh.GetIndices(1);
        Vector3[] vector3Array2 = new Vector3[indices.Length];
        for (int index = 0; index < indices.Length; ++index)
          vector3Array2[index] = vector3Array1[indices[index]];
        return vector3Array2;
      }

      public void Render()
      {
        if (this.boneCount == 0)
          return;
        Handles.BoneRenderer.material.SetPass(0);
        MaterialPropertyBlock properties = new MaterialPropertyBlock();
        CommandBuffer buffer = new CommandBuffer();
        int num1 = Handles.BoneRenderer.RenderChunkCount(this.boneCount);
        for (int chunkIndex = 0; chunkIndex < num1; ++chunkIndex)
        {
          buffer.Clear();
          Matrix4x4[] renderChunk = Handles.BoneRenderer.GetRenderChunk<Matrix4x4>(this.m_BoneMatrices, chunkIndex);
          properties.SetVectorArray("_Color", Handles.BoneRenderer.GetRenderChunk<Vector4>(this.m_BoneColors, chunkIndex));
          Handles.BoneRenderer.material.DisableKeyword("WIRE_ON");
          buffer.DrawMeshInstanced(Handles.BoneRenderer.mesh, 0, Handles.BoneRenderer.material, 0, renderChunk, renderChunk.Length, properties);
          Graphics.ExecuteCommandBuffer(buffer);
          buffer.Clear();
          Handles.BoneRenderer.material.EnableKeyword("WIRE_ON");
          buffer.DrawMeshInstanced(Handles.BoneRenderer.mesh, 1, Handles.BoneRenderer.material, 0, renderChunk, renderChunk.Length, properties);
          Graphics.ExecuteCommandBuffer(buffer);
        }
        if (this.boneLeafCount == 0)
          return;
        int num2 = Handles.BoneRenderer.RenderChunkCount(this.boneLeafCount);
        buffer.Clear();
        Handles.BoneRenderer.material.EnableKeyword("WIRE_ON");
        for (int chunkIndex = 0; chunkIndex < num2; ++chunkIndex)
        {
          Matrix4x4[] renderChunk = Handles.BoneRenderer.GetRenderChunk<Matrix4x4>(this.m_BoneLeafMatrices, chunkIndex);
          properties.SetVectorArray("_Color", Handles.BoneRenderer.GetRenderChunk<Vector4>(this.m_BoneLeafColors, chunkIndex));
          buffer.DrawMeshInstanced(Handles.BoneRenderer.mesh, 2, Handles.BoneRenderer.material, 0, renderChunk, renderChunk.Length, properties);
        }
        Graphics.ExecuteCommandBuffer(buffer);
      }

      public enum SubMeshType
      {
        BoneFaces,
        BoneWire,
        BoneLeafWire,
        Count,
      }
    }

    [Flags]
    internal enum ConeHandles
    {
      Radius = 1,
      Angle = 2,
      Range = 4,
      All = Range | Angle | Radius, // 0x00000007
    }

    internal struct PositionHandleIds
    {
      public readonly int x;
      public readonly int y;
      public readonly int z;
      public readonly int xy;
      public readonly int yz;
      public readonly int xz;
      public readonly int xyz;

      public static Handles.PositionHandleIds @default => new Handles.PositionHandleIds(GUIUtility.GetControlID(Handles.s_xAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_yAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_zAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_xyAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_xzAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_yzAxisMoveHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_FreeMoveHandleHash, FocusType.Passive));

      public int this[int index]
      {
        get
        {
          switch (index)
          {
            case 0:
              return this.x;
            case 1:
              return this.y;
            case 2:
              return this.z;
            case 3:
              return this.xy;
            case 4:
              return this.yz;
            case 5:
              return this.xz;
            case 6:
              return this.xyz;
            default:
              return -1;
          }
        }
      }

      public bool Has(int id) => this.x == id || this.y == id || (this.z == id || this.xy == id) || (this.yz == id || this.xz == id) || this.xyz == id;

      public PositionHandleIds(int x, int y, int z, int xy, int xz, int yz, int xyz)
      {
        this.x = x;
        this.y = y;
        this.z = z;
        this.xy = xy;
        this.yz = yz;
        this.xz = xz;
        this.xyz = xyz;
      }

      public override int GetHashCode() => this.x ^ this.y ^ this.z ^ this.xy ^ this.xz ^ this.yz ^ this.xyz;

      public override bool Equals(object obj) => obj is Handles.PositionHandleIds positionHandleIds && (positionHandleIds.x == this.x && positionHandleIds.y == this.y && (positionHandleIds.z == this.z && positionHandleIds.xy == this.xy) && (positionHandleIds.xz == this.xz && positionHandleIds.yz == this.yz) && positionHandleIds.xyz == this.xyz);
    }

    internal struct PositionHandleParam
    {
      public static Handles.PositionHandleParam DefaultHandle = new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.Z | Handles.PositionHandleParam.Handle.XY | Handles.PositionHandleParam.Handle.YZ | Handles.PositionHandleParam.Handle.XZ, Vector3.zero, Vector3.one, Vector3.zero, Vector3.one * 0.25f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Camera);
      public static Handles.PositionHandleParam DefaultFreeMoveHandle = new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.Z | Handles.PositionHandleParam.Handle.XYZ, Vector3.zero, Vector3.one, Vector3.zero, Vector3.one * 0.25f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Signed);
      public readonly Vector3 axisOffset;
      public readonly Vector3 axisSize;
      public readonly Vector3 planeOffset;
      public readonly Vector3 planeSize;
      public readonly Handles.PositionHandleParam.Handle handles;
      public readonly Handles.PositionHandleParam.Orientation axesOrientation;
      public readonly Handles.PositionHandleParam.Orientation planeOrientation;

      public bool ShouldShow(int axis) => (uint) (this.handles & (Handles.PositionHandleParam.Handle) (1 << axis)) > 0U;

      public bool ShouldShow(Handles.PositionHandleParam.Handle handle) => (uint) (this.handles & handle) > 0U;

      public PositionHandleParam(
        Handles.PositionHandleParam.Handle handles,
        Vector3 axisOffset,
        Vector3 axisSize,
        Vector3 planeOffset,
        Vector3 planeSize,
        Handles.PositionHandleParam.Orientation axesOrientation,
        Handles.PositionHandleParam.Orientation planeOrientation)
      {
        this.axisOffset = axisOffset;
        this.axisSize = axisSize;
        this.planeOffset = planeOffset;
        this.planeSize = planeSize;
        this.handles = handles;
        this.axesOrientation = axesOrientation;
        this.planeOrientation = planeOrientation;
      }

      [Flags]
      public enum Handle
      {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        XY = 8,
        YZ = 16, // 0x00000010
        XZ = 32, // 0x00000020
        XYZ = 64, // 0x00000040
        All = -1, // 0xFFFFFFFF
      }

      public enum Orientation
      {
        Signed,
        Camera,
      }
    }

    internal struct RotationHandleIds
    {
      public readonly int x;
      public readonly int y;
      public readonly int z;
      public readonly int cameraAxis;
      public readonly int xyz;

      public static Handles.RotationHandleIds @default => new Handles.RotationHandleIds(GUIUtility.GetControlID(Handles.s_xRotateHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_yRotateHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_zRotateHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_cameraAxisRotateHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_xyzRotateHandleHash, FocusType.Passive));

      public int this[int index]
      {
        get
        {
          switch (index)
          {
            case 0:
              return this.x;
            case 1:
              return this.y;
            case 2:
              return this.z;
            case 3:
              return this.cameraAxis;
            case 4:
              return this.xyz;
            default:
              return -1;
          }
        }
      }

      public bool Has(int id) => this.x == id || this.y == id || (this.z == id || this.cameraAxis == id) || this.xyz == id;

      public RotationHandleIds(int x, int y, int z, int cameraAxis, int xyz)
      {
        this.x = x;
        this.y = y;
        this.z = z;
        this.cameraAxis = cameraAxis;
        this.xyz = xyz;
      }

      public override int GetHashCode() => this.x ^ this.y ^ this.z ^ this.cameraAxis ^ this.xyz;

      public override bool Equals(object obj) => obj is Handles.RotationHandleIds rotationHandleIds && (rotationHandleIds.x == this.x && rotationHandleIds.y == this.y && (rotationHandleIds.z == this.z && rotationHandleIds.cameraAxis == this.cameraAxis) && rotationHandleIds.xyz == this.xyz);
    }

    internal struct RotationHandleParam
    {
      private static Handles.RotationHandleParam s_Default = new Handles.RotationHandleParam(Handles.RotationHandleParam.Handle.All, Vector3.one, 1f, 1.1f, true, false);
      public readonly Vector3 axisSize;
      public readonly float cameraAxisSize;
      public readonly float xyzSize;
      public readonly Handles.RotationHandleParam.Handle handles;
      public readonly bool enableRayDrag;
      public readonly bool displayXYZCircle;

      public static Handles.RotationHandleParam Default
      {
        get => Handles.RotationHandleParam.s_Default;
        set => Handles.RotationHandleParam.s_Default = value;
      }

      public bool ShouldShow(int axis) => (uint) (this.handles & (Handles.RotationHandleParam.Handle) (1 << axis)) > 0U;

      public bool ShouldShow(Handles.RotationHandleParam.Handle handle) => (uint) (this.handles & handle) > 0U;

      public RotationHandleParam(
        Handles.RotationHandleParam.Handle handles,
        Vector3 axisSize,
        float xyzSize,
        float cameraAxisSize,
        bool enableRayDrag,
        bool displayXYZCircle)
      {
        this.axisSize = axisSize;
        this.xyzSize = xyzSize;
        this.handles = handles;
        this.cameraAxisSize = cameraAxisSize;
        this.enableRayDrag = enableRayDrag;
        this.displayXYZCircle = displayXYZCircle;
      }

      [Flags]
      public enum Handle
      {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        CameraAxis = 8,
        XYZ = 16, // 0x00000010
        All = -1, // 0xFFFFFFFF
      }
    }

    internal struct ScaleHandleIds
    {
      public readonly int x;
      public readonly int y;
      public readonly int z;
      public readonly int xyz;

      public static Handles.ScaleHandleIds @default => new Handles.ScaleHandleIds(GUIUtility.GetControlID(Handles.s_xScaleHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_yScaleHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_zScaleHandleHash, FocusType.Passive), GUIUtility.GetControlID(Handles.s_xyzScaleHandleHash, FocusType.Passive));

      public int this[int index]
      {
        get
        {
          switch (index)
          {
            case 0:
              return this.x;
            case 1:
              return this.y;
            case 2:
              return this.z;
            case 3:
              return this.xyz;
            default:
              return -1;
          }
        }
      }

      public bool Has(int id) => this.x == id || this.y == id || this.z == id || this.xyz == id;

      public ScaleHandleIds(int x, int y, int z, int xyz)
      {
        this.x = x;
        this.y = y;
        this.z = z;
        this.xyz = xyz;
      }

      public override int GetHashCode() => this.x ^ this.y ^ this.z ^ this.xyz;

      public override bool Equals(object obj) => obj is Handles.ScaleHandleIds scaleHandleIds && (scaleHandleIds.x == this.x && scaleHandleIds.y == this.y && scaleHandleIds.z == this.z && scaleHandleIds.xyz == this.xyz);
    }

    internal struct ScaleHandleParam
    {
      private static Handles.ScaleHandleParam s_Default = new Handles.ScaleHandleParam(Handles.ScaleHandleParam.Handle.All, Vector3.zero, Vector3.one, Vector3.one, 1f, Handles.ScaleHandleParam.Orientation.Signed);
      public readonly Vector3 axisOffset;
      public readonly Vector3 axisSize;
      public readonly Vector3 axisLineScale;
      public readonly float xyzSize;
      public readonly Handles.ScaleHandleParam.Handle handles;
      public readonly Handles.ScaleHandleParam.Orientation orientation;

      public static Handles.ScaleHandleParam Default
      {
        get => Handles.ScaleHandleParam.s_Default;
        set => Handles.ScaleHandleParam.s_Default = value;
      }

      public bool ShouldShow(int axis) => (uint) (this.handles & (Handles.ScaleHandleParam.Handle) (1 << axis)) > 0U;

      public bool ShouldShow(Handles.ScaleHandleParam.Handle handle) => (uint) (this.handles & handle) > 0U;

      public ScaleHandleParam(
        Handles.ScaleHandleParam.Handle handles,
        Vector3 axisOffset,
        Vector3 axisSize,
        Vector3 axisLineScale,
        float xyzSize,
        Handles.ScaleHandleParam.Orientation orientation)
      {
        this.axisOffset = axisOffset;
        this.axisSize = axisSize;
        this.axisLineScale = axisLineScale;
        this.xyzSize = xyzSize;
        this.handles = handles;
        this.orientation = orientation;
      }

      [Flags]
      public enum Handle
      {
        None = 0,
        X = 1,
        Y = 2,
        Z = 4,
        XYZ = 8,
        All = -1, // 0xFFFFFFFF
      }

      public enum Orientation
      {
        Signed,
        Camera,
      }
    }

    internal struct TransformHandleIds
    {
      private static readonly int s_TransformTranslationXHash = "TransformTranslationXHash".GetHashCode();
      private static readonly int s_TransformTranslationYHash = "TransformTranslationYHash".GetHashCode();
      private static readonly int s_TransformTranslationZHash = "TransformTranslationZHash".GetHashCode();
      private static readonly int s_TransformTranslationXYHash = "TransformTranslationXYHash".GetHashCode();
      private static readonly int s_TransformTranslationXZHash = "TransformTranslationXZHash".GetHashCode();
      private static readonly int s_TransformTranslationYZHash = "TransformTranslationYZHash".GetHashCode();
      private static readonly int s_TransformTranslationXYZHash = "TransformTranslationXYZHash".GetHashCode();
      private static readonly int s_TransformRotationXHash = "TransformRotationXHash".GetHashCode();
      private static readonly int s_TransformRotationYHash = "TransformRotationYHash".GetHashCode();
      private static readonly int s_TransformRotationZHash = "TransformRotationZHash".GetHashCode();
      private static readonly int s_TransformRotationCameraAxisHash = "TransformRotationCameraAxisHash".GetHashCode();
      private static readonly int s_TransformRotationXYZHash = "TransformRotationXYZHash".GetHashCode();
      private static readonly int s_TransformScaleXHash = "TransformScaleXHash".GetHashCode();
      private static readonly int s_TransformScaleYHash = "TransformScaleYHash".GetHashCode();
      private static readonly int s_TransformScaleZHash = "TransformScaleZHash".GetHashCode();
      private static readonly int s_TransformScaleXYZHash = "TransformScaleXYZHash".GetHashCode();
      public readonly Handles.PositionHandleIds position;
      public readonly Handles.RotationHandleIds rotation;
      public readonly Handles.ScaleHandleIds scale;

      public static Handles.TransformHandleIds Default => new Handles.TransformHandleIds(new Handles.PositionHandleIds(GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationXHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationYHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationZHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationXYHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationXZHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationYZHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformTranslationXYZHash, FocusType.Passive)), new Handles.RotationHandleIds(GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformRotationXHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformRotationYHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformRotationZHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformRotationCameraAxisHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformRotationXYZHash, FocusType.Passive)), new Handles.ScaleHandleIds(GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformScaleXHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformScaleYHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformScaleZHash, FocusType.Passive), GUIUtility.GetControlID(Handles.TransformHandleIds.s_TransformScaleXYZHash, FocusType.Passive)));

      public bool Has(int id) => this.position.Has(id) || this.rotation.Has(id) || this.scale.Has(id);

      public TransformHandleIds(
        Handles.PositionHandleIds position,
        Handles.RotationHandleIds rotation,
        Handles.ScaleHandleIds scale)
      {
        this.position = position;
        this.rotation = rotation;
        this.scale = scale;
      }
    }

    internal struct TransformHandleParam
    {
      private static Handles.TransformHandleParam s_Default = new Handles.TransformHandleParam(new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.Z | Handles.PositionHandleParam.Handle.XY | Handles.PositionHandleParam.Handle.YZ | Handles.PositionHandleParam.Handle.XZ, Vector3.one * 0.15f, Vector3.one, Vector3.zero, Vector3.one * 0.375f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Camera), new Handles.RotationHandleParam(Handles.RotationHandleParam.Handle.X | Handles.RotationHandleParam.Handle.Y | Handles.RotationHandleParam.Handle.Z | Handles.RotationHandleParam.Handle.CameraAxis | Handles.RotationHandleParam.Handle.XYZ, Vector3.one * 1.4f, 1.4f, 1.5f, false, false), new Handles.ScaleHandleParam(Handles.ScaleHandleParam.Handle.XYZ, Vector3.zero, Vector3.one, Vector3.one, 1f, Handles.ScaleHandleParam.Orientation.Signed), new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.XY, Vector3.one * 0.15f, Vector3.one, Vector3.zero, Vector3.one * 0.375f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Signed), new Handles.RotationHandleParam(Handles.RotationHandleParam.Handle.Z | Handles.RotationHandleParam.Handle.XYZ, Vector3.one * 1.4f, 1.4f, 1.5f, false, false), new Handles.ScaleHandleParam(Handles.ScaleHandleParam.Handle.XYZ, Vector3.zero, Vector3.one, Vector3.one, 1f, Handles.ScaleHandleParam.Orientation.Signed), new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.Z | Handles.PositionHandleParam.Handle.XY | Handles.PositionHandleParam.Handle.YZ | Handles.PositionHandleParam.Handle.XZ, Vector3.one * 0.15f, Vector3.one, Vector3.zero, Vector3.one * 0.375f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Camera), new Handles.RotationHandleParam(Handles.RotationHandleParam.Handle.X | Handles.RotationHandleParam.Handle.Y | Handles.RotationHandleParam.Handle.Z | Handles.RotationHandleParam.Handle.CameraAxis | Handles.RotationHandleParam.Handle.XYZ, Vector3.one * 1.4f, 1.4f, 1.5f, false, false), new Handles.ScaleHandleParam(Handles.ScaleHandleParam.Handle.X | Handles.ScaleHandleParam.Handle.Y | Handles.ScaleHandleParam.Handle.Z | Handles.ScaleHandleParam.Handle.XYZ, Vector3.one * 1.5f, Vector3.one, Vector3.one * 0.25f, 1f, Handles.ScaleHandleParam.Orientation.Signed), new Handles.PositionHandleParam(Handles.PositionHandleParam.Handle.X | Handles.PositionHandleParam.Handle.Y | Handles.PositionHandleParam.Handle.Z | Handles.PositionHandleParam.Handle.XYZ, Vector3.one * 0.15f, Vector3.one, Vector3.zero, Vector3.one * 0.375f, Handles.PositionHandleParam.Orientation.Signed, Handles.PositionHandleParam.Orientation.Signed), new Handles.RotationHandleParam(Handles.RotationHandleParam.Handle.None, Vector3.one * 1.4f, 1.4f, 1.5f, false, false), new Handles.ScaleHandleParam(Handles.ScaleHandleParam.Handle.None, Vector3.one * 1.5f, Vector3.one, Vector3.one * 0.25f, 1f, Handles.ScaleHandleParam.Orientation.Signed));
      public readonly Handles.PositionHandleParam position;
      public readonly Handles.RotationHandleParam rotation;
      public readonly Handles.ScaleHandleParam scale;
      public readonly Handles.PositionHandleParam cameraAlignedPosition;
      public readonly Handles.RotationHandleParam cameraAlignedRotation;
      public readonly Handles.ScaleHandleParam cameraAlignedScale;
      public readonly Handles.PositionHandleParam localPosition;
      public readonly Handles.RotationHandleParam localRotation;
      public readonly Handles.ScaleHandleParam localScale;
      public readonly Handles.PositionHandleParam vertexSnappingPosition;
      public readonly Handles.RotationHandleParam vertexSnappingRotation;
      public readonly Handles.ScaleHandleParam vertexSnappingScale;

      public static Handles.TransformHandleParam Default
      {
        get => Handles.TransformHandleParam.s_Default;
        set => Handles.TransformHandleParam.s_Default = value;
      }

      public TransformHandleParam(
        Handles.PositionHandleParam position,
        Handles.RotationHandleParam rotation,
        Handles.ScaleHandleParam scale,
        Handles.PositionHandleParam cameraAlignedPosition,
        Handles.RotationHandleParam cameraAlignedRotation,
        Handles.ScaleHandleParam cameraAlignedScale,
        Handles.PositionHandleParam localPosition,
        Handles.RotationHandleParam localRotation,
        Handles.ScaleHandleParam localScale,
        Handles.PositionHandleParam vertexSnappingPosition,
        Handles.RotationHandleParam vertexSnappingRotation,
        Handles.ScaleHandleParam vertexSnappingScale)
      {
        this.position = position;
        this.rotation = rotation;
        this.scale = scale;
        this.cameraAlignedPosition = cameraAlignedPosition;
        this.cameraAlignedRotation = cameraAlignedRotation;
        this.cameraAlignedScale = cameraAlignedScale;
        this.localPosition = localPosition;
        this.localRotation = localRotation;
        this.localScale = localScale;
        this.vertexSnappingPosition = vertexSnappingPosition;
        this.vertexSnappingRotation = vertexSnappingRotation;
        this.vertexSnappingScale = vertexSnappingScale;
      }

      public Handles.TransformHandleParam Without(Handles.PositionHandleParam.Handle handles) => new Handles.TransformHandleParam(Handles.TransformHandleParam.RemoveHandles(this.position, handles), this.rotation, this.scale, Handles.TransformHandleParam.RemoveHandles(this.cameraAlignedPosition, handles), this.cameraAlignedRotation, this.cameraAlignedScale, Handles.TransformHandleParam.RemoveHandles(this.localPosition, handles), this.localRotation, this.localScale, Handles.TransformHandleParam.RemoveHandles(this.vertexSnappingPosition, handles), this.vertexSnappingRotation, this.vertexSnappingScale);

      private static Handles.PositionHandleParam RemoveHandles(
        Handles.PositionHandleParam p,
        Handles.PositionHandleParam.Handle handles)
      {
        return new Handles.PositionHandleParam(p.handles & ~handles, p.axisOffset, p.axisSize, p.planeOffset, p.planeSize, p.axesOrientation, p.planeOrientation);
      }

      public Handles.TransformHandleParam Without(Handles.RotationHandleParam.Handle handles) => new Handles.TransformHandleParam(this.position, Handles.TransformHandleParam.RemoveHandles(this.rotation, handles), this.scale, this.cameraAlignedPosition, Handles.TransformHandleParam.RemoveHandles(this.cameraAlignedRotation, handles), this.cameraAlignedScale, this.localPosition, Handles.TransformHandleParam.RemoveHandles(this.localRotation, handles), this.localScale, this.vertexSnappingPosition, Handles.TransformHandleParam.RemoveHandles(this.vertexSnappingRotation, handles), this.vertexSnappingScale);

      private static Handles.RotationHandleParam RemoveHandles(
        Handles.RotationHandleParam r,
        Handles.RotationHandleParam.Handle handles)
      {
        return new Handles.RotationHandleParam(r.handles & ~handles, r.axisSize, r.xyzSize, r.cameraAxisSize, r.enableRayDrag, r.displayXYZCircle);
      }

      public Handles.TransformHandleParam Without(Handles.ScaleHandleParam.Handle handles) => new Handles.TransformHandleParam(this.position, this.rotation, Handles.TransformHandleParam.RemoveHandles(this.scale, handles), this.cameraAlignedPosition, this.cameraAlignedRotation, Handles.TransformHandleParam.RemoveHandles(this.cameraAlignedScale, handles), this.localPosition, this.localRotation, Handles.TransformHandleParam.RemoveHandles(this.localScale, handles), this.vertexSnappingPosition, this.vertexSnappingRotation, Handles.TransformHandleParam.RemoveHandles(this.vertexSnappingScale, handles));

      private static Handles.ScaleHandleParam RemoveHandles(
        Handles.ScaleHandleParam s,
        Handles.ScaleHandleParam.Handle handles)
      {
        return new Handles.ScaleHandleParam(s.handles & ~handles, s.axisOffset, s.axisSize, s.axisLineScale, s.xyzSize, s.orientation);
      }

      public Handles.TransformHandleParam WithSoloPositionManipulatorSize() => new Handles.TransformHandleParam(Handles.TransformHandleParam.CopyDefaultSize(this.position), this.rotation, this.scale, Handles.TransformHandleParam.CopyDefaultSize(this.cameraAlignedPosition), this.cameraAlignedRotation, this.cameraAlignedScale, Handles.TransformHandleParam.CopyDefaultSize(this.localPosition), this.localRotation, this.localScale, Handles.TransformHandleParam.CopyDefaultSize(this.vertexSnappingPosition), this.vertexSnappingRotation, this.vertexSnappingScale);

      private static Handles.PositionHandleParam CopyDefaultSize(
        Handles.PositionHandleParam p)
      {
        Handles.PositionHandleParam defaultHandle = Handles.PositionHandleParam.DefaultHandle;
        return new Handles.PositionHandleParam(p.handles, defaultHandle.axisOffset, defaultHandle.axisSize, defaultHandle.planeOffset, defaultHandle.planeSize, p.axesOrientation, p.planeOrientation);
      }

      public Handles.TransformHandleParam WithSoloRotationManipulatorSize() => new Handles.TransformHandleParam(this.position, Handles.TransformHandleParam.CopyDefaultSize(this.rotation), this.scale, this.cameraAlignedPosition, Handles.TransformHandleParam.CopyDefaultSize(this.cameraAlignedRotation), this.cameraAlignedScale, this.localPosition, Handles.TransformHandleParam.CopyDefaultSize(this.localRotation), this.localScale, this.vertexSnappingPosition, Handles.TransformHandleParam.CopyDefaultSize(this.vertexSnappingRotation), this.vertexSnappingScale);

      private static Handles.RotationHandleParam CopyDefaultSize(
        Handles.RotationHandleParam r)
      {
        Handles.RotationHandleParam rotationHandleParam = Handles.RotationHandleParam.Default;
        return new Handles.RotationHandleParam(r.handles, rotationHandleParam.axisSize, rotationHandleParam.xyzSize, rotationHandleParam.cameraAxisSize, r.enableRayDrag, r.displayXYZCircle);
      }

      public Handles.TransformHandleParam WithSoloScaleManipulatorSize() => new Handles.TransformHandleParam(this.position, this.rotation, Handles.TransformHandleParam.CopyDefaultSize(this.scale), this.cameraAlignedPosition, this.cameraAlignedRotation, Handles.TransformHandleParam.CopyDefaultSize(this.cameraAlignedScale), this.localPosition, this.localRotation, Handles.TransformHandleParam.CopyDefaultSize(this.localScale), this.vertexSnappingPosition, this.vertexSnappingRotation, Handles.TransformHandleParam.CopyDefaultSize(this.vertexSnappingScale));

      private static Handles.ScaleHandleParam CopyDefaultSize(Handles.ScaleHandleParam s)
      {
        Handles.ScaleHandleParam scaleHandleParam = Handles.ScaleHandleParam.Default;
        return new Handles.ScaleHandleParam(s.handles, scaleHandleParam.axisOffset, scaleHandleParam.axisSize, scaleHandleParam.axisLineScale, s.xyzSize, s.orientation);
      }
    }

    private struct RotationHandleData
    {
      public bool rotationStarted;
      public Quaternion initialRotation;
    }
  }
}
