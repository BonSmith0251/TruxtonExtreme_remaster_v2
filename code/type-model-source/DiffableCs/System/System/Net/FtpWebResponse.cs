namespace System.Net;

[Token(Token = "0x200023A")]
public class FtpWebResponse : WebResponse, IDisposable
{
	[Token(Token = "0x200023B")]
	public sealed class EmptyStream : MemoryStream
	{

		[Address(RVA = "0x269A8A0", Offset = "0x2699CA0", Length = "0xA4")]
		[Token(Token = "0x6000F36")]
		internal EmptyStream() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008C0")]
	internal Stream _responseStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008C1")]
	private long _contentLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008C2")]
	private Uri _responseUri; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008C3")]
	private FtpStatusCode _statusCode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008C4")]
	private string _statusLine; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008C5")]
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008C6")]
	private DateTime _lastModified; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008C7")]
	private string _bannerMessage; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008C8")]
	private string _welcomeMessage; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008C9")]
	private string _exitMessage; //Field offset: 0x68

	[Token(Token = "0x17000313")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x26A73D0", Offset = "0x26A67D0", Length = "0xEE")]
		[Token(Token = "0x6000F33")]
		 get { } //Length: 238
	}

	[Token(Token = "0x17000314")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000F34")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000315")]
	public FtpStatusCode StatusCode
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000F35")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26A7270", Offset = "0x26A6670", Length = "0x152")]
	[Token(Token = "0x6000F2E")]
	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	[Address(RVA = "0x26A6F90", Offset = "0x26A6390", Length = "0xEA")]
	[Token(Token = "0x6000F32")]
	public virtual void Close() { }

	[Address(RVA = "0x26A73D0", Offset = "0x26A67D0", Length = "0xEE")]
	[Token(Token = "0x6000F33")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000F34")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000F35")]
	public FtpStatusCode get_StatusCode() { }

	[Address(RVA = "0x26A7080", Offset = "0x26A6480", Length = "0x103")]
	[Token(Token = "0x6000F30")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x26A7190", Offset = "0x26A6590", Length = "0x98")]
	[Token(Token = "0x6000F31")]
	internal void SetResponseStream(Stream stream) { }

	[Address(RVA = "0x26A7230", Offset = "0x26A6630", Length = "0x3D")]
	[Token(Token = "0x6000F2F")]
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

}

