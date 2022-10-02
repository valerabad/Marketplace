using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Data;
using Marketplace.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Repositories;

public class ItemRepository : IItemRepository
{
      private readonly MarketDbContext marketDbContext;
      
      public ItemRepository(MarketDbContext marketDbContext)
      {
            this.marketDbContext = marketDbContext;
      } 
      public async Task<IEnumerable>GetAll()
      {
            return await marketDbContext.Items
                  .Include(x=>x.Sales)
                  .ToListAsync();
            //.Where(x=>x.Id < 50).ToListAsync();
      }

      public Item GetById(int id)
      {
            return marketDbContext.Items.First(x => x.Id == id);
      }
}