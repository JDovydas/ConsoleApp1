using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _16_Paskaita_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Dictionary<string, int> ageOfPeople = new Dictionary<string, int>();
            ageOfPeople.Add("Rokas", 24);
            ageOfPeople.Add("Tomas", 28);
            ageOfPeople.Add("Jonas", 28);
            ageOfPeople.Add("Paulius", 24);
            ageOfPeople.Add("German", 24);
            ageOfPeople.Add("Migle", 28);
            ageOfPeople.Add("Algirdas", 28);
            ageOfPeople.Add("Kestas", 24);

            Console.WriteLine($"Rokas age is {ageOfPeople["Rokas"]}");

            if (ageOfPeople.ContainsKey("Jonas"))
            {
                Console.WriteLine($"Jonas age is {ageOfPeople["Jonas"]}");
            }
            else
            {
                Console.WriteLine("We don't have Jonas");
            }

            Console.WriteLine("---------------------");

            PrintPeopleAndAge(ageOfPeople);

            Console.WriteLine("---------------------");

            //ageOfPeople.Remove("Rokas");

            PrintPeopleAndAge(ageOfPeople);

            Console.WriteLine("---------------------");


            RemoveByValue(ageOfPeople, 24);

            Console.WriteLine("---------------------");

            PrintPeopleAndAge(ageOfPeople);


            string key = ageOfPeople.First(x => x.Value == 12).Key; //Randame Value (pirmąj

            */
            //1.1
            /*
            Dictionary<string, int> namesAndAge = CreateDictionary();

            PrintDictionary(namesAndAge);
            */

            //1.2
            /*
            Dictionary<string, string> countryDictionary = CreateCountyDictionary();

            Console.WriteLine("Enter the country name");
            string country = Console.ReadLine();

            string capitalPrint = GetCapital(countryDictionary, country);
            Console.WriteLine(capitalPrint);
            */

            //1.3
            /*
            
            Dictionary<string, int> fruitTable = new Dictionary<string, int>()
            {
                {"banana", 10 },
                {"apple", 5 },
                {"lemon", 6 }

            };

            Print(fruitTable);

            Console.WriteLine("Which fruit you would like to add?");
            string fruitName = (Console.ReadLine()).ToLower();
            Console.WriteLine("What amount you would like to add?");
            int quantity = int.Parse(Console.ReadLine());

            Dictionary<string, int> updatedFruitTable = FruitMethod(fruitTable, fruitName, quantity);

            Print(updatedFruitTable);

            */
            /*
            //1.4

            Dictionary<string, int> dict = CreateCountyPopulationDictionary();

            Console.WriteLine("Which city you would like to get the pupulation for?");
            string cityName = Console.ReadLine();

            Print(dict);

            int pupulation = CityPopulation(dict, cityName);
            Console.WriteLine(pupulation);
            */




        }

        public static void PrintPeopleAndAge(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Value} age is {item.Key}");
            }


        }

        public static void RemoveByValue (Dictionary<string, int> dict, int valueToRemove)
        {
            if(!dict.ContainsValue(valueToRemove))
            {
                return; //end this method, do not do anything below
            }
            foreach (var item in dict)
            {
                if (item.Value == valueToRemove)
                {
                    dict.Remove(item.Key);
                }
            }
        }

        static Dictionary<string, int> CreateDictionary()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Petras 1asis", 20);
            dictionary.Add("Petras 2asis", 25);
            dictionary.Add("Petras 3asis", 30);
            return dictionary;



        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach(var item in dict)
            {
                Console.WriteLine($"The person name is {item.Key} and the age is {item.Value}");

            }
        }

        static Dictionary<string, string> CreateCountyDictionary()
        {
            Dictionary<string, string> countriesAndCapitals = new Dictionary<string, string>
            {
                { "Lithuania", "Vilnius" },
                { "Latvia", "Riga"},
                { "Estionia", "Tallinn" },
                { "Poland", "Warsaw" }
            };
            return countriesAndCapitals;

        }

        static string GetCapital(Dictionary<string, string> countryDictionary, string country)
        {
            string result = "";
            if (countryDictionary.ContainsKey(country))
            {
                result = countryDictionary[country];
            }
            return result;
        
        
        }

        static void Print(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item);

            }
        }

        static Dictionary<string, int> FruitMethod(Dictionary<string, int> fruitTable, string fruitName, int quantity)
        {
            //Dictionary<string,int> result = new Dictionary<string,int>();

            if (fruitTable.ContainsKey(fruitName))
            {
                fruitTable[fruitName] += quantity;
            }
            else
            {
                fruitTable.Add(fruitName, quantity);
            }
 
            return fruitTable;
            

            

        }


        static Dictionary<string, int> CreateCountyPopulationDictionary()
        {
            Dictionary<string, int> countyPopulationDictionary = new Dictionary<string, int>
            {
                { "Vilnius", 544386 },
                { "Riga", 632614 },
                { "Tallinn", 426538 },
                { "Warsaw", 1765000 }
            };
            return countyPopulationDictionary;

        }


        static int CityPopulation(Dictionary<string, int> dict, string cityName)
        {
            int popul = 0;
            foreach (var item in dict)
            {
                if (cityName.Equals(item.Key))
                {
                    popul = item.Value;
                }
                   
       
            }
            return popul;
        }



    }
}
