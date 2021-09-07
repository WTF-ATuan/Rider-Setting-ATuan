// Decompiled with JetBrains decompiler
// Type: UnityEngine.Material
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The material class.</para>
  /// </summary>
  [NativeHeader("Runtime/Shaders/Material.h")]
  [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
  public class Material : Object
  {
    [Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", false)]
    public static Material Create(string scriptContents) => new Material(scriptContents);

    [FreeFunction("MaterialScripting::CreateWithShader")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void CreateWithShader([Writable] Material self, [NotNull] Shader shader);

    [FreeFunction("MaterialScripting::CreateWithMaterial")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void CreateWithMaterial([Writable] Material self, [NotNull] Material source);

    [FreeFunction("MaterialScripting::CreateWithString")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void CreateWithString([Writable] Material self);

    /// <summary>
    ///   <para>Create a temporary Material.</para>
    /// </summary>
    /// <param name="shader">Create a material with a given Shader.</param>
    /// <param name="source">Create a material by copying all properties from another material.</param>
    public Material(Shader shader) => Material.CreateWithShader(this, shader);

    /// <summary>
    ///   <para>Create a temporary Material.</para>
    /// </summary>
    /// <param name="shader">Create a material with a given Shader.</param>
    /// <param name="source">Create a material by copying all properties from another material.</param>
    [RequiredByNativeCode]
    public Material(Material source) => Material.CreateWithMaterial(this, source);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="contents"></param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
    public Material(string contents) => Material.CreateWithString(this);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern Material GetDefaultMaterial();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern Material GetDefaultParticleMaterial();

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern Material GetDefaultLineMaterial();

    /// <summary>
    ///   <para>The shader used by the material.</para>
    /// </summary>
    public extern Shader shader { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The main material's color.</para>
    /// </summary>
    public Color color
    {
      get
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainColor);
        return nameIdByAttribute >= 0 ? this.GetColor(nameIdByAttribute) : this.GetColor("_Color");
      }
      set
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainColor);
        if (nameIdByAttribute >= 0)
          this.SetColor(nameIdByAttribute, value);
        else
          this.SetColor("_Color", value);
      }
    }

    /// <summary>
    ///   <para>The material's texture.</para>
    /// </summary>
    public Texture mainTexture
    {
      get
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        return nameIdByAttribute >= 0 ? this.GetTexture(nameIdByAttribute) : this.GetTexture("_MainTex");
      }
      set
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        if (nameIdByAttribute >= 0)
          this.SetTexture(nameIdByAttribute, value);
        else
          this.SetTexture("_MainTex", value);
      }
    }

    /// <summary>
    ///   <para>The texture offset of the main texture.</para>
    /// </summary>
    public Vector2 mainTextureOffset
    {
      get
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        return nameIdByAttribute >= 0 ? this.GetTextureOffset(nameIdByAttribute) : this.GetTextureOffset("_MainTex");
      }
      set
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        if (nameIdByAttribute >= 0)
          this.SetTextureOffset(nameIdByAttribute, value);
        else
          this.SetTextureOffset("_MainTex", value);
      }
    }

    /// <summary>
    ///   <para>The texture scale of the main texture.</para>
    /// </summary>
    public Vector2 mainTextureScale
    {
      get
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        return nameIdByAttribute >= 0 ? this.GetTextureScale(nameIdByAttribute) : this.GetTextureScale("_MainTex");
      }
      set
      {
        int nameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
        if (nameIdByAttribute >= 0)
          this.SetTextureScale(nameIdByAttribute, value);
        else
          this.SetTextureScale("_MainTex", value);
      }
    }

    [NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag);

    /// <summary>
    ///   <para>Checks if material's shader has a property of a given name.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    [NativeName("HasPropertyFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool HasProperty(int nameID);

    /// <summary>
    ///   <para>Checks if material's shader has a property of a given name.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public bool HasProperty(string name) => this.HasProperty(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Render queue of this material.</para>
    /// </summary>
    public extern int renderQueue { [NativeName("GetActualRenderQueue"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetCustomRenderQueue"), MethodImpl(MethodImplOptions.InternalCall)] set; }

    internal extern int rawRenderQueue { [NativeName("GetCustomRenderQueue"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Sets a shader keyword that is enabled by this material.</para>
    /// </summary>
    /// <param name="keyword"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void EnableKeyword(string keyword);

    /// <summary>
    ///   <para>Unset a shader keyword.</para>
    /// </summary>
    /// <param name="keyword"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void DisableKeyword(string keyword);

    /// <summary>
    ///   <para>Is the shader keyword enabled on this material?</para>
    /// </summary>
    /// <param name="keyword"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool IsKeywordEnabled(string keyword);

    /// <summary>
    ///   <para>Defines how the material should interact with lightmaps and lightprobes.</para>
    /// </summary>
    public extern MaterialGlobalIlluminationFlags globalIlluminationFlags { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Gets and sets whether the Double Sided Global Illumination setting is enabled for this material.</para>
    /// </summary>
    public extern bool doubleSidedGI { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Gets and sets whether GPU instancing is enabled for this material.</para>
    /// </summary>
    [NativeProperty("EnableInstancingVariants")]
    public extern bool enableInstancing { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>How many passes are in this material (Read Only).</para>
    /// </summary>
    public extern int passCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Enables or disables a Shader pass on a per-Material level.</para>
    /// </summary>
    /// <param name="passName">Shader pass name (case insensitive).</param>
    /// <param name="enabled">Flag indicating whether this Shader pass should be enabled.</param>
    [FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetShaderPassEnabled(string passName, bool enabled);

    /// <summary>
    ///   <para>Checks whether a given Shader pass is enabled on this Material.</para>
    /// </summary>
    /// <param name="passName">Shader pass name (case insensitive).</param>
    /// <returns>
    ///   <para>True if the Shader pass is enabled.</para>
    /// </returns>
    [FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool GetShaderPassEnabled(string passName);

    /// <summary>
    ///   <para>Returns the name of the shader pass at index pass.</para>
    /// </summary>
    /// <param name="pass"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern string GetPassName(int pass);

    /// <summary>
    ///   <para>Returns the index of the pass passName.</para>
    /// </summary>
    /// <param name="passName"></param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int FindPass(string passName);

    /// <summary>
    ///   <para>Sets an override tag/value on the material.</para>
    /// </summary>
    /// <param name="tag">Name of the tag to set.</param>
    /// <param name="val">Name of the value to set. Empty string to clear the override flag.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetOverrideTag(string tag, string val);

    [NativeName("GetTag")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);

    /// <summary>
    ///   <para>Get the value of material's shader tag.</para>
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="searchFallbacks"></param>
    /// <param name="defaultValue"></param>
    public string GetTag(string tag, bool searchFallbacks, string defaultValue) => this.GetTagImpl(tag, !searchFallbacks, defaultValue);

    /// <summary>
    ///   <para>Get the value of material's shader tag.</para>
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="searchFallbacks"></param>
    /// <param name="defaultValue"></param>
    public string GetTag(string tag, bool searchFallbacks) => this.GetTagImpl(tag, !searchFallbacks, "");

    /// <summary>
    ///   <para>Interpolate properties between two materials.</para>
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="t"></param>
    [FreeFunction("MaterialScripting::Lerp", HasExplicitThis = true)]
    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Lerp(Material start, Material end, float t);

    /// <summary>
    ///   <para>Activate the given pass for rendering.</para>
    /// </summary>
    /// <param name="pass">Shader pass number to setup.</param>
    /// <returns>
    ///   <para>If false is returned, no rendering should be done.</para>
    /// </returns>
    [FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool SetPass(int pass);

    /// <summary>
    ///   <para>Copy properties from other material into this material.</para>
    /// </summary>
    /// <param name="mat"></param>
    [FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void CopyPropertiesFromMaterial(Material mat);

    [FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern string[] GetShaderKeywords();

    [FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetShaderKeywords(string[] names);

    /// <summary>
    ///   <para>Additional shader keywords set by this material.</para>
    /// </summary>
    public string[] shaderKeywords
    {
      get => this.GetShaderKeywords();
      set => this.SetShaderKeywords(value);
    }

    /// <summary>
    ///   <para>Computes a CRC hash value from the content of the material.</para>
    /// </summary>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int ComputeCRC();

    /// <summary>
    ///   <para>Returns the names of all texture properties exposed on this material.</para>
    /// </summary>
    /// <param name="outNames">Names of all texture properties exposed on this material.</param>
    /// <returns>
    ///   <para>Names of all texture properties exposed on this material.</para>
    /// </returns>
    [FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern string[] GetTexturePropertyNames();

    /// <summary>
    ///   <para>Return the name IDs of all texture properties exposed on this material.</para>
    /// </summary>
    /// <param name="outNames">IDs of all texture properties exposed on this material.</param>
    /// <returns>
    ///   <para>IDs of all texture properties exposed on this material.</para>
    /// </returns>
    [FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern int[] GetTexturePropertyNameIDs();

    [FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetTexturePropertyNamesInternal(object outNames);

    [FreeFunction("MaterialScripting::GetTexturePropertyNameIDsInternal", HasExplicitThis = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetTexturePropertyNameIDsInternal(object outNames);

    public void GetTexturePropertyNames(List<string> outNames) => this.GetTexturePropertyNamesInternal((object) outNames);

    public void GetTexturePropertyNameIDs(List<int> outNames) => this.GetTexturePropertyNameIDsInternal((object) outNames);

    [NativeName("SetFloatFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatImpl(int name, float value);

    [NativeName("SetColorFromScript")]
    private void SetColorImpl(int name, Color value) => this.SetColorImpl_Injected(name, ref value);

    [NativeName("SetMatrixFromScript")]
    private void SetMatrixImpl(int name, Matrix4x4 value) => this.SetMatrixImpl_Injected(name, ref value);

    [NativeName("SetTextureFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTextureImpl(int name, Texture value);

    [NativeName("SetRenderTextureFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetRenderTextureImpl(
      int name,
      RenderTexture value,
      RenderTextureSubElement element);

    [NativeName("SetBufferFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetBufferImpl(int name, ComputeBuffer value);

    [NativeName("SetConstantBufferFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size);

    [NativeName("GetFloatFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float GetFloatImpl(int name);

    [NativeName("GetColorFromScript")]
    private Color GetColorImpl(int name)
    {
      Color ret;
      this.GetColorImpl_Injected(name, out ret);
      return ret;
    }

    [NativeName("GetMatrixFromScript")]
    private Matrix4x4 GetMatrixImpl(int name)
    {
      Matrix4x4 ret;
      this.GetMatrixImpl_Injected(name, out ret);
      return ret;
    }

    [NativeName("GetTextureFromScript")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Texture GetTextureImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::SetFloatArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetFloatArrayImpl(int name, float[] values, int count);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::SetVectorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetVectorArrayImpl(int name, Vector4[] values, int count);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::SetColorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetColorArrayImpl(int name, Color[] values, int count);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::SetMatrixArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetFloatArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern float[] GetFloatArrayImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetVectorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Vector4[] GetVectorArrayImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetColorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Color[] GetColorArrayImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetMatrixArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Matrix4x4[] GetMatrixArrayImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetFloatArrayCount")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetFloatArrayCountImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetVectorArrayCount")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetVectorArrayCountImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetColorArrayCount")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetColorArrayCountImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::GetMatrixArrayCount")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern int GetMatrixArrayCountImpl(int name);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::ExtractFloatArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ExtractFloatArrayImpl(int name, [Out] float[] val);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::ExtractVectorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ExtractVectorArrayImpl(int name, [Out] Vector4[] val);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::ExtractColorArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ExtractColorArrayImpl(int name, [Out] Color[] val);

    [FreeFunction(HasExplicitThis = true, Name = "MaterialScripting::ExtractMatrixArray")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void ExtractMatrixArrayImpl(int name, [Out] Matrix4x4[] val);

    [NativeName("GetTextureScaleAndOffsetFromScript")]
    private Vector4 GetTextureScaleAndOffsetImpl(int name)
    {
      Vector4 ret;
      this.GetTextureScaleAndOffsetImpl_Injected(name, out ret);
      return ret;
    }

    [NativeName("SetTextureOffsetFromScript")]
    private void SetTextureOffsetImpl(int name, Vector2 offset) => this.SetTextureOffsetImpl_Injected(name, ref offset);

    [NativeName("SetTextureScaleFromScript")]
    private void SetTextureScaleImpl(int name, Vector2 scale) => this.SetTextureScaleImpl_Injected(name, ref scale);

    private void SetFloatArray(int name, float[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetFloatArrayImpl(name, values, count);
    }

    private void SetVectorArray(int name, Vector4[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetVectorArrayImpl(name, values, count);
    }

    private void SetColorArray(int name, Color[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetColorArrayImpl(name, values, count);
    }

    private void SetMatrixArray(int name, Matrix4x4[] values, int count)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      if (values.Length == 0)
        throw new ArgumentException("Zero-sized array is not allowed.");
      if (values.Length < count)
        throw new ArgumentException("array has less elements than passed count.");
      this.SetMatrixArrayImpl(name, values, count);
    }

    private void ExtractFloatArray(int name, List<float> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      values.Clear();
      int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
      if (floatArrayCountImpl <= 0)
        return;
      NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
      this.ExtractFloatArrayImpl(name, (float[]) NoAllocHelpers.ExtractArrayFromList((object) values));
    }

    private void ExtractVectorArray(int name, List<Vector4> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      values.Clear();
      int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
      if (vectorArrayCountImpl <= 0)
        return;
      NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
      this.ExtractVectorArrayImpl(name, (Vector4[]) NoAllocHelpers.ExtractArrayFromList((object) values));
    }

    private void ExtractColorArray(int name, List<Color> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      values.Clear();
      int colorArrayCountImpl = this.GetColorArrayCountImpl(name);
      if (colorArrayCountImpl <= 0)
        return;
      NoAllocHelpers.EnsureListElemCount<Color>(values, colorArrayCountImpl);
      this.ExtractColorArrayImpl(name, (Color[]) NoAllocHelpers.ExtractArrayFromList((object) values));
    }

    private void ExtractMatrixArray(int name, List<Matrix4x4> values)
    {
      if (values == null)
        throw new ArgumentNullException(nameof (values));
      values.Clear();
      int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
      if (matrixArrayCountImpl <= 0)
        return;
      NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
      this.ExtractMatrixArrayImpl(name, (Matrix4x4[]) NoAllocHelpers.ExtractArrayFromList((object) values));
    }

    /// <summary>
    ///   <para>Sets a named float value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="value">Float value to set.</param>
    /// <param name="name">Property name, e.g. "_Glossiness".</param>
    public void SetFloat(string name, float value) => this.SetFloatImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets a named float value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="value">Float value to set.</param>
    /// <param name="name">Property name, e.g. "_Glossiness".</param>
    public void SetFloat(int nameID, float value) => this.SetFloatImpl(nameID, value);

    /// <summary>
    ///   <para>Sets a named integer value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="value">Integer value to set.</param>
    /// <param name="name">Property name, e.g. "_SrcBlend".</param>
    public void SetInt(string name, int value) => this.SetFloatImpl(Shader.PropertyToID(name), (float) value);

    /// <summary>
    ///   <para>Sets a named integer value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="value">Integer value to set.</param>
    /// <param name="name">Property name, e.g. "_SrcBlend".</param>
    public void SetInt(int nameID, int value) => this.SetFloatImpl(nameID, (float) value);

    /// <summary>
    ///   <para>Sets a named color value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_Color".</param>
    /// <param name="value">Color value to set.</param>
    public void SetColor(string name, Color value) => this.SetColorImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets a named color value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_Color".</param>
    /// <param name="value">Color value to set.</param>
    public void SetColor(int nameID, Color value) => this.SetColorImpl(nameID, value);

    /// <summary>
    ///   <para>Sets a named vector value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_WaveAndDistance".</param>
    /// <param name="value">Vector value to set.</param>
    public void SetVector(string name, Vector4 value) => this.SetColorImpl(Shader.PropertyToID(name), (Color) value);

    /// <summary>
    ///   <para>Sets a named vector value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_WaveAndDistance".</param>
    /// <param name="value">Vector value to set.</param>
    public void SetVector(int nameID, Vector4 value) => this.SetColorImpl(nameID, (Color) value);

    /// <summary>
    ///   <para>Sets a named matrix for the shader.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_CubemapRotation".</param>
    /// <param name="value">Matrix value to set.</param>
    public void SetMatrix(string name, Matrix4x4 value) => this.SetMatrixImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets a named matrix for the shader.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_CubemapRotation".</param>
    /// <param name="value">Matrix value to set.</param>
    public void SetMatrix(int nameID, Matrix4x4 value) => this.SetMatrixImpl(nameID, value);

    /// <summary>
    ///   <para>Sets a named texture.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture to set.</param>
    /// <param name="element">Optional parameter that specifies the type of data from the render texture to set.</param>
    public void SetTexture(string name, Texture value) => this.SetTextureImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets a named texture.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture to set.</param>
    /// <param name="element">Optional parameter that specifies the type of data from the render texture to set.</param>
    public void SetTexture(int nameID, Texture value) => this.SetTextureImpl(nameID, value);

    /// <summary>
    ///   <para>Sets a named texture.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture to set.</param>
    /// <param name="element">Optional parameter that specifies the type of data from the render texture to set.</param>
    public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) => this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);

    /// <summary>
    ///   <para>Sets a named texture.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture to set.</param>
    /// <param name="element">Optional parameter that specifies the type of data from the render texture to set.</param>
    public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) => this.SetRenderTextureImpl(nameID, value, element);

    /// <summary>
    ///   <para>Sets a named ComputeBuffer value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name.</param>
    /// <param name="value">The ComputeBuffer value to set.</param>
    public void SetBuffer(string name, ComputeBuffer value) => this.SetBufferImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets a named ComputeBuffer value.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name.</param>
    /// <param name="value">The ComputeBuffer value to set.</param>
    public void SetBuffer(int nameID, ComputeBuffer value) => this.SetBufferImpl(nameID, value);

    /// <summary>
    ///   <para>Sets a ComputeBuffer as a named constant buffer for the material.</para>
    /// </summary>
    /// <param name="name">The name of the constant buffer to override.</param>
    /// <param name="value">The ComputeBuffer to override the constant buffer values with, or null to remove binding.</param>
    /// <param name="offset">Offset in bytes from the beginning of the ComputeBuffer to bind. Must be a multiple of SystemInfo.MinConstantBufferAlignment, or 0 if that value is 0.</param>
    /// <param name="size">The number of bytes to bind.</param>
    /// <param name="nameID">The shader property ID of the constant buffer to override.</param>
    public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) => this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);

    /// <summary>
    ///   <para>Sets a ComputeBuffer as a named constant buffer for the material.</para>
    /// </summary>
    /// <param name="name">The name of the constant buffer to override.</param>
    /// <param name="value">The ComputeBuffer to override the constant buffer values with, or null to remove binding.</param>
    /// <param name="offset">Offset in bytes from the beginning of the ComputeBuffer to bind. Must be a multiple of SystemInfo.MinConstantBufferAlignment, or 0 if that value is 0.</param>
    /// <param name="size">The number of bytes to bind.</param>
    /// <param name="nameID">The shader property ID of the constant buffer to override.</param>
    public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) => this.SetConstantBufferImpl(nameID, value, offset, size);

    public void SetFloatArray(string name, List<float> values) => this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);

    public void SetFloatArray(int nameID, List<float> values) => this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);

    /// <summary>
    ///   <para>Sets a float array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="nameID">Property name ID. Use Shader.PropertyToID to get this ID.</param>
    /// <param name="values">Array of values to set.</param>
    public void SetFloatArray(string name, float[] values) => this.SetFloatArray(Shader.PropertyToID(name), values, values.Length);

    /// <summary>
    ///   <para>Sets a float array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="nameID">Property name ID. Use Shader.PropertyToID to get this ID.</param>
    /// <param name="values">Array of values to set.</param>
    public void SetFloatArray(int nameID, float[] values) => this.SetFloatArray(nameID, values, values.Length);

    public void SetColorArray(string name, List<Color> values) => this.SetColorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);

    public void SetColorArray(int nameID, List<Color> values) => this.SetColorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);

    /// <summary>
    ///   <para>Sets a color array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="values">Array of values to set.</param>
    public void SetColorArray(string name, Color[] values) => this.SetColorArray(Shader.PropertyToID(name), values, values.Length);

    /// <summary>
    ///   <para>Sets a color array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="values">Array of values to set.</param>
    public void SetColorArray(int nameID, Color[] values) => this.SetColorArray(nameID, values, values.Length);

    public void SetVectorArray(string name, List<Vector4> values) => this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);

    public void SetVectorArray(int nameID, List<Vector4> values) => this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);

    /// <summary>
    ///   <para>Sets a vector array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="values">Array of values to set.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    public void SetVectorArray(string name, Vector4[] values) => this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);

    /// <summary>
    ///   <para>Sets a vector array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="values">Array of values to set.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    public void SetVectorArray(int nameID, Vector4[] values) => this.SetVectorArray(nameID, values, values.Length);

    public void SetMatrixArray(string name, List<Matrix4x4> values) => this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);

    public void SetMatrixArray(int nameID, List<Matrix4x4> values) => this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);

    /// <summary>
    ///   <para>Sets a matrix array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="values">Array of values to set.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    public void SetMatrixArray(string name, Matrix4x4[] values) => this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);

    /// <summary>
    ///   <para>Sets a matrix array property.</para>
    /// </summary>
    /// <param name="name">Property name.</param>
    /// <param name="values">Array of values to set.</param>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    public void SetMatrixArray(int nameID, Matrix4x4[] values) => this.SetMatrixArray(nameID, values, values.Length);

    /// <summary>
    ///   <para>Get a named float value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public float GetFloat(string name) => this.GetFloatImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named float value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public float GetFloat(int nameID) => this.GetFloatImpl(nameID);

    /// <summary>
    ///   <para>Get a named integer value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public int GetInt(string name) => (int) this.GetFloatImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named integer value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public int GetInt(int nameID) => (int) this.GetFloatImpl(nameID);

    /// <summary>
    ///   <para>Get a named color value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Color GetColor(string name) => this.GetColorImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named color value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Color GetColor(int nameID) => this.GetColorImpl(nameID);

    /// <summary>
    ///   <para>Get a named vector value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector4 GetVector(string name) => (Vector4) this.GetColorImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named vector value.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector4 GetVector(int nameID) => (Vector4) this.GetColorImpl(nameID);

    /// <summary>
    ///   <para>Get a named matrix value from the shader.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Matrix4x4 GetMatrix(string name) => this.GetMatrixImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named matrix value from the shader.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Matrix4x4 GetMatrix(int nameID) => this.GetMatrixImpl(nameID);

    /// <summary>
    ///   <para>Get a named texture.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Texture GetTexture(string name) => this.GetTextureImpl(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named texture.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Texture GetTexture(int nameID) => this.GetTextureImpl(nameID);

    /// <summary>
    ///   <para>Get a named float array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public float[] GetFloatArray(string name) => this.GetFloatArray(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named float array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public float[] GetFloatArray(int nameID) => this.GetFloatArrayCountImpl(nameID) != 0 ? this.GetFloatArrayImpl(nameID) : (float[]) null;

    /// <summary>
    ///   <para>Get a named color array.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Color[] GetColorArray(string name) => this.GetColorArray(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named color array.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Color[] GetColorArray(int nameID) => this.GetColorArrayCountImpl(nameID) != 0 ? this.GetColorArrayImpl(nameID) : (Color[]) null;

    /// <summary>
    ///   <para>Get a named vector array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public Vector4[] GetVectorArray(string name) => this.GetVectorArray(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named vector array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public Vector4[] GetVectorArray(int nameID) => this.GetVectorArrayCountImpl(nameID) != 0 ? this.GetVectorArrayImpl(nameID) : (Vector4[]) null;

    /// <summary>
    ///   <para>Get a named matrix array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public Matrix4x4[] GetMatrixArray(string name) => this.GetMatrixArray(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Get a named matrix array.</para>
    /// </summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    public Matrix4x4[] GetMatrixArray(int nameID) => this.GetMatrixArrayCountImpl(nameID) != 0 ? this.GetMatrixArrayImpl(nameID) : (Matrix4x4[]) null;

    public void GetFloatArray(string name, List<float> values) => this.ExtractFloatArray(Shader.PropertyToID(name), values);

    public void GetFloatArray(int nameID, List<float> values) => this.ExtractFloatArray(nameID, values);

    public void GetColorArray(string name, List<Color> values) => this.ExtractColorArray(Shader.PropertyToID(name), values);

    public void GetColorArray(int nameID, List<Color> values) => this.ExtractColorArray(nameID, values);

    public void GetVectorArray(string name, List<Vector4> values) => this.ExtractVectorArray(Shader.PropertyToID(name), values);

    public void GetVectorArray(int nameID, List<Vector4> values) => this.ExtractVectorArray(nameID, values);

    public void GetMatrixArray(string name, List<Matrix4x4> values) => this.ExtractMatrixArray(Shader.PropertyToID(name), values);

    public void GetMatrixArray(int nameID, List<Matrix4x4> values) => this.ExtractMatrixArray(nameID, values);

    /// <summary>
    ///   <para>Sets the placement offset of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, for example: "_MainTex".</param>
    /// <param name="value">Texture placement offset.</param>
    public void SetTextureOffset(string name, Vector2 value) => this.SetTextureOffsetImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets the placement offset of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, for example: "_MainTex".</param>
    /// <param name="value">Texture placement offset.</param>
    public void SetTextureOffset(int nameID, Vector2 value) => this.SetTextureOffsetImpl(nameID, value);

    /// <summary>
    ///   <para>Sets the placement scale of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture placement scale.</param>
    public void SetTextureScale(string name, Vector2 value) => this.SetTextureScaleImpl(Shader.PropertyToID(name), value);

    /// <summary>
    ///   <para>Sets the placement scale of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">Property name ID, use Shader.PropertyToID to get it.</param>
    /// <param name="name">Property name, e.g. "_MainTex".</param>
    /// <param name="value">Texture placement scale.</param>
    public void SetTextureScale(int nameID, Vector2 value) => this.SetTextureScaleImpl(nameID, value);

    /// <summary>
    ///   <para>Gets the placement offset of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector2 GetTextureOffset(string name) => this.GetTextureOffset(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Gets the placement offset of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector2 GetTextureOffset(int nameID)
    {
      Vector4 scaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
      return new Vector2(scaleAndOffsetImpl.z, scaleAndOffsetImpl.w);
    }

    /// <summary>
    ///   <para>Gets the placement scale of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector2 GetTextureScale(string name) => this.GetTextureScale(Shader.PropertyToID(name));

    /// <summary>
    ///   <para>Gets the placement scale of texture propertyName.</para>
    /// </summary>
    /// <param name="nameID">The name ID of the property retrieved by Shader.PropertyToID.</param>
    /// <param name="name">The name of the property.</param>
    public Vector2 GetTextureScale(int nameID)
    {
      Vector4 scaleAndOffsetImpl = this.GetTextureScaleAndOffsetImpl(nameID);
      return new Vector2(scaleAndOffsetImpl.x, scaleAndOffsetImpl.y);
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetColorImpl_Injected(int name, ref Color value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetMatrixImpl_Injected(int name, ref Matrix4x4 value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetColorImpl_Injected(int name, out Color ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetMatrixImpl_Injected(int name, out Matrix4x4 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void SetTextureScaleImpl_Injected(int name, ref Vector2 scale);
  }
}
