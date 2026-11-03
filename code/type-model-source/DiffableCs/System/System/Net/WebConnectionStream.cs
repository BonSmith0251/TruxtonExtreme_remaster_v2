namespace System.Net;

[Token(Token = "0x20002C5")]
internal abstract class WebConnectionStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BC4")]
	protected bool closed; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000BC5")]
	private bool disposed; //Field offset: 0x29
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BC6")]
	private object locker; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC7")]
	private int read_timeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000BC8")]
	private int write_timeout; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BC9")]
	internal bool IgnoreIOErrors; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BCA")]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BCB")]
	private readonly WebConnection <Connection>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BCC")]
	private readonly WebOperation <Operation>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000409")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60012B4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000406")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60012A1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000403")]
	internal WebConnection Connection
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600129E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700040A")]
	public virtual long Length
	{
		[Address(RVA = "0x25D7A80", Offset = "0x25D6E80", Length = "0x4E")]
		[Token(Token = "0x60012B5")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000404")]
	internal WebOperation Operation
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600129F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700040B")]
	public virtual long Position
	{
		[Address(RVA = "0x25D7AD0", Offset = "0x25D6ED0", Length = "0x4E")]
		[Token(Token = "0x60012B6")]
		 get { } //Length: 78
		[Address(RVA = "0x25D7B40", Offset = "0x25D6F40", Length = "0x4E")]
		[Token(Token = "0x60012B7")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000407")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60012A2")]
		 get { } //Length: 4
		[Address(RVA = "0x25D7B90", Offset = "0x25D6F90", Length = "0x63")]
		[Token(Token = "0x60012A3")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000402")]
	internal HttpWebRequest Request
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600129D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000405")]
	internal ServicePoint ServicePoint
	{
		[Address(RVA = "0x25D7B20", Offset = "0x25D6F20", Length = "0x1B")]
		[Token(Token = "0x60012A0")]
		internal get { } //Length: 27
	}

	[Token(Token = "0x17000408")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60012A4")]
		 get { } //Length: 4
		[Address(RVA = "0x25D7C00", Offset = "0x25D7000", Length = "0x63")]
		[Token(Token = "0x60012A5")]
		 set { } //Length: 99
	}

	[Address(RVA = "0x25D7980", Offset = "0x25D6D80", Length = "0xF2")]
	[Token(Token = "0x600129C")]
	protected WebConnectionStream(WebConnection cnc, WebOperation operation) { }

	[Address(RVA = "0x25D6B70", Offset = "0x25D5F70", Length = "0x272")]
	[Token(Token = "0x60012A9")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	[Address(RVA = "0x25D6DF0", Offset = "0x25D61F0", Length = "0x226")]
	[Token(Token = "0x60012AB")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	[Address(RVA = "0x25D7020", Offset = "0x25D6420", Length = "0x18")]
	[Token(Token = "0x60012B2")]
	public virtual void Close() { }

	[Token(Token = "0x60012B1")]
	protected abstract void Close_internal(ref bool disposed) { }

	[Address(RVA = "0x25D7040", Offset = "0x25D6440", Length = "0xC9")]
	[Token(Token = "0x60012AA")]
	public virtual int EndRead(IAsyncResult r) { }

	[Address(RVA = "0x25D7110", Offset = "0x25D6510", Length = "0xA8")]
	[Token(Token = "0x60012AC")]
	public virtual void EndWrite(IAsyncResult r) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012AE")]
	public virtual void Flush() { }

	[Address(RVA = "0x25D71C0", Offset = "0x25D65C0", Length = "0xDF")]
	[Token(Token = "0x60012AF")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60012B4")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60012A1")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600129E")]
	internal WebConnection get_Connection() { }

	[Address(RVA = "0x25D7A80", Offset = "0x25D6E80", Length = "0x4E")]
	[Token(Token = "0x60012B5")]
	public virtual long get_Length() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600129F")]
	internal WebOperation get_Operation() { }

	[Address(RVA = "0x25D7AD0", Offset = "0x25D6ED0", Length = "0x4E")]
	[Token(Token = "0x60012B6")]
	public virtual long get_Position() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60012A2")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600129D")]
	internal HttpWebRequest get_Request() { }

	[Address(RVA = "0x25D7B20", Offset = "0x25D6F20", Length = "0x1B")]
	[Token(Token = "0x60012A0")]
	internal ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60012A4")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x25D72A0", Offset = "0x25D66A0", Length = "0x17D")]
	[Token(Token = "0x60012A6")]
	protected Exception GetException(Exception e) { }

	[Address(RVA = "0x25D7420", Offset = "0x25D6820", Length = "0x5")]
	[Token(Token = "0x60012B0")]
	internal void InternalClose() { }

	[Address(RVA = "0x25D7430", Offset = "0x25D6830", Length = "0x2BD")]
	[Token(Token = "0x60012A8")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x25D76F0", Offset = "0x25D6AF0", Length = "0x4E")]
	[Token(Token = "0x60012B3")]
	public virtual long Seek(long a, SeekOrigin b) { }

	[Address(RVA = "0x25D7B40", Offset = "0x25D6F40", Length = "0x4E")]
	[Token(Token = "0x60012B7")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x25D7B90", Offset = "0x25D6F90", Length = "0x63")]
	[Token(Token = "0x60012A3")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x25D7C00", Offset = "0x25D7000", Length = "0x63")]
	[Token(Token = "0x60012A5")]
	public virtual void set_WriteTimeout(int value) { }

	[Token(Token = "0x60012A7")]
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[Address(RVA = "0x25D7740", Offset = "0x25D6B40", Length = "0x232")]
	[Token(Token = "0x60012AD")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

