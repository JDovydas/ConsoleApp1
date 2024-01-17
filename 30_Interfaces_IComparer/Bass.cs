using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class Bass : IAnimal, IFish
    {
        public void Eat()
        {
            Console.WriteLine("The bass is eating");
        }

        public void Swim()
        {
            Console.WriteLine("The bass is swimming around))");
        }
    }
}
