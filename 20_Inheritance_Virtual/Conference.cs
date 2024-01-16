using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Conference : Event
    {
        public override void StartEvent()
        {
            Console.WriteLine($"{Name} conference is starting ********************************");
        }


        //public string Name { get; set; } /// WE GET IT FROM INHERITANCE BY DEFAULT

        //public virtual void StartEvent()
        //{
        //    Console.WriteLine($"{Name} is starting");
        //}
    }

}
