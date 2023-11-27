using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _11_Paskaita_Debug_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();

            MeasureTime(Haroldas2);




            //Exercise 6 A

            /*
            Console.WriteLine("Enter a string: ");
            string textToReverse = Console.ReadLine();
            string reverse = StringBuilderReverse(textToReverse);
            */

            /*
            Console.WriteLine("Enter text: ");
            string textToReverse = Console.ReadLine();
            StringBuilder sb = new StringBuilder(textToReverse.Length);
            for (int i = textToReverse.Length - 1; i >= 0; i--) 
            {
                sb.Append(textToReverse[i]);
            }
            Console.WriteLine(sb.ToString());
            */

            //Exercise 6 B

            /*
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string output = removeDuplicates(input);
            Console.WriteLine("Removed duplicates are as follows: " + output);
            Console.ReadLine();
            */


            /*
            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            string text = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                text += "+";
            }
            string text = sb.ToString();

            //string html = FromHTML();

            sw.Stop();
            Console.WriteLine($"It took {sw.ElapsedMilliseconds} ms to form a html string");
            string html = FromHTML;
            string fileName = "Hello.html";


            WriteToFile(html, fileName);
        }

        static void WriteToFile(string text, string fileName)
        {
            if (string.IsNullOrEmpty(text))
            {
                PrintError("Text is null or empty");
                return;
            }
            if (string.IsNullOrEmpty(fileName))
            {
                PrintError("fileName is null or empty");
                return;
            }
            File.WriteAllText(fileName, text);
        }

        static string FromHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("<h1>Code your future! .NETUA3</h1>");
            sb.AppendLine("<p>CodeAcademy programming academy - the most direct path to a career in Technology!</p>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();


        }


        /*
        Stopwatch sw = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();

        for (int i= 0; i < 1000; i++)
        {
            text += "+";
        }
        string text = string.Empty;

        sw.Stop();
        Console.WriteLine($"iT TOOK {sw.ElapsedMilliseconds} ms to form a html string");
        string fileName = "Hello.html";
        WriteToFile(html, fileName);
        string html = FormHTML();

    }

    static void WriteToFile(string text, string fileName)
    {
        if (string .IsNullOrEmpty(text))
        {
            PrintError("Text is null or empty");
            return;
        }
        if (string.IsNullOrEmpty(fileName))
        {

        }
        */
        }


        static void Task1()
            {
                int a = 10;
                int b = 5;
                int c = 8;

                int max = a;
                if (b > max)
                    max = b;
                if (c > max)
                    max = b; //klaida - reikia priskirti "C" reiksmei
                Console.WriteLine("The maximum value is " + max);
            }

        static void Task2()
            {
                string firstName = "John";
                string lastName = "Doe";
                string fullName = firstName + " " + lastName;
                Console.WriteLine("Full Name: " + fullName);

            }

        static void Task3()
            {
                int counter = 0;
                while (counter <= 10)
                {
                    Console.WriteLine("Count: " + counter);
                    counter++;

                }
            }

        static void Task4()
            {
                int i = 1;
                while (i <= 5)
                {
                    Console.WriteLine(i);
                    i++;
                }

            }

        static void Task5()
            {
                string name1 = "John";
                string name2 = "john";

                if (name1.ToLower() == name2.ToLower())
                {
                    Console.WriteLine("Names are the same.");
                }
                else
                {
                    Console.WriteLine("Names are different.");
                }

            }


        public static string StringBuilderReverse(string textToReverse)
        {
            StringBuilder sb = new StringBuilder(textToReverse.Length);
            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                sb.Append(textToReverse[i]);
            }
            return sb.ToString();
        }


        public static string removeDuplicates(string input)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sbOutput = new StringBuilder();
            sb.Append(input);
            for (int i = 0; i < sb.Length; i++)
            {
                if (!sbOutput.ToString().Contains(sb[i]))
                {
                    sbOutput.Append(sb[i]);
                }

            }
            return sbOutput.ToString();



        }

            
        static void MeasureTime(Func<string> method)
        {
            Stopwatch sw = Stopwatch.StartNew();

            method();
            sw.Stop();
            Console.WriteLine(method.Method.Name + "Took: : \t\t" + sw.Elapsed);

        }

        public static string Haroldas2()
        {
            string output = string.Empty;
            string text = File.ReadAllText("longest 1.txt");
            for (var i = 0; i < text.Length; i++) 
            {
             if (!output.Contains(text[i])) 
                output += text[i];
            }
            return new string(output);
        }
            

    }
}
