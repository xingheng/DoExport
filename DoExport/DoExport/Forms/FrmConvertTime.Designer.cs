namespace DoExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvertTime));
            this.rBtnDateTime2TimeStamp = new System.Windows.Forms.RadioButton();
            this.rBtnTimeStamp2DateTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxtTimeStamp = new System.Windows.Forms.MaskedTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBoxCopyResult = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnDateTime2TimeStamp
            // 
            resources.ApplyResources(this.rBtnDateTime2TimeStamp, "rBtnDateTime2TimeStamp");
            this.rBtnDateTime2TimeStamp.Name = "rBtnDateTime2TimeStamp";
            this.rBtnDateTime2TimeStamp.TabStop = true;
            this.rBtnDateTime2TimeStamp.UseVisualStyleBackColor = true;
            // 
            // rBtnTimeStamp2DateTime
            // 
            resources.ApplyResources(this.rBtnTimeStamp2DateTime, "rBtnTimeStamp2DateTime");
            this.rBtnTimeStamp2DateTime.Name = "rBtnTimeStamp2DateTime";
            this.rBtnTimeStamp2DateTime.TabStop = true;
            this.rBtnTimeStamp2DateTime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // mTxtTimeStamp
            // 
            resources.ApplyResources(this.mTxtTimeStamp, "mTxtTimeStamp");
            this.mTxtTimeStamp.Name = "mTxtTimeStamp";
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cBoxCopyResult
            // 
            resources.ApplyResources(this.cBoxCopyResult, "cBoxCopyResult");
            this.cBoxCopyResult.Name = "cBoxCopyResult";
            this.cBoxCopyResult.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // FrmConvertTime
            // 
            this.AcceptButton = this.btnConvert;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConvertTime";
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