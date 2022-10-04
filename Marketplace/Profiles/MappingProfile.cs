using AutoMapper;
using Marketplace.Models.Domain;
using Marketplace.Models.DTO;

namespace Marketplace.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Item, ItemDTO>().ReverseMap();

        CreateMap<AuctionDto, AuctionViewDto>();
    }
}