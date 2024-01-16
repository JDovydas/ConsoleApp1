using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class Bicycle : Vehicle
    {
        public Bicycle(string type, int wheelSize, string make) : base(type, wheelSize, make)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"This is a healthy transport");
        }

    }
}
