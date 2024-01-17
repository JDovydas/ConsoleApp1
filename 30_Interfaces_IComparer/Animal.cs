using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    public class Animal : IComparer<Animal>
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        //public int CompareTo(Animal other)
        //{
        //    return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        //}

        public int Compare(Animal x, Animal y)
        {
            //throw new NotImplementedException();

            return string.Compare(x.Name, y.Name);

        }

    }
}
