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
                //SaveUserToFile(users[userCardNumber]);
                Console.WriteLine("Registration successful.");
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Such card already exists");
                return false;

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
        //    using (StreamWriter writer = new StreamWriter("transfer_data.txt", true))
        //    {
        //        writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.FirstName},{cardHolder.LastName},{cardHolder.Password},{cardHolder.Balance}");
        //    }
        //}


        public static void SaveTransaction(string currentUser, decimal transactionAmount)
        {
            try
            {
                if (users.ContainsKey(currentUser))
                {
                    // Get the current user's card number
                    //string cardNumber = users[currentUser].CardNumber;

                    // Record the transaction in the user's bank account
                    users[currentUser].Card.RecordTransaction(transactionAmount);

                    // Save the transaction details to a text file
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\djuod\\source\\repos\\ConsoleApp1\\31_ATM\\transfer_data.txt", true))
                    {
                        writer.WriteLine($"{currentUser},{transactionAmount},{DateTime.Now}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the transaction: {ex.Message}");

            }
        }

    }
}
