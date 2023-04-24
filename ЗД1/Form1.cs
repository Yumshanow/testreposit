using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗД1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker work = new worker();
            work.name = textBox1.Text;
            work.age = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(string.Format("Рабочий: {0} \nВозраст: {1} \nВес: {2}", work.name, work.age, work.WEIGHT));

            work.WEIGHT = 2;
            work.WEIGHT = 3;
            MessageBox.Show(string.Format("Рабочий: {0} \nВозраст: {1} \nВес: {2}", work.name, work.age, work.WEIGHT));

            work.WEIGHT = 15;
            MessageBox.Show(string.Format("Рабочий: {0} \nВозраст: {1} \nВес: {2}", work.name, work.age, work.WEIGHT));


        }
    }
}
