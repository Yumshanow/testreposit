using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зд4_св_ва_
{
    class eightcode
    {
        private int cel;
        private string eight;

        public int reverse(int a)
        {
            cel = a;
            return cel;
        }

        public string AS
        {
            set
            {               
                eight = "";
                if (cel > 0)
                {
                    while (cel > 0)
                    {
                        int re = cel % 8;
                        eight = Convert.ToString(re) + eight;
                        cel /= 8;
                    }
                }
                else eight = "0";
            }
        }
        public string AF
        {
            get
            {
                return eight;
            }
        }



    }
}
