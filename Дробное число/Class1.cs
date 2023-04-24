using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дробное_число
{
    class DROB
    {
        public int a;
        public char b;
        

        
        public double AS
        {
            get { return a; }

            set
            {
                int z = Convert.ToInt32(value);
                b = Convert.ToChar(z);
                double g = ((value - z) * 100) - 0.49;
                a = Convert.ToInt32(g);
            }
        }
        
    }

    class nedrob : DROB 
    {
        public void msg()
        {
            MessageBox.Show("Датыебанбля", "УВАГА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
