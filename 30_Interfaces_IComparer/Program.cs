namespace _30_Interfaces_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var comparerPerson = new PersonComparer();

            //List<Person> list = new List<Person>()
            //{
            //    new Person() { Name = "Dovydas", Age = 20 },
            //    new Person() { Name = "Dovydas1", Age = 22 },
            //    new Person() { Name = "Dovydas2", Age = 211 },
            //    new Person() { Name = "Dovydas3", Age = 10 },
            //};

            //list.Sort(comparerPerson);

            //list.ForEach(person => { Console.WriteLine(person); });

            ///Task 1

            //Car myCar = new Car();
            //myCar.Model = "Toyota Avensis";
            //myCar.Fuel = 40;

            //myCar.Drive();
            //myCar.Refuel(50);
            //myCar.Drive();
            //myCar.Refuel(10);
            //myCar.Refuel(-10);

            ///Task 2
            ///
            BmwCar myBmw = new BmwCar("BMW3", 35, 60, true);
            myBmw.Drive();
            myBmw.Refuel(70);
            Console.WriteLine(myBmw.Model);
            Console.WriteLine($"Is the car a four-wheel drive? Answer: {myBmw.IsXDrive}");


            AudiCar myAudi = new AudiCar("A3", 20, 50, false);

            myAudi.Drive();
            myAudi.Refuel(15);
            Console.WriteLine(myAudi.Model);
            Console.WriteLine($"Is the car a four-wheel drive? Answer: {myAudi.IsXDrive}");

            //Task3

            Dog myDog = new Dog();

            myDog.Eat();



        }
    }
}