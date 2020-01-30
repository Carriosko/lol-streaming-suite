using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameMultiKillEvent : InGameKillEvent
    {
        public int KillStreak { get; set; }
    }
}
