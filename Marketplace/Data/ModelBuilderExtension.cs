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
        ItemGenerator itemGenerator = new ItemGenerator();
        var fakeItems = itemGenerator.Generate(50000).ToList();
        builder.Entity<Item>().HasData(fakeItems);

        SaleGenerator saleGenerator = new SaleGenerator();
        var fakeSales = saleGenerator.Generate(50000);
        builder.Entity<Sale>().HasData(fakeSales);

    }
}