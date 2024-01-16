using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Paskaita__Accessibility
{
    public class Test
    {
        public int VariablePublic { get; set; }
        private int VariablePrivate { get; set; }
        internal int VariableInternal { get; set; }
        protected int VariableProtected { get; set; }
        internal protected int VariableInternalProtected { get; set; }
        private protected int VariablePrivateProtected { get; set; }

        public void Print()
        {
            Console.WriteLine(VariablePublic);
            Console.WriteLine(VariablePrivate);
            Console.WriteLine(VariableInternal);
            Console.WriteLine(VariableProtected);
            Console.WriteLine(VariableInternalProtected);
            Console.WriteLine(VariablePrivateProtected);

        }

    }


}
