using Marketplace.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Marketplace.Common;

namespace Marketplace.Data;

public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder builder)
    {
        var fakeItems = ItemGenerator.Generate(50).ToList();
        builder.Entity<Item>().HasData(fakeItems);
        
        var fakeSales = SaleGenerator.Generate(20);
        builder.Entity<Sale>().HasData(fakeSales);

    }
}