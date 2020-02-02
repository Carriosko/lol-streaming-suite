namespace lol_observer_suite.Core.Model.InGame.Event
{
    class InGameChampionKillEvent : InGameKillAssistEvent
    {
        public string VictimName { get; set; }
    }
}
