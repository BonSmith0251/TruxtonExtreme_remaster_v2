namespace KANAI.Network;

[Token(Token = "0x2000011")]
public class HTTPResponse : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000051")]
	private int <StatusCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000052")]
	private bool <IsStreamed>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000053")]
	private Dictionary<String, List`1<String>> <Headers>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000054")]
	private Byte[] _Buffers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000055")]
	protected string _dataAsText; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000056")]
	private HttpWebResponse _WebResponse; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000057")]
	private HTTPRequest _baseRequest; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000058")]
	protected Stream _Stream; //Field offset: 0x40

	[Token(Token = "0x17000015")]
	public string DataAsText
	{
		[Address(RVA = "0x1E026E0", Offset = "0x1E01AE0", Length = "0x91")]
		[Token(Token = "0x600006A")]
		 get { } //Length: 145
	}

	[Token(Token = "0x17000014")]
	public Dictionary<String, List`1<String>> Headers
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000068")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000069")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000013")]
	public bool IsStreamed
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000066")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000067")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	public int StatusCode
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000064")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000065")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1E02650", Offset = "0x1E01A50", Length = "0x82")]
	[Token(Token = "0x600006C")]
	public HTTPResponse(HTTPRequest request, Stream stream = null, bool isStream = false) { }

	[Address(RVA = "0x1E01E80", Offset = "0x1E01280", Length = "0x1EE")]
	[Token(Token = "0x600006F")]
	public void AddHeader(string key, string value) { }

	[Address(RVA = "0x1E02070", Offset = "0x1E01470", Length = "0x20")]
	[Token(Token = "0x600006E")]
	public void CloseWebResponse() { }

	[Address(RVA = "0x1E02090", Offset = "0x1E01490", Length = "0x5C")]
	[Token(Token = "0x6000072")]
	public override void Dispose() { }

	[Address(RVA = "0x1E026E0", Offset = "0x1E01AE0", Length = "0x91")]
	[Token(Token = "0x600006A")]
	public string get_DataAsText() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	public Dictionary<String, List`1<String>> get_Headers() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000066")]
	public bool get_IsStreamed() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000064")]
	public int get_StatusCode() { }

	[Address(RVA = "0x1E020F0", Offset = "0x1E014F0", Length = "0x20")]
	[Token(Token = "0x600006B")]
	public CookieCollection GetCookies() { }

	[Address(RVA = "0x1E02110", Offset = "0x1E01510", Length = "0x9A")]
	[Token(Token = "0x6000071")]
	public List<String> GetHeaderList(string key) { }

	[Address(RVA = "0x1E021B0", Offset = "0x1E015B0", Length = "0x5D")]
	[Token(Token = "0x6000070")]
	public bool HasHeader(string key) { }

	[Address(RVA = "0x1E02210", Offset = "0x1E01610", Length = "0x438")]
	[Token(Token = "0x600006D")]
	public override bool Receive(HttpWebResponse w) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000069")]
	protected void set_Headers(Dictionary<String, List`1<String>> value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000067")]
	protected void set_IsStreamed(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000065")]
	protected void set_StatusCode(int value) { }

}

