using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Paskaita_DelegatesAndAnonymous
{
    internal class Messeger
    {
        public delegate void MessagerDelegate(string message);

        Messeger()
        {
            MessagerDelegate messegerDelegate = new MessagerDelegate(SendMessage);
        }

        public void SendMessage(string message)
        {


        }

        static void Generate(Func<string> func)
        {
            string text = func();
            Console.WriteLine($"{text}@gmail.com");


        }

    }
}
