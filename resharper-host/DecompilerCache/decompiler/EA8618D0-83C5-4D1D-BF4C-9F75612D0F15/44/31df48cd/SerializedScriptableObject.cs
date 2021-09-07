// Decompiled with JetBrains decompiler
// Type: Sirenix.OdinInspector.SerializedScriptableObject
// Assembly: Sirenix.Serialization, Version=3.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: EA8618D0-83C5-4D1D-BF4C-9F75612D0F15
// Assembly location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Plugins\Odin\Assemblies\Sirenix.Serialization.dll

using Sirenix.Serialization;
using UnityEngine;

namespace Sirenix.OdinInspector
{
  [ShowOdinSerializedPropertiesInInspector]
  public abstract class SerializedScriptableObject : ScriptableObject, ISerializationCallbackReceiver
  {
    [SerializeField]
    [HideInInspector]
    private SerializationData serializationData;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
      UnitySerializationUtility.DeserializeUnityObject((Object) this, ref this.serializationData);
      this.OnAfterDeserialize();
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    {
      this.OnBeforeSerialize();
      UnitySerializationUtility.SerializeUnityObject((Object) this, ref this.serializationData);
    }

    protected virtual void OnAfterDeserialize()
    {
    }

    protected virtual void OnBeforeSerialize()
    {
    }

    [HideInTables]
    [OnInspectorGUI]
    [PropertyOrder(-2.147484E+09f)]
    private void InternalOnInspectorGUI() => EditorOnlyModeConfigUtility.InternalOnInspectorGUI((Object) this);
  }
}
