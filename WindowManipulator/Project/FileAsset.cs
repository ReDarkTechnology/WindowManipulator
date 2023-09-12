using System;
using System.IO;


[Serializable]
public class FileAsset : Asset
{
    public Metadata metadata;
    public byte[] data;
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
    public bool IsResourceLoaded()
    {
        return isLoaded;
    }
    public Type GetActualType()
    {
        return typeof(FileAsset);
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
