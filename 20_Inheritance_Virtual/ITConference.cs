using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class ITConference : Conference
    {
        public override void StartEvent()
        {
            Console.WriteLine($"{Name} conference is starting ITITITITIT");
        }
    }
}
