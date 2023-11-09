using System.Diagnostics;
using System.Threading.Channels;

namespace Lesson_5_String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            string name = "Rokas";
            string city = "Kaunas";
            string text = $"Name: {name} lives in {city} ";

            string part1 = text.Substring(0, 11);
            string part2 = text.Substring(12, 15);

            Console.WriteLine(part1);
            Console.WriteLine(part2);


            string part3 = text.Replace("Kaunas", "Vilnius");
            Console.WriteLine(part3);

            //Split
            string[] check = text.Split(" "); 
            Console.WriteLine(check);

            //Check

            if(text.Contains("Kaunas"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            string path = "C:/User/File/cv.pdf";

            if(path.EndsWith(".pdf")) //we can do with StartWith if(path.StartsWith("C:"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            string number = "5";

            string fullNumber = number.PadLeft(4, '0');
            // 0005
            Console.WriteLine(fullNumber);

            string zodis = "Rok";

            string fullNumber1 = zodis.PadRight(5, '_');
            // 0005
            Console.WriteLine(fullNumber1);


            string daina = "Hi, my name is. Hi my name is";
            int dainaIndex = daina.IndexOf("Hi");
            string newdaina = daina.Substring(0, dainaIndex) + "Hello" + text.Substring(dainaIndex + "Hi".Length);
            Console.WriteLine(newdaina);

            /*
            int textIndex = text.IndexOf('H');
            char[] chars = text.ToCharArray();
            chars[textIndex] = 's';
            string text2 = text.Substring(textIndex + 1);
            Console.WriteLine(text2);
            */

            /*

            string neklonuotas = "Hi, my name is. Hi my name is";
            string klonuotas = (string)neklonuotas.Clone();
            Console.WriteLine(klonuotas);

            */

            /
            //Task 1 A - version 1

            Console.WriteLine("Please enter the text");
            string textEntered = Console.ReadLine();
            char[] textEnteredArray = textEntered.ToCharArray();
            textEnteredArray[0] = char.ToUpper(textEnteredArray[0]);
            Console.WriteLine(textEnteredArray);



            /*

            //Task 1 B

            Console.WriteLine("Please enter the text");
            string yourText = Console.ReadLine();
            char[] yourTextArray = yourText.ToCharArray();
            yourTextArray[2] = 'g';
            yourTextArray[4] = 'b';
            yourTextArray[6] = '*';
            yourTextArray[8] = 'x';
            yourTextArray[10] = 'w';

            string UpdatedYourText = new string(yourTextArray);
            Console.WriteLine(UpdatedYourText);
            Console.WriteLine(yourTextArray);

            */
            /*

            //Task 1 C

            Console.WriteLine("Enter the text of 5 characters");
            string text = Console.ReadLine();
            char[] textArray = text.ToCharArray();

            if (text.Length == 5)
            {
                Console.WriteLine("How do you want to encode your message?");
                int number = Convert.ToInt32(Console.ReadLine());
                textArray[0] = (char)(textArray[0] + number);
                textArray[1] = (char)(textArray[1] + number);
                textArray[2] = (char)(textArray[2] + number);
                textArray[3] = (char)(textArray[3] + number);
                textArray[4] = (char)(textArray[4] + number);
                string encode = new string(textArray);

                Console.WriteLine(encode);

            }
            else
            {
                Console.WriteLine("Wrong input - 5 characters are needed");
            }
            //    char encoding = Convert.ToBase64CharArray.Console.ReadLine();

            //    char symbol1 = 'R';
            //    char symbol2 = 'o';
            //    char symbol3 = 'k';
            //    char symbol4 = 'a';
            //    char symbol5 = 's';
            //    char[] chars = { 'R', 'o', 'k', 'a', 's' };
            //    char encoding = '/';
            //    Console.WriteLine((char)(chars[0] + encoding));


            //}
            //else 
            //{
            //    Console.WriteLine("Wrong input - 5 characters are needed");
            //}

            //*/

            /*

            {
            DateTime date1 = new DateTime(1992, 01, 1); // Replace with your first date
            DateTime date2 = new DateTime(2023, 11, 8); // Replace with your second date

            TimeSpan difference = date2 - date1;

            int dayDifference = difference.Days;

            Console.WriteLine("The day difference between the two dates is: " + dayDifference + " days");
            {

            */
            /*

            //Task 2 A

            Console.WriteLine("Please input the sentence");
            string userInput = Console.ReadLine();

            string replaceuserInput = userInput.Replace("a", "uo").Replace('i', 'e');




            Console.WriteLine(replaceuserInput);

            */

            //Task 2 B

            /*
            Console.WriteLine("Please write the lyrics"); 
            string lyrics = Console.ReadLine();
            Console.WriteLine("What word you would like to change?");
            string wordToChange = Console.ReadLine();
            Console.WriteLine("What would be the new word?");
            string newWord = Console.ReadLine();


            string updatedlyrics = lyrics.Replace(wordToChange, newWord);
            Console.WriteLine("Updated Lyrics:");
            Console.WriteLine(updatedlyrics);

            */



            //galima tai apeiti pridedant tarpeli po 


            /*
            
            //string updatedLyrics = ReplaceWordInText(lyrics, wordToChange, newWord);

            if (lyrics.Contains(wordToChange))
            {
                static string ReplaceWordInText(string lyrics, string wordToChange, string newWord)
                {
                    string[] words = lyrics.Split(" ");
                    string updatedLyrics = "";
                    foreach (string word in words)
                    {
                        if (word.Equals(wordToChange, StringComparison.OrdinalIgnoreCase))
                        {
                            updatedLyrics += newWord + " ";
                        }
                        else
                        {
                            updatedLyrics += word + " ";
                        }
                    return updatedLyrics.Trim();
                    }
                return updatedLyrics.Trim();
                }
            }
            else
            {
                Console.WriteLine("There is no such word, please try next time");
            }

            */
            /*
            
                       
            //Task 2 C

            Console.WriteLine("This is the calculator to know how many days, weeks, months and years a user has before turining 90");
            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which year you were born");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month you were born");
            int monthBorn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day you were born");
            int dayBorn = Convert.ToInt32(Console.ReadLine());

            int totalYearsLeft = 90 - userAge;
            int totalMonthsLeft = (90*12) - ((userAge*12) + (12- monthBorn));
            int totalWeeksLeft = (90 * 12 * 4) - (((userAge * 12 + (12 - monthBorn)) * 4) + ((30 - dayBorn) * 7));

            Console.WriteLine($"You have {totalYearsLeft} years in total to reach the age of 90");
            Console.WriteLine($"You have {totalMonthsLeft} months in total to reach the age of 90");
            Console.WriteLine($"You have {totalWeeksLeft} weeks in total to reach the age of 90");

            */

            /*
             
            //Task 3 B

            Console.WriteLine("Enter the word");
            string wordInput = Console.ReadLine();
            char[] wordInputArray = wordInput.ToCharArray();

            if (char.IsUpper(wordInput[0]))
            {
                Console.WriteLine("Your word starts with the capital letter, thus we are printing a new word with all capital letters: " + wordInput.ToUpper());

            }
            else
            {
                Console.WriteLine("Your word starts with the lowercase letter, thus changing it to the capital one: " + char.ToUpper(wordInput[0]) + wordInput.Substring(1));
            }

            */

            //Task 3 B

            /

            Console.WriteLine("Please enter a word");
            string inputTxt = Console.ReadLine();

            if (inputTxt.Contains('a'))
            {
                int indexOfA = inputTxt.IndexOf('a');
                Console.WriteLine($"Your word is {inputTxt} and the index of 'a' is {indexOfA}");
            }
            else 
            {
                Console.WriteLine("Character 'a' not found");
            }

            */

            /*

            //3B - 2

            Console.WriteLine("Enter word");
            string text = Console.ReadLine();
            int index = text.IndexOf('a');
            if (index == -1) 
            {
                Console.WriteLine("Characte not found");
            }
            else
            {
                Console.WriteLine(text);
            }

            */

            

            //Task 3 C

            /*

            Console.WriteLine("Enter your word");
            string yourWord = Console.ReadLine();
            char[] yourWordArray = yourWord.ToCharArray();
            Array.Reverse(yourWordArray);
            string reversedString = new string(yourWordArray);

            if (yourWord.Contains("hello"))
            {
                Console.WriteLine($"Your your printed backwards is {reversedString}");
            }
            else
            {
                Console.WriteLine("Your entered word is not 'hello', thus no backwards printing");
            }

            */

            //Task 4 A

            /*

            double sumustinioSuma = 0;
            string sumustinioIngridientai = "";

            Console.WriteLine("Welcome to Subway, please create your sandwitch");
            Console.WriteLine("Please select a bread type: 'dark bread' or 'white bread'");
            string breadType = Console.ReadLine();
            Console.WriteLine("Would you like to add salami? - if so type 'yes', if no - type 'no'");
            string isSalamiAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add feta? - if so type 'yes', if no - type 'no'");
            //string isFetaAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add beans? - if so type 'yes', if no - type 'no'");
            //string isBeansAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add sauce? - if so type 'yes', if no - type 'no'");
            //string isSauceAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add tomato? - if so type 'yes', if no - type 'no'");
            //string isTomatoAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add cucumber? - if so type 'yes', if no - type 'no'");
            //string isCucumberAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add bacon? - if so type 'yes', if no - type 'no'");
            //string isBaconAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add chili? - if so type 'yes', if no - type 'no'");
            //string isChiliAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add butter? - if so type 'yes', if no - type 'no'");
            //string isButterAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add peas? - if so type 'yes', if no - type 'no'");
            //string isPeasAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add mozzarella? - if so type 'yes', if no - type 'no'");
            //string isMozzarellaAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add parmesan? - if so type 'yes', if no - type 'no'");
            //string isParmesanAdded = Console.ReadLine();
            //Console.WriteLine("Would you like to add rocket? - if so type 'yes', if no - type 'no'");
            //string isRocketAdded = Console.ReadLine();

            if (breadType == "dark bread" || breadType == "white bread")
            {
                double priceDarkBread = 1;
                sumustinioSuma += priceDarkBread;
                sumustinioIngridientai += breadType;
                Console.WriteLine($"Your bread costs {priceDarkBread}");
            }
            if (isSalamiAdded == "yes")
            {
                double priceSalami = 0.5;
                sumustinioSuma += priceSalami;
                sumustinioIngridientai += ", Salami";
                Console.WriteLine($"Your salami costs {priceSalami}");
            }

            Console.WriteLine($"Your total price is {sumustinioSuma}");
            Console.WriteLine($"Your chosen ingridients are {sumustinioIngridientai}");
            */



        }
    }
}