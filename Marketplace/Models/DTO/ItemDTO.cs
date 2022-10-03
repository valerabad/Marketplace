using System.Collections.Generic;
using Marketplace.Common;
using Marketplace.Models.Domain;

namespace Marketplace.Models.DTO;

public class ItemDTO
{
    public int Id { get; set; }
        
    public string Name { get; set; }
        
    public string Description { get; set; }
        
    public string Metadata { get; set; }
    
    public IEnumerable<Sale> Sales { get; set; }
    
    public MarketStatus Status { get; set; }
        
    public string Seller { get; set; }
        
    public decimal Price { get; set; }
        
    public string Buyer { get; set; }
        
    public string CreatedDt { get; set; }
        
    public string FinishedDt { get; set; }
}