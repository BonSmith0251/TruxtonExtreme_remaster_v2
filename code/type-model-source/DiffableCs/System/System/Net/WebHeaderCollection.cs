namespace System.Net;

[ComVisible(True)]
[DefaultMember("Item")]
[Token(Token = "0x2000259")]
public class WebHeaderCollection : NameValueCollection, ISerializable
{
	[Token(Token = "0x200025A")]
	private enum RfcChar : byte
	{
		High = 0,
		Reg = 1,
		Ctl = 2,
		CR = 3,
		LF = 4,
		WS = 5,
		Colon = 6,
		Delim = 7,
	}

	[Token(Token = "0x4000976")]
	private const int ApproxAveHeaderLineSize = 30; //Field offset: 0x0
	[Token(Token = "0x400098E")]
	private const int c_XPoweredBy = 17; //Field offset: 0x0
	[Token(Token = "0x400098D")]
	private const int c_XAspNetVersion = 16; //Field offset: 0x0
	[Token(Token = "0x400098C")]
	private const int c_WwwAuthenticate = 15; //Field offset: 0x0
	[Token(Token = "0x400098B")]
	private const int c_Via = 14; //Field offset: 0x0
	[Token(Token = "0x400098A")]
	private const int c_Server = 13; //Field offset: 0x0
	[Token(Token = "0x4000989")]
	private const int c_SetCookie = 12; //Field offset: 0x0
	[Token(Token = "0x4000988")]
	private const int c_SetCookie2 = 11; //Field offset: 0x0
	[Token(Token = "0x4000987")]
	private const int c_P3P = 10; //Field offset: 0x0
	[Token(Token = "0x4000986")]
	private const int c_ProxyAuthenticate = 9; //Field offset: 0x0
	[Token(Token = "0x4000985")]
	private const int c_Location = 8; //Field offset: 0x0
	[Token(Token = "0x4000983")]
	private const int c_ETag = 6; //Field offset: 0x0
	[Token(Token = "0x4000984")]
	private const int c_LastModified = 7; //Field offset: 0x0
	[Token(Token = "0x4000981")]
	private const int c_Date = 4; //Field offset: 0x0
	[Token(Token = "0x4000980")]
	private const int c_ContentType = 3; //Field offset: 0x0
	[Token(Token = "0x400097F")]
	private const int c_CacheControl = 2; //Field offset: 0x0
	[Token(Token = "0x400097E")]
	private const int c_ContentLength = 1; //Field offset: 0x0
	[Token(Token = "0x400097D")]
	private const int c_AcceptRanges = 0; //Field offset: 0x0
	[Token(Token = "0x4000978")]
	private static readonly HeaderInfoTable HInfo; //Field offset: 0x0
	[Token(Token = "0x4000977")]
	private const int ApproxHighAvgNumHeaders = 16; //Field offset: 0x0
	[Token(Token = "0x4000982")]
	private const int c_Expires = 5; //Field offset: 0x0
	[Token(Token = "0x400097B")]
	private static readonly String[] s_CommonHeaderNames; //Field offset: 0x8
	[Token(Token = "0x400097C")]
	private static readonly SByte[] s_CommonHeaderHints; //Field offset: 0x10
	[Token(Token = "0x4000991")]
	private static readonly Char[] HttpTrimCharacters; //Field offset: 0x18
	[Token(Token = "0x4000992")]
	private static RfcChar[] RfcCharMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000979")]
	private String[] m_CommonHeaders; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400097A")]
	private int m_NumCommonHeaders; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400098F")]
	private NameValueCollection m_InnerCollection; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000990")]
	private WebHeaderCollectionType m_Type; //Field offset: 0x80

	[Token(Token = "0x1700033C")]
	private bool AllowHttpRequestHeader
	{
		[Address(RVA = "0x26B0DD0", Offset = "0x26B01D0", Length = "0x36")]
		[Token(Token = "0x6000FB6")]
		private get { } //Length: 54
	}

	[Token(Token = "0x1700033D")]
	public virtual int Count
	{
		[Address(RVA = "0x26B0E10", Offset = "0x26B0210", Length = "0x3B")]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 59
	}

	[Token(Token = "0x1700033B")]
	private NameValueCollection InnerCollection
	{
		[Address(RVA = "0x26B0E50", Offset = "0x26B0250", Length = "0xB1")]
		[Token(Token = "0x6000FB4")]
		private get { } //Length: 177
	}

