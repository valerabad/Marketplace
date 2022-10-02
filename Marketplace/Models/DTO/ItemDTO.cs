using System.Collections.Generic;
using Marketplace.Models.Domain;

namespace Marketplace.Models.DTO;

public class ItemDTO
{
    public int Id { get; set; }
        
    public string Name { get; set; }
        
    public string Description { get; set; }
        
    public string Metadata { get; set; }
    
    public IEnumerable<Sale> Sales { get; set; }
}