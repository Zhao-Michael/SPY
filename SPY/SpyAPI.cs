using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SPY
{
    public static class SpyAPI
    {
        // 通用API===============================================================================
        // 获取错误信息
        [DllImport("kernel32", EntryPoint = "GetLastError")]
        public static extern int GetLastError();
        // 发送消息
        [DllImport("User32.dll")]
        public static extern IntPtr SendMessageA(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        // 私用API===========================================================================
        // 设置鼠标样式
        [DllImport("user32")]
        public static extern bool SetSystemCursor(IntPtr hCursor, int id);
        // 默认鼠标样式
        [DllImport("user32")]
        public static extern int SystemParametersInfoA(int uAction, int uParam, int lpvParam, int fuWinIni);
        // 获取鼠标位置
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);
        // 获取指针处窗口句柄
        [DllImport("user32")]
        public static extern int WindowFromPoint(Point Point);
        // 获取窗口大小
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(int hWnd, ref Rectangle prmtypRECT);
        // 根据句柄获取PID
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(uint hwnd, ref uint lpdwProcessId);
        // 根据句柄获取 类名
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hwnd, System.Text.StringBuilder lpClassName, int nMaxCount);
        // 热键
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey", CharSet = CharSet.Auto)]
        public static extern bool RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll", EntryPoint = "UnregisterHotKey", CharSet = CharSet.Auto)]
        public static extern bool UnRegisterHotKey(IntPtr hwnd, int id);
        // 获取窗口 文本
        [DllImport("User32.dll")]
        public static extern int GetWindowTextA(IntPtr hwnd, System.Text.StringBuilder lpString, int cch);
        // 设置窗口 文本
        [DllImport("user32")]
        public static extern int SetWindowTextA(int hwnd, string lpString);
        // 窗口标题
        [DllImport("User32.dll")]
        public static extern IntPtr SendMessageA(IntPtr hWnd, uint Msg, IntPtr wParam, System.Text.StringBuilder lParam);

        public const int WM_GETTEXTLENGTH = 0xE;
        public const int WM_GETTEXT = 0xD;
        // 冻结窗体
        [DllImport("user32.dll")]
        public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);
        // 控制窗口的显隐性
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hwnd, WindowShowStyle nCmdShow);
        [DllImport("user32", EntryPoint = "GetDC")]
        public static extern int GetDC(int hwnd);
        [DllImport("user32", EntryPoint = "ScreenToClient")]
        public static extern int ScreenToClient(int hwnd, Point lpPoint);
        [DllImport("gdi32", EntryPoint = "GetPixel")]
        public static extern int GetPixel(int hdc, int x, int y);
        [DllImport("user32", EntryPoint = "SendMessageA")]
        public static extern long SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32", EntryPoint = "GetDesktopWindow")]
        public static extern int GetDesktopWindow();

        // 移动窗口
        [DllImport("user32")]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);


        // 绘图相关

        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
        [DllImport("gdi32", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps(int hdc, int nIndex);
        [DllImport("user32", EntryPoint = "GetWindowDC")]
        public static extern int GetWindowDC(int hwnd);
        [DllImport("gdi32", EntryPoint = "SetROP2")]
        public static extern int SetROP2(int hdc, int nDrawMode);
        [DllImport("gdi32", EntryPoint = "CreatePen")]
        public static extern int CreatePen(int nPenStyle, int nWidth, int crColor);
        [DllImport("gdi32", EntryPoint = "SelectObject")]
        public static extern int SelectObject(int hdc, int hObject);
        [DllImport("gdi32", EntryPoint = "DeleteObject")]
        public static extern int DeleteObject(int hObject);
        [DllImport("user32", EntryPoint = "ReleaseDC")]
        public static extern int ReleaseDC(int hwnd, int hdc);
        [DllImport("gdi32", EntryPoint = "Rectangle")]
        public static extern int Rectangle(int hdc, int X1, int Y1, int X2, int Y2);

        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public int fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public int dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        [DllImport("Shell32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        public const int SW_NORMAL = 1;

        public enum WindowShowStyle : uint
        {
            /// <summary>Hides the window and activates another window.</summary>
            /// <remarks>See SW_HIDE</remarks>
            Hide = 0U,
            /// <summary>Activates and displays a window. If the window is minimized
            /// or maximized, the system restores it to its original size and
            /// position. An application should specify this flag when displaying
            /// the window for the first time.</summary>
            /// <remarks>See SW_SHOWNORMAL</remarks>
            ShowNormal = 1U,
            /// <summary>Activates the window and displays it as a minimized window.</summary>
            /// <remarks>See SW_SHOWMINIMIZED</remarks>
            ShowMinimized = 2U,
            /// <summary>Activates the window and displays it as a maximized window.</summary>
            /// <remarks>See SW_SHOWMAXIMIZED</remarks>
            ShowMaximized = 3U,
            /// <summary>Maximizes the specified window.</summary>
            /// <remarks>See SW_MAXIMIZE</remarks>
            Maximize = 3U,
            /// <summary>Displays a window in its most recent size and position.
            /// This value is similar to "ShowNormal", except the window is not
            /// actived.</summary>
            /// <remarks>See SW_SHOWNOACTIVATE</remarks>
            ShowNormalNoActivate = 4U,
            /// <summary>Activates the window and displays it in its current size
            /// and position.</summary>
            /// <remarks>See SW_SHOW</remarks>
            Show = 5U,
            /// <summary>Minimizes the specified window and activates the next
            /// top-level window in the Z order.</summary>
            /// <remarks>See SW_MINIMIZE</remarks>
            Minimize = 6U,
            /// <summary>Displays the window as a minimized window. This value is
            /// similar to "ShowMinimized", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWMINNOACTIVE</remarks>
            ShowMinNoActivate = 7U,
            /// <summary>Displays the window in its current size and position. This
            /// value is similar to "Show", except the window is not activated.</summary>
            /// <remarks>See SW_SHOWNA</remarks>
            ShowNoActivate = 8U,
            /// <summary>Activates and displays the window. If the window is
            /// minimized or maximized, the system restores it to its original size
            /// and position. An application should specify this flag when restoring
            /// a minimized window.</summary>
            /// <remarks>See SW_RESTORE</remarks>
            Restore = 9U,
            /// <summary>Sets the show state based on the SW_ value specified in the
            /// STARTUPINFO structure passed to the CreateProcess function by the
            /// program that started the application.</summary>
            /// <remarks>See SW_SHOWDEFAULT</remarks>
            ShowDefault = 10U,
            /// <summary>Windows 2000/XP: Minimizes a window, even if the thread
            /// that owns the window is hung. This flag should only be used when
            /// minimizing windows from a different thread.</summary>
            /// <remarks>See SW_FORCEMINIMIZE</remarks>
            ForceMinimized = 11U
        }

        public class CursorGenerator
        {
            // Methods

            public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
            {
                var tmp = new IconInfo();
                GetIconInfo(bmp.GetHicon(), ref tmp);
                tmp.xHotspot = xHotSpot;
                tmp.yHotspot = yHotSpot;
                tmp.fIcon = false;
                return new Cursor(CreateIconIndirect(ref tmp));
            }

            [DllImport("user32.dll")]
            public static extern IntPtr CreateIconIndirect(ref IconInfo icon);
            [DllImport("user32.dll")]
            public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

            // Nested Types
            [StructLayout(LayoutKind.Sequential)]
            public struct IconInfo
            {
                public bool fIcon;
                public int xHotspot;
                public int yHotspot;
                public IntPtr hbmMask;
                public IntPtr hbmColor;
            }
        }
    }
}