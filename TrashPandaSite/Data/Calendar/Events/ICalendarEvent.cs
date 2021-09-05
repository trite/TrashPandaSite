namespace TrashPandaSite.Data.Calendar.Events
{
    public interface ICalendarEvent
    {
        string TinyDetails { get; }

        string Details { get; }

        string ColorClass { get; }
    }
}