
#define LOCALIZED_DATA_FOR_DEBUG

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using UTILITIES_HAN;

namespace DoExport
{
    public partial class WeiboPanel : UserControl
    {
        private WeiboInfo g_weibo;

        public WeiboPanel(WeiboInfo info)
        {
            InitializeComponent();

            g_weibo = info;
            LoadInfo();
        }

        private void LoadInfo()
        {
            if (g_weibo != null)
            {
                SetUserPhoto(WeiboInfo.AppendImageSize(g_weibo.head,WeiboImageSize.TinySize));
                SetNickName(g_weibo.nick);
                SetWeiboContentText(g_weibo.origtext); // origtext or text ?? choose one later!

                SetSourceTip(g_weibo.from);
                SetPostTime(g_weibo.GetTime());
                SetLocationInfo(g_weibo.location);


                if (g_weibo.subWeibo != null)
                {
                    SetSubWeiboInfo(g_weibo.subWeibo);
                }
                else
                {
                    // Remove the controls about SubWeibo.
                    panelSubInfo.Controls.Remove(lblSubWeiboUserNick);
                    lblSubWeiboUserNick.Dispose();
                    panelSubInfo.Controls.Remove(rTxtSubWeiboContent);
                    rTxtSubWeiboContent.Dispose();
                }
            }

            // After all the values are set to control, then reset the location for all controls.
            UpdateLocationForCtrls();
        }

        private void UpdateLocationForCtrls()
        {
            int marginPixel = 5/*, bigMarginPixel = 10*/;

            // (1) Update the panelSubInfo's location first.
            panelSubInfo.Top = rTxtBoxWeiboText.Top + rTxtBoxWeiboText.Size.Height + marginPixel;

            // (2) Update the lblLocation's location, as we will take its location as a sight later.
            if (g_weibo.subWeibo != null)
                lblLocation.Top = rTxtSubWeiboContent.Top + rTxtSubWeiboContent.Height + marginPixel;
            else
                lblLocation.Top = marginPixel;

            picBoxWeiboImage.Top = picBoxWeiboVideo.Top = lblLocation.Top;

            bool fImage = (g_weibo.p_MediaFlag & WeiboMediaFlag.HasImageOnly) != 0;
            bool fVideo = (g_weibo.p_MediaFlag & WeiboMediaFlag.HasVideoOnly) != 0;

            if (!(fImage || fVideo))    // No image and video.
            {
                // (3) Location of lblSourceTip and lblTime.
                lblSourceTip.Top = lblTime.Top = lblLocation.Top + lblLocation.Height + marginPixel;
            }
            else
            {
                int bigTopMargin = picBoxWeiboImage.Top + picBoxWeiboImage.Height > lblLocation.Top + lblLocation.Height ?
                    picBoxWeiboImage.Top + picBoxWeiboImage.Height : lblLocation.Top + lblLocation.Height;
                lblSourceTip.Top = lblTime.Top = bigTopMargin + marginPixel;
            }

            // (4) Change the Size of panels.
            panelSubInfo.Height = lblSourceTip.Top + lblSourceTip.Height + marginPixel;
            panelAll.Height = panelSubInfo.Top + panelSubInfo.Height + marginPixel;
            this.Height = panelAll.Height;

            if (!fImage && fVideo)      // No image, but video.
            {
                // (5) Then move the video controls to the image's location.
                picBoxWeiboVideo.Location = picBoxWeiboImage.Location;
            }
        }

        /// <summary>
        /// Load media info.
        /// </summary>
        public /*async*/ void LoadInfoEx()
        {
            if (g_weibo != null)
            {
                bool fImage = (g_weibo.p_MediaFlag & WeiboMediaFlag.HasImageOnly) != 0;
                bool fVideo = (g_weibo.p_MediaFlag & WeiboMediaFlag.HasVideoOnly) != 0;

                if (fImage)
                {
                    string[] urls = g_weibo.GetImageURLs(WeiboImageSize.SmallSize);
                    SetWeiboImage((urls != null && urls.Length > 0) ? urls[0] : "");
                }
                else
                {
                    panelAll.Controls.Remove(picBoxWeiboImage);
                    picBoxWeiboImage.Dispose(); // This is crazy and dangerous!!!
                }
                if (fVideo)
                    SetWeiboVideo(String.IsNullOrEmpty(g_weibo.video) ? g_weibo.subWeibo.video : g_weibo.video);
                else
                {
                    panelAll.Controls.Remove(picBoxWeiboVideo);
                    picBoxWeiboVideo.Dispose();
                }
            }
        }

