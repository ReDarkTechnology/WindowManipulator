using System;
using System.Runtime.InteropServices;

namespace NativeInvoker
{
    public static class WindowManager
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern bool GetWindowPlacement(IntPtr hwnd, out NativeWindowPlacement placement);
        [DllImport("user32.dll")]
        public static extern bool SetWindowPlacement(IntPtr hwnd, [In] ref NativeWindowPlacement placement);
        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr handle, IntPtr handleAfter, int x, int y, int cx, int cy, uint flags);
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr child, IntPtr newParent);
        [DllImport("user32.dll")]
        public static extern IntPtr ShowWindow(IntPtr handle, int command);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref NativeRect lpRect);
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        public static bool MoveWindowPositon(string name, int x, int y)
        {
            try
            {
                var win = GetWindow(name);
                win.position = new Vector2(x, y);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static NativeWindow GetWindow(string name, NativeWindowState state = NativeWindowState.ShowNA)
        {
            var win = FindWindowByCaption(IntPtr.Zero, name);
            ShowWindowAsync(win, (int)state);
            NativeWindow w = null;
            if (win != default(IntPtr))
            {
                w = new NativeWindow(win);
                w.name = name;
            }
            GetWindowRect(win, ref w.rect);
            return w;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NativeWindowPlacement
    {
        public int length;
        public int flags;
        public int showCmd;
        public NativePoint minPosition;
        public NativePoint maxPosition;
        public NativeRect normalPosition;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeRect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NativePoint
    {
        public int x;
        public int y;
    }

    public enum NativeWindowState
    {
        Hide = 0,
        ShowNormal = 1,
        ShowMinimized = 2,
        ShowMaximized = 3,
        ShowNoActivate = 4,
        Show = 5,
        Minimize = 6,
        ShowMinNoActive = 7,
        ShowNA = 8,
        Restore = 9,
        ShowDefault = 10,
        ForceMinimize = 11
    }
    
    [Flags]
    public enum NativeWindowStyle : uint
    {
        WS_OVERLAPPED = 0x00000000,
        WS_POPUP = 0x80000000,
        WS_CHILD = 0x40000000,
        WS_MINIMIZE = 0x20000000,
        WS_VISIBLE = 0x10000000,
        WS_DISABLED = 0x08000000,
        WS_CLIPSIBLINGS = 0x04000000,
        WS_CLIPCHILDREN = 0x02000000,
        WS_MAXIMIZE = 0x01000000,
        WS_CAPTION = 0x00C00000,
        WS_BORDER = 0x00800000,
        WS_DLGFRAME = 0x00400000,
        WS_VSCROLL = 0x00200000,
        WS_HSCROLL = 0x00100000,
        WS_SYSMENU = 0x00080000,
        WS_THICKFRAME = 0x00040000,
        WS_GROUP = 0x00020000,
        WS_TABSTOP = 0x00010000,
        WS_MINIMIZEBOX = 0x00020000,
        WS_MAXIMIZEBOX = 0x00010000
    }

    public enum NativeWindowLong
    {
        GWL_EXSTYLE = -20,
        GWL_HINSTANCE = -6,
        GWL_HWNDPARENT = -8,
        GWL_ID = -12,
        GWL_STYLE = -16,
        GWL_USERDATA = -21,
        GWL_WNDPROC = -4
    }
}