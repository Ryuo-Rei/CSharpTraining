
namespace TextDifferentHunt
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPictureWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPictureHeight = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.backGroundColorPanel = new System.Windows.Forms.Panel();
            this.textColorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonChangeFont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPictureBox.Location = new System.Drawing.Point(394, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(100, 94);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "画像サイズ";
            // 
            // textPictureWidth
            // 
            this.textPictureWidth.Location = new System.Drawing.Point(62, 121);
            this.textPictureWidth.Name = "textPictureWidth";
            this.textPictureWidth.Size = new System.Drawing.Size(100, 19);
            this.textPictureWidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // textPictureHeight
            // 
            this.textPictureHeight.Location = new System.Drawing.Point(206, 121);
            this.textPictureHeight.Name = "textPictureHeight";
            this.textPictureHeight.Size = new System.Drawing.Size(100, 19);
            this.textPictureHeight.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(419, 119);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "文字列";
            // 
            // textString
            // 
            this.textString.Location = new System.Drawing.Point(44, 215);
            this.textString.Multiline = true;
            this.textString.Name = "textString";
            this.textString.Size = new System.Drawing.Size(262, 42);
            this.textString.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "フォントサイズ, フォント";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "背景色";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "文字色";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(73, 309);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(0, 12);
            this.labelFont.TabIndex = 13;
            this.labelFont.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // backGroundColorPanel
            // 
            this.backGroundColorPanel.Location = new System.Drawing.Point(44, 369);
            this.backGroundColorPanel.Name = "backGroundColorPanel";
            this.backGroundColorPanel.Size = new System.Drawing.Size(39, 35);
            this.backGroundColorPanel.TabIndex = 14;
            this.backGroundColorPanel.Click += new System.EventHandler(this.backGroundColorPanel_Click);
            // 
            // textColorPanel
            // 
            this.textColorPanel.Location = new System.Drawing.Point(161, 369);
            this.textColorPanel.Name = "textColorPanel";
            this.textColorPanel.Size = new System.Drawing.Size(39, 35);
            this.textColorPanel.TabIndex = 15;
            this.textColorPanel.Click += new System.EventHandler(this.textColor_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(407, 399);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "生成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOK);
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Location = new System.Drawing.Point(188, 278);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeFont.TabIndex = 17;
            this.buttonChangeFont.Text = "フォント変更";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.buttonChangeFont);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textColorPanel);
            this.Controls.Add(this.backGroundColorPanel);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textPictureHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPictureWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPictureWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPictureHeight;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Panel backGroundColorPanel;
        private System.Windows.Forms.Panel textColorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonChangeFont;
    }
}

