using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    //-----------------------------------------------------------------------------
    //---------------------------------BEGIN -------------------------------------
    public enum TimelineKind
    {
        UnDefined,
        MyPrivateWeibo,
        MyHomePage,
        MyFavouriteWeibo,
        SpecifiedPersonWeibo
    }

    public struct RequestKind
    {
        public static readonly string MyPrivateWeibo = "我的个人微博";
        public static readonly string MyHomePage = "我的微博主页";
        public static readonly string MyFavouriteWeibo = "我收藏的所有微博";
        public static readonly string SpecifiedPersonWeibo = "指定人的个人微博";
    }
    //----------------------------------END ---------------------------------------
    //-----------------------------------------------------------------------------

    public static class RequestArgs
    {
        public static int weiboType = 0;
        public static int contentType = 0;
        public static string userName = "xingheng907";
        public static int requestLength = 20;

        public static TimelineKind ConvertRequestKindString2TimeLineKind(string kindArgs)
        {
            TimelineKind kind = TimelineKind.UnDefined;

            if (kindArgs == RequestKind.MyPrivateWeibo)
                kind = TimelineKind.MyPrivateWeibo;
            else if (kindArgs == RequestKind.MyHomePage)
                kind = TimelineKind.MyHomePage;
            else if (kindArgs == RequestKind.MyFavouriteWeibo)
                kind = TimelineKind.MyFavouriteWeibo;
            else if (kindArgs == RequestKind.SpecifiedPersonWeibo)
                kind = TimelineKind.SpecifiedPersonWeibo;
            else
                MsgResult.DebugMsgBox("Unexpected parameters! kindArgs:", kindArgs);
            return kind;
        }
    }

    public class Request
    {

        public Request(TimelineKind flag)
        {
            m_requestString = "";
            m_pageFlag = 0;     // 0 means the first page, 1 means the next page, 2 means the previous page.
            m_lastWeiboID = "0";
            m_lastTimestamp = "0";
            m_kindFlag = flag;

            MsgResult.AssertMsg(GenerateRequestString(), "Class Request: Request string failed to init.");
        }

        #region Members and Properties
        private string m_requestString;
        public string RequestString
        {
            get { return m_requestString; }
            set { m_requestString = value; }
        }

        private int m_pageFlag;
        public int PageFlag
        {
            get { return m_pageFlag; }
            set { m_pageFlag = value; }
        }

        private string m_lastWeiboID;
        public string LastWeiboID
        {
            get { return m_lastWeiboID; }
            set { m_lastWeiboID = value; }
        }

        private string m_lastTimestamp;
        public string LastTimestamp
        {
            get { return m_lastTimestamp; }
            set { m_lastTimestamp = value; }
        }


        private WeiboErrorCode m_lastErrCode;
        public WeiboErrorCode LastErrCode
        {
            get { return m_lastErrCode; }
        }

        private TimelineKind m_kindFlag;
        public TimelineKind KindFlag
        {
            get { return m_kindFlag; }
        }

        #endregion

        /// <summary>
        /// Generate the request string using the data from its and RequestArgsmembers' members.
        /// </summary>
        /// <returns>True if getting the request string successfully, otherwise, false.</returns>
        private bool GenerateRequestString()
        {
            string strRequest = "";
            switch (m_kindFlag)
            {
                case TimelineKind.MyPrivateWeibo:
                    {
                        strRequest = "http://open.t.qq.com/api/statuses/broadcast_timeline?" +
                            "format=xml" +
                            "&pageflag=" + m_pageFlag.ToString() +
                            "&pagetime=" + m_lastTimestamp+
                            "&reqnum=" + RequestArgs.requestLength.ToString() +
                            "&lastid=" + m_lastWeiboID +
                            "&type=" + RequestArgs.weiboType.ToString() +
                            "&contenttype=" + RequestArgs.contentType.ToString() +
                            "&oauth_consumer_key=" + SharedMem.AppKey +
                            "&access_token=" + SharedMem.accessToken +
                            "&openid=" + SharedMem.openID +
                            "&clientip=" + PublicMem.GetIPAddress() +
                            "&oauth_version=2.a&scope=xx";
                    }
                    break;
                case TimelineKind.MyHomePage:
                    {
                        strRequest = "http://open.t.qq.com/api/statuses/home_timeline?" +
                            "format=xml&pageflag=" + m_pageFlag.ToString() +
                            "&pagetime=" + m_lastTimestamp +
                            "&reqnum=" + RequestArgs.requestLength.ToString() +
                            "&type=" + RequestArgs.weiboType.ToString() +
                            "&contenttype=" + RequestArgs.contentType.ToString() +
                            "&oauth_consumer_key=" + SharedMem.AppKey +
                            "&access_token=" + SharedMem.accessToken +
                            "&openid=" + SharedMem.openID +
                            "&clientip=" + PublicMem.GetIPAddress() +
                            "&oauth_version=2.a" +
                            "&scope=all";
                    }
                    break;
                case TimelineKind.MyFavouriteWeibo:
                    {
                        strRequest = "http://open.t.qq.com/api/fav/list_t?" +
                            "format=xml&pageflag=" + m_pageFlag.ToString() +
                            "&pagetime=" + m_lastTimestamp +
                            "&reqnum=" + RequestArgs.requestLength.ToString() +
                            "&lastid=" + m_lastWeiboID +
                            "&oauth_consumer_key=" + SharedMem.AppKey +
                            "&access_token=" + SharedMem.accessToken +
                            "&openid=" + SharedMem.openID +
                            "&clientip=" + PublicMem.GetIPAddress() +
                            "&oauth_version=2.a&scope=xx";
                    }
                    break;
                case TimelineKind.SpecifiedPersonWeibo:
                    {
                        strRequest = "http://open.t.qq.com/api/statuses/user_timeline?" +
                            "format=xml&pageflag=" + m_pageFlag.ToString() +
                            "&pagetime=" + m_lastTimestamp+
                            "&reqnum=" + RequestArgs.requestLength.ToString() +
                            "&lastid=" + m_lastWeiboID +
                            "&name=" + RequestArgs.userName +
                            "&fopenid=" +
                            "&type=" + RequestArgs.weiboType.ToString() +
                            "&contenttype=" + RequestArgs.contentType.ToString() +
                            "&oauth_consumer_key=" + SharedMem.AppKey +
                            "&access_token=" + SharedMem.accessToken +
                            "&openid=" + SharedMem.openID +
                            "&clientip=" + PublicMem.GetIPAddress() +
                            "&oauth_version=2.a&scope=xx";
                    }
                    break;
                default:
                    // TODO
                    break;
            }

            if (String.IsNullOrEmpty(strRequest))
                return false;
            else
            {
                m_requestString = strRequest;
                return true;
            }

        }

        /// <summary>
        /// Get the data with WeiboInfo list from m_requestString. 
        /// </summary>
        /// <param name="fDebug">True if we want to generate and check the request string for debugging.</param>
        /// <returns></returns>
        public async Task<WeiboInfo[]> SendRequest(bool fDebug = false)
        {
            if (String.IsNullOrEmpty(m_requestString))
                return null;

            if (fDebug)
            {
                m_lastTimestamp = DateTime.Now.Ticks.ToString();
                m_lastWeiboID = Guid.NewGuid().ToString();
                m_pageFlag = 1;
                GenerateRequestString();
                return null;
            }

            string resultString = await WebStreamService.GetResponseStringFromURL(m_requestString);

            WeiboErrorCode err;
            WeiboInfo[] weiboList;
            XMLParser.ParseWeiboInfoList(resultString, out weiboList, out err);
            m_lastErrCode = err;

            if (m_lastErrCode.FSuccess() && weiboList != null && weiboList.Length > 0)
            {
                m_lastTimestamp = weiboList[weiboList.Length - 1].timestamp;
                m_lastWeiboID = weiboList[weiboList.Length - 1].id;

                m_pageFlag = 1;
            }

            return weiboList;
        }
        
        /// <summary>
        /// Get data of next page.
        /// </summary>
        /// <returns></returns>
        public async Task<WeiboInfo[]> NextPage()
        {
            if (GenerateRequestString())
                return (await SendRequest());
            else
                return null;
        }
    }
}
