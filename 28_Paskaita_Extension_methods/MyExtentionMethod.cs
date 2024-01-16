using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_Paskaita_Extension_methods
{
    internal static class MyExtentionMethod // static - no need to initiate, called without initiatlization
    {
        public static bool IsLetters(this string str)
        {
            return str.All(char.IsLetter);
        }

        public static int WordCount(this string str, char splitBy)
        {
            return str.Split(splitBy).Length;
        }


        public static bool IsNumberPositive(this int number)
        {
            if (number < 0)
            {
                return false;
            }
            else
                return true;
        }

        public static bool IsNumberEven(this int number)
        {
            if ((number % 2) == 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsYourNumberGreater(this int number, int input)
        {

            if (input > number)
            {
                Console.WriteLine("Your entered number is greater than the system's number");
                return true;

            }
            else
            {
                return false;
            }



        }

        //6
        public static bool FindAndReturnIfEqual<T>(this List<T> initialList, T objectToCheck)
        {
            if (initialList.Contains(objectToCheck))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool DoesSentenceContainSpaces(this string sentence)
        {
            return sentence != null && sentence.Contains(" ");
        }


        public static string ReturnEmailAddress(this string emailAddress, string fullname, string yearOfBirth, string domain)
        {
            emailAddress = fullname + yearOfBirth + '@' + domain;
            return emailAddress;
        }

        public static List<T> EveryOtherWord<T>(this List<T> originalList)
        {
            var newList = new List<T>();
            for (int i = 0; i < originalList.Count; i += 2)
                newList.Add(originalList[i]);
            return newList;
        }

        public static IEnumerable<string> ReadEverySecondLine(this string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var linesUpdated = new List<string>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                linesUpdated.Add(lines[i]);
            }
            return linesUpdated;


        }








    }
}
