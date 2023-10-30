namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            





        }


    }
}