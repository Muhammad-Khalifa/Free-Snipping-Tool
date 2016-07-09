namespace FreeSnippingTool
{
    partial class FrmUploader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUploader));
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtUpload = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnCopy = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.LblImgUrl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.colorFadeBusyBar1 = new System.Windows.Forms.BusyBar.ColorFadeBusyBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Values.ExtraText = resources.GetString("BtnCancel.Values.ExtraText");
            this.BtnCancel.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("BtnCancel.Values.ImageTransparentColor")));
            this.BtnCancel.Values.Text = resources.GetString("BtnCancel.Values.Text");
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtUpload
            // 
            resources.ApplyResources(this.TxtUpload, "TxtUpload");
            this.TxtUpload.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BtnCopy});
            this.TxtUpload.Name = "TxtUpload";
            this.TxtUpload.ReadOnly = true;
            // 
            // BtnCopy
            // 
            resources.ApplyResources(this.BtnCopy, "BtnCopy");
            this.BtnCopy.Image = global::FreeSnippingTool.Properties.Resources.Copy;
            this.BtnCopy.UniqueName = "ACC70CA0A1B94B407390C980B72BC03E";
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // LblImgUrl
            // 
            resources.ApplyResources(this.LblImgUrl, "LblImgUrl");
            this.LblImgUrl.Name = "LblImgUrl";
            this.LblImgUrl.Values.ExtraText = resources.GetString("LblImgUrl.Values.ExtraText");
            this.LblImgUrl.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("LblImgUrl.Values.ImageTransparentColor")));
            this.LblImgUrl.Values.Text = resources.GetString("LblImgUrl.Values.Text");
            // 
            // colorFadeBusyBar1
            // 
            resources.ApplyResources(this.colorFadeBusyBar1, "colorFadeBusyBar1");
            this.colorFadeBusyBar1.BackColor = System.Drawing.Color.White;
            this.colorFadeBusyBar1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Adjust;
            this.colorFadeBusyBar1.Color2 = System.Drawing.Color.White;
            this.colorFadeBusyBar1.FadeLength = -1;
            this.colorFadeBusyBar1.ForeColor = System.Drawing.Color.Gray;
            this.colorFadeBusyBar1.Name = "colorFadeBusyBar1";
            this.colorFadeBusyBar1.PingPong = true;
            this.colorFadeBusyBar1.ShowBorder = false;
            this.colorFadeBusyBar1.StepSize = 5;
            this.colorFadeBusyBar1.StepTimeout = 50;
            this.colorFadeBusyBar1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmUploader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorFadeBusyBar1);
            this.Controls.Add(this.TxtUpload);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblImgUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUploader";
            this.Load += new System.EventHandler(this.FrmUploader_Load);
            this.Shown += new System.EventHandler(this.FrmUploader_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtUpload;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BtnCopy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LblImgUrl;
        private System.Windows.Forms.BusyBar.ColorFadeBusyBar colorFadeBusyBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}