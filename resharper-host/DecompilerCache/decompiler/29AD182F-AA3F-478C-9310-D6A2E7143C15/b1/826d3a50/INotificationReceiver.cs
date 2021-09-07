// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.INotificationReceiver
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 29AD182F-AA3F-478C-9310-D6A2E7143C15
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
  [RequiredByNativeCode]
  public interface INotificationReceiver
  {
    /// <summary>
    ///   <para>The method called when a notification is raised.</para>
    /// </summary>
    /// <param name="origin">The playable that sent the notification.</param>
    /// <param name="notification">The received notification.</param>
    /// <param name="context">User defined data that depends on the type of notification. Uses this to pass necessary information that can change with each invocation.</param>
    [RequiredByNativeCode]
    void OnNotify(Playable origin, INotification notification, object context);
  }
}
