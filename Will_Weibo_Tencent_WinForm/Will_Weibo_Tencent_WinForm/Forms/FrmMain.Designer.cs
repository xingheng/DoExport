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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            // 
            // btnRequest
            // 
            resources.ApplyResources(this.btnRequest, "btnRequest");
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPageListView);
            this.tabControl1.Controls.Add(this.tabPageDataSource);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPageListView
            // 
            resources.ApplyResources(this.tabPageListView, "tabPageListView");
            this.tabPageListView.Controls.Add(this.listView);
            this.tabPageListView.Name = "tabPageListView";
            this.tabPageListView.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            resources.ApplyResources(this.listView, "listView");
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tabPageDataSource
            // 
            resources.ApplyResources(this.tabPageDataSource, "tabPageDataSource");
            this.tabPageDataSource.Controls.Add(this.btnGenerateImage);
            this.tabPageDataSource.Controls.Add(this.btnDownloadInThread);
            this.tabPageDataSource.Controls.Add(this.btnDownloadImage);
            this.tabPageDataSource.Controls.Add(this.lblImagePreview);
            this.tabPageDataSource.Name = "tabPageDataSource";
            this.tabPageDataSource.UseVisualStyleBackColor = true;
            // 
            // btnGenerateImage
            // 
            resources.ApplyResources(this.btnGenerateImage, "btnGenerateImage");
            this.btnGenerateImage.Name = "btnGenerateImage";
            this.btnGenerateImage.UseVisualStyleBackColor = true;
            this.btnGenerateImage.Click += new System.EventHandler(this.btnGenerateImage_Click);
            // 
            // btnDownloadInThread
            // 
            resources.ApplyResources(this.btnDownloadInThread, "btnDownloadInThread");
            this.btnDownloadInThread.Name = "btnDownloadInThread";
            this.btnDownloadInThread.UseVisualStyleBackColor = true;
            this.btnDownloadInThread.Click += new System.EventHandler(this.btnDownloadInThread_Click);
            // 
            // btnDownloadImage
            // 
            resources.ApplyResources(this.btnDownloadImage, "btnDownloadImage");
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // lblImagePreview
            // 
            resources.ApplyResources(this.lblImagePreview, "lblImagePreview");
            this.lblImagePreview.Name = "lblImagePreview";
            // 
            // btnWeiboList
            // 
            resources.ApplyResources(this.btnWeiboList, "btnWeiboList");
            this.btnWeiboList.Name = "btnWeiboList";
            this.btnWeiboList.UseVisualStyleBackColor = true;
            this.btnWeiboList.Click += new System.EventHandler(this.btnWeiboList_Click);
            // 
            // btnFrmExport
            // 
            resources.ApplyResources(this.btnFrmExport, "btnFrmExport");
            this.btnFrmExport.Name = "btnFrmExport";
            this.btnFrmExport.UseVisualStyleBackColor = true;
            this.btnFrmExport.Click += new System.EventHandler(this.btnFrmExport_Click);
            // 
            // comboBoxCondition
            // 
            resources.ApplyResources(this.comboBoxCondition, "comboBoxCondition");
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Name = "comboBoxCondition";
            // 
            // btnSettingForRequest
            // 
            resources.ApplyResources(this.btnSettingForRequest, "btnSettingForRequest");
            this.btnSettingForRequest.Name = "btnSettingForRequest";
            this.btnSettingForRequest.UseVisualStyleBackColor = true;
            this.btnSettingForRequest.Click += new System.EventHandler(this.btnSettingForRequest_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettingForRequest);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.btnFrmExport);
            this.Controls.Add(this.btnWeiboList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.txtResult);
            this.Name = "FrmMain";
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

