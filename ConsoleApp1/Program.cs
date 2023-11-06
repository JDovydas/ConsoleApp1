using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            //Paskaita nr. 1
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            int number = 0;
            int numberTwo = 3;

            int sum = number + numberTwo;

            //Task 1

            Console.ResetColor();

            Console.WriteLine("             /\\");
            Console.WriteLine("            /  \\");
            Console.WriteLine("           /    \\");
            Console.WriteLine("          /______\\ ");

            Console.WriteLine("          \ntab ");
            Console.WriteLine("          \ntab\ntab\ntab\ntab\ntab ");
            Console.WriteLine("          \ttab\ttab\ttab\ttab\ttab ");


            //Task 2

            Console.WriteLine("     *****     ");
            Console.WriteLine("   **     **   ");
            Console.WriteLine(" **         **");
            Console.WriteLine("**   Hello   **");
            Console.WriteLine("**    from   **");
            Console.WriteLine(" **   C#    **");
            Console.WriteLine("   **     **");
            Console.WriteLine("     *****");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;

            Console.ResetColor();

            //Task 3


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             /\\");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            /  \\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("           /    \\");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("          /______\\ ");

            //Task 4

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   /  \\    /  \\     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  /    \\  /    \\");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  \\     \\/     /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   \\          /");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("    \\        /");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     \\      /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      \\    /");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("       \\  /");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        \\/   ");

            //Task 5

            string Preke = "Obuolys";
            int Kiekis = 5;
            int Kaina = 2;
                      
            Console.WriteLine("Preke: " + Preke + "\nKiekis: " + Kiekis + "\nKaina: " + Kaina);

            //Task 6

            string Vardas = "Vardenis Pavardenis";
            int Amzius = 28;
            string Pareigos = "Software Developer";
            string Epastas = "johndoe@example.com";
            string Tel = "+1 123-456-7890";

            Console.WriteLine("Vardas: " + Vardas + "\nAmzius: " + Amzius + "\nPareigos: " + Pareigos + "\nE. pastas: " + Epastas + "\nTel: " + Tel);

            


            //Paskaita nr. 2

            //Practice

            //                  0    1    2    3    4    5
            char[] cityArr = { 'K', 'a', 'u', 'n', 'a', 's' };
            string city2 = new string(cityArr);
            Console.WriteLine(city2);
            string city = "Kaunas";
            int lenghtOfCity = city.Length;
            Console.WriteLine(city);
            Console.WriteLine(city[0].ToString() + city[1] + city[2] + city[3] + city[5]);
            ///Console.WriteLine(cityArr.Length);
            ///Console.WriteLine(new string(cityArr));
            ///Console.WriteLine(city[0]);

            //Task nr.1

            /*
            string name = "Dovydas";
            Console.WriteLine(name);
            Console.WriteLine(name[3]);
            Console.WriteLine(name.Length);


            string name1 = "CodeAcademy";

            name.IndexOf(name1, lenghtOfCity);

            string city = "Kaunas";
            string partOfWord = city.Substring(0, (city.Length / 2));

            

            
            string FullName = "Dovydas Juodys";
            int SurnameIndex = FullName.IndexOf("J");

            Console.WriteLine(FullName.Substring(SurnameIndex));

            string partofCity = city.Substring(3, 3);

            int KurAntraRaide = city.IndexOf("un");

            string Miestas = "   Siauliai  Y";

            Console.WriteLine(Miestas.Trim());

            */

            /*

            Console.WriteLine("Write a city name");
            string city1 = Console.ReadLine();


            Console.Clear();


            string word1 = "is";
            string word2 = "a";
            string word3 = "city";

            Console.WriteLine("Replace city with: ");

            string input = Console.ReadLine(); 

            Console.Clear();

            //string result = city + " " + word1 + " " + word2 + " " + word3;

            string result = "";

            result += city1;
            result += " ";
            result += word1;
            result += " ";
            result += word2;
            result += " ";
            result += word3;

            Console.WriteLine(result);

            //Check if there is a combination of characters in the variable
            Console.WriteLine(result.Contains("dog"));

            */
            /*

            Console.WriteLine("Replace city with: ");

            string input = Console.ReadLine();

            Console.Clear();

               
            string word1 = "is";
            string word2 = "a";
            string word3 = input;


            Console.WriteLine("Write a "+ word3 + " name");

            string city = Console.ReadLine() ;

            Console.Clear();
           

           string print = "";

            print += city;
            print += " ";
            print += word1;
            print += " ";
            print += word2;
            print += " ";
            print += word3;

            Console.WriteLine(print);

            */


            //Task 1

            string sentence = "My name is Dovydas";

            int lengthOfSentence = sentence.Length;

            
            Console.WriteLine(sentence[2]);
            Console.WriteLine(sentence.Length);

            int nameLetterIndex = sentence.IndexOf("D");
            Console.WriteLine(sentence.IndexOf("D"));
            Console.WriteLine(sentence.Substring(nameLetterIndex));

            int LetterIndex = sentence.IndexOf("M");
            Console.WriteLine(sentence.Substring(LetterIndex,2));


            string newSentence = sentence.Substring(LetterIndex+6);

            string upperSentence = sentence.ToUpperInvariant();
            string lowerSentence = sentence.ToLowerInvariant();

            Console.WriteLine(upperSentence);
            Console.WriteLine(lowerSentence);
            Console.WriteLine(sentence.Trim());

            Console.WriteLine(sentence.IndexOf('d'));


            //Paskaita nr. 3










        }


    }
}