using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_InheritanceApp
{
    class Class2 : Class1
    {
        private string address;
        public Class2(string cst_name, DateTime cst_birthday, string cst_address)
            : base(cst_name, cst_birthday)
        {
            Address = cst_address;
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
