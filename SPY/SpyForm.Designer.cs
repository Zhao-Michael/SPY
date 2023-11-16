using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPY
{
    [DesignerGenerated()]
    public partial class SpyForm : Form
    {

        // Form 重写 Dispose，以清理组件列表。
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Windows 窗体设计器所必需的
        private System.ComponentModel.IContainer components;

        // 注意:  以下过程是 Windows 窗体设计器所必需的
        // 可以使用 Windows 窗体设计器修改它。  
        // 不要使用代码编辑器修改它。
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpyForm));
            textBoxWinText = new TextBox();
            textBoxEXEPath = new TextBox();
            textBoxWinClass = new TextBox();
            _Label11 = new Label();
            _Label9 = new Label();
            _Label8 = new Label();
            labelWinInfo_Txt = new Label();
            _checkBoxTopmost = new CheckBox();
            _textBoxPID = new TextBox();
            _textBoxHwnd = new TextBox();
            _Label3 = new Label();
            _Label2 = new Label();
            labelMousePos_Txt = new Label();
            _checkBoxFreeMode = new CheckBox();
            ToolTip1 = new ToolTip(components);
            _Label5 = new Label();
            textBoxWinTitle = new TextBox();
            ToolTip2 = new ToolTip(components);
            PicMenu1 = new ContextMenuStrip(components);
            _发送关闭消息ToolStripMenuItem = new ToolStripMenuItem();
            _销毁进程ToolStripMenuItem = new ToolStripMenuItem();
            ToolTip3 = new ToolTip(components);
            SetMenu1 = new ContextMenuStrip(components);
            _发送一次点击ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator3 = new ToolStripSeparator();
            _冻结窗体ToolStripMenuItem = new ToolStripMenuItem();
            _解冻窗体ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator1 = new ToolStripSeparator();
            _隐藏窗口ToolStripMenuItem = new ToolStripMenuItem();
            显示窗口ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator2 = new ToolStripSeparator();
            _强制最小化ToolStripMenuItem = new ToolStripMenuItem();
            _强制最大化ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator4 = new ToolStripSeparator();
            _移动目标窗口ToolStripMenuItem = new ToolStripMenuItem();
            _改变目标窗口大小ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator5 = new ToolStripSeparator();
            _消息控制对话框ToolStripMenuItem = new ToolStripMenuItem();
            _labelColorValue = new Label();
            Label10 = new Label();
            _Label12 = new Label();
            _Label16Decimal = new Label();
            pictureBoxConvert = new PictureBox();
            _PictureBox3 = new PictureBox();
            _pictureBoxSnap = new PictureBox();
            _PictureBox4 = new PictureBox();
            _PictureBox2 = new PictureBox();
            _PictureBoxMouseImage = new PictureBox();
            labelWinInfo = new Label();
            labelMousePos = new Label();
            labelRGB = new Label();
            labelHtmlColor = new Label();
            PicMenu1.SuspendLayout();
            SetMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConvert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_pictureBoxSnap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBoxMouseImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxWinText
            // 
            textBoxWinText.Location = new Point(121, 302);
            textBoxWinText.Margin = new Padding(2, 3, 2, 3);
            textBoxWinText.Multiline = true;
            textBoxWinText.Name = "textBoxWinText";
            textBoxWinText.Size = new Size(210, 40);
            textBoxWinText.TabIndex = 5;
            // 
            // textBoxEXEPath
            // 
            textBoxEXEPath.Location = new Point(121, 356);
            textBoxEXEPath.Margin = new Padding(2, 3, 2, 3);
            textBoxEXEPath.Multiline = true;
            textBoxEXEPath.Name = "textBoxEXEPath";
            textBoxEXEPath.Size = new Size(210, 60);
            textBoxEXEPath.TabIndex = 6;
            // 
            // textBoxWinClass
            // 
            textBoxWinClass.Location = new Point(121, 247);
            textBoxWinClass.Margin = new Padding(2, 3, 2, 3);
            textBoxWinClass.Multiline = true;
            textBoxWinClass.Name = "textBoxWinClass";
            textBoxWinClass.Size = new Size(210, 40);
            textBoxWinClass.TabIndex = 4;
            // 
            // _Label11
            // 
            _Label11.AutoSize = true;
            _Label11.Cursor = Cursors.Hand;
            _Label11.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label11.ForeColor = SystemColors.Highlight;
            _Label11.Location = new Point(42, 359);
            _Label11.Margin = new Padding(4, 0, 4, 0);
            _Label11.Name = "_Label11";
            _Label11.Size = new Size(75, 14);
            _Label11.TabIndex = 35;
            _Label11.Text = "进程路径:";
            _Label11.Click += 打开路径;
            _Label11.DoubleClick += 双击复制;
            // 
            // _Label9
            // 
            _Label9.AutoSize = true;
            _Label9.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label9.ForeColor = SystemColors.Highlight;
            _Label9.Location = new Point(42, 305);
            _Label9.Margin = new Padding(4, 0, 4, 0);
            _Label9.Name = "_Label9";
            _Label9.Size = new Size(75, 14);
            _Label9.TabIndex = 33;
            _Label9.Text = "窗体文本:";
            _Label9.DoubleClick += 双击复制;
            // 
            // _Label8
            // 
            _Label8.AutoSize = true;
            _Label8.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label8.ForeColor = SystemColors.Highlight;
            _Label8.Location = new Point(42, 250);
            _Label8.Margin = new Padding(4, 0, 4, 0);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(75, 14);
            _Label8.TabIndex = 36;
            _Label8.Text = "窗体类名:";
            _Label8.DoubleClick += 双击复制;
            // 
            // labelWinInfo_Txt
            // 
            labelWinInfo_Txt.AutoSize = true;
            labelWinInfo_Txt.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinInfo_Txt.ForeColor = SystemColors.Highlight;
            labelWinInfo_Txt.Location = new Point(12, 38);
            labelWinInfo_Txt.Margin = new Padding(2, 0, 2, 0);
            labelWinInfo_Txt.Name = "labelWinInfo_Txt";
            labelWinInfo_Txt.Size = new Size(105, 14);
            labelWinInfo_Txt.TabIndex = 32;
            labelWinInfo_Txt.Text = "窗口位置大小:";
            // 
            // _checkBoxTopmost
            // 
            _checkBoxTopmost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _checkBoxTopmost.AutoSize = true;
            _checkBoxTopmost.Location = new Point(13, 393);
            _checkBoxTopmost.Margin = new Padding(2, 3, 2, 3);
            _checkBoxTopmost.Name = "_checkBoxTopmost";
            _checkBoxTopmost.Size = new Size(75, 21);
            _checkBoxTopmost.TabIndex = 7;
            _checkBoxTopmost.Text = "置顶窗口";
            _checkBoxTopmost.UseVisualStyleBackColor = true;
            _checkBoxTopmost.CheckedChanged += 置顶;
            // 
            // _textBoxPID
            // 
            _textBoxPID.Location = new Point(121, 158);
            _textBoxPID.Margin = new Padding(2, 3, 2, 3);
            _textBoxPID.Name = "_textBoxPID";
            _textBoxPID.Size = new Size(210, 23);
            _textBoxPID.TabIndex = 2;
            _textBoxPID.TextChanged += PID改变;
            // 
            // _textBoxHwnd
            // 
            _textBoxHwnd.Location = new Point(120, 97);
            _textBoxHwnd.Margin = new Padding(2, 3, 2, 3);
            _textBoxHwnd.Name = "_textBoxHwnd";
            _textBoxHwnd.Size = new Size(210, 23);
            _textBoxHwnd.TabIndex = 1;
            _textBoxHwnd.TextChanged += TextBoxHwnd_TextChanged;
            // 
            // _Label3
            // 
            _Label3.AutoSize = true;
            _Label3.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label3.ForeColor = SystemColors.Highlight;
            _Label3.Location = new Point(48, 162);
            _Label3.Margin = new Padding(4, 0, 4, 0);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(69, 14);
            _Label3.TabIndex = 25;
            _Label3.Text = "窗体PID:";
            _Label3.DoubleClick += 双击复制;
            // 
            // _Label2
            // 
            _Label2.AutoSize = true;
            _Label2.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label2.ForeColor = SystemColors.Highlight;
            _Label2.Location = new Point(42, 101);
            _Label2.Margin = new Padding(4, 0, 4, 0);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(75, 14);
            _Label2.TabIndex = 34;
            _Label2.Text = "窗口句柄:";
            _Label2.DoubleClick += 双击复制;
            _Label2.MouseDoubleClick += 双击复制句柄;
            // 
            // labelMousePos_Txt
            // 
            labelMousePos_Txt.AutoSize = true;
            labelMousePos_Txt.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelMousePos_Txt.ForeColor = SystemColors.Highlight;
            labelMousePos_Txt.Location = new Point(12, 7);
            labelMousePos_Txt.Margin = new Padding(2, 0, 2, 0);
            labelMousePos_Txt.Name = "labelMousePos_Txt";
            labelMousePos_Txt.Size = new Size(105, 14);
            labelMousePos_Txt.TabIndex = 31;
            labelMousePos_Txt.Text = "当前鼠标位置:";
            // 
            // _checkBoxFreeMode
            // 
            _checkBoxFreeMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _checkBoxFreeMode.AutoSize = true;
            _checkBoxFreeMode.Checked = true;
            _checkBoxFreeMode.CheckState = CheckState.Checked;
            _checkBoxFreeMode.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _checkBoxFreeMode.ForeColor = Color.Salmon;
            _checkBoxFreeMode.Location = new Point(208, 4);
            _checkBoxFreeMode.Margin = new Padding(2, 3, 2, 3);
            _checkBoxFreeMode.Name = "_checkBoxFreeMode";
            _checkBoxFreeMode.Size = new Size(111, 16);
            _checkBoxFreeMode.TabIndex = 0;
            _checkBoxFreeMode.Text = "自由模式 (&F3)";
            _checkBoxFreeMode.TextImageRelation = TextImageRelation.ImageAboveText;
            _checkBoxFreeMode.UseVisualStyleBackColor = true;
            _checkBoxFreeMode.CheckedChanged += 自由模式;
            // 
            // _Label5
            // 
            _Label5.AutoSize = true;
            _Label5.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _Label5.ForeColor = SystemColors.Highlight;
            _Label5.Location = new Point(42, 197);
            _Label5.Margin = new Padding(4, 0, 4, 0);
            _Label5.Name = "_Label5";
            _Label5.Size = new Size(75, 14);
            _Label5.TabIndex = 36;
            _Label5.Text = "窗体标题:";
            _Label5.DoubleClick += 双击复制;
            // 
            // textBoxWinTitle
            // 
            textBoxWinTitle.Location = new Point(121, 194);
            textBoxWinTitle.Margin = new Padding(2, 3, 2, 3);
            textBoxWinTitle.Multiline = true;
            textBoxWinTitle.Name = "textBoxWinTitle";
            textBoxWinTitle.Size = new Size(210, 40);
            textBoxWinTitle.TabIndex = 3;
            // 
            // PicMenu1
            // 
            PicMenu1.ImageScalingSize = new Size(20, 20);
            PicMenu1.Items.AddRange(new ToolStripItem[] { _发送关闭消息ToolStripMenuItem, _销毁进程ToolStripMenuItem });
            PicMenu1.Name = "PicMenu1";
            PicMenu1.Size = new Size(149, 48);
            // 
            // _发送关闭消息ToolStripMenuItem
            // 
            _发送关闭消息ToolStripMenuItem.Name = "_发送关闭消息ToolStripMenuItem";
            _发送关闭消息ToolStripMenuItem.Size = new Size(148, 22);
            _发送关闭消息ToolStripMenuItem.Text = "发送关闭消息";
            _发送关闭消息ToolStripMenuItem.Click += 发送关闭消息ToolStripMenuItem_Click;
            // 
            // _销毁进程ToolStripMenuItem
            // 
            _销毁进程ToolStripMenuItem.Name = "_销毁进程ToolStripMenuItem";
            _销毁进程ToolStripMenuItem.Size = new Size(148, 22);
            _销毁进程ToolStripMenuItem.Text = "杀死进程";
            _销毁进程ToolStripMenuItem.Click += 销毁进程ToolStripMenuItem_Click;
            // 
            // SetMenu1
            // 
            SetMenu1.ImageScalingSize = new Size(24, 24);
            SetMenu1.Items.AddRange(new ToolStripItem[] { _发送一次点击ToolStripMenuItem, ToolStripSeparator3, _冻结窗体ToolStripMenuItem, _解冻窗体ToolStripMenuItem, ToolStripSeparator1, _隐藏窗口ToolStripMenuItem, 显示窗口ToolStripMenuItem, ToolStripSeparator2, _强制最小化ToolStripMenuItem, _强制最大化ToolStripMenuItem, ToolStripSeparator4, _移动目标窗口ToolStripMenuItem, _改变目标窗口大小ToolStripMenuItem, ToolStripSeparator5, _消息控制对话框ToolStripMenuItem });
            SetMenu1.Name = "SetMenu1";
            SetMenu1.Size = new Size(173, 254);
            // 
            // _发送一次点击ToolStripMenuItem
            // 
            _发送一次点击ToolStripMenuItem.Name = "_发送一次点击ToolStripMenuItem";
            _发送一次点击ToolStripMenuItem.Size = new Size(172, 22);
            _发送一次点击ToolStripMenuItem.Text = "发送一次点击";
            _发送一次点击ToolStripMenuItem.Click += 发送一次点击ToolStripMenuItem_Click;
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(169, 6);
            // 
            // _冻结窗体ToolStripMenuItem
            // 
            _冻结窗体ToolStripMenuItem.Name = "_冻结窗体ToolStripMenuItem";
            _冻结窗体ToolStripMenuItem.Size = new Size(172, 22);
            _冻结窗体ToolStripMenuItem.Text = "冻结窗口";
            _冻结窗体ToolStripMenuItem.Click += 冻结窗体ToolStripMenuItem_Click_1;
            // 
            // _解冻窗体ToolStripMenuItem
            // 
            _解冻窗体ToolStripMenuItem.Name = "_解冻窗体ToolStripMenuItem";
            _解冻窗体ToolStripMenuItem.Size = new Size(172, 22);
            _解冻窗体ToolStripMenuItem.Text = "解冻窗口";
            _解冻窗体ToolStripMenuItem.Click += 解冻窗体ToolStripMenuItem_Click_1;
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(169, 6);
            // 
            // _隐藏窗口ToolStripMenuItem
            // 
            _隐藏窗口ToolStripMenuItem.Name = "_隐藏窗口ToolStripMenuItem";
            _隐藏窗口ToolStripMenuItem.Size = new Size(172, 22);
            _隐藏窗口ToolStripMenuItem.Text = "隐藏窗口";
            _隐藏窗口ToolStripMenuItem.Click += 隐藏窗口ToolStripMenuItem_Click;
            // 
            // 显示窗口ToolStripMenuItem
            // 
            显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            显示窗口ToolStripMenuItem.Size = new Size(172, 22);
            显示窗口ToolStripMenuItem.Text = "显示窗口";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(169, 6);
            // 
            // _强制最小化ToolStripMenuItem
            // 
            _强制最小化ToolStripMenuItem.Name = "_强制最小化ToolStripMenuItem";
            _强制最小化ToolStripMenuItem.Size = new Size(172, 22);
            _强制最小化ToolStripMenuItem.Text = "强制最小化";
            _强制最小化ToolStripMenuItem.Click += 强制最小化ToolStripMenuItem_Click;
            // 
            // _强制最大化ToolStripMenuItem
            // 
            _强制最大化ToolStripMenuItem.Name = "_强制最大化ToolStripMenuItem";
            _强制最大化ToolStripMenuItem.Size = new Size(172, 22);
            _强制最大化ToolStripMenuItem.Text = "强制最大化";
            _强制最大化ToolStripMenuItem.Click += 强制最大化ToolStripMenuItem_Click;
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator4.Size = new Size(169, 6);
            // 
            // _移动目标窗口ToolStripMenuItem
            // 
            _移动目标窗口ToolStripMenuItem.Name = "_移动目标窗口ToolStripMenuItem";
            _移动目标窗口ToolStripMenuItem.Size = new Size(172, 22);
            _移动目标窗口ToolStripMenuItem.Text = "移动目标窗口";
            _移动目标窗口ToolStripMenuItem.Click += 移动目标窗口ToolStripMenuItem_Click;
            // 
            // _改变目标窗口大小ToolStripMenuItem
            // 
            _改变目标窗口大小ToolStripMenuItem.Name = "_改变目标窗口大小ToolStripMenuItem";
            _改变目标窗口大小ToolStripMenuItem.Size = new Size(172, 22);
            _改变目标窗口大小ToolStripMenuItem.Text = "改变目标窗口大小";
            _改变目标窗口大小ToolStripMenuItem.Click += 改变目标窗口大小ToolStripMenuItem_Click;
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator5.Size = new Size(169, 6);
            // 
            // _消息控制对话框ToolStripMenuItem
            // 
            _消息控制对话框ToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _消息控制对话框ToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            _消息控制对话框ToolStripMenuItem.Name = "_消息控制对话框ToolStripMenuItem";
            _消息控制对话框ToolStripMenuItem.Size = new Size(172, 22);
            _消息控制对话框ToolStripMenuItem.Text = "消息控制对话框";
            _消息控制对话框ToolStripMenuItem.Click += 消息控制对话框ToolStripMenuItem_Click;
            // 
            // _labelColorValue
            // 
            _labelColorValue.AutoSize = true;
            _labelColorValue.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            _labelColorValue.ForeColor = SystemColors.Highlight;
            _labelColorValue.Location = new Point(72, 69);
            _labelColorValue.Margin = new Padding(2, 0, 2, 0);
            _labelColorValue.Name = "_labelColorValue";
            _labelColorValue.Size = new Size(45, 14);
            _labelColorValue.TabIndex = 32;
            _labelColorValue.Text = "颜色:";
            // 
            // Label10
            // 
            Label10.BackColor = Color.Transparent;
            Label10.Location = new Point(44, 65);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(23, 23);
            Label10.TabIndex = 44;
            // 
            // _Label12
            // 
            _Label12.AutoSize = true;
            _Label12.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _Label12.ForeColor = SystemColors.Desktop;
            _Label12.Location = new Point(62, 130);
            _Label12.Margin = new Padding(4, 0, 4, 0);
            _Label12.Name = "_Label12";
            _Label12.Size = new Size(53, 17);
            _Label12.TabIndex = 45;
            _Label12.Text = "16 进制:";
            _Label12.DoubleClick += 双击复制;
            // 
            // _Label16Decimal
            // 
            _Label16Decimal.Location = new Point(121, 126);
            _Label16Decimal.Margin = new Padding(4, 0, 4, 0);
            _Label16Decimal.Name = "_Label16Decimal";
            _Label16Decimal.Size = new Size(210, 25);
            _Label16Decimal.TabIndex = 46;
            _Label16Decimal.TextAlign = ContentAlignment.MiddleLeft;
            _Label16Decimal.DoubleClick += 双击复制;
            // 
            // pictureBoxConvert
            // 
            pictureBoxConvert.Cursor = Cursors.Hand;
            pictureBoxConvert.Image = (Image)resources.GetObject("pictureBoxConvert.Image");
            pictureBoxConvert.Location = new Point(337, 359);
            pictureBoxConvert.Margin = new Padding(4);
            pictureBoxConvert.Name = "pictureBoxConvert";
            pictureBoxConvert.Size = new Size(23, 23);
            pictureBoxConvert.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConvert.TabIndex = 48;
            pictureBoxConvert.TabStop = false;
            pictureBoxConvert.Click += pictureBoxConvert_Click;
            // 
            // _PictureBox3
            // 
            _PictureBox3.Image = (Image)resources.GetObject("_PictureBox3.Image");
            _PictureBox3.Location = new Point(335, 158);
            _PictureBox3.Margin = new Padding(4);
            _PictureBox3.Name = "_PictureBox3";
            _PictureBox3.Size = new Size(23, 23);
            _PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            _PictureBox3.TabIndex = 47;
            _PictureBox3.TabStop = false;
            _PictureBox3.Click += 弹出菜单2;
            _PictureBox3.MouseEnter += PictureBox3_MouseEnter;
            _PictureBox3.MouseLeave += PictureBox3_MouseLeave;
            // 
            // _pictureBoxSnap
            // 
            _pictureBoxSnap.Location = new Point(322, 48);
            _pictureBoxSnap.Margin = new Padding(2, 3, 2, 3);
            _pictureBoxSnap.Name = "_pictureBoxSnap";
            _pictureBoxSnap.Size = new Size(39, 39);
            _pictureBoxSnap.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBoxSnap.TabIndex = 43;
            _pictureBoxSnap.TabStop = false;
            _pictureBoxSnap.Paint += PictureBox5_Paint;
            // 
            // _PictureBox4
            // 
            _PictureBox4.Cursor = Cursors.Hand;
            _PictureBox4.Image = (Image)resources.GetObject("_PictureBox4.Image");
            _PictureBox4.Location = new Point(336, 97);
            _PictureBox4.Margin = new Padding(4);
            _PictureBox4.Name = "_PictureBox4";
            _PictureBox4.Size = new Size(23, 23);
            _PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            _PictureBox4.TabIndex = 42;
            _PictureBox4.TabStop = false;
            _PictureBox4.Click += 弹出菜单1;
            _PictureBox4.MouseEnter += PictureBox4_MouseHover;
            _PictureBox4.MouseLeave += PictureBox4_MouseLeave;
            // 
            // _PictureBox2
            // 
            _PictureBox2.Cursor = Cursors.Hand;
            _PictureBox2.Image = (Image)resources.GetObject("_PictureBox2.Image");
            _PictureBox2.Location = new Point(337, 302);
            _PictureBox2.Margin = new Padding(4);
            _PictureBox2.Name = "_PictureBox2";
            _PictureBox2.Size = new Size(23, 23);
            _PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            _PictureBox2.TabIndex = 40;
            _PictureBox2.TabStop = false;
            _PictureBox2.MouseClick += PictureBox2_MouseClick;
            _PictureBox2.MouseEnter += PictureBox2_MouseEnter;
            _PictureBox2.MouseLeave += PictureBox2_MouseLeave;
            // 
            // _PictureBoxMouseImage
            // 
            _PictureBoxMouseImage.BorderStyle = BorderStyle.FixedSingle;
            _PictureBoxMouseImage.Image = (Image)resources.GetObject("_PictureBoxMouseImage.Image");
            _PictureBoxMouseImage.Location = new Point(326, 3);
            _PictureBoxMouseImage.Margin = new Padding(2, 3, 2, 3);
            _PictureBoxMouseImage.Name = "_PictureBoxMouseImage";
            _PictureBoxMouseImage.Size = new Size(32, 33);
            _PictureBoxMouseImage.SizeMode = PictureBoxSizeMode.CenterImage;
            _PictureBoxMouseImage.TabIndex = 0;
            _PictureBoxMouseImage.TabStop = false;
            _PictureBoxMouseImage.MouseDown += 按下图片;
            _PictureBoxMouseImage.MouseLeave += PictureBox1_MouseLeave;
            _PictureBoxMouseImage.MouseHover += PictureBox1_MouseHover;
            _PictureBoxMouseImage.MouseUp += 松开图片;
            // 
            // labelWinInfo
            // 
            labelWinInfo.AutoSize = true;
            labelWinInfo.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinInfo.ForeColor = SystemColors.Highlight;
            labelWinInfo.Location = new Point(121, 38);
            labelWinInfo.Margin = new Padding(2, 0, 2, 0);
            labelWinInfo.Name = "labelWinInfo";
            labelWinInfo.Size = new Size(39, 14);
            labelWinInfo.TabIndex = 32;
            labelWinInfo.Text = "----";
            labelWinInfo.DoubleClick += 双击复制;
            // 
            // labelMousePos
            // 
            labelMousePos.AutoSize = true;
            labelMousePos.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelMousePos.ForeColor = SystemColors.Highlight;
            labelMousePos.Location = new Point(121, 7);
            labelMousePos.Margin = new Padding(2, 0, 2, 0);
            labelMousePos.Name = "labelMousePos";
            labelMousePos.Size = new Size(39, 14);
            labelMousePos.TabIndex = 31;
            labelMousePos.Text = "----";
            // 
            // labelRGB
            // 
            labelRGB.AutoSize = true;
            labelRGB.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelRGB.ForeColor = SystemColors.Highlight;
            labelRGB.Location = new Point(121, 69);
            labelRGB.Margin = new Padding(2, 0, 2, 0);
            labelRGB.Name = "labelRGB";
            labelRGB.Size = new Size(39, 14);
            labelRGB.TabIndex = 32;
            labelRGB.Text = "----";
            labelRGB.Click += 双击复制;
            // 
            // labelHtmlColor
            // 
            labelHtmlColor.AutoSize = true;
            labelHtmlColor.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            labelHtmlColor.ForeColor = SystemColors.Highlight;
            labelHtmlColor.Location = new Point(223, 69);
            labelHtmlColor.Margin = new Padding(2, 0, 2, 0);
            labelHtmlColor.Name = "labelHtmlColor";
            labelHtmlColor.Size = new Size(39, 14);
            labelHtmlColor.TabIndex = 32;
            labelHtmlColor.Text = "----";
            labelHtmlColor.Click += 双击复制;
            // 
            // SpyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 425);
            Controls.Add(pictureBoxConvert);
            Controls.Add(_PictureBox3);
            Controls.Add(_Label16Decimal);
            Controls.Add(_Label12);
            Controls.Add(Label10);
            Controls.Add(_pictureBoxSnap);
            Controls.Add(_PictureBox4);
            Controls.Add(_PictureBox2);
            Controls.Add(_PictureBoxMouseImage);
            Controls.Add(_checkBoxTopmost);
            Controls.Add(_checkBoxFreeMode);
            Controls.Add(textBoxWinText);
            Controls.Add(textBoxEXEPath);
            Controls.Add(textBoxWinTitle);
            Controls.Add(textBoxWinClass);
            Controls.Add(_Label11);
            Controls.Add(_Label5);
            Controls.Add(_Label9);
            Controls.Add(_Label8);
            Controls.Add(labelHtmlColor);
            Controls.Add(labelRGB);
            Controls.Add(_labelColorValue);
            Controls.Add(labelWinInfo);
            Controls.Add(labelWinInfo_Txt);
            Controls.Add(_textBoxPID);
            Controls.Add(_textBoxHwnd);
            Controls.Add(_Label3);
            Controls.Add(_Label2);
            Controls.Add(labelMousePos);
            Controls.Add(labelMousePos_Txt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPY++";
            Deactivate += 失去焦点;
            FormClosing += SPYFORM_FormClosing;
            Load += SPYFORM_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            PicMenu1.ResumeLayout(false);
            SetMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxConvert).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)_pictureBoxSnap).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBoxMouseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox _PictureBoxMouseImage;

        internal PictureBox PictureBoxMouseImage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBoxMouseImage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBoxMouseImage != null)
                {
                    _PictureBoxMouseImage.MouseDown -= 按下图片;
                    _PictureBoxMouseImage.MouseUp -= 松开图片;
                    _PictureBoxMouseImage.MouseHover -= PictureBox1_MouseHover;
                    _PictureBoxMouseImage.MouseLeave -= PictureBox1_MouseLeave;
                }

                _PictureBoxMouseImage = value;
                if (_PictureBoxMouseImage != null)
                {
                    _PictureBoxMouseImage.MouseDown += 按下图片;
                    _PictureBoxMouseImage.MouseUp += 松开图片;
                    _PictureBoxMouseImage.MouseHover += PictureBox1_MouseHover;
                    _PictureBoxMouseImage.MouseLeave += PictureBox1_MouseLeave;
                }
            }
        }

        internal TextBox textBoxWinText;
        internal TextBox textBoxEXEPath;
        internal TextBox textBoxWinClass;
        private Label _Label11;

        internal Label Label11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label11 != null)
                {
                    _Label11.Click -= 打开路径;
                    _Label11.DoubleClick -= 双击复制;
                }

                _Label11 = value;
                if (_Label11 != null)
                {
                    _Label11.Click += 打开路径;
                    _Label11.DoubleClick += 双击复制;
                }
            }
        }

        private Label _Label9;

        internal Label Label9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label9 != null)
                {
                    _Label9.DoubleClick -= 双击复制;
                }

                _Label9 = value;
                if (_Label9 != null)
                {
                    _Label9.DoubleClick += 双击复制;
                }
            }
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                    _Label8.DoubleClick -= 双击复制;
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                    _Label8.DoubleClick += 双击复制;
                }
            }
        }

        internal Label labelWinInfo_Txt;
        private CheckBox _checkBoxTopmost;

        internal CheckBox checkBoxTopmost
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkBoxTopmost;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkBoxTopmost != null)
                {
                    _checkBoxTopmost.CheckedChanged -= 置顶;
                }

                _checkBoxTopmost = value;
                if (_checkBoxTopmost != null)
                {
                    _checkBoxTopmost.CheckedChanged += 置顶;
                }
            }
        }

        private TextBox _textBoxPID;

        internal TextBox textBoxPID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBoxPID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBoxPID != null)
                {
                    _textBoxPID.TextChanged -= PID改变;
                }

                _textBoxPID = value;
                if (_textBoxPID != null)
                {
                    _textBoxPID.TextChanged += PID改变;
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                    _Label3.DoubleClick -= 双击复制;
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                    _Label3.DoubleClick += 双击复制;
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                    _Label2.DoubleClick -= 双击复制;
                    _Label2.MouseDoubleClick -= 双击复制句柄;
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                    _Label2.DoubleClick += 双击复制;
                    _Label2.MouseDoubleClick += 双击复制句柄;
                }
            }
        }

        internal Label labelMousePos_Txt;
        private CheckBox _checkBoxFreeMode;

        internal CheckBox checkBoxFreeMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkBoxFreeMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkBoxFreeMode != null)
                {
                    _checkBoxFreeMode.CheckedChanged -= 自由模式;
                }

                _checkBoxFreeMode = value;
                if (_checkBoxFreeMode != null)
                {
                    _checkBoxFreeMode.CheckedChanged += 自由模式;
                }
            }
        }

        internal ToolTip ToolTip1;
        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                    _Label5.DoubleClick -= 双击复制;
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                    _Label5.DoubleClick += 双击复制;
                }
            }
        }

        internal TextBox textBoxWinTitle;
        internal ToolTip ToolTip2;
        private PictureBox _PictureBox2;

        internal PictureBox PictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox2 != null)
                {
                    _PictureBox2.MouseEnter -= PictureBox2_MouseEnter;
                    _PictureBox2.MouseLeave -= PictureBox2_MouseLeave;
                    _PictureBox2.MouseClick -= PictureBox2_MouseClick;
                }

                _PictureBox2 = value;
                if (_PictureBox2 != null)
                {
                    _PictureBox2.MouseEnter += PictureBox2_MouseEnter;
                    _PictureBox2.MouseLeave += PictureBox2_MouseLeave;
                    _PictureBox2.MouseClick += PictureBox2_MouseClick;
                }
            }
        }

        internal PictureBox PictureBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox3 != null)
                {
                    _PictureBox3.MouseEnter -= PictureBox3_MouseEnter;
                    _PictureBox3.MouseLeave -= PictureBox3_MouseLeave;
                    _PictureBox3.Click -= 弹出菜单2;
                }

                _PictureBox3 = value;
                if (_PictureBox3 != null)
                {
                    _PictureBox3.MouseEnter += PictureBox3_MouseEnter;
                    _PictureBox3.MouseLeave += PictureBox3_MouseLeave;
                    _PictureBox3.Click += 弹出菜单2;
                }
            }
        }

        internal ToolTip ToolTip3;
        internal ContextMenuStrip PicMenu1;
        private ToolStripMenuItem _发送关闭消息ToolStripMenuItem;

        internal ToolStripMenuItem 发送关闭消息ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _发送关闭消息ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_发送关闭消息ToolStripMenuItem != null)
                {
                    _发送关闭消息ToolStripMenuItem.Click -= 发送关闭消息ToolStripMenuItem_Click;
                }

                _发送关闭消息ToolStripMenuItem = value;
                if (_发送关闭消息ToolStripMenuItem != null)
                {
                    _发送关闭消息ToolStripMenuItem.Click += 发送关闭消息ToolStripMenuItem_Click;
                }
            }
        }

        private PictureBox _PictureBox4;

        internal PictureBox PictureBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click -= 弹出菜单1;
                    _PictureBox4.MouseEnter -= PictureBox4_MouseHover;
                    _PictureBox4.MouseLeave -= PictureBox4_MouseLeave;
                }

                _PictureBox4 = value;
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click += 弹出菜单1;
                    _PictureBox4.MouseEnter += PictureBox4_MouseHover;
                    _PictureBox4.MouseLeave += PictureBox4_MouseLeave;
                }
            }
        }

        internal ContextMenuStrip SetMenu1;
        private ToolStripMenuItem _冻结窗体ToolStripMenuItem;

        internal ToolStripMenuItem 冻结窗体ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _冻结窗体ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_冻结窗体ToolStripMenuItem != null)
                {
                    _冻结窗体ToolStripMenuItem.Click -= 冻结窗体ToolStripMenuItem_Click_1;
                }

                _冻结窗体ToolStripMenuItem = value;
                if (_冻结窗体ToolStripMenuItem != null)
                {
                    _冻结窗体ToolStripMenuItem.Click += 冻结窗体ToolStripMenuItem_Click_1;
                }
            }
        }

        private ToolStripMenuItem _解冻窗体ToolStripMenuItem;

        internal ToolStripMenuItem 解冻窗体ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _解冻窗体ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_解冻窗体ToolStripMenuItem != null)
                {
                    _解冻窗体ToolStripMenuItem.Click -= 解冻窗体ToolStripMenuItem_Click_1;
                }

                _解冻窗体ToolStripMenuItem = value;
                if (_解冻窗体ToolStripMenuItem != null)
                {
                    _解冻窗体ToolStripMenuItem.Click += 解冻窗体ToolStripMenuItem_Click_1;
                }
            }
        }

        private ToolStripMenuItem _销毁进程ToolStripMenuItem;

        internal ToolStripMenuItem 销毁进程ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _销毁进程ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_销毁进程ToolStripMenuItem != null)
                {
                    _销毁进程ToolStripMenuItem.Click -= 销毁进程ToolStripMenuItem_Click;
                }

                _销毁进程ToolStripMenuItem = value;
                if (_销毁进程ToolStripMenuItem != null)
                {
                    _销毁进程ToolStripMenuItem.Click += 销毁进程ToolStripMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator1;
        private ToolStripMenuItem _隐藏窗口ToolStripMenuItem;

        internal ToolStripMenuItem 隐藏窗口ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _隐藏窗口ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_隐藏窗口ToolStripMenuItem != null)
                {
                    _隐藏窗口ToolStripMenuItem.Click -= 隐藏窗口ToolStripMenuItem_Click;
                }

                _隐藏窗口ToolStripMenuItem = value;
                if (_隐藏窗口ToolStripMenuItem != null)
                {
                    _隐藏窗口ToolStripMenuItem.Click += 隐藏窗口ToolStripMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem 显示窗口ToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator2;
        private ToolStripMenuItem _强制最小化ToolStripMenuItem;

        internal ToolStripMenuItem 强制最小化ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _强制最小化ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_强制最小化ToolStripMenuItem != null)
                {
                    _强制最小化ToolStripMenuItem.Click -= 强制最小化ToolStripMenuItem_Click;
                }

                _强制最小化ToolStripMenuItem = value;
                if (_强制最小化ToolStripMenuItem != null)
                {
                    _强制最小化ToolStripMenuItem.Click += 强制最小化ToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _强制最大化ToolStripMenuItem;

        internal ToolStripMenuItem 强制最大化ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _强制最大化ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_强制最大化ToolStripMenuItem != null)
                {
                    _强制最大化ToolStripMenuItem.Click -= 强制最大化ToolStripMenuItem_Click;
                }

                _强制最大化ToolStripMenuItem = value;
                if (_强制最大化ToolStripMenuItem != null)
                {
                    _强制最大化ToolStripMenuItem.Click += 强制最大化ToolStripMenuItem_Click;
                }
            }
        }

        private Label _labelColorValue;

        internal Label labelColorValue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _labelColorValue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_labelColorValue != null)
                {
                    _labelColorValue.Click -= 双击复制;
                }

                _labelColorValue = value;
                if (_labelColorValue != null)
                {
                    _labelColorValue.Click += 双击复制;
                }
            }
        }

        private PictureBox _pictureBoxSnap;

        internal PictureBox pictureBoxSnap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pictureBoxSnap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pictureBoxSnap != null)
                {
                    _pictureBoxSnap.Paint -= PictureBox5_Paint;
                }

                _pictureBoxSnap = value;
                if (_pictureBoxSnap != null)
                {
                    _pictureBoxSnap.Paint += PictureBox5_Paint;
                }
            }
        }

        internal Label Label10;
        private ToolStripMenuItem _发送一次点击ToolStripMenuItem;

        internal ToolStripMenuItem 发送一次点击ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _发送一次点击ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_发送一次点击ToolStripMenuItem != null)
                {
                    _发送一次点击ToolStripMenuItem.Click -= 发送一次点击ToolStripMenuItem_Click;
                }

                _发送一次点击ToolStripMenuItem = value;
                if (_发送一次点击ToolStripMenuItem != null)
                {
                    _发送一次点击ToolStripMenuItem.Click += 发送一次点击ToolStripMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripSeparator ToolStripSeparator4;
        private ToolStripMenuItem _移动目标窗口ToolStripMenuItem;

        internal ToolStripMenuItem 移动目标窗口ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _移动目标窗口ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_移动目标窗口ToolStripMenuItem != null)
                {
                    _移动目标窗口ToolStripMenuItem.Click -= 移动目标窗口ToolStripMenuItem_Click;
                }

                _移动目标窗口ToolStripMenuItem = value;
                if (_移动目标窗口ToolStripMenuItem != null)
                {
                    _移动目标窗口ToolStripMenuItem.Click += 移动目标窗口ToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _改变目标窗口大小ToolStripMenuItem;

        internal ToolStripMenuItem 改变目标窗口大小ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _改变目标窗口大小ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_改变目标窗口大小ToolStripMenuItem != null)
                {
                    _改变目标窗口大小ToolStripMenuItem.Click -= 改变目标窗口大小ToolStripMenuItem_Click;
                }

                _改变目标窗口大小ToolStripMenuItem = value;
                if (_改变目标窗口大小ToolStripMenuItem != null)
                {
                    _改变目标窗口大小ToolStripMenuItem.Click += 改变目标窗口大小ToolStripMenuItem_Click;
                }
            }
        }

        private Label _Label12;

        internal Label Label12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label12 != null)
                {
                    _Label12.DoubleClick -= 双击复制;
                }

                _Label12 = value;
                if (_Label12 != null)
                {
                    _Label12.DoubleClick += 双击复制;
                }
            }
        }

        private Label _Label16Decimal;

        internal Label Label16Decimal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label16Decimal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label16Decimal != null)
                {
                    _Label16Decimal.DoubleClick -= 双击复制;
                }

                _Label16Decimal = value;
                if (_Label16Decimal != null)
                {
                    _Label16Decimal.DoubleClick += 双击复制;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator5;
        private ToolStripMenuItem _消息控制对话框ToolStripMenuItem;

        internal ToolStripMenuItem 消息控制对话框ToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _消息控制对话框ToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_消息控制对话框ToolStripMenuItem != null)
                {
                    _消息控制对话框ToolStripMenuItem.Click -= 消息控制对话框ToolStripMenuItem_Click;
                }

                _消息控制对话框ToolStripMenuItem = value;
                if (_消息控制对话框ToolStripMenuItem != null)
                {
                    _消息控制对话框ToolStripMenuItem.Click += 消息控制对话框ToolStripMenuItem_Click;
                }
            }
        }

        private TextBox _textBoxHwnd;
        private PictureBox _PictureBox3;
        private PictureBox pictureBoxConvert;
        internal Label labelWinInfo;
        internal Label labelMousePos;
        private Label labelRGB;
        private Label labelHtmlColor;

        public TextBox textBoxHwnd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _textBoxHwnd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBoxHwnd != null)
                {
                    _textBoxHwnd.TextChanged -= TextBoxHwnd_TextChanged;
                }

                _textBoxHwnd = value;
                if (_textBoxHwnd != null)
                {
                    _textBoxHwnd.TextChanged += TextBoxHwnd_TextChanged;
                }
            }
        }
    }
}