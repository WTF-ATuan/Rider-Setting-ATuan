// Decompiled with JetBrains decompiler
// Type: UnityEngine.ISerializationCallbackReceiver
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using UnityEngine.Scripting;

namespace UnityEngine
{
  [RequiredByNativeCode]
  public interface ISerializationCallbackReceiver
  {
    /// <summary>
    ///   <para>Implement this method to receive a callback before Unity serializes your object.</para>
    /// </summary>
    [RequiredByNativeCode]
    void OnBeforeSerialize();

    /// <summary>
    ///   <para>Implement this method to receive a callback after Unity deserializes your object.</para>
    /// </summary>
    [RequiredByNativeCode]
    void OnAfterDeserialize();
  }
}
