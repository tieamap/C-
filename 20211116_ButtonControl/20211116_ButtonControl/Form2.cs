using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211116_ButtonControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // ログインID-PWテーブル
        private string[] user1 = { "taro", "tr1234" };
        private string[] user2 = { "hanako", "hn1234" };

        // ユーザ名とパスワードが一致した場合に実行するメソッド
        private void auth()
        {
            MessageBox.Show("パスワードを受け付けました");
            this.Close(); // Form2を閉じてForm1を表示
        }

        private void noauth()
        {
            MessageBox.Show("認証できません。");
            textBox1.Clear(); // ユーザ名の入力欄を空にする
            textBox2.Clear(); // パスワードの入力欄を空にする
            textBox1.Focus(); // ユーザ名の入力欄にフォーカスを移動
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                // ユーザ名がtaroの場合
                case "taro":
                    // 配列taroの2つ目の要素とパスワードが一致するか
                    if(textBox2.Text == user1[1])
                    {
                        auth(); // 一致すればauth()メソッドを実行
                        break;
                    }
                    else
                    {
                        goto default; // 一致しなければdefaultブロックへ
                    }
                // ユーザ名がhanakoの場合
                case "hanako":
                    if(textBox2.Text == user2[1])
                    {
                        auth();
                        break;
                    }
                    else
                    {
                        goto default;
                    }
                // ユーザ名が登録されていない場合とユーザ名とパスワードが一致しない場合にnoauth()を実行
                default:
                    noauth();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // キャンセルボタンでアプリを終了
            Application.Exit();
        }
    }
}
