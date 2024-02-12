using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class User // Move to CarDHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Card Card { get; set; }
        public User(string firstName, string lastName, Card card)
        {
            FirstName = firstName;
            LastName = lastName;
            Card = card;

        }

        //Methots -> withdraw amount, deposit amount, show last tramsactopms, balance;
    }
}
