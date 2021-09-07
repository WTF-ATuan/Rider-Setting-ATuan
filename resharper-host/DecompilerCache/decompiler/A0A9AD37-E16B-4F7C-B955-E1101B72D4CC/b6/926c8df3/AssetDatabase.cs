// Decompiled with JetBrains decompiler
// Type: UnityEditor.AssetDatabase
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0A9AD37-E16B-4F7C-B955-E1101B72D4CC
// Assembly location: D:\unity\2019.4.1f1\Editor\Data\Managed\UnityEditor.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Profiling;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEditor
{
  /// <summary>
  ///   <para>An Interface for accessing assets and performing operations on assets.</para>
  /// </summary>
  [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabase.h")]
  [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseUtility.h")]
  [NativeHeader("Modules/AssetDatabase/Editor/ScriptBindings/AssetDatabase.bindings.h")]
  [NativeHeader("Editor/Src/PackageUtility.h")]
  [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
  [NativeHeader("Editor/Src/Application/ApplicationFunctions.h")]
  [StaticAccessor("AssetDatabaseBindings", StaticAccessorType.DoubleColon)]
  public sealed class AssetDatabase
  {
    public static event AssetDatabase.ImportPackageCallback importPackageStarted;

    public static event AssetDatabase.ImportPackageCallback importPackageCompleted;

    public static event AssetDatabase.ImportPackageCallback importPackageCancelled;

    public static event AssetDatabase.ImportPackageFailedCallback importPackageFailed;

    [RequiredByNativeCode]
    private static void Internal_CallImportPackageStarted(string packageName)
    {
      if (AssetDatabase.importPackageStarted == null)
        return;
      AssetDatabase.importPackageStarted(packageName);
    }

    [RequiredByNativeCode]
    private static void Internal_CallImportPackageCompleted(string packageName)
    {
      if (AssetDatabase.importPackageCompleted == null)
        return;
      AssetDatabase.importPackageCompleted(packageName);
    }

    [RequiredByNativeCode]
    private static void Internal_CallImportPackageCancelled(string packageName)
    {
      if (AssetDatabase.importPackageCancelled == null)
        return;
      AssetDatabase.importPackageCancelled(packageName);
    }

    [RequiredByNativeCode]
    private static void Internal_CallImportPackageFailed(string packageName, string errorMessage)
    {
      if (AssetDatabase.importPackageFailed == null)
        return;
      AssetDatabase.importPackageFailed(packageName, errorMessage);
    }

    public static void IsOpenForEdit(
      string[] assetOrMetaFilePaths,
      List<string> outNotEditablePaths,
      [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusQueryOptions = StatusQueryOptions.UseCachedIfPossible)
    {
      if (assetOrMetaFilePaths == null)
        throw new ArgumentNullException(nameof (assetOrMetaFilePaths));
      if (outNotEditablePaths == null)
        throw new ArgumentNullException(nameof (outNotEditablePaths));
      Profiler.BeginSample("AssetDatabase.IsOpenForEdit");
      AssetModificationProcessorInternal.IsOpenForEdit(assetOrMetaFilePaths, outNotEditablePaths, statusQueryOptions);
      Profiler.EndSample();
    }

    /// <summary>
    ///   <para>Makes a file open for editing in version control.</para>
    /// </summary>
    /// <param name="path">Specifies the path to a file relative to the project root.</param>
    /// <returns>
    ///   <para>true if Unity successfully made the file editable in the version control system. Otherwise, returns false.</para>
    /// </returns>
    public static bool MakeEditable(string path) => path != null ? AssetDatabase.MakeEditable(new string[1]
    {
      path
    }) : throw new ArgumentNullException(nameof (path));

    public static bool MakeEditable(
      string[] paths,
      string prompt = null,
      List<string> outNotEditablePaths = null)
    {
      if (paths == null)
        throw new ArgumentNullException(nameof (paths));
      ChangeSet changeSet = (ChangeSet) null;
      return Provider.HandlePreCheckoutCallback(ref paths, ref changeSet) && Provider.MakeEditableImpl(paths, prompt, changeSet, (object) outNotEditablePaths);
    }

    /// <summary>
    ///   <para>Gets the path to the text .meta file associated with an asset.</para>
    /// </summary>
    /// <param name="path">The path to the asset.</param>
    /// <returns>
    ///   <para>The path to the .meta text file or empty string if the file does not exist.</para>
    /// </returns>
    [Obsolete("GetTextMetaDataPathFromAssetPath has been renamed to GetTextMetaFilePathFromAssetPath (UnityUpgradable) -> GetTextMetaFilePathFromAssetPath(*)")]
    public static string GetTextMetaDataPathFromAssetPath(string path) => (string) null;

    /// <summary>
    ///   <para>Search the asset database using the search filter string.</para>
    /// </summary>
    /// <param name="filter">The filter string can contain search data.  See below for details about this string.</param>
    /// <param name="searchInFolders">The folders where the search will start.</param>
    /// <returns>
    ///   <para>Array of matching asset. Note that GUIDs will be returned.</para>
    /// </returns>
    public static string[] FindAssets(string filter) => AssetDatabase.FindAssets(filter, (string[]) null);

    /// <summary>
    ///   <para>Search the asset database using the search filter string.</para>
    /// </summary>
    /// <param name="filter">The filter string can contain search data.  See below for details about this string.</param>
    /// <param name="searchInFolders">The folders where the search will start.</param>
    /// <returns>
    ///   <para>Array of matching asset. Note that GUIDs will be returned.</para>
    /// </returns>
    public static string[] FindAssets(string filter, string[] searchInFolders)
    {
      SearchFilter searchFilter = new SearchFilter()
      {
        searchArea = SearchFilter.SearchArea.AllAssets
      };
      SearchUtility.ParseSearchString(filter, searchFilter);
      if (searchInFolders != null && (uint) searchInFolders.Length > 0U)
      {
        searchFilter.folders = searchInFolders;
        searchFilter.searchArea = SearchFilter.SearchArea.SelectedFolders;
      }
      return AssetDatabase.FindAssets(searchFilter);
    }

    internal static string[] FindAssets(SearchFilter searchFilter) => AssetDatabase.FindAllAssets(searchFilter).Select<HierarchyProperty, string>((Func<HierarchyProperty, string>) (property => property.guid)).ToArray<string>();

    internal static IEnumerable<HierarchyProperty> FindAllAssets(
      SearchFilter searchFilter)
    {
      IEnumerator<HierarchyProperty> enumerator = AssetDatabase.EnumerateAllAssets(searchFilter);
      while (enumerator.MoveNext())
        yield return enumerator.Current;
    }

    internal static IEnumerator<HierarchyProperty> EnumerateAllAssets(
      SearchFilter searchFilter)
    {
      return searchFilter.folders != null && searchFilter.folders.Length != 0 && searchFilter.searchArea == SearchFilter.SearchArea.SelectedFolders ? AssetDatabase.FindInFolders<HierarchyProperty>(searchFilter, (Func<HierarchyProperty, HierarchyProperty>) (p => p)) : AssetDatabase.FindEverywhere<HierarchyProperty>(searchFilter, (Func<HierarchyProperty, HierarchyProperty>) (p => p));
    }

    private static IEnumerator<T> FindInFolders<T>(
      SearchFilter searchFilter,
      Func<HierarchyProperty, T> selector)
    {
      List<string> folders = new List<string>();
      folders.AddRange((IEnumerable<string>) searchFilter.folders);
      if (folders.Remove(Folders.GetPackagesPath()))
      {
        UnityEditor.PackageManager.PackageInfo[] packages = PackageManagerUtilityInternal.GetAllVisiblePackages(searchFilter.skipHidden);
        UnityEditor.PackageManager.PackageInfo[] packageInfoArray = packages;
        for (int index = 0; index < packageInfoArray.Length; ++index)
        {
          UnityEditor.PackageManager.PackageInfo package = packageInfoArray[index];
          if (!folders.Contains(package.assetPath))
            folders.Add(package.assetPath);
          package = (UnityEditor.PackageManager.PackageInfo) null;
        }
        packageInfoArray = (UnityEditor.PackageManager.PackageInfo[]) null;
        packages = (UnityEditor.PackageManager.PackageInfo[]) null;
      }
      foreach (string str in folders)
      {
        string folderPath = str;
        int folderInstanceID = AssetDatabase.GetMainAssetOrInProgressProxyInstanceID(folderPath);
        string rootPath = "Assets";
        UnityEditor.PackageManager.PackageInfo packageInfo = UnityEditor.PackageManager.PackageInfo.FindForAssetPath(folderPath);
        if (packageInfo != null)
        {
          rootPath = packageInfo.assetPath;
          if (searchFilter.skipHidden && !PackageManagerUtilityInternal.IsPathInVisiblePackage(rootPath))
            continue;
        }
        HierarchyProperty property = new HierarchyProperty(rootPath);
        property.SetSearchFilter(new SearchFilter());
        if (property.Find(folderInstanceID, (int[]) null))
        {
          property.SetSearchFilter(searchFilter);
          int folderDepth = property.depth;
          int[] expanded = (int[]) null;
          while (property.NextWithDepthCheck(expanded, folderDepth + 1))
            yield return selector(property);
          expanded = (int[]) null;
        }
        else
          Debug.LogWarning((object) ("AssetDatabase.FindAssets: Folder not found: '" + folderPath + "'"));
        rootPath = (string) null;
        packageInfo = (UnityEditor.PackageManager.PackageInfo) null;
        property = (HierarchyProperty) null;
        folderPath = (string) null;
      }
    }

    private static IEnumerator<T> FindEverywhere<T>(
      SearchFilter searchFilter,
      Func<HierarchyProperty, T> selector)
    {
      List<string> rootPaths = new List<string>();
      if (searchFilter.searchArea == SearchFilter.SearchArea.AllAssets || searchFilter.searchArea == SearchFilter.SearchArea.InAssetsOnly)
        rootPaths.Add("Assets");
      if (searchFilter.searchArea == SearchFilter.SearchArea.AllAssets || searchFilter.searchArea == SearchFilter.SearchArea.InPackagesOnly)
      {
        UnityEditor.PackageManager.PackageInfo[] packages = PackageManagerUtilityInternal.GetAllVisiblePackages(searchFilter.skipHidden);
        UnityEditor.PackageManager.PackageInfo[] packageInfoArray = packages;
        for (int index = 0; index < packageInfoArray.Length; ++index)
        {
          UnityEditor.PackageManager.PackageInfo package = packageInfoArray[index];
          rootPaths.Add(package.assetPath);
          package = (UnityEditor.PackageManager.PackageInfo) null;
        }
        packageInfoArray = (UnityEditor.PackageManager.PackageInfo[]) null;
        packages = (UnityEditor.PackageManager.PackageInfo[]) null;
      }
      foreach (string str in rootPaths)
      {
        string rootPath = str;
        HierarchyProperty property = new HierarchyProperty(rootPath);
        property.SetSearchFilter(searchFilter);
        while (property.Next((int[]) null))
          yield return selector(property);
        property = (HierarchyProperty) null;
        rootPath = (string) null;
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool CanGetAssetMetaInfo(string path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void RegisterAssetFolder(string path, bool immutable, string guid);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void UnregisterAssetFolder(string path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void RegisterRedirectedAssetFolder(
      string mountPoint,
      string folder,
      string physicalPath,
      bool immutable,
      string guid);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void UnregisterRedirectedAssetFolder(string mountPoint, string folder);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool GetAssetFolderInfo(
      string path,
      out bool rootFolder,
      out bool immutable);

    /// <summary>
    ///   <para>Is object an asset?</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    public static bool Contains(UnityEngine.Object obj) => AssetDatabase.Contains(obj.GetInstanceID());

    /// <summary>
    ///   <para>Is object an asset?</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool Contains(int instanceID);

    /// <summary>
    ///   <para>Create a new folder.</para>
    /// </summary>
    /// <param name="parentFolder">The name of the parent folder.</param>
    /// <param name="newFolderName">The name of the new folder.</param>
    /// <returns>
    ///   <para>The GUID of the newly created folder.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string CreateFolder(string parentFolder, string newFolderName);

    /// <summary>
    ///   <para>Is asset a main asset in the project window?</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    public static bool IsMainAsset(UnityEngine.Object obj) => AssetDatabase.IsMainAsset(obj.GetInstanceID());

    /// <summary>
    ///   <para>Is asset a main asset in the project window?</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    [FreeFunction("AssetDatabase::IsMainAsset")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsMainAsset(int instanceID);

    /// <summary>
    ///   <para>Does the asset form part of another asset?</para>
    /// </summary>
    /// <param name="obj">The asset Object to query.</param>
    /// <param name="instanceID">Instance ID of the asset Object to query.</param>
    public static bool IsSubAsset(UnityEngine.Object obj) => AssetDatabase.IsSubAsset(obj.GetInstanceID());

    /// <summary>
    ///   <para>Does the asset form part of another asset?</para>
    /// </summary>
    /// <param name="obj">The asset Object to query.</param>
    /// <param name="instanceID">Instance ID of the asset Object to query.</param>
    [FreeFunction("AssetDatabase::IsSubAsset")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsSubAsset(int instanceID);

    /// <summary>
    ///   <para>Determines whether the Asset is a foreign Asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    public static bool IsForeignAsset(UnityEngine.Object obj) => !(obj == (UnityEngine.Object) null) ? AssetDatabase.IsForeignAsset(obj.GetInstanceID()) : throw new ArgumentNullException("obj is null");

    /// <summary>
    ///   <para>Determines whether the Asset is a foreign Asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsForeignAsset(int instanceID);

    /// <summary>
    ///   <para>Determines whether the Asset is a native Asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    public static bool IsNativeAsset(UnityEngine.Object obj) => !(obj == (UnityEngine.Object) null) ? AssetDatabase.IsNativeAsset(obj.GetInstanceID()) : throw new ArgumentNullException("obj is null");

    /// <summary>
    ///   <para>Determines whether the Asset is a native Asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="instanceID"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsNativeAsset(int instanceID);

    /// <summary>
    ///   <para>Gets the IP address of the Cache Server currently in use by the Editor.</para>
    /// </summary>
    /// <returns>
    ///   <para>Returns a string representation of the current Cache Server IP address.</para>
    /// </returns>
    [FreeFunction("AssetDatabase::GetCurrentCacheServerIpAddress")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetCurrentCacheServerIp();

    /// <summary>
    ///   <para>Creates a new unique path for an asset.</para>
    /// </summary>
    /// <param name="path"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GenerateUniqueAssetPath(string path);

    /// <summary>
    ///         <para>Starts importing Assets into the Asset Database. This lets you group several Asset imports together into one larger import.
    /// 
    /// Note:
    /// 
    /// Calling AssetDatabase.StartAssetEditing() places the Asset Database in a state that will prevent imports until AssetDatabase.StopAssetEditing() is called.
    /// This means that if an exception occurs between the two function calls, the AssetDatabase will be unresponsive.
    /// Therefore, it is highly recommended that you place calls to AssetDatabase.StartAssetEditing() and AssetDatabase.StopAssetEditing() inside
    /// either a try..catch block, or a try..finally block as needed.</para>
    ///       </summary>
    [FreeFunction("AssetDatabase::StartAssetImporting")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void StartAssetEditing();

    /// <summary>
    ///         <para>Stops importing Assets into the Asset Database. This lets you group several Asset imports together into one larger import.
    /// 
    /// Note:
    /// 
    /// Calling AssetDatabase.StartAssetEditing() places the Asset Database in a state that will prevent imports until AssetDatabase.StopAssetEditing() is called.
    /// This means that if an exception occurs between the two function calls, the AssetDatabase will be unresponsive.
    /// Therefore, it is highly recommended that you place calls to AssetDatabase.StartAssetEditing() and AssetDatabase.StopAssetEditing() inside
    /// either a try..catch block, or a try..finally block as needed.</para>
    ///       </summary>
    [FreeFunction("AssetDatabase::StopAssetImporting")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void StopAssetEditing();

    /// <summary>
    ///   <para>Calling this function will release file handles internally cached by Unity. This allows modifying asset or meta files safely thus avoiding potential file sharing IO errors.</para>
    /// </summary>
    [FreeFunction("AssetDatabase::UnloadAllFileStreams")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ReleaseCachedFileHandles();

    /// <summary>
    ///   <para>Checks if an asset file can be moved from one folder to another. (Without actually moving the file).</para>
    /// </summary>
    /// <param name="oldPath">The path where the asset currently resides.</param>
    /// <param name="newPath">The path which the asset should be moved to.</param>
    /// <returns>
    ///   <para>An empty string if the asset can be moved, otherwise an error message.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string ValidateMoveAsset(string oldPath, string newPath);

    /// <summary>
    ///   <para>Move an asset file (or folder) from one folder to another.</para>
    /// </summary>
    /// <param name="oldPath">The path where the asset currently resides.</param>
    /// <param name="newPath">The path which the asset should be moved to.</param>
    /// <returns>
    ///   <para>An empty string if the asset has been successfully moved, otherwise an error message.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string MoveAsset(string oldPath, string newPath);

    /// <summary>
    ///   <para>Creates an external Asset from an object (such as a Material) by extracting it from within an imported asset (such as an FBX file).</para>
    /// </summary>
    /// <param name="asset">The sub-asset to extract.</param>
    /// <param name="newPath">The file path of the new Asset.</param>
    /// <returns>
    ///   <para>An empty string if Unity has successfully extracted the Asset, or an error message if not.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string ExtractAsset(UnityEngine.Object asset, string newPath);

    /// <summary>
    ///   <para>Rename an asset file.</para>
    /// </summary>
    /// <param name="pathName">The path where the asset currently resides.</param>
    /// <param name="newName">The new name which should be given to the asset.</param>
    /// <returns>
    ///   <para>An empty string, if the asset has been successfully renamed, otherwise an error message.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string RenameAsset(string pathName, string newName);

    /// <summary>
    ///   <para>Moves the asset at path to the trash.</para>
    /// </summary>
    /// <param name="path"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool MoveAssetToTrash(string path);

    /// <summary>
    ///   <para>Deletes the asset file at path.</para>
    /// </summary>
    /// <param name="path">Filesystem path of the asset to be deleted.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool DeleteAsset(string path);

    /// <summary>
    ///   <para>Import asset at path.</para>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="options"></param>
    [ExcludeFromDocs]
    public static void ImportAsset(string path) => AssetDatabase.ImportAsset(path, ImportAssetOptions.Default);

    /// <summary>
    ///   <para>Import asset at path.</para>
    /// </summary>
    /// <param name="path"></param>
    /// <param name="options"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ImportAsset(string path, [DefaultValue("ImportAssetOptions.Default")] ImportAssetOptions options);

    /// <summary>
    ///   <para>Duplicates the asset at path and stores it at newPath.</para>
    /// </summary>
    /// <param name="path">Filesystem path of the source asset.</param>
    /// <param name="newPath">Filesystem path of the new asset to create.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool CopyAsset(string path, string newPath);

    /// <summary>
    ///   <para>Writes the import settings to disk.</para>
    /// </summary>
    /// <param name="path"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool WriteImportSettingsIfDirty(string path);

    /// <summary>
    ///   <para>Given a path to a directory in the Assets folder, relative to the project folder, this method will return an array of all its subdirectories.</para>
    /// </summary>
    /// <param name="path"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetSubFolders([NotNull] string path);

    /// <summary>
    ///   <para>Given a path to a folder, returns true if it exists, false otherwise.</para>
    /// </summary>
    /// <param name="path">The path to the folder.</param>
    /// <returns>
    ///   <para>Returns true if the folder exists.</para>
    /// </returns>
    [FreeFunction("AssetDatabase::IsFolderAsset")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsValidFolder(string path);

    /// <summary>
    ///   <para>Creates a new asset at path.</para>
    /// </summary>
    /// <param name="asset">Object to use in creating the asset.</param>
    /// <param name="path">Filesystem path for the new asset.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void CreateAsset([NotNull] UnityEngine.Object asset, string path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void CreateAssetFromObjects(UnityEngine.Object[] assets, string path);

    /// <summary>
    ///   <para>Adds objectToAdd to an existing asset at path.</para>
    /// </summary>
    /// <param name="objectToAdd">Object to add to the existing asset.</param>
    /// <param name="path">Filesystem path to the asset.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void AddObjectToAsset([NotNull] UnityEngine.Object objectToAdd, string path);

    /// <summary>
    ///   <para>Adds objectToAdd to an existing asset identified by assetObject.</para>
    /// </summary>
    /// <param name="objectToAdd"></param>
    /// <param name="assetObject"></param>
    public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject) => AssetDatabase.AddObjectToAsset_Obj(objectToAdd, assetObject);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void AddObjectToAsset_Obj([NotNull] UnityEngine.Object newAsset, [NotNull] UnityEngine.Object sameAssetFile);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void AddInstanceIDToAssetWithRandomFileId(
      int instanceIDToAdd,
      UnityEngine.Object assetObject,
      bool hide);

    /// <summary>
    ///   <para>Specifies which object in the asset file should become the main object after the next import.</para>
    /// </summary>
    /// <param name="mainObject">The object to become the main object.</param>
    /// <param name="assetPath">Path to the asset file.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetMainObject([NotNull] UnityEngine.Object mainObject, string assetPath);

    /// <summary>
    ///   <para>Returns the path name relative to the project folder where the asset is stored.</para>
    /// </summary>
    /// <param name="instanceID">The instance ID of the asset.</param>
    /// <param name="assetObject">A reference to the asset.</param>
    /// <returns>
    ///   <para>The asset path name, or null, or an empty string if the asset does not exist.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetAssetPath(UnityEngine.Object assetObject);

    /// <summary>
    ///   <para>Returns the path name relative to the project folder where the asset is stored.</para>
    /// </summary>
    /// <param name="instanceID">The instance ID of the asset.</param>
    /// <param name="assetObject">A reference to the asset.</param>
    /// <returns>
    ///   <para>The asset path name, or null, or an empty string if the asset does not exist.</para>
    /// </returns>
    public static string GetAssetPath(int instanceID) => AssetDatabase.GetAssetPathFromInstanceID(instanceID);

    [FreeFunction("::GetAssetPathFromInstanceID")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string GetAssetPathFromInstanceID(int instanceID);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern int GetMainAssetInstanceID(string assetPath);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern int GetMainAssetOrInProgressProxyInstanceID(string assetPath);

    /// <summary>
    ///   <para>Returns the path name relative to the project folder where the asset is stored.</para>
    /// </summary>
    /// <param name="assetObject"></param>
    [FreeFunction("::GetAssetOrScenePath")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetAssetOrScenePath(UnityEngine.Object assetObject);

    /// <summary>
    ///   <para>Gets the path to the text .meta file associated with an asset.</para>
    /// </summary>
    /// <param name="path">The path to the asset.</param>
    /// <returns>
    ///   <para>The path to the .meta text file or empty string if the file does not exist.</para>
    /// </returns>
    [FreeFunction("AssetDatabase::TextMetaFilePathFromAssetPath")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetTextMetaFilePathFromAssetPath(string path);

    /// <summary>
    ///   <para>Gets the path to the asset file associated with a text .meta file.</para>
    /// </summary>
    /// <param name="path"></param>
    [FreeFunction("AssetDatabase::AssetPathFromTextMetaFilePath")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetAssetPathFromTextMetaFilePath(string path);

    /// <summary>
    ///   <para>Returns the first asset object of type type at given path assetPath.</para>
    /// </summary>
    /// <param name="assetPath">Path of the asset to load.</param>
    /// <param name="type">Data type of the asset.</param>
    /// <returns>
    ///   <para>The asset matching the parameters.</para>
    /// </returns>
    [TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object LoadAssetAtPath(string assetPath, System.Type type);

    public static T LoadAssetAtPath<T>(string assetPath) where T : UnityEngine.Object => (T) AssetDatabase.LoadAssetAtPath(assetPath, typeof (T));

    /// <summary>
    ///   <para>Returns the main asset object at assetPath.</para>
    /// </summary>
    /// <param name="assetPath">Filesystem path of the asset to load.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object LoadMainAssetAtPath(string assetPath);

    [FreeFunction("AssetDatabase::GetMainAssetObject")]
    internal static UnityEngine.Object LoadMainAssetAtGUID(GUID assetGUID) => AssetDatabase.LoadMainAssetAtGUID_Injected(ref assetGUID);

    /// <summary>
    ///   <para>Returns the type of the main asset object at assetPath.</para>
    /// </summary>
    /// <param name="assetPath">Filesystem path of the asset to load.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern System.Type GetMainAssetTypeAtPath(string assetPath);

    /// <summary>
    ///   <para>Returns true if the main asset object at assetPath is loaded in memory.</para>
    /// </summary>
    /// <param name="assetPath">Filesystem path of the asset to load.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsMainAssetAtPathLoaded(string assetPath);

    /// <summary>
    ///   <para>Returns all sub Assets at assetPath.</para>
    /// </summary>
    /// <param name="assetPath"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(
      string assetPath);

    /// <summary>
    ///   <para>Returns an array of all Assets at assetPath.</para>
    /// </summary>
    /// <param name="assetPath">Filesystem path to the asset.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetAllAssetPaths();

    [Obsolete("Please use AssetDatabase.Refresh instead", true)]
    public static void RefreshDelayed(ImportAssetOptions options)
    {
    }

    [Obsolete("Please use AssetDatabase.Refresh instead", true)]
    public static void RefreshDelayed()
    {
    }

    [ExcludeFromDocs]
    public static void Refresh() => AssetDatabase.Refresh(ImportAssetOptions.Default);

    /// <summary>
    ///   <para>Import any changed assets.</para>
    /// </summary>
    /// <param name="options"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void Refresh([DefaultValue("ImportAssetOptions.Default")] ImportAssetOptions options);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    [ExcludeFromDocs]
    public static bool OpenAsset(int instanceID) => AssetDatabase.OpenAsset(instanceID, -1);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    public static bool OpenAsset(int instanceID, [DefaultValue("-1")] int lineNumber) => AssetDatabase.OpenAsset(instanceID, lineNumber, -1);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    [FreeFunction("::OpenAsset")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool OpenAsset(int instanceID, int lineNumber, int columnNumber);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    [ExcludeFromDocs]
    public static bool OpenAsset(UnityEngine.Object target) => AssetDatabase.OpenAsset(target, -1);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    public static bool OpenAsset(UnityEngine.Object target, [DefaultValue("-1")] int lineNumber) => AssetDatabase.OpenAsset(target, lineNumber, -1);

    /// <summary>
    ///   <para>Opens the asset with associated application.</para>
    /// </summary>
    /// <param name="instanceID"></param>
    /// <param name="lineNumber"></param>
    /// <param name="columnNumber"></param>
    /// <param name="target"></param>
    public static bool OpenAsset(UnityEngine.Object target, int lineNumber, int columnNumber) => (bool) target && AssetDatabase.OpenAsset(target.GetInstanceID(), lineNumber, columnNumber);

    /// <summary>
    ///   <para>Opens the asset(s) with associated application(s).</para>
    /// </summary>
    /// <param name="objects"></param>
    public static bool OpenAsset(UnityEngine.Object[] objects)
    {
      bool flag = true;
      foreach (UnityEngine.Object target in objects)
      {
        if (!AssetDatabase.OpenAsset(target))
          flag = false;
      }
      return flag;
    }

    /// <summary>
    ///   <para>Get the GUID for the asset at path.</para>
    /// </summary>
    /// <param name="path">Filesystem path for the asset.</param>
    /// <returns>
    ///   <para>GUID.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string AssetPathToGUID(string path);

    /// <summary>
    ///   <para>Gets the corresponding asset path for the supplied guid, or an empty string if the GUID can't be found.</para>
    /// </summary>
    /// <param name="guid"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GUIDToAssetPath(string guid);

    /// <summary>
    ///   <para>Returns the hash of all the dependencies of an asset.</para>
    /// </summary>
    /// <param name="path">Path to the asset.</param>
    /// <returns>
    ///   <para>Aggregate hash.</para>
    /// </returns>
    public static Hash128 GetAssetDependencyHash(string path)
    {
      Hash128 ret;
      AssetDatabase.GetAssetDependencyHash_Injected(path, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Writes all unsaved asset changes to disk.</para>
    /// </summary>
    [FreeFunction("AssetDatabase::SaveAssets")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SaveAssets();

    /// <summary>
    ///   <para>Retrieves an icon for the asset at the given asset path.</para>
    /// </summary>
    /// <param name="path"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern Texture GetCachedIcon(string path);

    /// <summary>
    ///   <para>Replaces that list of labels on an asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="labels"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SetLabels(UnityEngine.Object obj, string[] labels);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetAllLabelsImpl(object labelsList, object scoresList);

    internal static Dictionary<string, float> GetAllLabels()
    {
      List<string> stringList = new List<string>();
      List<float> floatList = new List<float>();
      AssetDatabase.GetAllLabelsImpl((object) stringList, (object) floatList);
      Dictionary<string, float> dictionary = new Dictionary<string, float>(stringList.Count);
      for (int index = 0; index < stringList.Count; ++index)
        dictionary[stringList[index]] = floatList[index];
      return dictionary;
    }

    /// <summary>
    ///   <para>Returns all labels attached to a given asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetLabels(UnityEngine.Object obj);

    /// <summary>
    ///   <para>Removes all labels attached to an asset.</para>
    /// </summary>
    /// <param name="obj"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ClearLabels(UnityEngine.Object obj);

    /// <summary>
    ///   <para>Return all the AssetBundle names in the asset database.</para>
    /// </summary>
    /// <returns>
    ///   <para>Array of asset bundle names.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetAllAssetBundleNames();

    [Obsolete("Method GetAssetBundleNames has been deprecated. Use GetAllAssetBundleNames instead.")]
    public string[] GetAssetBundleNames() => AssetDatabase.GetAllAssetBundleNames();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] GetAllAssetBundleNamesWithoutVariant();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] GetAllAssetBundleVariants();

    /// <summary>
    ///   <para>Return all the unused assetBundle names in the asset database.</para>
    /// </summary>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetUnusedAssetBundleNames();

    /// <summary>
    ///   <para>Remove the assetBundle name from the asset database. The forceRemove flag is used to indicate if you want to remove it even it's in use.</para>
    /// </summary>
    /// <param name="assetBundleName">The assetBundle name you want to remove.</param>
    /// <param name="forceRemove">Flag to indicate if you want to remove the assetBundle name even it's in use.</param>
    [FreeFunction("AssetDatabase::RemoveAssetBundleByName")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool RemoveAssetBundleName(string assetBundleName, bool forceRemove);

    /// <summary>
    ///   <para>Remove all the unused assetBundle names in the asset database.</para>
    /// </summary>
    [FreeFunction("AssetDatabase::RemoveUnusedAssetBundleNames")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void RemoveUnusedAssetBundleNames();

    /// <summary>
    ///   <para>Returns an array containing the paths of all assets marked with the specified Asset Bundle name.</para>
    /// </summary>
    /// <param name="assetBundleName"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetAssetPathsFromAssetBundle(string assetBundleName);

    /// <summary>
    ///   <para>Get the Asset paths for all Assets tagged with assetBundleName and
    ///           named assetName.</para>
    /// </summary>
    /// <param name="assetBundleName"></param>
    /// <param name="assetName"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetAssetPathsFromAssetBundleAndAssetName(
      string assetBundleName,
      string assetName);

    /// <summary>
    ///   <para>Returns the name of the AssetBundle that a given asset belongs to.</para>
    /// </summary>
    /// <param name="assetPath">The asset's path.</param>
    /// <returns>
    ///   <para>Returns the name of the AssetBundle that a given asset belongs to. See the method description for more details.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetImplicitAssetBundleName(string assetPath);

    /// <summary>
    ///   <para>Returns the name of the AssetBundle Variant that a given asset belongs to.</para>
    /// </summary>
    /// <param name="assetPath">The asset's path.</param>
    /// <returns>
    ///   <para>Returns the name of the AssetBundle Variant that a given asset belongs to. See the method description for more details.</para>
    /// </returns>
    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetImplicitAssetBundleVariantName(string assetPath);

    /// <summary>
    ///   <para>Given an assetBundleName, returns the list of AssetBundles that it depends on.</para>
    /// </summary>
    /// <param name="assetBundleName">The name of the AssetBundle for which dependencies are required.</param>
    /// <param name="recursive">If false, returns only AssetBundles which are direct dependencies of the input; if true, includes all indirect dependencies of the input.</param>
    /// <returns>
    ///   <para>The names of all AssetBundles that the input depends on.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetAssetBundleDependencies(string assetBundleName, bool recursive);

    /// <summary>
    ///         <para>Returns an array of all the assets that are dependencies of the asset at the specified pathName.
    /// 
    /// Note: GetDependencies() gets the Assets that are referenced by other Assets. For example, a Scene could contain many GameObjects with a Material attached to them. In this case,  GetDependencies() will return the path to the Material Assets, but not the GameObjects as those are not Assets on your disk.</para>
    ///       </summary>
    /// <param name="pathName">The path to the asset for which dependencies are required.</param>
    /// <param name="recursive">Controls whether this method recursively checks and returns all dependencies including indirect dependencies (when set to true), or whether it only returns direct dependencies (when set to false).</param>
    /// <returns>
    ///   <para>The paths of all assets that the input depends on.</para>
    /// </returns>
    public static string[] GetDependencies(string pathName) => AssetDatabase.GetDependencies(pathName, true);

    /// <summary>
    ///         <para>Returns an array of all the assets that are dependencies of the asset at the specified pathName.
    /// 
    /// Note: GetDependencies() gets the Assets that are referenced by other Assets. For example, a Scene could contain many GameObjects with a Material attached to them. In this case,  GetDependencies() will return the path to the Material Assets, but not the GameObjects as those are not Assets on your disk.</para>
    ///       </summary>
    /// <param name="pathName">The path to the asset for which dependencies are required.</param>
    /// <param name="recursive">Controls whether this method recursively checks and returns all dependencies including indirect dependencies (when set to true), or whether it only returns direct dependencies (when set to false).</param>
    /// <returns>
    ///   <para>The paths of all assets that the input depends on.</para>
    /// </returns>
    public static string[] GetDependencies(string pathName, bool recursive) => AssetDatabase.GetDependencies(new string[1]
    {
      pathName
    }, recursive);

    /// <summary>
    ///         <para>Returns an array of the paths of assets that are dependencies of all the assets in the list of pathNames that you provide.
    /// 
    /// Note: GetDependencies() gets the Assets that are referenced by other Assets. For example, a Scene could contain many GameObjects with a Material attached to them. In this case,  GetDependencies() will return the path to the Material Assets, but not the GameObjects as those are not Assets on your disk.</para>
    ///       </summary>
    /// <param name="pathNames">The path to the assets for which dependencies are required.</param>
    /// <param name="recursive">Controls whether this method recursively checks and returns all dependencies including indirect dependencies (when set to true), or whether it only returns direct dependencies (when set to false).</param>
    /// <returns>
    ///   <para>The paths of all assets that the input depends on.</para>
    /// </returns>
    public static string[] GetDependencies(string[] pathNames) => AssetDatabase.GetDependencies(pathNames, true);

    /// <summary>
    ///         <para>Returns an array of the paths of assets that are dependencies of all the assets in the list of pathNames that you provide.
    /// 
    /// Note: GetDependencies() gets the Assets that are referenced by other Assets. For example, a Scene could contain many GameObjects with a Material attached to them. In this case,  GetDependencies() will return the path to the Material Assets, but not the GameObjects as those are not Assets on your disk.</para>
    ///       </summary>
    /// <param name="pathNames">The path to the assets for which dependencies are required.</param>
    /// <param name="recursive">Controls whether this method recursively checks and returns all dependencies including indirect dependencies (when set to true), or whether it only returns direct dependencies (when set to false).</param>
    /// <returns>
    ///   <para>The paths of all assets that the input depends on.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetDependencies(string[] pathNames, bool recursive);

    /// <summary>
    ///   <para>Exports the assets identified by assetPathNames to a unitypackage file in fileName.</para>
    /// </summary>
    /// <param name="assetPathNames"></param>
    /// <param name="fileName"></param>
    /// <param name="flags"></param>
    /// <param name="assetPathName"></param>
    public static void ExportPackage(string assetPathName, string fileName) => AssetDatabase.ExportPackage(new string[1]
    {
      assetPathName
    }, fileName, ExportPackageOptions.Default);

    /// <summary>
    ///   <para>Exports the assets identified by assetPathNames to a unitypackage file in fileName.</para>
    /// </summary>
    /// <param name="assetPathNames"></param>
    /// <param name="fileName"></param>
    /// <param name="flags"></param>
    /// <param name="assetPathName"></param>
    public static void ExportPackage(
      string assetPathName,
      string fileName,
      ExportPackageOptions flags)
    {
      AssetDatabase.ExportPackage(new string[1]
      {
        assetPathName
      }, fileName, flags);
    }

    /// <summary>
    ///   <para>Exports the assets identified by assetPathNames to a unitypackage file in fileName.</para>
    /// </summary>
    /// <param name="assetPathNames"></param>
    /// <param name="fileName"></param>
    /// <param name="flags"></param>
    /// <param name="assetPathName"></param>
    [ExcludeFromDocs]
    public static void ExportPackage(string[] assetPathNames, string fileName) => AssetDatabase.ExportPackage(assetPathNames, fileName, ExportPackageOptions.Default);

    /// <summary>
    ///   <para>Exports the assets identified by assetPathNames to a unitypackage file in fileName.</para>
    /// </summary>
    /// <param name="assetPathNames"></param>
    /// <param name="fileName"></param>
    /// <param name="flags"></param>
    /// <param name="assetPathName"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void ExportPackage(
      string[] assetPathNames,
      string fileName,
      [DefaultValue("ExportPackageOptions.Default")] ExportPackageOptions flags);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string GetUniquePathNameAtSelectedPath(string fileName);

    /// <summary>
    ///   <para>Query whether an Asset file is open for editing in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose status you wish to query.</param>
    /// <param name="assetOrMetaFilePath">Path to the asset file or its .meta file on disk, relative to project folder.</param>
    /// <param name="message">Returns a reason for the asset not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset is considered open for edit by the selected version control system.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool IsOpenForEdit(UnityEngine.Object assetObject) => AssetDatabase.IsOpenForEdit(assetObject, StatusQueryOptions.UseCachedIfPossible);

    /// <summary>
    ///   <para>Query whether an Asset file is open for editing in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose status you wish to query.</param>
    /// <param name="assetOrMetaFilePath">Path to the asset file or its .meta file on disk, relative to project folder.</param>
    /// <param name="message">Returns a reason for the asset not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset is considered open for edit by the selected version control system.</para>
    /// </returns>
    public static bool IsOpenForEdit(UnityEngine.Object assetObject, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions) => AssetDatabase.IsOpenForEdit(AssetDatabase.GetAssetOrScenePath(assetObject), statusOptions);

    /// <summary>
    ///   <para>Query whether an Asset file is open for editing in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose status you wish to query.</param>
    /// <param name="assetOrMetaFilePath">Path to the asset file or its .meta file on disk, relative to project folder.</param>
    /// <param name="message">Returns a reason for the asset not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset is considered open for edit by the selected version control system.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool IsOpenForEdit(string assetOrMetaFilePath) => AssetDatabase.IsOpenForEdit(assetOrMetaFilePath, StatusQueryOptions.UseCachedIfPossible);

    /// <summary>
    ///   <para>Query whether an Asset file is open for editing in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose status you wish to query.</param>
    /// <param name="assetOrMetaFilePath">Path to the asset file or its .meta file on disk, relative to project folder.</param>
    /// <param name="message">Returns a reason for the asset not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset is considered open for edit by the selected version control system.</para>
    /// </returns>
    public static bool IsOpenForEdit(string assetOrMetaFilePath, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions) => AssetDatabase.IsOpenForEdit(assetOrMetaFilePath, out string _, statusOptions);

    [ExcludeFromDocs]
    public static bool IsOpenForEdit(UnityEngine.Object assetObject, out string message) => AssetDatabase.IsOpenForEdit(assetObject, out message, StatusQueryOptions.UseCachedIfPossible);

    public static bool IsOpenForEdit(
      UnityEngine.Object assetObject,
      out string message,
      [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions)
    {
      return AssetDatabase.IsOpenForEdit(AssetDatabase.GetAssetOrScenePath(assetObject), out message, statusOptions);
    }

    [ExcludeFromDocs]
    public static bool IsOpenForEdit(string assetOrMetaFilePath, out string message) => AssetDatabase.IsOpenForEdit(assetOrMetaFilePath, out message, StatusQueryOptions.UseCachedIfPossible);

    public static bool IsOpenForEdit(
      string assetOrMetaFilePath,
      out string message,
      [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions)
    {
      return AssetModificationProcessorInternal.IsOpenForEdit(assetOrMetaFilePath, out message, statusOptions);
    }

    /// <summary>
    ///   <para>Query whether an asset's metadata (.meta) file is open for edit in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose metadata status you wish to query.</param>
    /// <param name="message">Returns a reason for the asset metadata not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset's metadata is considered open for edit by the selected version control system.</para>
    /// </returns>
    [ExcludeFromDocs]
    public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject) => AssetDatabase.IsMetaFileOpenForEdit(assetObject, StatusQueryOptions.UseCachedIfPossible);

    /// <summary>
    ///   <para>Query whether an asset's metadata (.meta) file is open for edit in version control.</para>
    /// </summary>
    /// <param name="assetObject">Object representing the asset whose metadata status you wish to query.</param>
    /// <param name="message">Returns a reason for the asset metadata not being open for edit.</param>
    /// <param name="statusOptions">Options for how the version control system should be queried. These options can effect the speed and accuracy of the query. Default is StatusQueryOptions.UseCachedIfPossible.</param>
    /// <returns>
    ///   <para>True if the asset's metadata is considered open for edit by the selected version control system.</para>
    /// </returns>
    public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions) => AssetDatabase.IsMetaFileOpenForEdit(assetObject, out string _, statusOptions);

    [ExcludeFromDocs]
    public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject, out string message) => AssetDatabase.IsMetaFileOpenForEdit(assetObject, out message, StatusQueryOptions.UseCachedIfPossible);

    public static bool IsMetaFileOpenForEdit(
      UnityEngine.Object assetObject,
      out string message,
      [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions)
    {
      return AssetDatabase.IsOpenForEdit(AssetDatabase.GetTextMetaFilePathFromAssetPath(AssetDatabase.GetAssetOrScenePath(assetObject)), out message, statusOptions);
    }

    public static T GetBuiltinExtraResource<T>(string path) where T : UnityEngine.Object => (T) AssetDatabase.GetBuiltinExtraResource(typeof (T), path);

    [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern UnityEngine.Object GetBuiltinExtraResource(System.Type type, string path);

    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] CollectAllChildren(string guid, string[] collection);

    internal static extern string assetFolderGUID { [FreeFunction("AssetDatabaseBindings::GetAssetFolderGUID"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    [FreeFunction("AssetDatabase::IsV1Enabled")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool IsV1Enabled();

    [FreeFunction("AssetDatabase::IsV2Enabled")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern bool IsV2Enabled();

    [FreeFunction("AssetDatabase::CloseCachedFiles")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void CloseCachedFiles();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] GetSourceAssetImportDependenciesAsGUIDs(string path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] GetImportedAssetImportDependenciesAsGUIDs(string path);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern string[] GetGuidOfPathLocationImportDependencies(string path);

    [FreeFunction("AssetDatabase::ReSerializeAssetsForced")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void ReSerializeAssetsForced(
      GUID[] guids,
      ForceReserializeAssetsOptions options);

    public static void ForceReserializeAssets(
      IEnumerable<string> assetPaths,
      ForceReserializeAssetsOptions options = ForceReserializeAssetsOptions.ReserializeAssetsAndMetadata)
    {
      if (EditorApplication.isPlaying)
        throw new Exception("AssetDatabase.ForceReserializeAssets cannot be used when in play mode");
      HashSet<GUID> guidSet = new HashSet<GUID>();
      foreach (string assetPath in assetPaths)
      {
        bool rootFolder;
        bool immutable;
        if (!(assetPath == "") && !InternalEditorUtility.IsUnityExtensionRegistered(assetPath) && (!AssetDatabase.GetAssetFolderInfo(assetPath, out rootFolder, out immutable) || !(rootFolder | immutable)))
        {
          GUID guid = new GUID(AssetDatabase.AssetPathToGUID(assetPath));
          if (!guid.Empty())
            guidSet.Add(guid);
          else if (File.Exists(assetPath))
            Debug.LogWarningFormat("Cannot reserialize file \"{0}\": the file is not in the AssetDatabase. Skipping.", (object) assetPath);
          else
            Debug.LogWarningFormat("Cannot reserialize file \"{0}\": the file does not exist. Skipping.", (object) assetPath);
        }
      }
      GUID[] guidArray = new GUID[guidSet.Count];
      guidSet.CopyTo(guidArray);
      AssetDatabase.ReSerializeAssetsForced(guidArray, options);
    }

    [FreeFunction("AssetDatabase::GetGUIDAndLocalIdentifierInFile")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool GetGUIDAndLocalIdentifierInFile(
      int instanceID,
      out GUID outGuid,
      out long outLocalId);

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Please use the overload of this function that uses a long data type for the localId parameter, because this version can return a localID that has overflowed. This can happen when called on objects that are part of a Prefab.", true)]
    public static bool TryGetGUIDAndLocalFileIdentifier(
      UnityEngine.Object obj,
      out string guid,
      out int localId)
    {
      return AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj.GetInstanceID(), out guid, out localId);
    }

    [Obsolete("Please use the overload of this function that uses a long data type for the localId parameter, because this version can return a localID that has overflowed. This can happen when called on objects that are part of a Prefab.", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool TryGetGUIDAndLocalFileIdentifier(
      int instanceID,
      out string guid,
      out int localId)
    {
      throw new NotSupportedException("Use the overload of this function that uses a long data type for the localId parameter, because this version can return a localID that has overflowed. This can happen when called on objects that are part of a Prefab.");
    }

    public static bool TryGetGUIDAndLocalFileIdentifier(
      UnityEngine.Object obj,
      out string guid,
      out long localId)
    {
      return AssetDatabase.TryGetGUIDAndLocalFileIdentifier(obj.GetInstanceID(), out guid, out localId);
    }

    public static bool TryGetGUIDAndLocalFileIdentifier(
      int instanceID,
      out string guid,
      out long localId)
    {
      GUID outGuid;
      bool identifierInFile = AssetDatabase.GetGUIDAndLocalIdentifierInFile(instanceID, out outGuid, out localId);
      guid = outGuid.ToString();
      return identifierInFile;
    }

    public static bool TryGetGUIDAndLocalFileIdentifier<T>(
      LazyLoadReference<T> assetRef,
      out string guid,
      out long localId)
      where T : UnityEngine.Object
    {
      GUID outGuid;
      bool identifierInFile = AssetDatabase.GetGUIDAndLocalIdentifierInFile(assetRef.instanceID, out outGuid, out localId);
      guid = outGuid.ToString();
      return identifierInFile;
    }

    /// <summary>
    ///   <para>Forcibly load and re-serialize the given assets, flushing any outstanding data changes to disk.</para>
    /// </summary>
    /// <param name="assetPaths">The paths to the assets that should be reserialized. If omitted, will reserialize all assets in the project.</param>
    /// <param name="options">Specify whether you want to reserialize the assets themselves, their .meta files, or both. If omitted, defaults to both.</param>
    public static void ForceReserializeAssets() => AssetDatabase.ForceReserializeAssets((IEnumerable<string>) AssetDatabase.GetAllAssetPaths());

    /// <summary>
    ///   <para>Removes object from its asset (See Also: AssetDatabase.AddObjectToAsset).</para>
    /// </summary>
    /// <param name="objectToRemove"></param>
    [FreeFunction("AssetDatabase::RemoveObjectFromAsset")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void RemoveObjectFromAsset([NotNull] UnityEngine.Object objectToRemove);

    [FreeFunction("AssetDatabase::GUIDFromExistingAssetPath")]
    internal static GUID GUIDFromExistingAssetPath(string path)
    {
      GUID ret;
      AssetDatabase.GUIDFromExistingAssetPath_Injected(path, out ret);
      return ret;
    }

    [FreeFunction("::ImportPackage")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool ImportPackage(string packagePath, ImportPackageOptions options);

    /// <summary>
    ///   <para>Imports package at packagePath into the current project.</para>
    /// </summary>
    /// <param name="packagePath"></param>
    /// <param name="interactive"></param>
    public static void ImportPackage(string packagePath, bool interactive) => AssetDatabase.ImportPackage(packagePath, (ImportPackageOptions) (2 | (interactive ? 0 : 1)));

    internal static bool ImportPackageImmediately(string packagePath) => AssetDatabase.ImportPackage(packagePath, ImportPackageOptions.NoGUI);

    /// <summary>
    ///   <para>Increments an internal counter which Unity uses to determine whether to allow automatic AssetDatabase refreshing behavior.</para>
    /// </summary>
    [FreeFunction("ApplicationDisallowAutoRefresh")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DisallowAutoRefresh();

    /// <summary>
    ///   <para>Decrements an internal counter which Unity uses to determine whether to allow automatic AssetDatabase refreshing behavior.</para>
    /// </summary>
    [FreeFunction("ApplicationAllowAutoRefresh")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void AllowAutoRefresh();

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern UnityEngine.Object LoadMainAssetAtGUID_Injected(ref GUID assetGUID);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetAssetDependencyHash_Injected(string path, out Hash128 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GUIDFromExistingAssetPath_Injected(string path, out GUID ret);

    /// <summary>
    ///   <para>Delegate to be called from AssetDatabase.ImportPackage callbacks. packageName is the name of the package that raised the callback.</para>
    /// </summary>
    /// <param name="packageName"></param>
    public delegate void ImportPackageCallback(string packageName);

    /// <summary>
    ///   <para>Delegate to be called from AssetDatabase.ImportPackage callbacks. packageName is the name of the package that raised the callback. errorMessage is the reason for the failure.</para>
    /// </summary>
    /// <param name="packageName"></param>
    /// <param name="errorMessage"></param>
    public delegate void ImportPackageFailedCallback(string packageName, string errorMessage);
  }
}
