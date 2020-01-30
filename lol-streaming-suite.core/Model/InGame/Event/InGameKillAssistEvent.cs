using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameKillAssistEvent : InGameKillEvent
    {
        public List<string> Assisters { get; set; }
    }
}
