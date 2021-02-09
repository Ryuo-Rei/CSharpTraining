using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusen
{
    public partial class FormFusen : Form
    {
        private int mouseX; // マウスの横位置(x座標)
        private int mouseY; // マウスの縦位置(y座標)
        public FormFusen()
        {
            InitializeComponent();
        }

        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            // <判定> 押されたキーがエスケープキー
            if(e.KeyCode == Keys.Escape)
            {
                // Yesの場合
                // アプリケーションを終了
                if (Properties.Settings.Default.previousBackColor != textFusenMemo.BackColor
                    || Properties.Settings.Default.previousTextColor != textFusenMemo.ForeColor
                    || Properties.Settings.Default.previousFont != textFusenMemo.Font
                    || Properties.Settings.Default.previousOpacity != this.Opacity
                    || Properties.Settings.Default.previousText != textFusenMemo.Text)
                {
                    DialogResult dr = MessageBox.Show("前回の内容から変更されていますが、閉じますか？", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Properties.Settings.Default.previousBackColor = textFusenMemo.BackColor;
                        Properties.Settings.Default.previousTextColor = textFusenMemo.ForeColor;
                        Properties.Settings.Default.previousFont = textFusenMemo.Font;
                        Properties.Settings.Default.previousOpacity = this.Opacity;
                        Properties.Settings.Default.previousText = textFusenMemo.Text;
                        Properties.Settings.Default.Save();
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            // <判定> 押されたボタンがマウスの左ボタン?
            if(e.Button == MouseButtons.Left)
            {
                // Yesの場合
                this.mouseX = e.X; // マウスの横位置(x座標)を記憶
                this.mouseY = e.Y; // マウスの縦位置(y座標)を記憶
            }
        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog(); // 色の設定ダイアログを表示する
            this.TopMost = false;
        }

        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            // <判定> 押されたボタンがマウスの左ボタン?
            if(e.Button == MouseButtons.Left)
            {
                // Yesの場合
                this.Left += e.X - mouseX; // フォームの横位置(x座標)を更新
                this.Top += e.Y - mouseY; // フォームの縦位置(y座標)を更新
            }
        }

        private void FormFusen_Load(object sender, EventArgs e)
        {
            textFusenMemo.BackColor = Properties.Settings.Default.previousBackColor;
            textFusenMemo.ForeColor = Properties.Settings.Default.previousTextColor;
            textFusenMemo.Font = Properties.Settings.Default.previousFont;
            this.Opacity = Properties.Settings.Default.previousOpacity;
            textFusenMemo.Text = Properties.Settings.Default.previousText;
        }
    }
}
