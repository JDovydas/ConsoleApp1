using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Paskaita_Generics_P2
{
    internal class Generator<T>
    {
        public void Show(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
