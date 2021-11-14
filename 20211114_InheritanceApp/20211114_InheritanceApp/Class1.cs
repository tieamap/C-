using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_InheritanceApp
{
    class Class1
    {
        private string name;
        private DateTime birthday;

        // コンストラクターの宣言
        public Class1(string cst_name, DateTime cst_birthday)
        {
            Name = cst_name;
            Birthday = cst_birthday;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - birthday.Year;
            if(
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
