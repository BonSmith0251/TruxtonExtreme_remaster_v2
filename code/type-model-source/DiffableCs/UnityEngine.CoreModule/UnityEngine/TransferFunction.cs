namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[Token(Token = "0x2000113")]
[UsedByNativeCode]
public enum TransferFunction : int
{
	Unknown = -1,
	sRGB = 0,
	BT1886 = 1,
	PQ = 2,
	Linear = 3,
	Gamma22 = 4,
}

