
namespace Timer
{
    partial class FormTimer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textSetTime = new System.Windows.Forms.TextBox();
            this.secondLavel1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textRemainingTime = new System.Windows.Forms.TextBox();
            this.secondLevel2 = new System.Windows.Forms.Label();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "時間設定";
            // 
            // textSetTime
            // 
            this.textSetTime.Location = new System.Drawing.Point(90, 6);
            this.textSetTime.Name = "textSetTime";
            this.textSetTime.Size = new System.Drawing.Size(100, 19);
            this.textSetTime.TabIndex = 1;
            this.textSetTime.Text = "10";
            this.textSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textSetTime.TextChanged += new System.EventHandler(this.textSetTime_TextChanged);
            // 
            // secondLavel1
            // 
            this.secondLavel1.AutoSize = true;
            this.secondLavel1.Location = new System.Drawing.Point(206, 13);
            this.secondLavel1.Name = "secondLavel1";
            this.secondLavel1.Size = new System.Drawing.Size(17, 12);
            this.secondLavel1.TabIndex = 2;
            this.secondLavel1.Text = "秒";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "残り時間";
            // 
            // textRemainingTime
            // 
            this.textRemainingTime.Location = new System.Drawing.Point(90, 81);
            this.textRemainingTime.Name = "textRemainingTime";
            this.textRemainingTime.Size = new System.Drawing.Size(100, 19);
            this.textRemainingTime.TabIndex = 5;
            this.textRemainingTime.Text = "10";
            this.textRemainingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secondLevel2
            // 
            this.secondLevel2.AutoSize = true;
            this.secondLevel2.Location = new System.Drawing.Point(206, 88);
            this.secondLevel2.Name = "secondLevel2";
            this.secondLevel2.Size = new System.Drawing.Size(17, 12);
            this.secondLevel2.TabIndex = 6;
            this.secondLevel2.Text = "秒";
            // 
            // timerControl
            // 
            this.timerControl.Interval = 1000;
            this.timerControl.Tick += new System.EventHandler(this.timerControl_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(134, 41);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(89, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.secondLevel2);
            this.Controls.Add(this.textRemainingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.secondLavel1);
            this.Controls.Add(this.textSetTime);
            this.Controls.Add(this.label1);
            this.Name = "FormTimer";
            this.Text = "タイマー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSetTime;
        private System.Windows.Forms.Label secondLavel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRemainingTime;
        private System.Windows.Forms.Label secondLevel2;
        private System.Windows.Forms.Timer timerControl;
        private System.Windows.Forms.Button buttonReset;
    }
}

