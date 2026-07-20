using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDirectory.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "FirstName", "HireDate", "IsActive", "LastName", "Location", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, "Engineering", "john.smith@example.com", "John", new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Smith", "Remote", "555-1000", "Senior Software Engineer" },
                    { 2, "Human Resources", "jane.doe@example.com", "Jane", new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Doe", "Hartford", "555-2000", "HR Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
