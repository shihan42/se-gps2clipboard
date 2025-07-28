using HarmonyLib;
using Sandbox.Game.Multiplayer;
using Sandbox.Game.Screens.Helpers;
using Sandbox.Game.World;
using VRage.Platform.Windows.Forms;

namespace Gps2Clipboard
{
    [HarmonyPatch(typeof(MyGpsCollection))]
    // ReSharper disable once UnusedType.Global
    public static class Patch_MyGpsCollection
    {
        [HarmonyPatch("SendAddGpsRequest")]
        [HarmonyPostfix]
        // ReSharper disable once UnusedMember.Global
        public static void Postfix_SendAddGpsRequest(long identityId, ref MyGps gps, long entityId, bool playSoundOnCreation)
        {
            // only copy GPS if the player created it
            if (MySession.Static.LocalPlayerId == identityId)
            {
                var gpsString = gps.ToString();
                MyClipboardHelper.SetClipboard(gpsString);
            }
        }
    }
}
