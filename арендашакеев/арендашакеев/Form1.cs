using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace арендашакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ch = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked) { ch = ch * 500; }
            if (radioButton2.Checked) { ch = ch * 750; }
            if (radioButton3.Checked) { ch = ch * 1000; }

            textBox1.Text = Convert.ToString(ch);
        }
    }
}
