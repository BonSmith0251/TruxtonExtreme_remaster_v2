using System;
using UnityEngine;

public sealed class Round1EnemyAttackLibrary : ScriptableObject
{
    [Serializable] public class Bullet { public string name;public GameObject prefab; }
    public TextAsset source;
    public Bullet[] bullets;
    public Material laserMaterial;
}
