namespace System.Net;

[Token(Token = "0x20002A0")]
public class HttpWebRequest : WebRequest, ISerializable
{
	[CompilerGenerated]
	[Token(Token = "0x20002A7")]
	private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B03")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B04")]
		public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B05")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B06")]
		private MemoryStream <ms>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B07")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x25D4F00", Offset = "0x25D4300", Length = "0x398")]
		[Token(Token = "0x60011E1")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D52A0", Offset = "0x25D46A0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60011E2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002A3")]
	private sealed class <>c__241
	{
		[Token(Token = "0x4000ADD")]
		public static readonly <>c__241<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000ADE")]
		public static Func<Task`1<T>, Nullable`1<Int32>> <>9__241_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60011D8")]
		private static <>c__241`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60011D9")]
		public <>c__241`1() { }

		[Address(RVA = "0xA51A60", Offset = "0xA50E60", Length = "0x82")]
		[Token(Token = "0x60011DA")]
		internal Nullable<Int32> <RunWithTimeoutWorker>b__241_0(Task<T> t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002A6")]
	private struct <GetResponseFromData>d__244 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AF9")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		public AsyncTaskMethodBuilder<ValueTuple`5<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AFA")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AFB")]
		public WebResponseStream stream; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AFC")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AFD")]
		private HttpWebResponse <response>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AFE")]
		private WebException <throwMe>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AFF")]
		private bool <redirect>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x4000B00")]
		private bool <mustReadAll>5__5; //Field offset: 0x49
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B01")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000B02")]
		private ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x25CE210", Offset = "0x25CD610", Length = "0x8A9")]
		[Token(Token = "0x60011DF")]
		private override void MoveNext() { }

		[Address(RVA = "0x25CEAC0", Offset = "0x25CDEC0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60011E0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002A5")]
	private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AE8")]
		public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AE9")]
		public HttpWebRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AEA")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AEB")]
		private WebCompletionSource <completion>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AEC")]
		private WebOperation <operation>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AED")]
		private WebException <throwMe>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AEE")]
		private HttpWebResponse <response>5__5; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000AEF")]
		private WebResponseStream <stream>5__6; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AF0")]
		private bool <redirect>5__7; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4000AF1")]
		private bool <mustReadAll>5__8; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AF2")]
		private WebOperation <ntlm>5__9; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000AF3")]
		private BufferOffsetSize <writeBuffer>5__10; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000AF4")]
		private ConfiguredTaskAwaiter<WebRequestStream> <>u__1; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000AF5")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000AF6")]
		private TaskAwaiter<WebResponseStream> <>u__3; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000AF7")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		private ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> <>u__4; //Field offset: 0x98

		[Address(RVA = "0x25D04B0", Offset = "0x25CF8B0", Length = "0x10F5")]
		[Token(Token = "0x60011DD")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D15B0", Offset = "0x25D09B0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60011DE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002A4")]
	private struct <RunWithTimeoutWorker>d__241 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ADF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE0")]
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE1")]
		public Task<T> workerTask; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE2")]
		public int timeout; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE3")]
		public CancellationTokenSource cts; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE4")]
		public Action abort; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE5")]
		public Func<Boolean> aborted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE6")]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1981AC0", Offset = "0x1980EC0", Length = "0x6AA")]
		[Token(Token = "0x60011DB")]
		private override void MoveNext() { }

		[Address(RVA = "0x1982170", Offset = "0x1981570", Length = "0x98")]
		[DebuggerHidden]
		[Token(Token = "0x60011DC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20002A2")]
	private struct AuthorizationState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD9")]
		private readonly HttpWebRequest request; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000ADA")]
		private readonly bool isProxy; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000ADB")]
		private bool isCompleted; //Field offset: 0x9
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000ADC")]
		private NtlmAuthState ntlm_auth_state; //Field offset: 0xC

		[Token(Token = "0x170003D4")]
		public bool IsCompleted
		{
			[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
			[Token(Token = "0x60011D1")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170003D6")]
		public bool IsNtlmAuthenticated
		{
			[Address(RVA = "0x25C6600", Offset = "0x25C5A00", Length = "0x11")]
			[Token(Token = "0x60011D3")]
			 get { } //Length: 17
		}

		[Token(Token = "0x170003D5")]
		public NtlmAuthState NtlmAuthState
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x60011D2")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x25C65C0", Offset = "0x25C59C0", Length = "0x32")]
		[Token(Token = "0x60011D4")]
		public AuthorizationState(HttpWebRequest request, bool isProxy) { }

		[Address(RVA = "0x25C61E0", Offset = "0x25C55E0", Length = "0x284")]
		[Token(Token = "0x60011D5")]
		public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

		[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
		[Token(Token = "0x60011D1")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x25C6600", Offset = "0x25C5A00", Length = "0x11")]
		[Token(Token = "0x60011D3")]
		public bool get_IsNtlmAuthenticated() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60011D2")]
		public NtlmAuthState get_NtlmAuthState() { }

		[Address(RVA = "0x25C6470", Offset = "0x25C5870", Length = "0x75")]
		[Token(Token = "0x60011D6")]
		public void Reset() { }

		[Address(RVA = "0x25C64F0", Offset = "0x25C58F0", Length = "0xC7")]
		[Token(Token = "0x60011D7")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x20002A1")]
	private enum NtlmAuthState : int
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	[Token(Token = "0x4000AC5")]
	private static int defaultMaxResponseHeadersLength; //Field offset: 0x0
	[Token(Token = "0x4000AC6")]
	private static int defaultMaximumErrorResponseLength; //Field offset: 0x4
	[Token(Token = "0x4000AC7")]
	private static RequestCachePolicy defaultCachePolicy; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A98")]
	private Uri requestUri; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A99")]
	private Uri actualUri; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A9A")]
	private bool hostChanged; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000A9B")]
	private bool allowAutoRedirect; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x4000A9C")]
	private bool allowBuffering; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4000A9D")]
	private bool allowReadStreamBuffering; //Field offset: 0x4B
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A9E")]
	private X509CertificateCollection certificates; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A9F")]
	private string connectionGroup; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AA0")]
	private bool haveContentLength; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AA1")]
	private long contentLength; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000AA2")]
	private HttpContinueDelegate continueDelegate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AA3")]
	private CookieContainer cookieContainer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AA4")]
	private ICredentials credentials; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AA5")]
	private bool haveResponse; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000AA6")]
	private bool requestSent; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000AA7")]
	private WebHeaderCollection webHeaders; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AA8")]
	private bool keepAlive; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000AA9")]
	private int maxAutoRedirect; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000AAA")]
	private string mediaType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000AAB")]
	private string method; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000AAC")]
	private string initialMethod; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000AAD")]
	private bool pipelined; //Field offset: 0xB8
	[FieldOffset(Offset = "0xB9")]
	[Token(Token = "0x4000AAE")]
	private bool preAuthenticate; //Field offset: 0xB9
	[FieldOffset(Offset = "0xBA")]
	[Token(Token = "0x4000AAF")]
	private bool usedPreAuth; //Field offset: 0xBA
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000AB0")]
	private Version version; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000AB1")]
	private bool force_version; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000AB2")]
	private Version actualVersion; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000AB3")]
	private IWebProxy proxy; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000AB4")]
	private bool sendChunked; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000AB5")]
	private ServicePoint servicePoint; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000AB6")]
	private int timeout; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000AB7")]
	private int continueTimeout; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000AB8")]
	private WebRequestStream writeStream; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000AB9")]
	private HttpWebResponse webResponse; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000ABA")]
	private WebCompletionSource responseTask; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000ABB")]
	private WebOperation currentOperation; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000ABC")]
	private int aborted; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000ABD")]
	private bool gotRequestStream; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000ABE")]
	private int redirects; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000ABF")]
	private bool expectContinue; //Field offset: 0x124
	[FieldOffset(Offset = "0x125")]
	[Token(Token = "0x4000AC0")]
	private bool getResponseCalled; //Field offset: 0x125
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000AC1")]
	private object locker; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000AC2")]
	private bool finished_reading; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000AC3")]
	private DecompressionMethods auto_decomp; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000AC4")]
	private int maxResponseHeadersLength; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000AC8")]
	private int readWriteTimeout; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000AC9")]
	private MobileTlsProvider tlsProvider; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000ACA")]
	private MonoTlsSettings tlsSettings; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000ACB")]
	private ServerCertValidationCallback certValidationCallback; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000ACC")]
	private bool hostHasPort; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000ACD")]
	private Uri hostUri; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000ACE")]
	private AuthorizationState auth_state; //Field offset: 0x168
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000ACF")]
	private AuthorizationState proxy_auth_state; //Field offset: 0x178
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000AD0")]
	internal Func<Stream, Task> ResendContentFactory; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000AD1")]
	internal readonly int ID; //Field offset: 0x190
	[CompilerGenerated]
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000AD2")]
	private bool <ThrowOnError>k__BackingField; //Field offset: 0x194
	[FieldOffset(Offset = "0x195")]
	[Token(Token = "0x4000AD3")]
	private bool unsafe_auth_blah; //Field offset: 0x195
	[CompilerGenerated]
	[FieldOffset(Offset = "0x196")]
	[Token(Token = "0x4000AD4")]
	private bool <ReuseConnection>k__BackingField; //Field offset: 0x196

	[Token(Token = "0x170003D3")]
	internal bool Aborted
	{
		[Address(RVA = "0x26CB2D0", Offset = "0x26CA6D0", Length = "0x23")]
		[Token(Token = "0x60011BF")]
		internal get { } //Length: 35
	}

	[Token(Token = "0x170003AE")]
	public string Accept
	{
		[Address(RVA = "0x26CB770", Offset = "0x26CAB70", Length = "0x9C")]
		[Token(Token = "0x6001181")]
		 set { } //Length: 156
	}

	[Token(Token = "0x170003AF")]
	public Uri Address
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001182")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003B0")]
	public override bool AllowWriteStreamBuffering
	{
		[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
		[Token(Token = "0x6001183")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003CE")]
	internal Uri AuthUri
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60011A9")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B1")]
	public DecompressionMethods AutomaticDecompression
	{
		[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
		[Token(Token = "0x6001184")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003B6")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x26CB300", Offset = "0x26CA700", Length = "0x69")]
		[Token(Token = "0x6001189")]
		 get { } //Length: 105
	}

	[Token(Token = "0x170003B7")]
	public virtual long ContentLength
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600118A")]
		 get { } //Length: 5
		[Address(RVA = "0x26CB810", Offset = "0x26CAC10", Length = "0xCF")]
		[Token(Token = "0x600118B")]
		 set { } //Length: 207
	}

	[Token(Token = "0x170003BA")]
	public virtual string ContentType
	{
		[Address(RVA = "0x26CB8E0", Offset = "0x26CACE0", Length = "0x4B")]
		[Token(Token = "0x600118F")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170003BB")]
	public override CookieContainer CookieContainer
	{
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x6001190")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003BC")]
	public virtual ICredentials Credentials
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001191")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x6001192")]
		 set { } //Length: 16
	}

	[MonoTODO]
	[Token(Token = "0x170003BD")]
	public static int DefaultMaximumErrorResponseLength
	{
		[Address(RVA = "0x26CB370", Offset = "0x26CA770", Length = "0x4E")]
		[Token(Token = "0x6001193")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170003CD")]
	internal bool ExpectContinue
	{
		[Address(RVA = "0x26CB3C0", Offset = "0x26CA7C0", Length = "0x8")]
		[Token(Token = "0x60011A7")]
		internal get { } //Length: 8
		[Address(RVA = "0x26CB930", Offset = "0x26CAD30", Length = "0x7")]
		[Token(Token = "0x60011A8")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170003D2")]
	internal bool FinishedReading
	{
		[Address(RVA = "0x26CB940", Offset = "0x26CAD40", Length = "0x7")]
		[Token(Token = "0x60011BE")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170003BE")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6001194")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003BF")]
	public string Host
	{
		[Address(RVA = "0x26CB3D0", Offset = "0x26CA7D0", Length = "0x110")]
		[Token(Token = "0x6001195")]
		 get { } //Length: 272
	}

	[Token(Token = "0x170003B2")]
	internal bool InternalAllowBuffering
	{
		[Address(RVA = "0x26CB4F0", Offset = "0x26CA8F0", Length = "0x10")]
		[Token(Token = "0x6001185")]
		internal get { } //Length: 16
	}

	[Token(Token = "0x170003B8")]
	internal long InternalContentLength
	{
		[Address(RVA = "0x16D0C90", Offset = "0x16D0090", Length = "0x5")]
		[Token(Token = "0x600118C")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x170003C0")]
	public bool KeepAlive
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[Token(Token = "0x6001196")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[Token(Token = "0x6001197")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170003C2")]
	public virtual string Method
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6001199")]
		 get { } //Length: 8
		[Address(RVA = "0x26CB950", Offset = "0x26CAD50", Length = "0x2A6")]
		[Token(Token = "0x600119A")]
		 set { } //Length: 678
	}

	[Token(Token = "0x170003B3")]
	private bool MethodWithBuffer
	{
		[Address(RVA = "0x26CB500", Offset = "0x26CA900", Length = "0xE0")]
		[Token(Token = "0x6001186")]
		private get { } //Length: 224
	}

	[Token(Token = "0x170003C3")]
	public Version ProtocolVersion
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x600119B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003C4")]
	public virtual IWebProxy Proxy
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[Token(Token = "0x600119C")]
		 get { } //Length: 8
		[Address(RVA = "0x26CBC00", Offset = "0x26CB000", Length = "0x95")]
		[Token(Token = "0x600119D")]
		 set { } //Length: 149
	}

	[Token(Token = "0x170003CF")]
	internal bool ProxyQuery
	{
		[Address(RVA = "0x26CB5E0", Offset = "0x26CA9E0", Length = "0x2E")]
		[Token(Token = "0x60011AA")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x170003C1")]
	public int ReadWriteTimeout
	{
		[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
		[Token(Token = "0x6001198")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003C5")]
	public virtual Uri RequestUri
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600119E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C6")]
	public bool SendChunked
	{
		[Address(RVA = "0x26CB620", Offset = "0x26CAA20", Length = "0x8")]
		[Token(Token = "0x600119F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003D1")]
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[Address(RVA = "0x26CB640", Offset = "0x26CAA40", Length = "0x19")]
		[Token(Token = "0x60011AC")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170003D0")]
	internal ServerCertValidationCallback ServerCertValidationCallback
	{
		[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
		[Token(Token = "0x60011AB")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003C7")]
	public ServicePoint ServicePoint
	{
		[Address(RVA = "0x26CB660", Offset = "0x26CAA60", Length = "0x7")]
		[Token(Token = "0x60011A0")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003C8")]
	internal ServicePoint ServicePointNoLock
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x60011A1")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003B9")]
	internal bool ThrowOnError
	{
		[Address(RVA = "0x26CB670", Offset = "0x26CAA70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600118D")]
		internal get { } //Length: 8
		[Address(RVA = "0x26CBCA0", Offset = "0x26CB0A0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600118E")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170003C9")]
	public virtual int Timeout
	{
		[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
		[Token(Token = "0x60011A2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003B4")]
	internal MobileTlsProvider TlsProvider
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x6001187")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003B5")]
	internal MonoTlsSettings TlsSettings
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[Token(Token = "0x6001188")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003CA")]
	public string TransferEncoding
	{
		[Address(RVA = "0x26CB690", Offset = "0x26CAA90", Length = "0x4A")]
		[Token(Token = "0x60011A3")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170003CC")]
	public bool UnsafeAuthenticatedConnectionSharing
	{
		[Address(RVA = "0x26CB6E0", Offset = "0x26CAAE0", Length = "0x8")]
		[Token(Token = "0x60011A6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003CB")]
	public virtual bool UseDefaultCredentials
	{
		[Address(RVA = "0x26CB6F0", Offset = "0x26CAAF0", Length = "0x79")]
		[Token(Token = "0x60011A4")]
		 get { } //Length: 121
		[Address(RVA = "0x26CBCB0", Offset = "0x26CB0B0", Length = "0x7C")]
		[Token(Token = "0x60011A5")]
		 set { } //Length: 124
	}

	[Address(RVA = "0x26CADC0", Offset = "0x26CA1C0", Length = "0xA7")]
	[Token(Token = "0x600117C")]
	private static HttpWebRequest() { }

	[Address(RVA = "0x26CB130", Offset = "0x26CA530", Length = "0x19B")]
	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x600117E")]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26CAE70", Offset = "0x26CA270", Length = "0x2C")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	[Token(Token = "0x60011D0")]
	public HttpWebRequest() { }

	[Address(RVA = "0x26CAEA0", Offset = "0x26CA2A0", Length = "0x289")]
	[Token(Token = "0x600117D")]
	public HttpWebRequest(Uri uri) { }

	[Address(RVA = "0x26CACB0", Offset = "0x26CA0B0", Length = "0x101")]
	[AsyncStateMachine(typeof(<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	[Token(Token = "0x60011CF")]
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[Address(RVA = "0x820440", Offset = "0x81F840", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011CE")]
	private bool <RunWithTimeout>b__242_0() { }

	[Address(RVA = "0x26C7AD0", Offset = "0x26C6ED0", Length = "0xC4")]
	[Token(Token = "0x60011C0")]
	public virtual void Abort() { }

	[Address(RVA = "0x26C7BA0", Offset = "0x26C6FA0", Length = "0xAC")]
	[Token(Token = "0x60011B0")]
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C7C50", Offset = "0x26C7050", Length = "0x1C6")]
	[Token(Token = "0x60011BB")]
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C7E20", Offset = "0x26C7220", Length = "0x24")]
	[Token(Token = "0x60011CB")]
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	[Address(RVA = "0x26C7E50", Offset = "0x26C7250", Length = "0x509")]
	[Token(Token = "0x60011CD")]
	private ValueTuple<Boolean, Boolean, Task`1<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[Address(RVA = "0x26C8360", Offset = "0x26C7760", Length = "0x64")]
	[Token(Token = "0x60011C3")]
	private void CheckRequestStarted() { }

	[Address(RVA = "0x26C83D0", Offset = "0x26C77D0", Length = "0x9D")]
	[Token(Token = "0x60011BA")]
	internal static WebException CreateRequestAbortedException() { }

	[Address(RVA = "0x26C8470", Offset = "0x26C7870", Length = "0x1B")]
	[Token(Token = "0x60011C4")]
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	[Address(RVA = "0x26C8490", Offset = "0x26C7890", Length = "0x1DC")]
	[Token(Token = "0x60011C8")]
	private void DoPreAuthenticate() { }

	[Address(RVA = "0x26C8670", Offset = "0x26C7A70", Length = "0xC9")]
	[Token(Token = "0x60011B1")]
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26C8740", Offset = "0x26C7B40", Length = "0xC9")]
	[Token(Token = "0x60011BC")]
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26C8810", Offset = "0x26C7C10", Length = "0xB7")]
	[Token(Token = "0x60011B7")]
	internal static Exception FlattenException(Exception e) { }

	[Address(RVA = "0x26CB2D0", Offset = "0x26CA6D0", Length = "0x23")]
	[Token(Token = "0x60011BF")]
	internal bool get_Aborted() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001182")]
	public Uri get_Address() { }

	[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
	[Token(Token = "0x6001183")]
	public override bool get_AllowWriteStreamBuffering() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60011A9")]
	internal Uri get_AuthUri() { }

	[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
	[Token(Token = "0x6001184")]
	public DecompressionMethods get_AutomaticDecompression() { }

	[Address(RVA = "0x26CB300", Offset = "0x26CA700", Length = "0x69")]
	[Token(Token = "0x6001189")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600118A")]
	public virtual long get_ContentLength() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001191")]
	public virtual ICredentials get_Credentials() { }

	[Address(RVA = "0x26CB370", Offset = "0x26CA770", Length = "0x4E")]
	[Token(Token = "0x6001193")]
	public static int get_DefaultMaximumErrorResponseLength() { }

	[Address(RVA = "0x26CB3C0", Offset = "0x26CA7C0", Length = "0x8")]
	[Token(Token = "0x60011A7")]
	internal bool get_ExpectContinue() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6001194")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x26CB3D0", Offset = "0x26CA7D0", Length = "0x110")]
	[Token(Token = "0x6001195")]
	public string get_Host() { }

	[Address(RVA = "0x26CB4F0", Offset = "0x26CA8F0", Length = "0x10")]
	[Token(Token = "0x6001185")]
	internal bool get_InternalAllowBuffering() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[Token(Token = "0x6001196")]
	public bool get_KeepAlive() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6001199")]
	public virtual string get_Method() { }

	[Address(RVA = "0x26CB500", Offset = "0x26CA900", Length = "0xE0")]
	[Token(Token = "0x6001186")]
	private bool get_MethodWithBuffer() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x600119B")]
	public Version get_ProtocolVersion() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[Token(Token = "0x600119C")]
	public virtual IWebProxy get_Proxy() { }

	[Address(RVA = "0x26CB5E0", Offset = "0x26CA9E0", Length = "0x2E")]
	[Token(Token = "0x60011AA")]
	internal bool get_ProxyQuery() { }

	[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
	[Token(Token = "0x6001198")]
	public int get_ReadWriteTimeout() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600119E")]
	public virtual Uri get_RequestUri() { }

	[Address(RVA = "0x26CB620", Offset = "0x26CAA20", Length = "0x8")]
	[Token(Token = "0x600119F")]
	public bool get_SendChunked() { }

	[Address(RVA = "0x26CB640", Offset = "0x26CAA40", Length = "0x19")]
	[Token(Token = "0x60011AC")]
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	[Address(RVA = "0x26CB630", Offset = "0x26CAA30", Length = "0x8")]
	[Token(Token = "0x60011AB")]
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	[Address(RVA = "0x26CB660", Offset = "0x26CAA60", Length = "0x7")]
	[Token(Token = "0x60011A0")]
	public ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x60011A1")]
	internal ServicePoint get_ServicePointNoLock() { }

	[Address(RVA = "0x26CB670", Offset = "0x26CAA70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600118D")]
	internal bool get_ThrowOnError() { }

	[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
	[Token(Token = "0x60011A2")]
	public virtual int get_Timeout() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x6001187")]
	internal MobileTlsProvider get_TlsProvider() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[Token(Token = "0x6001188")]
	internal MonoTlsSettings get_TlsSettings() { }

	[Address(RVA = "0x26CB690", Offset = "0x26CAA90", Length = "0x4A")]
	[Token(Token = "0x60011A3")]
	public string get_TransferEncoding() { }

	[Address(RVA = "0x26CB6E0", Offset = "0x26CAAE0", Length = "0x8")]
	[Token(Token = "0x60011A6")]
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	[Address(RVA = "0x26CB6F0", Offset = "0x26CAAF0", Length = "0x79")]
	[Token(Token = "0x60011A4")]
	public virtual bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x26C88D0", Offset = "0x26C7CD0", Length = "0x741")]
	[Token(Token = "0x60011C7")]
	private string GetHeaders() { }

	[Address(RVA = "0x26C9020", Offset = "0x26C8420", Length = "0x3E")]
	[Token(Token = "0x60011C2")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C9060", Offset = "0x26C8460", Length = "0x3F3")]
	[Token(Token = "0x60011C9")]
	internal Byte[] GetRequestHeaders() { }

	[Address(RVA = "0x26C95B0", Offset = "0x26C89B0", Length = "0x9D")]
	[Token(Token = "0x60011BD")]
	public virtual WebResponse GetResponse() { }

	[Address(RVA = "0x26C9460", Offset = "0x26C8860", Length = "0x14E")]
	[AsyncStateMachine(typeof(<GetResponseFromData>d__244))]
	[Token(Token = "0x60011B6")]
	private Task<ValueTuple`5<HttpWebResponse, Boolean, Boolean, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26C9650", Offset = "0x26C8A50", Length = "0x1F6")]
	[Token(Token = "0x60011CC")]
	private ValueTuple<Task`1<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	[Address(RVA = "0x26C9850", Offset = "0x26C8C50", Length = "0x10E")]
	[Token(Token = "0x60011AD")]
	internal ServicePoint GetServicePoint() { }

	[Address(RVA = "0x26C9BB0", Offset = "0x26C8FB0", Length = "0x75")]
	[Token(Token = "0x60011B8")]
	private WebException GetWebException(Exception e) { }

	[Address(RVA = "0x26C9960", Offset = "0x26C8D60", Length = "0x24C")]
	[Token(Token = "0x60011B9")]
	private static WebException GetWebException(Exception e, bool aborted) { }

	[Address(RVA = "0x26C9C30", Offset = "0x26C9030", Length = "0x204")]
	[Token(Token = "0x60011CA")]
	private ValueTuple<WebOperation, Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26C9E40", Offset = "0x26C9240", Length = "0x3EC")]
	[Token(Token = "0x60011AF")]
	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x26CA230", Offset = "0x26C9630", Length = "0x110")]
	[AsyncStateMachine(typeof(<MyGetResponseAsync>d__243))]
	[Token(Token = "0x60011B5")]
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x26CA340", Offset = "0x26C9740", Length = "0x4F0")]
	[Token(Token = "0x60011C6")]
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	[Address(RVA = "0x26CA850", Offset = "0x26C9C50", Length = "0x79")]
	[Token(Token = "0x600117F")]
	private void ResetAuthorization() { }

	[Address(RVA = "0x26CA8D0", Offset = "0x26C9CD0", Length = "0x7F")]
	[Token(Token = "0x60011C5")]
	private void RewriteRedirectToGet() { }

	[Address(RVA = "0x81FFF0", Offset = "0x81F3F0", Length = "0x1EF")]
	[Token(Token = "0x60011B2")]
	internal static Task<T> RunWithTimeout(Func<CancellationToken, Task`1<T>> func, int timeout, Action abort, Func<Boolean> aborted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8201E0", Offset = "0x81F5E0", Length = "0x254")]
	[Token(Token = "0x60011B4")]
	private Task<T> RunWithTimeout(Func<CancellationToken, Task`1<T>> func) { }

	[Address(RVA = "0x81FAA0", Offset = "0x81EEA0", Length = "0x143")]
	[AsyncStateMachine(typeof(<RunWithTimeoutWorker>d__241`1))]
	[Token(Token = "0x60011B3")]
	private static Task<T> RunWithTimeoutWorker(Task<T> workerTask, int timeout, Action abort, Func<Boolean> aborted, CancellationTokenSource cts) { }

	[Address(RVA = "0x26CA950", Offset = "0x26C9D50", Length = "0x263")]
	[Token(Token = "0x60011AE")]
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26CB770", Offset = "0x26CAB70", Length = "0x9C")]
	[Token(Token = "0x6001181")]
	public void set_Accept(string value) { }

	[Address(RVA = "0x26CB810", Offset = "0x26CAC10", Length = "0xCF")]
	[Token(Token = "0x600118B")]
	public virtual void set_ContentLength(long value) { }

	[Address(RVA = "0x26CB8E0", Offset = "0x26CACE0", Length = "0x4B")]
	[Token(Token = "0x600118F")]
	public virtual void set_ContentType(string value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x6001190")]
	public override void set_CookieContainer(CookieContainer value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x6001192")]
	public virtual void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x26CB930", Offset = "0x26CAD30", Length = "0x7")]
	[Token(Token = "0x60011A8")]
	internal void set_ExpectContinue(bool value) { }

	[Address(RVA = "0x26CB940", Offset = "0x26CAD40", Length = "0x7")]
	[Token(Token = "0x60011BE")]
	internal void set_FinishedReading(bool value) { }

	[Address(RVA = "0x16D0C90", Offset = "0x16D0090", Length = "0x5")]
	[Token(Token = "0x600118C")]
	internal void set_InternalContentLength(long value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[Token(Token = "0x6001197")]
	public void set_KeepAlive(bool value) { }

	[Address(RVA = "0x26CB950", Offset = "0x26CAD50", Length = "0x2A6")]
	[Token(Token = "0x600119A")]
	public virtual void set_Method(string value) { }

	[Address(RVA = "0x26CBC00", Offset = "0x26CB000", Length = "0x95")]
	[Token(Token = "0x600119D")]
	public virtual void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x26CBCA0", Offset = "0x26CB0A0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600118E")]
	internal void set_ThrowOnError(bool value) { }

	[Address(RVA = "0x26CBCB0", Offset = "0x26CB0B0", Length = "0x7C")]
	[Token(Token = "0x60011A5")]
	public virtual void set_UseDefaultCredentials(bool value) { }

	[Address(RVA = "0x26CABC0", Offset = "0x26C9FC0", Length = "0xAA")]
	[Token(Token = "0x6001180")]
	private void SetSpecialHeaders(string HeaderName, string value) { }

	[Address(RVA = "0x26CAC70", Offset = "0x26CA070", Length = "0x3E")]
	[Token(Token = "0x60011C1")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

