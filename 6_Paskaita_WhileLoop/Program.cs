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




        }
    }
}