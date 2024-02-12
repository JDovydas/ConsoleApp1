//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ATM_Draft2
//{
//    internal class BankAccount
//    {
//        private List<decimal> transactions = new List<decimal>();
//        public decimal Balance { get; private set; } = 0;
//        public string CardNumber { get; private set; }

//        public BankAccount(string cardNumber)
//        {
//            CardNumber = cardNumber;
//        }

//        public void Deposit(decimal amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//                transactions.Add(amount);
//            }
//        }

//        public bool Withdraw(decimal amount)
//        {
//            if (amount > 0 && amount <= 1000 && Balance >= amount)
//            {
//                Balance -= amount;
//                transactions.Add(-amount);
//                return true;
//            }
//            return false;
//        }

//        public List<decimal> GetTransactionHistory()
//        {
//            return transactions;
//        }
//    }

//}
