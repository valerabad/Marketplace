using System;
using Marketplace.Common;

namespace Marketplace.Models.DTO;

public class AuctionDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public MarketStatus Status { get; set; }
    
    public decimal Price { get; set; }
    
    public string Seller { get; set; }

    public DateTime CreatedDt { get; set; }
    
}