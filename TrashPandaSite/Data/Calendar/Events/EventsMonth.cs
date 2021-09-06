using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrashPandaSite.Data.Calendar.Events
{
    public class EventsMonth
    {
        [JsonPropertyName("Events")]
        public Dictionary<int, List<ICalendarEvent>> Events { get; set; }

        public EventsMonth(Dictionary<int, List<ICalendarEvent>> events)
        {
            Events = events;
        }

        public EventsMonth()
        {

        }

        public List<ICalendarEvent> GetEventsForDay(int dayNumber) => Events[dayNumber];

        public List<ICalendarEvent> GetEventsForDay(DateTime date) => GetEventsForDay(date.Day);
    }
}