        private /*async*/ void WeiboPanel_Load(object sender, EventArgs e)
        {
            rTxtBoxWeiboText.BackColor = linkLblUserNick.BackColor;

            picBoxUserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxWeiboImage.SizeMode = PictureBoxSizeMode.Zoom;

            lblLocation.TextAlign = ContentAlignment.TopRight;
            lblTime.TextAlign = ContentAlignment.TopRight;
            lblSourceTip.TextAlign = ContentAlignment.TopLeft;

            panelAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelSubInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;

            rTxtBoxWeiboText.MouseDown += rTxtBoxWeiboText_MouseDown;
            rTxtSubWeiboContent.MouseDown += rTxtBoxWeiboText_MouseDown;

            contextMenuStrip1.Items.Add("Copy", null, contextMenuStrip1_Click);

            try
            {
                LoadInfoEx();
            }
            catch (Exception ex)
            {
                MsgResult.DebugMsgBox(ex.ToString());
            }
        }

        void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            //MsgResult.WriteLine("contextMenuStrip1_Click");
            AutoRichTextBox autoRtxt = contextMenuStrip1.Tag as AutoRichTextBox;
            if (autoRtxt != null)
            {
                // Select all the text, copy, deselect.
                autoRtxt.SelectAll();
                autoRtxt.Copy();
                autoRtxt.Select(0, 0);

                //MsgResult.WriteLine(autoRtxt.Text);
            }
            else
                MsgResult.WriteLine("contextMenuStrip1_Click: autoRtxt is null.",
                    " contextMenuStrip1.Tag:" + contextMenuStrip1.Tag.ToString(), 
                    " sender: " + sender.ToString(),
                    " (EventArgs)e: " + e.ToString());
        }

        private void SetUserPhoto(string imgURL)
        {
            if (!String.IsNullOrEmpty(imgURL))
                this.picBoxUserPhoto.ImageLocation = imgURL;
        }

        private void SetUserPhoto(Image img)
        {
            if (img != null)
                this.picBoxUserPhoto.Image = img;
        }

        private void SetNickName(string strNick)
        {
            if (!String.IsNullOrEmpty(strNick))
                linkLblUserNick.Text = strNick;
            else
                linkLblUserNick.Text = "NickName";
        }

        private void SetWeiboContentText(string content)
        {
            if (!String.IsNullOrEmpty(content))
            {
                rTxtBoxWeiboText.Text = content.Trim('\r','\n', ' '); // Tirm the whitespace in two sides here as we really dont wanna show that for users.
                    // keep pace with rTxtSubWeiboContent.Text in SetSubWeiboInfo(WeiboInfo info)
            }
            else /* This should NOT be happened when weibo.type == 1.*/
            {
#if !LOCALIZED_DATA_FOR_DEBUG
                rTxtBoxWeiboText.Text = "The content is nil.";
#else
                rTxtBoxWeiboText.Text = "(转发微博)";   // The content could be null in a repost item.
#endif
            }
        }

        /// <summary>
        /// Set the images to picBoxWeiboImage.
        /// Note: A weibo could be zero, one or more images in it, but we support only one here!
        /// </summary>
        /// <param name="imgs">Array to images</param>
        private void SetWeiboImage(string imgURL)
        {
            if (imgURL.StartsWith("http"))
            {
                picBoxWeiboImage.ImageLocation = imgURL;
            }
            else if (String.IsNullOrEmpty(imgURL))
            {
                MsgResult.WriteLine("Invalid image URL? ", imgURL);
            }
        }

        /// <summary>
        /// We just show an snipshot image for video to users.
        /// </summary>
        /// <param name="imgForVideo"></param>
        private void SetWeiboVideo(string videoURL)
        {
            if (!String.IsNullOrEmpty(videoURL))
            {
                picBoxWeiboVideo.ImageLocation = videoURL;
            }
        }

        private void SetSourceTip(string sourceTip)
        {
            if (!String.IsNullOrEmpty(sourceTip))
                lblSourceTip.Text = sourceTip;
            else /*The default source tip is "Tencent Weibo".*/
                lblSourceTip.Text = "Tencent Weibo";
        }

