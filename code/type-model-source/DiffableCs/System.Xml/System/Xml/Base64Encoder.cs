namespace System.Xml;

[Token(Token = "0x2000008")]
internal abstract class Base64Encoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	private Byte[] leftOverBytes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000008")]
	private int leftOverBytesCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000009")]
	private Char[] charsLine; //Field offset: 0x20

	[Address(RVA = "0x23EE110", Offset = "0x23ED510", Length = "0x55")]
	[Token(Token = "0x6000007")]
	internal Base64Encoder() { }

	[Address(RVA = "0x23EDC80", Offset = "0x23ED080", Length = "0x3B6")]
	[Token(Token = "0x6000009")]
	internal void Encode(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x23EE040", Offset = "0x23ED440", Length = "0xC1")]
	[Token(Token = "0x600000A")]
	internal void Flush() { }

	[Token(Token = "0x6000008")]
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

}

