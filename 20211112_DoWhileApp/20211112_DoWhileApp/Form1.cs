using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211112_DoWhileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            do
            {
                MessageBox.Show(Convert.ToString(i) + "回目の処理です。", "プログラム実行中");
                i++;
            }
            while (i <= 5);
        }
    }
}
