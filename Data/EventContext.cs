using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class EventContext : DbContext
{
    public EventContext(DbContextOptions<EventContext> options)
        : base(options)
    {
    }

    public DbSet<EventObject> EventList { get; set; } = null!;
}