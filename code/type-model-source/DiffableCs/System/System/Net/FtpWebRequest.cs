namespace System.Net;

[Token(Token = "0x2000235")]
public sealed class FtpWebRequest : WebRequest
{
	[CompilerGenerated]
	[Token(Token = "0x2000238")]
	private sealed class <>c
	{
		[Token(Token = "0x40008BE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40008BF")]
		public static Func<X509CertificateCollection> <>9__114_0; //Field offset: 0x8

		[Address(RVA = "0x26ADAB0", Offset = "0x26ACEB0", Length = "0x67")]
		[Token(Token = "0x6000F29")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F2A")]
		public <>c() { }

		[Address(RVA = "0x26AD760", Offset = "0x26ACB60", Length = "0x44")]
		[Token(Token = "0x6000F2B")]
		internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000237")]
	private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40008BA")]
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008BB")]
		public FtpWebRequest <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008BC")]
		private TcpClient <client>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008BD")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x26AD4C0", Offset = "0x26AC8C0", Length = "0x299")]
		[Token(Token = "0x6000F27")]
		private override void MoveNext() { }

		[Address(RVA = "0x220A510", Offset = "0x2209910", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000F28")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000236")]
	private enum RequestStage : int
	{
		CheckForError = 0,
		RequestStarted = 1,
		WriteReady = 2,
		ReadReady = 3,
		ReleaseConnection = 4,
	}

	[Token(Token = "0x40008B1")]
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; //Field offset: 0x0
	[Token(Token = "0x40008B2")]
	private static readonly Queue s_DefaultTimerQueue; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000891")]
	private object _syncObject; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000892")]
	private ICredentials _authInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000893")]
	private readonly Uri _uri; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000894")]
	private FtpMethodInfo _methodInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000895")]
	private string _renameTo; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000896")]
	private bool _getRequestStreamStarted; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000897")]
	private bool _getResponseStarted; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000898")]
	private DateTime _startTime; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000899")]
	private int _timeout; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400089A")]
	private int _remainingTimeout; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400089B")]
	private long _contentLength; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400089C")]
	private long _contentOffset; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400089D")]
	private X509CertificateCollection _clientCertificates; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400089E")]
	private bool _passive; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x400089F")]
	private bool _binary; //Field offset: 0x91
	[FieldOffset(Offset = "0x92")]
	[Token(Token = "0x40008A0")]
	private bool _async; //Field offset: 0x92
	[FieldOffset(Offset = "0x93")]
	[Token(Token = "0x40008A1")]
	private bool _aborted; //Field offset: 0x93
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40008A2")]
	private bool _timedOut; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008A3")]
	private Exception _exception; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008A4")]
	private Queue _timerQueue; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008A5")]
	private Callback _timerCallback; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008A6")]
	private bool _enableSsl; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40008A7")]
	private FtpControlStream _connection; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40008A8")]
	private Stream _stream; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40008A9")]
	private RequestStage _requestStage; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40008AA")]
	private bool _onceFailed; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40008AB")]
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40008AC")]
	private FtpWebResponse _ftpWebResponse; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40008AD")]
	private int _readWriteTimeout; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40008AE")]
	private ContextAwareResult _writeAsyncResult; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40008AF")]
	private LazyAsyncResult _readAsyncResult; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40008B0")]
	private LazyAsyncResult _requestCompleteAsyncResult; //Field offset: 0xF8

