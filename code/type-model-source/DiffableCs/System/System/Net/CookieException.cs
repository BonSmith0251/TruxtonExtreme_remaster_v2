namespace System.Net;

[Token(Token = "0x2000280")]
public class CookieException : FormatException, ISerializable
{

	[Address(RVA = "0x260E440", Offset = "0x260D840", Length = "0x7")]
	[Token(Token = "0x60010C9")]
	public CookieException() { }

	[Address(RVA = "0x260E460", Offset = "0x260D860", Length = "0x8")]
	[Token(Token = "0x60010CA")]
	internal CookieException(string message) { }

	[Address(RVA = "0x260E450", Offset = "0x260D850", Length = "0x8")]
	[Token(Token = "0x60010CB")]
	internal CookieException(string message, Exception inner) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x60010CC")]
	protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x60010CE")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x60010CD")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

