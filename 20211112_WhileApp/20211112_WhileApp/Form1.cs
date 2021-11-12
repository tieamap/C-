using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211112_WhileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 5;
            while (i != 0)
            {
                MessageBox.Show("あと" + Convert.ToString(i) + "回処理を実行します。", "プログラム実行中");
                i--;
            }
        }
    }
}