	[Token(Token = "0x17000308")]
	internal bool Aborted
	{
		[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
		[Token(Token = "0x6000F04")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700030A")]
	public virtual RequestCachePolicy CachePolicy
	{
		[Address(RVA = "0x26A6B20", Offset = "0x26A5F20", Length = "0x67")]
		[Token(Token = "0x6000F1A")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700030D")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x26A6850", Offset = "0x26A5C50", Length = "0x115")]
		[Token(Token = "0x6000F1D")]
		 get { } //Length: 277
	}

	[Token(Token = "0x17000306")]
	public virtual long ContentLength
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000F00")]
		 get { } //Length: 5
		[Address(RVA = "0x26A6B90", Offset = "0x26A5F90", Length = "0x5")]
		[Token(Token = "0x6000F01")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000305")]
	public long ContentOffset
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000EFF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000310")]
	public virtual string ContentType
	{
		[Address(RVA = "0x26A6BA0", Offset = "0x26A5FA0", Length = "0x27")]
		[Token(Token = "0x6000F20")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000300")]
	public virtual ICredentials Credentials
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000EF9")]
		 get { } //Length: 5
		[Address(RVA = "0x26A6BD0", Offset = "0x26A5FD0", Length = "0x172")]
		[Token(Token = "0x6000EFA")]
		 set { } //Length: 370
	}

	[Token(Token = "0x1700030E")]
	public bool EnableSsl
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[Token(Token = "0x6000F1E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700030F")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x26A6970", Offset = "0x26A5D70", Length = "0xBB")]
		[Token(Token = "0x6000F1F")]
		 get { } //Length: 187
	}

	[Token(Token = "0x17000312")]
	private bool InUse
	{
		[Address(RVA = "0x26A6A30", Offset = "0x26A5E30", Length = "0x11")]
		[Token(Token = "0x6000F23")]
		private get { } //Length: 17
	}

	[Token(Token = "0x170002FE")]
	public virtual string Method
	{
		[Address(RVA = "0x26A6A50", Offset = "0x26A5E50", Length = "0x1B")]
		[Token(Token = "0x6000EF6")]
		 get { } //Length: 27
		[Address(RVA = "0x26A6D50", Offset = "0x26A6150", Length = "0x191")]
		[Token(Token = "0x6000EF7")]
		 set { } //Length: 401
	}

	[Token(Token = "0x170002FD")]
	internal FtpMethodInfo MethodInfo
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000EF5")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000307")]
	public virtual IWebProxy Proxy
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F02")]
		 get { } //Length: 3
		[Address(RVA = "0x26A6EF0", Offset = "0x26A62F0", Length = "0x67")]
		[Token(Token = "0x6000F03")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000304")]
	public int ReadWriteTimeout
	{
		[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
		[Token(Token = "0x6000EFE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000303")]
	internal int RemainingTimeout
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x6000EFD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170002FF")]
	public string RenameTo
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000301")]
	public virtual Uri RequestUri
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000EFB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000302")]
	public virtual int Timeout
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x6000EFC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000309")]
	private Queue TimerQueue
	{
		[Address(RVA = "0x26A6A70", Offset = "0x26A5E70", Length = "0x7D")]
		[Token(Token = "0x6000F11")]
		private get { } //Length: 125
	}

	[Token(Token = "0x1700030B")]
	public bool UseBinary
	{
		[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
		[Token(Token = "0x6000F1B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000311")]
	public virtual bool UseDefaultCredentials
	{
		[Address(RVA = "0x26A6AF0", Offset = "0x26A5EF0", Length = "0x27")]
		[Token(Token = "0x6000F21")]
		 get { } //Length: 39
		[Address(RVA = "0x26A6F60", Offset = "0x26A6360", Length = "0x27")]
		[Token(Token = "0x6000F22")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700030C")]
	public bool UsePassive
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x6000F1C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x26A6220", Offset = "0x26A5620", Length = "0x18C")]
	[Token(Token = "0x6000F26")]
	private static FtpWebRequest() { }

	[Address(RVA = "0x26A63B0", Offset = "0x26A57B0", Length = "0x491")]
	[Token(Token = "0x6000F05")]
	internal FtpWebRequest(Uri uri) { }

	[Address(RVA = "0x26A1790", Offset = "0x26A0B90", Length = "0x394")]
	[Token(Token = "0x6000F19")]
	public virtual void Abort() { }

	[Address(RVA = "0x26A1B30", Offset = "0x26A0F30", Length = "0xA31")]
	[Token(Token = "0x6000F17")]
	private void AsyncRequestCallback(object obj) { }

	[Address(RVA = "0x26A2570", Offset = "0x26A1970", Length = "0x2B9")]
	[Token(Token = "0x6000F12")]
	private bool AttemptedRecovery(Exception e) { }

	[Address(RVA = "0x26A2830", Offset = "0x26A1C30", Length = "0x479")]
	[Token(Token = "0x6000F09")]
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26A2CB0", Offset = "0x26A20B0", Length = "0x5E0")]
	[Token(Token = "0x6000F07")]
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26A32A0", Offset = "0x26A26A0", Length = "0x19")]
	[Token(Token = "0x6000F14")]
	private void CheckError() { }

	[Address(RVA = "0x26A3380", Offset = "0x26A2780", Length = "0x10D")]
	[Token(Token = "0x6000F0E")]
	private FtpControlStream CreateConnection() { }

	[Address(RVA = "0x26A32C0", Offset = "0x26A26C0", Length = "0xB5")]
	[AsyncStateMachine(typeof(<CreateConnectionAsync>d__86))]
	[Token(Token = "0x6000F0D")]
	private void CreateConnectionAsync() { }

	[Address(RVA = "0x26A3490", Offset = "0x26A2890", Length = "0xA1")]
	[Token(Token = "0x6000F25")]
	internal void DataStreamClosed(CloseExState closeState) { }

	[Address(RVA = "0x26A3540", Offset = "0x26A2940", Length = "0x357")]
	[Token(Token = "0x6000F0A")]
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26A38A0", Offset = "0x26A2CA0", Length = "0x2CF")]
	[Token(Token = "0x6000F08")]
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26A3B70", Offset = "0x26A2F70", Length = "0x6B2")]
	[Token(Token = "0x6000F24")]
	private void EnsureFtpWebResponse(Exception exception) { }

	[Address(RVA = "0x26A4230", Offset = "0x26A3630", Length = "0x4C5")]
	[Token(Token = "0x6000F18")]
	private RequestStage FinishRequestStage(RequestStage stage) { }

	[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
	[Token(Token = "0x6000F04")]
	internal bool get_Aborted() { }

	[Address(RVA = "0x26A6850", Offset = "0x26A5C50", Length = "0x115")]
	[Token(Token = "0x6000F1D")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000F00")]
	public virtual long get_ContentLength() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000EFF")]
	public long get_ContentOffset() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000EF9")]
	public virtual ICredentials get_Credentials() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[Token(Token = "0x6000F1E")]
	public bool get_EnableSsl() { }

	[Address(RVA = "0x26A6970", Offset = "0x26A5D70", Length = "0xBB")]
	[Token(Token = "0x6000F1F")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x26A6A30", Offset = "0x26A5E30", Length = "0x11")]
	[Token(Token = "0x6000F23")]
	private bool get_InUse() { }

	[Address(RVA = "0x26A6A50", Offset = "0x26A5E50", Length = "0x1B")]
	[Token(Token = "0x6000EF6")]
	public virtual string get_Method() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000EF5")]
	internal FtpMethodInfo get_MethodInfo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F02")]
	public virtual IWebProxy get_Proxy() { }

	[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
	[Token(Token = "0x6000EFE")]
	public int get_ReadWriteTimeout() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x6000EFD")]
	internal int get_RemainingTimeout() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000EF8")]
	public string get_RenameTo() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000EFB")]
	public virtual Uri get_RequestUri() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6000EFC")]
	public virtual int get_Timeout() { }

	[Address(RVA = "0x26A6A70", Offset = "0x26A5E70", Length = "0x7D")]
	[Token(Token = "0x6000F11")]
	private Queue get_TimerQueue() { }

	[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
	[Token(Token = "0x6000F1B")]
	public bool get_UseBinary() { }

	[Address(RVA = "0x26A6AF0", Offset = "0x26A5EF0", Length = "0x27")]
	[Token(Token = "0x6000F21")]
	public virtual bool get_UseDefaultCredentials() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x6000F1C")]
	public bool get_UsePassive() { }

	[Address(RVA = "0x26A4700", Offset = "0x26A3B00", Length = "0x6FB")]
	[Token(Token = "0x6000F06")]
	public virtual WebResponse GetResponse() { }

	[Address(RVA = "0x26A4E00", Offset = "0x26A4200", Length = "0x17")]
	[Token(Token = "0x6000F15")]
	internal void RequestCallback(object obj) { }

	[Address(RVA = "0x26A6B20", Offset = "0x26A5F20", Length = "0x67")]
	[Token(Token = "0x6000F1A")]
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	[Address(RVA = "0x26A6B90", Offset = "0x26A5F90", Length = "0x5")]
	[Token(Token = "0x6000F01")]
	public virtual void set_ContentLength(long value) { }

	[Address(RVA = "0x26A6BA0", Offset = "0x26A5FA0", Length = "0x27")]
	[Token(Token = "0x6000F20")]
	public virtual void set_ContentType(string value) { }

	[Address(RVA = "0x26A6BD0", Offset = "0x26A5FD0", Length = "0x172")]
	[Token(Token = "0x6000EFA")]
	public virtual void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x26A6D50", Offset = "0x26A6150", Length = "0x191")]
	[Token(Token = "0x6000EF7")]
	public virtual void set_Method(string value) { }

	[Address(RVA = "0x26A6EF0", Offset = "0x26A62F0", Length = "0x67")]
	[Token(Token = "0x6000F03")]
	public virtual void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x26A6F60", Offset = "0x26A6360", Length = "0x27")]
	[Token(Token = "0x6000F22")]
	public virtual void set_UseDefaultCredentials(bool value) { }

	[Address(RVA = "0x26A4E20", Offset = "0x26A4220", Length = "0x3FD")]
	[Token(Token = "0x6000F13")]
	private void SetException(Exception exception) { }

	[Address(RVA = "0x26A5220", Offset = "0x26A4620", Length = "0x578")]
	[Token(Token = "0x6000F0B")]
	private void SubmitRequest(bool isAsync) { }

	[Address(RVA = "0x26A57A0", Offset = "0x26A4BA0", Length = "0x3BD")]
	[Token(Token = "0x6000F16")]
	private void SyncRequestCallback(object obj) { }

	[Address(RVA = "0x26A5B60", Offset = "0x26A4F60", Length = "0x4D0")]
	[Token(Token = "0x6000F0F")]
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	[Address(RVA = "0x26A6040", Offset = "0x26A5440", Length = "0xF9")]
	[Token(Token = "0x6000F10")]
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	[Address(RVA = "0x26A6140", Offset = "0x26A5540", Length = "0xDE")]
	[Token(Token = "0x6000F0C")]
	private Exception TranslateConnectException(Exception e) { }

}

