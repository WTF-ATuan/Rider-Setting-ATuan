// Decompiled with JetBrains decompiler
// Type: UnityEditor.Editor
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D90B285-60B6-44CE-87B8-263EFCC36EED
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEditor.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEditor.Experimental.AssetImporters;
using UnityEditor.Localization.Editor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

namespace UnityEditor
{
  /// <summary>
  ///   <para>Derive from this base class to create a custom inspector or editor for your custom object.</para>
  /// </summary>
  [NativeHeader("Editor/Mono/Inspector/ScriptBindings/Editor.bindings.h")]
  [RequiredByNativeCode]
  [ExcludeFromObjectFactory]
  [StaticAccessor("EditorBindings", StaticAccessorType.DoubleColon)]
  [StructLayout(LayoutKind.Sequential)]
  public class Editor : ScriptableObject, IPreviewable, IToolModeOwner
  {
    private UnityEngine.Object[] m_Targets;
    internal UnityEngine.Object m_Context;
    private int m_IsDirty;
    private int m_ReferenceTargetIndex = 0;
    private PropertyHandlerCache m_PropertyHandlerCache = new PropertyHandlerCache();
    private IPreviewable m_DummyPreview;
    private AudioFilterGUI m_AudioFilterGUI;
    internal SerializedObject m_SerializedObject = (SerializedObject) null;
    internal SerializedProperty m_EnabledProperty = (SerializedProperty) null;
    private InspectorMode m_InspectorMode = InspectorMode.Normal;
    internal static float kLineHeight = 18f;
    internal bool hideInspector = false;
    private const float kImageSectionWidth = 44f;
    internal const float k_WideModeMinWidth = 330f;
    internal const float k_HeaderHeight = 21f;
    internal static UnityEditor.Editor.OnEditorGUIDelegate OnPostIconGUI = (UnityEditor.Editor.OnEditorGUIDelegate) null;
    internal static bool m_AllowMultiObjectAccess = true;

    internal InspectorMode inspectorMode
    {
      get => this.m_InspectorMode;
      set
      {
        if (this.m_InspectorMode == value)
          return;
        this.m_InspectorMode = value;
        this.m_SerializedObject = (SerializedObject) null;
        this.m_EnabledProperty = (SerializedProperty) null;
      }
    }

    internal bool firstInspectedEditor { get; set; }

    internal virtual bool HasLargeHeader() => AssetDatabase.IsMainAsset(this.target) || AssetDatabase.IsSubAsset(this.target);

    internal bool canEditMultipleObjects => (uint) this.GetType().GetCustomAttributes(typeof (CanEditMultipleObjects), false).Length > 0U;

    internal virtual IPreviewable preview
    {
      get
      {
        if (this.m_DummyPreview == null)
        {
          this.m_DummyPreview = (IPreviewable) new ObjectPreview();
          this.m_DummyPreview.Initialize(this.targets);
        }
        return this.m_DummyPreview;
      }
    }

    internal PropertyHandlerCache propertyHandlerCache => this.m_PropertyHandlerCache;

    bool IToolModeOwner.areToolModesAvailable => !EditorUtility.IsPersistent(this.target);

    /// <summary>
    ///   <para>The object being inspected.</para>
    /// </summary>
    public UnityEngine.Object target
    {
      get => this.m_Targets[this.referenceTargetIndex];
      set => throw new InvalidOperationException("You can't set the target on an editor.");
    }

    /// <summary>
    ///   <para>An array of all the object being inspected.</para>
    /// </summary>
    public UnityEngine.Object[] targets
    {
      get
      {
        if (!UnityEditor.Editor.m_AllowMultiObjectAccess)
          Debug.LogError((object) "The targets array should not be used inside OnSceneGUI or OnPreviewGUI. Use the single target property instead.");
        return this.m_Targets;
      }
    }

    internal virtual int referenceTargetIndex
    {
      get => Mathf.Clamp(this.m_ReferenceTargetIndex, 0, this.m_Targets.Length - 1);
      set => this.m_ReferenceTargetIndex = (Math.Abs(value * this.m_Targets.Length) + value) % this.m_Targets.Length;
    }

    internal virtual string targetTitle
    {
      get
      {
        if (this.m_Targets.Length == 1 || !UnityEditor.Editor.m_AllowMultiObjectAccess)
          return this.target.name;
        return this.m_Targets.Length.ToString() + " " + ObjectNames.NicifyVariableName(ObjectNames.GetTypeName(this.target)) + "s";
      }
    }

