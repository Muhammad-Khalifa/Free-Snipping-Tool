using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Threading;

namespace FreeSnippingTool
{
    public partial class FrmMain : Form
    {

        #region Vars
        Image OriginalScreenImage;


        CropRect cropRect;
        public static ShapesTypes.ShapeTypes currentshape = ShapesTypes.ShapeTypes.CropRect;

        Point StartPoint = new Point();
        Point EndPoint = new Point();

        Color SelectedColor = Color.Red;
        Rectangle RectShape = new Rectangle();


        static float PenWidth = 2;
        Pen pen = new Pen(Color.Red, PenWidth);

        UndoRedo undoactions;

        ShapesTypes.ShapeTypes oldshape = ShapesTypes.ShapeTypes.None;
        #endregion

        #region Init Form
        public FrmMain()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            currentshape = ShapesTypes.ShapeTypes.CropRect;
            this.DoubleBuffered = true;

            ContextMenuSelectColor.ColorScheme = ComponentFactory.Krypton.Toolkit.ColorScheme.OfficeStandard;
            ContextMenuSelectColor.SelectedColor = Color.Red;
            BtnColor.ForeColor = SelectedColor;

            OriginalScreenImage = AssistOperation.CaptureScreen();

            cropRect = new CropRect(new Rectangle(-5, -5, 1, 1));
            cropRect.SetForm(this);

            cropRect.Visible = true;

            cropRect.RectMoved += CropRect_RectMoved;

            this.BackgroundImage = AssistOperation.FadeImage(OriginalScreenImage);
            this.BackgroundImageLayout = ImageLayout.Center;

            undoactions = new UndoRedo();
        }

        private void CropRect_RectMoved(object sender, EventArgs e)
        {
            MainToolBar.Visible = false;
            int toolstripY = (cropRect.rect.Y + cropRect.rect.Height) - MainToolBar.Height;
            int toolstripX = cropRect.rect.Width + cropRect.rect.X + 5;

            if (toolstripY < 0)
                toolstripY = 0;

            if (toolstripX + MainToolBar.Width > this.Width)
                toolstripX = cropRect.rect.X - MainToolBar.Width - 5;

            if (cropRect.rect.Width + MainToolBar.Width >= this.Width)
            {
                toolstripX = cropRect.rect.Width - MainToolBar.Width;

            }
            MainToolBar.Location = new Point(toolstripX, toolstripY);
        }
        #endregion

        #region override 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion      

