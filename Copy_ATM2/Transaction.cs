using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _31_ATM
{
    internal class Transaction
    {
        //public string CardNumber { get; set; }
        ////public string TransactionId { get; set; } //Guid?
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } //= DateTime.Now;
        //public string TransactionType { get; set; }

        public Transaction(decimal amount, DateTime timeStamp)
        {
            Amount = amount;
            TimeStamp = timeStamp;
            //kviesti irasymui i faila metoda
        }

        //public Transaction(decimal amount, DateTime date)
        //{
        //    Amount = amount;
        //    TimeStamp = DateTime.Now;
        //}

        ///sukurti write to file metoda
        private static void SaveTransferInfoToFile(CardHolder cardHolder)
        {
            using (StreamWriter writer = new StreamWriter("transfer_data.txt", true))
            {
                writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.FirstName},{cardHolder.LastName},{cardHolder.transactions} {DateTime.Now}");
            }
        }


    }
}
