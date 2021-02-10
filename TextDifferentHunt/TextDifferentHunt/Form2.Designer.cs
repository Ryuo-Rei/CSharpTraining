
namespace TextDifferentHunt
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.subPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // subPictureBox
            // 
            this.subPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPictureBox.Location = new System.Drawing.Point(0, 0);
            this.subPictureBox.Name = "subPictureBox";
            this.subPictureBox.Size = new System.Drawing.Size(800, 450);
            this.subPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subPictureBox.TabIndex = 0;
            this.subPictureBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subPictureBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox subPictureBox;
    }
}