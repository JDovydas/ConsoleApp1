using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static _29_Paskaita_DelegatesAndAnonymous.Program;

namespace _29_Paskaita_DelegatesAndAnonymous
{
    internal class Program
    {
        public delegate int MathDelegate(int a, int b);

        public delegate string PersonDelegate(string firstName, string lastName, int age);

        public delegate int NumberDelegate(int number1, int number2);

        public delegate List<int> NextElementDelegate(List<int> list, int step);

        public delegate string DataTypeDelegate<T>(T parameter);

        public delegate bool Filter(Person person);

        public delegate bool Filter2(Person person, int ageLimit);



        static void Main(string[] args)
        {
            ////2.1.1

            //PersonDelegate person = delegate (string firstName, string lastName, int age)
            //{
            //    return firstName + lastName + age;
            //};

            //Console.WriteLine(person($"Dovydas ", "Juodys ", 11));


            ////2.1.2

            //MathDelegate math = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Console.WriteLine(math(1, 2));

            ////2.1.3

            //var myListB = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //int stepB = 2;

            //NextElementDelegate everyOtherNumberB = delegate (List<int> myListB, int stepB)
            //{
            //    var newList = new List<int>();

            //    for (int i = 0; i < myListB.Count; i += stepB)
            //    {
            //        newList.Add(myListB[i]);

            //    }
            //    return newList;
            //};


            //List<int> updatedListbB = everyOtherNumberB(myListB, stepB);

            //Console.WriteLine($"Original list: {string.Join(", ", myListB)}");
            //Console.WriteLine($"New list: {string.Join(", ", updatedListbB)}");

            ////2.1.4


            //DataTypeDelegate<object> value = delegate (object parameter)
            //{
            //    return $"{parameter.GetType()}";
            //};

            //Console.WriteLine(value(1));

            //2.2.1

            //List<Person> people = new List<Person>
            //{
            //    new Person("Kazys Petras", 10),
            //    new Person("Petras Kazys", 25),
            //    new Person("Vytautas Didysis", 69),
            //    new Person("Kalavijuotis Antanas", 39)


            //};

            //Filter isChild = delegate (Person person)
            //{
            //    return person.Age < 18;
            //};

            //Filter isAdult = delegate (Person person)
            //{
            //    return person.Age >= 18;
            //};

            //Filter isSeniorCitizen = delegate (Person person)
            //{
            //    return person.Age >= 65;
            //};

            //Func<Person, bool> IsChildL = person => person.Age < 18;

            //DisplayPeople("Children", people, person => person.Age < 18);

            ////DisplayPeople2("Children", people, (person, ageLimit) => person.Age < ageLimit);


            //// Display people based on different filters using anonymous methods
            //DisplayPeople("Children:", people, isChild);
            //DisplayPeople("Adults:", people, isAdult);
            //DisplayPeople("Senior Citizens:", people, isSeniorCitizen);

            //Func<int, int, int> Multiply = (int x, int y) => x * y;

            //int multpl = Multiply(3, 5);

            //Console.WriteLine(multpl);

            //List<Person> personFiltered = people.Where(x => x.Age > 18).ToList();

            //List<Person> personTransformed = people.Select(x => new Person(x.Name, x.Age + 1)).ToList();

            //List<string> personTransformed2 = people.Select(x => x.Name).ToList();

            //List<Person> personOrdered = people.OrderBy(x => x.Age).ToList();

            //List<Person> personOrdered1 = people.OrderBy(x => x.Name).ThenBy(x => x.Age).ToList();

            //var personMulti = people.Where(x => x.Age > 18)
            //.OrderBy(x => x.Age);
            //.Select(x => x.Name)
            //.First();


            ///linq

            ////1.1

            //List<int> myList1 = new List<int> { 1, 2, 3, 4, };

            //List<int> squaredNumbers1 = myList1.Select(x => x * x).ToList();

            //List<int> squaredNumbers = myList1.Select(Square).ToList();

            //Console.WriteLine("Original List: ");
            //PrintListInt(myList1);

            //Console.WriteLine("Squared List: ");
            //PrintListInt(squaredNumbers);

            ////1.2

            //List<int> myList2 = new List<int> { 1, -2, -3, 4, 5, 6, -7 };

            //List<int> myList2Posivive = myList2.Where(x => x > 0).ToList();

            //PrintListInt(myList2);
            //PrintListInt(myList2Posivive);

            ////1.3

            //List<int> myList3 = new List<int> { 1, -2, -3, 4, 5, 6, -7, -15, -25, 25, 55, 72 };

            //List<int> myList3Posivive = myList3.Where(x => x > 0 && x <= 10).ToList();

            //PrintListInt(myList3);
            //PrintListInt(myList3Posivive);

            ////1.4

            //List<int> myList4 = new List<int> { 1, -2, -3, 4, 5, 6, -7, -15, -25, 25, 55, 72 };

            //List<int> myList4Ascending = myList4.OrderBy(x => x).ToList();

            //PrintListInt(myList4);
            //PrintListInt(myList4Ascending);

            ////1.5

            //List<int> myList5 = new List<int> { 1, -2, -3, 4, 5, 6, -7, -15, -25, 25, 55, 72 };

            //List<int> myList5Descending = myList5.OrderByDescending(x => x).ToList();

            //PrintListInt(myList5);
            //PrintListInt(myList5Descending);

            ////1.6

            //List<int> myList6 = new List<int> { 1, -2, -3, 4, 5, 6, -7, -15, -25, 25, 55, 72 };

            //int myList6Largest = myList6.Max();

            //Console.WriteLine(myList6Largest);

            //1.7

            //List<Person> peopleList = new List<Person>
            //{
            //    new Person ("Dovydas", 10),
            //    new Person ("Petras", 15 ),
            //    new Person ("Kastytis", 55),
            //    new Person ("Azuolas", 99),
            //    new Person ("Gluosnis", 150)

            //};


            //List<string> names = peopleList.Select(x => x.Name).ToList();

            //PrintListString(names);

            //List<int> ages = peopleList.Select(x => x.Age).ToList();

            //PrintListInt(ages);

            //List<Person> sortedByAge = peopleList.OrderByDescending(x => x.Age).ToList();

            //DisplayPerson(sortedByAge);

            //List<Person> namesStartWithA = peopleList.Where(x => x.Name.StartsWith("A")).ToList();

            //DisplayPerson(namesStartWithA);


            //2.1

            //Animal dog = new Animal("Dog", 1);
            //Animal cat = new Animal("Cat", 2);
            //Animal bird = new Animal("Bird", 6);
            //Animal lizard = new Animal("Lizard", 9);
            //Animal aligator = new Animal("Aligator", 11);


            //List<Animal> person1Animals = new List<Animal> { dog, cat, aligator };
            //PersonTask2 person1 = new PersonTask2("Dovydas", person1Animals);

            //List<Animal> person2Animals = new List<Animal> { bird };
            //PersonTask2 person2 = new PersonTask2("Kestas", person2Animals);

            //List<Animal> person3Animals = new List<Animal> { lizard };
            //PersonTask2 person3 = new PersonTask2("Vytas", person3Animals);


            //List<PersonTask2> peopleList = new List<PersonTask2> { person1, person2, person3 };

            //List<Animal> allAnimals = peopleList.SelectMany(person => person.Pet).ToList();

            //Console.WriteLine("Part one: The list consisting of all the animals in the list.");
            //DisplayAnimalList(allAnimals);

            //List<Animal> onlyNamesByA = allAnimals.Where(animal => animal.Name.StartsWith("A")).ToList();
            //Console.WriteLine("Part two: Another list will consist only of animals whose names start with the letter A");
            //DisplayAnimalList(onlyNamesByA);

            //List<Animal> animalAge = allAnimals.Where(animal => animal.Name.StartsWith("A")).Where(animal => animal.Age > 5).ToList();
            //DisplayAnimalList2(animalAge);

            //2.2

            //string sentence = "Gyvenu GERAI gyvenu gerai gyvenu a a aS GERAI";

            //var capitalWords = ReturnUppercaseWords(sentence);

            //string list = string.Join(",", capitalWords);

            //Console.WriteLine(list);



            //3.1

            string directoryPath = @"C:\Users\djuod\source\repos\ConsoleApp1\23_Paskaita_Streams\bin\Debug\net7.0";

            string[] allFiles = Directory.GetFiles(directoryPath);

            Console.WriteLine("Print all available files in the directory: --------------------------------------------------");

            foreach (string file in allFiles)
            {
                Console.WriteLine(file);
            }

            var allExtensions = allFiles
                .Select(file => Path.GetExtension(file).ToLower())
                .Distinct();


            Console.WriteLine("Write LINQ functionality to get all file extensions (e.g. .txt, .csproj): ");

            foreach (string file in allExtensions)
            {
                Console.WriteLine(file);
            }


            Console.WriteLine("Write LINQ functionality to retrieve all text files(.txt):  ");
            var allExtensionsTXT = allFiles
            .Where(file => Path.GetExtension(file).Equals(".txt", StringComparison.OrdinalIgnoreCase))
            .ToList();


            foreach (string file in allExtensionsTXT)
            {
                Console.WriteLine(file);
            }



            //DataTypeDelegate<string> dataType = delegate (string parameter);

            //DataTypeDelegate<int> dataType = GetType;
            //Console.WriteLine(check(parameter));

            //public static string GetType<T>(T parameter)
            //{
            //    return $"Getting type of '{parameter}', which is {parameter.GetType()}";
            //}

            ////////////////////////////////////////////////////////////////

            //Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //keyValuePairs.Add("name", "Rokas");
            //Subscriber subscriber = new Subscriber("Rokas", "Person");
            ////Subscriber subscriber1 = new Subscriber();


            //var publisher = new Publisher();

            //var subscriber3 = new Subscriber("Subscriber 3");
            //var subscriber4 = new Subscriber("Subscriber 4");

            //subscriber3.Subscribe(publisher);
            //subscriber4.Subscribe(publisher);

            //publisher.Handler += delegate (string message)
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"Received message anonymous method: {message}");
            //    Console.ResetColor();
            //};

