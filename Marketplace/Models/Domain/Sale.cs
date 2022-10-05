using System;
using System.Collections.Generic;
using Marketplace.Common;

namespace Marketplace.Models.Domain
{
    public class Sale
    {
        public int Id { get; set; }
        
        public int ItemId { get; set; }

        public MarketStatus Status { get; set; }
        
        public string Seller { get; set; }
        
        public decimal Price { get; set; }
        
        public string Buyer { get; set; }
        
        public DateTime CreatedDt { get; set; }
        
        public DateTime FinishedDt { get; set; }
    }
}