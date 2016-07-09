using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSnippingTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool res = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "SuarTool", out res);
            if (res)
            {
                CultureInfo cu = new CultureInfo("ar");

                Thread.CurrentThread.CurrentCulture = cu;
                Thread.CurrentThread.CurrentUICulture = cu;

                CultureInfo.DefaultThreadCurrentCulture = cu;
                CultureInfo.DefaultThreadCurrentUICulture = cu;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmTray());
            }
        }
    }
}
