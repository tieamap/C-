using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211113_GenericClass
{
    class Program
    {
        // 型パラメータ<T>を設定
        public class ListTest<T>
        {
            private T[] list = new T[100];
            int add;

            // ここの処理がよく分からない
            public void AddItem(T item)
            {
                list[add++] = item;
            }

            // インデクサの定義
            public T this[int index]
            {
                get { return list[index]; }
                set { list[index] = value; }
            }
        }


        static void Main(string[] args)
        {
            // 文字列のリストを作成
            ListTest<string> list = new ListTest<string>();

            list.AddItem("1番目の要素です。");
            list.AddItem("2番目の要素です。");

            // 文字列の出力
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            // DateTime型のリストを作成
            ListTest<DateTime> dt = new ListTest<DateTime>();
            dt.AddItem(DateTime.Today);

            // 日時の出力
            DateTime today = dt[0];
            Console.WriteLine(today);
        }
    }
}
