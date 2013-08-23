using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Xml;
using System.Threading;
using UTILITIES_HAN;

namespace DoExport
{
    public partial class FrmMain : Form
    {
        WeiboInfo[] g_weiboList;
        Request myRequest = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void LocalizationForRunTime()
        {
            string title = "";
            if (SharedMem.IsChineseSimpleCulture())
                title = SharedMem.AppName + " - 调试主窗口";
            else
                title = SharedMem.AppName + " - Debug";
            this.Text = title;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            comboBoxCondition.Items.Add(RequestKind.MyPrivateWeibo);
            comboBoxCondition.Items.Add(RequestKind.MyHomePage);
            comboBoxCondition.Items.Add(RequestKind.MyFavouriteWeibo);
            comboBoxCondition.Items.Add(RequestKind.SpecifiedPersonWeibo);
            comboBoxCondition.SelectedIndexChanged += delegate(object senderA, EventArgs eventA)
            {
                string selectedText = (senderA as ComboBox).SelectedItem.ToString();
                myRequest = new Request(RequestArgs.ConvertRequestKindString2TimeLineKind(selectedText));
            };
            comboBoxCondition.SelectedIndex = 0;
            
            listView.Columns.Add("ID");
            listView.Columns.Add("OriginalText");
            listView.Columns.Add("Text");
            listView.Columns.Add("TimeStamp");
            listView.Columns.Add("Image");
            listView.Columns.Add("Video");

            listView.FullRowSelect = true;
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "Next Page")
            {
                await SendRequest(false);   // the first request
                btn.Text = "Next Page";
            }
            else
                await SendRequest(true);
        }

        private async Task SendRequest(bool fNextpage)
        {
            string strRequest = "";
            strRequest = myRequest.RequestString;

            AppendResult(strRequest);
            AppendResult("type=" + RequestArgs.weiboType.ToString());
            AppendResult("contenttype=" + RequestArgs.contentType.ToString());

            WeiboErrorCode err;
            if (fNextpage)
            {
                g_weiboList = await myRequest.NextPage();
            }
            else
            {
                g_weiboList = await myRequest.SendRequest();
                listView.Items.Clear();
            }

            err = myRequest.LastErrCode;
            MsgResult.AssertMsgBox(err.FSuccess(), err.GetErrorString());

            if (g_weiboList.Length > 0)
            {
                foreach (WeiboInfo item in g_weiboList)
                {
                    ListViewItem listItem = new ListViewItem(new string[] { item.id, 
                        item.origtext, 
                        item.subWeibo != null ? item.subWeibo.origtext: "",
                        item.GetTime().ToString(),
                        item.image,
                        item.video
                        });
                    listView.Items.Add(listItem);
                }
            }
        }

        void AppendResult(string output)
        {
            txtResult.Text += output;
            txtResult.Text += "\r\n";

            txtResult.SelectionStart = txtResult.TextLength;
            txtResult.ScrollToCaret();
        }

        void EmptyResult()
        {
            txtResult.Text = "";
        }

        private void btnWeiboList_Click(object sender, EventArgs e)
        {
            if (g_weiboList != null && g_weiboList.Length > 0)
            {
                FrmWeiboList weiboList = new FrmWeiboList(g_weiboList);
                weiboList.Show();
            }
        }

        private void btnFrmExport_Click(object sender, EventArgs e)
        {
            FrmExport frmExp = new FrmExport(myRequest.KindFlag);
            frmExp.Show();
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

        private async void btnDownloadImage_Click(object sender, EventArgs e)
        {
            lblImagePreview.Image = null;

            string strRequest = //"http://t3.qpic.cn/mblogpic/5b320c09e7397dedb38c/2000";
                                "http://t2.qpic.cn/mblogpic/75087d5b0b7a762986c2/2000";
            Stream resultStream = (await WebStreamService.GetStreamFromURL(strRequest)).GetStream();
            if (resultStream == null)
            {
                lblImagePreview.Text = "Get stream failed.";
                return;
            }
            Image img = Image.FromStream(resultStream);
            if (img != null)
                lblImagePreview.Image = img;
            else
                lblImagePreview.Text = "Get image failed.";

            resultStream.Close();
        }

        private void btnDownloadInThread_Click(object sender, EventArgs e)
        {
            DownloadService service = new DownloadService();
            service.AddSourceURL("http://t3.qpic.cn/mblogpic/5b320c09e7397dedb38c/2000");
            service.AddSourceURL("http://t2.qpic.cn/mblogpic/75087d5b0b7a762986c2/2000");
            service.Start();
        }

        private void btnGenerateImage_Click(object sender, EventArgs e)
        {
            //Bitmap map = new Bitmap(listView.Width, listView.Height);
            //Graphics g = Graphics.FromImage(map);


            Bitmap myImage = new Bitmap(listView.Width, listView.Height);
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(
                listView.PointToScreen(new Point(0,0)),
                new Point(0, 0), new Size(listView.Width, listView.Height));
            IntPtr dc1 = g.GetHdc();
            g.ReleaseHdc(dc1);
            myImage.Save(@"screen0.jpg");

        }

    }
}
