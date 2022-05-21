using HarmonyLib;
using Hazel;
using UnityEngine;

namespace TheOtherRoles_tomarai_JP
{

    [HarmonyPatch(typeof(ControllerManager), nameof(ControllerManager.Update))]
    class ControllerManagerPatch
    {
        public static void Postfix()
        {
            // Terminate round
            if(AmongUsClient.Instance.AmHost && Input.GetKeyDown(KeyCode.Return) && Input.GetKey(KeyCode.L) && Input.GetKey(KeyCode.LeftShift) && AmongUsClient.Instance.IsGameStarted) {
                MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId, (byte)CustomRPC.ForceEnd, Hazel.SendOption.Reliable, -1);
                AmongUsClient.Instance.FinishRpcImmediately(writer);
                RPCProcedure.forceEnd();
            }
        }
    }
}