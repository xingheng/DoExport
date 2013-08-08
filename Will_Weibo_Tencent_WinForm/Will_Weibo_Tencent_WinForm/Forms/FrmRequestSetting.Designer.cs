namespace Will_Weibo_Tencent
{
    partial class FrmRequestSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestSetting));
            this.btnOK = new System.Windows.Forms.Button();
            this.checkBox1Original = new System.Windows.Forms.CheckBox();
            this.checkBox1Repost = new System.Windows.Forms.CheckBox();
            this.checkBox1AllType = new System.Windows.Forms.CheckBox();
            this.gBoxTypeFilter1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.checkBoxLink = new System.Windows.Forms.CheckBox();
            this.checkBoxImage = new System.Windows.Forms.CheckBox();
            this.checkBoxVideo = new System.Windows.Forms.CheckBox();
            this.checkBoxAudio = new System.Windows.Forms.CheckBox();
            this.checkBoxAllContents = new System.Windows.Forms.CheckBox();
            this.gBoxContentFilter = new System.Windows.Forms.GroupBox();
            this.checkBox2Original = new System.Windows.Forms.CheckBox();
            this.checkBox2Repost = new System.Windows.Forms.CheckBox();
            this.checkBox2Reply = new System.Windows.Forms.CheckBox();
            this.checkBox2Mention = new System.Windows.Forms.CheckBox();
            this.checkBox2ReplyNull = new System.Windows.Forms.CheckBox();
            this.checkBox2Comment = new System.Windows.Forms.CheckBox();
            this.checkBox2AllType = new System.Windows.Forms.CheckBox();
            this.gBoxTypeFilter2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.mTxtRequestLen = new System.Windows.Forms.MaskedTextBox();
            this.gBoxOthers = new System.Windows.Forms.GroupBox();
            this.btnCheckChannelName = new System.Windows.Forms.Button();
            this.cBoxChannelName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckUserName = new System.Windows.Forms.Button();
            this.gBoxTypeFilter1.SuspendLayout();
            this.gBoxContentFilter.SuspendLayout();
            this.gBoxTypeFilter2.SuspendLayout();
            this.gBoxOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkBox1Original
            // 
            resources.ApplyResources(this.checkBox1Original, "checkBox1Original");
            this.checkBox1Original.Name = "checkBox1Original";
            this.checkBox1Original.UseVisualStyleBackColor = true;
            // 
            // checkBox1Repost
            // 
            resources.ApplyResources(this.checkBox1Repost, "checkBox1Repost");
            this.checkBox1Repost.Name = "checkBox1Repost";
            this.checkBox1Repost.UseVisualStyleBackColor = true;
            // 
            // checkBox1AllType
            // 
            resources.ApplyResources(this.checkBox1AllType, "checkBox1AllType");
            this.checkBox1AllType.Name = "checkBox1AllType";
            this.checkBox1AllType.UseVisualStyleBackColor = true;
            // 
            // gBoxTypeFilter1
            // 
            resources.ApplyResources(this.gBoxTypeFilter1, "gBoxTypeFilter1");
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1AllType);
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1Repost);
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1Original);
            this.gBoxTypeFilter1.Name = "gBoxTypeFilter1";
            this.gBoxTypeFilter1.TabStop = false;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxText
            // 
            resources.ApplyResources(this.checkBoxText, "checkBoxText");
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.UseVisualStyleBackColor = true;
            // 
            // checkBoxLink
            // 
            resources.ApplyResources(this.checkBoxLink, "checkBoxLink");
            this.checkBoxLink.Name = "checkBoxLink";
            this.checkBoxLink.UseVisualStyleBackColor = true;
            // 
            // checkBoxImage
            // 
            resources.ApplyResources(this.checkBoxImage, "checkBoxImage");
            this.checkBoxImage.Name = "checkBoxImage";
            this.checkBoxImage.UseVisualStyleBackColor = true;
            // 
            // checkBoxVideo
            // 
            resources.ApplyResources(this.checkBoxVideo, "checkBoxVideo");
            this.checkBoxVideo.Name = "checkBoxVideo";
            this.checkBoxVideo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudio
            // 
            resources.ApplyResources(this.checkBoxAudio, "checkBoxAudio");
            this.checkBoxAudio.Name = "checkBoxAudio";
            this.checkBoxAudio.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllContents
            // 
            resources.ApplyResources(this.checkBoxAllContents, "checkBoxAllContents");
            this.checkBoxAllContents.Name = "checkBoxAllContents";
            this.checkBoxAllContents.UseVisualStyleBackColor = true;
            // 
            // gBoxContentFilter
            // 
            resources.ApplyResources(this.gBoxContentFilter, "gBoxContentFilter");
            this.gBoxContentFilter.Controls.Add(this.checkBoxAllContents);
            this.gBoxContentFilter.Controls.Add(this.checkBoxAudio);
            this.gBoxContentFilter.Controls.Add(this.checkBoxVideo);
            this.gBoxContentFilter.Controls.Add(this.checkBoxImage);
            this.gBoxContentFilter.Controls.Add(this.checkBoxLink);
            this.gBoxContentFilter.Controls.Add(this.checkBoxText);
            this.gBoxContentFilter.Name = "gBoxContentFilter";
            this.gBoxContentFilter.TabStop = false;
            // 
            // checkBox2Original
            // 
            resources.ApplyResources(this.checkBox2Original, "checkBox2Original");
            this.checkBox2Original.Name = "checkBox2Original";
            this.checkBox2Original.UseVisualStyleBackColor = true;
            // 
            // checkBox2Repost
            // 
            resources.ApplyResources(this.checkBox2Repost, "checkBox2Repost");
            this.checkBox2Repost.Name = "checkBox2Repost";
            this.checkBox2Repost.UseVisualStyleBackColor = true;
            // 
            // checkBox2Reply
            // 
            resources.ApplyResources(this.checkBox2Reply, "checkBox2Reply");
            this.checkBox2Reply.Name = "checkBox2Reply";
            this.checkBox2Reply.UseVisualStyleBackColor = true;
            // 
            // checkBox2Mention
            // 
            resources.ApplyResources(this.checkBox2Mention, "checkBox2Mention");
            this.checkBox2Mention.Name = "checkBox2Mention";
            this.checkBox2Mention.UseVisualStyleBackColor = true;
            // 
            // checkBox2ReplyNull
            // 
            resources.ApplyResources(this.checkBox2ReplyNull, "checkBox2ReplyNull");
            this.checkBox2ReplyNull.Name = "checkBox2ReplyNull";
            this.checkBox2ReplyNull.UseVisualStyleBackColor = true;
            // 
            // checkBox2Comment
            // 
            resources.ApplyResources(this.checkBox2Comment, "checkBox2Comment");
            this.checkBox2Comment.Name = "checkBox2Comment";
            this.checkBox2Comment.UseVisualStyleBackColor = true;
            // 
            // checkBox2AllType
            // 
            resources.ApplyResources(this.checkBox2AllType, "checkBox2AllType");
            this.checkBox2AllType.Name = "checkBox2AllType";
            this.checkBox2AllType.UseVisualStyleBackColor = true;
            // 
            // gBoxTypeFilter2
            // 
            resources.ApplyResources(this.gBoxTypeFilter2, "gBoxTypeFilter2");
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2AllType);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Comment);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2ReplyNull);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Mention);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Reply);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Repost);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Original);
            this.gBoxTypeFilter2.Name = "gBoxTypeFilter2";
            this.gBoxTypeFilter2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // mTxtRequestLen
            // 
            resources.ApplyResources(this.mTxtRequestLen, "mTxtRequestLen");
            this.mTxtRequestLen.Name = "mTxtRequestLen";
            this.mTxtRequestLen.Validated += new System.EventHandler(this.mTxtRequestLen_Validated);
            // 
            // gBoxOthers
            // 
            resources.ApplyResources(this.gBoxOthers, "gBoxOthers");
            this.gBoxOthers.Controls.Add(this.btnCheckChannelName);
            this.gBoxOthers.Controls.Add(this.cBoxChannelName);
            this.gBoxOthers.Controls.Add(this.label3);
            this.gBoxOthers.Controls.Add(this.btnCheckUserName);
            this.gBoxOthers.Controls.Add(this.mTxtRequestLen);
            this.gBoxOthers.Controls.Add(this.txtUserName);
            this.gBoxOthers.Controls.Add(this.label1);
            this.gBoxOthers.Controls.Add(this.label2);
            this.gBoxOthers.Name = "gBoxOthers";
            this.gBoxOthers.TabStop = false;
            // 
            // btnCheckChannelName
            // 
            resources.ApplyResources(this.btnCheckChannelName, "btnCheckChannelName");
            this.btnCheckChannelName.Name = "btnCheckChannelName";
            this.btnCheckChannelName.UseVisualStyleBackColor = true;
            this.btnCheckChannelName.Click += new System.EventHandler(this.btnCheckChannelName_Click);
            // 
            // cBoxChannelName
            // 
            resources.ApplyResources(this.cBoxChannelName, "cBoxChannelName");
            this.cBoxChannelName.FormattingEnabled = true;
            this.cBoxChannelName.Name = "cBoxChannelName";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnCheckUserName
            // 
            resources.ApplyResources(this.btnCheckUserName, "btnCheckUserName");
            this.btnCheckUserName.Name = "btnCheckUserName";
            this.btnCheckUserName.UseVisualStyleBackColor = true;
            this.btnCheckUserName.Click += new System.EventHandler(this.btnCheckUserName_Click);
            // 
            // FrmRequestSetting
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.gBoxOthers);
            this.Controls.Add(this.gBoxTypeFilter2);
            this.Controls.Add(this.gBoxContentFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBoxTypeFilter1);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "FrmRequestSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRequestSetting_FormClosing);
            this.Load += new System.EventHandler(this.FrmRequestSetting_Load);
            this.gBoxTypeFilter1.ResumeLayout(false);
            this.gBoxTypeFilter1.PerformLayout();
            this.gBoxContentFilter.ResumeLayout(false);
            this.gBoxContentFilter.PerformLayout();
            this.gBoxTypeFilter2.ResumeLayout(false);
            this.gBoxTypeFilter2.PerformLayout();
            this.gBoxOthers.ResumeLayout(false);
            this.gBoxOthers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkBox1Original;
        private System.Windows.Forms.CheckBox checkBox1Repost;
        private System.Windows.Forms.CheckBox checkBox1AllType;
        private System.Windows.Forms.GroupBox gBoxTypeFilter1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.CheckBox checkBoxLink;
        private System.Windows.Forms.CheckBox checkBoxImage;
        private System.Windows.Forms.CheckBox checkBoxVideo;
        private System.Windows.Forms.CheckBox checkBoxAudio;
        private System.Windows.Forms.CheckBox checkBoxAllContents;
        private System.Windows.Forms.GroupBox gBoxContentFilter;
        private System.Windows.Forms.CheckBox checkBox2Original;
        private System.Windows.Forms.CheckBox checkBox2Repost;
        private System.Windows.Forms.CheckBox checkBox2Reply;
        private System.Windows.Forms.CheckBox checkBox2Mention;
        private System.Windows.Forms.CheckBox checkBox2ReplyNull;
        private System.Windows.Forms.CheckBox checkBox2Comment;
        private System.Windows.Forms.CheckBox checkBox2AllType;
        private System.Windows.Forms.GroupBox gBoxTypeFilter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox mTxtRequestLen;
        private System.Windows.Forms.GroupBox gBoxOthers;
        private System.Windows.Forms.Button btnCheckUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxChannelName;
        private System.Windows.Forms.Button btnCheckChannelName;

    }
}