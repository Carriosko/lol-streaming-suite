namespace lol_observer_suite.Core.Model.InGame.Event
{
    public class InGameMultiKillEvent : InGameKillEvent
    {
        public int KillStreak { get; set; }
    }
}
