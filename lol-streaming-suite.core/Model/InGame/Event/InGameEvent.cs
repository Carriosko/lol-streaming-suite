using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameEvent
    {
        public int EventID { get; set; }
        public InGameEventType EventType { get; set; }
        public float EventTime { get; set; }
    }
}
