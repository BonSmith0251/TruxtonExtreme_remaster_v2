namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000675")]
public class StringReader : TextReader
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019FE")]
	private string _s; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019FF")]
	private int _pos; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001A00")]
	private int _length; //Field offset: 0x24

	[Address(RVA = "0x20018A0", Offset = "0x2000CA0", Length = "0xB9")]
	[Token(Token = "0x6003061")]
	public StringReader(string s) { }

	[Address(RVA = "0x1EF4750", Offset = "0x1EF3B50", Length = "0x16")]
	[Token(Token = "0x6003062")]
	public virtual void Close() { }

	[Address(RVA = "0x2001260", Offset = "0x2000660", Length = "0x43")]
	[Token(Token = "0x6003063")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x20012B0", Offset = "0x20006B0", Length = "0x3B")]
	[Token(Token = "0x6003064")]
	public virtual int Peek() { }

	[Address(RVA = "0x2001850", Offset = "0x2000C50", Length = "0x41")]
	[Token(Token = "0x6003065")]
	public virtual int Read() { }

	[Address(RVA = "0x2001640", Offset = "0x2000A40", Length = "0x20B")]
	[Token(Token = "0x6003066")]
	public virtual int Read(out Char[] buffer, int index, int count) { }

	[Address(RVA = "0x20012F0", Offset = "0x20006F0", Length = "0x1F9")]
	[ComVisible(False)]
	[Token(Token = "0x6003069")]
	public virtual Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x20014F0", Offset = "0x20008F0", Length = "0xF7")]
	[Token(Token = "0x6003068")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x20015F0", Offset = "0x20009F0", Length = "0x46")]
	[Token(Token = "0x6003067")]
	public virtual string ReadToEnd() { }

}

