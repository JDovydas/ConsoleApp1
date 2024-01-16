using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class Bus : Vehicle
    {
        public Bus(string type, int wheelSize, double engineSize, string make, string fuelType) : base(type, wheelSize, engineSize, make, fuelType)
        {

        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
