using System;

namespace _7_Paskaita_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tasks from the previous lecture

            //2.1

            /*

            int i = 1;
            int j = 1;

            while (j!= 0)
            {
                Console.WriteLine("Add number");
                i = int.Parse(Console.ReadLine());
                j = 1;
                while(i != 0) 
                {
                    j = j * i;
                    i--;              
                }
                Console.WriteLine($"Factorial is: {j}");
            }
            Console.WriteLine("Error");

            */

            //2.2


            /*
            int i = 1;

            do
            {
                Console.WriteLine("Number: " + i);
                i++;
            }
            while (i <= 5);

            */
            /*

            string input;

            do
            {
                Console.WriteLine("Enter 'exit' to stop");
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "rokas":
                        Console.WriteLine("This is my name");
                        break;
                    case "asd":
                        Console.WriteLine("Random text");
                        break;
                }
                //if (input == "Rokas") - we can use 
                //{
                //    Console.WriteLine("This is my name");
                //}
                //else if (input == "asd")
                //{
                //    Console.WriteLine("Random text");
                //}


            }
            while (input != "exit");
            */

            //Pratimas 5.1

            /*
            int sum = 0;
            int number;
            string yourInput;
            Console.WriteLine("Enter your number");

            do
            {
                yourInput = Console.ReadLine().ToLower();
                if (int.TryParse(yourInput, out number))
                {
                    sum += number;
                    Console.WriteLine($"Sum of your number {sum}");
                }

            }
            while (yourInput != "finish");
            
            */

            //Pratimas 5.2

            /*

            var correctPass = "Namas";

            string enteredData = "";

            do
            {
                Console.WriteLine("Enter your password");
                enteredData = Console.ReadLine();

            }
            while (enteredData != correctPass);
            Console.WriteLine("Password is correct!");

            */

            //Pratimas 5.3 - number comparison (without guidelines)

            /*

            int guessedNumber = 0;
            int randomnumber = 0;
            Random random = new Random();
            int randomNumber = random.Next();
            int min = 1;
            int max = 100;
            int randomInRange = random.Next(min, max);

            do
            {
                Console.WriteLine("Guess a number");
                guessedNumber = int.Parse(Console.ReadLine());

                //Random random = new Random();
                //int randomnumber = random.Next();
                if (guessedNumber != randomInRange) 
                {
                    Console.WriteLine("your guess was not successful");
                    Console.WriteLine($"The random number was {randomInRange}");
                }

                
            }
            while (guessedNumber != randomInRange);
            Console.WriteLine($"Your guessed number {guessedNumber} is equal to a random number {randomInRange} - SUCCESS");

            */

            

            //Pratimas 5.3 - number comparison (wit guidelines)

            int guessedNumber = 0;
            Random random = new Random();
            int randomNumber = random.Next();
            int min = 1;
            int max = 100;
            int randomInRange = random.Next(min, max);

            do
            {
                Console.WriteLine("Guess a number");
                guessedNumber = int.Parse(Console.ReadLine());

                //Random random = new Random();
                //int randomnumber = random.Next();
                if (guessedNumber != randomInRange)
                {
                    Console.WriteLine("your guess was not successful");
                    if (guessedNumber > randomInRange)
                    {
                        Console.WriteLine("Your number is greater then the random number");
                    }
                    else if (guessedNumber < randomInRange)
                    {
                        Console.WriteLine("Your number is lower than the random number");
                    }
                    Console.WriteLine($"The random number was {randomInRange}");
                }


            }
            while (guessedNumber != randomInRange);
            Console.WriteLine($"Your guessed number {guessedNumber} is equal to a random number {randomInRange} - SUCCESS");

            

            // Project 1 - Game

            /*

            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome to the game dear {name}!");
            Random var1 = new Random();
            int playerHP = var1.Next(0,100); //player HP
            Random var2 = new Random();
            int monsterHP = var2.Next(0,100);//Monster HP
            Console.WriteLine($"The game is loaded, {name}, your heroe has {playerHP} health points and your enemy monster has {monsterHP} health points");
            Console.WriteLine("Your heroe goes to the swamp and is attached by the monster known as 'very bad ogre'");
            //Console.WriteLine("You have to select one of the three attacks to hit the ogre: ');
            int playerAttack = var1.Next(0,100);
            int monsterAttack = var2.Next(0, 100);

            do
            {
                Random v1 = new Random();
                Random v2 = new Random();
                int attack1 = v1.Next(0, 100);
                int attack2 = v2.Next(0, 100);
                Console.WriteLine($"{name} - click any button to hit the monster!");
                string playerCombat = Console.ReadLine();
                Console.WriteLine($"{name} hit {attack1} POINTS!");
                Console.WriteLine($"Ogre SHOOT {attack2} POINTS!");
                playerHP = playerHP - attack2;
                monsterHP = monsterHP - attack1;
                if (playerHP <= 0 && monsterHP <= 0)
                {
                    Console.WriteLine($"You and your enemy 'very bad ogre' are BOTH dead - GAME OVER");
                }
                else if (playerHP <= 0)
                {
                    Console.WriteLine($"You're dead, your health point number is {playerHP} - GAME OVER ");
                }
                else if (monsterHP <= 0)
                {
                    Console.WriteLine($"WHOOOAAAA - 'very bad ogre' is dead - you are the WINNER - congratulations {name}!!!!");
                }
                else
                {
                    Console.WriteLine($"You still have {playerHP} health points left and the 'very bad ogre' has {monsterHP} health points left - keep up and prepare for the next round!!!");
                }


            }
            while (playerHP >= 0 && monsterHP >=0);
            //Console.WriteLine($"{name}, prepare for another round!");

            */
            /*

            var pass = "KaTu";
            string input = "";

            //Console.WriteLine("Guess the password");

            do
            {
                Console.WriteLine("Guess the password");
                input = Console.ReadLine();
                if (input == pass)
                {
                    Console.WriteLine($"Congratulations - your guess that the password is '{pass}' has been correct!!!");
                }



            }
            while (input != pass);

            */
            
            /*

            int n1 = 1;
            int n2 = 4;

            while (n1 <= 5)
            {
                Console.WriteLine(n1);
                n1++;
                while (n2 >= 0) 
                {
                    Console.WriteLine(n2);
                    n2 = n2 - 1;
                }
                n2 = 4;
            }
            
            Console.WriteLine("Here we finish");
            */

        }
    }
}