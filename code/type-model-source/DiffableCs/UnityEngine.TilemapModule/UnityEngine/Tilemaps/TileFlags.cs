namespace UnityEngine.Tilemaps;

[Flags]
[Token(Token = "0x2000009")]
public enum TileFlags : int
{
	None = 0,
	LockColor = 1,
	LockTransform = 2,
	InstantiateGameObjectRuntimeOnly = 4,
	KeepGameObjectRuntimeOnly = 8,
	LockAll = 3,
}

