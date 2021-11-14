using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 50, 200, 15, 3, 75, 1000 };
            var r = from n in num
                    where n >= 10
                    orderby n
                    select n;
            foreach (var n in r) Console.WriteLine(n);
        }
    }
}
