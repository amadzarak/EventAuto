using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class TicketContext : DbContext
{
    public TicketContext(DbContextOptions<TicketContext> options)
        : base(options)
    {
    }

    public DbSet<Ticket> Tickets { get; set; } = null!;
}