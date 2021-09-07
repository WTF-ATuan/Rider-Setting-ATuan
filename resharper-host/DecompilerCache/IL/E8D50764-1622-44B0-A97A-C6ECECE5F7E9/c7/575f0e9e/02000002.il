// Type: UnityEngine.Playables.PlayableDirector 
// Assembly: UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E8D50764-1622-44B0-A97A-C6ECECE5F7E9
// Location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.DirectorModule.dll
// Sequence point data from decompiler

.class public auto ansi beforefieldinit
  UnityEngine.Playables.PlayableDirector
    extends [UnityEngine.CoreModule]UnityEngine.Behaviour
    implements [UnityEngine.CoreModule]UnityEngine.IExposedPropertyTable
{
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Scripting.RequiredByNativeCodeAttribute::.ctor()
    = (01 00 00 00 )
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
    = (
      01 00 1c 52 75 6e 74 69 6d 65 2f 4d 6f 6e 6f 2f // ...Runtime/Mono/
      4d 6f 6e 6f 42 65 68 61 76 69 6f 75 72 2e 68 00 // MonoBehaviour.h.
      00                                              // .
    )
    // string('Runtime/Mono/MonoBehaviour.h')
  .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
    = (
      01 00 23 4d 6f 64 75 6c 65 73 2f 44 69 72 65 63 // ..#Modules/Direc
      74 6f 72 2f 50 6c 61 79 61 62 6c 65 44 69 72 65 // tor/PlayableDire
      63 74 6f 72 2e 68 00 00                         // ctor.h..
    )
    // string('Modules/Director/PlayableDirector.h')

  .field private class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> played
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState)
      = (01 00 00 00 00 00 00 00 ) // ........
      // int32(0) // 0x00000000

  .field private class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> paused
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState)
      = (01 00 00 00 00 00 00 00 ) // ........
      // int32(0) // 0x00000000

  .field private class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> stopped
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState)
      = (01 00 00 00 00 00 00 00 ) // ........
      // int32(0) // 0x00000000

  .method public hidebysig specialname instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState
    get_state() cil managed
  {
    .maxstack 1
    .locals init (
      [0] valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState V_0
    )

    IL_0000: nop

    // [25 31 - 25 50]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState UnityEngine.Playables.PlayableDirector::GetPlayState()
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method PlayableDirector::get_state

  .method public hidebysig specialname instance void
    set_extrapolationMode(
      valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode 'value'
    ) cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [32 14 - 32 37]
    IL_0001: ldarg.0      // this
    IL_0002: ldarg.1      // 'value'
    IL_0003: call         instance void UnityEngine.Playables.PlayableDirector::SetWrapMode(valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode)
    IL_0008: nop
    IL_0009: ret

  } // end of method PlayableDirector::set_extrapolationMode

  .method public hidebysig specialname instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode
    get_extrapolationMode() cil managed
  {
    .maxstack 1
    .locals init (
      [0] valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode V_0
    )

    IL_0000: nop

    // [33 14 - 33 32]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode UnityEngine.Playables.PlayableDirector::GetWrapMode()
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method PlayableDirector::get_extrapolationMode

  .method public hidebysig specialname instance class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset
    get_playableAsset() cil managed
  {
    .maxstack 1
    .locals init (
      [0] class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset V_0
    )

    IL_0000: nop

    // [41 14 - 41 63]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance class [UnityEngine.CoreModule]UnityEngine.ScriptableObject UnityEngine.Playables.PlayableDirector::Internal_GetPlayableAsset()
    IL_0007: isinst       [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset
    IL_000c: stloc.0      // V_0
    IL_000d: br.s         IL_000f
    IL_000f: ldloc.0      // V_0
    IL_0010: ret

  } // end of method PlayableDirector::get_playableAsset

  .method public hidebysig specialname instance void
    set_playableAsset(
      class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset 'value'
    ) cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [42 14 - 42 61]
    IL_0001: ldarg.0      // this
    IL_0002: ldarg.1      // 'value'
    IL_0003: call         instance void UnityEngine.Playables.PlayableDirector::SetPlayableAsset(class [UnityEngine.CoreModule]UnityEngine.ScriptableObject)
    IL_0008: nop
    IL_0009: ret

  } // end of method PlayableDirector::set_playableAsset

  .method public hidebysig specialname instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph
    get_playableGraph() cil managed
  {
    .maxstack 1
    .locals init (
      [0] valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph V_0
    )

    IL_0000: nop

    // [48 43 - 48 64]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph UnityEngine.Playables.PlayableDirector::GetGraphHandle()
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method PlayableDirector::get_playableGraph

  .method public hidebysig specialname instance bool
    get_playOnAwake() cil managed
  {
    .maxstack 1
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [55 14 - 55 35]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance bool UnityEngine.Playables.PlayableDirector::GetPlayOnAwake()
    IL_0007: stloc.0      // V_0
    IL_0008: br.s         IL_000a
    IL_000a: ldloc.0      // V_0
    IL_000b: ret

  } // end of method PlayableDirector::get_playOnAwake

  .method public hidebysig specialname instance void
    set_playOnAwake(
      bool 'value'
    ) cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [56 14 - 56 40]
    IL_0001: ldarg.0      // this
    IL_0002: ldarg.1      // 'value'
    IL_0003: call         instance void UnityEngine.Playables.PlayableDirector::SetPlayOnAwake(bool)
    IL_0008: nop
    IL_0009: ret

  } // end of method PlayableDirector::set_playOnAwake

  .method public hidebysig instance void
    DeferredEvaluate() cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [62 39 - 62 63]
    IL_0001: ldarg.0      // this
    IL_0002: call         instance void UnityEngine.Playables.PlayableDirector::EvaluateNextFrame()
    IL_0007: nop
    IL_0008: ret

  } // end of method PlayableDirector::DeferredEvaluate

  .method public hidebysig instance void
    Play(
      class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset asset
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [71 7 - 71 67]
    IL_0001: ldarg.1      // asset
    IL_0002: ldnull
    IL_0003: call         bool [UnityEngine.CoreModule]UnityEngine.Object::op_Equality(class [UnityEngine.CoreModule]UnityEngine.Object, class [UnityEngine.CoreModule]UnityEngine.Object)
    IL_0008: stloc.0      // V_0

    IL_0009: ldloc.0      // V_0
    IL_000a: brfalse.s    IL_0017

    // [72 9 - 72 57]
    IL_000c: ldstr        "asset"
    IL_0011: newobj       instance void [mscorlib]System.ArgumentNullException::.ctor(string)
    IL_0016: throw

    // [73 7 - 73 47]
    IL_0017: ldarg.0      // this
    IL_0018: ldarg.1      // asset
    IL_0019: ldarg.0      // this
    IL_001a: call         instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode UnityEngine.Playables.PlayableDirector::get_extrapolationMode()
    IL_001f: call         instance void UnityEngine.Playables.PlayableDirector::Play(class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset, valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode)
    IL_0024: nop
    IL_0025: ret

  } // end of method PlayableDirector::Play

  .method public hidebysig instance void
    Play(
      class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset asset,
      valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode mode
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [83 7 - 83 144]
    IL_0001: ldarg.1      // asset
    IL_0002: ldnull
    IL_0003: call         bool [UnityEngine.CoreModule]UnityEngine.Object::op_Equality(class [UnityEngine.CoreModule]UnityEngine.Object, class [UnityEngine.CoreModule]UnityEngine.Object)
    IL_0008: stloc.0      // V_0

    IL_0009: ldloc.0      // V_0
    IL_000a: brfalse.s    IL_0017
    IL_000c: ldstr        "asset"
    IL_0011: newobj       instance void [mscorlib]System.ArgumentNullException::.ctor(string)
    IL_0016: throw
    IL_0017: ldarg.0      // this
    IL_0018: ldarg.1      // asset
    IL_0019: call         instance void UnityEngine.Playables.PlayableDirector::set_playableAsset(class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset)
    IL_001e: nop

    // [84 7 - 84 36]
    IL_001f: ldarg.0      // this
    IL_0020: ldarg.2      // mode
    IL_0021: call         instance void UnityEngine.Playables.PlayableDirector::set_extrapolationMode(valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode)
    IL_0026: nop

    // [85 7 - 85 18]
    IL_0027: ldarg.0      // this
    IL_0028: call         instance void UnityEngine.Playables.PlayableDirector::Play()
    IL_002d: nop
    IL_002e: ret

  } // end of method PlayableDirector::Play

  .method public hidebysig instance void
    SetGenericBinding(
      class [UnityEngine.CoreModule]UnityEngine.Object key,
      class [UnityEngine.CoreModule]UnityEngine.Object 'value'
    ) cil managed
  {
    .maxstack 8

    IL_0000: nop

    // [93 88 - 93 131]
    IL_0001: ldarg.0      // this
    IL_0002: ldarg.1      // key
    IL_0003: ldarg.2      // 'value'
    IL_0004: call         instance void UnityEngine.Playables.PlayableDirector::Internal_SetGenericBinding(class [UnityEngine.CoreModule]UnityEngine.Object, class [UnityEngine.CoreModule]UnityEngine.Object)
    IL_0009: nop
    IL_000a: ret

  } // end of method PlayableDirector::SetGenericBinding

  .method public hidebysig specialname instance void
    set_timeUpdateMode(
      valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorUpdateMode 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::set_timeUpdateMode

  .method public hidebysig specialname instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorUpdateMode
    get_timeUpdateMode() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::get_timeUpdateMode

  .method public hidebysig specialname instance void
    set_time(
      float64 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::set_time

  .method public hidebysig specialname instance float64
    get_time() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::get_time

  .method public hidebysig specialname instance void
    set_initialTime(
      float64 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::set_initialTime

  .method public hidebysig specialname instance float64
    get_initialTime() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::get_initialTime

  .method public hidebysig specialname instance float64
    get_duration() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::get_duration

  .method public hidebysig instance void
    Evaluate() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Evaluate

  .method public hidebysig instance void
    Play() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Play

  .method public hidebysig instance void
    Stop() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Stop

  .method public hidebysig instance void
    Pause() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Pause

  .method public hidebysig instance void
    Resume() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Resume

  .method public hidebysig instance void
    RebuildGraph() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::RebuildGraph

  .method public final hidebysig virtual newslot instance void
    ClearReferenceValue(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName id
    ) cil managed
  {
    .maxstack 8

    // [157 57 - 157 98]
    IL_0000: ldarg.0      // this
    IL_0001: ldarga.s     id
    IL_0003: call         instance void UnityEngine.Playables.PlayableDirector::ClearReferenceValue_Injected(valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName&)
    IL_0008: ret

  } // end of method PlayableDirector::ClearReferenceValue

  .method public final hidebysig virtual newslot instance void
    SetReferenceValue(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName id,
      class [UnityEngine.CoreModule]UnityEngine.Object 'value'
    ) cil managed
  {
    .maxstack 8

    // [164 81 - 164 127]
    IL_0000: ldarg.0      // this
    IL_0001: ldarga.s     id
    IL_0003: ldarg.2      // 'value'
    IL_0004: call         instance void UnityEngine.Playables.PlayableDirector::SetReferenceValue_Injected(valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName&, class [UnityEngine.CoreModule]UnityEngine.Object)
    IL_0009: ret

  } // end of method PlayableDirector::SetReferenceValue

  .method public final hidebysig virtual newslot instance class [UnityEngine.CoreModule]UnityEngine.Object
    GetReferenceValue(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName id,
      [out] bool& idValid
    ) cil managed
  {
    .maxstack 8

    // [166 87 - 166 139]
    IL_0000: ldarg.0      // this
    IL_0001: ldarga.s     id
    IL_0003: ldarg.2      // idValid
    IL_0004: call         instance class [UnityEngine.CoreModule]UnityEngine.Object UnityEngine.Playables.PlayableDirector::GetReferenceValue_Injected(valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName&, bool&)
    IL_0009: ret

  } // end of method PlayableDirector::GetReferenceValue

  .method public hidebysig instance class [UnityEngine.CoreModule]UnityEngine.Object
    GetGenericBinding(
      class [UnityEngine.CoreModule]UnityEngine.Object key
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor(string)
      = (
        01 00 0d 47 65 74 42 69 6e 64 69 6e 67 46 6f 72 // ...GetBindingFor
        00 00                                           // ..
      )
      // string('GetBindingFor')
    // Can't find a body
  } // end of method PlayableDirector::GetGenericBinding

  .method public hidebysig instance void
    ClearGenericBinding(
      class [UnityEngine.CoreModule]UnityEngine.Object key
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor(string)
      = (
        01 00 0f 43 6c 65 61 72 42 69 6e 64 69 6e 67 46 // ...ClearBindingF
        6f 72 00 00                                     // or..
      )
      // string('ClearBindingFor')
    // Can't find a body
  } // end of method PlayableDirector::ClearGenericBinding

  .method public hidebysig instance void
    RebindPlayableGraphOutputs() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::RebindPlayableGraphOutputs

  .method assembly hidebysig instance void
    ProcessPendingGraphChanges() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::ProcessPendingGraphChanges

  .method assembly hidebysig instance bool
    HasGenericBinding(
      class [UnityEngine.CoreModule]UnityEngine.Object key
    ) cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeMethodAttribute::.ctor(string)
      = (01 00 0a 48 61 73 42 69 6e 64 69 6e 67 00 00 ) // ...HasBinding..
      // string('HasBinding')
    // Can't find a body
  } // end of method PlayableDirector::HasGenericBinding

  .method private hidebysig instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState
    GetPlayState() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::GetPlayState

  .method private hidebysig instance void
    SetWrapMode(
      valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode mode
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::SetWrapMode

  .method private hidebysig instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode
    GetWrapMode() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::GetWrapMode

  .method private hidebysig instance void
    EvaluateNextFrame() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::EvaluateNextFrame

  .method private hidebysig instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph
    GetGraphHandle() cil managed
  {
    .maxstack 2
    .locals init (
      [0] valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph 'ret'
    )

    // [212 7 - 212 44]
    IL_0000: ldarg.0      // this
    IL_0001: ldloca.s     'ret'
    IL_0003: call         instance void UnityEngine.Playables.PlayableDirector::GetGraphHandle_Injected(valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph&)

    // [213 7 - 213 18]
    IL_0008: ldloc.0      // 'ret'
    IL_0009: ret

  } // end of method PlayableDirector::GetGraphHandle

  .method private hidebysig instance void
    SetPlayOnAwake(
      bool on
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::SetPlayOnAwake

  .method private hidebysig instance bool
    GetPlayOnAwake() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::GetPlayOnAwake

  .method private hidebysig instance void
    Internal_SetGenericBinding(
      class [UnityEngine.CoreModule]UnityEngine.Object key,
      class [UnityEngine.CoreModule]UnityEngine.Object 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Internal_SetGenericBinding

  .method private hidebysig instance void
    SetPlayableAsset(
      class [UnityEngine.CoreModule]UnityEngine.ScriptableObject asset
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::SetPlayableAsset

  .method private hidebysig instance class [UnityEngine.CoreModule]UnityEngine.ScriptableObject
    Internal_GetPlayableAsset() cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::Internal_GetPlayableAsset

  .method public hidebysig specialname instance void
    add_played(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::add_played

  .method public hidebysig specialname instance void
    remove_played(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Remove(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::remove_played

  .method public hidebysig specialname instance void
    add_paused(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::add_paused

  .method public hidebysig specialname instance void
    remove_paused(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Remove(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::remove_paused

  .method public hidebysig specialname instance void
    add_stopped(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::add_stopped

  .method public hidebysig specialname instance void
    remove_stopped(
      class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> action,
      [1] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> comparand,
      [2] class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> V_2
    )

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
    IL_0006: stloc.0      // action
    // start of loop, entry point: IL_0007
      IL_0007: ldloc.0      // action
      IL_0008: stloc.1      // comparand
      IL_0009: ldloc.1      // comparand
      IL_000a: ldarg.1      // 'value'
      IL_000b: call         class [mscorlib]System.Delegate [mscorlib]System.Delegate::Remove(class [mscorlib]System.Delegate, class [mscorlib]System.Delegate)
      IL_0010: castclass    class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>
      IL_0015: stloc.2      // V_2
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
      IL_001c: ldloc.2      // V_2
      IL_001d: ldloc.1      // comparand
      IL_001e: call         !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/ [mscorlib]System.Threading.Interlocked::CompareExchange<class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>>(!!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/&, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/, !!0/*class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>*/)
      IL_0023: stloc.0      // action
      IL_0024: ldloc.0      // action
      IL_0025: ldloc.1      // comparand
      IL_0026: bne.un.s     IL_0007
    // end of loop
    IL_0028: ret

  } // end of method PlayableDirector::remove_stopped

  .method assembly hidebysig static void
    ResetFrameTiming() cil managed internalcall
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.NativeHeaderAttribute::.ctor(string)
      = (
        01 00 27 52 75 6e 74 69 6d 65 2f 44 69 72 65 63 // ..'Runtime/Direc
        74 6f 72 2f 43 6f 72 65 2f 44 69 72 65 63 74 6f // tor/Core/Directo
        72 4d 61 6e 61 67 65 72 2e 68 00 00             // rManager.h..
      )
      // string('Runtime/Director/Core/DirectorManager.h')
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.StaticAccessorAttribute::.ctor(string, valuetype [UnityEngine.SharedInternalsModule]UnityEngine.Bindings.StaticAccessorType)
      = (
        01 00 14 47 65 74 44 69 72 65 63 74 6f 72 4d 61 // ...GetDirectorMa
        6e 61 67 65 72 28 29 00 00 00 00 00 00          // nager()......
      )
      // string('GetDirectorManager()')
      // int32(0) // 0x00000000
    // Can't find a body
  } // end of method PlayableDirector::ResetFrameTiming

  .method private hidebysig instance void
    SendOnPlayableDirectorPlay() cil managed
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Scripting.RequiredByNativeCodeAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [245 7 - 245 31]
    IL_0001: ldarg.0      // this
    IL_0002: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
    IL_0007: ldnull
    IL_0008: cgt.un
    IL_000a: stloc.0      // V_0

    IL_000b: ldloc.0      // V_0
    IL_000c: brfalse.s    IL_001b

    // [247 7 - 247 24]
    IL_000e: ldarg.0      // this
    IL_000f: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::played
    IL_0014: ldarg.0      // this
    IL_0015: callvirt     instance void class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>::Invoke(!0/*class UnityEngine.Playables.PlayableDirector*/)
    IL_001a: nop

    IL_001b: ret

  } // end of method PlayableDirector::SendOnPlayableDirectorPlay

  .method private hidebysig instance void
    SendOnPlayableDirectorPause() cil managed
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Scripting.RequiredByNativeCodeAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [253 7 - 253 31]
    IL_0001: ldarg.0      // this
    IL_0002: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
    IL_0007: ldnull
    IL_0008: cgt.un
    IL_000a: stloc.0      // V_0

    IL_000b: ldloc.0      // V_0
    IL_000c: brfalse.s    IL_001b

    // [255 7 - 255 24]
    IL_000e: ldarg.0      // this
    IL_000f: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::paused
    IL_0014: ldarg.0      // this
    IL_0015: callvirt     instance void class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>::Invoke(!0/*class UnityEngine.Playables.PlayableDirector*/)
    IL_001a: nop

    IL_001b: ret

  } // end of method PlayableDirector::SendOnPlayableDirectorPause

  .method private hidebysig instance void
    SendOnPlayableDirectorStop() cil managed
  {
    .custom instance void [UnityEngine.SharedInternalsModule]UnityEngine.Scripting.RequiredByNativeCodeAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 2
    .locals init (
      [0] bool V_0
    )

    IL_0000: nop

    // [261 7 - 261 32]
    IL_0001: ldarg.0      // this
    IL_0002: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
    IL_0007: ldnull
    IL_0008: cgt.un
    IL_000a: stloc.0      // V_0

    IL_000b: ldloc.0      // V_0
    IL_000c: brfalse.s    IL_001b

    // [263 7 - 263 25]
    IL_000e: ldarg.0      // this
    IL_000f: ldfld        class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> UnityEngine.Playables.PlayableDirector::stopped
    IL_0014: ldarg.0      // this
    IL_0015: callvirt     instance void class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>::Invoke(!0/*class UnityEngine.Playables.PlayableDirector*/)
    IL_001a: nop

    IL_001b: ret

  } // end of method PlayableDirector::SendOnPlayableDirectorStop

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [UnityEngine.CoreModule]UnityEngine.Behaviour::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method PlayableDirector::.ctor

  .method private final hidebysig virtual newslot instance void
    ClearReferenceValue_Injected(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName& id
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::ClearReferenceValue_Injected

  .method private final hidebysig virtual newslot instance void
    SetReferenceValue_Injected(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName& id,
      class [UnityEngine.CoreModule]UnityEngine.Object 'value'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::SetReferenceValue_Injected

  .method private final hidebysig virtual newslot instance class [UnityEngine.CoreModule]UnityEngine.Object
    GetReferenceValue_Injected(
      valuetype [UnityEngine.CoreModule]UnityEngine.PropertyName& id,
      [out] bool& idValid
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::GetReferenceValue_Injected

  .method private hidebysig instance void
    GetGraphHandle_Injected(
      [out] valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph& 'ret'
    ) cil managed internalcall
  {
    // Can't find a body
  } // end of method PlayableDirector::GetGraphHandle_Injected

  .event class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> played
  {
    .addon instance void UnityEngine.Playables.PlayableDirector::add_played(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
    .removeon instance void UnityEngine.Playables.PlayableDirector::remove_played(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
  } // end of event PlayableDirector::played

  .event class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> paused
  {
    .addon instance void UnityEngine.Playables.PlayableDirector::add_paused(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
    .removeon instance void UnityEngine.Playables.PlayableDirector::remove_paused(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
  } // end of event PlayableDirector::paused

  .event class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector> stopped
  {
    .addon instance void UnityEngine.Playables.PlayableDirector::add_stopped(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
    .removeon instance void UnityEngine.Playables.PlayableDirector::remove_stopped(class [mscorlib]System.Action`1<class UnityEngine.Playables.PlayableDirector>)
  } // end of event PlayableDirector::stopped

  .property instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState state()
  {
    .get instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayState UnityEngine.Playables.PlayableDirector::get_state()
  } // end of property PlayableDirector::state

  .property instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode extrapolationMode()
  {
    .get instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode UnityEngine.Playables.PlayableDirector::get_extrapolationMode()
    .set instance void UnityEngine.Playables.PlayableDirector::set_extrapolationMode(valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorWrapMode)
  } // end of property PlayableDirector::extrapolationMode

  .property instance class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset playableAsset()
  {
    .get instance class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset UnityEngine.Playables.PlayableDirector::get_playableAsset()
    .set instance void UnityEngine.Playables.PlayableDirector::set_playableAsset(class [UnityEngine.CoreModule]UnityEngine.Playables.PlayableAsset)
  } // end of property PlayableDirector::playableAsset

  .property instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph playableGraph()
  {
    .get instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.PlayableGraph UnityEngine.Playables.PlayableDirector::get_playableGraph()
  } // end of property PlayableDirector::playableGraph

  .property instance bool playOnAwake()
  {
    .get instance bool UnityEngine.Playables.PlayableDirector::get_playOnAwake()
    .set instance void UnityEngine.Playables.PlayableDirector::set_playOnAwake(bool)
  } // end of property PlayableDirector::playOnAwake

  .property instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorUpdateMode timeUpdateMode()
  {
    .get instance valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorUpdateMode UnityEngine.Playables.PlayableDirector::get_timeUpdateMode()
    .set instance void UnityEngine.Playables.PlayableDirector::set_timeUpdateMode(valuetype [UnityEngine.CoreModule]UnityEngine.Playables.DirectorUpdateMode)
  } // end of property PlayableDirector::timeUpdateMode

  .property instance float64 time()
  {
    .get instance float64 UnityEngine.Playables.PlayableDirector::get_time()
    .set instance void UnityEngine.Playables.PlayableDirector::set_time(float64)
  } // end of property PlayableDirector::time

  .property instance float64 initialTime()
  {
    .get instance float64 UnityEngine.Playables.PlayableDirector::get_initialTime()
    .set instance void UnityEngine.Playables.PlayableDirector::set_initialTime(float64)
  } // end of property PlayableDirector::initialTime

  .property instance float64 duration()
  {
    .get instance float64 UnityEngine.Playables.PlayableDirector::get_duration()
  } // end of property PlayableDirector::duration
} // end of class UnityEngine.Playables.PlayableDirector
