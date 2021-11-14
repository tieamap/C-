using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_GenericMethod
{
    class Program
    {
        static void Test<T>(T t)
        {
            Console.WriteLine(t);
        }
        static void Main(string[] args)
        {
            Test<int>(500);
        }
    }
}
