namespace Mono.Net.Security;

[Token(Token = "0x2000046")]
internal class BufferOffsetSize
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000099")]
	public Byte[] Buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009A")]
	public int Offset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400009B")]
	public int Size; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009C")]
	public int TotalBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400009D")]
	public bool Complete; //Field offset: 0x24

	[Token(Token = "0x17000018")]
	public int EndOffset
	{
		[Address(RVA = "0x22BB630", Offset = "0x22BAA30", Length = "0x7")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000019")]
	public int Remaining
	{
		[Address(RVA = "0x22BB640", Offset = "0x22BAA40", Length = "0x20")]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x22BB4D0", Offset = "0x22BA8D0", Length = "0x152")]
	[Token(Token = "0x60000AD")]
	public BufferOffsetSize(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BB630", Offset = "0x22BAA30", Length = "0x7")]
	[Token(Token = "0x60000AB")]
	public int get_EndOffset() { }

	[Address(RVA = "0x22BB640", Offset = "0x22BAA40", Length = "0x20")]
	[Token(Token = "0x60000AC")]
	public int get_Remaining() { }

	[Address(RVA = "0x22BB450", Offset = "0x22BA850", Length = "0x7C")]
	[Token(Token = "0x60000AE")]
	public virtual string ToString() { }

}

