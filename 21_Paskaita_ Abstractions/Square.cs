using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class Square : GeometricShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Square(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double GetArea()
        {
            double area = (SideA * SideB);
            return area;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
