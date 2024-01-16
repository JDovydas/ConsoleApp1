using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class Square
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void SetSide(int side)
        {
            Width = side;
            Height = side;
        }

        public void SetSide(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void PrintSides()
        {
            Console.WriteLine($"{Width} x {Height}");
        }
    }
}
