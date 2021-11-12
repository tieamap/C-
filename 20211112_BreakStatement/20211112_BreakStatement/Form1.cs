using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211112_BreakStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2のインスタンス化
            Form2 frmForm2 = new Form2();

            for (int i = 0; i < 5; i++)
            {
                // Form2をモーダルで表示
                frmForm2.ShowDialog();

                string A = Convert.ToString(frmForm2.textBox1.Text);
                string B = "OK";
                if (A == B) break;
                MessageBox.Show(B + "と入力してください。", "繰り返し処理実行中");
            }
            frmForm2.Dispose();
        }
    }
}
