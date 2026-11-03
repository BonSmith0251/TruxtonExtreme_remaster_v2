namespace UnityEngine.Timeline;

[Flags]
[Token(Token = "0x2000010")]
public enum MatchTargetFields : int
{
	PositionX = 1,
	PositionY = 2,
	PositionZ = 4,
	RotationX = 8,
	RotationY = 16,
	RotationZ = 32,
}

