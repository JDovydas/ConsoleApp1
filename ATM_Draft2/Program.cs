//namespace ATM_Draft2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            {
//                var currentUser = "";
//                string input1 = "";

//                do
//                {
//                    if (string.IsNullOrEmpty(currentUser))
//                    {
//                        Console.WriteLine("Welcome to the Automated Teller Machine");
//                        Console.WriteLine("Please choose the action: ");
//                        Console.WriteLine("1. Register");
//                        Console.WriteLine("2. Login");
//                        Console.WriteLine("3. Exit");

//                        input1 = Console.ReadLine();
//                        Console.Clear();

//                        switch (input1)
//                        {
//                            case "1":
//                                Console.WriteLine("Register User");
//                                Console.Write("Please enter your name: ");
//                                string clientName = Console.ReadLine();
//                                Console.Write("Please enter your surname: ");
//                                string clientSurname = Console.ReadLine();
//                                Console.Write("Please enter your card number: ");
//                                string cardNumber = Console.ReadLine();
//                                Console.Write("Please enter your password: ");
//                                string password = Console.ReadLine();

//                                ATM.RegisterUser(clientName, clientSurname, cardNumber, password);
//                                currentUser = cardNumber;
//                                break;
//                            case "2":
//                                Console.WriteLine("Login User");
//                                Console.Write("Please enter your card number: ");
//                                string userCardNumber = Console.ReadLine();
//                                Console.Write("Please enter your password: ");
//                                string userPassword = Console.ReadLine();

//                                if (ATM.LoginUser(userCardNumber, userPassword))
//                                {
//                                    currentUser = userCardNumber;
//                                }
//                                break;
//                            case "3":
//                                Console.WriteLine("Exit");
//                                break;
//                            default:
//                                Console.WriteLine("Wrong choice, try again");
//                                break;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Main Menu: ");
//                        Console.WriteLine("Please choose the action: ");
//                        Console.WriteLine("1. Withdraw money");
//                        Console.WriteLine("2. Deposit money");
//                        Console.WriteLine("3. Show available balance");
//                        Console.WriteLine("4. List the historical transactions");
//                        Console.WriteLine("5. Change your PIN");
//                        Console.WriteLine("6. Return to Login");
//                        Console.WriteLine("7. Exit");

//                        var input2 = Console.ReadLine();

//                        switch (input2)
//                        {
//                            case "1":
//                                Console.Write("Enter withdrawal amount: ");
//                                decimal withdrawalAmount;
//                                if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
//                                {
//                                    if (ATM.users.ContainsKey(currentUser))
//                                    {
//                                        if (ATM.users[currentUser].Account.Withdraw(withdrawalAmount))
//                                        {
//                                            Console.WriteLine("Withdrawal successful.");
//                                        }
//                                        else
//                                        {
//                                            Console.WriteLine("Invalid withdrawal amount.");
//                                        }
//                                    }
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Invalid input. Please enter a valid amount.");
//                                }
//                                break;
//                            case "2":
//                                Console.WriteLine("Deposit Money");
//                                Console.Write("Enter deposit amount: ");
//                                decimal depositAmount;
//                                if (decimal.TryParse(Console.ReadLine(), out depositAmount))
//                                {
//                                    if (ATM.users.ContainsKey(currentUser))
//                                    {
//                                        ATM.users[currentUser].Account.Deposit(depositAmount);
//                                        Console.WriteLine("Deposit successful.");
//                                    }
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Invalid input. Please enter a valid amount.");
//                                }
//                                break;
//                            case "3":
//                                Console.WriteLine("Show Available Balance");
//                                ATM.ShowAccountInfo(currentUser);
//                                break;
//                            case "4":
//                                Console.WriteLine("List Historical Transactions");
//                                List<decimal> transactions = ATM.users[currentUser].Account.GetTransactionHistory();
//                                foreach (decimal transaction in transactions)
//                                {
//                                    Console.WriteLine(transaction > 0
//                                        ? $"Deposited: {transaction:C}"
//                                        : $"Withdrawn: {-transaction:C}");
//                                }
//                                break;
//                            case "5":
//                                Console.WriteLine("Change PIN");
//                                Console.Write("Enter new PIN: ");
//                                string newPin = Console.ReadLine();
//                                ATM.users[currentUser].Password = newPin;
//                                Console.WriteLine("PIN changed successfully.");
//                                break;
//                            case "6":
//                                Console.WriteLine("Return to Login");
//                                currentUser = "";
//                                break;
//                            case "7":
//                                Console.WriteLine("Exit");
//                                Environment.Exit(0);
//                                break;
//                        }
//                    }
//                    while (input1 != "3") ;
//                    Console.WriteLine("Goodbye");

//            }
//        }
//    }
//}