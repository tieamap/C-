using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_InstanceMethod
{
    class A
    {
        public int Num;
        public int Add(int p)
        {
            return Num + p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new A();
            var obj2 = new A();
            obj1.Num = 10;
            obj2.Num = 100;

            Console.WriteLine("obj1=" + obj1.Add(1));
            Console.WriteLine("obj2=" + obj2.Add(1));
        }
    }
}
