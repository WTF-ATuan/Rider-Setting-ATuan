﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.Scene
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
  /// <summary>
  ///   <para>Run-time data structure for *.unity file.</para>
  /// </summary>
  [NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
  [Serializable]
  public struct Scene
  {
    [SerializeField]
    private int m_Handle;

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsValidInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string GetPathInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string GetNameInternal(int sceneHandle);

    [NativeThrows]
    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetNameInternal(int sceneHandle, string name);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern string GetGUIDInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsSubScene(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetIsSubScene(int sceneHandle, bool value);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool GetIsLoadedInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Scene.LoadingState GetLoadingStateInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool GetIsDirtyInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetDirtyID(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetBuildIndexInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetRootCountInternal(int sceneHandle);

    [StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);

    public int handle => this.m_Handle;

    internal Scene.LoadingState loadingState => Scene.GetLoadingStateInternal(this.handle);

    internal string guid => Scene.GetGUIDInternal(this.handle);

    /// <summary>
    ///         <para>Whether this is a valid Scene.
    /// A Scene may be invalid if, for example, you tried to open a Scene that does not exist. In this case, the Scene returned from EditorSceneManager.OpenScene would return False for IsValid.</para>
    ///       </summary>
    /// <returns>
    ///   <para>Whether this is a valid Scene.</para>
    /// </returns>
    public bool IsValid() => Scene.IsValidInternal(this.handle);

    /// <summary>
    ///   <para>Returns the relative path of the Scene. Like: "AssetsMyScenesMyScene.unity".</para>
    /// </summary>
    public string path => Scene.GetPathInternal(this.handle);

    /// <summary>
    ///   <para>Returns the name of the Scene that is currently active in the game or app.</para>
    /// </summary>
    public string name
    {
      get => Scene.GetNameInternal(this.handle);
      set => Scene.SetNameInternal(this.handle, value);
    }

    /// <summary>
    ///   <para>Returns true if the Scene is loaded.</para>
    /// </summary>
    public bool isLoaded => Scene.GetIsLoadedInternal(this.handle);

    /// <summary>
    ///   <para>Return the index of the Scene in the Build Settings.</para>
    /// </summary>
    public int buildIndex => Scene.GetBuildIndexInternal(this.handle);

    /// <summary>
    ///   <para>Returns true if the Scene is modifed.</para>
    /// </summary>
    public bool isDirty => Scene.GetIsDirtyInternal(this.handle);

    internal int dirtyID => Scene.GetDirtyID(this.handle);

    /// <summary>
    ///   <para>The number of root transforms of this Scene.</para>
    /// </summary>
    public int rootCount => Scene.GetRootCountInternal(this.handle);

    public bool isSubScene
    {
      get => Scene.IsSubScene(this.handle);
      set => Scene.SetIsSubScene(this.handle, value);
    }

    /// <summary>
    ///   <para>Returns all the root game objects in the Scene.</para>
    /// </summary>
    /// <returns>
    ///   <para>An array of game objects.</para>
    /// </returns>
    public GameObject[] GetRootGameObjects()
    {
      List<GameObject> rootGameObjects = new List<GameObject>(this.rootCount);
      this.GetRootGameObjects(rootGameObjects);
      return rootGameObjects.ToArray();
    }

    public void GetRootGameObjects(List<GameObject> rootGameObjects)
    {
      if (rootGameObjects.Capacity < this.rootCount)
        rootGameObjects.Capacity = this.rootCount;
      rootGameObjects.Clear();
      if (!this.IsValid())
        throw new ArgumentException("The scene is invalid.");
      if (!Application.isPlaying && !this.isLoaded)
        throw new ArgumentException("The scene is not loaded.");
      if (this.rootCount == 0)
        return;
      Scene.GetRootGameObjectsInternal(this.handle, (object) rootGameObjects);
    }

    public static bool operator ==(Scene lhs, Scene rhs) => lhs.handle == rhs.handle;

    public static bool operator !=(Scene lhs, Scene rhs) => lhs.handle != rhs.handle;

    public override int GetHashCode() => this.m_Handle;

    public override bool Equals(object other) => other is Scene scene && this.handle == scene.handle;

    internal enum LoadingState
    {
      NotLoaded,
      Loading,
      Loaded,
      Unloading,
    }
  }
}
