using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_NonNameArray
{
    class DataSet
    {
        public string s;
        public int[] n;

        public DataSet(String _s, int[] _n)
        {
            s = _s;
            n = _n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // インスタンスの作成
            DataSet ds1 = new DataSet(
                "配列の値",
                new int[] { 10, 20, 30, 40, 50 }
                );

            Console.WriteLine(ds1.s + "= {");
            foreach (var m in ds1.n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine("}");
        }
    }
}
