using System.Windows.Forms;
public static class Initializer
{
    public static bool IsInitialized;
    static bool IsControlRequiredInitialized;
    public static bool DebugMode = true;
    public static void Initalize(Control control = null)
    {
        if (!IsInitialized)
        {
            Time.InitializeTime();
            Coroutine.Initialize();
            IsInitialized = true;
        }
        if (!IsControlRequiredInitialized)
        {
            if (control != null)
            {
                Input.AddKeyListener(control);
                IsControlRequiredInitialized = true;
            }
        }
    }
}
