using System;
using System.IO;

public class AudioClip : Asset
{
    public Metadata metadata;
    public byte[] data;
    public static AudioClip GetAudioClip(string path)
    {
        var clip = new AudioClip();
        return clip;
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
        return typeof(AudioClip);
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