using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

public static class Configuration
{
	public static string configPath = GetRidOfLastPath(GetRidOfLastPath(Application.UserAppDataPath)) + Path.DirectorySeparatorChar + "config.json";
	public static string dirPath = GetRidOfLastPath(GetRidOfLastPath(Application.UserAppDataPath));
    // A string field class to store the data;
    [Serializable]
	public class StringField {
		public string name;
		public string value;
	}
	// A prefs data class for saving the entire fields into one data.
	[Serializable]
	public class PrefsData {
		public string computerUniqueID;
		public List<StringField> prefs;
	}
	/// <summary>
	/// Saving a string into the CustomPlayerPrefs database.
	/// </summary>
	/// <param name="name">The prefs name</param>
	/// <param name="value">The prefs value</param>
	public static void SetString(string name, string value){
		
	}
	/// <summary>
	/// Getting a string from the CustomPlayerPrefs database
	/// </summary>
	/// <param name="name">Field name</param>
	/// <param name="defaultValue">If there's no data found, return the default value</param>
	/// <returns>The fetched data, if there's no default value set, return null.</returns>
	public static string GetString(string name, string defaultValue = null){
        return null;
	}
	static int ValueExists(List<StringField> val, string name){
		int index = 0;
		foreach(StringField a in val){
			if(a.name == name){
				return index;
			}
			index++;
		}
		return (-1);
	}
	static bool ConfigExists(){
		return File.Exists(configPath);
	}
	static string GetFileData(){
		// Read a file from the path, and the return the decrypted string.
		return File.ReadAllText(configPath);
	}
	public static string GetRidOfLastPath(string dir){
		var e = dir.Split(Path.DirectorySeparatorChar);
		var y = dir.Remove(dir.Length - e[e.Length - 1].Length, e[e.Length - 1].Length);
        if(y.EndsWith("\\") || y.EndsWith("/"))
        {
            y = y.Remove(y.Length - 1, 1);
        }
		return y;
	}
	static void SaveFile(string data){
		// Encrypting the data and then saving the string into a file on the specified path.
		if(!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
		File.WriteAllText(configPath, data);
	}

}