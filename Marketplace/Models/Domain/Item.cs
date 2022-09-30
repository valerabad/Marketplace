using System;
using System.Collections.Generic;

namespace Marketplace.Models.Domain
{
    public class Item
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Metadata { get; set; }
        
        public IEnumerable<Sale> Sales { get; set; } 
        
    }
}