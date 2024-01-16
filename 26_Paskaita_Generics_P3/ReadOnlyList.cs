using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Paskaita_Generics_P3
{
    internal class ReadOnlyList<T>
    {
        private readonly List<T> values;

        public ReadOnlyList(List<T> initialValues)
        {
            values = new List<T>(initialValues);
        }




    }
}
