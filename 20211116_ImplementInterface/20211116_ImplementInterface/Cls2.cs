﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_ImplementInterface
{
    class Cls2 : SperCls
    {
        public override void Multiplier(int n)
        {
            Val = n * 4;
            MessageBox.Show("処理結果は" + Val);
        }

        public override void Divider(int n)
        {
            Val = n / 4;
            MessageBox.Show("処理結果は" + Val);
        }
    }
}
