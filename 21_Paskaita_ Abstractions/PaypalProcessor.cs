using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal class PaypalProcessor : PaymentProcessor
    {

        public string Email { get; set; }

        public override void Process()
        {
            Console.WriteLine($"Processing credit card {Email} with amount {Amount}");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("*");
                Thread.Sleep(500);
            }
        }
    }
}
