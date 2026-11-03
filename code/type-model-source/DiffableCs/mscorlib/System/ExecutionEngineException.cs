namespace System;

[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[Token(Token = "0x20000D3")]
public sealed class ExecutionEngineException : SystemException
{

	[Address(RVA = "0x20210A0", Offset = "0x20204A0", Length = "0x44")]
	[Token(Token = "0x60006A1")]
	public ExecutionEngineException() { }

	[Address(RVA = "0x20210F0", Offset = "0x20204F0", Length = "0x1E")]
	[Token(Token = "0x60006A2")]
	public ExecutionEngineException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60006A3")]
	internal ExecutionEngineException(SerializationInfo info, StreamingContext context) { }

}

