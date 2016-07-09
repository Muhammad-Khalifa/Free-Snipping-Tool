using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace FreeSnippingTool
{
    public partial class FrmUploader : KryptonForm
    {
        Image img;

        public FrmUploader(Image img)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.img = img;
        }

        private void FrmUploader_Shown(object sender, EventArgs e)
        {
            Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            int left = workingArea.Width - this.Width;
            int top = workingArea.Height - this.Height;

            this.Location = new Point(left, top);
        }

        private void FrmUploader_Load(object sender, EventArgs e)
        {
            colorFadeBusyBar1.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtUpload.Text);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnCancel.Text = "Close";
            colorFadeBusyBar1.Visible = false;
            if(AssistOperation.IsUrl(TxtUpload.Text) && FrmTray.options.copylinkafterupload)
            {
                Clipboard.SetText(TxtUpload.Text);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorFadeBusyBar1.Visible)
                    backgroundWorker1.CancelAsync();

                this.Close();
            }
            catch
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            TxtUpload.Text = UploadToSuar.UploadImage(img);
        }
    }
}
