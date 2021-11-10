using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211110_ImplicitConvert1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 950;
            double y;
            double z = 0.05;

            y = x * z;

            Console.WriteLine(y);
        }
    }
}
