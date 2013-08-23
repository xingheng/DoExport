
#define USE_ASYNC

using System;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace UTILITIES_HAN
{
    class WebStreamService
    {
        private static bool CheckStream(Stream stream)
        {
            if (stream.CanRead && stream.CanSeek && stream.Length > 0)
                return true;
            else
            {
                //MsgResult.WriteLine("The stream could not be seek." + stream.ToString());
                return false;
            }
        }

        public static async Task<string> GetResponseStringFromURL(string strRequest)
        {
            string result = "";

            StreamReader resultStream = await WebStreamService.GetStreamReaderFromURL(strRequest);
            if (resultStream != null)
            {
                result = resultStream.ReadToEnd();
                resultStream.Close();
            }

            return result;
        }

        public static async Task<StreamReader> GetStreamReaderFromURL(string strRequest)
        {
            StreamReader resultStream = null;
            ResponseStream rStream = await GetStreamFromURL(strRequest);
            if (rStream != null)
            {
                resultStream = new StreamReader(rStream.GetStream());
            }
            return resultStream;
        }

        public static async Task<ResponseStream>  GetStreamFromURL(string strRequest)
        {
            ResponseStream responseStream = null;
            try
            {
                if (!String.IsNullOrEmpty(strRequest))
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(strRequest);
                    myRequest.Method = "GET";
                    myRequest.Timeout = 30000;
#if USE_ASYNC
                    HttpWebResponse myResponse = (HttpWebResponse)(await myRequest.GetResponseAsync());
#else
                    HttpWebResponse myResponse = (HttpWebResponse)(myRequest.GetResponse());
#endif

                    Stream tmpResponseStream = myResponse.GetResponseStream();
                    CheckStream(tmpResponseStream);

                    responseStream = new ResponseStream(tmpResponseStream);
                    responseStream.contentType = myResponse.ContentType;

                    //myResponse.Close();
                }
            }
            catch (Exception ex)
            {
                MsgResult.WriteLine(ex.ToString());
            }

            return responseStream;
        }
    }

}
