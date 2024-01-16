using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Paskaita_DelegatesAndAnonymous
{
    public delegate void MyEventHandler(string message);
    internal class Publisher
    {
        public event MyEventHandler Handler;

        public void Notify(string message)
        {
            Handler?.Invoke(message);
        }


    }
}
