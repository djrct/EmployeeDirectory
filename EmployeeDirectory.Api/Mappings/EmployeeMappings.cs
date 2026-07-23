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

        public static Employee ToEntity(this CreateEmployeeDto employee)
        {
            return new Employee
            {
                FirstName = employee.FirstName.Trim(),
                LastName = employee.LastName.Trim(),
                Email = employee.Email.Trim(),
                PhoneNumber = employee.PhoneNumber.Trim(),
                Department = employee.Department.Trim(),
                Title = employee.Title.Trim(),
                Location = employee.Location.Trim(),
                HireDate = employee.HireDate,
                IsActive = employee.IsActive
            };
        }
    }
}
