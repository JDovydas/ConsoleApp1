//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ATM_Draft2
//{
//    internal class CardHolder
//    {
//        public string Name { get; private set; }
//        public string Surname { get; private set; }
//        public string CardNumber { get; private set; }
//        private string Password { get; set; }
//        private BankAccount Account { get; set; }

//        public CardHolder(string name, string surname, string cardNumber, string password)
//        {
//            Name = name;
//            Surname = surname;
//            CardNumber = cardNumber;
//            Password = password;
//            Account = new BankAccount(cardNumber);
//        }

//        public bool ValidatePassword(string inputPassword)
//        {
//            return Password == inputPassword;
//        }

//        public void DisplayAccountInfo()
//        {
//            Console.WriteLine($"Name: {Name}");
//            Console.WriteLine($"Surname: {Surname}");
//            Console.WriteLine($"Card Number: {CardNumber}");
//            Console.WriteLine($"Balance: {Account.Balance:C}");
//        }
//    }
//}
