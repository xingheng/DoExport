using System;
using System.Net;

namespace UTILITIES_HAN
{
    public class PublicMem
    {
        /// <summary>
        /// Get the local IP address as a string value.
        ///     (1) Compatible with IPv4 and IPv6.
        ///     (2) Return "127.0.0.1" if failed.
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            string ipAddress = "127.0.0.1";
            try
            {
                IPAddress[] ipList = Dns.GetHostAddresses(Dns.GetHostName());
                if (ipList != null && ipList.Length > 0)
                {
                    try
                    {
                        IPAddress ipv4 = ipList[0].MapToIPv4();
                        if (ipv4 != null)
                        {
                            ipAddress = ipv4.ToString();
                            goto LEnd;
                        }
                    }
                    catch (Exception ex)
                    {
                        //MsgResult.DebugMsgBox("Get local IPv4 address failed. Exception: " + ex.ToString());
                        ex.ToString(); // placeholder.
                    }

                    try
                    {
                        IPAddress ipv6 = ipList[0].MapToIPv6();
                        if (ipv6 != null)
                        {
                            ipAddress = ipv6.ToString();
                            goto LEnd;
                        }
                    }
                    catch (Exception ex)
                    {
                        MsgResult.DebugMsgBox("Get local IPv6 address failed. Exception: " + ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MsgResult.DebugMsgBox("Get local IP address failed. Exception: " + ex.ToString());
            }

        LEnd:
            return ipAddress;
        }

        public static DateTime GetDateTimeFromTimeStamp(long timestamp)
        {
            DateTime offSetDate = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime result = offSetDate.AddSeconds(timestamp).ToLocalTime();
            return result;
        }

        public static long GetTimeStampFromDateTime(DateTime dTime)
        {
            DateTime offSetDate = new DateTime(1970, 1, 1, 0, 0, 0);
            TimeSpan tSpan = dTime - offSetDate;

            return (long)tSpan.TotalSeconds;
        }

        public static void NewLine(ref string strValue)
        {
            strValue += "\r\n";
        }
    }
}