    /// <summary>
    ///   <para>A SerializedObject representing the object or objects being inspected.</para>
    /// </summary>
    public SerializedObject serializedObject
    {
      get
      {
        if (!UnityEditor.Editor.m_AllowMultiObjectAccess)
          Debug.LogError((object) "The serializedObject should not be used inside OnSceneGUI or OnPreviewGUI. Use the target property directly instead.");
        return this.GetSerializedObjectInternal();
      }
    }

    internal SerializedProperty enabledProperty
    {
      get
      {
        this.GetSerializedObjectInternal();
        return this.m_EnabledProperty;
      }
    }

    internal bool isInspectorDirty
    {
      get => (uint) this.m_IsDirty > 0U;
      set => this.m_IsDirty = value ? 1 : 0;
    }

    /// <summary>
    ///   <para>Make a custom editor for targetObject or targetObjects with a context object.</para>
    /// </summary>
    /// <param name="targetObjects"></param>
    /// <param name="context"></param>
    /// <param name="editorType"></param>
    public static UnityEditor.Editor CreateEditorWithContext(
      UnityEngine.Object[] targetObjects,
      UnityEngine.Object context,
      [DefaultValue("null")] System.Type editorType)
    {
      if (editorType != null && !editorType.IsSubclassOf(typeof (UnityEditor.Editor)))
        throw new ArgumentException(string.Format("Editor type '{0}' does not derive from UnityEditor.Editor", (object) editorType), nameof (editorType));
      return UnityEditor.Editor.CreateEditorWithContextInternal(targetObjects, context, editorType);
    }

    [ExcludeFromDocs]
    public static UnityEditor.Editor CreateEditorWithContext(
      UnityEngine.Object[] targetObjects,
      UnityEngine.Object context)
    {
      System.Type editorType = (System.Type) null;
      return UnityEditor.Editor.CreateEditorWithContext(targetObjects, context, editorType);
    }

    public static void CreateCachedEditorWithContext(
      UnityEngine.Object targetObject,
      UnityEngine.Object context,
      System.Type editorType,
      ref UnityEditor.Editor previousEditor)
    {
      UnityEditor.Editor.CreateCachedEditorWithContext(new UnityEngine.Object[1]
      {
        targetObject
      }, context, editorType, ref previousEditor);
    }

