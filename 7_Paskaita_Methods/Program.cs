using System.Security.Cryptography.X509Certificates;

namespace _7_Paskaita_Methods
{
    internal class Program
    {
        static void Main(string[] args) //Use methods as ofter as possible ( have them outside the main)


        {




            ///Practice 1

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //int sum = Sum(number1, number2);

            ////int sum = Sum(1,2);
            //Console.WriteLine(sum);

            //    HelloWorld();

            //    bool isUnderAge = IsOfLegalAge(1999);
            //    Console.WriteLine(isUnderAge);
            //    Console.WriteLine(CalculateAge(1999));

            //    switch (2)
            //    {
            //        case 0:
            //            Console.WriteLine(CalculateAge(1999));
            //            break;
            //        case 1:
            //            bool isUnderage = IsOfLegalAge(1999);
            //            break;
            //        case 2:
            //            HelloWorld();
            //            break;
            //    }


            //}

            // Recusion(5);

            //Task 1.1 
            /*
            Console.WriteLine("Enter the password");
            string input = Console.ReadLine();//123456
            bool isValid = IsPasswordValid(input);
            */

            //Task 1.2
            /*
            Console.WriteLine("Enter the email address");

            string emailEntered = Console.ReadLine();

            bool isEmailValid = IsEmailValid(emailEntered);
            Console.WriteLine(isEmailValid);
            */

            //Task 1.3
            /*
            Console.WriteLine("This is Dollar to EUR converter");
            Console.WriteLine("Enter the dollar");
            double dollarInput = int.Parse(Console.ReadLine());
            double convertedEurAmount = ConvertToEuros(dollarInput);
            Console.WriteLine($"You received {convertedEurAmount} EUR");
            */

            //Task 2.1
            /*
            Console.WriteLine("Please enter your first name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string surname = Console.ReadLine();
            string nameAndSurname = GetInitials(name, surname);
            Console.WriteLine(nameAndSurname);
            */

            //Task 2.2

            /*
            Console.WriteLine("This is a tool to calculate the volume of the cylinder");
            Console.WriteLine("Please enter the radius");
            double radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height");
            double height = int.Parse(Console.ReadLine());
            double cylinderVolume = CalculateCylinderVolume(radius, height);
            Console.WriteLine(cylinderVolume);
            */

            //Task 2.3
            /*
            Console.WriteLine("The program checks if your entered number is even or odd");
            Console.WriteLine("Enter your number");
            int yourNumber = int.Parse(Console.ReadLine());
            bool isYourNumberEven = IsNumberEven(yourNumber);
            Console.WriteLine(isYourNumberEven);
            */

            //Task 2.4
            /*
            Console.WriteLine("This is the tool to calculate the area of the triangle");
            Console.WriteLine("Enter the length");
            double lengthOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            double widthOfTriangle = double.Parse(Console.ReadLine());
            double areaOfTriangle = CalculateRectangleArea(lengthOfTriangle, widthOfTriangle);
            Console.WriteLine($"The area of tiangle is {areaOfTriangle}");
            */

            //Task 3.1
            
            Console.WriteLine("Enter a number for factorial calculation");
            var number = 5;
            var factorial = CalculateFactorialRecursively(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");

            //Task 3.2

            Console.WriteLine("Enter a number for Fibonnaci calculation");
            var length = 5;
            var fibonacci = CalculateFactorialRecursively(length);
            Console.WriteLine($"Fibonacci number for n = {length} is {factorial}");






        }
        //public static void Recusion(int number)
        //{
        //    if(number == 0)
        //    {
        //        return;
        //    }
        //    Console.WriteLine(number);
        //    Recusion(number-1);

        //}
        //123456
        public static bool IsPasswordValid(string password)
        {

            if (password.Length > 8)
            {
                Console.WriteLine("THE PASSWIRD IS VALIUD");
                return true;
            }
            else
            {
                Console.WriteLine("THE PASSWIRD IS VALID");
                return false;
            }
            

        }


        public static bool IsEmailValid(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Your email is valid");
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static double ConvertToEuros(double dolalars)
        {
            double eurAmount = dolalars * 0.85;
            return eurAmount;
        }

        public static string GetInitials(string input1, string input2)
        {
            string mergedInput = input1 + input2;
            return mergedInput;
        }

        public static double CalculateCylinderVolume(double radius,  double height)
        {
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            return volume;

        }

        public static bool IsNumberEven (int yourNumber)
        {
            if (yourNumber % 2 ==0)
            {
                Console.WriteLine("Your number is even");
                return true;
            }
            else
            {
                Console.WriteLine("Your is odd");
                return false;
            }
        }

        public static double CalculateRectangleArea (double givenLength, double givenWidth)
        {
            double area = 0.5 * givenLength * givenWidth;
            return area;
        }


        public static int CalculateFactorialRecursively(int number)
        {
            if (number <= 0)
                return 1;
            return number * CalculateFactorialRecursively(number - 1);
        }

        public static int FibonacciSequence(int n)
        {
            if (n <= 1) return n;
            return FibonacciSequence(n-1) + FibonacciSequence(n-2);
        }

        //public static int Sum(int number1, int number2)//public static int Sum(int x, int y)
        //{
        //    //return x + y;
        //    return number1 + number2; 
        //}

        //public static void HelloWorld()
        //{
        //Console.WriteLine("Hello World");
        //}

        //public static bool IsOfLegalAge(int yearOfBirth)
        //{
        //    return CalculateAge(yearOfBirth) <= 18;
        //}
        //public static int CalculateAge(int yearOfBirth)
        //{
        //    return DateTime.Now.Year - yearOfBirth;
        //}




    }

}