﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Drawing.Drawing2D;
using System.IO;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private int width_p = 210;//单位是mm

        private int height_p = 297;//单位是mm

        private int margin_lr = 1;//左右边距

        private int margin_tb = 1;//上下边距

        /// <summary>
        /// 需要打印的内容
        /// </summary>
        public List<PrintInfo> PrintInfos { get; set; }

        private PrintHelper printHelper = new PrintHelper();
        private float zoom = 1.0f; // 初始缩放比例为1

        public MainForm()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            this.lstContent.View = View.Details;
            this.lstContent.MultiSelect = true; // 启用单选
            this.lstContent.FullRowSelect = true; // 选择整行
            this.lstContent.Columns.Add("序号", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("类型", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("颜色", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("起始", 80, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("结束", 80, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("字号", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("黑体", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("内容", 200, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("行数", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("列数", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("线型", 40, HorizontalAlignment.Left);
            this.lstContent.Columns.Add("线宽", 40, HorizontalAlignment.Left);

            this.myComboBox1.Items.Add(0);
            this.myComboBox1.Items.Add(1);
            this.myComboBox1.Items.Add(2);
            this.myComboBox1.Items.Add(3);
            this.myComboBox1.Items.Add(4);
            this.myComboBox1.Items.Add(5);
            this.myComboBox1.SelectedIndex = 0;

            this.comPrtType.Items.Add("文本");
            this.comPrtType.Items.Add("格式文本");
            this.comPrtType.Items.Add("表格");
            this.comPrtType.Items.Add("直线");
            this.comPrtType.Items.Add("点");

            this.comPrtType.SelectedIndex = 0;

            this.btnUp.Text = "\u2191";
            this.btnDown.Text = "\u2193";
            this.btnLeft.Text = " \u2190";
            this.btnRight.Text = "\u2192";

            this.label4.Text = "模板";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitInfo(); InitGrid();
            //this.ppVControl.Visible = false;
            InitDocument();
        }
        
        private void InitInfo()
        {
            PrinterSettings printSetting = new PrinterSettings();
            printSetting.PrintRange = PrintRange.AllPages;

            width_p = int.Parse(this.txtPaperWidth.Text);
            height_p = int.Parse(this.txtPaperHeigh.Text);
            margin_lr = int.Parse(this.txtMarginLR.Text);
            margin_tb = int.Parse(this.txtMarginTB.Text);

            this.vScrollBar1.Minimum = 0;
            this.vScrollBar1.Maximum= height_p - 2* margin_tb;
            this.hScrollBar1.Minimum= 0;
            this.hScrollBar1.Maximum=width_p-2*margin_lr;

            int width_in = MM2Inch(width_p);
            int height_in = MM2Inch(height_p);
            PageSettings pageSetting = new PageSettings(printSetting);
            pageSetting.PaperSize = new PaperSize("customer", width_in, height_in);

            int margin_lr_in = MM2Inch(margin_lr);
            int margin_tb_in = MM2Inch(margin_tb);
            pageSetting.Margins = new Margins(margin_lr_in, margin_lr_in, margin_tb_in, margin_tb_in);
            this.pdControl.DefaultPageSettings = pageSetting;

        }
        private void InitGrid()
        {
            if (this.chkGrid.Checked)
            {
                width_p = int.Parse(this.txtPaperWidth.Text);
                height_p = int.Parse(this.txtPaperHeigh.Text);
                margin_lr = int.Parse(this.txtMarginLR.Text);
                margin_tb = int.Parse(this.txtMarginTB.Text);

                List<PrintInfo> lstPrintInfos = new List<PrintInfo>();

                PrintInfo p0 = new PrintInfo()
                {
                    PrtType = PrintType.Table,
                    PrtColor = Color.Yellow,
                    Row = int.Parse(this.txtRow.Text.Trim()),
                    Column = int.Parse(this.txtColumn.Text.Trim()),
                    Start = new Point(0 + margin_tb, 0 + margin_lr),
                    End = new Point(width_p - margin_lr, height_p - margin_tb)

                };
                lstPrintInfos.Add(p0);

            }
        }
        private void InitDocument()
        {
            List<PrintInfo> lstPrintInfos = new List<PrintInfo>();

            printHelper.PrintInfos = lstPrintInfos;
        }

        /// <summary>
        /// 转换毫米到百分之一英寸
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        private int MM2Inch(int mm)
        {
            return (int)(mm * 100.0f / 25.4f);
        }

        /// <summary>
        /// 打印开始事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdControl_BeginPrint(object sender, PrintEventArgs e)
        {

        }

        /// <summary>
        /// 打印事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdControl_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14f, FontStyle.Regular);
            Graphics g = e.Graphics;
            g.PageScale = 1;
            g.PageUnit = GraphicsUnit.Millimeter;//单位
            //先画一个矩形
            Pen lineColor = new Pen(Color.Black, 0.2f);
            g.FillRectangle(Brushes.White, 0, 0, width_p, height_p);
            printHelper.Print(g);
        }

        /// <summary>
        /// 打印结束事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdControl_EndPrint(object sender, PrintEventArgs e)
        {

        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //打印对话框
            if (this.ptDControl.ShowDialog() == DialogResult.OK)
            {
                this.pdControl.Print();
            }

        }

        private void LblColor_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {

                this.lblColor.BackColor = f.Color;
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // this.ppVControl.Visible = false;
            InitInfo();
            
            List<PrintInfo> lstPrintInfos = new List<PrintInfo>();

            width_p = int.Parse(this.txtPaperWidth.Text);



            height_p = int.Parse(this.txtPaperHeigh.Text);
            margin_lr = int.Parse(this.txtMarginLR.Text);
            margin_tb = int.Parse(this.txtMarginTB.Text);

            //最优横轴刻度设置
            this.txtaxisLengthX.Text = ((width_p - 2 * margin_lr)).ToString();
            this.txtaxisLengthY.Text = ((height_p - 2 * margin_tb)).ToString();

            int axisLengthX = int.Parse(this.txtaxisLengthX.Text); // 坐标轴长�?
            int axisLengthY = int.Parse(this.txtaxisLengthY.Text); // 坐标轴长�?
            float scaleX = (width_p - 2 * margin_tb) * 1.0f / axisLengthX; // 每个单位 像素
            float scaleY = (height_p - 2 * margin_lr) * 1.0f / axisLengthY; // 每个单位 像素
            float gapX = float.Parse(this.txtGapX.Text);
            float gapY = float.Parse(this.txtGapY.Text);

           
            if (this.chkGrid.Checked)//网格
            {

                for (int i = 0; i <= axisLengthX; i += 5)
                {
                    for (int j = 0; j <= axisLengthY; j += 5)
                    {
                        Color c  ;
                        if (j % gapY == 0 || i % gapX == 0)
                            c = Color.Red;
                        else
                            c = Color.Green;
                        PrintInfo p00 = new PrintInfo()
                        {
                            PrtType = PrintType.Point,

                            PrtColor = c,
                            Width = 1,
                            Start = new PointF(margin_tb + i * scaleX, margin_lr + j * scaleY)

                        };
                        lstPrintInfos.Add(p00);
                    }

                }
            }
            //坐标点�?
            if (this.chkPoint.Checked)
            {

                for (float i = 0; i <= axisLengthX; i += gapX)
                {
                    PrintInfo p01 = new PrintInfo()
                    {
                        PrtType = PrintType.Text,
                        PrtColor = Color.Red,
                        Content = i.ToString(),
                        Size = 8,
                        FontStyle = FontStyle.Regular,
                        Start = new PointF(i * scaleX + margin_tb - 2, 0 + margin_lr - 4),
                    };
                    lstPrintInfos.Add(p01);
                }
                for (float j = 0; j <= axisLengthY; j += gapY)
                {
                    PrintInfo p01 = new PrintInfo()
                    {
                        PrtType = PrintType.Text,
                        PrtColor = Color.Red,
                        Content = j.ToString(),
                        Size = 8,
                        FontStyle = FontStyle.Regular,
                        Start = new PointF(0 + margin_tb - 4, j * scaleY + margin_lr),
                    };
                    lstPrintInfos.Add(p01);
                }
            }
            if (chkColumns.Checked == true)
            {
                int row = int.Parse(this.txtLabelRow.Text);
                int col=int.Parse(this.txtLabelCol.Text);
                string start  ;
                string end ;
                if(col>1)
                {
                    float c = ((width_p - 2 * margin_lr)*1.0f) / col;
                    for (int i = 1; i < col; i++)
                    {
                        
                        start = "("+((i )*c).ToString()+","+ "0)";
                        end = "(" + ((i ) * c ).ToString() + "," + (height_p -2*margin_tb).ToString() + ")";
                        PrintInfo p01 = new PrintInfo()
                        {
                            PrtType = PrintType.Line,

                            PrtColor = Color.Blue,
                            Width = 0.1f,
                            PrtDashStyle = DashStyle.Custom,

                            Start = new PointF(this.margin_tb + scaleX * float.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[0]), this.margin_lr + scaleY * float.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[1])),
                            End = new PointF(this.margin_tb + scaleX * float.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[0]), this.margin_lr + scaleY * float.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[1]))

                        };
                        lstPrintInfos.Add(p01);
                    }

                }
                if (row > 1)
                {
                    float c = (height_p - 2 * margin_tb)*1.0f / row;
                    for (int i = 1; i < row; i++)
                    {

                        start = "(0," + ((i) * c).ToString() + ")";
                        end = "(" + (width_p - 2*margin_lr).ToString() + "," + ((i) * c).ToString() + ")";
                        PrintInfo p01 = new PrintInfo()
                        {
                            PrtType = PrintType.Line,

                            PrtColor = Color.Blue,
                            Width = 0.1f,
                            PrtDashStyle = DashStyle.Custom,

                            Start = new PointF(this.margin_tb + scaleX * float.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[0]), this.margin_lr + scaleY * float.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[1])),
                            End = new PointF(this.margin_tb + scaleX * float.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[0]), this.margin_lr + scaleY * float.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[1]))

                        };
                        lstPrintInfos.Add(p01);
                    }
                }

            }
            //打印模板

            int Labelrow=1, Labelcol=1;
            float rowGap=0f, colGap=0f;
            if (this.ucCheck1.Checked == true)
            {
                  Labelrow = int.Parse(this.txtLabelRow.Text);
                  Labelcol = int.Parse(this.txtLabelCol.Text);
                  rowGap  = ((height_p - 2 * margin_tb)*1.0f) / Labelrow;
                  colGap = ((width_p - 2 * margin_lr) *1.0f)/ Labelcol;
            }
            
           

           for(int i=0; i< Labelrow; i++)
            {
                for(int j=0; j< Labelcol; j++)
                {
                    foreach (ListViewItem lvi in this.lstContent.Items)
                            {
                 
                                string type = lvi.SubItems[1].Text;
                                string color = lvi.SubItems[2].Text;
                                string start = lvi.SubItems[3].Text;
                                string end = lvi.SubItems[4].Text;
                                int size = int.Parse(lvi.SubItems[5].Text);
                                string fontstyle = lvi.SubItems[6].Text;
                                string content = lvi.SubItems[7].Text;
                                int row = int.Parse(lvi.SubItems[8].Text);
                                int col = int.Parse(lvi.SubItems[9].Text);
                                int dashstyle = int.Parse(lvi.SubItems[10].Text);
                                float width = float.Parse(lvi.SubItems[11].Text);

                                if (type=="格式文本")
                                {
                                    PrintInfo p = new PrintInfo()
                                    {
                                        PrtType = PrintType.FormatText,
                                        PrtColor = ColorTranslator.FromHtml(color),
                                        Content = content,
                                        Size = size,
                                        FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), fontstyle),
                                        Start = GetParsePoint(scaleX, scaleY, start, i, j, rowGap, colGap),
                                        End = GetParsePoint(scaleX, scaleY, end, i, j, rowGap, colGap)
                                    }; //margin_tb + i * scaleX  ,margin_lr + j * scaleY
                                    lstPrintInfos.Add(p);
                                }
                        
                                else if (type=="文本")
                                        {
                                            PrintInfo p = new PrintInfo()
                                            {
                                                PrtType = PrintType.Text,
                                                PrtColor = ColorTranslator.FromHtml(color),
                                                Content = content,
                                                Size = size,
                                                FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), fontstyle),
                                                Start = GetParsePoint(scaleX, scaleY, start, i, j, rowGap, colGap),
                                                End = GetParsePoint(scaleX, scaleY, end, i, j, rowGap, colGap)
                                            }; //margin_tb + i * scaleX  ,margin_lr + j * scaleY
                                            lstPrintInfos.Add(p);
                                        }
                                
                                else if (type == "表格")
                                {
                                    PrintInfo p0 = new PrintInfo()
                                    {
                                        PrtType = PrintType.Table,
                                        PrtColor = ColorTranslator.FromHtml(color),
                                        Width = width,
                                        PrtDashStyle = (DashStyle)(dashstyle),
                                        Row = row,
                                        Column = col,
                                        Start = GetParsePoint(scaleX, scaleY, start, i, j, rowGap, colGap),
                                        End = GetParsePoint(scaleX, scaleY, end, i, j, rowGap, colGap)
                                    };
                                    lstPrintInfos.Add(p0);
                                }
                                else if (type == "直线")
                                {
                                    PrintInfo p1 = new PrintInfo()
                                    {
                                        PrtType = PrintType.Line,
                                        PrtColor = ColorTranslator.FromHtml(color),
                                        Width = width,
                                        PrtDashStyle = (DashStyle)(dashstyle),

                                        Start = GetParsePoint(scaleX, scaleY, start, i, j, rowGap, colGap),
                                        End = GetParsePoint(scaleX, scaleY, end, i, j, rowGap, colGap)
                                    };
                                    lstPrintInfos.Add(p1);
                                }
                                else if (type == "点")
                                {
                                    PrintInfo p2 = new PrintInfo()
                                    {
                                        PrtType = PrintType.Point,

                                        PrtColor = ColorTranslator.FromHtml(color),
                                        Width = width,
                                        Start = GetParsePoint(scaleX,scaleY,start, i, j, rowGap, colGap)
                                    };

                                    lstPrintInfos.Add(p2);
                                }
                            }

                }
            } 

            printHelper.PrintInfos = lstPrintInfos;

           
            //this.ppVControl.Visible = true;
            //this.pdControl.Print();
            this.ppVControl.InvalidatePreview();//刷新文档的预览，重新调用PrintDocument的Print方法
        }

        PointF GetParsePoint(float scaleX,float scaleY,string point,int i,int j,float rowGap, float colGap)
        {
            return new PointF(this.margin_tb + scaleX *(j * colGap + float.Parse(point.Trim(new char[] { '(', ')' }).Split(',')[0])),
                              this.margin_lr + scaleY *(i * rowGap + float.Parse(point.Trim(new char[] { '(', ')' }).Split(',')[1]))); 
        }
        private void BtnCommand_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            ListViewItem lvi  ;
            switch (button.Text)
            {
                case "添加":
                      lvi = new ListViewItem();

                    lvi.Text = this.ucCheck2.Checked==false?"模板":"数据";
                    lvi.SubItems.Add(this.comPrtType.Text.Trim());
                    lvi.SubItems.Add(ColorTranslator.ToHtml(this.lblColor.BackColor));
                    lvi.SubItems.Add(this.txtStart.Text.Trim());
                    lvi.SubItems.Add(this.txtEnd.Text.Trim());
                    lvi.SubItems.Add(this.txtSize.Enabled == false ? "0" : this.txtSize.Text.Trim());
                    lvi.SubItems.Add((this.chkBold.Enabled == false ? "0" : (this.chkBold.Checked ? FontStyle.Bold : FontStyle.Regular).ToString()));
                    lvi.SubItems.Add(this.ucCheck2.Checked == true ? "999" : this.txtTitle.Text.Trim());//模板：内容为0，数据：内容为999

                    lvi.SubItems.Add(this.txtRow.Enabled == false ? "0" : this.txtRow.Text.Trim());
                    lvi.SubItems.Add(this.txtColumn.Enabled == false ? "0" : this.txtColumn.Text.Trim());
                    lvi.SubItems.Add(this.myComboBox1.Enabled == false ? "0" : this.myComboBox1.Text.Trim());
                    lvi.SubItems.Add(this.txtWidth.Enabled == false ? "0" : this.txtWidth.Text.Trim());
                    this.lstContent.Items.Add(lvi);
                    btnRefresh_Click(sender, e);
                    break;
                case "修改":
                    if (this.lstContent.SelectedItems.Count > 0)
                    {
                        int index = lstContent.SelectedIndices[0];
                        if (lstContent.Items[index].SubItems[1].Text == this.comPrtType.Text.Trim())
                        {
                            lstContent.Items[index].SubItems[0].Text = this.ucCheck2.Checked == false ? "模板" : "数据";
                            lstContent.Items[index].SubItems[2].Text = ColorTranslator.ToHtml(this.lblColor.BackColor);
                            lstContent.Items[index].SubItems[3].Text = this.txtStart.Text.Trim();
                            if (this.txtEnd.Enabled == true)
                                lstContent.Items[index].SubItems[4].Text = this.txtEnd.Text.Trim();


                            lstContent.Items[index].SubItems[5].Text = (this.txtSize.Enabled == false ? "0" : this.txtSize.Text.Trim());
                            lstContent.Items[index].SubItems[6].Text = (this.chkBold.Enabled == false ? "0" : (this.chkBold.Checked ? FontStyle.Bold : FontStyle.Regular).ToString());
                            lstContent.Items[index].SubItems[7].Text = this.txtTitle.Enabled == false ? "0" : this.txtTitle.Text.Trim();

                            lstContent.Items[index].SubItems[8].Text = this.txtRow.Enabled == false ? "0" : this.txtRow.Text.Trim();
                            lstContent.Items[index].SubItems[9].Text = this.txtColumn.Enabled == false ? "0" : this.txtColumn.Text.Trim();
                            lstContent.Items[index].SubItems[10].Text = this.myComboBox1.Enabled == false ? "0" : this.myComboBox1.Text.Trim();
                            lstContent.Items[index].SubItems[11].Text = this.txtWidth.Enabled == false ? "0" : this.txtWidth.Text.Trim();
                        }
                        else
                            MessageBox.Show("不同类别不能修改保存！");
                        btnRefresh_Click(sender, e);
                    }
                    break;
                case "平移":

                    break;
                case "删除":
                    foreach (ListViewItem item in lstContent.SelectedItems)
                        lstContent.Items.Remove(item);
                    btnRefresh_Click(sender, e);
                    break;
                case "导入模板":
                    openFileDialog1.Title = "选择需要打开的目标";
                    openFileDialog1.Filter = "Txt(*.txt)|*.txt";
                    
                    if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = null;
                        string fileName = openFileDialog1.FileName;
                        this.lstContent.Items.Clear();
                        try
                        {
                            sr = new StreamReader(fileName);
                            string line;
                            line = sr.ReadLine();//读页面配置
                            string[] str = line.Split(new char[] { '\t' });
                            this.txtPaperWidth.Text = str[0];
                            this.txtPaperHeigh.Text = str[1];
                            this.txtMarginLR.Text = str[2];
                            this.txtMarginTB.Text = str[3];
                            this.txtLabelRow.Text = str[4];
                            this.txtLabelCol.Text = str[5];

                            while ((line = sr.ReadLine()) != null)
                            {
                                str = line.Split(new char[] { '\t' });
                                 lvi = new ListViewItem();
                                
                                lvi.SubItems.Add(str[0]);
                                lvi.SubItems.Add(str[1]);
                                lvi.SubItems.Add(str[2]);
                                lvi.SubItems.Add(str[3]);
                                lvi.SubItems.Add(str[4]);
                                lvi.SubItems.Add(str[5]);
                                lvi.SubItems.Add(str[6]);

                                lvi.SubItems.Add(str[7]);
                                lvi.SubItems.Add(str[8]);
                                lvi.SubItems.Add(str[9]);
                                lvi.SubItems.Add(str[10]);
                                lvi.Text = str[11]==""?"模板": str[11];
                                this.lstContent.Items.Add(lvi);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally { sr.Close(); }
                        this.toolStripStatusLabel2.Text= openFileDialog1.FileName;

                    }
                    break;
                case "导出模板":
                    saveFileDialog1.Filter = "Txt(*.txt)|*.txt";
                    if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog1.FileName;

                        bool flag = true;
                        StreamWriter sw = null;
                        try
                        {
                            sw = new StreamWriter(fileName);
                            sw.WriteLine(this.txtPaperWidth.Text + "\t" + this.txtPaperHeigh.Text + "\t"
                                        + this.txtMarginLR.Text + "\t" + this.txtMarginTB.Text + "\t"
                                        + this.txtLabelRow.Text + "\t" + this.txtLabelCol.Text);
                            foreach (ListViewItem li in this.lstContent.Items)
                            {
                                //PrintInfo plvi = new PrintInfo();
                                string data_template=li.SubItems[0].Text;
                                string type = li.SubItems[1].Text;
                                string color = li.SubItems[2].Text;
                                string start = li.SubItems[3].Text;
                                string end = li.SubItems[4].Text;
                                int size = int.Parse(li.SubItems[5].Text);
                                string fontstyle = li.SubItems[6].Text;
                                string content = li.SubItems[7].Text;
                                int row = int.Parse(li.SubItems[8].Text);
                                int col = int.Parse(li.SubItems[9].Text);
                                int dashstyle = int.Parse(li.SubItems[10].Text);
                                float width = float.Parse(li.SubItems[11].Text);

                                sw.WriteLine(type + "\t" +
                                    color + "\t" + start + "\t" + end + "\t" + size + "\t" +
                                        fontstyle + "\t" + content + "\t" + row + "\t" +
                                            col + "\t" + dashstyle + "\t" + width + "\t"+data_template+"\t");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("写入流异常！" + ex.ToString());
                            flag = false;

                        }
                        finally
                        {
                            sw.Close();
                        }
                        if (flag)
                            MessageBox.Show("文件已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "清空":
                    lstContent.Items.Clear();
                    break;
                case "更新标签":
                    foreach (ListViewItem lv in this.lstContent.Items)
                    {

                    }

                        break;
                case "放大":
                    this.ppVControl.Zoom = this.ppVControl.Zoom * 1.1f;
                    break;
                case "缩小":
                    this.ppVControl.Zoom = this.ppVControl.Zoom / 1.1f;
                    break;


            }  
           
        }

            private void comPrtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabled();

            switch (comPrtType.SelectedItem.ToString()) //获取选择的内�?
            {

                case "文本":
                    this.txtEnd.Enabled = false;
                    this.txtRow.Enabled = false;
                    this.txtColumn.Enabled = false;
                    this.myComboBox1.Enabled = false;
                    this.txtWidth.Enabled = false;

                    break;
                case "格式文本":
                    this.txtEnd.Enabled = true;
                    this.txtRow.Enabled = false;
                    this.txtColumn.Enabled = false;
                    this.myComboBox1.Enabled = false;
                    this.txtWidth.Enabled = false;

                    break;
                case "表格":
                    this.txtSize.Enabled = false;
                    this.chkBold.Enabled = false;
                    this.txtTitle.Enabled = false;

                    //MessageBox.Show("B"); 
                    break;

                case "直线":
                    this.txtSize.Enabled = false;
                    this.chkBold.Enabled = false;
                    this.txtTitle.Enabled = false;
                    this.txtRow.Enabled = false;
                    this.txtColumn.Enabled = false;
                    //MessageBox.Show("C");
                    break;
                case "点":
                    this.txtSize.Enabled = false;
                    this.chkBold.Enabled = false;
                    this.txtEnd.Enabled = false;
                    this.txtRow.Enabled = false;
                    this.txtColumn.Enabled = false;
                    this.txtTitle.Enabled = false;
                    //MessageBox.Show("C"); 
                    break;

            }
        }

        private void SetEnabled()
        {
            this.txtTitle.Enabled = true;
            this.txtStart.Enabled = true;
            this.txtEnd.Enabled = true;
            this.txtStart.Enabled = true;
            this.chkBold.Enabled = true;
            this.txtRow.Enabled = true;
            this.txtColumn.Enabled = true;
            this.txtWidth.Enabled = true;
            this.myComboBox1.Enabled = true;
            this.comPrtType.Enabled = true;
            this.txtSize.Enabled = true;
        }

        private void LstContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabled();

            if (lstContent.SelectedItems.Count > 0)
            {
               
                ListViewItem selectedItem = lstContent.SelectedItems[0];
                string data_template=selectedItem.SubItems[0].Text;
                string type = selectedItem.SubItems[1].Text;
                string color = selectedItem.SubItems[2].Text;
                string start = selectedItem.SubItems[3].Text;
                string end = selectedItem.SubItems[4].Text;
                int size = int.Parse(selectedItem.SubItems[5].Text);
                string fontstyle = selectedItem.SubItems[6].Text;
                string content = selectedItem.SubItems[7].Text;
                int row = int.Parse(selectedItem.SubItems[8].Text);
                int col = int.Parse(selectedItem.SubItems[9].Text);
                int dashstyle = int.Parse(selectedItem.SubItems[10].Text);
                float width = float.Parse(selectedItem.SubItems[11].Text);
                switch (type)
                {
                    case "文本":
                        this.comPrtType.SelectedIndex = 0;

                        this.txtEnd.Enabled = true;
                        this.txtRow.Enabled = false;
                        this.txtColumn.Enabled = false;
                        this.myComboBox1.Enabled = false;
                        this.txtWidth.Enabled = false;
                        break;

                    case "格式文本":
                        this.comPrtType.SelectedIndex = 1;

                        this.txtEnd.Enabled = true;
                        this.txtRow.Enabled = false;
                        this.txtColumn.Enabled = false;
                        this.myComboBox1.Enabled = false;
                        this.txtWidth.Enabled = false;
                        break;

                    case "表格":
                        this.comPrtType.SelectedIndex = 2;
                        this.txtSize.Enabled = false;
                        this.chkBold.Enabled = false;
                        this.txtTitle.Enabled = false;

                        //MessageBox.Show("B"); 
                        break;

                    case "直线":
                        this.comPrtType.SelectedIndex = 3;
                        this.txtSize.Enabled = false;
                        this.chkBold.Enabled = false;
                        this.txtTitle.Enabled = false;
                        this.txtRow.Enabled = false;
                        this.txtColumn.Enabled = false;
                        //MessageBox.Show("C");
                        break;
                    case "点":
                        this.comPrtType.SelectedIndex = 4;
                        this.txtSize.Enabled = false;
                        this.chkBold.Enabled = false;
                        this.txtEnd.Enabled = false;
                        this.txtRow.Enabled = false;
                        this.txtColumn.Enabled = false;
                        this.txtTitle.Enabled = false;

                        break;
                    


                }
                this.ucCheck2.Checked= data_template.Contains("数据")?true:false;
                this.comPrtType.Enabled = false;
                this.lblColor.BackColor = ColorTranslator.FromHtml(selectedItem.SubItems[2].Text);
                this.txtStart.Text = selectedItem.SubItems[3].Text;
                this.txtEnd.Text = selectedItem.SubItems[4].Text;
                this.txtSize.Text = selectedItem.SubItems[5].Text;

                this.chkBold.Checked = selectedItem.SubItems[6].Text == "Bold";

                this.txtTitle.Text = selectedItem.SubItems[7].Text;
                this.txtRow.Text = selectedItem.SubItems[8].Text;
                this.txtColumn.Text = selectedItem.SubItems[9].Text;
                this.myComboBox1.SelectedIndex = int.Parse(selectedItem.SubItems[10].Text);
                this.txtWidth.Text = selectedItem.SubItems[11].Text;

                PointF p = new PointF(int.Parse(this.txtStart.Text.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(this.txtStart.Text.Trim(new char[] { '(', ')' }).Split(',')[1]));
             
                this.vScrollBar1.Value=p.Y>this.vScrollBar1.Maximum?this.vScrollBar1.Maximum:(int) p.Y;
                this.hScrollBar1.Value=p.X>this.hScrollBar1 .Maximum ?this.hScrollBar1 .Maximum: (int)p.X;

            }
            else
                
                        SetDefaultValue();
            
        }

        private void SetDefaultValue()
        {
            this.comPrtType.SelectedIndex = 0;
            this.lblColor.BackColor = Color.Black;
            this.txtStart.Text = "(5,5)";
            this.txtEnd.Text = "(25,35)";
            this.txtSize.Text = "12";

            this.chkBold.Checked = true;

            this.txtTitle.Text = "内容";
            this.txtRow.Text = "3";
            this.txtColumn.Text = "4";
            this.myComboBox1.SelectedIndex = 0;
            this.txtWidth.Text = "0.2";
        }
        // 微调函数，根据指定的微调量微调点的坐标
        public PointF AdjustPoint(PointF point, float xAdjustment, float yAdjustment)
        {
            return new PointF(point.X + xAdjustment, point.Y + yAdjustment);
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)sender;
            if(this.lstContent.SelectedItems.Count>0)
            {
                string start = this.txtStart.Text;

                PointF p = new PointF(int.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[1]));

                PointF padjust =new PointF(0,0);
                 

                if (scrollBar == vScrollBar1)
                {
                    padjust = AdjustPoint(p, 0,e.NewValue-e.OldValue);
                  
                }
                else if (scrollBar == hScrollBar1)
                {
                    padjust = AdjustPoint(p, e.NewValue - e.OldValue, 0);
                    
                }
                string startAdjust = "(" + padjust.X.ToString() + "," + padjust.Y.ToString() + ")";
                this.lstContent.SelectedItems[0].SubItems[3].Text = startAdjust;
                this.txtStart.Text = startAdjust;

                btnRefresh_Click(sender, e);
            }

        }

        private void move1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            
        }

        private void btn_MoveClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            int flagUD = 0, flagLR=0;
            int gap =int.Parse( this.textBox1.Text);
            if (btn == null) return;
            if(btn==btnUp) flagUD = -gap;
            else if(btn==btnDown) flagUD = +gap;
            else if(btn==btnLeft) flagLR = -gap; 
            else if(btn==btnRight) flagLR = +gap;    
             

            if (lstContent.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstContent.SelectedItems)
                {
                    ListViewItem selectedItem = item;
                    string type = selectedItem.SubItems[1].Text;
                    //string color = selectedItem.SubItems[2].Text;
                    string start = selectedItem.SubItems[3].Text;
                    string end = selectedItem.SubItems[4].Text;
                    //int size = int.Parse(selectedItem.SubItems[5].Text);
                    //string fontstyle = selectedItem.SubItems[6].Text;
                    //string content = selectedItem.SubItems[7].Text;
                    //int row = int.Parse(selectedItem.SubItems[8].Text);
                    //int col = int.Parse(selectedItem.SubItems[9].Text);
                    //int dashstyle = int.Parse(selectedItem.SubItems[10].Text);
                    //float width = float.Parse(selectedItem.SubItems[11].Text);
                    PointF pstart = new PointF(int.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(start.Trim(new char[] { '(', ')' }).Split(',')[1]));
                    
                    PointF padjust = new PointF(0, 0);
                    PointF pend;
                    string startAdjust = "";
                    string endAdjust = "";

                    switch (type)
                    {
                        case "格式文本":
                            pend = new PointF(int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[1]));

                            startAdjust = MoveLocation(pstart, flagUD, flagLR);
                            endAdjust = MoveLocation(pend, flagUD, flagLR);

                            item.SubItems[3].Text = startAdjust;
                            this.txtStart.Text = startAdjust;

                            item.SubItems[4].Text = endAdjust;
                            this.txtEnd.Text = endAdjust;

                            break;
                        case "文本":
                            startAdjust = MoveLocation(pstart, flagUD, flagLR);
                            item.SubItems[3].Text = startAdjust;
                            this.txtStart.Text = startAdjust;
                            break;
                        case "点":
                             
                            startAdjust = MoveLocation(pstart,flagUD, flagLR);
                            item.SubItems[3].Text = startAdjust;
                            this.txtStart.Text = startAdjust;
                            break;

                        case "表格":
                              pend = new PointF(int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[1]));

                            startAdjust = MoveLocation(pstart, flagUD, flagLR);
                            endAdjust = MoveLocation(pend, flagUD, flagLR);

                            item.SubItems[3].Text = startAdjust;
                            this.txtStart.Text = startAdjust;

                            item.SubItems[4].Text= endAdjust; 
                            this.txtEnd.Text = endAdjust;

                            break;

                        case "直线":
                              pend = new PointF(int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[0]), int.Parse(end.Trim(new char[] { '(', ')' }).Split(',')[1]));

                            startAdjust = MoveLocation(pstart, flagUD, flagLR);
                            endAdjust = MoveLocation(pend, flagUD, flagLR);

                            item.SubItems[3].Text = startAdjust;
                            this.txtStart.Text = startAdjust;

                            item.SubItems[4].Text = endAdjust;
                            this.txtEnd.Text = endAdjust;

                            break;  

                    }
                    

                    btnRefresh_Click(sender, e);
                }
            }
        }

        private string MoveLocation(PointF pstart,int flagUD, int flagLR )
        {
            PointF padjust = AdjustPoint(pstart, flagLR, flagUD);
            string startAdjust = "(" + padjust.X.ToString() + "," + padjust.Y.ToString() + ")";
            return startAdjust;
        }
        private string MoveTable(PointF pstart, PointF pend, int flagUD, int flagLR)
        {
            PointF padjust = AdjustPoint(pstart, flagLR, flagUD);
            string startAdjust = "(" + padjust.X.ToString() + "," + padjust.Y.ToString() + ")";
            return startAdjust;
        }

        private void ucCheck2_Click(object sender, EventArgs e)
        {
            UCCheck uCCheck = sender as UCCheck;
            if (uCCheck.Checked == false)
            {
                this.label4.Text = "模板";
            }
            else
              { this.label4.Text = "数据";
                this.lblColor.BackColor = Color.Red;
            }


        }

        private void ppVControl_MouseMove(object sender, MouseEventArgs e)
        {
            //// 判断滚轮方向
            //if (e.Delta > 0)
            //{
            //    // 放大操作
            //    zoom *= 1.1f;
            //}
            ////else
            ////{
            ////    // 缩小操作
            ////    zoom /= 1.1f;
            ////}

            //// 应用缩放比例
            //this.ppVControl.Zoom = zoom;
        }

        private void lstContent_DoubleClick(object sender, EventArgs e)
        {

            if (lstContent.SelectedItems.Count > 0)
            {
                // 获取被双击的项
             //   ListViewItem item = lstContent.SelectedItems[0];
             //   PrintInfo plvi = new PrintInfo();
             //   //string data_template = li.SubItems[0].Text;
             //    plvi.PrtType = item.SubItems[1].Text;
             //  plvi.PrtColor= item.SubItems[2].Text;
             //   plvi.Start = item.SubItems[3].Text;
             //   plvi.End = item.SubItems[4].Text;
             //   plvi.Size= int.Parse(item.SubItems[5].Text);
             //  plvi.FontStyle = item.SubItems[6].Text;
             //  plvi.Content = item.SubItems[7].Text;
             // plvi.Row = int.Parse(item.SubItems[8].Text);
             // plvi.Column = int.Parse(item.SubItems[9].Text);
             //plvi.PrtDashStyle = int.Parse(item.SubItems[10].Text);
             // plvi.Width = float.Parse(item.SubItems[11].Text);

            };
        }
    }
}