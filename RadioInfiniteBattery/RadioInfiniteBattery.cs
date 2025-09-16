using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace RadioInfiniteBattery
{
    public class RadioInfiniteBattery : Plugin
    {
        public override string Name => "Radio Infinite Battery";
        public override string Description => "A simple plugin to make your radio's infinite battery.";
        public override string Author => "araangarciiia";
        public override Version Version => new(1, 0, 0);
        public override Version RequiredApiVersion => new(LabApiProperties.CompiledVersion);

        public BatteryHandler BatteryHandler = new();
        
        public override void Enable()
        {
            CustomHandlersManager.RegisterEventsHandler(BatteryHandler);
        }

        public override void Disable()
        {
            CustomHandlersManager.UnregisterEventsHandler(BatteryHandler);
        }
    }
}