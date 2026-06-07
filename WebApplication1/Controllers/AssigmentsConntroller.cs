using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AssigmentsController : ControllerBase
{
    private readonly _2019sbdContext _context;

    public AssigmentsController(_2019sbdContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Assignment>>> GetJson()
    {
        var res = await _context.Assignments.ToListAsync();
        return Ok(res);
    }
}