namespace System.Xml;

[Token(Token = "0x20000CE")]
internal class UTF16Decoder : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400056F")]
	private bool bigEndian; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000570")]
	private int lastByte; //Field offset: 0x24

	[Address(RVA = "0x254AAA0", Offset = "0x2549EA0", Length = "0x2D")]
	[Token(Token = "0x6000B16")]
	public UTF16Decoder(bool bigEndian) { }

	[Address(RVA = "0x254A4E0", Offset = "0x25498E0", Length = "0x290")]
	[Token(Token = "0x6000B1A")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x1E9FC90", Offset = "0x1E9F090", Length = "0x27")]
	[Token(Token = "0x6000B17")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x254A780", Offset = "0x2549B80", Length = "0xEC")]
	[Token(Token = "0x6000B18")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x254A870", Offset = "0x2549C70", Length = "0x224")]
	[Token(Token = "0x6000B19")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

}

