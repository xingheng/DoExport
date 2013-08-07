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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntry));
            this.btnCommonUserStart = new System.Windows.Forms.Button();
            this.llblDevEntry = new System.Windows.Forms.LinkLabel();
            this.lblDescrption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommonUserStart
            // 
            resources.ApplyResources(this.btnCommonUserStart, "btnCommonUserStart");
            this.btnCommonUserStart.Name = "btnCommonUserStart";
            this.btnCommonUserStart.UseVisualStyleBackColor = true;
            this.btnCommonUserStart.Click += new System.EventHandler(this.btnCommonUserEntry_Click);
            // 
            // llblDevEntry
            // 
            resources.ApplyResources(this.llblDevEntry, "llblDevEntry");
            this.llblDevEntry.Name = "llblDevEntry";
            this.llblDevEntry.TabStop = true;
            this.llblDevEntry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDevEntry_LinkClicked);
            // 
            // lblDescrption
            // 
            resources.ApplyResources(this.lblDescrption, "lblDescrption");
            this.lblDescrption.Name = "lblDescrption";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescrption);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // FrmEntry
            // 
            this.AcceptButton = this.btnCommonUserStart;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCommonUserStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llblDevEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEntry";
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