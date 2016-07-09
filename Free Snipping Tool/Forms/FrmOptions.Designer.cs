namespace FreeSnippingTool
{
    partial class FrmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.TabOptions = new System.Windows.Forms.TabControl();
            this.PagDefaultNote = new System.Windows.Forms.TabPage();
            this.LblLanguage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CmbLang = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ChkCopyLinkAfterUpload = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.ChkCloseAfterSaveClipboard = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.PageShortCut = new System.Windows.Forms.TabPage();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CmbKeys = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.CmbModifiers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.BtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TabOptions.SuspendLayout();
            this.PagDefaultNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbLang)).BeginInit();
            this.PageShortCut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbModifiers)).BeginInit();
            this.SuspendLayout();
            // 
            // TabOptions
            // 
            resources.ApplyResources(this.TabOptions, "TabOptions");
            this.TabOptions.Controls.Add(this.PagDefaultNote);
            this.TabOptions.Controls.Add(this.PageShortCut);
            this.TabOptions.Name = "TabOptions";
            this.TabOptions.SelectedIndex = 0;
            // 
            // PagDefaultNote
            // 
            resources.ApplyResources(this.PagDefaultNote, "PagDefaultNote");
            this.PagDefaultNote.BackColor = System.Drawing.SystemColors.Control;
            this.PagDefaultNote.Controls.Add(this.LblLanguage);
            this.PagDefaultNote.Controls.Add(this.CmbLang);
            this.PagDefaultNote.Controls.Add(this.ChkCopyLinkAfterUpload);
            this.PagDefaultNote.Controls.Add(this.ChkCloseAfterSaveClipboard);
            this.PagDefaultNote.Name = "PagDefaultNote";
            // 
            // LblLanguage
            // 
            resources.ApplyResources(this.LblLanguage, "LblLanguage");
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Values.ExtraText = resources.GetString("LblLanguage.Values.ExtraText");
            this.LblLanguage.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("LblLanguage.Values.ImageTransparentColor")));
            this.LblLanguage.Values.Text = resources.GetString("LblLanguage.Values.Text");
            // 
            // CmbLang
            // 
            resources.ApplyResources(this.CmbLang, "CmbLang");
            this.CmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLang.DropDownWidth = 191;
            this.CmbLang.Items.AddRange(new object[] {
            resources.GetString("CmbLang.Items"),
            resources.GetString("CmbLang.Items1")});
            this.CmbLang.Name = "CmbLang";
            // 
            // ChkCopyLinkAfterUpload
            // 
            resources.ApplyResources(this.ChkCopyLinkAfterUpload, "ChkCopyLinkAfterUpload");
            this.ChkCopyLinkAfterUpload.Name = "ChkCopyLinkAfterUpload";
            this.ChkCopyLinkAfterUpload.Values.ExtraText = resources.GetString("ChkCopyLinkAfterUpload.Values.ExtraText");
            this.ChkCopyLinkAfterUpload.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("ChkCopyLinkAfterUpload.Values.ImageTransparentColor")));
            this.ChkCopyLinkAfterUpload.Values.Text = resources.GetString("ChkCopyLinkAfterUpload.Values.Text");
            // 
            // ChkCloseAfterSaveClipboard
            // 
            resources.ApplyResources(this.ChkCloseAfterSaveClipboard, "ChkCloseAfterSaveClipboard");
            this.ChkCloseAfterSaveClipboard.Name = "ChkCloseAfterSaveClipboard";
            this.ChkCloseAfterSaveClipboard.Values.ExtraText = resources.GetString("ChkCloseAfterSaveClipboard.Values.ExtraText");
            this.ChkCloseAfterSaveClipboard.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("ChkCloseAfterSaveClipboard.Values.ImageTransparentColor")));
            this.ChkCloseAfterSaveClipboard.Values.Text = resources.GetString("ChkCloseAfterSaveClipboard.Values.Text");
            // 
            // PageShortCut
            // 
            resources.ApplyResources(this.PageShortCut, "PageShortCut");
            this.PageShortCut.BackColor = System.Drawing.SystemColors.Control;
            this.PageShortCut.Controls.Add(this.kryptonLabel1);
            this.PageShortCut.Controls.Add(this.CmbKeys);
            this.PageShortCut.Controls.Add(this.CmbModifiers);
            this.PageShortCut.Name = "PageShortCut";
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Values.ExtraText = resources.GetString("kryptonLabel1.Values.ExtraText");
            this.kryptonLabel1.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("kryptonLabel1.Values.ImageTransparentColor")));
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // CmbKeys
            // 
            resources.ApplyResources(this.CmbKeys, "CmbKeys");
            this.CmbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKeys.DropDownWidth = 121;
            this.CmbKeys.Name = "CmbKeys";
            // 
            // CmbModifiers
            // 
            resources.ApplyResources(this.CmbModifiers, "CmbModifiers");
            this.CmbModifiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModifiers.DropDownWidth = 121;
            this.CmbModifiers.Name = "CmbModifiers";
            // 
            // BtnOk
            // 
            resources.ApplyResources(this.BtnOk, "BtnOk");
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Values.ExtraText = resources.GetString("BtnOk.Values.ExtraText");
            this.BtnOk.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("BtnOk.Values.ImageTransparentColor")));
            this.BtnOk.Values.Text = resources.GetString("BtnOk.Values.Text");
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmOptions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabOptions);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.TabOptions.ResumeLayout(false);
            this.PagDefaultNote.ResumeLayout(false);
            this.PagDefaultNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbLang)).EndInit();
            this.PageShortCut.ResumeLayout(false);
            this.PageShortCut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbModifiers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabOptions;
        private System.Windows.Forms.TabPage PagDefaultNote;
        private System.Windows.Forms.TabPage PageShortCut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbKeys;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbModifiers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ChkCopyLinkAfterUpload;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ChkCloseAfterSaveClipboard;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LblLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbLang;
    }
}