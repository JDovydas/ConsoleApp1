using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Inheritance_Virtual
{
    internal class Meeting : Event
    {
        public DateTime MeetingTime { get; set; }
        public  string Name {  get; set; }

        public override void StartEvent()
        {
            Console.WriteLine($"{Name} conference is starting at {MeetingTime.ToString("yyyy-MM-dd")}");
        }
    }
}
