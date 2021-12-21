using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace стеклопакетышакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = a * b;

            c = c * 2;

            if (comboBox1.SelectedIndex == 0) { c = c + 7000; }
            if (comboBox1.SelectedIndex == 1) { c = c + 9000; }

            if (checkBox1.Checked) { c = c + 1500; }
            if (checkBox2.Checked) { c = c + 2000; }
            if (checkBox3.Checked) { c = c + 2500; }

            textBox3.Text = Convert.ToString(c);
        }
    }
    }

