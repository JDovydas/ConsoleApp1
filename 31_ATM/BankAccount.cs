using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _31_ATM
{
    internal class BankAccount
    {
        public string CardNumber { get; set; }
        public string Password { get; set; }

        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
