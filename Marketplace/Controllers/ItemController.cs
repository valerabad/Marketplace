using System.Linq;
using System.Threading.Tasks;
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
    private IItemRepository repo;
    public ItemController(IItemRepository repo)
    {
        this.repo = repo;
    }
    
    [HttpGet] 
    public IActionResult GetAll()
    {
        var result = repo.GetAll().ToList();
        
        return Ok(result);
    }
    
    [HttpGet] 
    public IActionResult GetById([FromQuery] int id)
    {
        var result = repo.GetById(id);
        return Ok(result);
    }
}