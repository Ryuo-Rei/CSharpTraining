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
    public partial class Form2 : Form
    {
        private Bitmap canvas;
        Form1 form;
        public Form2(Form1 form)
        {
            this.form = form;
            this.TopMost = true;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox form_pb = (PictureBox)form.Controls["mainPictureBox"];
            Panel form_textColorPanel = (Panel)form.Controls["textColorPanel"];
            Panel form_backGroundColorPanel = (Panel)form.Controls["backGroundColorPanel"];
            TextBox form_tb = (TextBox)form.Controls["textString"];
            Brush textColorBrush = new SolidBrush(form_textColorPanel.BackColor);
            Brush backColorBrush = new SolidBrush(form_backGroundColorPanel.BackColor);

            canvas = new Bitmap(subPictureBox.Height, subPictureBox.Width);

            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.FillRectangle(backColorBrush, g.VisibleClipBounds);
                g.DrawString(form_tb.Text,
                    form_pb.Font,
                    textColorBrush, 0, subPictureBox.Height / 2 - form_pb.Font.Size, new StringFormat());

                subPictureBox.Image = canvas;
            }
        }
    }
}
