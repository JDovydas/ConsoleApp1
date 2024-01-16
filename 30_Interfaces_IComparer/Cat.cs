using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Cat : IAnimal, IMammal
    {
        public void Eat()
        {
            Console.WriteLine("The cat is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("The cat gave birth to a kitten");
        }
    }
}
