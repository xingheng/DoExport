namespace Will_Weibo_Tencent
{
    partial class FrmRequestSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestSelect));
            this.btnSettingForRequest = new System.Windows.Forms.Button();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnGoExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingForRequest
            // 
            resources.ApplyResources(this.btnSettingForRequest, "btnSettingForRequest");
            this.btnSettingForRequest.Name = "btnSettingForRequest";
            this.btnSettingForRequest.UseVisualStyleBackColor = true;
            this.btnSettingForRequest.Click += new System.EventHandler(this.btnSettingForRequest_Click);
            // 
            // comboBoxCondition
            // 
            resources.ApplyResources(this.comboBoxCondition, "comboBoxCondition");
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Name = "comboBoxCondition";
            // 
            // btnRequest
            // 
            resources.ApplyResources(this.btnRequest, "btnRequest");
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnGoExport
            // 
            resources.ApplyResources(this.btnGoExport, "btnGoExport");
            this.btnGoExport.Name = "btnGoExport";
            this.btnGoExport.UseVisualStyleBackColor = true;
            this.btnGoExport.Click += new System.EventHandler(this.btnGoExport_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.comboBoxCondition);
            this.groupBox1.Controls.Add(this.btnGoExport);
            this.groupBox1.Controls.Add(this.btnSettingForRequest);
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // FrmRequestSelect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmRequestSelect";
            this.Load += new System.EventHandler(this.FrmReadRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingForRequest;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnGoExport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}