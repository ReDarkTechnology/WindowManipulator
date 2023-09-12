using System;
using System.Reflection;
using System.Linq;

public static class Behavioural {
	public static void InvokeUpdate()
    {
        foreach (Type mytype in 
            Assembly.GetExecutingAssembly().GetTypes().Where(
                    mytype => mytype.GetInterfaces()
                    .Contains(typeof(EngineBehavioural)
                )
            )
        )
        {
            mytype.GetMethod("Update").Invoke(Activator.CreateInstance(mytype, null), null);
        }
    }
	public static void InvokeStart()
    {
        foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes().Where(mytype => mytype.GetInterfaces().Contains(typeof(EngineBehavioural))))
        {
            mytype.GetMethod("Start").Invoke(Activator.CreateInstance(mytype, null), null);
        }
    }
}
public interface EngineBehavioural
{
}