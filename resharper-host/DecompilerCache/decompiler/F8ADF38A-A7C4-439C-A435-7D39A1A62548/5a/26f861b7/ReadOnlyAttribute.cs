// Decompiled with JetBrains decompiler
// Type: Sirenix.OdinInspector.ReadOnlyAttribute
// Assembly: Sirenix.OdinInspector.Attributes, Version=3.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: F8ADF38A-A7C4-439C-A435-7D39A1A62548
// Assembly location: D:\unity\project\Anivine-V2\Assets\Odin\Assemblies\Sirenix.OdinInspector.Attributes.dll

using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
  /// <summary>
  /// <para>ReadOnly is used on any property, and disabled the property from being changed in the inspector.</para>
  /// <para>Use this for when you want to see the value of a property in the inspector, but don't want it to be changed.</para>
  /// </summary>
  /// <remarks>
  /// <note type="note">This attribute only affects the inspector! Values can still be changed by script.</note>
  /// </remarks>
  /// <example>
  /// <para>The following example shows how a field can be displayed in the editor, but not be editable.</para>
  /// <code>
  /// public class Health : MonoBehaviour
  /// {
  /// 	public int MaxHealth;
  /// 
  /// 	[ReadOnly]
  /// 	public int CurrentHealth;
  /// }
  /// </code>
  /// </example>
  /// <example>
  /// <para>ReadOnly can also be combined with <see cref="T:Sirenix.OdinInspector.ShowInInspectorAttribute" />.</para>
  /// <code>
  /// public class Health : MonoBehaviour
  /// {
  /// 	public int MaxHealth;
  /// 
  /// 	[ShowInInspector, ReadOnly]
  /// 	private int currentHealth;
  /// }
  /// </code>
  /// </example>
  /// <seealso cref="T:Sirenix.OdinInspector.ShowInInspectorAttribute" />
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  [Conditional("UNITY_EDITOR")]
  public sealed class ReadOnlyAttribute : Attribute
  {
  }
}
