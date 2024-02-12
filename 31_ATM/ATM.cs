using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM
{
    public class ATM
    {
        public static Dictionary<string, CardHolder> users = new Dictionary<string, CardHolder>();

        private static int loginAttempts = 0;
        public static bool RegisterUser(string firstName, string lastName, string userCardNumber, string password)
        {
            if (!users.ContainsKey(userCardNumber))
            {
                users[userCardNumber] = new CardHolder(firstName, lastName, userCardNumber, password, 0);
                Console.WriteLine("Registration successful.");
                EraseThePreviousText();
                return true;
            }
            else
            {
                Console.WriteLine("Such card already exists");
                EraseThePreviousText();
                return false;
            }
        }

        public static bool LoginUser(string userCardNumber, string enteredPassword)
        {
            if (users.ContainsKey(userCardNumber) && users[userCardNumber].ValidatePassword(enteredPassword))
            {
                Console.WriteLine("Login successful!");
                EraseThePreviousText();
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
            users[currentUser].DisplayAccountInfo();
        }

        public static void SaveTransaction(string currentUser, decimal transactionAmount)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\31_ATM\\transfer_data.txt", true))
                {
                    writer.WriteLine($"{currentUser}, {transactionAmount},{DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        public static void EraseThePreviousText()
        {
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
