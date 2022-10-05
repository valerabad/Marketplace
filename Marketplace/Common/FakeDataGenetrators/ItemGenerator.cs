using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Bogus;
using Bogus.DataSets;
using Marketplace.Models.Domain;

namespace Marketplace.Common;

public class ItemGenerator
{
    public ItemGenerator()
    {
        (Faker as IFakerTInternal).FakerHub.IndexFaker++;
    }

    private readonly Faker<Item> Faker = new Faker<Item>()
        .RuleFor(x => x.Id, f => f.IndexFaker)
        .RuleFor(x => x.Name, f => f.Commerce.ProductName())
        .RuleFor(x => x.Description, f => f.Lorem.Sentence())
        .RuleFor(x => x.Metadata, f => f.Lorem.Word());

    public Item Generate() => Faker.Generate();
    
    public IEnumerable<Item> Generate(int count) => Faker.Generate(count);
}