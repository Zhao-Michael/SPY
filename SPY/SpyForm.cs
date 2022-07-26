using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SPY
{
    public partial class SpyForm
    {
        public SpyForm()
        {
            thread = new System.Threading.Thread(check);
            InitializeComponent();
            _Label11.Name = "Label11";
            _Label9.Name = "Label9";
            _Label8.Name = "Label8";
            _checkBoxTopmost.Name = "checkBoxTopmost";
            _textBoxPID.Name = "textBoxPID";
            _textBoxHwnd.Name = "textBoxHwnd";
            _Label3.Name = "Label3";
            _Label2.Name = "Label2";
            _checkBoxFreeMode.Name = "checkBoxFreeMode";
            _Label5.Name = "Label5";
            _发送关闭消息ToolStripMenuItem.Name = "发送关闭消息ToolStripMenuItem";
            _销毁进程ToolStripMenuItem.Name = "销毁进程ToolStripMenuItem";
            _发送一次点击ToolStripMenuItem.Name = "发送一次点击ToolStripMenuItem";
            _冻结窗体ToolStripMenuItem.Name = "冻结窗体ToolStripMenuItem";
            _解冻窗体ToolStripMenuItem.Name = "解冻窗体ToolStripMenuItem";
            _隐藏窗口ToolStripMenuItem.Name = "隐藏窗口ToolStripMenuItem";
            _强制最小化ToolStripMenuItem.Name = "强制最小化ToolStripMenuItem";
            _强制最大化ToolStripMenuItem.Name = "强制最大化ToolStripMenuItem";
            _移动目标窗口ToolStripMenuItem.Name = "移动目标窗口ToolStripMenuItem";
            _改变目标窗口大小ToolStripMenuItem.Name = "改变目标窗口大小ToolStripMenuItem";
            _labelColorValue.Name = "labelColorValue";
            _Label12.Name = "Label12";
            _Label16Decimal.Name = "Label16Decimal";
            _pictureBoxSnap.Name = "pictureBoxSnap";
            _PictureBox4.Name = "PictureBox4";
            _PictureBox3.Name = "PictureBox3";
            _PictureBox2.Name = "PictureBox2";
            _PictureBoxMouseImage.Name = "PictureBoxMouseImage";
            _消息控制对话框ToolStripMenuItem.Name = "消息控制对话框ToolStripMenuItem";
        }

        private System.Threading.Thread thread;
        private bool flag = true;  // 线程是否运行
        private bool isdraw = false;
        private BlockingCollection<Bitmap> queue = new BlockingCollection<Bitmap>();
        public static SpyForm Intance;

        public event HwndChangedEventHandler HwndChanged;

        public delegate void HwndChangedEventHandler();


        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public int X, Y;
        public bool moveflag = true;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveflag == false)
                return;
            X = e.X;
            Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveflag == false)
                return;
            if (X == e.X & Y == e.Y)
                return;
            if (e.Button == MouseButtons.Left)
            {
                Left = Left + e.X - X;
                Top = Top + e.Y - Y;
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        private void 按下图片(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBoxMouseImage.Image = My.Resources.Resources.drag2;
                SpyAPI.SetSystemCursor(Cursors.Cross.CopyHandle(), 32512);
                if (e.Button == MouseButtons.Left)
                {
                    flag = true;
                    checkBoxFreeMode.Checked = flag;
                    isdraw = true;
                }
            }
        }

        private void 松开图片(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBoxMouseImage.Image = My.Resources.Resources.drag;
                SpyAPI.SystemParametersInfoA(87, 0, 0, 0x2);
                flag = false;
                checkBoxFreeMode.Checked = flag;
                isdraw = false;
                // SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, 0, 0)
            }
        }
        // 主程序
        private Point point = new Point(); // 鼠标位置
        private Pen sharedPen = new Pen(Brushes.Red, 4f);
        private Rectangle currPosition;
        private int currHwnd;

        public void check()
        {
            do
            {
                SpyAPI.GetCursorPos(ref point);
                labelMousePos.Text = "当前鼠标位置: (" + point.X.ToString() + "," + point.Y.ToString() + ")";
                if (flag == true)
                {

                    // 窗口句柄
                    int currHwnd = SpyAPI.WindowFromPoint(point);
                    textBoxHwnd.Text = currHwnd.ToString();
                    // 窗口大小

                    SpyAPI.GetWindowRect(currHwnd, ref currPosition);
                    labelWinInfo.Text = "窗体位置大小: " + "(" + currPosition.X.ToString() + ":" + currPosition.Y.ToString() + ")" + " " + "(" + (currPosition.Width - currPosition.X).ToString() + " × " + (currPosition.Height - currPosition.Y).ToString() + ")";
                    // 窗口PID
                    uint arglpdwProcessId = 0;
                    SpyAPI.GetWindowThreadProcessId((uint)currHwnd, ref arglpdwProcessId);
                    textBoxPID.Text = arglpdwProcessId.ToString();
                    // 窗口类名
                    var classname = new System.Text.StringBuilder(255);
                    if (currHwnd > 0)
                    {
                        SpyAPI.GetClassName((IntPtr)currHwnd, classname, 255);
                        textBoxWinClass.Text = classname.ToString();
                    }
                    else
                    {
                        textBoxWinClass.Text = null;
                    }
                    // 窗体文本
                    SpyAPI.GetWindowTextA((IntPtr)int.Parse(textBoxHwnd.Text), classname, 255);
                    textBoxWinText.Text = classname.ToString();
                    // 进程位置
                    try
                    {
                        var p = Process.GetProcessById(Conversions.ToInteger(textBoxPID.Text));
                        textBoxWinTitle.Text = p.MainWindowTitle;   // 窗口标题
                        textBoxEXEPath.Text = p.MainModule.FileName;
                    }
                    catch (Exception ex)
                    {
                        textBoxEXEPath.Text = "拒绝访问！";
                    }

                    // If isdraw AndAlso currHwnd <> 0 Then

                    // DeskHwnd = GetDesktopWindow()
                    // DeskDC = GetWindowDC(DeskHwnd)
                    // oldRop2 = SetROP2(DeskDC, 10)
                    // newPen = CreatePen(0, 2, 0)

                    // Console.WriteLine(r1.X.ToString() + "  ", r1.Y.ToString() + "  ", r1.Right.ToString() + "  ", r1.Bottom.ToString() + "  ")

                    // Rectangle(DeskDC, r1.X, r1.Y, 100, 100)

                    // DeleteObject(newPen)
                    // ReleaseDC(DeskHwnd, DeskDC)


                    // ControlPaint.DrawReversibleFrame(New Rectangle(r1.X, r1.Y, 100, 100), Color.Transparent, FrameStyle.Thick)

                }

                System.Threading.Thread.Sleep(50);
            }
            while (true);
        }

        private object DeskHwnd;
        private object DeskDC;
        private int oldRop2;
        private object newPen;
        private object oldPen;

        protected override void WndProc(ref Message m)
        {
            if (m.WParam == (IntPtr)234)
            {
                checkBoxFreeMode.Checked = !checkBoxFreeMode.Checked;
            }

            if (m.Msg == 274)
            {
                if (m.WParam == (IntPtr)1998)
                {
                    bool temp = checkBoxFreeMode.Checked;
                    checkBoxFreeMode.Checked = false;
                    var info = new SpyAPI.SHELLEXECUTEINFO();
                    info.cbSize = Marshal.SizeOf(info);
                    info.lpVerb = "runas";
                    info.nShow = SpyAPI.SW_NORMAL;
                    info.lpFile = Application.ExecutablePath;
                    if (SpyAPI.ShellExecuteEx(ref info))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        checkBoxFreeMode.Checked = temp;
                    }
                }
            }

            base.WndProc(ref m);
        }

        private void SPYFORM_Load(object sender, EventArgs e)
        {
            Intance = this;
            setsysmenu();
            SpyAPI.RegisterHotKey(Handle, 234, default, (int)Keys.F3); // 注册热键 
            CheckForIllegalCrossThreadCalls = false;
            thread.Start();
            float m_dpi = 0.0f;
            SpyAPI.SetProcessDPIAware();
            int desktopDC = SpyAPI.GetDC(SpyAPI.GetDesktopWindow());
            int dpiX = SpyAPI.GetDeviceCaps(desktopDC, 90);
            var bit = new Bitmap(20, 20);
            var g = Graphics.FromImage(bit);
            // 该点颜色

            var t = new System.Threading.Thread(() => { while (true) { try { if (checkBoxFreeMode.Checked) { g.CopyFromScreen(new Point(point.X - 10, point.Y - 10), new Point(0, 0), new Size(20, 20)); queue.Add((Bitmap)bit.Clone()); var color = bit.GetPixel(10, 10); labelColorValue.Text = "颜色: " + Strings.Mid(color.ToString(), 15).Replace("]", "").Replace(" ", "") + " " + ColorTranslator.ToHtml(color); Label10.BackColor = color; } } catch (Exception ex) { } System.Threading.Thread.Sleep(10); } }) { IsBackground = true };
            t.Start();
            var q = new System.Threading.Thread(() => { foreach (var item in queue.GetConsumingEnumerable()) pictureBoxSnap.Image = item; }) { IsBackground = true };
            q.Start();


            // 初始化绘图的相关句柄


        }




        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32", EntryPoint = "RemoveMenu")]
        static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);
        [DllImport("user32.dll")]
        static extern bool AppendMenuA(IntPtr hMenu, MenuFlags uFlags, int uIDNewItem, string lpNewItem);

        public enum MenuFlags : int
        {
            MF_BYPOSITION = 0x400,
            MF_REMOVE = 0x1000,
            MF_SEPARATOR = 0x800,
            MF_STRING = 0x0
        }

        public void setsysmenu()
        {
            var handle = GetSystemMenu(Handle, false);
            RemoveMenu((int)handle, 2, (int)MenuFlags.MF_BYPOSITION);
            RemoveMenu((int)handle, 3, (int)MenuFlags.MF_BYPOSITION);
            string arglpNewItem = "Run as Admin";
            SpyForm.AppendMenuA(handle, MenuFlags.MF_STRING, 1998, arglpNewItem);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void SPYFORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            SpyAPI.UnRegisterHotKey(Handle, 234);
            SpyAPI.SystemParametersInfoA(87, 0, 0, 0x2);
            thread.Abort();
            Environment.Exit(0);
        }

        private void 置顶(object sender, EventArgs e)
        {
            TopMost = checkBoxTopmost.Checked;
        }

        private void 失去焦点(object sender, EventArgs e)
        {
            // Me.BackColor = Color.FromArgb(235, 235, 235)
        }

        private void 自由模式(object sender, EventArgs e)
        {
            flag = checkBoxFreeMode.Checked;
            if (checkBoxFreeMode.Checked == true)
            {
                PictureBox2.Image = null;
            }
            else
            {
                PictureBox2.Image = My.Resources.Resources.writetext;
            }
        }

        private void 打开路径(object sender, EventArgs e)
        {
            Interaction.Shell("explorer.exe /select," + textBoxEXEPath.Text, AppWinStyle.NormalFocus);
        }


        /* TODO ERROR: Skipped RegionDirectiveTrivia */    // 至上而下 
                                                           // 1=================================================================================
        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip3.Active = true;
            ToolTip3.Show("请左击图标拖动需要查看的窗体", PictureBoxMouseImage, 40, 0);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ToolTip3.Active = false;
        }

        // 2=================================================================================

        private void 冻结窗体ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            解冻窗体ToolStripMenuItem.DropDownItems.Add(textBoxHwnd.Text);
            解冻窗体ToolStripMenuItem.DropDownItems[解冻窗体ToolStripMenuItem.DropDownItems.Count - 1].Click += enablectrl;
            SpyAPI.EnableWindow((IntPtr)int.Parse(textBoxHwnd.Text), false);
        }

        public void enablectrl(object sender, EventArgs e)
        {
            SpyAPI.EnableWindow((IntPtr)int.Parse(((ToolStripItem)sender).Text), true);
            解冻窗体ToolStripMenuItem.DropDownItems.Remove((ToolStripItem)sender);
        }

        private void 解冻窗体ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpyAPI.EnableWindow((IntPtr)int.Parse(textBoxHwnd.Text), true);
        }

        private void 隐藏窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            显示窗口ToolStripMenuItem.DropDownItems.Add(textBoxHwnd.Text);
            显示窗口ToolStripMenuItem.DropDownItems[显示窗口ToolStripMenuItem.DropDownItems.Count - 1].Click += showctrl;
            SpyAPI.ShowWindow((IntPtr)int.Parse(textBoxHwnd.Text), SpyAPI.WindowShowStyle.Hide);
        }

        public void showctrl(object sender, EventArgs e)
        {
            SpyAPI.ShowWindow((IntPtr)int.Parse(((ToolStripItem)sender).Text), SpyAPI.WindowShowStyle.ShowNormal);
            显示窗口ToolStripMenuItem.DropDownItems.Remove((ToolStripItem)sender);
        }

        private void 弹出菜单1(object sender, EventArgs e)
        {
            SetMenu1.Show(PictureBox4, PictureBox4.Width + 5, 0);
        }

        private void 强制最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpyAPI.ShowWindow((IntPtr)int.Parse(textBoxHwnd.Text), SpyAPI.WindowShowStyle.ForceMinimized);
        }

        private void 强制最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpyAPI.ShowWindow((IntPtr)int.Parse(textBoxHwnd.Text), SpyAPI.WindowShowStyle.Maximize);
        }

        private void TextBoxHwnd_TextChanged(object sender, EventArgs e)
        {
            if (Conversion.Val(textBoxHwnd.Text) % 2d != 0d | textBoxHwnd.Text == "0" | textBoxHwnd.Text == null)
            {
                PictureBox4.Image = null;
                PictureBox2.Image = null;
            }
            else
            {
                PictureBox2.Image = My.Resources.Resources.writetext;
            }

            int hex = 0;
            int.TryParse(textBoxHwnd.Text, out hex);
            Label16Decimal.Text = Convert.ToString(hex, 16);
            HwndChanged?.Invoke();
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Active = true;
            ToolTip1.ShowAlways = true;
            ToolTip1.Show("操作窗口", PictureBox4, PictureBox4.Width + 10, 0);
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            ToolTip1.Active = false;
        }
        // 3====================================================================================
        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip1.Active = true;
            ToolTip1.ShowAlways = true;
            ToolTip1.Show("关闭进程", PictureBox3, PictureBox3.Width + 11, 0);
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ToolTip1.Active = false;
        }

        private void PID改变(object sender, EventArgs e)
        {
            if (Conversion.Val(textBoxPID.Text) % 2d != 0d | textBoxPID.Text == "0" | textBoxPID.Text == null)
            {
                PictureBox3.Image = null;
            }
            else
            {
                PictureBox3.Image = My.Resources.Resources.close;
            }
        }

        private void 弹出菜单2(object sender, EventArgs e)
        {
            PicMenu1.Show(PictureBox3, PictureBox4.Width + 5, 0);
        }

        private void 发送关闭消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = Process.GetProcessById(Conversions.ToInteger(textBoxPID.Text));
            p.CloseMainWindow();
        }

        private void 销毁进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = Process.GetProcessById(Conversions.ToInteger(textBoxPID.Text));
            p.Kill();
        }
        // 4=================================================================================
        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip2.Active = true;
            ToolTip2.ShowAlways = true;
            ToolTip2.Show("修改窗口文本", PictureBox2, 30, 0);
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ToolTip2.Active = false;
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (Conversions.ToDouble(textBoxHwnd.Text) == 0d | textBoxHwnd.Text is null)
                return;
            if (e.Button != MouseButtons.Left)
                return;
            if (checkBoxTopmost.Checked == false)
            {
                string arglpString = textBoxWinText.Text;
                SpyAPI.SetWindowTextA(Conversions.ToInteger(textBoxHwnd.Text), arglpString);
                textBoxWinText.Text = arglpString;
                int myerror = SpyAPI.GetLastError();
                if (myerror != 0)
                {
                    Interaction.MsgBox(Conversions.ToDouble("修改失败!" + Constants.vbCrLf) + myerror, (MsgBoxStyle)64, "提示信息！");
                }
                else
                {
                    Interaction.MsgBox("修改成功!", (MsgBoxStyle)64, "提示信息！");
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        private void 双击复制(object sender, EventArgs e)
        {
            if (sender.Equals(Label2))
                My.MyProject.Computer.Clipboard.SetText(textBoxHwnd.Text);
            if (sender.Equals(Label3))
                My.MyProject.Computer.Clipboard.SetText(textBoxPID.Text);
            if (sender.Equals(Label5))
                My.MyProject.Computer.Clipboard.SetText(textBoxWinTitle.Text);
            if (sender.Equals(Label8))
                My.MyProject.Computer.Clipboard.SetText(textBoxWinClass.Text);
            if (sender.Equals(Label9))
                My.MyProject.Computer.Clipboard.SetText(textBoxWinText.Text);
            if (sender.Equals(Label11))
                My.MyProject.Computer.Clipboard.SetText(textBoxEXEPath.Text);
            if (sender.Equals(Label12) | sender.Equals(Label16Decimal))
                My.MyProject.Computer.Clipboard.SetText(Label16Decimal.Text);
            if (sender.Equals(labelColorValue))
            {
                if (labelColorValue.Text.Contains("#"))
                {
                    My.MyProject.Computer.Clipboard.SetText("#" + labelColorValue.Text.Split('#')[1]);
                }
            }
        }

        private void 双击复制句柄(object sender, EventArgs e)
        {
            My.MyProject.Computer.Clipboard.SetText(textBoxHwnd.Text);
        }

        private void PictureBox5_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(1, 1, pictureBoxSnap.Size.Width - 2, pictureBoxSnap.Size.Height - 2);
            e.Graphics.DrawRectangle(new Pen(Brushes.Green, 2f), rect);
            e.Graphics.DrawLine(new Pen(Brushes.Red, 1f), new Point(0, (int)(rect.Height / 2d)), new Point(rect.Width, (int)(rect.Height / 2d)));
            e.Graphics.DrawLine(new Pen(Brushes.Red, 1f), new Point((int)(rect.Width / 2d), 0), new Point((int)(rect.Width / 2d), rect.Height));
        }

        private const int MK_LBUTTON = 0x1;
        private const int WM_LBUTTONDBLCLK = 0x203;
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_LBUTTONUP = 0x202;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        private void 发送一次点击ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxHwnd.Text) && textBoxHwnd.Text != "0")
            {
                SpyAPI.SendMessage(Conversions.ToInteger(textBoxHwnd.Text), WM_KEYDOWN, (int)Keys.Space, 0);
                SpyAPI.SendMessage(Conversions.ToInteger(textBoxHwnd.Text), WM_KEYUP, (int)Keys.Space, 0);
            }
        }

        private void 移动目标窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = Interaction.InputBox("请输入目标窗口的位置，以逗号分隔", "移动目标窗口", "100,100");
            if (r.Contains(",") && Strings.Split(Conversions.ToString(r.ToArray()), ",").Length == 2)
            {
                int x = Conversions.ToInteger(Strings.Split(Conversions.ToString(r.ToArray()), ",")[0]);
                int y = Conversions.ToInteger(Strings.Split(Conversions.ToString(r.ToArray()), ",")[1]);
                SpyAPI.MoveWindow((IntPtr)int.Parse(textBoxHwnd.Text), x, y, currPosition.Width - currPosition.X, currPosition.Height - currPosition.Y, true);
            }
            else
            {
                MessageBox.Show(this, "输入格式不对", "Error");
            }
        }

        private void 改变目标窗口大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = Interaction.InputBox("请输入目标窗口的大小，以逗号分隔", "改变目标窗口大小", (currPosition.Width - currPosition.X).ToString() + " , " + (currPosition.Height - currPosition.Y).ToString());
            if (string.IsNullOrEmpty(r))
                return;
            if (r.Contains(",") && Strings.Split(Conversions.ToString(r.ToArray()), ",").Length == 2)
            {
                int w = Conversions.ToInteger(Strings.Split(Conversions.ToString(r.ToArray()), ",")[0]);
                int h = Conversions.ToInteger(Strings.Split(Conversions.ToString(r.ToArray()), ",")[1]);
                SpyAPI.MoveWindow((IntPtr)int.Parse(textBoxHwnd.Text), currPosition.X, currPosition.Y, w, h, true);
            }
            else
            {
                MessageBox.Show(this, "输入格式不对", "Error");
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeskHwnd = SpyAPI.GetDesktopWindow();
            DeskDC = SpyAPI.GetWindowDC(Conversions.ToInteger(DeskHwnd));
            oldRop2 = SpyAPI.SetROP2(Conversions.ToInteger(DeskDC), 6);
            newPen = SpyAPI.CreatePen(0, 2, 0);
            SpyAPI.Rectangle(Conversions.ToInteger(DeskDC), 100, 100, 800, 600);
            SpyAPI.DeleteObject(Conversions.ToInteger(newPen));
            SpyAPI.ReleaseDC(Conversions.ToInteger(DeskHwnd), Conversions.ToInteger(DeskDC));
        }

        private const int R2_NOP = 11;
        private const int R2_WHITE = 16;
        private const int R2_BLACK = 1;
        private const int R2_NOT = 6;

        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(int wEventId, int uFlags, int dwItem1, int dwItem2);

        private const long SHCNE_ASSOCCHANGED = 0x8000000L;

        private void 消息控制对话框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mhDialog.Show();
            mhDialog.Focus();
        }

        MessageHandle mhDialog = new MessageHandle();

        private void pictureBoxConvert_Click(object sender, EventArgs e)
        {
            new HexConvert().Show();
        }

        private const int SHCNF_IDLIST = 0x0;
    }
}