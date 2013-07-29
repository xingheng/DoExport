namespace Will_Weibo_Tencent
{
    partial class FrmMain
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListView = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.tabPageDataSource = new System.Windows.Forms.TabPage();
            this.btnGenerateImage = new System.Windows.Forms.Button();
            this.btnDownloadInThread = new System.Windows.Forms.Button();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.btnWeiboList = new System.Windows.Forms.Button();
            this.btnFrmExport = new System.Windows.Forms.Button();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.btnSettingForRequest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageListView.SuspendLayout();
            this.tabPageDataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(23, 120);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(401, 364);
            this.txtResult.TabIndex = 6;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(23, 66);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(91, 38);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "Test for Read";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageListView);
            this.tabControl1.Controls.Add(this.tabPageDataSource);
            this.tabControl1.Location = new System.Drawing.Point(446, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 468);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageListView
            // 
            this.tabPageListView.Controls.Add(this.listView);
            this.tabPageListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageListView.Name = "tabPageListView";
            this.tabPageListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListView.Size = new System.Drawing.Size(524, 442);
            this.tabPageListView.TabIndex = 3;
            this.tabPageListView.Text = "ListView";
            this.tabPageListView.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(518, 436);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tabPageDataSource
            // 
            this.tabPageDataSource.Controls.Add(this.btnGenerateImage);
            this.tabPageDataSource.Controls.Add(this.btnDownloadInThread);
            this.tabPageDataSource.Controls.Add(this.btnDownloadImage);
            this.tabPageDataSource.Controls.Add(this.lblImagePreview);
            this.tabPageDataSource.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataSource.Name = "tabPageDataSource";
            this.tabPageDataSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataSource.Size = new System.Drawing.Size(524, 442);
            this.tabPageDataSource.TabIndex = 2;
            this.tabPageDataSource.Text = "Image Preview";
            this.tabPageDataSource.UseVisualStyleBackColor = true;
            // 
            // btnGenerateImage
            // 
            this.btnGenerateImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateImage.Location = new System.Drawing.Point(366, 190);
            this.btnGenerateImage.Name = "btnGenerateImage";
            this.btnGenerateImage.Size = new System.Drawing.Size(121, 51);
            this.btnGenerateImage.TabIndex = 3;
            this.btnGenerateImage.Text = "Generate Image";
            this.btnGenerateImage.UseVisualStyleBackColor = true;
            this.btnGenerateImage.Click += new System.EventHandler(this.btnGenerateImage_Click);
            // 
            // btnDownloadInThread
            // 
            this.btnDownloadInThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadInThread.Location = new System.Drawing.Point(366, 90);
            this.btnDownloadInThread.Name = "btnDownloadInThread";
            this.btnDownloadInThread.Size = new System.Drawing.Size(121, 51);
            this.btnDownloadInThread.TabIndex = 2;
            this.btnDownloadInThread.Text = "Download Image in new thread";
            this.btnDownloadInThread.UseVisualStyleBackColor = true;
            this.btnDownloadInThread.Click += new System.EventHandler(this.btnDownloadInThread_Click);
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadImage.Location = new System.Drawing.Point(366, 18);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(121, 51);
            this.btnDownloadImage.TabIndex = 1;
            this.btnDownloadImage.Text = "Download Image";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagePreview.Location = new System.Drawing.Point(6, 8);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(512, 433);
            this.lblImagePreview.TabIndex = 0;
            this.lblImagePreview.Text = "image label";
            // 
            // btnWeiboList
            // 
            this.btnWeiboList.Location = new System.Drawing.Point(233, 66);
            this.btnWeiboList.Name = "btnWeiboList";
            this.btnWeiboList.Size = new System.Drawing.Size(92, 38);
            this.btnWeiboList.TabIndex = 11;
            this.btnWeiboList.Text = "FrmWeiboList";
            this.btnWeiboList.UseVisualStyleBackColor = true;
            this.btnWeiboList.Click += new System.EventHandler(this.btnWeiboList_Click);
            // 
            // btnFrmExport
            // 
            this.btnFrmExport.Location = new System.Drawing.Point(353, 66);
            this.btnFrmExport.Name = "btnFrmExport";
            this.btnFrmExport.Size = new System.Drawing.Size(71, 38);
            this.btnFrmExport.TabIndex = 13;
            this.btnFrmExport.Text = "FrmExport";
            this.btnFrmExport.UseVisualStyleBackColor = true;
            this.btnFrmExport.Click += new System.EventHandler(this.btnFrmExport_Click);
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Location = new System.Drawing.Point(23, 17);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(302, 20);
            this.comboBoxCondition.TabIndex = 14;
            // 
            // btnSettingForRequest
            // 
            this.btnSettingForRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettingForRequest.Location = new System.Drawing.Point(350, 17);
            this.btnSettingForRequest.Name = "btnSettingForRequest";
            this.btnSettingForRequest.Size = new System.Drawing.Size(74, 20);
            this.btnSettingForRequest.TabIndex = 15;
            this.btnSettingForRequest.Text = "Setting";
            this.btnSettingForRequest.UseVisualStyleBackColor = true;
            this.btnSettingForRequest.Click += new System.EventHandler(this.btnSettingForRequest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 497);
            this.Controls.Add(this.btnSettingForRequest);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.btnFrmExport);
            this.Controls.Add(this.btnWeiboList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.txtResult);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListView.ResumeLayout(false);
            this.tabPageDataSource.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDataSource;
        private System.Windows.Forms.TabPage tabPageListView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnWeiboList;
        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.Button btnDownloadInThread;
        private System.Windows.Forms.Button btnFrmExport;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Button btnSettingForRequest;
        private System.Windows.Forms.Button btnGenerateImage;
    }
}

