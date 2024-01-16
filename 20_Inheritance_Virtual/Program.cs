using System.Security.Cryptography.X509Certificates;

namespace _20_Inheritance_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Conference conf = new Conference(); //
            Meeting course = new Meeting();
            Event eve = new Event();
            ITConference IT = new ITConference();
            course.Name = "c#";
            conf.Name = "KURSAI";
            course.StartEvent();
            conf.StartEvent();
            eve.StartEvent();
            IT.StartEvent();

            */
            //Vehicle v = new Vehicle();
            //1.1
            Car car = new Car();
            //Alternative way of initiation is below
            //;
            //{
            //    Speed = 1, 
            //};
            car.Speed = 50;
            car.GetSpeed();

            Bike bike = new Bike(10);
            bike.GetBike();
            //1.1
            List<Employee> employees1 = new List<Employee>
            {
                new Employee("b", 100),
                new Employee("c", 120),
            };
            List<Employee> employees2 = new List<Employee>
            {
                new Employee("D", 130),
                new Employee("e", 140),

            };

            //1.2
            Manager manager = new Manager("Jonas Petras", 1000, 10);

            Console.WriteLine($"Manager Name: {manager.Name}");
            Console.WriteLine($"Manager salary: {manager.Salary}");
            Console.WriteLine($"Number of employees the manager has: {manager.Empoyees}");

            //1.2.1

            Programmer programmer = new Programmer("Kestutis", 1200, "C#");
            programmer.GetProgrammerDescription();

            //2.1

            Food food = new Food("Bread", 2, DateTime.Now);

            food.PrintFoodInfo();
            //2.2
            Electronic electronic = new Electronic("TV Set", 500, (new DateOnly(2023, 12, 31)));
            electronic.ElectronicInfo();

            //3.1

            Transport transport = new Transport();
            string speed = transport.MeasureSpeed();
            Console.WriteLine(speed);

            Car2 car2 = new Car2();
            Console.WriteLine(car2.MeasureSpeed());

            //3.2

            Employee2 employee2 = new Employee2();
            Console.WriteLine(employee2.Greeting());

            Manager2 manager2 = new Manager2();
            Console.WriteLine(manager2.Greeting());









        }
    }
}