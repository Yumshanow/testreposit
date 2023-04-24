using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗД1
{
    class worker
    {
        public string name;
        public int age;
        double weight = 60;

        public double WEIGHT
        {
            get { return weight; }
            set
            {
                if (value > 10)
                {
                    age++;
                    weight += value / 2;
                }
                else
                {
                    weight += value;
                }
            }
        }
    }
}
