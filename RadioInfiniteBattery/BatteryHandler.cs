using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;
using InventorySystem.Items.Radio;

namespace RadioInfiniteBattery;

[HarmonyPatch(typeof(RadioPickup), nameof(RadioPickup.LateUpdate))]
public class BatteryPatch
{
    [HarmonyTranspiler]
    private IEnumerator<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        yield return new CodeInstruction(OpCodes.Ret);
    }
}