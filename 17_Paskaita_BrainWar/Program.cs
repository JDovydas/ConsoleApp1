using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _17_Paskaita_BrainWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Dictionary<string, int> playersScores = new Dictionary<string, int>();
            string currentPleayer = "";

            Console.WriteLine("Welcome to the Quizz game!");
            Console.WriteLine("Press any button to proceed!");
            Console.ReadLine();
            Console.Clear();
            do
            {     
                bool loginIsChosen = LoginOrQuit();
                if (loginIsChosen)
                {
                    CreateUser(playersScores, ref currentPleayer);

                    DisplayMenu(ref currentPleayer, playersScores);
                }
                else
                {
                    Environment.Exit(0);
                }

                Console.ReadLine();
                Console.Clear();
            }
            while (true);


        }


        static void CreateUser(Dictionary<string, int> playersScores, ref string currentPleayer) //Dictionary turi ref, string - reikia pridet manually
        {
            string lastname = "";
            string firstname = "";

            do
            {
                //Console.WriteLine("Create your account");
                Console.WriteLine("Please enter your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Please enter your last name:");
                string lastName = Console.ReadLine();
                Console.Clear();

                string fullName = $"{firstName} {lastName}";

                if (playersScores.ContainsKey(fullName))
                {

                    Console.WriteLine($"Such user already exists - welcome back {fullName}. Your previous answers are set to 0");
                    playersScores[fullName] = 0;
                }
                else
                {
                    playersScores.Add(fullName, 0);
                    Console.WriteLine($"Congratulations, the new user {fullName} has been created!");
                }

                currentPleayer = fullName;

            }
            while (currentPleayer == "");
        }





        static void ShowResults(Dictionary<string, int> playersScores)
        {
            Console.Clear();
            var sortedScores = playersScores.OrderByDescending (x => x.Value);

            foreach (var item in sortedScores)
            {
                Console.WriteLine($"Player: {item.Key}, number of correct answers: {item.Value}");
            }
        }


        static void Print(Dictionary<string, string> userWelcome)
        {
            foreach (var item in userWelcome)
            {
                Console.WriteLine(item);
            }
        }


        static void DisplayMenu(ref string currentPleayer, Dictionary<string, int> playersScores)
        {
            string input = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------------------------------------  ");
                Console.WriteLine("                         Menu                        ");
                Console.WriteLine("---------------------------------------------------- ");
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select one of the following actions: ");

                Console.WriteLine(" 1 - See the rules of the game");
                Console.WriteLine(" 2 - play the game");
                Console.WriteLine(" 3 - see the results");
                Console.WriteLine(" q - quit the game (or create a new player)");


                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        GameRules();
                        break;
                    case "2":
                        TakeQuizz(currentPleayer, playersScores);
                        break;
                    case "3":
                        ShowResults(playersScores);
                        break;
                    case "q":
                        LogOut(ref currentPleayer);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }

            }
            while (input != "q");
            Console.WriteLine("Sad to say goodbye...Goodbye!");



        }
        static void GameRules()
        {
            string input = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Congratulations on joining the X Challenge app.\n" +
                "This challenge allows you to choose from X categories of questions. \n" +
                "Once you have selected a category, you will start the game and you will have to choose which is the correct answer to your question from 4 possible options");

                Console.WriteLine("Type q to exit the Game Rules window");
                input = Console.ReadLine();
                Console.Clear();
            }
            while (input != "q");

        }

        static void TakeQuizz(string currentPlayer, Dictionary<string, int> playersScores)
        {
            Console.WriteLine("Are you really ready? Ready steady? If so, just hit any button...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Let's start the quiz!");
            Dictionary<string, string> quizQuestions = new Dictionary<string, string>
            {
                { "What is the capital of Peru?", "Lima" },
                { "Which year did Saules musis happen?", "1236" },
                { "What is the most populated country in the world?", "China" }
            };

            int totalQuestions = quizQuestions.Count; //int totalQuestions = 3;
            int correctAnswers = 0;

            foreach (var question in quizQuestions)
            {
                Console.WriteLine($"\nQuestion: {question.Key}");
                string userAnswer = Console.ReadLine();

                if (userAnswer == question.Value)
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;

                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {question.Value}");
                }

            }
            Console.WriteLine($"\nQuiz completed, {currentPlayer}!");
            Console.WriteLine($"You answered {correctAnswers} out of {totalQuestions} questions correctly.\n");
 
            if (playersScores.ContainsKey(currentPlayer))
            {
                playersScores[currentPlayer] += correctAnswers;
            }
            else 
            {
                playersScores.Add(currentPlayer, correctAnswers);
            }


            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }


        static bool LoginOrQuit()
        {
            string userInput = "";
            do
            {
                Console.WriteLine("Window 1: Initial Login");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Log in");
                Console.WriteLine("q. Quit");

                userInput = Console.ReadLine();
                Console.Clear();


                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Lets create your account!");
                        return true;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Thanks and have a nice day!");
                        return false;
                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        Console.Clear();
                        break;
                }
            }
            while (userInput != "exit");
            return false;

        }
        static void LogOut(ref string currentPleayer)
        {
            currentPleayer = "";

        }
    }
}