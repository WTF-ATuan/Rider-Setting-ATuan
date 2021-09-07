// Decompiled with JetBrains decompiler
// Type: UnityEditor.AssetPostprocessor
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D90B285-60B6-44CE-87B8-263EFCC36EED
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEditor.dll

using System;
using System.ComponentModel;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
  /// <summary>
  ///   <para>AssetPostprocessor lets you hook into the import pipeline and run scripts prior or after importing assets.</para>
  /// </summary>
  public class AssetPostprocessor
  {
    private string m_PathName;
    private AssetImportContext m_Context;

    /// <summary>
    ///   <para>The path name of the asset being imported.</para>
    /// </summary>
    public string assetPath
    {
      get => this.m_PathName;
      set => this.m_PathName = value;
    }

    /// <summary>
    ///   <para>The import context.</para>
    /// </summary>
    public AssetImportContext context
    {
      get => this.m_Context;
      internal set => this.m_Context = value;
    }

    /// <summary>
    ///   <para>Logs an import warning to the console.</para>
    /// </summary>
    /// <param name="warning"></param>
    /// <param name="context"></param>
    [ExcludeFromDocs]
    public void LogWarning(string warning)
    {
      UnityEngine.Object context = (UnityEngine.Object) null;
      this.LogWarning(warning, context);
    }

    /// <summary>
    ///   <para>Logs an import warning to the console.</para>
    /// </summary>
    /// <param name="warning"></param>
    /// <param name="context"></param>
    public void LogWarning(string warning, [DefaultValue("null")] UnityEngine.Object context) => Debug.LogWarning((object) warning, context);

    /// <summary>
    ///   <para>Logs an import error message to the console.</para>
    /// </summary>
    /// <param name="warning"></param>
    /// <param name="context"></param>
    [ExcludeFromDocs]
    public void LogError(string warning)
    {
      UnityEngine.Object context = (UnityEngine.Object) null;
      this.LogError(warning, context);
    }

    /// <summary>
    ///   <para>Logs an import error message to the console.</para>
    /// </summary>
    /// <param name="warning"></param>
    /// <param name="context"></param>
    public void LogError(string warning, [DefaultValue("null")] UnityEngine.Object context) => Debug.LogError((object) warning, context);

    /// <summary>
    ///   <para>Returns the version of the asset postprocessor.</para>
    /// </summary>
    public virtual uint GetVersion() => 0;

    /// <summary>
    ///   <para>Reference to the asset importer.</para>
    /// </summary>
    public AssetImporter assetImporter => AssetImporter.GetAtPath(this.assetPath);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("To set or get the preview, call EditorUtility.SetAssetPreview or AssetPreview.GetAssetPreview instead", true)]
    public Texture2D preview
    {
      get => (Texture2D) null;
      set
      {
      }
    }

    /// <summary>
    ///   <para>Override the order in which importers are processed.</para>
    /// </summary>
    public virtual int GetPostprocessOrder() => 0;
  }
}
