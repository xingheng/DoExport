using System;
using System.Collections;
using System.Threading;
using System.IO;
using System.Drawing;

namespace UTILITIES_HAN
{
    class DownloadService
    {
        private ArrayList m_urls;
        private bool g_isRunning = false;
        private string g_savedImageFolder = "";

        public DownloadService()
        {
            m_urls = new ArrayList();
            g_savedImageFolder = ".";
        }

        public void SetSavedImageFolder(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                g_savedImageFolder = path; 
            }
        }

        public void SetSourceURL(string[] urlArray)
        {
            foreach (string item in urlArray)
            {
                m_urls.Add(item);
            }
        }

        public void AddSourceURL(string url)
        {
            m_urls.Add(url);
        }

        public bool RunStatus()
        {
            return g_isRunning;
        }

        public void Start()
        {
            Thread downloadThread = new Thread(DownLoad);
            downloadThread.Start();
        }

        public void Stop()
        {
            g_isRunning = false;
        }

        private async void DownLoad()
        {
            while (true)
            {
                ArrayList urls = (ArrayList)m_urls.Clone(); // For thread safe, then safe??

                if (urls == null || urls.Count <= 0)
                    return;

                if (!g_isRunning)
                    return;

                foreach (string item in urls)
                {
                    await DownloadImageToPath(item, g_savedImageFolder);
                    if (m_urls.Contains(item))
                    {
                        m_urls.Remove(item);
                    }


                } //foreach
            } //while
        }

        public static async System.Threading.Tasks.Task<string> DownloadImageToPath(string item, string strFolderPathWithoutTail)
        {
            string destinationImageURL = "";

            ResponseStream responseStream = await WebStreamService.GetStreamFromURL(item);
            Stream resultStream = responseStream.GetStream();
            if (resultStream == null)
            {
                MsgResult.WriteLine("Failed to get stream from url '{0}'.", item);
                //break;
            }

            // responseStream.contentType should be like "image/jpeg".
            string[] contentTypeArr = responseStream.contentType.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (contentTypeArr != null && contentTypeArr[0].ToLower().Trim() == "image")
            {
                Image img = Image.FromStream(resultStream);
                if (img != null)
                {
                    string imgExtension = contentTypeArr.Length > 0 ? ("." + contentTypeArr[1].ToString()) : "";
                    string newPath = strFolderPathWithoutTail + "\\" + Guid.NewGuid().ToString() + imgExtension;
                    img.Save(newPath);
                    destinationImageURL = newPath;

                    MsgResult.WriteLine("Save the image from '" + item + "' to '" + newPath + "'.");
                }
                else
                    MsgResult.WriteLine("Failed to get image from stream '", resultStream, "'.");
            }
            else
                MsgResult.WriteLine("Failed to get content type from stream '", responseStream, "'.");

            responseStream.Close();

            return destinationImageURL;
        }
    }

    /// <summary>
    /// Note: We just want to save the stream and its content type together!
    /// </summary>
    class ResponseStream
    {
        private Stream m_stream;    // Require!     Initialization in ResponseStream(Stream stream).

        public string contentType;  // Optional

        public ResponseStream(Stream stream)
        {
            m_stream = stream;
        }

        public Stream GetStream()
        {
            return m_stream;
        }

        public void Close()
        {
            contentType = null;
            m_stream.Close();
        }
    }
}
