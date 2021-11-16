using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_PolymorphismAbstruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Class1 obj;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            obj = new Class2();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj = new Class3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.ShowMsg("実行結果"); // ShowMsgメソッドの実行
        }
    }
}
