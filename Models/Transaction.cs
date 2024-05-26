namespace EventAuto.Models;
public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = null!;
    public Transaction(decimal amount, string description)
    {
        Amount = amount;
        Description = description;
    }
}

public class UserTransaction : Transaction
{
    public User User { get; set; } = null!;
    public UserTransaction(decimal amount, string description, User user) : base(amount, description)
    {
        User = user;
    }
}

public enum TicketTransactionType
{
    Purchase,
    Refund,
    Transfer,
    Cancel,
    Compensated,
    Free,
    Won
}
public class TicketTransaction : Transaction
{
    public Ticket Ticket { get; set; } = null!;
    public TicketTransactionType Type { get; set; }
    public User User { get; set; } = null!;
    public TicketTransaction(decimal amount, string description, Ticket ticket, User user) : base(amount, description)
    {
        Ticket = ticket;
        User = user;

    }
}