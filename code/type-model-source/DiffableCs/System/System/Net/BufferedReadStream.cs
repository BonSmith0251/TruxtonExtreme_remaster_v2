namespace System.Net;

[Token(Token = "0x2000292")]
internal class BufferedReadStream : WebReadStream
{
	[CompilerGenerated]
	[Token(Token = "0x2000293")]
	private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A72")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A73")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A74")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A75")]
		public BufferedReadStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A76")]
		public int size; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A77")]
		public Byte[] buffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A78")]
		public int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A79")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x26CF920", Offset = "0x26CED20", Length = "0x2D5")]
		[Token(Token = "0x600113B")]
		private override void MoveNext() { }

		[Address(RVA = "0x26CFC00", Offset = "0x26CF000", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600113C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A71")]
	private readonly BufferOffsetSize readBuffer; //Field offset: 0x40

	[Address(RVA = "0x26B3CE0", Offset = "0x26B30E0", Length = "0x32")]
	[Token(Token = "0x6001138")]
	public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[Address(RVA = "0x26B3AF0", Offset = "0x26B2EF0", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ProcessReadAsync>d__2))]
	[Token(Token = "0x6001139")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26B3C40", Offset = "0x26B3040", Length = "0x9F")]
	[Token(Token = "0x600113A")]
	internal bool TryReadFromBuffer(Byte[] buffer, int offset, int size, out int result) { }

}

