using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Manager2 : Employee2
    {
        public override string Greeting()
        {
            return "Manager is saying Greetings!";
        }
    }
}
