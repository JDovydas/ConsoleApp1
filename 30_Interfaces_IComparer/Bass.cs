using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class Bass : IAnimal, IFish
    {

        public string Name { get; set; }

        public Bass(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"The bass '{Name}' is eating");
        }

        public void Swim()
        {
            Console.WriteLine($"The bass '{Name}' is swimming around))");
        }
    }
}
