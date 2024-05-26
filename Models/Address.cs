namespace EventAuto.Models;
using System.ComponentModel.DataAnnotations;
public enum AddressUseOptions
{
    Home,
    Work,
    Temporary,
    Old,
    Billing
}
public enum AddressTypeOptions
{
    Postal,
    Physical,
    Both
}

public class AddressObject
{
    [Key]
    public int Id { get; set; }
    public AddressUseOptions AddressUse { get; set; }
    public AddressTypeOptions AddressType { get; set; }
    public string AddressLine1 { get; set; } = null!;
    public string AddressLine2 { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Zip { get; set; } = null!;

    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    public AddressObject(string addressLine1, string addressLine2, string city, string state, string zip)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        State = state;
        Zip = zip;
    }

    public void GetCoordinates()
    {

        Latitude = 0;
        Longitude = 0;
        Console.WriteLine($"Coordinates: {Latitude}, {Longitude}");

    }
    public void Print()
    {
        Console.WriteLine($"Address: {AddressLine1} {AddressLine2}, {City}, {State} {Zip}");
    }
}
