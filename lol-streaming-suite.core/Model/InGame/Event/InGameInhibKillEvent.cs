using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameInhibKillEvent : InGameKillAssistEvent
    {
        public string InhibKilled { get; set; } // TODO: make this an enum
    }
}
