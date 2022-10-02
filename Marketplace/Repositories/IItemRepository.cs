using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Models.Domain;

namespace Marketplace.Repositories;

public interface IItemRepository
{
    Task<IEnumerable> GetAll();
    Item GetById(int id);
}