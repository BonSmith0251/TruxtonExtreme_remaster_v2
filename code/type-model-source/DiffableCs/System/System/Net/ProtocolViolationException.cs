namespace System.Net;

[Token(Token = "0x2000252")]
public class ProtocolViolationException : InvalidOperationException, ISerializable
{

	[Address(RVA = "0x26ABD00", Offset = "0x26AB100", Length = "0x7")]
	[Token(Token = "0x6000F93")]
	public ProtocolViolationException() { }

	[Address(RVA = "0x26ABD10", Offset = "0x26AB110", Length = "0x8")]
	[Token(Token = "0x6000F94")]
	public ProtocolViolationException(string message) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x6000F95")]
	protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x6000F97")]
	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x260E420", Offset = "0x260D820", Length = "0x1F")]
	[Token(Token = "0x6000F96")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

