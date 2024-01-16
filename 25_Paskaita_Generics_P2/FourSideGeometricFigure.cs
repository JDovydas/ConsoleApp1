using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Paskaita_Generics_P2
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public FourSideGeometricFigure(string name, int @base, int height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public double GetArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Base: {Base}, Height: {Height}";
        }


    }





}
