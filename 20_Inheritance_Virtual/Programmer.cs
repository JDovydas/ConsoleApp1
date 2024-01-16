using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Programmer : Employee
    {
        public Programmer(string name, double salary, string programmingLanguage) : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public void GetProgrammerDescription()
        {
            Console.WriteLine($"Programmer name: {Name}");
            Console.WriteLine($"Programmer salary: {Salary}");
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
        public string ProgrammingLanguage { get; set; }
    }
}
