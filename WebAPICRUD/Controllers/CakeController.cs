using WebAPICRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dot6.API.Crud.Controllers;

[ApiController]
[Route("[controller]")]
public class CakeController : ControllerBase
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public CakeController(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        //https://youtu.be/A6dPEYbGH0k?t=842
        var cakes = await _myWorldDbContext.Cake.ToListAsync();
        return Ok(cakes);
    }

}