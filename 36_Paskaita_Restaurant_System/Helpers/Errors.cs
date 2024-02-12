using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System.Helpers
{
    internal class Errors
    {
        public static void ReturnError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid option.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
