using System;
using System.Globalization;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Turime vardus ir pavardes - reikia padaryti 1.) visas įmanomas vardų ir pavardžių kombinacijas 2.) Išspausdinti tik tuos vardus ir pavardes (kombinacijas), kurie yra ilgiausi.

            string[] names = new string[] { "Petras", "Jonas", "Gediminas", "Albinas", "Juozas" };
            string[] surnames = new string[] { "Katkus", "Pimpadryrius", "Kakadumbas", "Juozapaitis", "Nauseda", "Gerulis" };

            int numberOfCombinations = GetCount(names, surnames);

            string[] combinations = GetCombinations(numberOfCombinations, names, surnames);

            foreach (string combination in combinations)
            {
                Console.WriteLine(combination);
            }

            int maxLetters = MaxLetters(combinations);

            int numberOfLongersWords = CountofLongestWords(combinations, maxLetters);


            string[] LongestWords = LongestWord(combinations, numberOfLongersWords, maxLetters);

            foreach (string word in LongestWords)
            {
                Console.WriteLine($"Igiausas vardo ir pavardės žodis yra {word}, si zodi sudaro {maxLetters} characters ");
            }




            //int NumberofMaxLetterWords = CountofMaxLettersWords()



        }


        //Paskaita nr. 1

        /*

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("          /\\");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("         /  \\");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("        /    \\");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("       /______\\");
        Console.ForegroundColor = ConsoleColor.White;

        string preke = "Obuolys";
        int kiekis = 5;
        int kaina = 2;

        Console.WriteLine($"Preke: {preke}");
        Console.WriteLine($"Kiekis: {kiekis}");
        Console.WriteLine($"Kaina: {kaina} eur");



        string vardas = "Vardenis Pavardenis";
        int amzius = 28;
        string pareigos = "Sofware Developer";
        string ePastas = "johndoe@example.com";
        var tel = "+1 123-456-7890";

        Console.WriteLine($"Vardas: {vardas}");
        Console.WriteLine($"Amzius: {amzius}");
        Console.WriteLine($"Pareigos: {pareigos}");
        Console.WriteLine($"E. Pastas: {ePastas}");
        Console.WriteLine($"Tel.: {tel}");

        //Paskaita nr. 2

        */
        /*
        string gimtine = "Sutkunai";
        char gimtine2 = gimtine[3];
        int kazkas = gimtine.IndexOf('k');
        int gimtineIlgis = gimtine.Length;
        Console.WriteLine(gimtine2 + " yra trecioji zodzio" + gimtine + " Raide");
        Console.WriteLine(gimtine[2]);
        Console.WriteLine(gimtine2);
        Console.WriteLine(gimtineIlgis);
        string galas = gimtine.Substring(3, 2);
        string kunai = gimtine.Substring(kazkas);
        Console.WriteLine(kunai);

        */

        /*
        string manoVardas = "My name is Dovydas Juodys";
        int vardasLocation = manoVardas.IndexOf("Dovydas"); //Writ the full name to do not pick any previous letter "D"
        int pavardeLocation = manoVardas.IndexOf('J');
        int diffNameSurname = pavardeLocation - vardasLocation;
        Console.WriteLine(manoVardas.Substring(vardasLocation, diffNameSurname));
        Console.WriteLine(manoVardas.Substring(0,2));
        Console.WriteLine(manoVardas.IndexOf('n', 5));



        string spaces = "   wth you want  ";
        string correction = spaces.Trim();
        Console.WriteLine(spaces);
        Console.WriteLine(correction);

        */
        /*
        string result = "";

        result += "one ";
        result += "two ";
        result += "one ";

        Console.WriteLine(result);

        Console.WriteLine("Good afternoon".Length);

        string city = "Vilnius";
        Console.WriteLine(city[2]);
        Console.WriteLine(city.Substring(2, 4));
        string lowercaseCity = city.ToLower();
        Console.WriteLine(lowercaseCity.LastIndexOf("v"));
        */

        /*

        string city = "uncle";
        Console.WriteLine(city.Replace("u","m"));

        int n = 123456;
        string convN = n.ToString();
        int convertNBack = Convert.ToInt32(convN);

        int suma = n + convertNBack;
        Console.WriteLine(suma);

        */

        /*

        Console.WriteLine("Enter your number");
        int skaicius = Convert.ToInt32(Console.ReadLine());

        if (skaicius > 100)
        {
            Console.WriteLine("Skaicius didesnis nei 100");
        }
        else if (skaicius == 100)
        {
            Console.WriteLine("The number is equal to 100");
        }
        else 
        {
            Console.WriteLine("The number is less than 100");
        }

        */
        /*

        Console.WriteLine("Iveskite dienos numeri");
        int diena = Convert.ToInt32(Console.ReadLine());

        if (diena == 1)
        {
            Console.WriteLine("Pirmadienis");
        }
        else if (diena == 2)
        {
            Console.WriteLine("Antradienis");
        }
        else if(diena == 3) 
        {
            Console.WriteLine("Treciadienis");
        }
        else if (diena == 4)
        {
            Console.WriteLine("Ketv");
        }

        */
        /*


        Console.WriteLine("Enter Number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("You number is divisible by 5");
        }
        else 
        {
            Console.WriteLine("No criterie met"); 
        }
        */

        /*

        var manoSlaptazodis = "abcde123";

        Console.WriteLine("Enter your passowrd");
        string passEntered = Console.ReadLine();

        if (passEntered == manoSlaptazodis || passEntered == "Mellon")
        {
            Console.WriteLine("You have successfully logged in");
        }
        else if (passEntered == "01101001 01101110")
        {
            Console.WriteLine("Hacked..");
        }
        else
        {
            Console.WriteLine("Password is incorrect, please try again...");
        }

        */

        /*

        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("Minor");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("Adult");
        }
        else if (age >=65)
        { 
            Console.WriteLine("Senior"); 
        }

        */
        /*

        Console.WriteLine("Enter years");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years % 4 == 0 && years % 100 != 0 || years % 400 == 0)
        {
            Console.WriteLine("This is a leap year");
        }
        else 
        {
            Console.WriteLine("This is not a leap year");
        }
        */

        /*

        Console.WriteLine("Enter 3 numbers that represent sides of triangle");
        int side1 = Convert.ToInt32(Console.ReadLine());
        int side2 = Convert.ToInt32(Console.ReadLine());
        int side3 = Convert.ToInt32(Console.ReadLine());

        if ((side1 + side2) > side3 && (side1 + side3) > side2 && (side3 + side2) > side1)
        {
            Console.WriteLine("Can form a triangle");
        }
        else
        {
            Console.WriteLine("Cannot form a triangle");
        }

        */

        /*

        string basket = "";
        int price = 0;

        string produktas1 = "Kepalas duonos";
        int produktas1Kaina = 1;
        string produktas2 = "Stiklainis Pieno";
        int produktas2Kaina = 2;
        string produktas3 = "Kilogramas Kiaulienos";
        int produktas3Kaina = 3;

        Console.WriteLine($"Šiuo metu turime šiuos produktus:\n {produktas1} - kaina {produktas1Kaina} EUR\n {produktas2} - kaina {produktas2Kaina} EUR\n {produktas3} - kaina {produktas3Kaina} EUR");

        Console.WriteLine("Pasirinkite pirmąjį produktą įrašydami jo pavadinimą");
        string pirkinys1 = Console.ReadLine();
        Console.WriteLine($"Pirmasis pasirinktas pirkinys {pirkinys1}");

        if (pirkinys1 == "Kepalas duonos")
        {
            Console.WriteLine($"Kaina: {produktas1Kaina} EUR");
            basket += pirkinys1;
            price += produktas1Kaina;
        }
        if (pirkinys1 == "Stiklainis Pieno")
        {
            Console.WriteLine($"Kaina: {produktas2Kaina} EUR");
            basket += produktas2;
            price += produktas2Kaina;
        }
        if (pirkinys1 == "Kilogramas Kiaulienos")
        {
            Console.WriteLine($"Kaina: {produktas3Kaina} EUR");
            basket += produktas3;
            price += produktas3Kaina;
        }

        Console.WriteLine("Pasirinkite antrąjį produktą įrašydami jo pavadinimą");
        string pirkinys2 = Console.ReadLine();
        Console.WriteLine($"Antrasis pasirinktas pirkinys {pirkinys2}");

        if (pirkinys2 == "Kepalas duonos")
        {
            Console.WriteLine($"Kaina: {produktas1Kaina} EUR");
            basket += pirkinys1;
            price += produktas1Kaina;
        }
        if (pirkinys2 == "Stiklainis Pieno")
        {
            Console.WriteLine($"Kaina: {produktas2Kaina} EUR");
            basket += produktas2;
            price += produktas2Kaina;
        }
        if (pirkinys2 == "Kilogramas Kiaulienos")
        {
            Console.WriteLine($"Kaina: {produktas3Kaina} EUR");
            basket += produktas3;
            price += produktas3Kaina;
        }


        Console.WriteLine($"Produktai krepšelyje: {basket}, viso {price} EUR");

        if (pirkinys1 == pirkinys2)
        {
            double updatedPrice = price * 0.9;
            Console.WriteLine($"Jums galioja 10% nuolaida, galutine kaina yra {updatedPrice} EUR");
        }
        else
        {
            Console.WriteLine("Nepasirinkote dvieju vienodu produktu, nuolaidos negausute");
        }

        */

        /*

        Console.WriteLine("Input weekday number");
        int weekday = Convert.ToInt32(Console.ReadLine());

        switch (weekday)
        {
            case (1):
                Console.WriteLine("Pirmadienis");
                break;
            case (2):
                Console.WriteLine("Antradienis");
                break;
            case (3):
                Console.WriteLine("Treciadienis");
                break;
        }

        */

        /*

        Console.WriteLine("Your age");
        int age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case >= 7 and < 18:
                Console.WriteLine("Pupil");
                break;
            case >= 18 and < 66:
                Console.WriteLine("Worker");
                break;
            case >= 66:
                Console.WriteLine("Senior");
                break;


        }


        */

        /*

        Console.WriteLine("Select the mathematical operation: +,-");
        string operation = Console.ReadLine();
        Console.WriteLine("Enter number 1");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case "+":
                int sum = num1 + num2;
                Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
                break;
            case "-":
                int minus = num1 - num2;
                Console.WriteLine($"min of {num1} and {num2} is {minus}");
                break;
        }

        */

        /*

        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        char [] masyvas = text.ToCharArray();
        masyvas[0] = char.ToUpper(masyvas[0]);
        Console.WriteLine(masyvas);

        */
        /*
        Console.WriteLine("Enter text");
        string yourText = Console.ReadLine();
        char[] yourTextToArray = yourText.ToCharArray();
        yourTextToArray[2] = 'g';
        yourTextToArray[4] = 'b';
        yourTextToArray[6] = '*';
        yourTextToArray[8] = 'x';
        yourTextToArray[10] = 'w';
        string backToString = new string (yourTextToArray);
        Console.WriteLine(yourTextToArray);

        */

        /*

        Console.WriteLine("Enter word");
        string input = Console.ReadLine();
        char[] newinput = input.ToCharArray();
        Array.Reverse(newinput);

        if (input == "Hello")
        {


            Console.WriteLine(newinput);
        }

        */

        /*

        Console.WriteLine("Enter a word");
        string input = Console.ReadLine();
        char[] inputArray = input.ToCharArray();



        if (char.IsUpper(inputArray[0]))
        {
            Console.WriteLine("Your word starts with capital letter, thus we translate" + char.ToUpper(inputArray));
        }


        Console.WriteLine("How many minutes you have been on the phone?");
        int timeSpent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Call to number: {})

        */

        static int GetCount(string[] names, string[] surnames)
        {
            int count = 0;
            foreach (string name in names)
            {
                foreach (string surname in surnames)
                {
                    count++;

                }
            }
            return count;
        }

        static string[] GetCombinations(int numberOfCombinations, string[] names, string[] surnames)
        {
            int index = 0;
            string[] combinations = new string[numberOfCombinations];

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < surnames.Length; j++)
                {
                    combinations[index] = names[i] + " " + surnames[j];
                    index++;
                }


            }
            return combinations;



        }

        //static string[] MaxLengthWord(string s) { }

        static int MaxLetters(string[] combinations)
        {
            int maxLetters = 0;
            foreach (string name in combinations)
            {
                int currentValue = name.Length;
                if (currentValue > maxLetters)
                {
                    maxLetters = currentValue;
                }
            }
            return maxLetters;


        }

        static int CountofLongestWords(string[] combinations, int maxLetters)
        {
            int numberOfLongestWords = 0;
            foreach (string name in combinations)
            {
                if (name.Length == maxLetters)
                {
                    numberOfLongestWords++;
                }
            }
            return numberOfLongestWords;
        }


        static string[] LongestWord(string[] combinations, int numberOfLongestWords, int maxLetters)
        {
            int index = 0;
            string[] stringOfLongestWord = new string[numberOfLongestWords];
            foreach (string name in combinations)
            {
                if (name.Length == maxLetters)
                {
                    stringOfLongestWord[index] = name;
                    index++;
                }
            }
            return stringOfLongestWord;


        }

        //public static void SaveUserToFile(CardHolder cardHolder)
        //{
        //    using (StreamWriter writer = new StreamWriter("Guid.txt", true))
        //    {
        //        writer.WriteLine($"{cardHolder.CardNumber},{cardHolder.Name},{cardHolder.Surname},{cardHolder.Password},{cardHolder.Account.Balance}");
        //    }
        //}


    }
}