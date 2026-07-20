using EmployeeDirectory.Api.Data.Entities;
using EmployeeDirectory.Shared.DTOs;

namespace EmployeeDirectory.Api.Mappings
{
    public static class EmployeeMappings
    {
        public static EmployeeDto ToDto(this Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                Department = employee.Department,
                Title = employee.Title,
                Location = employee.Location,
                HireDate = employee.HireDate,
                IsActive = employee.IsActive
            };
        }
    }
}
