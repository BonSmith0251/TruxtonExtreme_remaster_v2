namespace System.IO;

[Token(Token = "0x2000681")]
internal class UnexceptionalStreamReader : StreamReader
{
	[Token(Token = "0x4001A54")]
	private static Boolean[] newline; //Field offset: 0x0
	[Token(Token = "0x4001A55")]
	private static char newlineChar; //Field offset: 0x8

	[Address(RVA = "0x2005010", Offset = "0x2004410", Length = "0xA9")]
	[Token(Token = "0x60030F5")]
	private static UnexceptionalStreamReader() { }

	[Address(RVA = "0x20050C0", Offset = "0x20044C0", Length = "0x69")]
	[Token(Token = "0x60030F6")]
	public UnexceptionalStreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x2004B70", Offset = "0x2003F70", Length = "0x1D1")]
	[Token(Token = "0x60030FA")]
	private bool CheckEOL(char current) { }

	[Address(RVA = "0x1FF0240", Offset = "0x1FEF640", Length = "0x1B")]
	[Token(Token = "0x60030F7")]
	public virtual int Peek() { }

	[Address(RVA = "0x2004FF0", Offset = "0x20043F0", Length = "0x1B")]
	[Token(Token = "0x60030F8")]
	public virtual int Read() { }

	[Address(RVA = "0x2004D90", Offset = "0x2004190", Length = "0x25C")]
	[Token(Token = "0x60030F9")]
	public virtual int Read(out Char[] dest_buffer, int index, int count) { }

	[Address(RVA = "0x2004D50", Offset = "0x2004150", Length = "0x18")]
	[Token(Token = "0x60030FB")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x2004D70", Offset = "0x2004170", Length = "0x18")]
	[Token(Token = "0x60030FC")]
	public virtual string ReadToEnd() { }

}

