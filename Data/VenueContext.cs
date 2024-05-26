using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class VenueContext : DbContext
{
    public VenueContext(DbContextOptions<VenueContext> options)
        : base(options)
    {
    }

    public DbSet<Venue> VenueList { get; set; } = null!;
}