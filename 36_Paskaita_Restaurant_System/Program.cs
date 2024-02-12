using _36_Paskaita_Restaurant_System.Models;
using MailKit;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace _36_Paskaita_Restaurant_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Product> products = new List<Product>();

            //List<Table> tables = new List<Table>();

            //WaitressUi waitress = new WaitressUi(products, tables);

            //waitress.Run();


            WaitressUi waitress = new WaitressUi();
            waitress.Run();

        }
    }
}






//SmtpClient smtpClient = new SmtpClient();
////smtpClient.Port port = smtpClient.Port;

//smtpClient.Send(new MailMessage());