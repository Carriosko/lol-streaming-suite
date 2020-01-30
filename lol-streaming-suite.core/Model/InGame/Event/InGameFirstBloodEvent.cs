using System;
using System.Collections.Generic;
using System.Text;

namespace lol_streaming_suite.core.Model.InGame.Event
{
    public class InGameFirstBloodEvent : InGameEvent
    {
        public string Recipient { get; set; }
    }
}
