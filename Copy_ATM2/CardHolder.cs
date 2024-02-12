using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class CardHolder : Card
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Card Card { get; set; }
        //public string CardNumber { get; set; }
        //public string Password { get; set; }

        public CardHolder(string firstName, string lastName, string cardNumber, string password, decimal balance) : base(cardNumber, password, balance)
        {
            FirstName = firstName;
            LastName = lastName;
            //CardNumber = cardNumber;
            //Password = password;
            Balance = balance;
            Card = new Card(cardNumber);
        }

        public bool ValidatePassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name: {FirstName}");
            Console.WriteLine($"Surname: {LastName}");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Balance: {Card.Balance}");
        }

        public static void SaveUserToFile(CardHolder cardHolder)
        {
            using (StreamWriter writer = new StreamWriter("transfer_data.txt", true))
            {
                writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.FirstName},{cardHolder.LastName},{cardHolder.Password},{cardHolder.Balance}");
            }
        }
    }
}

