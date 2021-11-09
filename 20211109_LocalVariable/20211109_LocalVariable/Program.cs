using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211109_LocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine(x);

            Test();
        }

        static void Test()
        {
            int x = 20;
            Console.WriteLine(x);
        }
    }
}
