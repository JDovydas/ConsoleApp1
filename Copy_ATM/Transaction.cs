using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    internal class Transaction
    {
        public string CardNumber { get; set; }
        public string TransactionId { get; set; } //Guid?
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string TransactionType { get; set; }

        public Transaction(string cardNumber, string transactionId, decimal amount, string transactionType)
        {
            CardNumber = cardNumber;
            TransactionId = transactionId;
            Amount = amount;
            TransactionType = transactionType;
            //kviesti irasymui i faila metoda
        }

        ///sukurti write to file metoda



    }
}
