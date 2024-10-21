﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UCBtnExt :UCControlBase
    {
        public bool IsShowTips
        {
            get {
                return this.lblTips.Visible;
            }
            set
            {
                this.lblTips.Visible = true;
            }
        }
        public string TipsText
        {
            get
            {
                return this.lblTips.Text;
            }
            set
            {
                this.lblTips.Text = value;
            
            }
        }
         private Color _btnBackColor = Color.White;
        [Description("按钮背景色"), Category("自定义")]
        public Color BtnBackColor
        {
            get { return _btnBackColor; }
            set
            {
                _btnBackColor = value;
                this.BackColor = value;
            }
        }
 
        private Color _btnForeColor = Color.Black;
        /// <summary>
        /// 按钮字体颜色
        /// </summary>
        [Description("按钮字体颜色"), Category("自定义")]
        public Color BtnForeColor
        {
            get { return _btnForeColor; }
            set
            {
                _btnForeColor = value;
                this.lbl.ForeColor = value;
            }
        }
 
        private Font _btnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        /// <summary>
        /// 按钮字体
        /// </summary>
        [Description("按钮字体"), Category("自定义")]
        public Font BtnFont
        {
            get { return _btnFont; }
            set
            {
                _btnFont = value;
                this.lbl.Font = value;
            }
        }
 
        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event EventHandler BtnClick;
 
        private string _btnText;
        /// <summary>
        /// 按钮文字
        /// </summary>
        [Description("按钮文字"), Category("自定义")]
        public string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                lbl.Text = value;
            }
        } 
        public UCBtnExt()
        {
            InitializeComponent();
            this.TabStop = false;

        }
 
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.BtnClick != null)
                BtnClick(this, e);
        }
    }
}
