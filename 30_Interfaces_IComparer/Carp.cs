using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class Carp : IAnimal, IFish
    {
        public string Name { get; set; }

        public Carp(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"Carp '{Name}' is eating");

        }

        public void Swim()
        {
            Console.WriteLine($"Carp '{Name}' is swimming around))");
        }
    }
}
