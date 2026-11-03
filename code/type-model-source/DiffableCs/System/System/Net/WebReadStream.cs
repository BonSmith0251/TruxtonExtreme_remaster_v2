namespace System.Net;

[Token(Token = "0x20002CD")]
internal abstract class WebReadStream : Stream
{
	[CompilerGenerated]
	[Token(Token = "0x20002CE")]
	private struct <ReadAsync>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C10")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C11")]
		public WebReadStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C12")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C13")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C14")]
		public int offset; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000C15")]
		public int size; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C16")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C17")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x25D20A0", Offset = "0x25D14A0", Length = "0x4F1")]
		[Token(Token = "0x6001309")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D25A0", Offset = "0x25D19A0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600130A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C0C")]
	private readonly WebOperation <Operation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C0D")]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C0E")]
	private bool disposed; //Field offset: 0x38

	[Token(Token = "0x17000424")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60012FC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000423")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60012FB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000425")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60012FD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000420")]
	protected Stream InnerStream
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000421")]
	public virtual long Length
	{
		[Address(RVA = "0x25DB280", Offset = "0x25DA680", Length = "0x3E")]
		[Token(Token = "0x60012F8")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700041F")]
	public WebOperation Operation
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012F5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000422")]
	public virtual long Position
	{
		[Address(RVA = "0x25DB2C0", Offset = "0x25DA6C0", Length = "0x3E")]
		[Token(Token = "0x60012F9")]
		 get { } //Length: 62
		[Address(RVA = "0x25DB300", Offset = "0x25DA700", Length = "0x3E")]
		[Token(Token = "0x60012FA")]
		 set { } //Length: 62
	}

	[Address(RVA = "0x25DB1F0", Offset = "0x25DA5F0", Length = "0x82")]
	[Token(Token = "0x60012F7")]
	public WebReadStream(WebOperation operation, Stream innerStream) { }

	[Address(RVA = "0x25DA6F0", Offset = "0x25D9AF0", Length = "0x272")]
	[Token(Token = "0x6001303")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	[Address(RVA = "0x25DA970", Offset = "0x25D9D70", Length = "0x49")]
	[Token(Token = "0x6001308")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x25DA9C0", Offset = "0x25D9DC0", Length = "0xC9")]
	[Token(Token = "0x6001304")]
	public virtual int EndRead(IAsyncResult r) { }

	[Address(RVA = "0x25DAA90", Offset = "0x25D9E90", Length = "0x10B")]
	[Token(Token = "0x6001307")]
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DABA0", Offset = "0x25D9FA0", Length = "0x3E")]
	[Token(Token = "0x6001300")]
	public virtual void Flush() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60012FC")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60012FB")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60012FD")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012F6")]
	protected Stream get_InnerStream() { }

	[Address(RVA = "0x25DB280", Offset = "0x25DA680", Length = "0x3E")]
	[Token(Token = "0x60012F8")]
	public virtual long get_Length() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012F5")]
	public WebOperation get_Operation() { }

	[Address(RVA = "0x25DB2C0", Offset = "0x25DA6C0", Length = "0x3E")]
	[Token(Token = "0x60012F9")]
	public virtual long get_Position() { }

	[Address(RVA = "0x25DABE0", Offset = "0x25D9FE0", Length = "0x17D")]
	[Token(Token = "0x6001301")]
	protected Exception GetException(Exception e) { }

	[Token(Token = "0x6001306")]
	protected abstract Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DAEB0", Offset = "0x25DA2B0", Length = "0x2BC")]
	[Token(Token = "0x6001302")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x25DAD60", Offset = "0x25DA160", Length = "0x14C")]
	[AsyncStateMachine(typeof(<ReadAsync>d__28))]
	[Token(Token = "0x6001305")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DB170", Offset = "0x25DA570", Length = "0x3E")]
	[Token(Token = "0x60012FE")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x25DB300", Offset = "0x25DA700", Length = "0x3E")]
	[Token(Token = "0x60012FA")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x25DB1B0", Offset = "0x25DA5B0", Length = "0x3E")]
	[Token(Token = "0x60012FF")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

