using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace этажишакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int f = Convert.ToInt32(textBox1.Text);
                int c = f * 500;
                textBox2.Text = Convert.ToString(c);
            }
            if (radioButton2.Checked)
            {
                int f = Convert.ToInt32(textBox1.Text);
                int c = f * 400;
                textBox2.Text = Convert.ToString(c);
            }
            if (radioButton3.Checked)
            {
                int f = Convert.ToInt32(textBox1.Text);
                int c = f * 350;
                textBox2.Text = Convert.ToString(c);
            }
        }
    }
}

