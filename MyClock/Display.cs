using System;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void SetDisplayTime()
        {
            timeNow.Text = DateTime.Now.ToString("HH時mm分 ss秒");
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            // フォームをフェードアウトさせる
            FormFadeOut();
            // フォームを閉じる → アプリを終了する
            this.Close();
        }

        private void FormFadeOut()
        {
            for (int n = 49; n >= 0; n--)
            {
                // 49％から1％ずつ不透明度を少なくする（＝透明になる）
                this.Opacity = (double)n / 100;
                // 1％減るごとに1ミリ秒処理を停止する
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
