using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _27_Paskaita_Exception_Handling
{
    internal class Test
    {
        public static void Test1()
        {
            TestError();
        }
        private static void TestError()
        {
            try
            {
                throw new BadWordException("Bad Word used");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("eRROR BUT HANDLED");
            }


        }
    }
}
