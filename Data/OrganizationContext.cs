using Microsoft.EntityFrameworkCore;

namespace EventAuto.Models;

public class OrganizationContext : DbContext
{
    public OrganizationContext(DbContextOptions<OrganizationContext> options)
        : base(options)
    {
    }

    public DbSet<Organization> OrganizationsList { get; set; } = null!;
}