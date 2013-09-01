using System;
using System.Xml;
using UTILITIES_HAN;

namespace DoExport
{
    class XMLParser
    {
        public static readonly string g_URLSeparator = " || ";

        //public static bool ParseInfoNodeString(string xmlString, out XmlNode dataNodeList/*out XmlNodeList infoNodeList*/)
        //{
        //    XmlDocument xmlDoc = new XmlDocument();
        //    xmlDoc.LoadXml(xmlString);

        //    XmlNode root = xmlDoc.SelectSingleNode("root");
        //    XmlNode data = root.SelectSingleNode("data");

        //    XmlNodeList nodeList = data.ChildNodes;
            
        //    int i= 0;
        //    object[] shouldRemovedNode = new object[nodeList.Count];
        //    foreach (XmlNode item in nodeList)
        //        if (item.Name.Trim().ToLower() != "info")
        //            shouldRemovedNode[i++] = item;

        //    foreach (XmlNode item in shouldRemovedNode)
        //        if (item != null)
        //            data.RemoveChild(item);

        //    //infoNodeList = data.ChildNodes;
        //    dataNodeList = data;

        //    return true;
        //}

        /// <summary>
        /// Parse the xml string to WeiboInfo array.
        /// 
        /// <remarks>(1) xmlString should contains the "root" node string. (2) The default start index is 0. (3) If the parsedLenth is 0, we will do it to an end.</remarks>
        /// </summary>
        /// <param name="xmlString">XML string to be parsed</param>
        /// <param name="startIndex">The start index, which "info" node we should begin to parse</param>
        /// <param name="weiboList">[OUT]The WeiboInfo list</param>
        /// <param name="parsedLength">The expected number of WeiboInfo object to be returned.</param>
        /// <param name="retValue">The error code of last request.</param>
        /// <returns>True if parse successfully</returns>
        public static bool ParseWeiboInfoList(string xmlString, int startIndex, out WeiboInfo[] weiboList, int parsedLength, out WeiboErrorCode retValue)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            XmlNode root = xmlDoc.SelectSingleNode("root");
            XmlNode data = root.SelectSingleNode("data");
            if (data != null)
            {
                XmlNodeList infoList = data.SelectNodes("info");

                int retLength = (parsedLength > 0) ? parsedLength : infoList.Count;
                weiboList = new WeiboInfo[retLength];
                int index = 0;  // for weiboList result array.
                int i = (startIndex > 0) ? startIndex : 0;  // for "info" node array.

                for( ; i < infoList.Count; i++)
                {
                    XmlNode info = infoList[i];
                    WeiboInfo weibo = CollectWeiboInfo(info);

                    weiboList[index++] = weibo;
                    if (index > retLength - 1)
                        break;
                }
            }
            else
            {
                MsgResult.WriteLine("no data return.");
                weiboList = null;
            }

            #region Initialization of retValue.
            int iret = 0, ierrcode = 0;
            string strRet = GetInnerTextFromSingleNode(root, "ret");
            if (!String.IsNullOrEmpty(strRet))
                iret = Convert.ToInt32(strRet);
            string strErrorcode = GetInnerTextFromSingleNode(root, "errcode");
            if (!String.IsNullOrEmpty(strErrorcode))
                ierrcode = Convert.ToInt32(strErrorcode);

            retValue = new WeiboErrorCode(iret, ierrcode,
                GetInnerTextFromSingleNode(root, "msg"),
                GetInnerTextFromSingleNode(root, "seqid"));

            string node1 = "hasnext", node2 = "totalnum", node3 = "timestamp";
            retValue.reserved1 = /*node1 + ": " + */GetInnerTextFromSingleNode(data, node1);
            retValue.reserved2 = /*node2 + ": " + */GetInnerTextFromSingleNode(data, node2);
            retValue.reserved3 = /*node3 + ": " + */GetInnerTextFromSingleNode(data, node3);

            #endregion

            return true;
        }

        /// <summary>
        /// Get InnerText string value from the specified XmlNode and node name.
        /// 
        /// We use this to avoid getting InnerText value from NULL object, or that will throw a exception.
        /// </summary>
        /// <param name="info">The root node to be retrieved.</param>
        /// <param name="nodeName">The name of sub-node to be retrieved.</param>
        /// <returns></returns>
        public static string GetInnerTextFromSingleNode(XmlNode info, string nodeName)
        {
            if (info != null)
            {
                XmlNode node = info.SelectSingleNode(nodeName);
                if (node != null)
                    return node.InnerText;
                else
                    goto Error;
            }
            else
                goto Error;
        Error:
            //MsgResult.WriteLine("Failed to get InnerText value from ", info.Name, ". Nodename: ", nodeName);
            return "";
        }

