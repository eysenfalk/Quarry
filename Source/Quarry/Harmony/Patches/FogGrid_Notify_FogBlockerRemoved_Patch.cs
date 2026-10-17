using HarmonyLib;
using Verse;

namespace Quarry
{
    [HarmonyPatch(typeof(FogGrid), "Notify_FogBlockerRemoved")]
    static class FogGrid_Notify_FogBlockerRemoved_Patch
    {
        static void Postfix(Map ___map)
        {
            ___map?.GetComponent<QuarryGrid>()?.Notify_FogGridUpdate();
        }
    }
}
