using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Event
    {
        public string Name { get; set; }

        public virtual void StartEvent()
        {
            Console.WriteLine($"{Name} is starting");
        }
    }
}
