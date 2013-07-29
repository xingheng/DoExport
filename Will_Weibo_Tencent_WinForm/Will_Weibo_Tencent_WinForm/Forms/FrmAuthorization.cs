using System;
using System.Windows.Forms;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    public partial class FrmAuthorization : Form
    {
        public FrmAuthorization()
        {
            InitializeComponent();
        }

        private bool g_fAuthorize = false;
        public bool FAuthorize
        {
            get { return g_fAuthorize; }
        }

        private void FrmAuthorization_Load(object sender, EventArgs e)
        {
            this.Text = SharedMem.AppName + " - Authorization";

            panelWebBrowser.Dock = DockStyle.Top;
            panelWebBrowser.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            panelToolBar.Dock = DockStyle.Bottom;
            panelToolBar.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            NavigateForAuthorization();
        }

        private void Dismiss()
        {
            this.Close();
        }

        private void NavigateForAuthorization()
        {
            string strRequest = "https://open.t.qq.com/cgi-bin/oauth2/authorize" +
                "?client_id=" + SharedMem.AppKey +
                "&response_type=token" +
                "&redirect_uri=" + SharedMem.redirectURL;
            
            webBrowser1.Navigate(strRequest);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = e.Url.ToString();
            //http://xinghenghan.blog.163.com/#access_token=ACCESS_TOKEN
            //&expires_in=8035200&openid=OPENID
            //&openkey=OPENKEY&refresh_token=REFERESH_TOKEN
            //&state=&name=xingheng907&nick=Will

            if (!(url.StartsWith(SharedMem.redirectURL)))
                return;

            int index = url.IndexOf('#');
            if (index > SharedMem.redirectURL.Length - 1)
            {
                string argStr = url.Substring(index + 1);
                string[] args = argStr.Split(new string[] { "&", "=" }, StringSplitOptions.None);

                if (args.Length % 2 != 0)
                    MsgResult.DebugMsgBox("args: " + args.ToString() + " count is odd!");

                for (int i = 0; i < args.Length; i += 2)
                {
                    string argKey = args[i];
                    string argValue = String.IsNullOrEmpty(args[i + 1]) ? "" : args[i + 1];

                    switch (args[i])
                    {
                        case "access_token":
                            SharedMem.accessToken = argValue;
                            break;
                        case "expires_in":
                            break;
                        case "openid":
                            SharedMem.openID = argValue;
                            break;
                        case "openkey":
                            SharedMem.openkey = argValue;
                            break;
                        case "refresh_token":
                            SharedMem.refreshToken = argValue;
                            break;
                        case "state":
                            break;
                        case "name":
                            break;
                        case "nick":
                            break;
                    }
                }

                if (!String.IsNullOrEmpty(SharedMem.refreshToken))  // TODO: Authorize successfully ???
                {
                    g_fAuthorize = true;
                    Dismiss();
                }
                else
                {
                    // TODO
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigateForAuthorization();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
