using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.CustomHandlers;

namespace RadioInfiniteBattery
{
    public class BatteryHandler : CustomEventsHandler
    {
        public override void OnPlayerUsingRadio(PlayerUsingRadioEventArgs ev)
        {
            if (ev.RadioItem.Base.BatteryPercent != 100)
            {
                ev.RadioItem.Base.BatteryPercent = 100;
            }
            
            ev.Drain = 0;
        }
    }
}