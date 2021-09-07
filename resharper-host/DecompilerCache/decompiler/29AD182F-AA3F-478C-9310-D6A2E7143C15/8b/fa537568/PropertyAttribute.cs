// Decompiled with JetBrains decompiler
// Type: UnityEngine.PropertyAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Base class to derive custom property attributes from. Use this to create custom attributes for script variables.</para>
  /// </summary>
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public abstract class PropertyAttribute : Attribute
  {
    /// <summary>
    ///   <para>Optional field to specify the order that multiple DecorationDrawers should be drawn in.</para>
    /// </summary>
    public int order { get; set; }
  }
}
