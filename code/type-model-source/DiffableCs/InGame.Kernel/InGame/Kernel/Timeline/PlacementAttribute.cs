namespace InGame.Kernel.Timeline;

[Flags]
[Token(Token = "0x20000DE")]
public enum PlacementAttribute : int
{
	None = 0,
	Child = 1,
	NoHit = 16,
}

