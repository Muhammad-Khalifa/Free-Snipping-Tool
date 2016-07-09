
partial class FrmAbout
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
            this.LblLine = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            this.LblCopyRight = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLine
            // 
            this.LblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblLine.Location = new System.Drawing.Point(13, 118);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(250, 3);
            this.LblLine.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(101, 187);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(69, 134);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(139, 13);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "Visit my page for more info:";
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(83, 152);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(111, 13);
            this.LblLink.TabIndex = 3;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "www.smart-arab.com";
            this.LblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLink_LinkClicked);
            // 
            // PicIcon
            // 
            this.PicIcon.Location = new System.Drawing.Point(15, 21);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(48, 48);
            this.PicIcon.TabIndex = 4;
            this.PicIcon.TabStop = false;
            // 
            // LblCopyRight
            // 
            this.LblCopyRight.AutoSize = true;
            this.LblCopyRight.Location = new System.Drawing.Point(69, 90);
            this.LblCopyRight.Name = "LblCopyRight";
            this.LblCopyRight.Size = new System.Drawing.Size(138, 13);
            this.LblCopyRight.TabIndex = 5;
            this.LblCopyRight.Text = "2009-2016 Smart Arab Inc.";
            // 
            // LblProductName
            // 
            this.LblProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(72, 16);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(189, 25);
            this.LblProductName.TabIndex = 6;
            this.LblProductName.Text = "Product Name";
            this.LblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblVersion
            // 
            this.LblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(76, 50);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(185, 13);
            this.LblVersion.TabIndex = 5;
            this.LblVersion.Text = "Version 1.7.1";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 217);
            this.Controls.Add(this.LblProductName);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblCopyRight);
            this.Controls.Add(this.PicIcon);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblLine;
    private System.Windows.Forms.Button BtnOk;
    private System.Windows.Forms.Label LblInfo;
    private System.Windows.Forms.LinkLabel LblLink;
    private System.Windows.Forms.PictureBox PicIcon;
    private System.Windows.Forms.Label LblCopyRight;
    private System.Windows.Forms.Label LblProductName;
    private System.Windows.Forms.Label LblVersion;
}
