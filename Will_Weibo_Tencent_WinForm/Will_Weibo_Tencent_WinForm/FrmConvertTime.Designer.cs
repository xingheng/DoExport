namespace Will_Weibo_Tencent
{
    partial class FrmConvertTime
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
            this.rBtnDateTime2TimeStamp = new System.Windows.Forms.RadioButton();
            this.rBtnTimeStamp2DateTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxtTimeStamp = new System.Windows.Forms.MaskedTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cBoxCopyResult = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnDateTime2TimeStamp
            // 
            this.rBtnDateTime2TimeStamp.AutoSize = true;
            this.rBtnDateTime2TimeStamp.Location = new System.Drawing.Point(14, 11);
            this.rBtnDateTime2TimeStamp.Name = "rBtnDateTime2TimeStamp";
            this.rBtnDateTime2TimeStamp.Size = new System.Drawing.Size(149, 16);
            this.rBtnDateTime2TimeStamp.TabIndex = 0;
            this.rBtnDateTime2TimeStamp.TabStop = true;
            this.rBtnDateTime2TimeStamp.Text = "DateTime to TimeStamp";
            this.rBtnDateTime2TimeStamp.UseVisualStyleBackColor = true;
            // 
            // rBtnTimeStamp2DateTime
            // 
            this.rBtnTimeStamp2DateTime.AutoSize = true;
            this.rBtnTimeStamp2DateTime.Location = new System.Drawing.Point(193, 11);
            this.rBtnTimeStamp2DateTime.Name = "rBtnTimeStamp2DateTime";
            this.rBtnTimeStamp2DateTime.Size = new System.Drawing.Size(149, 16);
            this.rBtnTimeStamp2DateTime.TabIndex = 1;
            this.rBtnTimeStamp2DateTime.TabStop = true;
            this.rBtnTimeStamp2DateTime.Text = "TimeStamp to DateTime";
            this.rBtnTimeStamp2DateTime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "DateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "TimeStamp";
            // 
            // mTxtTimeStamp
            // 
            this.mTxtTimeStamp.Location = new System.Drawing.Point(85, 69);
            this.mTxtTimeStamp.Name = "mTxtTimeStamp";
            this.mTxtTimeStamp.Size = new System.Drawing.Size(194, 21);
            this.mTxtTimeStamp.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(295, 43);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(80, 43);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cBoxCopyResult);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.mTxtTimeStamp);
            this.panel1.Controls.Add(this.rBtnDateTime2TimeStamp);
            this.panel1.Controls.Add(this.rBtnTimeStamp2DateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 123);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(85, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 21);
            this.dateTimePicker.TabIndex = 9;
            // 
            // cBoxCopyResult
            // 
            this.cBoxCopyResult.AutoSize = true;
            this.cBoxCopyResult.Location = new System.Drawing.Point(85, 98);
            this.cBoxCopyResult.Name = "cBoxCopyResult";
            this.cBoxCopyResult.Size = new System.Drawing.Size(192, 16);
            this.cBoxCopyResult.TabIndex = 10;
            this.cBoxCopyResult.Text = "Copy the result to clipboard";
            this.cBoxCopyResult.UseVisualStyleBackColor = true;
            // 
            // FrmConvertTime
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 140);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConvertTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConvertTime";
            this.Load += new System.EventHandler(this.FrmConvertTime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnTimeStamp2DateTime;
        private System.Windows.Forms.RadioButton rBtnDateTime2TimeStamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTxtTimeStamp;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox cBoxCopyResult;
    }
}