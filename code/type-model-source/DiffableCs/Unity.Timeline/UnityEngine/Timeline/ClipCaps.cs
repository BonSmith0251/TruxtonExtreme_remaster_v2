namespace UnityEngine.Timeline;

[Flags]
[Token(Token = "0x2000032")]
public enum ClipCaps : int
{
	None = 0,
	Looping = 1,
	Extrapolation = 2,
	ClipIn = 4,
	SpeedMultiplier = 8,
	Blending = 16,
	AutoScale = 40,
	All = -1,
}

