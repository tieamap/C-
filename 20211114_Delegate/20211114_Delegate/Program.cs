using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_Delegate
{
    class Program
    {
        private static void Disp() // 文字列の表示を行うメソッド
        {
            Console.WriteLine("Hello, world!");
        }

        private static void a(Action call)
        {
            call();
        }

        static void Main(string[] args)
        {
            a(Disp);
        }
    }
}
