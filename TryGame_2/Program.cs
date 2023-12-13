using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace TryGame_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> playersScores = new Dictionary<string, int>();
            string currentPlayer = "";

            string input = "";
            Console.WriteLine("Welcome to the Brain War");
            do
            {
                if (string.IsNullOrEmpty(currentPlayer))
                {
                    Console.WriteLine("Please select the option: ");
                    Console.WriteLine("1 - log in ");
                    Console.WriteLine("2 - exit");

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("---------------------------- MENU -----------------------------");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("1 or 2 - create/log in with another user");
                    Console.WriteLine("3 - view game rules");
                    Console.WriteLine("4 - view game results and participants ");
                    Console.WriteLine("5 - start the game");
                    Console.WriteLine("q - exit the game");
                }


                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                    case "2":
                        {
                            LogIn(playersScores, ref currentPlayer);
                            break;
                        }
                    case "3":
                        {
                            GameRules();
                            break;
                        }
                    case "4":
                        {
                            GameResultsAndParticipants(playersScores, ref currentPlayer);
                            break;
                        }
                    case "5":
                        {
                            StartGame(playersScores, ref currentPlayer);
                            break;
                        }
                    case "q":
                        {
                            Exit();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("There is not such value - your selected option does not exist");
                            Console.WriteLine("Type any button refresh the menu, so you could select the available option");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
            while (input != "q");
            Console.WriteLine("Thanks for your time - have a nice day!");






        }

        static void LogIn(Dictionary<string, int> playersScores, ref string currentPlayer)
        {
            Console.Clear();
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

          

            string fullName = name + " " + surname;

            currentPlayer = fullName;

            if (playersScores.ContainsKey(currentPlayer))
            {
                Console.WriteLine("Such user already exists - welcome back. Your previous game scores have been re-set");
                playersScores[currentPlayer] = 0;

            }
            else
            {
                playersScores.Add(currentPlayer, 0);
                Console.WriteLine($"New player has been created, welcome to the game {currentPlayer}!");
            }

            Console.WriteLine("Press any buton to go to the main menu");
            Console.ReadKey();


        }

        static void Exit()
        {
            Console.WriteLine("Have a nice day - bye!");
            Environment.Exit(0);

        }

        static void GameRules()
        {
            string input = "";


            do
            {
                Console.Clear();
                Console.WriteLine("Congratulations on joining the X Challenge app. This challenge allows you to choose from X categories of questions. Once you have selected a category, you will start the game and you will have to choose which is the correct answer to your question from 4 possible options.");
                Console.WriteLine("Type \"q\" if you want to come back to the main menu");
                input = Console.ReadLine();
                Console.Clear();

            }
            while (input != "q");

        }

        static void GameResultsAndParticipants(Dictionary<string, int> playersScores, ref string currentPlayer)
        {
            Console.Clear();
            Console.WriteLine("This is the results table, you can see, who has collected the most correct answers");
            int index = 1;

            var descendingScores = playersScores.OrderByDescending(x =>x.Value);

            foreach (var item in descendingScores)
            {                
                Console.WriteLine($"The player no. {index} is {item.Key} - answered {item.Value} questions correclty ");
                index++;
                //Console.WriteLine("\nPress any button to see the next question");
                Console.ReadKey();
            }

            Console.WriteLine("\n\nTo proceed to the main menu, please click any button");
            Console.ReadKey();

        }

        static void StartGame(Dictionary<string, int> playersScores, ref string currentPlayer)
        {
            Console.Clear();
            Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>
            {
                {"Capital of Lithuania: ", "Vilnius" },
                {"Lima is the capital of: ", "Peru" },
                {"Which one of the Baltic States has the highest GDP per capita?", "Lithiania" }
            };

            int totalNumberOfQuestions = questionsAndAnswers.Count();

            int correctAnswers = 0;

            string input = "";

            foreach (var question in questionsAndAnswers)
            {
                Console.WriteLine($"{question.Key}");
                input = Console.ReadLine() ;
                if (input == question.Value)
                {
                    Console.WriteLine("Your answer is correct!\n");
                    correctAnswers++;
                }
                else 
                {
                    Console.WriteLine("This is incorrect");               
                }

                            
            }

            Console.WriteLine($"You had {totalNumberOfQuestions} in total and you answered {correctAnswers} questions correctly. ");
            Console.WriteLine("Press any button to go back to the menu");

        }

    }
}