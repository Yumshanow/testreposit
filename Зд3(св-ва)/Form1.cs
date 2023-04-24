using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зд3_св_ва_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sum sum = new sum();
            int quantity = Convert.ToInt32(textBox1.Text);
            sum.masA = mass(quantity);

            int qweqwe = sum.reshalo(sum.masA);
            int qwe = sum.SUM;
            label2.Text = "Сумма: " + qwe;

            
        }

        int[] mass(int a)
        {
            Random rnd = new Random();
            int[] mas = new int[a];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(40);
                listBox1.Items.Add(mas[i]);
            }
            return mas;
        }
    }
}
