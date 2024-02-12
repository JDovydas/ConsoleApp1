using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string Password { get; set; }
        public BankAccount Account { get; set; }

        public Card(string cardNumber, string password, BankAccount account)
        {
            CardNumber = cardNumber;
            Password = password;
            Account = account;
        }
    }
}
