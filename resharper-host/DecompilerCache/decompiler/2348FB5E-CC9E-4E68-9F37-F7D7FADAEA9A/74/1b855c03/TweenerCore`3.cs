// Decompiled with JetBrains decompiler
// Type: DG.Tweening.Core.TweenerCore`3
// Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2348FB5E-CC9E-4E68-9F37-F7D7FADAEA9A
// Assembly location: D:\unity\project\AnitvineV2.0(Gitlab)\anitvine\Assets\Plugins\Demigiant\DOTween\DOTween.dll

using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using System;

namespace DG.Tweening.Core
{
  public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct, IPlugOptions
  {
    public T2 startValue;
    public T2 endValue;
    public T2 changeValue;
    public TPlugOptions plugOptions;
    public DOGetter<T1> getter;
    public DOSetter<T1> setter;
    internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
    private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

    internal TweenerCore()
    {
      this.typeofT1 = typeof (T1);
      this.typeofT2 = typeof (T2);
      this.typeofTPlugOptions = typeof (TPlugOptions);
      this.tweenType = TweenType.Tweener;
      this.Reset();
    }

    public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f)
    {
      if (this.isSequenced)
      {
        if (Debugger.logPriority >= 1)
          Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
        return (Tweener) this;
      }
      Type type = newStartValue.GetType();
      if (type == this.typeofT2)
        return (Tweener) Tweener.DoChangeStartValue<T1, T2, TPlugOptions>(this, (T2) newStartValue, newDuration);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) ("ChangeStartValue: incorrect newStartValue type (is " + type?.ToString() + ", should be " + this.typeofT2?.ToString() + ")"), (Tween) this);
      return (Tweener) this;
    }

    public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue) => this.ChangeEndValue(newEndValue, -1f, snapStartValue);

    public override Tweener ChangeEndValue(
      object newEndValue,
      float newDuration = -1f,
      bool snapStartValue = false)
    {
      if (this.isSequenced)
      {
        if (Debugger.logPriority >= 1)
          Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
        return (Tweener) this;
      }
      Type type = newEndValue.GetType();
      if (type == this.typeofT2)
        return (Tweener) Tweener.DoChangeEndValue<T1, T2, TPlugOptions>(this, (T2) newEndValue, newDuration, snapStartValue);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) ("ChangeEndValue: incorrect newEndValue type (is " + type?.ToString() + ", should be " + this.typeofT2?.ToString() + ")"), (Tween) this);
      return (Tweener) this;
    }

    public override Tweener ChangeValues(
      object newStartValue,
      object newEndValue,
      float newDuration = -1f)
    {
      if (this.isSequenced)
      {
        if (Debugger.logPriority >= 1)
          Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
        return (Tweener) this;
      }
      Type type1 = newStartValue.GetType();
      Type type2 = newEndValue.GetType();
      if (type1 != this.typeofT2)
      {
        if (Debugger.logPriority >= 1)
          Debugger.LogWarning((object) ("ChangeValues: incorrect value type (is " + type1?.ToString() + ", should be " + this.typeofT2?.ToString() + ")"), (Tween) this);
        return (Tweener) this;
      }
      if (type2 == this.typeofT2)
        return (Tweener) Tweener.DoChangeValues<T1, T2, TPlugOptions>(this, (T2) newStartValue, (T2) newEndValue, newDuration);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) ("ChangeValues: incorrect value type (is " + type2?.ToString() + ", should be " + this.typeofT2?.ToString() + ")"), (Tween) this);
      return (Tweener) this;
    }

    /// <summary>NO-GC METHOD: changes the start value of a tween and rewinds it (without pausing it).
    /// Has no effect with tweens that are inside Sequences</summary>
    /// <param name="newStartValue">The new start value</param>
    /// <param name="newDuration">If bigger than 0 applies it as the new tween duration</param>
    public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(
      T2 newStartValue,
      float newDuration = -1f)
    {
      if (!this.isSequenced)
        return Tweener.DoChangeStartValue<T1, T2, TPlugOptions>(this, newStartValue, newDuration);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
      return this;
    }

    /// <summary>NO-GC METHOD: changes the end value of a tween and rewinds it (without pausing it).
    /// Has no effect with tweens that are inside Sequences</summary>
    /// <param name="newEndValue">The new end value</param>
    /// <param name="snapStartValue">If TRUE the start value will become the current target's value, otherwise it will stay the same</param>
    public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(
      T2 newEndValue,
      bool snapStartValue)
    {
      return this.ChangeEndValue(newEndValue, -1f, snapStartValue);
    }

    /// <summary>NO-GC METHOD: changes the end value of a tween and rewinds it (without pausing it).
    /// Has no effect with tweens that are inside Sequences</summary>
    /// <param name="newEndValue">The new end value</param>
    /// <param name="newDuration">If bigger than 0 applies it as the new tween duration</param>
    /// <param name="snapStartValue">If TRUE the start value will become the current target's value, otherwise it will stay the same</param>
    public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(
      T2 newEndValue,
      float newDuration = -1f,
      bool snapStartValue = false)
    {
      if (!this.isSequenced)
        return Tweener.DoChangeEndValue<T1, T2, TPlugOptions>(this, newEndValue, newDuration, snapStartValue);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
      return this;
    }

    /// <summary>NO-GC METHOD: changes the start and end value of a tween and rewinds it (without pausing it).
    /// Has no effect with tweens that are inside Sequences</summary>
    /// <param name="newStartValue">The new start value</param>
    /// <param name="newEndValue">The new end value</param>
    /// <param name="newDuration">If bigger than 0 applies it as the new tween duration</param>
    public TweenerCore<T1, T2, TPlugOptions> ChangeValues(
      T2 newStartValue,
      T2 newEndValue,
      float newDuration = -1f)
    {
      if (!this.isSequenced)
        return Tweener.DoChangeValues<T1, T2, TPlugOptions>(this, newStartValue, newEndValue, newDuration);
      if (Debugger.logPriority >= 1)
        Debugger.LogWarning((object) "You cannot change the values of a tween contained inside a Sequence", (Tween) this);
      return this;
    }

    internal override Tweener SetFrom(bool relative)
    {
      this.tweenPlugin.SetFrom(this, relative);
      this.hasManuallySetStartValue = true;
      return (Tweener) this;
    }

    internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative)
    {
      this.tweenPlugin.SetFrom(this, fromValue, setImmediately, relative);
      this.hasManuallySetStartValue = true;
      return (Tweener) this;
    }

    internal override sealed void Reset()
    {
      base.Reset();
      if (this.tweenPlugin != null)
        this.tweenPlugin.Reset(this);
      this.plugOptions.Reset();
      this.getter = (DOGetter<T1>) null;
      this.setter = (DOSetter<T1>) null;
      this.hasManuallySetStartValue = false;
      this.isFromAllowed = true;
    }

    internal override bool Validate()
    {
      try
      {
        T1 obj = this.getter();
      }
      catch
      {
        return false;
      }
      return true;
    }

    internal override float UpdateDelay(float elapsed) => Tweener.DoUpdateDelay<T1, T2, TPlugOptions>(this, elapsed);

    internal override bool Startup() => Tweener.DoStartup<T1, T2, TPlugOptions>(this);

    internal override bool ApplyTween(
      float prevPosition,
      int prevCompletedLoops,
      int newCompletedSteps,
      bool useInversePosition,
      UpdateMode updateMode,
      UpdateNotice updateNotice)
    {
      float elapsed = useInversePosition ? this.duration - this.position : this.position;
      if (DOTween.useSafeMode)
      {
        try
        {
          this.tweenPlugin.EvaluateAndApply(this.plugOptions, (Tween) this, this.isRelative, this.getter, this.setter, elapsed, this.startValue, this.changeValue, this.duration, useInversePosition, updateNotice);
        }
        catch (Exception ex)
        {
          if (Debugger.logPriority >= 1)
            Debugger.LogWarning((object) string.Format("Target or field is missing/null ({0}) ► {1}\n\n{2}\n\n", (object) ex.TargetSite, (object) ex.Message, (object) ex.StackTrace), (Tween) this);
          DOTween.safeModeReport.Add(SafeModeReport.SafeModeReportType.TargetOrFieldMissing);
          return true;
        }
      }
      else
        this.tweenPlugin.EvaluateAndApply(this.plugOptions, (Tween) this, this.isRelative, this.getter, this.setter, elapsed, this.startValue, this.changeValue, this.duration, useInversePosition, updateNotice);
      return false;
    }
  }
}
