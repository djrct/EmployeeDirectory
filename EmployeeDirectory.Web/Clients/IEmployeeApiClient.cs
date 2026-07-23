using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Web.Clients;

public interface IEmployeeApiClient
{
    Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync(CancellationToken cancellationToken = default);

    Task<EmployeeDto?> GetEmployeeAsync(int id, CancellationToken cancellationToken = default);

    Task<EmployeeDto> CreateEmployeeAsync(CreateEmployeeDto employee, CancellationToken cancellationToken = default);
}
