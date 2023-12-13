using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Paskaita_Objects
{
    internal class PersonTest
    {
        public PersonTest()
        {

        }

        public PersonTest(string name)
        {
            Name = name;
        }
        public PersonTest(string name, string gender, DateTime birthday) : this(name)
        {
            Gender = gender;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }


    }
}
