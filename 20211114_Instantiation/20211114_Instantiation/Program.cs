using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_Instantiation
{
    class Program
    {
        class Fruit
        {
            public string code; // 商品番号を格納するフィールド
            public string name; // 商品名を格納するフィールド
            public int price; // 価格を格納するフィールド
        }

        static void Main(string[] args)
        {
            // クラス型の配列fを宣言
            Fruit[] f =
            {
                new Fruit { name = "Apple", price = 200, code = "A110" },
                new Fruit { name = "Orange", price = 150, code = "G201" },
                new Fruit { name = "Grape", price = 450, code = "GR50" }
            };
            var q = from n in f
                    select new { Name = n.name, Price = n.price, Code = n.code };
            foreach (var a in q)
            {
                Console.WriteLine("Name = {0} Price={1} Code={2}", a.Name, a.Price, a.Code);
            }
        }
    }
}
