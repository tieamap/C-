using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211114_InheritanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 person = new Class2(textBox1.Text, dateTimePicker1.Value.Date, textBox2.Text);

            MessageBox.Show(
                person.Name + "さんの年齢は" +
                Convert.ToString(person.GetAge()) + "歳です。" + "\r\n" +
                "住所は" + person.Address + "です。", "結果"
                );
        }
    }
}
