using _36_Part2_Restaurant_Solution_Structured.Services;
using _36_Paskaita_Restaurant_System.Models;
using _36_Paskaita_Restaurant_System.Repository;
using Paskaita_36_Another_Saved_Version.Repositories.Interfaces;
using Paskaita_36_Another_Saved_Version.Services.Interfaces;
using Paskaita_36_Another_Saved_Version.UI;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace _36_Paskaita_Restaurant_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Welcome to the restourant app");

            //List<Product> products = new List<Product>();

            //List<Table> tables = new List<Table>();

            //WaitressUi waitress = new WaitressUi(products, tables);

            //waitress.Run();

            IOrderRepository orderRepository = new OrderRepository(); // sukuriam nauja repositorija, kuri bus perduodama per Interface
            IOrderService orderService = new OrderService(orderRepository);
            ConsoleUi consoleUi = new ConsoleUi(orderService);

            //consoleUi.Run();
        }
    }
}






//SmtpClient smtpClient = new SmtpClient();
////smtpClient.Port port = smtpClient.Port;

//smtpClient.Send(new MailMessage());