using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPandaSite.Data.Calendar
{
    public class DayInfo
    {
        public DateTime Date { get; set; }

        public bool IsCurrentMonth { get; set; }

        public List<CalendarEvent> CalendarEvents { get; set; }
    }
}