            //publisher.Notify("Hello, world");
            //Console.ReadLine();
            ////////////////////////////////////////////////////////////////
            //1
            //PersonDelegate personInfo = new PersonDelegate(PersonInfo);

            //Console.WriteLine((personInfo("Dovydas", "Juodys", 11)));

            ////2
            //NumberDelegate numberDelegate = new NumberDelegate(NumberInfo);

            //Console.WriteLine((numberDelegate(1, 3)));

            //3

            //NextElementDelegate nextElementDelegate = GetNextElements;

            //var myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //int step = 2;

            //List<int> updatedList = nextElementDelegate(myList, step);

            //4

            //string parameter = "text";
            //DataTypeDelegate<string> check = GetType;
            //Console.WriteLine(check(parameter));




            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine($"Original list: {string.Join(", ", myList)}");
            //Console.WriteLine($"New list: {string.Join(", ", updatedList)}");

            //try
            //{
            //    MathDelegate AddDelegate = new MathDelegate(Add);
            //    MathDelegate SubtractDelegate = new MathDelegate(Subtract);

            //    Console.WriteLine(AddDelegate(2, 5));
            //    Console.WriteLine(SubtractDelegate(2, 5));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}


            //try
            //{
            //    MathDelegate AddDelegate = new MathDelegate(Add);
            //    MathDelegate SubtractDelegate = new MathDelegate(Subtract);

