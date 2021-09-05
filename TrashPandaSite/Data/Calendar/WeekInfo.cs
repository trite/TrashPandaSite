using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashPandaSite.Data.Calendar
{
    public class WeekInfo
    {
        private Dictionary<string, DayInfo> _dayDictionary;

        public string GetDayString(DayOfWeek dayOfWeek)
        {
            return dayOfWeek switch
            {
                DayOfWeek.Sunday => "sun",
                DayOfWeek.Monday => "mon",
                DayOfWeek.Tuesday => "tue",
                DayOfWeek.Wednesday => "wed",
                DayOfWeek.Thursday => "thu",
                DayOfWeek.Friday => "fri",
                DayOfWeek.Saturday => "sat",
                _ => throw new Exception("This shouldn't be possible, FIX IT FIX IT!")
            };
        }

        public DayInfo GetDay(string dayString) => _dayDictionary[dayString.ToLower()];

        public WeekInfo()
        {
            _dayDictionary = new()
            {
                { GetDayString(DayOfWeek.Sunday), new() },
                { GetDayString(DayOfWeek.Monday), new() },
                { GetDayString(DayOfWeek.Tuesday), new() },
                { GetDayString(DayOfWeek.Wednesday), new() },
                { GetDayString(DayOfWeek.Thursday), new() },
                { GetDayString(DayOfWeek.Friday), new() },
                { GetDayString(DayOfWeek.Saturday), new() }
            };
        }

        public DayInfo GetDayInfo(DayOfWeek dayOfWeek) => _dayDictionary[GetDayString(dayOfWeek)];
        public void SetDayInfo(DayOfWeek dayOfWeek, DayInfo dayInfo) => _dayDictionary[GetDayString(dayOfWeek)] = dayInfo;

        public DayInfo Sunday
        {
            get => GetDayInfo(DayOfWeek.Sunday);
            set => SetDayInfo(DayOfWeek.Sunday, value);
        }

        public DayInfo Monday
        {
            get => GetDayInfo(DayOfWeek.Monday);
            set => SetDayInfo(DayOfWeek.Monday, value);
        }

        public DayInfo Tuesday
        {
            get => GetDayInfo(DayOfWeek.Tuesday);
            set => SetDayInfo(DayOfWeek.Tuesday, value);
        }

        public DayInfo Wednesday
        {
            get => GetDayInfo(DayOfWeek.Wednesday);
            set => SetDayInfo(DayOfWeek.Wednesday, value);
        }

        public DayInfo Thursday
        {
            get => GetDayInfo(DayOfWeek.Thursday);
            set => SetDayInfo(DayOfWeek.Thursday, value);
        }

        public DayInfo Friday
        {
            get => GetDayInfo(DayOfWeek.Friday);
            set => SetDayInfo(DayOfWeek.Friday, value);
        }

        public DayInfo Saturday
        {
            get => GetDayInfo(DayOfWeek.Saturday);
            set => SetDayInfo(DayOfWeek.Saturday, value);
        }
    }
}
