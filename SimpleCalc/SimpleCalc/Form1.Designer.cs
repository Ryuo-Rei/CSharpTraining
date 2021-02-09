
namespace SimpleCalc
{
    partial class Result
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
            this.input1TextBox = new System.Windows.Forms.TextBox();
            this.plusLabel = new System.Windows.Forms.Label();
            this.input2TextBox = new System.Windows.Forms.TextBox();
            this.equalLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.operatorLavel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calcButton2 = new System.Windows.Forms.Button();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.multipliedRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // input1TextBox
            // 
            this.input1TextBox.Location = new System.Drawing.Point(12, 12);
            this.input1TextBox.Name = "input1TextBox";
            this.input1TextBox.Size = new System.Drawing.Size(100, 19);
            this.input1TextBox.TabIndex = 0;
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(118, 19);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(11, 12);
            this.plusLabel.TabIndex = 1;
            this.plusLabel.Text = "+";
            // 
            // input2TextBox
            // 
            this.input2TextBox.Location = new System.Drawing.Point(135, 12);
            this.input2TextBox.Name = "input2TextBox";
            this.input2TextBox.Size = new System.Drawing.Size(100, 19);
            this.input2TextBox.TabIndex = 2;
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(241, 19);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(11, 12);
            this.equalLabel.TabIndex = 3;
            this.equalLabel.Text = "=";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(258, 12);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 19);
            this.AnswerTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(12, 51);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(346, 23);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "計算する";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 6;
            // 
            // operatorLavel
            // 
            this.operatorLavel.AutoSize = true;
            this.operatorLavel.Location = new System.Drawing.Point(129, 127);
            this.operatorLavel.Name = "operatorLavel";
            this.operatorLavel.Size = new System.Drawing.Size(0, 12);
            this.operatorLavel.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 10;
            // 
            // calcButton2
            // 
            this.calcButton2.Location = new System.Drawing.Point(284, 176);
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.Size = new System.Drawing.Size(75, 23);
            this.calcButton2.TabIndex = 11;
            this.calcButton2.Text = "計算ボタン";
            this.calcButton2.UseVisualStyleBackColor = true;
            this.calcButton2.Click += new System.EventHandler(this.calcButton2_Click);
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Location = new System.Drawing.Point(12, 176);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(88, 16);
            this.plusRadioButton.TabIndex = 12;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "radioButton1";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            this.plusRadioButton.CheckedChanged += new System.EventHandler(this.plusRadioButton_CheckedChanged);
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Location = new System.Drawing.Point(106, 176);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(88, 16);
            this.divideRadioButton.TabIndex = 13;
            this.divideRadioButton.TabStop = true;
            this.divideRadioButton.Text = "radioButton2";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            this.divideRadioButton.CheckedChanged += new System.EventHandler(this.divideRadioButton_CheckedChanged);
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Location = new System.Drawing.Point(12, 207);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(88, 16);
            this.minusRadioButton.TabIndex = 14;
            this.minusRadioButton.TabStop = true;
            this.minusRadioButton.Text = "radioButton3";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            this.minusRadioButton.CheckedChanged += new System.EventHandler(this.minusRadioButton_CheckedChanged);
            // 
            // multipliedRadioButton
            // 
            this.multipliedRadioButton.AutoSize = true;
            this.multipliedRadioButton.Location = new System.Drawing.Point(106, 207);
            this.multipliedRadioButton.Name = "multipliedRadioButton";
            this.multipliedRadioButton.Size = new System.Drawing.Size(88, 16);
            this.multipliedRadioButton.TabIndex = 15;
            this.multipliedRadioButton.TabStop = true;
            this.multipliedRadioButton.Text = "radioButton4";
            this.multipliedRadioButton.UseVisualStyleBackColor = true;
            this.multipliedRadioButton.CheckedChanged += new System.EventHandler(this.multipliedRadioButton_CheckedChanged);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multipliedRadioButton);
            this.Controls.Add(this.minusRadioButton);
            this.Controls.Add(this.divideRadioButton);
            this.Controls.Add(this.plusRadioButton);
            this.Controls.Add(this.calcButton2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.operatorLavel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.input2TextBox);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.input1TextBox);
            this.Name = "Result";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1TextBox;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.TextBox input2TextBox;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label operatorLavel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calcButton2;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.RadioButton multipliedRadioButton;
    }
}

