using System;
using System.Windows.Forms;

namespace Will_Weibo_Tencent
{
    public enum LoginEntryOption
    {
        None                = 0x0001,
        CommonUserEntry     = None << 1,
        DeveloperEntry      = CommonUserEntry << 1,
        AnyEntry                = CommonUserEntry | DeveloperEntry     // We just want to verify the user really did one.
    };

    public partial class FrmEntry : Form
    {
        public LoginEntryOption entryOption;

        public FrmEntry()
        {
            InitializeComponent();
        }

        private void FrmEntry_Load(object sender, EventArgs e)
        {
            entryOption = LoginEntryOption.None;

            this.Text = SharedMem.AppName + " - Welcome!";
            lblDescrption.Text = "Welcome, users! \r\n\r\n";
            lblDescrption.Text += "\"" + SharedMem.AppName + "\" " + "is aiming to finish all kinds of werid tasks. " +
                "Currently, it could export all the weibo data records to local file, the default exported file type is xml file" +
                " that you could view it using your browser. (We will support image file for it later. Hooray!)" +
                "\r\n\r\n"
                ;
            lblDescrption.Text += "More interesting features come soon, mail to me (xinghenghan@163.com) if you have any crazy ideas/suggestions/feedbacks.";
        }

        private void Dismiss()
        {
            this.Close();
        }

        private void btnCommonUserEntry_Click(object sender, EventArgs e)
        {
            entryOption = LoginEntryOption.CommonUserEntry;
            Dismiss();
        }

        private void llblDevEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            entryOption = LoginEntryOption.DeveloperEntry;
            Dismiss();
        }
    }
}
