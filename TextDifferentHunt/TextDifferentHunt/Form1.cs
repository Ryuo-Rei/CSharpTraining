using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDifferentHunt
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(canvas, int.Parse(textPictureWidth.Text), int.Parse(textPictureHeight.Text));

            saveFileDialog1.Filter = "GIF形式|*.gif|JPEG形式|*.jpeg|PNG形式|*.png";

            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOK(object sender, CancelEventArgs e)
        {
            string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);

            switch (extension.ToUpper())
            {
                case ".GIF":
                    mainPictureBox.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case ".JPEG":
                    mainPictureBox.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".PNG":
                    mainPictureBox.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mainPictureBox.Image == null)
            {
                MessageBox.Show("画像イメージがありません。画像を生成してください。");
            }
            else
            {
                Form2 form2 = new Form2(this);
                form2.Size = new Size(int.Parse(textPictureWidth.Text), int.Parse(textPictureHeight.Text));
                this.TopMost = false;
                form2.Show();
            }
        }

        private void backGroundColorPanel_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                backGroundColorPanel.BackColor = colorDialog1.Color;
            }
        }

        private void textColor_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = colorDialog2.ShowDialog();
            if (dr2 == System.Windows.Forms.DialogResult.OK)
            {
                textColorPanel.BackColor = colorDialog2.Color;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(IsNumber() == false)
            {
                MessageBox.Show("画像サイズを数字で入力してください。");
            }

            else if (String.IsNullOrWhiteSpace(textString.Text) == true)
            {
                MessageBox.Show("生成する文字列を入力してください。");
            }
            else
            {
                if (float.Parse(textPictureWidth.Text) > 0
                                    && float.Parse(textPictureHeight.Text) > 0)
                {
                    Brush textColorBrush = new SolidBrush(textColorPanel.BackColor);
                    Brush backColorBrush = new SolidBrush(backGroundColorPanel.BackColor);

                    canvas = new Bitmap(mainPictureBox.Height, mainPictureBox.Width);

                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.FillRectangle(backColorBrush, g.VisibleClipBounds);
                        g.DrawString(textString.Text,
                            fontDialog1.Font,
                            textColorBrush, 0, mainPictureBox.Height / 2 - fontDialog1.Font.Size, new StringFormat());
                        mainPictureBox.Font = fontDialog1.Font;
                        mainPictureBox.Image = canvas;
                    }
                }
                else
                {
                    MessageBox.Show("画像サイズは0より大きい数字を入力してください。");
                }
            }
        }

        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = fontDialog1.ShowDialog();
            if (dr2 == System.Windows.Forms.DialogResult.OK)
            {
                labelFont.Text = "" + fontDialog1.Font.Name + ", " + fontDialog1.Font.Size;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backGroundColorPanel.BackColor = Color.Gray;
            textColorPanel.BackColor = Color.White;
        }

        private bool IsNumber()
        {
            if (float.TryParse(textPictureWidth.Text, out float width) == true
                && float.TryParse(textPictureHeight.Text, out float height) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}