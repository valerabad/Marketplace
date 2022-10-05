using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Common;
using Marketplace.Data;
using Marketplace.Models;
using Marketplace.Models.DTO;
using Marketplace.Paging;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Repositories;

public class SalesRepository : ISaleRepository
{
    private readonly MarketDbContext marketDbContext;
    
    public SalesRepository(MarketDbContext marketDbContext)
    {
        this.marketDbContext = marketDbContext;
    }
    public async Task<IEnumerable> GetAll()
    {
        var result = await marketDbContext.Sales.ToListAsync();
        return result;
    }

    public async Task<AuctionDto> GetById(int id)
    {
        var auction = await GetAllQuery().ToListAsync();

        var result = auction.FirstOrDefault(x => x.Id == id);

        return result;
    }

    public async Task<IQueryable<AuctionDto>> GetByFilter(AuctionFilter filter)
    {
        var sales = GetAllQuery();

        if (!string.IsNullOrEmpty(filter.SortKey) && filter.SortKey == "Price")
        {
            switch (filter.SortOrder)
            {
                case SortOrder.Desc:
                    sales = sales.OrderByDescending(x => x.Price);
                    break;
                default:
                    sales = sales.OrderBy(x => x.Price);
                    break;
            }
        }
        
        if (filter?.SortKey == "CreatedDt")
        {
            switch (filter.SortOrder)
            {
                case SortOrder.Desc:
                    sales = sales.OrderByDescending(x => x.CreatedDt);
                    break;
                default:
                    sales = sales.OrderBy(x => x.CreatedDt);
                    break;
            }
        }

        if (!string.IsNullOrEmpty(filter.SearchString))
        {
            sales = sales.Where(n => 
                n.Name.Contains(filter.SearchString, StringComparison.CurrentCultureIgnoreCase));
        }

        if (filter.Status != 0)
        {
            sales = sales.Where(x => x.Status == filter.Status);
        }
        

        if (!string.IsNullOrEmpty(filter.Seller))
        {
            sales = sales.Where(x => x.Seller == filter.Seller);
        }

        // Paging
        var result = PaginatedList<AuctionDto>.Create(
            sales, 
            filter.From,
            filter.Limit);

        return result.AsQueryable();
    }
    
    private IQueryable<AuctionDto> GetAllQuery()
    {
        return marketDbContext.Sales.Join(marketDbContext.Items,
            s => s.ItemId,
            i => i.Id,
            (s, i) => new AuctionDto()
            {
                Id = s.Id,
                Name = i.Name,
                Price = s.Price,
                Status = s.Status,
                Seller = s.Seller,
                CreatedDt = s.CreatedDt
            });
    }
}