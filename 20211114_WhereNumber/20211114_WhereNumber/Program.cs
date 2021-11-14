using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_WhereNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var query = from n in numbers where n >= 2 && n <= 4 select n;
            foreach (var a in query) Console.WriteLine(a);
        }
    }
}
