using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Paskaita__Accessibility
{
    public class Person
    {
        private string name;
        protected string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        /*
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
        */

        protected void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }



    }

}
