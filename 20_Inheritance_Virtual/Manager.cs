using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Manager : Employee
    {
        public int Empoyees { get; set; }

        public Manager(string name, double salary, int employees) : base (name, salary)
        {
            Empoyees = employees;
        
        }
    }
}
