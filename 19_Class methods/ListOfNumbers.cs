using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{

    internal class ListOfNumbers

    {
        private List<int> numbers = new List<int>();

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public void PrintNumbers()
        {
            Console.WriteLine("Numbers in the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }



}
