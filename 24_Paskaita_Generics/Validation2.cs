using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Paskaita_Generics
{
    internal class Validation2
    {
        public static void Validate<T>(T item)
        {
            if (item == null)
            {

                throw new ArgumentNullException(nameof(item), "item cannot be null");
                //Console.WriteLine($"{item} cannot be null");
            }
            else
            {
                Console.WriteLine($"{item} is not null");

            }
        }
    }
}




