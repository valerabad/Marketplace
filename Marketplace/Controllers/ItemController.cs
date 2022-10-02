using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Marketplace.Models.DTO;
using Marketplace.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace Marketplace.Controllers;

[ApiController]
//[ApiVersion("1.0")]
//[Route("api/v{version:apiVersion}/[controller]/[action]")]
[Route("api/[controller]/[action]")]
public class ItemController : Controller
{
    private readonly IItemRepository repo;
    private readonly IMapper mapper;
    
    public ItemController(IItemRepository repo, IMapper mapper)
    {
        this.repo = repo;
        this.mapper = mapper;
    }
    
    [HttpGet] 
    public async Task<IActionResult> GetAll()
    {
        var result = await repo.GetAll();

        var itemsDto = mapper.Map<List<ItemDTO>>(result);
        
        return Ok(itemsDto);
    }
    
    [HttpGet] 
    public IActionResult GetById([FromQuery] int id)
    {
        var result = repo.GetById(id);
        
        var itemsDto = mapper.Map<ItemDTO>(result);
        
        return Ok(itemsDto);
    }
}