using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using NativeInvoker;

public class NativeWindow
{
    public IntPtr window;
    public string name;
    public NativeRect rect;

    public Vector2 size
    {
        get
        {
            WindowManager.GetWindowRect(window, ref rect);
            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;
            return new Vector2(width, height);
        }
        set
        {
            WindowManager.GetWindowRect(window, ref rect);
            WindowManager.MoveWindow(window, Convert.ToInt32(position.x), Convert.ToInt32(position.y), Convert.ToInt32(value.x), Convert.ToInt32(value.y), true);
        }
    }

    public Vector2 position
    {
        get
        {
            WindowManager.GetWindowRect(window, ref rect);
            return new Vector2(rect.Left, rect.Top);
        }
        set
        {
            WindowManager.GetWindowRect(window, ref rect);
            WindowManager.MoveWindow(window, Convert.ToInt32(value.x), Convert.ToInt32(value.y), Convert.ToInt32(size.x), Convert.ToInt32(size.y), true);
        }
    }

    public NativeWindowState windowState
    {
        get => (NativeWindowState) RefreshPlacement().showCmd;
        set => SetPlacement(value);
    }

    public NativeWindowStyle windowStyle
    {
        get => (NativeWindowStyle)WindowManager.GetWindowLong(window, (int)NativeWindowLong.GWL_STYLE);
        set => WindowManager.SetWindowLong(window, (int)NativeWindowLong.GWL_STYLE, (int)value);
    }

    public NativeWindow(IntPtr window) => this.window = window;
    public void RefreshRect() => WindowManager.GetWindowRect(window, ref rect);
    public NativeWindowPlacement RefreshPlacement()
    {
        NativeWindowPlacement placement;
        placement.length = Marshal.SizeOf(typeof(NativeWindowPlacement));
        WindowManager.GetWindowPlacement(window, out placement);
        return placement;
    }

    public bool SetPlacement(NativeWindowState windowState)
    {
        bool result = WindowManager.ShowWindowAsync(window, (int)windowState);
        if (result) RefreshPlacement();
        return result;
    }
}

public class WindowStyleComboBox : FlagEnumComboBox<NativeWindowStyle> { }