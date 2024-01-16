namespace _26_Paskaita_Generics_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, };
            ReadOnlyList<int> myList = new ReadOnlyList<int>(list);


        }
    }
}