    public static void CreateCachedEditorWithContext(
      UnityEngine.Object[] targetObjects,
      UnityEngine.Object context,
      System.Type editorType,
      ref UnityEditor.Editor previousEditor)
    {
      if ((UnityEngine.Object) previousEditor != (UnityEngine.Object) null && ArrayUtility.ArrayEquals<UnityEngine.Object>(previousEditor.m_Targets, targetObjects) && previousEditor.m_Context == context)
        return;
      if ((UnityEngine.Object) previousEditor != (UnityEngine.Object) null)
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) previousEditor);
      previousEditor = UnityEditor.Editor.CreateEditorWithContext(targetObjects, context, editorType);
    }

    public static void CreateCachedEditor(
      UnityEngine.Object targetObject,
      System.Type editorType,
      ref UnityEditor.Editor previousEditor)
    {
      UnityEditor.Editor.CreateCachedEditorWithContext(new UnityEngine.Object[1]
      {
        targetObject
      }, (UnityEngine.Object) null, editorType, ref previousEditor);
    }

    public static void CreateCachedEditor(
      UnityEngine.Object[] targetObjects,
      System.Type editorType,
      ref UnityEditor.Editor previousEditor)
    {
      UnityEditor.Editor.CreateCachedEditorWithContext(targetObjects, (UnityEngine.Object) null, editorType, ref previousEditor);
    }

    /// <summary>
    ///   <para>Make a custom editor for targetObject or targetObjects.</para>
    /// </summary>
    /// <param name="objects">All objects must be of the same type.</param>
    /// <param name="targetObject"></param>
    /// <param name="editorType"></param>
    /// <param name="targetObjects"></param>
    [ExcludeFromDocs]
    public static UnityEditor.Editor CreateEditor(UnityEngine.Object targetObject)
    {
      System.Type editorType = (System.Type) null;
      return UnityEditor.Editor.CreateEditor(targetObject, editorType);
    }

    /// <summary>
    ///   <para>Make a custom editor for targetObject or targetObjects.</para>
    /// </summary>
    /// <param name="objects">All objects must be of the same type.</param>
    /// <param name="targetObject"></param>
    /// <param name="editorType"></param>
    /// <param name="targetObjects"></param>
    public static UnityEditor.Editor CreateEditor(UnityEngine.Object targetObject, [DefaultValue("null")] System.Type editorType) => UnityEditor.Editor.CreateEditorWithContext(new UnityEngine.Object[1]
    {
      targetObject
    }, (UnityEngine.Object) null, editorType);

    /// <summary>
    ///   <para>Make a custom editor for targetObject or targetObjects.</para>
    /// </summary>
    /// <param name="objects">All objects must be of the same type.</param>
    /// <param name="targetObject"></param>
    /// <param name="editorType"></param>
    /// <param name="targetObjects"></param>
    [ExcludeFromDocs]
    public static UnityEditor.Editor CreateEditor(UnityEngine.Object[] targetObjects)
    {
      System.Type editorType = (System.Type) null;
      return UnityEditor.Editor.CreateEditor(targetObjects, editorType);
    }

    /// <summary>
    ///   <para>Make a custom editor for targetObject or targetObjects.</para>
    /// </summary>
    /// <param name="objects">All objects must be of the same type.</param>
    /// <param name="targetObject"></param>
    /// <param name="editorType"></param>
    /// <param name="targetObjects"></param>
    public static UnityEditor.Editor CreateEditor(UnityEngine.Object[] targetObjects, [DefaultValue("null")] System.Type editorType) => UnityEditor.Editor.CreateEditorWithContext(targetObjects, (UnityEngine.Object) null, editorType);

    internal void CleanupPropertyEditor()
    {
      if (this.m_SerializedObject == null)
        return;
      this.m_SerializedObject.Dispose();
      this.m_SerializedObject = (SerializedObject) null;
    }

    private void OnDisableINTERNAL() => this.CleanupPropertyEditor();

    internal virtual SerializedObject GetSerializedObjectInternal()
    {
      if (this.m_SerializedObject == null)
        this.CreateSerializedObject();
      return this.m_SerializedObject;
    }

    private void CreateSerializedObject()
    {
      try
      {
        this.m_SerializedObject = new SerializedObject(this.targets, this.m_Context);
        this.m_SerializedObject.inspectorMode = this.inspectorMode;
        UnityEditor.Editor.AssignCachedProperties<UnityEditor.Editor>(this, this.m_SerializedObject.GetIterator());
        this.m_EnabledProperty = this.m_SerializedObject.FindProperty("m_Enabled");
      }
      catch (ArgumentException ex)
      {
        this.m_SerializedObject = (SerializedObject) null;
        this.m_EnabledProperty = (SerializedProperty) null;
        throw new UnityEditor.Editor.SerializedObjectNotCreatableException(ex.Message);
      }
    }

    internal static void AssignCachedProperties<T>(T self, SerializedProperty root) where T : class
    {
      List<System.Reflection.FieldInfo> autoLoadProperties = ScriptAttributeUtility.GetAutoLoadProperties(typeof (T));
      if (autoLoadProperties.Count == 0)
        return;
      Dictionary<string, System.Reflection.FieldInfo> dictionary = new Dictionary<string, System.Reflection.FieldInfo>(autoLoadProperties.Count);
      HashSet<string> stringSet = new HashSet<string>();
      foreach (System.Reflection.FieldInfo fieldInfo in autoLoadProperties)
      {
        CachePropertyAttribute propertyAttribute = (CachePropertyAttribute) ((IEnumerable<object>) fieldInfo.GetCustomAttributes(typeof (CachePropertyAttribute), false)).First<object>();
        string key = string.IsNullOrEmpty(propertyAttribute.propertyPath) ? fieldInfo.Name : propertyAttribute.propertyPath;
        dictionary.Add(key, fieldInfo);
        for (int length = key.LastIndexOf('.'); length != -1; length = key.LastIndexOf('.'))
        {
          key = key.Substring(0, length);
          if (!stringSet.Add(key))
            break;
        }
      }
      string propertyPath = root.propertyPath;
      int startIndex = propertyPath.Length > 0 ? propertyPath.Length + 1 : 0;
      int count = dictionary.Count;
      SerializedProperty serializedProperty = root.Copy();
      string key1;
      for (bool enterChildren = true; serializedProperty.Next(enterChildren) && count > 0; enterChildren = stringSet.Contains(key1))
      {
        key1 = serializedProperty.propertyPath.Substring(startIndex);
        System.Reflection.FieldInfo fieldInfo;
        if (dictionary.TryGetValue(key1, out fieldInfo))
        {
          fieldInfo.SetValue((object) self, (object) serializedProperty.Copy());
          dictionary.Remove(key1);
          --count;
        }
      }
      serializedProperty.Dispose();
      if (count <= 0)
        return;
      Debug.LogWarning((object) ("The following properties registered with CacheProperty where not found during the inspector creation: " + string.Join(", ", dictionary.Keys.ToArray<string>())));
    }

    internal virtual void InternalSetTargets(UnityEngine.Object[] t) => this.m_Targets = t;

    internal void InternalSetHidden(bool hidden) => this.hideInspector = hidden;

    internal void InternalSetContextObject(UnityEngine.Object context) => this.m_Context = context;

    Bounds IToolModeOwner.GetWorldBoundsOfTargets()
    {
      Bounds bounds = new Bounds();
      bool flag = false;
      foreach (UnityEngine.Object target in this.targets)
      {
        if (!(target == (UnityEngine.Object) null))
        {
          Bounds worldBoundsOfTarget = this.GetWorldBoundsOfTarget(target);
          if (!flag)
            bounds = worldBoundsOfTarget;
          bounds.Encapsulate(worldBoundsOfTarget);
          flag = true;
        }
      }
      return bounds;
    }

    internal virtual Bounds GetWorldBoundsOfTarget(UnityEngine.Object targetObject) => targetObject is Component ? ((Component) targetObject).gameObject.CalculateBounds() : new Bounds();

    bool IToolModeOwner.ModeSurvivesSelectionChange(int toolMode) => false;

    internal virtual void OnForceReloadInspector()
    {
      if (this.m_SerializedObject == null)
        return;
      this.m_SerializedObject.SetIsDifferentCacheDirty();
      this.InternalSetTargets(this.m_SerializedObject.targetObjects);
    }

    internal virtual bool GetOptimizedGUIBlock(bool isDirty, bool isVisible, out float height)
    {
      height = -1f;
      return false;
    }

    internal virtual bool OnOptimizedInspectorGUI(Rect contentRect)
    {
      Debug.LogError((object) "Not supported");
      return false;
    }

    protected internal static void DrawPropertiesExcluding(
      SerializedObject obj,
      params string[] propertyToExclude)
    {
      SerializedProperty iterator = obj.GetIterator();
      bool enterChildren = true;
      while (iterator.NextVisible(enterChildren))
      {
        enterChildren = false;
        if (!((IEnumerable<string>) propertyToExclude).Contains<string>(iterator.name))
          EditorGUILayout.PropertyField(iterator, true);
      }
    }

    /// <summary>
    ///   <para>Draws the built-in inspector.</para>
    /// </summary>
    public bool DrawDefaultInspector() => this.DoDrawDefaultInspector();

    internal static bool DoDrawDefaultInspector(SerializedObject obj)
    {
      EditorGUI.BeginChangeCheck();
      obj.UpdateIfRequiredOrScript();
      SerializedProperty iterator = obj.GetIterator();
      for (bool enterChildren = true; iterator.NextVisible(enterChildren); enterChildren = false)
      {
        using (new EditorGUI.DisabledScope("m_Script" == iterator.propertyPath))
          EditorGUILayout.PropertyField(iterator, true);
      }
      obj.ApplyModifiedProperties();
      return EditorGUI.EndChangeCheck();
    }

    internal bool DoDrawDefaultInspector()
    {
      bool flag;
      using (new LocalizationGroup((object) this.target))
      {
        flag = UnityEditor.Editor.DoDrawDefaultInspector(this.serializedObject);
        MonoBehaviour target = this.target as MonoBehaviour;
        if ((UnityEngine.Object) target == (UnityEngine.Object) null || !AudioUtil.HasAudioCallback(target) || AudioUtil.GetCustomFilterChannelCount(target) <= 0)
          return flag;
        if (this.m_AudioFilterGUI == null)
          this.m_AudioFilterGUI = new AudioFilterGUI();
        this.m_AudioFilterGUI.DrawAudioFilterGUI(target);
      }
      return flag;
    }

    /// <summary>
    ///   <para>Redraw any inspectors that shows this editor.</para>
    /// </summary>
    public void Repaint() => InspectorWindow.RepaintAllInspectors();

    /// <summary>
    ///   <para>Implement this function to make a custom inspector.</para>
    /// </summary>
    public virtual void OnInspectorGUI() => this.DrawDefaultInspector();

    /// <summary>
    ///   <para>Implement this method to make a custom UIElements inspector.</para>
    /// </summary>
    public virtual VisualElement CreateInspectorGUI() => (VisualElement) null;

    /// <summary>
    ///   <para>Checks if this editor requires constant repaints in its current state.</para>
    /// </summary>
    public virtual bool RequiresConstantRepaint() => false;

    public static event Action<UnityEditor.Editor> finishedDefaultHeaderGUI = null;

    /// <summary>
    ///   <para>Call this function to draw the header of the editor.</para>
    /// </summary>
    public void DrawHeader()
    {
      bool hierarchyMode = EditorGUIUtility.hierarchyMode;
      if (hierarchyMode)
        this.DrawHeaderFromInsideHierarchy();
      else
        this.OnHeaderGUI();
      if (UnityEditor.Editor.finishedDefaultHeaderGUI == null)
        return;
      if (hierarchyMode)
      {
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical(GUILayoutUtility.topLevel.style);
      }
      EditorGUIUtility.labelWidth = 0.0f;
      EditorGUIUtility.fieldWidth = 0.0f;
      GUILayout.Space(-1f - (float) UnityEditor.Editor.BaseStyles.inspectorBig.margin.bottom - (float) UnityEditor.Editor.BaseStyles.inspectorBig.padding.bottom - (float) UnityEditor.Editor.BaseStyles.inspectorBig.overflow.bottom);
      EditorGUIUtility.hierarchyMode = true;
      EditorGUIUtility.wideMode = (double) EditorGUIUtility.contextWidth > 330.0;
      EditorGUILayout.BeginVertical(UnityEditor.Editor.BaseStyles.postLargeHeaderBackground, GUILayout.ExpandWidth(true));
      UnityEditor.Editor.finishedDefaultHeaderGUI(this);
      EditorGUILayout.EndVertical();
      if (hierarchyMode)
      {
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical(this.UseDefaultMargins() ? EditorStyles.inspectorDefaultMargins : GUIStyle.none);
      }
    }

    protected virtual void OnHeaderGUI() => UnityEditor.Editor.DrawHeaderGUI(this, this.targetTitle);

    internal virtual void OnHeaderControlsGUI()
    {
      GUILayoutUtility.GetRect(10f, 10f, 16f, 16f, EditorStyles.layerMaskField);
      GUILayout.FlexibleSpace();
      bool flag = true;
      AssetImporterEditor assetImporterEditor = this as AssetImporterEditor;
      if ((UnityEngine.Object) assetImporterEditor == (UnityEngine.Object) null && !(this.targets[0] is AssetImportInProgressProxy))
      {
        string assetPath = AssetDatabase.GetAssetPath(this.targets[0]);
        if (!AssetDatabase.IsMainAsset(this.targets[0]))
          flag = false;
        AssetImporter atPath = AssetImporter.GetAtPath(assetPath);
        if ((bool) (UnityEngine.Object) atPath && atPath.GetType() != typeof (AssetImporter))
          flag = false;
      }
      if (!flag || this.ShouldHideOpenButton())
        return;
      using (new EditorGUI.DisabledScope((UnityEngine.Object) assetImporterEditor != (UnityEngine.Object) null && assetImporterEditor.assetTarget == (UnityEngine.Object) null))
      {
        if (GUILayout.Button(UnityEditor.Editor.BaseStyles.open, EditorStyles.miniButton))
        {
          if ((UnityEngine.Object) assetImporterEditor != (UnityEngine.Object) null)
            AssetDatabase.OpenAsset(assetImporterEditor.assetTargets);
          else
            AssetDatabase.OpenAsset(this.targets);
          GUIUtility.ExitGUI();
        }
      }
    }

    /// <summary>
    ///   <para>Returns the visibility setting of the "open" button in the Inspector.</para>
    /// </summary>
    /// <returns>
    ///   <para>Return true if the button should be hidden.</para>
    /// </returns>
    protected virtual bool ShouldHideOpenButton() => false;

    internal virtual void OnHeaderIconGUI(Rect iconRect)
    {
      bool flag = AssetPreview.IsLoadingAssetPreview(this.target.GetInstanceID());
      Texture2D texture2D = AssetPreview.GetAssetPreview(this.target);
      if (!(bool) (UnityEngine.Object) texture2D)
      {
        if (flag)
          this.Repaint();
        texture2D = AssetPreview.GetMiniThumbnail(this.target);
      }
      GUI.Label(iconRect, (Texture) texture2D, UnityEditor.Editor.BaseStyles.centerStyle);
    }

    internal virtual void OnHeaderTitleGUI(Rect titleRect, string header)
    {
      titleRect.yMin -= 2f;
      titleRect.yMax += 2f;
      GUI.Label(titleRect, header, EditorStyles.largeLabel);
    }

    internal virtual Rect DrawHeaderHelpAndSettingsGUI(Rect r)
    {
      Vector2 vector2 = EditorStyles.iconButton.CalcSize(EditorGUI.GUIContents.titleSettingsIcon);
      float x = vector2.x;
      Rect position = new Rect(r.xMax - x, r.y + 5f, vector2.x, vector2.y);
      bool enabled = GUI.enabled;
      GUI.enabled = true;
      bool flag = EditorGUI.DropdownButton(position, EditorGUI.GUIContents.titleSettingsIcon, FocusType.Passive, EditorStyles.iconButton);
      GUI.enabled = enabled;
      if (flag)
        EditorUtility.DisplayObjectContextMenu(position, this.targets, 0);
      float num = x + vector2.x;
      return EditorGUIUtility.DrawEditorHeaderItems(new Rect(r.xMax - num, r.y + 5f, vector2.x, vector2.y), this.targets);
    }

    private void DrawHeaderFromInsideHierarchy()
    {
      GUIStyle style = GUILayoutUtility.topLevel.style;
      EditorGUILayout.EndVertical();
      this.OnHeaderGUI();
      EditorGUILayout.BeginVertical(style);
    }

    internal static Rect DrawHeaderGUI(UnityEditor.Editor editor, string header) => UnityEditor.Editor.DrawHeaderGUI(editor, header, 0.0f);

    internal static Rect DrawHeaderGUI(UnityEditor.Editor editor, string header, float leftMargin)
    {
      GUILayout.BeginHorizontal(UnityEditor.Editor.BaseStyles.inspectorBig);
      GUILayout.Space(38f);
      GUILayout.BeginVertical();
      GUILayout.Space(21f);
      GUILayout.BeginHorizontal();
      if ((double) leftMargin > 0.0)
        GUILayout.Space(leftMargin);
      if ((bool) (UnityEngine.Object) editor)
        editor.OnHeaderControlsGUI();
      else
        EditorGUILayout.GetControlRect();
      GUILayout.EndHorizontal();
      GUILayout.EndVertical();
      GUILayout.EndHorizontal();
      Rect lastRect = GUILayoutUtility.GetLastRect();
      Rect r = new Rect(lastRect.x + leftMargin, lastRect.y, lastRect.width - leftMargin, lastRect.height);
      Rect rect1 = new Rect(r.x + 6f, r.y + 6f, 32f, 32f);
      if ((bool) (UnityEngine.Object) editor)
        editor.OnHeaderIconGUI(rect1);
      else
        GUI.Label(rect1, (Texture) AssetPreview.GetMiniTypeThumbnail(typeof (UnityEngine.Object)), UnityEditor.Editor.BaseStyles.centerStyle);
      if ((bool) (UnityEngine.Object) editor)
        editor.DrawPostIconContent(rect1);
      float lineHeight = EditorGUI.lineHeight;
      Rect rect2;
      if ((bool) (UnityEngine.Object) editor)
      {
        Rect rect3 = editor.DrawHeaderHelpAndSettingsGUI(r);
        float x = r.x + 44f;
        rect2 = new Rect(x, r.y + 6f, (float) ((double) rect3.x - (double) x - 4.0), lineHeight);
      }
      else
        rect2 = new Rect(r.x + 44f, r.y + 6f, r.width - 44f, lineHeight);
      if ((bool) (UnityEngine.Object) editor)
        editor.OnHeaderTitleGUI(rect2, header);
      else
        GUI.Label(rect2, header, EditorStyles.largeLabel);
      bool enabled = GUI.enabled;
      GUI.enabled = true;
      Event current = Event.current;
      bool flag = (UnityEngine.Object) editor != (UnityEngine.Object) null && current.type == UnityEngine.EventType.MouseDown && current.button == 1 && r.Contains(current.mousePosition);
      GUI.enabled = enabled;
      if (flag)
      {
        EditorUtility.DisplayObjectContextMenu(new Rect(current.mousePosition.x, current.mousePosition.y, 0.0f, 0.0f), editor.targets, 0);
        current.Use();
      }
      return lastRect;
    }

    internal void DrawPostIconContent(Rect iconRect)
    {
      if (UnityEditor.Editor.OnPostIconGUI == null)
        return;
      Rect drawRect = iconRect;
      drawRect.x = (float) ((double) drawRect.xMax - 16.0 + 4.0);
      drawRect.y = (float) ((double) drawRect.yMax - 16.0 + 1.0);
      drawRect.width = 16f;
      drawRect.height = 16f;
      UnityEditor.Editor.OnPostIconGUI(this, drawRect);
    }

    internal void DrawPostIconContent()
    {
      if (Event.current.type != UnityEngine.EventType.Repaint)
        return;
      this.DrawPostIconContent(GUILayoutUtility.GetLastRect());
    }

    public static void DrawFoldoutInspector(UnityEngine.Object target, ref UnityEditor.Editor editor)
    {
      if ((UnityEngine.Object) editor != (UnityEngine.Object) null && (editor.target != target || target == (UnityEngine.Object) null))
      {
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) editor);
        editor = (UnityEditor.Editor) null;
      }
      if ((UnityEngine.Object) editor == (UnityEngine.Object) null && target != (UnityEngine.Object) null)
        editor = UnityEditor.Editor.CreateEditor(target);
      if ((UnityEngine.Object) editor == (UnityEngine.Object) null)
        return;
      Rect rect = UnityEditor.Editor.DrawHeaderGUI(editor, editor.targetTitle, 10f);
      int controlId = GUIUtility.GetControlID(45678, FocusType.Passive);
      Rect foldoutRenderRect = EditorGUI.GetInspectorTitleBarObjectFoldoutRenderRect(rect);
      foldoutRenderRect.y = rect.yMax - 17f;
      bool inspectorExpanded = InternalEditorUtility.GetIsInspectorExpanded(target);
      bool isExpanded = EditorGUI.DoObjectFoldout(inspectorExpanded, rect, foldoutRenderRect, editor.targets, controlId);
      if (isExpanded != inspectorExpanded)
        InternalEditorUtility.SetIsInspectorExpanded(target, isExpanded);
      if (!isExpanded)
        return;
      editor.OnInspectorGUI();
    }

    /// <summary>
    ///   <para>Override this method in subclasses if you implement OnPreviewGUI.</para>
    /// </summary>
    /// <returns>
    ///   <para>True if this component can be Previewed in its current state.</para>
    /// </returns>
    public virtual bool HasPreviewGUI() => this.preview.HasPreviewGUI();

    /// <summary>
    ///   <para>Override this method if you want to change the label of the Preview area.</para>
    /// </summary>
    public virtual GUIContent GetPreviewTitle() => this.preview.GetPreviewTitle();

    /// <summary>
    ///   <para>Override this method if you want to render a static preview.</para>
    /// </summary>
    /// <param name="assetPath">The asset to operate on.</param>
    /// <param name="subAssets">An array of all Assets at assetPath.</param>
    /// <param name="width">Width of the created texture.</param>
    /// <param name="height">Height of the created texture.</param>
    /// <returns>
    ///   <para>Generated texture or null.</para>
    /// </returns>
    public virtual Texture2D RenderStaticPreview(
      string assetPath,
      UnityEngine.Object[] subAssets,
      int width,
      int height)
    {
      return (Texture2D) null;
    }

    /// <summary>
    ///   <para>Implement to create your own custom preview for the preview area of the inspector, the headers of the primary editor, and the object selector.</para>
    /// </summary>
    /// <param name="r">Rectangle in which to draw the preview.</param>
    /// <param name="background">Background image.</param>
    public virtual void OnPreviewGUI(Rect r, GUIStyle background) => this.preview.OnPreviewGUI(r, background);

    /// <summary>
    ///   <para>Implement to create your own interactive custom preview. Interactive custom previews are used in the preview area of the inspector and the object selector.</para>
    /// </summary>
    /// <param name="r">Rectangle in which to draw the preview.</param>
    /// <param name="background">Background image.</param>
    public virtual void OnInteractivePreviewGUI(Rect r, GUIStyle background) => this.OnPreviewGUI(r, background);

    /// <summary>
    ///   <para>Override this method if you want to show custom controls in the preview header.</para>
    /// </summary>
    public virtual void OnPreviewSettings() => this.preview.OnPreviewSettings();

    /// <summary>
    ///   <para>Implement this method to show asset information on top of the asset preview.</para>
    /// </summary>
    public virtual string GetInfoString() => this.preview.GetInfoString();

    /// <summary>
    ///   <para>The first entry point for Preview Drawing.</para>
    /// </summary>
    /// <param name="previewPosition">The available area to draw the preview.</param>
    /// <param name="previewArea"></param>
    public virtual void DrawPreview(Rect previewArea) => ObjectPreview.DrawPreview((IPreviewable) this, previewArea, this.targets);

    public virtual void ReloadPreviewInstances() => this.preview.ReloadPreviewInstances();

    internal bool alwaysAllowExpansion { get; set; }

    internal bool CanBeExpandedViaAFoldout()
    {
      if (this.alwaysAllowExpansion)
        return true;
      if (this.m_SerializedObject == null)
        this.CreateSerializedObject();
      else
        this.m_SerializedObject.Update();
      this.m_SerializedObject.inspectorMode = this.inspectorMode;
      return this.CanBeExpandedViaAFoldoutWithoutUpdate();
    }

    internal bool CanBeExpandedViaAFoldoutWithoutUpdate()
    {
      if (this.m_SerializedObject == null)
        this.CreateSerializedObject();
      SerializedProperty iterator = this.m_SerializedObject.GetIterator();
      for (bool enterChildren = true; iterator.NextVisible(enterChildren); enterChildren = false)
      {
        if ((double) EditorGUI.GetPropertyHeight(iterator, (GUIContent) null, true) > 0.0)
          return true;
      }
      return false;
    }

    internal static bool IsAppropriateFileOpenForEdit(UnityEngine.Object assetObject) => UnityEditor.Editor.IsAppropriateFileOpenForEdit(assetObject, out string _);

    internal static bool IsAppropriateFileOpenForEdit(UnityEngine.Object assetObject, out string message)
    {
      message = string.Empty;
      if ((object) assetObject == null)
        return false;
      int instanceId = assetObject.GetInstanceID();
      if (instanceId == 0)
        return false;
      StatusQueryOptions statusOptions = EditorUserSettings.allowAsyncStatusUpdate ? StatusQueryOptions.UseCachedAsync : StatusQueryOptions.UseCachedIfPossible;
      if (AssetDatabase.IsNativeAsset(instanceId))
      {
        if (!AssetDatabase.IsOpenForEdit(AssetDatabase.GetAssetPath(instanceId), out message, statusOptions))
          return false;
      }
      else if (AssetDatabase.IsForeignAsset(instanceId) && !AssetDatabase.IsMetaFileOpenForEdit(assetObject, out message, statusOptions))
        return false;
      return true;
    }

    internal virtual bool IsEnabled()
    {
      foreach (UnityEngine.Object target in this.targets)
      {
        if (target == (UnityEngine.Object) null || (uint) (target.hideFlags & HideFlags.NotEditable) > 0U || EditorUtility.IsPersistent(target) && !UnityEditor.Editor.IsAppropriateFileOpenForEdit(target))
          return false;
      }
      return true;
    }

    internal bool IsOpenForEdit() => this.IsOpenForEdit(out string _);

    internal bool IsOpenForEdit(out string message)
    {
      message = "";
      foreach (UnityEngine.Object target in this.targets)
      {
        if (EditorUtility.IsPersistent(target) && !UnityEditor.Editor.IsAppropriateFileOpenForEdit(target))
          return false;
      }
      return true;
    }

    /// <summary>
    ///   <para>Override this method in subclasses to return false if you don't want default margins.</para>
    /// </summary>
    public virtual bool UseDefaultMargins() => true;

    public void Initialize(UnityEngine.Object[] targets) => throw new InvalidOperationException("You shouldn't call Initialize for Editors");

    public bool MoveNextTarget()
    {
      ++this.referenceTargetIndex;
      return this.referenceTargetIndex < this.targets.Length;
    }

    public void ResetTarget() => this.referenceTargetIndex = 0;

    internal virtual void OnAssetStoreInspectorGUI()
    {
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern UnityEditor.Editor CreateEditorWithContextInternal(
      UnityEngine.Object[] targetObjects,
      UnityEngine.Object context,
      System.Type editorType);

    int IToolModeOwner.GetInstanceID() => this.GetInstanceID();

    internal delegate void OnEditorGUIDelegate(UnityEditor.Editor editor, Rect drawRect);

    private static class BaseStyles
    {
      public static readonly GUIContent open = EditorGUIUtility.TrTextContent("Open");
      public static readonly GUIStyle inspectorBig = new GUIStyle(EditorStyles.inspectorBig);
      public static readonly GUIStyle inspectorBigInner = (GUIStyle) "IN BigTitle inner";
      public static readonly GUIStyle centerStyle = new GUIStyle();
      public static readonly GUIStyle postLargeHeaderBackground = (GUIStyle) "IN BigTitle Post";

      static BaseStyles() => UnityEditor.Editor.BaseStyles.centerStyle.alignment = TextAnchor.MiddleCenter;
    }

    internal class SerializedObjectNotCreatableException : Exception
    {
      public SerializedObjectNotCreatableException(string msg)
        : base(msg)
      {
      }
    }
  }
}
