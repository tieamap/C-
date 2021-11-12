using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _20211113_ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList col = new ArrayList();
            col.Add("VisualC#");
            col.Add(2015);
            Console.WriteLine(col[0]);
            Console.WriteLine(col[1]);
            Console.WriteLine(col[0].GetType().Name);
            Console.WriteLine(col[1].GetType().Name);
        }
    }
}
