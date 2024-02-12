using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System_Structure.Helpers
{
    public class ConcoleClear
    {
        public static void ClearView()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress any button to continue");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Clear()
        {
            Console.Clear();

        }

    }

}
