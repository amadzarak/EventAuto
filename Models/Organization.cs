namespace EventAuto.Models;


interface IOrganization
{
    void GetKeyPersonnel();
    void AddPerson(Person person);
    void RemovePerson(Person person);

}

public class Organization
{
    public string? OrganizationName { get; set; }
    public string? OrganizationDescription { get; set; }
    public List<Venue> VenuesList { get; set; } = new List<Venue>();
}
