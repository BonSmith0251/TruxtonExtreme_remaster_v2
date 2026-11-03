namespace System.Xml;

[Token(Token = "0x20000CF")]
internal class SafeAsciiDecoder : Decoder
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000B1B")]
	public SafeAsciiDecoder() { }

	[Address(RVA = "0x25434C0", Offset = "0x25428C0", Length = "0xD1")]
	[Token(Token = "0x6000B1E")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x24EB0E0", Offset = "0x24EA4E0", Length = "0x4")]
	[Token(Token = "0x6000B1C")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x25435A0", Offset = "0x25429A0", Length = "0xA2")]
	[Token(Token = "0x6000B1D")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

}

