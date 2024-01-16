using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Car : Vehicle
    {
        //public Car(int speed) ///: base(speed)
        //{
        //    Speed = speed;

        //}

        public void GetSpeed()
        {
            Console.WriteLine($"Car's speed is {Speed}");
        }







    }
}
