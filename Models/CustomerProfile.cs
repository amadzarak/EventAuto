namespace EventAuto.Models;


public enum EducationLevels
{
    None,
    Elementary,
    HighSchool,
    College,
    PostGraduate
}

public enum FamilyStatus
{
    Single,
    Married,
    Divorced,
    Widowed
}
public class DemographicProfile
{
    public int Age { get; set; }
    public SexOptions Sex { get; set; }
    public string JobTitle { get; set; } = null!;
    public double Income { get; set; }
    public EducationLevels Education { get; set; }
    public FamilyStatus Family { get; set; }
}

public class PsychographicProfile
{
    public string Lifestyle { get; set; } = null!;
    public string Goals { get; set; } = null!;
    public string Pains { get; set; } = null!;
    public string Habits { get; set; } = null!;
    public string Personality { get; set; } = null!;
    public string Interests { get; set; } = null!;
    public string Opinions { get; set; } = null!;
    public string Values { get; set; } = null!;
}

public class BehavioralProfile
{
    public string Engagement { get; set; } = null!;
    public string ReadinessToBuy { get; set; } = null!;
    public string ProduceUsage { get; set; } = null!;
    public string Satisfaction { get; set; } = null!;
    public string AccountAge { get; set; } = null!;
    public string PurchaseHistory { get; set; } = null!;
    public string PurchaseFrequency { get; set; } = null!;
    public string PurchasePreferences { get; set; } = null!;
    public string PurchaseMethod { get; set; } = null!;
    public string PurchaseLocation { get; set; } = null!;
    public string PurchaseTime { get; set; } = null!;
    public string PurchaseAmount { get; set; } = null!;
    public bool AttentionRequired { get; set; }
}

public class GeographicProfile
{
    public string Country { get; set; } = null!;
    public string State { get; set; } = null!;
    public string City { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string Region { get; set; } = null!;

}

public class CustomerProfile
{
    public User User { get; set; } = null!;
    public DemographicProfile Demographic { get; set; } = null!;
    public PsychographicProfile Psychographic { get; set; } = null!;
    public BehavioralProfile Behavioral { get; set; } = null!;
    public GeographicProfile Geographic { get; set; } = null!;

    public void CreatePersona()
    {
        // Create a persona based on the profile
        System.Console.WriteLine("Title(s)");
        System.Console.WriteLine("Age Range");
        System.Console.WriteLine("Education Level");
        System.Console.WriteLine("Income Level");
        System.Console.WriteLine("How will they use the service");
        System.Console.WriteLine("Best marketing channel to reach them");
    }
}
