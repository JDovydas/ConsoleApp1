namespace _6_Paskaita_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //1
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++; // increases the value by the number of counter
            }

            //2
            int counter1 = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter1);
                counter1 = counter1 + 2;
                counter1 += 2; // the same as above - addint 2 to itself
            }

            Console.WriteLine("The end");

            //3
            */

            /*

            while (true)
            {
                Console.Write("Enter \"exit\" to end: "); //in this way we can add quotes
                string input = Console.ReadLine();

                if(input.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("You entered: " + input);
            }
            Console.WriteLine("The end");

            Console.WriteLine(); // Writes into a new line
            Console.Write(""); // Writes in one line

            Console.ReadLine(); // Reads all input
            Console.Read(); // Reads only one input (one symbol or one letter

            */

            /*

            int i = 1;
            while (i <= 5) 
            {
                int j = 1;
                while (j <= 5)
                {
                    Console.WriteLine($"i={i}; j={j}");
                    j++;
                }
                i++;
            }

            */
            /*
            int i = 1;
            while (i <= 5) 
            {
                Console.Write($"i={i} ");
                int j = 1;
                while (j <= 5)
                {
                    Console.Write($"j={j} ");
                    j++;
                }
                i++;
                Console.WriteLine();
            }
            /*
            int i = 1;
            while (i <= 5)
            {
                //Console.Write($"i={i} ");
                int j = 1;
                while (j <= 5)
                {
                    Console.Write($" i={i} j={j} ");
                    j++;
                }
                i++;
                Console.WriteLine();
            }

            */

            /*
            int i = 1;
            while (i <= 5)
            {
                //Console.Write($"i={i} ");
                int j = 1;
                while (j <= 5)
                {
                    Console.Write($" row={i} column={j} ");
                    j++;
                }
                i++;
                Console.WriteLine();
            }

            */

            // 1.1

            /*

            int number = 1;
    
            while(number <= 5)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine();

            */

            // 1.2
            /*

            int i = 1;
            while (i <= 5)
            {
                //Console.Write($"i={i} ");
                int j = 5;
                while (j <= 5 && j >= 1)
                {
                    Console.Write($" row {i}, column {j} ");
                    j= j-1;
                }
                i++;
                Console.WriteLine();

            }

            */

            /*

            // 1.3

            int no = 2;

            while (no >= 2 && no <=10 && no % 2 == 0)
            {
                Console.WriteLine(no);
                no +=2;
            }
            Console.WriteLine();

            */

            // 1.4

            /*

            int no = 2;

            while (no >= 2 && no <= 10 && no % 2 == 0)
            {
                int no2 = 1;
                while (no2 >= 1 && no2 <= 9 && no2 % 2 != 0)
                {
                    Console.WriteLine(no2);
                    no2 += 2;
                }
                Console.WriteLine(no);
                no += 2;
                
            }
            */

            // 1.5

            /*

            int numberEntered = 0;

            while (numberEntered <= 100)
            {
                Console.WriteLine("Enter a number");
                numberEntered = Convert.ToInt32(Console.ReadLine());
                if (numberEntered <= 100)
                Console.WriteLine($"Your entered {numberEntered} is not greater than 100, try again");

            }
            Console.WriteLine($"Your entered {numberEntered} is greater 100, case closed");

            */
            /*

            int numberEntered = 0;
            int anothernumberEntered = 0;

            while (numberEntered <= 100)
            {
                Console.WriteLine("Enter a number");
                numberEntered = Convert.ToInt32(Console.ReadLine());
                if (numberEntered <= 100)
                Console.WriteLine($"Your entered {numberEntered} is not greater than 100, try again");
                while (anothernumberEntered >= 0)
                {
                    Console.WriteLine("Enter another number");
                    anothernumberEntered = Convert.ToInt32(Console.ReadLine());
                    if (anothernumberEntered >= 0);
                    {
                        Console.WriteLine($"Your entered {anothernumberEntered} is not negative, try again");
                    }
                }
                Console.WriteLine($"Your entered {anothernumberEntered} is negative - success");
            }
            Console.WriteLine($"Your entered {numberEntered} is greater 100, case closed");

            //1.1

            */

            /*



            int input = 1;



            while (input <= 5)

            {

                Console.WriteLine(input);

                input++;

            }

            Console.WriteLine($"Your entered number {input} is more than 5 - program is closed");



            */









            //1.2



            /*



            int num1 = 1;

            int num2 = 5;



            while (num1 <= 5)

            {

                Console.WriteLine(num1);

                num1++;



                while (num2 <= 5 && num2 >= 1)

                {

                    Console.WriteLine(num2);

                    num2 = num2 - 1;

                }

                num2 = 5;



            }

            Console.WriteLine("The number reached its maximum");



            */







            // 1.3



            /*



            int yourNumber = 2;



            while (yourNumber <=10 && yourNumber % 2 == 0)

            {

                Console.WriteLine(yourNumber);

                yourNumber += 2;

            }



            */





            // 1.4



            /*



            int myNumber = 2;

            int anotherNumber = 1;



            while (myNumber <= 10 && myNumber % 2 == 0)

            {

                Console.WriteLine(myNumber);

                myNumber += 2;



                while (anotherNumber <= 9 && anotherNumber % 2 != 0)

                {

                    Console.WriteLine(anotherNumber);

                    anotherNumber += 2;

                }

                anotherNumber = 1;



            }



            */



            // 1.5 A



            /*

            int numberEntered = 0;

            while (numberEntered <=100)

            {
                Console.WriteLine("Enter a number");

                numberEntered = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Your entered number {numberEntered} is more than 100 - Success");

            */

            /*

            // 1.5 B

            int numberLevel1 = 0;

            int numberLevel2 = 0;

            while (numberLevel1 <= 100)

            {

                Console.WriteLine("Enter your Number");

                numberLevel1 = Convert.ToInt32(Console.ReadLine());

                while (numberLevel2 >= 0)

                {

                    Console.WriteLine("Enter your second number Number");

                    numberLevel2 = Convert.ToInt32(Console.ReadLine());

                }

            }

            */

            //2.1 A

            /*

            int factorialYours = 0;

            while (true)
            {
                Console.WriteLine("Enter the number");
                factorialYours = Convert.ToInt32(Console.ReadLine());
                factorialYours *= factorialYours;
                Console.WriteLine($"The factorial is {factorialYours}");

            }

            /*

            // 2.2

            int factorialYours = 0;

            while (true)
            {
                Console.WriteLine("Enter the number");
                factorialYours = Convert.ToInt32(Console.ReadLine());
                int factorialYoursResult = factorialYours * factorialYours;
                Console.WriteLine($"The factorial of {factorialYours} is {factorialYoursResult}");
                while (factorialYours >= 0)
                {
                    Console.WriteLine($"Your originally entered number is {factorialYours}");
                    break;
                }
                

            }

            */


            /*

            // 2.3

            int positiveNumber = 0;

            while (positiveNumber >= 0)
            {
                Console.WriteLine("Enter a positive number");
                positiveNumber = Convert.ToInt32(Console.ReadLine());
                string text = positiveNumber.ToString();
                char[] newList = text.ToCharArray();
                Console.WriteLine(newList[0]);
                
            }


            */
        }
    }
}