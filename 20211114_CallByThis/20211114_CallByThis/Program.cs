using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_CallByThis
{
    class Customer
    {
        public string id;
        public string name;
        public int age;

        // パラメータを持たないコンストラクター
        public Customer()
            : this("-", "-", -1)
        {

        }

        // 2つのパラメータを持つコンストラクター
        public Customer(string id, string name)
            : this(id, name, -1)
        {

        }

        // 3つのパラメータを持つコンストラクター
        public Customer(string id, string name, int age)
        {
            // 3つのパラメータ値をフィールドに格納
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer obj1 = new Customer();
            Customer obj2 = new Customer("A101", "秀和太郎");
            Customer obj3 = new Customer("B101", "山田二郎", 28);

            Console.WriteLine(obj1.id + "," + obj1.name + "," + obj1.age);
            Console.WriteLine(obj2.id + "," + obj2.name + "," + obj2.age);
            Console.WriteLine(obj3.id + "," + obj3.name + "," + obj3.age);
        }
    }
}
