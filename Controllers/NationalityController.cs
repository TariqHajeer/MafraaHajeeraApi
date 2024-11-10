using MafraaHajeeraApi.Doamin;
using MafraaHajeeraApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MafraaHajeeraApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NationalityController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;
    public NationalityController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _dbContext.Nationalities.Select(c => new IndexDto()
        {
            Id = c.Id,
            Name = c.Name,
        }).ToListAsync());
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromForm] string name)
    {
        _dbContext.Nationalities.Add(new Nationality()
        {
            Name = name
        });
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var nationality=await _dbContext.Nationalities.FindAsync(id);
        _dbContext.Remove(nationality);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
}

