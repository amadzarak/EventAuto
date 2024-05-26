using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class ProfileContext : DbContext
{
    public ProfileContext(DbContextOptions<ProfileContext> options)
        : base(options)
    {
    }

    public DbSet<Profile> Profiles { get; set; } = null!;
}