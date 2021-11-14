using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211114_OverrideApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 person = new Class1();

            person.Name = textBox1.Text;
            person.Birthday = dateTimePicker1.Value.Date;

            MessageBox.Show(
                person.Name + "さんの年齢は" +
                Convert.ToString(person.GetAge()) + "歳です。");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 person = new Class2();
            person.Name = textBox1.Text;
            person.Birthday = dateTimePicker1.Value.Date;

            MessageBox.Show(
                person.Name + "さんの年齢は" +
                Convert.ToString(person.GetAge()) + "歳です。");
        }
    }
}
