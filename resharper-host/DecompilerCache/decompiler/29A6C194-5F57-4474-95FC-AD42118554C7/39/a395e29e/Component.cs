// Decompiled with JetBrains decompiler
// Type: System.ComponentModel.Component
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: 29A6C194-5F57-4474-95FC-AD42118554C7
// Assembly location: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.dll

using System.Runtime.InteropServices;

namespace System.ComponentModel
{
  /// <summary>
  ///   提供基底實作 <see cref="T:System.ComponentModel.IComponent" /> 介面，並讓應用程式之間共用的物件。
  /// </summary>
  [ComVisible(true)]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [DesignerCategory("Component")]
  public class Component : MarshalByRefObject, IComponent, IDisposable
  {
    private static readonly object EventDisposed = new object();
    private ISite site;
    private EventHandlerList events;

    /// <summary>
    ///   釋出 Unmanaged 資源並執行其他清除作業後，記憶體回收才能重新回收 <see cref="T:System.ComponentModel.Component" />。
    /// </summary>
    ~Component() => this.Dispose(false);

    /// <summary>取得值，指出元件是否可以引發事件。</summary>
    /// <returns>
    ///   <see langword="true" /> 如果元件可以引發事件。否則， <see langword="false" />。
    ///    預設為 <see langword="true" />。
    /// </returns>
    protected virtual bool CanRaiseEvents => true;

    internal bool CanRaiseEventsInternal => this.CanRaiseEvents;

    /// <summary>
    ///   藉由呼叫處置元件時，會發生 <see cref="M:System.ComponentModel.Component.Dispose" /> 方法。
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public event EventHandler Disposed
    {
      add => this.Events.AddHandler(Component.EventDisposed, (Delegate) value);
      remove => this.Events.RemoveHandler(Component.EventDisposed, (Delegate) value);
    }

    /// <summary>
    ///   取得事件處理常式附加至這個清單 <see cref="T:System.ComponentModel.Component" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.ComponentModel.EventHandlerList" /> 這個元件提供的委派。
    /// </returns>
    protected EventHandlerList Events
    {
      get
      {
        if (this.events == null)
          this.events = new EventHandlerList(this);
        return this.events;
      }
    }

    /// <summary>
    ///   取得或設定 <see cref="T:System.ComponentModel.ISite" /> 的 <see cref="T:System.ComponentModel.Component" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.ComponentModel.ISite" /> 聯 <see cref="T:System.ComponentModel.Component" />, ，或 <see langword="null" /> 如果 <see cref="T:System.ComponentModel.Component" /> 不封裝在 <see cref="T:System.ComponentModel.IContainer" />, 、 <see cref="T:System.ComponentModel.Component" /> 沒有 <see cref="T:System.ComponentModel.ISite" /> 與其相關聯，或 <see cref="T:System.ComponentModel.Component" /> 移除其 <see cref="T:System.ComponentModel.IContainer" />。
    /// </returns>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual ISite Site
    {
      get => this.site;
      set => this.site = value;
    }

    /// <summary>
    ///   釋放 <see cref="T:System.ComponentModel.Component" /> 所使用的所有資源。
    /// </summary>
    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    /// <summary>
    ///   釋放 <see cref="T:System.ComponentModel.Component" /> 所使用的 Unmanaged 資源，並選擇性地釋放 Managed 資源。
    /// </summary>
    /// <param name="disposing">
    ///   <see langword="true" /> 表示釋放 Managed 和 Unmanaged 資源，<see langword="false" /> 則表示只釋放 Unmanaged 資源。
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposing)
        return;
      lock (this)
      {
        if (this.site != null && this.site.Container != null)
          this.site.Container.Remove((IComponent) this);
        if (this.events == null)
          return;
        EventHandler eventHandler = (EventHandler) this.events[Component.EventDisposed];
        if (eventHandler == null)
          return;
        eventHandler((object) this, EventArgs.Empty);
      }
    }

    /// <summary>
    ///   取得 <see cref="T:System.ComponentModel.IContainer" /> ，其中包含 <see cref="T:System.ComponentModel.Component" />。
    /// </summary>
    /// <returns>
    ///   <see cref="T:System.ComponentModel.IContainer" /> ，其中包含 <see cref="T:System.ComponentModel.Component" />, ，若有的話，或 <see langword="null" /> 如果 <see cref="T:System.ComponentModel.Component" /> 不封裝在 <see cref="T:System.ComponentModel.IContainer" />。
    /// </returns>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IContainer Container => this.site?.Container;

    /// <summary>
    ///   傳回表示 <see cref="T:System.ComponentModel.Component" /> 或其 <see cref="T:System.ComponentModel.Container" /> 所提供之服務的物件。
    /// </summary>
    /// <param name="service">
    ///   所提供的服務 <see cref="T:System.ComponentModel.Component" />。
    /// </param>
    /// <returns>
    ///   <see cref="T:System.Object" /> ，代表所提供的服務 <see cref="T:System.ComponentModel.Component" />, ，或 <see langword="null" /> 如果 <see cref="T:System.ComponentModel.Component" /> 不會提供指定的服務。
    /// </returns>
    protected virtual object GetService(Type service) => this.site?.GetService(service);

    /// <summary>
    ///   取得值，指出是否 <see cref="T:System.ComponentModel.Component" /> 目前正處於設計模式。
    /// </summary>
    /// <returns>
    ///   <see langword="true" /> 如果 <see cref="T:System.ComponentModel.Component" /> 處於設計模式; 否則 <see langword="false" />。
    /// </returns>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    protected bool DesignMode
    {
      get
      {
        ISite site = this.site;
        return site != null && site.DesignMode;
      }
    }

    /// <summary>
    ///   傳回 <see cref="T:System.String" /> 包含名稱的 <see cref="T:System.ComponentModel.Component" />, ，若有的話。
    ///    不應覆寫此方法。
    /// </summary>
    /// <returns>
    ///   A <see cref="T:System.String" /> 包含名稱的 <see cref="T:System.ComponentModel.Component" />, ，若有的話，或 <see langword="null" /> 如果 <see cref="T:System.ComponentModel.Component" /> 未命名。
    /// </returns>
    public override string ToString()
    {
      ISite site = this.site;
      return site != null ? site.Name + " [" + this.GetType().FullName + "]" : this.GetType().FullName;
    }
  }
}
