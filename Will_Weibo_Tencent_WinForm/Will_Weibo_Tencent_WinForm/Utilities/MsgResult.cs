/*--------------------------------------------------------------------------------------------*/
#if DEBUG

#define     MESSAGEBOX_DEBUG
#define     CONSOLE_DEBUG

#endif
/*---------------------------------------------------------------------------------------------*/

using System;

using System.Windows.Forms;
using System.Runtime.InteropServices;   // For DllImport

namespace UTILITIES_HAN
{
    public class MsgResult
    {
#if CONSOLE_DEBUG
        static int m_CountConsole = 0; // Count of Console. We just need ONE console for debugging, so init a object to share for all requests.
#endif

        /// <summary>
        /// Launch the console.
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        /// <summary>
        /// Release the console.
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        public static void AllocSingleConsole()
        {
#if CONSOLE_DEBUG
            if (m_CountConsole > 0)
                return;

            AllocConsole();
            m_CountConsole++;
#endif
        }

        public static void FreeSingleConsole()
        {
#if CONSOLE_DEBUG
            if (m_CountConsole <= 0)
                return;

            FreeConsole();
            m_CountConsole--;
#endif
        }

        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream.
        /// Note: This function just appends the array args values with standard format (string) to result string.
        /// </summary>
        /// <param name="strFormat"></param>
        /// <param name="args"></param>
        public static void WriteLine(object format, params object[] args)
        {
#if CONSOLE_DEBUG
            string strArgs = "";
            foreach (var item in args)
                strArgs += item.ToString();

            Console.WriteLine(format.ToString() + strArgs);
#endif
        }


        public static void DebugMsgBox(string format)
        {
#if MESSAGEBOX_DEBUG
            MessageBox.Show(String.Format(format));
#endif
        }

        /// <summary>
        /// Displays a message box with specified text.
        /// Note: This function just appends the array args values with standard format (string) to result string.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="argArr"></param>
        public static void DebugMsgBox(object format, params object[] argArr)
        {
#if MESSAGEBOX_DEBUG
            string args = "";
            foreach (var item in argArr)
                args += item.ToString();

            MessageBox.Show(format.ToString() + args);
#endif 
        }

        /// <summary>
        /// Display a message box with specified text if assert failed.
        /// 
        /// Note: This function just appends the array args values with standard format (string) to result string.
        /// </summary>
        /// <param name="fRet">The assert statement</param>
        /// <param name="argsArr">The message value</param>
        public static void AssertMsg(bool fRet, params object[] argsArr)
        {
#if MESSAGEBOX_DEBUG
            string args = "";
            foreach (var item in argsArr)
                args += item.ToString();

            if (!fRet)
                MessageBox.Show(args);
#endif 
        }
    }
}
