using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
 
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class myComboBox : ComboBox
    {
        public myComboBox()
        {
            InitializeComponent();
            InitItems();
        }

        private void InitItems()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;//手动绘制所有元素
            this.DropDownStyle = ComboBoxStyle.DropDownList;//下拉框样式不能编辑
            this.Items.Clear();
        }
        public myComboBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            InitItems();
        }
        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                int typeId = int.Parse(this.Items[e.Index].ToString());

                Font font = new Font("宋体", 9);
                Rectangle rect = e.Bounds;
                rect.Inflate(-2, -2);
                Pen pen = null;
                SolidBrush solidBrush = new SolidBrush(Color.Black);

                float offset = rect.Height / 2;
                float x = rect.Width / 5;
                float y = rect.Top + offset;

                switch (typeId)
                { 
                    case (int)DashStyle.Solid:
                        pen = new Pen(Color.Black, 1);
                        pen.DashStyle = DashStyle.Solid;

                        break;
                    case (int)DashStyle.Dash:
                        pen = new Pen(Color.Black, 1);
                        pen.DashStyle = DashStyle.Dash;

                        break;
                    case (int)DashStyle.Dot:
                        pen = new Pen(Color.Black, 1);
                        pen.DashStyle = DashStyle.Dot;

                        break;
                    case (int)DashStyle.DashDot:
                        pen = new Pen(Color.Black, 1);
                        pen.DashStyle = DashStyle.DashDot;

                        break;
                    case (int)DashStyle.DashDotDot:
                        pen = new Pen(Color.Black, 1);
                        pen.DashStyle = DashStyle.DashDotDot;

                        break;
                    case (int)DashStyle.Custom:
                        pen=new Pen(Color.Black,1);
                        pen.DashStyle = DashStyle.Dot;
                        pen.DashPattern = new float[] { 10, 10 };

                        break;

                }
                e.Graphics.DrawLine(pen,new PointF(x,y),new PointF(8*x,y));
            }
        }
    }
}
