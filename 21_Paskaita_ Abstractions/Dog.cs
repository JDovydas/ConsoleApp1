using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class Dog : Animal
    {
        //public Dog(string noise) : base(noise) 
        //{

        //}
        public override void MakeNoise()
        {
            Console.WriteLine("AU AU AU");
        }
    }
}
