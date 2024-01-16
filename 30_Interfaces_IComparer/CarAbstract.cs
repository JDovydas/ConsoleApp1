using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30_Interfaces_IComparer
{
    public abstract class CarAbstract : IVehiclePart2
    {

        public abstract string Model { get; set; } // public starts with Capital letter, private - _model (underscore + lowecase);

        public abstract int Fuel { get; set; }

        public abstract int MaxFuelCapacity { get; set; } //can be overrwitten

        public CarAbstract(string model, int fuel, int maxFuelCapacity)
        {
            Model = model;
            Fuel = fuel;
            MaxFuelCapacity = maxFuelCapacity;
        }




        public void Drive()
        {
            if (Fuel == 0)
            {
                Console.WriteLine("No fuel, you cannot drive");
            }
            else

                Console.WriteLine($"You have fuel - vehicle is ready to drive, remaining fuel: {Fuel -= 1}");

        }

        public void Refuel(int fuel)
        {
            if (Fuel + fuel > MaxFuelCapacity)
            {
                Console.WriteLine("You cannot refuel");
                Console.WriteLine($"The available amount you can refuel is {MaxFuelCapacity - Fuel} liters");
            }
            else if (Fuel + fuel == MaxFuelCapacity)
            {
                Console.WriteLine($"The tanks is full now ({MaxFuelCapacity}) liters");

            }
            else if (fuel < 0)
            {
                Console.WriteLine("You cannot refuel a negative amount of fuel");
            }
            else
            {
                Console.WriteLine($"Refueled - you have {Fuel + fuel} liters in the tank");
            }
        }


    }
}
