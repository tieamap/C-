using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211116_PolymorphismAbstruct
{
    class Class2 : Class1
    {
        public override void ShowMsg(string msg)
        {
            System.Windows.Forms.MessageBox.Show("Class2のShowMsg()を実行しました。", msg);
        }
    }
}
