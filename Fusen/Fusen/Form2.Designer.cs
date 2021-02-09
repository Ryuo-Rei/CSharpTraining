
namespace Fusen
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backGroundColorLabel = new System.Windows.Forms.Label();
            this.settingButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backGroundColorPanel = new System.Windows.Forms.Panel();
            this.textColorLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.fontPanel = new System.Windows.Forms.Panel();
            this.textColorPanel = new System.Windows.Forms.Panel();
            this.opacityPecentageLabel = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.opacityTxtBox = new System.Windows.Forms.TextBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // backGroundColorLabel
            // 
            this.backGroundColorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.backGroundColorLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backGroundColorLabel.Location = new System.Drawing.Point(12, 12);
            this.backGroundColorLabel.Name = "backGroundColorLabel";
            this.backGroundColorLabel.Size = new System.Drawing.Size(65, 22);
            this.backGroundColorLabel.TabIndex = 0;
            this.backGroundColorLabel.Text = "背景色";
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingButton.Location = new System.Drawing.Point(15, 171);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(75, 23);
            this.settingButton.TabIndex = 4;
            this.settingButton.Text = "設定";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(108, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backGroundColorPanel
            // 
            this.backGroundColorPanel.Location = new System.Drawing.Point(83, 12);
            this.backGroundColorPanel.Name = "backGroundColorPanel";
            this.backGroundColorPanel.Size = new System.Drawing.Size(41, 22);
            this.backGroundColorPanel.TabIndex = 6;
            this.backGroundColorPanel.Click += new System.EventHandler(this.backGroundColorPanel_Click);
            // 
            // textColorLabel
            // 
            this.textColorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.textColorLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textColorLabel.Location = new System.Drawing.Point(12, 52);
            this.textColorLabel.Name = "textColorLabel";
            this.textColorLabel.Size = new System.Drawing.Size(65, 22);
            this.textColorLabel.TabIndex = 7;
            this.textColorLabel.Text = "文字色";
            // 
            // fontLabel
            // 
            this.fontLabel.BackColor = System.Drawing.SystemColors.Control;
            this.fontLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fontLabel.Location = new System.Drawing.Point(12, 89);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(65, 22);
            this.fontLabel.TabIndex = 8;
            this.fontLabel.Text = "フォント";
            // 
            // opacityLabel
            // 
            this.opacityLabel.BackColor = System.Drawing.SystemColors.Control;
            this.opacityLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.opacityLabel.Location = new System.Drawing.Point(12, 127);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(65, 22);
            this.opacityLabel.TabIndex = 9;
            this.opacityLabel.Text = "透過率";
            // 
            // fontPanel
            // 
            this.fontPanel.Location = new System.Drawing.Point(83, 89);
            this.fontPanel.Name = "fontPanel";
            this.fontPanel.Size = new System.Drawing.Size(41, 22);
            this.fontPanel.TabIndex = 7;
            this.fontPanel.Click += new System.EventHandler(this.fontPanel_Click);
            // 
            // textColorPanel
            // 
            this.textColorPanel.Location = new System.Drawing.Point(83, 52);
            this.textColorPanel.Name = "textColorPanel";
            this.textColorPanel.Size = new System.Drawing.Size(41, 22);
            this.textColorPanel.TabIndex = 7;
            this.textColorPanel.Click += new System.EventHandler(this.textColorPanel_Click);
            // 
            // opacityPecentageLabel
            // 
            this.opacityPecentageLabel.AutoSize = true;
            this.opacityPecentageLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.opacityPecentageLabel.Location = new System.Drawing.Point(130, 130);
            this.opacityPecentageLabel.Name = "opacityPecentageLabel";
            this.opacityPecentageLabel.Size = new System.Drawing.Size(19, 19);
            this.opacityPecentageLabel.TabIndex = 10;
            this.opacityPecentageLabel.Text = "%";
            // 
            // opacityTxtBox
            // 
            this.opacityTxtBox.Location = new System.Drawing.Point(83, 129);
            this.opacityTxtBox.Name = "opacityTxtBox";
            this.opacityTxtBox.Size = new System.Drawing.Size(41, 19);
            this.opacityTxtBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.opacityTxtBox);
            this.Controls.Add(this.opacityPecentageLabel);
            this.Controls.Add(this.textColorPanel);
            this.Controls.Add(this.fontPanel);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.textColorLabel);
            this.Controls.Add(this.backGroundColorPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.backGroundColorLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label backGroundColorLabel;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel backGroundColorPanel;
        private System.Windows.Forms.Label textColorLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.Panel fontPanel;
        private System.Windows.Forms.Panel textColorPanel;
        private System.Windows.Forms.Label opacityPecentageLabel;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox opacityTxtBox;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}