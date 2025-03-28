public class EventService
{
    private List<Event> events = new List<Event>
    {
        new Event { Id = 1, Title = "Tech Conference", Description = "Annual tech event", Date = DateTime.Now.AddDays(5) },
        new Event { Id = 2, Title = "Music Festival", Description = "Live music all day", Date = DateTime.Now.AddDays(10) }
    };

    public List<Event> GetEvents() => events;

    public Event GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);

    public void MarkAttendance(int id, bool attended)
    {
        var ev = events.FirstOrDefault(e => e.Id == id);
        if (ev != null) ev.IsAttended = attended;
    }
}