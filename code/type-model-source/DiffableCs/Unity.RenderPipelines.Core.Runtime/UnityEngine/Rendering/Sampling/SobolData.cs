namespace UnityEngine.Rendering.Sampling;

[Token(Token = "0x2000238")]
internal static class SobolData
{
	[Token(Token = "0x40009EF")]
	public const uint SobolDims = 1024; //Field offset: 0x0
	[Token(Token = "0x40009F0")]
	public const uint SobolSize = 52; //Field offset: 0x0
	[Token(Token = "0x40009F1")]
	public static readonly UInt32[] SobolMatrices; //Field offset: 0x0

	[Address(RVA = "0x2C88180", Offset = "0x2C87580", Length = "0x8C")]
	[Token(Token = "0x6000FDE")]
	private static SobolData() { }

}

