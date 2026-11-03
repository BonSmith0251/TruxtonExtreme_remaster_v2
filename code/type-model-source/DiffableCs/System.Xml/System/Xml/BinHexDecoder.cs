namespace System.Xml;

[Token(Token = "0x200000B")]
internal class BinHexDecoder : IncrementalReadDecoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000C")]
	private Byte[] buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	private int curIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000E")]
	private int endIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	private bool hasHalfByteCached; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000010")]
	private byte cachedHalfByte; //Field offset: 0x21

	[Token(Token = "0x17000001")]
	internal virtual bool IsFull
	{
		[Address(RVA = "0x23EE820", Offset = "0x23EDC20", Length = "0xA")]
		[Token(Token = "0x600000F")]
		internal get { } //Length: 10
	}

	[Address(RVA = "0x23EE600", Offset = "0x23EDA00", Length = "0x21C")]
	[Token(Token = "0x6000010")]
	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	[Address(RVA = "0x23EE170", Offset = "0x23ED570", Length = "0x30B")]
	[Token(Token = "0x6000011")]
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	[Address(RVA = "0x23EE480", Offset = "0x23ED880", Length = "0x179")]
	[Token(Token = "0x6000012")]
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

	[Address(RVA = "0x23EE820", Offset = "0x23EDC20", Length = "0xA")]
	[Token(Token = "0x600000F")]
	internal virtual bool get_IsFull() { }

}

