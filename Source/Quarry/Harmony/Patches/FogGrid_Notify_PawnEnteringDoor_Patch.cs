using HarmonyLib;
using Verse;

namespace Quarry
{
    [HarmonyPatch(typeof(FogGrid), "Notify_PawnEnteringDoor")]
    static class FogGrid_Notify_PawnEnteringDoor_Patch
    {
        static void Postfix(Map ___map)
        {
            ___map?.GetComponent<QuarryGrid>()?.Notify_FogGridUpdate();
        }
    }
}
