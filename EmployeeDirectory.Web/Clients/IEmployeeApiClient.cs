using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Web.Clients;

public interface IEmployeeApiClient
{
    Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync(
        CancellationToken cancellationToken = default);
}