            //    Console.WriteLine(AddDelegate(2, 5));
            //    Console.WriteLine(SubtractDelegate(2, 5));

            //    MathDelegate MultiplicationDelegate = delegate (int a, int b)
            //    {
            //        return a * b;
            //    };

            //    Console.WriteLine("Multiplication");
            //    Console.WriteLine(MultiplicationDelegate(2, 5));

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}






        }


        public static List<string> ReturnUppercaseWords(string text)
        {
            string[] words = text.Split(' ');
            var uppercaseWords = words.Where(word => word.All(char.IsUpper)).ToList();
            return uppercaseWords;

        }

        static void DisplayAnimalList(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
            }
        }


        static void DisplayAnimalList2(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, Age: {animal.Age}");
            }
        }

        static int Square(int x)
        {
            return x * x;
        }

        static List<int> SquareNumbers(List<int> numbers)
        {
            List<int> numbersList = new List<int>();
            foreach (var x in numbersList)
            {
                int squared = x * x;
                numbersList.Add(squared);
            }
            return numbersList;

        }


        static void PrintListInt(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintListString(List<string> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void DisplayPeople(string title, List<Person> people, Filter filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }
            Console.WriteLine();
        }

        public static void DisplayPerson(List<Person> people)
        {
            foreach (Person person in people)
            {
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
            }

        }


        //public static void DisplayPeople2(string title, List<Person> people, Filter filter)
        //{
        //    Console.WriteLine(title);

        //    foreach (Person person in people)
        //    {
        //        if (filter(person, 18))
        //        {
        //            Console.WriteLine($"Name: {person.Name}");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return (x - y);
        }

        static string GetName()
        {
            return "Rokas";
        }

        static string GetNameSurname()
        {
            return "RokasSlab";
        }

        static string GetAnimal()
        {
            return "Tiger";
        }

        static string GetCodeAcademy()
        {
            return "CodeAcademy";
        }

        static string PersonInfo(string firstName, string lastName, int age)
        {
            return $"Name: {firstName}, last name: {lastName}, age: {age}";
        }

        public static int NumberInfo(int number1, int number2)
        {
            return number1 + number2;
        }

        public static List<int> GetNextElements(List<int> list, int step)
        {
            var newList = new List<int>();

            for (int i = 0; i < list.Count; i += step)
            {
                newList.Add(list[i]);

            }
            return newList;

        }

        public static string GetType<T>(T parameter)
        {
            return $"Getting type of '{parameter}', which is {parameter.GetType()}";
        }





    }

}