using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27_Paskaita_Exception_Handling
{
    internal class BadWordException : Exception
    {
        public BadWordException(string message) : base(message)
        {

        }
    }
}
