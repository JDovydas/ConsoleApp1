using _36_Paskaita_Restaurant_System.Models;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace _36_Part2_Restaurant_Solution_Structured
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the restourant app");

            List<Product> products = new List<Product>();

            List<Table> tables = new List<Table>();

            WaitressUi waitress = new WaitressUi(products, tables);

            waitress.Run();

        }
    }
}


