using System.ComponentModel.DataAnnotations;

namespace EventAuto.Models;
public class Ticket
{
    [Key]
    public long Id { get; set; }
    public EventObject TicketEvent { get; set; } = null!;
    public User TicketHolder { get; set; } = null!;
    public bool Purchased { get; set; }
    public string TicketType { get; set; } = null!;
    public string TicketStatus { get; set; } = null!;
    public string TicketNumber { get; set; } = null!;
    public string TicketPrice { get; set; } = null!;
    public string TicketDescription { get; set; } = null!;
    public string TicketDate { get; set; } = null!;
    public string TicketTime { get; set; } = null!;
    public bool QuantityRestriction { get; set; }
    public int Quantity { get; set; }

}

public class EventCheckIn
{
    public EventObject Event { get; set; } = null!;
    public User User { get; set; } = null!;
    public Ticket Ticket { get; set; } = null!;
    public DateTime CheckInTime { get; set; }
    public string CheckInLocation { get; set; } = null!;
    public bool CheckedIn { get; set; }
    public bool CheckedOut { get; set; }
}
