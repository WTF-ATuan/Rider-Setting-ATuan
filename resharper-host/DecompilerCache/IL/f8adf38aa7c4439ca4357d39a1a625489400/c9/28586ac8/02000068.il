// Type: Sirenix.OdinInspector.ReadOnlyAttribute 
// Assembly: Sirenix.OdinInspector.Attributes, Version=3.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: F8ADF38A-A7C4-439C-A435-7D39A1A62548
// Location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Plugins\Odin\Assemblies\Sirenix.OdinInspector.Attributes.dll
// Sequence point data from decompiler

.class public sealed auto ansi beforefieldinit
  Sirenix.OdinInspector.ReadOnlyAttribute
    extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets)
    = (
      01 00 ff 7f 00 00 02 00 54 02 0d 41 6c 6c 6f 77 // ..ÿ.....T..Allow
      4d 75 6c 74 69 70 6c 65 00 54 02 09 49 6e 68 65 // Multiple.T..Inhe
      72 69 74 65 64 01                               // rited.
    )
    // int32(32767) // 0x00007fff
    // property bool 'AllowMultiple' = bool(false)
    // property bool 'Inherited' = bool(true)
  .custom instance void [mscorlib]System.Diagnostics.ConditionalAttribute::.ctor(string)
    = (
      01 00 0c 55 4e 49 54 59 5f 45 44 49 54 4f 52 00 // ...UNITY_EDITOR.
      00                                              // .
    )
    // string('UNITY_EDITOR')

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [mscorlib]System.Attribute::.ctor()
    IL_0006: ret

  } // end of method ReadOnlyAttribute::.ctor
} // end of class Sirenix.OdinInspector.ReadOnlyAttribute
