using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_PersonalData
{
    class Class1
    {
        private string name; // 氏名を格納するフィールド
        private DateTime birthday; // 誕生日を格納するフィールド

        public Class1(string cst_name, DateTime cst_birthday)
        {
            Name = cst_name;
            Birthday = cst_birthday;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(value == "")
                {
                    System.Windows.Forms.MessageBox.Show("名前を入力してください。", "確認");
                    name = "????";
                }
                else
                {
                    name = value;
                }
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value > DateTime.Today)
                {
                    System.Windows.Forms.MessageBox.Show("今日以前の日付を選択してください。", "確認");
                    birthday = DateTime.Today;
                }
                else
                {
                    birthday = value;
                }
            }
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - birthday.Year;
            if (
                DateTime.Today.Month < birthday.Month ||
                DateTime.Today.Month == birthday.Month &&
                DateTime.Today.Day < birthday.Day)
            {
                age = age - 1;
            }
            return age;
        }
    }
}
