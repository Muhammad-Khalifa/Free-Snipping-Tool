using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

class AssistOperation
{
    public static Image CaptureScreen()
    {
        var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                           Screen.PrimaryScreen.Bounds.Height,
                           PixelFormat.Format32bppArgb);



        var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

        gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                   Screen.PrimaryScreen.Bounds.Y,
                                   0,
                                   0,
                                   Screen.PrimaryScreen.Bounds.Size,
                                   CopyPixelOperation.SourceCopy);

        gfxScreenshot.Dispose();
        return bmpScreenshot;
    }

    public static Image FadeImage(Image orignalImage)
    {
        Bitmap Fadedbitmap = new Bitmap(orignalImage, orignalImage.Width, orignalImage.Height);
        using (Graphics FadedScreenImageGraph = Graphics.FromImage(Fadedbitmap))
        {
            FadedScreenImageGraph.DrawImage(global::FreeSnippingTool.Properties.Resources.OverLay, 0, 0, orignalImage.Width, orignalImage.Height);
            return Fadedbitmap;
        }
    }


    public static Image CaptureResult(Control ctrl, CropRect croprect)
    {
        Rectangle bounds = croprect.rect;
        Point pt = ctrl.PointToScreen(bounds.Location);
        Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
        using (Graphics graph = Graphics.FromImage(bitmap))
        {
            graph.CopyFromScreen(new Point(croprect.rect.X - ctrl.Location.X, croprect.rect.Y - ctrl.Location.Y), Point.Empty, bounds.Size);
        }

        return bitmap;
    }

    public static Image CropImage(Image OriginalScreenImage, CropRect croprect, Form frmMain)
    {
        Bitmap OriginalImage = new Bitmap(OriginalScreenImage, frmMain.Width, frmMain.Height);

        Bitmap _img = new Bitmap(croprect.rect.Width, croprect.rect.Height);
        using (Graphics graph = Graphics.FromImage(_img))
        {

            graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graph.DrawImage(OriginalImage, 0, 0, croprect.rect, GraphicsUnit.Pixel);
        }
         
        OriginalImage.Dispose();

        return _img;
    }

    public static int PerceivedBrightness(Color c)
    {
        return (int)Math.Sqrt(
        c.R * c.R * .241 +
        c.G * c.G * .691 +
        c.B * c.B * .068);
    }

    public static bool IsUrl (string inputurl)
    {
        Regex urlRx = new Regex(@"^(http|ftp|https|www)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$", RegexOptions.IgnoreCase);

        return urlRx.IsMatch(inputurl);
    }

    public static byte[] ImageToByteArray(Image image)
    {
        if (image == null)
            return new byte[0];

        MemoryStream memorystream = new MemoryStream();
        image.Save(memorystream,  ImageFormat.Png);

        return memorystream.ToArray();
    }
}

