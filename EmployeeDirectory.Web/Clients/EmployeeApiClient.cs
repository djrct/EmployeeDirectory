using System.Net.Http.Json;
using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Web.Clients;

public sealed class EmployeeApiClient(HttpClient httpClient)
    : IEmployeeApiClient
{
    public async Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync(
        CancellationToken cancellationToken = default)
    {
        var employees = await httpClient.GetFromJsonAsync<List<EmployeeDto>>(
            "api/employee",
            cancellationToken);

        return employees ?? [];
    }

    public async Task<EmployeeDto?> GetEmployeeAsync(
        int id,
        CancellationToken cancellationToken = default)
    {
        var employee = await httpClient.GetFromJsonAsync<EmployeeDto>(
            $"api/employee/{id}",
            cancellationToken);
        return employee;
    }
}
