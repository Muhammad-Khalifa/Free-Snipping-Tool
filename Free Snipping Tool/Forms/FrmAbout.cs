using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


public partial class FrmAbout : Form
{
    public FrmAbout()
    {
        InitializeComponent();
        this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        PicIcon.Image = this.Icon.ToBitmap();

        LblProductName.Text = "Suar Tool";

        LblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
    }

    private void BtnOk_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            System.Diagnostics.Process.Start(LblLink.Text);
        }
        catch
        {
        }
    }
}
