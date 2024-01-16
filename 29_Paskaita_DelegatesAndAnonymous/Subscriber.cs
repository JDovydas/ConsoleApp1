using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Paskaita_DelegatesAndAnonymous
{
    internal class Subscriber
    {
        private string _name;

        public Subscriber(string age, string surname = "IDK", string name = "Unknown")
        {
            _name = name;
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.Handler += HandleEvent;
        }

        private void HandleEvent(string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_name} received message: {message}");
            Console.ResetColor();
        }
    }
}
