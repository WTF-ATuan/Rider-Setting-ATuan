// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerPrefs
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DC54541-A257-4AC7-826A-004A212A4332
// Assembly location: D:\unity\2019.4.1f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Stores and accesses player preferences between game sessions.</para>
  /// </summary>
  [NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
  public class PlayerPrefs
  {
    [NativeMethod("SetInt")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool TrySetInt(string key, int value);

    [NativeMethod("SetFloat")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool TrySetFloat(string key, float value);

    [NativeMethod("SetString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool TrySetSetString(string key, string value);

    /// <summary>
    ///   <para>Sets the value of the preference identified by key.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SetInt(string key, int value)
    {
      if (!PlayerPrefs.TrySetInt(key, value))
        throw new PlayerPrefsException("Could not store preference value");
    }

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int GetInt(string key, int defaultValue);

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    public static int GetInt(string key) => PlayerPrefs.GetInt(key, 0);

    /// <summary>
    ///   <para>Sets the value of the preference identified by key.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SetFloat(string key, float value)
    {
      if (!PlayerPrefs.TrySetFloat(key, value))
        throw new PlayerPrefsException("Could not store preference value");
    }

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern float GetFloat(string key, float defaultValue);

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    public static float GetFloat(string key) => PlayerPrefs.GetFloat(key, 0.0f);

    /// <summary>
    ///   <para>Sets the value of the preference identified by key.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void SetString(string key, string value)
    {
      if (!PlayerPrefs.TrySetSetString(key, value))
        throw new PlayerPrefsException("Could not store preference value");
    }

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string GetString(string key, string defaultValue);

    /// <summary>
    ///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    public static string GetString(string key) => PlayerPrefs.GetString(key, "");

    /// <summary>
    ///   <para>Returns true if key exists in the preferences.</para>
    /// </summary>
    /// <param name="key"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool HasKey(string key);

    /// <summary>
    ///   <para>Removes key and its corresponding value from the preferences.</para>
    /// </summary>
    /// <param name="key"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DeleteKey(string key);

    /// <summary>
    ///   <para>Removes all keys and values from the preferences. Use with caution.</para>
    /// </summary>
    [NativeMethod("DeleteAllWithCallback")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void DeleteAll();

    /// <summary>
    ///   <para>Writes all modified preferences to disk.</para>
    /// </summary>
    [NativeMethod("Sync")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void Save();

    [StaticAccessor("EditorPrefs", StaticAccessorType.DoubleColon)]
    [NativeMethod("SetInt")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void EditorPrefsSetInt(string key, int value);

    [NativeMethod("GetInt")]
    [StaticAccessor("EditorPrefs", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern int EditorPrefsGetInt(string key, int defaultValue);
  }
}
