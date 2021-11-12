using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211112_OneDimensionalArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] array = new int[5];


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmDialog = new Form2();
            for (int i = 0; i < 5; i++)
            {
                frmDialog.Text = (i + 1) + "番目の要素";
                frmDialog.ShowDialog();
                array[i] = Convert.ToInt32(frmDialog.textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strResult = "";
            for (int i = 0; i < 5; i++)
            {
                strResult = strResult + Convert.ToString(array[i]) + "\r\n";
            }
            textBox1.Text = strResult;
        }
    }
}
