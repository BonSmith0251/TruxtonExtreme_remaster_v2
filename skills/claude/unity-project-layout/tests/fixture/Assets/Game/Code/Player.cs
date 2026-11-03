using UnityEngine;
public class Player : MonoBehaviour
{
    public const string ConfigPath="Assets/Game/Data/config.json";   // a path string no move updates
    public static TextAsset Level()=>Resources.Load<TextAsset>("level");
}
