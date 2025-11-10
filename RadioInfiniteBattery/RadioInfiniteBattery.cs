using System;
using HarmonyLib;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace RadioInfiniteBattery;

public class RadioInfiniteBattery : Plugin
{
    public override string Name => "Radio Infinite Battery";
    public override string Description => "A simple plugin to make your radio's infinite battery.";
    public override string Author => "araangarciiia";
    public override Version Version => new(1, 0, 0);
    public override Version RequiredApiVersion => new(LabApiProperties.CompiledVersion);

    Harmony _harmony = new Harmony("romzyytv.harmony");
        
    public override void Enable() => _harmony.PatchAll();

    public override void Disable() => _harmony.UnpatchAll("romzyytv.harmony");
}