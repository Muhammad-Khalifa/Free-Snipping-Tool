using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

public class CropRect
{
    private Form mForm;
    public Rectangle rect;
    public bool AllowMovementAndResize = true;
    public bool allowDeformingDuringMovement = true;
    private bool mIsClick = false;
    private bool mMove = false;
    private int oldX;
    private int oldY;
    private int sizeNodeRect = 5;
    private PosSizableRect nodeSelected = PosSizableRect.None;
    private int PixelRectYOffset = 5;
    private int PixelRectXOffset = 2;
    private bool _visible;
    public bool Visible
    {
        get
        {
            return _visible;
        }
        set
        {
            _visible = value;
            mForm.Invalidate();
        }
    }

    private enum PosSizableRect
    {
        UpMiddle,
        LeftMiddle,
        LeftBottom,
        LeftUp,
        RightUp,
        RightMiddle,
        RightBottom,
        BottomMiddle,
        None
    };


    public event EventHandler RectMoved;
    protected virtual void OnRectMoved(MouseEventArgs e)
    {
        if (RectMoved != null)
            RectMoved(this, e);
    }

    public CropRect(Rectangle r)
    {
        rect = r;
        mIsClick = false;
    }

    public void Draw(Graphics g)
    {
        Pen p = new Pen(Color.Black, 1.0F);
        p.DashStyle = DashStyle.Solid;

        Pen pDash = new Pen(Color.White, 1.0F);
        pDash.DashStyle = DashStyle.Dash;
        pDash.DashPattern = new float[] { 4.0F, 4.0F };

        SolidBrush pixelBursh = new SolidBrush(Color.LightGray);
        SolidBrush pixelBkBursh = new SolidBrush(Color.Black);
        string PixelSizestring = string.Format("{0}×{1}", rect.Width, rect.Height);
        Font PixelFont = new Font("Arial", 11f, FontStyle.Regular);

        g.DrawRectangle(p, rect);
        g.DrawRectangle(pDash, rect);

        foreach (PosSizableRect pos in Enum.GetValues(typeof(PosSizableRect)))
        {
            SolidBrush blueBrush = new SolidBrush(Color.Black);
            Pen pe = new Pen(Color.White, 1.0f);
            g.FillRectangle(blueBrush, GetRect(pos));
            g.DrawRectangle(pe, GetRect(pos));
        }
        g.FillRectangle(pixelBkBursh, rect.X + PixelRectXOffset, rect.Y - g.MeasureString(PixelSizestring, PixelFont).Height - PixelRectYOffset, g.MeasureString(PixelSizestring, PixelFont).Width, g.MeasureString(PixelSizestring, PixelFont).Height);
        g.DrawString(PixelSizestring, PixelFont, pixelBursh, rect.X + PixelRectXOffset, rect.Y - g.MeasureString(PixelSizestring, PixelFont).Height - PixelRectYOffset);

    }


    public void SetForm(Form form)
    {
        this.mForm = form;
        mForm.MouseDown += new MouseEventHandler(mForm_MouseDown);
        mForm.MouseUp += new MouseEventHandler(mForm_MouseUp);
        mForm.MouseMove += new MouseEventHandler(mForm_MouseMove);
        mForm.Paint += new PaintEventHandler(mForm_Paint);
    }

    private void mForm_Paint(object sender, PaintEventArgs e)
    {
        try
        {
            if (Visible)
                Draw(e.Graphics);
        }
        catch (Exception exp)
        {
            System.Console.WriteLine(exp.Message);
        }

    }

    private void mForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (AllowMovementAndResize)
            mIsClick = true;
        else
            mIsClick = false;

        nodeSelected = PosSizableRect.None;
        nodeSelected = GetNodeSelectable(e.Location);

