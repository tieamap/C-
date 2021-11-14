using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_OverrideApp
{
    class Class1
    {
        private string name;
        private DateTime birthday;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public virtual int GetAge()
        {
            int age = DateTime.Today.Year - Birthday.Year;
            if(
                DateTime.Today.Month < Birthday.Month ||
                DateTime.Today.Month == Birthday.Month && 
                DateTime.Today.Day < Birthday.Day
                )
            {
                age = age - 1;
            }
            return age;
        }
    }
}
