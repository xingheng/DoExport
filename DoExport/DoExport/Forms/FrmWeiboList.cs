using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.IO;
using UTILITIES_HAN;

namespace DoExport
{
    public partial class FrmWeiboList : Form
    {
        public enum InputDataType
        {
            WeiboArray, DataBase, XML
        };

        public WeiboInfo[] g_weiboInfoList;
        private const int g_MaxCount = 10;
        private int g_CurIndex = 0; // The index of first item in current page.
        private InputDataType g_InputType;

        private string g_HtmlDataPath;

        public FrmWeiboList(WeiboInfo[] list)
        {
            InitializeComponent();
            SetPageFlip(false);

            MsgResult.AssertMsgBox(list.Length <= g_MaxCount, "Too much weibo records, suggest use data table instead.");
            g_weiboInfoList = list;
            g_InputType = InputDataType.WeiboArray;
        }

        public FrmWeiboList(string strDataPath, InputDataType input)
        {
            InitializeComponent();

            g_InputType = input;
            if (input == InputDataType.DataBase)
            {
                SetPageFlip(true);

                PrepareForDB(strDataPath);
                g_weiboInfoList = GetDataFromDBFile(g_CurIndex);
            }
            else if (input == InputDataType.XML)
            {
                SetPageFlip(true);

                PrepareForXML(strDataPath);
                g_HtmlDataPath = strDataPath;
                g_weiboInfoList = GetDataFromHtmlFile(g_CurIndex);
            }
            else
                MsgResult.DebugMsgBox("Unexpected input data type");
        }

        protected override void LocalizationForRunTime()
        {
            string title = "";
            if (SharedMem.IsChineseSimpleCulture())
                title = SharedMem.AppName + " - 微博列表";
            else
                title = SharedMem.AppName + " - List";
            this.Text = title;
        }

        private static void PrepareForDB(string strDBPath)
        {
            MsgResult.AssertMsgBox(!string.IsNullOrEmpty(strDBPath), "GetDataFromDBFile: Invalid Parameter: Empty file path");
            MsgResult.AssertMsgBox(strDBPath.ToLower().EndsWith("s3db") || strDBPath.ToLower().EndsWith("db"),
                "GetDataFromDBFile: Not a database file.");

            DBOperation.connectionString = "Data Source=" + strDBPath;
        }

        private WeiboInfo[] GetDataFromDBFile(int lengthToBeSkipped)
        {
            g_CurIndex = lengthToBeSkipped;

            string cmdString = "SELECT * FROM weibo LIMIT " + lengthToBeSkipped.ToString() + ", " + g_MaxCount.ToString();
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

        private static void PrepareForXML(string strHtmlFilePath)
        {
            MsgResult.AssertMsgBox(!string.IsNullOrEmpty(strHtmlFilePath), "GetDataFromHtmlFile: Invalid Parameter: Empty file path");
            MsgResult.AssertMsgBox(strHtmlFilePath.ToLower().EndsWith("xml") || strHtmlFilePath.ToLower().EndsWith("html"),
                "GetDataFromHtmlFile: Not a html file.");
        }

        private WeiboInfo[] GetDataFromHtmlFile(int startIndex)
        {
            WeiboInfo[] list = null;
            WeiboErrorCode err = null;

            g_CurIndex = startIndex;

            string strContent = File.ReadAllText(g_HtmlDataPath);
            MsgResult.AssertMsgBox(XMLParser.ParseWeiboInfoList(strContent, startIndex, out list, g_MaxCount, out err),
                "XMLParser.ParseWeiboInfoList: Failed to parse.");
            MsgResult.AssertMsgBox(err.FSuccess(), err.GetErrorString());

            MsgResult.AssertMsgConsole(list != null && list.Length > 0, "GetDataFromHtmlFile: None data returned.");
            return list;
        }

        private void FrmWeiboList_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(this.Location.X, workingArea.Y);
            this.Height = workingArea.Height;

            LoadData();
        }

        private void LoadData()
        {
            if (g_weiboInfoList == null)
                return;

            //foreach (Control item in tableLayoutPanel1.Controls)
            //    item.Dispose();
            tableLayoutPanel1.Controls.Clear();

            int count = g_weiboInfoList.Length;
            for (int i = 0; i < count; i++)
            {
                WeiboInfo weibo = g_weiboInfoList[i];

                WeiboPanel item = new WeiboPanel(weibo);
                tableLayoutPanel1.Controls.Add(item, 0, i);

#if DEBUG
                tableLayoutPanel1.ColumnCount = 2;
                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                textBox1.Location = new System.Drawing.Point(100, 100);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(100, 21);
                textBox1.TabIndex = 1;
                textBox1.Dock = DockStyle.Fill;
                textBox1.Multiline = true;
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
                textBox1.Text = weibo.ToString();
                tableLayoutPanel1.Controls.Add(textBox1, 1, i);
#else
                tableLayoutPanel1.ColumnCount = 1;
                this.Width = item.Width + 50;
#endif

                tableLayoutPanel1.RowCount++;
            }
        }

        private void SetPageFlip(bool fStatus)
        {
            btnPrevious.Enabled = btnNext.Enabled = fStatus;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (g_CurIndex < g_MaxCount)
                return;

            if (g_InputType == InputDataType.DataBase)
                g_weiboInfoList = GetDataFromDBFile(g_CurIndex - g_MaxCount);
            else if(g_InputType == InputDataType.XML)
                g_weiboInfoList = GetDataFromHtmlFile(g_CurIndex - g_MaxCount);
            else
                MsgResult.DebugMsgBox("Unexpected input kind that enabled flip");

            if (g_weiboInfoList.Length > 0)
            {
                btnNext.Enabled = true;
                LoadData();
            }
            else
                ((Button)sender).Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (g_InputType == InputDataType.DataBase)
                g_weiboInfoList = GetDataFromDBFile(g_CurIndex + g_MaxCount);
            else if (g_InputType == InputDataType.XML)
                g_weiboInfoList = GetDataFromHtmlFile(g_CurIndex + g_MaxCount);
            else
                MsgResult.DebugMsgBox("Unexpected input kind that enabled flip");

            if (g_weiboInfoList.Length > 0)
            {
                btnPrevious.Enabled = true;
                LoadData();
            }
            else
                ((Button)sender).Enabled = false;
        }
    }
}
