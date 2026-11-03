namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000676")]
public class StringWriter : TextWriter
{
	[Token(Token = "0x4001A01")]
	private static UnicodeEncoding m_encoding; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A02")]
	private StringBuilder _sb; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A03")]
	private bool _isOpen; //Field offset: 0x38

	[Token(Token = "0x17000792")]
	public virtual Encoding Encoding
	{
		[Address(RVA = "0x2002380", Offset = "0x2001780", Length = "0xB3")]
		[Token(Token = "0x6003070")]
		 get { } //Length: 179
	}

	[Address(RVA = "0x2001F10", Offset = "0x2001310", Length = "0x13E")]
	[Token(Token = "0x600306A")]
	public StringWriter() { }

	[Address(RVA = "0x2002140", Offset = "0x2001540", Length = "0x116")]
	[Token(Token = "0x600306B")]
	public StringWriter(IFormatProvider formatProvider) { }

	[Address(RVA = "0x2002260", Offset = "0x2001660", Length = "0x11C")]
	[Token(Token = "0x600306C")]
	public StringWriter(StringBuilder sb) { }

	[Address(RVA = "0x2002050", Offset = "0x2001450", Length = "0xE4")]
	[Token(Token = "0x600306D")]
	public StringWriter(StringBuilder sb, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2001960", Offset = "0x2000D60", Length = "0x16")]
	[Token(Token = "0x600306E")]
	public virtual void Close() { }

	[Address(RVA = "0x2001980", Offset = "0x2000D80", Length = "0xC")]
	[Token(Token = "0x600306F")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2001990", Offset = "0x2000D90", Length = "0x8A")]
	[ComVisible(False)]
	[Token(Token = "0x6003077")]
	public virtual Task FlushAsync() { }

	[Address(RVA = "0x2002380", Offset = "0x2001780", Length = "0xB3")]
	[Token(Token = "0x6003070")]
	public virtual Encoding get_Encoding() { }

	[Address(RVA = "0x2001A20", Offset = "0x2000E20", Length = "0x2A")]
	[Token(Token = "0x6003078")]
	public virtual string ToString() { }

	[Address(RVA = "0x2001EE0", Offset = "0x20012E0", Length = "0x2C")]
	[Token(Token = "0x6003071")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x2001CB0", Offset = "0x20010B0", Length = "0x1ED")]
	[Token(Token = "0x6003072")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2001EA0", Offset = "0x20012A0", Length = "0x36")]
	[Token(Token = "0x6003073")]
	public virtual void Write(string value) { }

	[Address(RVA = "0x2001B30", Offset = "0x2000F30", Length = "0xB5")]
	[ComVisible(False)]
	[Token(Token = "0x6003074")]
	public virtual Task WriteAsync(char value) { }

	[Address(RVA = "0x2001BF0", Offset = "0x2000FF0", Length = "0xB5")]
	[ComVisible(False)]
	[Token(Token = "0x6003075")]
	public virtual Task WriteAsync(string value) { }

	[Address(RVA = "0x2001A50", Offset = "0x2000E50", Length = "0xDB")]
	[ComVisible(False)]
	[Token(Token = "0x6003076")]
	public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

}

