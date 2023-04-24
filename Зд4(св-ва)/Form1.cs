using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зд4_св_ва_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eightcode eight = new eightcode();
            int a = Convert.ToInt32(textBox1.Text);

            eight.AS = Convert.ToString(eight.reverse(a));
            string g = eight.AF;
            label2.Text = Convert.ToString(eight.reverse(a));
            label3.Text = g;


        }
    }
}
