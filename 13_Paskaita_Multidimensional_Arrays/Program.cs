using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace _13_Paskaita_Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   //                      [row, column]                           
            /*int[,] matrix = new int[3, 3];

            matrix[0, 0] = 1;// 1   2   3
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;

            matrix[1, 0] = 4;// 4   5   6
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;

            matrix[2, 0] = 7;// 7   8   9
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;


            for (int i = 0; i < matrix.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // changes the columns
                {
                    matrix[i, j] = matrix[i, j];
                }

            }


            for (int i = 0; i < matrix.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // changes the columns
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            /*
            for (int i = 0; i < matrix.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // changes the columns
                {
                    matrix[i, j] = "*";
                }
                Console.WriteLine();
            }
            */

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            ReturnAverage(array);

            Console.WriteLine(ReturnAverage(array));

            /*
            int[] initialArray = { 1, 3, 9, 2, 16 };

            foreach (int number in initialArray)
            {
                Console.WriteLine(number);

            }
            */

            //Task 2.1
            /*
            

            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column");
            int column = int.Parse(Console.ReadLine());

            int[,] array = new int[row, column];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadRight(2));
                }
                Console.WriteLine();
            }
            */
            //Task 2.2
            /*
            int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {1, 9, 10, 11},
            {12, 13, 14, 1}
            };

            FindAndDisplayRepeatedNumbers(array);
            */
            //Task 2.3
            /*
            string[,] array3 = {
            {"Jonas", "Alina", "Petras"},
            { "Kazys", "Antanas", "Alina" },
            { "Rima", "Jonas", "Petras" }
            };

            FindAndDisplayRepeatedNames(array3);
            */
            //Task 2.4

            /*

            int[,] a = new int[3, 3];

            int[,] b = new int[3, 1];

            a[0, 0] = 1;// 1   2   3
            a[0, 1] = 2;
            a[0, 2] = 3;

            a[1, 0] = 4;// 4   5   6
            a[1, 1] = 5;
            a[1, 2] = 6;

            a[2, 0] = 7;// 7   8   9
            a[2, 1] = 8;
            a[2, 2] = 9;

            b[0, 0] = 2;// 2
            b[1, 0] = 3;// 3
            b[2, 0] = 4;// 4

            int[,] resultMatrix = MultiplyMatrices(a, b);


            //b[1, 0] = 2;
            //b[1, 1] = 3;
            //b[1, 2] = 4;

            //b[2, 0] = 2;
            //b[2, 1] = 3;
            //b[2, 2] = 4;

            for (int i = 0; i < a.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < a.GetLength(1); j++) // changes the columns
                {
                    a[i, j] = a[i, j];
                }

            }


            for (int i = 0; i < a.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < a.GetLength(1); j++) // changes the columns
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < b.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < b.GetLength(1); j++) // changes the columns
                {
                    b[i, j] = b[i, j];
                }

            }


            for (int i = 0; i < b.GetLength(0); i++) // changes the rows
            {
                for (int j = 0; j < b.GetLength(1); j++) // changes the columns
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

            */

            //Task 3.1
            /*

            int[,] c = new int[3, 3];

            c[0, 0] = 1;// 1   2   3
            c[0, 1] = 2;
            c[0, 2] = 3;

            c[1, 0] = 4;// 4   5   6
            c[1, 1] = 5;
            c[1, 2] = 6;

            c[2, 0] = 7;// 7   8   9
            c[2, 1] = 8;
            c[2, 2] = 9;

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = c[i, j];
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0;j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            FindAndDisplayMaxValue(c);

            */

            //Task 3.3
            /*
            Console.WriteLine("Please enter how many animals you want to add: ");
            string inputStr = Console.ReadLine();
            if 
            */
            /*

            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column");
            int column = int.Parse(Console.ReadLine());

            int[,] array = new int[row, column];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadRight(2));
                }
                Console.WriteLine();
            }

            */


            //Task 1.1

            /*
            
            int[] numbers = { 1, 2, 3, 4, 5 };

            double average = CalculateAverage(numbers);

            Console.WriteLine(average);
            
            */
            //Task 1.2
            /*

            int[] inputArray = { 1, -2, 3, -4, 5 };

            int[] positiveNumbers = GetPositiveNumbers(inputArray);

            for (int i = 0; i < positiveNumbers.Length; i++)
            {
                Console.WriteLine(positiveNumbers[i]);
            }

            foreach (int number in inputArray)
            {
                if (number > 0)
                {
                    Console.WriteLine(number);
                }
            }
            */
            //Task 1.3

            /*

            int[] arrayOfPayments = { 1, 200, 30, 55 };

            double vatToBePaid = ReturnVat(arrayOfPayments);

            Console.WriteLine($"The VAT you have to pay is {vatToBePaid}");
            
            */

            //Task 1.4
            /*
            string userSentence = Console.ReadLine();

            string[] wordsArray = userSentence.Split(" ");

            string[] validatedSentence = TextValidator(wordsArray);

            for (int i = 0; i < validatedSentence.Length; i++)
            {
                Console.WriteLine(validatedSentence[i]);

            }
            
            string concatinatedWords = string.Join(" ", validatedSentence);

            Console.WriteLine(concatinatedWords);
        
            */
            //Task 1.4 B

            /*
            string userSentence = "Hello guys my name is Voldemortas";
            string[] wordArray = userSentence.Split(' ');
            string[] stringArray = new string[wordArray.Length];
            int lettersNeeded = 5;
            int 
            = 0;
            foreach (string word in wordArray)
            {
                if (word.Length > lettersNeeded)
                {
                    stringArray[index] = word;
                    index++;
                }
            }

            string[] fileteredArray = new string[index];
            Array.Copy(stringArray, fileteredArray, index);
            foreach (string word in fileteredArray)
            {
                Console.WriteLine(word);
            }
            */

            //Task 1.5
            /*
            deckFace = new string[] { "Queen", "King", "Ace", "Joker" };
            deckType = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
            */

        }


        /*
        static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (double)sum / numbers.Length;

        }
        */
        static int[] GetPositiveNumbers(int[] inputArray)
        {

            int positiveCount = 0;
            foreach (int number in inputArray)
            {
                if (number > 0)
                {
                    positiveCount++;
                }

            }


            int[] positiveNumbersArray = new int[positiveCount];

            int index = 0;

            foreach (int number in inputArray)
            {
                if (number > 0)
                {
                    positiveNumbersArray[index] = number;
                    index++;
                }
            }

            return positiveNumbersArray;

        }
        static double ReturnVat(int[] arrayOfPayments)
        {
            double sum = 0;
            double vat = 0.15;

            foreach (int number in arrayOfPayments)
            {
                sum += number;

            }
            return (double)sum * vat;

        }

        static string[] TextValidator(string[] UserSentenceArray)
        {

            int goodLengthWords = 0;
            foreach (string goodLengthWord in UserSentenceArray)
            {
                if (goodLengthWord.Length >= 5)
                {
                    goodLengthWords++;
                }
            }


            string[] newArray = new string[goodLengthWords];
            int index = 0;
            foreach (string word in UserSentenceArray)
            {
                if (word.Length >= 5)
                {
                    newArray[index++] = word;

                }
            }
            return newArray;
        }


        static void FindAndDisplayRepeatedNumbers(int[,] array)
        {

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);


            int[] uniqueNumbers = new int[rows * cols];
            int[] repeatedNumbers = new int[rows * cols];
            int repeatedCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentNumber = array[i, j];

                    if (Array.IndexOf(uniqueNumbers, currentNumber) != -1)
                    {
                        // If not unique, add to the repeatedNumbers array
                        repeatedNumbers[repeatedCount++] = currentNumber;
                    }
                    else
                    {
                        // If unique, add to the uniqueNumbers array
                        uniqueNumbers[i * cols + j] = currentNumber;
                    }
                }

            }

            Array.Resize(ref repeatedNumbers, repeatedCount);

            // Display the result
            Console.WriteLine("Repeated Numbers:");
            foreach (var number in repeatedNumbers)
            {
                Console.Write(number + " ");
            }

        }

        static void FindAndDisplayRepeatedNames(string[,] array3)
        {
            int rows = array3.GetLength(0);
            int cols = array3.GetLength(1);

            string[] uniqueNames = new string[rows * cols];
            string[] repeatedNames = new string[rows * cols];
            int repeatedCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string currentName = array3[i, j];

                    // Check if the name is already in the uniqueNames array (indicating a repeat)
                    if (Array.IndexOf(uniqueNames, currentName) != -1)
                    {
                        // If not unique, add to the repeatedNames array
                        repeatedNames[repeatedCount++] = currentName;
                    }
                    else
                    {
                        // If unique, add to the uniqueNames array
                        uniqueNames[i * cols + j] = currentName;
                    }
                }
            }

            // Resize the repeatedNames array to the actual count of repeated names
            Array.Resize(ref repeatedNames, repeatedCount);

            // Display the result
            Console.WriteLine("Repeated Names:");
            foreach (var name in repeatedNames)
            {
                Console.Write(name + " ");
            }

        }
        static int[,] MultiplyMatrices(int[,] a, int[,] b)
        {
            //if (a.GetLength(1) != b.GetLength(0))
            //{
            //    return null;
            //}

            // Perform matrix multiplication
            int[,] resultMatrix = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return resultMatrix;


        }

        static void FindAndDisplayMaxValue(int[,] c)
        {
            int rows = c.GetLength(0);
            int cols = c.GetLength(1);

            int maxValue = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentValue = c[i, j];

                    if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                        maxRow = i;
                        maxCol = j;
                    }
                }

            }
            Console.WriteLine($"Maximum Value: {maxValue}");
            Console.WriteLine($"Position (Row, Column): ({maxRow}, {maxCol})");

        }

        static double ReturnAverage(int[] array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                sum += item;
            }
            return (double)sum / array.Length;
        }







    }
}