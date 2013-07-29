
namespace UTILITIES_HAN
{
    /// <summary>
    /// Error code set
    /// </summary>
    public abstract/*Dont allow the user to use this class directly in this project, at least*/ 
        class ErrorCode
    {
        private int m_ret;          // Return value.  0 if succeed, otherwise, ~0
        private int m_errorcode;    // Error code.
        private string m_msg;       // Error message.
        private string m_seqid;     // Serial number.

        // Reserved members. Optional
        public object reserved1;
        public object reserved2;
        public object reserved3;
        public object reserved4;

        public ErrorCode(int ret, int errorcode, string msg, string seqid)
        {
            m_ret = ret;
            m_errorcode = errorcode;
            m_msg = msg;
            m_seqid = seqid;

            reserved1 = reserved2 = reserved3 = reserved4 = null;
        }

        #region ReadOnly Properties.
        public int ret
        {
            get { return m_ret; }
        }

        public int errorcode
        {
            get { return m_errorcode; }
        }

        public string msg
        {
            get { return m_msg; }
        }

        public string seqid
        {
            get { return m_seqid; }
        }
        #endregion

        public string GetErrorString()
        {
            string result = "";
            if (FSuccess())
                result = "";
            else
            {
                result += "ret: " + m_ret.ToString();
                PublicMem.NewLine(ref result);
                result += "errorcode: " + m_errorcode.ToString();
                PublicMem.NewLine(ref result);
                result += "msg: " + m_msg;
                PublicMem.NewLine(ref result);
                result += "seqid: " + m_seqid;
            }
            return result;
        }

        public bool FSuccess()
        {
            return m_ret == 0;
        }

    }
}
