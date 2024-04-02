namespace _44_Paskaita_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string GetInitials(string name, string surname)
        {
            return $"{name[0]}{surname[0]}";
        }

        public static string CheckAge(int age)
        {
            if (age < 18)
                return "You are a minor";
            else if (age >= 18 && age < 65)
                return "You are an adult";
            else if (age >= 65)
                return "You are eligible for the Senior Citizen promotion";
            else return "Not a valid age";

        }




    }

    public class MyClass
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }

    }




}
