namespace System.Net.Sockets;

[Token(Token = "0x2000300")]
public class SocketException : Win32Exception
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000D2B")]
	private EndPoint m_EndPoint; //Field offset: 0x98

	[Token(Token = "0x1700045B")]
	public virtual string Message
	{
		[Address(RVA = "0x25E3260", Offset = "0x25E2660", Length = "0x8E")]
		[Token(Token = "0x6001470")]
		 get { } //Length: 142
	}

	[Token(Token = "0x1700045C")]
	public SocketError SocketErrorCode
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x6001471")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x25E3240", Offset = "0x25E2640", Length = "0x20")]
	[Token(Token = "0x600146B")]
	public SocketException() { }

	[Address(RVA = "0x25E3200", Offset = "0x25E2600", Length = "0x8")]
	[Token(Token = "0x600146C")]
	internal SocketException(int error, string message) { }

	[Address(RVA = "0x25E3210", Offset = "0x25E2610", Length = "0x8")]
	[Token(Token = "0x600146D")]
	public SocketException(int errorCode) { }

	[Address(RVA = "0x25E3210", Offset = "0x25E2610", Length = "0x8")]
	[Token(Token = "0x600146E")]
	internal SocketException(SocketError socketError) { }

	[Address(RVA = "0x25E3220", Offset = "0x25E2620", Length = "0x1F")]
	[Token(Token = "0x600146F")]
	protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x25E3260", Offset = "0x25E2660", Length = "0x8E")]
	[Token(Token = "0x6001470")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x6001471")]
	public SocketError get_SocketErrorCode() { }

	[Address(RVA = "0x25E31F0", Offset = "0x25E25F0", Length = "0x5")]
	[Token(Token = "0x600146A")]
	private static int WSAGetLastError_icall() { }

}

