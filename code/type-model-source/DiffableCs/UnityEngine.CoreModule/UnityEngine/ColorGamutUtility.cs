namespace UnityEngine;

[Token(Token = "0x20000E4")]
public class ColorGamutUtility
{

	[Address(RVA = "0x2FF1BC0", Offset = "0x2FF0FC0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60006A8")]
	public static ColorPrimaries GetColorPrimaries(ColorGamut gamut) { }

	[Address(RVA = "0x2FF1C00", Offset = "0x2FF1000", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60006AA")]
	public static TransferFunction GetTransferFunction(ColorGamut gamut) { }

	[Address(RVA = "0x2FF1C40", Offset = "0x2FF1040", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60006A9")]
	public static WhitePoint GetWhitePoint(ColorGamut gamut) { }

}

