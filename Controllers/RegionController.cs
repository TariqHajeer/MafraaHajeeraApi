using MafraaHajeeraApi.Doamin;
using MafraaHajeeraApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MafraaHajeeraApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RegionController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public RegionController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _dbContext.Regions.Select(c => new RegionDto()
        {
            Id = c.Id,
            Name = c.Name,
            CityName = c.City.Name
        }).ToListAsync());
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromForm] string name,[FromForm] int cityId)
    {

        _dbContext.Regions.Add(new Region()
        {
            Name = name,
            CityId =cityId,
        });
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var nationality = await _dbContext.Regions.FindAsync(id);
        _dbContext.Remove(nationality);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
}

