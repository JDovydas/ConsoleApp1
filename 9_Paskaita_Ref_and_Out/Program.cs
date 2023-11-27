using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_Paskaita_Ref_and_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Practice 1
            /*
            int number = 100;
            string name = "Rokas";

            AddNameLength(ref number, name);
            AddNameLength(ref number, name);
            name = "Tomas";
            AddNameLength(ref number, name);
            name = "Antanas";
            AddNameLength(ref number, name);

            Console.WriteLine(number);
            */

            // Practice 2

            /*
            int result;

            bool IsValid = TryToMultiply(0, 8, out result);
            if (IsValid) 
            {
                Console.WriteLine("Nice");
            }
            else 
            {
                Console.WriteLine("You cannot multiply by 0");
            }
            
            */
            // Practice 3
            /*

            int retry;
            bool isValid = Login(out retry);

            if (isValid)
            {
                Console.WriteLine("Nice, it took " + retry + " retries");
            }
            else
            {
                Console.WriteLine("Fail, it took " + retry + " retries");
            }
            */

            // Task 1.1
            /*
            int x = 10;
            int y = 20;
            Console.WriteLine("Original input is " + x + " and " + y);
            Swap(ref x,ref y);
            Console.WriteLine(x + " , " + y);
            */

            // Task 1.2
            /*
            int originalNumber = 10;
            int toBeIncreasedBy = 15;

            IncrementByN(ref originalNumber, toBeIncreasedBy);
            Console.WriteLine(originalNumber);
            */
            // Task 1.3
            

            //string variable = " kalnas";

            /*

            string variable = Console.ReadLine();


            TrimAndCapitalize(ref variable);
            Console.WriteLine(variable); 
            
            */
            // Task 2.1
            
            /* 
            string firstName;
            string lastName;

            GetUserData(out string firstName, out string lastName);
            Console.WriteLine($"Name is {firstName}, last name is {lastName}");
            */
            
            // Task 2.2
            /*

            int numberEntered;
            bool isWholeConversionOK;
            */
            /*
            while (true)
            {
                Console.Write("Enter a number: ");
                string numberEntered = Console.ReadLine();
                bool conversionToNumber = int.TryParse(numberEntered, out number);

                if (conversionToNumber && number > 100)
                {
                    Console.WriteLine("You entered a number greater than 100. Exiting the loop.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input - enter a valid number");
                }
            */
            /*

            int number = 0;
            int input;
            while (number < 100)
            {
                Console.WriteLine("Please input number: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine($"your input is: {number}");

                }

            }
            Console.WriteLine($"Final input is: {number}");

            */
        }

        
        static bool Login(out int retry)
        {
            retry = 0;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter password");
                string input = Console.ReadLine();
                if (input == "goodday")
                {
                    isValid = true;
                }
                else
                {
                    retry++;
                }
            }
            while (!isValid || retry <= 3);
            return isValid;

            
        }
        

        static void GetDimention(out int width, out int height)
        {
            width = 1980;
            height = 1420;
            
        }

        
        static bool TryToMultiply(int a, int b, out int result)
        {
            result = a * b;
            if (a == 0 && b == 0)
            {
                return false;
            }
            return true;
        }
        static void AddNameLength(ref int x, string name)
        {
            x += name.Length;
            name = "Antanas"; //if 'ref' is not stated before the 'string name' - the initial passed value, which was "Rokas" is not changed
        }

        static void AddTen(ref int x)
        {
            x += 10; 
        }

        static void Swap(ref int x, ref int y)
        {
            int originalX = x;
            x = y;
            y = originalX;
                
        }

        static void IncrementByN(ref int originalNumber, int toBeIncreasedBy)
        {
            originalNumber += toBeIncreasedBy;
        }

        static void TrimAndCapitalize(ref string variable)
        {
            variable = variable.Trim();
            variable = char.ToUpper(variable[0]) + variable.Substring(1);

        }

        static void GetUserData(out string firstName, out string lastName)
        {
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();        

        }


        

        /*
        public static int TryParse
        {
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

        }
        */

        }
        

    }   
  
