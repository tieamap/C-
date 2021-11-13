using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _20211113_Iterator
{
    class Program
    {
        static IEnumerable Show()
        {
            yield return "January";
            yield return "February";
            yield return "March";
        }

        static void Main(string[] args)
        {
            foreach (string val in Show())
            {
                Console.WriteLine(val);
            }
        }
    }
}
