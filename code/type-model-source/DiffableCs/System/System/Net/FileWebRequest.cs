namespace System.Net;

[Token(Token = "0x2000281")]
public class FileWebRequest : WebRequest, ISerializable
{
	[Token(Token = "0x4000A40")]
	private static WaitCallback s_GetRequestStreamCallback; //Field offset: 0x0
	[Token(Token = "0x4000A41")]
	private static WaitCallback s_GetResponseCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A42")]
	private string m_connectionGroupName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A43")]
	private long m_contentLength; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A44")]
	private ICredentials m_credentials; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A45")]
	private FileAccess m_fileAccess; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A46")]
	private WebHeaderCollection m_headers; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A47")]
	private string m_method; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A48")]
	private IWebProxy m_proxy; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A49")]
	private ManualResetEvent m_readerEvent; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A4A")]
	private bool m_readPending; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A4B")]
	private WebResponse m_response; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A4C")]
	private Stream m_stream; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A4D")]
	private bool m_syncHint; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000A4E")]
	private int m_timeout; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A4F")]
	private Uri m_uri; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A50")]
	private bool m_writePending; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000A51")]
	private bool m_writing; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A52")]
	private LazyAsyncResult m_WriteAResult; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A53")]
	private LazyAsyncResult m_ReadAResult; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A54")]
	private int m_Aborted; //Field offset: 0xB8

	[Token(Token = "0x1700038B")]
	internal bool Aborted
	{
		[Address(RVA = "0x26C2F10", Offset = "0x26C2310", Length = "0xB")]
		[Token(Token = "0x60010D3")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x1700038C")]
	public virtual long ContentLength
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60010D4")]
		 get { } //Length: 5
		[Address(RVA = "0x26C2F50", Offset = "0x26C2350", Length = "0x8A")]
		[Token(Token = "0x60010D5")]
		 set { } //Length: 138
	}

	[Token(Token = "0x1700038D")]
	public virtual string ContentType
	{
		[Address(RVA = "0x26C2FE0", Offset = "0x26C23E0", Length = "0x56")]
		[Token(Token = "0x60010D6")]
		 set { } //Length: 86
	}

	[Token(Token = "0x1700038E")]
	public virtual ICredentials Credentials
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60010D7")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60010D8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700038F")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60010D9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000390")]
	public virtual string Method
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60010DA")]
		 get { } //Length: 5
		[Address(RVA = "0x26C3040", Offset = "0x26C2440", Length = "0xCD")]
		[Token(Token = "0x60010DB")]
		 set { } //Length: 205
	}

	[Token(Token = "0x17000391")]
	public virtual IWebProxy Proxy
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60010DC")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60010DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000393")]
	public virtual Uri RequestUri
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60010DF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000392")]
	public virtual int Timeout
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x60010DE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000394")]
	public virtual bool UseDefaultCredentials
	{
		[Address(RVA = "0x26C2F20", Offset = "0x26C2320", Length = "0x27")]
		[Token(Token = "0x60010E9")]
		 get { } //Length: 39
		[Address(RVA = "0x26C3110", Offset = "0x26C2510", Length = "0x27")]
		[Token(Token = "0x60010EA")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x26C2860", Offset = "0x26C1C60", Length = "0xE4")]
	[Token(Token = "0x60010EC")]
	private static FileWebRequest() { }

	[Address(RVA = "0x26C2950", Offset = "0x26C1D50", Length = "0x180")]
	[Token(Token = "0x60010CF")]
	internal FileWebRequest(Uri uri) { }

	[Address(RVA = "0x26C2AE0", Offset = "0x26C1EE0", Length = "0x424")]
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x60010D0")]
	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C10F0", Offset = "0x26C04F0", Length = "0x26E")]
	[Token(Token = "0x60010EB")]
	public virtual void Abort() { }

	[Address(RVA = "0x26C1360", Offset = "0x26C0760", Length = "0x34B")]
	[Token(Token = "0x60010E0")]
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C16B0", Offset = "0x26C0AB0", Length = "0x237")]
	[Token(Token = "0x60010E1")]
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C18F0", Offset = "0x26C0CF0", Length = "0x5F")]
	[Token(Token = "0x60010E2")]
	private bool CanGetRequestStream() { }

	[Address(RVA = "0x26C1950", Offset = "0x26C0D50", Length = "0x21C")]
	[Token(Token = "0x60010E3")]
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26C1B70", Offset = "0x26C0F70", Length = "0x219")]
	[Token(Token = "0x60010E4")]
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26C2F10", Offset = "0x26C2310", Length = "0xB")]
	[Token(Token = "0x60010D3")]
	internal bool get_Aborted() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60010D4")]
	public virtual long get_ContentLength() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60010D7")]
	public virtual ICredentials get_Credentials() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60010D9")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60010DA")]
	public virtual string get_Method() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60010DC")]
	public virtual IWebProxy get_Proxy() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60010DF")]
	public virtual Uri get_RequestUri() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x60010DE")]
	public virtual int get_Timeout() { }

	[Address(RVA = "0x26C2F20", Offset = "0x26C2320", Length = "0x27")]
	[Token(Token = "0x60010E9")]
	public virtual bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x26C1D90", Offset = "0x26C1190", Length = "0x250")]
	[Token(Token = "0x60010D2")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C1FF0", Offset = "0x26C13F0", Length = "0x22C")]
	[Token(Token = "0x60010E6")]
	private static void GetRequestStreamCallback(object state) { }

	[Address(RVA = "0x26C2540", Offset = "0x26C1940", Length = "0x279")]
	[Token(Token = "0x60010E5")]
	public virtual WebResponse GetResponse() { }

	[Address(RVA = "0x26C2220", Offset = "0x26C1620", Length = "0x31C")]
	[Token(Token = "0x60010E7")]
	private static void GetResponseCallback(object state) { }

	[Address(RVA = "0x26C2F50", Offset = "0x26C2350", Length = "0x8A")]
	[Token(Token = "0x60010D5")]
	public virtual void set_ContentLength(long value) { }

	[Address(RVA = "0x26C2FE0", Offset = "0x26C23E0", Length = "0x56")]
	[Token(Token = "0x60010D6")]
	public virtual void set_ContentType(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60010D8")]
	public virtual void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x26C3040", Offset = "0x26C2440", Length = "0xCD")]
	[Token(Token = "0x60010DB")]
	public virtual void set_Method(string value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60010DD")]
	public virtual void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x26C3110", Offset = "0x26C2510", Length = "0x27")]
	[Token(Token = "0x60010EA")]
	public virtual void set_UseDefaultCredentials(bool value) { }

	[Address(RVA = "0x26B1CF0", Offset = "0x26B10F0", Length = "0x2A")]
	[Token(Token = "0x60010D1")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C27C0", Offset = "0x26C1BC0", Length = "0x9C")]
	[Token(Token = "0x60010E8")]
	internal void UnblockReader() { }

}

