using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зд3_св_ва_
{
    class sum
    {       
        public int summa;
        public int[] masA;

        public int reshalo(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                summa += a[i];
            }
            return summa;
        }
        public int SUM
        {
            get
            {
                return summa;
            }
        }
    }
}
