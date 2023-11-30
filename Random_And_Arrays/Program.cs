using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Random_And_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that generates random numbers from 1 to 10 and displays them in the console. 
            // 1

            //Random random = new Random();

            //int aRandomNumber1To10 = random.Next(1,10);
            //Console.WriteLine(aRandomNumber1To10);

            //RandomNumberGenerator();

            //2
            //RandomBooleanValues();

            //3.1

            //RandomLetterGenerator();

            //3.2

            //RandomPasswordGenerator();

            //4
            //RandomNumber1To6Generator();

            //5
            /*
            RandomNumber1To100Generator();

            int randomNumber = RandomNumber1To100Generator();

            Console.WriteLine("Type in 'Less' or 'More' to guess if the random number is less or greater than 50");

            string userInput = Console.ReadLine();

            IsTheGuessCorrect(userInput, randomNumber);
            */

            //6

            RandomMatrixGenerator();


        }


        static void RandomNumberGenerator()
        {
            Random random = new Random();

            Console.WriteLine("Random number from 1 to 10: ");

            for (int i = 0; i < 1; i++)
            {
                int randomNumber = random.Next(1, 11);
                Console.WriteLine(randomNumber + " ");
            }

        }

        static void RandomBooleanValues()
        {
            Random random = new Random();
            Console.WriteLine("Random boolean values are: ");
            for (int i = 0; i < 5; i++)
            {
                bool randomBool = Convert.ToBoolean(random.Next(0, 2));
                Console.WriteLine(randomBool + " ");
            }
            Console.WriteLine();

        }

        static void RandomLetterGenerator()
        {
            Random random = new Random();
            Console.WriteLine("Random letter from A to Z is: ");
            for (int i = 0; i < 1; i++)
            {
                char randomLetter = (char)random.Next('A', 'Z' + 1);
                Console.WriteLine(randomLetter + " ");
            }

        }

        static void RandomPasswordGenerator()
        {
            Console.WriteLine("How long the password should be? Enter the length");
            int passwordLength = Convert.ToInt32(Console.ReadLine());
            string password = "";
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                char randomLetter = (char)(random.Next('A', 'Z' + 1));
                password += randomLetter;

            }
            Console.WriteLine(password);
        }
        static void RandomNumber1To6Generator()
        {
            int sumOfRandoms = 0;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(1, 7);
                Console.WriteLine(randomNumber);
                sumOfRandoms += randomNumber;
                //foreach (int randomNumber )

            }
            Console.WriteLine($"The sum of all randoms is " + sumOfRandoms);
        }

        static int RandomNumber1To100Generator()
        {
            Random random = new Random();
            int randomNumber = (int)(random.Next(1, 101));
            return randomNumber;

        }


        static bool IsTheGuessCorrect(string userInput, int randomNumber)
        {
            if ((userInput == "Less" && randomNumber < 50) || (userInput == "More" && randomNumber > 50))
            {
                Console.WriteLine($"Your guess is correct, the random number was {randomNumber}");
                return true;

            }
            else
            {
                Console.WriteLine($"Your guess is incorrect, the random number was {randomNumber}");
            }
            return false;

        }

        static int[,] RandomMatrixGenerator()
        {
            Random random = new Random();

            int matrixRandom = random.Next(1, 9);

            int row = random.Next(1, 9);
            int column = random.Next(1, 9);

            int[,] matrix = new int[row, column];





        }


    }
}