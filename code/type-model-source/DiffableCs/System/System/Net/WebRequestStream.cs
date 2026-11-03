namespace System.Net;

[Token(Token = "0x20002CF")]
internal class WebRequestStream : WebConnectionStream
{
	[CompilerGenerated]
	[Token(Token = "0x20002D0")]
	private struct <FinishWriting>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C26")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C27")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C28")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C29")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C2A")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x25CDB20", Offset = "0x25CCF20", Length = "0x404")]
		[Token(Token = "0x6001322")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CDF30", Offset = "0x25CD330", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001323")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D3")]
	private struct <Initialize>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C3D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C3E")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C3F")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C40")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C41")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C42")]
		private TaskAwaiter <>u__2; //Field offset: 0x40

		[Address(RVA = "0x25CF290", Offset = "0x25CE690", Length = "0x342")]
		[Token(Token = "0x6001328")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CF5E0", Offset = "0x25CE9E0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001329")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D2")]
	private struct <ProcessWrite>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C35")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C36")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C37")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C38")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C39")]
		public int size; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C3A")]
		public Byte[] buffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C3B")]
		public int offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C3C")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x25D1A80", Offset = "0x25D0E80", Length = "0x5BB")]
		[Token(Token = "0x6001326")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D2040", Offset = "0x25D1440", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001327")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D4")]
	private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C43")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C44")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C45")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C46")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C47")]
		public bool setInternalLength; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C48")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x25D4820", Offset = "0x25D3C20", Length = "0x674")]
		[Token(Token = "0x600132A")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D4EA0", Offset = "0x25D42A0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600132B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D1")]
	private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C2B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C2C")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C2D")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C2E")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C2F")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C30")]
		public int size; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C31")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C32")]
		public WebCompletionSource completion; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C33")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C34")]
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x25D5B70", Offset = "0x25D4F70", Length = "0x5D4")]
		[Token(Token = "0x6001324")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D6150", Offset = "0x25D5550", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001325")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D6")]
	private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C50")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C51")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C52")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C53")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C54")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x25D61B0", Offset = "0x25D55B0", Length = "0x24B")]
		[Token(Token = "0x600132E")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D6400", Offset = "0x25D5800", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600132F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D7")]
	private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C55")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C56")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C57")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C58")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C59")]
		private Task <timeoutTask>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C5A")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C5B")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x25F62B0", Offset = "0x25F56B0", Length = "0x7B2")]
		[Token(Token = "0x6001330")]
		private override void MoveNext() { }

		[Address(RVA = "0x25F6A70", Offset = "0x25F5E70", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001331")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D5")]
	private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C49")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C4A")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C4B")]
		public WebRequestStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C4C")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C4D")]
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C4E")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C4F")]
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x25D6460", Offset = "0x25D5860", Length = "0x66A")]
		[Token(Token = "0x600132C")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D6AD0", Offset = "0x25D5ED0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600132D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000C18")]
	private static Byte[] crlf; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C19")]
	private MemoryStream writeBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C1A")]
	private bool requestWritten; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000C1B")]
	private bool allowBuffering; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x4000C1C")]
	private bool sendChunked; //Field offset: 0x6A
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C1D")]
	private WebCompletionSource pendingWrite; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C1E")]
	private long totalWritten; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C1F")]
	private Byte[] headers; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C20")]
	private bool headersSent; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000C21")]
	private int completeRequestWritten; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C22")]
	private int chunkTrailerWritten; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C23")]
	internal readonly string ME; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C24")]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C25")]
	private readonly bool <KeepAlive>k__BackingField; //Field offset: 0xA8

	[Token(Token = "0x17000428")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600130E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000429")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600130F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700042A")]
	internal bool HasWriteBuffer
	{
		[Address(RVA = "0x25DC810", Offset = "0x25DBC10", Length = "0x2D")]
		[Token(Token = "0x6001310")]
		internal get { } //Length: 45
	}

	[Token(Token = "0x17000426")]
	internal Stream InnerStream
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600130C")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000427")]
	public bool KeepAlive
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600130D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700042B")]
	internal int WriteBufferLength
	{
		[Address(RVA = "0x25DC840", Offset = "0x25DBC40", Length = "0x5C")]
		[Token(Token = "0x6001311")]
		internal get { } //Length: 92
	}

	[Address(RVA = "0x25DC530", Offset = "0x25DB930", Length = "0x8C")]
	[Token(Token = "0x6001321")]
	private static WebRequestStream() { }

	[Address(RVA = "0x25DC5C0", Offset = "0x25DB9C0", Length = "0x241")]
	[Token(Token = "0x600130B")]
	public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[Address(RVA = "0x25DB340", Offset = "0x25DA740", Length = "0xA9")]
	[Token(Token = "0x6001317")]
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[Address(RVA = "0x25DB3F0", Offset = "0x25DA7F0", Length = "0x291")]
	[Token(Token = "0x6001320")]
	protected virtual void Close_internal(ref bool disposed) { }

	[Address(RVA = "0x25DB690", Offset = "0x25DAA90", Length = "0xFC")]
	[AsyncStateMachine(typeof(<FinishWriting>d__31))]
	[Token(Token = "0x6001313")]
	private Task FinishWriting(CancellationToken cancellationToken) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600130E")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600130F")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x25DC810", Offset = "0x25DBC10", Length = "0x2D")]
	[Token(Token = "0x6001310")]
	internal bool get_HasWriteBuffer() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600130C")]
	internal Stream get_InnerStream() { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600130D")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x25DC840", Offset = "0x25DBC40", Length = "0x5C")]
	[Token(Token = "0x6001311")]
	internal int get_WriteBufferLength() { }

	[Address(RVA = "0x25DB790", Offset = "0x25DAB90", Length = "0x11C")]
	[Token(Token = "0x6001312")]
	internal BufferOffsetSize GetWriteBuffer() { }

	[Address(RVA = "0x25DB8B0", Offset = "0x25DACB0", Length = "0x104")]
	[AsyncStateMachine(typeof(<Initialize>d__36))]
	[Token(Token = "0x6001318")]
	internal Task Initialize(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DB9C0", Offset = "0x25DADC0", Length = "0x13")]
	[Token(Token = "0x600131D")]
	internal void KillBuffer() { }

	[Address(RVA = "0x25DB9E0", Offset = "0x25DADE0", Length = "0x13F")]
	[AsyncStateMachine(typeof(<ProcessWrite>d__34))]
	[Token(Token = "0x6001316")]
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DBB20", Offset = "0x25DAF20", Length = "0x90")]
	[Token(Token = "0x600131E")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DBBB0", Offset = "0x25DAFB0", Length = "0x115")]
	[AsyncStateMachine(typeof(<SetHeadersAsync>d__37))]
	[Token(Token = "0x6001319")]
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DBCD0", Offset = "0x25DB0D0", Length = "0x3E")]
	[Token(Token = "0x600131F")]
	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[Address(RVA = "0x25DBE50", Offset = "0x25DB250", Length = "0x3D1")]
	[Token(Token = "0x6001314")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DBD10", Offset = "0x25DB110", Length = "0x13A")]
	[AsyncStateMachine(typeof(<WriteAsyncInner>d__33))]
	[Token(Token = "0x6001315")]
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DC330", Offset = "0x25DB730", Length = "0xE2")]
	[AsyncStateMachine(typeof(<WriteChunkTrailer>d__40))]
	[Token(Token = "0x600131C")]
	private Task WriteChunkTrailer() { }

	[Address(RVA = "0x25DC230", Offset = "0x25DB630", Length = "0xFC")]
	[AsyncStateMachine(typeof(<WriteChunkTrailer_inner>d__39))]
	[Token(Token = "0x600131B")]
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DC420", Offset = "0x25DB820", Length = "0x105")]
	[AsyncStateMachine(typeof(<WriteRequestAsync>d__38))]
	[Token(Token = "0x600131A")]
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

}

