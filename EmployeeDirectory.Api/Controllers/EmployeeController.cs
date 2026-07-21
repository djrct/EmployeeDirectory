using EmployeeDirectory.Api.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = await _employeeService.GetEmployeesAsync();

        return Ok(employees);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEmployee(int id)
    {
        var employee = await _employeeService.GetEmployeeAsync(id);

        if (employee is null)
        {
            return NotFound();
        }

        return Ok(employee);
    }
}
