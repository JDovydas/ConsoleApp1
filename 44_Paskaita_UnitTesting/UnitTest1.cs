using _44_Paskaita_Testing;
namespace _44_Paskaita_UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Assert.Equal("You are a minor", Program.CheckAge(2));


            //public static string CheckAge(int age)
            //{
            //    if (age < 18)
            //        return "You are a minor";
            //    else if (age >= 18 && age < 65)
            //        return "You are an adult";
            //    else if (age >= 65)
            //        return "You are eligible for the Senior Citizen promotion";
            //    else return "Not a valid age";

            //}


        }
    }
}