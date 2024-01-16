using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Paskaita__Accessibility
{
    internal class TestOther //No ingeritence - NON DERIVED CLASS
    {
        public void Print()
        {
            Test test = new Test();
            Console.WriteLine(test.VariablePublic);
            //Console.WriteLine(test.VariablePrivate); //Not accessible
            Console.WriteLine(test.VariableInternal);
            //Console.WriteLine(test.VariableProtected);//Not accessible
            Console.WriteLine(test.VariableInternalProtected);
            //Console.WriteLine(test.VariablePrivateProtected);//Not accessible

        }
    }
}
