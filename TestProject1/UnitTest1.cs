using _44_Paskaita_Testing;
using System.Reflection;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetInitials_FromInitials_FormedCorrectly()
        {

            //Arrange
            string name = "Rokas";
            string surname = "Slabosevicius";

            //Act
            string result = Program.GetInitials(name, surname);


            //Assert
            Assert.Equal(result, "RS");
        }

        //[Fact]
        //public void TestPrivateMethod()
        //{
        //    MyClass myClass = new MyClass();

        //    Type type = typeof(MyClass);

        //    MethodInfo methodInfo = type.GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);

        //    object[] parameters = { 3, 4 };

        //    int result = (int)methodInfo.Invoke(myClass, parameters);

        //    Assert.Equal(7, result);
        //}
    }
}