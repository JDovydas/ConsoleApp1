using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class BmwCar : Car
    {

        public bool IsXDrive { get; set; }

        //public override string Model { get; set; }

        public BmwCar(string model, int fuel, int maxFuelCapacity, bool isXDrive) : base(model, fuel, maxFuelCapacity)
        {
            //Model = model;
            //Fuel = fuel;
            IsXDrive = isXDrive;
            //MaxFuelCapacity = maxFuelCapacity;


            //this.IsXDrive = true;
        }


    }
}
