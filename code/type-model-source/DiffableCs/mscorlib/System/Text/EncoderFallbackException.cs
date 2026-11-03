namespace System.Text;

[Token(Token = "0x20002A7")]
public sealed class EncoderFallbackException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B86")]
	private char _charUnknown; //Field offset: 0x98
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4000B87")]
	private char _charUnknownHigh; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000B88")]
	private char _charUnknownLow; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B89")]
	private int _index; //Field offset: 0xA0

	[Address(RVA = "0x1E8B830", Offset = "0x1E8AC30", Length = "0x44")]
	[Token(Token = "0x60015BB")]
	public EncoderFallbackException() { }

	[Address(RVA = "0x1E8BA60", Offset = "0x1E8AE60", Length = "0x3E")]
	[Token(Token = "0x60015BC")]
	internal EncoderFallbackException(string message, char charUnknown, int index) { }

	[Address(RVA = "0x1E8B880", Offset = "0x1E8AC80", Length = "0x1DB")]
	[Token(Token = "0x60015BD")]
	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x1E8BAA0", Offset = "0x1E8AEA0", Length = "0x1F")]
	[Token(Token = "0x60015BE")]
	private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

