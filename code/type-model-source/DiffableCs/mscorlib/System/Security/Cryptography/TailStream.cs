namespace System.Security.Cryptography;

[Token(Token = "0x2000307")]
internal sealed class TailStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CEF")]
	private Byte[] _Buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CF0")]
	private int _BufferSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000CF1")]
	private int _BufferIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CF2")]
	private bool _BufferFull; //Field offset: 0x38

	[Token(Token = "0x17000279")]
	public Byte[] Buffer
	{
		[Address(RVA = "0x1EC42E0", Offset = "0x1EC36E0", Length = "0x77")]
		[Token(Token = "0x60018AD")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700027A")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60018AE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700027B")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60018AF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700027C")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1EC4360", Offset = "0x1EC3760", Length = "0x9")]
		[Token(Token = "0x60018B0")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700027D")]
	public virtual long Length
	{
		[Address(RVA = "0x1EC4370", Offset = "0x1EC3770", Length = "0x5F")]
		[Token(Token = "0x60018B1")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700027E")]
	public virtual long Position
	{
		[Address(RVA = "0x1EC43D0", Offset = "0x1EC37D0", Length = "0x5F")]
		[Token(Token = "0x60018B2")]
		 get { } //Length: 95
		[Address(RVA = "0x1EC4430", Offset = "0x1EC3830", Length = "0x5F")]
		[Token(Token = "0x60018B3")]
		 set { } //Length: 95
	}

	[Address(RVA = "0x1EC4250", Offset = "0x1EC3650", Length = "0x82")]
	[Token(Token = "0x60018AA")]
	public TailStream(int bufferSize) { }

	[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
	[Token(Token = "0x60018AB")]
	public void Clear() { }

	[Address(RVA = "0x1EC3F50", Offset = "0x1EC3350", Length = "0xA8")]
	[Token(Token = "0x60018AC")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60018B4")]
	public virtual void Flush() { }

	[Address(RVA = "0x1EC42E0", Offset = "0x1EC36E0", Length = "0x77")]
	[Token(Token = "0x60018AD")]
	public Byte[] get_Buffer() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60018AE")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60018AF")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x1EC4360", Offset = "0x1EC3760", Length = "0x9")]
	[Token(Token = "0x60018B0")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1EC4370", Offset = "0x1EC3770", Length = "0x5F")]
	[Token(Token = "0x60018B1")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1EC43D0", Offset = "0x1EC37D0", Length = "0x5F")]
	[Token(Token = "0x60018B2")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1EC4000", Offset = "0x1EC3400", Length = "0x5F")]
	[Token(Token = "0x60018B6")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1EC4060", Offset = "0x1EC3460", Length = "0x5F")]
	[Token(Token = "0x60018B5")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x1EC4430", Offset = "0x1EC3830", Length = "0x5F")]
	[Token(Token = "0x60018B3")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1EC40C0", Offset = "0x1EC34C0", Length = "0x183")]
	[Token(Token = "0x60018B7")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

