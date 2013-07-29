namespace Will_Weibo_Tencent
{
    partial class FrmEntry
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
            this.btnCommonUserStart = new System.Windows.Forms.Button();
            this.llblDevEntry = new System.Windows.Forms.LinkLabel();
            this.lblDescrption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommonUserStart
            // 
            this.btnCommonUserStart.Location = new System.Drawing.Point(338, 124);
            this.btnCommonUserStart.Name = "btnCommonUserStart";
            this.btnCommonUserStart.Size = new System.Drawing.Size(82, 35);
            this.btnCommonUserStart.TabIndex = 0;
            this.btnCommonUserStart.Text = "Start";
            this.btnCommonUserStart.UseVisualStyleBackColor = true;
            this.btnCommonUserStart.Click += new System.EventHandler(this.btnCommonUserEntry_Click);
            // 
            // llblDevEntry
            // 
            this.llblDevEntry.AutoSize = true;
            this.llblDevEntry.Location = new System.Drawing.Point(328, 259);
            this.llblDevEntry.Name = "llblDevEntry";
            this.llblDevEntry.Size = new System.Drawing.Size(113, 12);
            this.llblDevEntry.TabIndex = 1;
            this.llblDevEntry.TabStop = true;
            this.llblDevEntry.Text = "Developer Entry...";
            this.llblDevEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDevEntry_LinkClicked);
            // 
            // lblDescrption
            // 
            this.lblDescrption.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDescrption.Location = new System.Drawing.Point(6, 15);
            this.lblDescrption.Name = "lblDescrption";
            this.lblDescrption.Size = new System.Drawing.Size(292, 242);
            this.lblDescrption.TabIndex = 2;
            this.lblDescrption.Text = "Welcome, users!\r\n....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescrption);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FrmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 290);
            this.Controls.Add(this.btnCommonUserStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llblDevEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntry";
            this.Load += new System.EventHandler(this.FrmEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommonUserStart;
        private System.Windows.Forms.LinkLabel llblDevEntry;
        private System.Windows.Forms.Label lblDescrption;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}