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
        }

        private void FrmReadRequest_Load(object sender, EventArgs e)
        {
            comboBoxCondition.Items.Add(RequestKind.MyPrivateWeibo);
            comboBoxCondition.Items.Add(RequestKind.MyHomePage);
            comboBoxCondition.Items.Add(RequestKind.MyFavouriteWeibo);
            comboBoxCondition.Items.Add(RequestKind.SpecifiedPersonWeibo);

            comboBoxCondition.SelectedIndexChanged += delegate(object senderA, EventArgs eventA)
            {
                string selectedText = (senderA as ComboBox).SelectedItem.ToString();
                m_requestKind = RequestArgs.ConvertRequestKindString2TimeLineKind(selectedText);
            };
            comboBoxCondition.SelectedIndex = 0;

            this.Text = SharedMem.AppName + " - Select & Config";
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

        public async Task<WeiboInfo[]> SendRequest()
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
            MsgResult.AssertMsg(err.FSuccess(), err.GetErrorString());

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
            RequestArgs.requestLength = setting.requestLength;
        }
    }
}
