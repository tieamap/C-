using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211109_DeclareVar
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1;
            Console.WriteLine(a.GetType().Name);

            // varで変数を宣言するとコンパイラが既定の型を設定する
            var b = 1;
            Console.WriteLine(b.GetType().Name);
        }
    }
}
