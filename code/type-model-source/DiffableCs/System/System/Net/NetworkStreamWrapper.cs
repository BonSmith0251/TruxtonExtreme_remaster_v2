namespace System.Net;

[Token(Token = "0x200023C")]
internal class NetworkStreamWrapper : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008CA")]
	private TcpClient _client; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008CB")]
	private NetworkStream _networkStream; //Field offset: 0x30

	[Token(Token = "0x1700031A")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1F2EC70", Offset = "0x1F2E070", Length = "0x2A")]
		[Token(Token = "0x6000F3D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031B")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x1FE3DD0", Offset = "0x1FE31D0", Length = "0x2A")]
		[Token(Token = "0x6000F3E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031D")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x26A0C30", Offset = "0x26A0030", Length = "0x2A")]
		[Token(Token = "0x6000F40")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031C")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1FE3F10", Offset = "0x1FE3310", Length = "0x2A")]
		[Token(Token = "0x6000F3F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000320")]
	public virtual long Length
	{
		[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
		[Token(Token = "0x6000F45")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000319")]
	internal NetworkStream NetworkStream
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000F3B")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000F3C")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000321")]
	public virtual long Position
	{
		[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
		[Token(Token = "0x6000F46")]
		 get { } //Length: 42
		[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
		[Token(Token = "0x6000F47")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700031E")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x26A0C60", Offset = "0x26A0060", Length = "0x2A")]
		[Token(Token = "0x6000F41")]
		 get { } //Length: 42
		[Address(RVA = "0x1F2EC40", Offset = "0x1F2E040", Length = "0x2A")]
		[Token(Token = "0x6000F42")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000317")]
	internal IPAddress ServerAddress
	{
		[Address(RVA = "0x26ABBE0", Offset = "0x26AAFE0", Length = "0x8A")]
		[Token(Token = "0x6000F39")]
		internal get { } //Length: 138
	}

	[Token(Token = "0x17000318")]
	internal Socket Socket
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000F3A")]
		internal get { } //Length: 27
	}

	[Token(Token = "0x17000316")]
	protected bool UsingSecureStream
	{
		[Address(RVA = "0x26ABC70", Offset = "0x26AB070", Length = "0x75")]
		[Token(Token = "0x6000F38")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700031F")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x26A0C90", Offset = "0x26A0090", Length = "0x2A")]
		[Token(Token = "0x6000F43")]
		 get { } //Length: 42
		[Address(RVA = "0x1F30950", Offset = "0x1F2FD50", Length = "0x2A")]
		[Token(Token = "0x6000F44")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x26ABB50", Offset = "0x26AAF50", Length = "0x89")]
	[Token(Token = "0x6000F37")]
	internal NetworkStreamWrapper(TcpClient client) { }

	[Address(RVA = "0x26AB850", Offset = "0x26AAC50", Length = "0x32")]
	[Token(Token = "0x6000F4E")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26AB890", Offset = "0x26AAC90", Length = "0x32")]
	[Token(Token = "0x6000F51")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26AB910", Offset = "0x26AAD10", Length = "0x34")]
	[Token(Token = "0x6000F4D")]
	public void Close(int timeout) { }

	[Address(RVA = "0x26AB8D0", Offset = "0x26AACD0", Length = "0x3F")]
	[Token(Token = "0x6000F4C")]
	internal void CloseSocket() { }

	[Address(RVA = "0x26AB950", Offset = "0x26AAD50", Length = "0xA8")]
	[Token(Token = "0x6000F4B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26ABA00", Offset = "0x26AAE00", Length = "0x2A")]
	[Token(Token = "0x6000F4F")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26ABA30", Offset = "0x26AAE30", Length = "0x2A")]
	[Token(Token = "0x6000F52")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26A04F0", Offset = "0x269F8F0", Length = "0x2A")]
	[Token(Token = "0x6000F54")]
	public virtual void Flush() { }

	[Address(RVA = "0x1F30870", Offset = "0x1F2FC70", Length = "0x2A")]
	[Token(Token = "0x6000F55")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1F2EC70", Offset = "0x1F2E070", Length = "0x2A")]
	[Token(Token = "0x6000F3D")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1FE3DD0", Offset = "0x1FE31D0", Length = "0x2A")]
	[Token(Token = "0x6000F3E")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x26A0C30", Offset = "0x26A0030", Length = "0x2A")]
	[Token(Token = "0x6000F40")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x1FE3F10", Offset = "0x1FE3310", Length = "0x2A")]
	[Token(Token = "0x6000F3F")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
	[Token(Token = "0x6000F45")]
	public virtual long get_Length() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000F3B")]
	internal NetworkStream get_NetworkStream() { }

	[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
	[Token(Token = "0x6000F46")]
	public virtual long get_Position() { }

	[Address(RVA = "0x26A0C60", Offset = "0x26A0060", Length = "0x2A")]
	[Token(Token = "0x6000F41")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x26ABBE0", Offset = "0x26AAFE0", Length = "0x8A")]
	[Token(Token = "0x6000F39")]
	internal IPAddress get_ServerAddress() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000F3A")]
	internal Socket get_Socket() { }

	[Address(RVA = "0x26ABC70", Offset = "0x26AB070", Length = "0x75")]
	[Token(Token = "0x6000F38")]
	protected bool get_UsingSecureStream() { }

	[Address(RVA = "0x26A0C90", Offset = "0x26A0090", Length = "0x2A")]
	[Token(Token = "0x6000F43")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x26ABA90", Offset = "0x26AAE90", Length = "0x2F")]
	[Token(Token = "0x6000F49")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x26ABA60", Offset = "0x26AAE60", Length = "0x2F")]
	[Token(Token = "0x6000F50")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26ABAC0", Offset = "0x26AAEC0", Length = "0x2A")]
	[Token(Token = "0x6000F48")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000F3C")]
	internal void set_NetworkStream(NetworkStream value) { }

	[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
	[Token(Token = "0x6000F47")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1F2EC40", Offset = "0x1F2E040", Length = "0x2A")]
	[Token(Token = "0x6000F42")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x1F30950", Offset = "0x1F2FD50", Length = "0x2A")]
	[Token(Token = "0x6000F44")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x26A0690", Offset = "0x269FA90", Length = "0x59")]
	[Token(Token = "0x6000F56")]
	internal void SetSocketTimeoutOption(int timeout) { }

	[Address(RVA = "0x26ABB20", Offset = "0x26AAF20", Length = "0x2F")]
	[Token(Token = "0x6000F4A")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x26ABAF0", Offset = "0x26AAEF0", Length = "0x2F")]
	[Token(Token = "0x6000F53")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

