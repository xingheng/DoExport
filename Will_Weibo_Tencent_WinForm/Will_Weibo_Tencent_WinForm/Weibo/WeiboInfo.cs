using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;
using System.Xml;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    public enum WeiboMediaFlag : byte
    {
        HasImageOnly            = 0x0001,
        HasVideoOnly            = HasImageOnly << 1,
        HasBoth           = HasImageOnly | HasVideoOnly
    };

    // This size data isn't from documendation in wiki.open.t.qq.com, thanks for flyer_ren's help!
    // Here is the link: http://bbs.csdn.net/topics/390510896?page=1#post-395007881
    enum WeiboImageFullSize : int
    {
        TinySize60 = 60,
        TinySize120 = 120,
        SmallSize150 = 150,
        SmallSize240 = 240,
        MediumSize460 = 460,
        MediumSize500 = 500,
        BigSize2000 = 2000,
    };

    public enum WeiboImageSize : int
    {
        TinySize = WeiboImageFullSize.TinySize120,
        SmallSize = WeiboImageFullSize.SmallSize240,
        OriginalSize = WeiboImageFullSize.BigSize2000
    };

    public enum WeiboType : byte    /*This date list comes from wiki.open.t.qq.com*/
    {
        Original        = 1,
        Reposted        = 2,
        PrivateMessage  = 3,
        Reply           = 4,
        ReplyNULL       = 5,
        Mention         = 6,
        Comment         = 7
    };

    public class WeiboInfo : ICloneable
    {
        #region Full members of weibo.
        public string citycode;
        public string count;
        public string country_code;
        public string emotiontype;
        public string emotionurl;
        public string from;
        public string fromurl;
        public string geo;
        public string head;
        public string https_head;
        public string id;
        public string image;
        //public object pic;    /*The pic node just contains the size and url info, let's skip the size info here.*/
        public string isrealname;
        public string isvip;
        public string jing;
        public string latitude;
        public string location;
        public string longitude;
        public string mcount;
        public string music;
        public string name;
        public string nick;
        public string openid;
        public string origtext;
        public string province_code;
        public string self;
        public string source;
        public string status;
        public string text;
        public string timestamp;
        public string type;
        public string video;
        public string wei;

        public WeiboInfo subWeibo;
        #endregion

        #region Personally, helper members.
        public WeiboMediaFlag p_MediaFlag;
        public WeiboType p_Type;
        public string str_XML_Info_Node;    // Save the full string of XML "info" node. eg, "<info><citycode></citycode>.....</info>"

        #endregion

        public WeiboInfo()
        {
        }

        public WeiboInfo(string xmlInfoNode)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlInfoNode);
            XmlNode info = xmlDoc.SelectSingleNode("info");
            WeiboInfo tmpWeibo = XMLParser.CollectWeiboInfo(info);
            // TODO
            //this = tmpWeibo.Clone() as WeiboInfo;
            MsgResult.DebugMsgBox("Not yet!");
        }

        public static WeiboInfo GetWeiboInfoFromNodeString(string xmlInfoNode)
        {
            WeiboInfo retWeibo = null;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlInfoNode);
            XmlNode info = xmlDoc.SelectSingleNode("info");
            if (info == null)
                info = xmlDoc.SelectSingleNode("source");
            if (info != null)
            {
                retWeibo = XMLParser.CollectWeiboInfo(info);
                retWeibo.ExpandInfo();
            }

            return retWeibo;
        }

        // Members of ICloneable
        public object Clone()
        {
            // TODO
            return this;
        }

        //public void ShallowClone()

        public override string ToString()
        {
            return "citycode " + citycode + "\r\n" +
                "count " + count + "\r\n" +
                "country_code " + country_code + "\r\n" +
                "from " + from + "\r\n" +
                "geo " + geo + "\r\n" +
                "id " + id + "\r\n" +
                "image " + image + "\r\n" +
                "isvip " + isvip + "\r\n" +
                "location " + location + "\r\n" +
                "mcount " + mcount + "\r\n" +
                "name " + name + "\r\n" +
                "nick " + nick + "\r\n" +
                "openid " + openid + "\r\n" +
                "origtext " + origtext + "\r\n" +
                "province_code " + province_code + "\r\n" +
                "source " + source + "\r\n" +
                "status " + status + "\r\n" +
                "text " + text + "\r\n" +
                "timestamp " + timestamp + "\r\n" +
                "type " + type + "\r\n" + 
                "";
        }

        /// <summary>
        ///  Expand the info from the references of weibo.
        ///  Note: This function just inits some additional properties for a weibo object,
        ///     if you need to get image object in background thread, see ExpandInfoEx().
        /// </summary>
        public void ExpandInfo()
        {
            if (subWeibo == null && !string.IsNullOrEmpty(source))
                subWeibo = GetWeiboInfoFromNodeString(source);

            if (!String.IsNullOrEmpty(image))
                p_MediaFlag |= WeiboMediaFlag.HasImageOnly;
            else if (this.subWeibo != null && !String.IsNullOrEmpty(this.subWeibo.image))
                p_MediaFlag |= WeiboMediaFlag.HasImageOnly;
            else
                p_MediaFlag &= ~(WeiboMediaFlag.HasImageOnly);

            if (!String.IsNullOrEmpty(video))
                p_MediaFlag |= WeiboMediaFlag.HasVideoOnly;
            else if (this.subWeibo != null && !String.IsNullOrEmpty(this.subWeibo.video))
                p_MediaFlag |= WeiboMediaFlag.HasVideoOnly;
            else
                p_MediaFlag &= ~(WeiboMediaFlag.HasVideoOnly);

            short i_type = 0;
            if (Int16.TryParse(this.type, out i_type))
                p_Type = (WeiboType)i_type;
            else
                p_Type = WeiboType.Original;
        }

        /// <summary>
        /// Expand the info from the references of weibo.
        ///     For some things, get the Image object from image url, convert the timestamp to DateTime object, etc.
        /// </summary>
        public async Task ExpandInfoEx()
        {
            if (!String.IsNullOrEmpty(image))
            {
                await GenerateImageFromURL(image);
            }
            if (!String.IsNullOrEmpty(video))
            {
            }
        }

        #region DataTime and Timestamp
        public DateTime GetTime()
        {
            long timestamp = 0;
            MsgResult.AssertMsgConsole(Int64.TryParse(this.timestamp.Trim(), out timestamp), "Int64.TryParse() failed.");
            DateTime result = DateTime.MinValue;    // Set DateTime.MinValue as default value and mark it as invalid DataTime.
            if (timestamp > 0)
                result = PublicMem.GetDateTimeFromTimeStamp(timestamp);
            return result;
        }

        public static int IsMiddleTimestamp(WeiboInfo weibo1, WeiboInfo weibo2, long timestamp)
        {
            long ts1 = 0, ts2 = 0;
            Int64.TryParse(weibo1.timestamp, out ts1);
            Int64.TryParse(weibo2.timestamp, out ts2);

            bool fts = ts1 < ts2;
            long tsLarger = fts ? ts2 : ts1;
            long tsSmaller = fts ? ts1 : ts2;

            if (timestamp < tsSmaller)
                return -1;
            else if (timestamp > tsLarger)
                return 1;
            else
                return 0;
        }
        #endregion

        #region Image

        public bool HasImage()
        {
            return (this.p_MediaFlag & WeiboMediaFlag.HasImageOnly) != 0;
        }

        public bool HasVideo()
        {
            return (this.p_MediaFlag & WeiboMediaFlag.HasVideoOnly) != 0;
        }

        public async Task<Image> GetImage()
        {
            return await GenerateImageFromURL(GetImageURLs(WeiboImageSize.OriginalSize)[0]);
        }

        private static async Task<Image> GenerateImageFromURL(string imageURL)
        {
            Image resultImg = null;
            if (String.IsNullOrEmpty(imageURL))
                resultImg = null;

            Stream resultStream = (await WebStreamService.GetStreamFromURL(imageURL)).GetStream();
            if (resultStream != null)
            {
                resultImg = Image.FromStream(resultStream);
                resultStream.Close();
            }
            return resultImg;
        }

        /// <summary>
        /// Get the image URLs with the same specified size as a string array.
        /// 
        /// A Weibo object should have ONLY ONE image ( or a image array).
        /// </summary>
        /// <param name="imageSize">The image size</param>
        /// <returns>The image URL</returns>
        public string[] GetImageURLs(WeiboImageSize imageSize)
        {
            string imgURLString = "";

            string imgURL1 = this.image;
            string imgURL2 = (this.subWeibo != null) ? this.subWeibo.image : "";

            if ((!String.IsNullOrEmpty(imgURL1)) && (!String.IsNullOrEmpty(imgURL2)))
                goto LError;

            if (!String.IsNullOrEmpty(imgURL1))
            {
                imgURLString = imgURL1;
                goto LSuccess;
            }
            else if (!String.IsNullOrEmpty(imgURL2))
            {
                imgURLString = imgURL2;
                goto LSuccess;
            }
            else
            {
                if (HasImage())
                {
                    // This should NOT be happened!

                    p_MediaFlag &= ~(WeiboMediaFlag.HasImageOnly); // Really? Should we need fix the media flag here?

                    goto LError;
                }
                else
                    goto LSuccess;
            }

        LError:
            MsgResult.DebugMsgBox("Impossible case! Invalid image URL, please check it!");
            imgURLString = "";
            // Fall through!

        LSuccess:

            // Append the size at the end of image URL.
            if ((!String.IsNullOrEmpty(imgURLString))/* && imgURLString.StartsWith("http")*/)
            {
                string[] URLs = imgURLString.Split(new string[] { XMLParser.g_URLSeparator }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < URLs.Length; i++)
                {
                    //URLs[i] += "/" + ((int)imageSize).ToString();
                    URLs[i] = AppendImageSize(URLs[i], imageSize);
                }

                return URLs;
            }
            return null;
        }

        public static string AppendImageSize(string imgURL, WeiboImageSize imageSize)
        {
            return imgURL += "/" + ((int)imageSize).ToString();
        }

        #endregion
    }
}
