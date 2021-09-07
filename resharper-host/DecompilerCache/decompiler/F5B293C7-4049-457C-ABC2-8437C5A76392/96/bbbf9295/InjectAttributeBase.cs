// Decompiled with JetBrains decompiler
// Type: Zenject.InjectAttributeBase
// Assembly: Zenject-usage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F5B293C7-4049-457C-ABC2-8437C5A76392
// Assembly location: D:\unity\project\Final-GameMechanics\Assets\Plugins\Zenject\Source\Usage\Zenject-usage.dll

using JetBrains.Annotations;
using Zenject.Internal;

namespace Zenject
{
  [MeansImplicitUse(ImplicitUseKindFlags.Assign)]
  public abstract class InjectAttributeBase : PreserveAttribute
  {
    public bool Optional { get; set; }

    public object Id { get; set; }

    public InjectSources Source { get; set; }
  }
}
