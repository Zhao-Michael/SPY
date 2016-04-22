Imports System.Drawing
Public Class SPYFORM
    Dim thread As New Threading.Thread(AddressOf check)
    Dim flag As Boolean = True  '线程是否运行

    Dim isdraw As Boolean = False

#Region "移动窗体"
    Public X, Y As Integer
    Public moveflag As Boolean = True
    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        If moveflag = False Then Exit Sub
        X = e.X : Y = e.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If moveflag = False Then Exit Sub
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y

        End If
    End Sub
#End Region



    Private Sub 按下图片(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PictureBox1.Image = My.Resources.drag2
            SetSystemCursor(Cursors.UpArrow.CopyHandle, 32512)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                flag = True
                CheckBox2.Checked = flag
                isdraw = True
            End If
        End If
    End Sub

    Private Sub 松开图片(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PictureBox1.Image = My.Resources.drag
            SystemParametersInfoA(87, 0, 0, &H2)
            flag = False
            CheckBox2.Checked = flag
            isdraw = False
            SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, 0, 0)

        End If

    End Sub
    '主程序
    Dim point As New Point '鼠标位置

    Dim sharedPen As New Pen(Brushes.Red, 4)


    Sub check()

        Do

            GetCursorPos(point)
            Label1.Text = "当前鼠标位置: (" + point.X.ToString + "," + point.Y.ToString + ")"
            If flag = True Then

                '窗口句柄
                Dim handle As Integer = WindowFromPoint(point)
                TextBox1.Text = handle
                '窗口大小
                Dim r1 As New Rectangle
                GetWindowRect(handle, r1)
                Label7.Text = "窗体位置大小: " & "(" + r1.X.ToString & ":" & r1.Y.ToString + ")" & " " & "(" & (r1.Width - r1.X).ToString + " × " & (r1.Height - r1.Y).ToString + ")"
                '窗口PID
                Dim pid As Integer
                GetWindowThreadProcessId(handle, pid)
                TextBox2.Text = pid
                '窗口类名
                Dim classname As New System.Text.StringBuilder(255)
                If handle > 0 Then
                    GetClassName(handle, classname, 255)
                    TextBox3.Text = classname.ToString
                Else
                    TextBox3.Text = Nothing
                End If
                '窗体文本
                GetWindowTextA(TextBox1.Text, classname, 255)
                TextBox4.Text = classname.ToString
                '进程位置
                Try
                    Dim p As Process = Process.GetProcessById(TextBox2.Text)
                    TextBox6.Text = p.MainWindowTitle   '窗口标题
                    TextBox5.Text = p.MainModule.FileName
                Catch ex As Exception
                    TextBox5.Text = "拒绝访问！"
                End Try

                'If isdraw AndAlso handle <> 0 Then

                '    DeskHwnd = GetDesktopWindow()
                '    DeskDC = GetWindowDC(DeskHwnd)
                '    oldRop2 = SetROP2(DeskDC, 10)
                '    newPen = CreatePen(0, 2, 0)

                '    Console.WriteLine(r1.X.ToString() + "  ", r1.Y.ToString() + "  ", r1.Right.ToString() + "  ", r1.Bottom.ToString() + "  ")

                '    Rectangle(DeskDC, r1.X, r1.Y, 100, 100)

                '    DeleteObject(newPen)
                '    ReleaseDC(DeskHwnd, DeskDC)

                'End If


            End If
            Threading.Thread.Sleep(50)
        Loop

    End Sub

    Dim DeskHwnd
    Dim DeskDC
    Dim oldRop2 As Integer
    Dim newPen
    Dim oldPen


    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.WParam = 234 Then
            CheckBox2.Checked = Not CheckBox2.Checked
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub SPYFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setsysmenu()
        RegisterHotKey(Handle, 234, Nothing, Keys.F3) '注册热键 
        Control.CheckForIllegalCrossThreadCalls = False
        thread.Start()

        Dim t As New Threading.Thread(Sub()

                                          While True

                                              If CheckBox2.Checked Then
                                                  '该点颜色

                                                  Dim bit As Bitmap = New Bitmap(20, 20)
                                                  Dim g As Graphics = Graphics.FromImage(bit)
                                                  g.CopyFromScreen(New Point(point.X - 10, point.Y - 10), New Point(0, 0), New Size(20, 20))


                                                  PictureBox5.Image = bit



                                                  Dim color = bit.GetPixel(10, 10)





                                                  Label6.Text = "颜色: " + Mid(color.ToString(), 15).Replace("]", "").Replace(" ", "") + " " + ColorTranslator.ToHtml(color)

                                                  Label10.BackColor = color


                                              End If

                                          End While

                                      End Sub) With {.IsBackground = True}
        t.Start()

        '初始化绘图的相关句柄


    End Sub




#Region "修改系统菜单"

    Declare Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    Declare Function RemoveMenu Lib "user32" Alias "RemoveMenu" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    Declare Function AppendMenuA Lib "user32.dll" (ByVal hMenu As IntPtr, ByVal uFlags As MenuFlags, ByVal uIDNewItem As Int32, ByVal lpNewItem As String) As Boolean
    Public Enum MenuFlags As Integer
        MF_BYPOSITION = &H400&
        MF_REMOVE = &H1000&
        MF_SEPARATOR = &H800&
        MF_STRING = &H0&
    End Enum
    Sub setsysmenu()
        Dim handle = GetSystemMenu(Me.Handle, False)
        RemoveMenu(handle, 2, MenuFlags.MF_BYPOSITION)
        RemoveMenu(handle, 3, MenuFlags.MF_BYPOSITION)
    End Sub
#End Region

    Private Sub SPYFORM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Hide()
        UnRegisterHotKey(Handle, 234)
        SystemParametersInfoA(87, 0, 0, &H2)
        thread.Abort()

        Environment.Exit(0)
    End Sub

    Private Sub 置顶(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.TopMost = CheckBox1.Checked
    End Sub


    Private Sub 失去焦点(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.BackColor = Color.FromArgb(235, 235, 235)
    End Sub

    Private Sub 自由模式(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        flag = CheckBox2.Checked
        If CheckBox2.Checked = True Then
            PictureBox2.Image = Nothing
        Else
            PictureBox2.Image = My.Resources.a1
        End If
    End Sub

    Private Sub 打开路径(sender As Object, e As EventArgs) Handles Label11.Click
        Shell("explorer.exe /select," & TextBox5.Text, AppWinStyle.NormalFocus)
    End Sub


#Region "图片设置"
    '至上而下 
    '1=================================================================================
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ToolTip3.Active = True
        ToolTip3.Show("请左击图标拖动需要查看的窗体", PictureBox1, 40, 0, 1200)
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        ToolTip3.Active = False
    End Sub

    '2=================================================================================

    Private Sub 冻结窗体ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 冻结窗体ToolStripMenuItem.Click
        解冻窗体ToolStripMenuItem.DropDownItems.Add(TextBox1.Text)
        AddHandler 解冻窗体ToolStripMenuItem.DropDownItems(解冻窗体ToolStripMenuItem.DropDownItems.Count - 1).Click, AddressOf enablectrl
        EnableWindow(TextBox1.Text, False)
    End Sub

    Sub enablectrl(sender As Object, e As EventArgs)
        EnableWindow(CType(sender, ToolStripItem).Text, True)
        解冻窗体ToolStripMenuItem.DropDownItems.Remove(CType(sender, ToolStripItem))
    End Sub

    Private Sub 解冻窗体ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 解冻窗体ToolStripMenuItem.Click
        EnableWindow(TextBox1.Text, True)
    End Sub

    Private Sub 隐藏窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 隐藏窗口ToolStripMenuItem.Click
        显示窗口ToolStripMenuItem.DropDownItems.Add(TextBox1.Text)
        AddHandler 显示窗口ToolStripMenuItem.DropDownItems(显示窗口ToolStripMenuItem.DropDownItems.Count - 1).Click, AddressOf showctrl
        ShowWindow(TextBox1.Text, WindowShowStyle.Hide)
    End Sub

    Sub showctrl(sender As Object, e As EventArgs)
        ShowWindow(CType(sender, ToolStripItem).Text, WindowShowStyle.ShowNormal)
        显示窗口ToolStripMenuItem.DropDownItems.Remove(CType(sender, ToolStripItem))
    End Sub

    Private Sub 弹出菜单1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SetMenu1.Show(PictureBox4, PictureBox4.Width + 5, 0)
    End Sub

    Private Sub 强制最小化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 强制最小化ToolStripMenuItem.Click
        ShowWindow(TextBox1.Text, WindowShowStyle.ForceMinimized)
    End Sub

    Private Sub 强制最大化ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 强制最大化ToolStripMenuItem.Click
        ShowWindow(TextBox1.Text, WindowShowStyle.Maximize)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) Mod 2 <> 0 Or TextBox1.Text = "0" Or TextBox1.Text = Nothing Then
            PictureBox4.Image = Nothing
            PictureBox2.Image = Nothing
        Else
            PictureBox2.Image = My.Resources.a1
        End If

    End Sub
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        ToolTip1.Active = True
        ToolTip1.ShowAlways = True
        ToolTip1.Show("注意，窗口包括窗体,也包括其它控件!", PictureBox4, PictureBox4.Width + 5, -22)
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        ToolTip1.Active = False
    End Sub
    '3====================================================================================
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        ToolTip1.Active = True
        ToolTip1.ShowAlways = True
        ToolTip1.Show("关闭该进程 PID.Kill!", PictureBox3, PictureBox3.Width + 5, -22)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        ToolTip1.Active = False
    End Sub
    Private Sub PID改变(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Val(TextBox2.Text) Mod 2 <> 0 Or TextBox2.Text = "0" Or TextBox2.Text = Nothing Then
            PictureBox3.Image = Nothing
        Else
            PictureBox3.Image = My.Resources.b
        End If
    End Sub

    Private Sub 弹出菜单2(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PicMenu1.Show(PictureBox3, PictureBox4.Width + 5, 0)
    End Sub
    Private Sub 发送关闭消息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送关闭消息ToolStripMenuItem.Click
        Dim p As Process = Process.GetProcessById(TextBox2.Text)
        p.CloseMainWindow()
    End Sub
    Private Sub 销毁进程ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销毁进程ToolStripMenuItem.Click

        Dim p As Process = Process.GetProcessById(TextBox2.Text)
        p.Kill()

    End Sub
    '4=================================================================================
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        ToolTip2.Active = True
        ToolTip2.ShowAlways = True
        ToolTip2.Show("修改窗口文本！" + vbCrLf + "一般来说，只能修改窗口标题和文本框！", PictureBox2, 25, -40)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        ToolTip2.Active = False
    End Sub
    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        If TextBox1.Text = 0 Or TextBox1.Text Is Nothing Then Exit Sub
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        If CheckBox1.Checked = False Then
            SetWindowTextA(TextBox1.Text, TextBox4.Text)
            Dim myerror As Integer = GetLastError()
            If myerror <> 0 Then
                MsgBox("修改失败!" + vbCrLf + myerror, 64, "提示信息！")
            Else
                MsgBox("修改成功!", 64, "提示信息！")
            End If
        End If
    End Sub

#End Region

    Private Sub 双击复制(sender As Object, e As EventArgs) Handles Label2.DoubleClick, Label3.DoubleClick, Label5.DoubleClick, Label8.DoubleClick, Label9.DoubleClick, Label11.DoubleClick
        If sender.Equals(Label2) Then My.Computer.Clipboard.SetText(TextBox1.Text)
        If sender.Equals(Label3) Then My.Computer.Clipboard.SetText(TextBox2.Text)
        If sender.Equals(Label5) Then My.Computer.Clipboard.SetText(TextBox6.Text)
        If sender.Equals(Label8) Then My.Computer.Clipboard.SetText(TextBox3.Text)
        If sender.Equals(Label9) Then My.Computer.Clipboard.SetText(TextBox4.Text)
        If sender.Equals(Label11) Then My.Computer.Clipboard.SetText(TextBox5.Text)
    End Sub

    Private Sub 双击复制句柄(sender As Object, e As EventArgs) Handles Label2.MouseDoubleClick
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub PictureBox5_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox5.Paint

        e.Graphics.DrawRectangle(New Pen(Brushes.Green, 2), New Rectangle(1, 1, PictureBox5.Size.Width - 2, PictureBox5.Size.Height - 2))

        e.Graphics.DrawLine(New Pen(Brushes.Red, 1), New Point(2, 20), New Point(38, 20))

        e.Graphics.DrawLine(New Pen(Brushes.Red, 1), New Point(20, 2), New Point(20, 38))

    End Sub

    Const MK_LBUTTON = &H1
    Const WM_LBUTTONDBLCLK = &H203
    Const WM_LBUTTONDOWN = &H201
    Const WM_LBUTTONUP = &H202
    Const WM_KEYDOWN = &H100
    Const WM_KEYUP = &H101
    Private Sub 发送一次点击ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送一次点击ToolStripMenuItem.Click

        If TextBox1.Text <> "" AndAlso TextBox1.Text <> "0" Then
            SendMessage(TextBox1.Text, WM_KEYDOWN, Keys.Space, 0)

            SendMessage(TextBox1.Text, WM_KEYUP, Keys.Space, 0)
        End If


    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        DeskHwnd = GetDesktopWindow()
        DeskDC = GetWindowDC(DeskHwnd)
        oldRop2 = SetROP2(DeskDC, 6)
        newPen = CreatePen(0, 2, 0)

        Rectangle(DeskDC, 100, 100, 800, 600)

        DeleteObject(newPen)
        ReleaseDC(DeskHwnd, DeskDC)

    End Sub

    Const R2_NOP = 11
    Const R2_WHITE = 16
    Const R2_BLACK = 1
    Const R2_NOT = 6

    Declare Sub SHChangeNotify Lib "shell32.dll" (ByVal wEventId As Integer, ByVal uFlags As Integer, dwItem1 As Integer, dwItem2 As Integer)
    Const SHCNE_ASSOCCHANGED = &H8000000&
    Const SHCNF_IDLIST = &H0



End Class
