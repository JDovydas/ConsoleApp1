using System.Numerics;

namespace _44_Paskaita_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();

        }

        public static void PrintMenuOptions()
        {
            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.WriteLine("Please select the option:");
            Console.WriteLine("1. Add numbers");
            Console.WriteLine("2. Subtract numbers");
            Console.WriteLine("3. Multiply numbers");
            Console.WriteLine("4. Divide numbers");
            Console.WriteLine("5. Raise a number by X degree");
            Console.WriteLine("6. Get the Nth root of a number");
            Console.WriteLine("7. Exit");

        }
        public static void Run()
        {
            string input = "";


            do
            {
                PrintMenuOptions();
                Console.WriteLine("\n Enter your option");

                input = Console.ReadLine();

                double num1 = 0;

                double num2 = 0;

                switch (input)
                {
                    case "1":
                        Sum(num1, num2);
                        break;
                    case "2":
                        Subtract(num1, num2);
                        break;
                    case "3":
                        Multiply(num1, num2);
                        break;
                    case "4":
                        Divide(num1, num2);
                        break;
                    case "5":
                        Power(num1, num2);
                        break;
                    case "6":
                        Root(num1);
                        break;
                    case "7":
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option - try again");
                        break;

                }

            }
            while (input != "7");
        }

        public static double Sum(double num1, double num2)
        {
            //num1 = GetNumber("Enter the first number");
            //num2 = GetNumber("Enter the second number");
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            //num1 = GetNumber("Enter the first number");
            //num2 = GetNumber("Enter the second number");
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            //num1 = GetNumber("Enter the first number");
            //num2 = GetNumber("Enter the second number");
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            //num1 = GetNumber("Enter the first number");
            //num2 = GetNumber("Enter the second number");
            if (num2 != 0)
                return num1 / num2;
            else
                Console.WriteLine("Cannot divide by zero");
            return 0;
        }

        public static double Power(double num1, double num2)
        {
            //num1 = GetNumber("Enter the base number");
            //num2 = GetNumber("Enter the exponent");
            return Math.Pow(num1, num2);
        }

        public static double Root(double num1)
        {
            //num1 = GetNumber("Enter the number");
            return Math.Sqrt(num1);
        }


        public static double GetNumber(string message)
        {
            double number;
            Console.WriteLine(message);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return number;
        }
    }
}
