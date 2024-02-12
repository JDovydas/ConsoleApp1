using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _31_ATM
{
    public class BankAccount // Change to Card
    //atskiras failas transakcijoms / user
    {
        public List<decimal> transactions = new List<decimal>();
        public decimal Balance { get; set; }

        private int DailyCashWithdrawalLimit = 1000;

        private int DailyTransactionLimit = 10;

        //public Card Card { get; set; }
        public string CardNumber { get; set; } //eliminate Card as class or change cardnumber -> card

        public BankAccount(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public BankAccount(decimal Balance)
        {
            Balance = Balance;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            transactions.Add(amount);
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > Balance || amount > DailyCashWithdrawalLimit || transactions.Count > DailyTransactionLimit)
            {
                Console.WriteLine("Transaction failed. Please check withdrawal amount or transaction limits.");/// Should you use try Catch built error?
                return false;
            }

            Balance -= amount;
            transactions.Add(-amount);
            Console.WriteLine($"Remaining balance: EUR {Balance}");
            //new Transaction(CardNumber, amount)
            return true;

        }
        public List<decimal> GetTransactionHistory()
        {
            return transactions;
        }

    }
}
