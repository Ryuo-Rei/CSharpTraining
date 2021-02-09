using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime; // 終了時間
        int elapsedTime; // 経過時間
        int initialSetting;
        
        public FormTimer()
        {
            InitializeComponent();
            initialSetting = int.Parse(textSetTime.Text);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if (int.TryParse(textSetTime.Text, out endTime) == true
                && int.Parse(textSetTime.Text) > 0)
            {
                endTime = int.Parse(textSetTime.Text);

                if (buttonStart.Text == "スタート")
                {
                    elapsedTime = 0;
                    // タイマースタート
                    timerControl.Start();
                    // 「スタート」ボタンを「一時停止」に変更する
                    buttonStart.Text = "一時停止";
                }
                else if (buttonStart.Text == "一時停止")
                {
                    // タイマーストップ
                    timerControl.Stop();
                    buttonStart.Text = "再スタート";
                }
                else if (buttonStart.Text == "再スタート")
                {
                    timerControl.Start();
                    buttonStart.Text = "一時停止";
                }
            }
            else
            {
                MessageBox.Show("0以上の数字を入力してください");
            }
        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            // 残り時間の変数を整数型で定義
            int remainingTime;
            // 経過時間に1秒を加える
            elapsedTime++;
            // 残り時間を計算して表示
            remainingTime = endTime - elapsedTime;
            textRemainingTime.Text = remainingTime.ToString();
            // <判定>設定時間になった?
            if (endTime == elapsedTime)
            {
                // 「Yes」の場合の処理
                // タイマーを止める
                timerControl.Stop();
                // 終了時間になったことを知らせる
                MessageBox.Show("時間になりました！");

                buttonStart.Text = "スタート";
                textRemainingTime.Text = endTime.ToString();

            }
            else
            {
                // 「No」の場合の処理
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timerControl.Stop();
            buttonStart.Text = "スタート";
            textSetTime.Text = initialSetting.ToString();
            textRemainingTime.Text = initialSetting.ToString();
        }

        private void textSetTime_TextChanged(object sender, EventArgs e)
        {

            textRemainingTime.Text = textSetTime.Text;
        }
    }
}
