using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_StaticMethod
{
    class A
    {
        public static int Add(int p1, int p2)
        {
            return p1 + p2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Add(10, 100));
            Console.WriteLine(A.Add(100, 100));
        }
    }
}
