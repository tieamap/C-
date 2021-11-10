using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211110_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 100;
            object obj1;
            obj1 = (object)value1;

            Console.WriteLine(obj1);
        }
    }
}
