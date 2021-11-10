using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211110_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 100;
            object obj1 = (object)value1;
            int value2 = (int)obj1;

            Console.WriteLine(value2);
        }
    }
}
