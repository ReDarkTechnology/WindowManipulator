using System;
using System.IO;

[Serializable]
public class Metadata
{
    private string m_op;
    public string OriginalPath {
        get
        {
            return m_op;
        }
        set
        {
            OriginalDirectory = Path.GetDirectoryName(value);
            m_op = value;
        }
    }
    public string OriginalDirectory;
    string m_md5;
    public string md5 {
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
    public override string ToString()
    {
        return null; // JsonConvert.SerializeObject(this);
    }
    public static Metadata Parse(string val)
    {
        return null; // JsonConvert.DeserializeObject<Metadata>(val);
    }
}
