
namespace Will_Weibo_Tencent
{
    public static class SharedMem
    {
        private static readonly string appkey = "6a99d5a16d1d463c965212c40cc74525";
        public static string AppKey
        {
            get { return appkey; }
        }
        public static readonly string appSecret = "****";
        public static string openID = "";
        public static string openkey = "";
        public static string accessToken = "";
        public static string refreshToken = "";

        public static string redirectURL = "http://xinghenghan.blog.163.com";

        private static readonly string appName = "Weibo Export Tool";
        public static string AppName
        {
            get { return appName; }
        }
    }
}
