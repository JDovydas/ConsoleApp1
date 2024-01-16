using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Bike : Vehicle
    {



        public Bike(int speed) //: base(speed) 
        {
            Speed = speed;
        }
        public void GetBike()
        {
            Console.WriteLine($"Bike's speed is {Speed}");
        }

    }
}
