using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interfaces_IComparer
{
    internal class MockDatabase : IRepository
    {

        void IRepository.Delete(string name)
        {
            throw new NotImplementedException();
        }

        string IRepository.Get(string name)
        {
            throw new NotImplementedException();
        }

        List<string> IRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
