Imports System.Runtime.InteropServices

Module spyapi
    '通用API===============================================================================
    '获取错误信息
    Public Declare Function GetLastError Lib "kernel32" Alias "GetLastError" () As Integer
    '发送消息
    Public Declare Function SendMessageA Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr


    '私用API===========================================================================
    '设置鼠标样式
    Public Declare Function SetSystemCursor Lib "user32" (ByVal hCursor As IntPtr, ByVal id As Integer) As Boolean
    '默认鼠标样式
    Public Declare Function SystemParametersInfoA Lib "user32" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As Integer, ByVal fuWinIni As Integer) As Integer
    '获取鼠标位置
    Public Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    '获取指针处窗口句柄
    Public Declare Function WindowFromPoint Lib "user32" (ByVal Point As Point) As Integer
    '获取窗口大小
    Public Declare Function GetWindowRect Lib "user32.dll" (ByVal hWnd As Integer, ByRef prmtypRECT As Rectangle) As Integer
    '根据句柄获取PID
    Public Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As UInteger, ByRef lpdwProcessId As UInteger) As UInteger
    '根据句柄获取 类名
    Public Declare Auto Function GetClassName Lib "User32.dll" (ByVal hwnd As IntPtr, ByVal lpClassName As System.Text.StringBuilder, ByVal nMaxCount As Integer) As Integer
    '热键
    Public Declare Auto Function RegisterHotKey Lib "user32.dll" Alias "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Boolean
    Public Declare Auto Function UnRegisterHotKey Lib "user32.dll" Alias "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean
    '获取窗口 文本
    Public Declare Function GetWindowTextA Lib "User32.dll" (ByVal hwnd As IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    '设置窗口 文本
    Public Declare Function SetWindowTextA Lib "user32" (ByVal hwnd As Integer, ByVal lpString As String) As Integer
    '窗口标题
    Public Declare Function SendMessageA Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As System.Text.StringBuilder) As IntPtr
    Public Const WM_GETTEXTLENGTH = &HE
    Public Const WM_GETTEXT = &HD
    '冻结窗体
    Public Declare Function EnableWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Boolean
    '控制窗口的显隐性
    Public Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As WindowShowStyle) As Boolean

    Public Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As Integer) As Integer

    Public Declare Function ScreenToClient Lib "user32" Alias "ScreenToClient" (ByVal hwnd As Integer, lpPoint As Point) As Integer

    Public Declare Function GetPixel Lib "gdi32" Alias "GetPixel" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer) As Long

    Declare Function GetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As Integer


    '绘图相关

    Declare Function SetProcessDPIAware Lib "user32.dll" () As Boolean

    Declare Function GetDeviceCaps Lib "gdi32" Alias "GetDeviceCaps" (ByVal hdc As Integer, ByVal nIndex As Integer) As Integer

    Declare Function GetWindowDC Lib "user32" Alias "GetWindowDC" (ByVal hwnd As Integer) As Integer

    Declare Function SetROP2 Lib "gdi32" Alias "SetROP2" (ByVal hdc As Integer, ByVal nDrawMode As Integer) As Integer

    Declare Function CreatePen Lib "gdi32" Alias "CreatePen" (ByVal nPenStyle As Integer, ByVal nWidth As Integer, ByVal crColor As Integer) As Integer

    Declare Function SelectObject Lib "gdi32" Alias "SelectObject" (ByVal hdc As Integer, ByVal hObject As Integer) As Integer

    Declare Function DeleteObject Lib "gdi32" Alias "DeleteObject" (ByVal hObject As Integer) As Integer

    Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As Integer, ByVal hdc As Integer) As Integer


    Declare Function Rectangle Lib "gdi32" Alias "Rectangle" (ByVal hdc As Integer, ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer





    Public Enum WindowShowStyle As UInteger
        ''' <summary>Hides the window and activates another window.</summary>
        ''' <remarks>See SW_HIDE</remarks>
        Hide = 0
        '''<summary>Activates and displays a window. If the window is minimized 
        ''' or maximized, the system restores it to its original size and 
        ''' position. An application should specify this flag when displaying 
        ''' the window for the first time.</summary>
        ''' <remarks>See SW_SHOWNORMAL</remarks>
        ShowNormal = 1
        ''' <summary>Activates the window and displays it as a minimized window.</summary>
        ''' <remarks>See SW_SHOWMINIMIZED</remarks>
        ShowMinimized = 2
        ''' <summary>Activates the window and displays it as a maximized window.</summary>
        ''' <remarks>See SW_SHOWMAXIMIZED</remarks>
        ShowMaximized = 3
        ''' <summary>Maximizes the specified window.</summary>
        ''' <remarks>See SW_MAXIMIZE</remarks>
        Maximize = 3
        ''' <summary>Displays a window in its most recent size and position. 
        ''' This value is similar to "ShowNormal", except the window is not 
        ''' actived.</summary>
        ''' <remarks>See SW_SHOWNOACTIVATE</remarks>
        ShowNormalNoActivate = 4
        ''' <summary>Activates the window and displays it in its current size 
        ''' and position.</summary>
        ''' <remarks>See SW_SHOW</remarks>
        Show = 5
        ''' <summary>Minimizes the specified window and activates the next 
        ''' top-level window in the Z order.</summary>
        ''' <remarks>See SW_MINIMIZE</remarks>
        Minimize = 6
        '''   <summary>Displays the window as a minimized window. This value is 
        '''   similar to "ShowMinimized", except the window is not activated.</summary>
        ''' <remarks>See SW_SHOWMINNOACTIVE</remarks>
        ShowMinNoActivate = 7
        ''' <summary>Displays the window in its current size and position. This 
        ''' value is similar to "Show", except the window is not activated.</summary>
        ''' <remarks>See SW_SHOWNA</remarks>
        ShowNoActivate = 8
        ''' <summary>Activates and displays the window. If the window is 
        ''' minimized or maximized, the system restores it to its original size 
        ''' and position. An application should specify this flag when restoring 
        ''' a minimized window.</summary>
        ''' <remarks>See SW_RESTORE</remarks>
        Restore = 9
        ''' <summary>Sets the show state based on the SW_ value specified in the 
        ''' STARTUPINFO structure passed to the CreateProcess function by the 
        ''' program that started the application.</summary>
        ''' <remarks>See SW_SHOWDEFAULT</remarks>
        ShowDefault = 10
        ''' <summary>Windows 2000/XP: Minimizes a window, even if the thread 
        ''' that owns the window is hung. This flag should only be used when 
        ''' minimizing windows from a different thread.</summary>
        ''' <remarks>See SW_FORCEMINIMIZE</remarks>
        ForceMinimized = 11

    End Enum





End Module
