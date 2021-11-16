using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_ProcessCompo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            process1.CloseMainWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            process2.CloseMainWindow();
        }
    }
}
