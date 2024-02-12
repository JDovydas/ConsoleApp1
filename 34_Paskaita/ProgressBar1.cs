using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Paskaita
{
    internal class ProgressBar1
    {
        private readonly object _lockProgress = new object();
        public int Progress = 0;

        public void Increment()
        {
            lock (_lockProgress)
            {
                if (Progress < 100)
                {
                    Progress++;
                }

            }
        }

        public int GetProgress()
        {
            lock (_lockProgress)
            {
                return Progress;
            }
        }


    }
}
