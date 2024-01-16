using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Dog : IAnimal, IMammal
    {
        public void Eat()
        {
            Console.WriteLine("The dog is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("The dog gave birth to a puppy");
        }
    }
}
