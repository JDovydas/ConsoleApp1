using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    public class Values
    {
        public static void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine($"Value 1 ({typeof(T1)}): {value1}, {value1.GetType()}");
            Console.WriteLine($"Value 2 ({typeof(T2)}): {value2}, {value2.GetType()}");
        }
    }
}
