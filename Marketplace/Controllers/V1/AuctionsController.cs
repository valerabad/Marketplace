using System.Linq;
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
    private readonly ISaleRepository saleRepository;
    private readonly IMapper mapper;
    
    public AuctionsController(ISaleRepository saleRepository, IMapper mapper)
    {
        this.saleRepository = saleRepository;
        this.mapper = mapper;
    }

    [MapToApiVersion("1.0")]
    [HttpGet("{id}")]
    public async Task<IActionResult> Index(int id)
    {
        var auction = await saleRepository.GetById(id);
        
        if (auction is null)
        {
            NotFound();
        }
        return Ok(auction);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetByFilter([FromQuery] AuctionFilter filter)
    {
        var auctions = await saleRepository.GetByFilter(filter);

        var auctionViewDto = auctions.Select(item => mapper.Map<AuctionViewDto>(item));

        return Ok(auctionViewDto);
    }
}