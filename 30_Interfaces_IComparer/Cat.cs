using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"The cat '{Name}'is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine($"The cat '{Name}' gave birth to a kitten");
        }
    }
}
