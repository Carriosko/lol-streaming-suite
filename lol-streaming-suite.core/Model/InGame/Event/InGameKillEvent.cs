using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameKillEvent : InGameEvent
    {
        public string KillerName { get; set; }
    }
}