        private void SetPostTime(DateTime time)
        {
            if (time != null && time != DateTime.MinValue/* Invalid DateTime */)
            {
                lblTime.Text = time.ToShortDateString();
            }
        }

        private void SetPostTime(string strTime)
        {
            if (!String.IsNullOrEmpty(strTime))
            {
                lblTime.Text = strTime;
            }
        }

        private void SetLocationInfo(string location)
        {
            if (location != null)
                lblLocation.Text = location;
            else
                lblLocation.Text = "Unknown Location";
        }

        #region SubWeibo
        public void SetSubWeiboInfo(WeiboInfo info)
        {
            if (info != null)
            {
                lblSubWeiboUserNick.Text = info.nick;
                rTxtSubWeiboContent.Text = info.origtext.Trim('\r', '\n', ' ');
                if (String.IsNullOrEmpty(rTxtSubWeiboContent.Text))
                {
#if !LOCALIZED_DATA_FOR_DEBUG
                    rTxtSubWeiboContent.Text = "The original content has been deleted.";
#else
                    rTxtSubWeiboContent.Text = "原微博已被删除。";
#endif
                }
            }
            else
            {
                // TODO: Should we remove the SubWeibo info here?
            }
        }
        #endregion

        //private delegate void ShowWeiboImage_CallBack();

        //private async Task ShowImage()
        //{
        //    Image img = null;
        //    string imgURL = picBoxWeiboImage.Tag.ToString();
        //    if (imgURL.StartsWith("http://"))
        //    {
        //        ResponseStream rStream = await WebStreamService.GetStreamFromURL(imgURL);
        //        if (rStream != null)
        //        {
        //            Stream imgStream = rStream.GetStream();
        //            if (imgStream != null)
        //            {
        //                img = Image.FromStream(imgStream);
        //                imgStream.Close();
        //            }
        //            rStream.Close();
        //        }
        //    }
        //    else /*As we are doing test for this app, the default image is from local disk.*/
        //        img = Image.FromFile(imgURL);

        //    if (img != null)
        //    {
        //        picBoxWeiboImage.Image = img;

        //        //FrmPreviewImage frmImage = new FrmPreviewImage(img);
        //        //frmImage.Show();
        //    }
        //    else
        //        MsgResult.WriteLine("Get Image from [", imgURL, "] failed");
        //}

//        async void picBoxWeiboImage_DoubleClick(object sender, EventArgs e)
//        {
//#if NOT_THREAD_SAFE
//            Image img = null;
//            string imgURL = picBoxWeiboImage.Tag.ToString();
//            if (imgURL.StartsWith("http://"))
//            {
//                Stream resultStream = (await WebStreamService.GetStreamFromURL(imgURL)).GetStream();
//                if (resultStream != null)
//                {
//                    img = Image.FromStream(resultStream);
//                    resultStream.Close();
//                }
//            }
//            else /*As we are doing test for this app, the default image is from local disk.*/
//                img = Image.FromFile(imgURL);

//            picBoxWeiboImage.Image = img;

//            FrmPreviewImage frmImage = new FrmPreviewImage(img);
//            frmImage.Show();
//#else
//            //ShowWeiboImage_CallBack callback = new ShowWeiboImage_CallBack(ShowImage);

//            //Thread thr = new Thread(ShowImage);
//            //thr.Start();

//            await ShowImage();
//#endif
//        }
        
        //public async Task DownLoadImage()
        //{
        //    Image img = null;
        //    string imgURL = "http://t2.qpic.cn/mblogpic/75087d5b0b7a762986c2/2000"; 
        //                    //"../../Resources/Images/460.jpg";
        //                    //picBoxWeiboImage.Tag.ToString();
        //    if (imgURL.StartsWith("http://"))
        //    {
        //        Stream resultStream = (await WebStreamService.GetStreamFromURL(imgURL)).GetStream();
        //        if (resultStream != null)
        //        {
        //            img = Image.FromStream(resultStream);
        //            resultStream.Close();
        //        }
        //    }
        //    else /*As we are doing test for this app, the default image is from local disk.*/
        //        img = Image.FromFile(imgURL);

        //    if (img!= null)
        //        picBoxWeiboImage.Image = img;
        //}
        

        void rTxtBoxWeiboText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Tag = sender;     // Save the sender object and we will get it when TooStripItem clicked.
                contextMenuStrip1.Show(rTxtBoxWeiboText, e.X, e.Y);
            }
        }
    }
}
