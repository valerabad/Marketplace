using System;
using Marketplace.Common;

namespace Marketplace.Models;

public class AuctionFilter : OffsetFilter
{
    public MarketStatus Status { get; set; }
        
    public string Seller { get; set; }

    public string SearchString { get; set; }
    
    public string SortKey { get; set; }

    public SortOrder SortOrder { get; set; } = SortOrder.Asc;
}