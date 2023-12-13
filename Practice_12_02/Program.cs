using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Practice_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your number");
            int numberEntered = Convert.ToInt32(Console.ReadLine());

            ReturnValidation(numberEntered);
            */

            /*
            Console.WriteLine("IVESKITE SAVAITES DIENOS NUMERĮ");
            int dayNymber = int.Parse(Console.ReadLine());
            string result = ReturnWeekDay(dayNymber);
            Console.WriteLine(result);
            */

            /*

            string passsaved = "kuku";
            Console.WriteLine("Enter a pass");
            string pass = Console.ReadLine();

            
            if (pass == passsaved)
            {
                Console.WriteLine("You have successfully logged in");
            }
            else if (pass == "Mellon")
            {
                Console.WriteLine("You have successfully logged in");
            }
            else if (pass == "01101001 01101110")
            {
                Console.WriteLine("Hacked...");
            }
            else
            {
                Console.WriteLine("Pass is incorect");
            }
            */
            /*
            Console.WriteLine("Enter the currency");
            string currency = (Console.ReadLine()?.ToLower());
            Console.WriteLine("Enter the amount");
            int amount = int.Parse(Console.ReadLine());
           

            double EURexchangeRate = 2;
            double GBPexchangeRate = 3;

            switch (currency)
            {
                case "eur":
                    double EURresult = amount * EURexchangeRate;
                    Console.WriteLine($"your entered amount of {amount} converted at {EURexchangeRate} will be {EURresult}");
                    break;
                case "gbp":
                    double result = amount * GBPexchangeRate;
                    Console.WriteLine($"your entered amount of {amount} converted at {GBPexchangeRate} will be {result}");
                    break;


            }
            */
            //int yourNumber = 0;
            //Random random = new Random();

            //int randomNumber = random.Next(1, 101);

            //Console.WriteLine(randomNumber);

            //do
            //{
            //    Console.WriteLine("Enter Your number");
            //    yourNumber = int.Parse(Console.ReadLine());
            //    if (randomNumber != yourNumber)
            //    {
            //        Console.WriteLine("Your guess is not successfull");
            //        if (yourNumber > randomNumber)
            //        {
            //            Console.WriteLine("Your number is too big");
            //        }
            //        else if (yourNumber < randomNumber) 
            //        {
            //            Console.WriteLine("Your number is too small");
            //        }

            //    }

            //} 
            //while (randomNumber != yourNumber);
            //Console.WriteLine($"Your guess {yourNumber} is equal to the randomply generated number {randomNumber}");


            //int yourNumber = 0;
            //Console.WriteLine("Enter Your number");
            //yourNumber = int.Parse(Console.ReadLine());

            //while (yourNumber != 0)
            //{

            //    Console.WriteLine("Enter once again");
            //    yourNumber = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("case closed");
            /*

            int num = 1;
            int secNum = 5;
            while (num <= 5)
            {
                Console.WriteLine(num);
                

                while (secNum <= 5 && secNum >= 1)
                {
                    Console.WriteLine(secNum);
                    secNum--;
                }
                num++;
                secNum = 5;
            }
            */
            //int typedInHeight = int.Parse(Console.ReadLine());
            //Console.Clear();
            /*
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 3; i <= 100; i+=3)
            {
                Console.WriteLine(i);
            }
            sw.Stop();

            TimeSpan timeSpan = sw.Elapsed;
            Console.WriteLine(timeSpan);
            */
            /*
            int rows = 4;
            int cols = 4;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i+=2)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write(matrix[i,j] + "\t" );
                }
                Console.WriteLine();
            }
            */
            /*
            int[] arr = { 1, 2, 3, 4, 5 };

            int[,] table = new int[4, 5];

            table[0, 4] = 5;

            int counter = 1;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = counter;
                    counter++;
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0;j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }


            /*
            1 2 3 4 5
            6 7 8 9 10
            11 12 12 14 15
            16 17 18 19 20
            
            */

            string[,] strings = new string[3, 2]
            {
                { "One", "two"},
                {  "Three", "four"},
                {"five", "six" }

            };

            for (int i = 0;i < strings.GetLength(0); i++)
            {
                for (int j = 0; j< strings.GetLength(1); j++)
                {
                    string num = strings[i, j];
                    Console.Write(num[0] + "\t");
                }
                Console.WriteLine();
            }
        }

        

       


        

        

        
        
        static void ReturnValidation(int numberEntered)
        {
            if (numberEntered > 100)
            {
                Console.WriteLine("The number is greater than 100");
            }
            else if (numberEntered == 100)
            {
                Console.WriteLine("The number is equal to 100");
            }
            else
            {
                Console.WriteLine("The number is less than 100");
            }


        }

        static string ReturnWeekDay(int dayNymber)
        {
            string day = "";
            if (dayNymber == 1)
            {
                day = "Pirmadienis";
            }
            else if(dayNymber == 2)
            {
                day = "Antradienis";
            }
            else if (dayNymber == 3)
            {
                day = "Treciadienis";
            }
            return day;
        }


        

        

    }
}