using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20211117_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string saveFileName;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }
            StreamWriter textFile = new StreamWriter(new FileStream(saveFileName, FileMode.Create));
            textFile.Write(textBox1.Text);
            textFile.Close();
        }

        // 開くボタンクリック時の処理
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string openFileName;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            textBox1.Clear();
            StreamReader textFile = new StreamReader(openFileName);
            textBox1.Text = textFile.ReadToEnd();
            textFile.Close();
        }
    }
}