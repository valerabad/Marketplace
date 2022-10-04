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
        var auction = await marketDbContext.Sales.Join(marketDbContext.Items,
            s => s.ItemId,
            i => i.Id,
            (i, s) => new AuctionDto()
            {
                Id = s.Id,
                Name = s.Name,
                Price = i.Price,
                Status = i.Status,
                Seller = i.Seller,
                CreatedDt = i.CreatedDt
            }).ToListAsync();

        var result = auction.FirstOrDefault(x => x.Id == id);

        return result;
    }

    public async Task<IQueryable<AuctionDto>> GetByFilter(AuctionFilter filter)
    {
        var sales = marketDbContext.Sales.Join(marketDbContext.Items,
            s => s.ItemId,
            i => i.Id,
            (i, s) => new AuctionDto()
            {
                Id = s.Id,
                Name = s.Name,
                Price = i.Price,
                Status = i.Status,
                Seller = i.Seller,
                CreatedDt = i.CreatedDt
            }).ToList();
        
        if (!string.IsNullOrEmpty(filter.SortKey) && filter.SortKey == "Price")
        {
            switch (filter.SortOrder)
            {
                case SortOrder.Desc:
                    sales = sales.OrderByDescending(x => x.Price).ToList();
                    break;
                default:
                    break;
            }
        }
        
        if (filter?.SortKey == "CreatedDt")
        {
            sales = sales.OrderByDescending(x => x.CreatedDt).ToList();
            switch (filter.SortOrder)
            {
                case SortOrder.Desc:
                    sales = sales.OrderByDescending(x => x.CreatedDt).ToList();
                    break;
                default:
                    break;
            }
        }

        if (!string.IsNullOrEmpty(filter.SearchString))
        {
            // change to name
            sales = sales.Where(n => 
                n.Name.Contains(filter.SearchString, StringComparison.CurrentCultureIgnoreCase))
                .ToList();
        }

        sales = sales.Where(x => x.Status == filter.Status).ToList();

        if (!string.IsNullOrEmpty(filter.Seller))
        {
            sales = sales.Where(x => x.Seller == filter.Seller).ToList();
        }
        
        // Paging
        int pageSize = filter.Limit;
        int pageNumber = filter.From;
        sales = PaginatedList<AuctionDto>.Create(sales.AsQueryable(), pageNumber, pageSize);

        return sales.AsQueryable();
    }
}