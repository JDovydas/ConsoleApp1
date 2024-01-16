using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Paskaita__Accessibility
{
    internal class TestChild : Test
    {   //Derived class
        public void Print()
        {
            Console.WriteLine(VariablePublic);
            //Console.WriteLine(VariablePrivate);//Not accessible
            Console.WriteLine(VariableInternal);
            Console.WriteLine(VariableProtected);
            Console.WriteLine(VariableInternalProtected);
            Console.WriteLine(VariablePrivateProtected);
        }
    }
}
