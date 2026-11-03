namespace System.Net;

[Token(Token = "0x200022E")]
internal class FtpControlStream : CommandStream
{
	[CompilerGenerated]
	[Token(Token = "0x2000230")]
	private sealed class <>c__DisplayClass31_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400086A")]
		public FtpControlStream <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400086B")]
		public TlsStream tlsStream; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000ED2")]
		public <>c__DisplayClass31_0() { }

		[Address(RVA = "0x26AD7B0", Offset = "0x26ACBB0", Length = "0xB8")]
		[Token(Token = "0x6000ED3")]
		internal void <PipelineCallback>b__0(IAsyncResult ar) { }

	}

	[Token(Token = "0x200022F")]
	private enum GetPathOption : int
	{
		Normal = 0,
		AssumeFilename = 1,
		AssumeNoFilename = 2,
	}

	[Token(Token = "0x4000863")]
	private static readonly AsyncCallback s_acceptCallbackDelegate; //Field offset: 0x0
	[Token(Token = "0x4000864")]
	private static readonly AsyncCallback s_connectCallbackDelegate; //Field offset: 0x8
	[Token(Token = "0x4000865")]
	private static readonly AsyncCallback s_SSLHandshakeCallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000851")]
	private Socket _dataSocket; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000852")]
	private IPEndPoint _passiveEndPoint; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000853")]
	private TlsStream _tlsStream; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000854")]
	private StringBuilder _bannerMessage; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000855")]
	private StringBuilder _welcomeMessage; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000856")]
	private StringBuilder _exitMessage; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000857")]
	private WeakReference _credentials; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000858")]
	private string _currentTypeSetting; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000859")]
	private long _contentLength; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400085A")]
	private DateTime _lastModified; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400085B")]
	private bool _dataHandshakeStarted; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400085C")]
	private string _loginDirectory; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400085D")]
	private string _establishedServerDirectory; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400085E")]
	private string _requestedServerDirectory; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400085F")]
	private Uri _responseUri; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000860")]
	private FtpLoginState _loginState; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000861")]
	internal FtpStatusCode StatusCode; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000862")]
	internal string StatusLine; //Field offset: 0x108

	[Token(Token = "0x170002EE")]
	internal string BannerMessage
	{
		[Address(RVA = "0x269FBF0", Offset = "0x269EFF0", Length = "0x28")]
		[Token(Token = "0x6000EC1")]
		internal get { } //Length: 40
	}

	[Token(Token = "0x170002EB")]
	internal long ContentLength
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x6000EBE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002EA")]
	internal NetworkCredential Credentials
	{
		[Address(RVA = "0x269FC20", Offset = "0x269F020", Length = "0xB8")]
		[Token(Token = "0x6000EAF")]
		internal get { } //Length: 184
		[Address(RVA = "0x269FD40", Offset = "0x269F140", Length = "0xA5")]
		[Token(Token = "0x6000EB0")]
		internal set { } //Length: 165
	}

	[Token(Token = "0x170002F0")]
	internal string ExitMessage
	{
		[Address(RVA = "0x269FCE0", Offset = "0x269F0E0", Length = "0x28")]
		[Token(Token = "0x6000EC3")]
		internal get { } //Length: 40
	}

	[Token(Token = "0x170002EC")]
	internal DateTime LastModified
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x6000EBF")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002ED")]
	internal Uri ResponseUri
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x6000EC0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002EF")]
	internal string WelcomeMessage
	{
		[Address(RVA = "0x269FD10", Offset = "0x269F110", Length = "0x28")]
		[Token(Token = "0x6000EC2")]
		internal get { } //Length: 40
	}

	[Address(RVA = "0x269F950", Offset = "0x269ED50", Length = "0x13F")]
	[Token(Token = "0x6000ED1")]
	private static FtpControlStream() { }

	[Address(RVA = "0x269FA90", Offset = "0x269EE90", Length = "0x150")]
	[Token(Token = "0x6000EB1")]
	internal FtpControlStream(TcpClient client) { }

	[Address(RVA = "0x269AC30", Offset = "0x269A030", Length = "0x1F")]
	[Token(Token = "0x6000EB2")]
	internal void AbortConnect() { }

	[Address(RVA = "0x269AC50", Offset = "0x269A050", Length = "0x2B2")]
	[Token(Token = "0x6000EB3")]
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	[Address(RVA = "0x269AF10", Offset = "0x269A310", Length = "0x1230")]
	[Token(Token = "0x6000EB9")]
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest req) { }

	[Address(RVA = "0x269C150", Offset = "0x269B550", Length = "0x3AB")]
	[Token(Token = "0x6000ECF")]
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	[Address(RVA = "0x269C500", Offset = "0x269B900", Length = "0xFD")]
	[Token(Token = "0x6000EB7")]
	protected virtual void ClearState() { }

	[Address(RVA = "0x269C600", Offset = "0x269BA00", Length = "0x100")]
	[Token(Token = "0x6000EB4")]
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	[Address(RVA = "0x269C710", Offset = "0x269BB10", Length = "0x87")]
	[Token(Token = "0x6000ECE")]
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	[Address(RVA = "0x269C7A0", Offset = "0x269BBA0", Length = "0x22E")]
	[Token(Token = "0x6000ECB")]
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	[Address(RVA = "0x269CAF0", Offset = "0x269BEF0", Length = "0x13C")]
	[Token(Token = "0x6000EBC")]
	private string FormatAddress(IPAddress address, int Port) { }

	[Address(RVA = "0x269C9D0", Offset = "0x269BDD0", Length = "0x110")]
	[Token(Token = "0x6000EBD")]
	private string FormatAddressV6(IPAddress address, int port) { }

	[Address(RVA = "0x269CC30", Offset = "0x269C030", Length = "0x106")]
	[Token(Token = "0x6000ECD")]
	private string FormatFtpCommand(string command, string parameter) { }

	[Address(RVA = "0x269FBF0", Offset = "0x269EFF0", Length = "0x28")]
	[Token(Token = "0x6000EC1")]
	internal string get_BannerMessage() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x6000EBE")]
	internal long get_ContentLength() { }

	[Address(RVA = "0x269FC20", Offset = "0x269F020", Length = "0xB8")]
	[Token(Token = "0x6000EAF")]
	internal NetworkCredential get_Credentials() { }

	[Address(RVA = "0x269FCE0", Offset = "0x269F0E0", Length = "0x28")]
	[Token(Token = "0x6000EC3")]
	internal string get_ExitMessage() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x6000EBF")]
	internal DateTime get_LastModified() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x6000EC0")]
	internal Uri get_ResponseUri() { }

	[Address(RVA = "0x269FD10", Offset = "0x269F110", Length = "0x28")]
	[Token(Token = "0x6000EC2")]
	internal string get_WelcomeMessage() { }

	[Address(RVA = "0x269CD40", Offset = "0x269C140", Length = "0x124")]
	[Token(Token = "0x6000EC4")]
	private long GetContentLengthFrom213Response(string responseString) { }

	[Address(RVA = "0x269CE70", Offset = "0x269C270", Length = "0x308")]
	[Token(Token = "0x6000EC5")]
	private DateTime GetLastModifiedFrom213Response(string str) { }

	[Address(RVA = "0x269D180", Offset = "0x269C580", Length = "0x82")]
	[Token(Token = "0x6000EC8")]
	private string GetLoginDirectory(string str) { }

	[Address(RVA = "0x269D210", Offset = "0x269C610", Length = "0x1B8")]
	[Token(Token = "0x6000EBB")]
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	[Address(RVA = "0x269D3D0", Offset = "0x269C7D0", Length = "0x3C7")]
	[Token(Token = "0x6000ECC")]
	private string GetPortCommandLine(FtpWebRequest request) { }

	[Address(RVA = "0x269D7A0", Offset = "0x269CBA0", Length = "0x1C5")]
	[Token(Token = "0x6000EC9")]
	private int GetPortV4(string responseString) { }

	[Address(RVA = "0x269D970", Offset = "0x269CD70", Length = "0x1ED")]
	[Token(Token = "0x6000ECA")]
	private int GetPortV6(string responseString) { }

	[Address(RVA = "0x269DB60", Offset = "0x269CF60", Length = "0x7F")]
	[Token(Token = "0x6000ED0")]
	private TriState IsFtpDataStreamWriteable() { }

	[Address(RVA = "0x269DBE0", Offset = "0x269CFE0", Length = "0xC4D")]
	[Token(Token = "0x6000EB8")]
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	[Address(RVA = "0x269E830", Offset = "0x269DC30", Length = "0x796")]
	[Token(Token = "0x6000EBA")]
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	[Address(RVA = "0x269EFD0", Offset = "0x269E3D0", Length = "0x3B4")]
	[Token(Token = "0x6000EB6")]
	private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	[Address(RVA = "0x269FD40", Offset = "0x269F140", Length = "0xA5")]
	[Token(Token = "0x6000EB0")]
	internal void set_Credentials(NetworkCredential value) { }

	[Address(RVA = "0x269F390", Offset = "0x269E790", Length = "0x11D")]
	[Token(Token = "0x6000EB5")]
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	[Address(RVA = "0x269F4B0", Offset = "0x269E8B0", Length = "0xE3")]
	[Token(Token = "0x6000EC7")]
	private void TryUpdateContentLength(string str) { }

	[Address(RVA = "0x269F5A0", Offset = "0x269E9A0", Length = "0x3AB")]
	[Token(Token = "0x6000EC6")]
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

}

