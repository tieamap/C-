using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_NextBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Birthday;
            label2.Text = "選択した日付" + dateTimePicker1.Value.Date.ToString();
            Birthday = dateTimePicker1.Value.Subtract(DateTime.Today).Days;
            label3.Text = "本日から次の誕生日まであと" + Birthday.ToString() + "日";
        }
    }
}
