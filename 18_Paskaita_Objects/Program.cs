using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace _18_Paskaita_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            /*
            Person person = new Person("Dovydas", 12);
            person.Name = "Kestas";
            person.Height = 99;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Height);
            */

            //1.2
            /*
            School school = new School("Petras", "Vilnius");

            school.NumberOfStudents = 1;
            Console.WriteLine(school.Name);
            Console.WriteLine(school.City);
            Console.WriteLine(school.NumberOfStudents);
            */
            //2.1



            //book.CountryOfEdition = "UK";
            //Console.WriteLine(book3.Title);
            //Console.WriteLine(book.Author);
            //Console.WriteLine(book.Year);
            //Console.WriteLine(book.CountryOfEdition);
            /*

            List<Book> list = new List<Book>
            {
                new Book("Programming Book", "Rokas", 2023),
                new Book("Vienam Gale Kablys", "Rokas", 1962),
                new Book("Trys parseliai", "Gediminas", 1999),
                new Book("Trys muskietininkai", "Rokas", 2000),
            };



            List<Book> filteredList = ReturnListOfNeededAuthor(list, "Rokas"); //galima tiek vieną value
            Console.WriteLine("Books of Rokas: ");
            foreach (Book book in filteredList)
            {
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Title);

            }
            

            //2.2

            /*

            List<Store> stores = new List<Store>
            {
                new Store("Store1", 2000, new List<string> { "Product1", "Product2", "Product3" }),
                new Store("Store2", 2010, new List<string> { "ProductA", "ProductB", "ProductC" }),
                new Store("Store3", 2022, new List<string> { "ItemX", "ItemY", "ItemZ" }),
            };

            PrintStoreInformation(stores);

            */


            //3.1
            /*

            List < Cat > cats = new()
            {
                new("Rainys", 1, "Grey"),
                new("Rudis", 2, "Yellow"),
                new("Rikis", 3, "Blue"),
                new("Pakis", 4, "Red"),
            };

            List<Dog> dogs = new()
            {
                new("Rainys", 1, "Grey"),
                new("Pilkis", 1, "Yellow"),
                new("Pakis", 1, "Blue"),
                new("Rikis", 1, "Grey"),
            };

            List<Hamster> hamsters = new()
            {
                new("Pilkis", 1, "Blue"),
                new("Rainys", 1, "Grey"),
                new("Pilkis", 1, "Grey"),
                new("Rikis", 1, "Yellow"),
            };


            List<string> petNames = ReturnPetNames(dogs, cats, hamsters);

            Console.WriteLine("Pet Names:");
            foreach (var name in petNames)
            {
                Console.WriteLine(name);
            }


            Dictionary<string, int> countAnimals = GetCountOfAnimalsByType(cats, dogs, hamsters);

            foreach (var name in countAnimals)
            {
                Console.WriteLine(name);
            }




            /*
            Person person = new Person();
            person.Name = "Test";
            person.Gender = "Male";
            person.Birthday = new DateTime(1999, 10, 26);

            Console.WriteLine(person.Birthday.ToShortDateString()); //print only date without the time
            */
            /*
            PersonTest person = new PersonTest("Rokas");
            PersonTest tomas = new PersonTest("Tomas");



            List<PersonTest> list = new List<PersonTest>();
            list.Add(person);
            list.Add(tomas);

            foreach (PersonTest item in list)
            {
                Console.WriteLine(item.Name);
            }
            */
            //Console.WriteLine(person.Name);
        }

        static List<Book> ReturnListOfNeededAuthor(List<Book> books, string author)
        {
            List<Book> filteredList = new List<Book>();

            foreach (Book item in books)
            {
                if (item.Author == author)
                {
                    filteredList.Add(item);
                }

            }
            return filteredList;
        }

        static void PrintStoreInformation(List<Store> stores)
        {
            foreach (var store in stores)
            {
                Console.WriteLine($"Name: {store.Name}, opened in: {store.YearOfOpening}, products: ");
                foreach (var product in store.Products)
                {
                    Console.WriteLine($"\t{product}");
                }
                Console.WriteLine();
            }
        }

        static List<string> ReturnPetNames(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            List<string> names = new List<string>();

            foreach (Dog dog in dogs)
            {
                names.Add(dog.Name);
            }
            foreach (Cat cat in cats)
            {
                names.Add(cat.Name);
            }
            foreach (Hamster hamster in hamsters)
            {
                names.Add(hamster.Name);
            }
            return names;


        }

        static Dictionary<string, int> GetCountOfAnimalsByType(List<Cat> cats, List<Dog> dogs, List<Hamster> hamsters)
        {
            Dictionary<string, int> countAnimals = new Dictionary<string, int>()
            {
                {"Cats", cats.Count},
                {"Dogs", dogs.Count},
                {"Hamsters", hamsters.Count}


            };
            return countAnimals;

        }



    }
}