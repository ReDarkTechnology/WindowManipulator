using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class Input : EngineBehavioural {
    #region InputKeys
    public static List<Keys> keyDowns = new List<Keys>();
    public static Action<Keys> OnKeyDown;
	public List<Keys> keyDownsRemove = new List<Keys>();
	public static List<Keys> keyUps = new List<Keys>();
    public static Action<Keys> OnKeyUp;
	public List<Keys> keyUpsRemove = new List<Keys>();
	public static List<Keys> keyPressed = new List<Keys>();
	public List<Keys> keyPressedRemove = new List<Keys>();
    #endregion
    #region CheckAdding
    public void Start(){
	}
	public static List<KeyStatement> statements = new List<KeyStatement>();
	public static bool LogInputs = true;
	public void Update(){
		keyDowns = new List<Keys>();
		keyUps = new List<Keys>();
		var keyDestroyQueue = new List<KeyStatement>();
		foreach(KeyStatement stat in statements){
			if(stat.keyTime > 0){
				stat.keyTime--;
			}else{
				stat.isDoneDown = true;
			}
			if(!stat.isDoneDown){
				keyDowns.Add(stat.keyCode);
				keyPressed.Add(stat.keyCode);
			}
			if(stat.isDoneDown){
				if(!stat.isPressed){
					if(!stat.isUp){
						keyUps.Add(stat.keyCode);
						keyPressed.Remove(stat.keyCode);
						stat.isUp = true;
					}else{
						keyDestroyQueue.Add(stat);
					}
				}
			}
		}
		foreach(KeyStatement stat in keyDestroyQueue){
			statements.Remove(stat);
		}
	}
    #endregion
    #region InputResults
    public static bool IsKeyPressedDown(Keys keyCode){
		return keyDowns.Contains(keyCode);
	}
	public static bool IsKeyPressedUp(Keys keyCode){
		return keyUps.Contains(keyCode);
	}
	public static bool IsKeyPressed(Keys keyCode){
		return keyPressed.Contains(keyCode);
	}
	public static bool IsStatementsHasKey(Keys keyCode){
		bool result = false;
		foreach(KeyStatement stat in statements){
			if(stat.keyCode.ToString() == keyCode.ToString()) result = true;
		}
		return result;
	}
	public static KeyResult GetKey(Keys keyCode){
		bool result = false;
		int index = 0;
		var res = new KeyResult();
		foreach(KeyStatement stat in statements){
			if(stat.keyCode.ToString() == keyCode.ToString()){
				result = true;
				res.statement = stat;
				res.index = index;
			}
			index++;
		}
		res.isExist = result;
		return res;
	}
    #endregion
    #region Listener
    public static void AddKeyListener(Control control)
    {
        var ctr = Utility.GetControls(control);
        AddListenerTo(control);
        foreach(var a in ctr)
        {
        	AddListenerTo(a);
        }
    }
    /// <summary>
    /// Adding listener without the child controls
    /// </summary>
    /// <param name="ctr">The target control</param>
    public static void AddListenerTo(Control ctr){
        ctr.KeyDown += (ee, val) =>
        {
            if (!IsStatementsHasKey(val.KeyCode))
            {
                KeyStatement stat = new KeyStatement();
            	if(OnKeyDown != null) OnKeyDown.Invoke(val.KeyCode);
                stat.keyCode = val.KeyCode;
                stat.keyTime = 1;
                stat.isPressed = true;
                statements.Add(stat);
            }
        };
        ctr.KeyUp += (ee, val) =>
        {
            KeyResult keyRes = GetKey(val.KeyCode);
            if(OnKeyUp != null) OnKeyUp.Invoke(val.KeyCode);
            if (keyRes.isExist)
            {
                keyRes.statement.isPressed = false;
            }
        };
        if(Initializer.DebugMode) Console.WriteLine("Implemented on : " + ctr.Name);
    }
    #endregion
}
[Serializable]
public class KeyStatement
{
    public Keys keyCode;
    public int keyTime;
    public bool isPressed;
    public bool isDoneDown;
    public bool isUp;
}
[Serializable]
public class KeyResult
{
    public bool isExist;
    public KeyStatement statement;
    public int index;
}