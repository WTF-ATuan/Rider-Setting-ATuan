// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEvent
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
  /// <summary>
  ///   <para>A zero argument persistent callback that can be saved with the Scene.</para>
  /// </summary>
  [Serializable]
  public class UnityEvent : UnityEventBase
  {
    private object[] m_InvokeArray = (object[]) null;

    /// <summary>
    ///   <para>Constructor.</para>
    /// </summary>
    [RequiredByNativeCode]
    public UnityEvent()
    {
    }

    /// <summary>
    ///   <para>Add a non persistent listener to the UnityEvent.</para>
    /// </summary>
    /// <param name="call">Callback function.</param>
    public void AddListener(UnityAction call) => this.AddCall(UnityEvent.GetDelegate(call));

    /// <summary>
    ///   <para>Remove a non persistent listener from the UnityEvent.</para>
    /// </summary>
    /// <param name="call">Callback function.</param>
    public void RemoveListener(UnityAction call) => this.RemoveListener(call.Target, call.Method);

    protected override MethodInfo FindMethod_Impl(string name, object targetObj) => UnityEventBase.GetValidMethodInfo(targetObj, name, new System.Type[0]);

    internal override BaseInvokableCall GetDelegate(
      object target,
      MethodInfo theFunction)
    {
      return (BaseInvokableCall) new InvokableCall(target, theFunction);
    }

    private static BaseInvokableCall GetDelegate(UnityAction action) => (BaseInvokableCall) new InvokableCall(action);

    /// <summary>
    ///   <para>Invoke all registered callbacks (runtime and persistent).</para>
    /// </summary>
    public void Invoke()
    {
      List<BaseInvokableCall> baseInvokableCallList = this.PrepareInvoke();
      for (int index = 0; index < baseInvokableCallList.Count; ++index)
      {
        if (baseInvokableCallList[index] is InvokableCall invokableCall)
          invokableCall.Invoke();
        else if (baseInvokableCallList[index] is InvokableCall invokableCall)
        {
          invokableCall.Invoke();
        }
        else
        {
          BaseInvokableCall baseInvokableCall = baseInvokableCallList[index];
          if (this.m_InvokeArray == null)
            this.m_InvokeArray = new object[0];
          baseInvokableCall.Invoke(this.m_InvokeArray);
        }
      }
    }

    internal void AddPersistentListener(UnityAction call) => this.AddPersistentListener(call, UnityEventCallState.RuntimeOnly);

    internal void AddPersistentListener(UnityAction call, UnityEventCallState callState)
    {
      int persistentEventCount = this.GetPersistentEventCount();
      this.AddPersistentListener();
      this.RegisterPersistentListener(persistentEventCount, call);
      this.SetPersistentListenerState(persistentEventCount, callState);
    }

    internal void RegisterPersistentListener(int index, UnityAction call)
    {
      if (call == null)
        Debug.LogWarning((object) "Registering a Listener requires an action");
      else
        this.RegisterPersistentListener(index, (object) (call.Target as UnityEngine.Object), call.Method);
    }
  }
}
