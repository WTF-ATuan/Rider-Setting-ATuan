﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.AnimationEvent
// Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 81A2A079-7F3C-43B2-AABD-7604740BCD48
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll

using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>AnimationEvent lets you call a script function similar to SendMessage as part of playing back an animation.</para>
  /// </summary>
  [RequiredByNativeCode]
  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public sealed class AnimationEvent
  {
    internal float m_Time;
    internal string m_FunctionName;
    internal string m_StringParameter;
    internal Object m_ObjectReferenceParameter;
    internal float m_FloatParameter;
    internal int m_IntParameter;
    internal int m_MessageOptions;
    internal AnimationEventSource m_Source;
    internal AnimationState m_StateSender;
    internal AnimatorStateInfo m_AnimatorStateInfo;
    internal AnimatorClipInfo m_AnimatorClipInfo;

    /// <summary>
    ///   <para>Creates a new animation event.</para>
    /// </summary>
    public AnimationEvent()
    {
      this.m_Time = 0.0f;
      this.m_FunctionName = "";
      this.m_StringParameter = "";
      this.m_ObjectReferenceParameter = (Object) null;
      this.m_FloatParameter = 0.0f;
      this.m_IntParameter = 0;
      this.m_MessageOptions = 0;
      this.m_Source = AnimationEventSource.NoSource;
      this.m_StateSender = (AnimationState) null;
    }

    [Obsolete("Use stringParameter instead")]
    public string data
    {
      get => this.m_StringParameter;
      set => this.m_StringParameter = value;
    }

    /// <summary>
    ///   <para>String parameter that is stored in the event and will be sent to the function.</para>
    /// </summary>
    public string stringParameter
    {
      get => this.m_StringParameter;
      set => this.m_StringParameter = value;
    }

    /// <summary>
    ///   <para>Float parameter that is stored in the event and will be sent to the function.</para>
    /// </summary>
    public float floatParameter
    {
      get => this.m_FloatParameter;
      set => this.m_FloatParameter = value;
    }

    /// <summary>
    ///   <para>Int parameter that is stored in the event and will be sent to the function.</para>
    /// </summary>
    public int intParameter
    {
      get => this.m_IntParameter;
      set => this.m_IntParameter = value;
    }

    /// <summary>
    ///   <para>Object reference parameter that is stored in the event and will be sent to the function.</para>
    /// </summary>
    public Object objectReferenceParameter
    {
      get => this.m_ObjectReferenceParameter;
      set => this.m_ObjectReferenceParameter = value;
    }

    /// <summary>
    ///   <para>The name of the function that will be called.</para>
    /// </summary>
    public string functionName
    {
      get => this.m_FunctionName;
      set => this.m_FunctionName = value;
    }

    /// <summary>
    ///   <para>The time at which the event will be fired off.</para>
    /// </summary>
    public float time
    {
      get => this.m_Time;
      set => this.m_Time = value;
    }

    /// <summary>
    ///   <para>Function call options.</para>
    /// </summary>
    public SendMessageOptions messageOptions
    {
      get => (SendMessageOptions) this.m_MessageOptions;
      set => this.m_MessageOptions = (int) value;
    }

    /// <summary>
    ///   <para>Returns true if this Animation event has been fired by an Animation component.</para>
    /// </summary>
    public bool isFiredByLegacy => this.m_Source == AnimationEventSource.Legacy;

    /// <summary>
    ///   <para>Returns true if this Animation event has been fired by an Animator component.</para>
    /// </summary>
    public bool isFiredByAnimator => this.m_Source == AnimationEventSource.Animator;

    /// <summary>
    ///   <para>The animation state that fired this event (Read Only).</para>
    /// </summary>
    public AnimationState animationState
    {
      get
      {
        if (!this.isFiredByLegacy)
          Debug.LogError((object) "AnimationEvent was not fired by Animation component, you shouldn't use AnimationEvent.animationState");
        return this.m_StateSender;
      }
    }

    /// <summary>
    ///   <para>The animator state info related to this event (Read Only).</para>
    /// </summary>
    public AnimatorStateInfo animatorStateInfo
    {
      get
      {
        if (!this.isFiredByAnimator)
          Debug.LogError((object) "AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorStateInfo");
        return this.m_AnimatorStateInfo;
      }
    }

    /// <summary>
    ///   <para>The animator clip info related to this event (Read Only).</para>
    /// </summary>
    public AnimatorClipInfo animatorClipInfo
    {
      get
      {
        if (!this.isFiredByAnimator)
          Debug.LogError((object) "AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorClipInfo");
        return this.m_AnimatorClipInfo;
      }
    }

    internal int GetHash() => 33 * this.functionName.GetHashCode() + this.time.GetHashCode();
  }
}
