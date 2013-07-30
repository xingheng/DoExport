
#if DEBUG
//#define DEBUG_SPECIFIED_WINDOW    // ONLY FOR DEBUGGING
#endif

using System;
using System.Windows.Forms;
using UTILITIES_HAN;

namespace Will_Weibo_Tencent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MsgResult.AllocSingleConsole();

#if DEBUG_SPECIFIED_WINDOW
            //Application.Run(new FrmMain());
            //Application.Run(new FrmRequestSelect());
            Application.Run(new FrmExport(TimelineKind.MyFavouriteWeibo));
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form frm = null;
            FrmEntry entry = new FrmEntry();
            Application.Run(entry);

            if ((entry.entryOption & LoginEntryOption.AnyEntry) != 0)
            {
                FrmAuthorization autho = new FrmAuthorization();
                Application.Run(autho);

                if (!autho.FAuthorize)
                    goto LError;
            }
            else
                goto LError;

            switch (entry.entryOption)
            {
                case LoginEntryOption.CommonUserEntry:
                    frm = new FrmRequestSelect();
                    break;
                case LoginEntryOption.DeveloperEntry:
                    frm = new FrmMain();
                    break;
                case LoginEntryOption.None:
                    goto LError;
            }

            if (frm != null)
            {
                Application.Run(frm);
            }

        LError:
#endif // DEBUG_SPECIFIED_WINDOW

            MsgResult.FreeSingleConsole();
        }
    }
}
