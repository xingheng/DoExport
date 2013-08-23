
#if DEBUG
//#define DEBUG_SPECIFIED_WINDOW    // ONLY FOR DEBUGGING
#endif

using System;
using System.Windows.Forms;
using UTILITIES_HAN;

namespace DoExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }


    public class Form : System.Windows.Forms.Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LocalizationForRunTime();   // Localization for ctl should happen after finishing init all the ctrls.
        }

        virtual protected void LocalizationForRunTime() { }
    }
}
