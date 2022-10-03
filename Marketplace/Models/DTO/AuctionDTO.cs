using Marketplace.Common;

namespace Marketplace.Models.DTO;

public class AuctionDTO
{
    public int ItemId { get; set; }
    
    public int SaleId { get; set; }
    
    public string Name { get; set; }
    
    public MarketStatus Status { get; set; }
    
    public decimal Price { get; set; }

    public string CreatedDt { get; set; }
    
}