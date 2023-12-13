using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Paskaita_Objects
{
    internal class Hamster
    {
        public Hamster()

        {

        }

        public Hamster(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }


    }
}
