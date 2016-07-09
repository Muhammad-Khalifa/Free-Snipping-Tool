namespace FreeSnippingTool
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.BtnCropRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRect = new System.Windows.Forms.ToolStripButton();
            this.BtnArrow = new System.Windows.Forms.ToolStripButton();
            this.BtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnColor = new System.Windows.Forms.ToolStripButton();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClipBoard = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.BtnUpload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.ContextColorMenu = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.ContextMenuSelectColor = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuColorColumns();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.ContextMenutMoreColor = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonBreadCrumbItem1 = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem();
            this.kryptonBreadCrumbItem2 = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem();
            this.kryptonBreadCrumbItem3 = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.MainToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolBar
            // 
            resources.ApplyResources(this.MainToolBar, "MainToolBar");
            this.MainToolBar.BackColor = System.Drawing.Color.Silver;
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCropRect,
            this.toolStripSeparator2,
            this.BtnRect,
            this.BtnArrow,
            this.BtnLine,
            this.toolStripSeparator3,
            this.BtnColor,
            this.BtnUndo,
            this.toolStripSeparator1,
            this.BtnClipBoard,
            this.BtnSaveToFile,
            this.BtnUpload,
            this.toolStripSeparator4,
            this.BtnClose});
            this.MainToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MainToolBar.Name = "MainToolBar";
            // 
            // BtnCropRect
            // 
            resources.ApplyResources(this.BtnCropRect, "BtnCropRect");
            this.BtnCropRect.CheckOnClick = true;
            this.BtnCropRect.Image = global::FreeSnippingTool.Properties.Resources.croprect;
            this.BtnCropRect.Name = "BtnCropRect";
            this.BtnCropRect.Click += new System.EventHandler(this.BtnCropRect_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // BtnRect
            // 
            resources.ApplyResources(this.BtnRect, "BtnRect");
            this.BtnRect.CheckOnClick = true;
            this.BtnRect.Image = global::FreeSnippingTool.Properties.Resources.rect;
            this.BtnRect.Name = "BtnRect";
            this.BtnRect.Click += new System.EventHandler(this.BtnRect_Click);
            // 
            // BtnArrow
            // 
            resources.ApplyResources(this.BtnArrow, "BtnArrow");
            this.BtnArrow.CheckOnClick = true;
            this.BtnArrow.Image = global::FreeSnippingTool.Properties.Resources.Arrow;
            this.BtnArrow.Name = "BtnArrow";
            this.BtnArrow.Click += new System.EventHandler(this.BtnArrow_Click);
            // 
            // BtnLine
            // 
            resources.ApplyResources(this.BtnLine, "BtnLine");
            this.BtnLine.CheckOnClick = true;
            this.BtnLine.Image = global::FreeSnippingTool.Properties.Resources.line;
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // BtnColor
            // 
            resources.ApplyResources(this.BtnColor, "BtnColor");
            this.BtnColor.Image = global::FreeSnippingTool.Properties.Resources.Color;
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnUndo
            // 
            resources.ApplyResources(this.BtnUndo, "BtnUndo");
            this.BtnUndo.Image = global::FreeSnippingTool.Properties.Resources.undo;
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // BtnClipBoard
            // 
            resources.ApplyResources(this.BtnClipBoard, "BtnClipBoard");
            this.BtnClipBoard.Image = global::FreeSnippingTool.Properties.Resources.Copy;
            this.BtnClipBoard.Name = "BtnClipBoard";
            this.BtnClipBoard.Click += new System.EventHandler(this.BtnClipBoard_Click);
            // 
            // BtnSaveToFile
            // 
            resources.ApplyResources(this.BtnSaveToFile, "BtnSaveToFile");
            this.BtnSaveToFile.Image = global::FreeSnippingTool.Properties.Resources.Save;
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // BtnUpload
            // 
            resources.ApplyResources(this.BtnUpload, "BtnUpload");
            this.BtnUpload.Image = global::FreeSnippingTool.Properties.Resources.upload;
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.Image = global::FreeSnippingTool.Properties.Resources.exit;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ContextColorMenu
            // 
            this.ContextColorMenu.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.ContextMenuSelectColor,
            this.kryptonContextMenuItems1});
            // 
            // ContextMenuSelectColor
            // 
            this.ContextMenuSelectColor.SelectedColor = System.Drawing.Color.Red;
            this.ContextMenuSelectColor.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.ContextMenuSelectColor_SelectedColorChanged);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.ContextMenutMoreColor});
            // 
            // ContextMenutMoreColor
            // 
            resources.ApplyResources(this.ContextMenutMoreColor, "ContextMenutMoreColor");
            this.ContextMenutMoreColor.Click += new System.EventHandler(this.ContextMenutMoreColor_Click);
            // 
            // kryptonContextMenuHeading1
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading1, "kryptonContextMenuHeading1");
            // 
            // kryptonContextMenuHeading2
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading2, "kryptonContextMenuHeading2");
            // 
            // kryptonBreadCrumbItem1
            // 
            this.kryptonBreadCrumbItem1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem[] {
            this.kryptonBreadCrumbItem2,
            this.kryptonBreadCrumbItem3});
            resources.ApplyResources(this.kryptonBreadCrumbItem1, "kryptonBreadCrumbItem1");
            // 
            // kryptonBreadCrumbItem2
            // 
            resources.ApplyResources(this.kryptonBreadCrumbItem2, "kryptonBreadCrumbItem2");
            // 
            // kryptonBreadCrumbItem3
            // 
            resources.ApplyResources(this.kryptonBreadCrumbItem3, "kryptonBreadCrumbItem3");
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalApplyToolstrips = false;
            this.kryptonManager1.GlobalStrings.Abort = resources.GetString("kryptonManager1.GlobalStrings.Abort");
            this.kryptonManager1.GlobalStrings.Cancel = resources.GetString("kryptonManager1.GlobalStrings.Cancel");
            this.kryptonManager1.GlobalStrings.Close = resources.GetString("kryptonManager1.GlobalStrings.Close");
            this.kryptonManager1.GlobalStrings.Ignore = resources.GetString("kryptonManager1.GlobalStrings.Ignore");
            this.kryptonManager1.GlobalStrings.No = resources.GetString("kryptonManager1.GlobalStrings.No");
            this.kryptonManager1.GlobalStrings.OK = resources.GetString("kryptonManager1.GlobalStrings.OK");
            this.kryptonManager1.GlobalStrings.Retry = resources.GetString("kryptonManager1.GlobalStrings.Retry");
            this.kryptonManager1.GlobalStrings.Today = resources.GetString("kryptonManager1.GlobalStrings.Today");
            this.kryptonManager1.GlobalStrings.Yes = resources.GetString("kryptonManager1.GlobalStrings.Yes");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.MainToolBar.ResumeLayout(false);
            this.MainToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.ToolStripButton BtnCropRect;
        private System.Windows.Forms.ToolStripButton BtnLine;
        private System.Windows.Forms.ToolStripButton BtnArrow;
        private System.Windows.Forms.ToolStripButton BtnRect;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu ContextColorMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuColorColumns ContextMenuSelectColor;
        private System.Windows.Forms.ToolStripButton BtnColor;
        private System.Windows.Forms.ToolStripButton BtnUndo;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem ContextMenutMoreColor;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private System.Windows.Forms.ToolStripButton BtnClipBoard;
        private System.Windows.Forms.ToolStripButton BtnSaveToFile;
        private ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem kryptonBreadCrumbItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem kryptonBreadCrumbItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem kryptonBreadCrumbItem3;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripButton BtnUpload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnClose;
    }
}

