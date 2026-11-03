namespace System.Xml;

[Token(Token = "0x200001A")]
internal static class Bits
{
	[Token(Token = "0x40000CD")]
	private static readonly uint MASK_0101010101010101; //Field offset: 0x0
	[Token(Token = "0x40000CE")]
	private static readonly uint MASK_0011001100110011; //Field offset: 0x4
	[Token(Token = "0x40000CF")]
	private static readonly uint MASK_0000111100001111; //Field offset: 0x8
	[Token(Token = "0x40000D0")]
	private static readonly uint MASK_0000000011111111; //Field offset: 0xC
	[Token(Token = "0x40000D1")]
	private static readonly uint MASK_1111111111111111; //Field offset: 0x10

	[Address(RVA = "0x23F3010", Offset = "0x23F2410", Length = "0x8D")]
	[Token(Token = "0x60000E0")]
	private static Bits() { }

	[Address(RVA = "0x23F2E70", Offset = "0x23F2270", Length = "0x9D")]
	[Token(Token = "0x60000DE")]
	public static int Count(uint num) { }

	[Address(RVA = "0x23F2F10", Offset = "0x23F2310", Length = "0xF8")]
	[Token(Token = "0x60000DF")]
	public static int LeastPosition(uint num) { }

}

