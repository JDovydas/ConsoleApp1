using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Paskaita_Generics_P2
{
    internal class Type<T1, T2>
    {
        
        
        public void GetType(T1 input)
        {
            Console.WriteLine($"The type of input is {typeof(T1)}");
        }


        public void GetType(T2 input)
        {
            Console.WriteLine($"The type of input is {typeof(T2)}");

        }

        public void GetType ()
        {
            Console.WriteLine($"The type of input one is {typeof(T1)}");
            Console.WriteLine($"The type of input two is {typeof(T2)}");
        }

    }


}
