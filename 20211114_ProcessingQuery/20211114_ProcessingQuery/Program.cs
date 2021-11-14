using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_ProcessingQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 100, 200, 300, 400, 500 };
            var r = from n in num
                    select n * 105 / 100;
            foreach (var n in r) Console.WriteLine(n);
        }
    }
}
