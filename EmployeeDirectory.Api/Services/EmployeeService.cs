using EmployeeDirectory.Api.Mappings;
using EmployeeDirectory.Api.Repositories;
using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IReadOnlyList<EmployeeDto>> GetEmployeesAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return employees
                .Select(employee => employee.ToDto())
                .ToList();
        }

        public async Task<EmployeeDto?> GetEmployeeAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);

            if (employee is null)
            {
                return null;
            }

            return employee.ToDto();
        }

        public async Task<EmployeeDto> CreateEmployeeAsync(CreateEmployeeDto employeeDto)
        {
            var employee = employeeDto.ToEntity();

            var createdEmployee = await _employeeRepository.AddAsync(employee);

            return createdEmployee.ToDto();
        }
    }
}
