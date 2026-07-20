using EmployeeDirectory.Api.Data;
using EmployeeDirectory.Api.Mappings;
using EmployeeDirectory.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync()
        {
            var employees = await _context.Employees
                .AsNoTracking()
                .OrderBy(employee => employee.LastName)
                .ThenBy(employee => employee.FirstName)
                .Select(employee => employee.ToDto())
                .ToListAsync();
            return employees;
        }
    }
}
