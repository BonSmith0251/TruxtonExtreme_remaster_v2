namespace UnityEngine.TextCore.LowLevel;

[Flags]
[Token(Token = "0x2000010")]
public enum FontFeatureLookupFlags : int
{
	None = 0,
	IgnoreLigatures = 4,
	IgnoreSpacingAdjustments = 256,
}

