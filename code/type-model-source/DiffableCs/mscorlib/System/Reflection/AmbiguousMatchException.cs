namespace System.Reflection;

[Token(Token = "0x20004C8")]
public sealed class AmbiguousMatchException : SystemException
{

	[Address(RVA = "0x1F318D0", Offset = "0x1F30CD0", Length = "0x44")]
	[Token(Token = "0x60021FF")]
	public AmbiguousMatchException() { }

	[Address(RVA = "0x1F318B0", Offset = "0x1F30CB0", Length = "0x1E")]
	[Token(Token = "0x6002200")]
	public AmbiguousMatchException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002201")]
	internal AmbiguousMatchException(SerializationInfo info, StreamingContext context) { }

}

