using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow meow meow");
        }
    }
}
