using System.Text;

namespace _14_Paskaita_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> strings = new List<string> {"John", "Rick", "Morty" };
            List<string> list = new List<string>();
            list.Add("Tom");
            list.Add("Rokas");
            list.Add("Rokas");
            list.Add("Rokas");
            list.Add("Rokas");
            list.Remove("Rokas");

            list.AddRange(strings); //Add new list to the already existing one

            //list.Eaquals(strings);

            int index = list.IndexOf("Rokas"); //Find the index of a word
            list.RemoveAt(index);//Remove the relevant word

            Console.WriteLine(list.Count);
            list.Remove("Rokas");
            list.RemoveAt(list.LastIndexOf("Rokas"));

            //foreach (var item in list)
            //{
            //    if (item == "Rokas")
            //    {
            //        list.Remove(item);
            //    }

            //}

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            foreach (var item in list.Distinct()) //Returns only distinct values from the list
            {
                Console.WriteLine(item);
            }

            for (int i = list.Count - 1; i > 0; i--) // To go through, we have to use for
            {
                if (list[i] == "Rokas")
                {
                    list.Remove(list[i]);
                }

            }

            List<string> list2 = new List<string>();

            list2.Add("Tom");
            list2.Add("Rokas");
            list2.Add("Anna");

            list2.Sort();

            list.OrderByDescending(x => x);
            
            foreach (string item in list2)
            {
                Console.WriteLine(item);

            }

            List<int> list3 = new List<int>();
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);
            list3.Add(9);
            list3.Add(7);
            list3.Add(8);
            list3.Sort();

            int sum = 0;

            foreach (int item in list3)
            {
                sum = sum + item;

            }
            Console.WriteLine(sum);
            Console.WriteLine(list3.Sum());
            Console.WriteLine(list3.Max());
            Console.WriteLine(list3.Min());
            Console.WriteLine(list3.Average());
            */
            /*
            List<int> list = new List<int> { 1,2,5,54,456,5,456};
            List<List<int>> twoD = new List<List<int>> {
                new List<int>{1,1,2,3,4,5},
                new List<int>{1,1,3},
                new List<int>{1,1,2,3,4,5},
                new List<int>{1,1,2,3,4,5}
            };
            twoD.Add(list);
            int singleList = twoD[2][0];

            */
            /*
            Create(out List<int> list);

            List<int> list2 = new List<int>(list);
            list2[0] = 99999;
            Print(list);
            */

            //Test Case

            /*
            List<string> countries = new List<string> {"Lithuania", "Poland" };

            List<string> cities = new List<string>();
            cities.Add("Kaunas");
            cities.Add("Vilnius");
            cities.Add("Klaipeda");
            cities.Add("Taurage");
            cities.Add("Siauliai");
            cities.Add("Nida");

            List<string> names = Construct(countries, cities);
            Print(names);
            */



            /*
            List<int> lists = new List<int>();
            Create(lists);
            Print(lists);
            */

            //Task 1.1
            /*
            
            List<string> list4 = new List<string>();
            list4.Add("Kaunas");
            list4.Add("Vilnius");
            list4.Add("Klaipeda");
            list4.Add("Taurage");
            list4.Add("Siauliai");
            list4.Add("Nida");

            PrintLength(list4);
            */
            //Task 1.2
            /*
            List<int> myList = GenerateList(50);

            Console.WriteLine("The list of elements: ");
            
            Print(myList);

            double average = CalculateAverage(myList);
            Console.WriteLine($"Average of the list of elements is {average}");
            */

            //1.3
            /*
            List<int> listOfMine = new List<int>();

            listOfMine.Add(1);
            listOfMine.Add(2);
            listOfMine.Add(3);
            listOfMine.Add(4);
            listOfMine.Add(5);
            listOfMine.Add(6);
            listOfMine.Add(7);
            listOfMine.Add(8);
            listOfMine.Add(9);
            listOfMine.Add(10);
            listOfMine.Add(11);
            listOfMine.Add(15);
            listOfMine.Add(11);

            List<int> biggerNumbers = NumberValidator(listOfMine);
            Print(biggerNumbers);
            */


            //1.4 - A

            /*
            List<string> words = new List<string> { "Namas", "Batas", "Kalvis" };

            List <string> longWords = ReturnEvenLetterWords(words);
            Print(longWords);

            CalculateSumASCII(longWords);
            */
            //1.4 - B
            /*
            
            List<string> words = new List<string> { "Namas", "Batas", "Kalvis" };

            Console.WriteLine("Original List:");
            Print(words);
            
            List<string> evenSumWords = FilterWordsByEvenSum(words);

            Console.WriteLine("\nWords with Even Sum of ASCII Codes:");
            Print(evenSumWords);
            */

            /*
            List<string> list = new List<string>();
            string num = Console.ReadLine();
            string[] sep = num.Split();
            foreach (string s in sep)
            {
                int sum = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    sum += s[i];
                }
                Console.WriteLine(sum);
                Console.WriteLine($"{s} -> {sum}");

            }

            */

            //1.5
            /*
            List<int> list = new List<int> {1,2,3,4,5 };
            */

            //1.6
            
            
            /*
            List<string> words = new List<string> { "Namas", "Batas", "Kalvis" };

            ReturnPrimeLetterWords(words);
            */



        }

        static void PrintLength(List<string> list4)
        {
            foreach (string item in list4)
            {
                Console.WriteLine($"{item} is length of {item.Length}");

            }
        
        }

        static void Create (List<int> lists)
        {
            for (int i = 0; i < 500; i++)
            {
            lists.Add(i);
            }
        }

        static void Print(List<int> lists)
        {
            foreach (int item in lists)
            {
                Console.WriteLine(item);

            }
        }

        static void Print(List<string> lists)
        {
            foreach (string item in lists)
            {
                Console.WriteLine(item);

            }
        }

        static List<string> Construct(List<string> countries, List<string> cities)
        {
            List<string> nameOfCities = new List<string>();
            foreach (string country in countries)
            {
                foreach (string city in cities)
                {
                    nameOfCities.Add($"{city} and {country}");
                }
                
            }
            return nameOfCities;
        }

        static List<int> GenerateList(int size)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(1, 101));
            }

            return list;
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }

        static double CalculateAverage(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum / list.Count;
        }

        static List<int> NumberValidator(List<int> numbers)
        {
            List<int> ints = new List<int>();
            foreach(int number  in numbers)
            {
                if (number > 10)
                {
                    //Console.WriteLine(number);
                    ints.Add(number);
                }
            }  
            return ints;
        }


        static List<string> ReturnEvenLetterWords(List<string> words)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    result.Add(word);

                }

            }
            return result;


        }

        /*

        static List<string> ReturnPrimeLetterWords(List<string> words)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                    if 
                {
                    result.Add(word);

                }

            }
            return result;

        }

        */

        static List<string> FilterWordsByEvenSum (List<string> words)
        {
            List<string> result = new List<string>();

            foreach (string word in words) 
            {
                int sumOfAsciiCodes = CalculateSumOfAsciiCodes(word);
                {
                    if (sumOfAsciiCodes % 2 == 0)
                    {
                        result.Add(word);
                    }
                }
            
            }
            return result;
        
        }

        static int CalculateSumOfAsciiCodes(string word)
        {
            int sum = 0;
            foreach (char c in word)
            {
                Console.WriteLine((int)c);
                sum += (int)c; // Casting the character to int gives its ASCII code

            }
            return sum;
        }

        public static List<string> SumOfLettersPrime(List<string> stringArray)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int total = 0;
            byte[] letters = new byte[] { };
            List<bool> checkPrime = new List<bool>();
            List<string> newList = new List<string>();



            foreach (var item in stringArray)
            {



                letters = Encoding.ASCII.GetBytes(item);



                foreach (int number in letters)
                {
                    total += number;
                }



                Console.WriteLine($"Total: {total}");



                for (int i = 2; i < total; i++)
                {
                    checkPrime.Add(total % i == 0);
                }
                bool isEven = checkPrime.Exists(x => x);
                if (!isEven)
                {
                    newList.Add(item);
                }
                total = 0;
                checkPrime.Clear();
            }

            Console.WriteLine(string.Join(", ", newList));
            return newList;
        }
    }

}
