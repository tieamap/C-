using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price, quantity, subtotal, tax, total;
            const double TAXR_RATE = 0.08;

            // テキストボックスに入力された値は全て文字列扱いになるので型変換が必要
            price = Convert.ToInt32(textBox1.Text);
            quantity = Convert.ToInt32(textBox2.Text);
            subtotal = price * quantity;
            tax = (int)(subtotal * TAXR_RATE);

            total = subtotal + tax;

            label6.Text = Convert.ToString(subtotal);
            label7.Text = Convert.ToString(tax);
            label8.Text = Convert.ToString(total);
        }
    }
}
