using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    internal enum TimeStampOption
    {
        None = 0,
        StartFrom = 1,
        EndWith = 2
    };

    public partial class FrmExport : Form
    {
        private TimelineKind m_requestKind;
        private Request g_ExportRequest = null;

        private bool g_FExporting = false;
        private bool g_FExportText = false;
        private bool g_FExportImage = false;
        private bool g_FExportDB = false;

        private bool g_FDetailedLog = true;

        private long g_lTimestamp = 0;

        public FrmExport(TimelineKind kindFlag)
        {
            InitializeComponent();
            m_requestKind = kindFlag;
            g_ExportRequest = new Request(m_requestKind);
        }

        protected override void LocalizationForRunTime()
        {
            string title = "";
            if (SharedMem.IsChineseSimpleCulture())
                title = SharedMem.AppName + " - 导出";
            else
                title = SharedMem.AppName + " - Export";
            this.Text = title;
        }

        private void FrmExport_Load(object sender, EventArgs e)
        {
            txtTextFilePath.ReadOnly = txtImageFilePath.ReadOnly =txtDBFilePath.ReadOnly = rTxtResult.ReadOnly = true;
            BtnCancel.BringToFront();

            cBoxExportText.Checked = false; cBoxExportImage.Checked = true; cBoxExportAllData.Checked = true;// We just want to trigger the event below when loading.
            cBoxExportText.CheckedChanged += delegate(object senderA, EventArgs eA)
            { 
                g_FExportText = btnBrowseTextFile.Enabled = (senderA as CheckBox).Checked; 
            };
            cBoxExportImage.CheckedChanged += delegate(object senderA, EventArgs eA)
            {
                g_FExportImage = btnBrowseImageFile.Enabled = (senderA as CheckBox).Checked; 
            };
            cBoxExportAllData.CheckedChanged += delegate(object senderA, EventArgs eA)
            {
                g_FExportDB = btnBrowseDB.Enabled = (senderA as CheckBox).Checked;
            };
            cBoxExportText.Checked = true; cBoxExportImage.Checked = false; cBoxExportAllData.Checked = false;

            cBoxDetailedLog.CheckedChanged += delegate(object senderA, EventArgs eA)
            {
                g_FDetailedLog = (senderA as CheckBox).Checked;
            };
            cBoxDetailedLog.Checked = g_FDetailedLog;

            SetExportStatus(false);

            AppendResult("RequestString: " + g_ExportRequest.RequestString);
            AppendResult("PageFlag: " + g_ExportRequest.PageFlag.ToString());
            AppendResult("LastTimestamp: " + g_ExportRequest.LastTimestamp.ToString());
            AppendResult("LastWeiboID: " + g_ExportRequest.LastWeiboID.ToString());

#if !DEBUG
            this.Controls.Remove(this.btnNextPage);
#endif
        }

        private void btnBrowseTextFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.xml)|*.xml|(*.txt)|*.txt|(*.html)|*.html|(All)|*.*";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtTextFilePath.Text = saveFileDialog1.FileName;
        }

        private void btnBrowseImageFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtImageFilePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnBrowseDB_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "SQLite3 Database File(*.s3db)|*.s3db|Database File(*.db)|*.db|All|*.*";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtDBFilePath.Text = saveFileDialog1.FileName;
        }

        private void AppendResult(string result)
        {
            rTxtResult.Text += result;
            rTxtResult.Text += "\r\n";

            rTxtResult.SelectionStart = rTxtResult.TextLength;
            rTxtResult.ScrollToCaret();
        }

        private void ExportTextToBackupFile(string strAppend)
        {
            string strTextFilePath = txtTextFilePath.Text.Trim();
            if (!String.IsNullOrEmpty(strTextFilePath))
                File.AppendAllText(strTextFilePath, strAppend);
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            #region Check status of setting
            string savedTextFilePath = txtTextFilePath.Text, savedImageFilePath = txtImageFilePath.Text,
                savedDBFilePath = txtDBFilePath.Text;
            if (cBoxExportText.Checked && String.IsNullOrEmpty(savedTextFilePath))
            {
                MessageBox.Show("You should choose a file path to save text if you want to.");
                btnBrowseTextFile_Click(null, null);
                return;
            }
            if (cBoxExportImage.Checked && String.IsNullOrEmpty(savedImageFilePath))
            {
                MessageBox.Show("You should choose a folder path to save images if you want to.");
                btnBrowseImageFile_Click(null, null);
                return;
            }
            if (cBoxExportAllData.Checked && String.IsNullOrEmpty(savedDBFilePath))
            {
                MessageBox.Show("You should choose a database file to save data if you want to.");
                btnBrowseImageFile_Click(null, null);
                return;
            }
            if (!cBoxExportText.Checked && !cBoxExportImage.Checked && !cBoxExportAllData.Checked)
            {
                MessageBox.Show("Text, Image or Database? Choose one at least.");
                return;
            }
            if ((rBtnStartTime.Checked || rBtnEndTime.Checked) && String.IsNullOrEmpty(mTxtTimeStamp.Text.Trim()))
            {
                MessageBox.Show("Please give me a timestamp value if you want, or you should deselect all the timestamp setting.");
                return;
            }
            #endregion

            // Loading for database.
            if (g_FExportDB)
                MsgResult.AssertMsgBox(PrepareforDatabase(savedDBFilePath), "PrepareforDatabase failed.");

            tabControl1.SelectedTab = tabPageDetails;
            SetExportStatus(true);

            bool fFoundFirst = false;   // find the first valid item
            bool fShouldEnd = false;    // check the last valid item

            TimeStampOption option = TimeStampOption.None;
            if (rBtnStartTime.Checked)
                option = TimeStampOption.StartFrom;
            else if (rBtnEndTime.Checked)
                option = TimeStampOption.EndWith;
            else
                option = TimeStampOption.None;

            g_lTimestamp = 0;
            if (option != TimeStampOption.None)
                MsgResult.AssertMsgBox(Int64.TryParse(mTxtTimeStamp.Text.Trim(), out g_lTimestamp), "Int64.TryParse() failed.");

            // ---------------------- The Beginning of Export---------------------
            #region
            ExportTextToBackupFile("<root><data>");
            ExportTextToBackupFile("\r\n");

            CollectResult collectLog = new CollectResult();
            collectLog.Environment = "We're exporting the Weibo data.";
            AppendResult("Starting...");

            int exportedSum = 0;
            long compared_TimeStamp = PublicMem.GetTimeStampFromDateTime(DateTime.Now);

            int exportedLength = 0;     // The requested length does not always equal to the exported length.
            long long_last_timestamp = 0;

            bool hasNext = false;

            try
            {
                do
                {
                    ArrayList errList = new ArrayList();    // Save all the error code for every request.
                LStart:

                    WeiboInfo[] weiboList = null;
                    if (g_ExportRequest.PageFlag == 0)
                        weiboList = await g_ExportRequest.SendRequest();
                    else
                        weiboList = await g_ExportRequest.NextPage();

                    WeiboErrorCode err = g_ExportRequest.LastErrCode;
                    if (!err.FSuccess())
                    {
                        collectLog.Reason = String.Format("Request Error:{0}.", err.GetErrorString());
                        MsgResult.DebugMsgBox(err.GetErrorString());

                        errList.Add(err);
                        if (!errList.Contains(err))
                            goto LStart;
                    }

                    if (weiboList != null && weiboList.Length > 0)
                    {
                        // Check the first valid one in this requested range.
                        WeiboInfo first = weiboList[0], last = weiboList[weiboList.Length - 1];
                        if (option == TimeStampOption.StartFrom)
                        {
                            if (!fFoundFirst && WeiboInfo.IsMiddleTimestamp(first, last, g_lTimestamp) == 0)
                                fFoundFirst = true;
                            else if (!fFoundFirst)
                                goto LSkip;
                        }
                        else// if (option == TimeStampOption.EndWith)     // then the first one must be valid, if so.
                            fFoundFirst = true;

                        foreach (WeiboInfo item in weiboList)
                        {
                            if (fFoundFirst)
                            {
                                long curTimestamp = 0;
                                MsgResult.AssertMsgConsole(Int64.TryParse(item.timestamp, out curTimestamp), "Int64.TryParse() failed.");
                                if (option == TimeStampOption.StartFrom)
                                {
                                    if (curTimestamp > g_lTimestamp)    // lookup the first one exactly!
                                        continue;
                                }
                                else if (option == TimeStampOption.EndWith)
                                {
                                    if (curTimestamp < g_lTimestamp)    // check the end.
                                    {
                                        fShouldEnd = true;
                                        break;
                                    }
                                }
                            }
                            else
                                MsgResult.AssertMsgBox(false, "Impossible case! Please check the logic about fFoundFirst.");

                            // For database
                            if (g_FExportDB)
                                ExportWeiboToDBTable(item, "weibo");

                            // For text
                            if (g_FExportText)
                                ExportTextToBackupFile(item.str_XML_Info_Node);

                            // For image
                            if (g_FExportImage)
                            {
                                if (!item.HasImage())
                                    continue;

                                foreach (string url in item.GetImageURLs(WeiboImageSize.OriginalSize))
                                {
                                    if (url == null)
                                        continue;

                                    string newImgURL = await DownloadService.DownloadImageToPath(url, savedImageFilePath, item.timestamp);

                                    if (g_FDetailedLog)
                                        AppendResult(String.Format("Downloaded the image '{0}' to path '{1}'.",
                                            url, newImgURL));
                                }
                            }

                            exportedLength++;

                            // This loop maybe takes too much time, so let's check the cancel signal.
                            if (!g_FExporting)
                                break;
                        }

                    LSkip:

                        //exportedLength = weiboList.Length;
                        exportedSum += exportedLength;

                        MsgResult.AssertMsgConsole(Int64.TryParse(g_ExportRequest.LastTimestamp, out long_last_timestamp), "Int64.TryParse() failed.");
                    }
                    else // Interesting case! There may be an end.
                    {
                        goto LError;
                    }

                    int int_hasNext = -1;
                    if (Int32.TryParse(err.reserved1.ToString(), out int_hasNext)) // hasnext property.
                        hasNext = int_hasNext > -1;
                    else
                        hasNext = false;

                    long totalNum = -1;
                    Int64.TryParse(err.reserved2.ToString(), out totalNum);

                    AppendResult("We have saved " + exportedSum.ToString() + " items. " +
                        (((float)exportedSum / (float)totalNum) * 100).ToString("F2") +
                        "% percent. Exported length is " + exportedLength.ToString() + " this time."
                        );

                    #region Check result
                    if (!g_FExporting)
                    {
                        AppendResult(collectLog.Reason = "Cancelled by user.");
                        goto LError;
                    }
                    if (fShouldEnd)
                    {
                        AppendResult(collectLog.Reason = "We arrived the end. The last weibo timestamp is " + long_last_timestamp.ToString());
                        goto LError;
                    }
                    if (exportedLength <= 0)   // That should be an end.
                    {
                        collectLog.Reason = String.Format("exportedLength <= 0. exportedLength: {0}.", exportedLength);
                        goto LError;
                    }
                    else if (!hasNext)
                    {
                        collectLog.Reason = "hasNext: " + err.reserved1.ToString();
                        goto LError;
                    }
                    else if (compared_TimeStamp < long_last_timestamp)
                    {
                        collectLog.Reason = String.Format("compared_TimeStamp < int_last_timestamp. compared_TimeStamp: {0}, int_last_timestamp: {1}",
                            compared_TimeStamp, long_last_timestamp);
                        goto LError;
                    }
                    else if (totalNum > 0 && exportedSum > totalNum)
                    {
                        collectLog.Reason = String.Format("exportedSum > totalNum. exportedSum: {0}, totalNum: {1}",
                            exportedSum, totalNum);
                        goto LError;
                    }
                    else if (exportedLength < RequestArgs.requestLength)   // Unknown reason, but this shouldn't be a error.
                    {
                        //collectLog.Reason = String.Format("exportedLength < shouldRequestNum. exportedLength: {0}, RequestArgs.requestLength: {1}",
                            //exportedLength, RequestArgs.requestLength);
                        //collectLog.AddEnvironmentNote("Note: This is the last time of exportedLength < shouldRequestNum.");
                        //goto LError;
                    }
                    #endregion

                    compared_TimeStamp = long_last_timestamp;

                    ExportTextToBackupFile("\r\n");
                }
                while (true);
            }
            catch (Exception ex)
            {
                MsgResult.DebugMsgBox(ex.ToString());

                collectLog.Exception = ex;
                collectLog.Reason = "Exception was thrown";
                goto LError;
            }
            finally
            {
                ExportTextToBackupFile("</data></root>");
            }

        LError:
            collectLog.EmtryAllArgs();
            collectLog.AddArgs("exportedLength", exportedLength);
            collectLog.AddArgs("exportedSum", exportedSum);
            collectLog.AddArgs("long_last_timestamp", long_last_timestamp);
            collectLog.AddArgs("compared_TimeStamp", compared_TimeStamp);
            collectLog.AddArgs("LastWeiboID", g_ExportRequest.LastWeiboID);
            collectLog.AddArgs("pageFlag", g_ExportRequest.PageFlag);

            string Logs = collectLog.FormatResult();
            MsgResult.WriteLine(Logs);

            AppendResult("Finished");
            #endregion
            // ---------------------- The End of Export---------------------

            SetExportStatus(false);
        }

        private static bool PrepareforDatabase(string strDBPath)
        {
            MsgResult.AssertMsgBox(!string.IsNullOrEmpty(strDBPath), "Path is null");

            DBOperation.connectionString = "Data Source=" + strDBPath;
            string cmdString = "DROP TABLE IF EXISTS weibo";
            Exception ret = DBOperation.SQLiteRequest_Write(cmdString);
            if (ret != null)
                goto LError;

            FileInfo fileScript = new FileInfo(@"..\..\Resources\CreateTable_weibo.sql");
            if (fileScript.Exists)
                cmdString = File.ReadAllText(fileScript.FullName, System.Text.Encoding.UTF8);
            else
            {
                MsgResult.DebugMsgBox("File " + fileScript.FullName + " not exists.");
                goto LError;
            }

            ret = DBOperation.SQLiteRequest_Write(cmdString);
            if (ret != null)
                goto LError;

            return true;

        LError:
            if (ret != null)
                MsgResult.DebugMsgBox(ret.ToString());
            return false;
        }

        private void ExportWeiboToDBTable(WeiboInfo weibo, string tbName)
        {
            string cmdString = "INSERT INTO "+ tbName +" VALUES(@id, @citycode, @_count, @country_code, @emotiontype,  @emotionurl, @from, @fromurl," +
                "@geo, @head, @https_head, @image,  @isrealname, @isvip, @jing, @latitude, @location,  @longitude, @mcount,  @music," +
                "@name, @nick, @openid, @origtext, @province_code, @self, @source, @status, @text,  @timestamp, @type, @video, @wei)";
            Exception ret = DBOperation.SQLiteRequest_Write(cmdString,
                "@id", weibo.id,
                "@citycode", weibo.citycode,
                "@_count", weibo.count,
                "@country_code", weibo.country_code,
                "@emotiontype", weibo.emotiontype,
                "@emotionurl", weibo.emotionurl,
                "@from", weibo.from,
                "@fromurl", weibo.fromurl,
                "@geo", weibo.geo,
                "@head", weibo.head,
                "@https_head", weibo.https_head,
                "@image", weibo.image,
                "@isrealname", weibo.isrealname,
                "@isvip", weibo.isvip,
                "@jing", weibo.jing,
                "@latitude", weibo.latitude,
                "@location", weibo.location,
                "@longitude", weibo.longitude,
                "@mcount", weibo.mcount,
                "@music", weibo.music,
                "@name", weibo.name,
                "@nick", weibo.nick,
                "@openid", weibo.openid,
                "@origtext", weibo.origtext,
                "@province_code", weibo.province_code,
                "@self", weibo.self,
                "@source", weibo.source,
                "@status", weibo.status,
                "@text", weibo.text,
                "@timestamp", weibo.timestamp,
                "@type", weibo.type,
                "@video", weibo.video,
                "@wei", weibo.wei
                );
            if (ret != null)
            {
                MessageBox.Show("Failed!\r\nret: " + ret.ToString() + "cmdText: " + cmdString, "Insert a row");
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (g_FExporting && e.TabPage == tabPagePreference)
                e.Cancel = true;
        }

        /// <summary>
        /// Set Status for the Exporting process.
        /// </summary>
        /// <param name="status">True if the export process is running, otherwise, false.</param>
        /// <returns>True if the operation is finished successfully.</returns>
        bool SetExportStatus(bool status)
        {
            if (status)
            {
                g_FExporting = status;
                BtnCancel.Visible = status;
            }
            else
            {
                g_FExporting = status;
                BtnCancel.Visible = status;
            }
            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetExportStatus(false);
        }

        // This function is available for debugging only, we just want to get check the request string for next page.
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            g_ExportRequest.SendRequest(true);
            AppendResult("RequestString: " + g_ExportRequest.RequestString);
            AppendResult("PageFlag: " + g_ExportRequest.PageFlag.ToString());
            AppendResult("LastTimestamp: " + g_ExportRequest.LastTimestamp.ToString());
            AppendResult("LastWeiboID: " + g_ExportRequest.LastWeiboID.ToString());
        }

        private void FrmExport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (g_FExporting && MessageBox.Show("The export task is in progress, are you sure to kill it?",
                    SharedMem.AppName, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                g_FExporting = false;
                e.Cancel = true;    // Do NOT close the window immediately as we should let users to get the finished log in the end.
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            rBtnStartTime.Checked = rBtnEndTime.Checked = false;
            mTxtTimeStamp.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            FrmConvertTime frmConvert = new FrmConvertTime(TimeConvertOption.DateTime2TimeStamp);
            frmConvert.ShowDialog();
            if (frmConvert.Result != null)
                mTxtTimeStamp.Text = frmConvert.Result.ToString();
        }
    }
}
