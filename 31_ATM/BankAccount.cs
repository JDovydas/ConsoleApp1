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
        //public string CardNumber { get; set; }
        //public string Password { get; set; }

        public decimal Balance { get; set; }
        public List<string> Transactions { get; set; }

        public BankAccount(decimal balance, List<string> transactions)
        {
            Balance = balance;
            Transactions = transactions;
        }

        public BankAccount()
        {
            Balance = 0;
            Transactions = new List<string>();
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add($"Deposit: +{amount}");
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }

            Balance -= amount;
            Transactions.Add($"Withdrawal: -{amount}");
            return true;

        }
        public List<string> GetTransactions()
        {
            return Transactions;
        }


    }
}
