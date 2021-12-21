using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace доходшакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textSum = textBox1.Text;
            int p = Convert.ToInt32(textBox1.Text);

            string textSrok = textBox2.Text;
            int TT = Convert.ToInt32(textBox2.Text);
            int TTT = TT / 12;
            int t = TTT + 1;

            int n = Convert.ToInt32(textBox3.Text);

            int sum = p + p * n * t / 100;
            textBox4.Text = Convert.ToString(sum);
        }
    }
}
