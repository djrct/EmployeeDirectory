using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Api.Services
{
    public interface IEmployeeService
    {
        Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync();

        Task<EmployeeDto?> GetEmployeeAsync(int id);
    }
}
