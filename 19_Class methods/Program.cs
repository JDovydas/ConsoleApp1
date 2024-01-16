using System.Runtime.InteropServices;

namespace _19_Class_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToyBox toyBox = new ToyBox();
            //toyBox.AddToy(new Toy() { Name = "Wolf", Weight = 1 });
            //toyBox.AddToy(new Toy() { Name = "Car", Weight = 10 });
            //toyBox.AddToy(new Toy() { Name = "Lego", Weight = 3 });

            //Toy toy = new Toy() { Name = "Duck", Weight = 2 };
            //toyBox.AddToy(toy);
            //toyBox.AddToy(toy);
            //toyBox.AddToy(toy);
            //toyBox.RemoveToy(toy);

            //toyBox.PrintNameOfToys();
            //Console.WriteLine("--------------------------------------------------------");
            //toyBox.PrintNameOfToys(3);
            /*

            ErrorPrint errorPrint = new ErrorPrint();

            errorPrint.PrintNotification("Hello");
            errorPrint.PrintNotification("Sunny", "Information");
            errorPrint.PrintNotification("Bad Coding", "Warning", false);
            errorPrint.PrintNotification("StackOwerload", "Error", true);


            Square square = new Square();
            square.SetSide(3);
            square.PrintSides();

            Square square2 = new Square();
            square2.SetSide(2, 4);
            square2.PrintSides();

            Random random = new Random();
            random.Next();
            random.Next(1);
            random.Next(1,9);
            */
            //1.1
            /*
            ListOfNumbers numberList = new ListOfNumbers();

            numberList.AddNumber(1);
            numberList.AddNumber(2);
            numberList.AddNumber(3);

            numberList.PrintNumbers();
            */
            //1.2
            /*
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine($"The width of rectangle is {rectangle.Width}");
            Console.WriteLine($"The heigth of rectangle is {rectangle.Height}");
            Console.WriteLine($"The area of rectangle is {rectangle.CalculateArea()}");
            Console.WriteLine($"The perimeter of rectangle is {rectangle.CalculatePerimeter()}");
            */
            //1.3
            /*
            Circle circle = new Circle(3);
            Console.WriteLine($"The area of circle is {circle.CalculateArea()}");
            Console.WriteLine($"The perimeter of circle is {circle.CalculatePerimeter()}");
            */
            //1.4

            Library myBooks = new Library();
            Book book = new Book();

            book.Title = "Test";

            myBooks.AddBooks(book);

            myBooks.PrintBooks();

            //Library1 library1 = new Library1();

            //library1.AddBook("HARIS poteris");

            //1.5

            /*
            Playlist myPlaylist = new Playlist();

            myPlaylist.AddtoPlaylist("Daina1");
            myPlaylist.AddtoPlaylist("Daina 2");

            myPlaylist.RemoveFromPlaylist("Daina1");

            myPlaylist.PrintPlaylist();
            */




        }


    }
}