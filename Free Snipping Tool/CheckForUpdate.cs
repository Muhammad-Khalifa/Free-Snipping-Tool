using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CheckForUpdate
{
    private float version { get; set; }
    private string newurl { get; set; }

    private const string updateurl = "http://www.smart-arab.com/suartool/version.txt";

    public static void CheckUpdate()
    {
        try
        {
            WebClient wb = new WebClient();
            wb.DownloadStringCompleted += Wb_DownloadStringCompleted;
            wb.DownloadStringAsync(new Uri(updateurl));
        }
        catch
        {
            MessageBox.Show(FreeSnippingTool.CommonStrings.CanNotCheckForUpdate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private static void Wb_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
    {
        try
        {
            string[] res = e.Result.Split(';');

            string version = res[0];
            string newurl = res[1];

            float newversion = 0;
            float.TryParse(version, out newversion);

            float currentversion = 0;
            float.TryParse(Assembly.GetExecutingAssembly().GetName().Version.ToString(2), out currentversion);

            if (currentversion < newversion)
            {
                if (MessageBox.Show(string.Format(FreeSnippingTool.CommonStrings.FoundNewVersion, newversion), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    return;

                System.Diagnostics.Process.Start(newurl);
            }
            else
            {
                MessageBox.Show(FreeSnippingTool.CommonStrings.NoNewVersion, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch
        {

            MessageBox.Show(FreeSnippingTool.CommonStrings.CanNotCheckForUpdate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}

