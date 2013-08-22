namespace DoExport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImportFilePath = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cBoxImportFileKind = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCondition, "comboBoxCondition");
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
            this.groupBox1.Controls.Add(this.comboBoxCondition);
            this.groupBox1.Controls.Add(this.btnGoExport);
            this.groupBox1.Controls.Add(this.btnSettingForRequest);
            this.groupBox1.Controls.Add(this.btnRequest);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImportFilePath);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.cBoxImportFileKind);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtImportFilePath
            // 
            this.txtImportFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImportFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtImportFilePath, "txtImportFilePath");
            this.txtImportFilePath.Name = "txtImportFilePath";
            this.txtImportFilePath.ReadOnly = true;
            // 
            // btnPreview
            // 
            resources.ApplyResources(this.btnPreview, "btnPreview");
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cBoxImportFileKind
            // 
            this.cBoxImportFileKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxImportFileKind.FormattingEnabled = true;
            resources.ApplyResources(this.cBoxImportFileKind, "cBoxImportFileKind");
            this.cBoxImportFileKind.Name = "cBoxImportFileKind";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmRequestSelect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmRequestSelect";
            this.Load += new System.EventHandler(this.FrmReadRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingForRequest;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnGoExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cBoxImportFileKind;
        private System.Windows.Forms.TextBox txtImportFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}