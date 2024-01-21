using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Quadrilateral : IPolygon, IComparable<Quadrilateral>
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double GetArea()
        {
            return Side1 * Side2;
        }

        public int CompareTo(Quadrilateral other)
        {
            return GetArea().CompareTo(other.GetArea());
        }
    }
}
