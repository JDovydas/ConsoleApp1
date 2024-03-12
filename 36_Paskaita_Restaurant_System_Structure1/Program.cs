using _36_Paskaita_Restaurant_System_Structure1.Models;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace _36_Paskaita_Restaurant_System_Structure1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaitressUi waitress = new WaitressUi();
            waitress.Run();

        }
    }
}


