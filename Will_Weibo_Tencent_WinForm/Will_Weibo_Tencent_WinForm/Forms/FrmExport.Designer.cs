namespace DoExport
{
    partial class FrmExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExport));
            this.btnBrowseTextFile = new System.Windows.Forms.Button();
            this.rTxtResult = new System.Windows.Forms.RichTextBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePreference = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseDB = new System.Windows.Forms.Button();
            this.cBoxExportAllData = new System.Windows.Forms.CheckBox();
            this.txtDBFilePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mTxtTimeStamp = new System.Windows.Forms.MaskedTextBox();
            this.rBtnEndTime = new System.Windows.Forms.RadioButton();
            this.rBtnStartTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxExportText = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseImageFile = new System.Windows.Forms.Button();
            this.cBoxExportImage = new System.Windows.Forms.CheckBox();
            this.txtImageFilePath = new System.Windows.Forms.TextBox();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.cBoxDetailedLog = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPagePreference.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseTextFile
            // 
            resources.ApplyResources(this.btnBrowseTextFile, "btnBrowseTextFile");
            this.btnBrowseTextFile.Name = "btnBrowseTextFile";
            this.btnBrowseTextFile.UseVisualStyleBackColor = true;
            this.btnBrowseTextFile.Click += new System.EventHandler(this.btnBrowseTextFile_Click);
            // 
            // rTxtResult
            // 
            resources.ApplyResources(this.rTxtResult, "rTxtResult");
            this.rTxtResult.Name = "rTxtResult";
            // 
            // txtTextFilePath
            // 
            resources.ApplyResources(this.txtTextFilePath, "txtTextFilePath");
            this.txtTextFilePath.Name = "txtTextFilePath";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // btnNextPage
            // 
            resources.ApplyResources(this.btnNextPage, "btnNextPage");
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPagePreference);
            this.tabControl1.Controls.Add(this.tabPageDetails);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPagePreference
            // 
            resources.ApplyResources(this.tabPagePreference, "tabPagePreference");
            this.tabPagePreference.Controls.Add(this.groupBox4);
            this.tabPagePreference.Controls.Add(this.groupBox3);
            this.tabPagePreference.Controls.Add(this.groupBox2);
            this.tabPagePreference.Controls.Add(this.groupBox1);
            this.tabPagePreference.Controls.Add(this.btnNextPage);
            this.tabPagePreference.Controls.Add(this.btnExport);
            this.tabPagePreference.Name = "tabPagePreference";
            this.tabPagePreference.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.btnBrowseDB);
            this.groupBox4.Controls.Add(this.cBoxExportAllData);
            this.groupBox4.Controls.Add(this.txtDBFilePath);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnBrowseDB
            // 
            resources.ApplyResources(this.btnBrowseDB, "btnBrowseDB");
            this.btnBrowseDB.Name = "btnBrowseDB";
            this.btnBrowseDB.UseVisualStyleBackColor = true;
            this.btnBrowseDB.Click += new System.EventHandler(this.btnBrowseDB_Click);
            // 
            // cBoxExportAllData
            // 
            resources.ApplyResources(this.cBoxExportAllData, "cBoxExportAllData");
            this.cBoxExportAllData.Name = "cBoxExportAllData";
            this.cBoxExportAllData.UseVisualStyleBackColor = true;
            // 
            // txtDBFilePath
            // 
            resources.ApplyResources(this.txtDBFilePath, "txtDBFilePath");
            this.txtDBFilePath.Name = "txtDBFilePath";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnDeselectAll);
            this.groupBox3.Controls.Add(this.btnConvert);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.mTxtTimeStamp);
            this.groupBox3.Controls.Add(this.rBtnEndTime);
            this.groupBox3.Controls.Add(this.rBtnStartTime);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnDeselectAll
            // 
            resources.ApplyResources(this.btnDeselectAll, "btnDeselectAll");
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mTxtTimeStamp
            // 
            resources.ApplyResources(this.mTxtTimeStamp, "mTxtTimeStamp");
            this.mTxtTimeStamp.Name = "mTxtTimeStamp";
            // 
            // rBtnEndTime
            // 
            resources.ApplyResources(this.rBtnEndTime, "rBtnEndTime");
            this.rBtnEndTime.Name = "rBtnEndTime";
            this.rBtnEndTime.TabStop = true;
            this.rBtnEndTime.UseVisualStyleBackColor = true;
            // 
            // rBtnStartTime
            // 
            resources.ApplyResources(this.rBtnStartTime, "rBtnStartTime");
            this.rBtnStartTime.Name = "rBtnStartTime";
            this.rBtnStartTime.TabStop = true;
            this.rBtnStartTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.cBoxExportText);
            this.groupBox2.Controls.Add(this.txtTextFilePath);
            this.groupBox2.Controls.Add(this.btnBrowseTextFile);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cBoxExportText
            // 
            resources.ApplyResources(this.cBoxExportText, "cBoxExportText");
            this.cBoxExportText.Name = "cBoxExportText";
            this.cBoxExportText.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnBrowseImageFile);
            this.groupBox1.Controls.Add(this.cBoxExportImage);
            this.groupBox1.Controls.Add(this.txtImageFilePath);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnBrowseImageFile
            // 
            resources.ApplyResources(this.btnBrowseImageFile, "btnBrowseImageFile");
            this.btnBrowseImageFile.Name = "btnBrowseImageFile";
            this.btnBrowseImageFile.UseVisualStyleBackColor = true;
            this.btnBrowseImageFile.Click += new System.EventHandler(this.btnBrowseImageFile_Click);
            // 
            // cBoxExportImage
            // 
            resources.ApplyResources(this.cBoxExportImage, "cBoxExportImage");
            this.cBoxExportImage.Name = "cBoxExportImage";
            this.cBoxExportImage.UseVisualStyleBackColor = true;
            // 
            // txtImageFilePath
            // 
            resources.ApplyResources(this.txtImageFilePath, "txtImageFilePath");
            this.txtImageFilePath.Name = "txtImageFilePath";
            // 
            // tabPageDetails
            // 
            resources.ApplyResources(this.tabPageDetails, "tabPageDetails");
            this.tabPageDetails.Controls.Add(this.cBoxDetailedLog);
            this.tabPageDetails.Controls.Add(this.BtnCancel);
            this.tabPageDetails.Controls.Add(this.rTxtResult);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // cBoxDetailedLog
            // 
            resources.ApplyResources(this.cBoxDetailedLog, "cBoxDetailedLog");
            this.cBoxDetailedLog.Name = "cBoxDetailedLog";
            this.cBoxDetailedLog.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // FrmExport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmExport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExport_FormClosing);
            this.Load += new System.EventHandler(this.FrmExport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePreference.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseTextFile;
        private System.Windows.Forms.RichTextBox rTxtResult;
        private System.Windows.Forms.TextBox txtTextFilePath;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePreference;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseImageFile;
        private System.Windows.Forms.CheckBox cBoxExportImage;
        private System.Windows.Forms.TextBox txtImageFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxExportText;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTxtTimeStamp;
        private System.Windows.Forms.RadioButton rBtnEndTime;
        private System.Windows.Forms.RadioButton rBtnStartTime;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.CheckBox cBoxDetailedLog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseDB;
        private System.Windows.Forms.CheckBox cBoxExportAllData;
        private System.Windows.Forms.TextBox txtDBFilePath;
    }
}