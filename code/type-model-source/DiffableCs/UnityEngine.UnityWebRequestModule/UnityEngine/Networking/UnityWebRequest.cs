namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
[Token(Token = "0x200000C")]
public class UnityWebRequest : IDisposable
{
	[Token(Token = "0x2000010")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000089")]
		public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }

	}

	[Token(Token = "0x200000F")]
	internal enum Result : int
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4,
	}

	[Token(Token = "0x200000E")]
	public enum UnityWebRequestError : int
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40,
	}

	[Token(Token = "0x200000D")]
	public enum UnityWebRequestMethod : int
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000017")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000018")]
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000019")]
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001A")]
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001B")]
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001C")]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400001D")]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x400001E")]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	[Token(Token = "0x17000015")]
	public CertificateHandler certificateHandler
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 7
		[Address(RVA = "0x347DE80", Offset = "0x347D280", Length = "0x168")]
		[Token(Token = "0x600006F")]
		 set { } //Length: 360
	}

	[Token(Token = "0x17000006")]
	public bool disposeCertificateHandlerOnDispose
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003A")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public bool disposeDownloadHandlerOnDispose
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public bool disposeUploadHandlerOnDispose
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003E")]
		 get { } //Length: 5
		[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000011")]
	public ulong downloadedBytes
	{
		[Address(RVA = "0x347D940", Offset = "0x347CD40", Length = "0x51")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000014")]
	public DownloadHandler downloadHandler
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 7
		[Address(RVA = "0x347DFF0", Offset = "0x347D3F0", Length = "0x168")]
		[Token(Token = "0x600006C")]
		 set { } //Length: 360
	}

	[Token(Token = "0x1700000A")]
	public string error
	{
		[Address(RVA = "0x347D9A0", Offset = "0x347CDA0", Length = "0x197")]
		[Token(Token = "0x6000056")]
		 get { } //Length: 407
	}

	[Token(Token = "0x1700000F")]
	public bool isDone
	{
		[Address(RVA = "0x347DB40", Offset = "0x347CF40", Length = "0x56")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 86
	}

	[Token(Token = "0x1700000E")]
	public bool isModifiable
	{
		[Address(RVA = "0x347DBE0", Offset = "0x347CFE0", Length = "0x51")]
		[NativeMethod("IsModifiable")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000009")]
	public string method
	{
		[Address(RVA = "0x347DC40", Offset = "0x347D040", Length = "0xEE")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 238
		[Address(RVA = "0x347E160", Offset = "0x347D560", Length = "0x253")]
		[Token(Token = "0x6000054")]
		 set { } //Length: 595
	}

	[Token(Token = "0x17000012")]
	public int redirectLimit
	{
		[Address(RVA = "0x347D260", Offset = "0x347C660", Length = "0x58")]
		[Token(Token = "0x6000063")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700000D")]
	public long responseCode
	{
		[Address(RVA = "0x347DD70", Offset = "0x347D170", Length = "0x51")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000010")]
	public Result result
	{
		[Address(RVA = "0x347DE10", Offset = "0x347D210", Length = "0x51")]
		[NativeMethod("GetResult")]
		[Token(Token = "0x6000060")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000016")]
	public int timeout
	{
		[Address(RVA = "0x347E3C0", Offset = "0x347D7C0", Length = "0x183")]
		[Token(Token = "0x6000071")]
		 set { } //Length: 387
	}

	[Token(Token = "0x17000013")]
	public UploadHandler uploadHandler
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 7
		[Address(RVA = "0x347E550", Offset = "0x347D950", Length = "0x168")]
		[Token(Token = "0x6000069")]
		 set { } //Length: 360
	}

	[Token(Token = "0x1700000C")]
	public Uri uri
	{
		[Address(RVA = "0x347E6C0", Offset = "0x347DAC0", Length = "0xF2")]
		[Token(Token = "0x6000059")]
		 set { } //Length: 242
	}

	[Token(Token = "0x1700000B")]
	public string url
	{
		[Address(RVA = "0x347DE70", Offset = "0x347D270", Length = "0x9")]
		[Token(Token = "0x6000057")]
		 get { } //Length: 9
		[Address(RVA = "0x347E7C0", Offset = "0x347DBC0", Length = "0x84")]
		[Token(Token = "0x6000058")]
		 set { } //Length: 132
	}

	[Address(RVA = "0x347D880", Offset = "0x347CC80", Length = "0x79")]
	[Token(Token = "0x6000044")]
	public UnityWebRequest(string url, string method) { }

	[Address(RVA = "0x347D700", Offset = "0x347CB00", Length = "0x178")]
	[Token(Token = "0x6000046")]
	public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[Address(RVA = "0x347D650", Offset = "0x347CA50", Length = "0xA4")]
	[Token(Token = "0x6000045")]
	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	[Address(RVA = "0x347BB20", Offset = "0x347AF20", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600004C")]
	public void Abort() { }

	[Address(RVA = "0x347BAE0", Offset = "0x347AEE0", Length = "0x33")]
	[Token(Token = "0x6000076")]
	private static void Abort_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347BBC0", Offset = "0x347AFC0", Length = "0xA6")]
	[NativeThrows]
	[Token(Token = "0x600004A")]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[Address(RVA = "0x347BB80", Offset = "0x347AF80", Length = "0x33")]
	[Token(Token = "0x6000075")]
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347BC70", Offset = "0x347B070", Length = "0x2A")]
	[NativeThrows]
	[Token(Token = "0x6000040")]
	internal static IntPtr Create() { }

	[Address(RVA = "0x347BD50", Offset = "0x347B150", Length = "0x5D")]
	[Token(Token = "0x6000048")]
	public override void Dispose() { }

	[Address(RVA = "0x347BCA0", Offset = "0x347B0A0", Length = "0xA3")]
	[Token(Token = "0x6000049")]
	private void DisposeHandlers() { }

	[Address(RVA = "0x347BDB0", Offset = "0x347B1B0", Length = "0x63")]
	[Token(Token = "0x6000047")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x600006E")]
	public CertificateHandler get_certificateHandler() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003A")]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003E")]
	public bool get_disposeUploadHandlerOnDispose() { }

	[Address(RVA = "0x347D940", Offset = "0x347CD40", Length = "0x51")]
	[Token(Token = "0x6000061")]
	public ulong get_downloadedBytes() { }

	[Address(RVA = "0x347D900", Offset = "0x347CD00", Length = "0x33")]
	[Token(Token = "0x6000081")]
	private static ulong get_downloadedBytes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x600006B")]
	public DownloadHandler get_downloadHandler() { }

	[Address(RVA = "0x347D9A0", Offset = "0x347CDA0", Length = "0x197")]
	[Token(Token = "0x6000056")]
	public string get_error() { }

	[Address(RVA = "0x347DB40", Offset = "0x347CF40", Length = "0x56")]
	[Token(Token = "0x600005F")]
	public bool get_isDone() { }

	[Address(RVA = "0x347DBE0", Offset = "0x347CFE0", Length = "0x51")]
	[NativeMethod("IsModifiable")]
	[Token(Token = "0x600005E")]
	public bool get_isModifiable() { }

	[Address(RVA = "0x347DBA0", Offset = "0x347CFA0", Length = "0x33")]
	[Token(Token = "0x600007F")]
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347DC40", Offset = "0x347D040", Length = "0xEE")]
	[Token(Token = "0x6000053")]
	public string get_method() { }

	[Address(RVA = "0x347DD70", Offset = "0x347D170", Length = "0x51")]
	[Token(Token = "0x600005D")]
	public long get_responseCode() { }

	[Address(RVA = "0x347DD30", Offset = "0x347D130", Length = "0x33")]
	[Token(Token = "0x600007E")]
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347DE10", Offset = "0x347D210", Length = "0x51")]
	[NativeMethod("GetResult")]
	[Token(Token = "0x6000060")]
	public Result get_result() { }

	[Address(RVA = "0x347DDD0", Offset = "0x347D1D0", Length = "0x33")]
	[Token(Token = "0x6000080")]
	private static Result get_result_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x6000068")]
	public UploadHandler get_uploadHandler() { }

	[Address(RVA = "0x347DE70", Offset = "0x347D270", Length = "0x9")]
	[Token(Token = "0x6000057")]
	public string get_url() { }

	[Address(RVA = "0x347BE70", Offset = "0x347B270", Length = "0xCE")]
	[Token(Token = "0x6000052")]
	internal string GetCustomMethod() { }

	[Address(RVA = "0x347BE20", Offset = "0x347B220", Length = "0x42")]
	[Token(Token = "0x600007A")]
	private static void GetCustomMethod_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347BF80", Offset = "0x347B380", Length = "0x51")]
	[Token(Token = "0x6000055")]
	private UnityWebRequestError GetError() { }

	[Address(RVA = "0x347BF40", Offset = "0x347B340", Length = "0x33")]
	[Token(Token = "0x600007B")]
	private static UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347C030", Offset = "0x347B430", Length = "0xAC")]
	[Token(Token = "0x6000039")]
	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	[Address(RVA = "0x347BFE0", Offset = "0x347B3E0", Length = "0x42")]
	[Token(Token = "0x6000073")]
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347C120", Offset = "0x347B520", Length = "0x51")]
	[Token(Token = "0x6000051")]
	internal UnityWebRequestMethod GetMethod() { }

	[Address(RVA = "0x347C0E0", Offset = "0x347B4E0", Length = "0x33")]
	[Token(Token = "0x6000079")]
	private static UnityWebRequestMethod GetMethod_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347C280", Offset = "0x347B680", Length = "0x20E")]
	[Token(Token = "0x6000064")]
	public string GetResponseHeader(string name) { }

	[Address(RVA = "0x347C220", Offset = "0x347B620", Length = "0x52")]
	[Token(Token = "0x6000083")]
	private static void GetResponseHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347C1C0", Offset = "0x347B5C0", Length = "0x51")]
	[Token(Token = "0x6000065")]
	internal String[] GetResponseHeaderKeys() { }

	[Address(RVA = "0x347C180", Offset = "0x347B580", Length = "0x33")]
	[Token(Token = "0x6000084")]
	private static String[] GetResponseHeaderKeys_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347C490", Offset = "0x347B890", Length = "0x1A1")]
	[Token(Token = "0x6000066")]
	public Dictionary<String, String> GetResponseHeaders() { }

	[Address(RVA = "0x347C690", Offset = "0x347BA90", Length = "0xCE")]
	[Token(Token = "0x600005A")]
	private string GetUrl() { }

	[Address(RVA = "0x347C640", Offset = "0x347BA40", Length = "0x42")]
	[Token(Token = "0x600007C")]
	private static void GetUrl_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347C7A0", Offset = "0x347BBA0", Length = "0xAA")]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000038")]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	[Address(RVA = "0x347C760", Offset = "0x347BB60", Length = "0x40")]
	[Token(Token = "0x6000072")]
	private static void GetWebErrorString_Injected(UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x347C850", Offset = "0x347BC50", Length = "0x87")]
	[Token(Token = "0x6000042")]
	internal void InternalDestroy() { }

	[Address(RVA = "0x347C8E0", Offset = "0x347BCE0", Length = "0x10F")]
	[Token(Token = "0x6000050")]
	internal void InternalSetCustomMethod(string customMethodName) { }

	[Address(RVA = "0x347C9F0", Offset = "0x347BDF0", Length = "0xB")]
	[Token(Token = "0x6000043")]
	private void InternalSetDefaults() { }

	[Address(RVA = "0x347CA00", Offset = "0x347BE00", Length = "0x13D")]
	[Token(Token = "0x600004E")]
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x347CB40", Offset = "0x347BF40", Length = "0x10F")]
	[Token(Token = "0x600005C")]
	private void InternalSetUrl(string url) { }

	[Address(RVA = "0x347CC90", Offset = "0x347C090", Length = "0x51")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000041")]
	private void Release() { }

	[Address(RVA = "0x347CC50", Offset = "0x347C050", Length = "0x33")]
	[Token(Token = "0x6000074")]
	private static void Release_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x347CCF0", Offset = "0x347C0F0", Length = "0xC1")]
	[Token(Token = "0x600004B")]
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[Address(RVA = "0x347DE80", Offset = "0x347D280", Length = "0x168")]
	[Token(Token = "0x600006F")]
	public void set_certificateHandler(CertificateHandler value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003B")]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003D")]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003F")]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[Address(RVA = "0x347DFF0", Offset = "0x347D3F0", Length = "0x168")]
	[Token(Token = "0x600006C")]
	public void set_downloadHandler(DownloadHandler value) { }

	[Address(RVA = "0x347E160", Offset = "0x347D560", Length = "0x253")]
	[Token(Token = "0x6000054")]
	public void set_method(string value) { }

	[Address(RVA = "0x347D260", Offset = "0x347C660", Length = "0x58")]
	[Token(Token = "0x6000063")]
	public void set_redirectLimit(int value) { }

	[Address(RVA = "0x347E3C0", Offset = "0x347D7C0", Length = "0x183")]
	[Token(Token = "0x6000071")]
	public void set_timeout(int value) { }

	[Address(RVA = "0x347E550", Offset = "0x347D950", Length = "0x168")]
	[Token(Token = "0x6000069")]
	public void set_uploadHandler(UploadHandler value) { }

	[Address(RVA = "0x347E6C0", Offset = "0x347DAC0", Length = "0xF2")]
	[Token(Token = "0x6000059")]
	public void set_uri(Uri value) { }

	[Address(RVA = "0x347E7C0", Offset = "0x347DBC0", Length = "0x84")]
	[Token(Token = "0x6000058")]
	public void set_url(string value) { }

	[Address(RVA = "0x347CE10", Offset = "0x347C210", Length = "0x71")]
	[Token(Token = "0x600006D")]
	private UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	[Address(RVA = "0x347CDC0", Offset = "0x347C1C0", Length = "0x42")]
	[Token(Token = "0x6000087")]
	private static UnityWebRequestError SetCertificateHandler_Injected(IntPtr _unity_self, IntPtr ch) { }

	[Address(RVA = "0x347CEE0", Offset = "0x347C2E0", Length = "0x1C1")]
	[Token(Token = "0x600004F")]
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	[Address(RVA = "0x347CE90", Offset = "0x347C290", Length = "0x42")]
	[Token(Token = "0x6000078")]
	private static UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	[Address(RVA = "0x347D100", Offset = "0x347C500", Length = "0x71")]
	[Token(Token = "0x600006A")]
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	[Address(RVA = "0x347D0B0", Offset = "0x347C4B0", Length = "0x42")]
	[Token(Token = "0x6000086")]
	private static UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }

	[Address(RVA = "0x347D1C0", Offset = "0x347C5C0", Length = "0x58")]
	[Token(Token = "0x600004D")]
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x347D180", Offset = "0x347C580", Length = "0x40")]
	[Token(Token = "0x6000077")]
	private static UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequestMethod methodType) { }

	[Address(RVA = "0x347D260", Offset = "0x347C660", Length = "0x58")]
	[NativeThrows]
	[Token(Token = "0x6000062")]
	private void SetRedirectLimitFromScripting(int limit) { }

	[Address(RVA = "0x347D220", Offset = "0x347C620", Length = "0x40")]
	[Token(Token = "0x6000082")]
	private static void SetRedirectLimitFromScripting_Injected(IntPtr _unity_self, int limit) { }

	[Address(RVA = "0x347D300", Offset = "0x347C700", Length = "0x58")]
	[Token(Token = "0x6000070")]
	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	[Address(RVA = "0x347D2C0", Offset = "0x347C6C0", Length = "0x40")]
	[Token(Token = "0x6000088")]
	private static UnityWebRequestError SetTimeoutMsec_Injected(IntPtr _unity_self, int timeout) { }

	[Address(RVA = "0x347D3B0", Offset = "0x347C7B0", Length = "0x71")]
	[Token(Token = "0x6000067")]
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	[Address(RVA = "0x347D360", Offset = "0x347C760", Length = "0x42")]
	[Token(Token = "0x6000085")]
	private static UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	[Address(RVA = "0x347D480", Offset = "0x347C880", Length = "0x1C1")]
	[Token(Token = "0x600005B")]
	private UnityWebRequestError SetUrl(string url) { }

	[Address(RVA = "0x347D430", Offset = "0x347C830", Length = "0x42")]
	[Token(Token = "0x600007D")]
	private static UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

}

