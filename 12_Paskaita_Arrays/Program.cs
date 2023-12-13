using System.Drawing;
using System.Runtime.ExceptionServices;

namespace _12_Paskaita_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    
            int[] numbers = new int[10];
            int[] numbers2 = {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            */

            //for (int i = 0;i < numbers2.Length; i++)
            //{
            //    numbers[i] = numbers2[i];
            //}


            // Task 1 A

            /*
            
            int[] numbersAdded = {1, 2, 3};
            
            //for (int i = 0; i < numbersAdded.Length; i++)
            //{
            //    Console.WriteLine(numbersAdded[i]);
            //}

            int[] squaredValues = NumbersSquared(numbersAdded);

            for (int i = 0; i < squaredValues.Length; i++)
            {
                Console.WriteLine(squaredValues[i]);
            }
            */

            // Task 1 B

            /*            
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int sumOfArrayValues = NumbersSummed(originalArray);

            Console.WriteLine("The sum of all the elements of the array is: " + sumOfArrayValues);
            */


            // Task 1 C
            /*
            int[] givenArray = { 1, 3, 9, 2, 16 };
            int highestValue = HighestOfArray(givenArray);

            Console.WriteLine(highestValue);
            */

            // Task 1 D
            /*
            int[] initialArray = { 1, 3, 9, 2, 16 };

            int[] reversedArray = ReversedArray(initialArray);

            Console.WriteLine(ReversedArray(initialArray));
            */
            // 2.1
            /*
            string text = "Hello";
            GetChar(text);
            */
            //2.2
            /*
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            char output = FirstLetter(text);

            Console.WriteLine(output);
            */
            //2.3
            /*
            //Console.WriteLine("Enter the text");
            string text = "namas";
            char lastLetter = LastLetter(text);
            Console.WriteLine(lastLetter);
            
            */

            //My Exercise

            string[] cards = {"Queen", "King"};
            string[] colors = {"Black", "Red"};

            int index = ReturnArrayLength(cards, colors);

            string[] allCombinations = CombinationMethod(cards,colors, index);

            foreach (string i in allCombinations)
            {
                Console.WriteLine(i);
            }
            
            
            //Console.WriteLine(combinations);


        }

        public static int[] NumbersSquared(int[] numbersAdded) //Method should start with CAPITAL letter
        {
            int[] newArray = new int[numbersAdded.Length];
            for (int i = 0; i < numbersAdded.Length; i++)
            {
                newArray[i] = numbersAdded[i] * numbersAdded[i];
            }
            return newArray;
        }


        public static int NumbersSummed(int[] numberofArray)
        {
            int sumOfArrayValues = 0;
            for (int i = 0;i < numberofArray.Length; i++)
            {
                sumOfArrayValues += numberofArray[i];
                Console.WriteLine(numberofArray[i] + " added to the previous number is eaqual to " + sumOfArrayValues);
            }
            return sumOfArrayValues;

        }

        public static int HighestOfArray(int[] givenArray)
        {
            int highest = givenArray[0];
            for (int i = 1; i< givenArray.Length; i++)
            {
                if (givenArray[i] > highest)
                {
                    highest = givenArray[i];
                }
            }
            return highest;

        }

        /*
        public static int[] ReversedArray(int[] initialArray)
        {
            for (int i = 0; i < initialArray.Length - 1; i--)
            {

                {
                    Console.WriteLine(initialArray[i] + " ");
                }
            }
            Console.WriteLine();
        }

        */

        static void GetChar(string text)
        {
            char[] charArray = text.ToCharArray();
            //char[] result = new char[text.Length];
            for (int i = 0; i < charArray.Length ; i++)
            {               
                Console.Write(charArray[i] + ", ");
            }

        }

        static char FirstLetter(string text)
        {
            char[] charArray = text.ToCharArray();

            return charArray[0];
        }

        
        static char LastLetter(string text)
        {

            char[] charArray = text.ToCharArray();

            return charArray[charArray.Length-1];
            //for (int i = charArray.Length - 1; i >= 0; i--)
            //{
            //    return charArray[i];
            //}

        }

        static string[] CombinationMethod(string[] cards, string[] colors, int index)
        {
            string[] allCombinations = new string[index];
            int counter = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                for (int j =  0; j < colors.Length; j++)
                {
                    allCombinations[counter] = colors[j] + " " + cards[i];
                    counter++;
                }
            }
            return allCombinations;         
          
        }

        static int ReturnArrayLength(string[] cards, string[] colors)
        {
            int index = 0;
            foreach (string card in cards)
            {
                foreach (string color in colors)
                {
                    index++;
                }
                    
            }
            return index;
                

        }
        


    }
}