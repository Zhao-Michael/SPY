﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPYFORM
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPYFORM))
        Me.textBoxWinText = New System.Windows.Forms.TextBox()
        Me.textBoxEXEPath = New System.Windows.Forms.TextBox()
        Me.textBoxWinClass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelWinInfo = New System.Windows.Forms.Label()
        Me.checkBoxTopmost = New System.Windows.Forms.CheckBox()
        Me.textBoxPID = New System.Windows.Forms.TextBox()
        Me.textBoxHwnd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelMousePos = New System.Windows.Forms.Label()
        Me.checkBoxFreeMode = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxWinTitle = New System.Windows.Forms.TextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PicMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.发送关闭消息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销毁进程ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMouseImage = New System.Windows.Forms.PictureBox()
        Me.SetMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.发送一次点击ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.冻结窗体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.解冻窗体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.隐藏窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.强制最小化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.强制最大化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.移动目标窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.改变目标窗口大小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelColorValue = New System.Windows.Forms.Label()
        Me.pictureBoxSnap = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PicMenu1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMouseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SetMenu1.SuspendLayout()
        CType(Me.pictureBoxSnap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxWinText
        '
        Me.textBoxWinText.Location = New System.Drawing.Point(130, 303)
        Me.textBoxWinText.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxWinText.Multiline = True
        Me.textBoxWinText.Name = "textBoxWinText"
        Me.textBoxWinText.Size = New System.Drawing.Size(173, 36)
        Me.textBoxWinText.TabIndex = 5
        '
        'textBoxEXEPath
        '
        Me.textBoxEXEPath.Location = New System.Drawing.Point(130, 359)
        Me.textBoxEXEPath.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxEXEPath.Multiline = True
        Me.textBoxEXEPath.Name = "textBoxEXEPath"
        Me.textBoxEXEPath.Size = New System.Drawing.Size(173, 36)
        Me.textBoxEXEPath.TabIndex = 6
        '
        'textBoxWinClass
        '
        Me.textBoxWinClass.Location = New System.Drawing.Point(130, 248)
        Me.textBoxWinClass.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxWinClass.Multiline = True
        Me.textBoxWinClass.Name = "textBoxWinClass"
        Me.textBoxWinClass.Size = New System.Drawing.Size(173, 36)
        Me.textBoxWinClass.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(45, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 14)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "进程路径："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(45, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 14)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "窗体文本："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(45, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 14)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "窗体类名："
        '
        'labelWinInfo
        '
        Me.labelWinInfo.AutoSize = True
        Me.labelWinInfo.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelWinInfo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.labelWinInfo.Location = New System.Drawing.Point(15, 54)
        Me.labelWinInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelWinInfo.Name = "labelWinInfo"
        Me.labelWinInfo.Size = New System.Drawing.Size(154, 21)
        Me.labelWinInfo.TabIndex = 32
        Me.labelWinInfo.Text = "窗口位置大小:"
        '
        'checkBoxTopmost
        '
        Me.checkBoxTopmost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkBoxTopmost.AutoSize = True
        Me.checkBoxTopmost.Location = New System.Drawing.Point(330, 48)
        Me.checkBoxTopmost.Margin = New System.Windows.Forms.Padding(2)
        Me.checkBoxTopmost.Name = "checkBoxTopmost"
        Me.checkBoxTopmost.Size = New System.Drawing.Size(72, 22)
        Me.checkBoxTopmost.TabIndex = 7
        Me.checkBoxTopmost.Text = "置顶"
        Me.checkBoxTopmost.UseVisualStyleBackColor = True
        '
        'textBoxPID
        '
        Me.textBoxPID.Location = New System.Drawing.Point(130, 154)
        Me.textBoxPID.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxPID.Name = "textBoxPID"
        Me.textBoxPID.Size = New System.Drawing.Size(173, 21)
        Me.textBoxPID.TabIndex = 2
        '
        'textBoxHwnd
        '
        Me.textBoxHwnd.Location = New System.Drawing.Point(130, 120)
        Me.textBoxHwnd.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxHwnd.Name = "textBoxHwnd"
        Me.textBoxHwnd.Size = New System.Drawing.Size(173, 21)
        Me.textBoxHwnd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(51, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "窗体PID："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(44, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "窗口句柄："
        '
        'labelMousePos
        '
        Me.labelMousePos.AutoSize = True
        Me.labelMousePos.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelMousePos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.labelMousePos.Location = New System.Drawing.Point(15, 16)
        Me.labelMousePos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelMousePos.Name = "labelMousePos"
        Me.labelMousePos.Size = New System.Drawing.Size(154, 21)
        Me.labelMousePos.TabIndex = 31
        Me.labelMousePos.Text = "当前鼠标位置:"
        '
        'checkBoxFreeMode
        '
        Me.checkBoxFreeMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkBoxFreeMode.AutoSize = True
        Me.checkBoxFreeMode.Checked = True
        Me.checkBoxFreeMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxFreeMode.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.checkBoxFreeMode.ForeColor = System.Drawing.Color.Salmon
        Me.checkBoxFreeMode.Location = New System.Drawing.Point(244, 12)
        Me.checkBoxFreeMode.Margin = New System.Windows.Forms.Padding(2)
        Me.checkBoxFreeMode.Name = "checkBoxFreeMode"
        Me.checkBoxFreeMode.Size = New System.Drawing.Size(110, 22)
        Me.checkBoxFreeMode.TabIndex = 0
        Me.checkBoxFreeMode.Text = "自由模式"
        Me.checkBoxFreeMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.checkBoxFreeMode.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "☆ 按 F3 切换模式 ☆"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(45, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "窗体标题："
        '
        'textBoxWinTitle
        '
        Me.textBoxWinTitle.Location = New System.Drawing.Point(130, 190)
        Me.textBoxWinTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxWinTitle.Multiline = True
        Me.textBoxWinTitle.Name = "textBoxWinTitle"
        Me.textBoxWinTitle.Size = New System.Drawing.Size(173, 36)
        Me.textBoxWinTitle.TabIndex = 3
        '
        'PicMenu1
        '
        Me.PicMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PicMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.发送关闭消息ToolStripMenuItem, Me.销毁进程ToolStripMenuItem})
        Me.PicMenu1.Name = "PicMenu1"
        Me.PicMenu1.Size = New System.Drawing.Size(221, 48)
        '
        '发送关闭消息ToolStripMenuItem
        '
        Me.发送关闭消息ToolStripMenuItem.Name = "发送关闭消息ToolStripMenuItem"
        Me.发送关闭消息ToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.发送关闭消息ToolStripMenuItem.Text = "发送关闭消息"
        '
        '销毁进程ToolStripMenuItem
        '
        Me.销毁进程ToolStripMenuItem.Name = "销毁进程ToolStripMenuItem"
        Me.销毁进程ToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.销毁进程ToolStripMenuItem.Text = "直接销毁进程，不保存数据"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.SPY.My.Resources.Resources._set
        Me.PictureBox4.Location = New System.Drawing.Point(352, 118)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.ContextMenuStrip = Me.PicMenu1
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.SPY.My.Resources.Resources.b
        Me.PictureBox3.Location = New System.Drawing.Point(352, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SPY.My.Resources.Resources.a1
        Me.PictureBox2.Location = New System.Drawing.Point(352, 304)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'PictureBoxMouseImage
        '
        Me.PictureBoxMouseImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxMouseImage.Image = Global.SPY.My.Resources.Resources.drag
        Me.PictureBoxMouseImage.Location = New System.Drawing.Point(344, 11)
        Me.PictureBoxMouseImage.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxMouseImage.Name = "PictureBoxMouseImage"
        Me.PictureBoxMouseImage.Size = New System.Drawing.Size(28, 28)
        Me.PictureBoxMouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxMouseImage.TabIndex = 0
        Me.PictureBoxMouseImage.TabStop = False
        '
        'SetMenu1
        '
        Me.SetMenu1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SetMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.发送一次点击ToolStripMenuItem, Me.ToolStripSeparator3, Me.冻结窗体ToolStripMenuItem, Me.解冻窗体ToolStripMenuItem, Me.ToolStripSeparator1, Me.隐藏窗口ToolStripMenuItem, Me.显示窗口ToolStripMenuItem, Me.ToolStripSeparator2, Me.强制最小化ToolStripMenuItem, Me.强制最大化ToolStripMenuItem, Me.ToolStripSeparator4, Me.移动目标窗口ToolStripMenuItem, Me.改变目标窗口大小ToolStripMenuItem})
        Me.SetMenu1.Name = "SetMenu1"
        Me.SetMenu1.Size = New System.Drawing.Size(173, 226)
        '
        '发送一次点击ToolStripMenuItem
        '
        Me.发送一次点击ToolStripMenuItem.Name = "发送一次点击ToolStripMenuItem"
        Me.发送一次点击ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.发送一次点击ToolStripMenuItem.Text = "发送一次点击"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(234, 6)
        '
        '冻结窗体ToolStripMenuItem
        '
        Me.冻结窗体ToolStripMenuItem.Name = "冻结窗体ToolStripMenuItem"
        Me.冻结窗体ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.冻结窗体ToolStripMenuItem.Text = "冻结窗口"
        '
        '解冻窗体ToolStripMenuItem
        '
        Me.解冻窗体ToolStripMenuItem.Name = "解冻窗体ToolStripMenuItem"
        Me.解冻窗体ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.解冻窗体ToolStripMenuItem.Text = "解冻窗口"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(234, 6)
        '
        '隐藏窗口ToolStripMenuItem
        '
        Me.隐藏窗口ToolStripMenuItem.Name = "隐藏窗口ToolStripMenuItem"
        Me.隐藏窗口ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.隐藏窗口ToolStripMenuItem.Text = "隐藏窗口"
        '
        '显示窗口ToolStripMenuItem
        '
        Me.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem"
        Me.显示窗口ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.显示窗口ToolStripMenuItem.Text = "显示窗口"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(234, 6)
        '
        '强制最小化ToolStripMenuItem
        '
        Me.强制最小化ToolStripMenuItem.Name = "强制最小化ToolStripMenuItem"
        Me.强制最小化ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.强制最小化ToolStripMenuItem.Text = "强制最小化"
        '
        '强制最大化ToolStripMenuItem
        '
        Me.强制最大化ToolStripMenuItem.Name = "强制最大化ToolStripMenuItem"
        Me.强制最大化ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.强制最大化ToolStripMenuItem.Text = "强制最大化"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(234, 6)
        '
        '移动目标窗口ToolStripMenuItem
        '
        Me.移动目标窗口ToolStripMenuItem.Name = "移动目标窗口ToolStripMenuItem"
        Me.移动目标窗口ToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.移动目标窗口ToolStripMenuItem.Text = "移动目标窗口"
        '
        '改变目标窗口大小ToolStripMenuItem
        '
        Me.改变目标窗口大小ToolStripMenuItem.Name = "改变目标窗口大小ToolStripMenuItem"
        Me.改变目标窗口大小ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.改变目标窗口大小ToolStripMenuItem.Text = "改变目标窗口大小"
        '
        'labelColorValue
        '
        Me.labelColorValue.AutoSize = True
        Me.labelColorValue.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelColorValue.ForeColor = System.Drawing.SystemColors.Highlight
        Me.labelColorValue.Location = New System.Drawing.Point(75, 89)
        Me.labelColorValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelColorValue.Name = "labelColorValue"
        Me.labelColorValue.Size = New System.Drawing.Size(66, 21)
        Me.labelColorValue.TabIndex = 32
        Me.labelColorValue.Text = "颜色:"
        '
        'pictureBoxSnap
        '
        Me.pictureBoxSnap.Location = New System.Drawing.Point(331, 69)
        Me.pictureBoxSnap.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxSnap.Name = "pictureBoxSnap"
        Me.pictureBoxSnap.Size = New System.Drawing.Size(40, 40)
        Me.pictureBoxSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxSnap.TabIndex = 43
        Me.pictureBoxSnap.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(47, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 20)
        Me.Label10.TabIndex = 44
        '
        'SPYFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 423)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pictureBoxSnap)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBoxMouseImage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkBoxTopmost)
        Me.Controls.Add(Me.checkBoxFreeMode)
        Me.Controls.Add(Me.textBoxWinText)
        Me.Controls.Add(Me.textBoxEXEPath)
        Me.Controls.Add(Me.textBoxWinTitle)
        Me.Controls.Add(Me.textBoxWinClass)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.labelColorValue)
        Me.Controls.Add(Me.labelWinInfo)
        Me.Controls.Add(Me.textBoxPID)
        Me.Controls.Add(Me.textBoxHwnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelMousePos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SPYFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPY++"
        Me.PicMenu1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMouseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SetMenu1.ResumeLayout(False)
        CType(Me.pictureBoxSnap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxMouseImage As System.Windows.Forms.PictureBox
    Friend WithEvents textBoxWinText As System.Windows.Forms.TextBox
    Friend WithEvents textBoxEXEPath As System.Windows.Forms.TextBox
    Friend WithEvents textBoxWinClass As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labelWinInfo As System.Windows.Forms.Label
    Friend WithEvents checkBoxTopmost As System.Windows.Forms.CheckBox
    Friend WithEvents textBoxPID As System.Windows.Forms.TextBox
    Friend WithEvents textBoxHwnd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelMousePos As System.Windows.Forms.Label
    Friend WithEvents checkBoxFreeMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textBoxWinTitle As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents PicMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 发送关闭消息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents SetMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 冻结窗体ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 解冻窗体ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 销毁进程ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 隐藏窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 强制最小化ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 强制最大化ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelColorValue As System.Windows.Forms.Label
    Friend WithEvents pictureBoxSnap As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents 发送一次点击ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 移动目标窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 改变目标窗口大小ToolStripMenuItem As ToolStripMenuItem
End Class
