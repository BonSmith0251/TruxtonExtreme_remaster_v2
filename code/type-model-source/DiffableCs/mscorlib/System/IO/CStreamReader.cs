namespace System.IO;

[Token(Token = "0x2000683")]
internal class CStreamReader : StreamReader
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A56")]
	private TermInfoDriver driver; //Field offset: 0x60

	[Address(RVA = "0x1FF04D0", Offset = "0x1FEF8D0", Length = "0x12C")]
	[Token(Token = "0x6003103")]
	public CStreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x1FF0240", Offset = "0x1FEF640", Length = "0x1B")]
	[Token(Token = "0x6003104")]
	public virtual int Peek() { }

	[Address(RVA = "0x1FF02C0", Offset = "0x1FEF6C0", Length = "0x5F")]
	[Token(Token = "0x6003105")]
	public virtual int Read() { }

	[Address(RVA = "0x1FF0320", Offset = "0x1FEF720", Length = "0x1A9")]
	[Token(Token = "0x6003106")]
	public virtual int Read(out Char[] dest, int index, int count) { }

	[Address(RVA = "0x1FF0260", Offset = "0x1FEF660", Length = "0x27")]
	[Token(Token = "0x6003107")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x1FF0290", Offset = "0x1FEF690", Length = "0x27")]
	[Token(Token = "0x6003108")]
	public virtual string ReadToEnd() { }

}

