using System;
using System.IO;


[Serializable]
public class ImageAsset : Asset
{
    public static string[] imageExtensions = { ".png", ".jpeg", ".jpg" };
    public static bool IsExtensionImage(string extension)
    {
        bool isEqual = false;
        extension = extension.ToLower();
        if (!extension.StartsWith(".")) extension = "." + extension;
        foreach(var a in imageExtensions)
        {
            if (a == extension) isEqual = true;
        }
        return isEqual;
    }
    public Metadata metadata;
    public byte[] data;
    string m_md5;
    public string md5
    {
        get
        {
            if (m_md5 == null) m_md5 = Utility.GetMD5();
            return m_md5;
        }
        set
        {
            m_md5 = value;
        }
    }
    public string GetMD5()
    {
        return md5;
    }
    bool isLoaded;
    public void LoadResource()
    {
        if (!isLoaded)
        {
            data = File.ReadAllBytes(metadata.OriginalPath);
            isLoaded = true;
        }
    }
    public byte[] GetData()
    {
        LoadResource();
        return data;
    }
    public bool IsResourceLoaded()
    {
        return isLoaded;
    }
    public Type GetActualType()
    {
        return typeof(ImageAsset);
    }
    public Metadata GetMetadata()
    {
        return metadata;
    }
    public void Destroy()
    {
        data = null;
    }
}
