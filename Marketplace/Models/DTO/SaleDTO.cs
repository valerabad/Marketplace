using Marketplace.Common;

namespace Marketplace.Models.DTO;

public class SaleDTO
{
    public int Id { get; set; }
        
    public int ItemId { get; set; }

    public MarketStatus Status { get; set; }
        
    public string Seller { get; set; }
        
    public decimal Price { get; set; }
        
    public string Buyer { get; set; }
        
    public string CreatedDt { get; set; }
        
    public string FinishedDt { get; set; }
}