        #region Mouse Events 
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentshape == ShapesTypes.ShapeTypes.Undo)
            {
                currentshape = oldshape;
            }

            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (currentshape)
                {
                    case ShapesTypes.ShapeTypes.CropRect:
                        {
                            DoCropRect(e.Location);
                        }
                        break;
                    case ShapesTypes.ShapeTypes.Rectangle:
                        {
                            DoDrawRect(e.Location);
                        }
                        break;
                    case ShapesTypes.ShapeTypes.Line:
                        {
                            DoLine(e.Location);
                        }
                        break;
                    case ShapesTypes.ShapeTypes.Arrow:
                        {
                            DoLine(e.Location);
                        }
                        break;
                    default:
                        break;
                }

                this.Invalidate();
            }

        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentshape == ShapesTypes.ShapeTypes.CropRect)
            {
                
                currentshape = ShapesTypes.ShapeTypes.None;
                MainToolBar.Visible = true;

            }

            if (MainToolBar.Visible == false)
                MainToolBar.Visible = true;

            if (currentshape == ShapesTypes.ShapeTypes.Line)
            {
                Shape shape = new Shape();
                shape.shape = ShapesTypes.ShapeTypes.Line;
                shape.X = StartPoint.X;
                shape.Y = StartPoint.Y;
                shape.Width = EndPoint.X;
                shape.Height = EndPoint.Y;
                shape.pen = pen;
                undoactions.AddShape(shape);
            }
            else if (currentshape == ShapesTypes.ShapeTypes.Arrow)
            {
                Shape shape = new Shape();
                shape.shape = ShapesTypes.ShapeTypes.Arrow;
                shape.X = StartPoint.X;
                shape.Y = StartPoint.Y;
                shape.Width = EndPoint.X;
                shape.Height = EndPoint.Y;
                shape.pen = pen;
                undoactions.AddShape(shape);
            }
            else if (currentshape == ShapesTypes.ShapeTypes.Rectangle)
            {
                Shape shape = new Shape();
                shape.shape = ShapesTypes.ShapeTypes.Rectangle;
                shape.X = RectShape.X;
                shape.Y = RectShape.Y;
                shape.Width = RectShape.Width;
                shape.Height = RectShape.Height;
                shape.pen = pen;
                undoactions.AddShape(shape);
            }
            this.Invalidate();

        }
        #endregion

        #region Draw Functions
        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;

            DoCropLayer(e.Graphics);

            if (currentshape == ShapesTypes.ShapeTypes.Rectangle)
            {
                e.Graphics.DrawRectangle(pen, RectShape);
            }
            else if (currentshape == ShapesTypes.ShapeTypes.Line)
            {
                pen = new Pen(SelectedColor, PenWidth);
                e.Graphics.DrawLine(pen, StartPoint, EndPoint);
            }
            else if (currentshape == ShapesTypes.ShapeTypes.Arrow)
            {
                e.Graphics.DrawLine(pen, StartPoint, EndPoint);

                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4);
                pen.CustomEndCap = bigArrow;
            }

            foreach (var item in undoactions.lstShape)
            {
                if (item.shape == ShapesTypes.ShapeTypes.Line)
                {
                    e.Graphics.DrawLine(item.pen, item.X, item.Y, item.Width, item.Height);
                }
                else if (item.shape == ShapesTypes.ShapeTypes.Arrow)
                {
                    e.Graphics.DrawLine(item.pen, item.X, item.Y, item.Width, item.Height);

                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4);
                    item.pen.CustomEndCap = bigArrow;
                }
                else if (item.shape == ShapesTypes.ShapeTypes.Rectangle)
                {
                    Rectangle newRect = new Rectangle(item.X, item.Y, item.Width, item.Height);
                    e.Graphics.DrawRectangle(item.pen, newRect);
                }
            }
        }

        void DoCropRect(Point location)
        {
            Point p = location;
            int x = Math.Min(StartPoint.X, p.X);
            int y = Math.Min(StartPoint.Y, p.Y);
            int w = Math.Abs(p.X - StartPoint.X);
            int h = Math.Abs(p.Y - StartPoint.Y);

            cropRect.rect = new Rectangle(x, y, w, h);
        }

        void DoCropLayer(Graphics graph)
        {
            Image cropimg = AssistOperation.CropImage(OriginalScreenImage, cropRect, this);
            graph.DrawImage(cropimg, cropRect.rect.X, cropRect.rect.Y, cropRect.rect.Width, cropRect.rect.Height);
        }

        void DoDrawRect(Point location)
        {
            Point p = location;
            int x = Math.Min(StartPoint.X, p.X);
            int y = Math.Min(StartPoint.Y, p.Y);
            int w = Math.Abs(p.X - StartPoint.X);
            int h = Math.Abs(p.Y - StartPoint.Y);

            RectShape = new Rectangle(x, y, w, h);
        }

        void DoLine(Point Location)
        {
            Point p = Location;
            EndPoint.X = p.X;
            EndPoint.Y = p.Y;
        }
        #endregion

        #region ToolBar 
        private void BtnCropRect_Click(object sender, EventArgs e)
        {
            currentshape = ShapesTypes.ShapeTypes.None;
            BtnArrow.Checked = BtnRect.Checked = BtnLine.Checked = !BtnCropRect.Checked;
            cropRect.AllowMovementAndResize = true;
        }

        private void BtnRect_Click(object sender, EventArgs e)
        {
            currentshape = ShapesTypes.ShapeTypes.Rectangle;
            BtnArrow.Checked = BtnLine.Checked = BtnCropRect.Checked = !BtnRect.Checked;
            cropRect.AllowMovementAndResize = false;
        }

        private void BtnArrow_Click(object sender, EventArgs e)
        {
            currentshape = ShapesTypes.ShapeTypes.Arrow;
            BtnLine.Checked = BtnRect.Checked = BtnCropRect.Checked = !BtnArrow.Checked;
            cropRect.AllowMovementAndResize = false;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            currentshape = ShapesTypes.ShapeTypes.Line;
            BtnArrow.Checked = BtnRect.Checked = BtnCropRect.Checked = !BtnLine.Checked;
            cropRect.AllowMovementAndResize = false;
        }


        private void BtnColor_Click(object sender, EventArgs e)
        {
            ContextColorMenu.Show(BtnColor);
        }

        private void ContextMenuSelectColor_SelectedColorChanged(object sender, ComponentFactory.Krypton.Toolkit.ColorEventArgs e)
        {
            SelectedColor = e.Color;
            BtnColor.ForeColor = (AssistOperation.PerceivedBrightness(e.Color) > 130 ? Color.Black : Color.White);
            BtnColor.BackColor = e.Color;

            pen = new Pen(e.Color, PenWidth);
            if (currentshape == ShapesTypes.ShapeTypes.None)
                BtnRect.PerformClick();
        }
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (currentshape != ShapesTypes.ShapeTypes.Undo)
            {
                oldshape = currentshape;
                currentshape = ShapesTypes.ShapeTypes.Undo;
            }
            if (undoactions.lstShape.Count > 0)
            {
                undoactions.Undo();
                this.Invalidate();
            }
        }

        private void ContextMenutMoreColor_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colordialog.Color;
                BtnColor.ForeColor = colordialog.Color;
                pen = new Pen(colordialog.Color, PenWidth);

                if (currentshape == ShapesTypes.ShapeTypes.None)
                    BtnRect.PerformClick();
            }
        }

        private async void BtnClipBoard_Click(object sender, EventArgs e)
        {
            cropRect.Visible = false;

            await DelayAction();

            Clipboard.SetImage(AssistOperation.CaptureResult(this, cropRect));

            cropRect.Visible = true;

            if (FrmTray.options.closeafterclipboard)
                this.Close();
        }

        private async void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            cropRect.Visible = false;

            await DelayAction();

            Image CapturedImage = AssistOperation.CaptureResult(this, cropRect);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save an Image File";
            sfd.RestoreDirectory = true;
            sfd.Filter = "PNG Image|*.png|Jpeg Image|*.jpg|Bitmap Image|*.bmp";
            sfd.FileName = string.Format("screenshot {0}",  DateTime.Now.ToString("HH-dd-MM")); 
            ImageFormat imgformat = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName).ToLower();
                switch (ext.ToLower())
                {
                    case ".jpg":
                        imgformat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imgformat = ImageFormat.Png;
                        break;
                    case ".bmp":
                        imgformat = ImageFormat.Bmp;
                        break;
                }
                CapturedImage.Save(sfd.FileName, imgformat);
            }

            CapturedImage.Dispose();
            cropRect.Visible = true;

            if (FrmTray.options.closeafterclipboard)
                this.Close();
        }


        private async void BtnUpload_Click(object sender, EventArgs e)
        {
            cropRect.Visible = false;

            await DelayAction();

            Image img = AssistOperation.CaptureResult(this, cropRect);

            cropRect.Visible = true;

            this.Close();

            FrmUploader upload = new FrmUploader(img);
            upload.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async Task DelayAction()
        {
            await Task.Delay(250);
        }

        #endregion

    }
}
