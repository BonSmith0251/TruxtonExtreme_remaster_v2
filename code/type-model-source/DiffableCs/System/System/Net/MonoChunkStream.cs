namespace System.Net;

[Token(Token = "0x20002AD")]
internal class MonoChunkStream : WebReadStream
{
	[CompilerGenerated]
	[Token(Token = "0x20002AF")]
	private struct <FinishReading>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B31")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B32")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B33")]
		public MonoChunkStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B34")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B35")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B36")]
		private Byte[] <buffer>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B37")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x48

		[Address(RVA = "0x25CD580", Offset = "0x25CC980", Length = "0x53D")]
		[Token(Token = "0x600120C")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CDAC0", Offset = "0x25CCEC0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600120D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002AE")]
	private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B28")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B29")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B2A")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B2B")]
		public MonoChunkStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B2C")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B2D")]
		public int offset; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000B2E")]
		public int size; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B2F")]
		private Byte[] <moreBytes>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B30")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x25D1620", Offset = "0x25D0A20", Length = "0x3EB")]
		[Token(Token = "0x600120A")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D1A10", Offset = "0x25D0E10", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600120B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B26")]
	private readonly WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B27")]
	private readonly MonoChunkParser <Decoder>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170003DF")]
	protected MonoChunkParser Decoder
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001204")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x25C9110", Offset = "0x25C8510", Length = "0x17C")]
	[Token(Token = "0x6001205")]
	public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[Address(RVA = "0x25C9000", Offset = "0x25C8400", Length = "0x10B")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6001209")]
	private Task <>n__0(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25C8D30", Offset = "0x25C8130", Length = "0x102")]
	[AsyncStateMachine(typeof(<FinishReading>d__8))]
	[Token(Token = "0x6001207")]
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001204")]
	protected MonoChunkParser get_Decoder() { }

	[Address(RVA = "0x25C8E40", Offset = "0x25C8240", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ProcessReadAsync>d__7))]
	[Token(Token = "0x6001206")]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25C8F90", Offset = "0x25C8390", Length = "0x60")]
	[Token(Token = "0x6001208")]
	private static void ThrowExpectingChunkTrailer() { }

}

