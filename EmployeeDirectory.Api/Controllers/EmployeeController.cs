using EmployeeDirectory.Api.Data;
using EmployeeDirectory.Api.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeDbContext _context;

    public EmployeeController(EmployeeDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = await _context.Employees
            .OrderBy(e => e.LastName)
            .ThenBy(e => e.FirstName)
            .ToListAsync();

        return Ok(employees.Select(e => e.ToDto()));
    }
}
