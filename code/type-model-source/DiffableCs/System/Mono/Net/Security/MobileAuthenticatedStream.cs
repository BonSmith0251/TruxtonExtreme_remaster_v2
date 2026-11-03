namespace Mono.Net.Security;

[Token(Token = "0x2000054")]
internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private sealed class <>c__DisplayClass66_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F9")]
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000FA")]
		public int len; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000117")]
		public <>c__DisplayClass66_0() { }

		[Address(RVA = "0x22CE680", Offset = "0x22CDA80", Length = "0x52")]
		[Token(Token = "0x6000118")]
		internal int <InnerRead>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private struct <InnerRead>d__66 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FD")]
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000FF")]
		public int requestedSize; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000100")]
		public bool sync; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000101")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x22CC050", Offset = "0x22CB450", Length = "0x46C")]
		[Token(Token = "0x6000119")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CC4C0", Offset = "0x22CB8C0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x600011A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private struct <InnerWrite>d__67 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000102")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000103")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000104")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000105")]
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000106")]
		public bool sync; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000107")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x22CC530", Offset = "0x22CB930", Length = "0x2B3")]
		[Token(Token = "0x600011B")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CC7F0", Offset = "0x22CBBF0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x600011C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private struct <ProcessAuthentication>d__48 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000ED")]
		public MonoSslAuthenticationOptions options; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000EE")]
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000EF")]
		public bool runSynchronously; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F0")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000F1")]
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x22CC850", Offset = "0x22CBC50", Length = "0x8E1")]
		[Token(Token = "0x6000113")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CD140", Offset = "0x22CC540", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000114")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private struct <StartOperation>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F2")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F4")]
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F5")]
		public OperationType type; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000F6")]
		public AsyncProtocolRequest asyncRequest; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000F7")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000F8")]
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x22CDCD0", Offset = "0x22CD0D0", Length = "0x76C")]
		[Token(Token = "0x6000115")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CE440", Offset = "0x22CD840", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6000116")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000055")]
	private enum Operation : int
	{
		None = 0,
		Handshake = 1,
		Authenticated = 2,
		Renegotiate = 3,
		Read = 4,
		Write = 5,
		Close = 6,
	}

	[Token(Token = "0x2000056")]
	private enum OperationType : int
	{
		Read = 0,
		Write = 1,
		Renegotiate = 2,
		Shutdown = 3,
	}

	[Token(Token = "0x40000D7")]
	private static int uniqueNameInteger; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	private static int nextId; //Field offset: 0x4
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000CC")]
	private MobileTlsContext xobileTlsContext; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000CD")]
	private ExceptionDispatchInfo lastException; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000CE")]
	private AsyncProtocolRequest asyncHandshakeRequest; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000CF")]
	private AsyncProtocolRequest asyncReadRequest; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000D0")]
	private AsyncProtocolRequest asyncWriteRequest; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000D1")]
	private BufferOffsetSize2 readBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000D2")]
	private BufferOffsetSize2 writeBuffer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000D3")]
	private object ioLock; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000D4")]
	private int closeRequested; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000D5")]
	private bool shutdown; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000D6")]
	private Operation operation; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000D8")]
	private readonly SslStream <SslStream>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000D9")]
	private readonly MonoTlsSettings <Settings>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000DA")]
	private readonly MobileTlsProvider <Provider>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000DB")]
	private string <TargetHost>k__BackingField; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000DD")]
	internal readonly int ID; //Field offset: 0xA8

	[Token(Token = "0x1700002A")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x22BED30", Offset = "0x22BE130", Length = "0x4D")]
		[Token(Token = "0x6000106")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700002D")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000109")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700002B")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x22BED80", Offset = "0x22BE180", Length = "0x2A")]
		[Token(Token = "0x6000107")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700002C")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x22BEDB0", Offset = "0x22BE1B0", Length = "0x69")]
		[Token(Token = "0x6000108")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000029")]
	public override X509Certificate InternalLocalCertificate
	{
		[Address(RVA = "0x22BEE20", Offset = "0x22BE220", Length = "0xED")]
		[Token(Token = "0x6000104")]
		 get { } //Length: 237
	}

	[Token(Token = "0x17000027")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x22BEF10", Offset = "0x22BE310", Length = "0xC0")]
		[Token(Token = "0x6000100")]
		 get { } //Length: 192
	}

	[Token(Token = "0x1700002E")]
	public virtual long Length
	{
		[Address(RVA = "0x22BEFE0", Offset = "0x22BE3E0", Length = "0x2A")]
		[Token(Token = "0x600010A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000028")]
	public override X509Certificate LocalCertificate
	{
		[Address(RVA = "0x22BF010", Offset = "0x22BE410", Length = "0x10E")]
		[Token(Token = "0x6000103")]
		 get { } //Length: 270
	}

	[Token(Token = "0x1700002F")]
	public virtual long Position
	{
		[Address(RVA = "0x22BF120", Offset = "0x22BE520", Length = "0x2A")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 42
		[Address(RVA = "0x22BF1B0", Offset = "0x22BE5B0", Length = "0x3E")]
		[Token(Token = "0x600010C")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000025")]
	public MobileTlsProvider Provider
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000030")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x22BF150", Offset = "0x22BE550", Length = "0x2A")]
		[Token(Token = "0x600010D")]
		 get { } //Length: 42
		[Address(RVA = "0x22BF1F0", Offset = "0x22BE5F0", Length = "0x2A")]
		[Token(Token = "0x600010E")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000024")]
	public MonoTlsSettings Settings
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000023")]
	public override SslStream SslStream
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000026")]
	internal string TargetHost
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000E6")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000E7")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000031")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x22BF180", Offset = "0x22BE580", Length = "0x2A")]
		[Token(Token = "0x600010F")]
		 get { } //Length: 42
		[Address(RVA = "0x22BF220", Offset = "0x22BE620", Length = "0x2A")]
		[Token(Token = "0x6000110")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x22BEB50", Offset = "0x22BDF50", Length = "0x39")]
	[Token(Token = "0x6000111")]
	private static MobileAuthenticatedStream() { }

	[Address(RVA = "0x22BEB90", Offset = "0x22BDF90", Length = "0x193")]
	[Token(Token = "0x60000E2")]
	public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[Address(RVA = "0x22BE960", Offset = "0x22BDD60", Length = "0x45")]
	[CompilerGenerated]
	[Token(Token = "0x6000112")]
	private void <InnerWrite>b__67_0() { }

	[Address(RVA = "0x22BCCE0", Offset = "0x22BC0E0", Length = "0x1FC")]
	[Token(Token = "0x60000EE")]
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x22BCB50", Offset = "0x22BBF50", Length = "0x18D")]
	[Token(Token = "0x60000EF")]
	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[Address(RVA = "0x22BCEE0", Offset = "0x22BC2E0", Length = "0xF6")]
	[Token(Token = "0x60000E8")]
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false) { }

	[Token(Token = "0x60000F1")]
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x22BCFE0", Offset = "0x22BC3E0", Length = "0x203")]
	[Token(Token = "0x6000101")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x22BD1F0", Offset = "0x22BC5F0", Length = "0x2A")]
	[Token(Token = "0x6000102")]
	public virtual void Flush() { }

	[Address(RVA = "0x22BED30", Offset = "0x22BE130", Length = "0x4D")]
	[Token(Token = "0x6000106")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000109")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x22BED80", Offset = "0x22BE180", Length = "0x2A")]
	[Token(Token = "0x6000107")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x22BEDB0", Offset = "0x22BE1B0", Length = "0x69")]
	[Token(Token = "0x6000108")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x22BEE20", Offset = "0x22BE220", Length = "0xED")]
	[Token(Token = "0x6000104")]
	public override X509Certificate get_InternalLocalCertificate() { }

	[Address(RVA = "0x22BEF10", Offset = "0x22BE310", Length = "0xC0")]
	[Token(Token = "0x6000100")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x22BEFE0", Offset = "0x22BE3E0", Length = "0x2A")]
	[Token(Token = "0x600010A")]
	public virtual long get_Length() { }

	[Address(RVA = "0x22BF010", Offset = "0x22BE410", Length = "0x10E")]
	[Token(Token = "0x6000103")]
	public override X509Certificate get_LocalCertificate() { }

	[Address(RVA = "0x22BF120", Offset = "0x22BE520", Length = "0x2A")]
	[Token(Token = "0x600010B")]
	public virtual long get_Position() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E5")]
	public MobileTlsProvider get_Provider() { }

	[Address(RVA = "0x22BF150", Offset = "0x22BE550", Length = "0x2A")]
	[Token(Token = "0x600010D")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E4")]
	public MonoTlsSettings get_Settings() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E3")]
	public override SslStream get_SslStream() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E6")]
	internal string get_TargetHost() { }

	[Address(RVA = "0x22BF180", Offset = "0x22BE580", Length = "0x2A")]
	[Token(Token = "0x600010F")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x22BD3A0", Offset = "0x22BC7A0", Length = "0x4E")]
	[Token(Token = "0x60000EB")]
	internal static Exception GetInternalError() { }

	[Address(RVA = "0x22BD3F0", Offset = "0x22BC7F0", Length = "0x4E")]
	[Token(Token = "0x60000EC")]
	internal static Exception GetInvalidNestedCallException() { }

	[Address(RVA = "0x22BD220", Offset = "0x22BC620", Length = "0x17A")]
	[Token(Token = "0x60000EA")]
	internal static Exception GetIOException(Exception e, string message) { }

	[Address(RVA = "0x22BD440", Offset = "0x22BC840", Length = "0x179")]
	[Token(Token = "0x60000E9")]
	internal static Exception GetSSPIException(Exception e) { }

	[Address(RVA = "0x22BD5C0", Offset = "0x22BC9C0", Length = "0x14A")]
	[AsyncStateMachine(typeof(<InnerRead>d__66))]
	[Token(Token = "0x60000FB")]
	internal Task<Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BD710", Offset = "0x22BCB10", Length = "0x115")]
	[AsyncStateMachine(typeof(<InnerWrite>d__67))]
	[Token(Token = "0x60000FC")]
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BD830", Offset = "0x22BCC30", Length = "0x171")]
	[Token(Token = "0x60000F8")]
	private ValueTuple<Int32, Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BD9B0", Offset = "0x22BCDB0", Length = "0x1DF")]
	[Token(Token = "0x60000F7")]
	internal int InternalRead(Byte[] buffer, int offset, int size, out bool outWantMore) { }

	[Address(RVA = "0x22BDBA0", Offset = "0x22BCFA0", Length = "0x1B9")]
	[Token(Token = "0x60000FA")]
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BDD60", Offset = "0x22BD160", Length = "0x15C")]
	[Token(Token = "0x60000F9")]
	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BDEE0", Offset = "0x22BD2E0", Length = "0x135")]
	[AsyncStateMachine(typeof(<ProcessAuthentication>d__48))]
	[Token(Token = "0x60000F0")]
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BE020", Offset = "0x22BD420", Length = "0x329")]
	[Token(Token = "0x60000FD")]
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	[Address(RVA = "0x22BE350", Offset = "0x22BD750", Length = "0x136")]
	[Token(Token = "0x60000FE")]
	internal ValueTuple<Int32, Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	[Address(RVA = "0x22BE490", Offset = "0x22BD890", Length = "0x136")]
	[Token(Token = "0x60000FF")]
	internal ValueTuple<Int32, Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	[Address(RVA = "0x22BE680", Offset = "0x22BDA80", Length = "0xF3")]
	[Token(Token = "0x60000F2")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x22BE5D0", Offset = "0x22BD9D0", Length = "0xA8")]
	[Token(Token = "0x60000F4")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BE780", Offset = "0x22BDB80", Length = "0x3E")]
	[Token(Token = "0x6000105")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x22BF1B0", Offset = "0x22BE5B0", Length = "0x3E")]
	[Token(Token = "0x600010C")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x22BF1F0", Offset = "0x22BE5F0", Length = "0x2A")]
	[Token(Token = "0x600010E")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000E7")]
	private void set_TargetHost(string value) { }

	[Address(RVA = "0x22BF220", Offset = "0x22BE620", Length = "0x2A")]
	[Token(Token = "0x6000110")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x22BE7C0", Offset = "0x22BDBC0", Length = "0x41")]
	[Token(Token = "0x60000ED")]
	internal ExceptionDispatchInfo SetException(Exception e) { }

	[Address(RVA = "0x22BE810", Offset = "0x22BDC10", Length = "0x14D")]
	[AsyncStateMachine(typeof(<StartOperation>d__57))]
	[Token(Token = "0x60000F6")]
	private Task<Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BEA60", Offset = "0x22BDE60", Length = "0xE5")]
	[Token(Token = "0x60000F3")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x22BE9B0", Offset = "0x22BDDB0", Length = "0xAB")]
	[Token(Token = "0x60000F5")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

