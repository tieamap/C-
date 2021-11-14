using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211114_PrefecturalCode
{
    public enum Code : int
    {
        Gunma = 10,
        Saitama = 11,
        Chiba = 12,
        Tokyo = 13,
        Kanagawa = 14
    }

    class Program
    {
        static void Main(string[] args)
        {
            Code value = Code.Saitama;
            Disp(value);
        }

        static void Disp(Code value)
        {
            // 渡されたコードによって分岐
            switch (value)
            {
                case Code.Gunma:
                    Console.WriteLine("群馬県のコード=" + (int)value);
                    break;
                case Code.Saitama:
                    Console.WriteLine("埼玉県のコード=" + (int)value);
                    break;
                case Code.Chiba:
                    Console.WriteLine("千葉県のコード=" + (int)value);
                    break;
                case Code.Tokyo:
                    Console.WriteLine("東京都のコード=" + (int)value);
                    break;
                case Code.Kanagawa:
                    Console.WriteLine("神奈川県のコード=" + (int)value);
                    break;
            }
        }
    }
}
