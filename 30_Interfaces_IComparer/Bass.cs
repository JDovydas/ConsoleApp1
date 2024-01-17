using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Bass : IAnimal, IFish, IComparable<Bass>
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

        public int CompareTo(Bass other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }

    }
}
