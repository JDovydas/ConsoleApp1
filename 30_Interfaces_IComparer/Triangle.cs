using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Triangle : IPolygon, IComparable<Triangle>
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public int CompareTo(Triangle other)
        {
            return GetArea().CompareTo(other.GetArea());

        }

    }
}
