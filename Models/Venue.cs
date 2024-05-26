namespace EventAuto.Models;
using System.ComponentModel.DataAnnotations;

public enum VenueType
{
    Indoor,
    Outdoor
}

public enum LeadStatus
{
    Prospect,
    Client
}
public class Venue : IOrganization
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public AddressObject Address { get; set; } = null!;
    public VenueType Type { get; set; }
    public List<Person> KeyPeople { get; set; } = new List<Person>();
    public LeadStatus Status { get; set; }

    public void updateStatus(LeadStatus status)
    {
        Status = status;
    }

    public void AddPerson(Person person)
    {
        KeyPeople.Add(person);
    }

    public void GetKeyPersonnel()
    {
        foreach (Person person in KeyPeople)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
    public void RemovePerson(Person person)
    {
        KeyPeople.Remove(person);
    }

    public void GetHostedEvents()
    {
        Console.WriteLine("Events hosted at this venue:");
    }

    public Venue() { }
    public Venue(string name, AddressObject address)
    {
        Name = name;
        Address = address;
    }

    public void Print()
    {
        Console.WriteLine($"Venue: {Name}");
    }

    public void PrintAddress()
    {
        Address.Print();
    }
}