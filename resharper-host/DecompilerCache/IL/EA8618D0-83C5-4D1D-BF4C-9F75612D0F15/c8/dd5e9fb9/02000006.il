// Type: Sirenix.OdinInspector.SerializedMonoBehaviour 
// Assembly: Sirenix.Serialization, Version=3.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: EA8618D0-83C5-4D1D-BF4C-9F75612D0F15
// Location: D:\unity\project\Anivine-V2\Assets\Odin\Assemblies\Sirenix.Serialization.dll
// Sequence point data from decompiler

.class public abstract auto ansi beforefieldinit
  Sirenix.OdinInspector.SerializedMonoBehaviour
    extends [UnityEngine]UnityEngine.MonoBehaviour
    implements [UnityEngine]UnityEngine.ISerializationCallbackReceiver, Sirenix.Serialization.ISupportsPrefabSerialization
{
  .custom instance void [Sirenix.OdinInspector.Attributes]Sirenix.OdinInspector.ShowOdinSerializedPropertiesInInspectorAttribute::.ctor()
    = (01 00 00 00 )

  .field private valuetype Sirenix.Serialization.SerializationData serializationData
    .custom instance void [UnityEngine]UnityEngine.SerializeField::.ctor()
      = (01 00 00 00 )
    .custom instance void [UnityEngine]UnityEngine.HideInInspector::.ctor()
      = (01 00 00 00 )

  .method private final hidebysig virtual newslot specialname instance valuetype Sirenix.Serialization.SerializationData
    Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() cil managed
  {
    .override method instance valuetype Sirenix.Serialization.SerializationData Sirenix.Serialization.ISupportsPrefabSerialization::get_SerializationData()
    .maxstack 8

    // [21 14 - 21 36]
    IL_0000: ldarg.0      // this
    IL_0001: ldfld        valuetype Sirenix.Serialization.SerializationData Sirenix.OdinInspector.SerializedMonoBehaviour::serializationData
    IL_0006: ret

  } // end of method SerializedMonoBehaviour::Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData

  .method private final hidebysig virtual newslot specialname instance void
    Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(
      valuetype Sirenix.Serialization.SerializationData 'value'
    ) cil managed
  {
    .override method instance void Sirenix.Serialization.ISupportsPrefabSerialization::set_SerializationData(valuetype Sirenix.Serialization.SerializationData)
    .maxstack 8

    // [22 14 - 22 44]
    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: stfld        valuetype Sirenix.Serialization.SerializationData Sirenix.OdinInspector.SerializedMonoBehaviour::serializationData
    IL_0007: ret

  } // end of method SerializedMonoBehaviour::Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData

  .method private final hidebysig virtual newslot instance void
    UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() cil managed
  {
    .override method instance void [UnityEngine]UnityEngine.ISerializationCallbackReceiver::OnAfterDeserialize()
    .maxstack 8

    // [27 7 - 27 98]
    IL_0000: ldarg.0      // this
    IL_0001: ldarg.0      // this
    IL_0002: ldflda       valuetype Sirenix.Serialization.SerializationData Sirenix.OdinInspector.SerializedMonoBehaviour::serializationData
    IL_0007: ldnull
    IL_0008: call         void Sirenix.Serialization.UnitySerializationUtility::DeserializeUnityObject(class [UnityEngine]UnityEngine.Object, valuetype Sirenix.Serialization.SerializationData&, class Sirenix.Serialization.DeserializationContext)

    // [28 7 - 28 32]
    IL_000d: ldarg.0      // this
    IL_000e: callvirt     instance void Sirenix.OdinInspector.SerializedMonoBehaviour::OnAfterDeserialize()
    IL_0013: ret

  } // end of method SerializedMonoBehaviour::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize

  .method private final hidebysig virtual newslot instance void
    UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() cil managed
  {
    .override method instance void [UnityEngine]UnityEngine.ISerializationCallbackReceiver::OnBeforeSerialize()
    .maxstack 8

    // [33 7 - 33 31]
    IL_0000: ldarg.0      // this
    IL_0001: callvirt     instance void Sirenix.OdinInspector.SerializedMonoBehaviour::OnBeforeSerialize()

    // [34 7 - 34 96]
    IL_0006: ldarg.0      // this
    IL_0007: ldarg.0      // this
    IL_0008: ldflda       valuetype Sirenix.Serialization.SerializationData Sirenix.OdinInspector.SerializedMonoBehaviour::serializationData
    IL_000d: ldc.i4.0
    IL_000e: ldnull
    IL_000f: call         void Sirenix.Serialization.UnitySerializationUtility::SerializeUnityObject(class [UnityEngine]UnityEngine.Object, valuetype Sirenix.Serialization.SerializationData&, bool, class Sirenix.Serialization.SerializationContext)
    IL_0014: ret

  } // end of method SerializedMonoBehaviour::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize

  .method family hidebysig virtual newslot instance void
    OnAfterDeserialize() cil managed
  {
    .maxstack 8

    IL_0000: ret

  } // end of method SerializedMonoBehaviour::OnAfterDeserialize

  .method family hidebysig virtual newslot instance void
    OnBeforeSerialize() cil managed
  {
    .maxstack 8

    IL_0000: ret

  } // end of method SerializedMonoBehaviour::OnBeforeSerialize

  .method private hidebysig instance void
    InternalOnInspectorGUI() cil managed
  {
    .custom instance void [Sirenix.OdinInspector.Attributes]Sirenix.OdinInspector.HideInTablesAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [Sirenix.OdinInspector.Attributes]Sirenix.OdinInspector.OnInspectorGUIAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [Sirenix.OdinInspector.Attributes]Sirenix.OdinInspector.PropertyOrderAttribute::.ctor(float32)
      = (01 00 00 00 00 cf 00 00 ) // .....Ï..
      // float32(-2.147484E+09)
    .maxstack 8

    // [48 46 - 48 111]
    IL_0000: ldarg.0      // this
    IL_0001: call         void Sirenix.OdinInspector.EditorOnlyModeConfigUtility::InternalOnInspectorGUI(class [UnityEngine]UnityEngine.Object)
    IL_0006: ret

  } // end of method SerializedMonoBehaviour::InternalOnInspectorGUI

  .method family hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [UnityEngine]UnityEngine.MonoBehaviour::.ctor()
    IL_0006: ret

  } // end of method SerializedMonoBehaviour::.ctor

  .property instance valuetype Sirenix.Serialization.SerializationData 'Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData'()
  {
    .get instance valuetype Sirenix.Serialization.SerializationData Sirenix.OdinInspector.SerializedMonoBehaviour::Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData()
    .set instance void Sirenix.OdinInspector.SerializedMonoBehaviour::Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(valuetype Sirenix.Serialization.SerializationData)
  } // end of property SerializedMonoBehaviour::Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData
} // end of class Sirenix.OdinInspector.SerializedMonoBehaviour
