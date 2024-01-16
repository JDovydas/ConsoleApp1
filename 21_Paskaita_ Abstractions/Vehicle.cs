using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal abstract class Vehicle
    {
        public string Type { get; set; }
        public int WheelSize { get; set; }
        //public double EngineSize { get; set; }
        public string Make { get; set; }
        //public string FuelType { get; set; }

        public Vehicle(string type, int wheelSize, double engineSize, string make, string fuelType)
        {
            Type = type;
            WheelSize = wheelSize;
            //EngineSize = engineSize;
            Make = make;
            //FuelType = fuelType;

        }

        public Vehicle(string type, int wheelSize, string make)
        {
            WheelSize = wheelSize;
            Make = make;
            Type = type;
        }

        public abstract void Drive();

    }




}
