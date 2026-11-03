namespace System.Net;

[Token(Token = "0x200029D")]
internal class FixedSizeReadStream : WebReadStream
{
	[CompilerGenerated]
	[Token(Token = "0x200029E")]
	private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A90")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A91")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A92")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A93")]
		public FixedSizeReadStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A94")]
		public int size; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A95")]
		public Byte[] buffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A96")]
		public int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A97")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x26CFC70", Offset = "0x26CF070", Length = "0x2B7")]
		[Token(Token = "0x6001178")]
		private override void MoveNext() { }

		[Address(RVA = "0x26CFF30", Offset = "0x26CF330", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001179")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A8E")]
	private readonly long <ContentLength>k__BackingField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A8F")]
	private long position; //Field offset: 0x48

	[Token(Token = "0x170003AD")]
	public long ContentLength
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001175")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x26C41C0", Offset = "0x26C35C0", Length = "0x27")]
	[Token(Token = "0x6001176")]
	public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001175")]
	public long get_ContentLength() { }

	[Address(RVA = "0x26C4070", Offset = "0x26C3470", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ProcessReadAsync>d__5))]
	[Token(Token = "0x6001177")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

