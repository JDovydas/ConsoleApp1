using _44_Paskaita_Calculator;

namespace _44_Paskaita_Calculator_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            Assert.Equal(4, Program.Sum(2, 2));

        }

        [Fact]
        public void TestSubtract()
        {
            Assert.Equal(0, Program.Subtract(2, 2));

        }

        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(4, Program.Multiply(2, 2));

        }

        [Fact]
        public void TestDivide()
        {
            Assert.Equal(1, Program.Divide(2, 2));

        }

        [Fact]
        public void TestPower()
        {
            Assert.Equal(8, Program.Power(2, 3));

        }

        [Fact]
        public void TestRoot()
        {
            Assert.Equal(2, Program.Root(4));

        }
    }
}