using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class Carp : IAnimal, IFish
    {
        public void Eat()
        {
            Console.WriteLine("Carp is eating");

        }

        public void Swim()
        {
            Console.WriteLine("The carp is swimming around))");
        }
    }
}
