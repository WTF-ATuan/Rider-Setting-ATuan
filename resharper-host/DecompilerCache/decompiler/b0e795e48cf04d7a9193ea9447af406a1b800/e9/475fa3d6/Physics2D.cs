// Decompiled with JetBrains decompiler
// Type: UnityEngine.Physics2D
// Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B0E795E4-8CF0-4D7A-9193-EA9447AF406A
// Assembly location: D:\unity\2020.3.14f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Global settings and helpers for 2D physics.</para>
  /// </summary>
  /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.html">External documentation for `Physics2D`</a></footer>
  [StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
  [NativeHeader("Physics2DScriptingClasses.h")]
  [NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
  [NativeHeader("Physics2DScriptingClasses.h")]
  public class Physics2D
  {
    /// <summary>
    ///   <para>Layer mask constant for the default layer that ignores raycasts.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IgnoreRaycastLayer.html">External documentation for `Physics2D.IgnoreRaycastLayer`</a></footer>
    public const int IgnoreRaycastLayer = 4;
    /// <summary>
    ///   <para>Layer mask constant that includes all layers participating in raycasts by default.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.DefaultRaycastLayers.html">External documentation for `Physics2D.DefaultRaycastLayers`</a></footer>
    public const int DefaultRaycastLayers = -5;
    /// <summary>
    ///   <para>Layer mask constant that includes all layers.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.AllLayers.html">External documentation for `Physics2D.AllLayers`</a></footer>
    public const int AllLayers = -1;
    private static List<Rigidbody2D> m_LastDisabledRigidbody2D = new List<Rigidbody2D>();

    /// <summary>
    ///   <para>The PhysicsScene2D automatically created when Unity starts.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-defaultPhysicsScene.html">External documentation for `Physics2D.defaultPhysicsScene`</a></footer>
    public static PhysicsScene2D defaultPhysicsScene => new PhysicsScene2D();

    /// <summary>
    ///   <para>The number of iterations of the physics solver when considering objects' velocities.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-velocityIterations.html">External documentation for `Physics2D.velocityIterations`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern int velocityIterations { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The number of iterations of the physics solver when considering objects' positions.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-positionIterations.html">External documentation for `Physics2D.positionIterations`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern int positionIterations { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Acceleration due to gravity.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-gravity.html">External documentation for `Physics2D.gravity`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static Vector2 gravity
    {
      get
      {
        Vector2 ret;
        Physics2D.get_gravity_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_gravity_Injected(ref value);
    }

    /// <summary>
    ///   <para>Do raycasts detect Colliders configured as triggers?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-queriesHitTriggers.html">External documentation for `Physics2D.queriesHitTriggers`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool queriesHitTriggers { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the raycasts or linecasts that start inside Colliders to detect or not detect those Colliders.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-queriesStartInColliders.html">External documentation for `Physics2D.queriesStartInColliders`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool queriesStartInColliders { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Use this to control whether or not the appropriate OnCollisionExit2D or OnTriggerExit2D callbacks should be called when a Collider2D is disabled.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-callbacksOnDisable.html">External documentation for `Physics2D.callbacksOnDisable`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool callbacksOnDisable { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Determines whether the garbage collector should reuse only a single instance of a Collision2D type for all collision callbacks.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-reuseCollisionCallbacks.html">External documentation for `Physics2D.reuseCollisionCallbacks`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool reuseCollisionCallbacks { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set whether to automatically sync changes to the Transform component with the physics engine.
    ///           </para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-autoSyncTransforms.html">External documentation for `Physics2D.autoSyncTransforms`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool autoSyncTransforms { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Controls when Unity executes the 2D physics simulation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-simulationMode.html">External documentation for `Physics2D.simulationMode`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern SimulationMode2D simulationMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>A set of options that control how physics operates when using the job system to multithread the physics simulation.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-jobOptions.html">External documentation for `Physics2D.jobOptions`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static PhysicsJobOptions2D jobOptions
    {
      get
      {
        PhysicsJobOptions2D ret;
        Physics2D.get_jobOptions_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_jobOptions_Injected(ref value);
    }

    /// <summary>
    ///   <para>Any collisions with a relative linear velocity below this threshold will be treated as inelastic.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-velocityThreshold.html">External documentation for `Physics2D.velocityThreshold`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float velocityThreshold { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum linear position correction used when solving constraints.  This helps to prevent overshoot.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-maxLinearCorrection.html">External documentation for `Physics2D.maxLinearCorrection`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float maxLinearCorrection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum angular position correction used when solving constraints.  This helps to prevent overshoot.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-maxAngularCorrection.html">External documentation for `Physics2D.maxAngularCorrection`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float maxAngularCorrection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum linear speed of a rigid-body per physics update.  Increasing this can cause numerical problems.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-maxTranslationSpeed.html">External documentation for `Physics2D.maxTranslationSpeed`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float maxTranslationSpeed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The maximum angular speed of a rigid-body per physics update.  Increasing this can cause numerical problems.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-maxRotationSpeed.html">External documentation for `Physics2D.maxRotationSpeed`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float maxRotationSpeed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default contact offset of the newly created Colliders.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-defaultContactOffset.html">External documentation for `Physics2D.defaultContactOffset`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float defaultContactOffset { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The scale factor that controls how fast overlaps are resolved.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-baumgarteScale.html">External documentation for `Physics2D.baumgarteScale`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float baumgarteScale { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The scale factor that controls how fast TOI overlaps are resolved.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-baumgarteTOIScale.html">External documentation for `Physics2D.baumgarteTOIScale`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float baumgarteTOIScale { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The time in seconds that a rigid-body must be still before it will go to sleep.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-timeToSleep.html">External documentation for `Physics2D.timeToSleep`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float timeToSleep { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>A rigid-body cannot sleep if its linear velocity is above this tolerance.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-linearSleepTolerance.html">External documentation for `Physics2D.linearSleepTolerance`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float linearSleepTolerance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>A Rigidbody cannot sleep if its angular velocity is above this tolerance threshold.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-angularSleepTolerance.html">External documentation for `Physics2D.angularSleepTolerance`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float angularSleepTolerance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Enable to always show the Collider Gizmos even when they are not selected.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-alwaysShowColliders.html">External documentation for `Physics2D.alwaysShowColliders`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool alwaysShowColliders { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Should the Collider Gizmos show the sleep-state for each Collider?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-showColliderSleep.html">External documentation for `Physics2D.showColliderSleep`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool showColliderSleep { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Should the Collider Gizmos show current contacts for each Collider?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-showColliderContacts.html">External documentation for `Physics2D.showColliderContacts`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool showColliderContacts { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Should the Collider Gizmos show the AABBs for each Collider?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-showColliderAABB.html">External documentation for `Physics2D.showColliderAABB`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern bool showColliderAABB { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The scale of the contact arrow used by the Collider Gizmos.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-contactArrowScale.html">External documentation for `Physics2D.contactArrowScale`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static extern float contactArrowScale { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The color used by the Gizmos to show all awake Colliders (Collider is awake when the body is awake).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-colliderAwakeColor.html">External documentation for `Physics2D.colliderAwakeColor`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static Color colliderAwakeColor
    {
      get
      {
        Color ret;
        Physics2D.get_colliderAwakeColor_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_colliderAwakeColor_Injected(ref value);
    }

    /// <summary>
    ///   <para>The color used by the Gizmos to show all asleep Colliders (Collider is asleep when the body is asleep).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-colliderAsleepColor.html">External documentation for `Physics2D.colliderAsleepColor`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static Color colliderAsleepColor
    {
      get
      {
        Color ret;
        Physics2D.get_colliderAsleepColor_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_colliderAsleepColor_Injected(ref value);
    }

    /// <summary>
    ///   <para>The color used by the Gizmos to show all Collider contacts.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-colliderContactColor.html">External documentation for `Physics2D.colliderContactColor`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static Color colliderContactColor
    {
      get
      {
        Color ret;
        Physics2D.get_colliderContactColor_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_colliderContactColor_Injected(ref value);
    }

    /// <summary>
    ///   <para>Set the color used by the Gizmos to show all Collider axis-aligned bounding boxes (AABBs).</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-colliderAABBColor.html">External documentation for `Physics2D.colliderAABBColor`</a></footer>
    [StaticAccessor("GetPhysics2DSettings()")]
    public static Color colliderAABBColor
    {
      get
      {
        Color ret;
        Physics2D.get_colliderAABBColor_Injected(out ret);
        return ret;
      }
      set => Physics2D.set_colliderAABBColor_Injected(ref value);
    }

    /// <summary>
    ///   <para>Simulate physics in the Scene.</para>
    /// </summary>
    /// <param name="step">The time to advance physics by.</param>
    /// <returns>
    ///   <para>Whether the simulation was run or not.  Running the simulation during physics callbacks will always fail.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Simulate.html">External documentation for `Physics2D.Simulate`</a></footer>
    public static bool Simulate(float step) => Physics2D.Simulate_Internal(Physics2D.defaultPhysicsScene, step);

    [NativeMethod("Simulate_Binding")]
    internal static bool Simulate_Internal(PhysicsScene2D physicsScene, float step) => Physics2D.Simulate_Internal_Injected(ref physicsScene, step);

    /// <summary>
    ///   <para>Synchronizes.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.SyncTransforms.html">External documentation for `Physics2D.SyncTransforms`</a></footer>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void SyncTransforms();

    [ExcludeFromDocs]
    public static void IgnoreCollision([Writable] Collider2D collider1, [Writable] Collider2D collider2) => Physics2D.IgnoreCollision(collider1, collider2, true);

    /// <summary>
    ///   <para>Makes the collision detection system ignore all collisionstriggers between collider1 and collider2/.</para>
    /// </summary>
    /// <param name="collider1">The first Collider to compare to collider2.</param>
    /// <param name="collider2">The second Collider to compare to collider1.</param>
    /// <param name="ignore">Whether collisionstriggers between collider1 and collider2/ should be ignored or not.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IgnoreCollision.html">External documentation for `Physics2D.IgnoreCollision`</a></footer>
    [StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("IgnoreCollision_Binding")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void IgnoreCollision(
      [NotNull("ArgumentNullException"), Writable] Collider2D collider1,
      [Writable, NotNull("ArgumentNullException")] Collider2D collider2,
      [DefaultValue("true")] bool ignore);

    /// <summary>
    ///   <para>Checks whether the collision detection system will ignore all collisionstriggers between collider1 and collider2/ or not.</para>
    /// </summary>
    /// <param name="collider1">The first Collider to compare to collider2.</param>
    /// <param name="collider2">The second Collider to compare to collider1.</param>
    /// <returns>
    ///   <para>Whether the collision detection system will ignore all collisionstriggers between collider1 and collider2/ or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetIgnoreCollision.html">External documentation for `Physics2D.GetIgnoreCollision`</a></footer>
    [NativeMethod("GetIgnoreCollision_Binding")]
    [StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool GetIgnoreCollision([NotNull("ArgumentNullException"), Writable] Collider2D collider1, [Writable, NotNull("ArgumentNullException")] Collider2D collider2);

    [ExcludeFromDocs]
    public static void IgnoreLayerCollision(int layer1, int layer2) => Physics2D.IgnoreLayerCollision(layer1, layer2, true);

    /// <summary>
    ///   <para>Choose whether to detect or ignore collisions between a specified pair of layers.</para>
    /// </summary>
    /// <param name="layer1">ID of the first layer.</param>
    /// <param name="layer2">ID of the second layer.</param>
    /// <param name="ignore">Should collisions between these layers be ignored?</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IgnoreLayerCollision.html">External documentation for `Physics2D.IgnoreLayerCollision`</a></footer>
    public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
    {
      if (layer1 < 0 || layer1 > 31)
        throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
      if (layer2 < 0 || layer2 > 31)
        throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
      Physics2D.IgnoreLayerCollision_Internal(layer1, layer2, ignore);
    }

    [StaticAccessor("GetPhysics2DSettings()")]
    [NativeMethod("IgnoreLayerCollision")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore);

    /// <summary>
    ///   <para>Checks whether collisions between the specified layers be ignored or not.</para>
    /// </summary>
    /// <param name="layer1">ID of first layer.</param>
    /// <param name="layer2">ID of second layer.</param>
    /// <returns>
    ///   <para>Whether collisions between the specified layers be ignored or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetIgnoreLayerCollision.html">External documentation for `Physics2D.GetIgnoreLayerCollision`</a></footer>
    public static bool GetIgnoreLayerCollision(int layer1, int layer2)
    {
      if (layer1 < 0 || layer1 > 31)
        throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
      return layer2 >= 0 && layer2 <= 31 ? Physics2D.GetIgnoreLayerCollision_Internal(layer1, layer2) : throw new ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
    }

    [StaticAccessor("GetPhysics2DSettings()")]
    [NativeMethod("GetIgnoreLayerCollision")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool GetIgnoreLayerCollision_Internal(int layer1, int layer2);

    /// <summary>
    ///   <para>Set the collision layer mask that indicates which layer(s) the specified layer can collide with.</para>
    /// </summary>
    /// <param name="layer">The layer to set the collision layer mask for.</param>
    /// <param name="layerMask">A mask where each bit indicates a layer and whether it can collide with layer or not.</param>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.SetLayerCollisionMask.html">External documentation for `Physics2D.SetLayerCollisionMask`</a></footer>
    public static void SetLayerCollisionMask(int layer, int layerMask)
    {
      if (layer < 0 || layer > 31)
        throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
      Physics2D.SetLayerCollisionMask_Internal(layer, layerMask);
    }

    [StaticAccessor("GetPhysics2DSettings()")]
    [NativeMethod("SetLayerCollisionMask")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetLayerCollisionMask_Internal(int layer, int layerMask);

    /// <summary>
    ///   <para>Get the collision layer mask that indicates which layer(s) the specified layer can collide with.</para>
    /// </summary>
    /// <param name="layer">The layer to retrieve the collision layer mask for.</param>
    /// <returns>
    ///   <para>A mask where each bit indicates a layer and whether it can collide with layer or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetLayerCollisionMask.html">External documentation for `Physics2D.GetLayerCollisionMask`</a></footer>
    public static int GetLayerCollisionMask(int layer) => layer >= 0 && layer <= 31 ? Physics2D.GetLayerCollisionMask_Internal(layer) : throw new ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");

    [StaticAccessor("GetPhysics2DSettings()")]
    [NativeMethod("GetLayerCollisionMask")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetLayerCollisionMask_Internal(int layer);

    /// <summary>
    ///   <para>Checks whether the passed Colliders are in contact or not.</para>
    /// </summary>
    /// <param name="collider1">The Collider to check if it is touching collider2.</param>
    /// <param name="collider2">The Collider to check if it is touching collider1.</param>
    /// <returns>
    ///   <para>Whether collider1 is touching collider2 or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IsTouching.html">External documentation for `Physics2D.IsTouching`</a></footer>
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsTouching([NotNull("ArgumentNullException"), Writable] Collider2D collider1, [Writable, NotNull("ArgumentNullException")] Collider2D collider2);

    /// <summary>
    ///   <para>Checks whether the passed Colliders are in contact or not.</para>
    /// </summary>
    /// <param name="collider1">The Collider to check if it is touching collider2.</param>
    /// <param name="collider2">The Collider to check if it is touching collider1.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <returns>
    ///   <para>Whether collider1 is touching collider2 or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IsTouching.html">External documentation for `Physics2D.IsTouching`</a></footer>
    public static bool IsTouching(
      [Writable] Collider2D collider1,
      [Writable] Collider2D collider2,
      ContactFilter2D contactFilter)
    {
      return Physics2D.IsTouching_TwoCollidersWithFilter(collider1, collider2, contactFilter);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("IsTouching")]
    private static bool IsTouching_TwoCollidersWithFilter(
      [NotNull("ArgumentNullException"), Writable] Collider2D collider1,
      [NotNull("ArgumentNullException"), Writable] Collider2D collider2,
      ContactFilter2D contactFilter)
    {
      return Physics2D.IsTouching_TwoCollidersWithFilter_Injected(collider1, collider2, ref contactFilter);
    }

    /// <summary>
    ///   <para>Checks whether the passed Colliders are in contact or not.</para>
    /// </summary>
    /// <param name="Collider">The Collider to check if it is touching any other Collider filtered by the contactFilter.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>Whether the Collider is touching any other Collider filtered by the contactFilter or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IsTouching.html">External documentation for `Physics2D.IsTouching`</a></footer>
    public static bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter) => Physics2D.IsTouching_SingleColliderWithFilter(collider, contactFilter);

    [NativeMethod("IsTouching")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static bool IsTouching_SingleColliderWithFilter(
      [NotNull("ArgumentNullException"), Writable] Collider2D collider,
      ContactFilter2D contactFilter)
    {
      return Physics2D.IsTouching_SingleColliderWithFilter_Injected(collider, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static bool IsTouchingLayers([Writable] Collider2D collider) => Physics2D.IsTouchingLayers(collider, -1);

    /// <summary>
    ///   <para>Checks whether the Collider is touching any Colliders on the specified layerMask or not.</para>
    /// </summary>
    /// <param name="Collider">The Collider to check if it is touching Colliders on the layerMask.</param>
    /// <param name="layerMask">Any Colliders on any of these layers count as touching.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>Whether the Collider is touching any Colliders on the specified layerMask or not.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.IsTouchingLayers.html">External documentation for `Physics2D.IsTouchingLayers`</a></footer>
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool IsTouchingLayers([NotNull("ArgumentNullException"), Writable] Collider2D collider, [DefaultValue("Physics2D.AllLayers")] int layerMask);

    /// <summary>
    ///   <para>Calculates the minimum distance between two Colliders.</para>
    /// </summary>
    /// <param name="colliderA">A Collider used to calculate the minimum distance against colliderB.</param>
    /// <param name="colliderB">A Collider used to calculate the minimum distance against colliderA.</param>
    /// <returns>
    ///   <para>The minimum distance between colliderA and colliderB.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Distance.html">External documentation for `Physics2D.Distance`</a></footer>
    public static ColliderDistance2D Distance(
      [Writable] Collider2D colliderA,
      [Writable] Collider2D colliderB)
    {
      if ((Object) colliderA == (Object) null)
        throw new ArgumentNullException("ColliderA cannot be NULL.");
      if ((Object) colliderB == (Object) null)
        throw new ArgumentNullException("ColliderB cannot be NULL.");
      return !((Object) colliderA == (Object) colliderB) ? Physics2D.Distance_Internal(colliderA, colliderB) : throw new ArgumentException("Cannot calculate the distance between the same collider.");
    }

    [NativeMethod("Distance")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static ColliderDistance2D Distance_Internal(
      [Writable, NotNull("ArgumentNullException")] Collider2D colliderA,
      [Writable, NotNull("ArgumentNullException")] Collider2D colliderB)
    {
      ColliderDistance2D ret;
      Physics2D.Distance_Internal_Injected(colliderA, colliderB, out ret);
      return ret;
    }

    /// <summary>
    ///   <para>Returns a point on the perimeter of the Collider that is closest to the specified position.</para>
    /// </summary>
    /// <param name="position">The position from which to find the closest point on the specified Collider.</param>
    /// <param name="Collider">The Collider on which to find the closest specified position.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>A point on the perimeter of the Collider that is closest to the specified position.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.ClosestPoint.html">External documentation for `Physics2D.ClosestPoint`</a></footer>
    public static Vector2 ClosestPoint(Vector2 position, Collider2D collider) => !((Object) collider == (Object) null) ? Physics2D.ClosestPoint_Collider(position, collider) : throw new ArgumentNullException("Collider cannot be NULL.");

    /// <summary>
    ///   <para>Returns a point on the perimeter of all enabled Colliders attached to the rigidbody that is closest to the specified position.</para>
    /// </summary>
    /// <param name="position">The position from which to find the closest point on the specified rigidbody.</param>
    /// <param name="rigidbody">The Rigidbody on which to find the closest specified position.</param>
    /// <returns>
    ///   <para>A point on the perimeter of a Collider attached to the rigidbody that is closest to the specified position.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.ClosestPoint.html">External documentation for `Physics2D.ClosestPoint`</a></footer>
    public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody) => !((Object) rigidbody == (Object) null) ? Physics2D.ClosestPoint_Rigidbody(position, rigidbody) : throw new ArgumentNullException("Rigidbody cannot be NULL.");

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("ClosestPoint")]
    private static Vector2 ClosestPoint_Collider(Vector2 position, [NotNull("ArgumentNullException")] Collider2D collider)
    {
      Vector2 ret;
      Physics2D.ClosestPoint_Collider_Injected(ref position, collider, out ret);
      return ret;
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("ClosestPoint")]
    private static Vector2 ClosestPoint_Rigidbody(Vector2 position, [NotNull("ArgumentNullException")] Rigidbody2D rigidbody)
    {
      Vector2 ret;
      Physics2D.ClosestPoint_Rigidbody_Injected(ref position, rigidbody, out ret);
      return ret;
    }

    [ExcludeFromDocs]
    public static RaycastHit2D Linecast(Vector2 start, Vector2 end) => Physics2D.defaultPhysicsScene.Linecast(start, end);

    [ExcludeFromDocs]
    public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D Linecast(
      Vector2 start,
      Vector2 end,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a line segment against Colliders in the Scene.</para>
    /// </summary>
    /// <param name="start">The start point of the line in world space.</param>
    /// <param name="end">The end point of the line in world space.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Linecast.html">External documentation for `Physics2D.Linecast`</a></footer>
    public static RaycastHit2D Linecast(
      Vector2 start,
      Vector2 end,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a line segment against Colliders in the Scene with results filtered by ContactFilter2D.</para>
    /// </summary>
    /// <param name="start">The start point of the line in world space.</param>
    /// <param name="end">The end point of the line in world space.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Linecast.html">External documentation for `Physics2D.Linecast`</a></footer>
    public static int Linecast(
      Vector2 start,
      Vector2 end,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
    }

    public static int Linecast(
      Vector2 start,
      Vector2 end,
      ContactFilter2D contactFilter,
      List<RaycastHit2D> results)
    {
      return Physics2D.defaultPhysicsScene.Linecast(start, end, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] LinecastAll(
      Vector2 start,
      Vector2 end,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a line against Colliders in the Scene.</para>
    /// </summary>
    /// <param name="start">The start point of the line in world space.</param>
    /// <param name="end">The end point of the line in world space.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.LinecastAll.html">External documentation for `Physics2D.LinecastAll`</a></footer>
    public static RaycastHit2D[] LinecastAll(
      Vector2 start,
      Vector2 end,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.LinecastAll_Internal(Physics2D.defaultPhysicsScene, start, end, legacyFilter);
    }

    [NativeMethod("LinecastAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static RaycastHit2D[] LinecastAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 start,
      Vector2 end,
      ContactFilter2D contactFilter)
    {
      return Physics2D.LinecastAll_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results) => Physics2D.defaultPhysicsScene.Linecast(start, end, results);

    [ExcludeFromDocs]
    public static int LinecastNonAlloc(
      Vector2 start,
      Vector2 end,
      RaycastHit2D[] results,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int LinecastNonAlloc(
      Vector2 start,
      Vector2 end,
      RaycastHit2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Casts a line against Colliders in the Scene. Note: This method will be deprecated in a future build and it is recommended to use Linecast instead.</para>
    /// </summary>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <param name="start">The start point of the line in world space.</param>
    /// <param name="end">The end point of the line in world space.</param>
    /// <param name="results">Returned array of objects that intersect the line.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.LinecastNonAlloc.html">External documentation for `Physics2D.LinecastNonAlloc`</a></footer>
    public static int LinecastNonAlloc(
      Vector2 start,
      Vector2 end,
      RaycastHit2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.Linecast(start, end, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) => Physics2D.defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity);

    [ExcludeFromDocs]
    public static RaycastHit2D Raycast(
      Vector2 origin,
      Vector2 direction,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance);
    }

    [ExcludeFromDocs]
    [RequiredByNativeCode]
    public static RaycastHit2D Raycast(
      Vector2 origin,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D Raycast(
      Vector2 origin,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a ray against Colliders in the Scene.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the ray originates.</param>
    /// <param name="direction">A vector representing the direction of the ray.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Raycast.html">External documentation for `Physics2D.Raycast`</a></footer>
    public static RaycastHit2D Raycast(
      Vector2 origin,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static int Raycast(
      Vector2 origin,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity, contactFilter, results);
    }

    /// <summary>
    ///   <para>Casts a ray against Colliders in the Scene.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the ray originates.</param>
    /// <param name="direction">A vector representing the direction of the ray.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.Raycast.html">External documentation for `Physics2D.Raycast`</a></footer>
    public static int Raycast(
      Vector2 origin,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance)
    {
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter, results);
    }

    public static int Raycast(
      Vector2 origin,
      Vector2 direction,
      ContactFilter2D contactFilter,
      List<RaycastHit2D> results,
      [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
    {
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results) => Physics2D.defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity, results);

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(
      Vector2 origin,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, results);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(
      Vector2 origin,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int RaycastNonAlloc(
      Vector2 origin,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Casts a ray into the Scene. Note: This method will be deprecated in a future build and it is recommended to use Raycast instead.</para>
    /// </summary>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <param name="origin">The point in 2D space where the ray originates.</param>
    /// <param name="direction">A vector representing the direction of the ray.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.RaycastNonAlloc.html">External documentation for `Physics2D.RaycastNonAlloc`</a></footer>
    public static int RaycastNonAlloc(
      Vector2 origin,
      Vector2 direction,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.Raycast(origin, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, float.PositiveInfinity, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] RaycastAll(
      Vector2 origin,
      Vector2 direction,
      float distance)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] RaycastAll(
      Vector2 origin,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] RaycastAll(
      Vector2 origin,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a ray against Colliders in the Scene, returning all Colliders that contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the ray originates.</param>
    /// <param name="direction">A vector representing the direction of the ray.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.RaycastAll.html">External documentation for `Physics2D.RaycastAll`</a></footer>
    public static RaycastHit2D[] RaycastAll(
      Vector2 origin,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.RaycastAll_Internal(Physics2D.defaultPhysicsScene, origin, direction, distance, legacyFilter);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("RaycastAll_Binding")]
    private static RaycastHit2D[] RaycastAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 origin,
      Vector2 direction,
      float distance,
      ContactFilter2D contactFilter)
    {
      return Physics2D.RaycastAll_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a circle against Colliders in the Scene, returning the first Collider to contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the circle originates.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="direction">A vector representing the direction of the circle.</param>
    /// <param name="distance">The maximum distance over which to cast the circle.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CircleCast.html">External documentation for `Physics2D.CircleCast`</a></footer>
    public static RaycastHit2D CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static int CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, contactFilter, results);
    }

    /// <summary>
    ///   <para>Casts a circle against Colliders in the Scene, returning all Colliders that contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the circle originates.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="direction">A vector representing the direction of the circle.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <param name="distance">The maximum distance over which to cast the circle.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CircleCast.html">External documentation for `Physics2D.CircleCast`</a></footer>
    public static int CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
    }

    public static int CircleCast(
      Vector2 origin,
      float radius,
      Vector2 direction,
      ContactFilter2D contactFilter,
      List<RaycastHit2D> results,
      [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CircleCastAll(
      Vector2 origin,
      float radius,
      Vector2 direction)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, float.PositiveInfinity, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CircleCastAll(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CircleCastAll(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CircleCastAll(
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a circle against Colliders in the Scene, returning all Colliders that contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the circle originates.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="direction">A vector representing the direction of the circle.</param>
    /// <param name="distance">The maximum distance over which to cast the circle.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CircleCastAll.html">External documentation for `Physics2D.CircleCastAll`</a></footer>
    public static RaycastHit2D[] CircleCastAll(
      Vector2 origin,
      float radius,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.CircleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, radius, direction, distance, legacyFilter);
    }

    [NativeMethod("CircleCastAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static RaycastHit2D[] CircleCastAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 origin,
      float radius,
      Vector2 direction,
      float distance,
      ContactFilter2D contactFilter)
    {
      return Physics2D.CircleCastAll_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int CircleCastNonAlloc(
      Vector2 origin,
      float radius,
      Vector2 direction,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, results);
    }

    [ExcludeFromDocs]
    public static int CircleCastNonAlloc(
      Vector2 origin,
      float radius,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, results);
    }

    [ExcludeFromDocs]
    public static int CircleCastNonAlloc(
      Vector2 origin,
      float radius,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int CircleCastNonAlloc(
      Vector2 origin,
      float radius,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Casts a circle into the Scene, returning Colliders that contact with it into the provided results array. Note: This method will be deprecated in a future build and it is recommended to use CircleCast instead.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the circle originates.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="direction">A vector representing the direction of the circle.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="distance">The maximum distance over which to cast the circle.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CircleCastNonAlloc.html">External documentation for `Physics2D.CircleCastNonAlloc`</a></footer>
    public static int CircleCastNonAlloc(
      Vector2 origin,
      float radius,
      Vector2 direction,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.CircleCast(origin, radius, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a box against Colliders in the Scene, returning the first Collider to contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the box originates.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box (in degrees).</param>
    /// <param name="direction">A vector representing the direction of the box.</param>
    /// <param name="distance">The maximum distance over which to cast the box.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.BoxCast.html">External documentation for `Physics2D.BoxCast`</a></footer>
    public static RaycastHit2D BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("Physics2D.AllLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static int BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, contactFilter, results);
    }

    /// <summary>
    ///   <para>Casts a box against the Colliders in the Scene and returns all Colliders that are in contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the box originates.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box (in degrees).</param>
    /// <param name="direction">A vector representing the direction of the box.</param>
    /// <param name="distance">The maximum distance over which to cast the box.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.BoxCast.html">External documentation for `Physics2D.BoxCast`</a></footer>
    public static int BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
    }

    public static int BoxCast(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      List<RaycastHit2D> results,
      [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] BoxCastAll(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, float.PositiveInfinity, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] BoxCastAll(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] BoxCastAll(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] BoxCastAll(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a box against Colliders in the Scene, returning all Colliders that contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the box originates.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box (in degrees).</param>
    /// <param name="direction">A vector representing the direction of the box.</param>
    /// <param name="distance">The maximum distance over which to cast the box.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.BoxCastAll.html">External documentation for `Physics2D.BoxCastAll`</a></footer>
    public static RaycastHit2D[] BoxCastAll(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.BoxCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, angle, direction, distance, legacyFilter);
    }

    [NativeMethod("BoxCastAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static RaycastHit2D[] BoxCastAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      float distance,
      ContactFilter2D contactFilter)
    {
      return Physics2D.BoxCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, results);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, results);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int BoxCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Casts a box into the Scene, returning Colliders that contact with it into the provided results array. Note: This method will be deprecated in a future build and it is recommended to use BoxCast instead.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the box originates.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box (in degrees).</param>
    /// <param name="direction">A vector representing the direction of the box.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="distance">The maximum distance over which to cast the box.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.BoxCastNonAlloc.html">External documentation for `Physics2D.BoxCastNonAlloc`</a></footer>
    public static int BoxCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a capsule against Colliders in the Scene, returning the first Collider to contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the capsule originates.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="capsuleDirection">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule (in degrees).</param>
    /// <param name="direction">Vector representing the direction to cast the capsule.</param>
    /// <param name="distance">The maximum distance over which to cast the capsule.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CapsuleCast.html">External documentation for `Physics2D.CapsuleCast`</a></footer>
    public static RaycastHit2D CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static int CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter, results);
    }

    /// <summary>
    ///   <para>Casts a capsule against the Colliders in the Scene and returns all Colliders that are in contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the capsule originates.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="capsuleDirection">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule (in degrees).</param>
    /// <param name="direction">Vector representing the direction to cast the capsule.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <param name="distance">The maximum distance over which to cast the capsule.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CapsuleCast.html">External documentation for `Physics2D.CapsuleCast`</a></footer>
    public static int CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
    }

    public static int CapsuleCast(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      ContactFilter2D contactFilter,
      List<RaycastHit2D> results,
      [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CapsuleCastAll(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CapsuleCastAll(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    [NativeMethod("CapsuleCastAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static RaycastHit2D[] CapsuleCastAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance,
      ContactFilter2D contactFilter)
    {
      return Physics2D.CapsuleCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CapsuleCastAll(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] CapsuleCastAll(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    /// <summary>
    ///   <para>Casts a capsule against Colliders in the Scene, returning all Colliders that contact with it.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the capsule originates.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="capsuleDirection">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule (in degrees).</param>
    /// <param name="direction">Vector representing the direction to cast the capsule.</param>
    /// <param name="distance">The maximum distance over which to cast the capsule.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CapsuleCastAll.html">External documentation for `Physics2D.CapsuleCastAll`</a></footer>
    public static RaycastHit2D[] CapsuleCastAll(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.CapsuleCastAll_Internal(Physics2D.defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, legacyFilter);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, results);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance)
    {
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, results);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int CapsuleCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      float distance,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Casts a capsule into the Scene, returning Colliders that contact with it into the provided results array. Note: This method will be deprecated in a future build and it is recommended to use CapsuleCast instead.</para>
    /// </summary>
    /// <param name="origin">The point in 2D space where the capsule originates.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="capsuleDirection">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule (in degrees).</param>
    /// <param name="direction">Vector representing the direction to cast the capsule.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="distance">The maximum distance over which to cast the capsule.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.CapsuleCastNonAlloc.html">External documentation for `Physics2D.CapsuleCastNonAlloc`</a></footer>
    public static int CapsuleCastNonAlloc(
      Vector2 origin,
      Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      Vector2 direction,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D GetRayIntersection(Ray ray) => Physics2D.defaultPhysicsScene.GetRayIntersection(ray, float.PositiveInfinity);

    [ExcludeFromDocs]
    public static RaycastHit2D GetRayIntersection(Ray ray, float distance) => Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance);

    /// <summary>
    ///   <para>Cast a 3D ray against the Colliders in the Scene returning the first Collider along the ray.</para>
    /// </summary>
    /// <param name="ray">The 3D ray defining origin and direction to test.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetRayIntersection.html">External documentation for `Physics2D.GetRayIntersection`</a></footer>
    public static RaycastHit2D GetRayIntersection(
      Ray ray,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask)
    {
      return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, layerMask);
    }

    [ExcludeFromDocs]
    public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) => Physics2D.GetRayIntersectionAll_Internal(Physics2D.defaultPhysicsScene, ray.origin, ray.direction, float.PositiveInfinity, -5);

    [ExcludeFromDocs]
    public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) => Physics2D.GetRayIntersectionAll_Internal(Physics2D.defaultPhysicsScene, ray.origin, ray.direction, distance, -5);

    /// <summary>
    ///   <para>Cast a 3D ray against the Colliders in the Scene returning all the Colliders along the ray.</para>
    /// </summary>
    /// <param name="ray">The 3D ray defining origin and direction to test.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetRayIntersectionAll.html">External documentation for `Physics2D.GetRayIntersectionAll`</a></footer>
    [RequiredByNativeCode]
    public static RaycastHit2D[] GetRayIntersectionAll(
      Ray ray,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask)
    {
      return Physics2D.GetRayIntersectionAll_Internal(Physics2D.defaultPhysicsScene, ray.origin, ray.direction, distance, layerMask);
    }

    [NativeMethod("GetRayIntersectionAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static RaycastHit2D[] GetRayIntersectionAll_Internal(
      PhysicsScene2D physicsScene,
      Vector3 origin,
      Vector3 direction,
      float distance,
      int layerMask)
    {
      return Physics2D.GetRayIntersectionAll_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, layerMask);
    }

    [ExcludeFromDocs]
    public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) => Physics2D.defaultPhysicsScene.GetRayIntersection(ray, float.PositiveInfinity, results);

    [ExcludeFromDocs]
    public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) => Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, results);

    /// <summary>
    ///   <para>Cast a 3D ray against the Colliders in the Scene returning the Colliders along the ray. Note: This method will be deprecated in a future build and it is recommended to use GetRayIntersection instead.</para>
    /// </summary>
    /// <param name="ray">The 3D ray defining origin and direction to test.</param>
    /// <param name="distance">The maximum distance over which to cast the ray.</param>
    /// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
    /// <param name="results">Array to receive results.</param>
    /// <returns>
    ///   <para>The number of results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetRayIntersectionNonAlloc.html">External documentation for `Physics2D.GetRayIntersectionNonAlloc`</a></footer>
    [RequiredByNativeCode]
    public static int GetRayIntersectionNonAlloc(
      Ray ray,
      RaycastHit2D[] results,
      [DefaultValue("Mathf.Infinity")] float distance,
      [DefaultValue("DefaultRaycastLayers")] int layerMask)
    {
      return Physics2D.defaultPhysicsScene.GetRayIntersection(ray, distance, results, layerMask);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapPoint(Vector2 point) => Physics2D.defaultPhysicsScene.OverlapPoint(point);

    [ExcludeFromDocs]
    public static Collider2D OverlapPoint(Vector2 point, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider overlaps a point in space.</para>
    /// </summary>
    /// <param name="point">A point in world space.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The Collider overlapping the point.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapPoint.html">External documentation for `Physics2D.OverlapPoint`</a></footer>
    public static Collider2D OverlapPoint(
      Vector2 point,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider overlaps a point in world space.</para>
    /// </summary>
    /// <param name="point">A point in world space.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapPoint.html">External documentation for `Physics2D.OverlapPoint`</a></footer>
    public static int OverlapPoint(
      Vector2 point,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
    }

    public static int OverlapPoint(
      Vector2 point,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapPointAll(Vector2 point)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapPointAll(
      Vector2 point,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, legacyFilter);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that overlap a point in space.</para>
    /// </summary>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <param name="point">A point in space.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapPointAll.html">External documentation for `Physics2D.OverlapPointAll`</a></footer>
    public static Collider2D[] OverlapPointAll(
      Vector2 point,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.OverlapPointAll_Internal(Physics2D.defaultPhysicsScene, point, legacyFilter);
    }

    [NativeMethod("OverlapPointAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static Collider2D[] OverlapPointAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 point,
      ContactFilter2D contactFilter)
    {
      return Physics2D.OverlapPointAll_Internal_Injected(ref physicsScene, ref point, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results) => Physics2D.defaultPhysicsScene.OverlapPoint(point, results);

    [ExcludeFromDocs]
    public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int OverlapPointNonAlloc(
      Vector2 point,
      Collider2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that overlap a point in space. Note: This method will be deprecated in a future build and it is recommended to use OverlapPoint instead.</para>
    /// </summary>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <param name="point">A point in space.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapPointNonAlloc.html">External documentation for `Physics2D.OverlapPointNonAlloc`</a></footer>
    public static int OverlapPointNonAlloc(
      Vector2 point,
      Collider2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapPoint(point, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapCircle(Vector2 point, float radius) => Physics2D.defaultPhysicsScene.OverlapCircle(point, radius);

    [ExcludeFromDocs]
    public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapCircle(
      Vector2 point,
      float radius,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a circular area.</para>
    /// </summary>
    /// <param name="point">Centre of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The Collider overlapping the circle.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCircle.html">External documentation for `Physics2D.OverlapCircle`</a></footer>
    public static Collider2D OverlapCircle(
      Vector2 point,
      float radius,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider is within a circular area.</para>
    /// </summary>
    /// <param name="point">Centre of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCircle.html">External documentation for `Physics2D.OverlapCircle`</a></footer>
    public static int OverlapCircle(
      Vector2 point,
      float radius,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
    }

    public static int OverlapCircle(
      Vector2 point,
      float radius,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCircleAll(Vector2 point, float radius)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCircleAll(
      Vector2 point,
      float radius,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCircleAll(
      Vector2 point,
      float radius,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, legacyFilter);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a circular area.</para>
    /// </summary>
    /// <param name="point">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="layerMask">Filter to check objects only on specified layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCircleAll.html">External documentation for `Physics2D.OverlapCircleAll`</a></footer>
    public static Collider2D[] OverlapCircleAll(
      Vector2 point,
      float radius,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.OverlapCircleAll_Internal(Physics2D.defaultPhysicsScene, point, radius, legacyFilter);
    }

    [NativeMethod("OverlapCircleAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static Collider2D[] OverlapCircleAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 point,
      float radius,
      ContactFilter2D contactFilter)
    {
      return Physics2D.OverlapCircleAll_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results) => Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, results);

    [ExcludeFromDocs]
    public static int OverlapCircleNonAlloc(
      Vector2 point,
      float radius,
      Collider2D[] results,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int OverlapCircleNonAlloc(
      Vector2 point,
      float radius,
      Collider2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a circular area. Note: This method will be deprecated in a future build and it is recommended to use OverlapCircle instead.</para>
    /// </summary>
    /// <param name="point">The center of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCircleNonAlloc.html">External documentation for `Physics2D.OverlapCircleNonAlloc`</a></footer>
    public static int OverlapCircleNonAlloc(
      Vector2 point,
      float radius,
      Collider2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapCircle(point, radius, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle) => Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle);

    [ExcludeFromDocs]
    public static Collider2D OverlapBox(
      Vector2 point,
      Vector2 size,
      float angle,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapBox(
      Vector2 point,
      Vector2 size,
      float angle,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a box area.</para>
    /// </summary>
    /// <param name="point">The center of the box.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The Collider overlapping the box.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapBox.html">External documentation for `Physics2D.OverlapBox`</a></footer>
    public static Collider2D OverlapBox(
      Vector2 point,
      Vector2 size,
      float angle,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a box area.</para>
    /// </summary>
    /// <param name="point">The center of the box.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapBox.html">External documentation for `Physics2D.OverlapBox`</a></footer>
    public static int OverlapBox(
      Vector2 point,
      Vector2 size,
      float angle,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
    }

    public static int OverlapBox(
      Vector2 point,
      Vector2 size,
      float angle,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapBoxAll(
      Vector2 point,
      Vector2 size,
      float angle,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapBoxAll(
      Vector2 point,
      Vector2 size,
      float angle,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a box area.</para>
    /// </summary>
    /// <param name="point">The center of the box.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapBoxAll.html">External documentation for `Physics2D.OverlapBoxAll`</a></footer>
    public static Collider2D[] OverlapBoxAll(
      Vector2 point,
      Vector2 size,
      float angle,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.OverlapBoxAll_Internal(Physics2D.defaultPhysicsScene, point, size, angle, legacyFilter);
    }

    [NativeMethod("OverlapBoxAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static Collider2D[] OverlapBoxAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 point,
      Vector2 size,
      float angle,
      ContactFilter2D contactFilter)
    {
      return Physics2D.OverlapBoxAll_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(
      Vector2 point,
      Vector2 size,
      float angle,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, results);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(
      Vector2 point,
      Vector2 size,
      float angle,
      Collider2D[] results,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int OverlapBoxNonAlloc(
      Vector2 point,
      Vector2 size,
      float angle,
      Collider2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a box area. Note: This method will be deprecated in a future build and it is recommended to use OverlapBox instead.</para>
    /// </summary>
    /// <param name="point">The center of the box.</param>
    /// <param name="size">The size of the box.</param>
    /// <param name="angle">The angle of the box.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapBoxNonAlloc.html">External documentation for `Physics2D.OverlapBoxNonAlloc`</a></footer>
    public static int OverlapBoxNonAlloc(
      Vector2 point,
      Vector2 size,
      float angle,
      Collider2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapBox(point, size, angle, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB) => Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB);

    [ExcludeFromDocs]
    public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapArea(
      Vector2 pointA,
      Vector2 pointB,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a rectangular area.</para>
    /// </summary>
    /// <param name="pointA">One corner of the rectangle.</param>
    /// <param name="pointB">Diagonally opposite the point A corner of the rectangle.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The Collider overlapping the area.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapArea.html">External documentation for `Physics2D.OverlapArea`</a></footer>
    public static Collider2D OverlapArea(
      Vector2 pointA,
      Vector2 pointB,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a rectangular area.</para>
    /// </summary>
    /// <param name="pointA">One corner of the rectangle.</param>
    /// <param name="pointB">Diagonally opposite the point A corner of the rectangle.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapArea.html">External documentation for `Physics2D.OverlapArea`</a></footer>
    public static int OverlapArea(
      Vector2 pointA,
      Vector2 pointB,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
    }

    public static int OverlapArea(
      Vector2 pointA,
      Vector2 pointB,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB) => Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, -5, float.NegativeInfinity, float.PositiveInfinity);

    [ExcludeFromDocs]
    public static Collider2D[] OverlapAreaAll(
      Vector2 pointA,
      Vector2 pointB,
      int layerMask)
    {
      return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, float.NegativeInfinity, float.PositiveInfinity);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapAreaAll(
      Vector2 pointA,
      Vector2 pointB,
      int layerMask,
      float minDepth)
    {
      return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, float.PositiveInfinity);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a rectangular area.</para>
    /// </summary>
    /// <param name="pointA">One corner of the rectangle.</param>
    /// <param name="pointB">Diagonally opposite the point A corner of the rectangle.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapAreaAll.html">External documentation for `Physics2D.OverlapAreaAll`</a></footer>
    public static Collider2D[] OverlapAreaAll(
      Vector2 pointA,
      Vector2 pointB,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      return Physics2D.OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, maxDepth);
    }

    private static Collider2D[] OverlapAreaAllToBox_Internal(
      Vector2 pointA,
      Vector2 pointB,
      int layerMask,
      float minDepth,
      float maxDepth)
    {
      return Physics2D.OverlapBoxAll((pointA + pointB) * 0.5f, new Vector2(Mathf.Abs(pointA.x - pointB.x), Math.Abs(pointA.y - pointB.y)), 0.0f, layerMask, minDepth, maxDepth);
    }

    [ExcludeFromDocs]
    public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results) => Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, results);

    [ExcludeFromDocs]
    public static int OverlapAreaNonAlloc(
      Vector2 pointA,
      Vector2 pointB,
      Collider2D[] results,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int OverlapAreaNonAlloc(
      Vector2 pointA,
      Vector2 pointB,
      Collider2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a specified area. Note: This method will be deprecated in a future build and it is recommended to use OverlapArea instead.</para>
    /// </summary>
    /// <param name="pointA">One corner of the rectangle.</param>
    /// <param name="pointB">Diagonally opposite the point A corner of the rectangle.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="layerMask">Filter to check objects only on specified layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than or equal to this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than or equal to this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapAreaNonAlloc.html">External documentation for `Physics2D.OverlapAreaNonAlloc`</a></footer>
    public static int OverlapAreaNonAlloc(
      Vector2 pointA,
      Vector2 pointB,
      Collider2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapArea(pointA, pointB, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle)
    {
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a capsule area.</para>
    /// </summary>
    /// <param name="point">The center of the capsule.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="direction">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The Collider overlapping the capsule.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCapsule.html">External documentation for `Physics2D.OverlapCapsule`</a></footer>
    public static Collider2D OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Checks if a Collider falls within a capsule area.</para>
    /// </summary>
    /// <param name="point">The center of the capsule.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="direction">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCapsule.html">External documentation for `Physics2D.OverlapCapsule`</a></footer>
    public static int OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
    }

    public static int OverlapCapsule(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCapsuleAll(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCapsuleAll(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, legacyFilter);
    }

    [ExcludeFromDocs]
    public static Collider2D[] OverlapCapsuleAll(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, legacyFilter);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a capsule area.</para>
    /// </summary>
    /// <param name="point">The center of the capsule.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="direction">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>The cast results returned.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCapsuleAll.html">External documentation for `Physics2D.OverlapCapsuleAll`</a></footer>
    public static Collider2D[] OverlapCapsuleAll(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.OverlapCapsuleAll_Internal(Physics2D.defaultPhysicsScene, point, size, direction, angle, legacyFilter);
    }

    [NativeMethod("OverlapCapsuleAll_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static Collider2D[] OverlapCapsuleAll_Internal(
      PhysicsScene2D physicsScene,
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      ContactFilter2D contactFilter)
    {
      return Physics2D.OverlapCapsuleAll_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
    }

    [ExcludeFromDocs]
    public static int OverlapCapsuleNonAlloc(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      Collider2D[] results)
    {
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, results);
    }

    [ExcludeFromDocs]
    public static int OverlapCapsuleNonAlloc(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      Collider2D[] results,
      int layerMask)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter, results);
    }

    [ExcludeFromDocs]
    public static int OverlapCapsuleNonAlloc(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      Collider2D[] results,
      int layerMask,
      float minDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Get a list of all Colliders that fall within a capsule area. Note: This method will be deprecated in a future build and it is recommended to use OverlapCapsule instead.</para>
    /// </summary>
    /// <param name="point">The center of the capsule.</param>
    /// <param name="size">The size of the capsule.</param>
    /// <param name="direction">The direction of the capsule.</param>
    /// <param name="angle">The angle of the capsule.</param>
    /// <param name="results">Array to receive results.</param>
    /// <param name="layerMask">Filter to check objects only on specific layers.</param>
    /// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
    /// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCapsuleNonAlloc.html">External documentation for `Physics2D.OverlapCapsuleNonAlloc`</a></footer>
    public static int OverlapCapsuleNonAlloc(
      Vector2 point,
      Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      Collider2D[] results,
      [DefaultValue("DefaultRaycastLayers")] int layerMask,
      [DefaultValue("-Mathf.Infinity")] float minDepth,
      [DefaultValue("Mathf.Infinity")] float maxDepth)
    {
      ContactFilter2D legacyFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
      return Physics2D.defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, legacyFilter, results);
    }

    /// <summary>
    ///   <para>Gets a list of all Colliders that overlap the given Collider.</para>
    /// </summary>
    /// <param name="Collider">The Collider that defines the area used to query for other Collider overlaps.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth.  Note that normal angle is not used for overlap testing.</param>
    /// <param name="results">The array to receive results.  The size of the array determines the maximum number of results that can be returned.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>Returns the number of results placed in the results array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.OverlapCollider.html">External documentation for `Physics2D.OverlapCollider`</a></footer>
    public static int OverlapCollider(
      Collider2D collider,
      ContactFilter2D contactFilter,
      Collider2D[] results)
    {
      return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
    }

    public static int OverlapCollider(
      Collider2D collider,
      ContactFilter2D contactFilter,
      List<Collider2D> results)
    {
      return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
    }

    /// <summary>
    ///   <para>Retrieves all contact points in for contacts between with the collider1 and collider2, with the results filtered by the ContactFilter2D.</para>
    /// </summary>
    /// <param name="collider1">The Collider to check if it has contacts against collider2.</param>
    /// <param name="collider2">The Collider to check if it has contacts against collider1.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="contacts">An array of ContactPoint2D used to receive the results.</param>
    /// <returns>
    ///   <para>Returns the number of contacts placed in the contacts array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(
      Collider2D collider1,
      Collider2D collider2,
      ContactFilter2D contactFilter,
      ContactPoint2D[] contacts)
    {
      return Physics2D.GetColliderColliderContactsArray(collider1, collider2, contactFilter, contacts);
    }

    /// <summary>
    ///   <para>Retrieves all contact points in contact with the Collider.</para>
    /// </summary>
    /// <param name="Collider">The Collider to retrieve contacts for.</param>
    /// <param name="contacts">An array of ContactPoint2D used to receive the results.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>Returns the number of contacts placed in the contacts array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(Collider2D collider, ContactPoint2D[] contacts) => Physics2D.GetColliderContactsArray(collider, new ContactFilter2D().NoFilter(), contacts);

    /// <summary>
    ///   <para>Retrieves all contact points in contact with the Collider, with the results filtered by the ContactFilter2D.</para>
    /// </summary>
    /// <param name="Collider">The Collider to retrieve contacts for.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="contacts">An array of ContactPoint2D used to receive the results.</param>
    /// <param name="collider"></param>
    /// <returns>
    ///   <para>Returns the number of contacts placed in the contacts array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(
      Collider2D collider,
      ContactFilter2D contactFilter,
      ContactPoint2D[] contacts)
    {
      return Physics2D.GetColliderContactsArray(collider, contactFilter, contacts);
    }

    /// <summary>
    ///   <para>Retrieves all Colliders in contact with the Collider.</para>
    /// </summary>
    /// <param name="Collider">The Collider to retrieve contacts for.</param>
    /// <param name="Colliders">An array of Collider2D used to receive the results.</param>
    /// <param name="collider"></param>
    /// <param name="colliders"></param>
    /// <returns>
    ///   <para>Returns the number of Colliders placed in the Colliders array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(Collider2D collider, Collider2D[] colliders) => Physics2D.GetColliderContactsCollidersOnlyArray(collider, new ContactFilter2D().NoFilter(), colliders);

    /// <summary>
    ///   <para>Retrieves all Colliders in contact with the Collider, with the results filtered by the ContactFilter2D.</para>
    /// </summary>
    /// <param name="Collider">The Collider to retrieve contacts for.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="Colliders">An array of Collider2D used to receive the results.</param>
    /// <param name="collider"></param>
    /// <param name="colliders"></param>
    /// <returns>
    ///   <para>Returns the number of Colliders placed in the Colliders array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(
      Collider2D collider,
      ContactFilter2D contactFilter,
      Collider2D[] colliders)
    {
      return Physics2D.GetColliderContactsCollidersOnlyArray(collider, contactFilter, colliders);
    }

    /// <summary>
    ///   <para>Retrieves all contact points in contact with any of the Collider(s) attached to this rigidbody.</para>
    /// </summary>
    /// <param name="rigidbody">The rigidbody to retrieve contacts for.  All Colliders attached to this rigidbody will be checked.</param>
    /// <param name="contacts">An array of ContactPoint2D used to receive the results.</param>
    /// <returns>
    ///   <para>Returns the number of contacts placed in the contacts array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(Rigidbody2D rigidbody, ContactPoint2D[] contacts) => Physics2D.GetRigidbodyContactsArray(rigidbody, new ContactFilter2D().NoFilter(), contacts);

    /// <summary>
    ///   <para>Retrieves all contact points in contact with any of the Collider(s) attached to this rigidbody, with the results filtered by the ContactFilter2D.</para>
    /// </summary>
    /// <param name="rigidbody">The rigidbody to retrieve contacts for.  All Colliders attached to this rigidbody will be checked.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="contacts">An array of ContactPoint2D used to receive the results.</param>
    /// <returns>
    ///   <para>Returns the number of contacts placed in the contacts array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(
      Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      ContactPoint2D[] contacts)
    {
      return Physics2D.GetRigidbodyContactsArray(rigidbody, contactFilter, contacts);
    }

    /// <summary>
    ///   <para>Retrieves all Colliders in contact with any of the Collider(s) attached to this rigidbody.</para>
    /// </summary>
    /// <param name="rigidbody">The rigidbody to retrieve contacts for.  All Colliders attached to this rigidbody will be checked.</param>
    /// <param name="Colliders">An array of Collider2D used to receive the results.</param>
    /// <param name="colliders"></param>
    /// <returns>
    ///   <para>Returns the number of Colliders placed in the Colliders array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(Rigidbody2D rigidbody, Collider2D[] colliders) => Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, new ContactFilter2D().NoFilter(), colliders);

    /// <summary>
    ///   <para>Retrieves all Colliders in contact with any of the Collider(s) attached to this rigidbody, with the results filtered by the ContactFilter2D.</para>
    /// </summary>
    /// <param name="rigidbody">The rigidbody to retrieve contacts for.  All Colliders attached to this rigidbody will be checked.</param>
    /// <param name="contactFilter">The contact filter used to filter the results differently, such as by layer mask, Z depth, or normal angle.</param>
    /// <param name="Colliders">An array of Collider2D used to receive the results.</param>
    /// <param name="colliders"></param>
    /// <returns>
    ///   <para>Returns the number of Colliders placed in the Colliders array.</para>
    /// </returns>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D.GetContacts.html">External documentation for `Physics2D.GetContacts`</a></footer>
    public static int GetContacts(
      Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      Collider2D[] colliders)
    {
      return Physics2D.GetRigidbodyContactsCollidersOnlyArray(rigidbody, contactFilter, colliders);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetColliderContactsArray_Binding")]
    private static int GetColliderContactsArray(
      [NotNull("ArgumentNullException")] Collider2D collider,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] ContactPoint2D[] results)
    {
      return Physics2D.GetColliderContactsArray_Injected(collider, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetColliderColliderContactsArray_Binding")]
    private static int GetColliderColliderContactsArray(
      [NotNull("ArgumentNullException")] Collider2D collider1,
      [NotNull("ArgumentNullException")] Collider2D collider2,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] ContactPoint2D[] results)
    {
      return Physics2D.GetColliderColliderContactsArray_Injected(collider1, collider2, ref contactFilter, results);
    }

    [NativeMethod("GetRigidbodyContactsArray_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static int GetRigidbodyContactsArray(
      [NotNull("ArgumentNullException")] Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] ContactPoint2D[] results)
    {
      return Physics2D.GetRigidbodyContactsArray_Injected(rigidbody, ref contactFilter, results);
    }

    [NativeMethod("GetColliderContactsCollidersOnlyArray_Binding")]
    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    private static int GetColliderContactsCollidersOnlyArray(
      [NotNull("ArgumentNullException")] Collider2D collider,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] Collider2D[] results)
    {
      return Physics2D.GetColliderContactsCollidersOnlyArray_Injected(collider, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetRigidbodyContactsCollidersOnlyArray_Binding")]
    private static int GetRigidbodyContactsCollidersOnlyArray(
      [NotNull("ArgumentNullException")] Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] Collider2D[] results)
    {
      return Physics2D.GetRigidbodyContactsCollidersOnlyArray_Injected(rigidbody, ref contactFilter, results);
    }

    public static int GetContacts(
      Collider2D collider1,
      Collider2D collider2,
      ContactFilter2D contactFilter,
      List<ContactPoint2D> contacts)
    {
      return Physics2D.GetColliderColliderContactsList(collider1, collider2, contactFilter, contacts);
    }

    public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts) => Physics2D.GetColliderContactsList(collider, new ContactFilter2D().NoFilter(), contacts);

    public static int GetContacts(
      Collider2D collider,
      ContactFilter2D contactFilter,
      List<ContactPoint2D> contacts)
    {
      return Physics2D.GetColliderContactsList(collider, contactFilter, contacts);
    }

    public static int GetContacts(Collider2D collider, List<Collider2D> colliders) => Physics2D.GetColliderContactsCollidersOnlyList(collider, new ContactFilter2D().NoFilter(), colliders);

    public static int GetContacts(
      Collider2D collider,
      ContactFilter2D contactFilter,
      List<Collider2D> colliders)
    {
      return Physics2D.GetColliderContactsCollidersOnlyList(collider, contactFilter, colliders);
    }

    public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts) => Physics2D.GetRigidbodyContactsList(rigidbody, new ContactFilter2D().NoFilter(), contacts);

    public static int GetContacts(
      Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      List<ContactPoint2D> contacts)
    {
      return Physics2D.GetRigidbodyContactsList(rigidbody, contactFilter, contacts);
    }

    public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders) => Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, new ContactFilter2D().NoFilter(), colliders);

    public static int GetContacts(
      Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      List<Collider2D> colliders)
    {
      return Physics2D.GetRigidbodyContactsCollidersOnlyList(rigidbody, contactFilter, colliders);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetColliderContactsList_Binding")]
    private static int GetColliderContactsList(
      [NotNull("ArgumentNullException")] Collider2D collider,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] List<ContactPoint2D> results)
    {
      return Physics2D.GetColliderContactsList_Injected(collider, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetColliderColliderContactsList_Binding")]
    private static int GetColliderColliderContactsList(
      [NotNull("ArgumentNullException")] Collider2D collider1,
      [NotNull("ArgumentNullException")] Collider2D collider2,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] List<ContactPoint2D> results)
    {
      return Physics2D.GetColliderColliderContactsList_Injected(collider1, collider2, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetRigidbodyContactsList_Binding")]
    private static int GetRigidbodyContactsList(
      [NotNull("ArgumentNullException")] Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] List<ContactPoint2D> results)
    {
      return Physics2D.GetRigidbodyContactsList_Injected(rigidbody, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetColliderContactsCollidersOnlyList_Binding")]
    private static int GetColliderContactsCollidersOnlyList(
      [NotNull("ArgumentNullException")] Collider2D collider,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] List<Collider2D> results)
    {
      return Physics2D.GetColliderContactsCollidersOnlyList_Injected(collider, ref contactFilter, results);
    }

    [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
    [NativeMethod("GetRigidbodyContactsCollidersOnlyList_Binding")]
    private static int GetRigidbodyContactsCollidersOnlyList(
      [NotNull("ArgumentNullException")] Rigidbody2D rigidbody,
      ContactFilter2D contactFilter,
      [NotNull("ArgumentNullException")] List<Collider2D> results)
    {
      return Physics2D.GetRigidbodyContactsCollidersOnlyList_Injected(rigidbody, ref contactFilter, results);
    }

    internal static void SetEditorDragMovement(bool dragging, GameObject[] objs)
    {
      foreach (Rigidbody2D rigidbody2D in Physics2D.m_LastDisabledRigidbody2D)
      {
        if ((Object) rigidbody2D != (Object) null)
          rigidbody2D.SetDragBehaviour(false);
      }
      Physics2D.m_LastDisabledRigidbody2D.Clear();
      if (!dragging)
        return;
      foreach (GameObject gameObject in objs)
      {
        foreach (Rigidbody2D componentsInChild in gameObject.GetComponentsInChildren<Rigidbody2D>(false))
        {
          Physics2D.m_LastDisabledRigidbody2D.Add(componentsInChild);
          componentsInChild.SetDragBehaviour(true);
        }
      }
    }

    /// <summary>
    ///   <para>Set the raycasts to either detect or not detect Triggers.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-raycastsHitTriggers.html">External documentation for `Physics2D.raycastsHitTriggers`</a></footer>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Physics2D.raycastsHitTriggers is deprecated. Use Physics2D.queriesHitTriggers instead. (UnityUpgradable) -> queriesHitTriggers", true)]
    public static bool raycastsHitTriggers
    {
      get => false;
      set
      {
      }
    }

    /// <summary>
    ///   <para>Do ray/line casts that start inside a Collider(s) detect those Collider(s)?</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-raycastsStartInColliders.html">External documentation for `Physics2D.raycastsStartInColliders`</a></footer>
    [Obsolete("Physics2D.raycastsStartInColliders is deprecated. Use Physics2D.queriesStartInColliders instead. (UnityUpgradable) -> queriesStartInColliders", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool raycastsStartInColliders
    {
      get => false;
      set
      {
      }
    }

    /// <summary>
    ///   <para>Set whether to continue or stop the proccesing of collision callbacks if any of the objects involved in the collision are deleted.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-deleteStopsCallbacks.html">External documentation for `Physics2D.deleteStopsCallbacks`</a></footer>
    [Obsolete("Physics2D.deleteStopsCallbacks is deprecated.(UnityUpgradable) -> changeStopsCallbacks", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool deleteStopsCallbacks
    {
      get => false;
      set
      {
      }
    }

    /// <summary>
    ///   <para>Set whether the reporting of collisions callbacks immediately stops if any of the objects involved in the collision are deleted or moved. </para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-changeStopsCallbacks.html">External documentation for `Physics2D.changeStopsCallbacks`</a></footer>
    [Obsolete("Physics2D.changeStopsCallbacks is deprecated and will always return false.", false)]
    public static bool changeStopsCallbacks
    {
      get => false;
      set
      {
      }
    }

    /// <summary>
    ///   <para>This property is obsolete.  You should use defaultContactOffset instead.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-minPenetrationForPenalty.html">External documentation for `Physics2D.minPenetrationForPenalty`</a></footer>
    [Obsolete("Physics2D.minPenetrationForPenalty is deprecated. Use Physics2D.defaultContactOffset instead. (UnityUpgradable) -> defaultContactOffset", false)]
    public static float minPenetrationForPenalty
    {
      get => Physics2D.defaultContactOffset;
      set => Physics2D.defaultContactOffset = value;
    }

    /// <summary>
    ///   <para>Set whether the physics should be simulated automatically or not.</para>
    /// </summary>
    /// <footer><a href="file:///D:/unity/2020.3.14f1/Editor/Data/Documentation/en/ScriptReference/Physics2D-autoSimulation.html">External documentation for `Physics2D.autoSimulation`</a></footer>
    [Obsolete("Physics2D.autoSimulation is deprecated. Use Physics2D.simulationMode instead.", false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool autoSimulation
    {
      get => Physics2D.simulationMode != SimulationMode2D.Script;
      set => Physics2D.simulationMode = value ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_gravity_Injected(out Vector2 ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_gravity_Injected(ref Vector2 value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_jobOptions_Injected(out PhysicsJobOptions2D ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_jobOptions_Injected(ref PhysicsJobOptions2D value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_colliderAwakeColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_colliderAwakeColor_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_colliderAsleepColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_colliderAsleepColor_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_colliderContactColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_colliderContactColor_Injected(ref Color value);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void get_colliderAABBColor_Injected(out Color ret);

    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void set_colliderAABBColor_Injected(ref Color value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool Simulate_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      float step);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsTouching_TwoCollidersWithFilter_Injected(
      [Writable] Collider2D collider1,
      [Writable] Collider2D collider2,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool IsTouching_SingleColliderWithFilter_Injected(
      [Writable] Collider2D collider,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Distance_Internal_Injected(
      [Writable] Collider2D colliderA,
      [Writable] Collider2D colliderB,
      out ColliderDistance2D ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void ClosestPoint_Collider_Injected(
      ref Vector2 position,
      Collider2D collider,
      out Vector2 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void ClosestPoint_Rigidbody_Injected(
      ref Vector2 position,
      Rigidbody2D rigidbody,
      out Vector2 ret);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] LinecastAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 start,
      ref Vector2 end,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] RaycastAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 origin,
      ref Vector2 direction,
      float distance,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] CircleCastAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 origin,
      float radius,
      ref Vector2 direction,
      float distance,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] BoxCastAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 origin,
      ref Vector2 size,
      float angle,
      ref Vector2 direction,
      float distance,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] CapsuleCastAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 origin,
      ref Vector2 size,
      CapsuleDirection2D capsuleDirection,
      float angle,
      ref Vector2 direction,
      float distance,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector3 origin,
      ref Vector3 direction,
      float distance,
      int layerMask);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider2D[] OverlapPointAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 point,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider2D[] OverlapCircleAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 point,
      float radius,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider2D[] OverlapBoxAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 point,
      ref Vector2 size,
      float angle,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern Collider2D[] OverlapCapsuleAll_Internal_Injected(
      ref PhysicsScene2D physicsScene,
      ref Vector2 point,
      ref Vector2 size,
      CapsuleDirection2D direction,
      float angle,
      ref ContactFilter2D contactFilter);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderContactsArray_Injected(
      Collider2D collider,
      ref ContactFilter2D contactFilter,
      ContactPoint2D[] results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderColliderContactsArray_Injected(
      Collider2D collider1,
      Collider2D collider2,
      ref ContactFilter2D contactFilter,
      ContactPoint2D[] results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetRigidbodyContactsArray_Injected(
      Rigidbody2D rigidbody,
      ref ContactFilter2D contactFilter,
      ContactPoint2D[] results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderContactsCollidersOnlyArray_Injected(
      Collider2D collider,
      ref ContactFilter2D contactFilter,
      Collider2D[] results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetRigidbodyContactsCollidersOnlyArray_Injected(
      Rigidbody2D rigidbody,
      ref ContactFilter2D contactFilter,
      Collider2D[] results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderContactsList_Injected(
      Collider2D collider,
      ref ContactFilter2D contactFilter,
      List<ContactPoint2D> results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderColliderContactsList_Injected(
      Collider2D collider1,
      Collider2D collider2,
      ref ContactFilter2D contactFilter,
      List<ContactPoint2D> results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetRigidbodyContactsList_Injected(
      Rigidbody2D rigidbody,
      ref ContactFilter2D contactFilter,
      List<ContactPoint2D> results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetColliderContactsCollidersOnlyList_Injected(
      Collider2D collider,
      ref ContactFilter2D contactFilter,
      List<Collider2D> results);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern int GetRigidbodyContactsCollidersOnlyList_Injected(
      Rigidbody2D rigidbody,
      ref ContactFilter2D contactFilter,
      List<Collider2D> results);
  }
}
