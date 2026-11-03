using System;
using UnityEngine;

public sealed class Round1GroundEnemyLibrary : ScriptableObject
{
    [Serializable] public class Visual { public string name;public GameObject prefab; }
    public TextAsset source;
    public Visual[] prefabs;
}
