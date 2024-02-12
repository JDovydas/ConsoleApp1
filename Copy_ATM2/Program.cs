using System;
using System.ComponentModel.Design;

namespace _31_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //private static Dictionary<string, CardHolder> users = new Dictionary<string, CardHolder>();

            var currentUser = "";

            string input1 = "";
            do
            {
                if (string.IsNullOrEmpty(currentUser))
                {

                    Console.WriteLine("Welcome to the Automated Teller Machine");
                    Console.WriteLine("Please choose the action: ");

                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");

                    input1 = Console.ReadLine();

                    Console.Clear();

                    switch (input1)
                    {
                        case "1":
                            Console.WriteLine("Register User");
                            Console.Write("Please enter your name: ");
                            string clientName = Console.ReadLine();
                            Console.Write("Please enter your surname: ");
                            string clientSurname = Console.ReadLine();
                            Console.Write("Please enter your card number: "); ////specify length
                            string cardNumber = Console.ReadLine();
                            Console.Write("Please enter your password: ");
                            string password = Console.ReadLine();
                            if (ATM.RegisterUser(clientName, clientSurname, cardNumber, password) == true)
                            { currentUser = cardNumber; }
                            else { currentUser = ""; }
                            //ATM.RegisterUser(clientName, clientSurname, cardNumber, password);
                            break;
                        case "2":
                            Console.WriteLine("LoginUser");
                            Console.Write("Please enter your card number: ");
                            string userCardNumber = Console.ReadLine();
                            Console.Write("Please enter your password: ");
                            string userPassword = Console.ReadLine();

                            if (ATM.LoginUser(userCardNumber, userPassword))
                            {
                                currentUser = userCardNumber;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Wrong choice, try again");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Main Menu: ");
                    Console.WriteLine("Please choose the action: ");
                    Console.WriteLine("1. Withdraw money");
                    Console.WriteLine("2. Deposit money");
                    Console.WriteLine("3. Show available balance");
                    Console.WriteLine("4. List the historical transactions");
                    Console.WriteLine("5. Change your PIN");
                    Console.WriteLine("6. Return to Login");
                    Console.WriteLine("7. Exit");

                    var input2 = Console.ReadLine();

                    switch (input2)
                    {
                        case "1":
                            decimal withdrawalAmount;
                            Console.Write("Enter withdrawal amount: ");
                            //ATM.WithdrawMoney();
                            if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
                            {
                                if (withdrawalAmount <= 0)
                                {
                                    Console.WriteLine("Invalid amount. Please enter a positive number.");
                                }
                                else
                                {
                                    if (ATM.users.ContainsKey(currentUser))
                                    {
                                        if (ATM.users[currentUser].Card.Withdraw(withdrawalAmount))
                                        {
                                            //Console.WriteLine($"Withdrawal of EUR {withdrawalAmount} successful.");
                                            //ATM.users[currentUser].Card.RecordTransaction(currentUser, -withdrawalAmount); // Record withdrawal as negative
                                            //ATM.users[currentUser].SaveUserToFile(); // Record withdrawal as negative
                                            ATM.SaveTransaction(currentUser, -withdrawalAmount);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Withdrawal of EUR {withdrawalAmount} failed.");
                                            Console.WriteLine($"The balance is insufficient, your current balance is EUR {ATM.users[currentUser].Card.Balance}");


                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Please enter a valid number.");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Deposit Money");
                            Console.Write("Enter deposit amount: ");
                            decimal depositAmount;
                            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                            {
                                if (ATM.users.ContainsKey(currentUser))
                                {
                                    ATM.users[currentUser].Card.Deposit(depositAmount);
                                    Console.WriteLine($"Deposit of EUR {depositAmount} successful.");
                                    //ATM.users[currentUser].Card.RecordTransaction(currentUser, depositAmount);
                                    Console.WriteLine("Save the client data in TXT");
                                    ATM.SaveTransaction(currentUser, depositAmount);
                                    //ATM.SaveUserToFile(CardHolder as);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        case "3":
                            Console.WriteLine("ShowAvailableBalance");
                            ATM.ShowAccountInfo(currentUser);
                            break;
                        case "4":
                            Console.WriteLine("List historical Transactions");
                            List<decimal> transactions = ATM.users[currentUser].Card.GetTransactionHistory();
                            var index = 1;
                            foreach (decimal transaction in transactions)
                            {

                                if (transaction > 0)
                                {
                                    Console.WriteLine($"{index}.) Deposited: EUR {transaction}");
                                    index++;
                                }
                                else
                                {
                                    Console.WriteLine($"{index}.) Withdrawn: EUR {-transaction}");
                                    index++;
                                }
                            }
                            break;
                        case "5":
                            Console.WriteLine("Change PIN");
                            Console.Write("Enter new PIN: ");
                            string newPin = Console.ReadLine();
                            ATM.users[currentUser].Password = newPin;
                            Console.WriteLine("PIN changed successfully.");
                            break;
                        case "6":
                            Console.WriteLine("6. Return to Login");
                            Thread.Sleep(2000);
                            Console.Clear();
                            currentUser = "";
                            break;
                        case "7":
                            Console.WriteLine("Exit");
                            Environment.Exit(0);
                            break;
                        case "8":
                            Console.WriteLine("Save to file");
                            break;
                        //Console.WriteLine("Save the client date in TXT");
                        //ATM.SaveUserToFile(CardHolder as);
                        default:
                            Console.WriteLine("Such option does not exist, choose again");
                            break;



                    }

                }

            }
            while (input1 != "3");
            Console.WriteLine("Goodbye");



        }

    }
}