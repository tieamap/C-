using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_ButtonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmForm2 = new Form2();
            frmForm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 600;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
