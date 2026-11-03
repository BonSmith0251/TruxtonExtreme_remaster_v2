namespace System.Net;

[Token(Token = "0x20002A8")]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B08")]
	private Uri uri; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B09")]
	private WebHeaderCollection webHeaders; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B0A")]
	private CookieCollection cookieCollection; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B0B")]
	private string method; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B0C")]
	private Version version; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B0D")]
	private HttpStatusCode statusCode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B0E")]
	private string statusDescription; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B0F")]
	private long contentLength; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B10")]
	private string contentType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B11")]
	private CookieContainer cookie_container; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B12")]
	private bool disposed; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B13")]
	private Stream stream; //Field offset: 0x78

	[Token(Token = "0x170003D7")]
	public override CookieCollection Cookies
	{
		[Address(RVA = "0x25C7C50", Offset = "0x25C7050", Length = "0x73")]
		[Token(Token = "0x60011E7")]
		 get { } //Length: 115
	}

	[Token(Token = "0x170003D8")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60011E8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D9")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x25C7CD0", Offset = "0x25C70D0", Length = "0x1A")]
		[Token(Token = "0x60011E9")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170003DA")]
	public override HttpStatusCode StatusCode
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60011EA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003DB")]
	public override string StatusDescription
	{
		[Address(RVA = "0x25C7CF0", Offset = "0x25C70F0", Length = "0x1A")]
		[Token(Token = "0x60011EB")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60011E3")]
	public HttpWebResponse() { }

	[Address(RVA = "0x25C74B0", Offset = "0x25C68B0", Length = "0xE8")]
	[Token(Token = "0x60011E4")]
	internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	[Address(RVA = "0x25C7990", Offset = "0x25C6D90", Length = "0x2B9")]
	[Token(Token = "0x60011E5")]
	internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Address(RVA = "0x25C75A0", Offset = "0x25C69A0", Length = "0x3EE")]
	[Obsolete("Serialization is obsoleted for this type", False)]
	[Token(Token = "0x60011E6")]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25C7000", Offset = "0x25C6400", Length = "0x81")]
	[Token(Token = "0x60011F2")]
	private void CheckDisposed() { }

	[Address(RVA = "0x25C7090", Offset = "0x25C6490", Length = "0x34")]
	[Token(Token = "0x60011EF")]
	public virtual void Close() { }

	[Address(RVA = "0x25C70D0", Offset = "0x25C64D0", Length = "0xE")]
	[Token(Token = "0x60011F1")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x25C70E0", Offset = "0x25C64E0", Length = "0x185")]
	[Token(Token = "0x60011F3")]
	private void FillCookies() { }

	[Address(RVA = "0x25C7C50", Offset = "0x25C7050", Length = "0x73")]
	[Token(Token = "0x60011E7")]
	public override CookieCollection get_Cookies() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60011E8")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x25C7CD0", Offset = "0x25C70D0", Length = "0x1A")]
	[Token(Token = "0x60011E9")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60011EA")]
	public override HttpStatusCode get_StatusCode() { }

	[Address(RVA = "0x25C7CF0", Offset = "0x25C70F0", Length = "0x1A")]
	[Token(Token = "0x60011EB")]
	public override string get_StatusDescription() { }

	[Address(RVA = "0x25C7270", Offset = "0x25C6670", Length = "0x16C")]
	[Token(Token = "0x60011EE")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25C73E0", Offset = "0x25C67E0", Length = "0x98")]
	[Token(Token = "0x60011EC")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x1E18410", Offset = "0x1E17810", Length = "0x16")]
	[Token(Token = "0x60011F0")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x25C7480", Offset = "0x25C6880", Length = "0x2A")]
	[Token(Token = "0x60011ED")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

