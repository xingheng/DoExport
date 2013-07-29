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

namespace Will_Weibo_Tencent
{
    public enum TimeConvertOption
    {
        DateTime2TimeStamp,
        TimeStamp2DateTime
    };

    public partial class FrmConvertTime : Form
    {
        public FrmConvertTime()
        {
            InitializeComponent();
            LoadSetting();
        }

        public FrmConvertTime(TimeConvertOption option) : this()
        {
            switch (option)
            {
                case TimeConvertOption.DateTime2TimeStamp:
                    rBtnDateTime2TimeStamp.Checked = true;
                    break;
                case TimeConvertOption.TimeStamp2DateTime:
                    rBtnTimeStamp2DateTime.Checked = true;
                    break;
            }
        }

        private object result = null;
        public object Result
        {
            get { return result; }
        }

        private void LoadSetting()
        {
            cBoxCopyResult.Checked = true;
            dateTimePicker.Format = DateTimePickerFormat.Long;
            //dateTimePicker.MaxDate = DateTime.Now;
            dateTimePicker.Enabled = mTxtTimeStamp.ReadOnly = true;

            rBtnDateTime2TimeStamp.CheckedChanged += delegate(object senderA, EventArgs eA)
            {
                bool status = (senderA as RadioButton).Checked;
                dateTimePicker.Enabled = status;
                mTxtTimeStamp.ReadOnly = status;
            };
            rBtnTimeStamp2DateTime.CheckedChanged += delegate(object senderA, EventArgs eA)
            {
                bool status = (senderA as RadioButton).Checked;
                mTxtTimeStamp.ReadOnly = !status;
                dateTimePicker.Enabled = !status;
            };
        }

        private void FrmConvertTime_Load(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rBtnDateTime2TimeStamp.Checked)
            {
                DateTime dTime = dateTimePicker.Value;
                long timeStamp = PublicMem.GetTimeStampFromDateTime(dTime);
                result = mTxtTimeStamp.Text = timeStamp.ToString();
            }
            else if (rBtnTimeStamp2DateTime.Checked)
            {
                long timeStamp = 0;
                if (!Int64.TryParse(mTxtTimeStamp.Text.Trim(), out timeStamp))
                {
                    MessageBox.Show("The format of time stamp is invalid.");
                    return;
                }
                DateTime dTime = PublicMem.GetDateTimeFromTimeStamp(timeStamp);
                result = dateTimePicker.Value = dTime;
                //result = dTime.ToShortDateString();
            }
            else
            { /* NULL */ }

            if (cBoxCopyResult.Checked)
            {
                RichTextBox rTxtTemp = new RichTextBox();
                rTxtTemp.Text = result.ToString();
                rTxtTemp.SelectAll();
                rTxtTemp.Copy();
            }
        }
    }
}
