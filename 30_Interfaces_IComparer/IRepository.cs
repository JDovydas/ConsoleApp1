using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal interface IRepository
    {
        public List<string> GetAll();

        public string Get(string name);

        public void Delete(string name);
    }
}
