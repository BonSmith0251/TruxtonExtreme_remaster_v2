namespace UnityEngine;

[Flags]
[Token(Token = "0x2000121")]
public enum MaterialGlobalIlluminationFlags : int
{
	None = 0,
	RealtimeEmissive = 1,
	BakedEmissive = 2,
	EmissiveIsBlack = 4,
	AnyEmissive = 3,
}

