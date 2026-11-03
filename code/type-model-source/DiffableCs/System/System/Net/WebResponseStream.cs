namespace System.Net;

[Token(Token = "0x20002D8")]
internal class WebResponseStream : WebConnectionStream
{
	[CompilerGenerated]
	[Token(Token = "0x20002DA")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C77")]
		public WebResponseStream <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C78")]
		public Byte[] buffer; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C79")]
		public int offset; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C7A")]
		public int size; //Field offset: 0x24

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001350")]
		public <>c__DisplayClass41_0() { }

		[Address(RVA = "0x25F6090", Offset = "0x25F5490", Length = "0x4D")]
		[Token(Token = "0x6001351")]
		internal Task<Int32> <ProcessRead>b__0(CancellationToken ct) { }

		[Address(RVA = "0x25F60E0", Offset = "0x25F54E0", Length = "0x45")]
		[Token(Token = "0x6001352")]
		internal void <ProcessRead>b__1() { }

		[Address(RVA = "0x25F6130", Offset = "0x25F5530", Length = "0x26")]
		[Token(Token = "0x6001353")]
		internal bool <ProcessRead>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002DD")]
	private struct <InitReadAsync>d__52 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C8D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C8E")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C8F")]
		public WebResponseStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C90")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C91")]
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C92")]
		private ReadState <state>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000C93")]
		private int <position>5__4; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C94")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x25F07B0", Offset = "0x25EFBB0", Length = "0x64F")]
		[Token(Token = "0x6001358")]
		private override void MoveNext() { }

		[Address(RVA = "0x25F0E10", Offset = "0x25F0210", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001359")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002DC")]
	private struct <ReadAllAsync>d__48 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C83")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C84")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C85")]
		public WebResponseStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C86")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C87")]
		public bool resending; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C88")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C89")]
		private CancellationTokenSource <timeoutCts>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C8A")]
		private Task <timeoutTask>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C8B")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C8C")]
		private ConfiguredTaskAwaiter<Byte[]> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x25F14B0", Offset = "0x25F08B0", Length = "0xD1B")]
		[Token(Token = "0x6001356")]
		private override void MoveNext() { }

		[Address(RVA = "0x25F21D0", Offset = "0x25F15D0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001357")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002DB")]
	private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C7B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C7C")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C7D")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C7E")]
		public WebResponseStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C7F")]
		private long <maximumSize>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C80")]
		private MemoryStream <ms>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C81")]
		private Byte[] <buffer>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C82")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x25F0E70", Offset = "0x25F0270", Length = "0x5C1")]
		[Token(Token = "0x6001354")]
		private override void MoveNext() { }

		[Address(RVA = "0x25F1440", Offset = "0x25F0840", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001355")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002D9")]
	private struct <ReadAsync>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C6B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C6C")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C6D")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C6E")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C6F")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C70")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C71")]
		public WebResponseStream <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C72")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C73")]
		private int <nbytes>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C74")]
		private Exception <throwMe>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C75")]
		private ConfiguredTaskAwaiter<Object> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C76")]
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x68

		[Address(RVA = "0x25F2230", Offset = "0x25F1630", Length = "0x945")]
		[Token(Token = "0x600134E")]
		private override void MoveNext() { }

		[Address(RVA = "0x25F2B80", Offset = "0x25F1F80", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600134F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C5C")]
	private WebReadStream innerStream; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C5D")]
	private bool nextReadCalled; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000C5E")]
	private bool bufferedEntireContent; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C5F")]
	private WebCompletionSource pendingRead; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C60")]
	private object locker; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C61")]
	private int nestedRead; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000C62")]
	private bool read_eof; //Field offset: 0x84
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C63")]
	private readonly WebRequestStream <RequestStream>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C64")]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C65")]
	private HttpStatusCode <StatusCode>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C66")]
	private string <StatusDescription>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C67")]
	private Version <Version>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C68")]
	private bool <KeepAlive>k__BackingField; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000C69")]
	internal readonly string ME; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C6A")]
	private bool <ChunkedRead>k__BackingField; //Field offset: 0xC0

	[Token(Token = "0x17000432")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600133E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000433")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600133F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000434")]
	private bool ChunkedRead
	{
		[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001340")]
		private get { } //Length: 8
		[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001341")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000435")]
	private bool ExpectContent
	{
		[Address(RVA = "0x25F8590", Offset = "0x25F7990", Length = "0x8F")]
		[Token(Token = "0x6001345")]
		private get { } //Length: 143
	}

	[Token(Token = "0x1700042D")]
	public private WebHeaderCollection Headers
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001333")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001334")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000431")]
	public private bool KeepAlive
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600133B")]
		 get { } //Length: 8
		[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600133C")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700042C")]
	public WebRequestStream RequestStream
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001332")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700042E")]
	public private HttpStatusCode StatusCode
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001335")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001336")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700042F")]
	public private string StatusDescription
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001337")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001338")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000430")]
	public private Version Version
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001339")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600133A")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x25F84F0", Offset = "0x25F78F0", Length = "0x9C")]
	[Token(Token = "0x600133D")]
	public WebResponseStream(WebRequestStream request) { }

	[Address(RVA = "0x25F6BC0", Offset = "0x25F5FC0", Length = "0x96")]
	[Token(Token = "0x600134A")]
	protected virtual void Close_internal(ref bool disposed) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600133E")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600133F")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001340")]
	private bool get_ChunkedRead() { }

	[Address(RVA = "0x25F8590", Offset = "0x25F7990", Length = "0x8F")]
	[Token(Token = "0x6001345")]
	private bool get_ExpectContent() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001333")]
	public WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600133B")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001332")]
	public WebRequestStream get_RequestStream() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001335")]
	public HttpStatusCode get_StatusCode() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001337")]
	public string get_StatusDescription() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001339")]
	public Version get_Version() { }

	[Address(RVA = "0x25F6C60", Offset = "0x25F6060", Length = "0x289")]
	[Token(Token = "0x600134B")]
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[Address(RVA = "0x25F6EF0", Offset = "0x25F62F0", Length = "0x7BC")]
	[Token(Token = "0x600134D")]
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

	[Address(RVA = "0x25F77C0", Offset = "0x25F6BC0", Length = "0x5AE")]
	[Token(Token = "0x6001346")]
	private void Initialize(BufferOffsetSize buffer) { }

	[Address(RVA = "0x25F76B0", Offset = "0x25F6AB0", Length = "0x105")]
	[AsyncStateMachine(typeof(<InitReadAsync>d__52))]
	[Token(Token = "0x600134C")]
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25F7D70", Offset = "0x25F7170", Length = "0x287")]
	[Token(Token = "0x6001343")]
	private Task<Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25F8130", Offset = "0x25F7530", Length = "0x116")]
	[AsyncStateMachine(typeof(<ReadAllAsync>d__48))]
	[Token(Token = "0x6001348")]
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25F8000", Offset = "0x25F7400", Length = "0x127")]
	[AsyncStateMachine(typeof(<ReadAllAsyncInner>d__47))]
	[Token(Token = "0x6001347")]
	private Task<Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[Address(RVA = "0x25F8250", Offset = "0x25F7650", Length = "0x156")]
	[AsyncStateMachine(typeof(<ReadAsync>d__40))]
	[Token(Token = "0x6001342")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25F8620", Offset = "0x25F7A20", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001341")]
	private void set_ChunkedRead(bool value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001334")]
	private void set_Headers(WebHeaderCollection value) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600133C")]
	private void set_KeepAlive(bool value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001336")]
	private void set_StatusCode(HttpStatusCode value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001338")]
	private void set_StatusDescription(string value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600133A")]
	private void set_Version(Version value) { }

	[Address(RVA = "0x25F83B0", Offset = "0x25F77B0", Length = "0xBC")]
	[Token(Token = "0x6001344")]
	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	[Address(RVA = "0x25F8470", Offset = "0x25F7870", Length = "0x7F")]
	[Token(Token = "0x6001349")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

