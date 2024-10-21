﻿using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class MainForm : Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pdControl = new System.Drawing.Printing.PrintDocument();
            this.ptDControl = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtGapY = new System.Windows.Forms.TextBox();
            this.txtGapX = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtaxisLengthY = new System.Windows.Forms.TextBox();
            this.txtaxisLengthX = new System.Windows.Forms.TextBox();
            this.chkPoint = new System.Windows.Forms.CheckBox();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtLabelRow = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLabelCol = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtMarginTB = new System.Windows.Forms.TextBox();
            this.txtMarginLR = new System.Windows.Forms.TextBox();
            this.txtPaperHeigh = new System.Windows.Forms.TextBox();
            this.txtPaperWidth = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ppVControl = new System.Windows.Forms.PrintPreviewControl();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.comPrtType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myComboBox1 = new WindowsFormsApplication1.myComboBox(this.components);
            this.lstContent = new System.Windows.Forms.ListView();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImportTempData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveTempData = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.ucControlBase1 = new WindowsFormsApplication1.UCControlBase();
            this.move1 = new WindowsFormsApplication1.Move();
            this.ucBtnExt1 = new WindowsFormsApplication1.UCBtnExt();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdControl
            // 
            this.pdControl.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.pdControl_BeginPrint);
            this.pdControl.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.pdControl_EndPrint);
            this.pdControl.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdControl_PrintPage);
            // 
            // ptDControl
            // 
            this.ptDControl.AllowCurrentPage = true;
            this.ptDControl.AllowSomePages = true;
            this.ptDControl.Document = this.pdControl;
            this.ptDControl.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(4, 157);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 28);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(56, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Checked = true;
            this.chkBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBold.Location = new System.Drawing.Point(307, 34);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 11;
            this.chkBold.Text = "加粗";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblColor.Location = new System.Drawing.Point(95, 34);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(15, 15);
            this.lblColor.TabIndex = 5;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(359, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 21);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.Text = "文字内容";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(276, 32);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(27, 21);
            this.txtSize.TabIndex = 8;
            this.txtSize.Text = "16";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(203, 32);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(69, 21);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.Text = "(185,60)";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(607, 32);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(37, 21);
            this.txtColumn.TabIndex = 2;
            this.txtColumn.Text = "4";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(127, 32);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(69, 21);
            this.txtStart.TabIndex = 2;
            this.txtStart.Text = "(15,15)";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(564, 32);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(40, 21);
            this.txtRow.TabIndex = 2;
            this.txtRow.Text = "3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.txtGapY);
            this.groupBox2.Controls.Add(this.txtGapX);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.txtaxisLengthY);
            this.groupBox2.Controls.Add(this.txtaxisLengthX);
            this.groupBox2.Controls.Add(this.chkPoint);
            this.groupBox2.Controls.Add(this.chkGrid);
            this.groupBox2.Location = new System.Drawing.Point(213, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(157, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "辅助";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 69);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 9;
            this.label37.Text = "纵轴刻度：";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(13, 47);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(65, 12);
            this.label44.TabIndex = 8;
            this.label44.Text = "横轴刻度：";
            // 
            // txtGapY
            // 
            this.txtGapY.Location = new System.Drawing.Point(79, 111);
            this.txtGapY.Margin = new System.Windows.Forms.Padding(2);
            this.txtGapY.Name = "txtGapY";
            this.txtGapY.Size = new System.Drawing.Size(65, 21);
            this.txtGapY.TabIndex = 7;
            this.txtGapY.Text = "50";
            // 
            // txtGapX
            // 
            this.txtGapX.Location = new System.Drawing.Point(79, 89);
            this.txtGapX.Margin = new System.Windows.Forms.Padding(2);
            this.txtGapX.Name = "txtGapX";
            this.txtGapX.Size = new System.Drawing.Size(65, 21);
            this.txtGapX.TabIndex = 6;
            this.txtGapX.Text = "50";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(7, 113);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(71, 12);
            this.label43.TabIndex = 5;
            this.label43.Text = "Y刻度间隔：";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 89);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 12);
            this.label42.TabIndex = 4;
            this.label42.Text = "X刻度间隔：";
            // 
            // txtaxisLengthY
            // 
            this.txtaxisLengthY.Location = new System.Drawing.Point(79, 66);
            this.txtaxisLengthY.Margin = new System.Windows.Forms.Padding(2);
            this.txtaxisLengthY.Name = "txtaxisLengthY";
            this.txtaxisLengthY.Size = new System.Drawing.Size(65, 21);
            this.txtaxisLengthY.TabIndex = 3;
            this.txtaxisLengthY.Text = "100";
            // 
            // txtaxisLengthX
            // 
            this.txtaxisLengthX.Location = new System.Drawing.Point(79, 44);
            this.txtaxisLengthX.Margin = new System.Windows.Forms.Padding(2);
            this.txtaxisLengthX.Name = "txtaxisLengthX";
            this.txtaxisLengthX.Size = new System.Drawing.Size(65, 21);
            this.txtaxisLengthX.TabIndex = 2;
            this.txtaxisLengthX.Text = "200";
            // 
            // chkPoint
            // 
            this.chkPoint.AutoSize = true;
            this.chkPoint.Location = new System.Drawing.Point(85, 20);
            this.chkPoint.Margin = new System.Windows.Forms.Padding(2);
            this.chkPoint.Name = "chkPoint";
            this.chkPoint.Size = new System.Drawing.Size(60, 16);
            this.chkPoint.TabIndex = 1;
            this.chkPoint.Text = "坐标点";
            this.chkPoint.UseVisualStyleBackColor = true;
            // 
            // chkGrid
            // 
            this.chkGrid.AutoSize = true;
            this.chkGrid.Checked = true;
            this.chkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrid.Location = new System.Drawing.Point(15, 20);
            this.chkGrid.Margin = new System.Windows.Forms.Padding(2);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(60, 16);
            this.chkGrid.TabIndex = 0;
            this.chkGrid.Text = "网格线";
            this.chkGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.txtLabelRow);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.txtLabelCol);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.txtMarginTB);
            this.groupBox1.Controls.Add(this.txtMarginLR);
            this.groupBox1.Controls.Add(this.txtPaperHeigh);
            this.groupBox1.Controls.Add(this.txtPaperWidth);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "页面设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "行数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "列数";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(170, 94);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 12);
            this.label41.TabIndex = 3;
            this.label41.Text = "mm";
            // 
            // txtLabelRow
            // 
            this.txtLabelRow.Location = new System.Drawing.Point(46, 115);
            this.txtLabelRow.Name = "txtLabelRow";
            this.txtLabelRow.Size = new System.Drawing.Size(37, 21);
            this.txtLabelRow.TabIndex = 2;
            this.txtLabelRow.Text = "1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(170, 71);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(17, 12);
            this.label40.TabIndex = 3;
            this.label40.Text = "mm";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(170, 49);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(17, 12);
            this.label39.TabIndex = 3;
            this.label39.Text = "mm";
            // 
            // txtLabelCol
            // 
            this.txtLabelCol.Location = new System.Drawing.Point(130, 116);
            this.txtLabelCol.Name = "txtLabelCol";
            this.txtLabelCol.Size = new System.Drawing.Size(40, 21);
            this.txtLabelCol.TabIndex = 2;
            this.txtLabelCol.Text = "1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(170, 25);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 12);
            this.label38.TabIndex = 3;
            this.label38.Text = "mm";
            // 
            // txtMarginTB
            // 
            this.txtMarginTB.Location = new System.Drawing.Point(74, 92);
            this.txtMarginTB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarginTB.Name = "txtMarginTB";
            this.txtMarginTB.Size = new System.Drawing.Size(93, 21);
            this.txtMarginTB.TabIndex = 1;
            this.txtMarginTB.Text = "5";
            // 
            // txtMarginLR
            // 
            this.txtMarginLR.Location = new System.Drawing.Point(74, 69);
            this.txtMarginLR.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarginLR.Name = "txtMarginLR";
            this.txtMarginLR.Size = new System.Drawing.Size(93, 21);
            this.txtMarginLR.TabIndex = 1;
            this.txtMarginLR.Text = "10";
            // 
            // txtPaperHeigh
            // 
            this.txtPaperHeigh.Location = new System.Drawing.Point(74, 47);
            this.txtPaperHeigh.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaperHeigh.Name = "txtPaperHeigh";
            this.txtPaperHeigh.Size = new System.Drawing.Size(93, 21);
            this.txtPaperHeigh.TabIndex = 1;
            this.txtPaperHeigh.Text = "110";
            // 
            // txtPaperWidth
            // 
            this.txtPaperWidth.Location = new System.Drawing.Point(75, 22);
            this.txtPaperWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaperWidth.Name = "txtPaperWidth";
            this.txtPaperWidth.Size = new System.Drawing.Size(93, 21);
            this.txtPaperWidth.TabIndex = 1;
            this.txtPaperWidth.Text = "210";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 95);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 12);
            this.label36.TabIndex = 0;
            this.label36.Text = "左右边距：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 69);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 12);
            this.label35.TabIndex = 0;
            this.label35.Text = "上下边距：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 49);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 0;
            this.label34.Text = "纸张高度：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 23);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "纸张宽度：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ppVControl);
            this.panel1.Location = new System.Drawing.Point(300, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 471);
            this.panel1.TabIndex = 15;
            // 
            // ppVControl
            // 
            this.ppVControl.AutoZoom = false;
            this.ppVControl.BackColor = System.Drawing.SystemColors.Control;
            this.ppVControl.Document = this.pdControl;
            this.ppVControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ppVControl.Location = new System.Drawing.Point(3, 3);
            this.ppVControl.Name = "ppVControl";
            this.ppVControl.Size = new System.Drawing.Size(886, 430);
            this.ppVControl.TabIndex = 1;
            this.ppVControl.UseAntiAlias = true;
            this.ppVControl.Zoom = 1D;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(739, 32);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "0.1";
            // 
            // comPrtType
            // 
            this.comPrtType.FormattingEnabled = true;
            this.comPrtType.Location = new System.Drawing.Point(11, 33);
            this.comPrtType.Margin = new System.Windows.Forms.Padding(2);
            this.comPrtType.Name = "comPrtType";
            this.comPrtType.Size = new System.Drawing.Size(66, 20);
            this.comPrtType.TabIndex = 19;
            this.comPrtType.SelectedIndexChanged += new System.EventHandler(this.comPrtType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myComboBox1);
            this.panel2.Controls.Add(this.chkBold);
            this.panel2.Controls.Add(this.lstContent);
            this.panel2.Controls.Add(this.txtColumn);
            this.panel2.Controls.Add(this.lblColor);
            this.panel2.Controls.Add(this.txtEnd);
            this.panel2.Controls.Add(this.txtRow);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtStart);
            this.panel2.Controls.Add(this.comPrtType);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtWidth);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtSize);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(389, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 159);
            this.panel2.TabIndex = 20;
            // 
            // myComboBox1
            // 
            this.myComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.myComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myComboBox1.Location = new System.Drawing.Point(650, 31);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(83, 22);
            this.myComboBox1.TabIndex = 22;
            // 
            // lstContent
            // 
            this.lstContent.HideSelection = false;
            this.lstContent.Location = new System.Drawing.Point(2, 56);
            this.lstContent.Margin = new System.Windows.Forms.Padding(2);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(790, 103);
            this.lstContent.TabIndex = 21;
            this.lstContent.UseCompatibleStateImageBehavior = false;
            this.lstContent.SelectedIndexChanged += new System.EventHandler(this.lstContent_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(673, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 12;
            this.label22.Text = "线型";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(401, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 11;
            this.label21.Text = "内容";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(293, 9);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "字号";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(560, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "行数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(605, 9);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 9;
            this.label18.Text = "列数";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(205, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 9;
            this.label17.Text = "结束位置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "起始位置";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(86, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "颜色";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(737, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "线宽";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "打印类型";
            // 
            // btnImportTempData
            // 
            this.btnImportTempData.Location = new System.Drawing.Point(4, 191);
            this.btnImportTempData.Name = "btnImportTempData";
            this.btnImportTempData.Size = new System.Drawing.Size(68, 28);
            this.btnImportTempData.TabIndex = 0;
            this.btnImportTempData.Text = "导入模板";
            this.btnImportTempData.UseVisualStyleBackColor = true;
            this.btnImportTempData.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveTempData
            // 
            this.btnSaveTempData.Location = new System.Drawing.Point(77, 190);
            this.btnSaveTempData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveTempData.Name = "btnSaveTempData";
            this.btnSaveTempData.Size = new System.Drawing.Size(68, 28);
            this.btnSaveTempData.TabIndex = 21;
            this.btnSaveTempData.Text = "导出模板";
            this.btnSaveTempData.UseVisualStyleBackColor = true;
            this.btnSaveTempData.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(212, 157);
            this.btnModi.Margin = new System.Windows.Forms.Padding(2);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(47, 28);
            this.btnModi.TabIndex = 22;
            this.btnModi.Text = "修改";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 190);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 28);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "每个坐标点之间为0.5cm";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(282, 187);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 298);
            this.vScrollBar1.TabIndex = 25;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(300, 176);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(618, 14);
            this.hScrollBar1.TabIndex = 26;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // ucControlBase1
            // 
            this.ucControlBase1.ConerRadius = 24;
            this.ucControlBase1.FillColor = System.Drawing.Color.Transparent;
            this.ucControlBase1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucControlBase1.IsRadius = false;
            this.ucControlBase1.IsShowRect = false;
            this.ucControlBase1.Location = new System.Drawing.Point(56, 358);
            this.ucControlBase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucControlBase1.Name = "ucControlBase1";
            this.ucControlBase1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucControlBase1.RectWidth = 1;
            this.ucControlBase1.Size = new System.Drawing.Size(222, 150);
            this.ucControlBase1.TabIndex = 2;
            // 
            // move1
            // 
            this.move1.Location = new System.Drawing.Point(84, 240);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(155, 127);
            this.move1.TabIndex = 27;
            this.move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.Black;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(40, 523);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(184, 60);
            this.ucBtnExt1.TabIndex = 28;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsText = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.ucControlBase1);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnSaveTempData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnImportTempData);
            this.Controls.Add(this.btnPrint);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签打印";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void comPrtType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void btnCommand_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void lblColor_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void pdControl_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void pdControl_BeginPrint(object sender, PrintEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void pdControl_EndPrint(object sender, PrintEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Drawing.Printing.PrintDocument pdControl;
        private System.Windows.Forms.PrintDialog ptDControl;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtGapY;
        private System.Windows.Forms.TextBox txtGapX;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtaxisLengthY;
        private System.Windows.Forms.TextBox txtaxisLengthX;
        private System.Windows.Forms.CheckBox chkPoint;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtMarginTB;
        private System.Windows.Forms.TextBox txtMarginLR;
        private System.Windows.Forms.TextBox txtPaperHeigh;
        private System.Windows.Forms.TextBox txtPaperWidth;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintPreviewControl ppVControl;
        private System.Windows.Forms.TextBox txtWidth;
        // private myComboBox myComboBox1;

        private System.Windows.Forms.ComboBox comPrtType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListView lstContent;
        private System.Windows.Forms.Button btnImportTempData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabelRow;
        private System.Windows.Forms.TextBox txtLabelCol;
        private System.Windows.Forms.Button btnSaveTempData;
         
        private myComboBox myComboBox1;
        private Button btnModi;
        private Button btnClear;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private Move move1;
        private UCControlBase ucControlBase1;
        private UCBtnExt ucBtnExt1;
         
    }
}

