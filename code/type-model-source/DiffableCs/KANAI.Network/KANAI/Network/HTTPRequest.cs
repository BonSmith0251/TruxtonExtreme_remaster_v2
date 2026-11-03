namespace KANAI.Network;

[Token(Token = "0x200000E")]
public sealed class HTTPRequest : IEnumerator, IEnumerator<HTTPRequest>, IDisposable
{
	[Token(Token = "0x200000F")]
	internal enum Method : byte
	{
		Get = 0,
		Head = 1,
		Post = 2,
		Put = 3,
	}

	[Token(Token = "0x2000010")]
	internal enum State : int
	{
		Initial = 0,
		RequestWait = 1,
		ResponseWait = 2,
		Finished = 3,
		Error = 4,
		Aborted = 5,
		Pingout = 6,
		Timeout = 7,
		ConnectionError = 8,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000036")]
	private State <RequestState>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000037")]
	private Uri <_Uri>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000038")]
	private Method <_MethodType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000039")]
	private Byte[] <RawData>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private HTTPResponse <Response>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003B")]
	private IAsyncResult <requestResult>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003C")]
	private IAsyncResult <responseResult>k__BackingField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003D")]
	private TimeSpan _Timeout; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400003E")]
	private DateTime _webAccessBeginTime; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400003F")]
	private Action<HTTPRequest, HTTPResponse> _Callback; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000040")]
	private HttpWebRequest httpWebRequest; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000041")]
	private Dictionary<String, List`1<String>> _Headers; //Field offset: 0x68

	[Token(Token = "0x1700000D")]
	public private Method _MethodType
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600005A")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public private Uri _Uri
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000058")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000059")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700000A")]
	public override object Current
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000E")]
	public internal Byte[] RawData
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000010")]
	public private IAsyncResult requestResult
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000060")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000061")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700000B")]
	public private State RequestState
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000056")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000057")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public private HTTPResponse Response
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000011")]
	public private IAsyncResult responseResult
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000062")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000063")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000009")]
	private override HTTPRequest System.Collections.Generic.IEnumerator<KANAI.Network.HTTPRequest>.Current
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000049")]
		private get { } //Length: 4
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000055")]
	private bool _IsTimeout() { }

	[Address(RVA = "0x1E01DB0", Offset = "0x1E011B0", Length = "0xCD")]
	[Token(Token = "0x6000041")]
	public HTTPRequest(Uri iUri, Method iType, Action<HTTPRequest, HTTPResponse> iCallback) { }

	[Address(RVA = "0x1E00720", Offset = "0x1DFFB20", Length = "0x11D")]
	[Token(Token = "0x6000054")]
	public void Abort() { }

	[Address(RVA = "0x1E00840", Offset = "0x1DFFC40", Length = "0x182")]
	[Token(Token = "0x600004F")]
	public void AddHeader(string name, string value) { }

	[Address(RVA = "0x1E009D0", Offset = "0x1DFFDD0", Length = "0x2C6")]
	[Token(Token = "0x6000050")]
	public void AddHeaders(Dictionary<String, String> values) { }

	[Address(RVA = "0x1E00CA0", Offset = "0x1E000A0", Length = "0x264")]
	[Token(Token = "0x6000044")]
	public CookieCollection CreateResponse() { }

	[Address(RVA = "0x1E00F10", Offset = "0x1E00310", Length = "0x85")]
	[Token(Token = "0x600004B")]
	public override void Dispose() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600005A")]
	public Method get__MethodType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000058")]
	public Uri get__Uri() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600004A")]
	public override object get_Current() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public Byte[] get_RawData() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000060")]
	public IAsyncResult get_requestResult() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000056")]
	public State get_RequestState() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	public HTTPResponse get_Response() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000062")]
	public IAsyncResult get_responseResult() { }

	[Address(RVA = "0x1E00FA0", Offset = "0x1E003A0", Length = "0x14")]
	[Token(Token = "0x600004D")]
	public List<String> GetResponseHeaderLists(string key) { }

	[Address(RVA = "0x1E00FC0", Offset = "0x1E003C0", Length = "0x7A7")]
	[Token(Token = "0x6000052")]
	public void HeaderToRequest(CookieContainer cookies, List<X509Certificate> clientCertificate) { }

	[Address(RVA = "0x1E01770", Offset = "0x1E00B70", Length = "0x8")]
	[Token(Token = "0x6000045")]
	public bool IsFinished() { }

	[Address(RVA = "0x1E01780", Offset = "0x1E00B80", Length = "0x94")]
	[Token(Token = "0x6000046")]
	public bool IsTimeout() { }

	[Address(RVA = "0x1E01820", Offset = "0x1E00C20", Length = "0x8")]
	[Token(Token = "0x6000047")]
	public override bool MoveNext() { }

	[Address(RVA = "0x1E01830", Offset = "0x1E00C30", Length = "0x3E")]
	[Token(Token = "0x6000048")]
	public override void Reset() { }

	[Address(RVA = "0x1E01870", Offset = "0x1E00C70", Length = "0x68")]
	[Token(Token = "0x600004C")]
	public bool ResponseHasHeader(string key) { }

	[Address(RVA = "0x1E018E0", Offset = "0x1E00CE0", Length = "0xFB")]
	[Token(Token = "0x6000053")]
	public void Send() { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	private void set__MethodType(Method value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000059")]
	private void set__Uri(Uri value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	internal void set_RawData(Byte[] value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000061")]
	private void set_requestResult(IAsyncResult value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000057")]
	private void set_RequestState(State value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	private void set_Response(HTTPResponse value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000063")]
	private void set_responseResult(IAsyncResult value) { }

	[Address(RVA = "0x1E019E0", Offset = "0x1E00DE0", Length = "0x55")]
	[Token(Token = "0x6000042")]
	public void SetError(State state) { }

	[Address(RVA = "0x1E01A40", Offset = "0x1E00E40", Length = "0x1D4")]
	[Token(Token = "0x6000051")]
	public void SetHeader(string name, string value) { }

	[Address(RVA = "0x1E01C20", Offset = "0x1E01020", Length = "0x12F")]
	[Token(Token = "0x6000043")]
	public void SetRequestToResponse() { }

	[Address(RVA = "0x1E01D50", Offset = "0x1E01150", Length = "0x5E")]
	[Token(Token = "0x600004E")]
	public void SetTimeout(int timeout) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000049")]
	private override HTTPRequest System.Collections.Generic.IEnumerator<KANAI.Network.HTTPRequest>.get_Current() { }

}

