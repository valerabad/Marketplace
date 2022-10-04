using System.Linq;
using System.Threading.Tasks;
using Marketplace.Models;
using Marketplace.Models.DTO;

namespace Marketplace.Repositories;

public interface ISaleRepository
{
    Task<IQueryable<AuctionDTO>> GetByFilter(AuctionFilter filter);
}