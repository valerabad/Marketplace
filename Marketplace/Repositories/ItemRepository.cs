using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
      public IQueryable<Item> GetAll()
      {
            return marketDbContext.Items
                  //.Include(x=>x.Sales)
                  .Where(x=>x.Id < 50);
      }

      public Item GetById(int id)
      {
            return marketDbContext.Items.First(x => x.Id == id);
      }
}