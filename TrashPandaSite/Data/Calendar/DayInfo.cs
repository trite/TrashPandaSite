using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashPandaSite.Data.Calendar.Events;

namespace TrashPandaSite.Data.Calendar
{
    public class DayInfo
    {
        public DateTime Date { get; set; }

        public bool IsCurrentMonth { get; set; }

        public List<ICalendarEvent> CalendarEvents { get; set; }
    }
}
