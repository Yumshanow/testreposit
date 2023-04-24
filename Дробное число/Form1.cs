using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дробное_число
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DROB drob = new DROB();
            nedrob asd = new nedrob();
            asd.AS = Convert.ToDouble(textBox1.Text);
            MessageBox.Show(string.Format("Число: {0} \nСимвол: {1}", asd.a, asd.b));
            asd.msg();
        }
    }
}
