using _41_Paskaita_Dapper.Models;
using _41_Paskaita_Dapper.Repository;

namespace _41_Paskaita_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=NewDatabase;Trusted_Connection=True";

            IEmployeeRepository employeeService = new EmployeeRepository(connectionString);


            //employeeService.AddEmployee(new Employee { PersonalCode = "99999999", FirstName = "Vardenis", LastName = "Pavardenis", StartDate = "2020-01-01", BirthDate = "2000-01-01", Position = "Tester", DepartmentName = "Testing", ProjectID = 1, Salary = 2000 });

            //var employees = employeeService.GetAllEmployees(1000);

            var employeeByName = employeeService.GetEmployeesByName("Vardenis");

            var employeeByDepartment = employeeService.GetEmployeesByName("Petras");

            var getAllYeongerEmployees = employeeService.GetAllYeongerEmployees("1999-01-01");

            var getAllYeongerEmployees2 = employeeService.GetAllYeongerEmployees("1988-01-01");



            //employeeService.UpdateEmployee(new Employee { PersonalCode = newEmployeeId, FirstName = "Updated Name", LastName = "Updated Last Name" });

            //employeeService.DeleteEmployee(newEmployeeId);
        }
    }
}
