using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_Delegate
{
    class Program
    {
        delegate void Del1();

        static void Disp() // 文字列の表示を行うメソッド
        {
            Console.WriteLine("Hello, world!");
        }

        static void a(Del1 call)
        {
            call();
        }

        static void Main(string[] args)
        {
            a(Disp);
        }
    }
}
