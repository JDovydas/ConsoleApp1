namespace _21_Paskaita__Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CreditCardProcessor cardProcessor = new CreditCardProcessor()
            {
                Amount = 100,
                CardNumber = "LT1234567894566132"
            };
            PaypalProcessor paypalProcessor = new PaypalProcessor()
            {
                Amount = 965,
                Email = "DDD@AAA.COM"
            };

            List<PaymentProcessor> paypalProcessors = new List<PaymentProcessor>();
            paypalProcessors.Add(cardProcessor);
            paypalProcessors.Add(paypalProcessor);

            foreach (var processor in paypalProcessors)
            {
                processor.StartProcess();
                processor.Process();
                if (processor is CreditCardProcessor card)
                {
                    card.Test();

                }

            }

            */
            //1.1
            Triangle triangleA = new Triangle(1, 2, 2);
            //{
            //    SideA = 1,
            //    SideB = 2,
            //    SideC = 3,
            //};
            Console.WriteLine($"Triangle area: {triangleA.GetArea()}");
            Console.WriteLine($"Triangle perimeter: {triangleA.GetPerimeter()}");

            Square squareA = new Square(1, 2);
            Console.WriteLine($"Square area: {squareA.GetArea()}");
            Console.WriteLine($"Square perimeter: {squareA.GetPerimeter()}");
            //1.2


            Animal dog = new Dog();
            dog.MakeNoise();
            Animal cat = new Cat();
            cat.MakeNoise();

            //1.3

            List<GeometricShape> geometricShapes = new List<GeometricShape>
            {
                new Triangle(1, 2, 2),
                new Square(2, 2)

            };
            foreach (GeometricShape shape in geometricShapes)
            {
                Console.WriteLine($"{shape} has the perimeter: {shape.GetPerimeter()}");
                Console.WriteLine($"{shape} has the area: {shape.GetArea()}");
            }


            //Bicycle bicycle = new Bicycle("Bicycle", 26, "Kalnų Dviratis");
            //Bus bus = new Bus("Bus", 24, 10, "Scania", "GAS");
            //Truck truck = new Truck("Truck", 26, 11, "MAN", "DIESEL");


            //List<Vehicle> vehicles = new List<Vehicle>();

            //vehicles.Add(bicycle);
            //vehicles.Add(bus);
            //vehicles.Add(truck);

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    Console.WriteLine($"{vehicle.Type}, {vehicle.EngineSize}");
            //}

            //List<Vehicle> vehicles = new List<Vehicle>
            //{
            //    new Bicycle(26,"Baltic Vairas", "Kalnų Dviratis"),
            //    new Bus(24, 10, "Scania", "GAS"),
            //    new Truck(26, 11, "MAN", "DIESEL")

            //};

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    Console.WriteLine($"Following vehicles are added to the list: {}");
            //}

            //PaypalProcessor paypal = CreditCardProcessor --- Listen to the recording January 08 - 19:00

        }
    }
}