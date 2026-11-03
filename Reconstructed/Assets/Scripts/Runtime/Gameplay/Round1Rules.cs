using System;
using UnityEngine;

public enum Round1Arms { Red, Green, Blue, Gold, Silver, Purple, Black }

[Serializable] public class Round1ShotSpec { public int mask,muzzle; public float angle; public Vector3 offset; }
[Serializable] public class Round1ShotTable { public int kind; public string name; public Round1ShotSpec[] shots; }
[Serializable] public class Round1ShotProfile { public int kind; public string className,prefab; public float speed; public int rapidCount; }
[Serializable] public class Round1Rules
{
    public Round1ShotTable[] tables;
    public Round1ShotProfile[] profiles;
    public float[] speeds;
    public static Round1Rules Read(TextAsset source)
    {
        if(!source)throw new InvalidOperationException("Extracted gameplay parameters are missing.");
        var data=JsonUtility.FromJson<Round1Rules>(source.text);
        if(data.tables.Length!=7 || data.speeds.Length!=6)throw new InvalidOperationException("Incomplete source weapon tables.");
        return data;
    }
}
