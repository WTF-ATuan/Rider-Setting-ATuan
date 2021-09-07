// Decompiled with JetBrains decompiler
// Type: Rewired.ReInput
// Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87012F54-A3A3-48DD-BAD0-35A200A3CC40
// Assembly location: C:\Users\ATuan\Downloads\Hollow-Knight-Like-Game-Development-develop\Assets\Rewired\Internal\Libraries\Runtime\Rewired_Core.dll

using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.InputManagers;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4;
using Rewired.Platforms.XboxOne;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using Rewired.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace Rewired
{
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  /// <summary>
  /// The main class for accessing all input-related information.
  /// </summary>
  public static class ReInput
  {
    [CustomObfuscation(rename = false)]
    internal const int programVersion1 = 1;
    [CustomObfuscation(rename = false)]
    internal const int programVersion2 = 1;
    [CustomObfuscation(rename = false)]
    internal const int programVersion3 = 39;
    [CustomObfuscation(rename = false)]
    internal const int programVersion4 = 2;
    [CustomObfuscation(rename = false)]
    internal const int dataVersion = 1;
    [CustomObfuscation(rename = false)]
    internal const bool isTrial = true;
    [CustomObfuscation(rename = false)]
    internal const string majorBranch = "U2020";
    private static InputManager_Base ybGwqznbxFisdrSVioLpNYpJswe;
    private static PlatformInputManager lxIwNHlLLhCTcLKwfECUdRyoQRqn;
    internal static UtfAbpIKiaaLpNbHJCavACDFowSL huPkcghnmfujhITXupfvuZzZnvX;
    internal static OSEvqAzfRRImIajEgswFeFeuEnmj ssVepcdhcQDCSmMguyiEkGPQzcFn;
    internal static oUFRYxhuYStPPSPmghvjLnFxEvy IunzkBzmzbvkNcXgVbfhTUGBTQT;
    private static ControllerDataFiles IpMEEVTbjuWFErEDfgWmyhDCeje;
    private static UserData RIFrLXBUOhfsSJgzsybOKhxdgYJ;
    private static bool HVKvGYoFyXXfhvoqnuhqBplpKEk;
    private static ConfigVars bVKkeJIbKbigPklBsshxgxpMgxT;
    private static UpdateLoopType qwhJSUwslsGEuWRFFFjTTVqEPpZ;
    private static bool FwHBikGgzpbsKzUoEaSEARcWtYXb;
    private static Rewired.Platforms.Platform DKWMqVtyubBkajFNQwELCcOaGRz;
    private static WebplayerPlatform rasyllrPLaVEYcDsvWnIplsRbLX;
    private static EditorPlatform TrhehmkLiyqWIcOWLVQBXtFrAeVs;
    private static bool BTHMlECYOOjCXwmylYgYiqAzSFM;
    private static TimerAbs kRcqGnVlcQgLIUphNiDODoYtEtG;
    private static ReInput.McKOXtijWtxGreONISFgcvboteO rCasTtxajaYfVqBdZjtydsSfKZag;
    private static string ZObkYhohlQJDrpyHiiLcaQpBBXl;
    private static bool WiPECnHnOxmsPcNuMJYDEcGKoCr;
    private static bool nnZuWiAyLnHIBmqNTqiaYbkOVfR;
    private static bool NeVIVssqMdfHIbMJqDMisOqHDTHe = true;
    private static int zkuOzmnnSjrEgzvtJvHpGUVryen = -1;
    [CustomObfuscation(rename = false)]
    internal static int _id = -1;
    private static int NBsChCDKndbtySHSEluWpaWdhldE = 0;
    private static int hacAZRuwjcjAyppzQtuprQiTjiN;
    private static bool gQSCsulqVehPHYubeQCKRnoblJC;
    private static readonly ReInput.UnityTouch RPoNGwmsvYeUEnQIgyymTfiOLKp;
    private static readonly ReInput.PlayerHelper vgROvCEburrNQtxwNtPTUaKOlAl;
    private static readonly ReInput.ControllerHelper xlGdBtQPOAGvjdzoezGyjODOCGgU;
    private static readonly ReInput.MappingHelper NcCSgLsMbakjIFCfFHHcympQQjc;
    private static readonly ReInput.TimeHelper LgKBNVHZmoqdQGHWLDfZxTrcHus;
    private static readonly ReInput.ConfigHelper CZCmSGXKhvqfJwEmdKCnREsxmDM;
    private static pEbhCNcfTSbBouVGFjuiskdvPrdF JIdDOWGDhNgIysUavrDFYClfkfk;
    private static UserDataStore omMZsBJMFhjqytvucXzSxfWOSPc;
    private static IControllerAssigner rHXofzgXUQMoEEeXKGkqpijNFQI;
    private static ReInput.turGXwBvHWoRGEzdiNffQHtjLxUE hzCluKkRomMVpVMKggrQlnitdalC;
    private static SafeAction<ControllerStatusChangedEventArgs> FktuBhmKTiGpvFCvSHIqwMSHhvpg;
    private static SafeAction<ControllerStatusChangedEventArgs> injKMJwLZRYPDmsKVBkpvIakuCN;
    private static SafeAction<ControllerStatusChangedEventArgs> uespMfZgrZnnwqIICaXQFmfDCcXg;
    private static SafeAction gfjGGHeupXeEeCzlazaBgdJhhTF;
    private static SafeAction gRrcKGVMfkbVjAUgyrYMmLXbcFDj;
    private static SafeAction iagFLpAUXxiaVisDjSyeOhqVFHuP;
    private static SafeAction exTFuxyVsWVvsRJZJlzolnWoHKJ;
    private static SafeAction AqtwWiVqymVxpVGiJdNHneaNeEc;
    [CustomObfuscation(rename = false)]
    private static Action<bool> _ApplicationFocusChangedEvent;
    private static Action rEuALJCYsRGwkSBNaQakcmnhoaPH;
    private static Action<UpdateLoopType> yudmTUZTllInXrmiIZLoTQUojzG;
    private static Action<UpdateLoopType> smvtLwcJYoipYmoBgEnlmMhLttx;
    private static Action<UpdateLoopType> ostueppptMQBZYxgOVsPupxDjZV;
    private static Action OIDJrIUJtXACLDdVXaUNdZdAqvnB;
    private static Action<bool> DTUpHJtKtyPGnDYNnPmJNxCsBbp;
    private static Action<bool> oVkdLoDQJznYunWvAxTElPCSGiy;
    private static Action<bool> vcOBHdeOXQlxDhZuZJbFQkCFRg;
    private static Action<FullScreenMode> lKyyhRCiajyuusLvAXuPKKqhlzY;
    private static Action LwaNEROjLYkQmacKjigBRysAKMx;
    private static Action<bool> aoIOjUMoGVjlQQuFnhlLmqiUCoWa;
    [CustomObfuscation(rename = false)]
    internal static double unscaledDeltaTime;
    [CustomObfuscation(rename = false)]
    internal static double unscaledTime;
    [CustomObfuscation(rename = false)]
    internal static double unscaledTimePrev;
    /// <summary>Frame count for current loop.</summary>
    [CustomObfuscation(rename = false)]
    internal static uint currentFrame;
    /// <summary>Previous frame count for current loop.</summary>
    [CustomObfuscation(rename = false)]
    internal static uint previousFrame;
    /// <summary>
    /// Total frame count of all update loops combined.
    /// Valid value starts at 1, not 0.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static uint absFrame;
    private static bool hPexmxlfmOhsvJpFwBzyzLQJyhYg;
    private static bool OUBTfacDdMEKZhIFynVcYvTvnmNH;

    static ReInput()
    {
label_1:
      int num1 = 489067697;
      while (true)
      {
        switch (num1 ^ 489067690)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg = new SafeAction<ControllerStatusChangedEventArgs>(ReInput.ARQlqlUkfTZVuDcCrbSITZQyONt);
            int num2;
            // ISSUE: reference to a compiler-generated field
            num1 = num2 = ReInput.fIxUOclXaEjmjgfpsQVuuQclypJ != null ? 489067710 : (num2 = 489067689);
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            ReInput.sBXuGfoABggJxWJZKBjhEtdBeaDs = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.ShutDownEvent", _param0));
            num1 = 489067707;
            continue;
          case 2:
            int num3;
            // ISSUE: reference to a compiler-generated field
            num1 = num3 = ReInput.CklpJxsyaAHAYUNtPfWgJdNhcZie != null ? 489067708 : (num3 = 489067683);
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ReInput.fIxUOclXaEjmjgfpsQVuuQclypJ = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.ControllerPreDisconnectEvent", _param0));
            num1 = 489067710;
            continue;
          case 4:
            int num4;
            // ISSUE: reference to a compiler-generated field
            num1 = num4 = ReInput.HeCjILHMUSBMENMtKhrfTaQhlonL != null ? 489067693 : (num4 = 489067699);
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ReInput.AqtwWiVqymVxpVGiJdNHneaNeEc = new SafeAction(ReInput.QVpmsnUBfkTcTdqkbdlLDhvfJNpF);
            num1 = 489067692;
            continue;
          case 6:
            int num5;
            // ISSUE: reference to a compiler-generated field
            num1 = num5 = ReInput.LKCQUOZDswTquzchKmHWMURIBMT != null ? 489067711 : (num5 = 489067681);
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj = new SafeAction(ReInput.HeCjILHMUSBMENMtKhrfTaQhlonL);
            num1 = 489067688;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg = new SafeAction<ControllerStatusChangedEventArgs>(ReInput.UsdJvzLvImUgGIjCMCryJoBYzGej);
            num1 = 489067704;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            ReInput.CklpJxsyaAHAYUNtPfWgJdNhcZie = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.PreShutDownEvent", _param0));
            num1 = 489067708;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            ReInput.UsdJvzLvImUgGIjCMCryJoBYzGej = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.ControllerDisconnectedEvent", _param0));
            num1 = 489067682;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            ReInput.LKCQUOZDswTquzchKmHWMURIBMT = (Action<Exception>) (_param0 => ReInput.HandleCallbackException(nameof (), _param0));
            num1 = 489067711;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF = new SafeAction(ReInput.afXywNVhXGxmKIrartRfNrNqXKL);
            num1 = 489067694;
            continue;
          case 13:
            goto label_1;
          case 14:
            ReInput.CZCmSGXKhvqfJwEmdKCnREsxmDM = ReInput.ConfigHelper.Instance;
            int num6;
            // ISSUE: reference to a compiler-generated field
            num1 = num6 = ReInput.ARQlqlUkfTZVuDcCrbSITZQyONt != null ? 489067690 : (num6 = 489067706);
            continue;
          case 15:
            ReInput.xlGdBtQPOAGvjdzoezGyjODOCGgU = ReInput.ControllerHelper.Instance;
            ReInput.NcCSgLsMbakjIFCfFHHcympQQjc = ReInput.MappingHelper.Instance;
            num1 = 489067698;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            ReInput.ARQlqlUkfTZVuDcCrbSITZQyONt = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.ControllerConnectedEvent", _param0));
            num1 = 489067690;
            continue;
          case 17:
            // ISSUE: reference to a compiler-generated field
            ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ = new SafeAction(ReInput.sBXuGfoABggJxWJZKBjhEtdBeaDs);
            num1 = 489067696;
            continue;
          case 18:
            int num7;
            // ISSUE: reference to a compiler-generated field
            num1 = num7 = ReInput.afXywNVhXGxmKIrartRfNrNqXKL != null ? 489067686 : (num7 = 489067709);
            continue;
          case 19:
            ReInput.vgROvCEburrNQtxwNtPTUaKOlAl = ReInput.PlayerHelper.Instance;
            num1 = 489067685;
            continue;
          case 20:
            // ISSUE: reference to a compiler-generated field
            ReInput.injKMJwLZRYPDmsKVBkpvIakuCN = new SafeAction<ControllerStatusChangedEventArgs>(ReInput.fIxUOclXaEjmjgfpsQVuuQclypJ);
            int num8;
            // ISSUE: reference to a compiler-generated field
            num1 = num8 = ReInput.UsdJvzLvImUgGIjCMCryJoBYzGej != null ? 489067682 : (num8 = 489067680);
            continue;
          case 22:
            // ISSUE: reference to a compiler-generated field
            ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP = new SafeAction(ReInput.CklpJxsyaAHAYUNtPfWgJdNhcZie);
            int num9;
            // ISSUE: reference to a compiler-generated field
            num1 = num9 = ReInput.sBXuGfoABggJxWJZKBjhEtdBeaDs != null ? 489067707 : (num9 = 489067691);
            continue;
          case 23:
            // ISSUE: reference to a compiler-generated field
            ReInput.afXywNVhXGxmKIrartRfNrNqXKL = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.InputSourceUpdateEvent", _param0));
            num1 = 489067686;
            continue;
          case 24:
            ReInput.LgKBNVHZmoqdQGHWLDfZxTrcHus = ReInput.TimeHelper.Instance;
            num1 = 489067684;
            continue;
          case 25:
            // ISSUE: reference to a compiler-generated field
            ReInput.HeCjILHMUSBMENMtKhrfTaQhlonL = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.EditorRecompileEvent", _param0));
            num1 = 489067693;
            continue;
          case 26:
            // ISSUE: reference to a compiler-generated field
            if (ReInput.QVpmsnUBfkTcTdqkbdlLDhvfJNpF == null)
            {
              // ISSUE: reference to a compiler-generated field
              ReInput.QVpmsnUBfkTcTdqkbdlLDhvfJNpF = (Action<Exception>) (_param0 => ReInput.HandleCallbackException("Rewired.ReInput.InitializedEvent", _param0));
              num1 = 489067695;
              continue;
            }
            goto case 5;
          case 27:
            ReInput.RPoNGwmsvYeUEnQIgyymTfiOLKp = ReInput.UnityTouch.Instance;
            num1 = 489067705;
            continue;
          default:
            goto label_30;
        }
      }
label_30:
      // ISSUE: reference to a compiler-generated field
      SafeDelegate.S_ExceptionHandler = ReInput.LKCQUOZDswTquzchKmHWMURIBMT;
    }

    private static pEbhCNcfTSbBouVGFjuiskdvPrdF unityInputBuffer => ReInput.JIdDOWGDhNgIysUavrDFYClfkfk ?? (ReInput.JIdDOWGDhNgIysUavrDFYClfkfk = new pEbhCNcfTSbBouVGFjuiskdvPrdF(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop));

    /// <summary>Event triggered when a controller is conected.</summary>
    public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent
    {
      add => ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg += value;
      remove => ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg -= value;
    }

    /// <summary>
    /// Event triggered just before a controller is disconnected. You can use this event to save controller maps before the controller is removed.
    /// </summary>
    public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent
    {
      add => ReInput.injKMJwLZRYPDmsKVBkpvIakuCN += value;
      remove => ReInput.injKMJwLZRYPDmsKVBkpvIakuCN -= value;
    }

    /// <summary>Event triggered after a controller is disconnected.</summary>
    public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent
    {
      add => ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg += value;
      remove => ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg -= value;
    }

    /// <summary>
    /// Event triggered before all input sources are updated. Use this event to update the element values Custom Controllers.
    /// </summary>
    public static event Action InputSourceUpdateEvent
    {
      add => ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF += value;
      remove => ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF -= value;
    }

    /// <summary>Event triggered when editor begins recompiling scripts.</summary>
    public static event Action EditorRecompileEvent
    {
      add => ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj += value;
      remove => ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj -= value;
    }

    /// <summary>
    /// Event triggered immediately before Rewired shuts down.
    /// Rewired objects are still valid during this event.
    /// </summary>
    public static event Action PreShutDownEvent
    {
      add => ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP += value;
      remove => ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP -= value;
    }

    /// <summary>Event triggered after Rewired shuts down.</summary>
    public static event Action ShutDownEvent
    {
      add => ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ += value;
      remove => ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ -= value;
    }

    /// <summary>
    /// Event triggered after Rewired initializes.
    /// Event listeners are never cleared from this event when Rewired is shut down so
    /// you can subscribe once and receive events every time Rewired initializes.
    /// </summary>
    public static event Action InitializedEvent
    {
      add => ReInput.AqtwWiVqymVxpVGiJdNHneaNeEc += value;
      remove => ReInput.AqtwWiVqymVxpVGiJdNHneaNeEc -= value;
    }

    /// <summary>
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<bool> ApplicationFocusChangedEvent
    {
      add => ReInput._ApplicationFocusChangedEvent += value;
      remove => ReInput._ApplicationFocusChangedEvent -= value;
    }

    /// <summary>
    /// This fires every once every main Unity thread update at the beginning
    /// of FixedUpdate or Update, whichever runs first.
    /// This event always executes on the main thread.
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action EarlyUpdateEvent
    {
      add => ReInput.rEuALJCYsRGwkSBNaQakcmnhoaPH += value;
      remove => ReInput.rEuALJCYsRGwkSBNaQakcmnhoaPH -= value;
    }

    /// <summary>
    /// This event fires every update loop before Time Manager updates.
    /// THIS EVENT IS NOT FED WHEN REWIRED IS RESET OR DESTROYED!
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent
    {
      add => ReInput.yudmTUZTllInXrmiIZLoTQUojzG += value;
      remove => ReInput.yudmTUZTllInXrmiIZLoTQUojzG -= value;
    }

    /// <summary>
    /// This event fires every update loop before Rewired's core update.
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<UpdateLoopType> UpdateStartedEvent
    {
      add => ReInput.smvtLwcJYoipYmoBgEnlmMhLttx += value;
      remove => ReInput.smvtLwcJYoipYmoBgEnlmMhLttx -= value;
    }

    /// <summary>
    /// This event fires every update loop after Rewired's core update is finished.
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<UpdateLoopType> UpdateEndedEvent
    {
      add => ReInput.ostueppptMQBZYxgOVsPupxDjZV += value;
      remove => ReInput.ostueppptMQBZYxgOVsPupxDjZV -= value;
    }

    /// <summary>
    /// This event fires every Unity LateUpdate.
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action LateUpdateEvent
    {
      add => ReInput.OIDJrIUJtXACLDdVXaUNdZdAqvnB += value;
      remove => ReInput.OIDJrIUJtXACLDdVXaUNdZdAqvnB -= value;
    }

    /// <summary>
    /// /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<bool> ApplicationIsFullScreenChangedEvent
    {
      add => ReInput.DTUpHJtKtyPGnDYNnPmJNxCsBbp += value;
      remove => ReInput.DTUpHJtKtyPGnDYNnPmJNxCsBbp -= value;
    }

    /// <summary>
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<bool> ApplicationRunInBackgroundChangedEvent
    {
      add => ReInput.oVkdLoDQJznYunWvAxTElPCSGiy += value;
      remove => ReInput.oVkdLoDQJznYunWvAxTElPCSGiy -= value;
    }

    /// <summary>
    /// /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<bool> TimeScalePauseChangedEvent
    {
      add => ReInput.vcOBHdeOXQlxDhZuZJbFQkCFRg += value;
      remove => ReInput.vcOBHdeOXQlxDhZuZJbFQkCFRg -= value;
    }

    [CustomObfuscation(rename = false)]
    internal static event Action<FullScreenMode> ApplicationFullScreenModeChangedEvent
    {
      add => ReInput.lKyyhRCiajyuusLvAXuPKKqhlzY += value;
      remove => ReInput.lKyyhRCiajyuusLvAXuPKKqhlzY -= value;
    }

    /// <summary>
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action SceneLoadedEvent
    {
      add => ReInput.LwaNEROjLYkQmacKjigBRysAKMx += value;
      remove => ReInput.LwaNEROjLYkQmacKjigBRysAKMx -= value;
    }

    /// <summary>
    /// This is thread-safe and can be unsubcribed in a destructor.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static event Action<bool> EditorPauseChangedEvent
    {
      add => ReInput.aoIOjUMoGVjlQQuFnhlLmqiUCoWa += value;
      remove => ReInput.aoIOjUMoGVjlQQuFnhlLmqiUCoWa -= value;
    }

    /// <summary>
    /// Gets an object that contains all player-related members.
    /// </summary>
    public static ReInput.PlayerHelper players
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.vgROvCEburrNQtxwNtPTUaKOlAl;
        ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
        return (ReInput.PlayerHelper) null;
      }
    }

    /// <summary>
    /// Gets an object that contains all controller-related members.
    /// </summary>
    public static ReInput.ControllerHelper controllers
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.xlGdBtQPOAGvjdzoezGyjODOCGgU;
        ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
        return (ReInput.ControllerHelper) null;
      }
    }

    /// <summary>
    /// Gets an object that contains all mapping-related members.
    /// </summary>
    public static ReInput.MappingHelper mapping
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.NcCSgLsMbakjIFCfFHHcympQQjc;
        ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
        return (ReInput.MappingHelper) null;
      }
    }

    /// <summary>Gets an object that contains all touch-related members.</summary>
    public static ReInput.UnityTouch touch
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.RPoNGwmsvYeUEnQIgyymTfiOLKp;
label_1:
        int num = -761631442;
        while (true)
        {
          switch (num ^ -761631444)
          {
            case 0:
              goto label_1;
            case 2:
              ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
              num = -761631443;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return (ReInput.UnityTouch) null;
      }
    }

    /// <summary>
    /// Gets an object that provides access to time-related data. This is mostly for time comparisons for button and axis active/inactive time measurement.
    /// </summary>
    public static ReInput.TimeHelper time
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.LgKBNVHZmoqdQGHWLDfZxTrcHus;
label_1:
        int num = 686297756;
        while (true)
        {
          switch (num ^ 686297758)
          {
            case 0:
              goto label_1;
            case 2:
              ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
              num = 686297759;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return (ReInput.TimeHelper) null;
      }
    }

    /// <summary>
    /// Gets the UserDataStore component attached to the Rewired Input Manager if any. Use to access data saving and loading.
    /// </summary>
    public static IUserDataStore userDataStore
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return (IUserDataStore) ReInput.omMZsBJMFhjqytvucXzSxfWOSPc;
label_1:
        int num = -1104655782;
        while (true)
        {
          switch (num ^ -1104655781)
          {
            case 1:
              ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
              num = -1104655781;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return (IUserDataStore) null;
      }
    }

    /// <summary>
    /// Gets an object that provides access to configuration-related data.
    /// </summary>
    public static ReInput.ConfigHelper configuration
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.CZCmSGXKhvqfJwEmdKCnREsxmDM;
        ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
        return (ReInput.ConfigHelper) null;
      }
    }

    /// <summary>Gets the current Rewired version number as a string.</summary>
    public static string programVersion
    {
      get
      {
        object[] objArray = new object[8];
        objArray[0] = (object) 1;
label_1:
        int num = 1003317940;
        while (true)
        {
          switch (num ^ 1003317941)
          {
            case 1:
              objArray[1] = (object) ".";
              objArray[2] = (object) 1;
              objArray[3] = (object) ".";
              objArray[4] = (object) 39;
              objArray[5] = (object) ".";
              objArray[6] = (object) 2;
              objArray[7] = (object) ".U2020";
              num = 1003317941;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return string.Concat(objArray);
      }
    }

    /// <summary>
    /// Is Unity (fallback) input currently being used to drive input?
    /// </summary>
    public static bool usingUnityInput => ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb;

    /// <summary>
    /// Does the current platform require manual joystick identification?
    /// </summary>
    public static bool unityJoystickIdentificationRequired => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && ReInput.isWindowsStandaloneWebplayerOrEditorPlatform && !UnityTools.windowsJoystickNamesReturnsEmptyStringsIfJoystickNull;

    /// <summary>Is the input system ready?</summary>
    public static bool isReady => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk;

    /// <summary>
    /// Completely clears and reinitializes the Input Manager.
    /// This is equivalent to destroying the Rewired Input Manager and reinstantiating it.
    /// The current input configuration (Joystick ids, controller assignments, modified Controller Maps) will be reset.
    /// All stored references to Rewired objects (Player, Joystick, ReInput.ControllerHelper, etc.) will become invalid.
    /// All event listeners will be cleared.
    /// </summary>
    public static void Reset()
    {
      if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        goto label_5;
label_1:
      int num = -445361362;
label_2:
      switch (num ^ -445361361)
      {
        case 0:
          goto label_7;
        case 1:
          return;
        case 2:
          break;
        case 3:
          return;
        case 4:
          goto label_1;
        default:
          return;
      }
label_5:
      if ((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe == (UnityEngine.Object) null)
        return;
label_7:
      ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
      num = -445361364;
      goto label_2;
    }

    /// <summary>
    /// The unique id of the Rewired instance. Every time Rewired is initialized, the id is incremented.
    /// This is used for version checking on Rewred objects.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static int id => ReInput._id;

    [CustomObfuscation(rename = false)]
    internal static bool initialized => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk;

    [CustomObfuscation(rename = false)]
    internal static UpdateLoopType currentUpdateLoop => ReInput.qwhJSUwslsGEuWRFFFjTTVqEPpZ;

    /// <summary>
    /// DO NOT CALL THIS FROM A PLUGIN!!!!
    /// Use pluginConfigVars instead.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static ConfigVars configVars => ReInput.bVKkeJIbKbigPklBsshxgxpMgxT;

    [CustomObfuscation(rename = false)]
    internal static IConfigVars_Internal pluginConfigVars => (IConfigVars_Internal) ReInput.bVKkeJIbKbigPklBsshxgxpMgxT;

    /// <summary>
    /// DO NOT CALL THIS FROM A PLUGIN!!!!
    /// Use pluginConfigVars instead.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static UserData UserData => ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ;

    [CustomObfuscation(rename = false)]
    internal static Rewired.Platforms.Platform currentPlatform => ReInput.DKWMqVtyubBkajFNQwELCcOaGRz;

    [CustomObfuscation(rename = false)]
    internal static WebplayerPlatform webplayerPlatform => ReInput.rasyllrPLaVEYcDsvWnIplsRbLX;

    [CustomObfuscation(rename = false)]
    internal static EditorPlatform editorPlatform => ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs;

    [CustomObfuscation(rename = false)]
    internal static bool checkNeverPressed
    {
      get
      {
        if (ReInput.DKWMqVtyubBkajFNQwELCcOaGRz != Rewired.Platforms.Platform.Linux)
          goto label_11;
label_1:
        int num1 = 948307555;
label_2:
        while (true)
        {
          switch (num1 ^ 948307556)
          {
            case 0:
              if (ReInput.primaryInputManager.inputSourceType == InputSource.OSX)
              {
                num1 = 948307565;
                continue;
              }
              goto label_7;
            case 1:
              if (ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
              {
                num1 = 948307554;
                continue;
              }
              goto label_17;
            case 2:
              goto label_3;
            case 4:
              int num2;
              num1 = num2 = ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb ? 948307565 : (num2 = 948307556);
              continue;
            case 5:
              if (ReInput.rasyllrPLaVEYcDsvWnIplsRbLX == WebplayerPlatform.OSX)
              {
                num1 = 948307558;
                continue;
              }
              goto label_4;
            case 6:
              goto label_16;
            case 7:
              goto label_9;
            case 8:
              goto label_1;
            case 9:
              goto label_6;
            default:
              goto label_23;
          }
        }
label_3:
        return true;
label_6:
        return true;
label_9:
        if (ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
          return true;
        goto label_11;
label_16:
        return true;
label_23:
        return true;
label_4:
        if (ReInput.DKWMqVtyubBkajFNQwELCcOaGRz != Rewired.Platforms.Platform.WebGL)
          return false;
        num1 = 948307559;
        goto label_2;
label_7:
        if (UnityTools.isAndroidPlatform)
        {
          num1 = 948307557;
          goto label_2;
        }
        else
          goto label_17;
label_11:
        if (ReInput.DKWMqVtyubBkajFNQwELCcOaGRz == Rewired.Platforms.Platform.OSX)
        {
          num1 = 948307552;
          goto label_2;
        }
        else
          goto label_7;
label_17:
        if (ReInput.DKWMqVtyubBkajFNQwELCcOaGRz == Rewired.Platforms.Platform.Webplayer)
        {
          num1 = 948307553;
          goto label_2;
        }
        else
          goto label_4;
      }
    }

    [CustomObfuscation(rename = false)]
    internal static bool isEditor => ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs != EditorPlatform.None;

    [CustomObfuscation(rename = false)]
    internal static Guid defaultHardwareJoystickMapGuid => !ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk ? Guid.Empty : ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.defaultHardwareJoystickMapGuid;

    [CustomObfuscation(rename = false)]
    internal static bool isRunningInEditMode => ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR;

    [CustomObfuscation(rename = false)]
    internal static bool isEditorPaused => UnityTools.externalTools.isEditorPaused;

    [CustomObfuscation(rename = false)]
    internal static float unityUnscaledDeltaTime => ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.pengAGLJXAdEPjHiVKPmJmvqiqDk;

    [CustomObfuscation(rename = false)]
    internal static float unityUnscaledDeltaTimePrev => ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.TfGchxBPBEyNlgFhMsZZEMUYPho;

    [CustomObfuscation(rename = false)]
    internal static double realTime => !ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk ? 0.0 : ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.FIRIpvFCpLepBeglYvRzekwoHgmJ;

    /// <summary>
    /// The current Unity frame.
    /// This only updates once per main thread frame in either FixedUpdate or Update, whichever runs first.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static int currentUnityFrame => !ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk ? 0 : ReInput.hzCluKkRomMVpVMKggrQlnitdalC.XiDZQOUPwAMXyPtXMnYBFcTlbKP;

    private static bool isEditorGameViewFocused => UnityTools.unityVersion >= UnityTools.UnityVersion.UNITY_5_1 ? ReInput.ZObkYhohlQJDrpyHiiLcaQpBBXl == "Game" : ReInput.ZObkYhohlQJDrpyHiiLcaQpBBXl == "UnityEditor.GameView";

    /// <summary>
    /// Determines if an editor window where input is allowed has focus.
    /// This does not incorporate whether the Unity Editor has focus.
    /// It also doesn't incorporate the ignore input when app not in focus stuff.
    /// </summary>
    [CustomObfuscation(rename = false)]
    internal static bool isAllowedEditorWindowFocused
    {
      get
      {
        if (ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.allowInputInEditorSceneView)
        {
label_1:
          int num = -498827762;
          while (true)
          {
            switch (num ^ -498827761)
            {
              case 1:
                if (UnityTools.externalTools.IsEditorSceneViewFocused())
                {
                  num = -498827761;
                  continue;
                }
                goto label_6;
              case 2:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return true;
        }
label_6:
        return ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe || ReInput.isEditorGameViewFocused;
      }
    }

    [CustomObfuscation(rename = false)]
    internal static bool isUnityEditorFocused => ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn is INativePlatformHelper ctcLkwfEcUdRyoQrqn ? ctcLkwfEcUdRyoQrqn.isApplicationFocused : ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe;

    [CustomObfuscation(rename = false)]
    internal static bool isWindowsStandaloneWebplayerOrEditorPlatform
    {
      get
      {
        if (!ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return false;
        if (ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
          goto label_6;
label_3:
        int num1 = -2112215326;
label_4:
        while (true)
        {
          switch (num1 ^ -2112215325)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_5;
            case 3:
              int num2;
              num1 = num2 = ReInput.DKWMqVtyubBkajFNQwELCcOaGRz != Rewired.Platforms.Platform.Webplayer ? -2112215327 : (num2 = -2112215321);
              continue;
            case 4:
              if (ReInput.rasyllrPLaVEYcDsvWnIplsRbLX != WebplayerPlatform.Windows)
              {
                num1 = -2112215327;
                continue;
              }
              goto label_12;
            default:
              goto label_11;
          }
        }
label_5:
        return false;
label_11:
        return ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs == EditorPlatform.Windows;
label_6:
        if (ReInput.DKWMqVtyubBkajFNQwELCcOaGRz != Rewired.Platforms.Platform.Windows)
        {
          num1 = -2112215328;
          goto label_4;
        }
label_12:
        return true;
      }
    }

    private static bool inputAllowed => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && (ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.value || !ReInput.gQSCsulqVehPHYubeQCKRnoblJC && (ReInput.isEditor || ReInput.hzCluKkRomMVpVMKggrQlnitdalC.YXvGkrWuFDzIDXbWAMtPnseRiuf.value));

    [CustomObfuscation(rename = false)]
    internal static bool IsInputAllowed(ControllerType controllerType)
    {
      if (ReInput.inputAllowed)
        goto label_4;
label_1:
      int num1 = 19130358;
label_2:
      while (true)
      {
        switch (num1 ^ 19130354)
        {
          case 1:
            if (ReInput.gQSCsulqVehPHYubeQCKRnoblJC)
            {
              num1 = 19130352;
              continue;
            }
            if (ReInput.isAllowedEditorWindowFocused)
            {
              if (controllerType == ControllerType.Mouse)
              {
                num1 = 19130354;
                continue;
              }
              goto label_20;
            }
            else
              goto label_15;
          case 2:
            if (!ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.value)
            {
              num1 = 19130359;
              continue;
            }
            goto label_20;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            goto label_13;
          case 6:
            int num2;
            num1 = num2 = controllerType == ControllerType.Keyboard ? 19130355 : (num2 = 19130357);
            continue;
          case 7:
            if (controllerType == ControllerType.Mouse)
            {
              num1 = 19130355;
              continue;
            }
            goto label_20;
          default:
            goto label_18;
        }
      }
label_3:
      return false;
label_13:
      return false;
label_15:
      return false;
label_18:
      if (!ReInput.isUnityEditorFocused)
        return false;
      goto label_20;
label_4:
      if (ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs != EditorPlatform.None)
      {
        num1 = 19130356;
        goto label_2;
      }
label_20:
      return true;
    }

    [CustomObfuscation(rename = false)]
    internal static bool applicationIsFocused => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.value;

    [CustomObfuscation(rename = false)]
    internal static bool applicationIsFullScreen => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && ReInput.hzCluKkRomMVpVMKggrQlnitdalC.xvFOSywVLenNnSMFVdzEYKETiTEG.value;

    [CustomObfuscation(rename = false)]
    internal static bool applicationRunInBackground => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && ReInput.hzCluKkRomMVpVMKggrQlnitdalC.YXvGkrWuFDzIDXbWAMtPnseRiuf.value;

    [CustomObfuscation(rename = false)]
    internal static bool timeScaleIsPaused => ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk && ReInput.hzCluKkRomMVpVMKggrQlnitdalC.BbyRoBsowyQmdHmWWxWCZqxtDV.value;

    [CustomObfuscation(rename = false)]
    internal static InputManager_Base rewiredInputManager => ReInput.ybGwqznbxFisdrSVioLpNYpJswe;

    [CustomObfuscation(rename = false)]
    internal static PlatformInputManager primaryInputManager
    {
      get
      {
        if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
          return ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.primaryInputManager;
        ReInput.aPgcgNcZfCkhELamqDBySBgmdTgI();
        return (PlatformInputManager) null;
      }
    }

    [CustomObfuscation(rename = false)]
    internal static IControllerAssigner controllerAssigner
    {
      get => ReInput.rHXofzgXUQMoEEeXKGkqpijNFQI;
      set => ReInput.rHXofzgXUQMoEEeXKGkqpijNFQI = value;
    }

    [CustomObfuscation(rename = false)]
    internal static RewiredVersion rewiredVersion => new RewiredVersion(ReInput.programVersion);

    [CustomObfuscation(rename = false)]
    internal static int timeScalePauseChangedCount => ReInput.hacAZRuwjcjAyppzQtuprQiTjiN;

    internal static void CUjetGXyPfLfCEdKRehfcNPqsrzO(
      InputManager_Base _param0,
      Func<ConfigVars, object> _param1,
      ConfigVars _param2,
      ControllerDataFiles _param3,
      UserData _param4)
    {
      try
      {
        ReInput._id = ReInput.NBsChCDKndbtySHSEluWpaWdhldE;
        ++ReInput.NBsChCDKndbtySHSEluWpaWdhldE;
        ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk = true;
label_1:
        int num1 = -226225238;
        while (true)
        {
          int num2;
          switch (num1 ^ -226225247)
          {
            case 0:
              ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.Set(ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe);
              num1 = -226225278;
              continue;
            case 1:
              ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn = new OSEvqAzfRRImIajEgswFeFeuEnmj(_param2, ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn);
              num1 = -226225230;
              continue;
            case 2:
              ReInput.uGGCMATxPHAhNVyQgoNkyCtCpOl();
              num1 = -226225279;
              continue;
            case 3:
              ReInput.DKWMqVtyubBkajFNQwELCcOaGRz = UnityTools.platform;
              ReInput.rasyllrPLaVEYcDsvWnIplsRbLX = UnityTools.webplayerPlatform;
              num1 = -226225242;
              continue;
            case 4:
              ReInput.omMZsBJMFhjqytvucXzSxfWOSPc.Initialize();
              num1 = -226225231;
              continue;
            case 5:
              num2 = !Application.isPlaying ? 1 : 0;
              break;
            case 6:
              ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.Set(ReInput.isUnityEditorFocused && ReInput.isAllowedEditorWindowFocused);
              num1 = -226225245;
              continue;
            case 7:
              ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs = UnityTools.editorPlatform;
              num1 = -226225277;
              continue;
            case 8:
              ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje = _param3;
              num1 = -226225218;
              continue;
            case 9:
              ThreadSafeUnityInput.Initialize();
              num1 = -226225235;
              continue;
            case 10:
              int num3;
              num1 = num3 = !ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR ? -226225228 : (num3 = -226225225);
              continue;
            case 11:
              ReInput.WiPECnHnOxmsPcNuMJYDEcGKoCr = true;
              num1 = -226225222;
              continue;
            case 12:
              ReInput.hzCluKkRomMVpVMKggrQlnitdalC = new ReInput.turGXwBvHWoRGEzdiNffQHtjLxUE();
              num1 = -226225247;
              continue;
            case 13:
              ReInput.bVKkeJIbKbigPklBsshxgxpMgxT = _param2;
              num1 = -226225246;
              continue;
            case 14:
              ReInput.GvzBpPUzfnXAFfMlFQoGVqiYZcc();
              num1 = -226225234;
              continue;
            case 15:
              ThreadSafeUnityInput.PostInitialize2();
              num1 = -226225224;
              continue;
            case 16:
              ReInput.PhrSTCaiexVCPzKwyppNAQnGOJa();
              ReInput.WiPECnHnOxmsPcNuMJYDEcGKoCr = false;
              num1 = -226225237;
              continue;
            case 17:
              ReInput.ybGwqznbxFisdrSVioLpNYpJswe = _param0;
              num1 = -226225236;
              continue;
            case 18:
              ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe = ReInput.isEditorGameViewFocused;
              num1 = -226225241;
              continue;
            case 19:
              ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT = new oUFRYxhuYStPPSPmghvjLnFxEvy(_param2);
              num1 = -226225219;
              continue;
            case 20:
              ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.HDNxdeWoOjiaXBvFGhsPKgriHpFU += new Action<ControllerType, int>(ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.DhqXgtAofDqfBLXtWfyWqNMMdVn);
              ThreadSafeUnityInput.PostInitialize();
              num1 = -226225233;
              continue;
            case 21:
              if (ReInput.AqtwWiVqymVxpVGiJdNHneaNeEc != null)
              {
                ReInput.AqtwWiVqymVxpVGiJdNHneaNeEc.Invoke();
                num1 = -226225280;
                continue;
              }
              goto label_45;
            case 22:
              Logger.Log((object) "Rewired is running in Edit mode.");
              num1 = -226225228;
              continue;
            case 23:
              if (UnityTools.isEditor)
              {
                ReInput.CheckRewiredVersionCompatibility();
                num1 = -226225232;
                continue;
              }
              goto case 17;
            case 24:
              goto label_1;
            case 25:
              ReInput.omMZsBJMFhjqytvucXzSxfWOSPc = UnityTools.GetComponent<UserDataStore>((UnityEngine.Component) ReInput.ybGwqznbxFisdrSVioLpNYpJswe);
              num1 = -226225220;
              continue;
            case 26:
              UnityTools.externalTools.EditorPausedStateChangedEvent += new Action<bool>(ReInput.DpBgrCBOVnsqdzKHXnXNQSbdLMY);
              num1 = -226225239;
              continue;
            case 27:
              if (!UnityTools.isEditor)
              {
                num2 = 0;
                break;
              }
              num1 = -226225244;
              continue;
            case 28:
              ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.DeviceConnectedEvent += new Action<BridgedController>(ReInput.JpLReznPRZbGPxCSwBezwGZCLTn);
              ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.DeviceDisconnectedEvent += new Action<ControllerDisconnectedEventArgs>(ReInput.yvMSwKggHZNQvVRFiJOoGyftdao);
              ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.UpdateControllerInfoEvent += new Action<UpdateControllerInfoEventArgs>(ReInput.ySZsjykbxOEFWLTQHfnCrtcWoKN);
              num1 = -226225275;
              continue;
            case 29:
              int num4;
              num1 = num4 = !((UnityEngine.Object) ReInput.omMZsBJMFhjqytvucXzSxfWOSPc != (UnityEngine.Object) null) ? -226225231 : (num4 = -226225243);
              continue;
            case 30:
              Logger.logToScreen = true;
              num1 = -226225221;
              continue;
            case 31:
              ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ = _param4;
              _param4.CUjetGXyPfLfCEdKRehfcNPqsrzO();
              num1 = -226225240;
              continue;
            case 32:
              ReInput.kRcqGnVlcQgLIUphNiDODoYtEtG = new TimerAbs(1.0);
              ReInput.rCasTtxajaYfVqBdZjtydsSfKZag = new ReInput.McKOXtijWtxGreONISFgcvboteO();
              ReInput.tuFXbiPMzwuDJfBADzxiMFlARxc(_param1);
              ReInput.huPkcghnmfujhITXupfvuZzZnvX = new UtfAbpIKiaaLpNbHJCavACDFowSL(_param4.GetActions_Copy());
              num1 = -226225248;
              continue;
            case 33:
              goto label_49;
            case 34:
              int num5;
              num1 = num5 = !_param2.logToScreen ? -226225221 : (num5 = -226225217);
              continue;
            case 35:
              ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.Use();
              if (ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs != EditorPlatform.None)
              {
                ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.getValueDelegate = (Func<bool>) (() => ReInput.isUnityEditorFocused && ReInput.isAllowedEditorWindowFocused);
                int num6;
                num1 = num6 = ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR ? -226225229 : (num6 = -226225241);
                continue;
              }
              goto case 2;
            case 36:
              ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.DMPUsMUOqDMhwvexWJjiiqgcBXe += new Action<ControllerStatusChangedEventArgs>(ReInput.TITNtDYVnWkMkHywppIKLWzIqom);
              num1 = -226225227;
              continue;
            default:
              goto label_3;
          }
          ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR = num2 != 0;
          num1 = -226225226;
        }
label_49:
        return;
label_3:
        return;
label_45:;
      }
      catch (Exception ex)
      {
label_47:
        int num = -226225248;
        while (true)
        {
          switch (num ^ -226225247)
          {
            case 0:
              goto label_47;
            case 1:
              ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk = false;
              num = -226225245;
              continue;
            default:
              goto label_51;
          }
        }
label_51:
        ReInput.WiPECnHnOxmsPcNuMJYDEcGKoCr = false;
        throw ex;
      }
    }

    internal static void DhzrUtjzEYctgobTliSDENLZuMr()
    {
      if (ReInput.rCasTtxajaYfVqBdZjtydsSfKZag != null)
        ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.SVTOpiOtolNbUKyxKsuPYyfmPMI();
      else
        goto label_5;
label_2:
      int num1 = -2083315284;
label_3:
      int index;
      while (true)
      {
        switch (num1 ^ -2083315288)
        {
          case 0:
            goto label_2;
          case 1:
            int num2;
            num1 = num2 = index < ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.xAVGDhciVoLcMXCqZYDqEoUzddsC ? -2083315282 : (num2 = -2083315283);
            continue;
          case 2:
            num1 = -2083315287;
            continue;
          case 3:
            index = 0;
            num1 = -2083315286;
            continue;
          case 4:
            goto label_5;
          case 5:
            goto label_4;
          case 6:
            Joystick joystick = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx[index];
            ReInput.eOTnMgWQXqLnOacWZrmHSfdRjTc(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
            num1 = -2083315281;
            continue;
          case 7:
            ++index;
            num1 = -2083315287;
            continue;
          default:
            goto label_11;
        }
      }
label_4:
      return;
label_11:
      return;
label_5:
      num1 = !ReInput.configVars.deferControllerConnectedEventsOnStart ? -2083315283 : (num1 = -2083315285);
      goto label_3;
    }

    internal static void aJIxpPkiuhiLraMORlMaOboqMwL(UpdateLoopType _param0)
    {
      if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        goto label_8;
label_1:
      int num = 566259251;
label_2:
      UpdateLoopType updateLoopType;
      while (true)
      {
        switch (num ^ 566259249)
        {
          case 0:
            goto label_1;
          case 1:
label_4:
            ReInput.kdpIhNgTxajEFOczNeqrvSsuIZdK();
            num = 566259253;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_3;
          case 4:
            goto label_6;
          case 5:
            updateLoopType = _param0;
            num = 566259254;
            continue;
          case 6:
            goto label_8;
          case 7:
            switch (updateLoopType)
            {
              case UpdateLoopType.Update:
              case UpdateLoopType.FixedUpdate:
                goto label_4;
              default:
                num = 566259250;
                continue;
            }
          default:
            goto label_11;
        }
      }
label_5:
      return;
label_3:
      return;
label_6:
      return;
label_11:
      return;
label_8:
      ReInput.UThmrsxRiinbqmljdetzaIZhWdnv(_param0);
      num = 566259252;
      goto label_2;
    }

    private static void UThmrsxRiinbqmljdetzaIZhWdnv(UpdateLoopType _param0)
    {
      if (ReInput.hzCluKkRomMVpVMKggrQlnitdalC != null)
      {
label_1:
        int num = 483770997;
        while (true)
        {
          switch (num ^ 483770996)
          {
            case 1:
              ReInput.hzCluKkRomMVpVMKggrQlnitdalC.KNXyhGDrVuKEJRkqcCqdGgMBLPHj();
              num = 483770996;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
      }
label_4:
      Action<UpdateLoopType> inXrmiIzLoTqUojzG = ReInput.yudmTUZTllInXrmiIZLoTQUojzG;
      if (inXrmiIzLoTqUojzG != null)
      {
        try
        {
          inXrmiIzLoTqUojzG(_param0);
        }
        catch (Exception ex)
        {
          ReInput.HandleCallbackException("ReInput.BeforeTimeManagerUpdateEvent", ex);
        }
      }
      ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.KNXyhGDrVuKEJRkqcCqdGgMBLPHj(_param0);
    }

    private static void kdpIhNgTxajEFOczNeqrvSsuIZdK()
    {
      int frameCount = Time.frameCount;
      if (ReInput.zkuOzmnnSjrEgzvtJvHpGUVryen == frameCount)
        return;
label_5:
      ReInput.zkuOzmnnSjrEgzvtJvHpGUVryen = frameCount;
      ThreadSafeUnityInput.Update();
      int num = 799305257;
      Action rgwkSbNaQakcmnhoaPh;
      while (true)
      {
        switch (num ^ 799305259)
        {
          case 1:
            goto label_5;
          case 2:
            rgwkSbNaQakcmnhoaPh = ReInput.rEuALJCYsRGwkSBNaQakcmnhoaPH;
            num = 799305259;
            continue;
          case 3:
            num = 799305258;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      if (rgwkSbNaQakcmnhoaPh == null)
        return;
      try
      {
        rgwkSbNaQakcmnhoaPh();
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.EarlyUpdateEvent", ex);
      }
    }

    internal static void KNXyhGDrVuKEJRkqcCqdGgMBLPHj(UpdateLoopType _param0)
    {
      if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        goto label_13;
label_1:
      int num1 = 1037548141;
label_2:
      Action<UpdateLoopType> jyoipYmoBgEnlmMhLttx;
      while (true)
      {
        switch (num1 ^ 1037548136)
        {
          case 0:
            if (ReInput.BTHMlECYOOjCXwmylYgYiqAzSFM)
            {
              int num2;
              num1 = num2 = !ReInput.kRcqGnVlcQgLIUphNiDODoYtEtG.Update() ? 1037548130 : (num2 = 1037548131);
              continue;
            }
            goto case 9;
          case 1:
            int num3;
            num1 = num3 = ReInput.editorPlatform == EditorPlatform.None ? 1037548136 : (num3 = 1037548143);
            continue;
          case 2:
            goto label_13;
          case 4:
            ReInput.qwhJSUwslsGEuWRFFFjTTVqEPpZ = _param0;
            num1 = 1037548132;
            continue;
          case 5:
            goto label_14;
          case 6:
            goto label_23;
          case 7:
            ReInput.ZObkYhohlQJDrpyHiiLcaQpBBXl = ReInput.hzCluKkRomMVpVMKggrQlnitdalC.dlPqyxpBzmUbBcKFAAQaGseQiIe.value;
            num1 = 1037548136;
            continue;
          case 8:
            jyoipYmoBgEnlmMhLttx = ReInput.smvtLwcJYoipYmoBgEnlmMhLttx;
            num1 = 1037548139;
            continue;
          case 9:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.LKTtxsLFzTOMxsXNzHgBqpTGmuV();
            num1 = 1037548128;
            continue;
          case 10:
            ReInput.unityInputBuffer.KNXyhGDrVuKEJRkqcCqdGgMBLPHj(_param0);
            num1 = 1037548129;
            continue;
          case 11:
            ReInput.BTHMlECYOOjCXwmylYgYiqAzSFM = false;
            num1 = 1037548134;
            continue;
          case 12:
            int num4;
            num1 = num4 = ReInput.MbQjnmQWzuUcDwjjAaglJnQEDlq() ? 1037548137 : (num4 = 1037548142);
            continue;
          case 13:
            goto label_1;
          case 14:
            ReInput.kRcqGnVlcQgLIUphNiDODoYtEtG.Clear();
            num1 = 1037548129;
            continue;
          default:
            goto label_17;
        }
      }
label_14:
      return;
label_23:
      return;
label_17:
      if (jyoipYmoBgEnlmMhLttx != null)
      {
        try
        {
          jyoipYmoBgEnlmMhLttx(_param0);
        }
        catch (Exception ex)
        {
          ReInput.HandleCallbackException("ReInput.UpdateStartedEvent", ex);
        }
      }
      ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.Update(_param0);
label_21:
      int num5 = 1037548138;
      Action<UpdateLoopType> mqbzYxgOvsPupxDjZv;
      while (true)
      {
        switch (num5 ^ 1037548136)
        {
          case 1:
            ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.KNXyhGDrVuKEJRkqcCqdGgMBLPHj(_param0);
            mqbzYxgOvsPupxDjZv = ReInput.ostueppptMQBZYxgOVsPupxDjZV;
            num5 = 1037548136;
            continue;
          case 2:
            if (ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF != null)
            {
              ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF.Invoke();
              num5 = 1037548137;
              continue;
            }
            goto case 1;
          case 3:
            goto label_21;
          default:
            goto label_27;
        }
      }
label_27:
      if (mqbzYxgOvsPupxDjZv == null)
        return;
      try
      {
        mqbzYxgOvsPupxDjZv(_param0);
        return;
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.UpdateEndedEvent", ex);
        return;
      }
label_13:
      num1 = ReInput.qwhJSUwslsGEuWRFFFjTTVqEPpZ != _param0 ? 1037548140 : (num1 = 1037548132);
      goto label_2;
    }

    internal static void MQLNdlURKYShGtHuIdofKrAqvfhe()
    {
      Action xaclDdVxaUndZdAqvnB = ReInput.OIDJrIUJtXACLDdVXaUNdZdAqvnB;
      if (xaclDdVxaUndZdAqvnB == null)
        return;
      try
      {
        xaclDdVxaUndZdAqvnB();
      }
      catch (Exception ex)
      {
label_3:
        int num = 389499872;
        while (true)
        {
          switch (num ^ 389499873)
          {
            case 0:
              goto label_7;
            case 1:
              ReInput.HandleCallbackException("ReInput.LateUpdateEvent", ex);
              num = 389499873;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
    }

    [CustomObfuscation(rename = false)]
    internal static void EditorUpdate()
    {
      if (!ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        return;
      if (ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR)
        goto label_7;
label_2:
      int num = -1741192600;
label_3:
      while (true)
      {
        switch (num ^ -1741192598)
        {
          case 0:
            ReInput.MQLNdlURKYShGtHuIdofKrAqvfhe();
            num = -1741192597;
            continue;
          case 1:
            goto label_5;
          case 2:
            goto label_8;
          case 3:
            goto label_2;
          case 4:
            goto label_7;
          default:
            goto label_9;
        }
      }
label_5:
      return;
label_8:
      return;
label_9:
      return;
label_7:
      ReInput.aJIxpPkiuhiLraMORlMaOboqMwL(UpdateLoopType.Update);
      ReInput.KNXyhGDrVuKEJRkqcCqdGgMBLPHj(UpdateLoopType.Update);
      num = -1741192598;
      goto label_3;
    }

    internal static void qAlthHobUDcxmFxmdjJTlLmXAJwD()
    {
      if (ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP != null)
        ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP.Invoke();
      else
        goto label_5;
label_2:
      int num1 = 262176710;
label_3:
      while (true)
      {
        switch (num1 ^ 262176709)
        {
          case 0:
            goto label_2;
          case 1:
            ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.OnDestroy();
            num1 = 262176711;
            continue;
          case 2:
            ReInput.fDLDpKaObKJQDYnFPQyFEcehyDtr();
            int num2;
            num1 = num2 = ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ != null ? 262176705 : (num2 = 262176704);
            continue;
          case 3:
            goto label_5;
          case 4:
            ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ.Invoke();
            ReInput.exTFuxyVsWVvsRJZJlzolnWoHKJ = (SafeAction) null;
            num1 = 262176704;
            continue;
          case 5:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_4:
      return;
label_9:
      return;
label_5:
      num1 = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn == null ? 262176711 : (num1 = 262176708);
      goto label_3;
    }

    internal static void OfrhhxABqtYuXqjemyCcFiBncrZK()
    {
      if (ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj == null)
        return;
      ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj.Invoke();
    }

    internal static void OgOzoTaVNbBLWWUpgMHbcaQIkvo(bool _param0)
    {
      ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe = _param0;
      if (ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs == EditorPlatform.None)
        goto label_6;
label_1:
      int num = 532940072;
label_2:
      while (true)
      {
        switch (num ^ 532940077)
        {
          case 0:
            goto label_6;
          case 1:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.TriggerEvent();
            num = 532940079;
            continue;
          case 2:
            goto label_7;
          case 3:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.Set(_param0);
            num = 532940076;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_3;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_7:
      return;
label_4:
      return;
label_3:
      return;
label_9:
      return;
label_6:
      num = !ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk ? 532940073 : (num = 532940078);
      goto label_2;
    }

    internal static void INNAEoYLOmrOWwgqmHMRgTGVcHd()
    {
      if (!ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        return;
      Action qmacKjigBrysAkMx = ReInput.LwaNEROjLYkQmacKjigBRysAKMx;
      if (qmacKjigBrysAkMx == null)
        return;
      try
      {
        qmacKjigBrysAkMx();
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.SceneLoadedEvent", ex);
      }
    }

    [CustomObfuscation(rename = false)]
    internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(
      BridgedControllerHWInfo bridgedController)
    {
      return ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.lvOcWthNSnFIrJFfJkxSgebhQOBj(bridgedController);
    }

    internal static HardwareJoystickMap WgTJspeLOVcLidLnnGXnzhqyJEf(Guid _param0) => ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.GetHardwareJoystickMap(_param0);

    internal static HardwareJoystickTemplateMap QIHEwwIbuOrxiNrVoaKnMKDJcLE(
      Guid _param0)
    {
      return ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.GetJoystickTemplate(_param0);
    }

    internal static IHardwareControllerTemplateMap jEYdHShGxJmsErxaGjxNSqZXATVl(
      Guid _param0)
    {
      return ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.GetControllerTemplate(_param0);
    }

    internal static IList<HardwareJoystickTemplateMap> sujhVcAMjIJxMQvJAOrCLdaqDgfg(
      Guid _param0)
    {
      HardwareJoystickMap hardwareJoystickMap = ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.GetHardwareJoystickMap(_param0);
label_1:
      int num1 = 214559211;
      string[] templateGuidsOrig;
      List<HardwareJoystickTemplateMap> joystickTemplateMapList;
      int index;
      while (true)
      {
        switch (num1 ^ 214559210)
        {
          case 0:
            goto label_1;
          case 1:
            if ((UnityEngine.Object) hardwareJoystickMap == (UnityEngine.Object) null)
            {
              num1 = 214559213;
              continue;
            }
            templateGuidsOrig = hardwareJoystickMap.GetTemplateGuidsOrig();
            num1 = 214559208;
            continue;
          case 2:
            int num2;
            num1 = num2 = templateGuidsOrig != null ? 214559212 : (num2 = 214559215);
            continue;
          case 3:
            index = 0;
            num1 = 214559214;
            continue;
          case 5:
            goto label_7;
          case 6:
            if (templateGuidsOrig.Length != 0)
            {
              joystickTemplateMapList = (List<HardwareJoystickTemplateMap>) null;
              num1 = 214559209;
              continue;
            }
            num1 = 214559215;
            continue;
          case 7:
            goto label_5;
          default:
            goto label_26;
        }
      }
label_5:
      return EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
label_7:
      return EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
label_26:
      while (index < templateGuidsOrig.Length)
      {
        Guid guid;
        try
        {
          guid = new Guid(templateGuidsOrig[index]);
        }
        catch
        {
label_15:
          int num3 = 214559211;
          while (true)
          {
            switch (num3 ^ 214559210)
            {
              case 0:
                goto label_15;
              case 1:
                Logger.LogWarning((object) ("Controller Template GUID is invalid: " + templateGuidsOrig[index]));
                num3 = 214559208;
                continue;
              default:
                goto label_22;
            }
          }
        }
        HardwareJoystickTemplateMap joystickTemplateMap = ReInput.QIHEwwIbuOrxiNrVoaKnMKDJcLE(guid);
        if (!((UnityEngine.Object) joystickTemplateMap == (UnityEngine.Object) null))
          goto label_25;
label_19:
        int num4 = 214559211;
label_20:
        while (true)
        {
          switch (num4 ^ 214559210)
          {
            case 0:
              goto label_22;
            case 1:
              Logger.LogWarning((object) ("Controller Template was not found for GUID " + guid.ToString()));
              num4 = 214559210;
              continue;
            case 2:
              goto label_19;
            case 3:
              joystickTemplateMapList = new List<HardwareJoystickTemplateMap>();
              num4 = 214559214;
              continue;
            case 4:
              ListTools.AddIfUnique<HardwareJoystickTemplateMap>((IList<HardwareJoystickTemplateMap>) joystickTemplateMapList, joystickTemplateMap);
              num4 = 214559210;
              continue;
            case 5:
              goto label_25;
            default:
              goto label_26;
          }
        }
label_22:
        ++index;
        num4 = 214559212;
        goto label_20;
label_25:
        num4 = joystickTemplateMapList != null ? 214559214 : (num4 = 214559209);
        goto label_20;
      }
      return (IList<HardwareJoystickTemplateMap>) joystickTemplateMapList ?? EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
    }

    [CustomObfuscation(rename = false)]
    internal static int GetNewJoystickId() => ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.OwmchVHRuvAonZuDhUQugharYz();

    [CustomObfuscation(rename = false)]
    internal static void HandleCallbackException(string source, Exception exception)
    {
      object[] objArray = new object[4]
      {
        (object) "An exception occurred inside an event handler or callback.\nSource: ",
        null,
        null,
        null
      };
label_1:
      int num = -926452019;
      string str;
      while (true)
      {
        switch (num ^ -926452023)
        {
          case 0:
            goto label_3;
          case 1:
            objArray[3] = exception.InnerException != null ? (object) exception.InnerException : (object) exception;
            num = -926452020;
            continue;
          case 2:
            Logger.LogError((object) str, true);
            num = -926452023;
            continue;
          case 3:
            goto label_1;
          case 4:
            objArray[1] = (object) source;
            objArray[2] = (object) "\n\nThis happens if your event handler/callback code throws an exception. This means the error in your code, not Rewired. Read the exception message and the stack trace carefully to find the source of the exception being thrown by your code.\n\nThis can also happen if you forget to unsubscribe to an event in a MonoBehaviour class and that object gets destroyed. Make sure you unsubscribe to events in OnDisable or OnDestroy. Rewired will attempt to continue running.\n\nException:\n";
            num = -926452024;
            continue;
          case 5:
            str = string.Concat(objArray);
            num = -926452021;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    [CustomObfuscation(rename = false)]
    internal static void HandleExternException(string source, Exception exception)
    {
    }

    [CustomObfuscation(rename = false)]
    internal static void HandleExternalInterfaceException(string source, Exception exception)
    {
      object[] objArray = new object[4];
label_1:
      int num = -518654134;
      string str;
      while (true)
      {
        switch (num ^ -518654135)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            str = string.Concat(objArray);
            num = -518654131;
            continue;
          case 3:
            objArray[0] = (object) "An exception occurred inside an external function call.\nSource: ";
            objArray[1] = (object) source;
            objArray[2] = (object) "\n\nThis happens if the external function throws an exception. This could indicate the error is in your code if Rewired is calling a function in an interface implementation you created. Read the exception message and the stack trace carefully to find the source of the exception being thrown.\n\nThis can also happen if you forget to unsubscribe to an event in a MonoBehaviour class and that object gets destroyed.\n\nException:\n";
            objArray[3] = exception.InnerException != null ? (object) exception.InnerException : (object) exception;
            num = -518654133;
            continue;
          case 4:
            Logger.LogError((object) str, true);
            num = -518654136;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    internal static void ZTcPuaxHgmLKXAGFHpGZrrRBFrh()
    {
      if (!ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        return;
      ReInput.PhrSTCaiexVCPzKwyppNAQnGOJa();
    }

    [CustomObfuscation(rename = false)]
    internal static void CheckRewiredVersionCompatibility()
    {
      if (!(UnityTools.unityVersionObj != (UnityTools.UnityVersionClass) null))
        return;
label_1:
      int num = 310421855;
      while (true)
      {
        switch (num ^ 310421854)
        {
          case 0:
            goto label_6;
          case 1:
            if (2020 != UnityTools.unityVersionObj.major)
            {
              ReInput.WNHdFBGooXleZylvhAGzJaITgsbC();
              num = 310421854;
              continue;
            }
            goto label_7;
          case 2:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_6:
      return;
label_8:
      return;
label_7:;
    }

    internal static float gIyLZjMrMJqcQLnfjtxUhKSpoHP() => ReInput.hzCluKkRomMVpVMKggrQlnitdalC.VjUgXgHDKGTDNqcWNEfnYglSqrnZ.value;

    [CustomObfuscation(rename = false)]
    internal static bool CheckInitialized()
    {
      if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        return true;
      Logger.LogError((object) "Rewired is not initialized. You must have an active and enabled Rewired Input Manager in the scene before calling any part of the Rewired API.");
      return false;
    }

    [CustomObfuscation(rename = false)]
    internal static bool CheckInitialized(int reInputId)
    {
      if (ReInput.CheckInitialized())
        goto label_4;
label_1:
      int num = 1695494629;
label_2:
      while (true)
      {
        switch (num ^ 1695494628)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            Logger.LogError((object) "You are attemping to access an object that was created by a previous session or different instance of Rewired and is no longer valid. When Rewired is reset or the Rewired Input Manager is disabled or destroyed, all old object references become invalid and can no longer be used. If you deinitialize Rewired, you cannot use locally stored Rewired objects obtained prior to deinitialization and you must get new objects from the Rewired API.");
            num = 1695494631;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return false;
label_7:
      return false;
label_4:
      if (ReInput._id == reInputId)
        return true;
      num = 1695494630;
      goto label_2;
    }

    private static void GvzBpPUzfnXAFfMlFQoGVqiYZcc()
    {
      ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.CUjetGXyPfLfCEdKRehfcNPqsrzO();
label_1:
      int num = 1444973599;
      while (true)
      {
        switch (num ^ 1444973597)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.CUjetGXyPfLfCEdKRehfcNPqsrzO(ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.GetInputDataUpdateDelegate(), ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetInputBehaviors_Copy());
            ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.Initialize();
            num = 1444973596;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private static void fDLDpKaObKJQDYnFPQyFEcehyDtr()
    {
      if (!((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null))
        goto label_28;
label_1:
      int num1 = -1782072553;
label_2:
      List<IExternalInputManager> inSelfAndChildren;
      int index;
      while (true)
      {
        switch (num1 ^ -1782072563)
        {
          case 0:
            inSelfAndChildren[index].Deinitialize();
            num1 = -1782072575;
            continue;
          case 1:
            ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn = (OSEvqAzfRRImIajEgswFeFeuEnmj) null;
            num1 = -1782072565;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num2;
            num1 = num2 = index < inSelfAndChildren.Count ? -1782072563 : (num2 = -1782072556);
            continue;
          case 4:
            ReInput.DKWMqVtyubBkajFNQwELCcOaGRz = Rewired.Platforms.Platform.Windows;
            num1 = -1782072547;
            continue;
          case 5:
            ReInput.gRrcKGVMfkbVjAUgyrYMmLXbcFDj.Clear();
            ReInput._ApplicationFocusChangedEvent = (Action<bool>) null;
            num1 = -1782072560;
            continue;
          case 6:
            ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT = (oUFRYxhuYStPPSPmghvjLnFxEvy) null;
            ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje = (ControllerDataFiles) null;
            num1 = -1782072549;
            continue;
          case 7:
            ReInput.nnZuWiAyLnHIBmqNTqiaYbkOVfR = false;
            ReInput.NeVIVssqMdfHIbMJqDMisOqHDTHe = true;
            num1 = -1782072558;
            continue;
          case 8:
            goto label_3;
          case 9:
            ReInput.smvtLwcJYoipYmoBgEnlmMhLttx = (Action<UpdateLoopType>) null;
            ReInput.ostueppptMQBZYxgOVsPupxDjZV = (Action<UpdateLoopType>) null;
            num1 = -1782072545;
            continue;
          case 10:
            ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb = false;
            num1 = -1782072567;
            continue;
          case 11:
            ReInput.lKyyhRCiajyuusLvAXuPKKqhlzY = (Action<FullScreenMode>) null;
            ReInput.vcOBHdeOXQlxDhZuZJbFQkCFRg = (Action<bool>) null;
            num1 = -1782072574;
            continue;
          case 12:
            ++index;
            num1 = -1782072562;
            continue;
          case 13:
            ReInput.LwaNEROjLYkQmacKjigBRysAKMx = (Action) null;
            num1 = -1782072529;
            continue;
          case 14:
            ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
            num1 = -1782072554;
            continue;
          case 15:
            ReInput.rEuALJCYsRGwkSBNaQakcmnhoaPH = (Action) null;
            num1 = -1782072572;
            continue;
          case 16:
            ReInput.rasyllrPLaVEYcDsvWnIplsRbLX = WebplayerPlatform.None;
            num1 = -1782072552;
            continue;
          case 17:
            ReInput._id = -1;
            ReInput.hacAZRuwjcjAyppzQtuprQiTjiN = 0;
            ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg.Clear();
            ReInput.injKMJwLZRYPDmsKVBkpvIakuCN.Clear();
            num1 = -1782072555;
            continue;
          case 18:
            ReInput.OIDJrIUJtXACLDdVXaUNdZdAqvnB = (Action) null;
            num1 = -1782072550;
            continue;
          case 19:
            if (ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn != null)
            {
              ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.Dispose();
              num1 = -1782072564;
              continue;
            }
            goto case 1;
          case 20:
            ThreadSafeUnityInput.Deinitialize();
            if (UnityTools.externalTools != null)
            {
              UnityTools.externalTools.EditorPausedStateChangedEvent -= new Action<bool>(ReInput.DpBgrCBOVnsqdzKHXnXNQSbdLMY);
              num1 = -1782072571;
              continue;
            }
            goto label_39;
          case 21:
            ReInput.TrhehmkLiyqWIcOWLVQBXtFrAeVs = EditorPlatform.None;
            num1 = -1782072531;
            continue;
          case 22:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ = (UserData) null;
            ReInput.rHXofzgXUQMoEEeXKGkqpijNFQI = (IControllerAssigner) null;
            ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk = false;
            ReInput.bVKkeJIbKbigPklBsshxgxpMgxT = (ConfigVars) null;
            ReInput.qwhJSUwslsGEuWRFFFjTTVqEPpZ = UpdateLoopType.Update;
            num1 = -1782072569;
            continue;
          case 23:
            ReInput.iagFLpAUXxiaVisDjSyeOhqVFHuP = (SafeAction) null;
            num1 = -1782072576;
            continue;
          case 24:
            ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg.Clear();
            ReInput.gfjGGHeupXeEeCzlazaBgdJhhTF.Clear();
            num1 = -1782072568;
            continue;
          case 25:
            goto label_28;
          case 26:
            inSelfAndChildren = UnityTools.GetComponentsInSelfAndChildren<IExternalInputManager>((UnityEngine.Component) ReInput.ybGwqznbxFisdrSVioLpNYpJswe);
            index = 0;
            num1 = -1782072562;
            continue;
          case 27:
            ReInput.huPkcghnmfujhITXupfvuZzZnvX = (UtfAbpIKiaaLpNbHJCavACDFowSL) null;
            num1 = -1782072546;
            continue;
          case 28:
            ReInput.ZObkYhohlQJDrpyHiiLcaQpBBXl = (string) null;
            num1 = -1782072532;
            continue;
          case 29:
            ReInput.DTUpHJtKtyPGnDYNnPmJNxCsBbp = (Action<bool>) null;
            ReInput.oVkdLoDQJznYunWvAxTElPCSGiy = (Action<bool>) null;
            num1 = -1782072570;
            continue;
          case 30:
            ReInput.kRcqGnVlcQgLIUphNiDODoYtEtG = (TimerAbs) null;
            ReInput.rCasTtxajaYfVqBdZjtydsSfKZag = (ReInput.McKOXtijWtxGreONISFgcvboteO) null;
            num1 = -1782072559;
            continue;
          case 31:
            ReInput.zkuOzmnnSjrEgzvtJvHpGUVryen = -1;
            num1 = -1782072548;
            continue;
          case 32:
            ReInput.BTHMlECYOOjCXwmylYgYiqAzSFM = false;
            num1 = -1782072557;
            continue;
          case 33:
            ReInput.gQSCsulqVehPHYubeQCKRnoblJC = false;
            num1 = -1782072566;
            continue;
          case 34:
            ReInput.aoIOjUMoGVjlQQuFnhlLmqiUCoWa = (Action<bool>) null;
            ReInput.dWAQyFhuGLwrTTzLeUgEMDmJbxv();
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC = (ReInput.turGXwBvHWoRGEzdiNffQHtjLxUE) null;
            num1 = -1782072551;
            continue;
          default:
            goto label_40;
        }
      }
label_3:
      return;
label_40:
      return;
label_39:
      return;
label_28:
      ReInput.ybGwqznbxFisdrSVioLpNYpJswe = (InputManager_Base) null;
      num1 = -1782072573;
      goto label_2;
    }

    private static void fnAbUrajOtQfvEFdeCGLXPkEWpfA(string _param0 = null)
    {
      if (_param0 == null)
        goto label_5;
label_1:
      int num = 1616982547;
label_2:
      string str;
      while (true)
      {
        switch (num ^ 1616982545)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            str = _param0;
            num = 1616982549;
            continue;
          case 3:
            goto label_5;
          case 4:
            Logger.LogError((object) (str + " can only be called in Play mode!"));
            num = 1616982544;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_5:
      str = "This function";
      num = 1616982549;
      goto label_2;
    }

    private static void KbAWJExdjvbycHAQVaOPCCFbdcGG()
    {
      if (!ReInput.BTHMlECYOOjCXwmylYgYiqAzSFM)
      {
label_1:
        int num = 1265521086;
        while (true)
        {
          switch (num ^ 1265521084)
          {
            case 0:
              goto label_1;
            case 2:
              ReInput.BTHMlECYOOjCXwmylYgYiqAzSFM = true;
              ReInput.unityInputBuffer.zVrLJSgSbkirDaUFhFiHaLCUQro();
              num = 1265521087;
              continue;
            case 3:
              ReInput.unityInputBuffer.ZpOjMaGNdPRgnJDBgQkXnUZBuFs();
              num = 1265521085;
              continue;
            default:
              goto label_5;
          }
        }
      }
label_5:
      ReInput.kRcqGnVlcQgLIUphNiDODoYtEtG.Start();
    }

    private static void aPgcgNcZfCkhELamqDBySBgmdTgI() => Logger.LogError((object) "Rewired is not initialized. Do you have a Rewired Input Manager in the scene and enabled?");

    private static void JpLReznPRZbGPxCSwBezwGZCLTn(BridgedController _param0)
    {
      if (_param0.sourceJoystick == null)
        return;
label_7:
      ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.SDTGmOOGDPGQYKKRVhonFIEszGK(_param0);
      int num1 = 895335626;
      Joystick joystick;
      while (true)
      {
        switch (num1 ^ 895335626)
        {
          case 0:
            joystick = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.JMbbzpNIbCJfWBuFXdrGKwigBcS(_param0.sourceJoystick.rewiredId);
            num1 = 895335624;
            continue;
          case 2:
            if (joystick != null)
              goto case 4;
            else
              goto label_9;
          case 3:
            num1 = 895335631;
            continue;
          case 4:
            ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.IBjRWHvuVpqlQrnJIPRDHwlyHLA(joystick);
            int num2;
            num1 = num2 = !ReInput.configVars.deferControllerConnectedEventsOnStart ? 895335627 : (num2 = 895335628);
            continue;
          case 5:
            goto label_7;
          case 6:
            goto label_8;
          default:
            goto label_11;
        }
      }
label_8:
      if (ReInput.WiPECnHnOxmsPcNuMJYDEcGKoCr)
        return;
      goto label_11;
label_9:
      return;
label_11:
      ReInput.eOTnMgWQXqLnOacWZrmHSfdRjTc(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
    }

    private static void yvMSwKggHZNQvVRFiJOoGyftdao(ControllerDisconnectedEventArgs _param0)
    {
      if (_param0 == null)
        return;
label_5:
      Joystick joystick = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.JMbbzpNIbCJfWBuFXdrGKwigBcS(_param0.rewiredId);
      int num = -1104508824;
      while (true)
      {
        switch (num ^ -1104508823)
        {
          case 0:
            ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ywuEUTqtanhsDxepfCRZhdCLMQky(_param0.rewiredId);
            ReInput.IPeCSgofyDFOujKQiNFMwCyzJmKU(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
            num = -1104508821;
            continue;
          case 1:
            if (joystick != null)
              goto case 0;
            else
              goto label_1;
          case 2:
            goto label_8;
          case 3:
            num = -1104508819;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:
      return;
label_1:;
    }

    private static void eOTnMgWQXqLnOacWZrmHSfdRjTc(ControllerStatusChangedEventArgs _param0)
    {
      if (ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg == null)
        return;
label_1:
      int num = -495062612;
      while (true)
      {
        switch (num ^ -495062611)
        {
          case 0:
            goto label_5;
          case 1:
            ReInput.FktuBhmKTiGpvFCvSHIqwMSHhvpg.Invoke(_param0);
            num = -495062611;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private static void TITNtDYVnWkMkHywppIKLWzIqom(ControllerStatusChangedEventArgs _param0)
    {
      if (ReInput.injKMJwLZRYPDmsKVBkpvIakuCN == null)
        return;
label_1:
      int num = 742194621;
      while (true)
      {
        switch (num ^ 742194623)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            ReInput.injKMJwLZRYPDmsKVBkpvIakuCN.Invoke(_param0);
            num = 742194622;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private static void IPeCSgofyDFOujKQiNFMwCyzJmKU(ControllerStatusChangedEventArgs _param0)
    {
      if (ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg == null)
        return;
label_1:
      int num = 1695332786;
      while (true)
      {
        switch (num ^ 1695332784)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            ReInput.uespMfZgrZnnwqIICaXQFmfDCcXg.Invoke(_param0);
            num = 1695332785;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private static void ySZsjykbxOEFWLTQHfnCrtcWoKN(UpdateControllerInfoEventArgs _param0) => ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.EkOyBfNdsbyzOocdCErmRjtnENTC(_param0);

    private static void KhkGSjFicDrduFfZGuNfOWqjDmyD(bool _param0)
    {
      if (ReInput.HVKvGYoFyXXfhvoqnuhqBplpKEk)
        goto label_5;
label_1:
      int num1 = -1842000594;
label_2:
      Action<bool> focusChangedEvent;
      switch (num1 ^ -1842000593)
      {
        case 0:
          goto label_1;
        case 1:
          return;
        case 3:
          break;
        default:
          if (focusChangedEvent == null)
            return;
          try
          {
            focusChangedEvent(_param0);
            return;
          }
          catch (Exception ex)
          {
label_9:
            int num2 = -1842000594;
            while (true)
            {
              switch (num2 ^ -1842000593)
              {
                case 0:
                  goto label_9;
                case 1:
                  ReInput.HandleCallbackException("ReInput.ApplicationFocusChangedEvent", ex);
                  num2 = -1842000595;
                  continue;
                case 2:
                  goto label_3;
                default:
                  goto label_13;
              }
            }
label_3:
            return;
label_13:
            return;
          }
      }
label_5:
      focusChangedEvent = ReInput._ApplicationFocusChangedEvent;
      num1 = -1842000595;
      goto label_2;
    }

    private static void FtYCGaoCGJfoRKuWGjsnrUqSFyv(bool _param0)
    {
      Action<bool> pgnDyNnPmJnxCsBbp = ReInput.DTUpHJtKtyPGnDYNnPmJNxCsBbp;
      if (pgnDyNnPmJnxCsBbp == null)
        return;
      try
      {
        pgnDyNnPmJnxCsBbp(_param0);
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.ApplicationIsFullScreenChangedEvent", ex);
      }
    }

    private static void DWkFGpdFlrnJnViqqOLOHkqXCxeE(int _param0)
    {
      if (ReInput.lKyyhRCiajyuusLvAXuPKKqhlzY == null)
        return;
      try
      {
        ReInput.lKyyhRCiajyuusLvAXuPKKqhlzY((FullScreenMode) _param0);
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.ApplicationFullScreenModeChangedEvent", ex);
      }
    }

    private static void JdLQIYRShxFYwofAhYayTgZXcnA(bool _param0)
    {
      Action<bool> yunWvAxTelPcsGiy = ReInput.oVkdLoDQJznYunWvAxTElPCSGiy;
      if (yunWvAxTelPcsGiy == null)
        return;
      try
      {
        yunWvAxTelPcsGiy(_param0);
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.ApplicationRunInBackgroundChangedEvent", ex);
      }
    }

    private static void zNSenLIoGteyUcRdgQIeuVeHHcdv(bool _param0)
    {
      ++ReInput.hacAZRuwjcjAyppzQtuprQiTjiN;
      Action<bool> qlxDhZuZjbFqkCfRg = ReInput.vcOBHdeOXQlxDhZuZJbFQkCFRg;
      if (qlxDhZuZjbFqkCfRg == null)
        return;
      try
      {
        qlxDhZuZjbFqkCfRg(_param0);
      }
      catch (Exception ex)
      {
label_3:
        int num = 873952423;
        while (true)
        {
          switch (num ^ 873952422)
          {
            case 0:
              goto label_3;
            case 1:
              ReInput.HandleCallbackException("ReInput.TimeScalePauseChangedEvent", ex);
              num = 873952420;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
    }

    private static void uGGCMATxPHAhNVyQgoNkyCtCpOl()
    {
      if (ReInput.hzCluKkRomMVpVMKggrQlnitdalC != null)
        goto label_7;
label_1:
      int num = -2042519925;
label_2:
      while (true)
      {
        switch (num ^ -2042519927)
        {
          case 0:
            goto label_1;
          case 1:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.xvFOSywVLenNnSMFVdzEYKETiTEG.ChangedEvent += new Action<bool>(ReInput.FtYCGaoCGJfoRKuWGjsnrUqSFyv);
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.YXvGkrWuFDzIDXbWAMtPnseRiuf.ChangedEvent += new Action<bool>(ReInput.JdLQIYRShxFYwofAhYayTgZXcnA);
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.KCFTJnjhinqIBbpvCUxCXzMFIKf.ChangedEvent += new Action<int>(ReInput.DWkFGpdFlrnJnViqqOLOHkqXCxeE);
            num = -2042519926;
            continue;
          case 2:
            goto label_3;
          case 3:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.BbyRoBsowyQmdHmWWxWCZqxtDV.ChangedEvent += new Action<bool>(ReInput.zNSenLIoGteyUcRdgQIeuVeHHcdv);
            num = -2042519923;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_7;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_4:
      return;
label_8:
      return;
label_7:
      ReInput.dWAQyFhuGLwrTTzLeUgEMDmJbxv();
      ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.ChangedEvent += new Action<bool>(ReInput.KhkGSjFicDrduFfZGuNfOWqjDmyD);
      num = -2042519928;
      goto label_2;
    }

    private static void dWAQyFhuGLwrTTzLeUgEMDmJbxv()
    {
      if (ReInput.hzCluKkRomMVpVMKggrQlnitdalC != null)
        goto label_5;
label_1:
      int num = 1401761865;
label_2:
      while (true)
      {
        switch (num ^ 1401761864)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ReInput.hzCluKkRomMVpVMKggrQlnitdalC.YXvGkrWuFDzIDXbWAMtPnseRiuf.ChangedEvent -= new Action<bool>(ReInput.JdLQIYRShxFYwofAhYayTgZXcnA);
            num = 1401761867;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      ReInput.hzCluKkRomMVpVMKggrQlnitdalC.KCFTJnjhinqIBbpvCUxCXzMFIKf.ChangedEvent -= new Action<int>(ReInput.DWkFGpdFlrnJnViqqOLOHkqXCxeE);
      ReInput.hzCluKkRomMVpVMKggrQlnitdalC.BbyRoBsowyQmdHmWWxWCZqxtDV.ChangedEvent -= new Action<bool>(ReInput.zNSenLIoGteyUcRdgQIeuVeHHcdv);
      return;
label_5:
      ReInput.hzCluKkRomMVpVMKggrQlnitdalC.zdfWFvFuJmKLPOOzDKWHpXcTGhm.ChangedEvent -= new Action<bool>(ReInput.KhkGSjFicDrduFfZGuNfOWqjDmyD);
      ReInput.hzCluKkRomMVpVMKggrQlnitdalC.xvFOSywVLenNnSMFVdzEYKETiTEG.ChangedEvent -= new Action<bool>(ReInput.FtYCGaoCGJfoRKuWGjsnrUqSFyv);
      num = 1401761866;
      goto label_2;
    }

    private static void DpBgrCBOVnsqdzKHXnXNQSbdLMY(bool _param0)
    {
      Action<bool> qquFnhlLmqiUcoWa = ReInput.aoIOjUMoGVjlQQuFnhlLmqiUCoWa;
      if (qquFnhlLmqiUcoWa == null)
        return;
      try
      {
        qquFnhlLmqiUcoWa(_param0);
      }
      catch (Exception ex)
      {
        ReInput.HandleCallbackException("ReInput.EditorPauseChangedEvent", ex);
      }
    }

    private static void tuFXbiPMzwuDJfBADzxiMFlARxc(Func<ConfigVars, object> _param0)
    {
      bool flag = ReInput.configVars.DoesPlatformUseFallback(UnityTools.platform, UnityTools.webplayerPlatform, ReInput.isEditor);
      if (flag)
        goto label_4;
label_1:
      int num1 = -811290298;
label_2:
      int index;
      List<IExternalInputManager> inSelfAndChildren;
      while (true)
      {
        switch (num1 ^ -811290304)
        {
          case 0:
            goto label_4;
          case 1:
            index = 0;
            num1 = -811290302;
            continue;
          case 2:
            int num2;
            num1 = num2 = index >= inSelfAndChildren.Count ? -811290304 : (num2 = -811290295);
            continue;
          case 3:
            goto label_113;
          case 4:
            goto label_116;
          case 5:
            goto label_1;
          case 6:
            inSelfAndChildren = UnityTools.GetComponentsInSelfAndChildren<IExternalInputManager>((UnityEngine.Component) ReInput.ybGwqznbxFisdrSVioLpNYpJswe);
            num1 = -811290303;
            continue;
          case 7:
            ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb = true;
            ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new gtAKSPJfXtBplIcEwBDHeJaSbNAM(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop);
            num1 = -811290301;
            continue;
          case 8:
            ++index;
            num1 = -811290302;
            continue;
          case 9:
            if (inSelfAndChildren[index].Initialize(UnityTools.platform, (object) ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) is PlatformInputManager platformInputManager)
            {
              ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = platformInputManager;
              num1 = -811290300;
              continue;
            }
            goto case 8;
          default:
            goto label_12;
        }
      }
label_116:
      return;
label_12:
      if (ReInput.configVars.DoesPlatformUseSDL2(UnityTools.platform, UnityTools.webplayerPlatform, ReInput.isEditor))
      {
        try
        {
          ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new JTdFiFyEjOcBjLXMeeLNKgbPpDab(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT, new Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>(ReInput.GetHardwareJoystickMap_InputManager), new Func<int>(ReInput.GetNewJoystickId), true, false, false);
label_14:
          switch (-811290302 ^ -811290304)
          {
            case 0:
              goto label_14;
            case 2:
              if (ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn == null)
                throw new Exception();
              break;
          }
        }
        catch
        {
label_18:
          int num3 = -811290302;
          while (true)
          {
            switch (num3 ^ -811290304)
            {
              case 0:
                goto label_18;
              case 2:
                Logger.LogError((object) "SDL2 could not be initialized! Make sure you have the SDL2 library installed. Please see the documentation for more information. Rewired will fall back to Unity input. Certain features may not be available.");
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                num3 = -811290303;
                continue;
              default:
                goto label_113;
            }
          }
        }
      }
      else
      {
        if (UnityTools.platform != Rewired.Platforms.Platform.Windows && UnityTools.platform != Rewired.Platforms.Platform.WindowsAppStore)
        {
label_22:
          int num3 = -811290300;
          while (true)
          {
            switch (num3 ^ -811290304)
            {
              case 1:
                if (UnityTools.platform == Rewired.Platforms.Platform.WebGL)
                {
                  num3 = -811290304;
                  continue;
                }
                goto label_42;
              case 2:
                goto label_31;
              case 3:
                goto label_22;
              case 4:
                int num4;
                switch (UnityTools.platform)
                {
                  case Rewired.Platforms.Platform.OSX:
                    num4 = -811290302;
                    break;
                  case Rewired.Platforms.Platform.WindowsUWP:
                    goto label_31;
                  default:
                    num4 = num4 = -811290299;
                    break;
                }
                num3 = num4;
                continue;
              case 5:
                int num5;
                num3 = num5 = UnityTools.platform != Rewired.Platforms.Platform.Linux ? -811290303 : (num5 = -811290302);
                continue;
              default:
                goto label_32;
            }
          }
label_32:
          if (!ReInput.isEditor)
          {
            try
            {
              ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = _param0(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) as PlatformInputManager;
label_34:
              int num6 = -811290303;
              while (true)
              {
                switch (num6 ^ -811290304)
                {
                  case 1:
                    int num7;
                    num6 = num7 = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn == null ? -811290302 : (num7 = -811290304);
                    continue;
                  case 2:
                    goto label_37;
                  case 3:
                    goto label_34;
                  default:
                    goto label_113;
                }
              }
label_37:
              throw new Exception();
            }
            catch
            {
              Logger.LogError((object) "WebGL platform could not be initialized! Is the Rewired WebGL library installed? See the documentation for more information.");
label_39:
              int num6 = -811290303;
              while (true)
              {
                switch (num6 ^ -811290304)
                {
                  case 1:
                    ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                    num6 = -811290304;
                    continue;
                  case 2:
                    goto label_39;
                  default:
                    goto label_113;
                }
              }
            }
          }
label_42:
          if (UnityTools.platform == Rewired.Platforms.Platform.XboxOne)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                XboxOneInputSource xboxOneInputSource = new XboxOneInputSource();
label_45:
                switch (-811290302 ^ -811290304)
                {
                  case 0:
                    goto label_45;
                  case 2:
                    ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new CustomInputManager((CustomInputSource) xboxOneInputSource, ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop, new Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>(ReInput.GetHardwareJoystickMap_InputManager), new Func<int>(ReInput.GetNewJoystickId));
                    if (ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn == null)
                      throw new Exception();
                    goto label_113;
                  default:
                    goto label_113;
                }
              }
              catch
              {
label_49:
                int num6 = -811290303;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 1:
                      Logger.LogError((object) "Xbox One platform could not be initialized! Is the Rewired Xbox One library installed? See the documentation for more information.");
                      num6 = -811290301;
                      continue;
                    case 2:
                      goto label_49;
                    case 3:
                      ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                      num6 = -811290304;
                      continue;
                    default:
                      goto label_113;
                  }
                }
              }
            }
          }
          if (UnityTools.platform == Rewired.Platforms.Platform.PS4)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new CustomInputManager((CustomInputSource) new PS4InputSource(), ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop, new Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>(ReInput.GetHardwareJoystickMap_InputManager), new Func<int>(ReInput.GetNewJoystickId));
label_56:
                int num6 = -811290303;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      goto label_56;
                    case 1:
                      int num7;
                      num6 = num7 = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn != null ? -811290302 : (num7 = -811290301);
                      continue;
                    case 3:
                      goto label_59;
                    default:
                      goto label_113;
                  }
                }
label_59:
                throw new Exception();
              }
              catch
              {
                Logger.LogError((object) "PS4 platform could not be initialized!");
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                goto label_113;
              }
            }
          }
          if (UnityTools.platform == Rewired.Platforms.Platform.Stadia)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = _param0(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) as PlatformInputManager;
label_64:
                int num6 = -811290303;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      goto label_64;
                    case 1:
                      int num7;
                      num6 = num7 = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn != null ? -811290301 : (num7 = -811290302);
                      continue;
                    case 2:
                      goto label_67;
                    default:
                      goto label_113;
                  }
                }
label_67:
                throw new Exception("Input Manager was null.");
              }
              catch (Exception ex)
              {
label_69:
                int num6 = -811290303;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      Logger.LogError((object) ex);
                      num6 = -811290301;
                      continue;
                    case 1:
                      Logger.LogError((object) "Stadia platform could not be initialized! Is the Rewired Stadia library installed? See the documentation for more information.");
                      num6 = -811290304;
                      continue;
                    case 2:
                      goto label_69;
                    default:
                      goto label_73;
                  }
                }
label_73:
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                goto label_113;
              }
            }
          }
          if (UnityTools.platform == Rewired.Platforms.Platform.GameCoreXboxOne || UnityTools.platform == Rewired.Platforms.Platform.GameCoreScarlett)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = _param0(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) as PlatformInputManager;
label_77:
                switch (-811290303 ^ -811290304)
                {
                  case 1:
                    if (ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn == null)
                      throw new Exception("Input Manager was null.");
                    goto label_113;
                  case 2:
                    goto label_77;
                  default:
                    goto label_113;
                }
              }
              catch (Exception ex)
              {
label_81:
                int num6 = -811290303;
                while (true)
                {
                  string str1;
                  string str2;
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      Logger.LogError((object) ex);
                      ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                      num6 = -811290302;
                      continue;
                    case 1:
                      if (UnityTools.platform != Rewired.Platforms.Platform.GameCoreXboxOne)
                      {
                        num6 = -811290301;
                        continue;
                      }
                      str2 = "Xbox One";
                      break;
                    case 3:
                      str2 = "Xbox Series X";
                      break;
                    case 4:
                      Logger.LogError((object) (str1 + " platform could not be initialized! Is the Rewired " + str1 + " library installed? See the documentation for more information."));
                      num6 = -811290304;
                      continue;
                    case 5:
                      goto label_81;
                    default:
                      goto label_113;
                  }
                  str1 = str2;
                  num6 = -811290300;
                }
              }
            }
          }
          if (UnityTools.platform == Rewired.Platforms.Platform.Ouya)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                System.Type unityBuildAssembly = ReflectionTools.GetTypeInUnityBuildAssembly("OuyaSDK", true);
                if (unityBuildAssembly != null)
                  goto label_100;
label_93:
                int num6 = -811290299;
label_94:
                CustomInputSource instance;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      goto label_100;
                    case 2:
                      goto label_97;
                    case 3:
                      goto label_96;
                    case 4:
                      goto label_98;
                    case 5:
                      goto label_95;
                    case 6:
                      goto label_93;
                    case 7:
                      ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new CustomInputManager(instance, ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop, new Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager>(ReInput.GetHardwareJoystickMap_InputManager), new Func<int>(ReInput.GetNewJoystickId));
                      int num7;
                      num6 = num7 = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn != null ? -811290303 : (num7 = -811290302);
                      continue;
                    default:
                      goto label_113;
                  }
                }
label_95:
                Logger.LogError((object) "OuyaEverywhereSDK was not found! Input may not function. See the documentation for building to the Ouya platform.");
                throw new Exception();
label_97:
                throw new Exception();
label_98:
                throw new Exception();
label_96:
                instance = (CustomInputSource) Assembly.GetAssembly(unityBuildAssembly).CreateInstance(unityBuildAssembly.FullName, false);
                num6 = -811290297;
                goto label_94;
label_100:
                unityBuildAssembly = ReflectionTools.GetTypeInUnityBuildAssembly("Rewired.Platforms.Ouya.OuyaInputSource", true);
                if (unityBuildAssembly == null)
                {
                  Logger.LogError((object) "Required files for Ouya support are missing. Input may not function. Please completely reinstall Rewired.");
                  num6 = -811290300;
                  goto label_94;
                }
                else
                  goto label_96;
              }
              catch
              {
label_103:
                int num6 = -811290303;
                while (true)
                {
                  switch (num6 ^ -811290304)
                  {
                    case 0:
                      goto label_103;
                    case 1:
                      Logger.LogError((object) "Ouya platform could not be initialized! Please see the documentation for required dependencies. Rewired will fall back to Unity input. All features may not be available.");
                      num6 = -811290301;
                      continue;
                    case 3:
                      ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) null;
                      num6 = -811290302;
                      continue;
                    default:
                      goto label_113;
                  }
                }
              }
            }
          }
          if (UnityTools.isAndroidPlatform)
          {
            if (!ReInput.isEditor)
            {
              try
              {
                UnityTools.androidFallbackPlatformHelper = _param0(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) as IAndroidFallbackPlatformHelper;
                goto label_113;
              }
              catch (Exception ex)
              {
                Logger.LogError((object) ex);
                goto label_113;
              }
            }
            else
              goto label_113;
          }
          else
            goto label_113;
        }
label_31:
        ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = _param0(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT) as PlatformInputManager;
      }
label_113:
      if (ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn != null)
        return;
label_114:
      int num8 = -811290303;
      while (true)
      {
        switch (num8 ^ -811290304)
        {
          case 0:
            goto label_114;
          case 1:
            ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb = true;
            ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn = (PlatformInputManager) new gtAKSPJfXtBplIcEwBDHeJaSbNAM(ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.updateLoop);
            num8 = -811290302;
            continue;
          case 2:
            goto label_108;
          default:
            goto label_105;
        }
      }
label_108:
      return;
label_105:
      return;
label_4:
      num1 = flag ? -811290297 : (num1 = -811290294);
      goto label_2;
    }

    private static bool MbQjnmQWzuUcDwjjAaglJnQEDlq()
    {
      float num1 = 30f;
label_1:
      int num2 = -1448302887;
      float num3;
      while (true)
      {
        switch (num2 ^ -1448302886)
        {
          case 0:
            if (!ReInput.hPexmxlfmOhsvJpFwBzyzLQJyhYg)
            {
              ReInput.hPexmxlfmOhsvJpFwBzyzLQJyhYg = true;
              num2 = -1448302885;
              continue;
            }
            goto label_10;
          case 2:
            goto label_1;
          case 3:
            float num4 = 2f;
            float num5 = 5f;
            num3 = num1 * num4 * num5;
            num2 = -1448302882;
            continue;
          case 4:
            int num6;
            num2 = num6 = ReInput.hPexmxlfmOhsvJpFwBzyzLQJyhYg ? -1448302886 : (num6 = -1448302881);
            continue;
          case 5:
            if (ReInput.unscaledTime < (double) num3)
            {
              if (ReInput.realTime >= (double) num3)
              {
                num2 = -1448302886;
                continue;
              }
              goto label_11;
            }
            else
              goto case 0;
          default:
            goto label_10;
        }
      }
label_10:
      return false;
label_11:
      return true;
    }

    internal static void jYAiiTBCQKbwfzaipQVRhqoXzxa()
    {
      if (!ReInput.hPexmxlfmOhsvJpFwBzyzLQJyhYg)
        return;
      if (!ReInput.OUBTfacDdMEKZhIFynVcYvTvnmNH)
        goto label_6;
label_2:
      int num = -1357544511;
label_3:
      switch (num ^ -1357544509)
      {
        case 0:
          goto label_2;
        case 1:
          break;
        case 2:
          return;
        case 3:
          return;
        default:
          return;
      }
label_6:
      byte[] bytes = new byte[68]
      {
        (byte) 82,
        (byte) 101,
        (byte) 119,
        (byte) 105,
        (byte) 114,
        (byte) 101,
        (byte) 100,
        (byte) 32,
        (byte) 116,
        (byte) 114,
        (byte) 105,
        (byte) 97,
        (byte) 108,
        (byte) 32,
        (byte) 116,
        (byte) 105,
        (byte) 109,
        (byte) 101,
        (byte) 32,
        (byte) 108,
        (byte) 105,
        (byte) 109,
        (byte) 105,
        (byte) 116,
        (byte) 32,
        (byte) 104,
        (byte) 97,
        (byte) 115,
        (byte) 32,
        (byte) 101,
        (byte) 120,
        (byte) 112,
        (byte) 105,
        (byte) 114,
        (byte) 101,
        (byte) 100,
        (byte) 33,
        (byte) 32,
        (byte) 73,
        (byte) 110,
        (byte) 112,
        (byte) 117,
        (byte) 116,
        (byte) 32,
        (byte) 105,
        (byte) 115,
        (byte) 32,
        (byte) 110,
        (byte) 111,
        (byte) 32,
        (byte) 108,
        (byte) 111,
        (byte) 110,
        (byte) 103,
        (byte) 101,
        (byte) 114,
        (byte) 32,
        (byte) 102,
        (byte) 117,
        (byte) 110,
        (byte) 99,
        (byte) 116,
        (byte) 105,
        (byte) 111,
        (byte) 110,
        (byte) 97,
        (byte) 108,
        (byte) 46
      };
      Logger.LogWarning((object) Encoding.UTF8.GetString(bytes, 0, bytes.Length));
      ReInput.OUBTfacDdMEKZhIFynVcYvTvnmNH = true;
      num = -1357544512;
      goto label_3;
    }

    private static void PhrSTCaiexVCPzKwyppNAQnGOJa()
    {
      if (ReInput.gQSCsulqVehPHYubeQCKRnoblJC == ReInput.bVKkeJIbKbigPklBsshxgxpMgxT.GetPlatformVar_ignoreInputWhenAppNotInFocus())
        return;
label_1:
      int num = -105403239;
      while (true)
      {
        switch (num ^ -105403240)
        {
          case 0:
            goto label_5;
          case 1:
            ReInput.gQSCsulqVehPHYubeQCKRnoblJC = !ReInput.gQSCsulqVehPHYubeQCKRnoblJC;
            num = -105403240;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private static void WNHdFBGooXleZylvhAGzJaITgsbC()
    {
      if (UnityTools.unityVersionObj == (UnityTools.UnityVersionClass) null)
        return;
label_7:
      object[] objArray = new object[7];
      int num = -568510668;
      while (true)
      {
        switch (num ^ -568510668)
        {
          case 0:
            objArray[0] = (object) "The version of Rewired installed (";
            num = -568510669;
            continue;
          case 1:
            objArray[2] = (object) ") was not designed for Unity ";
            num = -568510671;
            continue;
          case 2:
            num = -568510660;
            continue;
          case 3:
            Logger.LogWarning((object) string.Concat(objArray));
            num = -568510670;
            continue;
          case 4:
            objArray[4] = (object) ". Please install Rewired for Unity ";
            objArray[5] = (object) UnityTools.unityVersionObj.major;
            objArray[6] = (object) ".\n\nThis warning does not mean that Rewired will not function, but it may not function optimally.\n\nSome different major versions of Unity download Asset Store assets to the same folder location on disk, so if you download an asset in one version of the Unity editor, then open another version of the Unity editor and install the asset without re-downloading it, the wrong asset version will be installed. To fix this, manually re-download Rewired in the Unity Asset Store panel in this version of the Unity Editor, then install it.\n\nIf you are using a beta version of a new major version of Unity, you will have to wait until the release of the final version before a compatible version of Rewired can be uploaded to the Asset Store. When the new version is ready, it will be available through the Unity Asset Store for download as usual.";
            num = -568510665;
            continue;
          case 5:
            objArray[3] = (object) UnityTools.unityVersionObj.major;
            num = -568510672;
            continue;
          case 6:
            goto label_1;
          case 7:
            objArray[1] = (object) ReInput.programVersion;
            num = -568510667;
            continue;
          case 8:
            goto label_7;
          default:
            goto label_12;
        }
      }
label_1:
      return;
label_12:;
    }

    /// <summary>
    /// Provides access to time-related data. This is mostly for accurate unscaled time comparisons for button and axis times.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public sealed class ConfigHelper : CodeHelper
    {
      private static ReInput.ConfigHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;
      private float YFidvjkCrrHxIVWOJgduuPcGhdy = 0.7f;
      private float foDbvxgLnfPErkNzkbUzVjORTYH = 100f;

      internal static ReInput.ConfigHelper Instance => ReInput.ConfigHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.ConfigHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.ConfigHelper());

      private ConfigHelper()
      {
      }

      /// <summary>
      /// Toggles the use of XInput in Windows Standalone and Windows UWP during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool useXInput
      {
        get
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = -129939279;
label_2:
          switch (num ^ -129939280)
          {
            case 0:
              goto label_1;
            case 1:
              return false;
            default:
              if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
                return true;
              goto label_8;
          }
label_4:
          if (UnityTools.platform == Rewired.Platforms.Platform.Windows)
          {
            num = -129939278;
            goto label_2;
          }
label_8:
          return UnityTools.platform == Rewired.Platforms.Platform.WindowsUWP ? (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVars(Rewired.Platforms.Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP).useGamepadAPI : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.useXInput;
        }
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_16:
          int num1 = UnityTools.platform == Rewired.Platforms.Platform.WindowsUWP ? -1026369262 : (num1 = -1026369250);
          ConfigVars.PlatformVars_WindowsUWP platformVars;
          while (true)
          {
            switch (num1 ^ -1026369250)
            {
              case 0:
                if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.useXInput != value)
                  goto case 2;
                else
                  goto label_8;
              case 1:
                if ((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null)
                {
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num1 = -1026369256;
                  continue;
                }
                goto label_20;
              case 2:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.useXInput = value;
                if (!value && UnityTools.platform == Rewired.Platforms.Platform.Windows && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
                {
                  this.windowsStandalonePrimaryInputSource = WindowsStandalonePrimaryInputSource.RawInput;
                  num1 = -1026369257;
                  continue;
                }
                goto case 1;
              case 3:
                num1 = -1026369260;
                continue;
              case 4:
                goto label_12;
              case 5:
                ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                num1 = -1026369259;
                continue;
              case 6:
                goto label_13;
              case 7:
                goto label_11;
              case 8:
                platformVars.useGamepadAPI = value;
                int num2;
                num1 = num2 = (UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null ? -1026369253 : (num2 = -1026369259);
                continue;
              case 9:
                Logger.Log((object) "The primary input source has been changed to Raw Input.");
                num1 = -1026369255;
                continue;
              case 10:
                goto label_16;
              case 11:
                goto label_1;
              case 12:
                platformVars = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVars(Rewired.Platforms.Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP;
                num1 = -1026369261;
                continue;
              case 13:
                int num3;
                num1 = num3 = platformVars.useGamepadAPI == value ? -1026369254 : (num3 = -1026369258);
                continue;
              default:
                goto label_21;
            }
          }
label_12:
          return;
label_13:
          return;
label_11:
          return;
label_1:
          return;
label_21:
          return;
label_20:
          return;
label_8:;
        }
      }

      /// <summary>
      /// Changes the Update Loop setting during runtime. Rewired will be completely reset if this value is changed.
      /// This can be set to multiple values simultaneously.
      /// Note: Update is required. Update will be enabled even if you unset the Update flag.
      /// </summary>
      public UpdateLoopSetting updateLoop
      {
        get => !ReInput.CheckInitialized() ? UpdateLoopSetting.Update : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.updateLoop;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_10:
          while (value != ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.updateLoop)
          {
label_8:
            if ((value & UpdateLoopSetting.Update) != UpdateLoopSetting.None)
              goto label_5;
            else
              goto label_9;
label_3:
            int num1;
            while (true)
            {
              switch (num1 ^ 975131092)
              {
                case 0:
                  goto label_8;
                case 1:
                  goto label_10;
                case 2:
                  goto label_11;
                case 3:
                  num1 = 975131093;
                  continue;
                case 4:
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num1 = 975131094;
                  continue;
                case 5:
                  int num2;
                  num1 = num2 = (UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null ? 975131088 : (num2 = 975131094);
                  continue;
                case 6:
                  goto label_5;
                default:
                  goto label_12;
              }
            }
label_11:
            break;
label_12:
            break;
label_5:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.updateLoop = value;
            num1 = 975131089;
            goto label_3;
label_9:
            value |= UpdateLoopSetting.Update;
            num1 = 975131090;
            goto label_3;
          }
        }
      }

      /// <summary>
      /// Changes the primary input source in Windows Standalone during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? WindowsStandalonePrimaryInputSource.RawInput : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsStandalonePrimaryInputSource;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_9:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsStandalonePrimaryInputSource != value ? 1078489781 : (num = 1078489778);
          while (true)
          {
            switch (num ^ 1078489783)
            {
              case 0:
                if ((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null)
                {
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num = 1078489782;
                  continue;
                }
                goto label_11;
              case 1:
                goto label_10;
              case 2:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsStandalonePrimaryInputSource = value;
                if (UnityTools.platform == Rewired.Platforms.Platform.Windows && value == WindowsStandalonePrimaryInputSource.XInput)
                {
                  ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.useXInput = true;
                  num = 1078489783;
                  continue;
                }
                goto case 0;
              case 3:
                goto label_9;
              case 4:
                num = 1078489780;
                continue;
              case 5:
                goto label_1;
              default:
                goto label_12;
            }
          }
label_10:
          return;
label_1:
          return;
label_12:
          return;
label_11:;
        }
      }

      /// <summary>
      /// Changes the primary input source in OSX Standalone during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? OSXStandalonePrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.osx_primaryInputSource;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num = -1428479661;
label_2:
          switch (num ^ -1428479664)
          {
            case 0:
              break;
            case 1:
              goto label_7;
            case 2:
              goto label_1;
            case 3:
              return;
            case 4:
              return;
            default:
              return;
          }
label_5:
          if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.osx_primaryInputSource == value)
            return;
label_7:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.osx_primaryInputSource = value;
          if (!((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null))
            return;
          ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
          num = -1428479660;
          goto label_2;
        }
      }

      /// <summary>
      /// Changes the primary input source in Linux Standalone during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? LinuxStandalonePrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.linux_primaryInputSource;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_6;
label_1:
          int num1 = 1386733393;
label_2:
          while (true)
          {
            switch (num1 ^ 1386733394)
            {
              case 0:
                goto label_6;
              case 1:
                ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                num1 = 1386733397;
                continue;
              case 2:
                goto label_1;
              case 3:
                goto label_3;
              case 4:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.linux_primaryInputSource = value;
                num1 = 1386733399;
                continue;
              case 5:
                int num2;
                num1 = num2 = !((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null) ? 1386733397 : (num2 = 1386733395);
                continue;
              case 6:
                goto label_4;
              case 7:
                goto label_5;
              default:
                goto label_10;
            }
          }
label_3:
          return;
label_4:
          return;
label_5:
          return;
label_10:
          return;
label_6:
          num1 = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.linux_primaryInputSource != value ? 1386733398 : (num1 = 1386733396);
          goto label_2;
        }
      }

      /// <summary>
      /// Changes the primary input source in Windows 10 Universal during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? WindowsUWPPrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsUWP_primaryInputSource;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsUWP_primaryInputSource != value)
          {
label_8:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.windowsUWP_primaryInputSource = value;
            int num1 = -415710982;
            while (true)
            {
              switch (num1 ^ -415710978)
              {
                case 0:
                  goto label_6;
                case 1:
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num1 = -415710978;
                  continue;
                case 2:
                  goto label_8;
                case 3:
                  goto label_5;
                case 4:
                  int num2;
                  num1 = num2 = (UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null ? -415710977 : (num2 = -415710978);
                  continue;
                case 5:
                  num1 = -415710979;
                  continue;
                default:
                  goto label_10;
              }
            }
label_6:
            break;
label_10:
            break;
          }
        }
      }

      /// <summary>
      /// Toggles support for HID devices in Windows UWP. This includes older gamepads, gamepads made for Android, flight controllers, racing wheels,
      /// etc. In order to use this feature, you must add support for HID gamepads and joysticks to the app manifest file.
      /// Please see the Special Platform Support -&gt; Windows 10 Universal documentation for details.
      /// Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool windowsUWPSupportHIDDevices
      {
        get => ReInput.CheckInitialized() && (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVars(Rewired.Platforms.Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP).useHIDAPI;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num1 = -160962077;
label_2:
          ConfigVars.PlatformVars_WindowsUWP platformVars;
          while (true)
          {
            switch (num1 ^ -160962078)
            {
              case 0:
                goto label_6;
              case 1:
                goto label_3;
              case 2:
                ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                num1 = -160962076;
                continue;
              case 3:
                int num2;
                num1 = num2 = (UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null ? -160962080 : (num2 = -160962076);
                continue;
              case 4:
                goto label_1;
              case 5:
                platformVars.useHIDAPI = value;
                num1 = -160962079;
                continue;
              case 6:
                goto label_8;
              case 7:
                goto label_5;
              default:
                goto label_10;
            }
          }
label_6:
          return;
label_3:
          return;
label_8:
          return;
label_10:
          return;
label_5:
          platformVars = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVars(Rewired.Platforms.Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP;
          num1 = platformVars.useHIDAPI != value ? -160962073 : (num1 = -160962078);
          goto label_2;
        }
      }

      /// <summary>
      /// Changes the primary input source in Xbox One during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public XboxOnePrimaryInputSource xboxOnePrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? XboxOnePrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.xboxOne_primaryInputSource;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num1 = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.xboxOne_primaryInputSource == value ? -1607221670 : (num1 = -1607221668);
          while (true)
          {
            switch (num1 ^ -1607221668)
            {
              case 0:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.xboxOne_primaryInputSource = value;
                num1 = -1607221671;
                continue;
              case 1:
                goto label_7;
              case 2:
                goto label_5;
              case 3:
                num1 = -1607221666;
                continue;
              case 4:
                ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                num1 = -1607221667;
                continue;
              case 5:
                int num2;
                num1 = num2 = !((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null) ? -1607221667 : (num2 = -1607221672);
                continue;
              case 6:
                goto label_1;
              default:
                goto label_10;
            }
          }
label_7:
          return;
label_1:
          return;
label_10:;
        }
      }

      /// <summary>
      /// Changes the primary input source in PS4 during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public PS4PrimaryInputSource ps4PrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? PS4PrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.ps4_primaryInputSource;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.ps4_primaryInputSource != value)
          {
label_8:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.ps4_primaryInputSource = value;
            int num = !((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null) ? 281276362 : (num = 281276364);
            while (true)
            {
              switch (num ^ 281276366)
              {
                case 0:
                  num = 281276365;
                  continue;
                case 1:
                  goto label_8;
                case 2:
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num = 281276362;
                  continue;
                case 3:
                  goto label_5;
                case 4:
                  goto label_6;
                default:
                  goto label_9;
              }
            }
label_6:
            break;
label_9:
            break;
          }
        }
      }

      /// <summary>
      /// Changes the primary input source in WebGL during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public WebGLPrimaryInputSource webGLPrimaryInputSource
      {
        get => !ReInput.CheckInitialized() ? WebGLPrimaryInputSource.Native : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.webGL_primaryInputSource;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_8;
label_1:
          int num = 1888579205;
label_2:
          while (true)
          {
            switch (num ^ 1888579204)
            {
              case 0:
                goto label_3;
              case 1:
                goto label_4;
              case 2:
                goto label_8;
              case 3:
                goto label_1;
              case 4:
                goto label_7;
              case 5:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.webGL_primaryInputSource = value;
                if ((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null)
                {
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num = 1888579200;
                  continue;
                }
                goto label_9;
              default:
                goto label_10;
            }
          }
label_3:
          return;
label_4:
          return;
label_7:
          return;
label_10:
          return;
label_9:
          return;
label_8:
          num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.webGL_primaryInputSource == value ? 1888579204 : (num = 1888579201);
          goto label_2;
        }
      }

      /// <summary>
      /// Toggles the use of Unity input during runtime. Rewired will be completely reset if this value is changed.
      /// This is an alias for disableNativeInput.
      /// </summary>
      public bool alwaysUseUnityInput
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.alwaysUseUnityInput;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.alwaysUseUnityInput != value)
          {
label_7:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.alwaysUseUnityInput = value;
            int num = 328234269;
            while (true)
            {
              switch (num ^ 328234268)
              {
                case 0:
                  num = 328234264;
                  continue;
                case 1:
                  if ((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null)
                  {
                    ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                    num = 328234271;
                    continue;
                  }
                  goto label_10;
                case 2:
                  goto label_7;
                case 3:
                  goto label_6;
                case 4:
                  goto label_5;
                default:
                  goto label_11;
              }
            }
label_6:
            break;
label_11:
            break;
label_10:
            break;
          }
        }
      }

      /// <summary>
      /// Toggles the use of Unity input during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool disableNativeInput
      {
        get => this.alwaysUseUnityInput;
        set => this.alwaysUseUnityInput = value;
      }

      /// <summary>
      /// Toggles the use of native mouse handling during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool nativeMouseSupport
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVar_useNativeMouse();
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_7:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.SetPlatformVar_useNativeMouse(value))
          {
label_6:
            int num = !((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null) ? 1667460451 : (num = 1667460455);
            while (true)
            {
              switch (num ^ 1667460451)
              {
                case 0:
                  goto label_8;
                case 1:
                  goto label_7;
                case 2:
                  num = 1667460450;
                  continue;
                case 3:
                  goto label_6;
                case 4:
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num = 1667460451;
                  continue;
                default:
                  goto label_9;
              }
            }
label_8:
            break;
label_9:
            break;
          }
        }
      }

      /// <summary>
      /// Toggles the use of native keyboard handling during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool nativeKeyboardSupport
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVar_useNativeKeyboard();
        set
        {
          if (ReInput.CheckInitialized())
            goto label_6;
label_1:
          int num = 2053375090;
label_2:
          switch (num ^ 2053375088)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_6;
            case 2:
              return;
            case 3:
              return;
            case 4:
              break;
            default:
              return;
          }
label_4:
          if (!((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null))
            return;
          ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
          num = 2053375091;
          goto label_2;
label_6:
          if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.SetPlatformVar_useNativeKeyboard(value))
            goto label_4;
        }
      }

      /// <summary>
      /// Toggles the use of enhanced device support during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool enhancedDeviceSupport
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVar_useEnhancedDeviceSupport();
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.SetPlatformVar_useEnhancedDeviceSupport(value))
          {
label_7:
            int num = (UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null ? 1484086328 : (num = 1484086330);
            while (true)
            {
              switch (num ^ 1484086330)
              {
                case 0:
                  goto label_6;
                case 1:
                  goto label_5;
                case 2:
                  ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                  num = 1484086330;
                  continue;
                case 3:
                  goto label_7;
                case 4:
                  num = 1484086331;
                  continue;
                default:
                  goto label_9;
              }
            }
label_6:
            break;
label_9:
            break;
          }
        }
      }

      /// <summary>
      /// The joystick refresh rate in frames per second. [0 - 2000] [0 = Default]
      /// Set this to a higher value if you need higher precision input timing at high frame rates such as for a music beat game. Higher values result in higher CPU usage. Note that setting this to a very high value when the game is running at a low frame rate will not result in higher precision input.
      /// This settings only applies to input sources that use a separate thread to poll for joystick input values (currently XInput and Direct Input). This setting does not apply to event-based input sources such as Raw Input.
      /// This setting can be changed without resetting Rewired.
      /// </summary>
      public int joystickRefreshRate
      {
        get => !ReInput.CheckInitialized() ? 0 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVar_joystickRefreshRate();
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_4:
          value = MathTools.Clamp(value, 0, 2000);
          if (value == 0)
          {
            value = 240;
            int num = -1465217247;
            while (true)
            {
              switch (num ^ -1465217247)
              {
                case 1:
                  goto label_4;
                case 2:
                  num = -1465217248;
                  continue;
                default:
                  goto label_6;
              }
            }
          }
label_6:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.SetPlatformVar_joystickRefreshRate(value);
        }
      }

      /// <summary>
      /// Ignores input if the application is not in focus This setting has no effect on some platforms.
      /// NOTE: Disabling this does not guarantee that input will be processed when the application is out of focus.
      /// Whether input is received by the application or not is dependent on A) the input device type B) the current platform C) the input source(s) being used.
      /// This setting can be changed without resetting Rewired.
      /// </summary>
      public bool ignoreInputWhenAppNotInFocus
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.GetPlatformVar_ignoreInputWhenAppNotInFocus();
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num = !ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.SetPlatformVar_ignoreInputWhenAppNotInFocus(value) ? 667956523 : (num = 667956522);
          while (true)
          {
            switch (num ^ 667956521)
            {
              case 0:
                num = 667956520;
                continue;
              case 1:
                goto label_5;
              case 2:
                goto label_1;
              default:
                goto label_6;
            }
          }
label_1:
          return;
label_6:
          ReInput.ZTcPuaxHgmLKXAGFHpGZrrRBFrh();
        }
      }

      /// <summary>
      /// Toggles the support of unknown gamepads on the Android platform during runtime. Rewired will be completely reset if this value is changed.
      /// </summary>
      public bool android_supportUnknownGamepads
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.android_supportUnknownGamepads;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num1 = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.android_supportUnknownGamepads != value ? -294412783 : (num1 = -294412778);
          while (true)
          {
            switch (num1 ^ -294412781)
            {
              case 0:
                num1 = -294412777;
                continue;
              case 1:
                goto label_7;
              case 2:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.android_supportUnknownGamepads = value;
                int num2;
                num1 = num2 = !((UnityEngine.Object) ReInput.ybGwqznbxFisdrSVioLpNYpJswe != (UnityEngine.Object) null) ? -294412782 : (num2 = -294412784);
                continue;
              case 3:
                ReInput.ybGwqznbxFisdrSVioLpNYpJswe.ResetAll();
                num1 = -294412782;
                continue;
              case 4:
                goto label_5;
              case 5:
                goto label_1;
              default:
                goto label_9;
            }
          }
label_7:
          return;
label_1:
          return;
label_9:;
        }
      }

      /// <summary>
      /// Changes the default dead zone type for 2D joystick axes for recognized controllers. This setting can be changed without resetting Rewired.
      /// </summary>
      public DeadZone2DType defaultJoystickAxis2DDeadZoneType
      {
        get => !ReInput.CheckInitialized() ? DeadZone2DType.Radial : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DDeadZoneType;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_7:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DDeadZoneType == value ? 227076467 : (num = 227076466);
          while (true)
          {
            switch (num ^ 227076467)
            {
              case 0:
                goto label_1;
              case 1:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DDeadZoneType = value;
                num = 227076464;
                continue;
              case 2:
                num = 227076471;
                continue;
              case 3:
                goto label_6;
              case 4:
                goto label_7;
              default:
                goto label_8;
            }
          }
label_1:
          return;
label_6:
          return;
label_8:;
        }
      }

      /// <summary>
      /// Changes the default sensitivity type for 2D joystick axes for recognized controllers. This setting can be changed without resetting Rewired.
      /// </summary>
      public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType
      {
        get => !ReInput.CheckInitialized() ? AxisSensitivity2DType.Radial : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DSensitivityType;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          while (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DSensitivityType != value)
          {
label_7:
            ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultJoystickAxis2DSensitivityType = value;
            int num = 117132225;
            while (true)
            {
              switch (num ^ 117132227)
              {
                case 0:
                  num = 117132226;
                  continue;
                case 1:
                  goto label_5;
                case 2:
                  goto label_6;
                case 3:
                  goto label_7;
                default:
                  goto label_8;
              }
            }
label_6:
            break;
label_8:
            break;
          }
        }
      }

      /// <summary>
      /// Changes the default axis sensitivity type for axes. This setting can be changed without resetting Rewired.
      /// Changing this setting will not change the AxisSensitivityType on Controllers already connected during the game session.
      /// It will also not change the AxisSensitivityType in saved user data that is loaded.
      /// </summary>
      public AxisSensitivityType defaultAxisSensitivityType
      {
        get => !ReInput.CheckInitialized() ? AxisSensitivityType.Multiplier : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultAxisSensitivityType;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num = 1016371939;
label_2:
          while (true)
          {
            switch (num ^ 1016371943)
            {
              case 0:
                goto label_1;
              case 1:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultAxisSensitivityType = value;
                num = 1016371941;
                continue;
              case 2:
                goto label_6;
              case 3:
                goto label_5;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              default:
                goto label_8;
            }
          }
label_6:
          return;
label_3:
          return;
label_4:
          return;
label_8:
          return;
label_5:
          num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.defaultAxisSensitivityType == value ? 1016371938 : (num = 1016371942);
          goto label_2;
        }
      }

      /// <summary>
      /// Force all 8-way hats on recognized joysticks to be treated as 4-way hats.
      /// If enabled, the corner directions on all hats will activate the adjacent 2 cardinal direction buttons instead of the corner button.
      /// This is useful if you need joystick hats to behave like D-Pads instead of 8-way hats.
      /// This setting can be changed without resetting Rewired.
      /// </summary>
      public bool force4WayHats
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.force4WayHats;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.force4WayHats == value ? 518260270 : (num = 518260269);
          while (true)
          {
            switch (num ^ 518260268)
            {
              case 0:
                num = 518260271;
                continue;
              case 2:
                goto label_1;
              case 3:
                goto label_5;
              default:
                goto label_6;
            }
          }
label_1:
          return;
label_6:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.force4WayHats = value;
        }
      }

      /// <summary>
      /// The default polling dead zone used when polling Absolute coordinate mode axes.
      /// In order for the axis to be detected when polling, the change in absolute value
      /// of the axis over the polling period must be greater than this amount.
      /// Do not set this value too low or noisy axes will be detected.
      /// This only applies to axes that use an Absolute coordinate system such as joysticks.
      /// Each indivisual axis may override this default value.
      /// [Default = 0.7]
      /// </summary>
      public float defaultAbsoluteAxisPollingDeadZone
      {
        get => !ReInput.CheckInitialized() ? 0.7f : this.YFidvjkCrrHxIVWOJgduuPcGhdy;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_9:
          int num1 = (double) value >= 0.0 ? 181952674 : (num1 = 181952677);
          while (true)
          {
            switch (num1 ^ 181952675)
            {
              case 0:
                num1 = 181952679;
                continue;
              case 1:
                int num2;
                num1 = num2 = (double) this.YFidvjkCrrHxIVWOJgduuPcGhdy == (double) value ? 181952678 : (num2 = 181952672);
                continue;
              case 2:
                goto label_8;
              case 3:
                this.YFidvjkCrrHxIVWOJgduuPcGhdy = value;
                num1 = 181952673;
                continue;
              case 4:
                goto label_9;
              case 5:
                goto label_1;
              case 6:
                value = 0.0f;
                num1 = 181952674;
                continue;
              default:
                goto label_10;
            }
          }
label_8:
          return;
label_1:
          return;
label_10:;
        }
      }

      /// <summary>
      /// The default polling dead zone used when polling Relative coordinate mode axes.
      /// In order for the axis to be detected when polling, the change in absolute value
      /// of the axis over the polling period must be greater than this amount.
      /// Do not set this value too low or noisy axes will be detected.
      /// This only applies to axes that use a Relative coordinate system such as mouse axes.
      /// Each indivisual axis may override this default value.
      /// [Default = 100]
      /// </summary>
      public float defaultRelativeAxisPollingDeadZone
      {
        get => !ReInput.CheckInitialized() ? 100f : this.foDbvxgLnfPErkNzkbUzVjORTYH;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num = 1106216696;
label_2:
          while (true)
          {
            switch (num ^ 1106216698)
            {
              case 1:
                value = 0.0f;
                num = 1106216702;
                continue;
              case 2:
                goto label_3;
              case 3:
                goto label_5;
              case 4:
                goto label_7;
              case 5:
                goto label_1;
              default:
                goto label_8;
            }
          }
label_3:
          return;
label_7:
          if ((double) this.foDbvxgLnfPErkNzkbUzVjORTYH == (double) value)
            return;
label_8:
          this.foDbvxgLnfPErkNzkbUzVjORTYH = value;
          return;
label_5:
          num = (double) value < 0.0 ? 1106216699 : (num = 1106216702);
          goto label_2;
        }
      }

      /// <summary>
      /// Determines how button values are calculated by Player Actions.
      /// If enabled, Actions with either a negative or positive Axis value will return True when queried with player.GetButton.
      /// If disabled, Actions with a negative Axis value will always return False when queried with player.GetButton, and must be queried with player.GetNegativeButton.
      /// This setting can be changed without resetting Rewired.
      /// </summary>
      public bool activateActionButtonsOnNegativeValue
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.activateActionButtonsOnNegativeValue;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.activateActionButtonsOnNegativeValue != value ? -1360820842 : (num = -1360820845);
          while (true)
          {
            switch (num ^ -1360820846)
            {
              case 0:
                goto label_7;
              case 1:
                goto label_1;
              case 2:
                goto label_5;
              case 3:
                num = -1360820848;
                continue;
              case 4:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.activateActionButtonsOnNegativeValue = value;
                num = -1360820846;
                continue;
              default:
                goto label_8;
            }
          }
label_7:
          return;
label_1:
          return;
label_8:;
        }
      }

      /// <summary>
      /// Determines how throttles on recognized controllers are calibrated.
      /// By default, throttles are calibrated for a range of 0 to +1. This is suitable for most flight and racing games.
      /// Some games may require a range of -1 to +1 such as space flight games where a negative value denotes a reverse thrust.
      /// Changing this setting will revert all throttle calibrations to the default values for the chosen calibration mode.
      /// This setting can be changed without resetting Rewired.
      /// </summary>
      public ThrottleCalibrationMode throttleCalibrationMode
      {
        get => !ReInput.CheckInitialized() ? ThrottleCalibrationMode.ZeroToOne : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.throttleCalibrationMode;
        set
        {
          if (!ReInput.CheckInitialized())
          {
label_1:
            switch (1294635923 ^ 1294635922)
            {
              case 0:
                goto label_1;
              case 1:
                return;
              case 3:
                break;
              default:
                goto label_5;
            }
          }
          if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.throttleCalibrationMode == value)
            return;
label_5:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.throttleCalibrationMode = value;
          ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.SYNakgaiaktwSgmQAkFGRBMikItI(value);
        }
      }

      /// <summary>
      /// Defer controller connected events for controllers already connected when Rewired initializes until the Start event instead of
      /// during initialization. Normally, it's impossible to receive controller connection events at the start of runtime because Rewired
      /// initializes before any other script is able to subscribe to the controller connected event. Enabling this will defer the controller
      /// connected events until the Start event, allowing your scripts to subscribe to the controller connected event in Awake and still
      /// receive the event callback. If disabled, controller connection events for controllers already connected before runtime starts will be missed.
      /// </summary>
      public bool deferControllerConnectedEventsOnStart
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.deferControllerConnectedEventsOnStart;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num = 756129274;
label_2:
          while (true)
          {
            switch (num ^ 756129279)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_7;
              case 2:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.deferControllerConnectedEventsOnStart = value;
                num = 756129278;
                continue;
              case 3:
                goto label_5;
              case 4:
                goto label_3;
              case 5:
                goto label_4;
              default:
                goto label_8;
            }
          }
label_7:
          return;
label_3:
          return;
label_4:
          return;
label_8:
          return;
label_5:
          num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.deferControllerConnectedEventsOnStart == value ? 756129275 : (num = 756129277);
          goto label_2;
        }
      }

      /// <summary>
      /// Toggles joystick auto-assignment during runtime. This setting can be changed without resetting Rewired.
      /// </summary>
      public bool autoAssignJoysticks
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.autoAssignJoysticks;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.autoAssignJoysticks != value ? 1940609251 : (num = 1940609252);
          while (true)
          {
            switch (num ^ 1940609255)
            {
              case 0:
                num = 1940609254;
                continue;
              case 1:
                goto label_5;
              case 2:
                goto label_7;
              case 3:
                goto label_1;
              case 4:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.autoAssignJoysticks = value;
                num = 1940609253;
                continue;
              default:
                goto label_8;
            }
          }
label_7:
          return;
label_1:
          return;
label_8:;
        }
      }

      /// <summary>
      /// Set the max number of joysticks assigned to each Player by joystick auto-assignment during runtime. This setting can be changed without resetting Rewired.
      /// </summary>
      public int maxJoysticksPerPlayer
      {
        get => !ReInput.CheckInitialized() ? 0 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.maxJoysticksPerPlayer;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_7:
          if (value >= 1)
            goto label_6;
          else
            goto label_8;
label_3:
          int num;
          while (true)
          {
            switch (num ^ -200268463)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_6;
              case 2:
                goto label_7;
              case 3:
                goto label_5;
              case 4:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.maxJoysticksPerPlayer = value;
                num = -200268462;
                continue;
              case 5:
                num = -200268461;
                continue;
              default:
                goto label_10;
            }
          }
label_1:
          return;
label_5:
          return;
label_10:
          return;
label_6:
          num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.maxJoysticksPerPlayer != value ? -200268459 : (num = -200268463);
          goto label_3;
label_8:
          value = 1;
          num = -200268464;
          goto label_3;
        }
      }

      /// <summary>
      /// Toggles even joystick auto-assignment distribution among Players during runtime. This setting can be changed without resetting Rewired.
      /// </summary>
      public bool distributeJoysticksEvenly
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.distributeJoysticksEvenly;
        set
        {
          if (!ReInput.CheckInitialized())
          {
label_1:
            switch (-1624086190 ^ -1624086192)
            {
              case 1:
                break;
              case 2:
                return;
              case 3:
                goto label_1;
              default:
                goto label_5;
            }
          }
          if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.distributeJoysticksEvenly == value)
            return;
label_5:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.distributeJoysticksEvenly = value;
        }
      }

      /// <summary>
      /// Toggles even joystick auto-assignment to Players with isPlayer = True only during runtime. This setting can be changed without resetting Rewired.
      /// </summary>
      public bool assignJoysticksToPlayingPlayersOnly
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.assignJoysticksToPlayingPlayersOnly;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_7;
label_1:
          int num = -1687118640;
label_2:
          while (true)
          {
            switch (num ^ -1687118639)
            {
              case 0:
                goto label_7;
              case 1:
                goto label_4;
              case 2:
                goto label_1;
              case 3:
                ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.assignJoysticksToPlayingPlayersOnly = value;
                num = -1687118635;
                continue;
              case 4:
                goto label_6;
              case 5:
                goto label_3;
              default:
                goto label_8;
            }
          }
label_4:
          return;
label_6:
          return;
label_3:
          return;
label_8:
          return;
label_7:
          num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.assignJoysticksToPlayingPlayersOnly != value ? -1687118638 : (num = -1687118636);
          goto label_2;
        }
      }

      /// <summary>
      /// Toggles joystick auto-reassignment when re-connected to the last owning Player during runtime. This setting can be changed without resetting Rewired.
      /// </summary>
      public bool reassignJoystickToPreviousOwnerOnReconnect
      {
        get => ReInput.CheckInitialized() && ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect;
        set
        {
          if (ReInput.CheckInitialized())
            goto label_5;
label_1:
          int num = -2122628207;
label_2:
          switch (num ^ -2122628208)
          {
            case 0:
              break;
            case 1:
              return;
            case 2:
              goto label_7;
            case 3:
              return;
            case 4:
              goto label_1;
            default:
              return;
          }
label_5:
          if (ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect == value)
            return;
label_7:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect = value;
          num = -2122628205;
          goto label_2;
        }
      }

      /// <summary>Determines the level of internal logging.</summary>
      public LogLevelFlags logLevel
      {
        get => !ReInput.CheckInitialized() ? LogLevelFlags.Off : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.logLevel;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
label_5:
          int num = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.logLevel == value ? 1045234516 : (num = 1045234519);
          while (true)
          {
            switch (num ^ 1045234516)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_5;
              case 2:
                num = 1045234517;
                continue;
              default:
                goto label_6;
            }
          }
label_1:
          return;
label_6:
          ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ConfigVars.logLevel = value;
        }
      }
    }

    /// <summary>Provides access to all controller-related members.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public sealed class ControllerHelper : CodeHelper
    {
      private static ReInput.ControllerHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;
      /// <summary>
      /// Provides access to controller element polling-related members.
      /// This should only be used for controller mapping or other non-gameplay-related code.
      /// The polling system is expensive and should not be used during gameplay.
      /// </summary>
      public readonly ReInput.ControllerHelper.PollingHelper polling = ReInput.ControllerHelper.PollingHelper.Instance;
      /// <summary>
      /// Provides access to Controller Map conflict checking-related members.
      /// </summary>
      public readonly ReInput.ControllerHelper.ConflictCheckingHelper conflictChecking = ReInput.ControllerHelper.ConflictCheckingHelper.Instance;

      internal static ReInput.ControllerHelper Instance => ReInput.ControllerHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.ControllerHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.ControllerHelper());

      private ControllerHelper()
      {
      }

      /// <summary>Gets a controller of type by id.</summary>
      /// <typeparam name="T">Type of Controller</typeparam>
      /// <param name="controllerId">The controller id</param>
      /// <returns>A controller of type T</returns>
      public T GetController<T>(int controllerId) where T : Controller
      {
        T obj1;
        if (!ReInput.CheckInitialized())
          obj1 = default (T);
        else
          goto label_5;
label_2:
        int num = 769929719;
label_3:
        T obj2;
        switch (num ^ 769929716)
        {
          case 0:
            goto label_2;
          case 2:
            return obj2;
          case 3:
            return obj1;
          default:
            return this.GetJoystick(controllerId) as T;
        }
label_5:
        if (controllerId < 0)
        {
          obj2 = default (T);
          num = 769929718;
          goto label_3;
        }
        else
        {
          System.Type type = typeof (T);
          if (ReflectionTools.DoesTypeImplement(type, typeof (Joystick)))
          {
            num = 769929717;
            goto label_3;
          }
          else
          {
            if (ReflectionTools.DoesTypeImplement(type, typeof (Keyboard)))
              return ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.joGvYuxHrKMlBSIPrafbOeoYcUa as T;
            if (ReflectionTools.DoesTypeImplement(type, typeof (CustomController)))
              return this.GetCustomController(controllerId) as T;
            if (ReflectionTools.DoesTypeImplement(type, typeof (Mouse)))
              return ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.MARBRADmEmfcJPtkCcxtGpTRHGsv as T;
            throw new NotImplementedException();
          }
        }
      }

      /// <summary>
      /// Gets the number of controllers that exist of a specific type.
      /// </summary>
      /// <param name="controllerType">Type of controller</param>
      /// <returns>Number of controllers of a specific type</returns>
      public int GetControllerCount(ControllerType controllerType)
      {
        if (ReInput.CheckInitialized())
          goto label_6;
label_1:
        int num = 1056026901;
label_2:
        ControllerType controllerType1;
        while (true)
        {
          switch (num ^ 1056026900)
          {
            case 1:
              goto label_5;
            case 2:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  goto label_10;
                case ControllerType.Mouse:
                  goto label_11;
                case ControllerType.Joystick:
                  goto label_9;
                default:
                  num = 1056026896;
                  continue;
              }
            case 3:
              goto label_13;
            case 4:
              if (controllerType1 != ControllerType.Custom)
              {
                num = 1056026903;
                continue;
              }
              goto label_12;
            case 5:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_5:
        return 0;
label_9:
        return this.joystickCount;
label_10:
        return 1;
label_11:
        return 1;
label_12:
        return this.customControllerCount;
label_13:
        throw new NotImplementedException();
label_6:
        controllerType1 = controllerType;
        num = 1056026902;
        goto label_2;
      }

      /// <summary>
      /// The number of controllers of all types currently connected.
      /// </summary>
      public int controllerCount => !ReInput.CheckInitialized() ? 0 : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aXQCOfHhDjzbgcDtNhplDgCkfbLM;

      /// <summary>
      /// Gets a collection of connected controllers of all types.
      /// </summary>
      /// <returns>IList of Controller</returns>
      public IList<Controller> Controllers => !ReInput.CheckInitialized() ? EmptyObjects<Controller>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ybBbmknRrlazNBLgTmBMthjSJXzq;

      /// <summary>
      /// Gets a controller of a specific type with a specific id.
      /// </summary>
      /// <param name="controllerType">Type of controller</param>
      /// <param name="controllerId">Controller id</param>
      /// <returns>Controller</returns>
      public Controller GetController(ControllerType controllerType, int controllerId) => !ReInput.CheckInitialized() ? (Controller) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerType, controllerId);

      /// <summary>Gets a controller that matches a Controller Idnetifier.</summary>
      /// <param name="controllerIdentifier">Controller Identifier</param>
      /// <returns>Controller</returns>
      public Controller GetController(ControllerIdentifier controllerIdentifier) => !ReInput.CheckInitialized() ? (Controller) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier);

      /// <summary>
      /// Get a collection of connected controllers.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>An array of all Controllers of this type</returns>
      public Controller[] GetControllers(ControllerType controllerType) => !ReInput.CheckInitialized() ? EmptyObjects<Controller>.array : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.KdrTcktOZCghdgLmgmZHarFkCWik(controllerType);

      /// <summary>
      /// Get an array of connected controller names.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>An array of the names of all controllers of this type</returns>
      public string[] GetControllerNames(ControllerType controllerType) => !ReInput.CheckInitialized() ? EmptyObjects<string>.array : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.huqbXYPetjHHAlwBofxjwUbAfSL(controllerType);

      /// <summary>Is the specified controller assigned to any players?</summary>
      /// <param name="controllerType">Type of controller</param>
      /// <param name="controller">The controller</param>
      /// <returns>Boolean determining whether this controller is assigned to any player</returns>
      public bool IsControllerAssigned(ControllerType controllerType, Controller controller) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.wuVFgvlYzhgvFDUrALeNLoLZLJC(controller);

      /// <summary>Is the specified controller assigned to any players?</summary>
      /// <param name="controllerType">Type of controller</param>
      /// <param name="controllerId">Id of the controller</param>
      /// <returns>Boolean determining whether this controller is assigned to any player</returns>
      public bool IsControllerAssigned(ControllerType controllerType, int controllerId) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.wuVFgvlYzhgvFDUrALeNLoLZLJC(controllerType, controllerId);

      /// <summary>
      /// Is the specified controller assigned to the specified player?
      /// </summary>
      /// <param name="controllerType">Type of controller</param>
      /// <param name="controllerId">Id of the controller</param>
      /// <param name="playerId">Id of the player</param>
      /// <returns>Boolean determining whether this controller is assigned to the player</returns>
      public bool IsControllerAssignedToPlayer(
        ControllerType controllerType,
        int controllerId,
        int playerId)
      {
        return ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.NMeMTcSDhBLyOwjxenYZBYgmWhX(controllerType, controllerId, playerId);
      }

      /// <summary>De-assigns the specified controller from all players.</summary>
      /// <param name="controller">The controller</param>
      /// <param name="includeSystemPlayer">Do we de-assign from the System player also?</param>
      public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
          return;
label_5:
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.kaQfXjIEMSaQpgeUoklyJivsBSd(controller, includeSystemPlayer);
        int num = 340689914;
        while (true)
        {
          switch (num ^ 340689914)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_5;
            case 2:
              num = 340689915;
              continue;
            default:
              goto label_6;
          }
        }
label_1:
        return;
label_6:;
      }

      /// <summary>De-assigns the specified controller from all players.</summary>
      /// <param name="controllerType">Tyoe of the controller</param>
      /// <param name="controllerId">Id of the controller</param>
      /// <param name="includeSystemPlayer">Do we de-assign from the System player also?</param>
      public void RemoveControllerFromAllPlayers(
        ControllerType controllerType,
        int controllerId,
        bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
        {
label_1:
          switch (-1327051339 ^ -1327051340)
          {
            case 0:
              goto label_1;
            case 1:
              return;
          }
        }
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.kaQfXjIEMSaQpgeUoklyJivsBSd(controllerType, controllerId, includeSystemPlayer);
      }

      /// <summary>Gets the primary Mouse controller.</summary>
      public Mouse Mouse => !ReInput.CheckInitialized() ? (Mouse) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.MARBRADmEmfcJPtkCcxtGpTRHGsv;

      /// <summary>Gets the primary Keyboard controller.</summary>
      public Keyboard Keyboard => !ReInput.CheckInitialized() ? (Keyboard) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.joGvYuxHrKMlBSIPrafbOeoYcUa;

      /// <summary>
      /// Enabled or disables keyboard input processing. Disabling keyboard input can improve performance on mobile devices.
      /// Also useful for joystick games on Android where certain joystick buttons return keyboard keycodes. Disabling keyboard input on Android will
      /// still allow certain keyboard keys to return values if triggered by a button press on a joystick, but no keyboard maps will ever be processed.
      /// </summary>
      [Obsolete("Deprecated: Use Controller.enabled instead. For example, to disable keyboard input: ReInput.controllers.Keyboard.enabled = false.")]
      public bool keyboardEnabled
      {
        get => ReInput.CheckInitialized() && this.Keyboard.enabled;
        set
        {
          if (!ReInput.CheckInitialized())
            return;
          this.Keyboard.enabled = value;
        }
      }

      /// <summary>The number of joysticks currently connected.</summary>
      public int joystickCount => !ReInput.CheckInitialized() ? 0 : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.xAVGDhciVoLcMXCqZYDqEoUzddsC;

      /// <summary>Get a collection of connected joysticks.</summary>
      /// <returns>List of Joysticks</returns>
      public IList<Joystick> Joysticks => !ReInput.CheckInitialized() ? EmptyObjects<Joystick>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;

      /// <summary>Gets a specific joystick.</summary>
      /// <param name="joystickId">The id of the joystick</param>
      /// <returns>The Joystick</returns>
      public Joystick GetJoystick(int joystickId) => !ReInput.CheckInitialized() ? (Joystick) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.JMbbzpNIbCJfWBuFXdrGKwigBcS(joystickId);

      /// <summary>
      /// Gets a collection of connected joysticks.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>Array of Joysticks</returns>
      public Joystick[] GetJoysticks() => ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.kfNyOpSjjEiHHORWBOpkcRITBwf();

      /// <summary>
      /// Gets an array of connected joystick names.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>Array of joystick names</returns>
      public string[] GetJoystickNames() => !ReInput.CheckInitialized() ? EmptyObjects<string>.array : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ZzcgxWbEPDqMODePlhtcfuoJaxKU();

      /// <summary>Is a specific Joystick assigned to any players?</summary>
      /// <param name="joystick">The Joystick</param>
      /// <returns>Boolean determining if the specified joystick is assigned to any players</returns>
      public bool IsJoystickAssigned(Joystick joystick) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.KkhuRtOyQTdOfACpmcvGqzpvhho(joystick);

      /// <summary>Is a specific Joystick assigned to any players?</summary>
      /// <param name="joystickId">Id of the Joystick</param>
      /// <returns>Boolean determining if the specified joystick is assigned to any players</returns>
      public bool IsJoystickAssigned(int joystickId) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.KkhuRtOyQTdOfACpmcvGqzpvhho(joystickId);

      /// <summary>Is a specific Joystick assigned to a specific player?</summary>
      /// <param name="joystickId">Id of the Joystick</param>
      /// <param name="playerId">Id of the Player</param>
      /// <returns>Boolean determining if the specified joystick is assigned to the specified player</returns>
      public bool IsJoystickAssignedToPlayer(int joystickId, int playerId) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.cGKaQMJdLAWocptFVWvrkSHyNJwG(joystickId, playerId);

      /// <summary>De-assigns a specific Joystick from all Players</summary>
      /// <param name="joystick">The Joystick</param>
      /// <param name="includeSystemPlayer">De-assign from System player also?</param>
      public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
          return;
label_5:
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.iFADhLmCPpxEBOkgMIOSeKMOdzV(joystick, includeSystemPlayer);
        int num = 1348436067;
        while (true)
        {
          switch (num ^ 1348436065)
          {
            case 0:
              num = 1348436064;
              continue;
            case 1:
              goto label_5;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_1:
        return;
label_6:;
      }

      /// <summary>De-assigns a specific Joystick from all Players</summary>
      /// <param name="joystickId">Id of the Joystick</param>
      /// <param name="includeSystemPlayer">De-assign from System player also?</param>
      public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
          return;
label_5:
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.iFADhLmCPpxEBOkgMIOSeKMOdzV(joystickId, includeSystemPlayer);
        int num = 849629853;
        while (true)
        {
          switch (num ^ 849629855)
          {
            case 0:
              num = 849629854;
              continue;
            case 1:
              goto label_5;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_1:
        return;
label_6:;
      }

      /// <summary>
      /// Returns the 0 based id of the Unity joystick whose button was pressed. -1 if no button was pressed on any joystick.
      /// Use this to identify joysticks when using Unity's input system.
      /// This has no effect if Unity Input is not handling input on the current platform.
      /// </summary>
      /// <returns>0-based index of the Unity joystick whose button was pressed</returns>
      public int GetUnityJoystickIdFromAnyButtonPress()
      {
        if (ReInput.CheckInitialized())
          goto label_13;
label_1:
        int num1 = 985163251;
label_2:
        int num2;
        int num3;
        bool flag;
        while (true)
        {
          switch (num1 ^ 985163255)
          {
            case 0:
              num1 = 985163250;
              continue;
            case 1:
              num2 = 0;
              num1 = 985163255;
              continue;
            case 3:
              flag = ReInput.unityInputBuffer.YHTHAqaesBxHzRWHPpGRQxUjuiH(num3, num2);
              num1 = 985163248;
              continue;
            case 4:
              goto label_12;
            case 5:
              if (num2 >= 20)
              {
                ++num3;
                num1 = 985163249;
                continue;
              }
              goto case 3;
            case 6:
              int num4;
              num1 = num4 = num3 < 16 ? 985163254 : (num4 = 985163253);
              continue;
            case 7:
              if (!flag)
              {
                ++num2;
                num1 = 985163250;
                continue;
              }
              goto label_16;
            case 8:
              goto label_1;
            case 9:
              num3 = 0;
              num1 = 985163249;
              continue;
            case 10:
              goto label_7;
            default:
              goto label_18;
          }
        }
label_7:
        Logger.LogWarning((object) "This can only used when Unity Input is handling input. This has no effect on this platform.");
        return -1;
label_12:
        return -1;
label_16:
        return num3 + 1;
label_18:
        return -1;
label_13:
        if (ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
        {
          ReInput.KbAWJExdjvbycHAQVaOPCCFbdcGG();
          num1 = 985163262;
          goto label_2;
        }
        else
        {
          num1 = 985163261;
          goto label_2;
        }
      }

      /// <summary>
      /// Returns the 0 based id of the Unity joystick whose button or axis was pressed. -1 if no button or axis was pressed on any joystick.
      /// Use this to identify joysticks when using Unity's input system.
      /// This has no effect if Unity Input is not handling input on the current platform.
      /// </summary>
      /// <returns>0-based index of the Unity joystick whose button or axis was pressed</returns>
      /// <param name="axisThreshold">Any axis value below this threshold will be ignored.</param>
      /// <param name="positiveAxesOnly">Ignore negative axis values.</param>
      public int GetUnityJoystickIdFromAnyButtonOrAxisPress(
        float axisThreshold,
        bool positiveAxesOnly)
      {
        if (ReInput.CheckInitialized())
          goto label_18;
label_1:
        int num1 = 1121205391;
label_2:
        int num2;
        int num3;
        bool flag1;
        int num4;
        bool flag2;
        while (true)
        {
          switch (num1 ^ 1121205381)
          {
            case 0:
              flag2 = ReInput.unityInputBuffer.gpnbuMJLnPeqFBWDjhFPWjMvDLkk(num2, num3, positiveAxesOnly);
              num1 = 1121205383;
              continue;
            case 1:
              num4 = 0;
              num1 = 1121205382;
              continue;
            case 2:
              if (!flag2)
              {
                ++num3;
                num1 = 1121205388;
                continue;
              }
              num1 = 1121205387;
              continue;
            case 3:
              if (num4 >= 20)
              {
                num3 = 0;
                num1 = 1121205388;
                continue;
              }
              goto case 6;
            case 5:
              goto label_20;
            case 6:
              flag1 = ReInput.unityInputBuffer.YHTHAqaesBxHzRWHPpGRQxUjuiH(num2, num4);
              num1 = 1121205390;
              continue;
            case 7:
              goto label_12;
            case 8:
              goto label_1;
            case 9:
              int num5;
              num1 = num5 = num3 >= 29 ? 1121205384 : (num5 = 1121205381);
              continue;
            case 10:
              goto label_17;
            case 11:
              if (flag1)
              {
                num1 = 1121205376;
                continue;
              }
              ++num4;
              num1 = 1121205382;
              continue;
            case 12:
              num1 = 1121205377;
              continue;
            case 13:
              ++num2;
              num1 = 1121205377;
              continue;
            case 14:
              goto label_3;
            default:
              if (num2 < 16)
                goto case 1;
              else
                goto label_25;
          }
        }
label_3:
        return num2 + 1;
label_12:
        Logger.LogWarning((object) "This can only used when Unity Input is handling input. This has no effect on this platform.");
        return -1;
label_17:
        return -1;
label_20:
        return num2 + 1;
label_25:
        return -1;
label_18:
        if (ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
        {
          ReInput.KbAWJExdjvbycHAQVaOPCCFbdcGG();
          num2 = 0;
          num1 = 1121205385;
          goto label_2;
        }
        else
        {
          num1 = 1121205378;
          goto label_2;
        }
      }

      /// <summary>
      /// Sets a Unity joystick as the input source of a Joystick.
      /// Use this to remap a joystick to its source when reconnected on platforms that use Unity Input.
      /// This has no effect if Unity Input is not handling input on the current platform.
      /// </summary>
      /// <param name="joystickId">The id of the Joystick whose input source you are remapping.</param>
      /// <param name="unityJoystickId">The 0 based index of the Unity joystick which will become the Joystick's new input source.</param>
      public void SetUnityJoystickId(int joystickId, int unityJoystickId)
      {
        if (ReInput.CheckInitialized())
          goto label_5;
label_1:
        int num = -2074990630;
label_2:
        switch (num ^ -2074990629)
        {
          case 0:
            goto label_1;
          case 1:
            return;
          case 3:
            break;
          case 4:
            return;
          default:
            goto label_7;
        }
label_5:
        if (!ReInput.FwHBikGgzpbsKzUoEaSEARcWtYXb)
        {
          Logger.LogWarning((object) "This can only used when Unity Input is handling input. This has no effect on this platform.");
          num = -2074990625;
          goto label_2;
        }
label_7:
        ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.SetUnityJoystickId(joystickId, unityJoystickId);
      }

      /// <summary>
      /// Sets a Unity joystick as the input source of a Joystick.
      /// The first Unity joystick that returns a button press will be assigned to the Joystick.
      /// While no buttons are pressed, this will return False. When a button press is detected, it will return True and assign the joystick id.
      /// </summary>
      /// <param name="joystickId">The id of the Joystick</param>
      /// <returns>True if a joystick button was pressed and a joystick id was assigned.</returns>
      public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1398021407;
label_2:
        switch (num ^ 1398021405)
        {
          case 1:
            return false;
          case 2:
            return false;
          case 3:
            goto label_1;
          default:
            return true;
        }
label_4:
        int fromAnyButtonPress = this.GetUnityJoystickIdFromAnyButtonPress();
        if (fromAnyButtonPress < 1)
        {
          num = 1398021404;
          goto label_2;
        }
        else
        {
          this.SetUnityJoystickId(joystickId, fromAnyButtonPress);
          num = 1398021405;
          goto label_2;
        }
      }

      /// <summary>
      /// Sets a Unity joystick as the input source of a Joystick.
      /// The first Unity joystick that returns a button or axis press will be assigned to the Joystick.
      /// While no buttons or axes are pressed, this will return False. When a press is detected, it will return True and assign the joystick id.
      /// </summary>
      /// <param name="joystickId">The id of the Joystick</param>
      /// <returns>True if a joystick button was pressed and a joystick id was assigned.</returns>
      /// <param name="axisThreshold">Any axis value below this threshold will be ignored.</param>
      /// <param name="positiveAxesOnly">Ignore negative axis values.</param>
      public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(
        int joystickId,
        float axisThreshold,
        bool positiveAxesOnly)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1796216463;
label_2:
        int buttonOrAxisPress;
        while (true)
        {
          switch (num ^ -1796216464)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              if (buttonOrAxisPress >= 1)
              {
                this.SetUnityJoystickId(joystickId, buttonOrAxisPress);
                num = -1796216464;
                continue;
              }
              num = -1796216460;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_9;
          }
        }
label_3:
        return false;
label_5:
        return false;
label_9:
        return true;
label_4:
        buttonOrAxisPress = this.GetUnityJoystickIdFromAnyButtonOrAxisPress(axisThreshold, positiveAxesOnly);
        num = -1796216461;
        goto label_2;
      }

      /// <summary>The number of custom controllers</summary>
      public int customControllerCount => !ReInput.CheckInitialized() ? 0 : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.zDlVcIajKRmRPmIhGDDlrWdtglk;

      /// <summary>Get a collection of connected custom controllers.</summary>
      /// <returns>List of Custom Controllers</returns>
      public IList<CustomController> CustomControllers => !ReInput.CheckInitialized() ? EmptyObjects<CustomController>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;

      /// <summary>Gets a specific custom controller</summary>
      /// <param name="customControllerId">The id of the custom controller</param>
      /// <returns>The Custom Controller</returns>
      public CustomController GetCustomController(int customControllerId) => !ReInput.CheckInitialized() ? (CustomController) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.tloaGvHYSAbJLUTjtGjumUAWpvdg(customControllerId);

      /// <summary>
      /// Get a collection of connected custom controllers.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>CustomController[]</returns>
      public CustomController[] GetCustomControllers() => !ReInput.CheckInitialized() ? EmptyObjects<CustomController>.array : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.EXBlQnYlciPNvABewEdgajPbJQs();

      /// <summary>
      /// Get an array of connected custom controller names.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <returns>string[]</returns>
      public string[] GetCustomControllerNames() => !ReInput.CheckInitialized() ? EmptyObjects<string>.array : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.SJHskNsRtGeyWJfgeoLdUqsBCdu();

      /// <summary>
      /// Is a specific Custom Controller assigned to any players?
      /// </summary>
      /// <param name="customController">The Custom Controller</param>
      /// <returns>Boolean determining if the specified custom controller is assigned to any players</returns>
      public bool IsCustomControllerAssigned(CustomController customController) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.TVXRRCXAHfeufVWVMHwndMWNvgy(customController);

      /// <summary>
      /// Is a specific Custom Controller assigned to any players?
      /// </summary>
      /// <param name="customControllerId">Id of the Custom Controller</param>
      /// <returns>Boolean determining if the specified custom controller is assigned to any players</returns>
      public bool IsCustomControllerAssigned(int customControllerId) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.TVXRRCXAHfeufVWVMHwndMWNvgy(customControllerId);

      /// <summary>
      /// Is a specific Custom Controller assigned to a specific player?
      /// </summary>
      /// <param name="customControllerId">Id of the Custom Controller</param>
      /// <param name="playerId">Id of the Player</param>
      /// <returns>Boolean determining if the specified custom controller is assigned to the specified player</returns>
      public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId) => ReInput.CheckInitialized() && ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.IYnpWicndlTQrCLpWSDalZBKdgT(customControllerId, playerId);

      /// <summary>
      /// De-assigns a specific Custom Controller from all Players
      /// </summary>
      /// <param name="customController">The Custom Controller</param>
      /// <param name="includeSystemPlayer">De-assign from System player also?</param>
      public void RemoveCustomControllerFromAllPlayers(
        CustomController customController,
        bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
          return;
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.psJwzqvGcnbVLvvznMUjsRtWkVJ(customController, includeSystemPlayer);
      }

      /// <summary>
      /// De-assigns a specific Custom Controller from all Players
      /// </summary>
      /// <param name="customControllerId">Id of the Custom Controller</param>
      /// <param name="includeSystemPlayer">De-assign from System player also?</param>
      public void RemoveCustomControllerFromAllPlayers(
        int customControllerId,
        bool includeSystemPlayer = true)
      {
        if (!ReInput.CheckInitialized())
          return;
label_5:
        ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.psJwzqvGcnbVLvvznMUjsRtWkVJ(customControllerId, includeSystemPlayer);
        int num = -1986912454;
        while (true)
        {
          switch (num ^ -1986912454)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_5;
            case 2:
              num = -1986912453;
              continue;
            default:
              goto label_6;
          }
        }
label_1:
        return;
label_6:;
      }

      /// <summary>
      /// Create a new CustomController object from a source definition in the Rewired Input Manager.
      /// </summary>
      /// <param name="sourceControllerId">Source id of the CustomController definition</param>
      /// <returns>CustomController</returns>
      public CustomController CreateCustomController(int sourceControllerId) => !ReInput.CheckInitialized() ? (CustomController) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.CVCkxTVUUVrkYByYoNJxBsfdHY(sourceControllerId);

      /// <summary>
      /// Create a new CustomController object from a source definition in the Rewired Input Manager.
      /// </summary>
      /// <param name="sourceControllerId">Source id of the CustomController definition</param>
      /// <param name="tag">Tag to assign</param>
      /// <returns>CustomController</returns>
      public CustomController CreateCustomController(
        int sourceControllerId,
        string tag)
      {
        if (!ReInput.CheckInitialized())
          return (CustomController) null;
        CustomController customController = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.CVCkxTVUUVrkYByYoNJxBsfdHY(sourceControllerId);
        if (customController == null)
          return (CustomController) null;
        customController.tag = tag;
        return customController;
      }

      /// <summary>Destroys a CustomController.</summary>
      /// <param name="customController">The Custom Controller</param>
      /// <returns>Sucess/fail</returns>
      public bool DestroyCustomController(CustomController customController)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1413591414;
label_2:
        switch (num ^ 1413591415)
        {
          case 0:
            goto label_1;
          case 1:
            return false;
          default:
            return ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.MjozHblkgMZvcGNgCDKAFxpttwyf(customController);
        }
label_4:
        if (customController == null)
          return false;
        this.RemoveCustomControllerFromAllPlayers(customController);
        num = 1413591413;
        goto label_2;
      }

      /// <summary>
      /// Finds the first CustomController that has a matching source id.
      /// </summary>
      /// <param name="sourceId">Source id of the CustomController definition</param>
      /// <returns>CustomController</returns>
      public CustomController GetFirstCustomControllerWithSourceId(int sourceId) => !ReInput.CheckInitialized() ? (CustomController) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ZautujjBNCDToVDPSeGCkskSBKe(sourceId);

      /// <summary>
      /// Finds the first CustomController that has a matching tag.
      /// </summary>
      /// <param name="tag">Tag of the CustomController</param>
      /// <returns>CustomController</returns>
      public CustomController GetFirstCustomControllerWithTag(string tag) => !ReInput.CheckInitialized() ? (CustomController) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.CzyajXUwQWaDAmaqpdTBEQFRPag(tag);

      /// <summary>
      /// Enumerates all CustomControllers with a matching source id.
      /// </summary>
      /// <param name="sourceId">Source id of the CustomController definition</param>
      /// <returns>CustomControllers enumeration</returns>
      public IEnumerable<CustomController> CustomControllersWithSourceId(
        int sourceId)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<CustomController>) EmptyObjects<CustomController>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.FomovZlIprNNKXReWkqCLvwpSAJ(sourceId);
      }

      /// <summary>Enumerates all CustomControllers with a matching tag.</summary>
      /// <param name="tag">Tag of the CustomController</param>
      /// <returns>CustomControllers enumeration</returns>
      public IEnumerable<CustomController> CustomControllersWithTag(
        string tag)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<CustomController>) EmptyObjects<CustomController>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.vwBUMNQhkDXnbjEGtifgBraOazd(tag);
      }

      /// <summary>
      /// Gets a list of all Controller Templates in connected Controllers that match the type.
      /// </summary>
      /// <typeparam name="TInterface">Controller Template interface type. Note: You must use the interface of the Controller Template and not the concrete class.</typeparam>
      /// <returns></returns>
      public IList<TInterface> GetControllerTemplates<TInterface>() where TInterface : IControllerTemplate => !ReInput.CheckInitialized() ? EmptyObjects<TInterface>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.LpTWLkOfPEqdDLQlWNtqDEecAeB<TInterface>();

      /// <summary>
      /// Get the last controller that produced input.
      /// If there is no last active controller, the Keyboard will be returned.
      /// </summary>
      /// <returns>Last active Controller</returns>
      public Controller GetLastActiveController() => !ReInput.CheckInitialized() ? (Controller) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.WzVNQNKedYrHIuGIhGERdvLGlpW();

      /// <summary>
      /// Get the last controller that produced input.
      /// If there is no last active controller of the specified type, the return value will be null.
      /// </summary>
      /// <param name="controllerType">The controller type.</param>
      /// <returns>Controller</returns>
      public Controller GetLastActiveController(ControllerType controllerType) => !ReInput.CheckInitialized() ? (Controller) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.WzVNQNKedYrHIuGIhGERdvLGlpW(controllerType);

      /// <summary>
      /// Get the last controller that produced input.
      /// If there is no last active controller of the specified type, the return value will be null.
      /// </summary>
      /// <typeparam name="T">Controller type</typeparam>
      /// <returns>Controller</returns>
      public T GetLastActiveController<T>() where T : Controller => !ReInput.CheckInitialized() ? default (T) : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.WzVNQNKedYrHIuGIhGERdvLGlpW<T>();

      /// <summary>
      /// Get the controller type of the last controllerthat produced input.
      /// If there is no last active controller, ControllerType.Keyboard is returned.
      /// </summary>
      /// <returns>Last active Controller</returns>
      public ControllerType GetLastActiveControllerType() => !ReInput.CheckInitialized() ? ControllerType.Keyboard : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.QwqeLwyZvQkjgehFncHcDZWqtheO();

      /// <summary>
      /// Add a delegate to receive a callback every time the last active controller changes.
      /// </summary>
      /// <param name="callback">The delegate that will be called.</param>
      public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
      {
        if (ReInput.CheckInitialized())
          goto label_5;
label_1:
        int num = -287743626;
label_2:
        switch (num ^ -287743628)
        {
          case 0:
            goto label_1;
          case 1:
            break;
          case 2:
            return;
          case 3:
            return;
          default:
            return;
        }
label_5:
        ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ALOxoevwHaFjRuNCxnCCrAtSYxG(callback);
        num = -287743625;
        goto label_2;
      }

      /// <summary>
      /// Add a delegate to receive a callback every time the last active controller of a specific type changes.
      /// </summary>
      /// <param name="callback">The delegate that will be called.</param>
      /// <param name="controllerType">The controller type for which to listen for changes.</param>
      public void AddLastActiveControllerChangedDelegate(
        ActiveControllerChangedDelegate callback,
        ControllerType controllerType)
      {
        if (ReInput.CheckInitialized())
          goto label_5;
label_1:
        int num = -257276620;
label_2:
        switch (num ^ -257276617)
        {
          case 0:
            break;
          case 1:
            return;
          case 2:
            goto label_1;
          case 3:
            return;
          default:
            return;
        }
label_5:
        ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.ALOxoevwHaFjRuNCxnCCrAtSYxG(callback, controllerType);
        num = -257276618;
        goto label_2;
      }

      /// <summary>
      /// Remove a delegate to no longer receive callbacks when the last active controller changes.
      /// </summary>
      /// <param name="callback">The delegate that will be called.</param>
      public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
      {
        if (ReInput.CheckInitialized())
          goto label_5;
label_1:
        int num = 1396025368;
label_2:
        switch (num ^ 1396025370)
        {
          case 0:
            goto label_1;
          case 1:
            return;
          case 2:
            return;
          case 3:
            break;
          default:
            return;
        }
label_5:
        ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.GCvvCfTzBopgqBNBpBABAfZrglfQ(callback);
        num = 1396025371;
        goto label_2;
      }

      /// <summary>
      /// Remove a delegate to no longer receive callbacks when the last active controller of a specific type changes.
      /// </summary>
      /// <param name="callback">The delegate that will be called.</param>
      /// <param name="controllerType">The controller type for which to listen for changes.</param>
      public void RemoveLastActiveControllerChangedDelegate(
        ActiveControllerChangedDelegate callback,
        ControllerType controllerType)
      {
        if (!ReInput.CheckInitialized())
        {
label_1:
          switch (1200782240 ^ 1200782241)
          {
            case 0:
              goto label_1;
            case 1:
              return;
          }
        }
        ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.jrLpNuhBdgMTdxmieHSqbSQCOWd(callback, controllerType);
      }

      /// <summary>
      /// Remove all delegates to no longer receive any callbacks when the last active controller changes.
      /// </summary>
      public void ClearLastActiveControllerChangedDelegates()
      {
        if (!ReInput.CheckInitialized())
          return;
label_5:
        ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.tJtAZiNKoTZsBCslxkqjLNKYISM();
        int num = -1985863943;
        while (true)
        {
          switch (num ^ -1985863941)
          {
            case 0:
              num = -1985863942;
              continue;
            case 1:
              goto label_5;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_1:
        return;
label_6:;
      }

      /// <summary>
      /// Get the button held state of all buttons on all controllers. Returns TRUE if any button is held.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <returns>Button held state</returns>
      public bool GetAnyButton() => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.sBhTJbnLOXWersNOJGnxRLkdGme();

      /// <summary>
      /// Get the button held state of all buttons on all controllers of a specified type. Returns TRUE if any button is held.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <returns>Button held state</returns>
      public bool GetAnyButton(ControllerType controllerType) => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.sBhTJbnLOXWersNOJGnxRLkdGme(controllerType);

      /// <summary>
      /// Get the button just pressed state of all buttons on all controllers. This will only return TRUE only on the first frame a button is pressed.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <returns>Button just pressed state</returns>
      public bool GetAnyButtonDown() => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.wWutDOBcygZlEbhlhUjbdJDYKHH();

      /// <summary>
      /// Get the button just pressed state of all buttons on all controllers of a specified type. This will only return TRUE only on the first frame a button is pressed.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <returns>Button just pressed state</returns>
      public bool GetAnyButtonDown(ControllerType controllerType) => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.wWutDOBcygZlEbhlhUjbdJDYKHH(controllerType);

      /// <summary>
      /// Get the button just released state of all buttons on all controllers of a specified type. This will only return TRUE only on the first frame a button is released.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <returns>Button just released state</returns>
      public bool GetAnyButtonUp() => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.IyrAKMlpZFNcVneehGEKCUwvFIBM();

      /// <summary>
      /// Get the button just released state of all buttons on all controllers of a specified type. This will only return TRUE only on the first frame a button is released.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <returns>Button just released state</returns>
      public bool GetAnyButtonUp(ControllerType controllerType) => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.IyrAKMlpZFNcVneehGEKCUwvFIBM(controllerType);

      /// <summary>
      /// Returns true if any button has changed state from the previous frame to the current.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <returns>Button changed state</returns>
      public bool GetAnyButtonChanged() => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.TStgqNkVHeOeLOTGbmGbCPullhV();

      /// <summary>
      /// Returns true if any button has changed state from the previous frame to the current.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <returns>Button changed state</returns>
      public bool GetAnyButtonChanged(ControllerType controllerType) => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.TStgqNkVHeOeLOTGbmGbCPullhV(controllerType);

      /// <summary>
      /// Get the previous button held state of all buttons on all controllers. Returns TRUE if any button was held in the previous frame.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <returns>Previous button held state</returns>
      public bool GetAnyButtonPrev() => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.QbmHVitVXivtdlHovCAmMCsWaW();

      /// <summary>
      /// Get the previous button held state of all buttons on all controllers of a specified type. Returns TRUE if any button was held in the previous frame.
      /// This retrieves the value from the actual hardware buttons, not Actions as mapped by Controller Maps in Player.
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <returns>Previous button held state</returns>
      public bool GetAnyButtonPrev(ControllerType controllerType) => ReInput.CheckInitialized() && ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.QbmHVitVXivtdlHovCAmMCsWaW(controllerType);

      /// <summary>
      /// Auto-assigns a Joystick to a Player based on the joystick auto-assignment settings in the Rewired Input Manager.
      /// If the Joystick is already assigned to a Player, the Joystick will not be re-assigned.
      /// </summary>
      /// <param name="joystick">Joystick to assign to a Player.</param>
      /// <returns>True if the Joystick was assigned to a Player.</returns>
      public bool AutoAssignJoystick(Joystick joystick)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 605536038;
label_2:
        switch (num ^ 605536037)
        {
          case 0:
            goto label_1;
          case 2:
            return false;
          case 3:
            return false;
          default:
            return this.IsJoystickAssigned(joystick);
        }
label_4:
        if (joystick == null)
        {
          num = 605536039;
          goto label_2;
        }
        else
        {
          if (this.IsJoystickAssigned(joystick))
            return true;
          ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.lCdgedfNHxIZeQUYOvHaHdqCAmOu(joystick);
          num = 605536036;
          goto label_2;
        }
      }

      /// <summary>
      /// Auto-assigns all unassigned Joysticks to Players based on the joystick auto-assignment settings in the Rewired Input Manager.
      /// </summary>
      public void AutoAssignJoysticks()
      {
        if (ReInput.CheckInitialized())
          goto label_5;
label_1:
        int num1 = 1145063328;
label_2:
        IList<Joystick> joysticks;
        int index;
        int joystickCount;
        while (true)
        {
          switch (num1 ^ 1145063333)
          {
            case 0:
              joysticks = this.Joysticks;
              index = 0;
              num1 = 1145063329;
              continue;
            case 1:
              goto label_5;
            case 2:
              this.AutoAssignJoystick(joysticks[index]);
              ++index;
              num1 = 1145063329;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num2;
              num1 = num2 = index >= joystickCount ? 1145063331 : (num2 = 1145063335);
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_7:
        return;
label_9:
        return;
label_5:
        joystickCount = this.joystickCount;
        num1 = 1145063333;
        goto label_2;
      }

      /// <summary>
      /// Provides access to controller element polling-related members.
      /// This should only be used for controller mapping or other non-gameplay-related code.
      /// The polling system is expensive and should not be used during gameplay.
      /// </summary>
      [Browsable(false)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public sealed class PollingHelper : CodeHelper
      {
        private static ReInput.ControllerHelper.PollingHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;

        internal static ReInput.ControllerHelper.PollingHelper Instance => ReInput.ControllerHelper.PollingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.ControllerHelper.PollingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.ControllerHelper.PollingHelper());

        private PollingHelper()
        {
        }

        /// <summary>
        /// Poll every connected controller and gets information about the first element that is activated.
        /// Does not return Player information. If you need information about the Player, poll through Player instead.
        /// </summary>
        /// <returns>ControllerPollingInfo</returns>
        public ControllerPollingInfo PollAllControllersForFirstElement()
        {
          if (ReInput.CheckInitialized())
            goto label_15;
label_1:
          int num = 1396078993;
label_2:
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ 1396078998)
            {
              case 0:
                goto label_1;
              case 1:
                if (controllerPollingInfo.success)
                {
                  num = 1396078997;
                  continue;
                }
                controllerPollingInfo = this.sLHsjIJPZaWknPgIFADcCbIUBVwF();
                num = 1396078996;
                continue;
              case 2:
                if (controllerPollingInfo.success)
                {
                  num = 1396078995;
                  continue;
                }
                goto label_19;
              case 3:
                goto label_16;
              case 4:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.rIXwpWaADtNlMdRJNdauptPhASr();
                  num = 1396078999;
                  continue;
                }
                num = 1396079006;
                continue;
              case 6:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
                  num = 1396078994;
                  continue;
                }
                goto label_10;
              case 7:
                goto label_14;
              case 8:
                goto label_5;
              default:
                goto label_18;
            }
          }
label_5:
          return controllerPollingInfo;
label_10:
          return controllerPollingInfo;
label_14:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_16:
          return controllerPollingInfo;
label_18:
          return controllerPollingInfo;
label_19:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_15:
          controllerPollingInfo = this.xqEJnUvhRVeAxBFeBqTieJaboxrq();
          num = 1396078992;
          goto label_2;
        }

        public ControllerPollingInfo PollAllControllersForFirstElementDown()
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          ControllerPollingInfo controllerPollingInfo = this.vQAVedbMIlMSqYGiTLIrjfyFqBk();
          if (controllerPollingInfo.success)
            return controllerPollingInfo;
          controllerPollingInfo = this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
          if (!controllerPollingInfo.success)
            goto label_8;
label_5:
          int num = -1248889075;
label_6:
          while (true)
          {
            switch (num ^ -1248889076)
            {
              case 0:
                goto label_5;
              case 1:
                goto label_7;
              case 3:
                goto label_9;
              case 4:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.HOmfMafVbeqBKHuJhXAmiGrtAdsT();
                  num = -1248889074;
                  continue;
                }
                num = -1248889073;
                continue;
              default:
                goto label_13;
            }
          }
label_7:
          return controllerPollingInfo;
label_9:
          return controllerPollingInfo;
label_13:
          return controllerPollingInfo.success ? controllerPollingInfo : ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_8:
          controllerPollingInfo = this.iLSagMAvxdljFVsINVEQGdQksRyn();
          num = -1248889080;
          goto label_6;
        }

        public ControllerPollingInfo PollAllControllersForFirstButton()
        {
          if (ReInput.CheckInitialized())
            goto label_10;
label_1:
          int num = 131778017;
label_2:
          ControllerPollingInfo controllerPollingInfo1;
          ControllerPollingInfo controllerPollingInfo2;
          while (true)
          {
            switch (num ^ 131778023)
            {
              case 0:
                goto label_3;
              case 1:
                if (!controllerPollingInfo1.success)
                {
                  controllerPollingInfo1 = this.datDCmYtFkfMzKwxjFkLiXkBKTX();
                  num = 131778021;
                  continue;
                }
                goto label_12;
              case 2:
                if (controllerPollingInfo1.success)
                {
                  num = 131778019;
                  continue;
                }
                goto label_17;
              case 3:
                if (!controllerPollingInfo1.success)
                {
                  controllerPollingInfo2 = this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
                  if (!controllerPollingInfo2.success)
                  {
                    controllerPollingInfo1 = this.uFqRfvVjeHljJGJXGmHJYbeBMpN();
                    num = 131778022;
                    continue;
                  }
                  goto label_5;
                }
                else
                {
                  num = 131778023;
                  continue;
                }
              case 5:
                goto label_1;
              case 6:
                goto label_9;
              default:
                goto label_16;
            }
          }
label_3:
          return controllerPollingInfo1;
label_5:
          return controllerPollingInfo2;
label_9:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_12:
          return controllerPollingInfo1;
label_16:
          return controllerPollingInfo1;
label_17:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_10:
          controllerPollingInfo1 = this.XvOzsTsFKLrbAslgHosnAPxBtiI();
          num = 131778020;
          goto label_2;
        }

        public ControllerPollingInfo PollAllControllersForFirstButtonDown()
        {
          if (ReInput.CheckInitialized())
            goto label_12;
label_1:
          int num = -952227498;
label_2:
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ -952227497)
            {
              case 0:
                if (controllerPollingInfo.success)
                {
                  num = -952227499;
                  continue;
                }
                goto label_18;
              case 1:
                goto label_11;
              case 3:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.RktKkCMQsffwZbSFZCSIltaRhipF();
                  num = -952227497;
                  continue;
                }
                num = -952227504;
                continue;
              case 4:
                goto label_1;
              case 5:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.YwtGMeusfCVLDpOIQteDlhwhUvY();
                  num = -952227500;
                  continue;
                }
                goto label_4;
              case 6:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
                  num = -952227502;
                  continue;
                }
                goto label_7;
              case 7:
                goto label_9;
              default:
                goto label_17;
            }
          }
label_4:
          return controllerPollingInfo;
label_7:
          return controllerPollingInfo;
label_9:
          return controllerPollingInfo;
label_11:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_17:
          return controllerPollingInfo;
label_18:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_12:
          controllerPollingInfo = this.JkwAAJkeuhfqxpGvmZgJadVmNka();
          num = -952227503;
          goto label_2;
        }

        public ControllerPollingInfo PollAllControllersForFirstAxis()
        {
          if (ReInput.CheckInitialized())
            goto label_10;
label_1:
          int num = -811847038;
label_2:
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ -811847037)
            {
              case 0:
                if (controllerPollingInfo.success)
                {
                  num = -811847034;
                  continue;
                }
                goto label_20;
              case 1:
                goto label_9;
              case 2:
                if (controllerPollingInfo.success)
                {
                  num = -811847035;
                  continue;
                }
                controllerPollingInfo = ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
                num = -811847029;
                continue;
              case 3:
                goto label_5;
              case 4:
                goto label_13;
              case 6:
                goto label_15;
              case 7:
                if (controllerPollingInfo.success)
                {
                  num = -811847033;
                  continue;
                }
                controllerPollingInfo = this.oglTdYDgsevEIMHyxSzzjHmmiea();
                num = -811847037;
                continue;
              case 8:
                if (!controllerPollingInfo.success)
                {
                  controllerPollingInfo = this.oQUEBkbVxYyoxPBIimcLSVCYWggh();
                  num = -811847036;
                  continue;
                }
                num = -811847040;
                continue;
              case 9:
                goto label_1;
              default:
                goto label_19;
            }
          }
label_5:
          return controllerPollingInfo;
label_9:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_13:
          return controllerPollingInfo;
label_15:
          return controllerPollingInfo;
label_19:
          return controllerPollingInfo;
label_20:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_10:
          controllerPollingInfo = this.CtVpOuLQOkBPDmrcczxWDQeluex();
          num = -811847039;
          goto label_2;
        }

        public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(
          ControllerType controllerType)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 152326489;
label_2:
          ControllerType controllerType1;
          while (true)
          {
            switch (num ^ 152326488)
            {
              case 0:
                goto label_12;
              case 1:
                goto label_3;
              case 2:
                if (controllerType1 != ControllerType.Custom)
                {
                  num = 152326488;
                  continue;
                }
                goto label_11;
              case 3:
                goto label_1;
              default:
                goto label_8;
            }
          }
label_3:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_11:
          return this.sLHsjIJPZaWknPgIFADcCbIUBVwF();
label_12:
          throw new NotImplementedException();
label_4:
          controllerType1 = controllerType;
          switch (controllerType1)
          {
            case ControllerType.Keyboard:
              return this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
            case ControllerType.Mouse:
              return this.rIXwpWaADtNlMdRJNdauptPhASr();
            case ControllerType.Joystick:
              break;
            default:
              num = 152326490;
              goto label_2;
          }
label_8:
          return this.xqEJnUvhRVeAxBFeBqTieJaboxrq();
        }

        public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(
          ControllerType controllerType)
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
            case ControllerType.Mouse:
              return this.iLSagMAvxdljFVsINVEQGdQksRyn();
            case ControllerType.Joystick:
              return this.vQAVedbMIlMSqYGiTLIrjfyFqBk();
            case ControllerType.Custom:
              return this.HOmfMafVbeqBKHuJhXAmiGrtAdsT();
            default:
              throw new NotImplementedException();
          }
        }

        public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(
          ControllerType controllerType)
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
            case ControllerType.Mouse:
              return this.uFqRfvVjeHljJGJXGmHJYbeBMpN();
            case ControllerType.Joystick:
label_4:
              return this.XvOzsTsFKLrbAslgHosnAPxBtiI();
            case ControllerType.Custom:
              return this.datDCmYtFkfMzKwxjFkLiXkBKTX();
            default:
label_3:
              switch (507153444 ^ 507153445)
              {
                case 1:
                  throw new NotImplementedException();
                case 2:
                  goto label_3;
                default:
                  goto label_4;
              }
          }
        }

        public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(
          ControllerType controllerType)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = -1664878691;
label_2:
          ControllerType controllerType1;
          while (true)
          {
            switch (num ^ -1664878692)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_3;
              case 2:
                if (controllerType1 != ControllerType.Custom)
                {
                  num = -1664878689;
                  continue;
                }
                goto label_12;
              case 3:
                goto label_13;
              case 5:
                switch (controllerType1)
                {
                  case ControllerType.Keyboard:
                    goto label_10;
                  case ControllerType.Mouse:
                    goto label_11;
                  case ControllerType.Joystick:
                    goto label_9;
                  default:
                    num = -1664878690;
                    continue;
                }
              default:
                goto label_9;
            }
          }
label_3:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_9:
          return this.JkwAAJkeuhfqxpGvmZgJadVmNka();
label_10:
          return this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
label_11:
          return this.YwtGMeusfCVLDpOIQteDlhwhUvY();
label_12:
          return this.RktKkCMQsffwZbSFZCSIltaRhipF();
label_13:
          throw new NotImplementedException();
label_4:
          controllerType1 = controllerType;
          num = -1664878695;
          goto label_2;
        }

        public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(
          ControllerType controllerType)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = -444182429;
label_2:
          switch (num ^ -444182432)
          {
            case 0:
              goto label_1;
            case 2:
              throw new NotImplementedException();
            case 3:
              return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
            default:
              goto label_6;
          }
label_4:
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
            case ControllerType.Mouse:
              return this.oQUEBkbVxYyoxPBIimcLSVCYWggh();
            case ControllerType.Joystick:
              break;
            case ControllerType.Custom:
              return this.oglTdYDgsevEIMHyxSzzjHmmiea();
            default:
              num = -444182430;
              goto label_2;
          }
label_6:
          return this.CtVpOuLQOkBPDmrcczxWDQeluex();
        }

        public ControllerPollingInfo PollControllerForFirstElement(
          ControllerType controllerType,
          int controllerId)
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
            case ControllerType.Mouse:
              return this.rIXwpWaADtNlMdRJNdauptPhASr();
            case ControllerType.Joystick:
label_4:
              return this.pxOYAWOjmkiXKQODqfkVKMoXVKER(controllerId);
            case ControllerType.Custom:
              return this.meWUDZRPiTlVFHYLsGzwYgJTBkE(controllerId);
            default:
label_3:
              switch (-825606218 ^ -825606217)
              {
                case 1:
                  throw new NotImplementedException();
                case 2:
                  goto label_3;
                default:
                  goto label_4;
              }
          }
        }

        public ControllerPollingInfo PollControllerForFirstElementDown(
          ControllerType controllerType,
          int controllerId)
        {
          if (!ReInput.CheckInitialized())
          {
label_1:
            switch (185732527 ^ 185732526)
            {
              case 0:
                goto label_1;
              case 1:
                return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
            }
          }
          else
          {
            switch (controllerType)
            {
              case ControllerType.Keyboard:
                return this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
              case ControllerType.Mouse:
                return this.iLSagMAvxdljFVsINVEQGdQksRyn();
              case ControllerType.Joystick:
                break;
              case ControllerType.Custom:
                return this.YUauzKJFRsvFgxZYjLkQeZGaMLT(controllerId);
              default:
                throw new NotImplementedException();
            }
          }
          return this.xWmGlWCjhydBnFwrRcHWjaSBnkrN(controllerId);
        }

        public ControllerPollingInfo PollControllerForFirstButton(
          ControllerType controllerType,
          int controllerId)
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          ControllerType controllerType1 = controllerType;
label_3:
          switch (-870098716 ^ -870098715)
          {
            case 0:
              goto label_3;
            case 1:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  return this.JpyRHYiTCaDlEgsNPfyBRmSPBVf();
                case ControllerType.Mouse:
                  return this.uFqRfvVjeHljJGJXGmHJYbeBMpN();
                case ControllerType.Joystick:
                  break;
                case ControllerType.Custom:
                  return this.ZlPUXUeskMeIPFTfONOIYLdaFRmH(controllerId);
                default:
                  throw new NotImplementedException();
              }
              break;
          }
          return this.LntjQBAQCBrOFWHnQmOqxcmPuHH(controllerId);
        }

        public ControllerPollingInfo PollControllerForFirstButtonDown(
          ControllerType controllerType,
          int controllerId)
        {
          if (!ReInput.CheckInitialized())
            return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.eFMhTuQqJhfMkTiSAYKiiZHmGGX();
            case ControllerType.Mouse:
              return this.YwtGMeusfCVLDpOIQteDlhwhUvY();
            case ControllerType.Joystick:
label_4:
              return this.BhrbcPMCtluJnuqbIfIxJTKvjgo(controllerId);
            case ControllerType.Custom:
              return this.ELqiJjzwsunjVyajjKIEKixkbcv(controllerId);
            default:
label_3:
              switch (1115504842 ^ 1115504840)
              {
                case 0:
                  goto label_3;
                case 2:
                  throw new NotImplementedException();
                default:
                  goto label_4;
              }
          }
        }

        public ControllerPollingInfo PollControllerForFirstAxis(
          ControllerType controllerType,
          int controllerId)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 1090835245;
label_2:
          ControllerType controllerType1;
          while (true)
          {
            switch (num ^ 1090835246)
            {
              case 0:
                goto label_1;
              case 2:
                switch (controllerType1)
                {
                  case ControllerType.Keyboard:
                    goto label_10;
                  case ControllerType.Mouse:
                    goto label_11;
                  case ControllerType.Joystick:
                    goto label_9;
                  default:
                    num = 1090835243;
                    continue;
                }
              case 3:
                goto label_3;
              case 4:
                goto label_13;
              case 5:
                if (controllerType1 != ControllerType.Custom)
                {
                  num = 1090835242;
                  continue;
                }
                goto label_12;
              default:
                goto label_9;
            }
          }
label_3:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_9:
          return this.azKcgDyqbHBSJlZqsuFpQQWdTCe(controllerId);
label_10:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_11:
          return this.oQUEBkbVxYyoxPBIimcLSVCYWggh();
label_12:
          return this.gZYAAEbMDKuaCELRQnsReJIDvmiS(controllerId);
label_13:
          throw new NotImplementedException();
label_4:
          controllerType1 = controllerType;
          num = 1090835244;
          goto label_2;
        }

        /// <summary>
        /// Poll every connected controller and gets information about all elements that are activated.
        /// Does not return Player information. If you need information about the Player, poll through Player instead.
        /// </summary>
        /// <returns>IEnumerable of ControllerPollingInfo</returns>
        public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = -1506198425;
            ControllerPollingInfo current1;
            ControllerPollingInfo current2;
            ControllerPollingInfo current3;
            IEnumerator<ControllerPollingInfo> enumerator1;
            IEnumerator<ControllerPollingInfo> enumerator2;
            IEnumerator<ControllerPollingInfo> enumerator3;
            IEnumerator<ControllerPollingInfo> enumerator4;
            while (true)
            {
              switch (num1 ^ -1506198418)
              {
                case 0:
label_35:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -1506198450;
                  continue;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  this.ywPJmmOACbVABbGNxDZoPsnHoSH();
                  num1 = -1506198424;
                  continue;
                case 2:
label_34:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = -1506198406;
                  continue;
                case 3:
                  enumerator1 = this.QEfvrPMkROvCVvoTWLADrywyOYj().GetEnumerator();
                  num1 = -1506198405;
                  continue;
                case 4:
                  current1 = enumerator1.Current;
                  num1 = -1506198413;
                  continue;
                case 5:
                  // ISSUE: reference to a compiler-generated method
                  this.lfSOFTgjQTMLuGAGGJCBqbTCOXO();
                  num1 = -1506198449;
                  continue;
                case 7:
                  num1 = -1506198431;
                  continue;
                case 8:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 8;
                  num1 = -1506198432;
                  continue;
                case 9:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_25;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                      goto label_39;
                    case 2:
                      goto label_35;
                    case 4:
                      goto label_26;
                    case 6:
                      goto label_34;
                    case 8:
                      goto label_14;
                    default:
                      num1 = -1506198424;
                      continue;
                  }
                case 10:
                  goto label_17;
                case 11:
                case 13:
                  goto label_41;
                case 12:
                  current2 = enumerator2.Current;
                  num1 = -1506198416;
                  continue;
                case 14:
                  goto label_29;
                case 15:
                  int num2;
                  num1 = num2 = !enumerator4.MoveNext() ? -1506198417 : (num2 = -1506198454);
                  continue;
                case 16:
                  enumerator4 = this.pvZENOerCWQBWsdYLTeGFtMWaTz().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = -1506198423;
                  continue;
                case 17:
label_26:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = -1506198404;
                  continue;
                case 18:
                  int num3;
                  num1 = num3 = !enumerator2.MoveNext() ? -1506198403 : (num3 = -1506198430);
                  continue;
                case 19:
                  // ISSUE: reference to a compiler-generated method
                  this.WEWwVwpTRaLIumAyLiNPzOpxbqE();
                  num1 = -1506198451;
                  continue;
                case 20:
                  if (!enumerator3.MoveNext())
                  {
                    // ISSUE: reference to a compiler-generated method
                    this.YByUDJKiOOhMABmCRbygCBRkzFB();
                    num1 = -1506198402;
                    continue;
                  }
                  goto case 22;
                case 21:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -1506198410;
                  continue;
                case 22:
                  current3 = enumerator3.Current;
                  num1 = -1506198452;
                  continue;
                case 23:
                  goto label_1;
                case 24:
                  num1 = -1506198450;
                  continue;
                case 25:
                  num1 = -1506198404;
                  continue;
                case 26:
label_14:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = -1506198431;
                  continue;
                case 27:
label_25:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  int num4;
                  num1 = num4 = !ReInput.CheckInitialized() ? -1506198424 : (num4 = -1506198419);
                  continue;
                case 28:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = -1506198409;
                  continue;
                case 29:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current1;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = -1506198415;
                  continue;
                case 30:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current2;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 4;
                  flag = true;
                  num1 = -1506198427;
                  continue;
                case 31:
                  flag = true;
                  num1 = -1506198429;
                  continue;
                case 32:
                  int num5;
                  num1 = num5 = enumerator1.MoveNext() ? -1506198422 : (num5 = -1506198421);
                  continue;
                case 33:
                  enumerator2 = this.kljNJJXrtByRFIcwAsljSKQFlvQ().GetEnumerator();
                  num1 = -1506198414;
                  continue;
                case 34:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current3;
                  num1 = -1506198428;
                  continue;
                case 35:
                  enumerator3 = this.NWmcKgJLklHFfSnKejFzpeWoiCVV().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = -1506198453;
                  continue;
                case 36:
                  ControllerPollingInfo current4 = enumerator4.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current4;
                  num1 = -1506198426;
                  continue;
                case 37:
                  num1 = -1506198406;
                  continue;
                default:
                  goto label_39;
              }
            }
label_17:
            // ISSUE: reference to a compiler-generated field
            this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 6;
            flag = true;
            goto label_41;
label_29:
            flag = true;
            goto label_41;
label_39:
            flag = false;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_41:
          return flag;
        }

        public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = -707898575;
            ControllerPollingInfo current1;
            ControllerPollingInfo current2;
            IEnumerator<ControllerPollingInfo> enumerator1;
            IEnumerator<ControllerPollingInfo> enumerator2;
            IEnumerator<ControllerPollingInfo> enumerator3;
            IEnumerator<ControllerPollingInfo> enumerator4;
            while (true)
            {
              switch (num1 ^ -707898569)
              {
                case 0:
label_6:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -707898592;
                  continue;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  this.rwCZqWsBurXpCpgnMGgYBDUQKgT();
                  num1 = -707898601;
                  continue;
                case 2:
                  num1 = -707898566;
                  continue;
                case 3:
                  flag = true;
                  num1 = -707898578;
                  continue;
                case 4:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 6;
                  flag = true;
                  num1 = -707898574;
                  continue;
                case 5:
                case 18:
                case 21:
                case 25:
                  goto label_41;
                case 6:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_4;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                      goto label_39;
                    case 2:
                      goto label_6;
                    case 4:
                      goto label_37;
                    case 6:
                      goto label_28;
                    case 8:
                      goto label_18;
                    default:
                      num1 = -707898604;
                      continue;
                  }
                case 7:
                  ControllerPollingInfo current3 = enumerator1.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current3;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = -707898586;
                  continue;
                case 8:
                  current1 = enumerator2.Current;
                  num1 = -707898585;
                  continue;
                case 9:
label_37:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = -707898566;
                  continue;
                case 10:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 8;
                  flag = true;
                  num1 = -707898587;
                  continue;
                case 11:
                  int num2;
                  num1 = num2 = !enumerator3.MoveNext() ? -707898602 : (num2 = -707898565);
                  continue;
                case 12:
                  ControllerPollingInfo current4 = enumerator3.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current4;
                  num1 = -707898573;
                  continue;
                case 13:
                  int num3;
                  num1 = num3 = !enumerator2.MoveNext() ? -707898583 : (num3 = -707898561);
                  continue;
                case 14:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = -707898564;
                  continue;
                case 15:
                  if (!enumerator4.MoveNext())
                  {
                    // ISSUE: reference to a compiler-generated method
                    this.BCWTTyDGSdOcLgyqVLddGgBWbnO();
                    num1 = -707898579;
                    continue;
                  }
                  goto case 38;
                case 16:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current1;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 4;
                  num1 = -707898572;
                  continue;
                case 17:
                  flag = true;
                  num1 = -707898590;
                  continue;
                case 19:
                  num1 = -707898592;
                  continue;
                case 20:
                  if (ReInput.CheckInitialized())
                  {
                    enumerator1 = this.dGAClyTJRZWPpAQKouknSjVIbYf().GetEnumerator();
                    num1 = -707898577;
                    continue;
                  }
                  goto label_39;
                case 22:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current2;
                  num1 = -707898563;
                  continue;
                case 23:
                  int num4;
                  num1 = num4 = !enumerator1.MoveNext() ? -707898570 : (num4 = -707898576);
                  continue;
                case 24:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -707898588;
                  continue;
                case 27:
label_28:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = -707898564;
                  continue;
                case 28:
label_18:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = -707898568;
                  continue;
                case 29:
                  enumerator3 = this.TraLUWzINsJYxWivfIuerrzlgTi().GetEnumerator();
                  num1 = -707898567;
                  continue;
                case 30:
                  // ISSUE: reference to a compiler-generated method
                  this.mDBcbGeuytqqIbvbBIwvgIpEJprs();
                  num1 = -707898582;
                  continue;
                case 31:
label_4:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  num1 = -707898589;
                  continue;
                case 32:
                  enumerator2 = this.QxxGUoWBWEhiQfKywDRRZbrLPLN().GetEnumerator();
                  num1 = -707898606;
                  continue;
                case 33:
                  // ISSUE: reference to a compiler-generated method
                  this.bPhNXxEmgPjqhUBnzJPXpECsVTg();
                  enumerator4 = this.ZsushDHsDeUkdsWPmkbVaqzlNhY().GetEnumerator();
                  num1 = -707898605;
                  continue;
                case 34:
                  goto label_1;
                case 35:
                  num1 = -707898579;
                  continue;
                case 36:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = -707898568;
                  continue;
                case 37:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = -707898571;
                  continue;
                case 38:
                  current2 = enumerator4.Current;
                  num1 = -707898591;
                  continue;
                default:
                  goto label_39;
              }
            }
label_39:
            flag = false;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_41:
          return flag;
        }

        public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = 2050552551;
            ControllerPollingInfo current1;
            ControllerPollingInfo current2;
            ControllerPollingInfo current3;
            IEnumerator<ControllerPollingInfo> enumerator1;
            IEnumerator<ControllerPollingInfo> enumerator2;
            IEnumerator<ControllerPollingInfo> enumerator3;
            IEnumerator<ControllerPollingInfo> enumerator4;
            while (true)
            {
              switch (num1 ^ 2050552564)
              {
                case 1:
                  enumerator4 = this.UNMpQlxocJbpNttdBthdTyRpzaJ().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = 2050552573;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = 2050552561;
                  continue;
                case 3:
                  enumerator1 = this.XVSlcwBzmjJOnqseEQsYngvnAhic().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 2050552535;
                  continue;
                case 4:
label_6:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  num1 = 2050552552;
                  continue;
                case 5:
                  flag = true;
                  num1 = 2050552556;
                  continue;
                case 6:
                  num1 = 2050552532;
                  continue;
                case 7:
                  num1 = 2050552544;
                  continue;
                case 8:
label_3:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = 2050552532;
                  continue;
                case 9:
                  if (!enumerator4.MoveNext())
                  {
                    // ISSUE: reference to a compiler-generated method
                    this.fZARvqxboRgTYgKGqMBEGkMrSeSt();
                    num1 = 2050552528;
                    continue;
                  }
                  goto case 30;
                case 10:
                  current2 = enumerator3.Current;
                  num1 = 2050552546;
                  continue;
                case 11:
                  ControllerPollingInfo current4 = enumerator1.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current4;
                  num1 = 2050552566;
                  continue;
                case 12:
                  // ISSUE: reference to a compiler-generated method
                  this.MpodppeIZvctDGzjvZuRkOqAwcDs();
                  num1 = 2050552548;
                  continue;
                case 13:
                  num1 = 2050552528;
                  continue;
                case 14:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current1;
                  num1 = 2050552534;
                  continue;
                case 16:
                  enumerator3 = this.wqIrcXLJzpsvsCfAUzVixPDmIik().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = 2050552563;
                  continue;
                case 17:
                  flag = true;
                  num1 = 2050552564;
                  continue;
                case 18:
                  flag = true;
                  num1 = 2050552571;
                  continue;
                case 19:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_6;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                      goto label_10;
                    case 2:
                      goto label_8;
                    case 4:
                      goto label_3;
                    case 6:
                      goto label_5;
                    case 8:
                      goto label_11;
                    default:
                      num1 = 2050552569;
                      continue;
                  }
                case 20:
                  int num2;
                  num1 = num2 = !enumerator3.MoveNext() ? 2050552530 : (num2 = 2050552574);
                  continue;
                case 21:
                  int num3;
                  num1 = num3 = enumerator1.MoveNext() ? 2050552575 : (num3 = 2050552555);
                  continue;
                case 22:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current2;
                  num1 = 2050552531;
                  continue;
                case 23:
label_11:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = 2050552573;
                  continue;
                case 25:
label_5:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = 2050552544;
                  continue;
                case 26:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current3;
                  num1 = 2050552533;
                  continue;
                case 28:
                  int num4;
                  num1 = num4 = !ReInput.CheckInitialized() ? 2050552528 : (num4 = 2050552567);
                  continue;
                case 29:
                  current1 = enumerator2.Current;
                  num1 = 2050552570;
                  continue;
                case 30:
                  current3 = enumerator4.Current;
                  num1 = 2050552558;
                  continue;
                case 31:
                  // ISSUE: reference to a compiler-generated method
                  this.NkXnKQsGXbFdFFXjKACkuzVzvgx();
                  enumerator2 = this.kljNJJXrtByRFIcwAsljSKQFlvQ().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = 2050552562;
                  continue;
                case 32:
                  int num5;
                  num1 = num5 = !enumerator2.MoveNext() ? 2050552568 : (num5 = 2050552553);
                  continue;
                case 33:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 8;
                  num1 = 2050552550;
                  continue;
                case 34:
                  goto label_40;
                case 35:
                  num1 = 2050552545;
                  continue;
                case 36:
label_10:
                  flag = false;
                  num1 = 2050552559;
                  continue;
                case 37:
                  goto label_1;
                case 38:
                  // ISSUE: reference to a compiler-generated method
                  this.QFGtRwXSixpdVoKPEHcczurDJQy();
                  num1 = 2050552565;
                  continue;
                case 39:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 6;
                  num1 = 2050552549;
                  continue;
                case 40:
label_8:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 2050552545;
                  continue;
                default:
                  goto label_42;
              }
            }
label_40:
            // ISSUE: reference to a compiler-generated field
            this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 4;
            flag = true;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_42:
          return flag;
        }

        public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = 510253845;
            ControllerPollingInfo current1;
            ControllerPollingInfo current2;
            IEnumerator<ControllerPollingInfo> enumerator1;
            IEnumerator<ControllerPollingInfo> enumerator2;
            IEnumerator<ControllerPollingInfo> enumerator3;
            IEnumerator<ControllerPollingInfo> enumerator4;
            while (true)
            {
              switch (num1 ^ 510253847)
              {
                case 0:
                  current1 = enumerator1.Current;
                  num1 = 510253836;
                  continue;
                case 1:
                  int num2;
                  num1 = num2 = !enumerator2.MoveNext() ? 510253835 : (num2 = 510253832);
                  continue;
                case 2:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_8;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                      goto label_41;
                    case 2:
                      goto label_16;
                    case 4:
                      goto label_14;
                    case 6:
                      goto label_3;
                    case 8:
                      goto label_35;
                    default:
                      num1 = 510253824;
                      continue;
                  }
                case 3:
                  goto label_1;
                case 4:
label_8:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  num1 = 510253842;
                  continue;
                case 5:
                  int num3;
                  num1 = num3 = !ReInput.CheckInitialized() ? 510253878 : (num3 = 510253855);
                  continue;
                case 6:
label_16:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 510253874;
                  continue;
                case 7:
                case 22:
                case 40:
                  goto label_43;
                case 8:
                  enumerator1 = this.uKEBsCCcfrojVfdQaedKjXGnpJv().GetEnumerator();
                  num1 = 510253826;
                  continue;
                case 9:
                  goto label_18;
                case 10:
                  current2 = enumerator4.Current;
                  num1 = 510253830;
                  continue;
                case 11:
                  enumerator3 = this.KpBEvCstcldYMftrLHMbgSdULaHp().GetEnumerator();
                  num1 = 510253872;
                  continue;
                case 12:
label_35:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = 510253834;
                  continue;
                case 13:
                  flag = true;
                  num1 = 510253840;
                  continue;
                case 14:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 4;
                  num1 = 510253873;
                  continue;
                case 15:
                  num1 = 510253846;
                  continue;
                case 16:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 7;
                  num1 = 510253875;
                  continue;
                case 17:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current2;
                  num1 = 510253828;
                  continue;
                case 18:
                  int num4;
                  num1 = num4 = !enumerator3.MoveNext() ? 510253839 : (num4 = 510253837);
                  continue;
                case 19:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 8;
                  num1 = 510253876;
                  continue;
                case 20:
                  enumerator2 = this.QxxGUoWBWEhiQfKywDRRZbrLPLN().GetEnumerator();
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = 510253848;
                  continue;
                case 21:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 510253874;
                  continue;
                case 23:
                  num1 = 510253878;
                  continue;
                case 24:
                  // ISSUE: reference to a compiler-generated method
                  this.mjmtmzmtmYTWiTMjxvxToqGoTyo();
                  enumerator4 = this.ezWoYrEYmHGNXPOyRsmbevyLkTf().GetEnumerator();
                  num1 = 510253831;
                  continue;
                case 25:
                  // ISSUE: reference to a compiler-generated method
                  this.VyGAQRHihCjYSuMreiNaIpcLtLq();
                  num1 = 510253878;
                  continue;
                case 26:
                  ControllerPollingInfo current3 = enumerator3.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current3;
                  num1 = 510253854;
                  continue;
                case 27:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current1;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = 510253850;
                  continue;
                case 28:
                  // ISSUE: reference to a compiler-generated method
                  this.DHXzRnCpnBSgiIVGmnTZLHyUFDo();
                  num1 = 510253852;
                  continue;
                case 29:
                  int num5;
                  num1 = num5 = !enumerator4.MoveNext() ? 510253838 : (num5 = 510253853);
                  continue;
                case 30:
                  num1 = 510253829;
                  continue;
                case 31:
                  ControllerPollingInfo current4 = enumerator2.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current4;
                  num1 = 510253849;
                  continue;
                case 32:
label_14:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 3;
                  num1 = 510253846;
                  continue;
                case 34:
label_3:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = 510253829;
                  continue;
                case 35:
                  flag = true;
                  num1 = 510253887;
                  continue;
                case 36:
                  num1 = 510253834;
                  continue;
                case 37:
                  if (!enumerator1.MoveNext())
                  {
                    // ISSUE: reference to a compiler-generated method
                    this.TmHwoSEQqiOpqFdhuXYggTqGQlY();
                    num1 = 510253827;
                    continue;
                  }
                  goto case 0;
                case 38:
                  flag = true;
                  num1 = 510253825;
                  continue;
                case 39:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 5;
                  num1 = 510253833;
                  continue;
                default:
                  goto label_41;
              }
            }
label_18:
            // ISSUE: reference to a compiler-generated field
            this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 6;
            flag = true;
            goto label_43;
label_41:
            flag = false;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_43:
          return flag;
        }

        public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes() => (IEnumerable<ControllerPollingInfo>) new ReInput.ControllerHelper.PollingHelper.HZQRKiIyysBhSjFCcTvePOJSHQu(-2)
        {
          oWHzslGHLsVLefMtCsKFnAsXbjj = this
        };

        public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(
          ControllerType controllerType,
          int controllerId)
        {
          if (ReInput.CheckInitialized())
            goto label_8;
label_1:
          int num = -18464927;
label_2:
          ControllerType controllerType1;
          while (true)
          {
            switch (num ^ -18464923)
            {
              case 0:
                goto label_1;
              case 1:
                switch (controllerType1)
                {
                  case ControllerType.Keyboard:
                    goto label_10;
                  case ControllerType.Mouse:
                    goto label_11;
                  case ControllerType.Joystick:
                    goto label_9;
                  default:
                    num = -18464922;
                    continue;
                }
              case 2:
                goto label_13;
              case 3:
                if (controllerType1 != ControllerType.Custom)
                {
                  num = -18464921;
                  continue;
                }
                goto label_12;
              case 4:
                goto label_7;
              default:
                goto label_9;
            }
          }
label_7:
          return (IEnumerable<ControllerPollingInfo>) EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
label_9:
          return this.FRqXeIMJkRIdzkjlZAfEKqQVkbAI(controllerId);
label_10:
          return this.kljNJJXrtByRFIcwAsljSKQFlvQ();
label_11:
          return this.NWmcKgJLklHFfSnKejFzpeWoiCVV();
label_12:
          return this.oEsSkqtUFmeyuwuNlTvcVpVEDPg(controllerId);
label_13:
          throw new NotImplementedException();
label_8:
          controllerType1 = controllerType;
          num = -18464924;
          goto label_2;
        }

        public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(
          ControllerType controllerType,
          int controllerId)
        {
          if (ReInput.CheckInitialized())
            goto label_6;
label_1:
          int num = 373361013;
label_2:
          ControllerType controllerType1;
          while (true)
          {
            switch (num ^ 373361009)
            {
              case 0:
                if (controllerType1 != ControllerType.Custom)
                {
                  num = 373361011;
                  continue;
                }
                goto label_12;
              case 2:
                goto label_13;
              case 3:
                goto label_1;
              case 4:
                goto label_5;
              case 5:
                switch (controllerType1)
                {
                  case ControllerType.Keyboard:
                    goto label_10;
                  case ControllerType.Mouse:
                    goto label_11;
                  case ControllerType.Joystick:
                    goto label_9;
                  default:
                    num = 373361009;
                    continue;
                }
              default:
                goto label_9;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
label_9:
          return this.ZzwbYQBiouOZmyVHcJffPQBDniK(controllerId);
label_10:
          return this.QxxGUoWBWEhiQfKywDRRZbrLPLN();
label_11:
          return this.TraLUWzINsJYxWivfIuerrzlgTi();
label_12:
          return this.XOGElFGNOjbAfjQdsZpMCOyyuKGa(controllerId);
label_13:
          throw new NotImplementedException();
label_6:
          controllerType1 = controllerType;
          num = 373361012;
          goto label_2;
        }

        public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(
          ControllerType controllerType,
          int controllerId)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 1453513329;
label_2:
          switch (num ^ 1453513331)
          {
            case 1:
              throw new NotImplementedException();
            case 2:
              return (IEnumerable<ControllerPollingInfo>) EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
label_4:
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.kljNJJXrtByRFIcwAsljSKQFlvQ();
            case ControllerType.Mouse:
              return this.wqIrcXLJzpsvsCfAUzVixPDmIik();
            case ControllerType.Joystick:
              break;
            case ControllerType.Custom:
              return this.WSphMayHqExjYLZuEJlwDsllFwJ(controllerId);
            default:
              num = 1453513330;
              goto label_2;
          }
label_6:
          return this.rGXhZfkqdjLNvSNaYKcRHjQrJoQ(controllerId);
        }

        public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(
          ControllerType controllerType,
          int controllerId)
        {
          if (!ReInput.CheckInitialized())
            return (IEnumerable<ControllerPollingInfo>) EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
          ControllerType controllerType1 = controllerType;
label_3:
          int num = -1725276960;
          while (true)
          {
            switch (num ^ -1725276959)
            {
              case 1:
                switch (controllerType1)
                {
                  case ControllerType.Keyboard:
                    goto label_9;
                  case ControllerType.Mouse:
                    goto label_10;
                  case ControllerType.Joystick:
                    goto label_8;
                  default:
                    num = -1725276957;
                    continue;
                }
              case 2:
                goto label_7;
              case 3:
                goto label_3;
              default:
                goto label_8;
            }
          }
label_7:
          if (controllerType1 == ControllerType.Custom)
            return this.SzfYesStqXIbbyNmVGXTKEvsqWm(controllerId);
          throw new NotImplementedException();
label_8:
          return this.OozBwTWJHIpwkDcThQPrOSFchXI(controllerId);
label_9:
          return this.QxxGUoWBWEhiQfKywDRRZbrLPLN();
label_10:
          return this.KpBEvCstcldYMftrLHMbgSdULaHp();
        }

        public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(
          ControllerType controllerType,
          int controllerId)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 1854694199;
label_2:
          ControllerType controllerType1;
          switch (num ^ 1854694196)
          {
            case 0:
              goto label_1;
            case 2:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
                case ControllerType.Mouse:
                  return this.GpCJBiYKDQAyMmLvrziRQKZVyce();
                case ControllerType.Joystick:
                  break;
                case ControllerType.Custom:
                  return this.BNUfdQHmhMBaPRKFvZkNvNzurwRH(controllerId);
                default:
                  throw new NotImplementedException();
              }
              break;
            case 3:
              return (IEnumerable<ControllerPollingInfo>) EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
          }
          return this.GKqHHKhywbKIfKkyiVVHsNetOnZ(controllerId);
label_4:
          controllerType1 = controllerType;
          num = 1854694198;
          goto label_2;
        }

        private ControllerPollingInfo xqEJnUvhRVeAxBFeBqTieJaboxrq()
        {
          IList<Joystick> evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
          int index = 0;
label_5:
          int num = index >= evtXaPweQpgSubXx.Count ? -2145653382 : (num = -2145653383);
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ -2145653384)
            {
              case 0:
                goto label_6;
              case 1:
                controllerPollingInfo = evtXaPweQpgSubXx[index].PollForFirstElement();
                if (controllerPollingInfo.success)
                {
                  num = -2145653384;
                  continue;
                }
                ++index;
                num = -2145653381;
                continue;
              case 3:
                goto label_5;
              case 4:
                num = -2145653383;
                continue;
              default:
                goto label_8;
            }
          }
label_6:
          return controllerPollingInfo;
label_8:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo vQAVedbMIlMSqYGiTLIrjfyFqBk()
        {
          IList<Joystick> evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
label_1:
          int num1 = 1008205926;
          ControllerPollingInfo controllerPollingInfo;
          int index;
          while (true)
          {
            switch (num1 ^ 1008205922)
            {
              case 0:
                goto label_5;
              case 1:
                if (controllerPollingInfo.success)
                {
                  num1 = 1008205922;
                  continue;
                }
                ++index;
                num1 = 1008205924;
                continue;
              case 2:
                controllerPollingInfo = evtXaPweQpgSubXx[index].PollForFirstElementDown();
                num1 = 1008205923;
                continue;
              case 3:
                goto label_1;
              case 4:
                index = 0;
                num1 = 1008205927;
                continue;
              case 5:
                num1 = 1008205924;
                continue;
              case 6:
                int num2;
                num1 = num2 = index >= evtXaPweQpgSubXx.Count ? 1008205925 : (num2 = 1008205920);
                continue;
              default:
                goto label_11;
            }
          }
label_5:
          return controllerPollingInfo;
label_11:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo XvOzsTsFKLrbAslgHosnAPxBtiI()
        {
          IList<Joystick> evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
          int index = 0;
label_1:
          int num = 99903026;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ 99903027)
            {
              case 0:
                goto label_1;
              case 1:
                num = 99903024;
                continue;
              case 2:
                controllerPollingInfo = evtXaPweQpgSubXx[index].PollForFirstButton();
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num = 99903024;
                  continue;
                }
                goto label_5;
              default:
                if (index < evtXaPweQpgSubXx.Count)
                  goto case 2;
                else
                  goto label_8;
            }
          }
label_5:
          return controllerPollingInfo;
label_8:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo JkwAAJkeuhfqxpGvmZgJadVmNka()
        {
          IList<Joystick> evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
          int index = 0;
label_1:
          int num = 2118820237;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ 2118820232)
            {
              case 0:
                goto label_1;
              case 1:
                controllerPollingInfo = evtXaPweQpgSubXx[index].PollForFirstButtonDown();
                num = 2118820236;
                continue;
              case 2:
                goto label_5;
              case 4:
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num = 2118820235;
                  continue;
                }
                num = 2118820234;
                continue;
              case 5:
                num = 2118820235;
                continue;
              default:
                if (index < evtXaPweQpgSubXx.Count)
                  goto case 1;
                else
                  goto label_10;
            }
          }
label_5:
          return controllerPollingInfo;
label_10:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo CtVpOuLQOkBPDmrcczxWDQeluex()
        {
          IList<Joystick> evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
label_1:
          int num1 = -1879257831;
          int index;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num1 ^ -1879257829)
            {
              case 0:
                goto label_1;
              case 1:
                num1 = -1879257826;
                continue;
              case 2:
                index = 0;
                num1 = -1879257830;
                continue;
              case 3:
                controllerPollingInfo = evtXaPweQpgSubXx[index].PollForFirstAxis();
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num1 = -1879257826;
                  continue;
                }
                goto label_4;
              case 5:
                int num2;
                num1 = num2 = index >= evtXaPweQpgSubXx.Count ? -1879257825 : (num2 = -1879257832);
                continue;
              default:
                goto label_9;
            }
          }
label_4:
          return controllerPollingInfo;
label_9:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo pxOYAWOjmkiXKQODqfkVKMoXVKER(int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : joystick.PollForFirstElement();
        }

        private ControllerPollingInfo xWmGlWCjhydBnFwrRcHWjaSBnkrN(int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : joystick.PollForFirstElementDown();
        }

        private ControllerPollingInfo LntjQBAQCBrOFWHnQmOqxcmPuHH(int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
label_1:
          int num = 314254997;
          while (true)
          {
            switch (num ^ 314254996)
            {
              case 1:
                if (joystick == null)
                {
                  num = 314254996;
                  continue;
                }
                goto label_6;
              case 2:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_6:
          return joystick.PollForFirstButton();
        }

        private ControllerPollingInfo BhrbcPMCtluJnuqbIfIxJTKvjgo(int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : joystick.PollForFirstButtonDown();
        }

        private ControllerPollingInfo azKcgDyqbHBSJlZqsuFpQQWdTCe(int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : joystick.PollForFirstAxis();
        }

        private ControllerPollingInfo JpyRHYiTCaDlEgsNPfyBRmSPBVf() => ReInput.ControllerHelper.Instance.Keyboard.PollForFirstKey();

        private ControllerPollingInfo eFMhTuQqJhfMkTiSAYKiiZHmGGX() => ReInput.ControllerHelper.Instance.Keyboard.PollForFirstKeyDown();

        private ControllerPollingInfo rIXwpWaADtNlMdRJNdauptPhASr() => ReInput.ControllerHelper.Instance.Mouse.PollForFirstElement();

        private ControllerPollingInfo iLSagMAvxdljFVsINVEQGdQksRyn() => ReInput.ControllerHelper.Instance.Mouse.PollForFirstElementDown();

        private ControllerPollingInfo uFqRfvVjeHljJGJXGmHJYbeBMpN() => ReInput.ControllerHelper.Instance.Mouse.PollForFirstButton();

        private ControllerPollingInfo YwtGMeusfCVLDpOIQteDlhwhUvY() => ReInput.ControllerHelper.Instance.Mouse.PollForFirstButtonDown();

        private ControllerPollingInfo oQUEBkbVxYyoxPBIimcLSVCYWggh() => ReInput.ControllerHelper.Instance.Mouse.PollForFirstAxis();

        private ControllerPollingInfo sLHsjIJPZaWknPgIFADcCbIUBVwF()
        {
          IList<CustomController> krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
          int index = 0;
label_7:
          while (index < krhvjJvqIfnhKfAlb.Count)
          {
label_3:
            ControllerPollingInfo controllerPollingInfo = krhvjJvqIfnhKfAlb[index].PollForFirstElement();
            int num = 1107165655;
            while (true)
            {
              switch (num ^ 1107165654)
              {
                case 0:
                  num = 1107165653;
                  continue;
                case 1:
                  if (!controllerPollingInfo.success)
                  {
                    ++index;
                    num = 1107165652;
                    continue;
                  }
                  goto label_5;
                case 3:
                  goto label_3;
                default:
                  goto label_7;
              }
            }
label_5:
            return controllerPollingInfo;
          }
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo HOmfMafVbeqBKHuJhXAmiGrtAdsT()
        {
          IList<CustomController> krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
          int index = 0;
label_1:
          int num = -1348888309;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ -1348888312)
            {
              case 1:
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num = -1348888312;
                  continue;
                }
                num = -1348888308;
                continue;
              case 2:
                goto label_1;
              case 3:
                num = -1348888312;
                continue;
              case 4:
                goto label_4;
              case 5:
                controllerPollingInfo = krhvjJvqIfnhKfAlb[index].PollForFirstElementDown();
                num = -1348888311;
                continue;
              default:
                if (index < krhvjJvqIfnhKfAlb.Count)
                  goto case 5;
                else
                  goto label_10;
            }
          }
label_4:
          return controllerPollingInfo;
label_10:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo datDCmYtFkfMzKwxjFkLiXkBKTX()
        {
          IList<CustomController> krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
          int index = 0;
label_1:
          int num = 441592713;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num ^ 441592715)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_4;
              case 2:
                num = 441592712;
                continue;
              case 4:
                controllerPollingInfo = krhvjJvqIfnhKfAlb[index].PollForFirstButton();
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num = 441592712;
                  continue;
                }
                num = 441592714;
                continue;
              default:
                if (index < krhvjJvqIfnhKfAlb.Count)
                  goto case 4;
                else
                  goto label_9;
            }
          }
label_4:
          return controllerPollingInfo;
label_9:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo RktKkCMQsffwZbSFZCSIltaRhipF()
        {
          IList<CustomController> krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
label_1:
          int num1 = 1900351865;
          ControllerPollingInfo controllerPollingInfo;
          int index;
          while (true)
          {
            switch (num1 ^ 1900351868)
            {
              case 0:
                if (!controllerPollingInfo.success)
                {
                  ++index;
                  num1 = 1900351869;
                  continue;
                }
                num1 = 1900351864;
                continue;
              case 1:
                int num2;
                num1 = num2 = index < krhvjJvqIfnhKfAlb.Count ? 1900351866 : (num2 = 1900351871);
                continue;
              case 2:
                goto label_1;
              case 4:
                goto label_3;
              case 5:
                index = 0;
                num1 = 1900351869;
                continue;
              case 6:
                controllerPollingInfo = krhvjJvqIfnhKfAlb[index].PollForFirstButtonDown();
                num1 = 1900351868;
                continue;
              default:
                goto label_10;
            }
          }
label_3:
          return controllerPollingInfo;
label_10:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo oglTdYDgsevEIMHyxSzzjHmmiea()
        {
          IList<CustomController> krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
label_1:
          int num1 = -1068016643;
          int index;
          ControllerPollingInfo controllerPollingInfo;
          while (true)
          {
            switch (num1 ^ -1068016645)
            {
              case 0:
                controllerPollingInfo = krhvjJvqIfnhKfAlb[index].PollForFirstAxis();
                num1 = -1068016642;
                continue;
              case 1:
                int num2;
                num1 = num2 = index >= krhvjJvqIfnhKfAlb.Count ? -1068016644 : (num2 = -1068016645);
                continue;
              case 2:
                goto label_1;
              case 3:
                num1 = -1068016646;
                continue;
              case 4:
                goto label_8;
              case 5:
                if (controllerPollingInfo.success)
                {
                  num1 = -1068016641;
                  continue;
                }
                ++index;
                num1 = -1068016646;
                continue;
              case 6:
                index = 0;
                num1 = -1068016648;
                continue;
              default:
                goto label_11;
            }
          }
label_8:
          return controllerPollingInfo;
label_11:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
        }

        private ControllerPollingInfo meWUDZRPiTlVFHYLsGzwYgJTBkE(int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : customController.PollForFirstElement();
        }

        private ControllerPollingInfo YUauzKJFRsvFgxZYjLkQeZGaMLT(int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : customController.PollForFirstElementDown();
        }

        private ControllerPollingInfo ZlPUXUeskMeIPFTfONOIYLdaFRmH(int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : customController.PollForFirstButton();
        }

        private ControllerPollingInfo ELqiJjzwsunjVyajjKIEKixkbcv(int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF() : customController.PollForFirstButtonDown();
        }

        private ControllerPollingInfo gZYAAEbMDKuaCELRQnsReJIDvmiS(int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
label_1:
          int num = -284715051;
          while (true)
          {
            switch (num ^ -284715052)
            {
              case 1:
                if (customController == null)
                {
                  num = -284715052;
                  continue;
                }
                goto label_6;
              case 2:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return ControllerPollingInfo.exyhKXMIeKqHIaNEGgarvdJjhLF();
label_6:
          return customController.PollForFirstAxis();
        }

        private IEnumerable<ControllerPollingInfo> QEfvrPMkROvCVvoTWLADrywyOYj()
        {
label_3:
          int num1 = 1261932295;
          IList<Joystick> evtXaPweQpgSubXx;
          int index;
          ControllerPollingInfo current;
          IEnumerator<ControllerPollingInfo> enumerator;
          bool flag;
          while (true)
          {
            switch (num1 ^ 1261932295)
            {
              case 0:
                evtXaPweQpgSubXx = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.qqzFcATYvnoEVtXAPweQpgSubXx;
                index = 0;
                num1 = 1261932289;
                continue;
              case 1:
                num1 = 1261932291;
                continue;
              case 2:
                enumerator = evtXaPweQpgSubXx[index].PollForAllElements().GetEnumerator();
                num1 = 1261932291;
                continue;
              case 3:
                num1 = 1261932302;
                continue;
              case 4:
                if (!enumerator.MoveNext())
                {
                  // ISSUE: reference to a compiler-generated method
                  this.xNMdUeBhTiyjLmkPPLDtscnAWgNw();
                  ++index;
                  num1 = 1261932289;
                  continue;
                }
                goto case 8;
              case 5:
                goto label_13;
              case 6:
                int num2;
                num1 = num2 = index >= evtXaPweQpgSubXx.Count ? 1261932290 : (num2 = 1261932293);
                continue;
              case 7:
                goto label_14;
              case 8:
                current = enumerator.Current;
                num1 = 1261932301;
                continue;
              case 9:
                goto label_3;
              case 10:
                // ISSUE: reference to a compiler-generated field
                this.swvfDJElZhJVPfqAQWUScBgXUPD = current;
                // ISSUE: reference to a compiler-generated field
                this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                flag = true;
                num1 = 1261932288;
                continue;
              default:
                goto label_7;
            }
          }
label_13:
          yield break;
label_7:
          yield break;
label_14:
          return flag;
        }

        private IEnumerable<ControllerPollingInfo> dGAClyTJRZWPpAQKouknSjVIbYf()
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.PollingHelper.vSDchOgZxcgGKClJCIIFLCAgKcQz gkClJciiflcAgKcQz = new ReInput.ControllerHelper.PollingHelper.vSDchOgZxcgGKClJCIIFLCAgKcQz(-2);
label_1:
          int num = 1722951989;
          while (true)
          {
            switch (num ^ 1722951988)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                gkClJciiflcAgKcQz.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = 1722951988;
                continue;
              case 2:
                goto label_1;
              default:
                goto label_4;
            }
          }
label_4:
          return (IEnumerable<ControllerPollingInfo>) gkClJciiflcAgKcQz;
        }

        private IEnumerable<ControllerPollingInfo> XVSlcwBzmjJOnqseEQsYngvnAhic() => (IEnumerable<ControllerPollingInfo>) new ReInput.ControllerHelper.PollingHelper.veZXzHoPJoqKBqzxOnAaDHaDhoE(-2)
        {
          oWHzslGHLsVLefMtCsKFnAsXbjj = this
        };

        private IEnumerable<ControllerPollingInfo> uKEBsCCcfrojVfdQaedKjXGnpJv() => (IEnumerable<ControllerPollingInfo>) new ReInput.ControllerHelper.PollingHelper.oYyMMKtqlWILEjyftQaWeaylMbNE(-2)
        {
          oWHzslGHLsVLefMtCsKFnAsXbjj = this
        };

        private IEnumerable<ControllerPollingInfo> OcaAdLmtZjdeCjvTnJpUUXXyMex()
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.PollingHelper.WPmIoRFIAQsROUnAIZNGYiViEwz roUnAizngYiViEwz = new ReInput.ControllerHelper.PollingHelper.WPmIoRFIAQsROUnAIZNGYiViEwz(-2);
label_1:
          int num = 1136520694;
          while (true)
          {
            switch (num ^ 1136520695)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                roUnAizngYiViEwz.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = 1136520695;
                continue;
              case 2:
                goto label_1;
              default:
                goto label_4;
            }
          }
label_4:
          return (IEnumerable<ControllerPollingInfo>) roUnAizngYiViEwz;
        }

        private IEnumerable<ControllerPollingInfo> FRqXeIMJkRIdzkjlZAfEKqQVkbAI(
          int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
label_1:
          int num = 118899533;
          while (true)
          {
            switch (num ^ 118899532)
            {
              case 0:
                goto label_1;
              case 1:
                if (joystick == null)
                {
                  num = 118899534;
                  continue;
                }
                goto label_6;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
label_6:
          return joystick.PollForAllElements();
        }

        private IEnumerable<ControllerPollingInfo> ZzwbYQBiouOZmyVHcJffPQBDniK(
          int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
label_1:
          int num = -1435006586;
          while (true)
          {
            switch (num ^ -1435006585)
            {
              case 1:
                if (joystick == null)
                {
                  num = -1435006585;
                  continue;
                }
                goto label_6;
              case 2:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
label_6:
          return joystick.PollForAllElementsDown();
        }

        private IEnumerable<ControllerPollingInfo> rGXhZfkqdjLNvSNaYKcRHjQrJoQ(
          int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>() : joystick.PollForAllButtons();
        }

        private IEnumerable<ControllerPollingInfo> OozBwTWJHIpwkDcThQPrOSFchXI(
          int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>() : joystick.PollForAllButtonsDown();
        }

        private IEnumerable<ControllerPollingInfo> GKqHHKhywbKIfKkyiVVHsNetOnZ(
          int _param1)
        {
          Joystick joystick = ReInput.ControllerHelper.Instance.GetJoystick(_param1);
          return joystick == null ? (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>() : joystick.PollForAllAxes();
        }

        private IEnumerable<ControllerPollingInfo> kljNJJXrtByRFIcwAsljSKQFlvQ() => ReInput.ControllerHelper.Instance.Keyboard.PollForAllKeys();

        private IEnumerable<ControllerPollingInfo> QxxGUoWBWEhiQfKywDRRZbrLPLN() => ReInput.ControllerHelper.Instance.Keyboard.PollForAllKeysDown();

        private IEnumerable<ControllerPollingInfo> NWmcKgJLklHFfSnKejFzpeWoiCVV() => ReInput.ControllerHelper.Instance.Mouse.PollForAllElements();

        private IEnumerable<ControllerPollingInfo> TraLUWzINsJYxWivfIuerrzlgTi() => ReInput.ControllerHelper.Instance.Mouse.PollForAllElementsDown();

        private IEnumerable<ControllerPollingInfo> wqIrcXLJzpsvsCfAUzVixPDmIik() => ReInput.ControllerHelper.Instance.Mouse.PollForAllButtons();

        private IEnumerable<ControllerPollingInfo> KpBEvCstcldYMftrLHMbgSdULaHp() => ReInput.ControllerHelper.Instance.Mouse.PollForAllButtonsDown();

        private IEnumerable<ControllerPollingInfo> GpCJBiYKDQAyMmLvrziRQKZVyce() => ReInput.ControllerHelper.Instance.Mouse.PollForAllAxes();

        private IEnumerable<ControllerPollingInfo> pvZENOerCWQBWsdYLTeGFtMWaTz()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = 215837505;
            IList<CustomController> krhvjJvqIfnhKfAlb;
            int index;
            ControllerPollingInfo current;
            IEnumerator<ControllerPollingInfo> enumerator;
            while (true)
            {
              switch (num1 ^ 215837515)
              {
                case 0:
                  goto label_1;
                case 1:
                  num1 = 215837509;
                  continue;
                case 4:
                  current = enumerator.Current;
                  num1 = 215837531;
                  continue;
                case 5:
                  num1 = 215837517;
                  continue;
                case 6:
label_12:
                  flag = false;
                  num1 = 215837512;
                  continue;
                case 7:
                  index = 0;
                  num1 = 215837529;
                  continue;
                case 8:
label_3:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 215837509;
                  continue;
                case 9:
                  enumerator = krhvjJvqIfnhKfAlb[index].PollForAllElements().GetEnumerator();
                  num1 = 215837530;
                  continue;
                case 10:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_16;
                    case 1:
                      goto label_12;
                    case 2:
                      goto label_3;
                    default:
                      num1 = 215837518;
                      continue;
                  }
                case 11:
                  // ISSUE: reference to a compiler-generated method
                  this.PSiCqXlfSUbydZgZJokEfMDgOhX();
                  num1 = 215837510;
                  continue;
                case 12:
                  flag = true;
                  num1 = 215837513;
                  continue;
                case 13:
                  ++index;
                  num1 = 215837529;
                  continue;
                case 14:
                  int num2;
                  num1 = num2 = enumerator.MoveNext() ? 215837519 : (num2 = 215837504);
                  continue;
                case 15:
label_16:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
                  num1 = 215837516;
                  continue;
                case 16:
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current;
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = 215837511;
                  continue;
                case 17:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = 215837514;
                  continue;
                case 18:
                  int num3;
                  num1 = num3 = index >= krhvjJvqIfnhKfAlb.Count ? 215837517 : (num3 = 215837506);
                  continue;
                default:
                  goto label_21;
              }
            }
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_21:
          return flag;
        }

        private IEnumerable<ControllerPollingInfo> ZsushDHsDeUkdsWPmkbVaqzlNhY()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            // ISSUE: reference to a compiler-generated field
            int ndkdUzdWtGkAknzWf = this.gtjpkqAodPRNdkdUzdWtGkAknzWF;
label_1:
            int num1 = -1569756934;
            IList<CustomController> krhvjJvqIfnhKfAlb;
            int index;
            IEnumerator<ControllerPollingInfo> enumerator;
            while (true)
            {
              switch (num1 ^ -1569756944)
              {
                case 0:
                  goto label_19;
                case 1:
                  enumerator = krhvjJvqIfnhKfAlb[index].PollForAllElementsDown().GetEnumerator();
                  num1 = -1569756930;
                  continue;
                case 2:
                  num1 = -1569756937;
                  continue;
                case 3:
                  num1 = -1569756936;
                  continue;
                case 4:
                  ControllerPollingInfo current = enumerator.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current;
                  num1 = -1569756939;
                  continue;
                case 5:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  flag = true;
                  num1 = -1569756944;
                  continue;
                case 6:
label_6:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -1569756937;
                  continue;
                case 7:
                  int num2;
                  num1 = num2 = enumerator.MoveNext() ? -1569756940 : (num2 = -1569756931);
                  continue;
                case 9:
                  int num3;
                  num1 = num3 = index >= krhvjJvqIfnhKfAlb.Count ? -1569756936 : (num3 = -1569756943);
                  continue;
                case 10:
                  switch (ndkdUzdWtGkAknzWf)
                  {
                    case 0:
                      goto label_12;
                    case 1:
                      goto label_17;
                    case 2:
                      goto label_6;
                    default:
                      num1 = -1569756941;
                      continue;
                  }
                case 11:
label_12:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                  krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
                  index = 0;
                  num1 = -1569756935;
                  continue;
                case 12:
                  ++index;
                  num1 = -1569756935;
                  continue;
                case 13:
                  // ISSUE: reference to a compiler-generated method
                  this.RgQdmasRStnvsKZVvbWDjeLytoC();
                  num1 = -1569756932;
                  continue;
                case 14:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -1569756942;
                  continue;
                case 15:
                  goto label_1;
                default:
                  goto label_17;
              }
            }
label_17:
            flag = false;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_19:
          return flag;
        }

        private IEnumerable<ControllerPollingInfo> UNMpQlxocJbpNttdBthdTyRpzaJ()
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.PollingHelper.zQGXOJsBQFfNBhIkJJhLCxrfSfPg nbhIkJjhLcxrfSfPg = new ReInput.ControllerHelper.PollingHelper.zQGXOJsBQFfNBhIkJJhLCxrfSfPg(-2);
label_1:
          int num = -1170053581;
          while (true)
          {
            switch (num ^ -1170053582)
            {
              case 0:
                goto label_1;
              case 1:
                // ISSUE: reference to a compiler-generated field
                nbhIkJjhLcxrfSfPg.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = -1170053584;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return (IEnumerable<ControllerPollingInfo>) nbhIkJjhLcxrfSfPg;
        }

        private IEnumerable<ControllerPollingInfo> ezWoYrEYmHGNXPOyRsmbevyLkTf()
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.PollingHelper.vDcytVEzEFqRFyVTAgwaYgYIXjr rfyVtAgwaYgYiXjr = new ReInput.ControllerHelper.PollingHelper.vDcytVEzEFqRFyVTAgwaYgYIXjr(-2);
label_1:
          int num = 1189351094;
          while (true)
          {
            switch (num ^ 1189351092)
            {
              case 0:
                goto label_1;
              case 2:
                // ISSUE: reference to a compiler-generated field
                rfyVtAgwaYgYiXjr.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = 1189351093;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return (IEnumerable<ControllerPollingInfo>) rfyVtAgwaYgYiXjr;
        }

        private IEnumerable<ControllerPollingInfo> inTVqNwHcOTkFPNXabaPGNljKauZ()
        {
          bool flag;
          // ISSUE: fault handler
          try
          {
            int num1;
            // ISSUE: reference to a compiler-generated field
            switch (this.gtjpkqAodPRNdkdUzdWtGkAknzWF)
            {
              case 0:
label_5:
                // ISSUE: reference to a compiler-generated field
                this.gtjpkqAodPRNdkdUzdWtGkAknzWF = -1;
                num1 = -170156416;
                break;
              case 2:
label_4:
                // ISSUE: reference to a compiler-generated field
                this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                num1 = -170156414;
                break;
              default:
label_17:
                flag = false;
                num1 = -170156406;
                break;
            }
            IList<CustomController> krhvjJvqIfnhKfAlb;
            int index;
            IEnumerator<ControllerPollingInfo> enumerator;
            while (true)
            {
              switch (num1 ^ -170156408)
              {
                case 0:
                  num1 = -170156414;
                  continue;
                case 1:
                  goto label_8;
                case 3:
                  ControllerPollingInfo current = enumerator.Current;
                  // ISSUE: reference to a compiler-generated field
                  this.swvfDJElZhJVPfqAQWUScBgXUPD = current;
                  num1 = -170156412;
                  continue;
                case 4:
                  goto label_17;
                case 5:
                  // ISSUE: reference to a compiler-generated method
                  this.KBQVrxZWxujgbhKiLFAYwVmaLNM();
                  num1 = -170156413;
                  continue;
                case 6:
                  num1 = -170156411;
                  continue;
                case 7:
                  goto label_4;
                case 8:
                  krhvjJvqIfnhKfAlb = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.aiubvpFfSiwKRHVJJvqIFnhKfALB;
                  num1 = -170156409;
                  continue;
                case 9:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 1;
                  num1 = -170156408;
                  continue;
                case 10:
                  int num2;
                  num1 = num2 = enumerator.MoveNext() ? -170156405 : (num2 = -170156403);
                  continue;
                case 11:
                  ++index;
                  num1 = -170156410;
                  continue;
                case 12:
                  // ISSUE: reference to a compiler-generated field
                  this.gtjpkqAodPRNdkdUzdWtGkAknzWF = 2;
                  num1 = -170156407;
                  continue;
                case 13:
                  goto label_5;
                case 14:
                  int num3;
                  num1 = num3 = index < krhvjJvqIfnhKfAlb.Count ? -170156392 : (num3 = -170156404);
                  continue;
                case 15:
                  index = 0;
                  num1 = -170156410;
                  continue;
                case 16:
                  enumerator = krhvjJvqIfnhKfAlb[index].PollForAllAxes().GetEnumerator();
                  num1 = -170156415;
                  continue;
                default:
                  goto label_19;
              }
            }
label_8:
            flag = true;
          }
          __fault
          {
            // ISSUE: reference to a compiler-generated method
            this.System\u002EIDisposable\u002EDispose();
          }
label_19:
          return flag;
        }

        private IEnumerable<ControllerPollingInfo> oEsSkqtUFmeyuwuNlTvcVpVEDPg(
          int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
label_1:
          int num = 1642106515;
          while (true)
          {
            switch (num ^ 1642106514)
            {
              case 0:
                goto label_1;
              case 1:
                if (customController == null)
                {
                  num = 1642106512;
                  continue;
                }
                goto label_6;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
label_6:
          return customController.PollForAllElements();
        }

        private IEnumerable<ControllerPollingInfo> XOGElFGNOjbAfjQdsZpMCOyyuKGa(
          int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
label_1:
          int num = -1404668004;
          while (true)
          {
            switch (num ^ -1404668003)
            {
              case 1:
                if (customController == null)
                {
                  num = -1404668003;
                  continue;
                }
                goto label_6;
              case 2:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
label_6:
          return customController.PollForAllElementsDown();
        }

        private IEnumerable<ControllerPollingInfo> WSphMayHqExjYLZuEJlwDsllFwJ(
          int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>() : customController.PollForAllButtons();
        }

        private IEnumerable<ControllerPollingInfo> SzfYesStqXIbbyNmVGXTKEvsqWm(
          int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
          return customController == null ? (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>() : customController.PollForAllButtonsDown();
        }

        private IEnumerable<ControllerPollingInfo> BNUfdQHmhMBaPRKFvZkNvNzurwRH(
          int _param1)
        {
          CustomController customController = ReInput.ControllerHelper.Instance.GetCustomController(_param1);
label_1:
          int num = 891620825;
          while (true)
          {
            switch (num ^ 891620827)
            {
              case 0:
                goto label_1;
              case 2:
                if (customController == null)
                {
                  num = 891620826;
                  continue;
                }
                goto label_6;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ControllerPollingInfo>) new List<ControllerPollingInfo>();
label_6:
          return customController.PollForAllAxes();
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [Browsable(false)]
      public sealed class ConflictCheckingHelper : CodeHelper
      {
        private static ReInput.ControllerHelper.ConflictCheckingHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;

        internal static ReInput.ControllerHelper.ConflictCheckingHelper Instance => ReInput.ControllerHelper.ConflictCheckingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.ControllerHelper.ConflictCheckingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.ControllerHelper.ConflictCheckingHelper());

        private ConflictCheckingHelper()
        {
        }

        public bool DoesAnyElementAssignmentConflict() => this.DoesAnyElementAssignmentConflict(false, false, true);

        public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps) => this.DoesAnyElementAssignmentConflict(skipDisabledMaps, false, true);

        public bool DoesAnyElementAssignmentConflict(
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.DoesAnyElementAssignmentConflict(skipDisabledMaps, forceCheckAllCategories, true);
        }

        public bool DoesAnyElementAssignmentConflict(
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (!ReInput.CheckInitialized())
            return false;
          if (includeSystemPlayer)
            goto label_20;
label_3:
          int num1 = -1235160295;
label_4:
          int index1;
          int index2;
          IList<CustomController> customControllers;
          int index3;
          CustomController customController;
          Player player1;
          Joystick joystick;
          IList<JoystickMap> maps1;
          int index4;
          int num2;
          IList<KeyboardMap> maps2;
          IList<Player> playerList1;
          int index5;
          Player player2;
          IList<CustomControllerMap> maps3;
          int count1;
          Player player3;
          int index6;
          int count2;
          int index7;
          int count3;
          int index8;
          Player player4;
          int index9;
          IList<MouseMap> maps4;
          int index10;
          int index11;
          IList<Joystick> joysticks;
          while (true)
          {
            switch (num1 ^ -1235160262)
            {
              case 0:
                if (player2.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Custom, customController.id, (ControllerMap) maps3[index6], skipDisabledMaps, forceCheckAllCategories))
                {
                  num1 = -1235160266;
                  continue;
                }
                ++index6;
                num1 = -1235160270;
                continue;
              case 1:
                player3 = playerList1[index11];
                index1 = 0;
                num1 = -1235160299;
                continue;
              case 2:
                index5 = num2;
                num1 = -1235160276;
                continue;
              case 3:
                int num3;
                num1 = num3 = index9 >= maps4.Count ? -1235160277 : (num3 = -1235160302);
                continue;
              case 4:
                goto label_3;
              case 5:
                num2 = forceCheckAllCategories ? index4 : 0;
                num1 = -1235160278;
                continue;
              case 6:
                index4 = 0;
                num1 = -1235160292;
                continue;
              case 7:
                int num4;
                num1 = num4 = index5 < count2 ? -1235160310 : (num4 = -1235160289);
                continue;
              case 8:
                if (index6 >= count1)
                {
                  ++index5;
                  num1 = -1235160259;
                  continue;
                }
                goto case 0;
              case 9:
                maps2 = player1.controllers.maps.GetMaps<KeyboardMap>(0);
                num1 = -1235160287;
                continue;
              case 10:
                if (index3 >= customControllers.Count)
                {
                  ++index4;
                  num1 = -1235160292;
                  continue;
                }
                goto case 14;
              case 11:
                player1 = playerList1[index4];
                num1 = -1235160257;
                continue;
              case 12:
                goto label_47;
              case 13:
                num1 = -1235160263;
                continue;
              case 14:
                customController = customControllers[index3];
                num1 = -1235160279;
                continue;
              case 15:
                ++index2;
                num1 = -1235160283;
                continue;
              case 16:
                joysticks = player1.controllers.Joysticks;
                num1 = -1235160297;
                continue;
              case 17:
                customControllers = player1.controllers.CustomControllers;
                num1 = -1235160281;
                continue;
              case 18:
                int num5;
                num1 = num5 = index10 < count2 ? -1235160291 : (num5 = -1235160286);
                continue;
              case 19:
                maps3 = player1.controllers.maps.GetMaps<CustomControllerMap>(customController.id);
                if (maps3 != null)
                {
                  count1 = maps3.Count;
                  num1 = -1235160264;
                  continue;
                }
                goto case 37;
              case 20:
                player4 = playerList1[index8];
                num1 = -1235160275;
                continue;
              case 21:
                if (index7 >= maps2.Count)
                {
                  maps4 = player1.controllers.maps.GetMaps<MouseMap>(0);
                  index9 = 0;
                  num1 = -1235160265;
                  continue;
                }
                goto case 46;
              case 22:
                num1 = -1235160259;
                continue;
              case 23:
                if (!player4.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Mouse, 0, (ControllerMap) maps4[index9], skipDisabledMaps, forceCheckAllCategories))
                {
                  ++index8;
                  num1 = -1235160282;
                  continue;
                }
                goto label_60;
              case 24:
                ++index7;
                num1 = -1235160273;
                continue;
              case 25:
                ++index9;
                num1 = -1235160263;
                continue;
              case 26:
                count3 = maps1.Count;
                index11 = num2;
                num1 = -1235160303;
                continue;
              case 27:
                index7 = 0;
                num1 = -1235160273;
                continue;
              case 28:
                int num6;
                num1 = num6 = index8 < count2 ? -1235160274 : (num6 = -1235160285);
                continue;
              case 29:
                index3 = 0;
                num1 = -1235160272;
                continue;
              case 30:
                num1 = -1235160280;
                continue;
              case 31:
                int num7;
                num1 = num7 = index2 < joysticks.Count ? -1235160304 : (num7 = -1235160269);
                continue;
              case 32:
                int num8;
                num1 = num8 = maps1 == null ? -1235160267 : (num8 = -1235160288);
                continue;
              case 33:
                goto label_5;
              case 34:
                if (!player3.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Joystick, joystick.id, (ControllerMap) maps1[index1], skipDisabledMaps, forceCheckAllCategories))
                {
                  ++index1;
                  num1 = -1235160299;
                  continue;
                }
                num1 = -1235160293;
                continue;
              case 35:
                goto label_19;
              case 36:
                ++index11;
                num1 = -1235160303;
                continue;
              case 37:
                ++index3;
                num1 = -1235160272;
                continue;
              case 39:
                if (!playerList1[index10].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Keyboard, 0, (ControllerMap) maps2[index7], skipDisabledMaps, forceCheckAllCategories))
                {
                  ++index10;
                  num1 = -1235160280;
                  continue;
                }
                goto label_64;
              case 40:
                index8 = num2;
                num1 = -1235160282;
                continue;
              case 41:
                maps1 = player1.controllers.maps.GetMaps<JoystickMap>(joystick.id);
                num1 = -1235160294;
                continue;
              case 42:
                joystick = joysticks[index2];
                num1 = -1235160301;
                continue;
              case 43:
                int num9;
                num1 = num9 = index11 < count2 ? -1235160261 : (num9 = -1235160267);
                continue;
              case 44:
                index6 = 0;
                num1 = -1235160270;
                continue;
              case 45:
                index2 = 0;
                num1 = -1235160283;
                continue;
              case 46:
                index10 = num2;
                num1 = -1235160284;
                continue;
              case 47:
                int num10;
                num1 = num10 = index1 >= count3 ? -1235160290 : (num10 = -1235160296);
                continue;
              case 48:
                player2 = playerList1[index5];
                num1 = -1235160298;
                continue;
              default:
                if (index4 < count2)
                  goto case 11;
                else
                  goto label_67;
            }
          }
label_5:
          return true;
label_19:
          IList<Player> playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
          goto label_21;
label_47:
          return true;
label_60:
          return true;
label_64:
          return true;
label_67:
          return false;
label_20:
          playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
label_21:
          playerList1 = playerList2;
          count2 = playerList1.Count;
          num1 = -1235160260;
          goto label_4;
        }

        public bool DoesElementAssignmentConflict(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap)
        {
          return this.DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, false, false, true);
        }

        public bool DoesElementAssignmentConflict(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps)
        {
          return this.DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, false, true);
        }

        public bool DoesElementAssignmentConflict(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public bool DoesElementAssignmentConflict(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (ReInput.CheckInitialized())
            goto label_14;
label_1:
          int num = 1553548758;
label_2:
          while (true)
          {
            switch (num ^ 1553548756)
            {
              case 0:
                goto label_1;
              case 2:
                goto label_13;
              case 3:
                goto label_5;
              case 4:
                if (elementMap != null)
                {
                  switch (controllerType)
                  {
                    case ControllerType.Keyboard:
                      num = 1553548753;
                      continue;
                    case ControllerType.Mouse:
                      num = 1553548754;
                      continue;
                    case ControllerType.Joystick:
                      goto label_7;
                    case ControllerType.Custom:
                      num = 1553548757;
                      continue;
                    default:
                      goto label_16;
                  }
                }
                else
                {
                  num = 1553548759;
                  continue;
                }
              case 5:
                goto label_3;
              case 6:
                goto label_11;
              default:
                goto label_15;
            }
          }
label_3:
          return this.arwPpRzkkmDYnFCjGiKckWEBVbVj(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_5:
          return false;
label_7:
          return this.VGEMHXfjdPJMWLbEvaMjGjmzYjNj(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_11:
          return this.kaVHUViblWBqHFspWzMJRRbdrpm(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_13:
          return false;
label_15:
          return this.VUbawLFdQgvubgbOdAWFnPppwbqW(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_16:
          throw new NotImplementedException();
label_14:
          num = playerId >= 0 ? 1553548752 : (num = 1553548759);
          goto label_2;
        }

        public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) => this.DoesElementAssignmentConflict(conflictCheck, false, false, true);

        public bool DoesElementAssignmentConflict(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps)
        {
          return this.DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps, false, true);
        }

        public bool DoesElementAssignmentConflict(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public bool DoesElementAssignmentConflict(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 1227348569;
label_2:
          switch (num ^ 1227348573)
          {
            case 0:
              goto label_1;
            case 2:
              return this.arwPpRzkkmDYnFCjGiKckWEBVbVj(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 3:
              return this.kaVHUViblWBqHFspWzMJRRbdrpm(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 4:
              return false;
            default:
              return this.VUbawLFdQgvubgbOdAWFnPppwbqW(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
          }
label_4:
          if (conflictCheck.playerId < 0)
            return false;
          if (conflictCheck.controllerType == ControllerType.Joystick)
            return this.VGEMHXfjdPJMWLbEvaMjGjmzYjNj(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
          if (conflictCheck.controllerType == ControllerType.Keyboard)
          {
            num = 1227348575;
            goto label_2;
          }
          else if (conflictCheck.controllerType == ControllerType.Mouse)
          {
            num = 1227348574;
            goto label_2;
          }
          else
          {
            if (conflictCheck.controllerType != ControllerType.Custom)
              throw new NotImplementedException();
            num = 1227348572;
            goto label_2;
          }
        }

        private bool VGEMHXfjdPJMWLbEvaMjGjmzYjNj(
          int _param1,
          int _param2,
          JoystickMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num = 1270697773;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num ^ 1270697775)
              {
                case 0:
                  num = 1270697768;
                  continue;
                case 1:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 2:
                  if (_param4 != null)
                  {
                    if (!_param7)
                    {
                      num = 1270697774;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num = 1270697767;
                  continue;
                case 3:
                  goto label_10;
                case 4:
                  if (!playerList1[index].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Joystick, _param2, (ControllerMap) _param3, _param4, _param5, _param6))
                  {
                    ++index;
                    num = 1270697768;
                    continue;
                  }
                  num = 1270697772;
                  continue;
                case 5:
                  index = 0;
                  num = 1270697775;
                  continue;
                case 6:
                  goto label_1;
                case 8:
                  goto label_5;
                default:
                  if (index < playerList1.Count)
                    goto case 4;
                  else
                    goto label_18;
              }
              playerList1 = playerList2;
              num = 1270697770;
            }
label_10:
            return true;
label_18:
            return false;
          }
label_5:
          return false;
        }

        private bool VGEMHXfjdPJMWLbEvaMjGjmzYjNj(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = 723638117;
            int index;
            IList<Player> playerList;
            while (true)
            {
              switch (num1 ^ 723638113)
              {
                case 0:
                  goto label_4;
                case 1:
                  index = 0;
                  num1 = 723638119;
                  continue;
                case 2:
                  goto label_1;
                case 4:
                  if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
                  {
                    playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                    num1 = 723638112;
                    continue;
                  }
                  num1 = 723638113;
                  continue;
                case 5:
                  goto label_11;
                case 6:
                  int num2;
                  num1 = num2 = index >= playerList.Count ? 723638114 : (num2 = 723638118);
                  continue;
                case 7:
                  if (playerList[index].controllers.conflictChecking.DoesElementAssignmentConflict(_param1, _param2, _param3))
                  {
                    num1 = 723638116;
                    continue;
                  }
                  ++index;
                  num1 = 723638119;
                  continue;
                default:
                  goto label_13;
              }
            }
label_11:
            return true;
label_13:
            return false;
          }
label_4:
          return false;
        }

        private bool arwPpRzkkmDYnFCjGiKckWEBVbVj(
          int _param1,
          KeyboardMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
            if (_param3 != null)
              goto label_9;
label_2:
            int num = -103315301;
label_3:
            int index;
            IList<Player> playerList;
            while (true)
            {
              switch (num ^ -103315302)
              {
                case 0:
                  num = -103315298;
                  continue;
                case 1:
                  goto label_8;
                case 2:
                  index = 0;
                  num = -103315302;
                  continue;
                case 3:
                  goto label_4;
                case 5:
                  if (!playerList[index].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Keyboard, 0, (ControllerMap) _param2, _param3, _param4, _param5))
                  {
                    ++index;
                    num = -103315298;
                    continue;
                  }
                  num = -103315303;
                  continue;
                case 6:
                  goto label_2;
                default:
                  if (index < playerList.Count)
                    goto case 5;
                  else
                    goto label_13;
              }
            }
label_4:
            return true;
label_13:
            return false;
label_9:
            playerList = _param6 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            num = -103315304;
            goto label_3;
          }
label_8:
          return false;
        }

        private bool arwPpRzkkmDYnFCjGiKckWEBVbVj(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = 2100800006;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ 2100800003)
              {
                case 1:
                  int num2;
                  num1 = num2 = index < playerList1.Count ? 2100800005 : (num2 = 2100800003);
                  continue;
                case 2:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 3:
                  goto label_1;
                case 4:
                  goto label_9;
                case 5:
                  if (_param1.elementAssignmentType == ElementAssignmentType.KeyboardKey)
                  {
                    if (_param4)
                    {
                      playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                      break;
                    }
                    num1 = 2100800001;
                    continue;
                  }
                  num1 = 2100800004;
                  continue;
                case 6:
                  if (playerList1[index].controllers.conflictChecking.DoesElementAssignmentConflict(_param1, _param2, _param3))
                  {
                    num1 = 2100800007;
                    continue;
                  }
                  ++index;
                  num1 = 2100800002;
                  continue;
                case 7:
                  goto label_11;
                default:
                  goto label_16;
              }
              playerList1 = playerList2;
              index = 0;
              num1 = 2100800002;
            }
label_9:
            return true;
label_16:
            return false;
          }
label_11:
          return false;
        }

        private bool kaVHUViblWBqHFspWzMJRRbdrpm(
          int _param1,
          MouseMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num = 1455940987;
            while (true)
            {
              IList<Player> playerList1;
              int index;
              IList<Player> playerList2;
              switch (num ^ 1455940989)
              {
                case 0:
                  goto label_6;
                case 1:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 2:
                  if (!playerList1[index].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Mouse, 0, (ControllerMap) _param2, _param3, _param4, _param5))
                  {
                    ++index;
                    num = 1455940990;
                    continue;
                  }
                  goto label_4;
                case 4:
                  goto label_1;
                case 5:
                  index = 0;
                  num = 1455940990;
                  continue;
                case 6:
                  if (_param3 != null)
                  {
                    if (!_param6)
                    {
                      num = 1455940988;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num = 1455940989;
                  continue;
                default:
                  if (index < playerList1.Count)
                    goto case 2;
                  else
                    goto label_16;
              }
              playerList1 = playerList2;
              num = 1455940984;
            }
label_4:
            return true;
label_16:
            return false;
          }
label_6:
          return false;
        }

        private bool kaVHUViblWBqHFspWzMJRRbdrpm(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num = 777628256;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num ^ 777628263)
              {
                case 0:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 2:
                  goto label_3;
                case 3:
                  goto label_5;
                case 4:
                  index = 0;
                  num = 777628262;
                  continue;
                case 5:
                  if (!playerList1[index].controllers.conflictChecking.DoesElementAssignmentConflict(_param1, _param2, _param3))
                  {
                    ++index;
                    num = 777628262;
                    continue;
                  }
                  num = 777628261;
                  continue;
                case 6:
                  goto label_1;
                case 7:
                  if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
                  {
                    if (!_param4)
                    {
                      num = 777628263;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num = 777628260;
                  continue;
                default:
                  if (index < playerList1.Count)
                    goto case 5;
                  else
                    goto label_17;
              }
              playerList1 = playerList2;
              num = 777628259;
            }
label_3:
            return true;
label_17:
            return false;
          }
label_5:
          return false;
        }

        private bool VUbawLFdQgvubgbOdAWFnPppwbqW(
          int _param1,
          int _param2,
          CustomControllerMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = 1373097137;
            while (true)
            {
              IList<Player> playerList1;
              int index;
              IList<Player> playerList2;
              switch (num1 ^ 1373097138)
              {
                case 0:
                  index = 0;
                  num1 = 1373097147;
                  continue;
                case 1:
                  if (playerList1[index].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Custom, _param2, (ControllerMap) _param3, _param4, _param5, _param6))
                  {
                    num1 = 1373097142;
                    continue;
                  }
                  ++index;
                  num1 = 1373097141;
                  continue;
                case 2:
                  goto label_15;
                case 3:
                  if (_param4 == null)
                  {
                    num1 = 1373097136;
                    continue;
                  }
                  if (_param7)
                  {
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = 1373097140;
                  continue;
                case 4:
                  goto label_13;
                case 6:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 7:
                  int num2;
                  num1 = num2 = index >= playerList1.Count ? 1373097143 : (num2 = 1373097139);
                  continue;
                case 8:
                  goto label_1;
                case 9:
                  num1 = 1373097141;
                  continue;
                default:
                  goto label_18;
              }
              playerList1 = playerList2;
              num1 = 1373097138;
            }
label_13:
            return true;
label_18:
            return false;
          }
label_15:
          return false;
        }

        private bool VUbawLFdQgvubgbOdAWFnPppwbqW(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = 624157197;
            int index;
            IList<Player> playerList;
            while (true)
            {
              switch (num1 ^ 624157193)
              {
                case 0:
                  int num2;
                  num1 = num2 = index < playerList.Count ? 624157185 : (num2 = 624157192);
                  continue;
                case 2:
                  goto label_8;
                case 3:
                  num1 = 624157193;
                  continue;
                case 4:
                  if (_param1.elementAssignmentType == ElementAssignmentType.KeyboardKey)
                  {
                    num1 = 624157195;
                    continue;
                  }
                  playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  num1 = 624157196;
                  continue;
                case 5:
                  index = 0;
                  num1 = 624157194;
                  continue;
                case 6:
                  goto label_1;
                case 7:
                  goto label_12;
                case 8:
                  if (playerList[index].controllers.conflictChecking.DoesElementAssignmentConflict(_param1, _param2, _param3))
                  {
                    num1 = 624157198;
                    continue;
                  }
                  ++index;
                  num1 = 624157193;
                  continue;
                default:
                  goto label_14;
              }
            }
label_12:
            return true;
label_14:
            return false;
          }
label_8:
          return false;
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap)
        {
          return this.ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, false, false, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps)
        {
          return this.ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, false, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (!ReInput.CheckInitialized())
            return (IEnumerable<ElementAssignmentConflictInfo>) EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
          if (playerId >= 0)
          {
label_3:
            int num = 668703330;
            while (true)
            {
              switch (num ^ 668703329)
              {
                case 0:
                  goto label_3;
                case 1:
                  goto label_9;
                case 2:
                  goto label_7;
                case 3:
                  if (elementMap == null)
                  {
                    num = 668703332;
                    continue;
                  }
                  switch (controllerType)
                  {
                    case ControllerType.Keyboard:
                      num = 668703331;
                      continue;
                    case ControllerType.Mouse:
                      num = 668703333;
                      continue;
                    case ControllerType.Joystick:
                      num = 668703328;
                      continue;
                    case ControllerType.Custom:
                      goto label_15;
                    default:
                      goto label_16;
                  }
                case 5:
                  goto label_11;
                default:
                  goto label_14;
              }
            }
label_7:
            return this.vmFTJMheqDCxxqTUEHLqkfnLnsp(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_9:
            return this.IQosuqymTvQJQfdSTgmwIsFNrdu(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_14:
            return this.QnjmJLYJdMlKBnjHUAuJGbhUIEjs(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_15:
            return this.vEvPgFkKIYAhikDmANXMEHHaBXVD(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_16:
            throw new NotImplementedException();
          }
label_11:
          return (IEnumerable<ElementAssignmentConflictInfo>) new List<ElementAssignmentConflictInfo>();
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck)
        {
          return this.ElementAssignmentConflicts(conflictCheck, false, false, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps)
        {
          return this.ElementAssignmentConflicts(conflictCheck, skipDisabledMaps, false, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.ElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (!ReInput.CheckInitialized())
            return (IEnumerable<ElementAssignmentConflictInfo>) EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
          if (conflictCheck.playerId >= 0)
            goto label_6;
label_3:
          int num = -1318588516;
label_4:
          switch (num ^ -1318588520)
          {
            case 0:
              return this.vmFTJMheqDCxxqTUEHLqkfnLnsp(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 2:
              goto label_3;
            case 3:
              return this.IQosuqymTvQJQfdSTgmwIsFNrdu(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 4:
              return (IEnumerable<ElementAssignmentConflictInfo>) new List<ElementAssignmentConflictInfo>();
            default:
              return this.vEvPgFkKIYAhikDmANXMEHHaBXVD(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
          }
label_6:
          if (conflictCheck.controllerType == ControllerType.Joystick)
          {
            num = -1318588517;
            goto label_4;
          }
          else if (conflictCheck.controllerType == ControllerType.Keyboard)
          {
            num = -1318588520;
            goto label_4;
          }
          else
          {
            if (conflictCheck.controllerType == ControllerType.Mouse)
              return this.QnjmJLYJdMlKBnjHUAuJGbhUIEjs(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            if (conflictCheck.controllerType != ControllerType.Custom)
              throw new NotImplementedException();
            num = -1318588519;
            goto label_4;
          }
        }

        private IEnumerable<ElementAssignmentConflictInfo> IQosuqymTvQJQfdSTgmwIsFNrdu(
          int _param1,
          int _param2,
          JoystickMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.gyGTlLdahRDlZbVSCBRDZjzXXzE rdlZbVscbrdZjzXxzE = new ReInput.ControllerHelper.ConflictCheckingHelper.gyGTlLdahRDlZbVSCBRDZjzXXzE(-2);
          // ISSUE: reference to a compiler-generated field
          rdlZbVscbrdZjzXxzE.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
label_1:
          int num = 1514473266;
          while (true)
          {
            switch (num ^ 1514473267)
            {
              case 0:
                goto label_1;
              case 1:
                // ISSUE: reference to a compiler-generated field
                rdlZbVscbrdZjzXxzE.gkeMefjkcVwdqOgKZJmbuvrdWow = _param1;
                num = 1514473265;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                rdlZbVscbrdZjzXxzE.TfOjkIFCYfkjDFvxzXmHOropZZII = _param2;
                num = 1514473270;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                rdlZbVscbrdZjzXxzE.nOdebFvuWOOIoFVsgNOVgTTPRNA = _param4;
                num = 1514473271;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                rdlZbVscbrdZjzXxzE.ayWGYlkOfgxZsTQbRmkQPvcvCjA = _param3;
                num = 1514473264;
                continue;
              default:
                goto label_7;
            }
          }
label_7:
          // ISSUE: reference to a compiler-generated field
          rdlZbVscbrdZjzXxzE.jFbDkKOUsaOzHEUHAgIdalTItWe = _param5;
          // ISSUE: reference to a compiler-generated field
          rdlZbVscbrdZjzXxzE.pLpIivibMdGZDWWuHQzCwUBDkaK = _param6;
          // ISSUE: reference to a compiler-generated field
          rdlZbVscbrdZjzXxzE.fTgLevlSLMvBzonjDdsYdaaRMYq = _param7;
          return (IEnumerable<ElementAssignmentConflictInfo>) rdlZbVscbrdZjzXxzE;
        }

        private IEnumerable<ElementAssignmentConflictInfo> IQosuqymTvQJQfdSTgmwIsFNrdu(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.PfAUVJlCSZgZrVJDjgDbGrcdyJh zrVjDjgDbGrcdyJh = new ReInput.ControllerHelper.ConflictCheckingHelper.PfAUVJlCSZgZrVJDjgDbGrcdyJh(-2);
label_1:
          int num = 781724789;
          while (true)
          {
            switch (num ^ 781724788)
            {
              case 0:
                goto label_1;
              case 1:
                // ISSUE: reference to a compiler-generated field
                zrVjDjgDbGrcdyJh.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                // ISSUE: reference to a compiler-generated field
                zrVjDjgDbGrcdyJh.jAEEOgBpVRMCaaPqwIozbIRzmyrQ = _param1;
                // ISSUE: reference to a compiler-generated field
                zrVjDjgDbGrcdyJh.jFbDkKOUsaOzHEUHAgIdalTItWe = _param2;
                num = 781724790;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                zrVjDjgDbGrcdyJh.pLpIivibMdGZDWWuHQzCwUBDkaK = _param3;
                num = 781724791;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated field
          zrVjDjgDbGrcdyJh.fTgLevlSLMvBzonjDdsYdaaRMYq = _param4;
          return (IEnumerable<ElementAssignmentConflictInfo>) zrVjDjgDbGrcdyJh;
        }

        private IEnumerable<ElementAssignmentConflictInfo> vmFTJMheqDCxxqTUEHLqkfnLnsp(
          int _param1,
          KeyboardMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.omYlUFuHcVciMbliyHosDACSsZz vciMbliyHosDacSsZz = new ReInput.ControllerHelper.ConflictCheckingHelper.omYlUFuHcVciMbliyHosDACSsZz(-2);
          // ISSUE: reference to a compiler-generated field
          vciMbliyHosDacSsZz.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
label_1:
          int num = 2009259607;
          while (true)
          {
            switch (num ^ 2009259606)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                vciMbliyHosDacSsZz.nOdebFvuWOOIoFVsgNOVgTTPRNA = _param3;
                // ISSUE: reference to a compiler-generated field
                vciMbliyHosDacSsZz.jFbDkKOUsaOzHEUHAgIdalTItWe = _param4;
                num = 2009259604;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                vciMbliyHosDacSsZz.gkeMefjkcVwdqOgKZJmbuvrdWow = _param1;
                // ISSUE: reference to a compiler-generated field
                vciMbliyHosDacSsZz.CmvqEMFeEbvHsyxGYIEPDKljiDFJ = _param2;
                num = 2009259606;
                continue;
              case 3:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated field
          vciMbliyHosDacSsZz.pLpIivibMdGZDWWuHQzCwUBDkaK = _param5;
          // ISSUE: reference to a compiler-generated field
          vciMbliyHosDacSsZz.fTgLevlSLMvBzonjDdsYdaaRMYq = _param6;
          return (IEnumerable<ElementAssignmentConflictInfo>) vciMbliyHosDacSsZz;
        }

        private IEnumerable<ElementAssignmentConflictInfo> vmFTJMheqDCxxqTUEHLqkfnLnsp(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.LaFFPCekDEfiOZvCusgkZqvOyZX defiOzvCusgkZqvOyZx = new ReInput.ControllerHelper.ConflictCheckingHelper.LaFFPCekDEfiOZvCusgkZqvOyZX(-2);
label_1:
          int num = 262953318;
          while (true)
          {
            switch (num ^ 262953319)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                defiOzvCusgkZqvOyZx.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                // ISSUE: reference to a compiler-generated field
                defiOzvCusgkZqvOyZx.jAEEOgBpVRMCaaPqwIozbIRzmyrQ = _param1;
                num = 262953316;
                continue;
              case 2:
                goto label_1;
              case 3:
                // ISSUE: reference to a compiler-generated field
                defiOzvCusgkZqvOyZx.jFbDkKOUsaOzHEUHAgIdalTItWe = _param2;
                // ISSUE: reference to a compiler-generated field
                defiOzvCusgkZqvOyZx.pLpIivibMdGZDWWuHQzCwUBDkaK = _param3;
                // ISSUE: reference to a compiler-generated field
                defiOzvCusgkZqvOyZx.fTgLevlSLMvBzonjDdsYdaaRMYq = _param4;
                num = 262953319;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          return (IEnumerable<ElementAssignmentConflictInfo>) defiOzvCusgkZqvOyZx;
        }

        private IEnumerable<ElementAssignmentConflictInfo> QnjmJLYJdMlKBnjHUAuJGbhUIEjs(
          int _param1,
          MouseMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.SBuctBbiUWpOQbvifGvJeYenjhM oqbvifGvJeYenjhM = new ReInput.ControllerHelper.ConflictCheckingHelper.SBuctBbiUWpOQbvifGvJeYenjhM(-2);
label_1:
          int num = -1143274906;
          while (true)
          {
            switch (num ^ -1143274910)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.jFbDkKOUsaOzHEUHAgIdalTItWe = _param4;
                num = -1143274908;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.nOdebFvuWOOIoFVsgNOVgTTPRNA = _param3;
                num = -1143274910;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.jGkVlHJvAXVULPCuOVSaVfDeUGN = _param2;
                num = -1143274909;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.gkeMefjkcVwdqOgKZJmbuvrdWow = _param1;
                num = -1143274912;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = -1143274911;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.pLpIivibMdGZDWWuHQzCwUBDkaK = _param5;
                // ISSUE: reference to a compiler-generated field
                oqbvifGvJeYenjhM.fTgLevlSLMvBzonjDdsYdaaRMYq = _param6;
                num = -1143274905;
                continue;
              case 7:
                goto label_1;
              default:
                goto label_9;
            }
          }
label_9:
          return (IEnumerable<ElementAssignmentConflictInfo>) oqbvifGvJeYenjhM;
        }

        private IEnumerable<ElementAssignmentConflictInfo> QnjmJLYJdMlKBnjHUAuJGbhUIEjs(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.xJJowTdwNLadunakXZZsYlKMWqq nladunakXzZsYlKmWqq = new ReInput.ControllerHelper.ConflictCheckingHelper.xJJowTdwNLadunakXZZsYlKMWqq(-2);
label_1:
          int num = 364718794;
          while (true)
          {
            switch (num ^ 364718795)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                nladunakXzZsYlKmWqq.jAEEOgBpVRMCaaPqwIozbIRzmyrQ = _param1;
                // ISSUE: reference to a compiler-generated field
                nladunakXzZsYlKmWqq.jFbDkKOUsaOzHEUHAgIdalTItWe = _param2;
                num = 364718793;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                nladunakXzZsYlKmWqq.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = 364718795;
                continue;
              case 3:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated field
          nladunakXzZsYlKmWqq.pLpIivibMdGZDWWuHQzCwUBDkaK = _param3;
          // ISSUE: reference to a compiler-generated field
          nladunakXzZsYlKmWqq.fTgLevlSLMvBzonjDdsYdaaRMYq = _param4;
          return (IEnumerable<ElementAssignmentConflictInfo>) nladunakXzZsYlKmWqq;
        }

        private IEnumerable<ElementAssignmentConflictInfo> vEvPgFkKIYAhikDmANXMEHHaBXVD(
          int _param1,
          int _param2,
          CustomControllerMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.zQuRMqUvKUjYOSPhllclicJSFRVc yosPhllclicJsfrVc = new ReInput.ControllerHelper.ConflictCheckingHelper.zQuRMqUvKUjYOSPhllclicJSFRVc(-2);
label_1:
          int num = 1586443964;
          while (true)
          {
            switch (num ^ 1586443965)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.TfOjkIFCYfkjDFvxzXmHOropZZII = _param2;
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.QOwFUkBQRWHzzbsbIJaQHriadFIN = _param3;
                num = 1586443966;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.gkeMefjkcVwdqOgKZJmbuvrdWow = _param1;
                num = 1586443965;
                continue;
              case 2:
                goto label_1;
              case 3:
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.nOdebFvuWOOIoFVsgNOVgTTPRNA = _param4;
                num = 1586443961;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.jFbDkKOUsaOzHEUHAgIdalTItWe = _param5;
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.pLpIivibMdGZDWWuHQzCwUBDkaK = _param6;
                // ISSUE: reference to a compiler-generated field
                yosPhllclicJsfrVc.fTgLevlSLMvBzonjDdsYdaaRMYq = _param7;
                num = 1586443960;
                continue;
              default:
                goto label_7;
            }
          }
label_7:
          return (IEnumerable<ElementAssignmentConflictInfo>) yosPhllclicJsfrVc;
        }

        private IEnumerable<ElementAssignmentConflictInfo> vEvPgFkKIYAhikDmANXMEHHaBXVD(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ReInput.ControllerHelper.ConflictCheckingHelper.ixFVXbnTpxNAzaKoukZkTpcXwWi nazaKoukZkTpcXwWi = new ReInput.ControllerHelper.ConflictCheckingHelper.ixFVXbnTpxNAzaKoukZkTpcXwWi(-2);
label_1:
          int num = 324581554;
          while (true)
          {
            switch (num ^ 324581553)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                nazaKoukZkTpcXwWi.jAEEOgBpVRMCaaPqwIozbIRzmyrQ = _param1;
                num = 324581552;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                nazaKoukZkTpcXwWi.jFbDkKOUsaOzHEUHAgIdalTItWe = _param2;
                // ISSUE: reference to a compiler-generated field
                nazaKoukZkTpcXwWi.pLpIivibMdGZDWWuHQzCwUBDkaK = _param3;
                num = 324581557;
                continue;
              case 2:
                goto label_1;
              case 3:
                // ISSUE: reference to a compiler-generated field
                nazaKoukZkTpcXwWi.oWHzslGHLsVLefMtCsKFnAsXbjj = this;
                num = 324581553;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                nazaKoukZkTpcXwWi.fTgLevlSLMvBzonjDdsYdaaRMYq = _param4;
                num = 324581556;
                continue;
              default:
                goto label_7;
            }
          }
label_7:
          return (IEnumerable<ElementAssignmentConflictInfo>) nazaKoukZkTpcXwWi;
        }

        public int RemoveElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap)
        {
          return this.RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, false, false, true);
        }

        public int RemoveElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps)
        {
          return this.RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, false, true);
        }

        public int RemoveElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public int RemoveElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (!ReInput.CheckInitialized() || playerId < 0)
            return 0;
label_2:
          int num = -737598967;
          while (true)
          {
            switch (num ^ -737598968)
            {
              case 1:
                if (elementMap != null)
                {
                  switch (controllerType)
                  {
                    case ControllerType.Keyboard:
                      num = -737598962;
                      continue;
                    case ControllerType.Mouse:
                      num = -737598966;
                      continue;
                    case ControllerType.Joystick:
                      num = -737598963;
                      continue;
                    case ControllerType.Custom:
                      num = -737598968;
                      continue;
                    default:
                      goto label_16;
                  }
                }
                else
                {
                  num = -737598964;
                  continue;
                }
              case 2:
                goto label_4;
              case 3:
                goto label_2;
              case 4:
                goto label_6;
              case 5:
                goto label_13;
              case 6:
                goto label_9;
              default:
                goto label_15;
            }
          }
label_4:
          return this.wWHGPmFLEsRHSYPbrZFUCuTLFaB(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_6:
          return 0;
label_9:
          return this.CfPqahaYFYfWFCVGlSrdyHcgTav(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_13:
          return this.lmqrZQjALiMwddsfftDdceMfASV(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_15:
          return this.eCatJEiLzvVAgcHcigNMjnkFInj(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
label_16:
          throw new NotImplementedException();
        }

        public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) => this.RemoveElementAssignmentConflicts(conflictCheck, false, false, true);

        public int RemoveElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps)
        {
          return this.RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps, false, true);
        }

        public int RemoveElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public int RemoveElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (ReInput.CheckInitialized())
            goto label_4;
label_1:
          int num = 2062379714;
label_2:
          switch (num ^ 2062379713)
          {
            case 0:
              return this.lmqrZQjALiMwddsfftDdceMfASV(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 1:
              return this.CfPqahaYFYfWFCVGlSrdyHcgTav(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 2:
              goto label_1;
            case 3:
              return 0;
            default:
              return this.eCatJEiLzvVAgcHcigNMjnkFInj(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
          }
label_4:
          if (conflictCheck.playerId < 0)
            return 0;
          if (conflictCheck.controllerType == ControllerType.Joystick)
          {
            num = 2062379713;
            goto label_2;
          }
          else if (conflictCheck.controllerType == ControllerType.Keyboard)
          {
            num = 2062379712;
            goto label_2;
          }
          else
          {
            if (conflictCheck.controllerType == ControllerType.Mouse)
              return this.wWHGPmFLEsRHSYPbrZFUCuTLFaB(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            if (conflictCheck.controllerType != ControllerType.Custom)
              throw new NotImplementedException();
            num = 2062379717;
            goto label_2;
          }
        }

        private int lmqrZQjALiMwddsfftDdceMfASV(
          int _param1,
          int _param2,
          JoystickMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = -1667879469;
            int num2;
            while (true)
            {
              IList<Player> playerList1;
              int index;
              IList<Player> playerList2;
              switch (num1 ^ -1667879470)
              {
                case 0:
                  int num3;
                  num1 = num3 = index < playerList1.Count ? -1667879466 : (num3 = -1667879462);
                  continue;
                case 1:
                  if (_param4 != null)
                  {
                    if (!_param7)
                    {
                      num1 = -1667879472;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = -1667879467;
                  continue;
                case 2:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 3:
                  goto label_1;
                case 4:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Joystick, _param2, (ControllerMap) _param3, _param4, _param5, _param6);
                  ++index;
                  num1 = -1667879470;
                  continue;
                case 5:
                  num2 = 0;
                  num1 = -1667879468;
                  continue;
                case 6:
                  index = 0;
                  num1 = -1667879470;
                  continue;
                case 7:
                  goto label_4;
                default:
                  goto label_15;
              }
              playerList1 = playerList2;
              num1 = -1667879465;
            }
label_15:
            return num2;
          }
label_4:
          return 0;
        }

        private int lmqrZQjALiMwddsfftDdceMfASV(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
            if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
              goto label_5;
label_2:
            int num1 = -752971084;
label_3:
            IList<Player> playerList;
            int index;
            int num2;
            while (true)
            {
              switch (num1 ^ -752971087)
              {
                case 0:
                  num2 = 0;
                  index = 0;
                  num1 = -752971083;
                  continue;
                case 1:
                  int num3;
                  num1 = num3 = index < playerList.Count ? -752971085 : (num3 = -752971081);
                  continue;
                case 2:
                  num2 += playerList[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(_param1, _param2, _param3);
                  ++index;
                  num1 = -752971088;
                  continue;
                case 3:
                  goto label_2;
                case 4:
                  num1 = -752971088;
                  continue;
                case 5:
                  goto label_4;
                default:
                  goto label_10;
              }
            }
label_10:
            return num2;
label_5:
            playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            num1 = -752971087;
            goto label_3;
          }
label_4:
          return 0;
        }

        private int CfPqahaYFYfWFCVGlSrdyHcgTav(
          int _param1,
          KeyboardMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = -1084626074;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ -1084626079)
              {
                case 0:
                  goto label_12;
                case 2:
                  goto label_1;
                case 3:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 4:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Keyboard, 0, (ControllerMap) _param2, _param3, _param4, _param5);
                  ++index;
                  num1 = -1084626071;
                  continue;
                case 5:
                  num2 = 0;
                  index = 0;
                  num1 = -1084626073;
                  continue;
                case 6:
                  num1 = -1084626071;
                  continue;
                case 7:
                  if (_param3 == null)
                  {
                    num1 = -1084626079;
                    continue;
                  }
                  if (_param6)
                  {
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = -1084626078;
                  continue;
                case 8:
                  int num3;
                  num1 = num3 = index < playerList1.Count ? -1084626075 : (num3 = -1084626080);
                  continue;
                default:
                  goto label_15;
              }
              playerList1 = playerList2;
              num1 = -1084626076;
            }
label_15:
            return num2;
          }
label_12:
          return 0;
        }

        private int CfPqahaYFYfWFCVGlSrdyHcgTav(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = 1991133956;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ 1991133957)
              {
                case 0:
                  int num3;
                  num1 = num3 = index >= playerList1.Count ? 1991133952 : (num3 = 1991133955);
                  continue;
                case 1:
                  if (_param1.elementAssignmentType == ElementAssignmentType.KeyboardKey)
                  {
                    if (!_param4)
                    {
                      num1 = 1991133958;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = 1991133953;
                  continue;
                case 2:
                  goto label_1;
                case 3:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 4:
                  goto label_4;
                case 6:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(_param1, _param2, _param3);
                  ++index;
                  num1 = 1991133957;
                  continue;
                case 7:
                  num2 = 0;
                  index = 0;
                  num1 = 1991133957;
                  continue;
                default:
                  goto label_14;
              }
              playerList1 = playerList2;
              num1 = 1991133954;
            }
label_14:
            return num2;
          }
label_4:
          return 0;
        }

        private int wWHGPmFLEsRHSYPbrZFUCuTLFaB(
          int _param1,
          MouseMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = 426825070;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ 426825071)
              {
                case 0:
                  num2 = 0;
                  index = 0;
                  num1 = 426825068;
                  continue;
                case 1:
                  if (_param3 == null)
                  {
                    num1 = 426825069;
                    continue;
                  }
                  if (_param6)
                  {
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = 426825065;
                  continue;
                case 2:
                  goto label_11;
                case 4:
                  goto label_1;
                case 5:
                  ++index;
                  num1 = 426825068;
                  continue;
                case 6:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 7:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Mouse, 0, (ControllerMap) _param2, _param3, _param4, _param5);
                  num1 = 426825066;
                  continue;
                default:
                  if (index < playerList1.Count)
                    goto case 7;
                  else
                    goto label_15;
              }
              playerList1 = playerList2;
              num1 = 426825071;
            }
label_15:
            return num2;
          }
label_11:
          return 0;
        }

        private int wWHGPmFLEsRHSYPbrZFUCuTLFaB(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = 848627120;
            int num2;
            IList<Player> playerList;
            int index;
            while (true)
            {
              switch (num1 ^ 848627125)
              {
                case 0:
                  goto label_4;
                case 1:
                  int num3;
                  num1 = num3 = index < playerList.Count ? 848627123 : (num3 = 848627121);
                  continue;
                case 2:
                  goto label_1;
                case 3:
                  index = 0;
                  num1 = 848627124;
                  continue;
                case 5:
                  if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
                  {
                    playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                    num1 = 848627122;
                    continue;
                  }
                  num1 = 848627125;
                  continue;
                case 6:
                  num2 += playerList[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(_param1, _param2, _param3);
                  ++index;
                  num1 = 848627124;
                  continue;
                case 7:
                  num2 = 0;
                  num1 = 848627126;
                  continue;
                default:
                  goto label_11;
              }
            }
label_11:
            return num2;
          }
label_4:
          return 0;
        }

        private int eCatJEiLzvVAgcHcigNMjnkFInj(
          int _param1,
          int _param2,
          CustomControllerMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = 1344382855;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ 1344382850)
              {
                case 0:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 1:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Custom, _param2, (ControllerMap) _param3, _param4, _param5, _param6);
                  ++index;
                  num1 = 1344382854;
                  continue;
                case 2:
                  num2 = 0;
                  index = 0;
                  num1 = 1344382852;
                  continue;
                case 3:
                  goto label_1;
                case 4:
                  int num3;
                  num1 = num3 = index >= playerList1.Count ? 1344382858 : (num3 = 1344382851);
                  continue;
                case 5:
                  if (_param4 != null)
                  {
                    if (!_param7)
                    {
                      num1 = 1344382850;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = 1344382853;
                  continue;
                case 6:
                  num1 = 1344382854;
                  continue;
                case 7:
                  goto label_7;
                default:
                  goto label_15;
              }
              playerList1 = playerList2;
              num1 = 1344382848;
            }
label_15:
            return num2;
          }
label_7:
          return 0;
        }

        private int eCatJEiLzvVAgcHcigNMjnkFInj(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
            if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
              goto label_8;
label_2:
            int num1 = 751374189;
label_3:
            int num2;
            int index;
            IList<Player> playerList1;
            while (true)
            {
              switch (num1 ^ 751374191)
              {
                case 1:
                  num2 += playerList1[index].controllers.conflictChecking.RemoveElementAssignmentConflicts(_param1, _param2, _param3);
                  num1 = 751374188;
                  continue;
                case 2:
                  goto label_7;
                case 3:
                  ++index;
                  num1 = 751374191;
                  continue;
                case 4:
                  goto label_2;
                case 5:
                  goto label_10;
                case 6:
                  num1 = 751374191;
                  continue;
                case 7:
                  num2 = 0;
                  index = 0;
                  num1 = 751374185;
                  continue;
                default:
                  if (index < playerList1.Count)
                    goto case 1;
                  else
                    goto label_15;
              }
            }
label_10:
            IList<Player> playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            goto label_12;
label_15:
            return num2;
label_8:
            if (!_param4)
            {
              num1 = 751374186;
              goto label_3;
            }
            else
              playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
label_12:
            playerList1 = playerList2;
            num1 = 751374184;
            goto label_3;
          }
label_7:
          return 0;
        }

        public int DisableElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap)
        {
          return this.DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, false, false, true);
        }

        public int DisableElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps)
        {
          return this.DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, false, true);
        }

        public int DisableElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public int DisableElementAssignmentConflicts(
          int playerId,
          ControllerType controllerType,
          int controllerId,
          ControllerMap controllerMap,
          ActionElementMap elementMap,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (!ReInput.CheckInitialized() || playerId < 0)
            return 0;
label_2:
          int num = 1572044415;
          while (true)
          {
            switch (num ^ 1572044414)
            {
              case 1:
                if (elementMap == null)
                {
                  num = 1572044414;
                  continue;
                }
                goto label_7;
              case 2:
                goto label_2;
              default:
                goto label_6;
            }
          }
label_6:
          return 0;
label_7:
          switch (controllerType)
          {
            case ControllerType.Keyboard:
              return this.YMdwzrJdRAIDnTQYdefyKijLlZo(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case ControllerType.Mouse:
              return this.pvvuWXovnLQmqbSZwMFMMZBuLvP(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case ControllerType.Joystick:
              return this.JjngpSkuupyeMzKCHpeCTRTNPiR(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case ControllerType.Custom:
              return this.ijZzjCRLgChXdpDvYfPbolEjjVo(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            default:
              throw new NotImplementedException();
          }
        }

        public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) => this.DisableElementAssignmentConflicts(conflictCheck, false, false, true);

        public int DisableElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps)
        {
          return this.DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps, false, true);
        }

        public int DisableElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories)
        {
          return this.DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, true);
        }

        public int DisableElementAssignmentConflicts(
          ElementAssignmentConflictCheck conflictCheck,
          bool skipDisabledMaps,
          bool forceCheckAllCategories,
          bool includeSystemPlayer)
        {
          if (ReInput.CheckInitialized())
            goto label_16;
label_1:
          int num = 213374000;
label_2:
          switch (num ^ 213374003)
          {
            case 0:
              goto label_1;
            case 1:
              return this.JjngpSkuupyeMzKCHpeCTRTNPiR(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 2:
              return this.pvvuWXovnLQmqbSZwMFMMZBuLvP(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            case 3:
              return 0;
            case 4:
              return 0;
            case 5:
              return this.YMdwzrJdRAIDnTQYdefyKijLlZo(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
            default:
              return this.ijZzjCRLgChXdpDvYfPbolEjjVo(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
          }
label_16:
          if (conflictCheck.playerId >= 0)
          {
            if (conflictCheck.controllerType != ControllerType.Joystick)
            {
              if (conflictCheck.controllerType == ControllerType.Keyboard)
              {
                num = 213374006;
                goto label_2;
              }
              else if (conflictCheck.controllerType == ControllerType.Mouse)
              {
                num = 213374001;
                goto label_2;
              }
              else
              {
                if (conflictCheck.controllerType != ControllerType.Custom)
                  throw new NotImplementedException();
                num = 213374005;
                goto label_2;
              }
            }
            else
            {
              num = 213374002;
              goto label_2;
            }
          }
          else
          {
            num = 213374007;
            goto label_2;
          }
        }

        private int JjngpSkuupyeMzKCHpeCTRTNPiR(
          int _param1,
          int _param2,
          JoystickMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
label_1:
            int num1 = -929473479;
            int num2;
            int index;
            IList<Player> playerList;
            while (true)
            {
              switch (num1 ^ -929473478)
              {
                case 0:
                  num2 += playerList[index].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Joystick, _param2, (ControllerMap) _param3, _param4, _param5, _param6);
                  num1 = -929473473;
                  continue;
                case 1:
                  index = 0;
                  num1 = -929473486;
                  continue;
                case 3:
                  if (_param4 != null)
                  {
                    playerList = _param7 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                    num1 = -929473474;
                    continue;
                  }
                  num1 = -929473476;
                  continue;
                case 4:
                  num2 = 0;
                  num1 = -929473477;
                  continue;
                case 5:
                  ++index;
                  num1 = -929473480;
                  continue;
                case 6:
                  goto label_8;
                case 7:
                  goto label_1;
                case 8:
                  num1 = -929473480;
                  continue;
                default:
                  if (index < playerList.Count)
                    goto case 0;
                  else
                    goto label_13;
              }
            }
label_13:
            return num2;
          }
label_8:
          return 0;
        }

        private int JjngpSkuupyeMzKCHpeCTRTNPiR(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
            if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
              goto label_9;
label_2:
            int num1 = 388481779;
label_3:
            int num2;
            IList<Player> playerList;
            int index;
            while (true)
            {
              switch (num1 ^ 388481781)
              {
                case 0:
                  num1 = 388481776;
                  continue;
                case 1:
                  num2 += playerList[index].controllers.conflictChecking.DisableElementAssignmentConflicts(_param1, _param2, _param3);
                  num1 = 388481778;
                  continue;
                case 3:
                  num2 = 0;
                  num1 = 388481789;
                  continue;
                case 4:
                  goto label_2;
                case 5:
                  int num3;
                  num1 = num3 = index >= playerList.Count ? 388481783 : (num3 = 388481780);
                  continue;
                case 6:
                  goto label_8;
                case 7:
                  ++index;
                  num1 = 388481776;
                  continue;
                case 8:
                  index = 0;
                  num1 = 388481781;
                  continue;
                default:
                  goto label_12;
              }
            }
label_12:
            return num2;
label_9:
            playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            num1 = 388481782;
            goto label_3;
          }
label_8:
          return 0;
        }

        private int YMdwzrJdRAIDnTQYdefyKijLlZo(
          int _param1,
          KeyboardMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
            if (_param3 != null)
              goto label_7;
label_2:
            int num1 = 1047711455;
label_3:
            int num2;
            int index;
            IList<Player> playerList1;
            while (true)
            {
              switch (num1 ^ 1047711454)
              {
                case 1:
                  goto label_6;
                case 2:
                  goto label_10;
                case 3:
                  num1 = 1047711454;
                  continue;
                case 4:
                  num2 += playerList1[index].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Keyboard, 0, (ControllerMap) _param2, _param3, _param4, _param5);
                  ++index;
                  num1 = 1047711454;
                  continue;
                case 5:
                  goto label_2;
                case 6:
                  num2 = 0;
                  index = 0;
                  num1 = 1047711453;
                  continue;
                default:
                  if (index < playerList1.Count)
                    goto case 4;
                  else
                    goto label_14;
              }
            }
label_10:
            IList<Player> playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            goto label_12;
label_14:
            return num2;
label_7:
            if (!_param6)
            {
              num1 = 1047711452;
              goto label_3;
            }
            else
              playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
label_12:
            playerList1 = playerList2;
            num1 = 1047711448;
            goto label_3;
          }
label_6:
          return 0;
        }

        private int YMdwzrJdRAIDnTQYdefyKijLlZo(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = -206965975;
            int index;
            int num2;
            IList<Player> playerList;
            while (true)
            {
              switch (num1 ^ -206965970)
              {
                case 0:
                  ++index;
                  num1 = -206965969;
                  continue;
                case 1:
                  int num3;
                  num1 = num3 = index < playerList.Count ? -206965976 : (num3 = -206965974);
                  continue;
                case 2:
                  goto label_5;
                case 3:
                  num2 = 0;
                  num1 = -206965973;
                  continue;
                case 5:
                  index = 0;
                  num1 = -206965969;
                  continue;
                case 6:
                  num2 += playerList[index].controllers.conflictChecking.DisableElementAssignmentConflicts(_param1, _param2, _param3);
                  num1 = -206965970;
                  continue;
                case 7:
                  if (_param1.elementAssignmentType == ElementAssignmentType.KeyboardKey)
                  {
                    playerList = _param4 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                    num1 = -206965971;
                    continue;
                  }
                  num1 = -206965972;
                  continue;
                case 8:
                  goto label_1;
                default:
                  goto label_12;
              }
            }
label_12:
            return num2;
          }
label_5:
          return 0;
        }

        private int pvvuWXovnLQmqbSZwMFMMZBuLvP(
          int _param1,
          MouseMap _param2,
          ActionElementMap _param3,
          bool _param4 = false,
          bool _param5 = false,
          bool _param6 = true)
        {
          if (_param1 >= 0)
          {
            if (_param3 != null)
              goto label_7;
label_2:
            int num1 = 1754969975;
label_3:
            int index;
            int num2;
            IList<Player> playerList;
            while (true)
            {
              switch (num1 ^ 1754969974)
              {
                case 0:
                  index = 0;
                  num1 = 1754969970;
                  continue;
                case 1:
                  goto label_6;
                case 2:
                  goto label_2;
                case 3:
                  num2 += playerList[index].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Mouse, 0, (ControllerMap) _param2, _param3, _param4, _param5);
                  ++index;
                  num1 = 1754969969;
                  continue;
                case 4:
                  num1 = 1754969969;
                  continue;
                case 5:
                  num2 = 0;
                  num1 = 1754969974;
                  continue;
                case 7:
                  int num3;
                  num1 = num3 = index >= playerList.Count ? 1754969968 : (num3 = 1754969973);
                  continue;
                default:
                  goto label_11;
              }
            }
label_11:
            return num2;
label_7:
            playerList = _param6 ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            num1 = 1754969971;
            goto label_3;
          }
label_6:
          return 0;
        }

        private int pvvuWXovnLQmqbSZwMFMMZBuLvP(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = -1353720507;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ -1353720511)
              {
                case 0:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 1:
                  index = 0;
                  num1 = -1353720503;
                  continue;
                case 2:
                  num2 += playerList1[index].controllers.conflictChecking.DisableElementAssignmentConflicts(_param1, _param2, _param3);
                  num1 = -1353720505;
                  continue;
                case 4:
                  if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
                  {
                    if (!_param4)
                    {
                      num1 = -1353720511;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = -1353720508;
                  continue;
                case 5:
                  goto label_4;
                case 6:
                  ++index;
                  num1 = -1353720504;
                  continue;
                case 7:
                  num2 = 0;
                  num1 = -1353720512;
                  continue;
                case 8:
                  num1 = -1353720504;
                  continue;
                case 9:
                  int num3;
                  num1 = num3 = index >= playerList1.Count ? -1353720510 : (num3 = -1353720509);
                  continue;
                case 10:
                  goto label_1;
                default:
                  goto label_17;
              }
              playerList1 = playerList2;
              num1 = -1353720506;
            }
label_17:
            return num2;
          }
label_4:
          return 0;
        }

        private int ijZzjCRLgChXdpDvYfPbolEjjVo(
          int _param1,
          int _param2,
          CustomControllerMap _param3,
          ActionElementMap _param4,
          bool _param5 = false,
          bool _param6 = false,
          bool _param7 = true)
        {
          if (_param1 >= 0)
          {
            if (_param4 != null)
              goto label_9;
label_2:
            int num1 = 1323415393;
label_3:
            int index;
            IList<Player> playerList1;
            int num2;
            while (true)
            {
              switch (num1 ^ 1323415392)
              {
                case 0:
                  num2 += playerList1[index].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Custom, _param2, (ControllerMap) _param3, _param4, _param5, _param6);
                  num1 = 1323415394;
                  continue;
                case 1:
                  goto label_8;
                case 2:
                  ++index;
                  num1 = 1323415398;
                  continue;
                case 4:
                  goto label_2;
                case 5:
                  goto label_5;
                case 6:
                  int num3;
                  num1 = num3 = index < playerList1.Count ? 1323415392 : (num3 = 1323415395);
                  continue;
                default:
                  goto label_13;
              }
            }
label_5:
            IList<Player> playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
            goto label_7;
label_13:
            return num2;
label_7:
            playerList1 = playerList2;
            num2 = 0;
            index = 0;
            num1 = 1323415398;
            goto label_3;
label_9:
            if (_param7)
            {
              playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
              goto label_7;
            }
            else
            {
              num1 = 1323415397;
              goto label_3;
            }
          }
label_8:
          return 0;
        }

        private int ijZzjCRLgChXdpDvYfPbolEjjVo(
          ElementAssignmentConflictCheck _param1,
          bool _param2 = false,
          bool _param3 = false,
          bool _param4 = true)
        {
          if (_param1.playerId >= 0)
          {
label_1:
            int num1 = -1380356140;
            int num2;
            while (true)
            {
              int index;
              IList<Player> playerList1;
              IList<Player> playerList2;
              switch (num1 ^ -1380356142)
              {
                case 0:
                  goto label_1;
                case 1:
                  int num3;
                  num1 = num3 = index < playerList1.Count ? -1380356138 : (num3 = -1380356133);
                  continue;
                case 2:
                  ++index;
                  num1 = -1380356141;
                  continue;
                case 3:
                  goto label_6;
                case 4:
                  num2 += playerList1[index].controllers.conflictChecking.DisableElementAssignmentConflicts(_param1, _param2, _param3);
                  num1 = -1380356144;
                  continue;
                case 5:
                  playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;
                  break;
                case 6:
                  if (_param1.elementAssignmentType != ElementAssignmentType.KeyboardKey)
                  {
                    if (!_param4)
                    {
                      num1 = -1380356137;
                      continue;
                    }
                    playerList2 = ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
                    break;
                  }
                  num1 = -1380356143;
                  continue;
                case 7:
                  num1 = -1380356141;
                  continue;
                case 8:
                  num2 = 0;
                  index = 0;
                  num1 = -1380356139;
                  continue;
                default:
                  goto label_16;
              }
              playerList1 = playerList2;
              num1 = -1380356134;
            }
label_16:
            return num2;
          }
label_6:
          return 0;
        }
      }
    }

    /// <summary>
    /// Provides access to all mapping-related data defined in the Rewired Editor.
    /// This data is read-only. Data created in the Rewired Editor cannot be changed at run time.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class MappingHelper : CodeHelper
    {
      private static ReInput.MappingHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;

      internal static ReInput.MappingHelper Instance => ReInput.MappingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.MappingHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.MappingHelper());

      private MappingHelper()
      {
      }

      /// <summary>Gets list of all map categories</summary>
      public IList<InputMapCategory> MapCategories => !ReInput.CheckInitialized() ? EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.MapCategories_readOnly;

      /// <summary>Gets a specific map category</summary>
      /// <param name="mapCategoryId">Map Category id</param>
      /// <returns>Map Category</returns>
      public InputMapCategory GetMapCategory(int mapCategoryId) => !ReInput.CheckInitialized() ? (InputMapCategory) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMapCategoryById(mapCategoryId);

      /// <summary>Gets a specific map category</summary>
      /// <param name="name">Map Category name</param>
      /// <returns>Map Category</returns>
      public InputMapCategory GetMapCategory(string name) => !ReInput.CheckInitialized() ? (InputMapCategory) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMapCategory(name);

      /// <summary>Gets id of a specific map category</summary>
      /// <param name="name">Map Category name</param>
      /// <returns>Map Category id</returns>
      public int GetMapCategoryId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMapCategoryId(name);

      /// <summary>Enumerates all map categories with matching tag</summary>
      /// <param name="tag">Tag</param>
      /// <returns>IEnumerable of Map Categories with tag</returns>
      public IEnumerable<InputMapCategory> MapCategoriesWithTag(
        string tag)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputMapCategory>) EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.OubiptfelyjsXZZzaWNKAuRMODo(tag);
      }

      /// <summary>Enumerates all user-assignable map categories</summary>
      /// <returns>IEnumerable of user-assignable Map Categories</returns>
      public IEnumerable<InputMapCategory> UserAssignableMapCategories => !ReInput.CheckInitialized() ? (IEnumerable<InputMapCategory>) EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.UserAssignableMapCategories;

      /// <summary>
      /// Enumerates all user-assignable map categories with matching tag
      /// </summary>
      /// <param name="tag">Tag</param>
      /// <returns>IEnumerable of user-assignable Map Categories with tag</returns>
      public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(
        string tag)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputMapCategory>) EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.oirhjuDyRxIClCMaZavJHktrDZXf(tag);
      }

      /// <summary>Is the specified map category user assignable?</summary>
      /// <param name="mapCategoryId">Map Category id</param>
      /// <returns>True = is user assignable</returns>
      public bool IsMapCategoryUserAssignable(int mapCategoryId)
      {
        if (!ReInput.CheckInitialized())
          return false;
        InputCategory mapCategory = (InputCategory) this.GetMapCategory(mapCategoryId);
        return mapCategory != null && mapCategory.userAssignable;
      }

      /// <summary>Gets a specific action category</summary>
      /// <param name="mapCategoryId">Action Category id</param>
      /// <returns>Action Category</returns>
      public InputCategory GetActionCategory(int mapCategoryId) => !ReInput.CheckInitialized() ? (InputCategory) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetActionCategoryById(mapCategoryId);

      /// <summary>Gets a specific action category</summary>
      /// <param name="name">Action Category name</param>
      /// <returns>Action Category</returns>
      public InputCategory GetActionCategory(string name) => !ReInput.CheckInitialized() ? (InputCategory) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetActionCategory(name);

      /// <summary>Gets the id of a specific action category</summary>
      /// <param name="name">Action Category name</param>
      /// <returns>Id of the Action Category</returns>
      public int GetActionCategoryId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetActionCategoryId(name);

      /// <summary>Gets list of all action categories</summary>
      public IList<InputCategory> ActionCategories => !ReInput.CheckInitialized() ? EmptyObjects<InputCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.ActionCategories_readOnly;

      /// <summary>Enumerates all action categories with matching tag</summary>
      /// <param name="tag">Tag</param>
      /// <returns>IEnumerable of Action Categories with tag</returns>
      public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag) => !ReInput.CheckInitialized() ? (IEnumerable<InputCategory>) EmptyObjects<InputCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.yPSYISmfCaZxfzzskcYvvTVVsLa(tag);

      /// <summary>Enumerates all user-assignable action categories</summary>
      public IEnumerable<InputCategory> UserAssignableActionCategories => !ReInput.CheckInitialized() ? (IEnumerable<InputCategory>) EmptyObjects<InputCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.UserAssignableActionCategories;

      /// <summary>
      /// Enumerates all user-assignable action categories with matching tag
      /// </summary>
      /// <param name="tag">Tag</param>
      /// <returns>IEnumerable of user-assignable Action Categories with tag</returns>
      public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(
        string tag)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputCategory>) EmptyObjects<InputCategory>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.KrppnjfvpIPVAaeTOHmmCGlXiLU(tag);
      }

      /// <summary>Is the specified action category user-assignable?</summary>
      /// <param name="mapCategoryId">Action Category id</param>
      /// <returns>True = is user assignable</returns>
      public bool IsActionCategoryUserAssignable(int mapCategoryId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1461612294;
label_2:
        switch (num ^ -1461612296)
        {
          case 0:
            goto label_1;
          case 2:
            return false;
          default:
            return false;
        }
label_4:
        InputCategory actionCategory = this.GetActionCategory(mapCategoryId);
        if (actionCategory != null)
          return actionCategory.userAssignable;
        num = -1461612295;
        goto label_2;
      }

      /// <summary>
      /// Gets a layout by specifying the controller type and layout id
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <param name="layoutId">Layout id</param>
      /// <returns>Layout</returns>
      public InputLayout GetLayout(ControllerType controllerType, int layoutId)
      {
        if (!ReInput.CheckInitialized())
          return (InputLayout) null;
        ControllerType controllerType1 = controllerType;
        switch (controllerType1)
        {
          case ControllerType.Keyboard:
            return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayoutById(layoutId);
          case ControllerType.Mouse:
            return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayoutById(layoutId);
          case ControllerType.Joystick:
label_5:
            return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayoutById(layoutId);
          default:
label_3:
            switch (-1131281660 ^ -1131281659)
            {
              case 1:
                if (controllerType1 == ControllerType.Custom)
                  return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayoutById(layoutId);
                throw new NotImplementedException();
              case 2:
                goto label_3;
              default:
                goto label_5;
            }
        }
      }

      /// <summary>
      /// Gets a layout by specifying the controller type and layout name
      /// </summary>
      /// <param name="controllerType">Controller type</param>
      /// <param name="name">Layout name</param>
      /// <returns>Layout</returns>
      public InputLayout GetLayout(ControllerType controllerType, string name)
      {
        if (ReInput.CheckInitialized())
          goto label_7;
label_1:
        int num = 2142321005;
label_2:
        ControllerType controllerType1;
        while (true)
        {
          switch (num ^ 2142321001)
          {
            case 0:
              goto label_1;
            case 1:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  goto label_9;
                case ControllerType.Mouse:
                  goto label_10;
                case ControllerType.Joystick:
                  goto label_8;
                default:
                  num = 2142321002;
                  continue;
              }
            case 3:
              goto label_3;
            case 4:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_3:
        if (controllerType1 == ControllerType.Custom)
          return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayout(name);
        throw new NotImplementedException();
label_6:
        return (InputLayout) null;
label_8:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayout(name);
label_9:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayout(name);
label_10:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayout(name);
label_7:
        controllerType1 = controllerType;
        num = 2142321000;
        goto label_2;
      }

      /// <summary>Gets id of a layout by controller type</summary>
      /// <param name="controllerType">Controller type</param>
      /// <param name="name">Layout name</param>
      /// <returns>Layout id</returns>
      public int GetLayoutId(ControllerType controllerType, string name)
      {
        if (ReInput.CheckInitialized())
          goto label_7;
label_1:
        int num = 686905960;
label_2:
        ControllerType controllerType1;
        while (true)
        {
          switch (num ^ 686905962)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              goto label_6;
            case 4:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  goto label_9;
                case ControllerType.Mouse:
                  goto label_10;
                case ControllerType.Joystick:
                  goto label_8;
                default:
                  num = 686905963;
                  continue;
              }
            default:
              goto label_8;
          }
        }
label_3:
        if (controllerType1 == ControllerType.Custom)
          return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayoutId(name);
        throw new NotImplementedException();
label_6:
        return -1;
label_8:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayoutId(name);
label_9:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayoutId(name);
label_10:
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayoutId(name);
label_7:
        controllerType1 = controllerType;
        num = 686905966;
        goto label_2;
      }

      /// <summary>Gets a joystick layout</summary>
      /// <param name="layoutId">Layout id</param>
      /// <returns>Joystick Layout</returns>
      public InputLayout GetJoystickLayout(int layoutId) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayoutById(layoutId);

      /// <summary>Gets a joystick layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Joystick Layout</returns>
      public InputLayout GetJoystickLayout(string name) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayout(name);

      /// <summary>Gets the id of a joystick layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Joystick Layout id</returns>
      public int GetJoystickLayoutId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetJoystickLayoutId(name);

      /// <summary>Gets a keyboard layout</summary>
      /// <param name="layoutId">Layout id</param>
      /// <returns>Keyboard Layout</returns>
      public InputLayout GetKeyboardLayout(int layoutId) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayoutById(layoutId);

      /// <summary>Gets a keyboard layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Keyboard layout</returns>
      public InputLayout GetKeyboardLayout(string name) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayout(name);

      /// <summary>Gets the id of a keyboard layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Keyboard Layout id</returns>
      public int GetKeyboardLayoutId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetKeyboardLayoutId(name);

      /// <summary>Get a mouse layout</summary>
      /// <param name="layoutId">Layout id</param>
      /// <returns>Mouse Layout</returns>
      public InputLayout GetMouseLayout(int layoutId) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayoutById(layoutId);

      /// <summary>Gets a mouse layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Mouse Layout</returns>
      public InputLayout GetMouseLayout(string name) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayout(name);

      /// <summary>Gets the id of a mouse layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Mouse Layout id</returns>
      public int GetMouseLayoutId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetMouseLayoutId(name);

      /// <summary>Gets a custom controller layout</summary>
      /// <param name="layoutId">Layout id</param>
      /// <returns>Custom Controller Layout</returns>
      public InputLayout GetCustomControllerLayout(int layoutId) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayoutById(layoutId);

      /// <summary>Gets a custom controller layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Custom Controller Layout</returns>
      public InputLayout GetCustomControllerLayout(string name) => !ReInput.CheckInitialized() ? (InputLayout) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayout(name);

      /// <summary>Gets the id of a custom controller layout</summary>
      /// <param name="name">Layout name</param>
      /// <returns>Custom Controller id</returns>
      public int GetCustomControllerLayoutId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerLayoutId(name);

      /// <summary>
      /// Gets a list of all map layouts for the specified controller type
      /// </summary>
      /// <param name="controllerType">Type of controller</param>
      /// <returns>List of map layouts</returns>
      public IList<InputLayout> MapLayouts(ControllerType controllerType)
      {
        if (ReInput.CheckInitialized())
          goto label_7;
label_1:
        int num = 681488523;
label_2:
        ControllerType controllerType1;
        while (true)
        {
          switch (num ^ 681488527)
          {
            case 0:
              goto label_1;
            case 2:
              switch (controllerType1)
              {
                case ControllerType.Keyboard:
                  goto label_9;
                case ControllerType.Mouse:
                  goto label_10;
                case ControllerType.Joystick:
                  goto label_8;
                default:
                  num = 681488524;
                  continue;
              }
            case 3:
              goto label_3;
            case 4:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_3:
        if (controllerType1 == ControllerType.Custom)
          return this.CustomControllerLayouts;
        throw new NotImplementedException();
label_6:
        return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
label_8:
        return this.JoystickLayouts;
label_9:
        return this.KeyboardLayouts;
label_10:
        return this.MouseLayouts;
label_7:
        controllerType1 = controllerType;
        num = 681488525;
        goto label_2;
      }

      /// <summary>Gets a list of all joystick layouts</summary>
      public IList<InputLayout> JoystickLayouts => !ReInput.CheckInitialized() ? EmptyObjects<InputLayout>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.JoystickLayouts_readOnly;

      /// <summary>Gets a list of all keyboard layouts</summary>
      public IList<InputLayout> KeyboardLayouts => !ReInput.CheckInitialized() ? EmptyObjects<InputLayout>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.KeyboardLayouts_readOnly;

      /// <summary>Gets a list of all mouse layouts</summary>
      public IList<InputLayout> MouseLayouts => !ReInput.CheckInitialized() ? EmptyObjects<InputLayout>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.MouseLayouts_readOnly;

      /// <summary>Gets a list of all custom controller layouts</summary>
      public IList<InputLayout> CustomControllerLayouts => !ReInput.CheckInitialized() ? EmptyObjects<InputLayout>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.CustomControllerLayouts_readOnly;

      /// <summary>Gets a list of all actions</summary>
      public IList<InputAction> Actions => !ReInput.CheckInitialized() ? EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.huPkcghnmfujhITXupfvuZzZnvX.MGhcRgBKrTLChHZBGzmNgcYWsSuL;

      /// <summary>Gets a specific action</summary>
      /// <param name="actionId">Action id</param>
      /// <returns>Action</returns>
      public InputAction GetAction(int actionId) => !ReInput.CheckInitialized() ? (InputAction) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetActionById(actionId);

      /// <summary>Gets a specific action</summary>
      /// <param name="name">Action name</param>
      /// <returns>Action</returns>
      public InputAction GetAction(string name) => !ReInput.CheckInitialized() ? (InputAction) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetAction(name);

      /// <summary>Gets the id of a specific action</summary>
      /// <param name="name">Action name</param>
      /// <returns>Action id</returns>
      public int GetActionId(string name) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetActionId(name);

      /// <summary>Enumerates all user-assignable actions</summary>
      public IEnumerable<InputAction> UserAssignableActions => !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.UserAssignableActions;

      /// <summary>Enumerates all actions in a specific category</summary>
      /// <param name="mapCategoryName">Category name</param>
      /// <returns>IEnumerable of actions in category</returns>
      public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName) => !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.tZnySWAcdXgcoBBnwsXzLwURLtT(mapCategoryName, false);

      /// <summary>Enumerates all actions in a specific category</summary>
      /// <param name="mapCategoryName">Category name</param>
      /// <param name="sort">Sorts results as shown in Rewired Input Manager</param>
      /// <returns>IEnumerable of actions in category</returns>
      public IEnumerable<InputAction> ActionsInCategory(
        string mapCategoryName,
        bool sort)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.tZnySWAcdXgcoBBnwsXzLwURLtT(mapCategoryName, sort);
      }

      /// <summary>Enumerates all actions in a specific category</summary>
      /// <param name="mapCategoryId">Caregory id</param>
      /// <returns>IEnumerable of actions in category</returns>
      public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId) => !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.tZnySWAcdXgcoBBnwsXzLwURLtT(mapCategoryId, false);

      /// <summary>Enumerates all actions in a specific category</summary>
      /// <param name="mapCategoryId">Caregory id</param>
      /// <param name="sort">Sorts results as shown in Rewired Input Manager</param>
      /// <returns>IEnumerable of actions in category</returns>
      public IEnumerable<InputAction> ActionsInCategory(
        int mapCategoryId,
        bool sort)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.tZnySWAcdXgcoBBnwsXzLwURLtT(mapCategoryId, sort);
      }

      /// <summary>Enumerates all actions with a tag</summary>
      /// <param name="tag">Tag</param>
      /// <returns>IEnumerable of actions with tag</returns>
      public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag) => !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.saQURWPbOfyIDfHqrhGHIUfQplg(tag);

      /// <summary>
      /// Enumerates all user-assignable actions in a specific category
      /// </summary>
      /// <param name="mapCategoryId">Category id</param>
      /// 
      ///             Enumerates all user-assignable actions in a specific category
      public IEnumerable<InputAction> UserAssignableActionsInCategory(
        int mapCategoryId)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.AFHjWYUpUsexUFKaiLWdBsAATpBG(mapCategoryId, false);
      }

      /// <summary>
      /// Enumerates all user-assignable actions in a specific category
      /// </summary>
      /// <param name="mapCategoryId">Category id</param>
      /// <param name="sort">Sorts results as shown in Rewired Input Manager</param>
      /// 
      ///             Enumerates all user-assignable actions in a specific category
      public IEnumerable<InputAction> UserAssignableActionsInCategory(
        int mapCategoryId,
        bool sort)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.AFHjWYUpUsexUFKaiLWdBsAATpBG(mapCategoryId, sort);
      }

      /// <summary>
      /// Enumerates all user-assignable actions in a specific category
      /// </summary>
      /// <param name="mapCategoryName">Category name</param>
      /// 
      ///             Enumerates all user-assignable actions in a specific category
      public IEnumerable<InputAction> UserAssignableActionsInCategory(
        string mapCategoryName)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.AFHjWYUpUsexUFKaiLWdBsAATpBG(mapCategoryName, false);
      }

      /// <summary>
      /// Enumerates all user-assignable actions in a specific category
      /// </summary>
      /// <param name="mapCategoryName">Category name</param>
      /// <param name="sort">Sorts results as shown in Rewired Input Manager</param>
      /// 
      ///             Enumerates all user-assignable actions in a specific category
      public IEnumerable<InputAction> UserAssignableActionsInCategory(
        string mapCategoryName,
        bool sort)
      {
        return !ReInput.CheckInitialized() ? (IEnumerable<InputAction>) EmptyObjects<InputAction>.EmptyReadOnlyIListT : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.AFHjWYUpUsexUFKaiLWdBsAATpBG(mapCategoryName, sort);
      }

      /// <summary>Gets a list of input behaviors from a specific player</summary>
      /// <param name="playerId">Player id</param>
      /// <returns>List of input behaviors from the player</returns>
      public IList<InputBehavior> GetInputBehaviors(int playerId) => !ReInput.CheckInitialized() ? EmptyObjects<InputBehavior>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.AvcAsXVUPNGtmUWmaSYhLOlJEmg(playerId);

      /// <summary>Gets a list of input behaviors from the system player</summary>
      /// <returns></returns>
      public IList<InputBehavior> GetSystemPlayerInputBehaviors() => !ReInput.CheckInitialized() ? EmptyObjects<InputBehavior>.EmptyReadOnlyIListT : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.AvcAsXVUPNGtmUWmaSYhLOlJEmg(9999999);

      /// <summary>Gets a specific input behavior from a specific player</summary>
      /// <param name="playerId">Player id</param>
      /// <param name="behaviorId">Input Behavior id</param>
      /// <returns>Input Behavior from the player</returns>
      public InputBehavior GetInputBehavior(int playerId, int behaviorId) => !ReInput.CheckInitialized() ? (InputBehavior) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.BAPmYuGWUnkWELJLpvHbbfqKLBX(playerId, behaviorId);

      /// <summary>Gets a specific input behavior from a specific player</summary>
      /// <param name="playerId">Player id</param>
      /// <param name="behaviorName">Input Behavior name</param>
      /// <returns>Input Behavior from the player</returns>
      public InputBehavior GetInputBehavior(int playerId, string behaviorName) => !ReInput.CheckInitialized() ? (InputBehavior) null : ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.BAPmYuGWUnkWELJLpvHbbfqKLBX(playerId, behaviorName);

      /// <summary>Gets a specific input behavior from the System player</summary>
      /// <param name="behaviorId">Input Behavior id</param>
      /// <returns>Input Behavior from the System player</returns>
      public InputBehavior GetSystemPlayerInputBehavior(int behaviorId) => !ReInput.CheckInitialized() ? (InputBehavior) null : this.GetInputBehavior(9999999, behaviorId);

      /// <summary>Gets a specific input behavior from the System player</summary>
      /// <param name="behaviorName">Input Behavior name</param>
      /// <returns>Input Behavior from the System player</returns>
      public InputBehavior GetSystemPlayerInputBehavior(string behaviorName) => !ReInput.CheckInitialized() ? (InputBehavior) null : this.GetInputBehavior(9999999, behaviorName);

      /// <summary>Gets the id of a specific input behavior</summary>
      /// <param name="behaviorName">Input Behavior name</param>
      /// <returns></returns>
      public int GetInputBehaviorId(string behaviorName) => !ReInput.CheckInitialized() ? -1 : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetInputBehaviorId(behaviorName);

      internal InputBehavior ZVOFUYvIGjAthNJZneacAYffxcB(int _param1) => ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetInputBehaviorById(_param1);

      internal InputBehavior ZVOFUYvIGjAthNJZneacAYffxcB(string _param1) => ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetInputBehavior(_param1);

      /// <summary>
      /// Gets the Controller Map with the specified id from
      /// existing Controller Maps loaded in all Players.
      /// </summary>
      /// <param name="id">The unique id of the Controller Map.</param>
      /// <returns>Controller Map with the specified id.</returns>
      public ControllerMap GetControllerMap(int id)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num1 = 1642886422;
label_2:
        IList<Player> allPlayers;
        ControllerMap map;
        int index;
        while (true)
        {
          switch (num1 ^ 1642886420)
          {
            case 1:
              int num2;
              num1 = num2 = index < allPlayers.Count ? 1642886417 : (num2 = 1642886420);
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = 1642886421;
              continue;
            case 4:
              goto label_1;
            case 5:
              map = allPlayers[index].controllers.maps.GetMap(id);
              if (map == null)
              {
                ++index;
                num1 = 1642886421;
                continue;
              }
              num1 = 1642886419;
              continue;
            case 6:
              index = 0;
              num1 = 1642886423;
              continue;
            case 7:
              goto label_5;
            default:
              goto label_12;
          }
        }
label_3:
        return (ControllerMap) null;
label_5:
        return map;
label_12:
        return (ControllerMap) null;
label_4:
        allPlayers = ReInput.players.AllPlayers;
        num1 = 1642886418;
        goto label_2;
      }

      /// <summary>
      /// Gets the Action Element Map with the specified id from
      /// existing Action Element Maps in all Players.
      /// </summary>
      /// <param name="id">The unique id of the Action Element Map.</param>
      /// <returns>Action Element Map with the specified id.</returns>
      public ActionElementMap GetActionElementMap(int id)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num1 = 826360903;
label_2:
        int index;
        while (true)
        {
          switch (num1 ^ 826360900)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_18;
            case 3:
              goto label_3;
            case 4:
              index = 0;
              num1 = 826360901;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return (ActionElementMap) null;
label_6:
        IList<Player> allPlayers;
        ActionElementMap actionElementMap;
        using (IEnumerator<ControllerMap> enumerator = allPlayers[index].controllers.maps.GetAllMaps().GetEnumerator())
        {
label_13:
          if (enumerator.MoveNext())
          {
label_10:
            ControllerMap current = enumerator.Current;
            if (current != null)
            {
              ActionElementMap elementMap = current.GetElementMap(id);
              int num2 = elementMap == null ? 826360902 : (num2 = 826360896);
              while (true)
              {
                switch (num2 ^ 826360900)
                {
                  case 0:
                    num2 = 826360903;
                    continue;
                  case 1:
                    goto label_20;
                  case 3:
                    goto label_10;
                  case 4:
                    actionElementMap = elementMap;
                    num2 = 826360901;
                    continue;
                  default:
                    goto label_13;
                }
              }
            }
            else
              goto label_13;
          }
        }
        ++index;
        goto label_18;
label_20:
        return actionElementMap;
label_18:
        if (index >= allPlayers.Count)
          return (ActionElementMap) null;
        goto label_6;
label_4:
        allPlayers = ReInput.players.AllPlayers;
        num1 = 826360896;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the default Controller Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="controller">Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstance(
        Controller controller,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -106235555;
label_2:
        ControllerType type;
        while (true)
        {
          switch (num ^ -106235556)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              goto label_13;
            case 3:
              switch (type)
              {
                case ControllerType.Keyboard:
                  goto label_10;
                case ControllerType.Mouse:
                  goto label_11;
                case ControllerType.Joystick:
                  goto label_9;
                case ControllerType.Custom:
                  goto label_12;
                default:
                  num = -106235554;
                  continue;
              }
            default:
              goto label_9;
          }
        }
label_3:
        return (ControllerMap) null;
label_9:
        return (ControllerMap) this.GetJoystickMapInstance((Joystick) controller, mapCategoryId, layoutId);
label_10:
        return (ControllerMap) this.GetKeyboardMapInstance(mapCategoryId, layoutId);
label_11:
        return (ControllerMap) this.GetMouseMapInstance(mapCategoryId, layoutId);
label_12:
        return (ControllerMap) this.GetCustomControllerMapInstance((CustomController) controller, mapCategoryId, layoutId);
label_13:
        throw new NotImplementedException();
label_4:
        if (controller == null)
          return (ControllerMap) null;
        type = controller.type;
        num = -106235553;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the default Controller Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="controller">Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstance(
        Controller controller,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1248060631;
label_2:
        int mapCategoryId;
        int layoutId;
        while (true)
        {
          switch (num ^ 1248060629)
          {
            case 0:
              goto label_1;
            case 2:
              goto label_3;
            case 3:
              goto label_6;
            case 4:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(controller.type, layoutName);
                num = 1248060624;
                continue;
              }
              goto label_9;
            case 5:
              if (layoutId < 0)
              {
                num = 1248060628;
                continue;
              }
              goto label_14;
            default:
              goto label_13;
          }
        }
label_3:
        return (ControllerMap) null;
label_6:
        return (ControllerMap) null;
label_9:
        return (ControllerMap) null;
label_13:
        return (ControllerMap) null;
label_14:
        return this.GetControllerMapInstance(controller, mapCategoryId, layoutId);
label_4:
        if (controller == null)
        {
          num = 1248060630;
          goto label_2;
        }
        else
        {
          mapCategoryId = this.GetMapCategoryId(mapCategoryName);
          num = 1248060625;
          goto label_2;
        }
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the default Controller Map setup in the Rewired Input Manager.
      /// This overload can be used when no Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstance(
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1213843555;
label_2:
        int mapCategoryId;
        while (true)
        {
          switch (num ^ -1213843553)
          {
            case 0:
              goto label_1;
            case 1:
              if (mapCategoryId < 0)
              {
                num = -1213843556;
                continue;
              }
              goto label_8;
            case 2:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_3:
        return (ControllerMap) null;
label_7:
        return (ControllerMap) null;
label_8:
        int layoutId = this.GetLayoutId(controllerIdentifier.controllerType, layoutName);
        return layoutId < 0 ? (ControllerMap) null : this.GetControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId);
label_4:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        num = -1213843554;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the default Controller Map setup in the Rewired Input Manager.
      /// This overload can be used when no Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstance(
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_6;
label_1:
        int num = 300709917;
label_2:
        ControllerType controllerType;
        Controller controller;
        while (true)
        {
          switch (num ^ 300709914)
          {
            case 0:
              goto label_1;
            case 1:
              switch (controllerType)
              {
                case ControllerType.Keyboard:
                  goto label_15;
                case ControllerType.Mouse:
                  goto label_16;
                case ControllerType.Joystick:
                  goto label_13;
                default:
                  num = 300709912;
                  continue;
              }
            case 2:
              if (controllerType != ControllerType.Custom)
              {
                num = 300709919;
                continue;
              }
              goto label_14;
            case 3:
              if (controller == null)
              {
                controllerType = controllerIdentifier.controllerType;
                num = 300709915;
                continue;
              }
              num = 300709918;
              continue;
            case 4:
              goto label_7;
            case 5:
              goto label_17;
            case 7:
              goto label_5;
            default:
              goto label_13;
          }
        }
label_5:
        return (ControllerMap) null;
label_7:
        return this.GetControllerMapInstance(controller, mapCategoryId, layoutId);
label_13:
        return (ControllerMap) this.GetJoystickMapInstance(controllerIdentifier, mapCategoryId, layoutId);
label_14:
        return (ControllerMap) this.GetCustomControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId);
label_15:
        return (ControllerMap) this.GetKeyboardMapInstance(mapCategoryId, layoutId);
label_16:
        return (ControllerMap) this.GetMouseMapInstance(mapCategoryId, layoutId);
label_17:
        throw new NotImplementedException();
label_6:
        controller = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier);
        num = 300709913;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Joystick Map.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="joystick">Joystick for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        Joystick joystick,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1208581845;
label_2:
        JoystickMap joystickMap;
        while (true)
        {
          switch (num ^ 1208581844)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              if (joystickMap != null)
              {
                ((Controller) joystick).IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) joystickMap);
                num = 1208581847;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_3:
        return (JoystickMap) null;
label_9:
        return joystickMap;
label_4:
        if (joystick == null)
          return (JoystickMap) null;
        joystickMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.hllDyZsVgAhjnGBkWhOtFmBhhsL(joystick, mapCategoryId, layoutId);
        num = 1208581846;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Joystick Map.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="joystick">Joystick for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        Joystick joystick,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -59083687;
label_2:
        int mapCategoryId;
        int layoutId;
        switch (num ^ -59083688)
        {
          case 1:
            return (JoystickMap) null;
          case 2:
            return (JoystickMap) null;
          case 3:
            goto label_1;
          default:
            return layoutId < 0 ? (JoystickMap) null : this.GetJoystickMapInstance(joystick, mapCategoryId, layoutId);
        }
label_4:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
        {
          num = -59083686;
          goto label_2;
        }
        else
        {
          layoutId = this.GetLayoutId(ControllerType.Joystick, layoutName);
          num = -59083688;
          goto label_2;
        }
      }

      /// <summary>
      /// Gets a copy of a joystick map from the default controller maps.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="joystickTypeGuid">Joystick GUID for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        Guid joystickTypeGuid,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_11;
label_1:
        int num1 = 100615217;
label_2:
        JoystickMap joystickMap;
        HardwareJoystickMap_InputManager joystickMapInputManager;
        HardwareControllerMap_Game hardwareControllerMap;
        InputSource inputSourceType;
        while (true)
        {
          switch (num1 ^ 100615216)
          {
            case 0:
              goto label_13;
            case 1:
              goto label_10;
            case 2:
              if (joystickMapInputManager == null)
              {
                num1 = 100615224;
                continue;
              }
              joystickMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.IzDVCCfUAGFzkdUwbMUhkaRUrVm(joystickMapInputManager.hardwareMapIdentifier, mapCategoryId, layoutId);
              if (joystickMap != null)
              {
                num1 = 100615220;
                continue;
              }
              goto label_25;
            case 3:
              goto label_7;
            case 4:
              joystickMap.controllerType = ControllerType.Joystick;
              hardwareControllerMap = joystickMapInputManager.ToGameHardwareControllerMap();
              num1 = 100615221;
              continue;
            case 6:
              goto label_1;
            case 7:
              joystickMapInputManager = ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.RJHtxCgXvrIVPvKoTNMJHfHvDDoc(joystickTypeGuid, inputSourceType);
              num1 = 100615218;
              continue;
            case 8:
              Logger.LogError((object) "No hardware map found.");
              num1 = 100615216;
              continue;
            default:
              goto label_16;
          }
        }
label_7:
        return (JoystickMap) null;
label_10:
        return (JoystickMap) null;
label_13:
        return (JoystickMap) null;
label_16:
        using (IEnumerator<ActionElementMap> enumerator = joystickMap.AllMaps.GetEnumerator())
        {
label_21:
          while (enumerator.MoveNext())
          {
label_20:
            enumerator.Current.imxUKNTInpmtYXCxVISbIKTPDMu((ControllerMap) joystickMap, hardwareControllerMap);
            int num2 = 100615217;
            while (true)
            {
              switch (num2 ^ 100615216)
              {
                case 0:
                  num2 = 100615218;
                  continue;
                case 2:
                  goto label_20;
                default:
                  goto label_21;
              }
            }
          }
        }
label_25:
        return joystickMap;
label_11:
        if (!(joystickTypeGuid == Guid.Empty))
        {
          inputSourceType = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.inputSourceType;
          num1 = 100615223;
          goto label_2;
        }
        else
        {
          num1 = 100615219;
          goto label_2;
        }
      }

      /// <summary>
      /// Gets a copy of a joystick map from the default controller maps.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="joystickTypeGuid">Joystick GUID for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        Guid joystickTypeGuid,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (JoystickMap) null;
        if (joystickTypeGuid == Guid.Empty)
          return (JoystickMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_5:
        int num = 1422466600;
        int layoutId;
        while (true)
        {
          switch (num ^ 1422466601)
          {
            case 0:
              if (layoutId < 0)
              {
                num = 1422466602;
                continue;
              }
              goto label_13;
            case 1:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Joystick, layoutName);
                num = 1422466601;
                continue;
              }
              goto label_8;
            case 2:
              goto label_5;
            default:
              goto label_12;
          }
        }
label_8:
        return (JoystickMap) null;
label_12:
        return (JoystickMap) null;
label_13:
        return this.GetJoystickMapInstance(joystickTypeGuid, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a joystick map from the default controller maps.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (!ReInput.CheckInitialized())
          return (JoystickMap) null;
        if (controllerIdentifier.controllerType == ControllerType.Joystick)
          goto label_6;
label_3:
        int num = 820731384;
label_4:
        switch (num ^ 820731385)
        {
          case 0:
            goto label_3;
          case 1:
            return (JoystickMap) null;
          default:
            return this.GetJoystickMapInstance(joystick, mapCategoryId, layoutId);
        }
label_6:
        if (!(ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier) is Joystick joystick))
          return this.GetJoystickMapInstance(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
        num = 820731387;
        goto label_4;
      }

      /// <summary>
      /// Gets a copy of a joystick map from the default controller maps.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default Joystick Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstance(
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (JoystickMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_3:
        int num = 1221953300;
        while (true)
        {
          switch (num ^ 1221953301)
          {
            case 1:
              if (mapCategoryId < 0)
              {
                num = 1221953301;
                continue;
              }
              goto label_8;
            case 2:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return (JoystickMap) null;
label_8:
        int layoutId = this.GetLayoutId(ControllerType.Joystick, layoutName);
        return layoutId < 0 ? (JoystickMap) null : this.GetJoystickMapInstance(controllerIdentifier, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Keyboard Map.
      /// This can be used to view the default Keyboard Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Keyboard Map</returns>
      public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId)
      {
        if (!ReInput.CheckInitialized())
          return (KeyboardMap) null;
        KeyboardMap keyboardMapGame = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.FindKeyboardMap_Game(mapCategoryId, layoutId);
        if (keyboardMapGame != null)
          ((Controller) ReInput.controllers.Keyboard).IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) keyboardMapGame);
        return keyboardMapGame;
      }

      /// <summary>
      /// Gets a copy of a Keyboard Map.
      /// This can be used to view the default Keyboard Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Keyboard Map</returns>
      public KeyboardMap GetKeyboardMapInstance(
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (KeyboardMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_3:
        int num = -723837211;
        int layoutId;
        while (true)
        {
          switch (num ^ -723837212)
          {
            case 0:
              goto label_3;
            case 1:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Keyboard, layoutName);
                num = -723837210;
                continue;
              }
              goto label_6;
            default:
              goto label_8;
          }
        }
label_6:
        return (KeyboardMap) null;
label_8:
        return layoutId < 0 ? (KeyboardMap) null : this.GetKeyboardMapInstance(mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Mouse Map.
      /// This can be used to view the default Mouse Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Mouse Map</returns>
      public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_6;
label_1:
        int num1 = 1003279612;
label_2:
        MouseMap mouseMapGame;
        while (true)
        {
          switch (num1 ^ 1003279615)
          {
            case 0:
              int num2;
              num1 = num2 = mouseMapGame == null ? 1003279611 : (num2 = 1003279614);
              continue;
            case 1:
              ((Controller) ReInput.controllers.Mouse).IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) mouseMapGame);
              num1 = 1003279611;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_5:
        return (MouseMap) null;
label_7:
        return mouseMapGame;
label_6:
        mouseMapGame = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.FindMouseMap_Game(mapCategoryId, layoutId);
        num1 = 1003279615;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Mouse Map.
      /// This can be used to view the default Mouse Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Mouse Map</returns>
      public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (MouseMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_3:
        int num = -1678690769;
        int layoutId;
        while (true)
        {
          switch (num ^ -1678690772)
          {
            case 0:
              goto label_3;
            case 2:
              if (layoutId < 0)
              {
                num = -1678690771;
                continue;
              }
              goto label_11;
            case 3:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Mouse, layoutName);
                num = -1678690770;
                continue;
              }
              goto label_6;
            default:
              goto label_10;
          }
        }
label_6:
        return (MouseMap) null;
label_10:
        return (MouseMap) null;
label_11:
        return this.GetMouseMapInstance(mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Custom Controller Map.
      /// This can be used to view the default Custom Controller Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="customController">Custom Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstance(
        CustomController customController,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1532058891;
label_2:
        CustomControllerMap customControllerMap;
        while (true)
        {
          switch (num ^ 1532058890)
          {
            case 0:
              ((Controller) customController).IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) customControllerMap);
              num = 1532058889;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_3:
        return (CustomControllerMap) null;
label_6:
        return customControllerMap;
label_4:
        customControllerMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.SnyDgXhMtXnTLgAbfNkPcbzbVjUt(customController.sourceControllerId, mapCategoryId, layoutId);
        num = customControllerMap == null ? 1532058889 : (num = 1532058890);
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Custom Controller Map.
      /// This can be used to view the default Custom Controller Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="customController">Custom Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstance(
        CustomController customController,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1934255791;
label_2:
        int layoutId;
        while (true)
        {
          switch (num ^ 1934255787)
          {
            case 0:
              goto label_1;
            case 2:
              goto label_6;
            case 3:
              if (layoutId < 0)
              {
                num = 1934255786;
                continue;
              }
              goto label_11;
            case 4:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_3:
        return (CustomControllerMap) null;
label_6:
        return (CustomControllerMap) null;
label_10:
        return (CustomControllerMap) null;
label_11:
        int mapCategoryId;
        return this.GetCustomControllerMapInstance(customController, mapCategoryId, layoutId);
label_4:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
        {
          num = 1934255785;
          goto label_2;
        }
        else
        {
          layoutId = this.GetLayoutId(ControllerType.Custom, layoutName);
          num = 1934255784;
          goto label_2;
        }
      }

      /// <summary>
      /// Gets a copy of a custom controller map from the default controller maps.
      /// This overload can be used when no Custom Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default CustomController Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstance(
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (!ReInput.CheckInitialized())
          return (CustomControllerMap) null;
        if (controllerIdentifier.controllerType != ControllerType.Custom)
          return (CustomControllerMap) null;
        if (!(ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier) is CustomController customController))
          goto label_8;
label_5:
        int num1 = 1189156755;
label_6:
        CustomControllerMap customControllerMap;
        CustomController_Editor hardwareTypeGuid;
        HardwareControllerMap_Game controllerMapGame;
        while (true)
        {
          switch (num1 ^ 1189156754)
          {
            case 0:
              if (customControllerMap != null)
              {
                controllerMapGame = hardwareTypeGuid.YChaIsPdMrjKbfvWjnubNSauQQzX();
                if (controllerMapGame == null)
                {
                  num1 = 1189156752;
                  continue;
                }
                customControllerMap.controllerType = ControllerType.Custom;
                num1 = 1189156753;
                continue;
              }
              goto label_30;
            case 1:
              goto label_7;
            case 2:
              Logger.LogError((object) "No hardware map found.");
              num1 = 1189156758;
              continue;
            case 4:
              goto label_16;
            case 5:
              goto label_5;
            case 6:
              goto label_13;
            case 7:
              if (hardwareTypeGuid != null)
              {
                customControllerMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.SnyDgXhMtXnTLgAbfNkPcbzbVjUt(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
                num1 = 1189156754;
                continue;
              }
              goto label_19;
            default:
              goto label_21;
          }
        }
label_7:
        return this.GetCustomControllerMapInstance(customController, mapCategoryId, layoutId);
label_13:
        return (CustomControllerMap) null;
label_16:
        return (CustomControllerMap) null;
label_19:
        return (CustomControllerMap) null;
label_21:
        using (IEnumerator<ActionElementMap> enumerator = customControllerMap.AllMaps.GetEnumerator())
        {
label_26:
          while (enumerator.MoveNext())
          {
label_25:
            enumerator.Current.imxUKNTInpmtYXCxVISbIKTPDMu((ControllerMap) customControllerMap, controllerMapGame);
            int num2 = 1189156752;
            while (true)
            {
              switch (num2 ^ 1189156754)
              {
                case 0:
                  num2 = 1189156755;
                  continue;
                case 1:
                  goto label_25;
                default:
                  goto label_26;
              }
            }
          }
        }
label_30:
        return customControllerMap;
label_8:
        if (controllerIdentifier.hardwareTypeGuid == Guid.Empty)
        {
          num1 = 1189156756;
          goto label_6;
        }
        else
        {
          hardwareTypeGuid = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerByHardwareTypeGuid(controllerIdentifier.hardwareTypeGuid);
          num1 = 1189156757;
          goto label_6;
        }
      }

      /// <summary>
      /// Gets a copy of a custom controller map from the default controller maps.
      /// This overload can be used when no Custom Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the default CustomController Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// This method can only be used to load Controller Maps for recognized Controllers. Unrecognized Controllers are not supported.
      /// </summary>
      /// <param name="controllerIdentifier">Controller for which to retrieve the map.</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstance(
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_8;
label_1:
        int num = 328356879;
label_2:
        int layoutId;
        int mapCategoryId;
        while (true)
        {
          switch (num ^ 328356875)
          {
            case 0:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Custom, layoutName);
                num = 328356874;
                continue;
              }
              num = 328356875;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_3:
        return (CustomControllerMap) null;
label_7:
        return (CustomControllerMap) null;
label_9:
        return layoutId < 0 ? (CustomControllerMap) null : this.GetCustomControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId);
label_8:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        num = 328356872;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controller">Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstanceSavedOrDefault(
        int playerId,
        Controller controller,
        int mapCategoryId,
        int layoutId)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerMap) null;
        if (controller != null)
          goto label_10;
label_3:
        int num1 = -1677016855;
label_4:
        ControllerMap controllerMap;
        Player player;
        while (true)
        {
          switch (num1 ^ -1677016853)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_7;
            case 2:
              goto label_9;
            case 3:
              int num2;
              num1 = num2 = player != null ? -1677016851 : (num2 = -1677016850);
              continue;
            case 4:
              num1 = -1677016861;
              continue;
            case 5:
              controller.IWlegfCdJKyzVFAKpjUlDCHVffD(controllerMap);
              num1 = -1677016861;
              continue;
            case 6:
              player.controllers.maps.IWlegfCdJKyzVFAKpjUlDCHVffD(controller, controllerMap);
              num1 = -1677016849;
              continue;
            case 7:
              player = ReInput.players.GetPlayer(playerId);
              num1 = -1677016856;
              continue;
            case 9:
              goto label_3;
            default:
              goto label_16;
          }
        }
label_9:
        return (ControllerMap) null;
label_16:
        return controllerMap;
label_6:
        num1 = controllerMap == null ? -1677016861 : (num1 = -1677016852);
        goto label_4;
label_7:
        if (controllerMap == null)
        {
          controllerMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.YTylnYvxUPieQwVdoYLHSSwJHuP(controller, mapCategoryId, layoutId);
          num1 = -1677016853;
          goto label_4;
        }
        else
          goto label_6;
label_10:
        controllerMap = (ControllerMap) null;
        if (ReInput.userDataStore is IControllerMapStore userDataStore)
        {
          controllerMap = userDataStore.LoadControllerMap(playerId, controller.identifier, mapCategoryId, layoutId);
          num1 = -1677016854;
          goto label_4;
        }
        else
          goto label_7;
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controller">Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstanceSavedOrDefault(
        int playerId,
        Controller controller,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerMap) null;
        if (controller != null)
          goto label_6;
label_3:
        int num = -493433338;
label_4:
        int mapCategoryId;
        int layoutId;
        switch (num ^ -493433337)
        {
          case 1:
            return (ControllerMap) null;
          case 2:
            return (ControllerMap) null;
          case 3:
            goto label_3;
          default:
            return layoutId < 0 ? (ControllerMap) null : this.GetControllerMapInstanceSavedOrDefault(playerId, controller, mapCategoryId, layoutId);
        }
label_6:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
        {
          num = -493433339;
          goto label_4;
        }
        else
        {
          layoutId = this.GetLayoutId(controller.type, layoutName);
          num = -493433337;
          goto label_4;
        }
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// This overload can be used when no Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controllerIdentifier">The Controller Idenfitier that defines the Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1494503915;
label_2:
        switch (num ^ -1494503916)
        {
          case 0:
            throw new NotImplementedException();
          case 1:
            return (ControllerMap) null;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
label_4:
        switch (controllerIdentifier.controllerType)
        {
          case ControllerType.Keyboard:
            return (ControllerMap) this.GetKeyboardMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
          case ControllerType.Mouse:
            return (ControllerMap) this.GetMouseMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
          case ControllerType.Joystick:
            break;
          case ControllerType.Custom:
            return (ControllerMap) this.GetCustomControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
          default:
            num = -1494503916;
            goto label_2;
        }
label_6:
        return (ControllerMap) this.GetJoystickMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// This overload can be used when no Controller is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controllerIdentifier">The Controller Idenfitier that defines the Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Controller Map</returns>
      public ControllerMap GetControllerMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId >= 0)
          goto label_6;
label_3:
        int num = -1883278413;
label_4:
        int layoutId;
        switch (num ^ -1883278415)
        {
          case 0:
            goto label_3;
          case 2:
            return (ControllerMap) null;
          default:
            return layoutId < 0 ? (ControllerMap) null : this.GetControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
        }
label_6:
        layoutId = this.GetLayoutId(controllerIdentifier.controllerType, layoutName);
        num = -1883278416;
        goto label_4;
      }

      /// <summary>
      /// Gets a copy of a Joystick Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="joystick">Joystick for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstanceSavedOrDefault(
        int playerId,
        Joystick joystick,
        int mapCategoryId,
        int layoutId)
      {
        return !ReInput.CheckInitialized() ? (JoystickMap) null : this.GetControllerMapInstanceSavedOrDefault(playerId, (Controller) joystick, mapCategoryId, layoutId) as JoystickMap;
      }

      /// <summary>
      /// Gets a copy of a Joystick Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="joystick">Joystick for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstanceSavedOrDefault(
        int playerId,
        Joystick joystick,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -700360060;
label_2:
        int mapCategoryId;
        int layoutId;
        while (true)
        {
          switch (num ^ -700360059)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Joystick, layoutName);
                num = -700360064;
                continue;
              }
              num = -700360058;
              continue;
            case 3:
              goto label_7;
            case 5:
              if (layoutId < 0)
              {
                num = -700360063;
                continue;
              }
              goto label_12;
            default:
              goto label_11;
          }
        }
label_3:
        return (JoystickMap) null;
label_7:
        return (JoystickMap) null;
label_11:
        return (JoystickMap) null;
label_12:
        return this.GetJoystickMapInstanceSavedOrDefault(playerId, joystick, mapCategoryId, layoutId);
label_4:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        num = -700360057;
        goto label_2;
      }

      /// <summary>
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controllerIdentifier">The Controller Idenfitier that defines the Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_10;
label_1:
        int num1 = -1881335170;
label_2:
        JoystickMap joystickMap;
        Joystick joystick;
        InputSource inputSourceType;
        IControllerMapStore userDataStore;
        HardwareJoystickMap_InputManager joystickMapInputManager;
        HardwareControllerMap_Game hardwareControllerMap;
        while (true)
        {
          switch (num1 ^ -1881335177)
          {
            case 0:
              joystickMapInputManager = ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.RJHtxCgXvrIVPvKoTNMJHfHvDDoc(controllerIdentifier.hardwareTypeGuid, inputSourceType);
              num1 = -1881335178;
              continue;
            case 1:
              if (joystickMapInputManager == null)
              {
                num1 = -1881335184;
                continue;
              }
              joystickMap = (JoystickMap) null;
              num1 = -1881335173;
              continue;
            case 2:
              joystickMap.playerId = playerId;
              num1 = -1881335172;
              continue;
            case 3:
              if (joystick == null)
              {
                inputSourceType = ReInput.lxIwNHlLLhCTcLKwfECUdRyoQRqn.inputSourceType;
                num1 = -1881335177;
                continue;
              }
              goto label_5;
            case 4:
              if (joystickMap == null)
              {
                joystickMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.IzDVCCfUAGFzkdUwbMUhkaRUrVm(joystickMapInputManager.hardwareMapIdentifier, mapCategoryId, layoutId);
                num1 = -1881335174;
                continue;
              }
              goto case 13;
            case 6:
              goto label_15;
            case 7:
              Logger.LogError((object) "No hardware map found.");
              num1 = -1881335183;
              continue;
            case 8:
              goto label_1;
            case 9:
              goto label_9;
            case 10:
              if (userDataStore != null)
              {
                joystickMap = userDataStore.LoadControllerMap(playerId, controllerIdentifier, mapCategoryId, layoutId) as JoystickMap;
                num1 = -1881335181;
                continue;
              }
              goto case 4;
            case 11:
              hardwareControllerMap = joystickMapInputManager.ToGameHardwareControllerMap();
              num1 = -1881335182;
              continue;
            case 12:
              userDataStore = ReInput.userDataStore as IControllerMapStore;
              num1 = -1881335171;
              continue;
            case 13:
              if (joystickMap != null)
              {
                joystickMap.controllerType = ControllerType.Joystick;
                int num2;
                num1 = num2 = ReInput.players.GetPlayer(playerId) == null ? -1881335172 : (num2 = -1881335179);
                continue;
              }
              goto label_34;
            default:
              goto label_23;
          }
        }
label_5:
        return this.GetJoystickMapInstanceSavedOrDefault(playerId, joystick, mapCategoryId, layoutId);
label_9:
        return (JoystickMap) null;
label_15:
        return (JoystickMap) null;
label_23:
        IEnumerator<ActionElementMap> enumerator = joystickMap.AllMaps.GetEnumerator();
        try
        {
label_28:
          int num2 = !enumerator.MoveNext() ? -1881335179 : (num2 = -1881335180);
          while (true)
          {
            switch (num2 ^ -1881335177)
            {
              case 0:
                num2 = -1881335180;
                continue;
              case 1:
                goto label_28;
              case 3:
                enumerator.Current.imxUKNTInpmtYXCxVISbIKTPDMu((ControllerMap) joystickMap, hardwareControllerMap);
                num2 = -1881335178;
                continue;
              default:
                goto label_34;
            }
          }
        }
        finally
        {
          if (enumerator != null)
          {
label_30:
            int num2 = -1881335179;
            while (true)
            {
              switch (num2 ^ -1881335177)
              {
                case 0:
                  goto label_30;
                case 2:
                  enumerator.Dispose();
                  num2 = -1881335178;
                  continue;
                default:
                  goto label_33;
              }
            }
          }
label_33:;
        }
label_34:
        return joystickMap;
label_10:
        joystick = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier) as Joystick;
        num1 = -1881335180;
        goto label_2;
      }

      /// <summary>
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// This overload can be used when no Joystick is actually connected and available to be used to look up the correct Controller Maps to load.
      /// The Controller Map returned by this method is not guarateed to be consistent with the Controller Map that would be loaded
      /// were the actual device to be connected. This is due to the fact that different Controller Maps may be loaded depending on the
      /// actual device connected, properties returned by this device, the current input source(s) in use, and more factors.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// NOTE: Element indices in ActionElementMaps may not match to to a Controller Map created with the actual controller connected.
      /// Do not rely on ActionElementMap.elementIndex being accurate in Controller Maps returned by this method.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="controllerIdentifier">The Controller Idenfitier that defines the Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Joystick Map</returns>
      public JoystickMap GetJoystickMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1003891607;
label_2:
        int mapCategoryId;
        int layoutId;
        while (true)
        {
          switch (num ^ -1003891608)
          {
            case 0:
              if (mapCategoryId >= 0)
              {
                layoutId = this.GetLayoutId(ControllerType.Joystick, layoutName);
                num = -1003891604;
                continue;
              }
              goto label_6;
            case 1:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              if (layoutId < 0)
              {
                num = -1003891606;
                continue;
              }
              goto label_11;
            default:
              goto label_10;
          }
        }
label_3:
        return (JoystickMap) null;
label_6:
        return (JoystickMap) null;
label_10:
        return (JoystickMap) null;
label_11:
        return this.GetJoystickMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
label_4:
        mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        num = -1003891608;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Custom Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="customController">Custom Controller for which to retrieve the map</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(
        int playerId,
        CustomController customController,
        int mapCategoryId,
        int layoutId)
      {
        return this.GetControllerMapInstanceSavedOrDefault(playerId, (Controller) customController, mapCategoryId, layoutId) as CustomControllerMap;
      }

      /// <summary>
      /// Gets a copy of a Custom Controller Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="customController">Custom Controller for which to retrieve the map</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>CustomController Map</returns>
      public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(
        int playerId,
        CustomController customController,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (CustomControllerMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_3:
        int num = -904968126;
        int layoutId;
        while (true)
        {
          switch (num ^ -904968125)
          {
            case 0:
              goto label_7;
            case 1:
              if (mapCategoryId < 0)
              {
                num = -904968125;
                continue;
              }
              layoutId = this.GetLayoutId(ControllerType.Custom, layoutName);
              if (layoutId < 0)
              {
                num = -904968128;
                continue;
              }
              goto label_11;
            case 2:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_7:
        return (CustomControllerMap) null;
label_10:
        return (CustomControllerMap) null;
label_11:
        return this.GetCustomControllerMapInstanceSavedOrDefault(playerId, customController, mapCategoryId, layoutId);
      }

      public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_13;
label_1:
        int num1 = 1846396555;
label_2:
        CustomController_Editor hardwareTypeGuid;
        CustomControllerMap customControllerMap;
        HardwareControllerMap_Game controllerMapGame;
        CustomController customController;
        IControllerMapStore userDataStore;
        while (true)
        {
          switch (num1 ^ 1846396546)
          {
            case 0:
              goto label_19;
            case 1:
              goto label_5;
            case 2:
              if (customControllerMap != null)
              {
                num1 = 1846396545;
                continue;
              }
              goto label_34;
            case 3:
              controllerMapGame = hardwareTypeGuid.YChaIsPdMrjKbfvWjnubNSauQQzX();
              if (controllerMapGame != null)
              {
                customControllerMap.controllerType = ControllerType.Custom;
                if (ReInput.players.GetPlayer(playerId) != null)
                {
                  customControllerMap.playerId = playerId;
                  num1 = 1846396548;
                  continue;
                }
                goto label_24;
              }
              else
              {
                Logger.LogError((object) "No hardware map found.");
                num1 = 1846396547;
                continue;
              }
            case 4:
              goto label_1;
            case 5:
              if (customController == null)
              {
                hardwareTypeGuid = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetCustomControllerByHardwareTypeGuid(controllerIdentifier.hardwareTypeGuid);
                num1 = 1846396552;
                continue;
              }
              goto label_22;
            case 7:
              userDataStore = ReInput.userDataStore as IControllerMapStore;
              num1 = 1846396553;
              continue;
            case 8:
              if (customControllerMap == null)
              {
                customControllerMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.SnyDgXhMtXnTLgAbfNkPcbzbVjUt(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
                num1 = 1846396544;
                continue;
              }
              goto case 2;
            case 9:
              goto label_12;
            case 10:
              if (hardwareTypeGuid == null)
              {
                num1 = 1846396546;
                continue;
              }
              customControllerMap = (CustomControllerMap) null;
              num1 = 1846396549;
              continue;
            case 11:
              if (userDataStore != null)
              {
                customControllerMap = userDataStore.LoadControllerMap(playerId, controllerIdentifier, mapCategoryId, layoutId) as CustomControllerMap;
                num1 = 1846396554;
                continue;
              }
              goto case 8;
            default:
              goto label_24;
          }
        }
label_5:
        return (CustomControllerMap) null;
label_12:
        return (CustomControllerMap) null;
label_19:
        return (CustomControllerMap) null;
label_22:
        return this.GetCustomControllerMapInstanceSavedOrDefault(playerId, customController, mapCategoryId, layoutId);
label_24:
        using (IEnumerator<ActionElementMap> enumerator = customControllerMap.AllMaps.GetEnumerator())
        {
label_28:
          int num2 = !enumerator.MoveNext() ? 1846396547 : (num2 = 1846396545);
          ActionElementMap current;
          while (true)
          {
            switch (num2 ^ 1846396546)
            {
              case 0:
                current.imxUKNTInpmtYXCxVISbIKTPDMu((ControllerMap) customControllerMap, controllerMapGame);
                num2 = 1846396550;
                continue;
              case 2:
                num2 = 1846396545;
                continue;
              case 3:
                current = enumerator.Current;
                num2 = 1846396546;
                continue;
              case 4:
                goto label_28;
              default:
                goto label_34;
            }
          }
        }
label_34:
        return customControllerMap;
label_13:
        customController = ReInput.ssVepcdhcQDCSmMguyiEkGPQzcFn.nFZdXeBJaPXBfrqfgbOcmjwrMOVl(controllerIdentifier) as CustomController;
        num1 = 1846396551;
        goto label_2;
      }

      public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(
        int playerId,
        ControllerIdentifier controllerIdentifier,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (CustomControllerMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
          return (CustomControllerMap) null;
        int layoutId = this.GetLayoutId(ControllerType.Custom, layoutName);
label_5:
        int num = 1941362225;
        while (true)
        {
          switch (num ^ 1941362224)
          {
            case 1:
              if (layoutId < 0)
              {
                num = 1941362224;
                continue;
              }
              goto label_10;
            case 2:
              goto label_5;
            default:
              goto label_9;
          }
        }
label_9:
        return (CustomControllerMap) null;
label_10:
        return this.GetCustomControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Keyboard Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Keyboard Map</returns>
      public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(
        int playerId,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_7;
label_1:
        int num1 = -892398313;
label_2:
        Player player;
        Controller keyboard;
        KeyboardMap keyboardMap;
        IControllerMapStore userDataStore;
        while (true)
        {
          switch (num1 ^ -892398315)
          {
            case 1:
              player = ReInput.players.GetPlayer(playerId);
              int num2;
              num1 = num2 = player == null ? -892398314 : (num2 = -892398307);
              continue;
            case 2:
              goto label_6;
            case 3:
              keyboard.IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) keyboardMap);
              num1 = -892398315;
              continue;
            case 4:
              keyboardMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.FindKeyboardMap_Game(mapCategoryId, layoutId);
              num1 = -892398320;
              continue;
            case 5:
              int num3;
              num1 = num3 = keyboardMap == null ? -892398315 : (num3 = -892398316);
              continue;
            case 6:
              if (userDataStore != null)
              {
                keyboardMap = userDataStore.LoadControllerMap(playerId, keyboard.identifier, mapCategoryId, layoutId) as KeyboardMap;
                num1 = -892398308;
                continue;
              }
              goto case 9;
            case 7:
              goto label_1;
            case 8:
              player.controllers.maps.IWlegfCdJKyzVFAKpjUlDCHVffD(keyboard, (ControllerMap) keyboardMap);
              num1 = -892398305;
              continue;
            case 9:
              int num4;
              num1 = num4 = keyboardMap == null ? -892398319 : (num4 = -892398320);
              continue;
            case 10:
              num1 = -892398315;
              continue;
            default:
              goto label_14;
          }
        }
label_6:
        return (KeyboardMap) null;
label_14:
        return keyboardMap;
label_7:
        keyboard = (Controller) ReInput.controllers.Keyboard;
        keyboardMap = (KeyboardMap) null;
        userDataStore = ReInput.userDataStore as IControllerMapStore;
        num1 = -892398317;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Keyboard Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Keyboard Map</returns>
      public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(
        int playerId,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (KeyboardMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
          return (KeyboardMap) null;
        int layoutId = this.GetLayoutId(ControllerType.Keyboard, layoutName);
        return layoutId < 0 ? (KeyboardMap) null : this.GetKeyboardMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Mouse Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Mouse Map</returns>
      public MouseMap GetMouseMapInstanceSavedOrDefault(
        int playerId,
        int mapCategoryId,
        int layoutId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num1 = 512350024;
label_2:
        Controller mouse;
        IControllerMapStore userDataStore;
        Player player;
        MouseMap mouseMap;
        while (true)
        {
          switch (num1 ^ 512350029)
          {
            case 0:
              goto label_1;
            case 1:
              mouseMap = userDataStore.LoadControllerMap(playerId, mouse.identifier, mapCategoryId, layoutId) as MouseMap;
              num1 = 512350020;
              continue;
            case 2:
              int num2;
              num1 = num2 = userDataStore == null ? 512350020 : (num2 = 512350028);
              continue;
            case 3:
              mouseMap = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.FindMouseMap_Game(mapCategoryId, layoutId);
              num1 = 512350025;
              continue;
            case 4:
              int num3;
              num1 = num3 = mouseMap != null ? 512350017 : (num3 = 512350022);
              continue;
            case 5:
              goto label_3;
            case 6:
              mouseMap = (MouseMap) null;
              userDataStore = ReInput.userDataStore as IControllerMapStore;
              num1 = 512350031;
              continue;
            case 7:
              player.controllers.maps.IWlegfCdJKyzVFAKpjUlDCHVffD(mouse, (ControllerMap) mouseMap);
              num1 = 512350021;
              continue;
            case 8:
              num1 = 512350022;
              continue;
            case 9:
              int num4;
              num1 = num4 = mouseMap != null ? 512350025 : (num4 = 512350030);
              continue;
            case 10:
              mouse.IWlegfCdJKyzVFAKpjUlDCHVffD((ControllerMap) mouseMap);
              num1 = 512350022;
              continue;
            case 12:
              player = ReInput.players.GetPlayer(playerId);
              int num5;
              num1 = num5 = player != null ? 512350026 : (num5 = 512350023);
              continue;
            default:
              goto label_15;
          }
        }
label_3:
        return (MouseMap) null;
label_15:
        return mouseMap;
label_4:
        mouse = (Controller) ReInput.controllers.Mouse;
        num1 = 512350027;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of a Mouse Map.
      /// This can be used to view the Controller Map saved in user data if available or the default Controller Map setup in the Rewired Input Manager.
      /// The Controller Map will be first loaded from <see cref="T:Rewired.Data.UserDataStore" />. If none is found, it will be loaded from the Rewired Input Manager defaults.
      /// <see cref="T:Rewired.Data.UserDataStore" /> must implement <see cref="T:Rewired.Interfaces.IControllerMapStore" /> or data cannot be loaded from saved user data.
      /// </summary>
      /// <param name="playerId">The Player id. This is used when loading from UserDataStore.</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Mouse Map</returns>
      public MouseMap GetMouseMapInstanceSavedOrDefault(
        int playerId,
        string mapCategoryName,
        string layoutName)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -1252184521;
label_2:
        switch (num ^ -1252184522)
        {
          case 1:
            return (MouseMap) null;
          case 2:
            goto label_1;
          default:
            return (MouseMap) null;
        }
label_4:
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
        if (mapCategoryId < 0)
        {
          num = -1252184522;
          goto label_2;
        }
        else
        {
          int layoutId = this.GetLayoutId(ControllerType.Mouse, layoutName);
          return layoutId < 0 ? (MouseMap) null : this.GetMouseMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
        }
      }

      /// <summary>
      /// Gets the first template Element Identifier on the first joystick template found that maps to the joystick's Element Identifier.
      /// NOTE: It is discouraged to use this method as the mapping template system wasn't designed for this use. This method has been added
      /// as a short-term solution to the problem of trying to identify controller elements as generic Gamepad elements for use in displaying
      /// visual help to users. A better solution will be available in the future and this method will be deprecated at that time.
      /// </summary>
      /// <param name="joystick">The joystick</param>
      /// <param name="joystickElementIdentifierId">The joystick element identifier id.</param>
      /// <returns>ControllerElementIdentifier</returns>
      [Obsolete("This method has been deprecated. Use the Controller Template system instead.", false)]
      public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(
        Joystick joystick,
        int joystickElementIdentifierId)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 1405262437;
label_2:
        switch (num ^ 1405262436)
        {
          case 0:
            goto label_1;
          case 1:
            return (ControllerElementIdentifier) null;
          default:
            return (ControllerElementIdentifier) null;
        }
label_4:
        if (joystick != null)
          return this.tNyLBvCtDEuBxOFliEbgTefIskx(joystick.hardwareTypeGuid, joystickElementIdentifierId);
        num = 1405262438;
        goto label_2;
      }

      private ControllerElementIdentifier tNyLBvCtDEuBxOFliEbgTefIskx(
        Guid _param1,
        int _param2)
      {
        return ReInput.IpMEEVTbjuWFErEDfgWmyhDCeje.tNyLBvCtDEuBxOFliEbgTefIskx(_param1, _param2)?.ToControllerElementIdentifier();
      }

      /// <summary>
      /// Gets a copy of a Controller Template Map from the default controller maps.
      /// This can be used to view the default Controller Template Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="templateTypeGuid">Controller Template type guid</param>
      /// <param name="mapCategoryId">Map Category Id</param>
      /// <param name="layoutId">Layout Id</param>
      /// <returns>Controller Map</returns>
      public ControllerTemplateMap GetControllerTemplateMapInstance(
        Guid templateTypeGuid,
        int mapCategoryId,
        int layoutId)
      {
        return !ReInput.CheckInitialized() ? (ControllerTemplateMap) null : ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.keMEvkeotcJHxFHVZGMDSadpJQd(templateTypeGuid, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of a Controller Template Map from the default controller maps.
      /// This can be used to view the default Controller Template Map setup in the Rewired Input Manager.
      /// </summary>
      /// <param name="templateTypeGuid">Controller Template type guid</param>
      /// <param name="mapCategoryName">Map Category Name</param>
      /// <param name="layoutName">Layout Name</param>
      /// <returns>Controller Map</returns>
      public ControllerTemplateMap GetControllerTemplateMapInstance(
        Guid templateTypeGuid,
        string mapCategoryName,
        string layoutName)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerTemplateMap) null;
        int mapCategoryId = this.GetMapCategoryId(mapCategoryName);
label_3:
        int num = 1040774822;
        int layoutId;
        while (true)
        {
          switch (num ^ 1040774823)
          {
            case 1:
              if (mapCategoryId < 0)
              {
                num = 1040774820;
                continue;
              }
              layoutId = this.GetLayoutId(ControllerType.Custom, layoutName);
              num = 1040774823;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_7:
        return (ControllerTemplateMap) null;
label_9:
        return layoutId < 0 ? (ControllerTemplateMap) null : this.GetControllerTemplateMapInstance(templateTypeGuid, mapCategoryId, layoutId);
      }

      /// <summary>
      /// Gets a copy of the Controller Map Layout Manager Rule Set at the specified id.
      /// </summary>
      /// <param name="id">The id of the Controller Map Layout Manager Rule Set.</param>
      /// <returns>An instance of the Controller Map Layout Manager Rule Set at the specified id.</returns>
      public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(
        int id)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerMapLayoutManager.RuleSet) null;
        return ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetControllerMapLayoutManagerRuleSetById(id)?.ToRuntime();
      }

      /// <summary>
      /// Gets a copy of the Controller Map Layout Manager Rule Set with the specified name.
      /// </summary>
      /// <param name="name">The name of the Controller Map Layout Manager Rule Set.</param>
      /// <returns>A copy of the Controller Map Layout Manager Rule Set with the specified name.</returns>
      public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(
        string name)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = 982480542;
label_2:
        int managerRuleSetId;
        while (true)
        {
          switch (num ^ 982480543)
          {
            case 1:
              goto label_3;
            case 2:
              if (managerRuleSetId < 0)
              {
                num = 982480543;
                continue;
              }
              goto label_8;
            case 3:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_3:
        return (ControllerMapLayoutManager.RuleSet) null;
label_7:
        return (ControllerMapLayoutManager.RuleSet) null;
label_8:
        return this.GetControllerMapLayoutManagerRuleSetInstance(managerRuleSetId);
label_4:
        managerRuleSetId = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetControllerMapLayoutManagerRuleSetId(name);
        num = 982480541;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of the Controller Map Enabler Rule Set at the specified id.
      /// </summary>
      /// <param name="id">The id of the Controller Map Enabler Rule Set.</param>
      /// <returns>A copy of the Controller Map Enabler Rule Set at the specified id.</returns>
      public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(
        int id)
      {
        if (ReInput.CheckInitialized())
          goto label_4;
label_1:
        int num = -2127353114;
label_2:
        switch (num ^ -2127353113)
        {
          case 0:
            goto label_1;
          case 1:
            return (ControllerMapEnabler.RuleSet) null;
          default:
            return (ControllerMapEnabler.RuleSet) null;
        }
label_4:
        ControllerMapEnabler_RuleSet_Editor enablerRuleSetById = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetControllerMapEnablerRuleSetById(id);
        if (enablerRuleSetById != null)
          return enablerRuleSetById.ToRuntime();
        num = -2127353115;
        goto label_2;
      }

      /// <summary>
      /// Gets a copy of the Controller Map Enabler Rule Set with the specified name.
      /// </summary>
      /// <param name="name">The name of the Controller Map Enabler Rule Set.</param>
      /// <returns>A copy of the Controller Map Enabler Rule Set with the specified name.</returns>
      public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(
        string name)
      {
        if (!ReInput.CheckInitialized())
          return (ControllerMapEnabler.RuleSet) null;
        int enablerRuleSetId = ReInput.RIFrLXBUOhfsSJgzsybOKhxdgYJ.GetControllerMapEnablerRuleSetId(name);
        return enablerRuleSetId < 0 ? (ControllerMapEnabler.RuleSet) null : this.GetControllerMapEnablerRuleSetInstance(enablerRuleSetId);
      }
    }

    /// <summary>Provides access to all player-related members.</summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class PlayerHelper : CodeHelper
    {
      private static ReInput.PlayerHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;

      internal static ReInput.PlayerHelper Instance => ReInput.PlayerHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.PlayerHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.PlayerHelper());

      private PlayerHelper()
      {
      }

      /// <summary>Count of Players excluding system player</summary>
      /// <returns>Count of Players excluding system player</returns>
      public int playerCount => !ReInput.CheckInitialized() ? 0 : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.jUdSiOdzosLOzaauahbpfCucBsuC;

      /// <summary>Count of all players including system player</summary>
      /// <returns>Count of all players including system player</returns>
      public int allPlayerCount => !ReInput.CheckInitialized() ? 0 : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.UtPAoqUpJkDhdMeIxQNRmLNfFOM;

      /// <summary>List of all Players excluding System player</summary>
      /// <returns>Player collection excluding the system player</returns>
      public IList<Player> Players => !ReInput.CheckInitialized() ? EmptyObjects<Player>.EmptyReadOnlyIListT : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh;

      /// <summary>List of all Players including System player</summary>
      /// <returns>Player collection including the system player</returns>
      public IList<Player> AllPlayers => !ReInput.CheckInitialized() ? EmptyObjects<Player>.EmptyReadOnlyIListT : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;

      /// <summary>The System player</summary>
      /// <returns>System player</returns>
      public Player SystemPlayer => !ReInput.CheckInitialized() ? (Player) null : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.YQaWcEPIXvpXNJMaGMivuFHfYgf();

      /// <summary>Gets a list of Players.</summary>
      /// <param name="includeSystemPlayer">Optionally include the System player</param>
      /// <returns>Player collection</returns>
      public IList<Player> GetPlayers(bool includeSystemPlayer = false)
      {
        if (!ReInput.CheckInitialized())
          return EmptyObjects<Player>.EmptyReadOnlyIListT;
        return !includeSystemPlayer ? ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.dziwAbRFMHJLdqCNkewyveDGBlh : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.xrmwongJBdtmMULVxQIaiivvMQY;
      }

      /// <summary>Gets a Player at a specific id</summary>
      /// <param name="playerId">The id of the player</param>
      /// <returns>Player with id</returns>
      public Player GetPlayer(int playerId) => !ReInput.CheckInitialized() ? (Player) null : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.HtdDShzhJxZZbzjutuYSLTLxGvy(playerId);

      /// <summary>Gets a Player by name</summary>
      /// <param name="name">The name of the player</param>
      /// <returns>Player with name</returns>
      public Player GetPlayer(string name) => !ReInput.CheckInitialized() ? (Player) null : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.HtdDShzhJxZZbzjutuYSLTLxGvy(name);

      /// <summary>Gets the System Player</summary>
      /// <returns>The system player</returns>
      public Player GetSystemPlayer() => !ReInput.CheckInitialized() ? (Player) null : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.YQaWcEPIXvpXNJMaGMivuFHfYgf();

      /// <summary>Gets the id of a Player by name</summary>
      /// <param name="playerName">The name of the player</param>
      /// <returns>Id of the Player</returns>
      public int GetPlayerId(string playerName) => !ReInput.CheckInitialized() ? -1 : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.qxLeORuEhjhUqlvdfdxkfGQsjGBM(playerName);

      /// <summary>
      /// Gets an array of player names. Optionally includes the System player.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <param name="includeSystemPlayer"></param>
      /// <returns>Player names</returns>
      public string[] GetPlayerNames(bool includeSystemPlayer = false) => !ReInput.CheckInitialized() ? EmptyObjects<string>.array : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.riWKLsHeeQadfRfhrPipjFrkQgM(includeSystemPlayer);

      /// <summary>
      /// Gets an array of player descriptive names. Optionally includes the System player.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <param name="includeSystemPlayer"></param>
      /// <returns>Player descriptive names</returns>
      public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = false) => !ReInput.CheckInitialized() ? EmptyObjects<string>.array : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.zExkRwhBcVDTyjiHNNCPOZZNgKTo(includeSystemPlayer);

      /// <summary>
      /// Gets an array of player ids. Optionally includes System player.
      /// Allocates an array, so use sparingly to reduce garbage collection.
      /// </summary>
      /// <param name="includeSystemPlayer"></param>
      /// <returns>Player ids</returns>
      public int[] GetPlayerIds(bool includeSystemPlayer = false) => !ReInput.CheckInitialized() ? EmptyObjects<int>.array : ReInput.IunzkBzmzbvkNcXgVbfhTUGBTQT.jSwQfFNVHObCwQOfIfCUXiJcABx(includeSystemPlayer);
    }

    /// <summary>
    /// Provides access to time-related data. This is mostly for accurate unscaled time comparisons for button and axis times.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class TimeHelper : CodeHelper
    {
      private static ReInput.TimeHelper oaOElAxNrCsgjnGhpJEMVHTtwxI;

      internal static ReInput.TimeHelper Instance => ReInput.TimeHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.TimeHelper.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.TimeHelper());

      private TimeHelper()
      {
      }

      /// <summary>
      /// Unscaled time since the last update in the current update loop.
      /// Always use this when doing current time comparisons for button and axis active/inactive times instead of Time.time or Time.unscaledTime.
      /// </summary>
      public float unscaledDeltaTime => !ReInput.CheckInitialized() ? 0.0f : (float) ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.VjUgXgHDKGTDNqcWNEfnYglSqrnZ;

      /// <summary>
      /// Current unscaled time since start of the game.
      /// Always use this when doing current time comparisons for button and axis active/inactive times instead of Time.time or Time.unscaledTime.
      /// </summary>
      public double unscaledTime => !ReInput.CheckInitialized() ? 0.0 : ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.cDBpfYGoBHHXABunSWQLwbdPeoG;

      /// <summary>
      /// The current frame in the current update loop.
      /// This value does not match UnityEngine.Time.frameCount.
      /// </summary>
      public uint currentFrame => !ReInput.CheckInitialized() ? 0U : ReInput.rCasTtxajaYfVqBdZjtydsSfKZag.ynhdwwHcdqBblkzzsSnqJgTmUgr;
    }

    private class McKOXtijWtxGreONISFgcvboteO
    {
      private StopwatchBase WgMbRtrdLgqEszCGzIRVqQRzZum;
      private double VarasGTmyOvvRwWvLLcozjUBqVE;
      private ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf ddnxvPdWpHbNMHFKPlWrydLYBSDF;
      private ADictionary<int, ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf> UNsKcVhOPnJtbnusXQrSCfqWehX;
      private uint lAXDJTitTejrnRitndIPtarhsRh;

      public double cDBpfYGoBHHXABunSWQLwbdPeoG => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.cDBpfYGoBHHXABunSWQLwbdPeoG;

      public double UHFgiGhaYSfMfJJXkpDZlPhpFsSX => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.UHFgiGhaYSfMfJJXkpDZlPhpFsSX;

      public double VjUgXgHDKGTDNqcWNEfnYglSqrnZ => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.VjUgXgHDKGTDNqcWNEfnYglSqrnZ;

      public float pengAGLJXAdEPjHiVKPmJmvqiqDk => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.pengAGLJXAdEPjHiVKPmJmvqiqDk;

      public float TfGchxBPBEyNlgFhMsZZEMUYPho => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.TfGchxBPBEyNlgFhMsZZEMUYPho;

      internal double FIRIpvFCpLepBeglYvRzekwoHgmJ => this.WgMbRtrdLgqEszCGzIRVqQRzZum.elapsedSeconds + this.VarasGTmyOvvRwWvLLcozjUBqVE;

      public uint ynhdwwHcdqBblkzzsSnqJgTmUgr => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.ynhdwwHcdqBblkzzsSnqJgTmUgr;

      public uint MhUKKzHJIzaLUkSvfsookmVLkLHU => this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.MhUKKzHJIzaLUkSvfsookmVLkLHU;

      public uint mPFHsfrEGcdmNunBZTtJAzKNtDI => this.lAXDJTitTejrnRitndIPtarhsRh;

      public McKOXtijWtxGreONISFgcvboteO()
      {
label_1:
        int num = -862394128;
        while (true)
        {
          switch (num ^ -862394127)
          {
            case 1:
              this.WgMbRtrdLgqEszCGzIRVqQRzZum = ReInput.McKOXtijWtxGreONISFgcvboteO.aXRIJzLppsjbephUFJkhraGhFgdJ.AuQbrBkcDSaZfcCcxeCNxtCfMlJy;
              num = -862394127;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        this.QUTypegHiwjlXkoowveNEGsBPup();
      }

      public void SVTOpiOtolNbUKyxKsuPYyfmPMI() => this.VarasGTmyOvvRwWvLLcozjUBqVE = (double) Time.realtimeSinceStartup;

      public void QUTypegHiwjlXkoowveNEGsBPup()
      {
        this.ddnxvPdWpHbNMHFKPlWrydLYBSDF = (ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf) null;
        this.UNsKcVhOPnJtbnusXQrSCfqWehX = new ADictionary<int, ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf>();
        TempListPool.TList<UpdateLoopType> tlist = TempListPool.GetTList<UpdateLoopType>(3);
        try
        {
          List<UpdateLoopType> list = tlist.list;
label_2:
          int num = 1174729936;
          int index;
          ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf kxubdwgMdjnbLdCrjskrf;
          while (true)
          {
            switch (num ^ 1174729943)
            {
              case 0:
                goto label_2;
              case 1:
                ++index;
                num = 1174729951;
                continue;
              case 2:
                if (this.ddnxvPdWpHbNMHFKPlWrydLYBSDF == null)
                {
                  this.ddnxvPdWpHbNMHFKPlWrydLYBSDF = kxubdwgMdjnbLdCrjskrf;
                  num = 1174729942;
                  continue;
                }
                goto case 1;
              case 3:
                num = 1174729951;
                continue;
              case 4:
                this.UNsKcVhOPnJtbnusXQrSCfqWehX.Add((int) list[index], kxubdwgMdjnbLdCrjskrf);
                num = 1174729941;
                continue;
              case 5:
                index = 0;
                num = 1174729940;
                continue;
              case 6:
                kxubdwgMdjnbLdCrjskrf = new ReInput.McKOXtijWtxGreONISFgcvboteO.qkwWTAiKXubdwgMDJNBLdCRjskrf(list[index]);
                num = 1174729939;
                continue;
              case 7:
                EnumConverter.ToUpdateLoopTypes((UpdateLoopSetting) 2147483647, list);
                num = 1174729938;
                continue;
              default:
                if (index < list.Count)
                  goto case 6;
                else
                  goto label_16;
            }
          }
label_16:;
        }
        finally
        {
          if (tlist != null)
          {
label_14:
            int num = 1174729941;
            while (true)
            {
              switch (num ^ 1174729943)
              {
                case 0:
                  goto label_14;
                case 2:
                  tlist.Dispose();
                  num = 1174729942;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
      }

      public void KNXyhGDrVuKEJRkqcCqdGgMBLPHj(UpdateLoopType _param1)
      {
        if (this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.kLntcctrrYvdWLnswmNzoCjVnVy == _param1)
          goto label_5;
label_1:
        int num1 = 917442722;
label_2:
        while (true)
        {
          switch (num1 ^ 917442727)
          {
            case 0:
              goto label_3;
            case 1:
              this.ddnxvPdWpHbNMHFKPlWrydLYBSDF.KNXyhGDrVuKEJRkqcCqdGgMBLPHj();
              num1 = 917442721;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_1;
            case 4:
              int num2;
              num1 = num2 = Event.current.rawType == EventType.Layout ? 917442726 : (num2 = 917442727);
              continue;
            case 5:
              this.ddnxvPdWpHbNMHFKPlWrydLYBSDF = this.UNsKcVhOPnJtbnusXQrSCfqWehX[(int) _param1];
              num1 = 917442725;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        this.lAXDJTitTejrnRitndIPtarhsRh = MiscTools.Tick(this.lAXDJTitTejrnRitndIPtarhsRh);
        ReInput.absFrame = this.lAXDJTitTejrnRitndIPtarhsRh;
        return;
label_5:
        num1 = _param1 == UpdateLoopType.OnGUI ? 917442723 : (num1 = 917442726);
        goto label_2;
      }

      private class qkwWTAiKXubdwgMDJNBLdCRjskrf
      {
        public readonly UpdateLoopType kLntcctrrYvdWLnswmNzoCjVnVy;
        private double kjOYgaGhaSzJvwnFpcfmFqAZKcO;
        private double kgzcLubXvgvFzNqqvyfPngEyBUHG;
        private double LgsNGHoyXfVOAwvYcgxaEFsCJvU;
        private double oKgdJmCwHvoWryZCQRHUBbvljpB;
        private uint wtzxrhElebOvjyqAlRACWCSUswC;
        private uint rEOKQSCGIDrcrpdtrjZbOvLcdST;
        private float AFFbTuXINIeSrjdAeVgbQQoTxmJ;
        private float fInpRbYVOuKkKqOFmdugzkugihO;

        public double cDBpfYGoBHHXABunSWQLwbdPeoG => this.kjOYgaGhaSzJvwnFpcfmFqAZKcO;

        public double UHFgiGhaYSfMfJJXkpDZlPhpFsSX => this.kgzcLubXvgvFzNqqvyfPngEyBUHG;

        public double VjUgXgHDKGTDNqcWNEfnYglSqrnZ => this.LgsNGHoyXfVOAwvYcgxaEFsCJvU;

        public uint ynhdwwHcdqBblkzzsSnqJgTmUgr => this.wtzxrhElebOvjyqAlRACWCSUswC;

        public uint MhUKKzHJIzaLUkSvfsookmVLkLHU => this.rEOKQSCGIDrcrpdtrjZbOvLcdST;

        public float pengAGLJXAdEPjHiVKPmJmvqiqDk => this.AFFbTuXINIeSrjdAeVgbQQoTxmJ;

        public float TfGchxBPBEyNlgFhMsZZEMUYPho => this.fInpRbYVOuKkKqOFmdugzkugihO;

        public qkwWTAiKXubdwgMDJNBLdCRjskrf(UpdateLoopType updateLoop)
        {
          this.kLntcctrrYvdWLnswmNzoCjVnVy = updateLoop;
          this.oKgdJmCwHvoWryZCQRHUBbvljpB = (double) Time.realtimeSinceStartup;
          this.wtzxrhElebOvjyqAlRACWCSUswC = 0U;
        }

        public void KNXyhGDrVuKEJRkqcCqdGgMBLPHj()
        {
          this.kgzcLubXvgvFzNqqvyfPngEyBUHG = this.kjOYgaGhaSzJvwnFpcfmFqAZKcO;
label_1:
          int num1 = 1057622084;
          while (true)
          {
            switch (num1 ^ 1057622087)
            {
              case 0:
                this.AFFbTuXINIeSrjdAeVgbQQoTxmJ = ReInput.gIyLZjMrMJqcQLnfjtxUhKSpoHP();
                ReInput.previousFrame = this.rEOKQSCGIDrcrpdtrjZbOvLcdST;
                ReInput.currentFrame = this.wtzxrhElebOvjyqAlRACWCSUswC;
                num1 = 1057622095;
                continue;
              case 1:
                this.oKgdJmCwHvoWryZCQRHUBbvljpB = 0.0;
                num1 = 1057622094;
                continue;
              case 2:
                int num2;
                num1 = num2 = this.oKgdJmCwHvoWryZCQRHUBbvljpB > this.kjOYgaGhaSzJvwnFpcfmFqAZKcO ? 1057622086 : (num2 = 1057622094);
                continue;
              case 3:
                this.kjOYgaGhaSzJvwnFpcfmFqAZKcO = ReInput.realTime;
                num1 = 1057622085;
                continue;
              case 4:
                goto label_1;
              case 5:
                this.wtzxrhElebOvjyqAlRACWCSUswC = MiscTools.Tick(this.wtzxrhElebOvjyqAlRACWCSUswC);
                this.fInpRbYVOuKkKqOFmdugzkugihO = this.AFFbTuXINIeSrjdAeVgbQQoTxmJ;
                num1 = 1057622087;
                continue;
              case 6:
                this.oKgdJmCwHvoWryZCQRHUBbvljpB = this.kjOYgaGhaSzJvwnFpcfmFqAZKcO;
                num1 = 1057622080;
                continue;
              case 7:
                this.rEOKQSCGIDrcrpdtrjZbOvLcdST = this.wtzxrhElebOvjyqAlRACWCSUswC;
                num1 = 1057622082;
                continue;
              case 9:
                this.LgsNGHoyXfVOAwvYcgxaEFsCJvU = this.kjOYgaGhaSzJvwnFpcfmFqAZKcO - this.oKgdJmCwHvoWryZCQRHUBbvljpB;
                num1 = 1057622081;
                continue;
              default:
                goto label_11;
            }
          }
label_11:
          ReInput.unscaledTime = this.kjOYgaGhaSzJvwnFpcfmFqAZKcO;
          ReInput.unscaledTimePrev = this.kgzcLubXvgvFzNqqvyfPngEyBUHG;
          ReInput.unscaledDeltaTime = this.LgsNGHoyXfVOAwvYcgxaEFsCJvU;
        }
      }

      private static class aXRIJzLppsjbephUFJkhraGhFgdJ
      {
        public static StopwatchBase AuQbrBkcDSaZfcCcxeCNxtCfMlJy => !UnityTools.isEditor && UnityTools.platform == Rewired.Platforms.Platform.XboxOne ? (StopwatchBase) UnityStopwatch.Global : (StopwatchBase) Stopwatch.Global;

        public static StopwatchBase SiUcQoHUMSjocNLyjbuzvdqmrXM() => !UnityTools.isEditor && UnityTools.platform == Rewired.Platforms.Platform.XboxOne ? (StopwatchBase) new UnityStopwatch() : (StopwatchBase) new Stopwatch();

        public static StopwatchBase wkSgyFrGPqHxCspAlZoPlGyGSFV() => !UnityTools.isEditor && UnityTools.platform == Rewired.Platforms.Platform.XboxOne ? (StopwatchBase) UnityStopwatch.StartNew() : (StopwatchBase) Stopwatch.StartNew();
      }
    }

    /// <summary>Provides access to touch-related members.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public sealed class UnityTouch : CodeHelper
    {
      private static ReInput.UnityTouch oaOElAxNrCsgjnGhpJEMVHTtwxI;

      internal static ReInput.UnityTouch Instance => ReInput.UnityTouch.oaOElAxNrCsgjnGhpJEMVHTtwxI ?? (ReInput.UnityTouch.oaOElAxNrCsgjnGhpJEMVHTtwxI = new ReInput.UnityTouch());

      private UnityTouch()
      {
      }

      public int touchCount => Input.touchCount;

      public Touch[] touches => Input.touches;

      public bool simulateMouseWithTouches
      {
        get => Input.simulateMouseWithTouches;
        set => Input.simulateMouseWithTouches = value;
      }

      public bool multiTouchEnabled
      {
        get => Input.multiTouchEnabled;
        set => Input.multiTouchEnabled = value;
      }

      public Touch GetTouch(int index) => Input.GetTouch(index);
    }

    internal class turGXwBvHWoRGEzdiNffQHtjLxUE
    {
      public readonly ValueWatcher<bool> zdfWFvFuJmKLPOOzDKWHpXcTGhm;
      public readonly ValueWatcher<bool> xvFOSywVLenNnSMFVdzEYKETiTEG;
      public readonly ValueWatcher<bool> YXvGkrWuFDzIDXbWAMtPnseRiuf;
      public readonly ValueWatcher<int> KCFTJnjhinqIBbpvCUxCXzMFIKf;
      public readonly ValueWatcher<float> VjUgXgHDKGTDNqcWNEfnYglSqrnZ;
      public readonly ValueWatcher<string> dlPqyxpBzmUbBcKFAAQaGseQiIe;
      public readonly ValueWatcher<bool> BbyRoBsowyQmdHmWWxWCZqxtDV;
      private int oTHpLTYUDjpKsXORtKvJvquOzRn;
      private readonly ValueWatcher[] zzpsjSVXwcmuhmclkcROItTVeyTd;

      public int XiDZQOUPwAMXyPtXMnYBFcTlbKP => this.oTHpLTYUDjpKsXORtKvJvquOzRn;

      public turGXwBvHWoRGEzdiNffQHtjLxUE()
      {
label_1:
        int num1 = 68462673;
        List<ValueWatcher> valueWatcherList1;
        List<ValueWatcher> valueWatcherList2;
        while (true)
        {
          switch (num1 ^ 68462681)
          {
            case 0:
              int num2;
              num1 = num2 = ReInput.editorPlatform != EditorPlatform.None ? 68462675 : (num2 = 68462686);
              continue;
            case 1:
              valueWatcherList2.Add((ValueWatcher) (this.xvFOSywVLenNnSMFVdzEYKETiTEG = new ValueWatcher<bool>(Screen.fullScreen, (Func<bool>) (() => Screen.fullScreen), false)));
              num1 = 68462685;
              continue;
            case 2:
              valueWatcherList2.Add((ValueWatcher) (this.zdfWFvFuJmKLPOOzDKWHpXcTGhm = new ValueWatcher<bool>(true, false)));
              num1 = 68462680;
              continue;
            case 3:
              valueWatcherList1 = valueWatcherList2;
              num1 = 68462681;
              continue;
            case 4:
              valueWatcherList2.Add((ValueWatcher) (this.YXvGkrWuFDzIDXbWAMtPnseRiuf = new ValueWatcher<bool>(Application.runInBackground, (Func<bool>) (() => Application.runInBackground), false)));
              num1 = 68462672;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              this.zzpsjSVXwcmuhmclkcROItTVeyTd = valueWatcherList1.ToArray();
              this.KNXyhGDrVuKEJRkqcCqdGgMBLPHj();
              num1 = 68462687;
              continue;
            case 8:
              valueWatcherList2 = new List<ValueWatcher>();
              num1 = 68462683;
              continue;
            case 9:
              valueWatcherList2.Add((ValueWatcher) (this.KCFTJnjhinqIBbpvCUxCXzMFIKf = new ValueWatcher<int>((int) Screen.fullScreenMode, (Func<int>) (() => (int) Screen.fullScreenMode), false)));
              valueWatcherList2.Add((ValueWatcher) (this.VjUgXgHDKGTDNqcWNEfnYglSqrnZ = new ValueWatcher<float>(Time.unscaledDeltaTime, (Func<float>) (() => Time.unscaledDeltaTime), false)));
              valueWatcherList2.Add((ValueWatcher) (this.BbyRoBsowyQmdHmWWxWCZqxtDV = new ValueWatcher<bool>(MathTools.ApproximatelyZero(Time.timeScale), (Func<bool>) (() => MathTools.ApproximatelyZero(Time.timeScale)), MathTools.ApproximatelyZero(Time.timeScale))));
              num1 = 68462682;
              continue;
            case 10:
              valueWatcherList1.Add((ValueWatcher) (this.dlPqyxpBzmUbBcKFAAQaGseQiIe = new ValueWatcher<string>(UnityTools.externalTools.GetFocusedEditorWindowTitle(), (Func<string>) (() => UnityTools.externalTools.GetFocusedEditorWindowTitle()), false)));
              num1 = 68462686;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }

      public void KNXyhGDrVuKEJRkqcCqdGgMBLPHj()
      {
        int index = 0;
label_7:
        int num = index >= this.zzpsjSVXwcmuhmclkcROItTVeyTd.Length ? -457031181 : (num = -457031178);
        while (true)
        {
          switch (num ^ -457031177)
          {
            case 0:
              goto label_3;
            case 1:
              this.zzpsjSVXwcmuhmclkcROItTVeyTd[index].Update();
              num = -457031180;
              continue;
            case 2:
              num = -457031178;
              continue;
            case 3:
              ++index;
              num = -457031182;
              continue;
            case 4:
              this.oTHpLTYUDjpKsXORtKvJvquOzRn = Time.frameCount;
              num = -457031177;
              continue;
            case 5:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }

      public void LKTtxsLFzTOMxsXNzHgBqpTGmuV()
      {
        int index = 0;
label_1:
        int num1 = -1787571670;
        while (true)
        {
          switch (num1 ^ -1787571672)
          {
            case 0:
              goto label_1;
            case 1:
              int num2;
              num1 = num2 = index < this.zzpsjSVXwcmuhmclkcROItTVeyTd.Length ? -1787571668 : (num2 = -1787571669);
              continue;
            case 2:
              num1 = -1787571671;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.zzpsjSVXwcmuhmclkcROItTVeyTd[index].TriggerEvent();
              ++index;
              num1 = -1787571671;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }
    }
  }
}
