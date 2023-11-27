using System.Numerics;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Case1.1
            /*
            int no1 = 1;
            int no2 = 2;

            Swap(ref no1, ref no2);

            Console.WriteLine(no1);
            Console.WriteLine(no2);
            */

            //Case1.2
            /*
            int refNumber = 5;

            IncrementBy(ref refNumber);

            Console.WriteLine(refNumber);
            */

            //Case1.3
            /*

            string youWord = Console.ReadLine();
            TrimAndCapitalize(ref youWord);
            Console.WriteLine(youWord);
            */
            //Case2.1
            /*
            string Yourvardas;
            string Yourpavarde;
            GetUserData(out Yourvardas, out Yourpavarde);

            Console.WriteLine(Yourvardas + " " + Yourpavarde);
           */

            //Case2.2

            /*

            bool isConversionValid;
            int number;

            do
            {
                Console.WriteLine("Please enter the number");
                isConversionValid = (int.TryParse(Console.ReadLine(), out number));
                if (number >= 100)
                {
                    Console.WriteLine("Thanks for your nmber - it is correct");

                }


            }
            while (number < 100);

            */


            //double number2;

            Console.WriteLine("Enter the number 1");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            double number2 = double.Parse(Console.ReadLine());

            Divide(number1, number2, out double quotient, out double reminder);
            Console.WriteLine(quotient + " " + reminder);


        }

        private static void Swap(ref int x, ref int y)
        {
            int no3 = x;
            x = y;
            y = no3;


        }

        private static void IncrementBy(ref int x)
        {
            int increaseBy = int.Parse(Console.ReadLine());
            x += increaseBy;

        }

        static void TrimAndCapitalize(ref string youWord)
        {
            youWord = youWord.Trim();
            youWord = char.ToUpper(youWord[0]) + youWord.Substring(1);

        }

        static void GetUserData(out string Yourvardas, out string Yourpavarde)
        {
            Console.WriteLine("Iveskit varda");
            Yourvardas = Console.ReadLine();
            Console.WriteLine("Iveskit pavarde");
            Yourpavarde = Console.ReadLine();
            string vardasPavarde = Yourvardas + Yourpavarde;



        }

        static void Divide(double number1, double number2, out double quotient, out double remainder)
        {

            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("Division is not possible");
            }
            
            quotient = number1 / number2;
            remainder = number1 % number2;
        }



    }
}