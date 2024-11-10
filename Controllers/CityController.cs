using MafraaHajeeraApi.Doamin;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MafraaHajeeraApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace MafraaHajeeraApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public CityController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _dbContext.Cities.Select(c => new IndexDto()
        {
            Id = c.Id,
            Name = c.Name,
        }).ToListAsync());
    }
}
