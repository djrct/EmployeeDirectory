using EmployeeDirectory.Api.Data.Entities;

namespace EmployeeDirectory.Api.Data;

public static class SeedData
{
    public static IEnumerable<Employee> Employees => new[]
    {
        new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Email = "john.smith@example.com",
            PhoneNumber = "555-1000",
            Department = "Engineering",
            Title = "Senior Software Engineer",
            Location = "Remote",
            HireDate = new DateTime(2021, 5, 10),
            IsActive = true
        },
        new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Doe",
            Email = "jane.doe@example.com",
            PhoneNumber = "555-2000",
            Department = "Human Resources",
            Title = "HR Manager",
            Location = "Hartford",
            HireDate = new DateTime(2019, 9, 1),
            IsActive = true
        }
    };
}
