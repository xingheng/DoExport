
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    partial class WeiboPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelSubInfo = new System.Windows.Forms.Panel();
            this.rTxtSubWeiboContent = new UTILITIES_HAN.AutoRichTextBox();
            this.lblSubWeiboUserNick = new System.Windows.Forms.LinkLabel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSourceTip = new System.Windows.Forms.Label();
            this.picBoxWeiboImage = new System.Windows.Forms.PictureBox();
            this.picBoxWeiboVideo = new System.Windows.Forms.PictureBox();
            this.rTxtBoxWeiboText = new UTILITIES_HAN.AutoRichTextBox();
            this.linkLblUserNick = new System.Windows.Forms.LinkLabel();
            this.picBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAll.SuspendLayout();
            this.panelSubInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeiboImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeiboVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAll.Controls.Add(this.panelSubInfo);
            this.panelAll.Controls.Add(this.rTxtBoxWeiboText);
            this.panelAll.Controls.Add(this.linkLblUserNick);
            this.panelAll.Controls.Add(this.picBoxUserPhoto);
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(486, 229);
            this.panelAll.TabIndex = 1;
            // 
            // panelSubInfo
            // 
            this.panelSubInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubInfo.Controls.Add(this.rTxtSubWeiboContent);
            this.panelSubInfo.Controls.Add(this.lblSubWeiboUserNick);
            this.panelSubInfo.Controls.Add(this.lblTime);
            this.panelSubInfo.Controls.Add(this.lblLocation);
            this.panelSubInfo.Controls.Add(this.lblSourceTip);
            this.panelSubInfo.Controls.Add(this.picBoxWeiboImage);
            this.panelSubInfo.Controls.Add(this.picBoxWeiboVideo);
            this.panelSubInfo.Location = new System.Drawing.Point(46, 51);
            this.panelSubInfo.Name = "panelSubInfo";
            this.panelSubInfo.Size = new System.Drawing.Size(426, 173);
            this.panelSubInfo.TabIndex = 2;
            // 
            // rTxtSubWeiboContent
            // 
            this.rTxtSubWeiboContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtSubWeiboContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtSubWeiboContent.Location = new System.Drawing.Point(1, 20);
            this.rTxtSubWeiboContent.Name = "rTxtSubWeiboContent";
            this.rTxtSubWeiboContent.ReadOnly = true;
            this.rTxtSubWeiboContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTxtSubWeiboContent.Size = new System.Drawing.Size(421, 25);
            this.rTxtSubWeiboContent.TabIndex = 3;
            this.rTxtSubWeiboContent.Text = "Weibo Content Text....";
            // 
            // lblSubWeiboUserNick
            // 
            this.lblSubWeiboUserNick.AutoSize = true;
            this.lblSubWeiboUserNick.Location = new System.Drawing.Point(2, 2);
            this.lblSubWeiboUserNick.Name = "lblSubWeiboUserNick";
            this.lblSubWeiboUserNick.Size = new System.Drawing.Size(53, 12);
            this.lblSubWeiboUserNick.TabIndex = 3;
            this.lblSubWeiboUserNick.TabStop = true;
            this.lblSubWeiboUserNick.Text = "NickName";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Location = new System.Drawing.Point(350, 152);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 12);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "(Post Time)";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.Location = new System.Drawing.Point(326, 63);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(95, 12);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "(Post Location)";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSourceTip
            // 
            this.lblSourceTip.Location = new System.Drawing.Point(2, 152);
            this.lblSourceTip.Name = "lblSourceTip";
            this.lblSourceTip.Size = new System.Drawing.Size(123, 12);
            this.lblSourceTip.TabIndex = 5;
            this.lblSourceTip.Text = "Tencent Weibo";
            // 
            // picBoxWeiboImage
            // 
            this.picBoxWeiboImage.Location = new System.Drawing.Point(2, 63);
            this.picBoxWeiboImage.Name = "picBoxWeiboImage";
            this.picBoxWeiboImage.Size = new System.Drawing.Size(80, 80);
            this.picBoxWeiboImage.TabIndex = 3;
            this.picBoxWeiboImage.TabStop = false;
            // 
            // picBoxWeiboVideo
            // 
            this.picBoxWeiboVideo.Location = new System.Drawing.Point(88, 63);
            this.picBoxWeiboVideo.Name = "picBoxWeiboVideo";
            this.picBoxWeiboVideo.Size = new System.Drawing.Size(80, 80);
            this.picBoxWeiboVideo.TabIndex = 4;
            this.picBoxWeiboVideo.TabStop = false;
            // 
            // rTxtBoxWeiboText
            // 
            this.rTxtBoxWeiboText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtBoxWeiboText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxWeiboText.Location = new System.Drawing.Point(46, 24);
            this.rTxtBoxWeiboText.Name = "rTxtBoxWeiboText";
            this.rTxtBoxWeiboText.ReadOnly = true;
            this.rTxtBoxWeiboText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTxtBoxWeiboText.Size = new System.Drawing.Size(426, 25);
            this.rTxtBoxWeiboText.TabIndex = 2;
            this.rTxtBoxWeiboText.Text = "Weibo Content Text....";
            // 
            // linkLblUserNick
            // 
            this.linkLblUserNick.AutoSize = true;
            this.linkLblUserNick.Location = new System.Drawing.Point(44, 6);
            this.linkLblUserNick.Name = "linkLblUserNick";
            this.linkLblUserNick.Size = new System.Drawing.Size(53, 12);
            this.linkLblUserNick.TabIndex = 1;
            this.linkLblUserNick.TabStop = true;
            this.linkLblUserNick.Text = "NickName";
            // 
            // picBoxUserPhoto
            // 
            this.picBoxUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxUserPhoto.Image = global::Will_Weibo_Tencent.Properties.Resources.weiboicon32;
            this.picBoxUserPhoto.Location = new System.Drawing.Point(3, 3);
            this.picBoxUserPhoto.Name = "picBoxUserPhoto";
            this.picBoxUserPhoto.Size = new System.Drawing.Size(35, 35);
            this.picBoxUserPhoto.TabIndex = 0;
            this.picBoxUserPhoto.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WeiboPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelAll);
            this.Name = "WeiboPanel";
            this.Size = new System.Drawing.Size(489, 232);
            this.Load += new System.EventHandler(this.WeiboPanel_Load);
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.panelSubInfo.ResumeLayout(false);
            this.panelSubInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeiboImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeiboVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSourceTip;
        private System.Windows.Forms.PictureBox picBoxWeiboVideo;
        private System.Windows.Forms.PictureBox picBoxWeiboImage;
        private AutoRichTextBox rTxtBoxWeiboText;
        private System.Windows.Forms.LinkLabel linkLblUserNick;
        private System.Windows.Forms.PictureBox picBoxUserPhoto;
        private System.Windows.Forms.Panel panelSubInfo;
        private AutoRichTextBox rTxtSubWeiboContent;
        private System.Windows.Forms.LinkLabel lblSubWeiboUserNick;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}
