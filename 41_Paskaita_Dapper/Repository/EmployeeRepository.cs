using _41_Paskaita_Dapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Paskaita_Dapper.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Connection => new SqlConnection(_connectionString);

        public void AddEmployee(Employee employee)
        {
            var sql = "INSERT INTO Employee (PersonalCode, FirstName, LastName, StartDate, BirthDate, Position, DepartmentName, ProjectID, Salary) VALUES (@PersonalCode, @FirstName, @LastName, @StartDate, @BirthDate, @Position, @DepartmentName, @ProjectID, @Salary);";
            //" SELECT CAST(SCOPE_IDENTITY() as int);";

            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(sql, employee);
                //var id = dbConnection.QuerySingle<int>(sql, employee);
            }
        }

        public IEnumerable<Employee> GetEmployeesByName(string firstName)
        {
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Employee>("sp_getEmployeesByName", new { filter = firstName }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(string firstName)
        {
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Employee>("sp_getEmployeeByDepartment", new { filter = firstName }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Employee> GetAllYeongerEmployees(string birthdate)
        {
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Employee>("sp_getEmployeeBornFromDate", new { birthdate = birthdate }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Employee> GetAllEmployees(int salary)
        {
            var sql = "SELECT * FROM Employee WHERE Salary > @Salary;";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Employee>(sql, new { Salary = salary }).ToList();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            var sql = "UPDATE Employee SET PersonalCode = @PersonalCode, FirstName = @FirstName, LastName = @LastName, StartDate = @StartDate, BirthDate = @BirthDate, Position = @Position, DepartmentName = @DepartmentName, ProjectID = @ProjectID , Salary = @Salary";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(sql, employee);
            }
        }

        public void DeleteEmployee(int personalCode)
        {
            var sql = "DELETE FROM Employee WHERE PersonalCode = @PersonalCode";
            using (var dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(sql, new { PersonalCode = personalCode });
            }
        }






    }

}
