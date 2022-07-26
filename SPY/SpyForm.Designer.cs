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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpyForm));
            this.textBoxWinText = new System.Windows.Forms.TextBox();
            this.textBoxEXEPath = new System.Windows.Forms.TextBox();
            this.textBoxWinClass = new System.Windows.Forms.TextBox();
            this._Label11 = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this.labelWinInfo = new System.Windows.Forms.Label();
            this._checkBoxTopmost = new System.Windows.Forms.CheckBox();
            this._textBoxPID = new System.Windows.Forms.TextBox();
            this._textBoxHwnd = new System.Windows.Forms.TextBox();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this.labelMousePos = new System.Windows.Forms.Label();
            this._checkBoxFreeMode = new System.Windows.Forms.CheckBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._Label5 = new System.Windows.Forms.Label();
            this.textBoxWinTitle = new System.Windows.Forms.TextBox();
            this.ToolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.PicMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._发送关闭消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._销毁进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SetMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._发送一次点击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._冻结窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._解冻窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._隐藏窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._强制最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._强制最大化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._移动目标窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._改变目标窗口大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._消息控制对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._labelColorValue = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this._Label12 = new System.Windows.Forms.Label();
            this._Label16Decimal = new System.Windows.Forms.Label();
            this.pictureBoxConvert = new System.Windows.Forms.PictureBox();
            this._PictureBox3 = new System.Windows.Forms.PictureBox();
            this._pictureBoxSnap = new System.Windows.Forms.PictureBox();
            this._PictureBox4 = new System.Windows.Forms.PictureBox();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this._PictureBoxMouseImage = new System.Windows.Forms.PictureBox();
            this.PicMenu1.SuspendLayout();
            this.SetMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxSnap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBoxMouseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWinText
            // 
            this.textBoxWinText.Location = new System.Drawing.Point(130, 304);
            this.textBoxWinText.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWinText.Multiline = true;
            this.textBoxWinText.Name = "textBoxWinText";
            this.textBoxWinText.Size = new System.Drawing.Size(197, 36);
            this.textBoxWinText.TabIndex = 5;
            // 
            // textBoxEXEPath
            // 
            this.textBoxEXEPath.Location = new System.Drawing.Point(130, 352);
            this.textBoxEXEPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEXEPath.Multiline = true;
            this.textBoxEXEPath.Name = "textBoxEXEPath";
            this.textBoxEXEPath.Size = new System.Drawing.Size(197, 61);
            this.textBoxEXEPath.TabIndex = 6;
            // 
            // textBoxWinClass
            // 
            this.textBoxWinClass.Location = new System.Drawing.Point(130, 256);
            this.textBoxWinClass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWinClass.Multiline = true;
            this.textBoxWinClass.Name = "textBoxWinClass";
            this.textBoxWinClass.Size = new System.Drawing.Size(197, 36);
            this.textBoxWinClass.TabIndex = 4;
            // 
            // _Label11
            // 
            this._Label11.AutoSize = true;
            this._Label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label11.Location = new System.Drawing.Point(45, 354);
            this._Label11.Name = "_Label11";
            this._Label11.Size = new System.Drawing.Size(82, 14);
            this._Label11.TabIndex = 35;
            this._Label11.Text = "进程路径：";
            this._Label11.Click += new System.EventHandler(this.打开路径);
            this._Label11.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label9.Location = new System.Drawing.Point(45, 311);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(82, 14);
            this._Label9.TabIndex = 33;
            this._Label9.Text = "窗体文本：";
            this._Label9.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // _Label8
            // 
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label8.Location = new System.Drawing.Point(45, 260);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(82, 14);
            this._Label8.TabIndex = 36;
            this._Label8.Text = "窗体类名：";
            this._Label8.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // labelWinInfo
            // 
            this.labelWinInfo.AutoSize = true;
            this.labelWinInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWinInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWinInfo.Location = new System.Drawing.Point(15, 51);
            this.labelWinInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWinInfo.Name = "labelWinInfo";
            this.labelWinInfo.Size = new System.Drawing.Size(105, 14);
            this.labelWinInfo.TabIndex = 32;
            this.labelWinInfo.Text = "窗口位置大小:";
            // 
            // _checkBoxTopmost
            // 
            this._checkBoxTopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._checkBoxTopmost.AutoSize = true;
            this._checkBoxTopmost.Location = new System.Drawing.Point(18, 397);
            this._checkBoxTopmost.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxTopmost.Name = "_checkBoxTopmost";
            this._checkBoxTopmost.Size = new System.Drawing.Size(72, 16);
            this._checkBoxTopmost.TabIndex = 7;
            this._checkBoxTopmost.Text = "置顶窗口";
            this._checkBoxTopmost.UseVisualStyleBackColor = true;
            this._checkBoxTopmost.CheckedChanged += new System.EventHandler(this.置顶);
            // 
            // _textBoxPID
            // 
            this._textBoxPID.Location = new System.Drawing.Point(130, 175);
            this._textBoxPID.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxPID.Name = "_textBoxPID";
            this._textBoxPID.Size = new System.Drawing.Size(197, 21);
            this._textBoxPID.TabIndex = 2;
            this._textBoxPID.TextChanged += new System.EventHandler(this.PID改变);
            // 
            // _textBoxHwnd
            // 
            this._textBoxHwnd.Location = new System.Drawing.Point(130, 118);
            this._textBoxHwnd.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxHwnd.Name = "_textBoxHwnd";
            this._textBoxHwnd.Size = new System.Drawing.Size(197, 21);
            this._textBoxHwnd.TabIndex = 1;
            this._textBoxHwnd.TextChanged += new System.EventHandler(this.TextBoxHwnd_TextChanged);
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label3.Location = new System.Drawing.Point(51, 177);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(76, 14);
            this._Label3.TabIndex = 25;
            this._Label3.Text = "窗体PID：";
            this._Label3.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label2.Location = new System.Drawing.Point(44, 121);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(82, 14);
            this._Label2.TabIndex = 34;
            this._Label2.Text = "窗口句柄：";
            this._Label2.DoubleClick += new System.EventHandler(this.双击复制);
            this._Label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.双击复制句柄);
            // 
            // labelMousePos
            // 
            this.labelMousePos.AutoSize = true;
            this.labelMousePos.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMousePos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMousePos.Location = new System.Drawing.Point(15, 13);
            this.labelMousePos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMousePos.Name = "labelMousePos";
            this.labelMousePos.Size = new System.Drawing.Size(105, 14);
            this.labelMousePos.TabIndex = 31;
            this.labelMousePos.Text = "当前鼠标位置:";
            // 
            // _checkBoxFreeMode
            // 
            this._checkBoxFreeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._checkBoxFreeMode.AutoSize = true;
            this._checkBoxFreeMode.Checked = true;
            this._checkBoxFreeMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxFreeMode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._checkBoxFreeMode.ForeColor = System.Drawing.Color.Salmon;
            this._checkBoxFreeMode.Location = new System.Drawing.Point(217, 13);
            this._checkBoxFreeMode.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxFreeMode.Name = "_checkBoxFreeMode";
            this._checkBoxFreeMode.Size = new System.Drawing.Size(111, 16);
            this._checkBoxFreeMode.TabIndex = 0;
            this._checkBoxFreeMode.Text = "自由模式 (&F3)";
            this._checkBoxFreeMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._checkBoxFreeMode.UseVisualStyleBackColor = true;
            this._checkBoxFreeMode.CheckedChanged += new System.EventHandler(this.自由模式);
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label5.Location = new System.Drawing.Point(45, 211);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(82, 14);
            this._Label5.TabIndex = 36;
            this._Label5.Text = "窗体标题：";
            this._Label5.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // textBoxWinTitle
            // 
            this.textBoxWinTitle.Location = new System.Drawing.Point(130, 209);
            this.textBoxWinTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWinTitle.Multiline = true;
            this.textBoxWinTitle.Name = "textBoxWinTitle";
            this.textBoxWinTitle.Size = new System.Drawing.Size(197, 36);
            this.textBoxWinTitle.TabIndex = 3;
            // 
            // PicMenu1
            // 
            this.PicMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PicMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._发送关闭消息ToolStripMenuItem,
            this._销毁进程ToolStripMenuItem});
            this.PicMenu1.Name = "PicMenu1";
            this.PicMenu1.Size = new System.Drawing.Size(149, 48);
            // 
            // _发送关闭消息ToolStripMenuItem
            // 
            this._发送关闭消息ToolStripMenuItem.Name = "_发送关闭消息ToolStripMenuItem";
            this._发送关闭消息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this._发送关闭消息ToolStripMenuItem.Text = "发送关闭消息";
            this._发送关闭消息ToolStripMenuItem.Click += new System.EventHandler(this.发送关闭消息ToolStripMenuItem_Click);
            // 
            // _销毁进程ToolStripMenuItem
            // 
            this._销毁进程ToolStripMenuItem.Name = "_销毁进程ToolStripMenuItem";
            this._销毁进程ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this._销毁进程ToolStripMenuItem.Text = "杀死进程";
            this._销毁进程ToolStripMenuItem.Click += new System.EventHandler(this.销毁进程ToolStripMenuItem_Click);
            // 
            // SetMenu1
            // 
            this.SetMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SetMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._发送一次点击ToolStripMenuItem,
            this.ToolStripSeparator3,
            this._冻结窗体ToolStripMenuItem,
            this._解冻窗体ToolStripMenuItem,
            this.ToolStripSeparator1,
            this._隐藏窗口ToolStripMenuItem,
            this.显示窗口ToolStripMenuItem,
            this.ToolStripSeparator2,
            this._强制最小化ToolStripMenuItem,
            this._强制最大化ToolStripMenuItem,
            this.ToolStripSeparator4,
            this._移动目标窗口ToolStripMenuItem,
            this._改变目标窗口大小ToolStripMenuItem,
            this.ToolStripSeparator5,
            this._消息控制对话框ToolStripMenuItem});
            this.SetMenu1.Name = "SetMenu1";
            this.SetMenu1.Size = new System.Drawing.Size(173, 254);
            // 
            // _发送一次点击ToolStripMenuItem
            // 
            this._发送一次点击ToolStripMenuItem.Name = "_发送一次点击ToolStripMenuItem";
            this._发送一次点击ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._发送一次点击ToolStripMenuItem.Text = "发送一次点击";
            this._发送一次点击ToolStripMenuItem.Click += new System.EventHandler(this.发送一次点击ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // _冻结窗体ToolStripMenuItem
            // 
            this._冻结窗体ToolStripMenuItem.Name = "_冻结窗体ToolStripMenuItem";
            this._冻结窗体ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._冻结窗体ToolStripMenuItem.Text = "冻结窗口";
            this._冻结窗体ToolStripMenuItem.Click += new System.EventHandler(this.冻结窗体ToolStripMenuItem_Click_1);
            // 
            // _解冻窗体ToolStripMenuItem
            // 
            this._解冻窗体ToolStripMenuItem.Name = "_解冻窗体ToolStripMenuItem";
            this._解冻窗体ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._解冻窗体ToolStripMenuItem.Text = "解冻窗口";
            this._解冻窗体ToolStripMenuItem.Click += new System.EventHandler(this.解冻窗体ToolStripMenuItem_Click_1);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // _隐藏窗口ToolStripMenuItem
            // 
            this._隐藏窗口ToolStripMenuItem.Name = "_隐藏窗口ToolStripMenuItem";
            this._隐藏窗口ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._隐藏窗口ToolStripMenuItem.Text = "隐藏窗口";
            this._隐藏窗口ToolStripMenuItem.Click += new System.EventHandler(this.隐藏窗口ToolStripMenuItem_Click);
            // 
            // 显示窗口ToolStripMenuItem
            // 
            this.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            this.显示窗口ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.显示窗口ToolStripMenuItem.Text = "显示窗口";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // _强制最小化ToolStripMenuItem
            // 
            this._强制最小化ToolStripMenuItem.Name = "_强制最小化ToolStripMenuItem";
            this._强制最小化ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._强制最小化ToolStripMenuItem.Text = "强制最小化";
            this._强制最小化ToolStripMenuItem.Click += new System.EventHandler(this.强制最小化ToolStripMenuItem_Click);
            // 
            // _强制最大化ToolStripMenuItem
            // 
            this._强制最大化ToolStripMenuItem.Name = "_强制最大化ToolStripMenuItem";
            this._强制最大化ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._强制最大化ToolStripMenuItem.Text = "强制最大化";
            this._强制最大化ToolStripMenuItem.Click += new System.EventHandler(this.强制最大化ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // _移动目标窗口ToolStripMenuItem
            // 
            this._移动目标窗口ToolStripMenuItem.Name = "_移动目标窗口ToolStripMenuItem";
            this._移动目标窗口ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._移动目标窗口ToolStripMenuItem.Text = "移动目标窗口";
            this._移动目标窗口ToolStripMenuItem.Click += new System.EventHandler(this.移动目标窗口ToolStripMenuItem_Click);
            // 
            // _改变目标窗口大小ToolStripMenuItem
            // 
            this._改变目标窗口大小ToolStripMenuItem.Name = "_改变目标窗口大小ToolStripMenuItem";
            this._改变目标窗口大小ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._改变目标窗口大小ToolStripMenuItem.Text = "改变目标窗口大小";
            this._改变目标窗口大小ToolStripMenuItem.Click += new System.EventHandler(this.改变目标窗口大小ToolStripMenuItem_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // _消息控制对话框ToolStripMenuItem
            // 
            this._消息控制对话框ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._消息控制对话框ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._消息控制对话框ToolStripMenuItem.Name = "_消息控制对话框ToolStripMenuItem";
            this._消息控制对话框ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this._消息控制对话框ToolStripMenuItem.Text = "消息控制对话框";
            this._消息控制对话框ToolStripMenuItem.Click += new System.EventHandler(this.消息控制对话框ToolStripMenuItem_Click);
            // 
            // _labelColorValue
            // 
            this._labelColorValue.AutoSize = true;
            this._labelColorValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._labelColorValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this._labelColorValue.Location = new System.Drawing.Point(75, 89);
            this._labelColorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelColorValue.Name = "_labelColorValue";
            this._labelColorValue.Size = new System.Drawing.Size(45, 14);
            this._labelColorValue.TabIndex = 32;
            this._labelColorValue.Text = "颜色:";
            this._labelColorValue.Click += new System.EventHandler(this.双击复制);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(47, 86);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(20, 20);
            this.Label10.TabIndex = 44;
            // 
            // _Label12
            // 
            this._Label12.AutoSize = true;
            this._Label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this._Label12.Location = new System.Drawing.Point(59, 150);
            this._Label12.Name = "_Label12";
            this._Label12.Size = new System.Drawing.Size(65, 12);
            this._Label12.TabIndex = 45;
            this._Label12.Text = "16 进制：";
            this._Label12.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // _Label16Decimal
            // 
            this._Label16Decimal.Location = new System.Drawing.Point(131, 146);
            this._Label16Decimal.Name = "_Label16Decimal";
            this._Label16Decimal.Size = new System.Drawing.Size(196, 20);
            this._Label16Decimal.TabIndex = 46;
            this._Label16Decimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Label16Decimal.DoubleClick += new System.EventHandler(this.双击复制);
            // 
            // pictureBoxConvert
            // 
            this.pictureBoxConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConvert.Image = global::SPY.My.Resources.Resources.convert;
            this.pictureBoxConvert.Location = new System.Drawing.Point(352, 354);
            this.pictureBoxConvert.Name = "pictureBoxConvert";
            this.pictureBoxConvert.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxConvert.TabIndex = 48;
            this.pictureBoxConvert.TabStop = false;
            this.pictureBoxConvert.Click += new System.EventHandler(this.pictureBoxConvert_Click);
            // 
            // _PictureBox3
            // 
            this._PictureBox3.Image = global::SPY.My.Resources.Resources.close;
            this._PictureBox3.Location = new System.Drawing.Point(346, 173);
            this._PictureBox3.Name = "_PictureBox3";
            this._PictureBox3.Size = new System.Drawing.Size(26, 21);
            this._PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._PictureBox3.TabIndex = 47;
            this._PictureBox3.TabStop = false;
            this._PictureBox3.Click += new System.EventHandler(this.弹出菜单2);
            this._PictureBox3.MouseEnter += new System.EventHandler(this.PictureBox3_MouseEnter);
            this._PictureBox3.MouseLeave += new System.EventHandler(this.PictureBox3_MouseLeave);
            // 
            // _pictureBoxSnap
            // 
            this._pictureBoxSnap.Location = new System.Drawing.Point(331, 59);
            this._pictureBoxSnap.Margin = new System.Windows.Forms.Padding(2);
            this._pictureBoxSnap.Name = "_pictureBoxSnap";
            this._pictureBoxSnap.Size = new System.Drawing.Size(40, 40);
            this._pictureBoxSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBoxSnap.TabIndex = 43;
            this._pictureBoxSnap.TabStop = false;
            this._pictureBoxSnap.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox5_Paint);
            // 
            // _PictureBox4
            // 
            this._PictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PictureBox4.Image = global::SPY.My.Resources.Resources.setting;
            this._PictureBox4.Location = new System.Drawing.Point(352, 118);
            this._PictureBox4.Name = "_PictureBox4";
            this._PictureBox4.Size = new System.Drawing.Size(20, 20);
            this._PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._PictureBox4.TabIndex = 42;
            this._PictureBox4.TabStop = false;
            this._PictureBox4.Click += new System.EventHandler(this.弹出菜单1);
            this._PictureBox4.MouseEnter += new System.EventHandler(this.PictureBox4_MouseHover);
            this._PictureBox4.MouseLeave += new System.EventHandler(this.PictureBox4_MouseLeave);
            // 
            // _PictureBox2
            // 
            this._PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PictureBox2.Image = global::SPY.My.Resources.Resources.writetext;
            this._PictureBox2.Location = new System.Drawing.Point(352, 304);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(20, 20);
            this._PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._PictureBox2.TabIndex = 40;
            this._PictureBox2.TabStop = false;
            this._PictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseClick);
            this._PictureBox2.MouseEnter += new System.EventHandler(this.PictureBox2_MouseEnter);
            this._PictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave);
            // 
            // _PictureBoxMouseImage
            // 
            this._PictureBoxMouseImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PictureBoxMouseImage.Image = global::SPY.My.Resources.Resources.drag;
            this._PictureBoxMouseImage.Location = new System.Drawing.Point(338, 13);
            this._PictureBoxMouseImage.Margin = new System.Windows.Forms.Padding(2);
            this._PictureBoxMouseImage.Name = "_PictureBoxMouseImage";
            this._PictureBoxMouseImage.Size = new System.Drawing.Size(28, 28);
            this._PictureBoxMouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._PictureBoxMouseImage.TabIndex = 0;
            this._PictureBoxMouseImage.TabStop = false;
            this._PictureBoxMouseImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.按下图片);
            this._PictureBoxMouseImage.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this._PictureBoxMouseImage.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            this._PictureBoxMouseImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.松开图片);
            // 
            // SpyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 427);
            this.Controls.Add(this.pictureBoxConvert);
            this.Controls.Add(this._PictureBox3);
            this.Controls.Add(this._Label16Decimal);
            this.Controls.Add(this._Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this._pictureBoxSnap);
            this.Controls.Add(this._PictureBox4);
            this.Controls.Add(this._PictureBox2);
            this.Controls.Add(this._PictureBoxMouseImage);
            this.Controls.Add(this._checkBoxTopmost);
            this.Controls.Add(this._checkBoxFreeMode);
            this.Controls.Add(this.textBoxWinText);
            this.Controls.Add(this.textBoxEXEPath);
            this.Controls.Add(this.textBoxWinTitle);
            this.Controls.Add(this.textBoxWinClass);
            this.Controls.Add(this._Label11);
            this.Controls.Add(this._Label5);
            this.Controls.Add(this._Label9);
            this.Controls.Add(this._Label8);
            this.Controls.Add(this._labelColorValue);
            this.Controls.Add(this.labelWinInfo);
            this.Controls.Add(this._textBoxPID);
            this.Controls.Add(this._textBoxHwnd);
            this.Controls.Add(this._Label3);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this.labelMousePos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPY++";
            this.Deactivate += new System.EventHandler(this.失去焦点);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SPYFORM_FormClosing);
            this.Load += new System.EventHandler(this.SPYFORM_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.PicMenu1.ResumeLayout(false);
            this.SetMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxSnap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBoxMouseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        internal Label labelWinInfo;
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

        internal Label labelMousePos;
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