using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211109_ReferenceType
{
    class Value
    {
        // int型の変数valueの宣言
        public int value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Value型の変数xの宣言
            Value x;

            // インスタンスの生成
            x = new Value();

            // 値の格納
            x.value = 1;

            Value y;
            y = new Value();

            y = x;

            y.value = 10;

            Console.WriteLine(x.value);
            Console.WriteLine(y.value);

        }
    }
}
