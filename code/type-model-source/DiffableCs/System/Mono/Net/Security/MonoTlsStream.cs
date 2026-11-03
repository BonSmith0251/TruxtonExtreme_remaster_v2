namespace Mono.Net.Security;

[Token(Token = "0x2000061")]
internal class MonoTlsStream : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000124")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000126")]
		public MonoTlsStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000127")]
		public WebConnectionTunnel tunnel; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000128")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000129")]
		private Socket <socket>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400012A")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40

		[Address(RVA = "0x22CB450", Offset = "0x22CA850", Length = "0x6A6")]
		[Token(Token = "0x600016D")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CBB00", Offset = "0x22CAF00", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600016E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011C")]
	private readonly MobileTlsProvider provider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011D")]
	private readonly NetworkStream networkStream; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011E")]
	private readonly HttpWebRequest request; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011F")]
	private readonly MonoTlsSettings settings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000120")]
	private SslStream sslStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000121")]
	private readonly object sslStreamLock; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000122")]
	private WebExceptionStatus status; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000123")]
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0x44

	[Token(Token = "0x17000055")]
	internal bool CertificateValidationFailed
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000167")]
		internal get { } //Length: 5
		[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000168")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000054")]
	internal WebExceptionStatus ExceptionStatus
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000166")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000053")]
	internal HttpWebRequest Request
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000165")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x22C9A80", Offset = "0x22C8E80", Length = "0x26D")]
	[Token(Token = "0x6000169")]
	public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) { }

	[Address(RVA = "0x22C9870", Offset = "0x22C8C70", Length = "0xA3")]
	[Token(Token = "0x600016C")]
	private void CloseSslStream() { }

	[Address(RVA = "0x22C9920", Offset = "0x22C8D20", Length = "0x149")]
	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	[Token(Token = "0x600016A")]
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22C9A70", Offset = "0x22C8E70", Length = "0x7")]
	[Token(Token = "0x600016B")]
	public override void Dispose() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000167")]
	internal bool get_CertificateValidationFailed() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6000166")]
	internal WebExceptionStatus get_ExceptionStatus() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000165")]
	internal HttpWebRequest get_Request() { }

	[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000168")]
	internal void set_CertificateValidationFailed(bool value) { }

}

