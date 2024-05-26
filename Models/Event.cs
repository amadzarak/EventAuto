namespace EventAuto.Models;


public class EventObject
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime EventDate { get; set; }
    public bool RequireTickets { get; set; }
    public Venue EventVenue { get; set; } = null!;
    public AddressObject Address { get; set; } = null!;
    public Person? EventHost { get; set; }
    public List<Person> EventCoHosts { get; set; } = new List<Person>();


    public EventObject(string name, Venue venue)
    {
        Name = name;
        EventVenue = venue;
    }


    public void AddHost(Person person)
    {
        EventHost = person;
    }

    public void AddCoHost(Person person)
    {
        EventCoHosts.Add(person);
    }
    public void AssignVenue(Venue venue)
    {
        EventVenue = venue;

    }
    public void Print()
    {
        Console.WriteLine($"Event: {Name}");
    }

    public void PrintAddress()
    {
        EventVenue.PrintAddress();
    }
}

public class EventFeedback
{
    public EventObject Event { get; set; } = null!;
    public Person Person { get; set; } = null!;
    public string Feedback { get; set; } = null!;
    public int Rating { get; set; }
    public DateTime CreatedAt { get; set; }

    public EventFeedback(EventObject event_, Person person, string feedback, int rating)
    {
        Event = event_;
        Person = person;
        Feedback = feedback;
        Rating = rating;
        CreatedAt = DateTime.Now;
    }
}