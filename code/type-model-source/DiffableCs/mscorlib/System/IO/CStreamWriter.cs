namespace System.IO;

[Token(Token = "0x2000684")]
internal class CStreamWriter : StreamWriter
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A57")]
	private TermInfoDriver driver; //Field offset: 0x70

	[Address(RVA = "0x1FF0A80", Offset = "0x1FEFE80", Length = "0x157")]
	[Token(Token = "0x6003109")]
	public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen) { }

	[Address(RVA = "0x1FF0600", Offset = "0x1FEFA00", Length = "0x14")]
	[Token(Token = "0x600310D")]
	public void InternalWriteChar(char val) { }

	[Address(RVA = "0x1FF0620", Offset = "0x1FEFA20", Length = "0x20")]
	[Token(Token = "0x600310E")]
	public void InternalWriteChars(Char[] buffer, int n) { }

	[Address(RVA = "0x1FF0640", Offset = "0x1FEFA40", Length = "0x14")]
	[Token(Token = "0x600310C")]
	public void InternalWriteString(string val) { }

	[Address(RVA = "0x1FF06C0", Offset = "0x1FEFAC0", Length = "0x218")]
	[Token(Token = "0x600310A")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FF08E0", Offset = "0x1FEFCE0", Length = "0xE8")]
	[Token(Token = "0x600310B")]
	public virtual void Write(char val) { }

	[Address(RVA = "0x1FF0A40", Offset = "0x1FEFE40", Length = "0x33")]
	[Token(Token = "0x600310F")]
	public virtual void Write(Char[] val) { }

	[Address(RVA = "0x1FF09D0", Offset = "0x1FEFDD0", Length = "0x61")]
	[Token(Token = "0x6003110")]
	public virtual void Write(string val) { }

	[Address(RVA = "0x1FF0660", Offset = "0x1FEFA60", Length = "0x51")]
	[Token(Token = "0x6003111")]
	public virtual void WriteLine(string val) { }

}

