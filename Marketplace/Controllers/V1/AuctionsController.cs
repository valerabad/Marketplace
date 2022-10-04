using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Marketplace.Models;
using Marketplace.Models.DTO;
using Marketplace.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using ILogger = Serilog.ILogger;

namespace Marketplace.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AuctionsController : Controller
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<AuctionsController> _logger;
    
    
    public AuctionsController(ISaleRepository saleRepository, IMapper mapper, ILogger<AuctionsController> logger)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
        _logger = logger;
    }

    [MapToApiVersion("1.0")]
    [HttpGet("{id}")]
    public async Task<IActionResult> Index(int id)
    {
        _logger.LogDebug("Find element by id has been started");
        var auction = await _saleRepository.GetById(id);
        
        if (auction is null)
        {
            _logger.LogWarning($"There is no auction (sale) in DB with Id: - {id}");
            return NotFound($"There is no auction (sale) in DB with Id: - {id}");
        }

        _logger.LogInformation($"Successfully retrieved element by id: {id}");
        
        return Ok(auction);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetByFilter([FromQuery] AuctionFilter filter)
    {
        try
        {
            _logger.LogDebug("Find elements by filter has been started");
            var auctions = await _saleRepository.GetByFilter(filter);

            var auctionViewDto = auctions.Select(item => _mapper.Map<AuctionViewDto>(item));

            _logger.LogInformation($"Successfully retrieved elements by filter");
            
            return Ok(auctionViewDto);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Exception occured: {ex.Message}");
            return BadRequest();
        }
       
    }
}