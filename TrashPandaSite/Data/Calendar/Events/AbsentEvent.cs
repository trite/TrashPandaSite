﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPandaSite.Data.Calendar.Events
{
    public class AbsentEvent : ICalendarEvent
    {
        public string TinyDetails { get; set; }

        public string Details { get; set; }
    }
}