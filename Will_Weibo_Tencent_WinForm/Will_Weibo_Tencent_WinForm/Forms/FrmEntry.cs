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
        }

        protected override void LocalizationForRunTime()
        {
            string title = "", description = "";
            if (SharedMem.IsChineseSimpleCulture())
            {
                title = SharedMem.AppName + " - 欢迎";
                description = "你好, 用户! \r\n\r\n";
                description += "“" + SharedMem.AppName + "”" + "这个工具的目的在于实现各种古怪的功能。" +
                    "目前，它能够把用户指定类型的微博列表全部导出到本地（XML）文件，如果你想看的话，最直接的方式是用浏览器就可以打开了。" +
                    "(后期我们会让它支持把微博导出到图片等等格式，期待吧！)" +
                    "\r\n\r\n"
                    ;
                description += "更有意思的功能正在实现中, 如果你有什么够大胆/疯狂/古怪的想法，可以联系我 (xinghenghan@163.com)。";
            }
            else
            {
                title = SharedMem.AppName + " - Welcome!";
                description = "Welcome, users! \r\n\r\n";
                description += "\"" + SharedMem.AppName + "\" " + "is aiming to finish all kinds of werid tasks. " +
                    "Currently, it could export all the weibo data records to local file, the default exported file type is xml file" +
                    " that you could view it using your browser. (We will support image file for it later. Hooray!)" +
                    "\r\n\r\n"
                    ;
                description += "More interesting features come soon, mail to me (xinghenghan@163.com) if you have any crazy ideas/suggestions/feedbacks.";
            }

            this.Text = title;
            lblDescrption.Text = description;
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
