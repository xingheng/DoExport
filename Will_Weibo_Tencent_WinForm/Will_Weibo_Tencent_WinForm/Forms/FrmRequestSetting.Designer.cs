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
            this.btnCheckName = new System.Windows.Forms.Button();
            this.gBoxTypeFilter1.SuspendLayout();
            this.gBoxContentFilter.SuspendLayout();
            this.gBoxTypeFilter2.SuspendLayout();
            this.gBoxOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(120, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkBox1Original
            // 
            this.checkBox1Original.AutoSize = true;
            this.checkBox1Original.Location = new System.Drawing.Point(105, 24);
            this.checkBox1Original.Name = "checkBox1Original";
            this.checkBox1Original.Size = new System.Drawing.Size(48, 16);
            this.checkBox1Original.TabIndex = 0;
            this.checkBox1Original.Text = "原创";
            this.checkBox1Original.UseVisualStyleBackColor = true;
            // 
            // checkBox1Repost
            // 
            this.checkBox1Repost.AutoSize = true;
            this.checkBox1Repost.Location = new System.Drawing.Point(172, 24);
            this.checkBox1Repost.Name = "checkBox1Repost";
            this.checkBox1Repost.Size = new System.Drawing.Size(48, 16);
            this.checkBox1Repost.TabIndex = 1;
            this.checkBox1Repost.Text = "转播";
            this.checkBox1Repost.UseVisualStyleBackColor = true;
            // 
            // checkBox1AllType
            // 
            this.checkBox1AllType.AutoSize = true;
            this.checkBox1AllType.Location = new System.Drawing.Point(14, 24);
            this.checkBox1AllType.Name = "checkBox1AllType";
            this.checkBox1AllType.Size = new System.Drawing.Size(72, 16);
            this.checkBox1AllType.TabIndex = 2;
            this.checkBox1AllType.Text = "所有类型";
            this.checkBox1AllType.UseVisualStyleBackColor = true;
            // 
            // gBoxTypeFilter1
            // 
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1AllType);
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1Repost);
            this.gBoxTypeFilter1.Controls.Add(this.checkBox1Original);
            this.gBoxTypeFilter1.Location = new System.Drawing.Point(12, 12);
            this.gBoxTypeFilter1.Name = "gBoxTypeFilter1";
            this.gBoxTypeFilter1.Size = new System.Drawing.Size(416, 56);
            this.gBoxTypeFilter1.TabIndex = 0;
            this.gBoxTypeFilter1.TabStop = false;
            this.gBoxTypeFilter1.Text = "Type Filter 1";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Location = new System.Drawing.Point(105, 17);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(48, 16);
            this.checkBoxText.TabIndex = 0;
            this.checkBoxText.Text = "文本";
            this.checkBoxText.UseVisualStyleBackColor = true;
            // 
            // checkBoxLink
            // 
            this.checkBoxLink.AutoSize = true;
            this.checkBoxLink.Location = new System.Drawing.Point(172, 17);
            this.checkBoxLink.Name = "checkBoxLink";
            this.checkBoxLink.Size = new System.Drawing.Size(48, 16);
            this.checkBoxLink.TabIndex = 4;
            this.checkBoxLink.Text = "链接";
            this.checkBoxLink.UseVisualStyleBackColor = true;
            // 
            // checkBoxImage
            // 
            this.checkBoxImage.AutoSize = true;
            this.checkBoxImage.Location = new System.Drawing.Point(233, 17);
            this.checkBoxImage.Name = "checkBoxImage";
            this.checkBoxImage.Size = new System.Drawing.Size(48, 16);
            this.checkBoxImage.TabIndex = 5;
            this.checkBoxImage.Text = "图片";
            this.checkBoxImage.UseVisualStyleBackColor = true;
            // 
            // checkBoxVideo
            // 
            this.checkBoxVideo.AutoSize = true;
            this.checkBoxVideo.Location = new System.Drawing.Point(287, 17);
            this.checkBoxVideo.Name = "checkBoxVideo";
            this.checkBoxVideo.Size = new System.Drawing.Size(48, 16);
            this.checkBoxVideo.TabIndex = 6;
            this.checkBoxVideo.Text = "视频";
            this.checkBoxVideo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudio
            // 
            this.checkBoxAudio.AutoSize = true;
            this.checkBoxAudio.Location = new System.Drawing.Point(350, 17);
            this.checkBoxAudio.Name = "checkBoxAudio";
            this.checkBoxAudio.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAudio.TabIndex = 7;
            this.checkBoxAudio.Text = "音频";
            this.checkBoxAudio.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllContents
            // 
            this.checkBoxAllContents.AutoSize = true;
            this.checkBoxAllContents.Location = new System.Drawing.Point(14, 17);
            this.checkBoxAllContents.Name = "checkBoxAllContents";
            this.checkBoxAllContents.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAllContents.TabIndex = 8;
            this.checkBoxAllContents.Text = "所有类型";
            this.checkBoxAllContents.UseVisualStyleBackColor = true;
            // 
            // gBoxContentFilter
            // 
            this.gBoxContentFilter.Controls.Add(this.checkBoxAllContents);
            this.gBoxContentFilter.Controls.Add(this.checkBoxAudio);
            this.gBoxContentFilter.Controls.Add(this.checkBoxVideo);
            this.gBoxContentFilter.Controls.Add(this.checkBoxImage);
            this.gBoxContentFilter.Controls.Add(this.checkBoxLink);
            this.gBoxContentFilter.Controls.Add(this.checkBoxText);
            this.gBoxContentFilter.Location = new System.Drawing.Point(12, 151);
            this.gBoxContentFilter.Name = "gBoxContentFilter";
            this.gBoxContentFilter.Size = new System.Drawing.Size(416, 51);
            this.gBoxContentFilter.TabIndex = 6;
            this.gBoxContentFilter.TabStop = false;
            this.gBoxContentFilter.Text = "Content Filter";
            // 
            // checkBox2Original
            // 
            this.checkBox2Original.AutoSize = true;
            this.checkBox2Original.Location = new System.Drawing.Point(105, 20);
            this.checkBox2Original.Name = "checkBox2Original";
            this.checkBox2Original.Size = new System.Drawing.Size(48, 16);
            this.checkBox2Original.TabIndex = 0;
            this.checkBox2Original.Text = "原创";
            this.checkBox2Original.UseVisualStyleBackColor = true;
            // 
            // checkBox2Repost
            // 
            this.checkBox2Repost.AutoSize = true;
            this.checkBox2Repost.Location = new System.Drawing.Point(172, 20);
            this.checkBox2Repost.Name = "checkBox2Repost";
            this.checkBox2Repost.Size = new System.Drawing.Size(48, 16);
            this.checkBox2Repost.TabIndex = 1;
            this.checkBox2Repost.Text = "转播";
            this.checkBox2Repost.UseVisualStyleBackColor = true;
            // 
            // checkBox2Reply
            // 
            this.checkBox2Reply.AutoSize = true;
            this.checkBox2Reply.Location = new System.Drawing.Point(233, 20);
            this.checkBox2Reply.Name = "checkBox2Reply";
            this.checkBox2Reply.Size = new System.Drawing.Size(48, 16);
            this.checkBox2Reply.TabIndex = 2;
            this.checkBox2Reply.Text = "回复";
            this.checkBox2Reply.UseVisualStyleBackColor = true;
            // 
            // checkBox2Mention
            // 
            this.checkBox2Mention.AutoSize = true;
            this.checkBox2Mention.Location = new System.Drawing.Point(14, 42);
            this.checkBox2Mention.Name = "checkBox2Mention";
            this.checkBox2Mention.Size = new System.Drawing.Size(48, 16);
            this.checkBox2Mention.TabIndex = 3;
            this.checkBox2Mention.Text = "提及";
            this.checkBox2Mention.UseVisualStyleBackColor = true;
            // 
            // checkBox2ReplyNull
            // 
            this.checkBox2ReplyNull.AutoSize = true;
            this.checkBox2ReplyNull.Location = new System.Drawing.Point(287, 20);
            this.checkBox2ReplyNull.Name = "checkBox2ReplyNull";
            this.checkBox2ReplyNull.Size = new System.Drawing.Size(60, 16);
            this.checkBox2ReplyNull.TabIndex = 4;
            this.checkBox2ReplyNull.Text = "空回复";
            this.checkBox2ReplyNull.UseVisualStyleBackColor = true;
            // 
            // checkBox2Comment
            // 
            this.checkBox2Comment.AutoSize = true;
            this.checkBox2Comment.Location = new System.Drawing.Point(105, 42);
            this.checkBox2Comment.Name = "checkBox2Comment";
            this.checkBox2Comment.Size = new System.Drawing.Size(48, 16);
            this.checkBox2Comment.TabIndex = 5;
            this.checkBox2Comment.Text = "评论";
            this.checkBox2Comment.UseVisualStyleBackColor = true;
            // 
            // checkBox2AllType
            // 
            this.checkBox2AllType.AutoSize = true;
            this.checkBox2AllType.Location = new System.Drawing.Point(14, 20);
            this.checkBox2AllType.Name = "checkBox2AllType";
            this.checkBox2AllType.Size = new System.Drawing.Size(72, 16);
            this.checkBox2AllType.TabIndex = 6;
            this.checkBox2AllType.Text = "所有类型";
            this.checkBox2AllType.UseVisualStyleBackColor = true;
            // 
            // gBoxTypeFilter2
            // 
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2AllType);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Comment);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2ReplyNull);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Mention);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Reply);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Repost);
            this.gBoxTypeFilter2.Controls.Add(this.checkBox2Original);
            this.gBoxTypeFilter2.Location = new System.Drawing.Point(12, 74);
            this.gBoxTypeFilter2.Name = "gBoxTypeFilter2";
            this.gBoxTypeFilter2.Size = new System.Drawing.Size(416, 71);
            this.gBoxTypeFilter2.TabIndex = 1;
            this.gBoxTypeFilter2.TabStop = false;
            this.gBoxTypeFilter2.Text = "Type Filter 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Request Length";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(108, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(177, 21);
            this.txtUserName.TabIndex = 9;
            // 
            // mTxtRequestLen
            // 
            this.mTxtRequestLen.Location = new System.Drawing.Point(108, 22);
            this.mTxtRequestLen.Mask = "000";
            this.mTxtRequestLen.Name = "mTxtRequestLen";
            this.mTxtRequestLen.Size = new System.Drawing.Size(61, 21);
            this.mTxtRequestLen.TabIndex = 10;
            this.mTxtRequestLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtRequestLen.Validated += new System.EventHandler(this.mTxtRequestLen_Validated);
            // 
            // gBoxOthers
            // 
            this.gBoxOthers.Controls.Add(this.btnCheckName);
            this.gBoxOthers.Controls.Add(this.mTxtRequestLen);
            this.gBoxOthers.Controls.Add(this.txtUserName);
            this.gBoxOthers.Controls.Add(this.label1);
            this.gBoxOthers.Controls.Add(this.label2);
            this.gBoxOthers.Location = new System.Drawing.Point(12, 208);
            this.gBoxOthers.Name = "gBoxOthers";
            this.gBoxOthers.Size = new System.Drawing.Size(416, 87);
            this.gBoxOthers.TabIndex = 11;
            this.gBoxOthers.TabStop = false;
            this.gBoxOthers.Text = "Others";
            // 
            // btnCheckName
            // 
            this.btnCheckName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckName.Location = new System.Drawing.Point(301, 54);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(75, 23);
            this.btnCheckName.TabIndex = 11;
            this.btnCheckName.Text = "Check Name";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // FrmRequestSetting
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(441, 354);
            this.Controls.Add(this.gBoxOthers);
            this.Controls.Add(this.gBoxTypeFilter2);
            this.Controls.Add(this.gBoxContentFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBoxTypeFilter1);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "FrmRequestSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRequestSetting";
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
        private System.Windows.Forms.Button btnCheckName;

    }
}