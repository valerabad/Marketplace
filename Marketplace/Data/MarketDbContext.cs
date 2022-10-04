using Marketplace.Data.Configuration;
using Marketplace.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Data
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
        
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Sale>()
                .Property(b => b.Price).HasColumnType("money");
            
            builder.ApplyConfiguration(new ItemConfiguration());
            
            builder.Seed();
        }
    }
}