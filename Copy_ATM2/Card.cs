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

        public List<decimal> transactions = new List<decimal>();



        public decimal Balance { get; set; }

        private decimal DailyCashWithdrawalLimit = 1000;

        private decimal DailyTransactionLimit = 10;

        private List<Transaction> transactionsHistory = new List<Transaction>();

        public Card(string cardNumber, string password, decimal balance)
        {
            CardNumber = cardNumber;
            Password = password;
            Balance = balance;
        }

        public Card(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public Card(decimal Balance)
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
                Console.WriteLine("Transaction failed. Please check your balance, withdrawal amount or transaction limits.");/// Should you use try Catch built error?
                return false;
            }

            Balance -= amount;
            transactions.Add(-amount);
            Console.WriteLine($"Withdrawal of EUR {amount} successful.");
            Console.WriteLine($"Remaining balance: EUR {Balance}");
            //new Transaction(CardNumber, amount)
            return true;

        }
        public List<decimal> GetTransactionHistory()
        {
            return transactions;
        }

        public void RecordTransaction(decimal amount)
        {

            transactionsHistory.Add(new Transaction(amount, DateTime.Now));
        }

    }
}
