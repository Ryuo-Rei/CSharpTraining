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
    public partial class Form2 : Form
    {
        FormFusen ff;
        public Form2(FormFusen ff)
        {
            this.ff = ff;
            this.TopMost = true;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            backGroundColorPanel.BackColor = Properties.Settings.Default.previousBackColor;
            textColorPanel.BackColor = Properties.Settings.Default.previousTextColor;
            fontPanel.Font = Properties.Settings.Default.previousFont;
            opacityTxtBox.Text = (Properties.Settings.Default.previousOpacity * 100).ToString();
        }

        private void backGroundColorPanel_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                backGroundColorPanel.BackColor = colorDialog1.Color;
            }
        }

        private void fontPanel_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = fontDialog1.ShowDialog();
            if (dr2 == System.Windows.Forms.DialogResult.OK)
            {
                fontPanel.Font = fontDialog1.Font;
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            TextBox ff_tb = (TextBox)ff.Controls["textFusenMemo"];
            ff_tb.BackColor = this.backGroundColorPanel.BackColor;
            ff_tb.ForeColor = this.textColorPanel.BackColor;
            ff_tb.Font = this.fontPanel.Font;
            ff.Opacity = double.Parse(opacityTxtBox.Text) / 100;

            this.Close();

        }

        private void textColorPanel_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = colorDialog2.ShowDialog();
            if (dr2 == System.Windows.Forms.DialogResult.OK)
            {
                textColorPanel.BackColor = colorDialog2.Color;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
