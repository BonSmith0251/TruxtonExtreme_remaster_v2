namespace System.Text;

[Token(Token = "0x200029C")]
public sealed class DecoderFallbackException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B6F")]
	private Byte[] _bytesUnknown; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B70")]
	private int _index; //Field offset: 0xA0

	[Address(RVA = "0x20AED40", Offset = "0x20AE140", Length = "0x44")]
	[Token(Token = "0x6001569")]
	public DecoderFallbackException() { }

	[Address(RVA = "0x20AECF0", Offset = "0x20AE0F0", Length = "0x4C")]
	[Token(Token = "0x600156A")]
	public DecoderFallbackException(string message, Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x1E8BAA0", Offset = "0x1E8AEA0", Length = "0x1F")]
	[Token(Token = "0x600156B")]
	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

