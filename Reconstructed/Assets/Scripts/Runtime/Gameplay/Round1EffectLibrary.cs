using System;
using UnityEngine;

// Resources/Truxton/EffectLibrary.asset (Round1EffectBuilder): imported original effect prefabs by their source name.
public sealed class Round1EffectLibrary : ScriptableObject
{
    [Serializable] public class Effect { public string name;public GameObject prefab; }
    public Effect[] prefabs;
}
