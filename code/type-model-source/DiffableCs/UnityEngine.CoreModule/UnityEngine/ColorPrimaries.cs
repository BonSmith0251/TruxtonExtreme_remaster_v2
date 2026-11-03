namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[Token(Token = "0x2000111")]
[UsedByNativeCode]
public enum ColorPrimaries : int
{
	Unknown = -1,
	Rec709 = 0,
	Rec2020 = 1,
	P3 = 2,
}

