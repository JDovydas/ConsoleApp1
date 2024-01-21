using System.ComponentModel.Design;

namespace _31_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentUser = "";

            Console.WriteLine(Guid.NewGuid());

            string input1 = "";
            do
            {
                Console.WriteLine("Welcome to the Automated Teller Machine");
                Console.WriteLine("Please choose the action: ");

                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                input1 = Console.ReadLine();

                if (string.IsNullOrEmpty(currentUser))
                {
                    switch (input1)
                    {
                        case "1":
                            Console.WriteLine("RegisterUser");
                            //RegisterUser();
                            break;
                        case "2":
                            Console.WriteLine("LoginUser");
                            //LoginUser();
                            break;
                        case "3":
                            Console.WriteLine("Exit");
                            //Exit();
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
                            Console.WriteLine("WithdrawMoney");
                            //WithdrawMoney();
                            break;
                        case "2":
                            Console.WriteLine("DepositMoney");
                            //DepositMoney();
                            break;
                        case "3":
                            Console.WriteLine("ShowAvailableBalance");
                            //ShowAvailableBalance();
                            break;
                        case "4":
                            Console.WriteLine("ListHistoricalTransactions");
                            //ListHistoricalTransactions();
                            break;
                        case "5":
                            Console.WriteLine("ChangePin");
                            //ChangePin();
                            break;
                        case "6":
                            Console.WriteLine("6. Return to Login");
                            break;
                        case "7":
                            Console.WriteLine("Exit");
                            Environment.Exit(0);
                            break;



                    }

                }



            }
            while (input1 != "3");




        }

    }
}