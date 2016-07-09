namespace FreeSnippingTool
{
    partial class FrmTray
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTray));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuTakeScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.TrayMenu;
            // 
            // TrayMenu
            // 
            resources.ApplyResources(this.TrayMenu, "TrayMenu");
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTakeScreenshot,
            this.MenuOptions,
            this.toolStripSeparator2,
            this.MenuCheckForUpdate,
            this.MenuAbout,
            this.toolStripSeparator1,
            this.MenuExit});
            this.TrayMenu.Name = "TrayMenu";
            // 
            // MenuTakeScreenshot
            // 
            resources.ApplyResources(this.MenuTakeScreenshot, "MenuTakeScreenshot");
            this.MenuTakeScreenshot.Name = "MenuTakeScreenshot";
            this.MenuTakeScreenshot.Click += new System.EventHandler(this.MenuTakeScreenshot_Click);
            // 
            // MenuOptions
            // 
            resources.ApplyResources(this.MenuOptions, "MenuOptions");
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Click += new System.EventHandler(this.MenuOptions_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // MenuCheckForUpdate
            // 
            resources.ApplyResources(this.MenuCheckForUpdate, "MenuCheckForUpdate");
            this.MenuCheckForUpdate.Name = "MenuCheckForUpdate";
            this.MenuCheckForUpdate.Click += new System.EventHandler(this.MenuCheckForUpdate_Click);
            // 
            // MenuAbout
            // 
            resources.ApplyResources(this.MenuAbout, "MenuAbout");
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // MenuExit
            // 
            resources.ApplyResources(this.MenuExit, "MenuExit");
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // FrmTray
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTray_FormClosing);
            this.Load += new System.EventHandler(this.FrmTray_Load);
            this.Shown += new System.EventHandler(this.FrmTray_Shown);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuTakeScreenshot;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuCheckForUpdate;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}