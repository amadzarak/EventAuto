using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class EventContext : DbContext
{
    public EventContext(DbContextOptions<EventContext> options)
        : base(options)
    {
    }

    public DbSet<Event> EventList { get; set; } = null!;
}