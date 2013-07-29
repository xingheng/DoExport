namespace Will_Weibo_Tencent
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
            this.btnBrowseTextFile = new System.Windows.Forms.Button();
            this.rTxtResult = new System.Windows.Forms.RichTextBox();
            this.txtTextFilePath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePreference = new System.Windows.Forms.TabPage();
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cBoxDetailedLog = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePreference.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseTextFile
            // 
            this.btnBrowseTextFile.Location = new System.Drawing.Point(445, 42);
            this.btnBrowseTextFile.Name = "btnBrowseTextFile";
            this.btnBrowseTextFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTextFile.TabIndex = 0;
            this.btnBrowseTextFile.Text = "Browse...";
            this.btnBrowseTextFile.UseVisualStyleBackColor = true;
            this.btnBrowseTextFile.Click += new System.EventHandler(this.btnBrowseTextFile_Click);
            // 
            // rTxtResult
            // 
            this.rTxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtResult.Location = new System.Drawing.Point(3, 3);
            this.rTxtResult.Name = "rTxtResult";
            this.rTxtResult.Size = new System.Drawing.Size(566, 354);
            this.rTxtResult.TabIndex = 2;
            this.rTxtResult.Text = "";
            // 
            // txtTextFilePath
            // 
            this.txtTextFilePath.Location = new System.Drawing.Point(33, 42);
            this.txtTextFilePath.Name = "txtTextFilePath";
            this.txtTextFilePath.Size = new System.Drawing.Size(395, 21);
            this.txtTextFilePath.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(240, 316);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 34);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(362, 316);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(93, 34);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePreference);
            this.tabControl1.Controls.Add(this.tabPageDetails);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 386);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPagePreference
            // 
            this.tabPagePreference.Controls.Add(this.groupBox3);
            this.tabPagePreference.Controls.Add(this.groupBox2);
            this.tabPagePreference.Controls.Add(this.groupBox1);
            this.tabPagePreference.Controls.Add(this.btnNextPage);
            this.tabPagePreference.Controls.Add(this.btnExport);
            this.tabPagePreference.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreference.Name = "tabPagePreference";
            this.tabPagePreference.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreference.Size = new System.Drawing.Size(572, 360);
            this.tabPagePreference.TabIndex = 0;
            this.tabPagePreference.Text = "Preferences";
            this.tabPagePreference.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeselectAll);
            this.groupBox3.Controls.Add(this.btnConvert);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.mTxtTimeStamp);
            this.groupBox3.Controls.Add(this.rBtnEndTime);
            this.groupBox3.Controls.Add(this.rBtnStartTime);
            this.groupBox3.Location = new System.Drawing.Point(15, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 102);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export Timestamp";
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(16, 65);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(93, 23);
            this.btnDeselectAll.TabIndex = 6;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(445, 65);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Stamp";
            // 
            // mTxtTimeStamp
            // 
            this.mTxtTimeStamp.Location = new System.Drawing.Point(295, 67);
            this.mTxtTimeStamp.Mask = "99999999999";
            this.mTxtTimeStamp.Name = "mTxtTimeStamp";
            this.mTxtTimeStamp.Size = new System.Drawing.Size(133, 21);
            this.mTxtTimeStamp.TabIndex = 2;
            this.mTxtTimeStamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rBtnEndTime
            // 
            this.rBtnEndTime.AutoSize = true;
            this.rBtnEndTime.Location = new System.Drawing.Point(16, 42);
            this.rBtnEndTime.Name = "rBtnEndTime";
            this.rBtnEndTime.Size = new System.Drawing.Size(203, 16);
            this.rBtnEndTime.TabIndex = 1;
            this.rBtnEndTime.TabStop = true;
            this.rBtnEndTime.Text = "End to the specified timestamp";
            this.rBtnEndTime.UseVisualStyleBackColor = true;
            // 
            // rBtnStartTime
            // 
            this.rBtnStartTime.AutoSize = true;
            this.rBtnStartTime.Location = new System.Drawing.Point(16, 20);
            this.rBtnStartTime.Name = "rBtnStartTime";
            this.rBtnStartTime.Size = new System.Drawing.Size(227, 16);
            this.rBtnStartTime.TabIndex = 0;
            this.rBtnStartTime.TabStop = true;
            this.rBtnStartTime.Text = "Start from the specified timestamp";
            this.rBtnStartTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxExportText);
            this.groupBox2.Controls.Add(this.txtTextFilePath);
            this.groupBox2.Controls.Add(this.btnBrowseTextFile);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For Text";
            // 
            // cBoxExportText
            // 
            this.cBoxExportText.AutoSize = true;
            this.cBoxExportText.Location = new System.Drawing.Point(16, 20);
            this.cBoxExportText.Name = "cBoxExportText";
            this.cBoxExportText.Size = new System.Drawing.Size(108, 16);
            this.cBoxExportText.TabIndex = 9;
            this.cBoxExportText.Text = "Export Text To";
            this.cBoxExportText.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseImageFile);
            this.groupBox1.Controls.Add(this.cBoxExportImage);
            this.groupBox1.Controls.Add(this.txtImageFilePath);
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Image";
            // 
            // btnBrowseImageFile
            // 
            this.btnBrowseImageFile.Location = new System.Drawing.Point(445, 40);
            this.btnBrowseImageFile.Name = "btnBrowseImageFile";
            this.btnBrowseImageFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImageFile.TabIndex = 7;
            this.btnBrowseImageFile.Text = "Browse...";
            this.btnBrowseImageFile.UseVisualStyleBackColor = true;
            this.btnBrowseImageFile.Click += new System.EventHandler(this.btnBrowseImageFile_Click);
            // 
            // cBoxExportImage
            // 
            this.cBoxExportImage.AutoSize = true;
            this.cBoxExportImage.Location = new System.Drawing.Point(16, 20);
            this.cBoxExportImage.Name = "cBoxExportImage";
            this.cBoxExportImage.Size = new System.Drawing.Size(114, 16);
            this.cBoxExportImage.TabIndex = 0;
            this.cBoxExportImage.Text = "Export Image To";
            this.cBoxExportImage.UseVisualStyleBackColor = true;
            // 
            // txtImageFilePath
            // 
            this.txtImageFilePath.Location = new System.Drawing.Point(33, 42);
            this.txtImageFilePath.Name = "txtImageFilePath";
            this.txtImageFilePath.Size = new System.Drawing.Size(395, 21);
            this.txtImageFilePath.TabIndex = 8;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.cBoxDetailedLog);
            this.tabPageDetails.Controls.Add(this.BtnCancel);
            this.tabPageDetails.Controls.Add(this.rTxtResult);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(572, 360);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Details";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(451, 285);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(74, 30);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cBoxDetailedLog
            // 
            this.cBoxDetailedLog.AutoSize = true;
            this.cBoxDetailedLog.Location = new System.Drawing.Point(363, 321);
            this.cBoxDetailedLog.Name = "cBoxDetailedLog";
            this.cBoxDetailedLog.Size = new System.Drawing.Size(162, 16);
            this.cBoxDetailedLog.TabIndex = 4;
            this.cBoxDetailedLog.Text = "Enable the detailed log";
            this.cBoxDetailedLog.UseVisualStyleBackColor = true;
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 414);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Weibo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExport_FormClosing);
            this.Load += new System.EventHandler(this.FrmExport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePreference.ResumeLayout(false);
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
    }
}