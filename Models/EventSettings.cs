namespace EventAuto.Models;

public class EventSettings
{
    // Date and Time Information
    public string StartDate { get; set; } = null!;
    public string StartTime { get; set; } = null!;
    public string TimeZone { get; set; } = null!;
    public string? EndTime { get; set; }
    public string? EndDate { get; set; }
    public bool? IsMultiDay { get; set; }
    public bool IsRecurring { get; set; }
    public string? RecurrencePattern { get; set; }
    public string? RecurrenceDescription { get; set; }
    public string? RecurrenceException { get; set; }
    public string? RecurrenceEndDate { get; set; }
    public bool IsAllDay { get; set; }

    // Access Control and Privacy Settings
    public bool IsPrivate { get; set; }
    public bool IsVisible { get; set; }
    public bool IsPasswordProtected { get; set; }
    public string? Password { get; set; }

    // Detailed Pricing and Ticketing Settings
    public bool IsFree { get; set; }
    public bool IsPaid { get; set; }
    public bool IsDonation { get; set; }
    public bool IsTicketed { get; set; }

    // Event Status
    public bool IsCancelled { get; set; }
    public bool IsPostponed { get; set; }
    public bool IsRescheduled { get; set; }
    public bool IsSoldOut { get; set; }


    public bool IsVirtual { get; set; }
    public bool IsPhysical { get; set; }
    public bool IsHybrid { get; set; }
    public bool IsOnline { get; set; }
    public bool IsOffline { get; set; }
    public bool IsInPerson { get; set; }
    public bool IsRemote { get; set; }
    public bool IsPublic { get; set; }
    public bool IsDraft { get; set; }
    public bool IsPublished { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsArchived { get; set; }
    public bool IsCancelledByHost { get; set; }
    public bool IsCancelledByOrganizer { get; set; }
    public bool IsCancelledByAttendee { get; set; }
    public bool IsCancelledBySystem { get; set; }
    public bool IsPostponedByHost { get; set; }
    public bool IsPostponedByOrganizer { get; set; }
    public bool IsPostponedByAttendee { get; set; }
    public bool IsPostponedBySystem { get; set; }
    public bool IsRescheduledByHost
    {
        get; set;
    }
}
