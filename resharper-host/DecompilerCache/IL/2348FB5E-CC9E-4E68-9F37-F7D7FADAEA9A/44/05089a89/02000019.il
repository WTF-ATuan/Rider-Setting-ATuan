// Type: DG.Tweening.Tween 
// Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2348FB5E-CC9E-4E68-9F37-F7D7FADAEA9A
// Location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Plugins\Demigiant\DOTween\DOTween.dll
// Sequence point data from decompiler

.class public abstract auto ansi beforefieldinit
  DG.Tweening.Tween
    extends DG.Tweening.Core.ABSSequentiable
{

  .field public float32 timeScale

  .field public bool isBackwards

  .field public object id

  .field public string stringId

  .field public int32 intId

  .field public object target

  .field assembly valuetype DG.Tweening.UpdateType updateType

  .field assembly bool isIndependentUpdate

  .field public class DG.Tweening.TweenCallback onPlay

  .field public class DG.Tweening.TweenCallback onPause

  .field public class DG.Tweening.TweenCallback onRewind

  .field public class DG.Tweening.TweenCallback onUpdate

  .field public class DG.Tweening.TweenCallback onStepComplete

  .field public class DG.Tweening.TweenCallback onComplete

  .field public class DG.Tweening.TweenCallback onKill

  .field public class DG.Tweening.TweenCallback`1<int32> onWaypointChange

  .field assembly bool isFrom

  .field assembly bool isBlendable

  .field assembly bool isRecyclable

  .field assembly bool isSpeedBased

  .field assembly bool autoKill

  .field assembly float32 duration

  .field assembly int32 loops

  .field assembly valuetype DG.Tweening.LoopType loopType

  .field assembly float32 delay

  .field private bool '<isRelative>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

  .field assembly valuetype DG.Tweening.Ease easeType

  .field assembly class DG.Tweening.EaseFunction customEase

  .field public float32 easeOvershootOrAmplitude

  .field public float32 easePeriod

  .field public string debugTargetId

  .field assembly class [mscorlib]System.Type typeofT1

  .field assembly class [mscorlib]System.Type typeofT2

  .field assembly class [mscorlib]System.Type typeofTPlugOptions

  .field private bool '<active>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

  .field assembly bool isSequenced

  .field assembly class DG.Tweening.Sequence sequenceParent

  .field assembly int32 activeId

  .field assembly valuetype DG.Tweening.Core.Enums.SpecialStartupMode specialStartupMode

  .field assembly bool creationLocked

  .field assembly bool startupDone

  .field private bool '<playedOnce>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

  .field private float32 '<position>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

  .field assembly float32 fullDuration

  .field assembly int32 completedLoops

  .field assembly bool isPlaying

  .field assembly bool isComplete

  .field assembly float32 elapsedDelay

  .field assembly bool delayComplete

  .field assembly int32 miscInt

  .method public hidebysig specialname instance bool
    get_isRelative() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        bool DG.Tweening.Tween::'<isRelative>k__BackingField'
    IL_0006: ret

  } // end of method Tween::get_isRelative

  .method assembly hidebysig specialname instance void
    set_isRelative(
      bool 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: stfld        bool DG.Tweening.Tween::'<isRelative>k__BackingField'
    IL_0007: ret

  } // end of method Tween::set_isRelative

  .method public hidebysig specialname instance bool
    get_active() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        bool DG.Tweening.Tween::'<active>k__BackingField'
    IL_0006: ret

  } // end of method Tween::get_active

  .method assembly hidebysig specialname instance void
    set_active(
      bool 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: stfld        bool DG.Tweening.Tween::'<active>k__BackingField'
    IL_0007: ret

  } // end of method Tween::set_active

  .method public hidebysig specialname instance float32
    get_fullPosition() cil managed
  {
    .maxstack 8

    // [95 14 - 95 28]
    IL_0000: ldarg.0      // this
    IL_0001: ldc.i4.1
    IL_0002: call         float32 DG.Tweening.TweenExtensions::Elapsed(class DG.Tweening.Tween, bool)
    IL_0007: ret

  } // end of method Tween::get_fullPosition

  .method public hidebysig specialname instance void
    set_fullPosition(
      float32 'value'
    ) cil managed
  {
    .maxstack 8

    // [96 14 - 96 46]
    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: ldarg.0      // this
    IL_0003: ldfld        bool DG.Tweening.Tween::isPlaying
    IL_0008: call         void DG.Tweening.TweenExtensions::Goto(class DG.Tweening.Tween, float32, bool)
    IL_000d: ret

  } // end of method Tween::set_fullPosition

  .method public hidebysig specialname instance bool
    get_hasLoops() cil managed
  {
    .maxstack 8

    // [100 29 - 100 63]
    IL_0000: ldarg.0      // this
    IL_0001: ldfld        int32 DG.Tweening.Tween::loops
    IL_0006: ldc.i4.m1
    IL_0007: beq.s        IL_0013

    IL_0009: ldarg.0      // this
    IL_000a: ldfld        int32 DG.Tweening.Tween::loops
    IL_000f: ldc.i4.1
    IL_0010: cgt
    IL_0012: ret
    IL_0013: ldc.i4.1
    IL_0014: ret

  } // end of method Tween::get_hasLoops

  .method public hidebysig specialname instance bool
    get_playedOnce() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        bool DG.Tweening.Tween::'<playedOnce>k__BackingField'
    IL_0006: ret

  } // end of method Tween::get_playedOnce

  .method private hidebysig specialname instance void
    set_playedOnce(
      bool 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: stfld        bool DG.Tweening.Tween::'<playedOnce>k__BackingField'
    IL_0007: ret

  } // end of method Tween::set_playedOnce

  .method public hidebysig specialname instance float32
    get_position() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldfld        float32 DG.Tweening.Tween::'<position>k__BackingField'
    IL_0006: ret

  } // end of method Tween::get_position

  .method assembly hidebysig specialname instance void
    set_position(
      float32 'value'
    ) cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: ldarg.1      // 'value'
    IL_0002: stfld        float32 DG.Tweening.Tween::'<position>k__BackingField'
    IL_0007: ret

  } // end of method Tween::set_position

  .method assembly hidebysig strict virtual newslot instance void
    Reset() cil managed
  {
    .maxstack 9
    .locals init (
      [0] class DG.Tweening.TweenCallback V_0,
      [1] bool V_1,
      [2] int32 V_2,
      [3] float32 V_3
    )

    // [110 7 - 110 26]
    IL_0000: ldarg.0      // this
    IL_0001: ldc.r4       1
    IL_0006: stfld        float32 DG.Tweening.Tween::timeScale

    // [111 7 - 111 31]
    IL_000b: ldarg.0      // this
    IL_000c: ldc.i4.0
    IL_000d: stfld        bool DG.Tweening.Tween::isBackwards

    // [112 7 - 112 30]
    IL_0012: ldarg.0      // this
    IL_0013: ldnull
    IL_0014: stfld        object DG.Tweening.Tween::id

    // [113 7 - 113 36]
    IL_0019: ldarg.0      // this
    IL_001a: ldnull
    IL_001b: stfld        string DG.Tweening.Tween::stringId

    // [114 7 - 114 24]
    IL_0020: ldarg.0      // this
    IL_0021: ldc.i4       -999 // 0xfffffc19
    IL_0026: stfld        int32 DG.Tweening.Tween::intId

    // [115 7 - 115 39]
    IL_002b: ldarg.0      // this
    IL_002c: ldc.i4.0
    IL_002d: stfld        bool DG.Tweening.Tween::isIndependentUpdate

    // [116 7 - 116 142]
    IL_0032: ldarg.0      // this
    IL_0033: ldarg.0      // this
    IL_0034: ldarg.0      // this
    IL_0035: ldarg.0      // this
    IL_0036: ldarg.0      // this
    IL_0037: ldarg.0      // this
    IL_0038: ldarg.0      // this
    IL_0039: ldnull
    IL_003a: dup
    IL_003b: stloc.0      // V_0
    IL_003c: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onKill
    IL_0041: ldloc.0      // V_0
    IL_0042: dup
    IL_0043: stloc.0      // V_0
    IL_0044: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onStepComplete
    IL_0049: ldloc.0      // V_0
    IL_004a: dup
    IL_004b: stloc.0      // V_0
    IL_004c: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onComplete
    IL_0051: ldloc.0      // V_0
    IL_0052: dup
    IL_0053: stloc.0      // V_0
    IL_0054: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onUpdate
    IL_0059: ldloc.0      // V_0
    IL_005a: dup
    IL_005b: stloc.0      // V_0
    IL_005c: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onRewind
    IL_0061: ldloc.0      // V_0
    IL_0062: dup
    IL_0063: stloc.0      // V_0
    IL_0064: stfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onPlay
    IL_0069: ldloc.0      // V_0
    IL_006a: stfld        class DG.Tweening.TweenCallback DG.Tweening.Core.ABSSequentiable::onStart

    // [117 7 - 117 56]
    IL_006f: ldarg.0      // this
    IL_0070: ldnull
    IL_0071: stfld        class DG.Tweening.TweenCallback`1<int32> DG.Tweening.Tween::onWaypointChange

    // [118 7 - 118 41]
    IL_0076: ldarg.0      // this
    IL_0077: ldnull
    IL_0078: stfld        string DG.Tweening.Tween::debugTargetId

    // [119 7 - 119 34]
    IL_007d: ldarg.0      // this
    IL_007e: ldnull
    IL_007f: stfld        object DG.Tweening.Tween::target

    // [120 7 - 120 26]
    IL_0084: ldarg.0      // this
    IL_0085: ldc.i4.0
    IL_0086: stfld        bool DG.Tweening.Tween::isFrom

    // [121 7 - 121 31]
    IL_008b: ldarg.0      // this
    IL_008c: ldc.i4.0
    IL_008d: stfld        bool DG.Tweening.Tween::isBlendable

    // [122 7 - 122 32]
    IL_0092: ldarg.0      // this
    IL_0093: ldc.i4.0
    IL_0094: stfld        bool DG.Tweening.Tween::isSpeedBased

    // [123 7 - 123 27]
    IL_0099: ldarg.0      // this
    IL_009a: ldc.r4       0.0
    IL_009f: stfld        float32 DG.Tweening.Tween::duration

    // [124 7 - 124 21]
    IL_00a4: ldarg.0      // this
    IL_00a5: ldc.i4.1
    IL_00a6: stfld        int32 DG.Tweening.Tween::loops

    // [125 7 - 125 24]
    IL_00ab: ldarg.0      // this
    IL_00ac: ldc.r4       0.0
    IL_00b1: stfld        float32 DG.Tweening.Tween::delay

    // [126 7 - 126 30]
    IL_00b6: ldarg.0      // this
    IL_00b7: ldc.i4.0
    IL_00b8: call         instance void DG.Tweening.Tween::set_isRelative(bool)

    // [127 7 - 127 44]
    IL_00bd: ldarg.0      // this
    IL_00be: ldnull
    IL_00bf: stfld        class DG.Tweening.EaseFunction DG.Tweening.Tween::customEase

    // [128 7 - 128 31]
    IL_00c4: ldarg.0      // this
    IL_00c5: ldc.i4.0
    IL_00c6: stfld        bool DG.Tweening.Tween::isSequenced

    // [129 7 - 129 44]
    IL_00cb: ldarg.0      // this
    IL_00cc: ldnull
    IL_00cd: stfld        class DG.Tweening.Sequence DG.Tweening.Tween::sequenceParent

    // [130 7 - 130 56]
    IL_00d2: ldarg.0      // this
    IL_00d3: ldc.i4.0
    IL_00d4: stfld        valuetype DG.Tweening.Core.Enums.SpecialStartupMode DG.Tweening.Tween::specialStartupMode

    // [131 7 - 131 71]
    IL_00d9: ldarg.0      // this
    IL_00da: ldarg.0      // this
    IL_00db: ldarg.0      // this
    IL_00dc: ldc.i4.0
    IL_00dd: dup
    IL_00de: stloc.1      // V_1
    IL_00df: call         instance void DG.Tweening.Tween::set_playedOnce(bool)
    IL_00e4: ldloc.1      // V_1
    IL_00e5: dup
    IL_00e6: stloc.1      // V_1
    IL_00e7: stfld        bool DG.Tweening.Tween::startupDone
    IL_00ec: ldloc.1      // V_1
    IL_00ed: stfld        bool DG.Tweening.Tween::creationLocked

    // [132 7 - 132 76]
    IL_00f2: ldarg.0      // this
    IL_00f3: ldarg.0      // this
    IL_00f4: ldarg.0      // this
    IL_00f5: ldc.i4.0
    IL_00f6: dup
    IL_00f7: stloc.2      // V_2
    IL_00f8: stfld        int32 DG.Tweening.Tween::completedLoops
    IL_00fd: ldloc.2      // V_2
    IL_00fe: conv.r4
    IL_00ff: dup
    IL_0100: stloc.3      // V_3
    IL_0101: stfld        float32 DG.Tweening.Tween::fullDuration
    IL_0106: ldloc.3      // V_3
    IL_0107: call         instance void DG.Tweening.Tween::set_position(float32)

    // [133 7 - 133 47]
    IL_010c: ldarg.0      // this
    IL_010d: ldarg.0      // this
    IL_010e: ldc.i4.0
    IL_010f: dup
    IL_0110: stloc.1      // V_1
    IL_0111: stfld        bool DG.Tweening.Tween::isComplete
    IL_0116: ldloc.1      // V_1
    IL_0117: stfld        bool DG.Tweening.Tween::isPlaying

    // [134 7 - 134 31]
    IL_011c: ldarg.0      // this
    IL_011d: ldc.r4       0.0
    IL_0122: stfld        float32 DG.Tweening.Tween::elapsedDelay

    // [135 7 - 135 32]
    IL_0127: ldarg.0      // this
    IL_0128: ldc.i4.1
    IL_0129: stfld        bool DG.Tweening.Tween::delayComplete

    // [136 7 - 136 24]
    IL_012e: ldarg.0      // this
    IL_012f: ldc.i4.m1
    IL_0130: stfld        int32 DG.Tweening.Tween::miscInt
    IL_0135: ret

  } // end of method Tween::Reset

  .method assembly hidebysig strict virtual newslot abstract instance bool
    Validate() cil managed
  {
    // Can't find a body
  } // end of method Tween::Validate

  .method assembly hidebysig strict virtual newslot instance float32
    UpdateDelay(
      float32 elapsed
    ) cil managed
  {
    .maxstack 8

    // [141 58 - 141 62]
    IL_0000: ldc.r4       0.0
    IL_0005: ret

  } // end of method Tween::UpdateDelay

  .method assembly hidebysig strict virtual newslot abstract instance bool
    Startup() cil managed
  {
    // Can't find a body
  } // end of method Tween::Startup

  .method assembly hidebysig strict virtual newslot abstract instance bool
    ApplyTween(
      float32 prevPosition,
      int32 prevCompletedLoops,
      int32 newCompletedSteps,
      bool useInversePosition,
      valuetype DG.Tweening.Core.Enums.UpdateMode updateMode,
      valuetype DG.Tweening.Core.Enums.UpdateNotice updateNotice
    ) cil managed
  {
    // Can't find a body
  } // end of method Tween::ApplyTween

  .method assembly hidebysig static bool
    DoGoto(
      class DG.Tweening.Tween t,
      float32 toPosition,
      int32 toCompletedLoops,
      valuetype DG.Tweening.Core.Enums.UpdateMode updateMode
    ) cil managed
  {
    .maxstack 7
    .locals init (
      [0] float32 position,
      [1] int32 completedLoops,
      [2] bool flag,
      [3] bool isComplete,
      [4] int32 newCompletedSteps,
      [5] bool isPlaying,
      [6] bool useInversePosition,
      [7] valuetype DG.Tweening.Core.Enums.UpdateNotice updateNotice,
      [8] int32 index
    )

    // [159 7 - 159 42]
    IL_0000: ldarg.0      // t
    IL_0001: ldfld        bool DG.Tweening.Tween::startupDone
    IL_0006: brtrue.s     IL_0012

    IL_0008: ldarg.0      // t
    IL_0009: callvirt     instance bool DG.Tweening.Tween::Startup()
    IL_000e: brtrue.s     IL_0012

    // [160 9 - 160 21]
    IL_0010: ldc.i4.1
    IL_0011: ret

    // [161 7 - 161 60]
    IL_0012: ldarg.0      // t
    IL_0013: callvirt     instance bool DG.Tweening.Tween::get_playedOnce()
    IL_0018: brtrue.s     IL_0062

    IL_001a: ldarg.3      // updateMode
    IL_001b: brtrue.s     IL_0062

    // [163 9 - 163 28]
    IL_001d: ldarg.0      // t
    IL_001e: ldc.i4.1
    IL_001f: callvirt     instance void DG.Tweening.Tween::set_playedOnce(bool)

    // [164 9 - 164 31]
    IL_0024: ldarg.0      // t
    IL_0025: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Core.ABSSequentiable::onStart
    IL_002a: brfalse.s    IL_0043

    // [166 11 - 166 46]
    IL_002c: ldarg.0      // t
    IL_002d: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Core.ABSSequentiable::onStart
    IL_0032: ldarg.0      // t
    IL_0033: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_0038: pop

    // [167 11 - 167 25]
    IL_0039: ldarg.0      // t
    IL_003a: callvirt     instance bool DG.Tweening.Tween::get_active()
    IL_003f: brtrue.s     IL_0043

    // [168 13 - 168 25]
    IL_0041: ldc.i4.1
    IL_0042: ret

    // [170 9 - 170 30]
    IL_0043: ldarg.0      // t
    IL_0044: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onPlay
    IL_0049: brfalse.s    IL_0062

    // [172 11 - 172 45]
    IL_004b: ldarg.0      // t
    IL_004c: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onPlay
    IL_0051: ldarg.0      // t
    IL_0052: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_0057: pop

    // [173 11 - 173 25]
    IL_0058: ldarg.0      // t
    IL_0059: callvirt     instance bool DG.Tweening.Tween::get_active()
    IL_005e: brtrue.s     IL_0062

    // [174 13 - 174 25]
    IL_0060: ldc.i4.1
    IL_0061: ret

    // [177 7 - 177 34]
    IL_0062: ldarg.0      // t
    IL_0063: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_0068: stloc.0      // position

    // [178 7 - 178 44]
    IL_0069: ldarg.0      // t
    IL_006a: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_006f: stloc.1      // completedLoops

    // [179 7 - 179 42]
    IL_0070: ldarg.0      // t
    IL_0071: ldarg.2      // toCompletedLoops
    IL_0072: stfld        int32 DG.Tweening.Tween::completedLoops

    // [180 7 - 180 68]
    IL_0077: ldarg.0      // t
    IL_0078: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_007d: ldc.r4       0.0
    IL_0082: bgt.un.s     IL_008d

    IL_0084: ldloc.1      // completedLoops
    IL_0085: ldc.i4.0
    IL_0086: cgt
    IL_0088: ldc.i4.0
    IL_0089: ceq
    IL_008b: br.s         IL_008e
    IL_008d: ldc.i4.0
    IL_008e: stloc.2      // flag

    // [181 7 - 181 37]
    IL_008f: ldarg.0      // t
    IL_0090: ldfld        bool DG.Tweening.Tween::isComplete
    IL_0095: stloc.3      // isComplete

    // [182 7 - 182 25]
    IL_0096: ldarg.0      // t
    IL_0097: ldfld        int32 DG.Tweening.Tween::loops
    IL_009c: ldc.i4.m1
    IL_009d: beq.s        IL_00b3

    // [183 9 - 183 51]
    IL_009f: ldarg.0      // t
    IL_00a0: ldarg.0      // t
    IL_00a1: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_00a6: ldarg.0      // t
    IL_00a7: ldfld        int32 DG.Tweening.Tween::loops
    IL_00ac: ceq
    IL_00ae: stfld        bool DG.Tweening.Tween::isComplete

    // [184 7 - 184 32]
    IL_00b3: ldc.i4.0
    IL_00b4: stloc.s      newCompletedSteps

    // [185 7 - 185 43]
    IL_00b6: ldarg.3      // updateMode
    IL_00b7: brtrue.s     IL_0108

    // [187 9 - 187 27]
    IL_00b9: ldarg.0      // t
    IL_00ba: ldfld        bool DG.Tweening.Tween::isBackwards
    IL_00bf: brfalse.s    IL_00f0

    // [189 11 - 189 146]
    IL_00c1: ldarg.0      // t
    IL_00c2: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_00c7: ldloc.1      // completedLoops
    IL_00c8: blt.s        IL_00db

    IL_00ca: ldarg.1      // toPosition
    IL_00cb: ldc.r4       0.0
    IL_00d0: bgt.un.s     IL_00d5
    IL_00d2: ldloc.2      // flag
    IL_00d3: brfalse.s    IL_00d8
    IL_00d5: ldc.i4.0
    IL_00d6: br.s         IL_00e3
    IL_00d8: ldc.i4.1
    IL_00d9: br.s         IL_00e3
    IL_00db: ldloc.1      // completedLoops
    IL_00dc: ldarg.0      // t
    IL_00dd: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_00e2: sub
    IL_00e3: stloc.s      newCompletedSteps

    // [190 11 - 190 26]
    IL_00e5: ldloc.3      // isComplete
    IL_00e6: brfalse.s    IL_0120

    // [191 13 - 191 32]
    IL_00e8: ldloc.s      newCompletedSteps
    IL_00ea: ldc.i4.1
    IL_00eb: sub
    IL_00ec: stloc.s      newCompletedSteps

    IL_00ee: br.s         IL_0120

    // [194 11 - 194 104]
    IL_00f0: ldarg.0      // t
    IL_00f1: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_00f6: ldloc.1      // completedLoops
    IL_00f7: bgt.s        IL_00fc

    IL_00f9: ldc.i4.0
    IL_00fa: br.s         IL_0104
    IL_00fc: ldarg.0      // t
    IL_00fd: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_0102: ldloc.1      // completedLoops
    IL_0103: sub
    IL_0104: stloc.s      newCompletedSteps
    IL_0106: br.s         IL_0120

    // [196 12 - 196 50]
    IL_0108: ldarg.0      // t
    IL_0109: ldfld        valuetype DG.Tweening.TweenType DG.Tweening.Core.ABSSequentiable::tweenType
    IL_010e: ldc.i4.1
    IL_010f: bne.un.s     IL_0120

    // [198 9 - 198 62]
    IL_0111: ldloc.1      // completedLoops
    IL_0112: ldarg.2      // toCompletedLoops
    IL_0113: sub
    IL_0114: stloc.s      newCompletedSteps

    // [199 9 - 199 35]
    IL_0116: ldloc.s      newCompletedSteps
    IL_0118: ldc.i4.0
    IL_0119: bge.s        IL_0120

    // [200 11 - 200 49]
    IL_011b: ldloc.s      newCompletedSteps
    IL_011d: neg
    IL_011e: stloc.s      newCompletedSteps

    // [202 7 - 202 30]
    IL_0120: ldarg.0      // t
    IL_0121: ldarg.1      // toPosition
    IL_0122: callvirt     instance void DG.Tweening.Tween::set_position(float32)

    // [203 7 - 203 53]
    IL_0127: ldarg.0      // t
    IL_0128: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_012d: ldarg.0      // t
    IL_012e: ldfld        float32 DG.Tweening.Tween::duration
    IL_0133: ble.un.s     IL_0143

    // [204 9 - 204 32]
    IL_0135: ldarg.0      // t
    IL_0136: ldarg.0      // t
    IL_0137: ldfld        float32 DG.Tweening.Tween::duration
    IL_013c: callvirt     instance void DG.Tweening.Tween::set_position(float32)

    IL_0141: br.s         IL_017a

    // [205 12 - 205 43]
    IL_0143: ldarg.0      // t
    IL_0144: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_0149: ldc.r4       0.0
    IL_014e: bgt.un.s     IL_017a

    // [206 9 - 206 78]
    IL_0150: ldarg.0      // t
    IL_0151: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_0156: ldc.i4.0
    IL_0157: bgt.s        IL_0161

    IL_0159: ldarg.0      // t
    IL_015a: ldfld        bool DG.Tweening.Tween::isComplete
    IL_015f: brfalse.s    IL_016f
    IL_0161: ldarg.0      // t
    IL_0162: ldarg.0      // t
    IL_0163: ldfld        float32 DG.Tweening.Tween::duration
    IL_0168: callvirt     instance void DG.Tweening.Tween::set_position(float32)
    IL_016d: br.s         IL_017a
    IL_016f: ldarg.0      // t
    IL_0170: ldc.r4       0.0
    IL_0175: callvirt     instance void DG.Tweening.Tween::set_position(float32)

    // [207 7 - 207 35]
    IL_017a: ldarg.0      // t
    IL_017b: ldfld        bool DG.Tweening.Tween::isPlaying
    IL_0180: stloc.s      isPlaying

    // [208 7 - 208 23]
    IL_0182: ldarg.0      // t
    IL_0183: ldfld        bool DG.Tweening.Tween::isPlaying
    IL_0188: brfalse.s    IL_01c1

    // [209 9 - 209 105]
    IL_018a: ldarg.0      // t
    IL_018b: ldfld        bool DG.Tweening.Tween::isBackwards
    IL_0190: brtrue.s     IL_01a3

    IL_0192: ldarg.0      // t
    IL_0193: ldarg.0      // t
    IL_0194: ldfld        bool DG.Tweening.Tween::isComplete
    IL_0199: ldc.i4.0
    IL_019a: ceq
    IL_019c: stfld        bool DG.Tweening.Tween::isPlaying
    IL_01a1: br.s         IL_01c1
    IL_01a3: ldarg.0      // t
    IL_01a4: ldarg.0      // t
    IL_01a5: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_01aa: brtrue.s     IL_01bb
    IL_01ac: ldarg.0      // t
    IL_01ad: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_01b2: ldc.r4       0.0
    IL_01b7: cgt.un
    IL_01b9: br.s         IL_01bc
    IL_01bb: ldc.i4.1
    IL_01bc: stfld        bool DG.Tweening.Tween::isPlaying

    // [210 7 - 210 186]
    IL_01c1: ldarg.0      // t
    IL_01c2: callvirt     instance bool DG.Tweening.Tween::get_hasLoops()
    IL_01c7: brfalse.s    IL_01fa

    IL_01c9: ldarg.0      // t
    IL_01ca: ldfld        valuetype DG.Tweening.LoopType DG.Tweening.Tween::loopType
    IL_01cf: ldc.i4.1
    IL_01d0: bne.un.s     IL_01fa
    IL_01d2: ldarg.0      // t
    IL_01d3: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_01d8: ldarg.0      // t
    IL_01d9: ldfld        float32 DG.Tweening.Tween::duration
    IL_01de: blt.s        IL_01ed
    IL_01e0: ldarg.0      // t
    IL_01e1: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_01e6: ldc.i4.2
    IL_01e7: rem
    IL_01e8: ldc.i4.0
    IL_01e9: ceq
    IL_01eb: br.s         IL_01fb
    IL_01ed: ldarg.0      // t
    IL_01ee: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_01f3: ldc.i4.2
    IL_01f4: rem
    IL_01f5: ldc.i4.0
    IL_01f6: cgt.un
    IL_01f8: br.s         IL_01fb
    IL_01fa: ldc.i4.0
    IL_01fb: stloc.s      useInversePosition

    // [211 7 - 211 289]
    IL_01fd: ldloc.2      // flag
    IL_01fe: brtrue.s     IL_0249

    IL_0200: ldarg.0      // t
    IL_0201: ldfld        valuetype DG.Tweening.LoopType DG.Tweening.Tween::loopType
    IL_0206: brtrue.s     IL_0228
    IL_0208: ldarg.0      // t
    IL_0209: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_020e: ldloc.1      // completedLoops
    IL_020f: beq.s        IL_0228
    IL_0211: ldarg.0      // t
    IL_0212: ldfld        int32 DG.Tweening.Tween::loops
    IL_0217: ldc.i4.m1
    IL_0218: beq.s        IL_0246
    IL_021a: ldarg.0      // t
    IL_021b: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_0220: ldarg.0      // t
    IL_0221: ldfld        int32 DG.Tweening.Tween::loops
    IL_0226: blt.s        IL_0246
    IL_0228: ldarg.0      // t
    IL_0229: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_022e: ldc.r4       0.0
    IL_0233: bgt.un.s     IL_0243
    IL_0235: ldarg.0      // t
    IL_0236: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_023b: ldc.i4.0
    IL_023c: cgt
    IL_023e: ldc.i4.0
    IL_023f: ceq
    IL_0241: br.s         IL_024a
    IL_0243: ldc.i4.0
    IL_0244: br.s         IL_024a
    IL_0246: ldc.i4.1
    IL_0247: br.s         IL_024a
    IL_0249: ldc.i4.0
    IL_024a: brtrue.s     IL_024f
    IL_024c: ldc.i4.0
    IL_024d: br.s         IL_0250
    IL_024f: ldc.i4.1
    IL_0250: stloc.s      updateNotice

    // [212 7 - 212 115]
    IL_0252: ldarg.0      // t
    IL_0253: ldloc.0      // position
    IL_0254: ldloc.1      // completedLoops
    IL_0255: ldloc.s      newCompletedSteps
    IL_0257: ldloc.s      useInversePosition
    IL_0259: ldarg.3      // updateMode
    IL_025a: ldloc.s      updateNotice
    IL_025c: callvirt     instance bool DG.Tweening.Tween::ApplyTween(float32, int32, int32, bool, valuetype DG.Tweening.Core.Enums.UpdateMode, valuetype DG.Tweening.Core.Enums.UpdateNotice)
    IL_0261: brfalse.s    IL_0265

    // [213 9 - 213 21]
    IL_0263: ldc.i4.1
    IL_0264: ret

    // [214 7 - 214 73]
    IL_0265: ldarg.0      // t
    IL_0266: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onUpdate
    IL_026b: brfalse.s    IL_027e

    IL_026d: ldarg.3      // updateMode
    IL_026e: ldc.i4.2
    IL_026f: beq.s        IL_027e

    // [215 9 - 215 45]
    IL_0271: ldarg.0      // t
    IL_0272: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onUpdate
    IL_0277: ldarg.0      // t
    IL_0278: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_027d: pop

    // [216 7 - 216 96]
    IL_027e: ldarg.0      // t
    IL_027f: callvirt     instance float32 DG.Tweening.Tween::get_position()
    IL_0284: ldc.r4       0.0
    IL_0289: bgt.un.s     IL_02ac

    IL_028b: ldarg.0      // t
    IL_028c: ldfld        int32 DG.Tweening.Tween::completedLoops
    IL_0291: ldc.i4.0
    IL_0292: bgt.s        IL_02ac
    IL_0294: ldloc.2      // flag
    IL_0295: brtrue.s     IL_02ac
    IL_0297: ldarg.0      // t
    IL_0298: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onRewind
    IL_029d: brfalse.s    IL_02ac

    // [217 9 - 217 45]
    IL_029f: ldarg.0      // t
    IL_02a0: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onRewind
    IL_02a5: ldarg.0      // t
    IL_02a6: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_02ab: pop

    // [218 7 - 218 96]
    IL_02ac: ldloc.s      newCompletedSteps
    IL_02ae: ldc.i4.0
    IL_02af: ble.s        IL_02e2

    IL_02b1: ldarg.3      // updateMode
    IL_02b2: brtrue.s     IL_02e2
    IL_02b4: ldarg.0      // t
    IL_02b5: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onStepComplete
    IL_02ba: brfalse.s    IL_02e2

    // [220 14 - 220 27]
    IL_02bc: ldc.i4.0
    IL_02bd: stloc.s      index

    IL_02bf: br.s         IL_02dc
    // start of loop, entry point: IL_02dc

      // [222 11 - 222 53]
      IL_02c1: ldarg.0      // t
      IL_02c2: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onStepComplete
      IL_02c7: ldarg.0      // t
      IL_02c8: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
      IL_02cd: pop

      // [223 11 - 223 25]
      IL_02ce: ldarg.0      // t
      IL_02cf: callvirt     instance bool DG.Tweening.Tween::get_active()
      IL_02d4: brfalse.s    IL_02e2

      // [220 56 - 220 63]
      IL_02d6: ldloc.s      index
      IL_02d8: ldc.i4.1
      IL_02d9: add
      IL_02da: stloc.s      index

      // [220 29 - 220 54]
      IL_02dc: ldloc.s      index
      IL_02de: ldloc.s      newCompletedSteps
      IL_02e0: blt.s        IL_02c1
    // end of loop

    // [227 7 - 227 110]
    IL_02e2: ldarg.0      // t
    IL_02e3: ldfld        bool DG.Tweening.Tween::isComplete
    IL_02e8: brfalse.s    IL_0306

    IL_02ea: ldloc.3      // isComplete
    IL_02eb: brtrue.s     IL_0306
    IL_02ed: ldarg.3      // updateMode
    IL_02ee: ldc.i4.3
    IL_02ef: beq.s        IL_0306
    IL_02f1: ldarg.0      // t
    IL_02f2: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onComplete
    IL_02f7: brfalse.s    IL_0306

    // [228 9 - 228 47]
    IL_02f9: ldarg.0      // t
    IL_02fa: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onComplete
    IL_02ff: ldarg.0      // t
    IL_0300: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_0305: pop

    // [229 7 - 229 91]
    IL_0306: ldarg.0      // t
    IL_0307: ldfld        bool DG.Tweening.Tween::isPlaying
    IL_030c: ldc.i4.0
    IL_030d: ceq
    IL_030f: ldloc.s      isPlaying
    IL_0311: and
    IL_0312: brfalse.s    IL_0339

    IL_0314: ldarg.0      // t
    IL_0315: ldfld        bool DG.Tweening.Tween::isComplete
    IL_031a: brfalse.s    IL_0324
    IL_031c: ldarg.0      // t
    IL_031d: ldfld        bool DG.Tweening.Tween::autoKill
    IL_0322: brtrue.s     IL_0339
    IL_0324: ldarg.0      // t
    IL_0325: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onPause
    IL_032a: brfalse.s    IL_0339

    // [230 9 - 230 44]
    IL_032c: ldarg.0      // t
    IL_032d: ldfld        class DG.Tweening.TweenCallback DG.Tweening.Tween::onPause
    IL_0332: ldarg.0      // t
    IL_0333: call         bool DG.Tweening.Tween::OnTweenCallback(class DG.Tweening.TweenCallback, class DG.Tweening.Tween)
    IL_0338: pop

    // [231 7 - 231 41]
    IL_0339: ldarg.0      // t
    IL_033a: ldfld        bool DG.Tweening.Tween::autoKill
    IL_033f: brfalse.s    IL_0348

    IL_0341: ldarg.0      // t
    IL_0342: ldfld        bool DG.Tweening.Tween::isComplete
    IL_0347: ret
    IL_0348: ldc.i4.0
    IL_0349: ret

  } // end of method Tween::DoGoto

  .method assembly hidebysig static bool
    OnTweenCallback(
      class DG.Tweening.TweenCallback callback,
      class DG.Tweening.Tween t
    ) cil managed
  {
    .maxstack 4
    .locals init (
      [0] class [mscorlib]System.Exception ex,
      [1] bool V_1
    )

    // [236 7 - 236 31]
    IL_0000: ldsfld       bool DG.Tweening.DOTween::useSafeMode
    IL_0005: brfalse.s    IL_0049
    .try
    {

      // [240 11 - 240 21]
      IL_0007: ldarg.0      // callback
      IL_0008: callvirt     instance void DG.Tweening.TweenCallback::Invoke()

      IL_000d: leave.s      IL_004f
    } // end of .try
    catch [mscorlib]System.Exception
    {

      // [242 9 - 242 29]
      IL_000f: stloc.0      // ex

      // [244 11 - 244 41]
      IL_0010: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
      IL_0015: ldc.i4.1
      IL_0016: blt.s        IL_003a

      // [245 13 - 245 214]
      IL_0018: ldstr        "An error inside a tween callback was silently taken care of ({0}) ► {1}\n\n{2}\n\n"
      IL_001d: ldloc.0      // ex
      IL_001e: callvirt     instance class [mscorlib]System.Reflection.MethodBase [mscorlib]System.Exception::get_TargetSite()
      IL_0023: ldloc.0      // ex
      IL_0024: callvirt     instance string [mscorlib]System.Exception::get_Message()
      IL_0029: ldloc.0      // ex
      IL_002a: callvirt     instance string [mscorlib]System.Exception::get_StackTrace()
      IL_002f: call         string [mscorlib]System.String::Format(string, object, object, object)
      IL_0034: ldarg.1      // t
      IL_0035: call         void DG.Tweening.Core.Debugger::LogWarning(object, class DG.Tweening.Tween)

      // [246 11 - 246 81]
      IL_003a: ldsflda      valuetype DG.Tweening.Core.SafeModeReport DG.Tweening.DOTween::safeModeReport
      IL_003f: ldc.i4.2
      IL_0040: call         instance void DG.Tweening.Core.SafeModeReport::Add(valuetype DG.Tweening.Core.SafeModeReport/SafeModeReportType)

      // [247 11 - 247 24]
      IL_0045: ldc.i4.0
      IL_0046: stloc.1      // V_1

      IL_0047: leave.s      IL_0051
    } // end of catch

    // [251 9 - 251 19]
    IL_0049: ldarg.0      // callback
    IL_004a: callvirt     instance void DG.Tweening.TweenCallback::Invoke()

    // [252 7 - 252 19]
    IL_004f: ldc.i4.1
    IL_0050: ret

    IL_0051: ldloc.1      // V_1
    IL_0052: ret

  } // end of method Tween::OnTweenCallback

  .method assembly hidebysig static bool
    OnTweenCallback<T>(
      class DG.Tweening.TweenCallback`1<!!0/*T*/> callback,
      class DG.Tweening.Tween t,
      !!0/*T*/ param
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] class [mscorlib]System.Exception ex,
      [1] bool V_1
    )

    // [257 7 - 257 31]
    IL_0000: ldsfld       bool DG.Tweening.DOTween::useSafeMode
    IL_0005: brfalse.s    IL_0044
    .try
    {

      // [261 11 - 261 26]
      IL_0007: ldarg.0      // callback
      IL_0008: ldarg.2      // param
      IL_0009: callvirt     instance void class DG.Tweening.TweenCallback`1<!!0/*T*/>::Invoke(!0/*T*/)

      IL_000e: leave.s      IL_004b
    } // end of .try
    catch [mscorlib]System.Exception
    {

      // [263 9 - 263 29]
      IL_0010: stloc.0      // ex

      // [265 11 - 265 41]
      IL_0011: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
      IL_0016: ldc.i4.1
      IL_0017: blt.s        IL_0035

      // [266 13 - 266 179]
      IL_0019: ldstr        "An error inside a tween callback was silently taken care of ({0}) ► {1}"
      IL_001e: ldloc.0      // ex
      IL_001f: callvirt     instance class [mscorlib]System.Reflection.MethodBase [mscorlib]System.Exception::get_TargetSite()
      IL_0024: ldloc.0      // ex
      IL_0025: callvirt     instance string [mscorlib]System.Exception::get_Message()
      IL_002a: call         string [mscorlib]System.String::Format(string, object, object)
      IL_002f: ldarg.1      // t
      IL_0030: call         void DG.Tweening.Core.Debugger::LogWarning(object, class DG.Tweening.Tween)

      // [267 11 - 267 81]
      IL_0035: ldsflda      valuetype DG.Tweening.Core.SafeModeReport DG.Tweening.DOTween::safeModeReport
      IL_003a: ldc.i4.2
      IL_003b: call         instance void DG.Tweening.Core.SafeModeReport::Add(valuetype DG.Tweening.Core.SafeModeReport/SafeModeReportType)

      // [268 11 - 268 24]
      IL_0040: ldc.i4.0
      IL_0041: stloc.1      // V_1

      IL_0042: leave.s      IL_004d
    } // end of catch

    // [272 9 - 272 24]
    IL_0044: ldarg.0      // callback
    IL_0045: ldarg.2      // param
    IL_0046: callvirt     instance void class DG.Tweening.TweenCallback`1<!!0/*T*/>::Invoke(!0/*T*/)

    // [273 7 - 273 19]
    IL_004b: ldc.i4.1
    IL_004c: ret

    IL_004d: ldloc.1      // V_1
    IL_004e: ret

  } // end of method Tween::OnTweenCallback

  .method family hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    // [27 5 - 27 29]
    IL_0000: ldarg.0      // this
    IL_0001: ldc.i4       -999 // 0xfffffc19
    IL_0006: stfld        int32 DG.Tweening.Tween::intId

    // [74 5 - 74 32]
    IL_000b: ldarg.0      // this
    IL_000c: ldc.i4.m1
    IL_000d: stfld        int32 DG.Tweening.Tween::activeId

    // [83 5 - 83 40]
    IL_0012: ldarg.0      // this
    IL_0013: ldc.i4.1
    IL_0014: stfld        bool DG.Tweening.Tween::delayComplete

    // [84 5 - 84 31]
    IL_0019: ldarg.0      // this
    IL_001a: ldc.i4.m1
    IL_001b: stfld        int32 DG.Tweening.Tween::miscInt
    IL_0020: ldarg.0      // this
    IL_0021: call         instance void DG.Tweening.Core.ABSSequentiable::.ctor()
    IL_0026: ret

  } // end of method Tween::.ctor

  .property instance bool isRelative()
  {
    .get instance bool DG.Tweening.Tween::get_isRelative()
    .set instance void DG.Tweening.Tween::set_isRelative(bool)
  } // end of property Tween::isRelative

  .property instance bool active()
  {
    .get instance bool DG.Tweening.Tween::get_active()
    .set instance void DG.Tweening.Tween::set_active(bool)
  } // end of property Tween::active

  .property instance float32 fullPosition()
  {
    .get instance float32 DG.Tweening.Tween::get_fullPosition()
    .set instance void DG.Tweening.Tween::set_fullPosition(float32)
  } // end of property Tween::fullPosition

  .property instance bool hasLoops()
  {
    .get instance bool DG.Tweening.Tween::get_hasLoops()
  } // end of property Tween::hasLoops

  .property instance bool playedOnce()
  {
    .get instance bool DG.Tweening.Tween::get_playedOnce()
    .set instance void DG.Tweening.Tween::set_playedOnce(bool)
  } // end of property Tween::playedOnce

  .property instance float32 position()
  {
    .get instance float32 DG.Tweening.Tween::get_position()
    .set instance void DG.Tweening.Tween::set_position(float32)
  } // end of property Tween::position
} // end of class DG.Tweening.Tween
