using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSnippingTool
{
    public partial class FrmTray : Form
    {
        public static Options options = new Options();
        public FrmTray()
        {
            LoadSettings();

            ChangeCulture(options.lang);

            InitializeComponent();
            notifyIcon1.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            ApplySettings();
        }

        void LoadSettings()
        {
            if (!Settings.ReadSettings(options))
            {
                options.closeafterclipboard = true;
                options.copylinkafterupload = true;
                options.hotkey = "PrintScreen";
                options.modifierhotkey = "Control";
                options.lang = "en";
                Settings.SaveSettings(options);
            }
        }

        void ApplySettings()
        {
            Shortcuts.RemoveHotKey(this.Handle);

            Shortcuts.ApplyHotKey(this.Handle, options.hotkey, options.modifierhotkey);

            notifyIcon1.Text = string.Format(FreeSnippingTool.CommonStrings.TrayIconToolTip, options.modifierhotkey.ToString(), options.hotkey.ToString());
        }

        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {

                case Shortcuts.WM_HOTKEY:
                    switch ((short)msg.WParam)
                    {
                        case Shortcuts.HOTKEY_ID:
                            {
                                MenuTakeScreenshot.PerformClick();
                            }
                            break;

                        default:
                            break;
                    }

                    break;

            }
            base.WndProc(ref msg);
        }


        private void ChangeCulture(string culture)
        {
            CultureInfo _culture = new CultureInfo(culture);

            Thread.CurrentThread.CurrentCulture = _culture;
            Thread.CurrentThread.CurrentUICulture = _culture;

            CultureInfo.DefaultThreadCurrentCulture = _culture;
            CultureInfo.DefaultThreadCurrentUICulture = _culture;
        }

        private void FrmTray_Load(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuTakeScreenshot_Click(object sender, EventArgs e)
        {
            FrmMain frmain = new FrmMain();
            frmain.ShowDialog();
        }

        private void FrmTray_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void MenuOptions_Click(object sender, EventArgs e)
        {
            FrmOptions frmopt = new FrmOptions();
            frmopt.ShowDialog();
            LoadSettings();
        }

        private void FrmTray_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void MenuCheckForUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdate.CheckUpdate();
        }
    }
}
