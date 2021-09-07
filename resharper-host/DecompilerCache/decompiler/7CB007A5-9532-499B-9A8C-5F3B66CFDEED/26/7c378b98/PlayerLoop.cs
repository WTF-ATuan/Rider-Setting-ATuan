// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.LowLevel.PlayerLoop
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7CB007A5-9532-499B-9A8C-5F3B66CFDEED
// Assembly location: D:\unity\2018.4.29f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.LowLevel
{
  /// <summary>
  ///   <para>The class representing the player loop in Unity.</para>
  /// </summary>
  public class PlayerLoop
  {
    /// <summary>
    ///   <para>Returns the default update order of all engine systems in Unity.</para>
    /// </summary>
    public static PlayerLoopSystem GetDefaultPlayerLoop()
    {
      PlayerLoopSystemInternal[] playerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
      int offset = 0;
      return PlayerLoop.InternalToPlayerLoopSystem(playerLoopInternal, ref offset);
    }

    public static void SetPlayerLoop(PlayerLoopSystem loop)
    {
      List<PlayerLoopSystemInternal> internalSys = new List<PlayerLoopSystemInternal>();
      PlayerLoop.PlayerLoopSystemToInternal(loop, ref internalSys);
      PlayerLoop.SetPlayerLoopInternal(internalSys.ToArray());
    }

    private static int PlayerLoopSystemToInternal(
      PlayerLoopSystem sys,
      ref List<PlayerLoopSystemInternal> internalSys)
    {
      int count = internalSys.Count;
      PlayerLoopSystemInternal loopSystemInternal = new PlayerLoopSystemInternal()
      {
        type = sys.type,
        updateDelegate = sys.updateDelegate,
        updateFunction = sys.updateFunction,
        loopConditionFunction = sys.loopConditionFunction,
        numSubSystems = 0
      };
      internalSys.Add(loopSystemInternal);
      if (sys.subSystemList != null)
      {
        for (int index = 0; index < sys.subSystemList.Length; ++index)
          loopSystemInternal.numSubSystems += PlayerLoop.PlayerLoopSystemToInternal(sys.subSystemList[index], ref internalSys);
      }
      internalSys[count] = loopSystemInternal;
      return loopSystemInternal.numSubSystems + 1;
    }

    private static PlayerLoopSystem InternalToPlayerLoopSystem(
      PlayerLoopSystemInternal[] internalSys,
      ref int offset)
    {
      PlayerLoopSystem playerLoopSystem = new PlayerLoopSystem()
      {
        type = internalSys[offset].type,
        updateDelegate = internalSys[offset].updateDelegate,
        updateFunction = internalSys[offset].updateFunction,
        loopConditionFunction = internalSys[offset].loopConditionFunction,
        subSystemList = (PlayerLoopSystem[]) null
      };
      int num;
      offset = (num = offset) + 1;
      int index = num;
      if (internalSys[index].numSubSystems > 0)
      {
        List<PlayerLoopSystem> playerLoopSystemList = new List<PlayerLoopSystem>();
        while (offset <= index + internalSys[index].numSubSystems)
          playerLoopSystemList.Add(PlayerLoop.InternalToPlayerLoopSystem(internalSys, ref offset));
        playerLoopSystem.subSystemList = playerLoopSystemList.ToArray();
      }
      return playerLoopSystem;
    }

    [NativeMethod(IsFreeFunction = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern PlayerLoopSystemInternal[] GetDefaultPlayerLoopInternal();

    [NativeMethod(IsFreeFunction = true)]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop);
  }
}
