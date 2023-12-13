using _18_Paskaita_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_Paskaita_Objects
{


    internal class Person
    {

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(int height)
        {
            Height = height;

        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }



}


//public Person() //Public properties Uppercase
//{

//}

////public Person (string name, int age)
////{
////    Name = name;
////    Age = age;
////}

//public string Name { get; set; } //Public properties Uppercase
//public int Age { get; set; } //Public properties Uppercase