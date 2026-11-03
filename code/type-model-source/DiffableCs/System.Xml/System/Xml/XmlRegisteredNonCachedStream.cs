namespace System.Xml;

[Token(Token = "0x20000CC")]
internal class XmlRegisteredNonCachedStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400056B")]
	protected Stream stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400056C")]
	private XmlDownloadManager downloadManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400056D")]
	private string host; //Field offset: 0x38

	[Token(Token = "0x170002C9")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x255D160", Offset = "0x255C560", Length = "0x2A")]
		[Token(Token = "0x6000B0F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002CA")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x255D190", Offset = "0x255C590", Length = "0x2A")]
		[Token(Token = "0x6000B10")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002CB")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x255D1C0", Offset = "0x255C5C0", Length = "0x2A")]
		[Token(Token = "0x6000B11")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002CC")]
	public virtual long Length
	{
		[Address(RVA = "0x22BEFE0", Offset = "0x22BE3E0", Length = "0x2A")]
		[Token(Token = "0x6000B12")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002CD")]
	public virtual long Position
	{
		[Address(RVA = "0x22BF120", Offset = "0x22BE520", Length = "0x2A")]
		[Token(Token = "0x6000B13")]
		 get { } //Length: 42
		[Address(RVA = "0x255D1F0", Offset = "0x255C5F0", Length = "0x2A")]
		[Token(Token = "0x6000B14")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x255D0C0", Offset = "0x255C4C0", Length = "0x9F")]
	[Token(Token = "0x6000B02")]
	internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host) { }

	[Address(RVA = "0x255CDA0", Offset = "0x255C1A0", Length = "0x32")]
	[Token(Token = "0x6000B05")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x255CDE0", Offset = "0x255C1E0", Length = "0x32")]
	[Token(Token = "0x6000B06")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x255CE20", Offset = "0x255C220", Length = "0x115")]
	[Token(Token = "0x6000B04")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x255CF40", Offset = "0x255C340", Length = "0x2A")]
	[Token(Token = "0x6000B07")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x255CF70", Offset = "0x255C370", Length = "0x2A")]
	[Token(Token = "0x6000B08")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x255CFA0", Offset = "0x255C3A0", Length = "0x84")]
	[Token(Token = "0x6000B03")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x22BD1F0", Offset = "0x22BC5F0", Length = "0x2A")]
	[Token(Token = "0x6000B09")]
	public virtual void Flush() { }

	[Address(RVA = "0x255D160", Offset = "0x255C560", Length = "0x2A")]
	[Token(Token = "0x6000B0F")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x255D190", Offset = "0x255C590", Length = "0x2A")]
	[Token(Token = "0x6000B10")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x255D1C0", Offset = "0x255C5C0", Length = "0x2A")]
	[Token(Token = "0x6000B11")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x22BEFE0", Offset = "0x22BE3E0", Length = "0x2A")]
	[Token(Token = "0x6000B12")]
	public virtual long get_Length() { }

	[Address(RVA = "0x22BF120", Offset = "0x22BE520", Length = "0x2A")]
	[Token(Token = "0x6000B13")]
	public virtual long get_Position() { }

	[Address(RVA = "0x255D060", Offset = "0x255C460", Length = "0x2F")]
	[Token(Token = "0x6000B0A")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x255D030", Offset = "0x255C430", Length = "0x2A")]
	[Token(Token = "0x6000B0B")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x255D090", Offset = "0x255C490", Length = "0x2A")]
	[Token(Token = "0x6000B0C")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x255D1F0", Offset = "0x255C5F0", Length = "0x2A")]
	[Token(Token = "0x6000B14")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1DE6EC0", Offset = "0x1DE62C0", Length = "0x2F")]
	[Token(Token = "0x6000B0D")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x24EC650", Offset = "0x24EBA50", Length = "0x2A")]
	[Token(Token = "0x6000B0E")]
	public virtual void WriteByte(byte value) { }

}

