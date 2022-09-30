using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
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
        .RuleFor(x => x.ItemId, f => f.Random.Int(min:1, max:10))
        .RuleFor(x => x.CreatedDt, f => f.Date.ToString())
        .RuleFor(x => x.FinishedDt, f => f.Date.ToString())
        .RuleFor(x => x.Buyer, f => f.Name.FullName())
        .RuleFor(x => x.Seller, f => f.Company.CompanyName());
    
    public static Sale Generate() => Faker.Generate();
    
    public static IEnumerable<Sale> Generate(int count) => Faker.Generate(count);
}