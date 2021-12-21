using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace покупкашакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\source\repos\Шакеев\авто1.jpg");
                label3.Text = ("300000");
            }

            if (checkBox2.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\source\repos\Шакеев\авто2.jpg");
                label3.Text = ("500000");
            }

            if (checkBox3.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\student\source\repos\Шакеев\авто3.jpg");
                label3.Text = ("700000");
            }
        }
    }
}
