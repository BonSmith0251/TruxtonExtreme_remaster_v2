namespace UnityEngine.Rendering;

[Token(Token = "0x20001B5")]
public static class BitArrayUtilities
{

	[Address(RVA = "0x2C3CA10", Offset = "0x2C3BE10", Length = "0x1C")]
	[Token(Token = "0x6000D43")]
	public static bool Get128(uint index, ulong data1, ulong data2) { }

	[Address(RVA = "0x2C3CA30", Offset = "0x2C3BE30", Length = "0x13")]
	[Token(Token = "0x6000D40")]
	public static bool Get16(uint index, ushort data) { }

	[Address(RVA = "0x2C3CA50", Offset = "0x2C3BE50", Length = "0x3B")]
	[Token(Token = "0x6000D44")]
	public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4) { }

	[Address(RVA = "0x2C3CA90", Offset = "0x2C3BE90", Length = "0xD")]
	[Token(Token = "0x6000D41")]
	public static bool Get32(uint index, uint data) { }

	[Address(RVA = "0x2C3CAA0", Offset = "0x2C3BEA0", Length = "0xF")]
	[Token(Token = "0x6000D42")]
	public static bool Get64(uint index, ulong data) { }

	[Address(RVA = "0x2C3CAB0", Offset = "0x2C3BEB0", Length = "0x13")]
	[Token(Token = "0x6000D3F")]
	public static bool Get8(uint index, byte data) { }

	[Address(RVA = "0x2C3CAD0", Offset = "0x2C3BED0", Length = "0x3C")]
	[Token(Token = "0x6000D49")]
	public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value) { }

	[Address(RVA = "0x2C3CB10", Offset = "0x2C3BF10", Length = "0x19")]
	[Token(Token = "0x6000D46")]
	public static void Set16(uint index, ref ushort data, bool value) { }

	[Address(RVA = "0x2C3CB30", Offset = "0x2C3BF30", Length = "0x6D")]
	[Token(Token = "0x6000D4A")]
	public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value) { }

	[Address(RVA = "0x2C3CBA0", Offset = "0x2C3BFA0", Length = "0x16")]
	[Token(Token = "0x6000D47")]
	public static void Set32(uint index, ref uint data, bool value) { }

	[Address(RVA = "0x2C3CBC0", Offset = "0x2C3BFC0", Length = "0x1B")]
	[Token(Token = "0x6000D48")]
	public static void Set64(uint index, ref ulong data, bool value) { }

	[Address(RVA = "0x2C3CBE0", Offset = "0x2C3BFE0", Length = "0x17")]
	[Token(Token = "0x6000D45")]
	public static void Set8(uint index, ref byte data, bool value) { }

}

