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
    }
}