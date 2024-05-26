namespace EventAuto.Models;
public enum EventRole
{
    Host,
    Creator,
    CoHost,
    Staff,
    Security,
    Admin
}
public class EventStaff
{

    public Person Person { get; set; } = null!;
    public EventRole Role { get; set; }
    public EventObject Event { get; set; } = null!;
    public EventStaff(Person person, EventRole role, EventObject event_)
    {
        Person = person;
        Role = role;
        Event = event_;
    }
}