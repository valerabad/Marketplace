using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Marketplace.Models.Domain;

namespace Marketplace.Common;

public class SaleGenerator
{
    public SaleGenerator()
    {
        (Faker as IFakerTInternal).FakerHub.IndexFaker++;
    }
    
    private  readonly Faker<Sale> Faker = new Faker<Sale>()
        .RuleFor(x => x.Id, f => f.IndexFaker)
        .RuleFor(x => x.Price, f => f.Finance.Amount())
        .RuleFor(x => x.Status, f => f.Random.Enum<MarketStatus>())
        .RuleFor(x => x.ItemId, f => f.Random.Int(min:1, max:25000))
        .RuleFor(x => x.CreatedDt,  f => f.Date.Recent())
        .RuleFor(x => x.FinishedDt, f => f.Date.Recent())
        .RuleFor(x => x.Buyer, f => f.Name.FullName())
        .RuleFor(x => x.Seller, f => f.Company.CompanyName());
    
    public Sale Generate() => Faker.Generate();
    
    public IEnumerable<Sale> Generate(int count) => Faker.Generate(count);
}