using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace вагонышакеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int x = Convert.ToInt32(textBox3.Text);
            int vv = y / k;
            int h = y % k;

            if (h > 0)
            {

                vv = vv + 1; textBox5.Text = Convert.ToString(vv);
            }

            else
            {
                textBox5.Text = Convert.ToString(vv);
            }

            int vp = x / k;
            if (h > 0)
            {
                vp = vp + 1; textBox4.Text = Convert.ToString(vp);

            }
            else
            {
                textBox4.Text = Convert.ToString(vp);
            }

            if (vp > vv)
            {
                int vagon = vp - vv;
                textBox6.Text = Convert.ToString(vagon);
            }
            else
            {
                int vagon = vv - vp;
                textBox6.Text = Convert.ToString(vagon);
            }
        }
    }
}
