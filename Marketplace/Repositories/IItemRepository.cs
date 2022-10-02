using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Marketplace.Models.Domain;

namespace Marketplace.Repositories;

public interface IItemRepository
{
    IQueryable<Item> GetAll();
    Item GetById(int id);
}