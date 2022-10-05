using System.Linq;
using System.Threading.Tasks;
using Marketplace.Models;
using Marketplace.Models.DTO;

namespace Marketplace.Repositories;

public interface ISaleRepository
{
    Task<IQueryable<AuctionDto>> GetByFilter(AuctionFilter filter);
    Task<AuctionDto> GetById(int id);
}