// Type: UnityEngine.Object 
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
// Sequence point data from decompiler

.class public sequential ansi beforefieldinit
  UnityEngine.Object
    extends [mscorlib]System.Object
{
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
    = (
      01 00 1e 52 75 6e 74 69 6d 65 2f 47 61 6d 65 43 // ...Runtime/GameC
      6f 64 65 2f 43 6c 6f 6e 65 4f 62 6a 65 63 74 2e // ode/CloneObject.
      68 00 00                                        // h..
    )
    // string('Runtime/GameCode/CloneObject.h')
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
    = (
      01 00 35 52 75 6e 74 69 6d 65 2f 45 78 70 6f 72 // ..5Runtime/Expor
      74 2f 53 63 72 69 70 74 69 6e 67 2f 55 6e 69 74 // t/Scripting/Unit
      79 45 6e 67 69 6e 65 4f 62 6a 65 63 74 2e 62 69 // yEngineObject.bi
      6e 64 69 6e 67 73 2e 68 00 00                   // ndings.h..
    )
    // string('Runtime/Export/Scripting/UnityEngineObject.bindings.h')
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Scripting.RequiredByNativeCodeAttribute::.ctor()
    = (
      01 00 01 00 54 02 0d 47 65 6e 65 72 61 74 65 50 // ....T..GenerateP
      72 6f 78 79 01                                  // roxy.
    )
    // property bool 'GenerateProxy' = bool(true)
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
    = (
      01 00 23 52 75 6e 74 69 6d 65 2f 53 63 65 6e 65 // ..#Runtime/Scene
      4d 61 6e 61 67 65 72 2f 53 63 65 6e 65 4d 61 6e // Manager/SceneMan
      61 67 65 72 2e 68 00 00                         // ager.h..
    )
    // string('Runtime/SceneManager/SceneManager.h')

  .field private native int m_CachedPtr

  .field private int32 m_InstanceID

  .field private string m_UnityRuntimeErrorString

  .field assembly static int32 OffsetOfInstanceIDInCPlusPlusObject

  .field private static literal string objectIsNullMessage = "The Object you want to instantiate is null."

  .field private static literal string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."

  .method public hidebysig instance int32
    GetInstanceID() cil managed
  {
    .custom instance void [mscorlib]System.Security.SecuritySafeCriticalAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 1
    .locals init (
      [0] int32 V_0
    )

    IL_0000: nop

    // [43 7 - 43 39]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance void UnityEngine.Object::EnsureRunningOnMainThread()
    IL_0007: nop

    // [44 7 - 44 32]
    IL_0008: ldarg.0      // this
    IL_0009: ldfld        int32 UnityEngine.Object::m_InstanceID
    IL_000e: stloc.0      // V_0
    IL_000f: br.s         IL_0011
    IL_0011: ldloc.0      // V_0
    IL_0012: ret

  } // end of method Object::GetInstanceID

  .method public hidebysig virtual instance int32
    GetHashCode() cil managed
  {
    .maxstack 1
    .locals init (
      [0] int32 V_0
    )

    IL_0000: nop

    // [47 42 - 47 59]
    IL_0001: ldarg.0      // this
    IL_0002: ldfld        int32 UnityEngine.Object::m_InstanceID
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method Object::GetHashCode

  .method public hidebysig virtual instance bool
    Equals(
      object other
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] class UnityEngine.Object rhs,
      [1] bool V_1,
      [2] bool V_2
    )

    IL_0000: nop

    // [51 7 - 51 35]
    IL_0001: ldarg.1      // other
    IL_0002: isinst       UnityEngine.Object
    IL_0007: stloc.0      // rhs

    // [52 7 - 52 116]
    IL_0008: ldloc.0      // rhs
    IL_0009: ldnull
    IL_000a: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_000f: brfalse.s    IL_0022

    IL_0011: ldarg.1      // other
    IL_0012: brfalse.s    IL_0022
    IL_0014: ldarg.1      // other
    IL_0015: isinst       UnityEngine.Object
    IL_001a: ldnull
    IL_001b: cgt.un
    IL_001d: ldc.i4.0
    IL_001e: ceq
    IL_0020: br.s         IL_0023
    IL_0022: ldc.i4.0
    IL_0023: stloc.1      // V_1
    IL_0024: ldloc.1      // V_1
    IL_0025: brfalse.s    IL_002b
    IL_0027: ldc.i4.0
    IL_0028: stloc.2      // V_2
    IL_0029: br.s         IL_0035
    IL_002b: ldarg.0      // this
    IL_002c: ldloc.0      // rhs
    IL_002d: call         bool UnityEngine.Object::CompareBaseObjects(class UnityEngine.Object, class UnityEngine.Object)
    IL_0032: stloc.2      // V_2
    IL_0033: br.s         IL_0035
    IL_0035: ldloc.2      // V_2
    IL_0036: ret

  } // end of method Object::Equals

  .method public hidebysig static specialname bool
    op_Implicit(
      class UnityEngine.Object exists
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [55 60 - 55 109]
    IL_0001: ldarg.0      // exists
    IL_0002: ldnull
    IL_0003: call         bool UnityEngine.Object::CompareBaseObjects(class UnityEngine.Object, class UnityEngine.Object)
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000b: stloc.0      // V_0
    IL_000c: br.s         IL_000e
    IL_000e: ldloc.0      // V_0
    IL_000f: ret

  } // end of method Object::op_Implicit

  .method private hidebysig static bool
    CompareBaseObjects(
      class UnityEngine.Object lhs,
      class UnityEngine.Object rhs
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool flag1,
      [1] bool flag2,
      [2] bool V_2,
      [3] bool V_3,
      [4] bool V_4,
      [5] bool V_5
    )

    IL_0000: nop

    // [59 7 - 59 40]
    IL_0001: ldarg.0      // lhs
    IL_0002: ldnull
    IL_0003: ceq
    IL_0005: stloc.0      // flag1

    // [60 7 - 60 40]
    IL_0006: ldarg.1      // rhs
    IL_0007: ldnull
    IL_0008: ceq
    IL_000a: stloc.1      // flag2

    // [61 7 - 61 25]
    IL_000b: ldloc.1      // flag2
    IL_000c: ldloc.0      // flag1
    IL_000d: and
    IL_000e: stloc.2      // V_2

    IL_000f: ldloc.2      // V_2
    IL_0010: brfalse.s    IL_0016

    // [62 9 - 62 21]
    IL_0012: ldc.i4.1
    IL_0013: stloc.3      // V_3

    IL_0014: br.s         IL_004d

    // [63 7 - 63 17]
    IL_0016: ldloc.1      // flag2
    IL_0017: stloc.s      V_4

    IL_0019: ldloc.s      V_4
    IL_001b: brfalse.s    IL_0029

    // [64 9 - 64 49]
    IL_001d: ldarg.0      // lhs
    IL_001e: call         bool UnityEngine.Object::IsNativeObjectAlive(class UnityEngine.Object)
    IL_0023: ldc.i4.0
    IL_0024: ceq
    IL_0026: stloc.3      // V_3

    IL_0027: br.s         IL_004d

    // [65 7 - 65 94]
    IL_0029: ldloc.0      // flag1
    IL_002a: stloc.s      V_5

    IL_002c: ldloc.s      V_5
    IL_002e: brfalse.s    IL_003c
    IL_0030: ldarg.1      // rhs
    IL_0031: call         bool UnityEngine.Object::IsNativeObjectAlive(class UnityEngine.Object)
    IL_0036: ldc.i4.0
    IL_0037: ceq
    IL_0039: stloc.3      // V_3
    IL_003a: br.s         IL_004d
    IL_003c: ldarg.0      // lhs
    IL_003d: ldfld        int32 UnityEngine.Object::m_InstanceID
    IL_0042: ldarg.1      // rhs
    IL_0043: ldfld        int32 UnityEngine.Object::m_InstanceID
    IL_0048: ceq
    IL_004a: stloc.3      // V_3
    IL_004b: br.s         IL_004d
    IL_004d: ldloc.3      // V_3
    IL_004e: ret

  } // end of method Object::CompareBaseObjects

  .method private hidebysig instance void
    EnsureRunningOnMainThread() cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [70 7 - 70 47]
    IL_0001: call         bool UnityEngine.Object::CurrentThreadIsMainThread()
    IL_0006: ldc.i4.0
    IL_0007: ceq
    IL_0009: stloc.0      // V_0

    IL_000a: ldloc.0      // V_0
    IL_000b: brfalse.s    IL_0018

    // [71 9 - 71 114]
    IL_000d: ldstr        "EnsureRunningOnMainThread can only be called from the main thread"
    IL_0012: newobj       instance void [mscorlib]System.InvalidOperationException::.ctor(string)
    IL_0017: throw

    IL_0018: ret

  } // end of method Object::EnsureRunningOnMainThread

  .method private hidebysig static bool
    IsNativeObjectAlive(
      class UnityEngine.Object o
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0,
      [1] bool V_1,
      [2] bool V_2
    )

    IL_0000: nop

    // [76 7 - 76 43]
    IL_0001: ldarg.0      // o
    IL_0002: callvirt     instance native int UnityEngine.Object::GetCachedPtr()
    IL_0007: ldsfld       native int [mscorlib]System.IntPtr::Zero
    IL_000c: call         bool [mscorlib]System.IntPtr::op_Inequality(native int, native int)
    IL_0011: stloc.0      // V_0

    IL_0012: ldloc.0      // V_0
    IL_0013: brfalse.s    IL_0019

    // [77 9 - 77 21]
    IL_0015: ldc.i4.1
    IL_0016: stloc.1      // V_1

    IL_0017: br.s         IL_0043

    // [78 7 - 78 123]
    IL_0019: ldarg.0      // o
    IL_001a: isinst       UnityEngine.MonoBehaviour
    IL_001f: brtrue.s     IL_002c

    IL_0021: ldarg.0      // o
    IL_0022: isinst       UnityEngine.ScriptableObject
    IL_0027: ldnull
    IL_0028: cgt.un
    IL_002a: br.s         IL_002d
    IL_002c: ldc.i4.1
    IL_002d: stloc.2      // V_2
    IL_002e: ldloc.2      // V_2
    IL_002f: brfalse.s    IL_0035
    IL_0031: ldc.i4.0
    IL_0032: stloc.1      // V_1
    IL_0033: br.s         IL_0043
    IL_0035: ldarg.0      // o
    IL_0036: callvirt     instance int32 UnityEngine.Object::GetInstanceID()
    IL_003b: call         bool UnityEngine.Object::DoesObjectWithInstanceIDExist(int32)
    IL_0040: stloc.1      // V_1
    IL_0041: br.s         IL_0043
    IL_0043: ldloc.1      // V_1
    IL_0044: ret

  } // end of method Object::IsNativeObjectAlive

  .method private hidebysig instance native int
    GetCachedPtr() cil managed
  {
    .maxstack 1
    .locals init (
      [0] native int V_0
    )

    IL_0000: nop

    // [81 38 - 81 54]
    IL_0001: ldarg.0      // this
    IL_0002: ldfld        native int UnityEngine.Object::m_CachedPtr
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method Object::GetCachedPtr

  .method public hidebysig specialname instance string
    get_name() cil managed
  {
    .maxstack 1
    .locals init (
      [0] string V_0
    )

    IL_0000: nop

    // [89 14 - 89 34]
    IL_0001: ldarg.0      // this
    IL_0002: call         string UnityEngine.Object::GetName(class UnityEngine.Object)
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method Object::get_name

  .method public hidebysig specialname instance void
    set_name(
      string 'value'
    ) cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [90 14 - 90 41]
    IL_0001: ldarg.0      // this
    IL_0002: ldarg.1      // 'value'
    IL_0003: call         void UnityEngine.Object::SetName(class UnityEngine.Object, string)
    IL_0008: nop
    IL_0009: ret

  } // end of method Object::set_name

  .method public hidebysig static class UnityEngine.Object
    Instantiate(
      class UnityEngine.Object original,
      valuetype UnityEngine.Vector3 position,
      valuetype UnityEngine.Quaternion rotation
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 03 00 00 00 00 00 ) // ........
      // int32(3) // 0x00000003
    .maxstack 3
    .locals init (
      [0] class UnityEngine.Object 'object',
      [1] bool V_1,
      [2] bool V_2,
      [3] class UnityEngine.Object V_3
    )

    IL_0000: nop

    // [108 7 - 108 97]
    IL_0001: ldarg.0      // original
    IL_0002: ldstr        "The Object you want to instantiate is null."
    IL_0007: call         void UnityEngine.Object::CheckNullArgument(object, string)
    IL_000c: nop

    // [109 7 - 109 40]
    IL_000d: ldarg.0      // original
    IL_000e: isinst       UnityEngine.ScriptableObject
    IL_0013: ldnull
    IL_0014: cgt.un
    IL_0016: stloc.1      // V_1

    IL_0017: ldloc.1      // V_1
    IL_0018: brfalse.s    IL_0025

    // [110 9 - 110 107]
    IL_001a: ldstr        "Cannot instantiate a ScriptableObject with a position and rotation"
    IL_001f: newobj       instance void [mscorlib]System.ArgumentException::.ctor(string)
    IL_0024: throw

    // [111 7 - 111 87]
    IL_0025: ldarg.0      // original
    IL_0026: ldarg.1      // position
    IL_0027: ldarg.2      // rotation
    IL_0028: call         class UnityEngine.Object UnityEngine.Object::Internal_InstantiateSingle(class UnityEngine.Object, valuetype UnityEngine.Vector3, valuetype UnityEngine.Quaternion)
    IL_002d: stloc.0      // 'object'

    // [112 7 - 112 220]
    IL_002e: ldloc.0      // 'object'
    IL_002f: ldnull
    IL_0030: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_0035: stloc.2      // V_2

    IL_0036: ldloc.2      // V_2
    IL_0037: brfalse.s    IL_0044
    IL_0039: ldstr        "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."
    IL_003e: newobj       instance void UnityEngine.UnityException::.ctor(string)
    IL_0043: throw
    IL_0044: ldloc.0      // 'object'
    IL_0045: stloc.3      // V_3
    IL_0046: br.s         IL_0048
    IL_0048: ldloc.3      // V_3
    IL_0049: ret

  } // end of method Object::Instantiate

  .method public hidebysig static class UnityEngine.Object
    Instantiate(
      class UnityEngine.Object original,
      valuetype UnityEngine.Vector3 position,
      valuetype UnityEngine.Quaternion rotation,
      class UnityEngine.Transform parent
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 03 00 00 00 00 00 ) // ........
      // int32(3) // 0x00000003
    .maxstack 4
    .locals init (
      [0] class UnityEngine.Object 'object',
      [1] bool V_1,
      [2] class UnityEngine.Object V_2,
      [3] bool V_3
    )

    IL_0000: nop

    // [134 7 - 134 44]
    IL_0001: ldarg.3      // parent
    IL_0002: ldnull
    IL_0003: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_0008: stloc.1      // V_1

    IL_0009: ldloc.1      // V_1
    IL_000a: brfalse.s    IL_0017

    // [135 9 - 135 65]
    IL_000c: ldarg.0      // original
    IL_000d: ldarg.1      // position
    IL_000e: ldarg.2      // rotation
    IL_000f: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object, valuetype UnityEngine.Vector3, valuetype UnityEngine.Quaternion)
    IL_0014: stloc.2      // V_2

    IL_0015: br.s         IL_0047

    // [136 7 - 136 97]
    IL_0017: ldarg.0      // original
    IL_0018: ldstr        "The Object you want to instantiate is null."
    IL_001d: call         void UnityEngine.Object::CheckNullArgument(object, string)
    IL_0022: nop

    // [137 7 - 137 105]
    IL_0023: ldarg.0      // original
    IL_0024: ldarg.3      // parent
    IL_0025: ldarg.1      // position
    IL_0026: ldarg.2      // rotation
    IL_0027: call         class UnityEngine.Object UnityEngine.Object::Internal_InstantiateSingleWithParent(class UnityEngine.Object, class UnityEngine.Transform, valuetype UnityEngine.Vector3, valuetype UnityEngine.Quaternion)
    IL_002c: stloc.0      // 'object'

    // [138 7 - 138 220]
    IL_002d: ldloc.0      // 'object'
    IL_002e: ldnull
    IL_002f: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_0034: stloc.3      // V_3

    IL_0035: ldloc.3      // V_3
    IL_0036: brfalse.s    IL_0043
    IL_0038: ldstr        "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."
    IL_003d: newobj       instance void UnityEngine.UnityException::.ctor(string)
    IL_0042: throw
    IL_0043: ldloc.0      // 'object'
    IL_0044: stloc.2      // V_2
    IL_0045: br.s         IL_0047
    IL_0047: ldloc.2      // V_2
    IL_0048: ret

  } // end of method Object::Instantiate

  .method public hidebysig static class UnityEngine.Object
    Instantiate(
      class UnityEngine.Object original
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 03 00 00 00 00 00 ) // ........
      // int32(3) // 0x00000003
    .maxstack 2
    .locals init (
      [0] class UnityEngine.Object 'object',
      [1] bool V_1,
      [2] class UnityEngine.Object V_2
    )

    IL_0000: nop

    // [156 7 - 156 97]
    IL_0001: ldarg.0      // original
    IL_0002: ldstr        "The Object you want to instantiate is null."
    IL_0007: call         void UnityEngine.Object::CheckNullArgument(object, string)
    IL_000c: nop

    // [157 7 - 157 61]
    IL_000d: ldarg.0      // original
    IL_000e: call         class UnityEngine.Object UnityEngine.Object::Internal_CloneSingle(class UnityEngine.Object)
    IL_0013: stloc.0      // 'object'

    // [158 7 - 158 220]
    IL_0014: ldloc.0      // 'object'
    IL_0015: ldnull
    IL_0016: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_001b: stloc.1      // V_1

    IL_001c: ldloc.1      // V_1
    IL_001d: brfalse.s    IL_002a
    IL_001f: ldstr        "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."
    IL_0024: newobj       instance void UnityEngine.UnityException::.ctor(string)
    IL_0029: throw
    IL_002a: ldloc.0      // 'object'
    IL_002b: stloc.2      // V_2
    IL_002c: br.s         IL_002e
    IL_002e: ldloc.2      // V_2
    IL_002f: ret

  } // end of method Object::Instantiate

  .method public hidebysig static class UnityEngine.Object
    Instantiate(
      class UnityEngine.Object original,
      class UnityEngine.Transform parent
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 03 00 00 00 00 00 ) // ........
      // int32(3) // 0x00000003
    .maxstack 3
    .locals init (
      [0] class UnityEngine.Object V_0
    )

    IL_0000: nop

    // [174 76 - 174 119]
    IL_0001: ldarg.0      // original
    IL_0002: ldarg.1      // parent
    IL_0003: ldc.i4.0
    IL_0004: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object, class UnityEngine.Transform, bool)
    IL_0009: stloc.0      // V_0
    IL_000a: br.s         IL_000c
    IL_000c: ldloc.0      // V_0
    IL_000d: ret

  } // end of method Object::Instantiate

  .method public hidebysig static class UnityEngine.Object
    Instantiate(
      class UnityEngine.Object original,
      class UnityEngine.Transform parent,
      bool instantiateInWorldSpace
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 03 00 00 00 00 00 ) // ........
      // int32(3) // 0x00000003
    .maxstack 3
    .locals init (
      [0] class UnityEngine.Object 'object',
      [1] bool V_1,
      [2] class UnityEngine.Object V_2,
      [3] bool V_3
    )

    IL_0000: nop

    // [194 7 - 194 44]
    IL_0001: ldarg.1      // parent
    IL_0002: ldnull
    IL_0003: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_0008: stloc.1      // V_1

    IL_0009: ldloc.1      // V_1
    IL_000a: brfalse.s    IL_0015

    // [195 9 - 195 45]
    IL_000c: ldarg.0      // original
    IL_000d: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object)
    IL_0012: stloc.2      // V_2

    IL_0013: br.s         IL_0044

    // [196 7 - 196 97]
    IL_0015: ldarg.0      // original
    IL_0016: ldstr        "The Object you want to instantiate is null."
    IL_001b: call         void UnityEngine.Object::CheckNullArgument(object, string)
    IL_0020: nop

    // [197 7 - 197 104]
    IL_0021: ldarg.0      // original
    IL_0022: ldarg.1      // parent
    IL_0023: ldarg.2      // instantiateInWorldSpace
    IL_0024: call         class UnityEngine.Object UnityEngine.Object::Internal_CloneSingleWithParent(class UnityEngine.Object, class UnityEngine.Transform, bool)
    IL_0029: stloc.0      // 'object'

    // [198 7 - 198 220]
    IL_002a: ldloc.0      // 'object'
    IL_002b: ldnull
    IL_002c: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_0031: stloc.3      // V_3

    IL_0032: ldloc.3      // V_3
    IL_0033: brfalse.s    IL_0040
    IL_0035: ldstr        "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."
    IL_003a: newobj       instance void UnityEngine.UnityException::.ctor(string)
    IL_003f: throw
    IL_0040: ldloc.0      // 'object'
    IL_0041: stloc.2      // V_2
    IL_0042: br.s         IL_0044
    IL_0044: ldloc.2      // V_2
    IL_0045: ret

  } // end of method Object::Instantiate

  .method public hidebysig static !!0/*T*/
    Instantiate<(class UnityEngine.Object) T>(
      !!0/*T*/ original
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] !!0/*T*/ obj,
      [1] bool V_1,
      [2] !!0/*T*/ V_2
    )

    IL_0000: nop

    // [203 7 - 203 97]
    IL_0001: ldarg.0      // original
    IL_0002: box          !!0/*T*/
    IL_0007: ldstr        "The Object you want to instantiate is null."
    IL_000c: call         void UnityEngine.Object::CheckNullArgument(object, string)
    IL_0011: nop

    // [204 7 - 204 65]
    IL_0012: ldarg.0      // original
    IL_0013: box          !!0/*T*/
    IL_0018: call         class UnityEngine.Object UnityEngine.Object::Internal_CloneSingle(class UnityEngine.Object)
    IL_001d: unbox.any    !!0/*T*/
    IL_0022: stloc.0      // obj

    // [205 7 - 205 221]
    IL_0023: ldloc.0      // obj
    IL_0024: box          !!0/*T*/
    IL_0029: ldnull
    IL_002a: call         bool UnityEngine.Object::op_Equality(class UnityEngine.Object, class UnityEngine.Object)
    IL_002f: stloc.1      // V_1

    IL_0030: ldloc.1      // V_1
    IL_0031: brfalse.s    IL_003e
    IL_0033: ldstr        "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."
    IL_0038: newobj       instance void UnityEngine.UnityException::.ctor(string)
    IL_003d: throw
    IL_003e: ldloc.0      // obj
    IL_003f: stloc.2      // V_2
    IL_0040: br.s         IL_0042
    IL_0042: ldloc.2      // V_2
    IL_0043: ret

  } // end of method Object::Instantiate

  .method public hidebysig static !!0/*T*/
    Instantiate<(class UnityEngine.Object) T>(
      !!0/*T*/ original,
      valuetype UnityEngine.Vector3 position,
      valuetype UnityEngine.Quaternion rotation
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] !!0/*T*/ V_0
    )

    IL_0000: nop

    // [208 107 - 208 168]
    IL_0001: ldarg.0      // original
    IL_0002: box          !!0/*T*/
    IL_0007: ldarg.1      // position
    IL_0008: ldarg.2      // rotation
    IL_0009: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object, valuetype UnityEngine.Vector3, valuetype UnityEngine.Quaternion)
    IL_000e: unbox.any    !!0/*T*/
    IL_0013: stloc.0      // V_0
    IL_0014: br.s         IL_0016
    IL_0016: ldloc.0      // V_0
    IL_0017: ret

  } // end of method Object::Instantiate

  .method public hidebysig static !!0/*T*/
    Instantiate<(class UnityEngine.Object) T>(
      !!0/*T*/ original,
      valuetype UnityEngine.Vector3 position,
      valuetype UnityEngine.Quaternion rotation,
      class UnityEngine.Transform parent
    ) cil managed
  {
    .maxstack 4
    .locals init (
      [0] !!0/*T*/ V_0
    )

    IL_0000: nop

    // [217 7 - 217 84]
    IL_0001: ldarg.0      // original
    IL_0002: box          !!0/*T*/
    IL_0007: ldarg.1      // position
    IL_0008: ldarg.2      // rotation
    IL_0009: ldarg.3      // parent
    IL_000a: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object, valuetype UnityEngine.Vector3, valuetype UnityEngine.Quaternion, class UnityEngine.Transform)
    IL_000f: unbox.any    !!0/*T*/
    IL_0014: stloc.0      // V_0
    IL_0015: br.s         IL_0017
    IL_0017: ldloc.0      // V_0
    IL_0018: ret

  } // end of method Object::Instantiate

  .method public hidebysig static !!0/*T*/
    Instantiate<(class UnityEngine.Object) T>(
      !!0/*T*/ original,
      class UnityEngine.Transform parent
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] !!0/*T*/ V_0
    )

    IL_0000: nop

    // [220 86 - 220 132]
    IL_0001: ldarg.0      // original
    IL_0002: ldarg.1      // parent
    IL_0003: ldc.i4.0
    IL_0004: call         !!0/*T*/ UnityEngine.Object::Instantiate<!!0/*T*/>(!!0/*T*/, class UnityEngine.Transform, bool)
    IL_0009: stloc.0      // V_0
    IL_000a: br.s         IL_000c
    IL_000c: ldloc.0      // V_0
    IL_000d: ret

  } // end of method Object::Instantiate

  .method public hidebysig static !!0/*T*/
    Instantiate<(class UnityEngine.Object) T>(
      !!0/*T*/ original,
      class UnityEngine.Transform parent,
      bool worldPositionStays
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] !!0/*T*/ V_0
    )

    IL_0000: nop

    // [222 111 - 222 180]
    IL_0001: ldarg.0      // original
    IL_0002: box          !!0/*T*/
    IL_0007: ldarg.1      // parent
    IL_0008: ldarg.2      // worldPositionStays
    IL_0009: call         class UnityEngine.Object UnityEngine.Object::Instantiate(class UnityEngine.Object, class UnityEngine.Transform, bool)
    IL_000e: unbox.any    !!0/*T*/
    IL_0013: stloc.0      // V_0
    IL_0014: br.s         IL_0016
    IL_0016: ldloc.0      // V_0
    IL_0017: ret

  } // end of method Object::Instantiate

  .method public hidebysig static void
    Destroy(
      class UnityEngine.Object obj,
      float32 t
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor()
      = (
        01 00 03 00 54 0e 04 4e 61 6d 65 25 53 63 72 69 // ....T..Name%Scri
        70 74 69 6e 67 3a 3a 44 65 73 74 72 6f 79 4f 62 // pting::DestroyOb
        6a 65 63 74 46 72 6f 6d 53 63 72 69 70 74 69 6e // jectFromScriptin
        67 54 02 0e 49 73 46 72 65 65 46 75 6e 63 74 69 // gT..IsFreeFuncti
        6f 6e 01 54 02 0f 54 68 72 6f 77 73 45 78 63 65 // on.T..ThrowsExce
        70 74 69 6f 6e 01                               // ption.
      )
      // property string 'Name' = string('Scripting::DestroyObjectFromScripting')
      // property bool 'IsFreeFunction' = bool(true)
      // property bool 'ThrowsException' = bool(true)
    .param [2]
      .custom instance void UnityEngine.Internal.DefaultValueAttribute::.ctor(string)
        = (01 00 04 30 2e 30 46 00 00 ) // ...0.0F..
        // string('0.0F')
    // Can't find a body
  } // end of method Object::Destroy

  .method public hidebysig static void
    Destroy(
      class UnityEngine.Object obj
    ) cil managed
  {
    .custom instance void UnityEngine.Internal.ExcludeFromDocsAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 2
    .locals init (
      [0] float32 t
    )

    IL_0000: nop

    // [243 7 - 243 21]
    IL_0001: ldc.r4       0.0
    IL_0006: stloc.0      // t

    // [244 7 - 244 29]
    IL_0007: ldarg.0      // obj
    IL_0008: ldloc.0      // t
    IL_0009: call         void UnityEngine.Object::Destroy(class UnityEngine.Object, float32)
    IL_000e: nop
    IL_000f: ret

  } // end of method Object::Destroy

  .method public hidebysig static void
    DestroyImmediate(
      class UnityEngine.Object obj,
      bool allowDestroyingAssets
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor()
      = (
        01 00 03 00 54 0e 04 4e 61 6d 65 2e 53 63 72 69 // ....T..Name.Scri
        70 74 69 6e 67 3a 3a 44 65 73 74 72 6f 79 4f 62 // pting::DestroyOb
        6a 65 63 74 46 72 6f 6d 53 63 72 69 70 74 69 6e // jectFromScriptin
        67 49 6d 6d 65 64 69 61 74 65 54 02 0e 49 73 46 // gImmediateT..IsF
        72 65 65 46 75 6e 63 74 69 6f 6e 01 54 02 0f 54 // reeFunction.T..T
        68 72 6f 77 73 45 78 63 65 70 74 69 6f 6e 01    // hrowsException.
      )
      // property string 'Name' = string('Scripting::DestroyObjectFromScriptingImmediate')
      // property bool 'IsFreeFunction' = bool(true)
      // property bool 'ThrowsException' = bool(true)
    .param [2]
      .custom instance void UnityEngine.Internal.DefaultValueAttribute::.ctor(string)
        = (01 00 05 66 61 6c 73 65 00 00 ) // ...false..
        // string('false')
    // Can't find a body
  } // end of method Object::DestroyImmediate

  .method public hidebysig static void
    DestroyImmediate(
      class UnityEngine.Object obj
    ) cil managed
  {
    .custom instance void UnityEngine.Internal.ExcludeFromDocsAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 2
    .locals init (
      [0] bool allowDestroyingAssets
    )

    IL_0000: nop

    // [266 7 - 266 41]
    IL_0001: ldc.i4.0
    IL_0002: stloc.0      // allowDestroyingAssets

    // [267 7 - 267 58]
    IL_0003: ldarg.0      // obj
    IL_0004: ldloc.0      // allowDestroyingAssets
    IL_0005: call         void UnityEngine.Object::DestroyImmediate(class UnityEngine.Object, bool)
    IL_000a: nop
    IL_000b: ret

  } // end of method Object::DestroyImmediate

  .method public hidebysig static class UnityEngine.Object[]
    FindObjectsOfType(
      class [mscorlib]System.Type 'type'
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 2c 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..,UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 46 69 // jectBindings::Fi
        6e 64 4f 62 6a 65 63 74 73 4f 66 54 79 70 65 00 // ndObjectsOfType.
        00                                              // .
      )
      // string('UnityEngineObjectBindings::FindObjectsOfType')
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 02 00 00 00 00 00 ) // ........
      // int32(2) // 0x00000002
    // Can't find a body
  } // end of method Object::FindObjectsOfType

  .method public hidebysig static void
    DontDestroyOnLoad(
      class UnityEngine.Object target
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 23 47 65 74 53 63 65 6e 65 4d 61 6e 61 67 // ..#GetSceneManag
        65 72 28 29 2e 44 6f 6e 74 44 65 73 74 72 6f 79 // er().DontDestroy
        4f 6e 4c 6f 61 64 00 00                         // OnLoad..
      )
      // string('GetSceneManager().DontDestroyOnLoad')
    // Can't find a body
  } // end of method Object::DontDestroyOnLoad

  .method public hidebysig specialname instance valuetype UnityEngine.HideFlags
    get_hideFlags() cil managed internalcall
  {
    // Can't find a body
  } // end of method Object::get_hideFlags

  .method public hidebysig specialname instance void
    set_hideFlags(
      valuetype UnityEngine.HideFlags 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method Object::set_hideFlags

  .method public hidebysig static void
    DestroyObject(
      class UnityEngine.Object obj,
      float32 t
    ) cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string)
      = (
        01 00 1b 75 73 65 20 4f 62 6a 65 63 74 2e 44 65 // ...use Object.De
        73 74 72 6f 79 20 69 6e 73 74 65 61 64 2e 00 00 // stroy instead...
      )
      // string('use Object.Destroy instead.')
    .param [2]
      .custom instance void UnityEngine.Internal.DefaultValueAttribute::.ctor(string)
        = (01 00 04 30 2e 30 46 00 00 ) // ...0.0F..
        // string('0.0F')
    .maxstack 8

    IL_0000: nop

    // [300 85 - 300 107]
    IL_0001: ldarg.0      // obj
    IL_0002: ldarg.1      // t
    IL_0003: call         void UnityEngine.Object::Destroy(class UnityEngine.Object, float32)
    IL_0008: nop
    IL_0009: ret

  } // end of method Object::DestroyObject

  .method public hidebysig static void
    DestroyObject(
      class UnityEngine.Object obj
    ) cil managed
  {
    .custom instance void UnityEngine.Internal.ExcludeFromDocsAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string)
      = (
        01 00 1b 75 73 65 20 4f 62 6a 65 63 74 2e 44 65 // ...use Object.De
        73 74 72 6f 79 20 69 6e 73 74 65 61 64 2e 00 00 // stroy instead...
      )
      // string('use Object.Destroy instead.')
    .maxstack 2
    .locals init (
      [0] float32 t
    )

    IL_0000: nop

    // [306 7 - 306 21]
    IL_0001: ldc.r4       0.0
    IL_0006: stloc.0      // t

    // [307 7 - 307 29]
    IL_0007: ldarg.0      // obj
    IL_0008: ldloc.0      // t
    IL_0009: call         void UnityEngine.Object::Destroy(class UnityEngine.Object, float32)
    IL_000e: nop
    IL_000f: ret

  } // end of method Object::DestroyObject

  .method public hidebysig static class UnityEngine.Object[]
    FindSceneObjectsOfType(
      class [mscorlib]System.Type 'type'
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 2c 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..,UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 46 69 // jectBindings::Fi
        6e 64 4f 62 6a 65 63 74 73 4f 66 54 79 70 65 00 // ndObjectsOfType.
        00                                              // .
      )
      // string('UnityEngineObjectBindings::FindObjectsOfType')
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string)
      = (
        01 00 2d 77 61 72 6e 69 6e 67 20 75 73 65 20 4f // ..-warning use O
        62 6a 65 63 74 2e 46 69 6e 64 4f 62 6a 65 63 74 // bject.FindObject
        73 4f 66 54 79 70 65 20 69 6e 73 74 65 61 64 2e // sOfType instead.
        00 00                                           // ..
      )
      // string('warning use Object.FindObjectsOfType instead.')
    // Can't find a body
  } // end of method Object::FindSceneObjectsOfType

  .method public hidebysig static class UnityEngine.Object[]
    FindObjectsOfTypeIncludingAssets(
      class [mscorlib]System.Type 'type'
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 3b 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..;UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 46 69 // jectBindings::Fi
        6e 64 4f 62 6a 65 63 74 73 4f 66 54 79 70 65 49 // ndObjectsOfTypeI
        6e 63 6c 75 64 69 6e 67 41 73 73 65 74 73 00 00 // ncludingAssets..
      )
      // string('UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets')
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string)
      = (
        01 00 2b 75 73 65 20 52 65 73 6f 75 72 63 65 73 // ..+use Resources
        2e 46 69 6e 64 4f 62 6a 65 63 74 73 4f 66 54 79 // .FindObjectsOfTy
        70 65 41 6c 6c 20 69 6e 73 74 65 61 64 2e 00 00 // peAll instead...
      )
      // string('use Resources.FindObjectsOfTypeAll instead.')
    // Can't find a body
  } // end of method Object::FindObjectsOfTypeIncludingAssets

  .method public hidebysig static !!0/*T*/[]
    FindObjectsOfType<(class UnityEngine.Object) T>() cil managed
  {
    .maxstack 1
    .locals init (
      [0] !!0/*T*/[] V_0
    )

    IL_0000: nop

    // [328 66 - 328 131]
    IL_0001: ldtoken      !!0/*T*/
    IL_0006: call         class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_000b: call         class UnityEngine.Object[] UnityEngine.Object::FindObjectsOfType(class [mscorlib]System.Type)
    IL_0010: call         !!0/*T*/[] UnityEngine.Resources::ConvertObjects<!!0/*T*/>(class UnityEngine.Object[])
    IL_0015: stloc.0      // V_0
    IL_0016: br.s         IL_0018
    IL_0018: ldloc.0      // V_0
    IL_0019: ret

  } // end of method Object::FindObjectsOfType

  .method public hidebysig static !!0/*T*/
    FindObjectOfType<(class UnityEngine.Object) T>() cil managed
  {
    .maxstack 1
    .locals init (
      [0] !!0/*T*/ V_0
    )

    IL_0000: nop

    // [330 63 - 330 102]
    IL_0001: ldtoken      !!0/*T*/
    IL_0006: call         class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_000b: call         class UnityEngine.Object UnityEngine.Object::FindObjectOfType(class [mscorlib]System.Type)
    IL_0010: unbox.any    !!0/*T*/
    IL_0015: stloc.0      // V_0
    IL_0016: br.s         IL_0018
    IL_0018: ldloc.0      // V_0
    IL_0019: ret

  } // end of method Object::FindObjectOfType

  .method public hidebysig static class UnityEngine.Object[]
    FindObjectsOfTypeAll(
      class [mscorlib]System.Type 'type'
    ) cil managed
  {
    .custom instance void [mscorlib]System.ObsoleteAttribute::.ctor(string)
      = (
        01 00 31 50 6c 65 61 73 65 20 75 73 65 20 52 65 // ..1Please use Re
        73 6f 75 72 63 65 73 2e 46 69 6e 64 4f 62 6a 65 // sources.FindObje
        63 74 73 4f 66 54 79 70 65 41 6c 6c 20 69 6e 73 // ctsOfTypeAll ins
        74 65 61 64 00 00                               // tead..
      )
      // string('Please use Resources.FindObjectsOfTypeAll instead')
    .maxstack 1
    .locals init (
      [0] class UnityEngine.Object[] V_0
    )

    IL_0000: nop

    // [341 70 - 341 106]
    IL_0001: ldarg.0      // 'type'
    IL_0002: call         class UnityEngine.Object[] UnityEngine.Resources::FindObjectsOfTypeAll(class [mscorlib]System.Type)
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method Object::FindObjectsOfTypeAll

  .method private hidebysig static void
    CheckNullArgument(
      object arg,
      string message
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [345 7 - 345 23]
    IL_0001: ldarg.0      // arg
    IL_0002: ldnull
    IL_0003: ceq
    IL_0005: stloc.0      // V_0

    IL_0006: ldloc.0      // V_0
    IL_0007: brfalse.s    IL_0010

    // [346 9 - 346 46]
    IL_0009: ldarg.1      // message
    IL_000a: newobj       instance void [mscorlib]System.ArgumentException::.ctor(string)
    IL_000f: throw

    IL_0010: ret

  } // end of method Object::CheckNullArgument

  .method public hidebysig static class UnityEngine.Object
    FindObjectOfType(
      class [mscorlib]System.Type 'type'
    ) cil managed
  {
    .custom instance void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(valuetype UnityEngineInternal.TypeInferenceRules)
      = (01 00 00 00 00 00 00 00 ) // ........
      // int32(0) // 0x00000000
    .maxstack 2
    .locals init (
      [0] class UnityEngine.Object[] objectsOfType,
      [1] bool V_1,
      [2] class UnityEngine.Object V_2
    )

    IL_0000: nop

    // [360 7 - 360 62]
    IL_0001: ldarg.0      // 'type'
    IL_0002: call         class UnityEngine.Object[] UnityEngine.Object::FindObjectsOfType(class [mscorlib]System.Type)
    IL_0007: stloc.0      // objectsOfType

    // [361 7 - 361 82]
    IL_0008: ldloc.0      // objectsOfType
    IL_0009: ldlen
    IL_000a: ldc.i4.0
    IL_000b: cgt.un
    IL_000d: stloc.1      // V_1

    IL_000e: ldloc.1      // V_1
    IL_000f: brfalse.s    IL_0017
    IL_0011: ldloc.0      // objectsOfType
    IL_0012: ldc.i4.0
    IL_0013: ldelem.ref
    IL_0014: stloc.2      // V_2
    IL_0015: br.s         IL_001b
    IL_0017: ldnull
    IL_0018: stloc.2      // V_2
    IL_0019: br.s         IL_001b
    IL_001b: ldloc.2      // V_2
    IL_001c: ret

  } // end of method Object::FindObjectOfType

  .method public hidebysig virtual instance string
    ToString() cil managed
  {
    .maxstack 1
    .locals init (
      [0] string V_0
    )

    IL_0000: nop

    // [371 42 - 371 63]
    IL_0001: ldarg.0      // this
    IL_0002: call         string UnityEngine.Object::ToString(class UnityEngine.Object)
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method Object::ToString

  .method public hidebysig static specialname bool
    op_Equality(
      class UnityEngine.Object x,
      class UnityEngine.Object y
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [373 59 - 373 90]
    IL_0001: ldarg.0      // x
    IL_0002: ldarg.1      // y
    IL_0003: call         bool UnityEngine.Object::CompareBaseObjects(class UnityEngine.Object, class UnityEngine.Object)
    IL_0008: stloc.0      // V_0
    IL_0009: br.s         IL_000b
    IL_000b: ldloc.0      // V_0
    IL_000c: ret

  } // end of method Object::op_Equality

  .method public hidebysig static specialname bool
    op_Inequality(
      class UnityEngine.Object x,
      class UnityEngine.Object y
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [375 59 - 375 91]
    IL_0001: ldarg.0      // x
    IL_0002: ldarg.1      // y
    IL_0003: call         bool UnityEngine.Object::CompareBaseObjects(class UnityEngine.Object, class UnityEngine.Object)
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000b: stloc.0      // V_0
    IL_000c: br.s         IL_000e
    IL_000e: ldloc.0      // V_0
    IL_000f: ret

  } // end of method Object::op_Inequality

  .method private hidebysig static int32
    GetOffsetOfInstanceIDInCPlusPlusObject() cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor()
      = (
        01 00 03 00 54 0e 04 4e 61 6d 65 23 4f 62 6a 65 // ....T..Name#Obje
        63 74 3a 3a 47 65 74 4f 66 66 73 65 74 4f 66 49 // ct::GetOffsetOfI
        6e 73 74 61 6e 63 65 49 64 4d 65 6d 62 65 72 54 // nstanceIdMemberT
        02 0e 49 73 46 72 65 65 46 75 6e 63 74 69 6f 6e // ..IsFreeFunction
        01 54 02 0c 49 73 54 68 72 65 61 64 53 61 66 65 // .T..IsThreadSafe
        01                                              // .
      )
      // property string 'Name' = string('Object::GetOffsetOfInstanceIdMember')
      // property bool 'IsFreeFunction' = bool(true)
      // property bool 'IsThreadSafe' = bool(true)
    // Can't find a body
  } // end of method Object::GetOffsetOfInstanceIDInCPlusPlusObject

  .method private hidebysig static bool
    CurrentThreadIsMainThread() cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor()
      = (
        01 00 03 00 54 0e 04 4e 61 6d 65 19 43 75 72 72 // ....T..Name.Curr
        65 6e 74 54 68 72 65 61 64 49 73 4d 61 69 6e 54 // entThreadIsMainT
        68 72 65 61 64 54 02 0e 49 73 46 72 65 65 46 75 // hreadT..IsFreeFu
        6e 63 74 69 6f 6e 01 54 02 0c 49 73 54 68 72 65 // nction.T..IsThre
        61 64 53 61 66 65 01                            // adSafe.
      )
      // property string 'Name' = string('CurrentThreadIsMainThread')
      // property bool 'IsFreeFunction' = bool(true)
      // property bool 'IsThreadSafe' = bool(true)
    // Can't find a body
  } // end of method Object::CurrentThreadIsMainThread

  .method private hidebysig static class UnityEngine.Object
    Internal_CloneSingle(
      class UnityEngine.Object data
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (01 00 0b 43 6c 6f 6e 65 4f 62 6a 65 63 74 00 00 ) // ...CloneObject..
      // string('CloneObject')
    // Can't find a body
  } // end of method Object::Internal_CloneSingle

  .method private hidebysig static class UnityEngine.Object
    Internal_CloneSingleWithParent(
      class UnityEngine.Object data,
      class UnityEngine.Transform parent,
      bool worldPositionStays
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (01 00 0b 43 6c 6f 6e 65 4f 62 6a 65 63 74 00 00 ) // ...CloneObject..
      // string('CloneObject')
    // Can't find a body
  } // end of method Object::Internal_CloneSingleWithParent

  .method private hidebysig static class UnityEngine.Object
    Internal_InstantiateSingle(
      class UnityEngine.Object data,
      valuetype UnityEngine.Vector3 pos,
      valuetype UnityEngine.Quaternion rot
    ) cil managed
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 11 49 6e 73 74 61 6e 74 69 61 74 65 4f 62 // ...InstantiateOb
        6a 65 63 74 00 00                               // ject..
      )
      // string('InstantiateObject')
    .maxstack 8

    // [402 7 - 402 81]
    IL_0000: ldarg.0      // data
    IL_0001: ldarga.s     pos
    IL_0003: ldarga.s     rot
    IL_0005: call         class UnityEngine.Object UnityEngine.Object::Internal_InstantiateSingle_Injected(class UnityEngine.Object, valuetype UnityEngine.Vector3&, valuetype UnityEngine.Quaternion&)
    IL_000a: ret

  } // end of method Object::Internal_InstantiateSingle

  .method private hidebysig static class UnityEngine.Object
    Internal_InstantiateSingleWithParent(
      class UnityEngine.Object data,
      class UnityEngine.Transform parent,
      valuetype UnityEngine.Vector3 pos,
      valuetype UnityEngine.Quaternion rot
    ) cil managed
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 11 49 6e 73 74 61 6e 74 69 61 74 65 4f 62 // ...InstantiateOb
        6a 65 63 74 00 00                               // ject..
      )
      // string('InstantiateObject')
    .maxstack 8

    // [412 7 - 412 99]
    IL_0000: ldarg.0      // data
    IL_0001: ldarg.1      // parent
    IL_0002: ldarga.s     pos
    IL_0004: ldarga.s     rot
    IL_0006: call         class UnityEngine.Object UnityEngine.Object::Internal_InstantiateSingleWithParent_Injected(class UnityEngine.Object, class UnityEngine.Transform, valuetype UnityEngine.Vector3&, valuetype UnityEngine.Quaternion&)
    IL_000b: ret

  } // end of method Object::Internal_InstantiateSingleWithParent

  .method private hidebysig static string
    ToString(
      class UnityEngine.Object obj
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 23 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..#UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 54 6f // jectBindings::To
        53 74 72 69 6e 67 00 00                         // String..
      )
      // string('UnityEngineObjectBindings::ToString')
    // Can't find a body
  } // end of method Object::ToString

  .method private hidebysig static string
    GetName(
      class UnityEngine.Object obj
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 22 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // .."UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 47 65 // jectBindings::Ge
        74 4e 61 6d 65 00 00                            // tName..
      )
      // string('UnityEngineObjectBindings::GetName')
    // Can't find a body
  } // end of method Object::GetName

  .method assembly hidebysig static bool
    IsPersistent(
      class UnityEngine.Object obj
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 27 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..'UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 49 73 // jectBindings::Is
        50 65 72 73 69 73 74 65 6e 74 00 00             // Persistent..
      )
      // string('UnityEngineObjectBindings::IsPersistent')
    // Can't find a body
  } // end of method Object::IsPersistent

  .method private hidebysig static void
    SetName(
      class UnityEngine.Object obj,
      string name
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 22 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // .."UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 53 65 // jectBindings::Se
        74 4e 61 6d 65 00 00                            // tName..
      )
      // string('UnityEngineObjectBindings::SetName')
    // Can't find a body
  } // end of method Object::SetName

  .method assembly hidebysig static bool
    DoesObjectWithInstanceIDExist(
      int32 instanceID
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor()
      = (
        01 00 03 00 54 0e 04 4e 61 6d 65 38 55 6e 69 74 // ....T..Name8Unit
        79 45 6e 67 69 6e 65 4f 62 6a 65 63 74 42 69 6e // yEngineObjectBin
        64 69 6e 67 73 3a 3a 44 6f 65 73 4f 62 6a 65 63 // dings::DoesObjec
        74 57 69 74 68 49 6e 73 74 61 6e 63 65 49 44 45 // tWithInstanceIDE
        78 69 73 74 54 02 0e 49 73 46 72 65 65 46 75 6e // xistT..IsFreeFun
        63 74 69 6f 6e 01 54 02 0c 49 73 54 68 72 65 61 // ction.T..IsThrea
        64 53 61 66 65 01                               // dSafe.
      )
      // property string 'Name' = string('UnityEngineObjectBindings::DoesObjectWithInstanceIDExist')
      // property bool 'IsFreeFunction' = bool(true)
      // property bool 'IsThreadSafe' = bool(true)
    // Can't find a body
  } // end of method Object::DoesObjectWithInstanceIDExist

  .method assembly hidebysig static class UnityEngine.Object
    FindObjectFromInstanceID(
      int32 instanceID
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 33 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..3UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 46 69 // jectBindings::Fi
        6e 64 4f 62 6a 65 63 74 46 72 6f 6d 49 6e 73 74 // ndObjectFromInst
        61 6e 63 65 49 44 00 00                         // anceID..
      )
      // string('UnityEngineObjectBindings::FindObjectFromInstanceID')
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.VisibleToOtherModulesAttribute::.ctor()
      = (01 00 00 00 )
    // Can't find a body
  } // end of method Object::FindObjectFromInstanceID

  .method assembly hidebysig static class UnityEngine.Object
    ForceLoadFromInstanceID(
      int32 instanceID
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.VisibleToOtherModulesAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.FreeFunctionAttribute::.ctor(string)
      = (
        01 00 32 55 6e 69 74 79 45 6e 67 69 6e 65 4f 62 // ..2UnityEngineOb
        6a 65 63 74 42 69 6e 64 69 6e 67 73 3a 3a 46 6f // jectBindings::Fo
        72 63 65 4c 6f 61 64 46 72 6f 6d 49 6e 73 74 61 // rceLoadFromInsta
        6e 63 65 49 44 00 00                            // nceID..
      )
      // string('UnityEngineObjectBindings::ForceLoadFromInstanceID')
    // Can't find a body
  } // end of method Object::ForceLoadFromInstanceID

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [mscorlib]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Object::.ctor

  .method private hidebysig static specialname rtspecialname void
    .cctor() cil managed
  {
    .maxstack 8

    // [32 5 - 32 66]
    IL_0000: ldc.i4.m1
    IL_0001: stsfld       int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
    IL_0006: ret

  } // end of method Object::.cctor

  .method private hidebysig static class UnityEngine.Object
    Internal_InstantiateSingle_Injected(
      class UnityEngine.Object data,
      valuetype UnityEngine.Vector3& pos,
      valuetype UnityEngine.Quaternion& rot
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method Object::Internal_InstantiateSingle_Injected

  .method private hidebysig static class UnityEngine.Object
    Internal_InstantiateSingleWithParent_Injected(
      class UnityEngine.Object data,
      class UnityEngine.Transform parent,
      valuetype UnityEngine.Vector3& pos,
      valuetype UnityEngine.Quaternion& rot
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method Object::Internal_InstantiateSingleWithParent_Injected

  .property instance string name()
  {
    .get instance string UnityEngine.Object::get_name()
    .set instance void UnityEngine.Object::set_name(string)
  } // end of property Object::name

  .property instance valuetype UnityEngine.HideFlags hideFlags()
  {
    .get instance valuetype UnityEngine.HideFlags UnityEngine.Object::get_hideFlags()
    .set instance void UnityEngine.Object::set_hideFlags(valuetype UnityEngine.HideFlags)
  } // end of property Object::hideFlags
} // end of class UnityEngine.Object
