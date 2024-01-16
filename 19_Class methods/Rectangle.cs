using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return (Width * Height);

        }

        public int CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

    }
}
