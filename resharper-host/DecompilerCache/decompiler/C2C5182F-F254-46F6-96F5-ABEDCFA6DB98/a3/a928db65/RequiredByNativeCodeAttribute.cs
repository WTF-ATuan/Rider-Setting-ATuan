// Decompiled with JetBrains decompiler
// Type: UnityEngine.Scripting.RequiredByNativeCodeAttribute
// Assembly: UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C2C5182F-F254-46F6-96F5-ABEDCFA6DB98
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.SharedInternalsModule.dll

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
  [VisibleToOtherModules]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
  internal class RequiredByNativeCodeAttribute : Attribute
  {
    public RequiredByNativeCodeAttribute()
    {
    }

    public RequiredByNativeCodeAttribute(string name) => this.Name = name;

    public RequiredByNativeCodeAttribute(bool optional) => this.Optional = optional;

    public RequiredByNativeCodeAttribute(string name, bool optional)
    {
      this.Name = name;
      this.Optional = optional;
    }

    public string Name { get; set; }

    public bool Optional { get; set; }

    public bool GenerateProxy { get; set; }
  }
}
