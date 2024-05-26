namespace EventAuto.Models;

// Honestly, I'm still not sure how to make use of this model to its best.
public class Person
{
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Email { get; set; } = null!;

    public Person(string firstname, string middlename, string lastname, string phone, string email)
    {
        FirstName = firstname;
        MiddleName = middlename;
        LastName = lastname;
        Phone = phone;
        Email = email;
    }

}


