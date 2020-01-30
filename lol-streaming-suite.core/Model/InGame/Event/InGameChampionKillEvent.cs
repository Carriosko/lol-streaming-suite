using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    class InGameChampionKillEvent : InGameKillAssistEvent
    {
        public string VictimName { get; set; }
    }
}
