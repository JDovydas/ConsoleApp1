using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class Hexagon : IPolygon, IComparable<Hexagon>
    {

        public double Side { get; set; }

        public double GetArea()
        {
            return Side;
        }

        public int CompareTo(Hexagon other)
        {
            return GetArea().CompareTo(other.GetArea());
        }

    }
}
