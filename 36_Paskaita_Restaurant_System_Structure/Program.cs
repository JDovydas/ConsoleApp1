using _36_Paskaita_Restaurant_System_Structure.Models;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace _36_Paskaita_Restaurant_System_Structure
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


