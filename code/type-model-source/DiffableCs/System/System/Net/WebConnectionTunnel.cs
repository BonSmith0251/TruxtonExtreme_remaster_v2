namespace System.Net;

[Token(Token = "0x20002C6")]
internal class WebConnectionTunnel
{
	[CompilerGenerated]
	[Token(Token = "0x20002C8")]
	private struct <Initialize>d__42 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BDE")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BDF")]
		public WebConnectionTunnel <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE0")]
		public Stream stream; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE1")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BE2")]
		private bool <have_auth>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BE3")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BE4")]
		private ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, Byte[], Int32>> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x25CF640", Offset = "0x25CEA40", Length = "0xE01")]
		[Token(Token = "0x60012CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D0450", Offset = "0x25CF850", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60012CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C9")]
	private struct <ReadHeaders>d__43 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BE6")]
		public AsyncTaskMethodBuilder<ValueTuple`3<WebHeaderCollection, Byte[], Int32>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE7")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE8")]
		public Stream stream; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE9")]
		public WebConnectionTunnel <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BEA")]
		private Byte[] <retBuffer>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BEB")]
		private int <status>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BEC")]
		private Byte[] <buffer>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BED")]
		private MemoryStream <ms>5__5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BEE")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x58

		[Address(RVA = "0x25D2610", Offset = "0x25D1A10", Length = "0x8D5")]
		[Token(Token = "0x60012CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D2EF0", Offset = "0x25D22F0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60012D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20002C7")]
	private enum NtlmAuthState : int
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BCD")]
	private readonly HttpWebRequest <Request>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BCE")]
	private readonly Uri <ConnectUri>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BCF")]
	private HttpWebRequest connectRequest; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BD0")]
	private NtlmAuthState ntlmAuthState; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000BD1")]
	private bool <Success>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000BD2")]
	private bool <CloseConnection>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BD3")]
	private int <StatusCode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BD4")]
	private string <StatusDescription>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BD5")]
	private String[] <Challenge>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BD6")]
	private WebHeaderCollection <Headers>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BD7")]
	private Version <ProxyVersion>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BD8")]
	private Byte[] <Data>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000412")]
	public private String[] Challenge
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012C2")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012C3")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700040F")]
	public private bool CloseConnection
	{
		[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012BD")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60012BE")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700040D")]
	public Uri ConnectUri
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012B9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000415")]
	public private Byte[] Data
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012C8")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012C9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000413")]
	public private WebHeaderCollection Headers
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012C4")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012C5")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000414")]
	public private Version ProxyVersion
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012C6")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012C7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700040C")]
	public HttpWebRequest Request
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012B8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000410")]
	public private int StatusCode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60012BF")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60012C0")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000411")]
	private string StatusDescription
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012C1")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700040E")]
	public private bool Success
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60012BB")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60012BC")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60012BA")]
	public WebConnectionTunnel(HttpWebRequest request, Uri connectUri) { }

	[Address(RVA = "0x25D7C70", Offset = "0x25D7070", Length = "0x82")]
	[Token(Token = "0x60012CC")]
	private void FlushContents(Stream stream, int contentLength) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012C2")]
	public String[] get_Challenge() { }

	[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012BD")]
	public bool get_CloseConnection() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012B9")]
	public Uri get_ConnectUri() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012C8")]
	public Byte[] get_Data() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012C4")]
	public WebHeaderCollection get_Headers() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012C6")]
	public Version get_ProxyVersion() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012B8")]
	public HttpWebRequest get_Request() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60012BF")]
	public int get_StatusCode() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60012BB")]
	public bool get_Success() { }

	[Address(RVA = "0x25D7D00", Offset = "0x25D7100", Length = "0x11E")]
	[AsyncStateMachine(typeof(<Initialize>d__42))]
	[Token(Token = "0x60012CA")]
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25D7E20", Offset = "0x25D7220", Length = "0x150")]
	[AsyncStateMachine(typeof(<ReadHeaders>d__43))]
	[Token(Token = "0x60012CB")]
	private Task<ValueTuple`3<WebHeaderCollection, Byte[], Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012C3")]
	private void set_Challenge(String[] value) { }

	[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60012BE")]
	private void set_CloseConnection(bool value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012C9")]
	private void set_Data(Byte[] value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012C5")]
	private void set_Headers(WebHeaderCollection value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012C7")]
	private void set_ProxyVersion(Version value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60012C0")]
	private void set_StatusCode(int value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60012C1")]
	private void set_StatusDescription(string value) { }

	[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60012BC")]
	private void set_Success(bool value) { }

}

