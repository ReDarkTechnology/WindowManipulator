using System;


public static class Debug
{
    public static Action<DebugInfo> OnWarning;
    public static Action<DebugInfo> OnInfo;
    public static Action<DebugInfo> OnError;

    public static void Log(object sender, object argument)
    {
        if(OnInfo != null) OnInfo.Invoke(new DebugInfo()
        {
            type = DebugType.Info,
            sender = sender,
            arguments = argument
        });
    }
    public static void LogError(object sender, object argument)
    {
        if (OnInfo != null) OnInfo.Invoke(new DebugInfo()
        {
            type = DebugType.Error,
            sender = sender,
            arguments = argument
        });
    }
    public static void LogWarning(object sender, object argument)
    {
        if (OnInfo != null) OnInfo.Invoke(new DebugInfo()
        {
            type = DebugType.Warning,
            sender = sender,
            arguments = argument
        });
    }
}
[Serializable]
public class DebugInfo
{
    public DebugType type;
    public object sender;
    public object arguments;
}
public enum DebugType
{
    Error,
    Warning,
    Info
}
