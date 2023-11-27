namespace Test_ff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a row"); 
            int row = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter a column"); 
            int column = int.Parse(Console.ReadLine()); 
            int[,] array = new int[row, column]; 
            for (int i = 0; i < array.GetLength(0); i++) { for (int j = 0; j < array.GetLength(1); j++) { Console.WriteLine("Enter a number"); array[i, j] = int.Parse(Console.ReadLine()); } }
            for (int i = 0; i < array.GetLength(0); i++) { for (int j = 0; j < array.GetLength(1); j++) { Console.Write(array[i, j].ToString().PadRight(2)); } Console.WriteLine(); }
        }
    }
}