using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class CardHolder //: Card
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public Card Card { get; set; }

        public CardHolder(string firstName, string lastName, string cardNumber, string password, decimal balance) //: base(cardNumber, password, balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Card = new Card(cardNumber);
        }

        public bool ValidatePassword(string inputPassword)
        {
            return Card.Password == inputPassword;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name: {FirstName}");
            Console.WriteLine($"Surname: {LastName}");
            Console.WriteLine($"Card Number: {Card.CardNumber}");
            Console.WriteLine($"Balance: {Card.Balance}");
            Console.WriteLine($"Daily Cash Withdrawal Limit : {Card.DailyCashWithdrawalLimit}");
            Console.WriteLine($"Daily Transaction Limit : {Card.DailyTransactionLimit}");
        }

    }
}

