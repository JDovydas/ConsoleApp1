using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Carp : IAnimal, IFish, IComparable<Carp>
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

        public int CompareTo(Carp other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }
    }
}
