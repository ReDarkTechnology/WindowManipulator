using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class Theme {
    public static Scheme light = new Scheme()
    {
        backgroundColor = Color.FromArgb(255, 240, 240, 240),
        foreColor = Color.Black,
        buttonBackColor = Color.FromArgb(255, 216, 216, 216),
        buttonForeColor = Color.Black,
        labelColor = Color.Black
    };
    public static Scheme dark = new Scheme()
    {
        backgroundColor = Color.FromArgb(255, 25, 25, 25),
        foreColor = Color.White,
        buttonBackColor = Color.FromArgb(255, 25, 25, 25),
        buttonForeColor = Color.White,
        labelColor = Color.White
    };
    public static Scheme custom = new Scheme()
    {
        backgroundColor = Color.FromArgb(255, 25, 25, 25),
        foreColor = Color.White,
        buttonBackColor = Color.FromArgb(255, 25, 25, 25),
        buttonForeColor = Color.White,
        labelColor = Color.White
    };
    public static List<Scheme> schemes = new List<Scheme>(new Scheme[] {
        light, dark
    });
    public static Scheme GetCurrentScheme()
    {
        int UITheme = int.Parse(Configuration.GetString("EditorTheme", "1"));
        return schemes[UITheme];
    }
    public static void SetScheme(int index)
    {
        Configuration.SetString("EditorTheme", index.ToString());
    }
}

[Serializable]
public class Scheme
{
    public Color backgroundColor;
    public Color foreColor;
    public Color buttonBackColor;
    public Color buttonForeColor;
    public Color labelColor;

    public void ApplyScheme(Control control)
    {
        control.BackColor = backgroundColor;
        control.ForeColor = foreColor;
        var controls = Utility.GetControls(control);
        foreach (Control pb in controls)
        {
            pb.BackColor = backgroundColor;
            pb.ForeColor = foreColor;
        }
        var buttons = Utility.GetControlsWithType<Button>(control);
        foreach (var pb in buttons)
        {
            pb.BackColor = buttonBackColor;
            pb.UseCompatibleTextRendering = true;
            pb.ForeColor = buttonForeColor;
        }
        var labels = Utility.GetControlsWithType<Label>(control);
        foreach (var pb in labels)
        {
            pb.UseCompatibleTextRendering = true;
            pb.ForeColor = labelColor;
        }
    }
}