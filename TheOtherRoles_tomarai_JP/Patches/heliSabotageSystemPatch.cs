using HarmonyLib;
using System;
using static TheOtherRoles_tomarai_JP.TheOtherRoles_tomarai_JP;
using UnityEngine;
using System.Linq;
using TheOtherRoles_tomarai_JP.Objects;

namespace TheOtherRoles_tomarai_JP.Patches {
    [HarmonyPatch(typeof(HeliSabotageSystem), nameof(HeliSabotageSystem.Detoriorate))]
    public static class HeliSabotageSystemPatch
    {
        static void Prefix(HeliSabotageSystem __instance, float deltaTime)
        {
            if (!__instance.IsActive)
                return;
            if (AirshipStatus.Instance == null)
                return;

            if (__instance.Countdown > CustomOptionHolder.heliSabotageSystemTimeLimit.getFloat())
                __instance.Countdown = CustomOptionHolder.heliSabotageSystemTimeLimit.getFloat();
        }
    }
}

