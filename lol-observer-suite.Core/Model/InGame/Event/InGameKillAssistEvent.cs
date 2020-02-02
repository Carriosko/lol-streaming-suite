using System.Collections.Generic;

namespace lol_observer_suite.Core.Model.InGame.Event
{
    public class InGameKillAssistEvent : InGameKillEvent
    {
        public List<string> Assisters { get; set; }
    }
}
