using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Paskaita__Accessibility
{
    internal class Student : Person
    {
        private string studentId = Guid.NewGuid().ToString();
        /*
        public Student(string name, int age) : base(name, age)
        {

        }
        public void Print()
        {
            Console.WriteLine(Name);
        }

        public string GetStudentId()
        {
            return studentId;
        }
        */
    }
}
