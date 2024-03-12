using _41_Paskaita_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Paskaita_Dapper.Repository
{
    internal interface IEmployeeRepository
    {
        public void AddEmployee(Employee employee);
        public IEnumerable<Employee> GetEmployeesByName(string firstName);
        public IEnumerable<Employee> GetAllEmployees(int salary);
        public IEnumerable<Employee> GetAllYeongerEmployees(string birthdate);

        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(int personalCode);


    }
}
