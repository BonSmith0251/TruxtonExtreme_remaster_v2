namespace System.Net;

[Token(Token = "0x2000284")]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A56")]
	private bool m_closed; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A57")]
	private long m_contentLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A58")]
	private FileAccess m_fileAccess; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A59")]
	private WebHeaderCollection m_headers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A5A")]
	private Stream m_stream; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A5B")]
	private Uri m_uri; //Field offset: 0x48

	[Token(Token = "0x17000395")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x26C3A60", Offset = "0x26C2E60", Length = "0x1A")]
		[Token(Token = "0x60010FE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000396")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x26C3A80", Offset = "0x26C2E80", Length = "0x1A")]
		[Token(Token = "0x60010FF")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x26C3770", Offset = "0x26C2B70", Length = "0x2E8")]
	[Token(Token = "0x60010FA")]
	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Address(RVA = "0x26C34F0", Offset = "0x26C28F0", Length = "0x276")]
	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Token(Token = "0x60010FB")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C3140", Offset = "0x26C2540", Length = "0x81")]
	[Token(Token = "0x6001100")]
	private void CheckDisposed() { }

	[Address(RVA = "0x26C31D0", Offset = "0x26C25D0", Length = "0x3E")]
	[Token(Token = "0x6001101")]
	public virtual void Close() { }

	[Address(RVA = "0x26C3A60", Offset = "0x26C2E60", Length = "0x1A")]
	[Token(Token = "0x60010FE")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x26C3A80", Offset = "0x26C2E80", Length = "0x1A")]
	[Token(Token = "0x60010FF")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0x26C3210", Offset = "0x26C2610", Length = "0x177")]
	[Token(Token = "0x60010FD")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26C3390", Offset = "0x26C2790", Length = "0x3E")]
	[Token(Token = "0x6001103")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x26C33D0", Offset = "0x26C27D0", Length = "0x111")]
	[Token(Token = "0x6001102")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x25C7480", Offset = "0x25C6880", Length = "0x2A")]
	[Token(Token = "0x60010FC")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

