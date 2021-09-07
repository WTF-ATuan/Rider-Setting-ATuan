// Type: DG.Tweening.ShortcutExtensions 
// Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2348FB5E-CC9E-4E68-9F37-F7D7FADAEA9A
// Location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Plugins\Demigiant\DOTween\DOTween.dll
// Sequence point data from decompiler

.class public abstract sealed auto ansi beforefieldinit
  DG.Tweening.ShortcutExtensions
    extends [mscorlib]System.Object
{
  .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
    = (01 00 00 00 )

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass0_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass0_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOAspect>b__0'() cil managed
    {
      .maxstack 8

      // [32 87 - 32 100]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Camera::get_aspect()
      IL_000b: ret

    } // end of method '<>c__DisplayClass0_0'::'<DOAspect>b__0'

    .method assembly hidebysig instance void
      '<DOAspect>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [32 127 - 32 144]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_aspect(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass0_0'::'<DOAspect>b__1'
  } // end of class '<>c__DisplayClass0_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass1_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass1_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [46 87 - 46 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Camera::get_backgroundColor()
      IL_000b: ret

    } // end of method '<>c__DisplayClass1_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [46 136 - 46 162]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_backgroundColor(valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: ret

    } // end of method '<>c__DisplayClass1_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass1_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass2_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass2_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOFarClipPlane>b__0'() cil managed
    {
      .maxstack 8

      // [60 87 - 60 106]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Camera::get_farClipPlane()
      IL_000b: ret

    } // end of method '<>c__DisplayClass2_0'::'<DOFarClipPlane>b__0'

    .method assembly hidebysig instance void
      '<DOFarClipPlane>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [60 133 - 60 156]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_farClipPlane(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass2_0'::'<DOFarClipPlane>b__1'
  } // end of class '<>c__DisplayClass2_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass3_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass3_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOFieldOfView>b__0'() cil managed
    {
      .maxstack 8

      // [74 87 - 74 105]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Camera::get_fieldOfView()
      IL_000b: ret

    } // end of method '<>c__DisplayClass3_0'::'<DOFieldOfView>b__0'

    .method assembly hidebysig instance void
      '<DOFieldOfView>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [74 132 - 74 154]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_fieldOfView(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass3_0'::'<DOFieldOfView>b__1'
  } // end of class '<>c__DisplayClass3_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass4_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass4_0'::.ctor

    .method assembly hidebysig instance float32
      '<DONearClipPlane>b__0'() cil managed
    {
      .maxstack 8

      // [88 87 - 88 107]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Camera::get_nearClipPlane()
      IL_000b: ret

    } // end of method '<>c__DisplayClass4_0'::'<DONearClipPlane>b__0'

    .method assembly hidebysig instance void
      '<DONearClipPlane>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [88 134 - 88 158]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_nearClipPlane(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass4_0'::'<DONearClipPlane>b__1'
  } // end of class '<>c__DisplayClass4_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass5_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass5_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOOrthoSize>b__0'() cil managed
    {
      .maxstack 8

      // [102 87 - 102 110]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Camera::get_orthographicSize()
      IL_000b: ret

    } // end of method '<>c__DisplayClass5_0'::'<DOOrthoSize>b__0'

    .method assembly hidebysig instance void
      '<DOOrthoSize>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [102 137 - 102 164]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_orthographicSize(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass5_0'::'<DOOrthoSize>b__1'
  } // end of class '<>c__DisplayClass5_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass6_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass6_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Rect
      '<DOPixelRect>b__0'() cil managed
    {
      .maxstack 8

      // [116 83 - 116 99]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Rect [UnityEngine]UnityEngine.Camera::get_pixelRect()
      IL_000b: ret

    } // end of method '<>c__DisplayClass6_0'::'<DOPixelRect>b__0'

    .method assembly hidebysig instance void
      '<DOPixelRect>b__1'(
        valuetype [UnityEngine]UnityEngine.Rect x
      ) cil managed
    {
      .maxstack 8

      // [116 125 - 116 145]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_pixelRect(valuetype [UnityEngine]UnityEngine.Rect)
      IL_000c: ret

    } // end of method '<>c__DisplayClass6_0'::'<DOPixelRect>b__1'
  } // end of class '<>c__DisplayClass6_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass7_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass7_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Rect
      '<DORect>b__0'() cil managed
    {
      .maxstack 8

      // [130 83 - 130 94]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Rect [UnityEngine]UnityEngine.Camera::get_rect()
      IL_000b: ret

    } // end of method '<>c__DisplayClass7_0'::'<DORect>b__0'

    .method assembly hidebysig instance void
      '<DORect>b__1'(
        valuetype [UnityEngine]UnityEngine.Rect x
      ) cil managed
    {
      .maxstack 8

      // [130 120 - 130 135]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Camera::set_rect(valuetype [UnityEngine]UnityEngine.Rect)
      IL_000c: ret

    } // end of method '<>c__DisplayClass7_0'::'<DORect>b__1'
  } // end of class '<>c__DisplayClass7_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass8_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass8_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakePosition>b__0'() cil managed
    {
      .maxstack 8

      // [152 67 - 152 97]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_0010: ret

    } // end of method '<>c__DisplayClass8_0'::'<DOShakePosition>b__0'

    .method assembly hidebysig instance void
      '<DOShakePosition>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [152 126 - 152 160]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: ldarg.1      // x
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0011: ret

    } // end of method '<>c__DisplayClass8_0'::'<DOShakePosition>b__1'
  } // end of class '<>c__DisplayClass8_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass9_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass9_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakePosition>b__0'() cil managed
    {
      .maxstack 8

      // [175 67 - 175 97]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_0010: ret

    } // end of method '<>c__DisplayClass9_0'::'<DOShakePosition>b__0'

    .method assembly hidebysig instance void
      '<DOShakePosition>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [175 126 - 175 160]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: ldarg.1      // x
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0011: ret

    } // end of method '<>c__DisplayClass9_0'::'<DOShakePosition>b__1'
  } // end of class '<>c__DisplayClass9_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass10_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass10_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeRotation>b__0'() cil managed
    {
      .maxstack 8

      // [198 67 - 198 100]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localEulerAngles()
      IL_0010: ret

    } // end of method '<>c__DisplayClass10_0'::'<DOShakeRotation>b__0'

    .method assembly hidebysig instance void
      '<DOShakeRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [198 129 - 198 181]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: ldarg.1      // x
      IL_000c: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0011: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0016: ret

    } // end of method '<>c__DisplayClass10_0'::'<DOShakeRotation>b__1'
  } // end of class '<>c__DisplayClass10_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass11_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Camera target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass11_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeRotation>b__0'() cil managed
    {
      .maxstack 8

      // [221 67 - 221 100]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localEulerAngles()
      IL_0010: ret

    } // end of method '<>c__DisplayClass11_0'::'<DOShakeRotation>b__0'

    .method assembly hidebysig instance void
      '<DOShakeRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [221 129 - 221 181]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::target
      IL_0006: callvirt     instance class [UnityEngine]UnityEngine.Transform [UnityEngine]UnityEngine.Component::get_transform()
      IL_000b: ldarg.1      // x
      IL_000c: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0011: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0016: ret

    } // end of method '<>c__DisplayClass11_0'::'<DOShakeRotation>b__1'
  } // end of class '<>c__DisplayClass11_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass12_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Light target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass12_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [236 87 - 236 99]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Light::get_color()
      IL_000b: ret

    } // end of method '<>c__DisplayClass12_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [236 126 - 236 142]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Light::set_color(valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: ret

    } // end of method '<>c__DisplayClass12_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass12_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass13_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Light target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass13_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOIntensity>b__0'() cil managed
    {
      .maxstack 8

      // [250 87 - 250 103]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Light::get_intensity()
      IL_000b: ret

    } // end of method '<>c__DisplayClass13_0'::'<DOIntensity>b__0'

    .method assembly hidebysig instance void
      '<DOIntensity>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [250 130 - 250 150]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Light::set_intensity(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass13_0'::'<DOIntensity>b__1'
  } // end of class '<>c__DisplayClass13_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass14_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Light target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass14_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOShadowStrength>b__0'() cil managed
    {
      .maxstack 8

      // [264 87 - 264 108]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.Light::get_shadowStrength()
      IL_000b: ret

    } // end of method '<>c__DisplayClass14_0'::'<DOShadowStrength>b__0'

    .method assembly hidebysig instance void
      '<DOShadowStrength>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [264 135 - 264 160]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Light::set_shadowStrength(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass14_0'::'<DOShadowStrength>b__1'
  } // end of class '<>c__DisplayClass14_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass15_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype DG.Tweening.Color2 startValue

    .field public class [UnityEngine]UnityEngine.LineRenderer target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass15_0'::.ctor

    .method assembly hidebysig instance valuetype DG.Tweening.Color2
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [282 61 - 282 71]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype DG.Tweening.Color2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::startValue
      IL_0006: ret

    } // end of method '<>c__DisplayClass15_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype DG.Tweening.Color2 x
      ) cil managed
    {
      .maxstack 8

      // [282 99 - 282 127]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.LineRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.Color2::ca
      IL_000c: ldarg.1      // x
      IL_000d: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.Color2::cb
      IL_0012: callvirt     instance void [UnityEngine]UnityEngine.LineRenderer::SetColors(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_0017: ret

    } // end of method '<>c__DisplayClass15_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass15_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass16_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass16_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [294 87 - 294 99]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::get_color()
      IL_000b: ret

    } // end of method '<>c__DisplayClass16_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [294 126 - 294 142]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Material::set_color(valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: ret

    } // end of method '<>c__DisplayClass16_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass16_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass17_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass17_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [316 87 - 316 112]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'property'
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass17_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [316 139 - 316 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(string, valuetype [UnityEngine]UnityEngine.Color)
      IL_0012: ret

    } // end of method '<>c__DisplayClass17_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass17_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass18_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public int32 propertyID

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass18_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOColor>b__0'() cil managed
    {
      .maxstack 8

      // [338 87 - 338 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::propertyID
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(int32)
      IL_0011: ret

    } // end of method '<>c__DisplayClass18_0'::'<DOColor>b__0'

    .method assembly hidebysig instance void
      '<DOColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [338 141 - 338 171]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::propertyID
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(int32, valuetype [UnityEngine]UnityEngine.Color)
      IL_0012: ret

    } // end of method '<>c__DisplayClass18_0'::'<DOColor>b__1'
  } // end of class '<>c__DisplayClass18_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass19_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass19_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOFade>b__0'() cil managed
    {
      .maxstack 8

      // [353 96 - 353 108]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::get_color()
      IL_000b: ret

    } // end of method '<>c__DisplayClass19_0'::'<DOFade>b__0'

    .method assembly hidebysig instance void
      '<DOFade>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [353 135 - 353 151]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Material::set_color(valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: ret

    } // end of method '<>c__DisplayClass19_0'::'<DOFade>b__1'
  } // end of class '<>c__DisplayClass19_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass20_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass20_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOFade>b__0'() cil managed
    {
      .maxstack 8

      // [376 96 - 376 121]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'property'
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass20_0'::'<DOFade>b__0'

    .method assembly hidebysig instance void
      '<DOFade>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [376 148 - 376 176]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(string, valuetype [UnityEngine]UnityEngine.Color)
      IL_0012: ret

    } // end of method '<>c__DisplayClass20_0'::'<DOFade>b__1'
  } // end of class '<>c__DisplayClass20_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass21_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public int32 propertyID

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass21_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOFade>b__0'() cil managed
    {
      .maxstack 8

      // [399 96 - 399 123]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::propertyID
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(int32)
      IL_0011: ret

    } // end of method '<>c__DisplayClass21_0'::'<DOFade>b__0'

    .method assembly hidebysig instance void
      '<DOFade>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 8

      // [399 150 - 399 180]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::propertyID
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(int32, valuetype [UnityEngine]UnityEngine.Color)
      IL_0012: ret

    } // end of method '<>c__DisplayClass21_0'::'<DOFade>b__1'
  } // end of class '<>c__DisplayClass21_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass22_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass22_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOFloat>b__0'() cil managed
    {
      .maxstack 8

      // [421 87 - 421 112]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'property'
      IL_000c: callvirt     instance float32 [UnityEngine]UnityEngine.Material::GetFloat(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass22_0'::'<DOFloat>b__0'

    .method assembly hidebysig instance void
      '<DOFloat>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [421 139 - 421 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetFloat(string, float32)
      IL_0012: ret

    } // end of method '<>c__DisplayClass22_0'::'<DOFloat>b__1'
  } // end of class '<>c__DisplayClass22_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass23_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public int32 propertyID

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass23_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOFloat>b__0'() cil managed
    {
      .maxstack 8

      // [443 87 - 443 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::propertyID
      IL_000c: callvirt     instance float32 [UnityEngine]UnityEngine.Material::GetFloat(int32)
      IL_0011: ret

    } // end of method '<>c__DisplayClass23_0'::'<DOFloat>b__0'

    .method assembly hidebysig instance void
      '<DOFloat>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [443 141 - 443 171]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::propertyID
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetFloat(int32, float32)
      IL_0012: ret

    } // end of method '<>c__DisplayClass23_0'::'<DOFloat>b__1'
  } // end of class '<>c__DisplayClass23_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass24_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass24_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector2
      '<DOOffset>b__0'() cil managed
    {
      .maxstack 8

      // [457 94 - 457 118]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector2 [UnityEngine]UnityEngine.Material::get_mainTextureOffset()
      IL_000b: ret

    } // end of method '<>c__DisplayClass24_0'::'<DOOffset>b__0'

    .method assembly hidebysig instance void
      '<DOOffset>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector2 x
      ) cil managed
    {
      .maxstack 8

      // [457 147 - 457 175]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Material::set_mainTextureOffset(valuetype [UnityEngine]UnityEngine.Vector2)
      IL_000c: ret

    } // end of method '<>c__DisplayClass24_0'::'<DOOffset>b__1'
  } // end of class '<>c__DisplayClass24_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass25_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass25_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector2
      '<DOOffset>b__0'() cil managed
    {
      .maxstack 8

      // [479 94 - 479 127]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'property'
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector2 [UnityEngine]UnityEngine.Material::GetTextureOffset(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass25_0'::'<DOOffset>b__0'

    .method assembly hidebysig instance void
      '<DOOffset>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector2 x
      ) cil managed
    {
      .maxstack 8

      // [479 156 - 479 192]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetTextureOffset(string, valuetype [UnityEngine]UnityEngine.Vector2)
      IL_0012: ret

    } // end of method '<>c__DisplayClass25_0'::'<DOOffset>b__1'
  } // end of class '<>c__DisplayClass25_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass26_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass26_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector2
      '<DOTiling>b__0'() cil managed
    {
      .maxstack 8

      // [493 94 - 493 117]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector2 [UnityEngine]UnityEngine.Material::get_mainTextureScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass26_0'::'<DOTiling>b__0'

    .method assembly hidebysig instance void
      '<DOTiling>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector2 x
      ) cil managed
    {
      .maxstack 8

      // [493 146 - 493 173]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Material::set_mainTextureScale(valuetype [UnityEngine]UnityEngine.Vector2)
      IL_000c: ret

    } // end of method '<>c__DisplayClass26_0'::'<DOTiling>b__1'
  } // end of class '<>c__DisplayClass26_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass27_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass27_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector2
      '<DOTiling>b__0'() cil managed
    {
      .maxstack 8

      // [515 94 - 515 126]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'property'
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector2 [UnityEngine]UnityEngine.Material::GetTextureScale(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass27_0'::'<DOTiling>b__0'

    .method assembly hidebysig instance void
      '<DOTiling>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector2 x
      ) cil managed
    {
      .maxstack 8

      // [515 155 - 515 190]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetTextureScale(string, valuetype [UnityEngine]UnityEngine.Vector2)
      IL_0012: ret

    } // end of method '<>c__DisplayClass27_0'::'<DOTiling>b__1'
  } // end of class '<>c__DisplayClass27_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass28_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass28_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector4
      '<DOVector>b__0'() cil managed
    {
      .maxstack 8

      // [537 94 - 537 120]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'property'
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector4 [UnityEngine]UnityEngine.Material::GetVector(string)
      IL_0011: ret

    } // end of method '<>c__DisplayClass28_0'::'<DOVector>b__0'

    .method assembly hidebysig instance void
      '<DOVector>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector4 x
      ) cil managed
    {
      .maxstack 8

      // [537 149 - 537 178]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'property'
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetVector(string, valuetype [UnityEngine]UnityEngine.Vector4)
      IL_0012: ret

    } // end of method '<>c__DisplayClass28_0'::'<DOVector>b__1'
  } // end of class '<>c__DisplayClass28_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass29_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Material target

    .field public int32 propertyID

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass29_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector4
      '<DOVector>b__0'() cil managed
    {
      .maxstack 8

      // [559 94 - 559 122]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::propertyID
      IL_000c: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector4 [UnityEngine]UnityEngine.Material::GetVector(int32)
      IL_0011: ret

    } // end of method '<>c__DisplayClass29_0'::'<DOVector>b__0'

    .method assembly hidebysig instance void
      '<DOVector>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector4 x
      ) cil managed
    {
      .maxstack 8

      // [559 151 - 559 182]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::target
      IL_0006: ldarg.0      // this
      IL_0007: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::propertyID
      IL_000c: ldarg.1      // x
      IL_000d: callvirt     instance void [UnityEngine]UnityEngine.Material::SetVector(int32, valuetype [UnityEngine]UnityEngine.Vector4)
      IL_0012: ret

    } // end of method '<>c__DisplayClass29_0'::'<DOVector>b__1'
  } // end of class '<>c__DisplayClass29_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass30_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.TrailRenderer target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass30_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector2
      '<DOResize>b__0'() cil managed
    {
      .maxstack 8

      // [575 62 - 575 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.TrailRenderer::get_startWidth()
      IL_000b: ldarg.0      // this
      IL_000c: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target
      IL_0011: callvirt     instance float32 [UnityEngine]UnityEngine.TrailRenderer::get_endWidth()
      IL_0016: newobj       instance void [UnityEngine]UnityEngine.Vector2::.ctor(float32, float32)
      IL_001b: ret

    } // end of method '<>c__DisplayClass30_0'::'<DOResize>b__0'

    .method assembly hidebysig instance void
      '<DOResize>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector2 x
      ) cil managed
    {
      .maxstack 8

      // [577 9 - 577 32]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: ldfld        float32 [UnityEngine]UnityEngine.Vector2::x
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.TrailRenderer::set_startWidth(float32)

      // [578 9 - 578 30]
      IL_0011: ldarg.0      // this
      IL_0012: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target
      IL_0017: ldarg.1      // x
      IL_0018: ldfld        float32 [UnityEngine]UnityEngine.Vector2::y
      IL_001d: callvirt     instance void [UnityEngine]UnityEngine.TrailRenderer::set_endWidth(float32)
      IL_0022: ret

    } // end of method '<>c__DisplayClass30_0'::'<DOResize>b__1'
  } // end of class '<>c__DisplayClass30_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass31_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.TrailRenderer target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass31_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOTime>b__0'() cil managed
    {
      .maxstack 8

      // [591 87 - 591 98]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::target
      IL_0006: callvirt     instance float32 [UnityEngine]UnityEngine.TrailRenderer::get_time()
      IL_000b: ret

    } // end of method '<>c__DisplayClass31_0'::'<DOTime>b__0'

    .method assembly hidebysig instance void
      '<DOTime>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [591 125 - 591 140]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.TrailRenderer::set_time(float32)
      IL_000c: ret

    } // end of method '<>c__DisplayClass31_0'::'<DOTime>b__1'
  } // end of class '<>c__DisplayClass31_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass32_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass32_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOMove>b__0'() cil managed
    {
      .maxstack 8

      // [607 94 - 607 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass32_0'::'<DOMove>b__0'

    .method assembly hidebysig instance void
      '<DOMove>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [607 138 - 607 157]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass32_0'::'<DOMove>b__1'
  } // end of class '<>c__DisplayClass32_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass33_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass33_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOMoveX>b__0'() cil managed
    {
      .maxstack 8

      // [623 94 - 623 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass33_0'::'<DOMoveX>b__0'

    .method assembly hidebysig instance void
      '<DOMoveX>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [623 138 - 623 157]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass33_0'::'<DOMoveX>b__1'
  } // end of class '<>c__DisplayClass33_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass34_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass34_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOMoveY>b__0'() cil managed
    {
      .maxstack 8

      // [639 94 - 639 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass34_0'::'<DOMoveY>b__0'

    .method assembly hidebysig instance void
      '<DOMoveY>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [639 138 - 639 157]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass34_0'::'<DOMoveY>b__1'
  } // end of class '<>c__DisplayClass34_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass35_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass35_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOMoveZ>b__0'() cil managed
    {
      .maxstack 8

      // [655 94 - 655 109]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass35_0'::'<DOMoveZ>b__0'

    .method assembly hidebysig instance void
      '<DOMoveZ>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [655 138 - 655 157]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass35_0'::'<DOMoveZ>b__1'
  } // end of class '<>c__DisplayClass35_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass36_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass36_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalMove>b__0'() cil managed
    {
      .maxstack 8

      // [671 94 - 671 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass36_0'::'<DOLocalMove>b__0'

    .method assembly hidebysig instance void
      '<DOLocalMove>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [671 143 - 671 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass36_0'::'<DOLocalMove>b__1'
  } // end of class '<>c__DisplayClass36_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass37_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass37_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalMoveX>b__0'() cil managed
    {
      .maxstack 8

      // [687 94 - 687 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass37_0'::'<DOLocalMoveX>b__0'

    .method assembly hidebysig instance void
      '<DOLocalMoveX>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [687 143 - 687 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass37_0'::'<DOLocalMoveX>b__1'
  } // end of class '<>c__DisplayClass37_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass38_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass38_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalMoveY>b__0'() cil managed
    {
      .maxstack 8

      // [703 94 - 703 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass38_0'::'<DOLocalMoveY>b__0'

    .method assembly hidebysig instance void
      '<DOLocalMoveY>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [703 143 - 703 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass38_0'::'<DOLocalMoveY>b__1'
  } // end of class '<>c__DisplayClass38_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass39_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass39_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalMoveZ>b__0'() cil managed
    {
      .maxstack 8

      // [719 94 - 719 114]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass39_0'::'<DOLocalMoveZ>b__0'

    .method assembly hidebysig instance void
      '<DOLocalMoveZ>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [719 143 - 719 167]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass39_0'::'<DOLocalMoveZ>b__1'
  } // end of class '<>c__DisplayClass39_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass40_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass40_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DORotate>b__0'() cil managed
    {
      .maxstack 8

      // [735 104 - 735 119]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_rotation()
      IL_000b: ret

    } // end of method '<>c__DisplayClass40_0'::'<DORotate>b__0'

    .method assembly hidebysig instance void
      '<DORotate>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 8

      // [735 151 - 735 170]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_rotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: ret

    } // end of method '<>c__DisplayClass40_0'::'<DORotate>b__1'
  } // end of class '<>c__DisplayClass40_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass41_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass41_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DORotateQuaternion>b__0'() cil managed
    {
      .maxstack 8

      // [754 215 - 754 230]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_rotation()
      IL_000b: ret

    } // end of method '<>c__DisplayClass41_0'::'<DORotateQuaternion>b__0'

    .method assembly hidebysig instance void
      '<DORotateQuaternion>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 8

      // [754 262 - 754 281]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_rotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: ret

    } // end of method '<>c__DisplayClass41_0'::'<DORotateQuaternion>b__1'
  } // end of class '<>c__DisplayClass41_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass42_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass42_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DOLocalRotate>b__0'() cil managed
    {
      .maxstack 8

      // [770 104 - 770 124]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_localRotation()
      IL_000b: ret

    } // end of method '<>c__DisplayClass42_0'::'<DOLocalRotate>b__0'

    .method assembly hidebysig instance void
      '<DOLocalRotate>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 8

      // [770 156 - 770 180]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: ret

    } // end of method '<>c__DisplayClass42_0'::'<DOLocalRotate>b__1'
  } // end of class '<>c__DisplayClass42_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass43_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass43_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DOLocalRotateQuaternion>b__0'() cil managed
    {
      .maxstack 8

      // [789 215 - 789 235]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_localRotation()
      IL_000b: ret

    } // end of method '<>c__DisplayClass43_0'::'<DOLocalRotateQuaternion>b__0'

    .method assembly hidebysig instance void
      '<DOLocalRotateQuaternion>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 8

      // [789 267 - 789 291]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: ret

    } // end of method '<>c__DisplayClass43_0'::'<DOLocalRotateQuaternion>b__1'
  } // end of class '<>c__DisplayClass43_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass44_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass44_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOScale>b__0'() cil managed
    {
      .maxstack 8

      // [803 94 - 803 111]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass44_0'::'<DOScale>b__0'

    .method assembly hidebysig instance void
      '<DOScale>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [803 140 - 803 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass44_0'::'<DOScale>b__1'
  } // end of class '<>c__DisplayClass44_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass45_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass45_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOScale>b__0'() cil managed
    {
      .maxstack 8

      // [817 94 - 817 111]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass45_0'::'<DOScale>b__0'

    .method assembly hidebysig instance void
      '<DOScale>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [817 140 - 817 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass45_0'::'<DOScale>b__1'
  } // end of class '<>c__DisplayClass45_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass46_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass46_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOScaleX>b__0'() cil managed
    {
      .maxstack 8

      // [831 94 - 831 111]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass46_0'::'<DOScaleX>b__0'

    .method assembly hidebysig instance void
      '<DOScaleX>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [831 140 - 831 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass46_0'::'<DOScaleX>b__1'
  } // end of class '<>c__DisplayClass46_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass47_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass47_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOScaleY>b__0'() cil managed
    {
      .maxstack 8

      // [845 94 - 845 111]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass47_0'::'<DOScaleY>b__0'

    .method assembly hidebysig instance void
      '<DOScaleY>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [845 140 - 845 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass47_0'::'<DOScaleY>b__1'
  } // end of class '<>c__DisplayClass47_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass48_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass48_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOScaleZ>b__0'() cil managed
    {
      .maxstack 8

      // [859 94 - 859 111]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass48_0'::'<DOScaleZ>b__0'

    .method assembly hidebysig instance void
      '<DOScaleZ>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [859 140 - 859 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass48_0'::'<DOScaleZ>b__1'
  } // end of class '<>c__DisplayClass48_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass49_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass49_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DOLookAt>b__0'() cil managed
    {
      .maxstack 8

      // [877 114 - 877 129]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_rotation()
      IL_000b: ret

    } // end of method '<>c__DisplayClass49_0'::'<DOLookAt>b__0'

    .method assembly hidebysig instance void
      '<DOLookAt>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 8

      // [877 161 - 877 180]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_rotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: ret

    } // end of method '<>c__DisplayClass49_0'::'<DOLookAt>b__1'
  } // end of class '<>c__DisplayClass49_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass50_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass50_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOPunchPosition>b__0'() cil managed
    {
      .maxstack 8

      // [901 57 - 901 77]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass50_0'::'<DOPunchPosition>b__0'

    .method assembly hidebysig instance void
      '<DOPunchPosition>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [901 106 - 901 130]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass50_0'::'<DOPunchPosition>b__1'
  } // end of class '<>c__DisplayClass50_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass51_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass51_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOPunchScale>b__0'() cil managed
    {
      .maxstack 8

      // [923 67 - 923 84]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass51_0'::'<DOPunchScale>b__0'

    .method assembly hidebysig instance void
      '<DOPunchScale>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [923 113 - 923 134]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass51_0'::'<DOPunchScale>b__1'
  } // end of class '<>c__DisplayClass51_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass52_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass52_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOPunchRotation>b__0'() cil managed
    {
      .maxstack 8

      // [945 67 - 945 90]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localEulerAngles()
      IL_000b: ret

    } // end of method '<>c__DisplayClass52_0'::'<DOPunchRotation>b__0'

    .method assembly hidebysig instance void
      '<DOPunchRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [945 119 - 945 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0011: ret

    } // end of method '<>c__DisplayClass52_0'::'<DOPunchRotation>b__1'
  } // end of class '<>c__DisplayClass52_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass53_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass53_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakePosition>b__0'() cil managed
    {
      .maxstack 8

      // [969 57 - 969 77]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass53_0'::'<DOShakePosition>b__0'

    .method assembly hidebysig instance void
      '<DOShakePosition>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [969 106 - 969 130]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass53_0'::'<DOShakePosition>b__1'
  } // end of class '<>c__DisplayClass53_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass54_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass54_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakePosition>b__0'() cil managed
    {
      .maxstack 8

      // [993 57 - 993 77]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass54_0'::'<DOShakePosition>b__0'

    .method assembly hidebysig instance void
      '<DOShakePosition>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [993 106 - 993 130]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass54_0'::'<DOShakePosition>b__1'
  } // end of class '<>c__DisplayClass54_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass55_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass55_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeRotation>b__0'() cil managed
    {
      .maxstack 8

      // [1015 67 - 1015 90]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localEulerAngles()
      IL_000b: ret

    } // end of method '<>c__DisplayClass55_0'::'<DOShakeRotation>b__0'

    .method assembly hidebysig instance void
      '<DOShakeRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1015 119 - 1015 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0011: ret

    } // end of method '<>c__DisplayClass55_0'::'<DOShakeRotation>b__1'
  } // end of class '<>c__DisplayClass55_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass56_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass56_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeRotation>b__0'() cil managed
    {
      .maxstack 8

      // [1037 67 - 1037 90]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localEulerAngles()
      IL_000b: ret

    } // end of method '<>c__DisplayClass56_0'::'<DOShakeRotation>b__0'

    .method assembly hidebysig instance void
      '<DOShakeRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1037 119 - 1037 161]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0011: ret

    } // end of method '<>c__DisplayClass56_0'::'<DOShakeRotation>b__1'
  } // end of class '<>c__DisplayClass56_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass57_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass57_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeScale>b__0'() cil managed
    {
      .maxstack 8

      // [1059 67 - 1059 84]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass57_0'::'<DOShakeScale>b__0'

    .method assembly hidebysig instance void
      '<DOShakeScale>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1059 113 - 1059 134]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass57_0'::'<DOShakeScale>b__1'
  } // end of class '<>c__DisplayClass57_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass58_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass58_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOShakeScale>b__0'() cil managed
    {
      .maxstack 8

      // [1082 67 - 1082 84]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_000b: ret

    } // end of method '<>c__DisplayClass58_0'::'<DOShakeScale>b__0'

    .method assembly hidebysig instance void
      '<DOShakeScale>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1082 113 - 1082 134]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass58_0'::'<DOShakeScale>b__1'
  } // end of class '<>c__DisplayClass58_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass59_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .field public float32 startPosY

    .field public bool offsetYSet

    .field public float32 offsetY

    .field public class DG.Tweening.Sequence s

    .field public valuetype [UnityEngine]UnityEngine.Vector3 endValue

    .field public class DG.Tweening.Tween yTween

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass59_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOJump>b__0'() cil managed
    {
      .maxstack 8

      // [1110 68 - 1110 83]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__0'

    .method assembly hidebysig instance void
      '<DOJump>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1110 112 - 1110 131]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__1'

    .method assembly hidebysig instance void
      '<DOJump>b__2'() cil managed
    {
      .maxstack 8

      // [1110 385 - 1110 414]
      IL_0000: ldarg.0      // this
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0007: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000c: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0011: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::startPosY
      IL_0016: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__2'

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOJump>b__3'() cil managed
    {
      .maxstack 8

      // [1111 62 - 1111 77]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__3'

    .method assembly hidebysig instance void
      '<DOJump>b__4'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1111 106 - 1111 125]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__4'

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOJump>b__5'() cil managed
    {
      .maxstack 8

      // [1111 296 - 1111 311]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__5'

    .method assembly hidebysig instance void
      '<DOJump>b__6'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1111 340 - 1111 359]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__6'

    .method assembly hidebysig instance void
      '<DOJump>b__7'() cil managed
    {
      .maxstack 6
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Vector3 position
      )

      // [1114 9 - 1114 25]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetYSet
      IL_0006: brtrue.s     IL_0041

      // [1116 11 - 1116 28]
      IL_0008: ldarg.0      // this
      IL_0009: ldc.i4.1
      IL_000a: stfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetYSet

      // [1117 11 - 1117 71]
      IL_000f: ldarg.0      // this
      IL_0010: ldarg.0      // this
      IL_0011: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::s
      IL_0016: callvirt     instance bool DG.Tweening.Tween::get_isRelative()
      IL_001b: brtrue.s     IL_0031

      IL_001d: ldarg.0      // this
      IL_001e: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::endValue
      IL_0023: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0028: ldarg.0      // this
      IL_0029: ldfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::startPosY
      IL_002e: sub
      IL_002f: br.s         IL_003c
      IL_0031: ldarg.0      // this
      IL_0032: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::endValue
      IL_0037: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_003c: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetY

      // [1119 9 - 1119 43]
      IL_0041: ldarg.0      // this
      IL_0042: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_0047: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_004c: stloc.0      // position

      // [1120 9 - 1120 100]
      IL_004d: ldloca.s     position
      IL_004f: ldflda       float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0054: dup
      IL_0055: ldind.r4
      IL_0056: ldc.r4       0.0
      IL_005b: ldarg.0      // this
      IL_005c: ldfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetY
      IL_0061: ldarg.0      // this
      IL_0062: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::yTween
      IL_0067: ldc.i4.1
      IL_0068: call         float32 DG.Tweening.TweenExtensions::ElapsedPercentage(class DG.Tweening.Tween, bool)
      IL_006d: ldc.i4.6
      IL_006e: call         float32 DG.Tweening.DOVirtual::EasedValue(float32, float32, float32, valuetype DG.Tweening.Ease)
      IL_0073: add
      IL_0074: stind.r4

      // [1121 9 - 1121 35]
      IL_0075: ldarg.0      // this
      IL_0076: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
      IL_007b: ldloc.0      // position
      IL_007c: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0081: ret

    } // end of method '<>c__DisplayClass59_0'::'<DOJump>b__7'
  } // end of class '<>c__DisplayClass59_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass60_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .field public bool offsetYSet

    .field public float32 offsetY

    .field public class DG.Tweening.Sequence s

    .field public valuetype [UnityEngine]UnityEngine.Vector3 endValue

    .field public float32 startPosY

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass60_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalJump>b__0'() cil managed
    {
      .maxstack 8

      // [1148 62 - 1148 82]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__0'

    .method assembly hidebysig instance void
      '<DOLocalJump>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1148 111 - 1148 135]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__1'

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalJump>b__2'() cil managed
    {
      .maxstack 8

      // [1148 306 - 1148 326]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__2'

    .method assembly hidebysig instance void
      '<DOLocalJump>b__3'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1148 355 - 1148 379]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__3'

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalJump>b__4'() cil managed
    {
      .maxstack 8

      // [1148 550 - 1148 570]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__4'

    .method assembly hidebysig instance void
      '<DOLocalJump>b__5'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1148 599 - 1148 623]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__5'

    .method assembly hidebysig instance void
      '<DOLocalJump>b__6'() cil managed
    {
      .maxstack 6
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Vector3 localPosition
      )

      // [1150 9 - 1150 25]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetYSet
      IL_0006: brtrue.s     IL_0041

      // [1152 11 - 1152 29]
      IL_0008: ldarg.0      // this
      IL_0009: ldc.i4.0
      IL_000a: stfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetYSet

      // [1153 11 - 1153 71]
      IL_000f: ldarg.0      // this
      IL_0010: ldarg.0      // this
      IL_0011: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::s
      IL_0016: callvirt     instance bool DG.Tweening.Tween::get_isRelative()
      IL_001b: brtrue.s     IL_0031

      IL_001d: ldarg.0      // this
      IL_001e: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::endValue
      IL_0023: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0028: ldarg.0      // this
      IL_0029: ldfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::startPosY
      IL_002e: sub
      IL_002f: br.s         IL_003c
      IL_0031: ldarg.0      // this
      IL_0032: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::endValue
      IL_0037: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_003c: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetY

      // [1155 9 - 1155 53]
      IL_0041: ldarg.0      // this
      IL_0042: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_0047: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_004c: stloc.0      // localPosition

      // [1156 9 - 1156 111]
      IL_004d: ldloca.s     localPosition
      IL_004f: ldflda       float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0054: dup
      IL_0055: ldind.r4
      IL_0056: ldc.r4       0.0
      IL_005b: ldarg.0      // this
      IL_005c: ldfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetY
      IL_0061: ldarg.0      // this
      IL_0062: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::s
      IL_0067: call         float32 DG.Tweening.TweenExtensions::ElapsedDirectionalPercentage(class DG.Tweening.Tween)
      IL_006c: ldc.i4.6
      IL_006d: call         float32 DG.Tweening.DOVirtual::EasedValue(float32, float32, float32, valuetype DG.Tweening.Ease)
      IL_0072: add
      IL_0073: stind.r4

      // [1157 9 - 1157 45]
      IL_0074: ldarg.0      // this
      IL_0075: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
      IL_007a: ldloc.0      // localPosition
      IL_007b: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0080: ret

    } // end of method '<>c__DisplayClass60_0'::'<DOLocalJump>b__6'
  } // end of class '<>c__DisplayClass60_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass61_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass61_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOPath>b__0'() cil managed
    {
      .maxstack 8

      // [1182 145 - 1182 160]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass61_0'::'<DOPath>b__0'

    .method assembly hidebysig instance void
      '<DOPath>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1182 189 - 1182 208]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass61_0'::'<DOPath>b__1'
  } // end of class '<>c__DisplayClass61_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass62_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass62_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalPath>b__0'() cil managed
    {
      .maxstack 8

      // [1207 145 - 1207 165]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass62_0'::'<DOLocalPath>b__0'

    .method assembly hidebysig instance void
      '<DOLocalPath>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1207 194 - 1207 218]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass62_0'::'<DOLocalPath>b__1'
  } // end of class '<>c__DisplayClass62_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass63_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass63_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOPath>b__0'() cil managed
    {
      .maxstack 8

      // [1225 145 - 1225 160]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_000b: ret

    } // end of method '<>c__DisplayClass63_0'::'<DOPath>b__0'

    .method assembly hidebysig instance void
      '<DOPath>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1225 189 - 1225 208]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass63_0'::'<DOPath>b__1'
  } // end of class '<>c__DisplayClass63_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass64_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass64_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOLocalPath>b__0'() cil managed
    {
      .maxstack 8

      // [1242 145 - 1242 165]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::target
      IL_0006: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_000b: ret

    } // end of method '<>c__DisplayClass64_0'::'<DOLocalPath>b__0'

    .method assembly hidebysig instance void
      '<DOLocalPath>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 8

      // [1242 194 - 1242 218]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: ret

    } // end of method '<>c__DisplayClass64_0'::'<DOLocalPath>b__1'
  } // end of class '<>c__DisplayClass64_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass65_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public class DG.Tweening.Tween target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass65_0'::.ctor

    .method assembly hidebysig instance float32
      '<DOTimeScale>b__0'() cil managed
    {
      .maxstack 8

      // [1257 87 - 1257 103]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::target
      IL_0006: ldfld        float32 DG.Tweening.Tween::timeScale
      IL_000b: ret

    } // end of method '<>c__DisplayClass65_0'::'<DOTimeScale>b__0'

    .method assembly hidebysig instance void
      '<DOTimeScale>b__1'(
        float32 x
      ) cil managed
    {
      .maxstack 8

      // [1257 130 - 1257 150]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::target
      IL_0006: ldarg.1      // x
      IL_0007: stfld        float32 DG.Tweening.Tween::timeScale
      IL_000c: ret

    } // end of method '<>c__DisplayClass65_0'::'<DOTimeScale>b__1'
  } // end of class '<>c__DisplayClass65_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass66_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Color 'to'

    .field public class [UnityEngine]UnityEngine.Light target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass66_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOBlendableColor>b__0'() cil managed
    {
      .maxstack 8

      // [1275 60 - 1275 62]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass66_0'::'<DOBlendableColor>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Color color
      )

      // [1277 9 - 1277 29]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: stloc.0      // color

      // [1278 9 - 1278 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'to'

      // [1279 9 - 1279 30]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::target
      IL_001a: dup
      IL_001b: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Light::get_color()
      IL_0020: ldloc.0      // color
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Addition(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_0026: callvirt     instance void [UnityEngine]UnityEngine.Light::set_color(valuetype [UnityEngine]UnityEngine.Color)
      IL_002b: ret

    } // end of method '<>c__DisplayClass66_0'::'<DOBlendableColor>b__1'
  } // end of class '<>c__DisplayClass66_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass67_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Color 'to'

    .field public class [UnityEngine]UnityEngine.Material target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass67_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOBlendableColor>b__0'() cil managed
    {
      .maxstack 8

      // [1296 60 - 1296 62]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass67_0'::'<DOBlendableColor>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Color color
      )

      // [1298 9 - 1298 29]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: stloc.0      // color

      // [1299 9 - 1299 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'to'

      // [1300 9 - 1300 30]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::target
      IL_001a: dup
      IL_001b: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::get_color()
      IL_0020: ldloc.0      // color
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Addition(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_0026: callvirt     instance void [UnityEngine]UnityEngine.Material::set_color(valuetype [UnityEngine]UnityEngine.Color)
      IL_002b: ret

    } // end of method '<>c__DisplayClass67_0'::'<DOBlendableColor>b__1'
  } // end of class '<>c__DisplayClass67_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass68_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Color 'to'

    .field public class [UnityEngine]UnityEngine.Material target

    .field public string 'property'

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass68_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOBlendableColor>b__0'() cil managed
    {
      .maxstack 8

      // [1325 60 - 1325 62]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass68_0'::'<DOBlendableColor>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 4
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Color color
      )

      // [1327 9 - 1327 29]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: stloc.0      // color

      // [1328 9 - 1328 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'to'

      // [1329 9 - 1329 69]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
      IL_001a: ldarg.0      // this
      IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'
      IL_0020: ldarg.0      // this
      IL_0021: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
      IL_0026: ldarg.0      // this
      IL_0027: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'
      IL_002c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(string)
      IL_0031: ldloc.0      // color
      IL_0032: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Addition(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_0037: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(string, valuetype [UnityEngine]UnityEngine.Color)
      IL_003c: ret

    } // end of method '<>c__DisplayClass68_0'::'<DOBlendableColor>b__1'
  } // end of class '<>c__DisplayClass68_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass69_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Color 'to'

    .field public class [UnityEngine]UnityEngine.Material target

    .field public int32 propertyID

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass69_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Color
      '<DOBlendableColor>b__0'() cil managed
    {
      .maxstack 8

      // [1354 60 - 1354 62]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass69_0'::'<DOBlendableColor>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableColor>b__1'(
        valuetype [UnityEngine]UnityEngine.Color x
      ) cil managed
    {
      .maxstack 4
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Color color
      )

      // [1356 9 - 1356 29]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_000c: stloc.0      // color

      // [1357 9 - 1357 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'to'

      // [1358 9 - 1358 73]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
      IL_001a: ldarg.0      // this
      IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID
      IL_0020: ldarg.0      // this
      IL_0021: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
      IL_0026: ldarg.0      // this
      IL_0027: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID
      IL_002c: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(int32)
      IL_0031: ldloc.0      // color
      IL_0032: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Addition(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
      IL_0037: callvirt     instance void [UnityEngine]UnityEngine.Material::SetColor(int32, valuetype [UnityEngine]UnityEngine.Color)
      IL_003c: ret

    } // end of method '<>c__DisplayClass69_0'::'<DOBlendableColor>b__1'
  } // end of class '<>c__DisplayClass69_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass70_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Vector3 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass70_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOBlendableMoveBy>b__0'() cil managed
    {
      .maxstack 8

      // [1376 52 - 1376 54]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass70_0'::'<DOBlendableMoveBy>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableMoveBy>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Vector3 vector3
      )

      // [1378 9 - 1378 33]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Subtraction(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: stloc.0      // vector3

      // [1379 9 - 1379 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'to'

      // [1380 9 - 1380 35]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::target
      IL_001a: dup
      IL_001b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_position()
      IL_0020: ldloc.0      // vector3
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Addition(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0026: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_position(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_002b: ret

    } // end of method '<>c__DisplayClass70_0'::'<DOBlendableMoveBy>b__1'
  } // end of class '<>c__DisplayClass70_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass71_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Vector3 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass71_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOBlendableLocalMoveBy>b__0'() cil managed
    {
      .maxstack 8

      // [1398 52 - 1398 54]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass71_0'::'<DOBlendableLocalMoveBy>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableLocalMoveBy>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Vector3 vector3
      )

      // [1400 9 - 1400 33]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Subtraction(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: stloc.0      // vector3

      // [1401 9 - 1401 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'to'

      // [1402 9 - 1402 40]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::target
      IL_001a: dup
      IL_001b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
      IL_0020: ldloc.0      // vector3
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Addition(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0026: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localPosition(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_002b: ret

    } // end of method '<>c__DisplayClass71_0'::'<DOBlendableLocalMoveBy>b__1'
  } // end of class '<>c__DisplayClass71_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass72_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Quaternion 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass72_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DOBlendableRotateBy>b__0'() cil managed
    {
      .maxstack 8

      // [1420 114 - 1420 116]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass72_0'::'<DOBlendableRotateBy>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableRotateBy>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Quaternion quaternion,
        [1] valuetype [UnityEngine]UnityEngine.Quaternion rotation
      )

      // [1422 9 - 1422 59]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0011: stloc.0      // quaternion

      // [1423 9 - 1423 15]
      IL_0012: ldarg.0      // this
      IL_0013: ldarg.1      // x
      IL_0014: stfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'to'

      // [1424 9 - 1424 46]
      IL_0019: ldarg.0      // this
      IL_001a: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::target
      IL_001f: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_rotation()
      IL_0024: stloc.1      // rotation

      // [1425 9 - 1425 90]
      IL_0025: ldarg.0      // this
      IL_0026: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::target
      IL_002b: ldloc.1      // rotation
      IL_002c: ldloc.1      // rotation
      IL_002d: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0032: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0037: ldloc.0      // quaternion
      IL_0038: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_003d: ldloc.1      // rotation
      IL_003e: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0043: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_rotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0048: ret

    } // end of method '<>c__DisplayClass72_0'::'<DOBlendableRotateBy>b__1'
  } // end of class '<>c__DisplayClass72_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass73_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Quaternion 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass73_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Quaternion
      '<DOBlendableLocalRotateBy>b__0'() cil managed
    {
      .maxstack 8

      // [1445 114 - 1445 116]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass73_0'::'<DOBlendableLocalRotateBy>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableLocalRotateBy>b__1'(
        valuetype [UnityEngine]UnityEngine.Quaternion x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Quaternion quaternion,
        [1] valuetype [UnityEngine]UnityEngine.Quaternion localRotation
      )

      // [1447 9 - 1447 59]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_000c: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0011: stloc.0      // quaternion

      // [1448 9 - 1448 15]
      IL_0012: ldarg.0      // this
      IL_0013: ldarg.1      // x
      IL_0014: stfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'to'

      // [1449 9 - 1449 56]
      IL_0019: ldarg.0      // this
      IL_001a: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::target
      IL_001f: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_localRotation()
      IL_0024: stloc.1      // localRotation

      // [1450 9 - 1450 110]
      IL_0025: ldarg.0      // this
      IL_0026: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::target
      IL_002b: ldloc.1      // localRotation
      IL_002c: ldloc.1      // localRotation
      IL_002d: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0032: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0037: ldloc.0      // quaternion
      IL_0038: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_003d: ldloc.1      // localRotation
      IL_003e: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0043: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localRotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0048: ret

    } // end of method '<>c__DisplayClass73_0'::'<DOBlendableLocalRotateBy>b__1'
  } // end of class '<>c__DisplayClass73_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass74_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Vector3 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass74_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOBlendablePunchRotation>b__0'() cil managed
    {
      .maxstack 8

      // [1479 65 - 1479 67]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass74_0'::'<DOBlendablePunchRotation>b__0'

    .method assembly hidebysig instance void
      '<DOBlendablePunchRotation>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 v
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Quaternion rotation1,
        [1] valuetype [UnityEngine]UnityEngine.Quaternion quaternion,
        [2] valuetype [UnityEngine]UnityEngine.Quaternion rotation2
      )

      // [1481 9 - 1481 66]
      IL_0000: ldarg.0      // this
      IL_0001: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'
      IL_0006: ldfld        float32 [UnityEngine]UnityEngine.Vector3::x
      IL_000b: ldarg.0      // this
      IL_000c: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'
      IL_0011: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0016: ldarg.0      // this
      IL_0017: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'
      IL_001c: ldfld        float32 [UnityEngine]UnityEngine.Vector3::z
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(float32, float32, float32)
      IL_0026: stloc.0      // rotation1

      // [1482 9 - 1482 96]
      IL_0027: ldarg.1      // v
      IL_0028: ldfld        float32 [UnityEngine]UnityEngine.Vector3::x
      IL_002d: ldarg.1      // v
      IL_002e: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
      IL_0033: ldarg.1      // v
      IL_0034: ldfld        float32 [UnityEngine]UnityEngine.Vector3::z
      IL_0039: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Euler(float32, float32, float32)
      IL_003e: ldloc.0      // rotation1
      IL_003f: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0044: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0049: stloc.1      // quaternion

      // [1483 9 - 1483 15]
      IL_004a: ldarg.0      // this
      IL_004b: ldarg.1      // v
      IL_004c: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'

      // [1484 9 - 1484 47]
      IL_0051: ldarg.0      // this
      IL_0052: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::target
      IL_0057: callvirt     instance valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Transform::get_rotation()
      IL_005c: stloc.2      // rotation2

      // [1485 9 - 1485 93]
      IL_005d: ldarg.0      // this
      IL_005e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::target
      IL_0063: ldloc.2      // rotation2
      IL_0064: ldloc.2      // rotation2
      IL_0065: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::Inverse(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_006a: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_006f: ldloc.1      // quaternion
      IL_0070: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0075: ldloc.2      // rotation2
      IL_0076: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::op_Multiply(valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_007b: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_rotation(valuetype [UnityEngine]UnityEngine.Quaternion)
      IL_0080: ret

    } // end of method '<>c__DisplayClass74_0'::'<DOBlendablePunchRotation>b__1'
  } // end of class '<>c__DisplayClass74_0'

  .class nested private sealed auto ansi beforefieldinit
    '<>c__DisplayClass75_0'
      extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = (01 00 00 00 )

    .field public valuetype [UnityEngine]UnityEngine.Vector3 'to'

    .field public class [UnityEngine]UnityEngine.Transform target

    .method public hidebysig specialname rtspecialname instance void
      .ctor() cil managed
    {
      .maxstack 8

      IL_0000: ldarg.0      // this
      IL_0001: call         instance void [mscorlib]System.Object::.ctor()
      IL_0006: ret

    } // end of method '<>c__DisplayClass75_0'::.ctor

    .method assembly hidebysig instance valuetype [UnityEngine]UnityEngine.Vector3
      '<DOBlendableScaleBy>b__0'() cil managed
    {
      .maxstack 8

      // [1501 62 - 1501 64]
      IL_0000: ldarg.0      // this
      IL_0001: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'to'
      IL_0006: ret

    } // end of method '<>c__DisplayClass75_0'::'<DOBlendableScaleBy>b__0'

    .method assembly hidebysig instance void
      '<DOBlendableScaleBy>b__1'(
        valuetype [UnityEngine]UnityEngine.Vector3 x
      ) cil managed
    {
      .maxstack 3
      .locals init (
        [0] valuetype [UnityEngine]UnityEngine.Vector3 vector3
      )

      // [1503 9 - 1503 33]
      IL_0000: ldarg.1      // x
      IL_0001: ldarg.0      // this
      IL_0002: ldfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'to'
      IL_0007: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Subtraction(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_000c: stloc.0      // vector3

      // [1504 9 - 1504 15]
      IL_000d: ldarg.0      // this
      IL_000e: ldarg.1      // x
      IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'to'

      // [1505 9 - 1505 37]
      IL_0014: ldarg.0      // this
      IL_0015: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::target
      IL_001a: dup
      IL_001b: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localScale()
      IL_0020: ldloc.0      // vector3
      IL_0021: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::op_Addition(valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3)
      IL_0026: callvirt     instance void [UnityEngine]UnityEngine.Transform::set_localScale(valuetype [UnityEngine]UnityEngine.Vector3)
      IL_002b: ret

    } // end of method '<>c__DisplayClass75_0'::'<DOBlendableScaleBy>b__1'
  } // end of class '<>c__DisplayClass75_0'

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOAspect(
      class [UnityEngine]UnityEngine.Camera target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::target

    // [32 7 - 32 166]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::'<DOAspect>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::'<DOAspect>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [33 7 - 33 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass0_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [34 7 - 34 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOAspect

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOColor(
      class [UnityEngine]UnityEngine.Camera target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::target

    // [46 7 - 46 184]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::'<DOColor>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::'<DOColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_002c: dup

    // [47 7 - 47 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass1_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0038: pop

    // [48 7 - 48 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOFarClipPlane(
      class [UnityEngine]UnityEngine.Camera target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::target

    // [60 7 - 60 178]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::'<DOFarClipPlane>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::'<DOFarClipPlane>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [61 7 - 61 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass2_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [62 7 - 62 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOFarClipPlane

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOFieldOfView(
      class [UnityEngine]UnityEngine.Camera target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::target

    // [74 7 - 74 176]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::'<DOFieldOfView>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::'<DOFieldOfView>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [75 7 - 75 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass3_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [76 7 - 76 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOFieldOfView

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DONearClipPlane(
      class [UnityEngine]UnityEngine.Camera target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::target

    // [88 7 - 88 180]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::'<DONearClipPlane>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::'<DONearClipPlane>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [89 7 - 89 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass4_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [90 7 - 90 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DONearClipPlane

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOOrthoSize(
      class [UnityEngine]UnityEngine.Camera target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::target

    // [102 7 - 102 186]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::'<DOOrthoSize>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::'<DOOrthoSize>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [103 7 - 103 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass5_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [104 7 - 104 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOOrthoSize

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>
    DOPixelRect(
      class [UnityEngine]UnityEngine.Camera target,
      valuetype [UnityEngine]UnityEngine.Rect endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::target

    // [116 7 - 116 167]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Rect DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::'<DOPixelRect>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Rect>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::'<DOPixelRect>b__1'(valuetype [UnityEngine]UnityEngine.Rect)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Rect>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Rect>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Rect>, valuetype [UnityEngine]UnityEngine.Rect, float32)
    IL_002c: dup

    // [117 7 - 117 73]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass6_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>*/, object)
    IL_0038: pop

    // [118 7 - 118 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOPixelRect

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>
    DORect(
      class [UnityEngine]UnityEngine.Camera target,
      valuetype [UnityEngine]UnityEngine.Rect endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::target

    // [130 7 - 130 157]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Rect DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::'<DORect>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Rect>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::'<DORect>b__1'(valuetype [UnityEngine]UnityEngine.Rect)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Rect>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Rect>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Rect>, valuetype [UnityEngine]UnityEngine.Rect, float32)
    IL_002c: dup

    // [131 7 - 131 73]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass7_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Rect, valuetype [UnityEngine]UnityEngine.Rect, valuetype DG.Tweening.Plugins.Options.RectOptions>*/, object)
    IL_0038: pop

    // [132 7 - 132 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DORect

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakePosition(
      class [UnityEngine]UnityEngine.Camera target,
      float32 duration,
      [opt] float32 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = float32(3)
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 8
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::target

    // [151 7 - 151 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [153 7 - 153 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [154 9 - 154 115]
    IL_001d: ldstr        "DOShakePosition: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [155 7 - 155 29]
    IL_0027: ldnull
    IL_0028: ret

    // [152 9 - 152 422]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::'<DOShakePosition>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::'<DOShakePosition>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldc.i4.1
    IL_0047: ldarg.s      fadeOut
    IL_0049: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, float32, int32, float32, bool, bool)
    IL_004e: ldloc.0      // V_0
    IL_004f: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass8_0'::target
    IL_0054: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0059: ldc.i4.4
    IL_005a: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005f: ret

  } // end of method ShortcutExtensions::DOShakePosition

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakePosition(
      class [UnityEngine]UnityEngine.Camera target,
      float32 duration,
      valuetype [UnityEngine]UnityEngine.Vector3 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::target

    // [174 7 - 174 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [176 7 - 176 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [177 9 - 177 115]
    IL_001d: ldstr        "DOShakePosition: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [178 7 - 178 29]
    IL_0027: ldnull
    IL_0028: ret

    // [175 9 - 175 413]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::'<DOShakePosition>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::'<DOShakePosition>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldarg.s      fadeOut
    IL_0048: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, valuetype [UnityEngine]UnityEngine.Vector3, int32, float32, bool)
    IL_004d: ldloc.0      // V_0
    IL_004e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass9_0'::target
    IL_0053: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0058: ldc.i4.4
    IL_0059: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005e: ret

  } // end of method ShortcutExtensions::DOShakePosition

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeRotation(
      class [UnityEngine]UnityEngine.Camera target,
      float32 duration,
      [opt] float32 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = float32(90)
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 8
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::target

    // [197 7 - 197 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [199 7 - 199 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [200 9 - 200 115]
    IL_001d: ldstr        "DOShakeRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [201 7 - 201 29]
    IL_0027: ldnull
    IL_0028: ret

    // [198 9 - 198 427]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::'<DOShakeRotation>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::'<DOShakeRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldc.i4.0
    IL_0047: ldarg.s      fadeOut
    IL_0049: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, float32, int32, float32, bool, bool)
    IL_004e: ldloc.0      // V_0
    IL_004f: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass10_0'::target
    IL_0054: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0059: ldc.i4.2
    IL_005a: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005f: ret

  } // end of method ShortcutExtensions::DOShakeRotation

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeRotation(
      class [UnityEngine]UnityEngine.Camera target,
      float32 duration,
      valuetype [UnityEngine]UnityEngine.Vector3 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::target

    // [220 7 - 220 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [222 7 - 222 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [223 9 - 223 115]
    IL_001d: ldstr        "DOShakeRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [224 7 - 224 29]
    IL_0027: ldnull
    IL_0028: ret

    // [221 9 - 221 420]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::'<DOShakeRotation>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::'<DOShakeRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldarg.s      fadeOut
    IL_0048: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, valuetype [UnityEngine]UnityEngine.Vector3, int32, float32, bool)
    IL_004d: ldloc.0      // V_0
    IL_004e: ldfld        class [UnityEngine]UnityEngine.Camera DG.Tweening.ShortcutExtensions/'<>c__DisplayClass11_0'::target
    IL_0053: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0058: ldc.i4.2
    IL_0059: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005e: ret

  } // end of method ShortcutExtensions::DOShakeRotation

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOColor(
      class [UnityEngine]UnityEngine.Light target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::target

    // [236 7 - 236 164]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::'<DOColor>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::'<DOColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_002c: dup

    // [237 7 - 237 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass12_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0038: pop

    // [238 7 - 238 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOIntensity(
      class [UnityEngine]UnityEngine.Light target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::target

    // [250 7 - 250 172]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::'<DOIntensity>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::'<DOIntensity>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [251 7 - 251 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass13_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [252 7 - 252 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOIntensity

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOShadowStrength(
      class [UnityEngine]UnityEngine.Light target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::target

    // [264 7 - 264 182]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::'<DOShadowStrength>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::'<DOShadowStrength>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [265 7 - 265 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass14_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [266 7 - 266 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOShadowStrength

  .method public hidebysig static class DG.Tweening.Tweener
    DOColor(
      class [UnityEngine]UnityEngine.LineRenderer target,
      valuetype DG.Tweening.Color2 startValue,
      valuetype DG.Tweening.Color2 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.1      // startValue
    IL_0008: stfld        valuetype DG.Tweening.Color2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::startValue
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.0      // target
    IL_000f: stfld        class [UnityEngine]UnityEngine.LineRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::target

    // [282 7 - 282 220]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldftn        instance valuetype DG.Tweening.Color2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::'<DOColor>b__0'()
    IL_001b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype DG.Tweening.Color2>::.ctor(object, native int)
    IL_0020: ldloc.0      // V_0
    IL_0021: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::'<DOColor>b__1'(valuetype DG.Tweening.Color2)
    IL_0027: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype DG.Tweening.Color2>::.ctor(object, native int)
    IL_002c: ldarg.2      // endValue
    IL_002d: ldarg.3      // duration
    IL_002e: call         class DG.Tweening.Core.TweenerCore`3<valuetype DG.Tweening.Color2, valuetype DG.Tweening.Color2, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype DG.Tweening.Color2>, class DG.Tweening.Core.DOSetter`1<valuetype DG.Tweening.Color2>, valuetype DG.Tweening.Color2, float32)
    IL_0033: ldloc.0      // V_0
    IL_0034: ldfld        class [UnityEngine]UnityEngine.LineRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass15_0'::target
    IL_0039: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype DG.Tweening.Color2, valuetype DG.Tweening.Color2, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype DG.Tweening.Color2, valuetype DG.Tweening.Color2, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype DG.Tweening.Color2, valuetype DG.Tweening.Color2, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_003e: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::target

    // [294 7 - 294 164]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::'<DOColor>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::'<DOColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_002c: dup

    // [295 7 - 295 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass16_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0038: pop

    // [296 7 - 296 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'property'

    // [310 7 - 310 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [312 9 - 312 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [313 11 - 313 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [314 9 - 314 63]
    IL_003a: ldnull
    IL_003b: ret

    // [316 7 - 316 189]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'<DOColor>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::'<DOColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_005b: dup

    // [317 7 - 317 76]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass17_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0067: pop

    // [318 7 - 318 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      int32 propertyID,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // propertyID
    IL_000f: stfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::propertyID

    // [332 7 - 332 43]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::propertyID
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(int32)
    IL_0025: brtrue.s     IL_003c

    // [334 9 - 334 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [335 11 - 335 58]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::propertyID
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(int32)

    // [336 9 - 336 63]
    IL_003a: ldnull
    IL_003b: ret

    // [338 7 - 338 193]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::'<DOColor>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::'<DOColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_005b: dup

    // [339 7 - 339 76]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass18_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0067: pop

    // [340 7 - 340 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOColor

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOFade(
      class [UnityEngine]UnityEngine.Material target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::target

    // [353 7 - 353 173]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::'<DOFade>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::'<DOFade>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::ToAlpha(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, float32, float32)
    IL_002c: dup

    // [354 7 - 354 80]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass19_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0038: pop

    // [355 7 - 355 20]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOFade

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOFade(
      class [UnityEngine]UnityEngine.Material target,
      float32 endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'property'

    // [370 7 - 370 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [372 9 - 372 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [373 11 - 373 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [374 9 - 374 63]
    IL_003a: ldnull
    IL_003b: ret

    // [376 7 - 376 198]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'<DOFade>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::'<DOFade>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::ToAlpha(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, float32, float32)
    IL_005b: dup

    // [377 7 - 377 80]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass20_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0067: pop

    // [378 7 - 378 20]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOFade

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>
    DOFade(
      class [UnityEngine]UnityEngine.Material target,
      float32 endValue,
      int32 propertyID,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // propertyID
    IL_000f: stfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::propertyID

    // [393 7 - 393 43]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::propertyID
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(int32)
    IL_0025: brtrue.s     IL_003c

    // [395 9 - 395 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [396 11 - 396 58]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::propertyID
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(int32)

    // [397 9 - 397 63]
    IL_003a: ldnull
    IL_003b: ret

    // [399 7 - 399 202]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::'<DOFade>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::'<DOFade>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::ToAlpha(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, float32, float32)
    IL_005b: dup

    // [400 7 - 400 80]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass21_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_0067: pop

    // [401 7 - 401 20]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOFade

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOFloat(
      class [UnityEngine]UnityEngine.Material target,
      float32 endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'property'

    // [415 7 - 415 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [417 9 - 417 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [418 11 - 418 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [419 9 - 419 63]
    IL_003a: ldnull
    IL_003b: ret

    // [421 7 - 421 189]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'<DOFloat>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::'<DOFloat>b__1'(float32)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_005b: dup

    // [422 7 - 422 76]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass22_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0067: pop

    // [423 7 - 423 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOFloat

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOFloat(
      class [UnityEngine]UnityEngine.Material target,
      float32 endValue,
      int32 propertyID,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // propertyID
    IL_000f: stfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::propertyID

    // [437 7 - 437 43]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::propertyID
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(int32)
    IL_0025: brtrue.s     IL_003c

    // [439 9 - 439 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [440 11 - 440 58]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::propertyID
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(int32)

    // [441 9 - 441 63]
    IL_003a: ldnull
    IL_003b: ret

    // [443 7 - 443 193]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::'<DOFloat>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::'<DOFloat>b__1'(float32)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_005b: dup

    // [444 7 - 444 76]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass23_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0067: pop

    // [445 7 - 445 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOFloat

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOOffset(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector2 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::target

    // [457 7 - 457 197]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::'<DOOffset>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::'<DOOffset>b__1'(valuetype [UnityEngine]UnityEngine.Vector2)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, valuetype [UnityEngine]UnityEngine.Vector2, float32)
    IL_002c: dup

    // [458 7 - 458 81]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass24_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0038: pop

    // [459 7 - 459 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOOffset

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOOffset(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector2 endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'property'

    // [473 7 - 473 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [475 9 - 475 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [476 11 - 476 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [477 9 - 477 68]
    IL_003a: ldnull
    IL_003b: ret

    // [479 7 - 479 214]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'<DOOffset>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::'<DOOffset>b__1'(valuetype [UnityEngine]UnityEngine.Vector2)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, valuetype [UnityEngine]UnityEngine.Vector2, float32)
    IL_005b: dup

    // [480 7 - 480 81]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass25_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0067: pop

    // [481 7 - 481 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOOffset

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOTiling(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector2 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::target

    // [493 7 - 493 195]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::'<DOTiling>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::'<DOTiling>b__1'(valuetype [UnityEngine]UnityEngine.Vector2)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, valuetype [UnityEngine]UnityEngine.Vector2, float32)
    IL_002c: dup

    // [494 7 - 494 81]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass26_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0038: pop

    // [495 7 - 495 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOTiling

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOTiling(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector2 endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'property'

    // [509 7 - 509 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [511 9 - 511 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [512 11 - 512 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [513 9 - 513 68]
    IL_003a: ldnull
    IL_003b: ret

    // [515 7 - 515 212]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'<DOTiling>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::'<DOTiling>b__1'(valuetype [UnityEngine]UnityEngine.Vector2)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, valuetype [UnityEngine]UnityEngine.Vector2, float32)
    IL_005b: dup

    // [516 7 - 516 81]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass27_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0067: pop

    // [517 7 - 517 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOTiling

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOVector(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector4 endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'property'

    // [531 7 - 531 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [533 9 - 533 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [534 11 - 534 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [535 9 - 535 68]
    IL_003a: ldnull
    IL_003b: ret

    // [537 7 - 537 200]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector4 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'<DOVector>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector4>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::'<DOVector>b__1'(valuetype [UnityEngine]UnityEngine.Vector4)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector4>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector4>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector4>, valuetype [UnityEngine]UnityEngine.Vector4, float32)
    IL_005b: dup

    // [538 7 - 538 81]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass28_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0067: pop

    // [539 7 - 539 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOVector

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOVector(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Vector4 endValue,
      int32 propertyID,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // propertyID
    IL_000f: stfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::propertyID

    // [553 7 - 553 43]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::propertyID
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(int32)
    IL_0025: brtrue.s     IL_003c

    // [555 9 - 555 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [556 11 - 556 58]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::propertyID
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(int32)

    // [557 9 - 557 68]
    IL_003a: ldnull
    IL_003b: ret

    // [559 7 - 559 204]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector4 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::'<DOVector>b__0'()
    IL_0043: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector4>::.ctor(object, native int)
    IL_0048: ldloc.0      // V_0
    IL_0049: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::'<DOVector>b__1'(valuetype [UnityEngine]UnityEngine.Vector4)
    IL_004f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector4>::.ctor(object, native int)
    IL_0054: ldarg.1      // endValue
    IL_0055: ldarg.3      // duration
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector4>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector4>, valuetype [UnityEngine]UnityEngine.Vector4, float32)
    IL_005b: dup

    // [560 7 - 560 81]
    IL_005c: ldloc.0      // V_0
    IL_005d: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass29_0'::target
    IL_0062: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector4, valuetype [UnityEngine]UnityEngine.Vector4, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0067: pop

    // [561 7 - 561 16]
    IL_0068: ret

  } // end of method ShortcutExtensions::DOVector

  .method public hidebysig static class DG.Tweening.Tweener
    DOResize(
      class [UnityEngine]UnityEngine.TrailRenderer target,
      float32 toStartWidth,
      float32 toEndWidth,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target

    // [575 7 - 579 133]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector2 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::'<DOResize>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::'<DOResize>b__1'(valuetype [UnityEngine]UnityEngine.Vector2)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>::.ctor(object, native int)
    IL_0025: ldarg.1      // toStartWidth
    IL_0026: ldarg.2      // toEndWidth
    IL_0027: newobj       instance void [UnityEngine]UnityEngine.Vector2::.ctor(float32, float32)
    IL_002c: ldarg.3      // duration
    IL_002d: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector2>, valuetype [UnityEngine]UnityEngine.Vector2, float32)
    IL_0032: ldloc.0      // V_0
    IL_0033: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass30_0'::target
    IL_0038: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector2, valuetype [UnityEngine]UnityEngine.Vector2, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_003d: ret

  } // end of method ShortcutExtensions::DOResize

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOTime(
      class [UnityEngine]UnityEngine.TrailRenderer target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::target

    // [591 7 - 591 162]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::'<DOTime>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::'<DOTime>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [592 7 - 592 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.TrailRenderer DG.Tweening.ShortcutExtensions/'<>c__DisplayClass31_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [593 7 - 593 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOTime

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOMove(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::target

    // [607 7 - 607 179]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::'<DOMove>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::'<DOMove>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: dup

    // [608 7 - 608 65]
    IL_002d: ldarg.3      // snapping
    IL_002e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, bool)
    IL_0033: ldloc.0      // V_0
    IL_0034: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass32_0'::target
    IL_0039: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_003e: pop

    // [609 7 - 609 16]
    IL_003f: ret

  } // end of method ShortcutExtensions::DOMove

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOMoveX(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::target

    // [623 7 - 623 204]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::'<DOMoveX>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::'<DOMoveX>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldc.r4       0.0
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [624 7 - 624 83]
    IL_003c: ldc.i4.2
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass33_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [625 7 - 625 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOMoveX

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOMoveY(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::target

    // [639 7 - 639 204]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::'<DOMoveY>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::'<DOMoveY>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldarg.1      // endValue
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [640 7 - 640 83]
    IL_003c: ldc.i4.4
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass34_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [641 7 - 641 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOMoveY

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOMoveZ(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::target

    // [655 7 - 655 204]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::'<DOMoveZ>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::'<DOMoveZ>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldc.r4       0.0
    IL_002f: ldarg.1      // endValue
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [656 7 - 656 83]
    IL_003c: ldc.i4.8
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass35_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [657 7 - 657 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOMoveZ

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOLocalMove(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::target

    // [671 7 - 671 189]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::'<DOLocalMove>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::'<DOLocalMove>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: dup

    // [672 7 - 672 65]
    IL_002d: ldarg.3      // snapping
    IL_002e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, bool)
    IL_0033: ldloc.0      // V_0
    IL_0034: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass36_0'::target
    IL_0039: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_003e: pop

    // [673 7 - 673 16]
    IL_003f: ret

  } // end of method ShortcutExtensions::DOLocalMove

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOLocalMoveX(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::target

    // [687 7 - 687 214]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::'<DOLocalMoveX>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::'<DOLocalMoveX>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldc.r4       0.0
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [688 7 - 688 83]
    IL_003c: ldc.i4.2
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass37_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [689 7 - 689 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOLocalMoveX

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOLocalMoveY(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::target

    // [703 7 - 703 214]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::'<DOLocalMoveY>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::'<DOLocalMoveY>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldarg.1      // endValue
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [704 7 - 704 83]
    IL_003c: ldc.i4.4
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass38_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [705 7 - 705 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOLocalMoveY

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOLocalMoveZ(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::target

    // [719 7 - 719 214]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::'<DOLocalMoveZ>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::'<DOLocalMoveZ>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldc.r4       0.0
    IL_002f: ldarg.1      // endValue
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [720 7 - 720 83]
    IL_003c: ldc.i4.8
    IL_003d: ldarg.3      // snapping
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass39_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [721 7 - 721 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOLocalMoveZ

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>
    DORotate(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 duration,
      [opt] valuetype DG.Tweening.RotateMode mode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::target

    // [735 7 - 735 192]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::'<DORotate>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::'<DORotate>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: dup

    // [736 7 - 736 88]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass40_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, object)
    IL_0038: pop
    IL_0039: dup

    // [737 7 - 737 38]
    IL_003a: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions
    IL_003f: ldarg.3      // mode
    IL_0040: stfld        valuetype DG.Tweening.RotateMode DG.Tweening.Plugins.Options.QuaternionOptions::rotateMode

    // [738 7 - 738 16]
    IL_0045: ret

  } // end of method ShortcutExtensions::DORotate

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>
    DORotateQuaternion(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Quaternion endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::target

    // [754 7 - 754 303]
    IL_000d: call         class DG.Tweening.CustomPlugins.PureQuaternionPlugin DG.Tweening.CustomPlugins.PureQuaternionPlugin::Plug()
    IL_0012: ldloc.0      // V_0
    IL_0013: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::'<DORotateQuaternion>b__0'()
    IL_0019: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_001e: ldloc.0      // V_0
    IL_001f: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::'<DORotateQuaternion>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_0025: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_002a: ldarg.1      // endValue
    IL_002b: ldarg.2      // duration
    IL_002c: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!2/*valuetype DG.Tweening.Plugins.Options.NoOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!2/*valuetype DG.Tweening.Plugins.Options.NoOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/>, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, float32)
    IL_0031: dup

    // [755 7 - 755 83]
    IL_0032: ldloc.0      // V_0
    IL_0033: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass41_0'::target
    IL_0038: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>*/, object)
    IL_003d: pop

    // [756 7 - 756 16]
    IL_003e: ret

  } // end of method ShortcutExtensions::DORotateQuaternion

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>
    DOLocalRotate(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 duration,
      [opt] valuetype DG.Tweening.RotateMode mode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::target

    // [770 7 - 770 202]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::'<DOLocalRotate>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::'<DOLocalRotate>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: dup

    // [771 7 - 771 88]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass42_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, object)
    IL_0038: pop
    IL_0039: dup

    // [772 7 - 772 38]
    IL_003a: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions
    IL_003f: ldarg.3      // mode
    IL_0040: stfld        valuetype DG.Tweening.RotateMode DG.Tweening.Plugins.Options.QuaternionOptions::rotateMode

    // [773 7 - 773 16]
    IL_0045: ret

  } // end of method ShortcutExtensions::DOLocalRotate

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>
    DOLocalRotateQuaternion(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Quaternion endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::target

    // [789 7 - 789 313]
    IL_000d: call         class DG.Tweening.CustomPlugins.PureQuaternionPlugin DG.Tweening.CustomPlugins.PureQuaternionPlugin::Plug()
    IL_0012: ldloc.0      // V_0
    IL_0013: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::'<DOLocalRotateQuaternion>b__0'()
    IL_0019: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_001e: ldloc.0      // V_0
    IL_001f: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::'<DOLocalRotateQuaternion>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_0025: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_002a: ldarg.1      // endValue
    IL_002b: ldarg.2      // duration
    IL_002c: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!2/*valuetype DG.Tweening.Plugins.Options.NoOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!2/*valuetype DG.Tweening.Plugins.Options.NoOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/>, !!1/*valuetype [UnityEngine]UnityEngine.Quaternion*/, float32)
    IL_0031: dup

    // [790 7 - 790 83]
    IL_0032: ldloc.0      // V_0
    IL_0033: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass43_0'::target
    IL_0038: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Quaternion, valuetype DG.Tweening.Plugins.Options.NoOptions>*/, object)
    IL_003d: pop

    // [791 7 - 791 16]
    IL_003e: ret

  } // end of method ShortcutExtensions::DOLocalRotateQuaternion

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOScale(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::target

    // [803 7 - 803 183]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::'<DOScale>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::'<DOScale>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: dup

    // [804 7 - 804 81]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass44_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0038: pop

    // [805 7 - 805 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOScale

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOScale(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0' V_0,
      [1] valuetype [UnityEngine]UnityEngine.Vector3 V_1
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::target

    // [817 7 - 817 216]
    IL_000d: ldloca.s     V_1
    IL_000f: ldarg.1      // endValue
    IL_0010: ldarg.1      // endValue
    IL_0011: ldarg.1      // endValue
    IL_0012: call         instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0017: ldloc.0      // V_0
    IL_0018: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::'<DOScale>b__0'()
    IL_001e: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0023: ldloc.0      // V_0
    IL_0024: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::'<DOScale>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002a: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_002f: ldloc.1      // V_1
    IL_0030: ldarg.2      // duration
    IL_0031: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0036: dup

    // [818 7 - 818 81]
    IL_0037: ldloc.0      // V_0
    IL_0038: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass45_0'::target
    IL_003d: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0042: pop

    // [819 7 - 819 16]
    IL_0043: ret

  } // end of method ShortcutExtensions::DOScale

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOScaleX(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::target

    // [831 7 - 831 208]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::'<DOScaleX>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::'<DOScaleX>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldc.r4       0.0
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [832 7 - 832 73]
    IL_003c: ldc.i4.2
    IL_003d: ldc.i4.0
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass46_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [833 7 - 833 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOScaleX

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOScaleY(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::target

    // [845 7 - 845 208]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::'<DOScaleY>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::'<DOScaleY>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldarg.1      // endValue
    IL_002b: ldc.r4       0.0
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [846 7 - 846 73]
    IL_003c: ldc.i4.4
    IL_003d: ldc.i4.0
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass47_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [847 7 - 847 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOScaleY

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>
    DOScaleZ(
      class [UnityEngine]UnityEngine.Transform target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::target

    // [859 7 - 859 208]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::'<DOScaleZ>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::'<DOScaleZ>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0025: ldc.r4       0.0
    IL_002a: ldc.r4       0.0
    IL_002f: ldarg.1      // endValue
    IL_0030: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0035: ldarg.2      // duration
    IL_0036: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_003b: dup

    // [860 7 - 860 73]
    IL_003c: ldc.i4.8
    IL_003d: ldc.i4.0
    IL_003e: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass48_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004e: pop

    // [861 7 - 861 16]
    IL_004f: ret

  } // end of method ShortcutExtensions::DOScaleZ

  .method public hidebysig static class DG.Tweening.Tweener
    DOLookAt(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 towards,
      float32 duration,
      [opt] valuetype DG.Tweening.AxisConstraint axisConstraint,
      [opt] valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Vector3> up
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .param [5] = nullref
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::target

    // [877 7 - 877 386]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::'<DOLookAt>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::'<DOLookAt>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0025: ldarg.1      // towards
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_002c: ldloc.0      // V_0
    IL_002d: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass49_0'::target
    IL_0032: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, object)
    IL_0037: ldc.i4.1
    IL_0038: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_003d: dup

    // [878 7 - 878 62]
    IL_003e: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions
    IL_0043: ldarg.3      // axisConstraint
    IL_0044: stfld        valuetype DG.Tweening.AxisConstraint DG.Tweening.Plugins.Options.QuaternionOptions::axisConstraint
    IL_0049: dup

    // [879 7 - 879 72]
    IL_004a: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions

    IL_004f: ldarga.s     up
    IL_0051: call         instance bool valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Vector3>::get_HasValue()
    IL_0056: brfalse.s    IL_0061
    IL_0058: ldarga.s     up
    IL_005a: call         instance !0/*valuetype [UnityEngine]UnityEngine.Vector3*/ valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Vector3>::get_Value()
    IL_005f: br.s         IL_0066
    IL_0061: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::get_up()
    IL_0066: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.Plugins.Options.QuaternionOptions::up

    // [880 7 - 880 36]
    IL_006b: ret

  } // end of method ShortcutExtensions::DOLookAt

  .method public hidebysig static class DG.Tweening.Tweener
    DOPunchPosition(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 punch,
      float32 duration,
      [opt] int32 vibrato,
      [opt] float32 elasticity,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(1)
    .param [6] = bool(false)
    .maxstack 6
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::target

    // [900 7 - 900 35]
    IL_000d: ldarg.2      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [902 7 - 902 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [903 9 - 903 115]
    IL_001d: ldstr        "DOPunchPosition: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [904 7 - 904 29]
    IL_0027: ldnull
    IL_0028: ret

    // [901 9 - 901 273]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::'<DOPunchPosition>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::'<DOPunchPosition>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // punch
    IL_0042: ldarg.2      // duration
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      elasticity
    IL_0046: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Punch(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32, int32, float32)
    IL_004b: ldloc.0      // V_0
    IL_004c: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass50_0'::target
    IL_0051: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0056: ldarg.s      snapping
    IL_0058: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>, bool)
    IL_005d: ret

  } // end of method ShortcutExtensions::DOPunchPosition

  .method public hidebysig static class DG.Tweening.Tweener
    DOPunchScale(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 punch,
      float32 duration,
      [opt] int32 vibrato,
      [opt] float32 elasticity
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(1)
    .maxstack 6
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::target

    // [922 7 - 922 35]
    IL_000d: ldarg.2      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [924 7 - 924 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [925 9 - 925 112]
    IL_001d: ldstr        "DOPunchScale: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [926 7 - 926 29]
    IL_0027: ldnull
    IL_0028: ret

    // [923 9 - 923 256]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::'<DOPunchScale>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::'<DOPunchScale>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // punch
    IL_0042: ldarg.2      // duration
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      elasticity
    IL_0046: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Punch(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32, int32, float32)
    IL_004b: ldloc.0      // V_0
    IL_004c: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass51_0'::target
    IL_0051: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0056: ret

  } // end of method ShortcutExtensions::DOPunchScale

  .method public hidebysig static class DG.Tweening.Tweener
    DOPunchRotation(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 punch,
      float32 duration,
      [opt] int32 vibrato,
      [opt] float32 elasticity
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(1)
    .maxstack 6
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::target

    // [944 7 - 944 35]
    IL_000d: ldarg.2      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [946 7 - 946 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [947 9 - 947 115]
    IL_001d: ldstr        "DOPunchRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [948 7 - 948 29]
    IL_0027: ldnull
    IL_0028: ret

    // [945 9 - 945 283]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::'<DOPunchRotation>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::'<DOPunchRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // punch
    IL_0042: ldarg.2      // duration
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      elasticity
    IL_0046: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Punch(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32, int32, float32)
    IL_004b: ldloc.0      // V_0
    IL_004c: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass52_0'::target
    IL_0051: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0056: ret

  } // end of method ShortcutExtensions::DOPunchRotation

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakePosition(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      [opt] float32 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool snapping,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = float32(1)
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(false)
    .param [7] = bool(true)
    .maxstack 8
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::target

    // [968 7 - 968 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [970 7 - 970 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [971 9 - 971 115]
    IL_001d: ldstr        "DOShakePosition: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [972 7 - 972 29]
    IL_0027: ldnull
    IL_0028: ret

    // [969 9 - 969 397]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::'<DOShakePosition>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::'<DOShakePosition>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldc.i4.0
    IL_0047: ldarg.s      fadeOut
    IL_0049: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, float32, int32, float32, bool, bool)
    IL_004e: ldloc.0      // V_0
    IL_004f: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass53_0'::target
    IL_0054: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0059: ldc.i4.2
    IL_005a: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005f: ldarg.s      snapping
    IL_0061: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>, bool)
    IL_0066: ret

  } // end of method ShortcutExtensions::DOShakePosition

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakePosition(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      valuetype [UnityEngine]UnityEngine.Vector3 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool snapping,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(false)
    .param [7] = bool(true)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::target

    // [992 7 - 992 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [994 7 - 994 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [995 9 - 995 115]
    IL_001d: ldstr        "DOShakePosition: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [996 7 - 996 29]
    IL_0027: ldnull
    IL_0028: ret

    // [993 9 - 993 390]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::'<DOShakePosition>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::'<DOShakePosition>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldarg.s      fadeOut
    IL_0048: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, valuetype [UnityEngine]UnityEngine.Vector3, int32, float32, bool)
    IL_004d: ldloc.0      // V_0
    IL_004e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass54_0'::target
    IL_0053: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0058: ldc.i4.2
    IL_0059: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005e: ldarg.s      snapping
    IL_0060: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>, bool)
    IL_0065: ret

  } // end of method ShortcutExtensions::DOShakePosition

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeRotation(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      [opt] float32 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = float32(90)
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 8
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::target

    // [1014 7 - 1014 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [1016 7 - 1016 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [1017 9 - 1017 115]
    IL_001d: ldstr        "DOShakeRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [1018 7 - 1018 29]
    IL_0027: ldnull
    IL_0028: ret

    // [1015 9 - 1015 407]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::'<DOShakeRotation>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::'<DOShakeRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldc.i4.0
    IL_0047: ldarg.s      fadeOut
    IL_0049: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, float32, int32, float32, bool, bool)
    IL_004e: ldloc.0      // V_0
    IL_004f: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass55_0'::target
    IL_0054: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0059: ldc.i4.2
    IL_005a: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005f: ret

  } // end of method ShortcutExtensions::DOShakeRotation

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeRotation(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      valuetype [UnityEngine]UnityEngine.Vector3 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::target

    // [1036 7 - 1036 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [1038 7 - 1038 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [1039 9 - 1039 115]
    IL_001d: ldstr        "DOShakeRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [1040 7 - 1040 29]
    IL_0027: ldnull
    IL_0028: ret

    // [1037 9 - 1037 400]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::'<DOShakeRotation>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::'<DOShakeRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldarg.s      fadeOut
    IL_0048: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, valuetype [UnityEngine]UnityEngine.Vector3, int32, float32, bool)
    IL_004d: ldloc.0      // V_0
    IL_004e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass56_0'::target
    IL_0053: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0058: ldc.i4.2
    IL_0059: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005e: ret

  } // end of method ShortcutExtensions::DOShakeRotation

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeScale(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      [opt] float32 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = float32(1)
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 8
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::target

    // [1058 7 - 1058 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0038

    // [1060 7 - 1060 47]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: box          [mscorlib]System.Int32
    IL_001f: call         void [UnityEngine]UnityEngine.Debug::Log(object)

    // [1061 7 - 1061 36]
    IL_0024: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_0029: ldc.i4.0
    IL_002a: ble.s        IL_0036

    // [1062 9 - 1062 112]
    IL_002c: ldstr        "DOShakeScale: duration can't be 0, returning NULL without creating a tween"
    IL_0031: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [1063 7 - 1063 29]
    IL_0036: ldnull
    IL_0037: ret

    // [1059 9 - 1059 380]
    IL_0038: ldloc.0      // V_0
    IL_0039: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::'<DOShakeScale>b__0'()
    IL_003f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0044: ldloc.0      // V_0
    IL_0045: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::'<DOShakeScale>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_004b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0050: ldarg.1      // duration
    IL_0051: ldarg.2      // strength
    IL_0052: ldarg.3      // vibrato
    IL_0053: ldarg.s      randomness
    IL_0055: ldc.i4.0
    IL_0056: ldarg.s      fadeOut
    IL_0058: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, float32, int32, float32, bool, bool)
    IL_005d: ldloc.0      // V_0
    IL_005e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass57_0'::target
    IL_0063: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0068: ldc.i4.2
    IL_0069: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_006e: ret

  } // end of method ShortcutExtensions::DOShakeScale

  .method public hidebysig static class DG.Tweening.Tweener
    DOShakeScale(
      class [UnityEngine]UnityEngine.Transform target,
      float32 duration,
      valuetype [UnityEngine]UnityEngine.Vector3 strength,
      [opt] int32 vibrato,
      [opt] float32 randomness,
      [opt] bool fadeOut
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(90)
    .param [6] = bool(true)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::target

    // [1081 7 - 1081 35]
    IL_000d: ldarg.1      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [1083 7 - 1083 36]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [1084 9 - 1084 112]
    IL_001d: ldstr        "DOShakeScale: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [1085 7 - 1085 29]
    IL_0027: ldnull
    IL_0028: ret

    // [1082 9 - 1082 373]
    IL_0029: ldloc.0      // V_0
    IL_002a: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::'<DOShakeScale>b__0'()
    IL_0030: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0035: ldloc.0      // V_0
    IL_0036: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::'<DOShakeScale>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_003c: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0041: ldarg.1      // duration
    IL_0042: ldarg.2      // strength
    IL_0043: ldarg.3      // vibrato
    IL_0044: ldarg.s      randomness
    IL_0046: ldarg.s      fadeOut
    IL_0048: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Shake(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, float32, valuetype [UnityEngine]UnityEngine.Vector3, int32, float32, bool)
    IL_004d: ldloc.0      // V_0
    IL_004e: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass58_0'::target
    IL_0053: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0058: ldc.i4.2
    IL_0059: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.Core.Extensions::SetSpecialStartupMode<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, valuetype DG.Tweening.Core.Enums.SpecialStartupMode)
    IL_005e: ret

  } // end of method ShortcutExtensions::DOShakeScale

  .method public hidebysig static class DG.Tweening.Sequence
    DOJump(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 jumpPower,
      int32 numJumps,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [6] = bool(false)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.1      // endValue
    IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::endValue

    // [1104 7 - 1104 24]
    IL_0014: ldarg.3      // numJumps
    IL_0015: ldc.i4.1
    IL_0016: bge.s        IL_001b

    // [1105 9 - 1105 21]
    IL_0018: ldc.i4.1
    IL_0019: starg.s      numJumps

    // [1106 7 - 1106 29]
    IL_001b: ldloc.0      // V_0
    IL_001c: ldc.r4       0.0
    IL_0021: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::startPosY

    // [1107 7 - 1107 26]
    IL_0026: ldloc.0      // V_0
    IL_0027: ldc.r4       -1
    IL_002c: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetY

    // [1108 7 - 1108 30]
    IL_0031: ldloc.0      // V_0
    IL_0032: ldc.i4.0
    IL_0033: stfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::offsetYSet

    // [1109 7 - 1109 38]
    IL_0038: ldloc.0      // V_0
    IL_0039: call         class DG.Tweening.Sequence DG.Tweening.DOTween::Sequence()
    IL_003e: stfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::s

    // [1110 7 - 1110 416]
    IL_0043: ldloc.0      // V_0
    IL_0044: ldloc.0      // V_0
    IL_0045: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__0'()
    IL_004b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0050: ldloc.0      // V_0
    IL_0051: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0057: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_005c: ldc.r4       0.0
    IL_0061: ldarg.2      // jumpPower
    IL_0062: ldc.r4       0.0
    IL_0067: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_006c: ldarg.s      duration
    IL_006e: ldarg.3      // numJumps
    IL_006f: ldc.i4.2
    IL_0070: mul
    IL_0071: conv.r4
    IL_0072: div
    IL_0073: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0078: ldc.i4.4
    IL_0079: ldarg.s      snapping
    IL_007b: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0080: ldc.i4.6
    IL_0081: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_0086: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetRelative<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/)
    IL_008b: ldarg.3      // numJumps
    IL_008c: ldc.i4.2
    IL_008d: mul
    IL_008e: ldc.i4.1
    IL_008f: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetLoops<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, int32, valuetype DG.Tweening.LoopType)
    IL_0094: ldloc.0      // V_0
    IL_0095: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__2'()
    IL_009b: newobj       instance void DG.Tweening.TweenCallback::.ctor(object, native int)
    IL_00a0: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::OnStart<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, class DG.Tweening.TweenCallback)
    IL_00a5: stfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::yTween

    // [1111 7 - 1111 571]
    IL_00aa: ldloc.0      // V_0
    IL_00ab: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::s
    IL_00b0: ldloc.0      // V_0
    IL_00b1: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__3'()
    IL_00b7: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_00bc: ldloc.0      // V_0
    IL_00bd: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__4'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_00c3: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_00c8: ldloc.0      // V_0
    IL_00c9: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::endValue
    IL_00ce: ldfld        float32 [UnityEngine]UnityEngine.Vector3::x
    IL_00d3: ldc.r4       0.0
    IL_00d8: ldc.r4       0.0
    IL_00dd: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_00e2: ldarg.s      duration
    IL_00e4: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_00e9: ldc.i4.2
    IL_00ea: ldarg.s      snapping
    IL_00ec: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_00f1: ldc.i4.1
    IL_00f2: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_00f7: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Append(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_00fc: ldloc.0      // V_0
    IL_00fd: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__5'()
    IL_0103: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0108: ldloc.0      // V_0
    IL_0109: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__6'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_010f: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0114: ldc.r4       0.0
    IL_0119: ldc.r4       0.0
    IL_011e: ldloc.0      // V_0
    IL_011f: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::endValue
    IL_0124: ldfld        float32 [UnityEngine]UnityEngine.Vector3::z
    IL_0129: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_012e: ldarg.s      duration
    IL_0130: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0135: ldc.i4.8
    IL_0136: ldarg.s      snapping
    IL_0138: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_013d: ldc.i4.1
    IL_013e: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_0143: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Join(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_0148: ldloc.0      // V_0
    IL_0149: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::yTween
    IL_014e: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Join(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_0153: ldloc.0      // V_0
    IL_0154: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::target
    IL_0159: call         !!0/*class DG.Tweening.Sequence*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Sequence>(!!0/*class DG.Tweening.Sequence*/, object)
    IL_015e: ldsfld       valuetype DG.Tweening.Ease DG.Tweening.DOTween::defaultEaseType
    IL_0163: call         !!0/*class DG.Tweening.Sequence*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Sequence>(!!0/*class DG.Tweening.Sequence*/, valuetype DG.Tweening.Ease)
    IL_0168: pop

    // [1112 7 - 1122 10]
    IL_0169: ldloc.0      // V_0
    IL_016a: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::yTween
    IL_016f: ldloc.0      // V_0
    IL_0170: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::'<DOJump>b__7'()
    IL_0176: newobj       instance void DG.Tweening.TweenCallback::.ctor(object, native int)
    IL_017b: call         !!0/*class DG.Tweening.Tween*/ DG.Tweening.TweenSettingsExtensions::OnUpdate<class DG.Tweening.Tween>(!!0/*class DG.Tweening.Tween*/, class DG.Tweening.TweenCallback)
    IL_0180: pop

    // [1123 7 - 1123 16]
    IL_0181: ldloc.0      // V_0
    IL_0182: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass59_0'::s
    IL_0187: ret

  } // end of method ShortcutExtensions::DOJump

  .method public hidebysig static class DG.Tweening.Sequence
    DOLocalJump(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 endValue,
      float32 jumpPower,
      int32 numJumps,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [6] = bool(false)
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.1      // endValue
    IL_000f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::endValue

    // [1142 7 - 1142 24]
    IL_0014: ldarg.3      // numJumps
    IL_0015: ldc.i4.1
    IL_0016: bge.s        IL_001b

    // [1143 9 - 1143 21]
    IL_0018: ldc.i4.1
    IL_0019: starg.s      numJumps

    // [1144 7 - 1144 47]
    IL_001b: ldloc.0      // V_0
    IL_001c: ldloc.0      // V_0
    IL_001d: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
    IL_0022: callvirt     instance valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Transform::get_localPosition()
    IL_0027: ldfld        float32 [UnityEngine]UnityEngine.Vector3::y
    IL_002c: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::startPosY

    // [1145 7 - 1145 26]
    IL_0031: ldloc.0      // V_0
    IL_0032: ldc.r4       -1
    IL_0037: stfld        float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetY

    // [1146 7 - 1146 30]
    IL_003c: ldloc.0      // V_0
    IL_003d: ldc.i4.0
    IL_003e: stfld        bool DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::offsetYSet

    // [1147 7 - 1147 38]
    IL_0043: ldloc.0      // V_0
    IL_0044: call         class DG.Tweening.Sequence DG.Tweening.DOTween::Sequence()
    IL_0049: stfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::s

    // [1148 7 - 1158 10]
    IL_004e: ldloc.0      // V_0
    IL_004f: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::s
    IL_0054: ldloc.0      // V_0
    IL_0055: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__0'()
    IL_005b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0060: ldloc.0      // V_0
    IL_0061: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0067: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_006c: ldloc.0      // V_0
    IL_006d: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::endValue
    IL_0072: ldfld        float32 [UnityEngine]UnityEngine.Vector3::x
    IL_0077: ldc.r4       0.0
    IL_007c: ldc.r4       0.0
    IL_0081: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0086: ldarg.s      duration
    IL_0088: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_008d: ldc.i4.2
    IL_008e: ldarg.s      snapping
    IL_0090: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0095: ldc.i4.1
    IL_0096: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_009b: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Append(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_00a0: ldloc.0      // V_0
    IL_00a1: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__2'()
    IL_00a7: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_00ac: ldloc.0      // V_0
    IL_00ad: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__3'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_00b3: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_00b8: ldc.r4       0.0
    IL_00bd: ldc.r4       0.0
    IL_00c2: ldloc.0      // V_0
    IL_00c3: ldflda       valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::endValue
    IL_00c8: ldfld        float32 [UnityEngine]UnityEngine.Vector3::z
    IL_00cd: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_00d2: ldarg.s      duration
    IL_00d4: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_00d9: ldc.i4.8
    IL_00da: ldarg.s      snapping
    IL_00dc: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_00e1: ldc.i4.1
    IL_00e2: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_00e7: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Join(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_00ec: ldloc.0      // V_0
    IL_00ed: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__4'()
    IL_00f3: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_00f8: ldloc.0      // V_0
    IL_00f9: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__5'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_00ff: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0104: ldc.r4       0.0
    IL_0109: ldarg.2      // jumpPower
    IL_010a: ldc.r4       0.0
    IL_010f: newobj       instance void [UnityEngine]UnityEngine.Vector3::.ctor(float32, float32, float32)
    IL_0114: ldarg.s      duration
    IL_0116: ldarg.3      // numJumps
    IL_0117: ldc.i4.2
    IL_0118: mul
    IL_0119: conv.r4
    IL_011a: div
    IL_011b: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0120: ldc.i4.4
    IL_0121: ldarg.s      snapping
    IL_0123: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, valuetype DG.Tweening.AxisConstraint, bool)
    IL_0128: ldc.i4.6
    IL_0129: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, valuetype DG.Tweening.Ease)
    IL_012e: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetRelative<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/)
    IL_0133: ldarg.3      // numJumps
    IL_0134: ldc.i4.2
    IL_0135: mul
    IL_0136: ldc.i4.1
    IL_0137: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetLoops<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, int32, valuetype DG.Tweening.LoopType)
    IL_013c: call         class DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Join(class DG.Tweening.Sequence, class DG.Tweening.Tween)
    IL_0141: ldloc.0      // V_0
    IL_0142: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::target
    IL_0147: call         !!0/*class DG.Tweening.Sequence*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Sequence>(!!0/*class DG.Tweening.Sequence*/, object)
    IL_014c: ldsfld       valuetype DG.Tweening.Ease DG.Tweening.DOTween::defaultEaseType
    IL_0151: call         !!0/*class DG.Tweening.Sequence*/ DG.Tweening.TweenSettingsExtensions::SetEase<class DG.Tweening.Sequence>(!!0/*class DG.Tweening.Sequence*/, valuetype DG.Tweening.Ease)
    IL_0156: ldloc.0      // V_0
    IL_0157: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::'<DOLocalJump>b__6'()
    IL_015d: newobj       instance void DG.Tweening.TweenCallback::.ctor(object, native int)
    IL_0162: call         !!0/*class DG.Tweening.Sequence*/ DG.Tweening.TweenSettingsExtensions::OnUpdate<class DG.Tweening.Sequence>(!!0/*class DG.Tweening.Sequence*/, class DG.Tweening.TweenCallback)
    IL_0167: pop

    // [1159 7 - 1159 16]
    IL_0168: ldloc.0      // V_0
    IL_0169: ldfld        class DG.Tweening.Sequence DG.Tweening.ShortcutExtensions/'<>c__DisplayClass60_0'::s
    IL_016e: ret

  } // end of method ShortcutExtensions::DOLocalJump

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>
    DOPath(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3[] path,
      float32 duration,
      [opt] valuetype DG.Tweening.PathType pathType,
      [opt] valuetype DG.Tweening.PathMode pathMode,
      [opt] int32 resolution,
      [opt] valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Color> gizmoColor
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .param [5] = int32(1) // 0x00000001
    .param [6] = int32(10) // 0x0000000a
    .param [7] = nullref
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::target

    // [1180 7 - 1180 26]
    IL_000d: ldarg.s      resolution
    IL_000f: ldc.i4.1
    IL_0010: bge.s        IL_0015

    // [1181 9 - 1181 23]
    IL_0012: ldc.i4.1
    IL_0013: starg.s      resolution

    // [1182 7 - 1182 338]
    IL_0015: call         class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Plugins.PathPlugin::Get()
    IL_001a: ldloc.0      // V_0
    IL_001b: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::'<DOPath>b__0'()
    IL_0021: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0026: ldloc.0      // V_0
    IL_0027: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::'<DOPath>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002d: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0032: ldarg.3      // pathType
    IL_0033: ldarg.1      // path
    IL_0034: ldarg.s      resolution
    IL_0036: ldarg.s      gizmoColor
    IL_0038: newobj       instance void DG.Tweening.Plugins.Core.PathCore.Path::.ctor(valuetype DG.Tweening.PathType, valuetype [UnityEngine]UnityEngine.Vector3[], int32, valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Color>)
    IL_003d: ldarg.2      // duration
    IL_003e: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, float32)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass61_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/, object)
    IL_004e: dup

    // [1183 7 - 1183 46]
    IL_004f: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_0054: ldarg.s      pathMode
    IL_0056: stfld        valuetype DG.Tweening.PathMode DG.Tweening.Plugins.Options.PathOptions::mode

    // [1184 7 - 1184 26]
    IL_005b: ret

  } // end of method ShortcutExtensions::DOPath

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>
    DOLocalPath(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3[] path,
      float32 duration,
      [opt] valuetype DG.Tweening.PathType pathType,
      [opt] valuetype DG.Tweening.PathMode pathMode,
      [opt] int32 resolution,
      [opt] valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Color> gizmoColor
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .param [5] = int32(1) // 0x00000001
    .param [6] = int32(10) // 0x0000000a
    .param [7] = nullref
    .maxstack 7
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::target

    // [1205 7 - 1205 26]
    IL_000d: ldarg.s      resolution
    IL_000f: ldc.i4.1
    IL_0010: bge.s        IL_0015

    // [1206 9 - 1206 23]
    IL_0012: ldc.i4.1
    IL_0013: starg.s      resolution

    // [1207 7 - 1207 348]
    IL_0015: call         class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Plugins.PathPlugin::Get()
    IL_001a: ldloc.0      // V_0
    IL_001b: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::'<DOLocalPath>b__0'()
    IL_0021: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0026: ldloc.0      // V_0
    IL_0027: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::'<DOLocalPath>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002d: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0032: ldarg.3      // pathType
    IL_0033: ldarg.1      // path
    IL_0034: ldarg.s      resolution
    IL_0036: ldarg.s      gizmoColor
    IL_0038: newobj       instance void DG.Tweening.Plugins.Core.PathCore.Path::.ctor(valuetype DG.Tweening.PathType, valuetype [UnityEngine]UnityEngine.Vector3[], int32, valuetype [mscorlib]System.Nullable`1<valuetype [UnityEngine]UnityEngine.Color>)
    IL_003d: ldarg.2      // duration
    IL_003e: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, float32)
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass62_0'::target
    IL_0049: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/, object)
    IL_004e: dup

    // [1208 7 - 1208 46]
    IL_004f: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_0054: ldarg.s      pathMode
    IL_0056: stfld        valuetype DG.Tweening.PathMode DG.Tweening.Plugins.Options.PathOptions::mode
    IL_005b: dup

    // [1209 7 - 1209 54]
    IL_005c: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_0061: ldc.i4.1
    IL_0062: stfld        bool DG.Tweening.Plugins.Options.PathOptions::useLocalPosition

    // [1210 7 - 1210 26]
    IL_0067: ret

  } // end of method ShortcutExtensions::DOLocalPath

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>
    DOPath(
      class [UnityEngine]UnityEngine.Transform target,
      class DG.Tweening.Plugins.Core.PathCore.Path path,
      float32 duration,
      [opt] valuetype DG.Tweening.PathMode pathMode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(1) // 0x00000001
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::target

    // [1225 7 - 1225 294]
    IL_000d: call         class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Plugins.PathPlugin::Get()
    IL_0012: ldloc.0      // V_0
    IL_0013: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::'<DOPath>b__0'()
    IL_0019: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_001e: ldloc.0      // V_0
    IL_001f: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::'<DOPath>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0025: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_002a: ldarg.1      // path
    IL_002b: ldarg.2      // duration
    IL_002c: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, float32)
    IL_0031: ldloc.0      // V_0
    IL_0032: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass63_0'::target
    IL_0037: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/, object)
    IL_003c: dup

    // [1226 7 - 1226 46]
    IL_003d: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_0042: ldarg.3      // pathMode
    IL_0043: stfld        valuetype DG.Tweening.PathMode DG.Tweening.Plugins.Options.PathOptions::mode

    // [1227 7 - 1227 26]
    IL_0048: ret

  } // end of method ShortcutExtensions::DOPath

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>
    DOLocalPath(
      class [UnityEngine]UnityEngine.Transform target,
      class DG.Tweening.Plugins.Core.PathCore.Path path,
      float32 duration,
      [opt] valuetype DG.Tweening.PathMode pathMode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(1) // 0x00000001
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::target

    // [1242 7 - 1242 304]
    IL_000d: call         class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Plugins.PathPlugin::Get()
    IL_0012: ldloc.0      // V_0
    IL_0013: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::'<DOLocalPath>b__0'()
    IL_0019: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_001e: ldloc.0      // V_0
    IL_001f: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::'<DOLocalPath>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0025: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_002a: ldarg.1      // path
    IL_002b: ldarg.2      // duration
    IL_002c: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/> DG.Tweening.DOTween::To<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>(class DG.Tweening.Plugins.Core.ABSTweenPlugin`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, !!2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/>, class DG.Tweening.Core.DOGetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, class DG.Tweening.Core.DOSetter`1<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/>, !!1/*class DG.Tweening.Plugins.Core.PathCore.Path*/, float32)
    IL_0031: ldloc.0      // V_0
    IL_0032: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass64_0'::target
    IL_0037: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>*/, object)
    IL_003c: dup

    // [1243 7 - 1243 46]
    IL_003d: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_0042: ldarg.3      // pathMode
    IL_0043: stfld        valuetype DG.Tweening.PathMode DG.Tweening.Plugins.Options.PathOptions::mode
    IL_0048: dup

    // [1244 7 - 1244 54]
    IL_0049: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.PathOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, class DG.Tweening.Plugins.Core.PathCore.Path, valuetype DG.Tweening.Plugins.Options.PathOptions>::plugOptions
    IL_004e: ldc.i4.1
    IL_004f: stfld        bool DG.Tweening.Plugins.Options.PathOptions::useLocalPosition

    // [1245 7 - 1245 26]
    IL_0054: ret

  } // end of method ShortcutExtensions::DOLocalPath

  .method public hidebysig static class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>
    DOTimeScale(
      class DG.Tweening.Tween target,
      float32 endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::target

    // [1257 7 - 1257 172]
    IL_000d: ldloc.0      // V_0
    IL_000e: ldftn        instance float32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::'<DOTimeScale>b__0'()
    IL_0014: newobj       instance void class DG.Tweening.Core.DOGetter`1<float32>::.ctor(object, native int)
    IL_0019: ldloc.0      // V_0
    IL_001a: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::'<DOTimeScale>b__1'(float32)
    IL_0020: newobj       instance void class DG.Tweening.Core.DOSetter`1<float32>::.ctor(object, native int)
    IL_0025: ldarg.1      // endValue
    IL_0026: ldarg.2      // duration
    IL_0027: call         class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<float32>, class DG.Tweening.Core.DOSetter`1<float32>, float32, float32)
    IL_002c: dup

    // [1258 7 - 1258 76]
    IL_002d: ldloc.0      // V_0
    IL_002e: ldfld        class DG.Tweening.Tween DG.Tweening.ShortcutExtensions/'<>c__DisplayClass65_0'::target
    IL_0033: call         !!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<float32, float32, valuetype DG.Tweening.Plugins.Options.FloatOptions>*/, object)
    IL_0038: pop

    // [1259 7 - 1259 16]
    IL_0039: ret

  } // end of method ShortcutExtensions::DOTimeScale

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableColor(
      class [UnityEngine]UnityEngine.Light target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::target

    // [1273 7 - 1273 31]
    IL_000d: ldarg.1      // endValue
    IL_000e: ldloc.0      // V_0
    IL_000f: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::target
    IL_0014: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Light::get_color()
    IL_0019: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
    IL_001e: starg.s      endValue

    // [1274 7 - 1274 51]
    IL_0020: ldloc.0      // V_0
    IL_0021: ldc.r4       0.0
    IL_0026: ldc.r4       0.0
    IL_002b: ldc.r4       0.0
    IL_0030: ldc.r4       0.0
    IL_0035: newobj       instance void [UnityEngine]UnityEngine.Color::.ctor(float32, float32, float32, float32)
    IL_003a: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'to'

    // [1275 7 - 1280 139]
    IL_003f: ldloc.0      // V_0
    IL_0040: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'<DOBlendableColor>b__0'()
    IL_0046: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_004b: ldloc.0      // V_0
    IL_004c: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::'<DOBlendableColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0052: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0057: ldarg.1      // endValue
    IL_0058: ldarg.2      // duration
    IL_0059: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_005e: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/>)
    IL_0063: ldloc.0      // V_0
    IL_0064: ldfld        class [UnityEngine]UnityEngine.Light DG.Tweening.ShortcutExtensions/'<>c__DisplayClass66_0'::target
    IL_0069: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_006e: ret

  } // end of method ShortcutExtensions::DOBlendableColor

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::target

    // [1294 7 - 1294 31]
    IL_000d: ldarg.1      // endValue
    IL_000e: ldloc.0      // V_0
    IL_000f: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::target
    IL_0014: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::get_color()
    IL_0019: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
    IL_001e: starg.s      endValue

    // [1295 7 - 1295 51]
    IL_0020: ldloc.0      // V_0
    IL_0021: ldc.r4       0.0
    IL_0026: ldc.r4       0.0
    IL_002b: ldc.r4       0.0
    IL_0030: ldc.r4       0.0
    IL_0035: newobj       instance void [UnityEngine]UnityEngine.Color::.ctor(float32, float32, float32, float32)
    IL_003a: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'to'

    // [1296 7 - 1301 139]
    IL_003f: ldloc.0      // V_0
    IL_0040: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'<DOBlendableColor>b__0'()
    IL_0046: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_004b: ldloc.0      // V_0
    IL_004c: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::'<DOBlendableColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0052: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0057: ldarg.1      // endValue
    IL_0058: ldarg.2      // duration
    IL_0059: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_005e: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/>)
    IL_0063: ldloc.0      // V_0
    IL_0064: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass67_0'::target
    IL_0069: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_006e: ret

  } // end of method ShortcutExtensions::DOBlendableColor

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      string 'property',
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // 'property'
    IL_000f: stfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'

    // [1317 7 - 1317 41]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(string)
    IL_0025: brtrue.s     IL_003c

    // [1319 9 - 1319 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [1320 11 - 1320 56]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(string)

    // [1321 9 - 1321 31]
    IL_003a: ldnull
    IL_003b: ret

    // [1323 7 - 1323 44]
    IL_003c: ldarg.1      // endValue
    IL_003d: ldloc.0      // V_0
    IL_003e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        string DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'property'
    IL_0049: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(string)
    IL_004e: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
    IL_0053: starg.s      endValue

    // [1324 7 - 1324 51]
    IL_0055: ldloc.0      // V_0
    IL_0056: ldc.r4       0.0
    IL_005b: ldc.r4       0.0
    IL_0060: ldc.r4       0.0
    IL_0065: ldc.r4       0.0
    IL_006a: newobj       instance void [UnityEngine]UnityEngine.Color::.ctor(float32, float32, float32, float32)
    IL_006f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'to'

    // [1325 7 - 1330 139]
    IL_0074: ldloc.0      // V_0
    IL_0075: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'<DOBlendableColor>b__0'()
    IL_007b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0080: ldloc.0      // V_0
    IL_0081: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::'<DOBlendableColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0087: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_008c: ldarg.1      // endValue
    IL_008d: ldarg.3      // duration
    IL_008e: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_0093: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/>)
    IL_0098: ldloc.0      // V_0
    IL_0099: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass68_0'::target
    IL_009e: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_00a3: ret

  } // end of method ShortcutExtensions::DOBlendableColor

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableColor(
      class [UnityEngine]UnityEngine.Material target,
      valuetype [UnityEngine]UnityEngine.Color endValue,
      int32 propertyID,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 5
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
    IL_000d: ldloc.0      // V_0
    IL_000e: ldarg.2      // propertyID
    IL_000f: stfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID

    // [1346 7 - 1346 43]
    IL_0014: ldloc.0      // V_0
    IL_0015: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
    IL_001a: ldloc.0      // V_0
    IL_001b: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID
    IL_0020: callvirt     instance bool [UnityEngine]UnityEngine.Material::HasProperty(int32)
    IL_0025: brtrue.s     IL_003c

    // [1348 9 - 1348 38]
    IL_0027: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_002c: ldc.i4.0
    IL_002d: ble.s        IL_003a

    // [1349 11 - 1349 58]
    IL_002f: ldloc.0      // V_0
    IL_0030: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID
    IL_0035: call         void DG.Tweening.Core.Debugger::LogMissingMaterialProperty(int32)

    // [1350 9 - 1350 31]
    IL_003a: ldnull
    IL_003b: ret

    // [1352 7 - 1352 46]
    IL_003c: ldarg.1      // endValue
    IL_003d: ldloc.0      // V_0
    IL_003e: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
    IL_0043: ldloc.0      // V_0
    IL_0044: ldfld        int32 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::propertyID
    IL_0049: callvirt     instance valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Material::GetColor(int32)
    IL_004e: call         valuetype [UnityEngine]UnityEngine.Color [UnityEngine]UnityEngine.Color::op_Subtraction(valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color)
    IL_0053: starg.s      endValue

    // [1353 7 - 1353 51]
    IL_0055: ldloc.0      // V_0
    IL_0056: ldc.r4       0.0
    IL_005b: ldc.r4       0.0
    IL_0060: ldc.r4       0.0
    IL_0065: ldc.r4       0.0
    IL_006a: newobj       instance void [UnityEngine]UnityEngine.Color::.ctor(float32, float32, float32, float32)
    IL_006f: stfld        valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'to'

    // [1354 7 - 1359 139]
    IL_0074: ldloc.0      // V_0
    IL_0075: ldftn        instance valuetype [UnityEngine]UnityEngine.Color DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'<DOBlendableColor>b__0'()
    IL_007b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_0080: ldloc.0      // V_0
    IL_0081: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::'<DOBlendableColor>b__1'(valuetype [UnityEngine]UnityEngine.Color)
    IL_0087: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>::.ctor(object, native int)
    IL_008c: ldarg.1      // endValue
    IL_008d: ldarg.3      // duration
    IL_008e: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Color>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Color>, valuetype [UnityEngine]UnityEngine.Color, float32)
    IL_0093: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Color*/, !!1/*valuetype [UnityEngine]UnityEngine.Color*/, !!2/*valuetype DG.Tweening.Plugins.Options.ColorOptions*/>)
    IL_0098: ldloc.0      // V_0
    IL_0099: ldfld        class [UnityEngine]UnityEngine.Material DG.Tweening.ShortcutExtensions/'<>c__DisplayClass69_0'::target
    IL_009e: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Color, valuetype [UnityEngine]UnityEngine.Color, valuetype DG.Tweening.Plugins.Options.ColorOptions>*/, object)
    IL_00a3: ret

  } // end of method ShortcutExtensions::DOBlendableColor

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableMoveBy(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 byValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::target

    // [1375 7 - 1375 32]
    IL_000d: ldloc.0      // V_0
    IL_000e: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::get_zero()
    IL_0013: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'to'

    // [1376 7 - 1381 132]
    IL_0018: ldloc.0      // V_0
    IL_0019: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'<DOBlendableMoveBy>b__0'()
    IL_001f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0024: ldloc.0      // V_0
    IL_0025: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::'<DOBlendableMoveBy>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0030: ldarg.1      // byValue
    IL_0031: ldarg.2      // duration
    IL_0032: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0037: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/>)
    IL_003c: ldarg.3      // snapping
    IL_003d: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, bool)
    IL_0042: ldloc.0      // V_0
    IL_0043: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass70_0'::target
    IL_0048: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004d: ret

  } // end of method ShortcutExtensions::DOBlendableMoveBy

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableLocalMoveBy(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 byValue,
      float32 duration,
      [opt] bool snapping
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = bool(false)
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::target

    // [1397 7 - 1397 32]
    IL_000d: ldloc.0      // V_0
    IL_000e: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::get_zero()
    IL_0013: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'to'

    // [1398 7 - 1403 132]
    IL_0018: ldloc.0      // V_0
    IL_0019: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'<DOBlendableLocalMoveBy>b__0'()
    IL_001f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0024: ldloc.0      // V_0
    IL_0025: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::'<DOBlendableLocalMoveBy>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0030: ldarg.1      // byValue
    IL_0031: ldarg.2      // duration
    IL_0032: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0037: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/>)
    IL_003c: ldarg.3      // snapping
    IL_003d: call         class DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>, bool)
    IL_0042: ldloc.0      // V_0
    IL_0043: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass71_0'::target
    IL_0048: call         !!0/*class DG.Tweening.Tweener*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Tweener>(!!0/*class DG.Tweening.Tweener*/, object)
    IL_004d: ret

  } // end of method ShortcutExtensions::DOBlendableLocalMoveBy

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableRotateBy(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 byValue,
      float32 duration,
      [opt] valuetype DG.Tweening.RotateMode mode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::target

    // [1419 7 - 1419 42]
    IL_000d: ldloc.0      // V_0
    IL_000e: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::get_identity()
    IL_0013: stfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'to'

    // [1420 7 - 1426 161]
    IL_0018: ldloc.0      // V_0
    IL_0019: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'<DOBlendableRotateBy>b__0'()
    IL_001f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0024: ldloc.0      // V_0
    IL_0025: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::'<DOBlendableRotateBy>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_002b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0030: ldarg.1      // byValue
    IL_0031: ldarg.2      // duration
    IL_0032: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0037: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/>)
    IL_003c: ldloc.0      // V_0
    IL_003d: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass72_0'::target
    IL_0042: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, object)
    IL_0047: dup

    // [1427 7 - 1427 48]
    IL_0048: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions
    IL_004d: ldarg.3      // mode
    IL_004e: stfld        valuetype DG.Tweening.RotateMode DG.Tweening.Plugins.Options.QuaternionOptions::rotateMode

    // [1428 7 - 1428 36]
    IL_0053: ret

  } // end of method ShortcutExtensions::DOBlendableRotateBy

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableLocalRotateBy(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 byValue,
      float32 duration,
      [opt] valuetype DG.Tweening.RotateMode mode
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(0) // 0x00000000
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::target

    // [1444 7 - 1444 42]
    IL_000d: ldloc.0      // V_0
    IL_000e: call         valuetype [UnityEngine]UnityEngine.Quaternion [UnityEngine]UnityEngine.Quaternion::get_identity()
    IL_0013: stfld        valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'to'

    // [1445 7 - 1451 161]
    IL_0018: ldloc.0      // V_0
    IL_0019: ldftn        instance valuetype [UnityEngine]UnityEngine.Quaternion DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'<DOBlendableLocalRotateBy>b__0'()
    IL_001f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0024: ldloc.0      // V_0
    IL_0025: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::'<DOBlendableLocalRotateBy>b__1'(valuetype [UnityEngine]UnityEngine.Quaternion)
    IL_002b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>::.ctor(object, native int)
    IL_0030: ldarg.1      // byValue
    IL_0031: ldarg.2      // duration
    IL_0032: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Quaternion>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0037: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Quaternion*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/>)
    IL_003c: ldloc.0      // V_0
    IL_003d: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass73_0'::target
    IL_0042: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>*/, object)
    IL_0047: dup

    // [1452 7 - 1452 48]
    IL_0048: ldflda       !2/*valuetype DG.Tweening.Plugins.Options.QuaternionOptions*/ class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Quaternion, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.QuaternionOptions>::plugOptions
    IL_004d: ldarg.3      // mode
    IL_004e: stfld        valuetype DG.Tweening.RotateMode DG.Tweening.Plugins.Options.QuaternionOptions::rotateMode

    // [1453 7 - 1453 36]
    IL_0053: ret

  } // end of method ShortcutExtensions::DOBlendableLocalRotateBy

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendablePunchRotation(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 punch,
      float32 duration,
      [opt] int32 vibrato,
      [opt] float32 elasticity
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [4] = int32(10) // 0x0000000a
    .param [5] = float32(1)
    .maxstack 6
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::target

    // [1472 7 - 1472 36]
    IL_000d: ldarg.2      // duration
    IL_000e: ldc.r4       0.0
    IL_0013: bgt.un.s     IL_0029

    // [1474 9 - 1474 38]
    IL_0015: call         int32 DG.Tweening.Core.Debugger::get_logPriority()
    IL_001a: ldc.i4.0
    IL_001b: ble.s        IL_0027

    // [1475 11 - 1475 126]
    IL_001d: ldstr        "DOBlendablePunchRotation: duration can't be 0, returning NULL without creating a tween"
    IL_0022: call         void [UnityEngine]UnityEngine.Debug::LogWarning(object)

    // [1476 9 - 1476 31]
    IL_0027: ldnull
    IL_0028: ret

    // [1478 7 - 1478 32]
    IL_0029: ldloc.0      // V_0
    IL_002a: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::get_zero()
    IL_002f: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'to'

    // [1479 7 - 1486 183]
    IL_0034: ldloc.0      // V_0
    IL_0035: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'<DOBlendablePunchRotation>b__0'()
    IL_003b: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0040: ldloc.0      // V_0
    IL_0041: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::'<DOBlendablePunchRotation>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_0047: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_004c: ldarg.1      // punch
    IL_004d: ldarg.2      // duration
    IL_004e: ldarg.3      // vibrato
    IL_004f: ldarg.s      elasticity
    IL_0051: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions> DG.Tweening.DOTween::Punch(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32, int32, float32)
    IL_0056: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3[]*/, !!2/*valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3[]*/, !!2/*valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions*/>)
    IL_005b: ldloc.0      // V_0
    IL_005c: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass74_0'::target
    IL_0061: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3[], valuetype DG.Tweening.Plugins.Options.Vector3ArrayOptions>*/, object)
    IL_0066: ret

  } // end of method ShortcutExtensions::DOBlendablePunchRotation

  .method public hidebysig static class DG.Tweening.Tweener
    DOBlendableScaleBy(
      class [UnityEngine]UnityEngine.Transform target,
      valuetype [UnityEngine]UnityEngine.Vector3 byValue,
      float32 duration
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 4
    .locals init (
      [0] class DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0' V_0
    )

    IL_0000: newobj       instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::.ctor()
    IL_0005: stloc.0      // V_0
    IL_0006: ldloc.0      // V_0
    IL_0007: ldarg.0      // target
    IL_0008: stfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::target

    // [1500 7 - 1500 32]
    IL_000d: ldloc.0      // V_0
    IL_000e: call         valuetype [UnityEngine]UnityEngine.Vector3 [UnityEngine]UnityEngine.Vector3::get_zero()
    IL_0013: stfld        valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'to'

    // [1501 7 - 1506 148]
    IL_0018: ldloc.0      // V_0
    IL_0019: ldftn        instance valuetype [UnityEngine]UnityEngine.Vector3 DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'<DOBlendableScaleBy>b__0'()
    IL_001f: newobj       instance void class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0024: ldloc.0      // V_0
    IL_0025: ldftn        instance void DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::'<DOBlendableScaleBy>b__1'(valuetype [UnityEngine]UnityEngine.Vector3)
    IL_002b: newobj       instance void class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>::.ctor(object, native int)
    IL_0030: ldarg.1      // byValue
    IL_0031: ldarg.2      // duration
    IL_0032: call         class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions> DG.Tweening.DOTween::To(class DG.Tweening.Core.DOGetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, class DG.Tweening.Core.DOSetter`1<valuetype [UnityEngine]UnityEngine.Vector3>, valuetype [UnityEngine]UnityEngine.Vector3, float32)
    IL_0037: call         class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/> DG.Tweening.Core.Extensions::Blendable<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>(class DG.Tweening.Core.TweenerCore`3<!!0/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!1/*valuetype [UnityEngine]UnityEngine.Vector3*/, !!2/*valuetype DG.Tweening.Plugins.Options.VectorOptions*/>)
    IL_003c: ldloc.0      // V_0
    IL_003d: ldfld        class [UnityEngine]UnityEngine.Transform DG.Tweening.ShortcutExtensions/'<>c__DisplayClass75_0'::target
    IL_0042: call         !!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/ DG.Tweening.TweenSettingsExtensions::SetTarget<class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>>(!!0/*class DG.Tweening.Core.TweenerCore`3<valuetype [UnityEngine]UnityEngine.Vector3, valuetype [UnityEngine]UnityEngine.Vector3, valuetype DG.Tweening.Plugins.Options.VectorOptions>*/, object)
    IL_0047: ret

  } // end of method ShortcutExtensions::DOBlendableScaleBy

  .method public hidebysig static int32
    DOComplete(
      class [UnityEngine]UnityEngine.Component target,
      [opt] bool withCallbacks
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(false)
    .maxstack 8

    // [1517 88 - 1517 136]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // withCallbacks
    IL_0002: call         int32 DG.Tweening.DOTween::Complete(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DOComplete

  .method public hidebysig static int32
    DOComplete(
      class [UnityEngine]UnityEngine.Material target,
      [opt] bool withCallbacks
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(false)
    .maxstack 8

    // [1527 87 - 1527 135]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // withCallbacks
    IL_0002: call         int32 DG.Tweening.DOTween::Complete(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DOComplete

  .method public hidebysig static int32
    DOKill(
      class [UnityEngine]UnityEngine.Component target,
      [opt] bool complete
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(false)
    .maxstack 8

    // [1535 79 - 1535 118]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // complete
    IL_0002: call         int32 DG.Tweening.DOTween::Kill(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DOKill

  .method public hidebysig static int32
    DOKill(
      class [UnityEngine]UnityEngine.Material target,
      [opt] bool complete
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(false)
    .maxstack 8

    // [1543 78 - 1543 117]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // complete
    IL_0002: call         int32 DG.Tweening.DOTween::Kill(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DOKill

  .method public hidebysig static int32
    DOFlip(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1550 56 - 1550 85]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Flip(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOFlip

  .method public hidebysig static int32
    DOFlip(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1557 55 - 1557 84]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Flip(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOFlip

  .method public hidebysig static int32
    DOGoto(
      class [UnityEngine]UnityEngine.Component target,
      float32 'to',
      [opt] bool andPlay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = bool(false)
    .maxstack 8

    // [1567 88 - 1567 130]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // 'to'
    IL_0002: ldarg.2      // andPlay
    IL_0003: call         int32 DG.Tweening.DOTween::Goto(object, float32, bool)
    IL_0008: ret

  } // end of method ShortcutExtensions::DOGoto

  .method public hidebysig static int32
    DOGoto(
      class [UnityEngine]UnityEngine.Material target,
      float32 'to',
      [opt] bool andPlay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [3] = bool(false)
    .maxstack 8

    // [1577 87 - 1577 129]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // 'to'
    IL_0002: ldarg.2      // andPlay
    IL_0003: call         int32 DG.Tweening.DOTween::Goto(object, float32, bool)
    IL_0008: ret

  } // end of method ShortcutExtensions::DOGoto

  .method public hidebysig static int32
    DOPause(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1584 57 - 1584 87]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Pause(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPause

  .method public hidebysig static int32
    DOPause(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1591 56 - 1591 86]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Pause(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPause

  .method public hidebysig static int32
    DOPlay(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1598 56 - 1598 85]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Play(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlay

  .method public hidebysig static int32
    DOPlay(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1605 55 - 1605 84]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::Play(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlay

  .method public hidebysig static int32
    DOPlayBackwards(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1612 65 - 1612 103]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::PlayBackwards(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlayBackwards

  .method public hidebysig static int32
    DOPlayBackwards(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1619 64 - 1619 102]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::PlayBackwards(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlayBackwards

  .method public hidebysig static int32
    DOPlayForward(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1626 63 - 1626 99]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::PlayForward(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlayForward

  .method public hidebysig static int32
    DOPlayForward(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1633 62 - 1633 98]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::PlayForward(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOPlayForward

  .method public hidebysig static int32
    DORestart(
      class [UnityEngine]UnityEngine.Component target,
      [opt] bool includeDelay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(true)
    .maxstack 8

    // [1640 85 - 1640 136]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // includeDelay
    IL_0002: ldc.r4       -1
    IL_0007: call         int32 DG.Tweening.DOTween::Restart(object, bool, float32)
    IL_000c: ret

  } // end of method ShortcutExtensions::DORestart

  .method public hidebysig static int32
    DORestart(
      class [UnityEngine]UnityEngine.Material target,
      [opt] bool includeDelay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(true)
    .maxstack 8

    // [1647 84 - 1647 135]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // includeDelay
    IL_0002: ldc.r4       -1
    IL_0007: call         int32 DG.Tweening.DOTween::Restart(object, bool, float32)
    IL_000c: ret

  } // end of method ShortcutExtensions::DORestart

  .method public hidebysig static int32
    DORewind(
      class [UnityEngine]UnityEngine.Component target,
      [opt] bool includeDelay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(true)
    .maxstack 8

    // [1654 84 - 1654 129]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // includeDelay
    IL_0002: call         int32 DG.Tweening.DOTween::Rewind(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DORewind

  .method public hidebysig static int32
    DORewind(
      class [UnityEngine]UnityEngine.Material target,
      [opt] bool includeDelay
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .param [2] = bool(true)
    .maxstack 8

    // [1661 83 - 1661 128]
    IL_0000: ldarg.0      // target
    IL_0001: ldarg.1      // includeDelay
    IL_0002: call         int32 DG.Tweening.DOTween::Rewind(object, bool)
    IL_0007: ret

  } // end of method ShortcutExtensions::DORewind

  .method public hidebysig static int32
    DOSmoothRewind(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1668 64 - 1668 101]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::SmoothRewind(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOSmoothRewind

  .method public hidebysig static int32
    DOSmoothRewind(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1675 63 - 1675 100]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::SmoothRewind(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOSmoothRewind

  .method public hidebysig static int32
    DOTogglePause(
      class [UnityEngine]UnityEngine.Component target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1682 63 - 1682 99]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::TogglePause(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOTogglePause

  .method public hidebysig static int32
    DOTogglePause(
      class [UnityEngine]UnityEngine.Material target
    ) cil managed
  {
    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
      = (01 00 00 00 )
    .maxstack 8

    // [1689 62 - 1689 98]
    IL_0000: ldarg.0      // target
    IL_0001: call         int32 DG.Tweening.DOTween::TogglePause(object)
    IL_0006: ret

  } // end of method ShortcutExtensions::DOTogglePause
} // end of class DG.Tweening.ShortcutExtensions
