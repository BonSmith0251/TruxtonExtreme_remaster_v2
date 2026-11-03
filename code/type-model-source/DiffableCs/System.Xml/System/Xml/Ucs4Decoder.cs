namespace System.Xml;

[Token(Token = "0x20000D5")]
internal abstract class Ucs4Decoder : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000572")]
	internal Byte[] lastBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000573")]
	internal int lastBytesCount; //Field offset: 0x28

	[Address(RVA = "0x254AD90", Offset = "0x254A190", Length = "0x55")]
	[Token(Token = "0x6000B40")]
	protected Ucs4Decoder() { }

	[Address(RVA = "0x254B630", Offset = "0x254AA30", Length = "0x240")]
	[Token(Token = "0x6000B3E")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x254B880", Offset = "0x254AC80", Length = "0x10")]
	[Token(Token = "0x6000B3B")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x254B890", Offset = "0x254AC90", Length = "0x1B6")]
	[Token(Token = "0x6000B3D")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Token(Token = "0x6000B3C")]
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x254BA50", Offset = "0x254AE50", Length = "0x60")]
	[Token(Token = "0x6000B3F")]
	internal void Ucs4ToUTF16(uint code, Char[] chars, int charIndex) { }

}

