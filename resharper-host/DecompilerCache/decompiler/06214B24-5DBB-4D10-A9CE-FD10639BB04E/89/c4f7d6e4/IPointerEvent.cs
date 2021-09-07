// Decompiled with JetBrains decompiler
// Type: UnityEngine.UIElements.IPointerEvent
// Assembly: UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 06214B24-5DBB-4D10-A9CE-FD10639BB04E
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll

namespace UnityEngine.UIElements
{
  public interface IPointerEvent
  {
    /// <summary>
    ///   <para>Identifies the pointer that sends the event.</para>
    /// </summary>
    int pointerId { get; }

    /// <summary>
    ///   <para>The type of pointer that created this event. This value is taken from the value defined in `PointerType`.</para>
    /// </summary>
    string pointerType { get; }

    /// <summary>
    ///   <para>Returns true if the pointer is a primary pointer</para>
    /// </summary>
    bool isPrimary { get; }

    /// <summary>
    ///   <para>Integer that indicates which mouse button is pressed: 0 is the left button, 1 is the right button, 2 is the middle button.</para>
    /// </summary>
    int button { get; }

    /// <summary>
    ///   <para>A bitmask that describes the currently pressed buttons.</para>
    /// </summary>
    int pressedButtons { get; }

    /// <summary>
    ///   <para>The pointer position in the Screen or World coordinate system.</para>
    /// </summary>
    Vector3 position { get; }

    /// <summary>
    ///   <para>The pointer position in the current target coordinate system.</para>
    /// </summary>
    Vector3 localPosition { get; }

    /// <summary>
    ///   <para>The difference between the pointer's position during the previous mouse event and its position during the current mouse event.</para>
    /// </summary>
    Vector3 deltaPosition { get; }

    /// <summary>
    ///   <para>The amount of time that has passed since the last recorded change in pointer values, in seconds.</para>
    /// </summary>
    float deltaTime { get; }

    /// <summary>
    ///   <para>The number of times the button is pressed.</para>
    /// </summary>
    int clickCount { get; }

    /// <summary>
    ///   <para>The amount of pressure currently applied by a touch. If the device does not report pressure, the value of this property is 1.0f.</para>
    /// </summary>
    float pressure { get; }

    /// <summary>
    ///   <para>The pressure applied to an additional pressure-sensitive control on the stylus.</para>
    /// </summary>
    float tangentialPressure { get; }

    /// <summary>
    ///   <para>Angle of the stylus relative to the surface, in radians</para>
    /// </summary>
    float altitudeAngle { get; }

    /// <summary>
    ///   <para>Angle of the stylus relative to the x-axis, in radians.</para>
    /// </summary>
    float azimuthAngle { get; }

    /// <summary>
    ///   <para>The rotation of the stylus around its axis, in radians.</para>
    /// </summary>
    float twist { get; }

    /// <summary>
    ///   <para>An estimate of the radius of a touch. Add `radiusVariance` to get the maximum touch radius, subtract it to get the minimum touch radius.</para>
    /// </summary>
    Vector2 radius { get; }

    /// <summary>
    ///   <para>Determines the accuracy of the touch radius. Add this value to the radius to get the maximum touch radius, subtract it to get the minimum touch radius.</para>
    /// </summary>
    Vector2 radiusVariance { get; }

    /// <summary>
    ///   <para>Flags that hold pressed modifier keys (Alt, Ctrl, Shift, Windows/Cmd).</para>
    /// </summary>
    EventModifiers modifiers { get; }

    /// <summary>
    ///   <para>Returns true if the Shift key is pressed.</para>
    /// </summary>
    bool shiftKey { get; }

    /// <summary>
    ///   <para>Returns true if the Ctrl key is pressed.</para>
    /// </summary>
    bool ctrlKey { get; }

    /// <summary>
    ///   <para>Returns true if the Windows/Cmd key is pressed.</para>
    /// </summary>
    bool commandKey { get; }

    /// <summary>
    ///   <para>Returns true if the Alt key is pressed.</para>
    /// </summary>
    bool altKey { get; }

    /// <summary>
    ///   <para>Returns true if the platform-specific action key is pressed. This key is Cmd on macOS, and Ctrl on all other platforms.</para>
    /// </summary>
    bool actionKey { get; }
  }
}
