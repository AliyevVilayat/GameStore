using GamingStore.MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GamingStore.MVC.Contexts;

public class GamingStoreDbContext : DbContext
{
    public GamingStoreDbContext(DbContextOptions<GamingStoreDbContext> options) : base(options)
    {

    }
    public DbSet<Game> Games { get; set; }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entityEntries = ChangeTracker.Entries<AuditableEntity>();
        foreach (var entityEntry in entityEntries)
        {
            _ = entityEntry.State switch
            {
                EntityState.Added => entityEntry.Entity.CreatedAt = DateTime.Now,
                EntityState.Modified => entityEntry.Entity.UpdatedAt = DateTime.Now,
                _ => DateTime.Now,
            };
        }

        return base.SaveChangesAsync(cancellationToken);
    }

}
