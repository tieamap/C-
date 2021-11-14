using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211114_OverrideApp
{
    class Class2 : Class1 // Class1を継承
    {
        // Nameプロパティをオーバライド
        public override string Name
        {
            get { return base.Name; }
            set
            {
                // プロパティにセットする値が空であればメッセージを表示して既定の値をセットする
                if (value == "")
                {
                    MessageBox.Show("名前が入力されていません。", "確認");
                    base.Name = "?";
                }
                // 値が存在すれば基本クラスのプロパティにセットする
                else
                {
                    base.Name = value;
                }
            }
        }

        public override DateTime Birthday
        {
            get { return base.Birthday; }
            set
            {
                // 本日以降の日付が選択されていればメッセージを表示して今日の日付に置き換える
                if (value > DateTime.Today)
                {
                    MessageBox.Show(
                        "誕生日の値が不正ですので、本日の日付を設定します。", "確認");
                    base.Birthday = DateTime.Today;
                }
                // 本日以前の日付であれば基本クラスのプロパティにセットする
                else
                {
                    base.Birthday = value;
                }
            }
        }

        public override int GetAge()
        {
            // メッセージを表示してから基本クラスのメソッドを呼び出す
            MessageBox.Show("年齢を計算します。", "確認");
            return base.GetAge();
        }
    }
}
