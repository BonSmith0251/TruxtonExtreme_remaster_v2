namespace System.Reflection;

[Token(Token = "0x2000502")]
public sealed class TargetInvocationException : ApplicationException
{

	[Address(RVA = "0x1F6DB40", Offset = "0x1F6CF40", Length = "0x53")]
	[Token(Token = "0x6002379")]
	public TargetInvocationException(Exception inner) { }

	[Address(RVA = "0x1F6DBA0", Offset = "0x1F6CFA0", Length = "0x1E")]
	[Token(Token = "0x600237A")]
	public TargetInvocationException(string message, Exception inner) { }

	[Address(RVA = "0x1F5ED10", Offset = "0x1F5E110", Length = "0x1F")]
	[Token(Token = "0x600237B")]
	internal TargetInvocationException(SerializationInfo info, StreamingContext context) { }

}

