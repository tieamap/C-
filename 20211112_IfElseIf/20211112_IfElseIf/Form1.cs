using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211112_IfElseIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("今週末は「庭の掃除」をする。", "確認");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("今週末は「窓拭き」をする。", "確認");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("今週末は「車の洗車」をする。", "確認");
            }
        }
    }
}
