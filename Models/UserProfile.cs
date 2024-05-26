namespace EventAuto.Models;

public enum SexOptions
{
    Male,
    Female
}
public enum SexualOrientationOptions
{
    Straight,
    Gay,
    Lesbian,
    Bisexual,
    Transgender
}

public enum RelationshipStatusOptions
{
    Single,
    InARelationship,
    Engaged,
    Married,
    Divorced,
    Widowed,
    Complicated,
    Open

}

public class Profile
{
    public long Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public string FullName => $"{FirstName} {MiddleName} {LastName}";
    public SexOptions Sex { get; set; }
    public DateOnly BirthDate { get; set; }
    public bool Active { get; set; }
    public string? DisplayName { get; set; }
    public SexualOrientationOptions SexualOrientation { get; set; }
    public RelationshipStatusOptions RelationshipStatus { get; set; }
    public string Occupation { get; set; } = null!;
    public string OpenEndedResponse { get; set; } = null!;
    public List<ProfileConversationStarters> ConversationStarters { get; set; } = null!;
    public ProfileContactInfo ContactInfo { get; set; } = null!;
}

public class ProfileContactInfo
{
    public User user { get; set; } = null!;
    public string phone { get; set; } = null!;
    public string email { get; set; } = null!;
    public string facebook { get; set; } = null!;
    public string instagram { get; set; } = null!;
    public string x { get; set; } = null!;
    public string tiktok { get; set; } = null!;
    public string linkedin { get; set; } = null!;
    public string snapchat { get; set; } = null!;
    public int zip_code { get; set; }

}

public class ProfileConversationStarters
{
    // The reason I have this as a seperate object, is because in the database, I want all the fields to be seperate rows,
    // for ease of data-mining.
    public User user { get; set; } = null!;
    public string description { get; set; } = null!;


}
