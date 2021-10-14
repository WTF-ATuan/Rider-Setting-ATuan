// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.SceneManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CFC1AD89-0650-411E-946C-FF2E6F276711
// Assembly location: D:\unity\2020.3.14f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
  /// <summary>
  ///   <para>Scene management at run-time.</para>
  /// </summary>
  /// <footer><a href="https://docs.unity3d.com/2020.3/Documentation/ScriptReference/30_search.html?q=SceneManager">`SceneManager` on docs.unity3d.com</a></footer>
  [RequiredByNativeCode]
  [NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
  public class SceneManager
  {
    internal static bool s_AllowLoadScene = true;

    /// <summary>
    ///   <para>The total number of currently loaded Scenes.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager-sceneCount.html">External documentation for `SceneManager.sceneCount`</a></footer>
    public static extern int sceneCount { [NativeHeader("Runtime/SceneManager/SceneManager.h"), NativeMethod("GetSceneCount"), StaticAccessor("GetSceneManager()", StaticAccessorType.Dot), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Number of Scenes in Build Settings.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager-sceneCountInBuildSettings.html">External documentation for `SceneManager.sceneCountInBuildSettings`</a></footer>
    public static int sceneCountInBuildSettings => SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();

    /// <summary>
    ///   <para>Gets the currently active Scene.</para>
    /// </summary>
    /// <returns>
    ///   <para>The active Scene.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetActiveScene.html">External documentation for `SceneManager.GetActiveScene`</a></footer>
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static Scene GetActiveScene()
    {
      Scene ret;
      SceneManager.GetActiveScene_Injected(out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Set the Scene to be active.</para>
    /// </summary>
    /// <param name="scene">The Scene to be set.</param>
    /// <returns>
    ///   <para>Returns false if the Scene is not loaded yet.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.SetActiveScene.html">External documentation for `SceneManager.SetActiveScene`</a></footer>
    [NativeThrows]
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static bool SetActiveScene(Scene scene) => SceneManager.SetActiveScene_Injected(ref scene);

    /// <summary>
    ///   <para>Searches all Scenes loaded for a Scene that has the given asset path.</para>
    /// </summary>
    /// <param name="scenePath">Path of the Scene. Should be relative to the project folder. Like: "AssetsMyScenesMyScene.unity".</param>
    /// <returns>
    ///   <para>A reference to the Scene, if valid. If not, an invalid Scene is returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetSceneByPath.html">External documentation for `SceneManager.GetSceneByPath`</a></footer>
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static Scene GetSceneByPath(string scenePath)
    {
      Scene ret;
      SceneManager.GetSceneByPath_Injected(scenePath, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Searches through the Scenes loaded for a Scene with the given name.</para>
    /// </summary>
    /// <param name="name">Name of Scene to find.</param>
    /// <returns>
    ///   <para>A reference to the Scene, if valid. If not, an invalid Scene is returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetSceneByName.html">External documentation for `SceneManager.GetSceneByName`</a></footer>
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static Scene GetSceneByName(string name)
    {
      Scene ret;
      SceneManager.GetSceneByName_Injected(name, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Get a Scene struct from a build index.</para>
    /// </summary>
    /// <param name="buildIndex">Build index as shown in the Build Settings window.</param>
    /// <returns>
    ///   <para>A reference to the Scene, if valid. If not, an invalid Scene is returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetSceneByBuildIndex.html">External documentation for `SceneManager.GetSceneByBuildIndex`</a></footer>
    public static Scene GetSceneByBuildIndex(int buildIndex) => SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);

    /// <summary>
    ///   <para>Get the Scene at index in the SceneManager's list of loaded Scenes.</para>
    /// </summary>
    /// <param name="index">Index of the Scene to get. Index must be greater than or equal to 0 and less than SceneManager.sceneCount.</param>
    /// <returns>
    ///   <para>A reference to the Scene at the index specified.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetSceneAt.html">External documentation for `SceneManager.GetSceneAt`</a></footer>
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    [NativeThrows]
    public static Scene GetSceneAt(int index)
    {
      Scene ret;
      SceneManager.GetSceneAt_Injected(index, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Create an empty new Scene at runtime with the given name.</para>
    /// </summary>
    /// <param name="sceneName">The name of the new Scene. It cannot be empty or null, or same as the name of the existing Scenes.</param>
    /// <param name="parameters">Various parameters used to create the Scene.</param>
    /// <returns>
    ///   <para>A reference to the new Scene that was created, or an invalid Scene if creation failed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.CreateScene.html">External documentation for `SceneManager.CreateScene`</a></footer>
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    [NativeThrows]
    public static Scene CreateScene([NotNull("ArgumentNullException")] string sceneName, CreateSceneParameters parameters)
    {
      Scene ret;
      SceneManager.CreateScene_Injected(sceneName, ref parameters, out ret);
      return ret;
    }

    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    [NativeThrows]
    private static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options) => SceneManager.UnloadSceneInternal_Injected(ref scene, options);

    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    [NativeThrows]
    private static AsyncOperation UnloadSceneAsyncInternal(
      Scene scene,
      UnloadSceneOptions options)
    {
      return SceneManager.UnloadSceneAsyncInternal_Injected(ref scene, options);
    }

    private static AsyncOperation LoadSceneAsyncNameIndexInternal(
      string sceneName,
      int sceneBuildIndex,
      LoadSceneParameters parameters,
      bool mustCompleteNextFrame)
    {
      return !SceneManager.s_AllowLoadScene ? (AsyncOperation) null : SceneManagerAPI.ActiveAPI.LoadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, parameters, mustCompleteNextFrame);
    }

    private static AsyncOperation UnloadSceneNameIndexInternal(
      string sceneName,
      int sceneBuildIndex,
      bool immediately,
      UnloadSceneOptions options,
      out bool outSuccess)
    {
      if (SceneManager.s_AllowLoadScene)
        return SceneManagerAPI.ActiveAPI.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
      outSuccess = false;
      return (AsyncOperation) null;
    }

    /// <summary>
    ///   <para>This will merge the source Scene into the destinationScene.</para>
    /// </summary>
    /// <param name="sourceScene">The Scene that will be merged into the destination Scene.</param>
    /// <param name="destinationScene">Existing Scene to merge the source Scene into.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.MergeScenes.html">External documentation for `SceneManager.MergeScenes`</a></footer>
    [NativeThrows]
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static void MergeScenes(Scene sourceScene, Scene destinationScene) => SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);

    /// <summary>
    ///   <para>Move a GameObject from its current Scene to a new Scene.</para>
    /// </summary>
    /// <param name="go">GameObject to move.</param>
    /// <param name="scene">Scene to move into.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.MoveGameObjectToScene.html">External documentation for `SceneManager.MoveGameObjectToScene`</a></footer>
    [NativeThrows]
    [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
    public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene) => SceneManager.MoveGameObjectToScene_Injected(go, ref scene);

    [RequiredByNativeCode]
    internal static AsyncOperation LoadFirstScene_Internal(bool async) => SceneManagerAPI.ActiveAPI.LoadFirstScene(async);

    public static event UnityAction<Scene, LoadSceneMode> sceneLoaded;

    public static event UnityAction<Scene> sceneUnloaded;

    public static event UnityAction<Scene, Scene> activeSceneChanged;

    /// <summary>
    ///   <para>Returns an array of all the Scenes currently open in the hierarchy.</para>
    /// </summary>
    /// <returns>
    ///   <para>Array of Scenes in the Hierarchy.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.GetAllScenes.html">External documentation for `SceneManager.GetAllScenes`</a></footer>
    [Obsolete("Use SceneManager.sceneCount and SceneManager.GetSceneAt(int index) to loop the all scenes instead.")]
    public static Scene[] GetAllScenes()
    {
      Scene[] sceneArray = new Scene[SceneManager.sceneCount];
      for (int index = 0; index < SceneManager.sceneCount; ++index)
        sceneArray[index] = SceneManager.GetSceneAt(index);
      return sceneArray;
    }

    /// <summary>
    ///   <para>Create an empty new Scene at runtime with the given name.</para>
    /// </summary>
    /// <param name="sceneName">The name of the new Scene. It cannot be empty or null, or same as the name of the existing Scenes.</param>
    /// <param name="parameters">Various parameters used to create the Scene.</param>
    /// <returns>
    ///   <para>A reference to the new Scene that was created, or an invalid Scene if creation failed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.CreateScene.html">External documentation for `SceneManager.CreateScene`</a></footer>
    public static Scene CreateScene(string sceneName)
    {
      CreateSceneParameters parameters = new CreateSceneParameters(LocalPhysicsMode.None);
      return SceneManager.CreateScene(sceneName, parameters);
    }

    /// <summary>
    ///   <para>Loads the Scene by its name or index in Build Settings.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">Allows you to specify whether or not to load the Scene additively. See SceneManagement.LoadSceneMode for more information about the options.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadScene.html">External documentation for `SceneManager.LoadScene`</a></footer>
    public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(mode);
      SceneManager.LoadScene(sceneName, parameters);
    }

    [ExcludeFromDocs]
    public static void LoadScene(string sceneName)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
      SceneManager.LoadScene(sceneName, parameters);
    }

    /// <summary>
    ///   <para>Loads the Scene by its name or index in Build Settings.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="parameters">Various parameters used to load the Scene.</param>
    /// <returns>
    ///   <para>A handle to the Scene being loaded.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadScene.html">External documentation for `SceneManager.LoadScene`</a></footer>
    public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
    {
      SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, true);
      return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
    }

    /// <summary>
    ///   <para>Loads the Scene by its name or index in Build Settings.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">Allows you to specify whether or not to load the Scene additively. See SceneManagement.LoadSceneMode for more information about the options.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadScene.html">External documentation for `SceneManager.LoadScene`</a></footer>
    public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(mode);
      SceneManager.LoadScene(sceneBuildIndex, parameters);
    }

    [ExcludeFromDocs]
    public static void LoadScene(int sceneBuildIndex)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
      SceneManager.LoadScene(sceneBuildIndex, parameters);
    }

    /// <summary>
    ///   <para>Loads the Scene by its name or index in Build Settings.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="parameters">Various parameters used to load the Scene.</param>
    /// <returns>
    ///   <para>A handle to the Scene being loaded.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadScene.html">External documentation for `SceneManager.LoadScene`</a></footer>
    public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
    {
      SceneManager.LoadSceneAsyncNameIndexInternal((string) null, sceneBuildIndex, parameters, true);
      return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
    }

    /// <summary>
    ///   <para>Loads the Scene asynchronously in the background.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">If LoadSceneMode.Single then all current Scenes will be unloaded before loading.</param>
    /// <param name="parameters">Struct that collects the various parameters into a single place except for the name and index.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html">External documentation for `SceneManager.LoadSceneAsync`</a></footer>
    public static AsyncOperation LoadSceneAsync(
      int sceneBuildIndex,
      [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(mode);
      return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
    }

    [ExcludeFromDocs]
    public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
      return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
    }

    /// <summary>
    ///   <para>Loads the Scene asynchronously in the background.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">If LoadSceneMode.Single then all current Scenes will be unloaded before loading.</param>
    /// <param name="parameters">Struct that collects the various parameters into a single place except for the name and index.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html">External documentation for `SceneManager.LoadSceneAsync`</a></footer>
    public static AsyncOperation LoadSceneAsync(
      int sceneBuildIndex,
      LoadSceneParameters parameters)
    {
      return SceneManager.LoadSceneAsyncNameIndexInternal((string) null, sceneBuildIndex, parameters, false);
    }

    /// <summary>
    ///   <para>Loads the Scene asynchronously in the background.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">If LoadSceneMode.Single then all current Scenes will be unloaded before loading.</param>
    /// <param name="parameters">Struct that collects the various parameters into a single place except for the name and index.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html">External documentation for `SceneManager.LoadSceneAsync`</a></footer>
    public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(mode);
      return SceneManager.LoadSceneAsync(sceneName, parameters);
    }

    [ExcludeFromDocs]
    public static AsyncOperation LoadSceneAsync(string sceneName)
    {
      LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
      return SceneManager.LoadSceneAsync(sceneName, parameters);
    }

    /// <summary>
    ///   <para>Loads the Scene asynchronously in the background.</para>
    /// </summary>
    /// <param name="sceneName">Name or path of the Scene to load.</param>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to load.</param>
    /// <param name="mode">If LoadSceneMode.Single then all current Scenes will be unloaded before loading.</param>
    /// <param name="parameters">Struct that collects the various parameters into a single place except for the name and index.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html">External documentation for `SceneManager.LoadSceneAsync`</a></footer>
    public static AsyncOperation LoadSceneAsync(
      string sceneName,
      LoadSceneParameters parameters)
    {
      return SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, false);
    }

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to unload.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <returns>
    ///   <para>Returns true if the Scene is unloaded.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadScene.html">External documentation for `SceneManager.UnloadScene`</a></footer>
    [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
    public static bool UnloadScene(Scene scene) => SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to unload.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <returns>
    ///   <para>Returns true if the Scene is unloaded.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadScene.html">External documentation for `SceneManager.UnloadScene`</a></footer>
    [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
    public static bool UnloadScene(int sceneBuildIndex)
    {
      bool outSuccess;
      SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out outSuccess);
      return outSuccess;
    }

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in the Build Settings to unload.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <returns>
    ///   <para>Returns true if the Scene is unloaded.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadScene.html">External documentation for `SceneManager.UnloadScene`</a></footer>
    [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
    public static bool UnloadScene(string sceneName)
    {
      bool outSuccess;
      SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out outSuccess);
      return outSuccess;
    }

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex) => SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out bool _);

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(string sceneName) => SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, UnloadSceneOptions.None, out bool _);

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(Scene scene) => SceneManager.UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(
      int sceneBuildIndex,
      UnloadSceneOptions options)
    {
      return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out bool _);
    }

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(
      string sceneName,
      UnloadSceneOptions options)
    {
      return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out bool _);
    }

    /// <summary>
    ///   <para>Destroys all GameObjects associated with the given Scene and removes the Scene from the SceneManager.</para>
    /// </summary>
    /// <param name="sceneBuildIndex">Index of the Scene in BuildSettings.</param>
    /// <param name="sceneName">Name or path of the Scene to unload.</param>
    /// <param name="scene">Scene to unload.</param>
    /// <param name="options">Scene unloading options.</param>
    /// <returns>
    ///   <para>Use the AsyncOperation to determine if the operation has completed.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/SceneManagement.SceneManager.UnloadSceneAsync.html">External documentation for `SceneManager.UnloadSceneAsync`</a></footer>
    public static AsyncOperation UnloadSceneAsync(
      Scene scene,
      UnloadSceneOptions options)
    {
      return SceneManager.UnloadSceneAsyncInternal(scene, options);
    }

    [RequiredByNativeCode]
    private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
    {
      if (SceneManager.sceneLoaded == null)
        return;
      SceneManager.sceneLoaded(scene, mode);
    }

    [RequiredByNativeCode]
    private static void Internal_SceneUnloaded(Scene scene)
    {
      if (SceneManager.sceneUnloaded == null)
        return;
      SceneManager.sceneUnloaded(scene);
    }

    [RequiredByNativeCode]
    private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
    {
      if (SceneManager.activeSceneChanged == null)
        return;
      SceneManager.activeSceneChanged(previousActiveScene, newActiveScene);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetActiveScene_Injected(out Scene ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool SetActiveScene_Injected(ref Scene scene);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSceneByPath_Injected(string scenePath, out Scene ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSceneByName_Injected(string name, out Scene ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSceneAt_Injected(int index, out Scene ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void CreateScene_Injected(
      string sceneName,
      ref CreateSceneParameters parameters,
      out Scene ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool UnloadSceneInternal_Injected(
      ref Scene scene,
      UnloadSceneOptions options);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AsyncOperation UnloadSceneAsyncInternal_Injected(
      ref Scene scene,
      UnloadSceneOptions options);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void MergeScenes_Injected(
      ref Scene sourceScene,
      ref Scene destinationScene);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene);
  }
}
