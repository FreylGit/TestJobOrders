using Microsoft.EntityFrameworkCore;
using TestJobOrders.Models;

namespace TestJobOrders.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
            .HasIndex(account => account.Number)
            .IsUnique();
            builder.Entity<Order>()
            .Property(account => account.Number)
            .HasDefaultValueSql("NEWID()");
        }
     
        public DbSet<Order> Orders { get; set; }
    }
}
