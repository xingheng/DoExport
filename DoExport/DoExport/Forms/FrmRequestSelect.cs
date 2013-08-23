using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILITIES_HAN;
using System.IO;

namespace DoExport
{
    public partial class FrmRequestSelect : Form
    {
        public TimelineKind m_requestKind;

        public FrmRequestSelect()
        {
            InitializeComponent();
        }

        protected override void LocalizationForRunTime()
        {
            string title = "";
            if (SharedMem.IsChineseSimpleCulture())
                title = SharedMem.AppName + " - 选择和配置";
            else
                title = SharedMem.AppName + " - Select & Config";
            this.Text = title;
        }

        private void FrmReadRequest_Load(object sender, EventArgs e)
        {
            comboBoxCondition.Items.Add(RequestKind.MyPrivateWeibo);
            comboBoxCondition.Items.Add(RequestKind.MyHomePage);
            comboBoxCondition.Items.Add(RequestKind.MyFavouriteWeibo);
            comboBoxCondition.Items.Add(RequestKind.SpecifiedPersonWeibo);
            comboBoxCondition.Items.Add(RequestKind.TypeChannel);

            comboBoxCondition.SelectedIndexChanged += delegate(object senderA, EventArgs eventA)
            {
                string selectedText = (senderA as ComboBox).SelectedItem.ToString();
                m_requestKind = RequestArgs.ConvertRequestKindString2TimeLineKind(selectedText);
            };
            comboBoxCondition.SelectedIndex = 0;

            cBoxImportFileKind.Items.Clear();
            cBoxImportFileKind.Items.Insert(0, "Database File (sqlite3)");
            cBoxImportFileKind.Items.Insert(1, "XML/HTML File");
            cBoxImportFileKind.SelectedIndex = 0;
        }

        private void btnGoExport_Click(object sender, EventArgs e)
        {
            FrmExport export = new FrmExport(m_requestKind);
            export.ShowDialog();
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            WeiboInfo[]  weiboList = await SendRequest();
            if (weiboList != null && weiboList.Length > 0)
            {
                FrmWeiboList frmList = new FrmWeiboList(weiboList);
                frmList.Show();
            }
        }

        private async Task<WeiboInfo[]> SendRequest()
        {
            WeiboErrorCode err;
            WeiboInfo[] weiboList;

            Encoding encode = Encoding.GetEncoding("gb2312");

            Request request = new Request(m_requestKind);
            weiboList = await request.SendRequest();
            err = request.LastErrCode;
            MsgResult.AssertMsgBox(err.FSuccess(), err.GetErrorString());

            return weiboList;
        }

        FrmRequestSetting setting = new FrmRequestSetting();

        private void btnSettingForRequest_Click(object sender, EventArgs e)
        {
            setting.SetGroupEnabled(comboBoxCondition.SelectedItem.ToString());
            setting.ShowDialog();

            RequestArgs.weiboType = setting.weibo_type;
            RequestArgs.contentType = setting.content_type;
            RequestArgs.userName = setting.UserName;
            RequestArgs.channelName = setting.ChannelName;
            RequestArgs.requestLength = setting.requestLength;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int index = cBoxImportFileKind.SelectedIndex;
            if (index == 0)
                openFileDialog1.Filter = "SQLite3 Database File(*.s3db)|*.s3db|Database File(*.db)|*.db";
            else if (index == 1)
                openFileDialog1.Filter = "XML File(*.xml)|*.xml|Html File(*.html)|*.html";
            else
                MsgResult.DebugMsgBox("Additional imported file kind?");

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImportFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string strImportFilePath = txtImportFilePath.Text;
            WeiboInfo[] weiboList = null;

            int index = cBoxImportFileKind.SelectedIndex;
            if (index == 0)
            {
                FrmWeiboList listWindow = new FrmWeiboList(strImportFilePath);
                listWindow.ShowDialog();
            }
            else if (index == 1)
                weiboList = GetDataFromHtmlFile(strImportFilePath);
            else
                MsgResult.DebugMsgBox("Additional imported file kind?");

            if (weiboList != null)
            {
                FrmWeiboList listWindow = new FrmWeiboList(weiboList);
                listWindow.ShowDialog();
            }
        }

        private WeiboInfo[] GetDataFromHtmlFile(string strHtmlFilePath)
        {
            MsgResult.AssertMsgBox(!string.IsNullOrEmpty(strHtmlFilePath), "GetDataFromHtmlFile: Invalid Parameter: Empty file path");
            MsgResult.AssertMsgBox(strHtmlFilePath.ToLower().EndsWith("xml") || strHtmlFilePath.ToLower().EndsWith("html"), 
                "GetDataFromHtmlFile: Not a html file.");

            WeiboInfo[] list = null;
            WeiboErrorCode err = null;
            string strContent = File.ReadAllText(strHtmlFilePath);
            MsgResult.AssertMsgBox(XMLParser.ParseWeiboInfoList(strContent, out list, out err), 
                "XMLParser.ParseWeiboInfoList: Failed to parse.");
            MsgResult.AssertMsgBox(err.FSuccess(), err.GetErrorString());

            MsgResult.AssertMsgConsole(list != null && list.Length > 0, "GetDataFromHtmlFile: None data returned.");
            return list;
        }
    }
}
