using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPandaSite.Data.Calendar.Events
{
    public class BasicEvent : ICalendarEvent
    {
        public string TinyDetails { get; set; }

        public string Details { get; set; }

        public string ColorClass { get; set; }
    }
}