	[Token(Token = "0x1700033E")]
	public virtual KeysCollection Keys
	{
		[Address(RVA = "0x26B0F10", Offset = "0x26B0310", Length = "0x40")]
		[Token(Token = "0x6000FCF")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x26B0540", Offset = "0x26AF940", Length = "0x55D")]
	[Token(Token = "0x6000FD2")]
	private static WebHeaderCollection() { }

	[Address(RVA = "0x26B0C80", Offset = "0x26B0080", Length = "0x5E")]
	[Token(Token = "0x6000FC6")]
	public WebHeaderCollection() { }

	[Address(RVA = "0x26B0CE0", Offset = "0x26B00E0", Length = "0xE5")]
	[Token(Token = "0x6000FC7")]
	internal WebHeaderCollection(WebHeaderCollectionType type) { }

	[Address(RVA = "0x26B0AA0", Offset = "0x26AFEA0", Length = "0x1D8")]
	[Token(Token = "0x6000FC8")]
	protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26AE5B0", Offset = "0x26AD9B0", Length = "0x2DA")]
	[Token(Token = "0x6000FBF")]
	public void Add(string header) { }

	[Address(RVA = "0x26AE3F0", Offset = "0x26AD7F0", Length = "0x1B5")]
	[Token(Token = "0x6000FBE")]
	public virtual void Add(string name, string value) { }

	[Address(RVA = "0x26AE380", Offset = "0x26AD780", Length = "0x69")]
	[Token(Token = "0x6000FB8")]
	internal void AddInternal(string name, string value) { }

	[Address(RVA = "0x26AE890", Offset = "0x26ADC90", Length = "0x9A")]
	[Token(Token = "0x6000FB5")]
	internal static bool AllowMultiValues(string name) { }

	[Address(RVA = "0x26AE930", Offset = "0x26ADD30", Length = "0x69")]
	[Token(Token = "0x6000FB9")]
	internal void ChangeInternal(string name, string value) { }

	[Address(RVA = "0x26AE9A0", Offset = "0x26ADDA0", Length = "0x57D")]
	[Token(Token = "0x6000FBB")]
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	[Address(RVA = "0x26AEF20", Offset = "0x26AE320", Length = "0x66")]
	[Token(Token = "0x6000FBC")]
	internal static bool ContainsNonAsciiChars(string token) { }

	[Address(RVA = "0x26AF6C0", Offset = "0x26AEAC0", Length = "0x363")]
	[Token(Token = "0x6000FCC")]
	public virtual string Get(string name) { }

	[Address(RVA = "0x26AFA30", Offset = "0x26AEE30", Length = "0x4D")]
	[Token(Token = "0x6000FD0")]
	public virtual string Get(int index) { }

	[Address(RVA = "0x26B0DD0", Offset = "0x26B01D0", Length = "0x36")]
	[Token(Token = "0x6000FB6")]
	private bool get_AllowHttpRequestHeader() { }

	[Address(RVA = "0x26B0E10", Offset = "0x26B0210", Length = "0x3B")]
	[Token(Token = "0x6000FCE")]
	public virtual int get_Count() { }

	[Address(RVA = "0x26B0E50", Offset = "0x26B0250", Length = "0xB1")]
	[Token(Token = "0x6000FB4")]
	private NameValueCollection get_InnerCollection() { }

	[Address(RVA = "0x26B0F10", Offset = "0x26B0310", Length = "0x40")]
	[Token(Token = "0x6000FCF")]
	public virtual KeysCollection get_Keys() { }

	[Address(RVA = "0x26AEF90", Offset = "0x26AE390", Length = "0x28A")]
	[Token(Token = "0x6000FC5")]
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	[Address(RVA = "0x26AF220", Offset = "0x26AE620", Length = "0x6B")]
	[Token(Token = "0x6000FCD")]
	public virtual IEnumerator GetEnumerator() { }

	[Address(RVA = "0x26AF290", Offset = "0x26AE690", Length = "0x4D")]
	[Token(Token = "0x6000FD1")]
	public virtual string GetKey(int index) { }

	[Address(RVA = "0x26AF2E0", Offset = "0x26AE6E0", Length = "0x189")]
	[Token(Token = "0x6000FCA")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26AF470", Offset = "0x26AE870", Length = "0x240")]
	[Token(Token = "0x6000FC3")]
	public virtual String[] GetValues(string header) { }

	[Address(RVA = "0x26AFA80", Offset = "0x26AEE80", Length = "0x136")]
	[Token(Token = "0x6000FB3")]
	private void NormalizeCommonHeaders() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FC9")]
	public virtual void OnDeserialization(object sender) { }

	[Address(RVA = "0x26AFC20", Offset = "0x26AF020", Length = "0xF3")]
	[Token(Token = "0x6000FB7")]
	public void Remove(HttpRequestHeader header) { }

	[Address(RVA = "0x26AFD20", Offset = "0x26AF120", Length = "0x11E")]
	[Token(Token = "0x6000FC2")]
	public virtual void Remove(string name) { }

	[Address(RVA = "0x26AFBC0", Offset = "0x26AEFC0", Length = "0x57")]
	[Token(Token = "0x6000FBA")]
	internal void RemoveInternal(string name) { }

	[Address(RVA = "0x26B0070", Offset = "0x26AF470", Length = "0x23A")]
	[Token(Token = "0x6000FC0")]
	public virtual void Set(string name, string value) { }

	[Address(RVA = "0x26AFE40", Offset = "0x26AF240", Length = "0x22C")]
	[Token(Token = "0x6000FC1")]
	internal void SetInternal(string name, string value) { }

	[Address(RVA = "0x26ADE90", Offset = "0x26AD290", Length = "0x2A")]
	[Token(Token = "0x6000FCB")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26B02B0", Offset = "0x26AF6B0", Length = "0x23C")]
	[Token(Token = "0x6000FBD")]
	internal void ThrowOnRestrictedHeader(string headerName) { }

	[Address(RVA = "0x26B04F0", Offset = "0x26AF8F0", Length = "0x4F")]
	[Token(Token = "0x6000FC4")]
	public virtual string ToString() { }

}

