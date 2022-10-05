using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Marketplace.Common;
using Marketplace.Data;
using Marketplace.Models;
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

      public async Task<IEnumerable> GetAll()
      {
            return await marketDbContext.Items
                  .Include(x => x.Sales)
                  .ToListAsync();
      }

      public async Task<Item> GetById(int id)
      {
            return await marketDbContext.Items.FirstAsync(x => x.Id == id);
      }

      public async Task<IEnumerable<Item>> GetByFilter(AuctionFilter filter)
      {
            var allItems = marketDbContext.Items.OrderBy(x => x.Name).ToList();

            return allItems;
      }
}