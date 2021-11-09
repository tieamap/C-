using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211109_Field
{
    class Test
    {
        public int x = 10;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            int y = obj.x;
            Console.WriteLine(y);
        }
    }
}
