using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211116_ImplementInterface
{
    // ISampleインターフェイスを実装する抽象クラス
    abstract class SperCls : ISample
    {
        public int Val { get; set; } // 計算結果を保持するプロパティ
        public int Num { get; set; } = 100; // 計算に使用する値を保持するプロパティ

        // 掛け算を行うメソッド
        abstract public void Multiplier(int n);

        // 割り算を行うメソッド
        abstract public void Divider(int n);

        // Multiplier()とDiveder()を呼び出す方法だけを定義
        public void DoCalc(int n)
        {
            if (Num > n)
                // パラメータnの値がNumより小さければMultiplier()を実行
                this.Multiplier(n);
            else
                // それ以外はDivider()を実行
                this.Divider(n);
        }
    }
}
