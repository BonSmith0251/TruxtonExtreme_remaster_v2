namespace System.Data.SqlTypes;

[Token(Token = "0x20000BF")]
internal sealed class SqlXmlStreamWrapper : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041D")]
	private Stream _stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400041E")]
	private long _lPosition; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400041F")]
	private bool _isClosed; //Field offset: 0x38

	[Token(Token = "0x17000181")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x23A6A10", Offset = "0x23A5E10", Length = "0x43")]
		[Token(Token = "0x6000A83")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000182")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x23A6A60", Offset = "0x23A5E60", Length = "0x43")]
		[Token(Token = "0x6000A84")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000183")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x23A6AB0", Offset = "0x23A5EB0", Length = "0x43")]
		[Token(Token = "0x6000A85")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000184")]
	public virtual long Length
	{
		[Address(RVA = "0x23A6B00", Offset = "0x23A5F00", Length = "0xC6")]
		[Token(Token = "0x6000A86")]
		 get { } //Length: 198
	}

	[Token(Token = "0x17000185")]
	public virtual long Position
	{
		[Address(RVA = "0x23A6BD0", Offset = "0x23A5FD0", Length = "0xA8")]
		[Token(Token = "0x6000A87")]
		 get { } //Length: 168
		[Address(RVA = "0x23A6C80", Offset = "0x23A6080", Length = "0x12E")]
		[Token(Token = "0x6000A88")]
		 set { } //Length: 302
	}

	[Address(RVA = "0x23A6990", Offset = "0x23A5D90", Length = "0x72")]
	[Token(Token = "0x6000A82")]
	internal SqlXmlStreamWrapper(Stream stream) { }

	[Address(RVA = "0x23A5B90", Offset = "0x23A4F90", Length = "0x41")]
	[Token(Token = "0x6000A8F")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x23A5BE0", Offset = "0x23A4FE0", Length = "0x20")]
	[Token(Token = "0x6000A8E")]
	public virtual void Flush() { }

	[Address(RVA = "0x23A6A10", Offset = "0x23A5E10", Length = "0x43")]
	[Token(Token = "0x6000A83")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x23A6A60", Offset = "0x23A5E60", Length = "0x43")]
	[Token(Token = "0x6000A84")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x23A6AB0", Offset = "0x23A5EB0", Length = "0x43")]
	[Token(Token = "0x6000A85")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x23A6B00", Offset = "0x23A5F00", Length = "0xC6")]
	[Token(Token = "0x6000A86")]
	public virtual long get_Length() { }

	[Address(RVA = "0x23A6BD0", Offset = "0x23A5FD0", Length = "0xA8")]
	[Token(Token = "0x6000A87")]
	public virtual long get_Position() { }

	[Address(RVA = "0x23A5C00", Offset = "0x23A5000", Length = "0x8D")]
	[Token(Token = "0x6000A94")]
	private bool IsStreamClosed() { }

	[Address(RVA = "0x23A5E30", Offset = "0x23A5230", Length = "0x27A")]
	[Token(Token = "0x6000A8A")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x23A5C90", Offset = "0x23A5090", Length = "0x19C")]
	[Token(Token = "0x6000A8C")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x23A60B0", Offset = "0x23A54B0", Length = "0x2C1")]
	[Token(Token = "0x6000A89")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x23A6C80", Offset = "0x23A6080", Length = "0x12E")]
	[Token(Token = "0x6000A88")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x23A6380", Offset = "0x23A5780", Length = "0x87")]
	[Token(Token = "0x6000A91")]
	private void ThrowIfStreamCannotRead(string method) { }

	[Address(RVA = "0x23A6410", Offset = "0x23A5810", Length = "0x87")]
	[Token(Token = "0x6000A90")]
	private void ThrowIfStreamCannotSeek(string method) { }

	[Address(RVA = "0x23A64A0", Offset = "0x23A58A0", Length = "0x87")]
	[Token(Token = "0x6000A92")]
	private void ThrowIfStreamCannotWrite(string method) { }

	[Address(RVA = "0x23A6530", Offset = "0x23A5930", Length = "0x6D")]
	[Token(Token = "0x6000A93")]
	private void ThrowIfStreamClosed(string method) { }

	[Address(RVA = "0x23A6700", Offset = "0x23A5B00", Length = "0x285")]
	[Token(Token = "0x6000A8B")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x23A65A0", Offset = "0x23A59A0", Length = "0x150")]
	[Token(Token = "0x6000A8D")]
	public virtual void WriteByte(byte value) { }

}

