using System.Threading.Tasks;
using AutoMapper;
using Marketplace.Models;
using Marketplace.Models.DTO;
using Marketplace.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AuctionsController : Controller
{
    private readonly IItemRepository itemRepository;
    private readonly IMapper mapper;
    
    public AuctionsController(IItemRepository itemRepository, IMapper mapper)
    {
        this.itemRepository = itemRepository;
        this.mapper = mapper;
    }

    [MapToApiVersion("1.0")]
    [HttpGet("{id}")]
    public async Task<IActionResult> Index(int id)
    {
        var item = await itemRepository.GetById(id);

        var result = mapper.Map<ItemDTO>(item);
        
        return Ok(result);
    }
    
    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetByFilter([FromQuery] AuctionFilter filter)
    // {
    //     var item = await itemRepository.GetByFilter(filter);
    //
    //     var result = mapper.Map<ItemDTO>(item);
    //     
    //     return Ok(result);
    // }
}