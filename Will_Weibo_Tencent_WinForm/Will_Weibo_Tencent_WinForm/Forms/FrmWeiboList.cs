using System;
using System.Windows.Forms;
using System.Drawing;
using UTILITIES_HAN;

namespace DoExport
{
    public partial class FrmWeiboList : Form
    {
        public WeiboInfo[] g_weiboInfoList; 

        public FrmWeiboList(WeiboInfo[] list)
        {
            InitializeComponent();
            g_weiboInfoList = list;
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

        private void FrmWeiboList_Load(object sender, EventArgs e)
        {
            if (g_weiboInfoList == null)
                return;

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
    }
}
