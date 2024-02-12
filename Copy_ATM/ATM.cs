using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class ATM
    {
        public static Dictionary<string, CardHolder> users = new Dictionary<string, CardHolder>();

        private static int loginAttempts = 0;

        public static void RegisterUser(string firstName, string lastName, string userCardNumber, string password)
        {
            if (!users.ContainsKey(userCardNumber))
            {
                users[userCardNumber] = new CardHolder(firstName, lastName, userCardNumber, password);
                Console.WriteLine("Registration successful.");
            }
            else
            {
                Console.WriteLine("Card number is already registered.");
            }
        }

        public static bool LoginUser(string userCardNumber, string enteredPassword)
        {
            if (users.ContainsKey(userCardNumber) && users[userCardNumber].ValidatePassword(enteredPassword))
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect card number or password. Please try again.");
                loginAttempts++;
                if (loginAttempts == 3)
                {
                    Console.WriteLine("Too many incorrect attempts. Application disabled.");
                    Environment.Exit(0);
                }
            }
            return false;
        }


        public static void ShowAccountInfo(string currentUser)
        {
            if (users.ContainsKey(currentUser))
            {
                users[currentUser].DisplayAccountInfo();
            }
        }

        //private static void SaveUserToFile(CardHolder cardHolder)
        //{
        //    using (StreamWriter writer = new StreamWriter("user_data.txt", true))
        //    {
        //        writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.Name},{cardHolder.Surname},{cardHolder.Password},{cardHolder.Balance}");
        //    }
        //}



    }
}
