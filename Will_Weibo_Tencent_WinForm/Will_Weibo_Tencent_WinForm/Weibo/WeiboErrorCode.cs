
using System.Xml;
using System.IO;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{

    public class WeiboErrorCode : ErrorCode
    {
        public WeiboErrorCode(int ret, int errcode, string msg, string seqid)
            : base(ret, errcode, msg, seqid)
        {
        }

        public new string GetErrorString()
        {
            string result = "";
            if (FSuccess())
                result = "";
            else
            {
                result += ExpandInfo();
                PublicMem.NewLine(ref result);
                result += "msg: " + this.msg;
                PublicMem.NewLine(ref result);
                result += "seqid: " + this.seqid;
            }
            return result;
        }

        /// <summary>
        /// Return the corresponding descriptions of current ErrorCode object.
        /// </summary>
        /// <returns></returns>
        private string ExpandInfo()
        {
            string resultString = "";

            string errCodeFilePath = "../../Resources/ReturnValue.xml";
            if (!File.Exists(errCodeFilePath))
            {
                MsgResult.WriteLine("File ", errCodeFilePath, " not found");
                return "";
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(errCodeFilePath);
            XmlNode root = xmlDoc.SelectSingleNode("root");

            bool foundRet = false, foundErrcode = false;

            XmlNodeList retNodes = root.SelectNodes("ret");
            foreach (XmlNode retNode in retNodes)
            {
                XmlAttributeCollection retAttributes = retNode.Attributes;
                MsgResult.AssertMsg(retAttributes.Count == 2, "node ret should have only two attributes.");

                foreach (XmlAttribute item in retNode.Attributes)
                {
                    string attName = item.Name.ToLower();
                    if (foundRet && attName == "description")
                    {
                        resultString += "\t description: " + item.Value;
                        break;
                    }

                    if (attName == "value" && this.ret.ToString() == item.Value)
                    {
                        foundRet = true;
                        resultString += "ret: " + item.Value;
                        continue;
                    }
                    else
                        break;
                }

                if (foundRet)
                {

                    XmlNodeList errcodeList = retNode.SelectNodes("errcode");

                    foreach (XmlNode errocodeNode in errcodeList)
                    {
                        XmlAttributeCollection errcodeAttrs = errocodeNode.Attributes;
                        MsgResult.AssertMsg(retAttributes.Count == 2, "node errcode should have only two attributes.");

                        foreach (XmlAttribute item in errcodeAttrs)
                        {
                            string attName = item.Name.ToLower();
                            if (foundErrcode && attName == "description")
                            {
                                resultString += "\t description: " + item.Value;
                                break;
                            }
                            if (attName == "value" && this.errorcode.ToString() == item.Value)
                            {
                                foundErrcode = true;
                                PublicMem.NewLine(ref resultString);
                                resultString += "errcode: " + item.Value;
                                continue;
                            }
                        }
                        if (foundErrcode)
                            break;
                    }
                } // if (foundRet)

                if (foundRet && foundErrcode)
                    break;   // Wow! We did it!

            } // foreach (XmlNode retNode in retNodes)

            if (!foundRet)
                resultString += "Didn't found ret description. ret: " + this.ret.ToString();
            if (!foundErrcode)
            {
                PublicMem.NewLine(ref resultString);
                resultString += "errcode: " + this.errorcode.ToString() + ". Didn't found this errcode description.";
                resultString += " Please go to site open.t.qq.com to get the detailed info.";
                PublicMem.NewLine(ref resultString);
            }

            return resultString;
        }
    }
}
