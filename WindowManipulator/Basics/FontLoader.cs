using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

public static class FontLoader {

    public static PrivateFontCollection pfc = new PrivateFontCollection();
    static bool IsInitialized;
    public static void Initialize()
    {
        if (!IsInitialized)
        {
            //AddMemoryFont(Stority.Properties.Resources.Square);
            IsInitialized = true;
        }
    }

    public static void AddMemoryFont(byte[] fontData)
    {
        //Select your font from the resources.
        int fontLength = fontData.Length;

        // create a buffer to read in to
        byte[] fontdata = fontData;

        // create an unsafe memory block for the font data
        System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

        // copy the bytes to the unsafe memory block
        Marshal.Copy(fontdata, 0, data, fontLength);

        // pass the font to the font collection
        pfc.AddMemoryFont(data, fontLength);
    }

    public static void ApplyFonts(Control control)
    {
        var controls = GetControls(control);
        Initialize();
        foreach (var pb in controls)
        {
            pb.Font = new Font(pfc.Families[0], pb.Font.Size);
        }
    }

    static Control[] GetControls(Control control)
    {
        List<Control> controll = new List<Control>();
        foreach (Control pb in control.Controls)
        {
            controll.Add(pb);
        }
        foreach (Control ctrl in control.Controls)
        {
            var controls = GetControls(ctrl);
            foreach (var butt in controls)
            {
                controll.Add(butt);
            }
        }
        return controll.ToArray();
    }
}

