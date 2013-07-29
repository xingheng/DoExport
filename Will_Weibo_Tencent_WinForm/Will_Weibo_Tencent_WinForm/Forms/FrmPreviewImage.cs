using System;
using System.Drawing;
using System.Windows.Forms;

namespace Will_Weibo_Tencent
{
    public partial class FrmPreviewImage : Form
    {
        public FrmPreviewImage(Image img)
        {
            InitializeComponent();

            //lblImage.Size = img.Size;
            this.Size = img.Size;
            this.Height += 20;
            this.Width += 5;

            //if (lblImage.Size.Height > this.Height)
                //this.Height = lblImage.Size.Height + 20;
            //if (lblImage.Size.Width > this.Size.Width)
                //this.Width = lblImage.Size.Width + 5;

            lblImage.Image = img;
        }

        private void FrmPreviewImage_Load(object sender, EventArgs e)
        {
        }
    }
}
