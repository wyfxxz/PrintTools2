using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class UCControlBase : UserControl
    {
        private bool _isRadius = false;
        private int _conerRadius = 24;
        private Color _fillColor = Color.Transparent;

        public Color FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; }
        }

        public int ConerRadius
        {
            get { return _conerRadius; }
            set { _conerRadius = value; }
        }
        private bool _isShowRect = false;

        public bool IsShowRect
        {
            get { return _isShowRect; }
            set { _isShowRect = value; }
        }
        private Color _rectColor = Color.FromArgb(220, 220, 220);

        public Color RectColor
        {
            get { return _rectColor; }
            set { _rectColor = value; }
        }
        private int _rectWidth = 1;

        public int RectWidth
        {
            get { return _rectWidth; }
            set { _rectWidth = value; }
        }
        [Description("是否圆角"), Category("自定义")]
        public bool IsRadius {
            get
            {
                return this._isRadius;
            }
            set
            {
                this._isRadius = value;
             }
        }

        public UCControlBase()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Visible)
            {
                if (this._isRadius)
                    this.SetWindowRegion();
                if (this._isShowRect)
                {
                    Color rectColor = this._rectColor;
                    Pen pen = new Pen(rectColor, this._rectWidth);
                    Rectangle clientRectangle = base.ClientRectangle;
                    
                    GraphicsPath graphicsPath = new GraphicsPath();
                    graphicsPath.AddArc(0, 0, _conerRadius, _conerRadius, 180f, 90f);
                    graphicsPath.AddArc(clientRectangle.Width - _conerRadius - 1, 0, _conerRadius, _conerRadius, 270f, 90f);
                    graphicsPath.AddArc(clientRectangle.Width - _conerRadius - 1, clientRectangle.Height - +_conerRadius - 1, _conerRadius, _conerRadius, 0f, 90f);
                    graphicsPath.AddArc(0, clientRectangle.Height - _conerRadius - 1, _conerRadius, _conerRadius, 90f, 90f);

                    graphicsPath.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    if (_fillColor != Color.Empty && _fillColor != Color.Transparent && _fillColor != this.BackColor)
                        e.Graphics.FillPath(new SolidBrush(this._fillColor), graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath); 
                     
                }

            
            }
            base.OnPaint(e);
        }

        private void SetWindowRegion()
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(-1, -1, base.Width + 1, base.Height);
            path = this.GetRoundedRectPath(rect, this._conerRadius);
            base.Region = new Region(path);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
             Rectangle rect2=new Rectangle (rect.Location,new Size (radius,radius));
             GraphicsPath graphicsPath = new GraphicsPath();
             graphicsPath.AddArc(rect2, 180f, 90f);
             rect2.X = rect.Right - radius;
             graphicsPath.AddArc(rect2, 270f, 90f);
             rect2.Y = rect.Bottom - radius;
             rect2.Width += 1;
             rect2.Height += 1;
             graphicsPath.AddArc(rect2, 360f, 90f);
             rect2.X = rect.Left;
             graphicsPath.AddArc(rect2, 90f, 90f);
             graphicsPath.CloseFigure();
             return graphicsPath;

        }
        protected override void WndProc(ref Message m)
        {
            if(m.Msg!=20)
                base.WndProc(ref m);
        }
    }
}
