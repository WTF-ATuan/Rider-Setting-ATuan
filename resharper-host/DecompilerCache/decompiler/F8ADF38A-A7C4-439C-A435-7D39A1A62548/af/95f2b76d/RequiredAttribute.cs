// Decompiled with JetBrains decompiler
// Type: Sirenix.OdinInspector.RequiredAttribute
// Assembly: Sirenix.OdinInspector.Attributes, Version=3.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: F8ADF38A-A7C4-439C-A435-7D39A1A62548
// Assembly location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Odin\Assemblies\Sirenix.OdinInspector.Attributes.dll

using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
  /// <summary>
  /// <para>Required is used on any object property, and draws a message in the inspector if the property is missing.</para>
  /// <para>Use this to clearly mark fields as necessary to the object.</para>
  /// </summary>
  /// <example>
  /// <para>The following example shows different uses of the Required attribute.</para>
  /// <code>
  /// public class MyComponent : MonoBehaviour
  /// {
  /// 	[Required]
  /// 	public GameObject MyPrefab;
  /// 
  /// 	[Required(InfoMessageType.Warning)]
  /// 	public Texture2D MyTexture;
  /// 
  /// 	[Required("MyMesh is nessessary for this component.")]
  /// 	public Mesh MyMesh;
  /// 
  /// 	[Required("MyTransform might be important.", InfoMessageType.Info)]
  /// 	public Transform MyTransform;
  /// }
  /// </code>
  /// </example>
  /// <seealso cref="T:Sirenix.OdinInspector.InfoBoxAttribute" />
  /// <seealso cref="T:Sirenix.OdinInspector.ValidateInputAttribute" />
  [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
  [Conditional("UNITY_EDITOR")]
  public sealed class RequiredAttribute : Attribute
  {
    /// <summary>The message of the info box.</summary>
    public string ErrorMessage;
    /// <summary>The type of the info box.</summary>
    public InfoMessageType MessageType;

    /// <summary>
    /// Adds an error box to the inspector, if the property is missing.
    /// </summary>
    public RequiredAttribute() => this.MessageType = InfoMessageType.Error;

    /// <summary>
    /// Adds an info box to the inspector, if the property is missing.
    /// </summary>
    /// <param name="errorMessage">The message to display in the error box.</param>
    /// <param name="messageType">The type of info box to draw.</param>
    public RequiredAttribute(string errorMessage, InfoMessageType messageType)
    {
      this.ErrorMessage = errorMessage;
      this.MessageType = messageType;
    }

    /// <summary>
    /// Adds an error box to the inspector, if the property is missing.
    /// </summary>
    /// <param name="errorMessage">The message to display in the error box.</param>
    public RequiredAttribute(string errorMessage)
    {
      this.ErrorMessage = errorMessage;
      this.MessageType = InfoMessageType.Error;
    }

    /// <summary>
    /// Adds an info box to the inspector, if the property is missing.
    /// </summary>
    /// <param name="messageType">The type of info box to draw.</param>
    public RequiredAttribute(InfoMessageType messageType) => this.MessageType = messageType;
  }
}
