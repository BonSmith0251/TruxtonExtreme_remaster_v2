namespace System.Net;

[Token(Token = "0x2000254")]
public class WebException : InvalidOperationException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400094B")]
	private WebExceptionStatus m_Status; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400094C")]
	private WebResponse m_Response; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400094D")]
	private WebExceptionInternalStatus m_InternalStatus; //Field offset: 0xA0

	[Token(Token = "0x1700033A")]
	public WebResponse Response
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000FB0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000339")]
	public WebExceptionStatus Status
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x6000FAF")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x26ADEC0", Offset = "0x26AD2C0", Length = "0x11")]
	[Token(Token = "0x6000FA3")]
	public WebException() { }

	[Address(RVA = "0x26AE360", Offset = "0x26AD760", Length = "0x15")]
	[Token(Token = "0x6000FA4")]
	public WebException(string message) { }

	[Address(RVA = "0x26AE0B0", Offset = "0x26AD4B0", Length = "0x12")]
	[Token(Token = "0x6000FA5")]
	public WebException(string message, Exception innerException) { }

	[Address(RVA = "0x26ADEE0", Offset = "0x26AD2E0", Length = "0x20")]
	[Token(Token = "0x6000FA6")]
	public WebException(string message, WebExceptionStatus status) { }

	[Address(RVA = "0x26ADF30", Offset = "0x26AD330", Length = "0xBD")]
	[Token(Token = "0x6000FA7")]
	internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	[Address(RVA = "0x26AE0D0", Offset = "0x26AD4D0", Length = "0xB3")]
	[Token(Token = "0x6000FA8")]
	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	[Address(RVA = "0x26AE190", Offset = "0x26AD590", Length = "0xDA")]
	[Token(Token = "0x6000FA9")]
	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	[Address(RVA = "0x26ADFF0", Offset = "0x26AD3F0", Length = "0xBE")]
	[Token(Token = "0x6000FAA")]
	internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	[Address(RVA = "0x26AE270", Offset = "0x26AD670", Length = "0xE5")]
	[Token(Token = "0x6000FAB")]
	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	[Address(RVA = "0x26ADF00", Offset = "0x26AD300", Length = "0x29")]
	[Token(Token = "0x6000FAC")]
	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000FB0")]
	public WebResponse get_Response() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x6000FAF")]
	public WebExceptionStatus get_Status() { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x6000FAE")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26ADE90", Offset = "0x26AD290", Length = "0x2A")]
	[Token(Token = "0x6000FAD")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

