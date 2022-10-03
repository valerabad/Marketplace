using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Marketplace.Models.Domain;

namespace Marketplace.Common;

public static class SaleGenerator
{
    static SaleGenerator()
    {
        (Faker as IFakerTInternal).FakerHub.IndexFaker++;
    }
    
    private static readonly Faker<Sale> Faker = new Faker<Sale>()
        .RuleFor(x => x.Id, f => f.IndexFaker)
        .RuleFor(x => x.Price, f => f.Finance.Amount())
        .RuleFor(x => x.Status, f => f.Random.Enum<MarketStatus>())
        .RuleFor(x => x.ItemId, f => f.Random.Int(min:51, max:61))
        .RuleFor(x => x.CreatedDt,  f => f.Date.Between(DateTime.MinValue, DateTime.MaxValue))
        .RuleFor(x => x.FinishedDt, f => f.Date.Between(DateTime.MinValue, DateTime.MaxValue))
        .RuleFor(x => x.Buyer, f => f.Name.FullName())
        .RuleFor(x => x.Seller, f => f.Company.CompanyName());
    
    public static Sale Generate() => Faker.Generate();
    
    public static IEnumerable<Sale> Generate(int count) => Faker.Generate(count);
}