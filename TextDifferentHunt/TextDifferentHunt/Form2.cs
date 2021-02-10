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
            subPictureBox.Image = form_pb.Image;
            subPictureBox.BackColor = form_pb.BackColor;
        }
    }
}
