using EmployeeDirectory.Api.Data.Entities;

namespace EmployeeDirectory.Api.Repositories;

public interface IEmployeeRepository
{
    Task<IReadOnlyList<Employee>> GetAllAsync();

    Task<Employee?> GetByIdAsync(int id);

    Task<Employee> AddAsync(Employee employee);
}