        if (rect.Contains(new Point(e.X, e.Y)))
        {
            mMove = true;
        }
        oldX = e.X;
        oldY = e.Y;
    }

    private void mForm_MouseUp(object sender, MouseEventArgs e)
    {
        mIsClick = false;
        mMove = false;
    }

    private void mForm_MouseMove(object sender, MouseEventArgs e)
    {
        ChangeCursor(e.Location);

        if (mIsClick == false)
        {
            return;
        }

        Rectangle backupRect = rect;

        switch (nodeSelected)
        {
            case PosSizableRect.LeftUp:
                rect.X += e.X - oldX;
                rect.Width -= e.X - oldX;
                rect.Y += e.Y - oldY;
                rect.Height -= e.Y - oldY;
                break;
            case PosSizableRect.LeftMiddle:
                rect.X += e.X - oldX;
                rect.Width -= e.X - oldX;
                break;
            case PosSizableRect.LeftBottom:
                rect.Width -= e.X - oldX;
                rect.X += e.X - oldX;
                rect.Height += e.Y - oldY;
                break;
            case PosSizableRect.BottomMiddle:
                rect.Height += e.Y - oldY;
                break;
            case PosSizableRect.RightUp:
                rect.Width += e.X - oldX;
                rect.Y += e.Y - oldY;
                rect.Height -= e.Y - oldY;
                break;
            case PosSizableRect.RightBottom:
                rect.Width += e.X - oldX;
                rect.Height += e.Y - oldY;
                break;
            case PosSizableRect.RightMiddle:
                rect.Width += e.X - oldX;
                break;

            case PosSizableRect.UpMiddle:
                rect.Y += e.Y - oldY;
                rect.Height -= e.Y - oldY;
                break;

            default:
                if (mMove)
                {
                    rect.X = rect.X + e.X - oldX;
                    rect.Y = rect.Y + e.Y - oldY;
                    mForm.Cursor = Cursors.SizeAll;
                }
                break;
        }
        oldX = e.X;
        oldY = e.Y;

        if (rect.Width < 5 || rect.Height < 5)
        {
            rect = backupRect;
        }

        TestIfRectInsideArea();
        OnRectMoved(e);
        mForm.Invalidate();
    }

    private void TestIfRectInsideArea()
    {
        if (rect.X < 0) rect.X = 0;
        if (rect.Y < 0) rect.Y = 0;
        if (rect.Width <= 0) rect.Width = 1;
        if (rect.Height <= 0) rect.Height = 1;

        if (rect.X + rect.Width > mForm.Width)
        {
            rect.Width = mForm.Width - rect.X - 1; // -1 to be still show 
            if (allowDeformingDuringMovement == false)
            {
                mIsClick = false;
            }
        }
        if (rect.Y + rect.Height > mForm.Height)
        {
            rect.Height = mForm.Height - rect.Y - 1;// -1 to be still show 
            if (allowDeformingDuringMovement == false)
            {
                mIsClick = false;
            }
        }
        if (rect.Y <= 25)
            PixelRectYOffset = -25;
        else
            PixelRectYOffset = 5;
    }

    private Rectangle CreateRectSizableNode(int x, int y)
    {
        return new Rectangle(x - sizeNodeRect / 2, y - sizeNodeRect / 2, sizeNodeRect, sizeNodeRect);
    }

    private Rectangle GetRect(PosSizableRect p)
    {
        switch (p)
        {
            case PosSizableRect.LeftUp:
                return CreateRectSizableNode(rect.X, rect.Y);

            case PosSizableRect.LeftMiddle:
                return CreateRectSizableNode(rect.X, rect.Y + +rect.Height / 2);

            case PosSizableRect.LeftBottom:
                return CreateRectSizableNode(rect.X, rect.Y + rect.Height);

            case PosSizableRect.BottomMiddle:
                return CreateRectSizableNode(rect.X + rect.Width / 2, rect.Y + rect.Height);

            case PosSizableRect.RightUp:
                return CreateRectSizableNode(rect.X + rect.Width, rect.Y);

            case PosSizableRect.RightBottom:
                return CreateRectSizableNode(rect.X + rect.Width, rect.Y + rect.Height);

            case PosSizableRect.RightMiddle:
                return CreateRectSizableNode(rect.X + rect.Width, rect.Y + rect.Height / 2);

            case PosSizableRect.UpMiddle:
                return CreateRectSizableNode(rect.X + rect.Width / 2, rect.Y);
            default:
                return new Rectangle();
        }
    }

    private PosSizableRect GetNodeSelectable(Point p)
    {
        foreach (PosSizableRect r in Enum.GetValues(typeof(PosSizableRect)))
        {
            if (GetRect(r).Contains(p))
            {
                return r;
            }
        }
        return PosSizableRect.None;
    }

    private void ChangeCursor(Point p)
    {
        if (AllowMovementAndResize)
        {
            mForm.Cursor = GetCursor(GetNodeSelectable(p));
            if (rect.Contains(p))
                mForm.Cursor = Cursors.SizeAll;
        }
        else
        {
            if (FreeSnippingTool.FrmMain.currentshape == ShapesTypes.ShapeTypes.CropRect)
            {
                using (var memoryStream = new MemoryStream(FreeSnippingTool.CommonImages.selectcur))
                {
                    mForm.Cursor = new Cursor(memoryStream);
                }
            }
            else
                mForm.Cursor = Cursors.Default;

        }
    }

    private Cursor GetCursor(PosSizableRect p)
    {
        switch (p)
        {
            case PosSizableRect.LeftUp:
                return Cursors.SizeNWSE;

            case PosSizableRect.LeftMiddle:
                return Cursors.SizeWE;

            case PosSizableRect.LeftBottom:
                return Cursors.SizeNESW;

            case PosSizableRect.BottomMiddle:
                return Cursors.SizeNS;

            case PosSizableRect.RightUp:
                return Cursors.SizeNESW;

            case PosSizableRect.RightBottom:
                return Cursors.SizeNWSE;

            case PosSizableRect.RightMiddle:
                return Cursors.SizeWE;

            case PosSizableRect.UpMiddle:
                return Cursors.SizeNS;
            default:
                {
                    if (FreeSnippingTool.FrmMain.currentshape == ShapesTypes.ShapeTypes.CropRect)
                    {
                        using (var memoryStream = new MemoryStream(FreeSnippingTool.CommonImages.selectcur))
                        {
                          return new Cursor(memoryStream);
                        }
                    }
                    else
                      
                    return Cursors.Default;
                }

        }
    }

}

