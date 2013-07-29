using System;
using System.Windows.Forms;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    public partial class WeiboRequestSetting : UserControl
    {
        public WeiboRequestSetting()
        {
            InitializeComponent();
            InitForCtrls();
        }

        private void InitForCtrls()
        {
            //-----------------------------------------------------------------
            // Type Filter of checkbox list.
            // -----Group 1-----
            checkBox1AllType.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (checkBox1AllType.Checked)
                {
                    checkBox1Original.Checked = true;
                    checkBox1Repost.Checked = true;
                }
            };
            checkBox1Original.CheckedChanged += checkBoxWeiboType1_CheckedChanged;
            checkBox1Repost.CheckedChanged += checkBoxWeiboType1_CheckedChanged;

            checkBox1AllType.Checked = true;

            // -----Group 2-----
            checkBox2AllType.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (checkBox2AllType.Checked)
                {
                    checkBox2Original.Checked = true;
                    checkBox2Repost.Checked = true;
                    checkBox2Reply.Checked = true;
                    checkBox2ReplyNull.Checked = true;
                    checkBox2Mention.Checked = true;
                    checkBox2Comment.Checked = true;
                }
            };
            checkBox2Original.CheckedChanged += checkBoxWeiboType2_CheckedChanged;
            checkBox2Repost.CheckedChanged += checkBoxWeiboType2_CheckedChanged;
            checkBox2Reply.CheckedChanged += checkBoxWeiboType2_CheckedChanged;
            checkBox2ReplyNull.CheckedChanged += checkBoxWeiboType2_CheckedChanged;
            checkBox2Mention.CheckedChanged += checkBoxWeiboType2_CheckedChanged;
            checkBox2Comment.CheckedChanged += checkBoxWeiboType2_CheckedChanged;

            checkBox2AllType.Checked = true;
            //-----------------------------------------------------------------
            // Content Filter of checkbox list.
            checkBoxAllContents.CheckedChanged += delegate(object sender, EventArgs e)
            {
                if (checkBoxAllContents.Checked)
                {
                    checkBoxText.Checked = true;
                    checkBoxImage.Checked = true;
                    checkBoxLink.Checked = true;
                    checkBoxVideo.Checked = true;
                    checkBoxAudio.Checked = true;
                }
            };

            checkBoxText.CheckedChanged += checkBoxWeiboContent_CheckedChanged;
            checkBoxImage.CheckedChanged += checkBoxWeiboContent_CheckedChanged;
            checkBoxLink.CheckedChanged += checkBoxWeiboContent_CheckedChanged;
            checkBoxVideo.CheckedChanged += checkBoxWeiboContent_CheckedChanged;
            checkBoxAudio.CheckedChanged += checkBoxWeiboContent_CheckedChanged;

            checkBoxAllContents.Checked = true;
            //-----------------------------------------------------------------
            // Others
            mTxtRequestLen.Text = RequestArgs.requestLength.ToString();
            txtUserName.Text = RequestArgs.userName;

            this.Text = SharedMem.AppName + " - Setting";
            //-----------------------------------------------------------------
        }

        void checkBoxWeiboContent_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cBox = sender as CheckBox;
            if (cBox != null && !cBox.Checked)
            {
                checkBoxAllContents.Checked = false;
            }
        }

        void checkBoxWeiboType1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1Original.Checked ^ checkBox1Repost.Checked)
            //    checkBox1AllType.Checked = false;
            CheckBox cBox = sender as CheckBox;
            if (cBox != null && !cBox.Checked)
            {
                checkBox1AllType.Checked = false;
            }
        }

        void checkBoxWeiboType2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cBox = sender as CheckBox;
            if (cBox != null && !cBox.Checked)
            {
                checkBox2AllType.Checked = false;
            }
        }

        #region Members and Properties
        private int m_weibo_type;
        public int weibo_type
        {
            get { return m_weibo_type; }
        }

        private int m_content_type;
        public int content_type
        {
            get { return m_content_type; }
        }

        private int m_requestLength;
        public int requestLength
        {
            get { return m_requestLength; }
        }

        private string m_userName;
        public string UserName
        {
            get { return m_userName; }
        }
        #endregion

        private void FrmRequestSetting_Load(object sender, EventArgs e)
        {
        }

        public void SetGroupEnabled(string strFlag)
        {
            if (strFlag == RequestKind.MyPrivateWeibo)
                GroupBoxEnabled(true, false, true, true);
            else if (strFlag == RequestKind.MyHomePage)
                GroupBoxEnabled(true, false, true, true);
            else if (strFlag == RequestKind.MyFavouriteWeibo)
                GroupBoxEnabled(false, false, false, true);
            else if (strFlag == RequestKind.SpecifiedPersonWeibo)
                GroupBoxEnabled(false, true, true, true, true);
            else
                MsgResult.WriteLine("Invalid parameter. strFlag:", strFlag);
        }

        private void GroupBoxEnabled(bool b1, bool b2, bool b3, bool b4, bool b5 = false)
        {
            gBoxTypeFilter1.Enabled = b1;
            gBoxTypeFilter2.Enabled = b2;
            gBoxContentFilter.Enabled = b3;
            gBoxOthers.Enabled = b4;

            this.txtUserName.Enabled = b4 && b5;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------
            // Type Filter of checkbox list.
            if (gBoxTypeFilter1.Enabled && gBoxTypeFilter2.Enabled)
            {
                // This shouldn't be happened!
                MsgResult.DebugMsgBox("Which case should we need this? Please check the member of SetGroupEnabled.");
            }
            else if (gBoxTypeFilter1.Enabled)
            {
                // -----Group 1-----
                if (checkBox1AllType.Checked)
                    m_weibo_type = 0;
                else
                    m_weibo_type = checkBox1Original.Checked ?
                        (checkBox1Repost.Checked ? 3/* =(0x1 | 0x2)*/ : 1) : (checkBox1Repost.Checked ? 2 : 0);
            }
            else if (gBoxTypeFilter2.Enabled)
            {
                // -----Group 2-----
                if (checkBox2AllType.Checked)
                    m_weibo_type = 0;
                else
                {
                    m_weibo_type = 0;
                    if (checkBox2Original.Checked)
                        m_weibo_type |= 0x1;
                    if (checkBox2Repost.Checked)
                        m_weibo_type |= 0x2;
                    if (checkBox2Reply.Checked)
                        m_weibo_type |= 0x8;
                    if (checkBox2ReplyNull.Checked)
                        m_weibo_type |= 0x10;
                    if (checkBox2Mention.Checked)
                        m_weibo_type |= 0x20;
                    if (checkBox2Comment.Checked)
                        m_weibo_type |= 0x40;
                }
            }
            else
            {
                // If the both type filter groups are disabled, go back!
                m_weibo_type = 0;
            }
            //-----------------------------------------------------------------
            // Content Filter of checkbox list.
            if (gBoxContentFilter.Enabled)
            {
                if (checkBoxAllContents.Checked)
                    m_content_type = 0;
                else
                {
                    m_content_type = 0;
                    // -------------------SPECIFIC CASES-------------------
                    // Case 1,
                    if (checkBoxText.Checked && !checkBoxLink.Checked && !checkBoxImage.Checked &&
                        !checkBoxAudio.Checked && !checkBoxVideo.Checked)
                        m_content_type = 0x80;
                    else if (checkBoxText.Checked)
                        m_content_type = 0x10;
                    // Case 2,
                    if (checkBoxAudio.Checked)
                        m_content_type = 0x10;
                    // ----------------------------------------------------
                    if (checkBoxLink.Checked)
                        m_content_type |= 2;
                    if (checkBoxImage.Checked)
                        m_content_type |= 4;
                    if (checkBoxVideo.Checked)
                        m_content_type |= 8;
                }
            }
            else
            {
                m_content_type = 0;
            }
            //-----------------------------------------------------------------
            // Others
            if (gBoxOthers.Enabled)
            {
                this.m_requestLength = Convert.ToInt32(mTxtRequestLen.Text);
                this.m_userName = txtUserName.Text.ToString().Trim();
            }
            else
            {
                this.m_requestLength = 20;
                this.m_userName = "xingheng907"; // Hurray! My name must be default!
            }
            //-----------------------------------------------------------------

            Dismiss();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dismiss();
        }

        private void FrmRequestSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dismiss();
            e.Cancel = true;    // Then the corresponding event FormClosed will be cancelled.
        }

        void Dismiss()
        {
            this.Hide();
        }

        private void mTxtRequestLen_Validated(object sender, EventArgs e)
        {
            int maxLength = 100;    // 100 should be the MAX_VALUE refer to the documendation in wiki.open.t.qq.com.
            if (Convert.ToInt32(mTxtRequestLen.Text.Trim()) > maxLength)
                mTxtRequestLen.Text = maxLength.ToString();
        }
    }
}
