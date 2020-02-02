namespace lol_observer_suite.Core.Model.InGame.Event
{
    public class InGameTurretKillEvent : InGameKillAssistEvent
    {
        public string TurredKilled { get; set; } // TODO: make this an enum
    }
}
