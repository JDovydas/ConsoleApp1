﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class AudiCar : Car
    {
        public bool IsXDrive { get; set; }
        public AudiCar(string model, int fuel, int maxFuelCapacity, bool isXDrive) : base(model, fuel, maxFuelCapacity)
        {
            //Model = model;
            //Fuel = fuel;
            //MaxFuelCapacity = maxFuelCapacity;
            IsXDrive = isXDrive;

        }

    }
}
