namespace _24_Paskaita_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print<string>("Rokas");
            //// incorrect example: Print<int>("Rokas");
            //Print("Rokas");
            //Print(123);
            //Print(0.5);
            //Print(true);
            //Print(new List<int> { 1,2,3,4,5});
            //Print(new int[] { 1, 2, 3, 4 });

            /*
            Person person = new Person()
            {
                Name = "Rokas",
                Age = 18,
                Id = 1,
            };
            Print(person);

            */

            /*
            var repository = new Repository<string>();

            repository.AddItem("Rokas");
            repository.AddItem("Jonas");
            repository.AddItem("Rimas");
            repository.AddItem("John");

            if(repository.Contains("John"))
            {
                Console.WriteLine("Yes it has John");
            }
            repository.RemoveItem("John");

            repository.Print();
            repository.Shufle();
            repository.Print();
            */
            /*
            //1
            Validation<string> stringValidator = new Validation<string>();

            string myString = "Hello World";

            stringValidator.Validate(myString);


            Validation<int> intValidation = new Validation<int>();
            int myInt = 999;
            intValidation.Validate(myInt);
            */
            //string myNullString = null;
            //stringValidator.Validate(myNullString);

            //2
            /*
            Validation2.Validate<string>("dovydas");
            */
            //3
            /*
            Values.ShowValues("Hi", 20);
            */
            //4

            //var selfMadeList = new MySelfMadeList<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    selfMadeList.AddElement(i);
            //}

            /*
            MySelfMadeList<int> myList = new MySelfMadeList<int>();
            myList.AddElement(1);
            myList.AddElement(2);
            myList.AddElement(3);

            myList.RemoveElement(3);

            Console.WriteLine("List after removal:");
            foreach (var item in myList.MyArray)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}