        #region Private members
        public static WeiboInfo CollectWeiboInfo(XmlNode info)
        {
            WeiboInfo weibo = new WeiboInfo();

            weibo.citycode = GetInnerTextFromSingleNode(info, "city_code");
            weibo.count = GetInnerTextFromSingleNode(info, "count");
            weibo.country_code = GetInnerTextFromSingleNode(info, "country_code");
            weibo.emotiontype = GetInnerTextFromSingleNode(info, "emotiontype");
            weibo.emotionurl = GetInnerTextFromSingleNode(info, "emotionurl");
            weibo.from = GetInnerTextFromSingleNode(info, "from");
            weibo.fromurl = GetInnerTextFromSingleNode(info, "fromurl");
            weibo.geo = GetInnerTextFromSingleNode(info, "geo");
            weibo.head = GetInnerTextFromSingleNode(info, "head");
            weibo.https_head = GetInnerTextFromSingleNode(info, "https_head");
            weibo.id = GetInnerTextFromSingleNode(info, "id");
            
            foreach (XmlNode imageNode in info.SelectNodes("image"))
            {
                if (imageNode != null && !String.IsNullOrEmpty(imageNode.InnerText))
                {
                    /* Sometimes the image node in returned xml data is just like this,
                     * <image><....><url></url></image>
                     */
                    XmlNode image_info_node = imageNode.SelectSingleNode("info");
                    if (image_info_node != null)
                        weibo.image = GetInnerTextFromSingleNode(image_info_node, "url");
                    else
                        weibo.image += g_URLSeparator + imageNode.InnerText;
                }
            }

            weibo.isrealname = GetInnerTextFromSingleNode(info, "isrealname");
            weibo.isvip = GetInnerTextFromSingleNode(info, "isvip");
            weibo.jing = GetInnerTextFromSingleNode(info, "jing");
            weibo.latitude = GetInnerTextFromSingleNode(info, "latitude");
            weibo.location = GetInnerTextFromSingleNode(info, "location");
            weibo.longitude = GetInnerTextFromSingleNode(info, "longitude");
            weibo.mcount = GetInnerTextFromSingleNode(info, "mcount");
            weibo.music = GetInnerTextFromSingleNode(info, "music");
            weibo.name = GetInnerTextFromSingleNode(info, "name");
            weibo.nick = GetInnerTextFromSingleNode(info, "nick");
            weibo.openid = GetInnerTextFromSingleNode(info, "openid");
            weibo.origtext = GetInnerTextFromSingleNode(info, "origtext");
            weibo.province_code = GetInnerTextFromSingleNode(info, "province_code");
            weibo.self = GetInnerTextFromSingleNode(info, "self");

            string strSourceKey = "source";
            string strSourceValue = GetInnerTextFromSingleNode(info, strSourceKey);
            if (String.IsNullOrEmpty(strSourceValue))
                weibo.source = "";
            else
            {
                XmlNode subSourceNode = info.SelectSingleNode(strSourceKey);
                weibo.subWeibo = CollectWeiboInfo(subSourceNode);   // Endless loop here? No!
                //  A WeiboInfo object could have only one original source, logically.

                weibo.source = "<" + strSourceKey + ">" + subSourceNode.InnerXml + "</" + strSourceKey + ">";
            }

            weibo.status = GetInnerTextFromSingleNode(info, "status");
            weibo.text = GetInnerTextFromSingleNode(info, "text");

            // timestamp or pubtime?
            weibo.timestamp = GetInnerTextFromSingleNode(info, "timestamp");
            if (String.IsNullOrEmpty(weibo.timestamp))
                weibo.timestamp = GetInnerTextFromSingleNode(info, "pubtime");

            weibo.type = GetInnerTextFromSingleNode(info, "type");

            // TODO
            weibo.video = GetInnerTextFromSingleNode(info.SelectSingleNode("video"), "picurl");

            weibo.wei = GetInnerTextFromSingleNode(info, "wei");

            if (info.Name.ToLower() == "info")
                weibo.str_XML_Info_Node = "<info>" + info.InnerXml + "</info>";
            else if (info.Name.ToLower() == "source")
                weibo.str_XML_Info_Node = "<source>" + info.InnerXml + "</source>";
            else
                MsgResult.DebugMsgBox("Unexpected value! info.Name: " + info.Name);

            // -----------------IMPORTANT-----------------
            // After generating a new weibo object, expand all the infos for it soon.
            weibo.ExpandInfo(); /* Disable it because this will create some new sub-threads to load weibo info. Temporarily!*/
            // -----------------IMPORTANT-----------------
            return weibo;
        }
        #endregion
    }
}
