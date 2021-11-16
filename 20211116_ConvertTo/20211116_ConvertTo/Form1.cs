using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_ConvertTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // テキストボックスの値を保持するint型のフィールド
        private int num1, num2;

        private bool checkValue()
        {
            // テキストボックスの値をint型に変換してフィールドに格納
            // 成功すればtrueを返す
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                return true;
            }

            // int型に変換できない場合はメッセージを表示
            // falseを返す

            catch
            {
                MessageBox.Show("A欄とB欄に数字を入力してください。", "エラー");
                return false;
            }

            // テキストボックスをクリアする
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        // 加算
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 + num2));
        }

        // 減算
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 - num2));
        }

        // 積算
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 * num2));
        }
        
        // 除算
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                double a = num1 / (double)num2;
                MessageBox.Show(Convert.ToString(a));
            }
        }
    }
}
