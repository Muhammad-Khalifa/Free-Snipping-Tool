using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeSnippingTool
{
    public partial class FrmOptions : Form
    {
        Options opt = new Options();
        public FrmOptions()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);



            FillKeys();

            Settings.ReadSettings(opt);

            ChkCloseAfterSaveClipboard.Checked = opt.closeafterclipboard;
            ChkCopyLinkAfterUpload.Checked = opt.copylinkafterupload;
            CmbModifiers.Text = opt.modifierhotkey;
            CmbKeys.Text = opt.hotkey;

            if (opt.lang == "ar")
            {
                CmbLang.SelectedIndex = 1;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            opt.closeafterclipboard = ChkCloseAfterSaveClipboard.Checked;
            opt.copylinkafterupload = ChkCopyLinkAfterUpload.Checked;
            opt.modifierhotkey = CmbModifiers.Text;
            opt.hotkey = CmbKeys.Text;



            if (CmbLang.SelectedIndex == 0)
                opt.lang = "en";
            else
                opt.lang = "ar";

            Settings.SaveSettings(opt);
            MessageBox.Show(FreeSnippingTool.CommonStrings.ApplyNewOptions, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        void FillKeys()
        {
            CmbModifiers.Items.AddRange(Shortcuts.Modifiers);
            CmbKeys.Items.AddRange(Shortcuts.keys);
            CmbModifiers.SelectedIndex = 2;
            CmbKeys.SelectedIndex = 0;
            CmbLang.SelectedIndex = 0;
        }
    }
}
