namespace lol_observer_suite.Core.Model.InGame.Event
{
    public class InGameInhibKillEvent : InGameKillAssistEvent
    {
        public string InhibKilled { get; set; } // TODO: make this an enum
    }
}
