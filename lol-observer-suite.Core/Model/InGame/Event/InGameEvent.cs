namespace lol_observer_suite.Core.Model.InGame.Event
{
    public class InGameEvent
    {
        public int EventID { get; set; }
        public InGameEventType EventType { get; set; }
        public float EventTime { get; set; }
    }
}
