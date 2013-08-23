using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UTILITIES_HAN
{
    /// <summary>
    /// AutoRichTextBox is base on System.Windows.Forms.RichTextBox.
    /// "Auto" means "auto size", it will be expand its size according to the content size.
    /// </summary>
    class AutoRichTextBox : RichTextBox
    {
        const int EM_GETLINECOUNT = 0x00BA;
        const int WM_SETFOCUS = 0x0007;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

        public AutoRichTextBox()
            : base()
        {
            this.ScrollBars = RichTextBoxScrollBars.None;

            //this.MinimumSize = new Size(200, 55);
            //this.MaximumSize = new Size(200, 200);
            this.ContentsResized += AutoRichTextBox_ContentsResized;

            this.Resize += AutoRichTextBox_Resize;
            this.ReadOnlyChanged += AutoRichTextBox_ReadOnlyChanged;
        }

        void AutoRichTextBox_ReadOnlyChanged(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETFOCUS, IntPtr.Zero, "");
        }

        void AutoRichTextBox_Resize(object sender, EventArgs e)
        {
            ChangeHeight();
        }

        void AutoRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ChangeHeight();
        }

        private void ChangeHeight()
        {
            int lc = SendMessage(this.Handle, EM_GETLINECOUNT, IntPtr.Zero, "");
            double sf = this.Font.Height * (lc + 0.8);
            this.Height = (int)sf;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                //case EM_GETLINECOUNT:
                //    {
                //    }
                //    break;
                case WM_SETFOCUS:
                    if (this.ReadOnly)
                    {
                        // Disable the focus message.
                        return;
                    }
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }
    }
}
