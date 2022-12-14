using System;
using Marketplace.Common;

namespace Marketplace.Models.DTO;

public class AuctionViewDto
{
    public string Name { get; set; }
    
    public MarketStatus Status { get; set; }
    
    public decimal Price { get; set; }
    
    public string Seller { get; set; }

    public DateTime CreatedDt { get; set; }
}