namespace TXEKernel;

[Token(Token = "0x20000EA")]
public static class TXEParameters
{
	[Token(Token = "0x40004B7")]
	private static readonly int SpeedRateID; //Field offset: 0x0
	[Token(Token = "0x40004B8")]
	private static readonly int ScaledTimeID; //Field offset: 0x4

	[Address(RVA = "0x27168F0", Offset = "0x2715CF0", Length = "0x7A")]
	[Token(Token = "0x60006E8")]
	private static TXEParameters() { }

	[Address(RVA = "0x2716860", Offset = "0x2715C60", Length = "0x8A")]
	[Token(Token = "0x60006E7")]
	public static void UpdateShaderParameters(float ttime, float tscale) { }

}

