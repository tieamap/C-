using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _20211113_IteratorDays
{
    class Program
    {
        public static IEnumerable Test(int days)
        {
            DateTime dt = DateTime.Today;
            for (int i = 1; i <= days;)
            {
                //土曜と日曜を除く日付を返す
                if (dt.DayOfWeek != DayOfWeek.Sunday && dt.DayOfWeek != DayOfWeek.Saturday)
                {
                    yield return dt; //日付を戻り値として返す
                    i++; //処理回数の加算
                }
                dt = dt.AddDays(1); //日付に1日加算
            }
        }

        static void Main(string[] args)
        {
            // Test()を10回呼び戻す
            foreach (DateTime dt in Test(10))
            {
                Console.WriteLine(dt.ToString("yyyy年MM月dd日(ddd)"));
            }
        }
    }
}
