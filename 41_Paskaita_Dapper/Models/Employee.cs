using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Paskaita_Dapper.Models
{
    public class Employee
    {
        public string PersonalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StartDate { get; set; }
        public string BirthDate { get; set; }
        public string Position { get; set; }
        public string DepartmentName { get; set; }
        public int ProjectID { get; set; }
        public decimal Salary { get; set; }


    }
}
