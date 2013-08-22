/*---------------------------------------------------------------------------------------------*/

// define this switcher to determinate whether we need use weibo cache data.
//#define USE_CACHE_DATA_WEIBO
//#undef USE_CACHE_DATA_WEIBO       // Comment out/Uncomment this line to enable/disable it.

/*---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILITIES_HAN;
using System.IO;

namespace Will_Weibo_Tencent
{
    public partial class FrmRequestSelect : Form
    {
        public TimelineKind m_requestKind;

        public FrmRequestSelect()
        {
            InitializeComponent();
            LocalizationForRunTime();
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
            cBoxImportFileKind.Items.Insert(1, "Html File");
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

            string cacheFilepath = "./weibo_cache_list.txt";
            Encoding encode = Encoding.GetEncoding("gb2312");

#if !(USE_CACHE_DATA_WEIBO)

            Request request = new Request(m_requestKind);

            if (true)   // for cache data
            {
                string strRequest = request.RequestString;
                string resultString = await WebStreamService.GetResponseStringFromURL(strRequest);

                // Cache the lastest weibo list to local file, then we could debug the app using the data without Authorization.
                if (File.Exists(cacheFilepath))
                    File.Delete(cacheFilepath);

                File.AppendAllText(cacheFilepath, resultString, encode);
            }

            weiboList = await request.SendRequest();
            err = request.LastErrCode;
#else
            string resultString = "";
            if (File.Exists(cacheFilepath))
                resultString = File.ReadAllText(cacheFilepath, encode);
            else
                MsgResult.DebugMsgBox("weibo cache file doesn't exist. Path: {0}", cacheFilepath);

            XMLParser.ParseWeiboInfoList(resultString, out weiboList, out err);
#endif
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
                openFileDialog1.Filter = "Html File(*.html)|*.html";
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
                weiboList = GetDataFromDBFile(strImportFilePath);
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
            MsgResult.AssertMsgBox(strHtmlFilePath.ToLower().EndsWith("html"), "GetDataFromHtmlFile: Not a html file.");

            return null;
        }

        private WeiboInfo[] GetDataFromDBFile(string strDBPath)
        {
            MsgResult.AssertMsgBox(!string.IsNullOrEmpty(strDBPath), "GetDataFromDBFile: Invalid Parameter: Empty file path");
            MsgResult.AssertMsgBox(strDBPath.ToLower().EndsWith("s3db") || strDBPath.ToLower().EndsWith("db"),
                "GetDataFromDBFile: Not a database file.");

            DBOperation.connectionString = "Data Source=" + strDBPath;
            string cmdString = "SELECT * FROM weibo";
            DataTable list = DBOperation.SQLiteRequest_Read(cmdString);
            if (list == null)
            {
                MsgResult.WriteLine("GetDataFromDBFile: None data returned.");
                return null;
            }

            WeiboInfo[] retData = new WeiboInfo[list.Rows.Count];
            int index = 0;
            foreach (DataRow item in list.Rows)
            {
                WeiboInfo weibo = new WeiboInfo();

                #region Convert DataRow to WeiboInfo
                weibo.id = item[list.Columns["id"]].ToString();
                weibo.citycode = item[list.Columns["city_code"]].ToString();
                weibo.count = item[list.Columns["_count"]].ToString();
                weibo.country_code = item[list.Columns["country_code"]].ToString();
                weibo.emotiontype = item[list.Columns["emotiontype"]].ToString();
                weibo.emotionurl = item[list.Columns["emotionurl"]].ToString();
                weibo.from = item[list.Columns["from"]].ToString();
                weibo.fromurl = item[list.Columns["fromurl"]].ToString();
                weibo.geo = item[list.Columns["geo"]].ToString();
                weibo.head = item[list.Columns["head"]].ToString();
                weibo.https_head = item[list.Columns["https_head"]].ToString();
                weibo.image = item[list.Columns["image"]].ToString();
                weibo.isrealname = item[list.Columns["isrealname"]].ToString();
                weibo.isvip = item[list.Columns["isvip"]].ToString();
                weibo.jing = item[list.Columns["jing"]].ToString();
                weibo.latitude = item[list.Columns["latitude"]].ToString();
                weibo.location = item[list.Columns["location"]].ToString();
                weibo.longitude = item[list.Columns["longitude"]].ToString();
                weibo.mcount = item[list.Columns["mcount"]].ToString();
                weibo.music = item[list.Columns["music"]].ToString();
                weibo.name = item[list.Columns["name"]].ToString();
                weibo.nick = item[list.Columns["nick"]].ToString();
                weibo.openid = item[list.Columns["openid"]].ToString();
                weibo.origtext = item[list.Columns["origtext"]].ToString();
                weibo.province_code = item[list.Columns["province_code"]].ToString();
                weibo.self = item[list.Columns["self"]].ToString();
                weibo.source = item[list.Columns["source"]].ToString();
                weibo.status = item[list.Columns["status"]].ToString();
                weibo.text = item[list.Columns["text"]].ToString();
                weibo.timestamp = item[list.Columns["timestamp"]].ToString();
                weibo.type = item[list.Columns["type"]].ToString();
                weibo.video = item[list.Columns["video"]].ToString();
                weibo.wei = item[list.Columns["wei"]].ToString();
                #endregion

                // We will show the weibo data in UI, so generate the extra data for weibo object here.
                weibo.ExpandInfo();

                retData[index++] = weibo;
            }
            return retData;
        }
    }
}
