using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211115_ReferenceType
{
    public class TestClass
    {
        private int num;
        public TestClass(int num)
        {
            this.num = num;
        }
        public int Num
        {
            get { return num; }
        }

        // クラス型のパラメータを持つメソッド
        public void Show(TestClass a)
        {
            // フィールドnumの値をvalueに代入する
            Console.WriteLine(
                "呼び出し元のインスタンスのフィールド値は" + this.num);
            Console.WriteLine(
                "引数で渡されたインスタンスのフィールド値は" + a.num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass obj1 = new TestClass(100);
            TestClass obj2 = new TestClass(500);
            // 参照変数obj2を引数にしてshow()メソッドを呼び出す
            obj1.Show(obj2);
        }
    }
}
