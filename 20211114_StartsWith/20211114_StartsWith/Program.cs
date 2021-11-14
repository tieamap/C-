using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_StartsWith
{
    class Program
    {
        static string[] getString(string[] str)
        {
            return (
                from s in str
                where s.StartsWith("A")
                select s
                ).ToArray();
        }

        static void Main(string[] args)
        {
            string[] fruit = { "Orange", "Apple", "Grape" };
            string[] result = getString(fruit);
            foreach (var name in result) Console.WriteLine(name);
        }
    }
}
