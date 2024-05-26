namespace EventAuto.Models;

public enum VenueRole
{
    Owner,
    Manager,
    Staff,
    Bar,
    Waiter,
    Security,
}
public class VenueStaff
{
    public Person Person { get; set; } = null!;
    public VenueRole Role { get; set; }
    public Venue Venue { get; set; } = null!;
    public VenueStaff(Person person, VenueRole role, Venue venue)
    {
        Person = person;
        Role = role;
        Venue = venue;
    }
}