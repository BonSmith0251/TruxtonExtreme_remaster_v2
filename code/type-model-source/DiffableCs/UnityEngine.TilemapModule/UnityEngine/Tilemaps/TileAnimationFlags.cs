namespace UnityEngine.Tilemaps;

[Flags]
[Token(Token = "0x200000A")]
public enum TileAnimationFlags : int
{
	None = 0,
	LoopOnce = 1,
	PauseAnimation = 2,
	UpdatePhysics = 4,
	UnscaledTime = 8,
	SyncAnimation = 16,
}

