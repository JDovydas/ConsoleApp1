﻿namespace _30_Interfaces_IComparer
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

            /////Task 2
            ///
            //BmwCar myBmw = new BmwCar("BMW3", 35, 60, true);
            //myBmw.Drive();
            //myBmw.Refuel(70);
            //Console.WriteLine(myBmw.Model);
            //Console.WriteLine($"Is the car a four-wheel drive? Answer: {myBmw.IsXDrive}");


            //AudiCar myAudi = new AudiCar("A3", 20, 50, false);

            //myAudi.Drive();
            //myAudi.Refuel(15);
            //Console.WriteLine(myAudi.Model);
            //Console.WriteLine($"Is the car a four-wheel drive? Answer: {myAudi.IsXDrive}");

            ////Task3

            //Dog myDog = new Dog();

            //myDog.Eat();


            //Slides 15
            //Task 1.

            //List<IAnimal> animals = new List<IAnimal>
            //{
            //    new Dog ("Rudis"),
            //    new Dog("Pirskis"),
            //    new Cat("Pilkis"),
            //    new Bass("Zerutis"),
            //    new Carp("Karpelis"),
            //    new Carp("Albinas"),
            //    new Carp("Karosas")
            //};


            Dog dog1 = new Dog("Kurkis");
            dog1.Eat();
            dog1.GiveBirth();


            Cat cat1 = new Cat("Rainis");
            cat1.Eat();
            cat1.GiveBirth();

            Bass bass1 = new Bass("Basiukas");
            bass1.Eat();
            bass1.Swim();

            //Carp carp1 = new Carp("Car-peace");
            //carp1.Eat();
            //carp1.Swim();
            //Carp carp2 = new Carp("Albinas");
            //Carp carp3 = new Carp("Geras karpis");
            //var carps = new List<Carp> { carp1, carp2, carp3 };



            //foreach (IAnimal animal in animals)
            //{
            //    animal.Eat();

            //    if (animal is IMammal mammal)
            //    {
            //        mammal.GiveBirth();
            //    }
            //    else if (animal is IFish fish)
            //    {
            //        fish.Swim();
            //    }


            //}

            //List<IComparable> allAnimals = new List<IComparable>
            //                {
            //                    new Dog { Name = "Buddy" },
            //                    new Cat { Name = "Whiskers" },
            //                    new Bass { Name = "Fishy" },
            //                    new Carp { Name = "Goldie" }
            //                };

            //List<IComparable> allAnimals1 = new List<IComparable>
            //            {
            //                new Dog ("Rudis"),
            //                new Dog("Pirskis"),
            //                new Cat("Pilkis"),
            //                new Bass("Zerutis"),
            //                new Carp("Karelis"),
            //            };

            //var animalComparer = new List<IAnimal> { new Animal("Rikis") };


            Carp carp1 = new Carp("Car-peace");
            Carp carp2 = new Carp("Albinas");
            Carp carp3 = new Carp("Geras karpis");
            var carps = new List<Carp> { carp1, carp2, carp3 };

            var carpComparer = new CarpComparer();


            carps.Sort(carpComparer);

            foreach (var carp in carps)
            {
                Console.WriteLine(carp.Name);
            }

            //    //Task 2

            //List<IPolygon> polygons = new List<IPolygon>
            //    {
            //        new Triangle { Base = 4, Height = 3 },
            //        new Quadrilateral { Side1 = 4, Side2 = 6 },
            //        new Pentagon { Side = 8 },
            //        new Hexagon { Side = 7 }
            //    };

            ////polygons.Sort();

            //Console.WriteLine("Sorted Polygons by Area:");
            //foreach (var polygon in polygons)
            //{
            //    Console.WriteLine($"Area: {polygon.GetArea()}");
            //}


        }


    }
}