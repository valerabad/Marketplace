using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Marketplace.Common;
using Marketplace.Models;
using Marketplace.Models.Domain;

namespace Marketplace.Repositories;

public interface IItemRepository
{
    Task<IEnumerable> GetAll();

    Task<Item> GetById(int id);
    
    Task<IEnumerable<Item>> GetByFilter(AuctionFilter filter);
}