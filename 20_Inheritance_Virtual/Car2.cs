using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Car2 : Transport
    {
        public override string MeasureSpeed()
        {
            return "Measuring your speed IN ANOTHER WAY???";
        }
    }
}
