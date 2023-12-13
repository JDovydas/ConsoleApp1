using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Paskaita_Objects
{
    internal class School
    {

        public School(string name, string city)
        {
            Name = name;
            City = city;

        }

        public School(int numberOfStudents)
        {
            NumberOfStudents = numberOfStudents;
        }

        public string Name { get; set; }
        public string City { get; set; }

        public int NumberOfStudents { get; set; }
    }


}
