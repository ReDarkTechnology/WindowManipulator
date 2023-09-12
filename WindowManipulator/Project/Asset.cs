using System;


public interface Asset
{
    void LoadResource();
    string GetMD5();
    byte[] GetData();
    bool IsResourceLoaded();
    Type GetActualType();
    Metadata GetMetadata();
    void Destroy();
}
